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
      hash = ((hash << 5) + hash) + 18;
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
      hash = ((hash << 5) + hash) + 19;
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
      hash = ((hash << 5) + hash) + 20;
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
      hash = ((hash << 5) + hash) + 21;
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
      hash = ((hash << 5) + hash) + 22;
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
        _30_typeParamI = (_30_typeParamI) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(::std::default::Default)]\npub struct r#"), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _19_fields), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _32_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _33_traitBodies;
      Dafny.ISequence<Dafny.Rune> _out16;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out17;
      DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(path)), Dafny.Set<DAST._IType>.FromElements(), out _out16, out _out17);
      _32_implBody = _out16;
      _33_traitBodies = _out17;
      _32_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn new() -> Self {\n::std::default::Default::default()\n}\n"), _32_implBody);
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
      Dafny.ISequence<Dafny.Rune> _60_printImpl;
      _60_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n"));
      _60_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_60_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \"r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), (((new BigInteger(((c).dtor_fields).Count)).Sign == 1) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"));
      BigInteger _61_i;
      _61_i = BigInteger.Zero;
      while ((_61_i) < (new BigInteger(((c).dtor_fields).Count))) {
        DAST._IField _62_field;
        _62_field = ((c).dtor_fields).Select(_61_i);
        if ((_61_i).Sign == 1) {
          _60_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_60_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \", \")?;"));
        }
        _60_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_60_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(::std::ops::Deref::deref(&(self.r#")), ((_62_field).dtor_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow())), __fmt_print_formatter, false)?;"));
        _61_i = (_61_i) + (BigInteger.One);
      }
      _60_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_60_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \")\")?;\nOk(())\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _63_ptrPartialEqImpl;
      _63_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::cmp::PartialEq for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _63_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_63_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn eq(&self, other: &Self) -> bool {\n"));
      _63_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_63_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ptr::eq(self, other)"));
      _63_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_63_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _60_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _63_ptrPartialEqImpl);
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
          DCOMP.COMP.GenExpr(_77_e, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out28, out _out29, out _out30, out _out31);
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
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _130___mcc_h16 = _source6.dtor_path;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
            }
          } else if (_source6.is_Trait) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _131___mcc_h18 = _source6.dtor_path;
            {
              if (inBinding) {
                s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_");
              } else {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
              }
            }
          } else {
            DAST._IType _132___mcc_h20 = _source6.dtor_Newtype_a0;
            DAST._IResolvedType _133_Primitive = _126_resolved;
          }
        }
      } else if (_source5.is_Tuple) {
        Dafny.ISequence<DAST._IType> _134___mcc_h3 = _source5.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IType> _135_types = _134___mcc_h3;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          BigInteger _136_i;
          _136_i = BigInteger.Zero;
          while ((_136_i) < (new BigInteger((_135_types).Count))) {
            if ((_136_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _137_generated;
            Dafny.ISequence<Dafny.Rune> _out43;
            _out43 = DCOMP.COMP.GenType((_135_types).Select(_136_i), inBinding, inFn);
            _137_generated = _out43;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _137_generated), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            _136_i = (_136_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
        }
      } else if (_source5.is_Array) {
        DAST._IType _138___mcc_h4 = _source5.dtor_element;
        DAST._IType _139_element = _138___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _140_elemStr;
          Dafny.ISequence<Dafny.Rune> _out44;
          _out44 = DCOMP.COMP.GenType(_139_element, inBinding, inFn);
          _140_elemStr = _out44;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _140_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Seq) {
        DAST._IType _141___mcc_h5 = _source5.dtor_element;
        DAST._IType _142_element = _141___mcc_h5;
        {
          Dafny.ISequence<Dafny.Rune> _143_elemStr;
          Dafny.ISequence<Dafny.Rune> _out45;
          _out45 = DCOMP.COMP.GenType(_142_element, inBinding, inFn);
          _143_elemStr = _out45;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _143_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Set) {
        DAST._IType _144___mcc_h6 = _source5.dtor_element;
        DAST._IType _145_element = _144___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _146_elemStr;
          Dafny.ISequence<Dafny.Rune> _out46;
          _out46 = DCOMP.COMP.GenType(_145_element, inBinding, inFn);
          _146_elemStr = _out46;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashSet<"), _146_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Multiset) {
        DAST._IType _147___mcc_h7 = _source5.dtor_element;
        DAST._IType _148_element = _147___mcc_h7;
        {
          Dafny.ISequence<Dafny.Rune> _149_elemStr;
          Dafny.ISequence<Dafny.Rune> _out47;
          _out47 = DCOMP.COMP.GenType(_148_element, inBinding, inFn);
          _149_elemStr = _out47;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _149_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", u64>"));
        }
      } else if (_source5.is_Map) {
        DAST._IType _150___mcc_h8 = _source5.dtor_key;
        DAST._IType _151___mcc_h9 = _source5.dtor_value;
        DAST._IType _152_value = _151___mcc_h9;
        DAST._IType _153_key = _150___mcc_h8;
        {
          Dafny.ISequence<Dafny.Rune> _154_keyStr;
          Dafny.ISequence<Dafny.Rune> _out48;
          _out48 = DCOMP.COMP.GenType(_153_key, inBinding, inFn);
          _154_keyStr = _out48;
          Dafny.ISequence<Dafny.Rune> _155_valueStr;
          Dafny.ISequence<Dafny.Rune> _out49;
          _out49 = DCOMP.COMP.GenType(_152_value, inBinding, inFn);
          _155_valueStr = _out49;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _154_keyStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _155_valueStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Arrow) {
        Dafny.ISequence<DAST._IType> _156___mcc_h10 = _source5.dtor_args;
        DAST._IType _157___mcc_h11 = _source5.dtor_result;
        DAST._IType _158_result = _157___mcc_h11;
        Dafny.ISequence<DAST._IType> _159_args = _156___mcc_h10;
        {
          if (inBinding) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<_>");
          } else {
            if (inFn) {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<::std::boxed::Box<dyn ::std::ops::Fn(");
            } else {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<impl ::std::ops::Fn(");
            }
            BigInteger _160_i;
            _160_i = BigInteger.Zero;
            while ((_160_i) < (new BigInteger((_159_args).Count))) {
              if ((_160_i).Sign == 1) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _161_generated;
              Dafny.ISequence<Dafny.Rune> _out50;
              _out50 = DCOMP.COMP.GenType((_159_args).Select(_160_i), inBinding, true);
              _161_generated = _out50;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _161_generated);
              _160_i = (_160_i) + (BigInteger.One);
            }
            Dafny.ISequence<Dafny.Rune> _162_resultType;
            Dafny.ISequence<Dafny.Rune> _out51;
            _out51 = DCOMP.COMP.GenType(_158_result, inBinding, inFn);
            _162_resultType = _out51;
            if (inFn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _162_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + 'static>>"));
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _162_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + Clone + 'static>"));
            }
          }
        }
      } else if (_source5.is_Primitive) {
        DAST._IPrimitive _163___mcc_h12 = _source5.dtor_Primitive_a0;
        DAST._IPrimitive _164_p = _163___mcc_h12;
        {
          DAST._IPrimitive _source7 = _164_p;
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
        Dafny.ISequence<Dafny.Rune> _165___mcc_h13 = _source5.dtor_Passthrough_a0;
        Dafny.ISequence<Dafny.Rune> _166_v = _165___mcc_h13;
        s = _166_v;
      } else {
        Dafny.ISequence<Dafny.Rune> _167___mcc_h14 = _source5.dtor_TypeArg_a0;
        Dafny.ISequence<Dafny.Rune> _source8 = _167___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _168___mcc_h15 = _source8;
        Dafny.ISequence<Dafny.Rune> _169_name = _168___mcc_h15;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _169_name);
      }
      return s;
    }
    public static void GenClassImplBody(Dafny.ISequence<DAST._IMethod> body, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams, out Dafny.ISequence<Dafny.Rune> s, out Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> traitBodies) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _170_i;
      _170_i = BigInteger.Zero;
      while ((_170_i) < (new BigInteger((body).Count))) {
        DAST._IMethod _source9 = (body).Select(_170_i);
        DAST._IMethod _171___mcc_h0 = _source9;
        DAST._IMethod _172_m = _171___mcc_h0;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source10 = (_172_m).dtor_overridingPath;
          if (_source10.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _173___mcc_h1 = _source10.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _174_p = _173___mcc_h1;
            {
              Dafny.ISequence<Dafny.Rune> _175_existing;
              _175_existing = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              if ((traitBodies).Contains(_174_p)) {
                _175_existing = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(traitBodies, _174_p);
              }
              if ((new BigInteger((_175_existing).Count)).Sign == 1) {
                _175_existing = Dafny.Sequence<Dafny.Rune>.Concat(_175_existing, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
              }
              Dafny.ISequence<Dafny.Rune> _176_genMethod;
              Dafny.ISequence<Dafny.Rune> _out52;
              _out52 = DCOMP.COMP.GenMethod(_172_m, true, enclosingType, enclosingTypeParams);
              _176_genMethod = _out52;
              _175_existing = Dafny.Sequence<Dafny.Rune>.Concat(_175_existing, _176_genMethod);
              traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Merge(traitBodies, Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements(new Dafny.Pair<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>(_174_p, _175_existing)));
            }
          } else {
            {
              Dafny.ISequence<Dafny.Rune> _177_generated;
              Dafny.ISequence<Dafny.Rune> _out53;
              _out53 = DCOMP.COMP.GenMethod(_172_m, forTrait, enclosingType, enclosingTypeParams);
              _177_generated = _out53;
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, _177_generated);
            }
          }
        }
        if ((new BigInteger((s).Count)).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        _170_i = (_170_i) + (BigInteger.One);
      }
    }
    public static Dafny.ISequence<Dafny.Rune> GenParams(Dafny.ISequence<DAST._IFormal> @params) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _178_i;
      _178_i = BigInteger.Zero;
      while ((_178_i) < (new BigInteger((@params).Count))) {
        DAST._IFormal _179_param;
        _179_param = (@params).Select(_178_i);
        Dafny.ISequence<Dafny.Rune> _180_paramType;
        Dafny.ISequence<Dafny.Rune> _out54;
        _out54 = DCOMP.COMP.GenType((_179_param).dtor_typ, false, false);
        _180_paramType = _out54;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_179_param).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _180_paramType);
        if ((_178_i) < ((new BigInteger((@params).Count)) - (BigInteger.One))) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        _178_i = (_178_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenMethod(DAST._IMethod m, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _181_params;
      Dafny.ISequence<Dafny.Rune> _out55;
      _out55 = DCOMP.COMP.GenParams((m).dtor_params);
      _181_params = _out55;
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _182_paramNames;
      _182_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _183_paramI;
      _183_paramI = BigInteger.Zero;
      while ((_183_paramI) < (new BigInteger(((m).dtor_params).Count))) {
        _182_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_182_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((m).dtor_params).Select(_183_paramI)).dtor_name));
        _183_paramI = (_183_paramI) + (BigInteger.One);
      }
      if (!((m).dtor_isStatic)) {
        if (forTrait) {
          _181_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _181_params);
        } else {
          Dafny.ISequence<Dafny.Rune> _184_enclosingTypeString;
          Dafny.ISequence<Dafny.Rune> _out56;
          _out56 = DCOMP.COMP.GenType(enclosingType, false, false);
          _184_enclosingTypeString = _out56;
          _181_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self: &"), _184_enclosingTypeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _181_params);
        }
      }
      Dafny.ISequence<Dafny.Rune> _185_retType;
      _185_retType = (((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
      BigInteger _186_typeI;
      _186_typeI = BigInteger.Zero;
      while ((_186_typeI) < (new BigInteger(((m).dtor_outTypes).Count))) {
        if ((_186_typeI).Sign == 1) {
          _185_retType = Dafny.Sequence<Dafny.Rune>.Concat(_185_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        Dafny.ISequence<Dafny.Rune> _187_typeString;
        Dafny.ISequence<Dafny.Rune> _out57;
        _out57 = DCOMP.COMP.GenType(((m).dtor_outTypes).Select(_186_typeI), false, false);
        _187_typeString = _out57;
        _185_retType = Dafny.Sequence<Dafny.Rune>.Concat(_185_retType, _187_typeString);
        _186_typeI = (_186_typeI) + (BigInteger.One);
      }
      if ((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) {
        _185_retType = Dafny.Sequence<Dafny.Rune>.Concat(_185_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      if (forTrait) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn r#"), (m).dtor_name);
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#"), (m).dtor_name);
      }
      Dafny.ISequence<DAST._IType> _188_typeParamsFiltered;
      _188_typeParamsFiltered = Dafny.Sequence<DAST._IType>.FromElements();
      BigInteger _189_typeParamI;
      _189_typeParamI = BigInteger.Zero;
      while ((_189_typeParamI) < (new BigInteger(((m).dtor_typeParams).Count))) {
        DAST._IType _190_typeParam;
        _190_typeParam = ((m).dtor_typeParams).Select(_189_typeParamI);
        if (!((enclosingTypeParams).Contains(_190_typeParam))) {
          _188_typeParamsFiltered = Dafny.Sequence<DAST._IType>.Concat(_188_typeParamsFiltered, Dafny.Sequence<DAST._IType>.FromElements(_190_typeParam));
        }
        _189_typeParamI = (_189_typeParamI) + (BigInteger.One);
      }
      if ((new BigInteger((_188_typeParamsFiltered).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _191_i;
        _191_i = BigInteger.Zero;
        while ((_191_i) < (new BigInteger((_188_typeParamsFiltered).Count))) {
          if ((_191_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _192_typeString;
          Dafny.ISequence<Dafny.Rune> _out58;
          _out58 = DCOMP.COMP.GenType((_188_typeParamsFiltered).Select(_191_i), false, false);
          _192_typeString = _out58;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _192_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::DafnyErasable + ::dafny_runtime::DafnyUnerasable<")), _192_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> + Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static"));
          _191_i = (_191_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _181_params), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _185_retType);
      if ((m).dtor_hasBody) {
        Dafny.ISequence<Dafny.Rune> _193_earlyReturn;
        _193_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return;");
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source11 = (m).dtor_outVars;
        if (_source11.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _194___mcc_h0 = _source11.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _195_outVars = _194___mcc_h0;
          {
            _193_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return (");
            BigInteger _196_outI;
            _196_outI = BigInteger.Zero;
            while ((_196_outI) < (new BigInteger((_195_outVars).Count))) {
              if ((_196_outI).Sign == 1) {
                _193_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_193_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _197_outVar;
              _197_outVar = (_195_outVars).Select(_196_outI);
              _193_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_193_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_197_outVar));
              _196_outI = (_196_outI) + (BigInteger.One);
            }
            _193_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_193_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
          }
        } else {
        }
        Dafny.ISequence<Dafny.Rune> _198_body;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _199___v12;
        Dafny.ISequence<Dafny.Rune> _out59;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out60;
        DCOMP.COMP.GenStmts((m).dtor_body, _182_paramNames, true, _193_earlyReturn, out _out59, out _out60);
        _198_body = _out59;
        _199___v12 = _out60;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source12 = (m).dtor_outVars;
        if (_source12.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _200___mcc_h1 = _source12.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _201_outVars = _200___mcc_h1;
          {
            _198_body = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_198_body, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _193_earlyReturn);
          }
        } else {
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _198_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
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
      BigInteger _202_i;
      _202_i = BigInteger.Zero;
      while ((_202_i) < (new BigInteger((stmts).Count))) {
        DAST._IStatement _203_stmt;
        _203_stmt = (stmts).Select(_202_i);
        Dafny.ISequence<Dafny.Rune> _204_stmtString;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _205_recIdents;
        Dafny.ISequence<Dafny.Rune> _out61;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out62;
        DCOMP.COMP.GenStmt(_203_stmt, @params, (isLast) && ((_202_i) == ((new BigInteger((stmts).Count)) - (BigInteger.One))), earlyReturn, out _out61, out _out62);
        _204_stmtString = _out61;
        _205_recIdents = _out62;
        readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _205_recIdents);
        if ((_202_i).Sign == 1) {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, _204_stmtString);
        _202_i = (_202_i) + (BigInteger.One);
      }
    }
    public static void GenAssignLhs(DAST._IAssignLhs lhs, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      needsIIFE = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IAssignLhs _source13 = lhs;
      if (_source13.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _206___mcc_h0 = _source13.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _source14 = _206___mcc_h0;
        Dafny.ISequence<Dafny.Rune> _207___mcc_h1 = _source14;
        Dafny.ISequence<Dafny.Rune> _208_id = _207___mcc_h1;
        {
          if ((@params).Contains(_208_id)) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*r#"), _208_id);
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _208_id);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_208_id);
          needsIIFE = false;
        }
      } else {
        DAST._IExpression _209___mcc_h2 = _source13.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _210___mcc_h3 = _source13.dtor_field;
        Dafny.ISequence<Dafny.Rune> _211_field = _210___mcc_h3;
        DAST._IExpression _212_on = _209___mcc_h2;
        {
          Dafny.ISequence<Dafny.Rune> _213_onExpr;
          bool _214_onOwned;
          bool _215_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _216_recIdents;
          Dafny.ISequence<Dafny.Rune> _out63;
          bool _out64;
          bool _out65;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out66;
          DCOMP.COMP.GenExpr(_212_on, @params, false, out _out63, out _out64, out _out65, out _out66);
          _213_onExpr = _out63;
          _214_onOwned = _out64;
          _215_onErased = _out65;
          _216_recIdents = _out66;
          if (!(_215_onErased)) {
            Dafny.ISequence<Dafny.Rune> _217_eraseFn;
            _217_eraseFn = ((_214_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _213_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _217_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _213_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _213_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _211_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut())"));
          readIdents = _216_recIdents;
          needsIIFE = true;
        }
      }
    }
    public static void GenStmt(DAST._IStatement stmt, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IStatement _source15 = stmt;
      if (_source15.is_DeclareVar) {
        Dafny.ISequence<Dafny.Rune> _218___mcc_h0 = _source15.dtor_name;
        DAST._IType _219___mcc_h1 = _source15.dtor_typ;
        DAST._IOptional<DAST._IExpression> _220___mcc_h2 = _source15.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source16 = _220___mcc_h2;
        if (_source16.is_Some) {
          DAST._IExpression _221___mcc_h3 = _source16.dtor_Some_a0;
          DAST._IExpression _222_expression = _221___mcc_h3;
          DAST._IType _223_typ = _219___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _224_name = _218___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _225_expr;
            bool _226___v13;
            bool _227_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _228_recIdents;
            Dafny.ISequence<Dafny.Rune> _out67;
            bool _out68;
            bool _out69;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out70;
            DCOMP.COMP.GenExpr(_222_expression, @params, true, out _out67, out _out68, out _out69, out _out70);
            _225_expr = _out67;
            _226___v13 = _out68;
            _227_recErased = _out69;
            _228_recIdents = _out70;
            if (_227_recErased) {
              _225_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _225_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _229_typeString;
            Dafny.ISequence<Dafny.Rune> _out71;
            _out71 = DCOMP.COMP.GenType(_223_typ, true, false);
            _229_typeString = _out71;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _224_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _229_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _225_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _228_recIdents;
          }
        } else {
          DAST._IType _230_typ = _219___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _231_name = _218___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _232_typeString;
            Dafny.ISequence<Dafny.Rune> _out72;
            _out72 = DCOMP.COMP.GenType(_230_typ, true, false);
            _232_typeString = _out72;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _231_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _232_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source15.is_Assign) {
        DAST._IAssignLhs _233___mcc_h4 = _source15.dtor_lhs;
        DAST._IExpression _234___mcc_h5 = _source15.dtor_value;
        DAST._IExpression _235_expression = _234___mcc_h5;
        DAST._IAssignLhs _236_lhs = _233___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _237_lhsGen;
          bool _238_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _239_recIdents;
          Dafny.ISequence<Dafny.Rune> _out73;
          bool _out74;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out75;
          DCOMP.COMP.GenAssignLhs(_236_lhs, @params, out _out73, out _out74, out _out75);
          _237_lhsGen = _out73;
          _238_needsIIFE = _out74;
          _239_recIdents = _out75;
          Dafny.ISequence<Dafny.Rune> _240_exprGen;
          bool _241___v14;
          bool _242_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _243_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out76;
          bool _out77;
          bool _out78;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out79;
          DCOMP.COMP.GenExpr(_235_expression, @params, true, out _out76, out _out77, out _out78, out _out79);
          _240_exprGen = _out76;
          _241___v14 = _out77;
          _242_exprErased = _out78;
          _243_exprIdents = _out79;
          if (_242_exprErased) {
            _240_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _240_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_238_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ let __rhs = "), _240_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; ")), _237_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = __rhs; }"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_237_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _240_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_239_recIdents, _243_exprIdents);
        }
      } else if (_source15.is_If) {
        DAST._IExpression _244___mcc_h6 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _245___mcc_h7 = _source15.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _246___mcc_h8 = _source15.dtor_els;
        Dafny.ISequence<DAST._IStatement> _247_els = _246___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _248_thn = _245___mcc_h7;
        DAST._IExpression _249_cond = _244___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _250_condString;
          bool _251___v15;
          bool _252_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _253_recIdents;
          Dafny.ISequence<Dafny.Rune> _out80;
          bool _out81;
          bool _out82;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out83;
          DCOMP.COMP.GenExpr(_249_cond, @params, true, out _out80, out _out81, out _out82, out _out83);
          _250_condString = _out80;
          _251___v15 = _out81;
          _252_condErased = _out82;
          _253_recIdents = _out83;
          if (!(_252_condErased)) {
            _250_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _250_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _253_recIdents;
          Dafny.ISequence<Dafny.Rune> _254_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _255_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out84;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out85;
          DCOMP.COMP.GenStmts(_248_thn, @params, isLast, earlyReturn, out _out84, out _out85);
          _254_thnString = _out84;
          _255_thnIdents = _out85;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _255_thnIdents);
          Dafny.ISequence<Dafny.Rune> _256_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _257_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out86;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out87;
          DCOMP.COMP.GenStmts(_247_els, @params, isLast, earlyReturn, out _out86, out _out87);
          _256_elsString = _out86;
          _257_elsIdents = _out87;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _257_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _250_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _254_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _256_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_While) {
        DAST._IExpression _258___mcc_h9 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _259___mcc_h10 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _260_body = _259___mcc_h10;
        DAST._IExpression _261_cond = _258___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _262_condString;
          bool _263___v16;
          bool _264_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _265_recIdents;
          Dafny.ISequence<Dafny.Rune> _out88;
          bool _out89;
          bool _out90;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out91;
          DCOMP.COMP.GenExpr(_261_cond, @params, true, out _out88, out _out89, out _out90, out _out91);
          _262_condString = _out88;
          _263___v16 = _out89;
          _264_condErased = _out90;
          _265_recIdents = _out91;
          if (!(_264_condErased)) {
            _262_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _262_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _265_recIdents;
          Dafny.ISequence<Dafny.Rune> _266_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _267_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out92;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out93;
          DCOMP.COMP.GenStmts(_260_body, @params, false, earlyReturn, out _out92, out _out93);
          _266_bodyString = _out92;
          _267_bodyIdents = _out93;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _267_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _262_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _266_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _268___mcc_h11 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _269___mcc_h12 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _270___mcc_h13 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _271___mcc_h14 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _272___mcc_h15 = _source15.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _273_maybeOutVars = _272___mcc_h15;
        Dafny.ISequence<DAST._IExpression> _274_args = _271___mcc_h14;
        Dafny.ISequence<DAST._IType> _275_typeArgs = _270___mcc_h13;
        Dafny.ISequence<Dafny.Rune> _276_name = _269___mcc_h12;
        DAST._IExpression _277_on = _268___mcc_h11;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _278_typeArgString;
          _278_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_275_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _279_typeI;
            _279_typeI = BigInteger.Zero;
            _278_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_279_typeI) < (new BigInteger((_275_typeArgs).Count))) {
              if ((_279_typeI).Sign == 1) {
                _278_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_278_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _280_typeString;
              Dafny.ISequence<Dafny.Rune> _out94;
              _out94 = DCOMP.COMP.GenType((_275_typeArgs).Select(_279_typeI), false, false);
              _280_typeString = _out94;
              _278_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_278_typeArgString, _280_typeString);
              _279_typeI = (_279_typeI) + (BigInteger.One);
            }
            _278_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_278_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _281_argString;
          _281_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _282_i;
          _282_i = BigInteger.Zero;
          while ((_282_i) < (new BigInteger((_274_args).Count))) {
            if ((_282_i).Sign == 1) {
              _281_argString = Dafny.Sequence<Dafny.Rune>.Concat(_281_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _283_argExpr;
            bool _284_isOwned;
            bool _285_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _286_argIdents;
            Dafny.ISequence<Dafny.Rune> _out95;
            bool _out96;
            bool _out97;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out98;
            DCOMP.COMP.GenExpr((_274_args).Select(_282_i), @params, false, out _out95, out _out96, out _out97, out _out98);
            _283_argExpr = _out95;
            _284_isOwned = _out96;
            _285_argErased = _out97;
            _286_argIdents = _out98;
            if (_284_isOwned) {
              _283_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _283_argExpr);
            }
            _281_argString = Dafny.Sequence<Dafny.Rune>.Concat(_281_argString, _283_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _286_argIdents);
            _282_i = (_282_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _287_enclosingString;
          bool _288___v17;
          bool _289___v18;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _290_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out99;
          bool _out100;
          bool _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenExpr(_277_on, @params, false, out _out99, out _out100, out _out101, out _out102);
          _287_enclosingString = _out99;
          _288___v17 = _out100;
          _289___v18 = _out101;
          _290_enclosingIdents = _out102;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _290_enclosingIdents);
          DAST._IExpression _source17 = _277_on;
          if (_source17.is_Literal) {
            DAST._ILiteral _291___mcc_h18 = _source17.dtor_Literal_a0;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _292___mcc_h20 = _source17.dtor_Ident_a0;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _293___mcc_h22 = _source17.dtor_Companion_a0;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_287_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source17.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _294___mcc_h24 = _source17.dtor_Tuple_a0;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _295___mcc_h26 = _source17.dtor_path;
            Dafny.ISequence<DAST._IExpression> _296___mcc_h27 = _source17.dtor_args;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _297___mcc_h30 = _source17.dtor_dims;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _298___mcc_h32 = _source17.dtor_path;
            Dafny.ISequence<Dafny.Rune> _299___mcc_h33 = _source17.dtor_variant;
            bool _300___mcc_h34 = _source17.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _301___mcc_h35 = _source17.dtor_contents;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Convert) {
            DAST._IExpression _302___mcc_h40 = _source17.dtor_value;
            DAST._IType _303___mcc_h41 = _source17.dtor_from;
            DAST._IType _304___mcc_h42 = _source17.dtor_typ;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _305___mcc_h46 = _source17.dtor_elements;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _306___mcc_h48 = _source17.dtor_elements;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_This) {
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ite) {
            DAST._IExpression _307___mcc_h50 = _source17.dtor_cond;
            DAST._IExpression _308___mcc_h51 = _source17.dtor_thn;
            DAST._IExpression _309___mcc_h52 = _source17.dtor_els;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_UnOp) {
            DAST._IUnaryOp _310___mcc_h56 = _source17.dtor_unOp;
            DAST._IExpression _311___mcc_h57 = _source17.dtor_expr;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _312___mcc_h60 = _source17.dtor_op;
            DAST._IExpression _313___mcc_h61 = _source17.dtor_left;
            DAST._IExpression _314___mcc_h62 = _source17.dtor_right;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Select) {
            DAST._IExpression _315___mcc_h66 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _316___mcc_h67 = _source17.dtor_field;
            bool _317___mcc_h68 = _source17.dtor_isConstant;
            bool _318___mcc_h69 = _source17.dtor_onDatatype;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SelectFn) {
            DAST._IExpression _319___mcc_h74 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _320___mcc_h75 = _source17.dtor_field;
            bool _321___mcc_h76 = _source17.dtor_onDatatype;
            bool _322___mcc_h77 = _source17.dtor_isStatic;
            BigInteger _323___mcc_h78 = _source17.dtor_arity;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TupleSelect) {
            DAST._IExpression _324___mcc_h84 = _source17.dtor_expr;
            BigInteger _325___mcc_h85 = _source17.dtor_index;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Call) {
            DAST._IExpression _326___mcc_h88 = _source17.dtor_on;
            Dafny.ISequence<Dafny.Rune> _327___mcc_h89 = _source17.dtor_name;
            Dafny.ISequence<DAST._IType> _328___mcc_h90 = _source17.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _329___mcc_h91 = _source17.dtor_args;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _330___mcc_h96 = _source17.dtor_params;
            DAST._IType _331___mcc_h97 = _source17.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _332___mcc_h98 = _source17.dtor_body;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _333___mcc_h102 = _source17.dtor_name;
            DAST._IType _334___mcc_h103 = _source17.dtor_typ;
            DAST._IExpression _335___mcc_h104 = _source17.dtor_value;
            DAST._IExpression _336___mcc_h105 = _source17.dtor_iifeBody;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Apply) {
            DAST._IExpression _337___mcc_h110 = _source17.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _338___mcc_h111 = _source17.dtor_args;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TypeTest) {
            DAST._IExpression _339___mcc_h114 = _source17.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _340___mcc_h115 = _source17.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _341___mcc_h116 = _source17.dtor_variant;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _342___mcc_h120 = _source17.dtor_typ;
            {
              _287_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _343_receiver;
          _343_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source18 = _273_maybeOutVars;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _344___mcc_h122 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _345_outVars = _344___mcc_h122;
            {
              if ((new BigInteger((_345_outVars).Count)) > (BigInteger.One)) {
                _343_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _346_outI;
              _346_outI = BigInteger.Zero;
              while ((_346_outI) < (new BigInteger((_345_outVars).Count))) {
                if ((_346_outI).Sign == 1) {
                  _343_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_343_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _347_outVar;
                _347_outVar = (_345_outVars).Select(_346_outI);
                _343_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_343_receiver, (_347_outVar));
                _346_outI = (_346_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_345_outVars).Count)) > (BigInteger.One)) {
                _343_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_343_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_343_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_343_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _287_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _276_name), _278_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _281_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _348___mcc_h16 = _source15.dtor_expr;
        DAST._IExpression _349_expr = _348___mcc_h16;
        {
          Dafny.ISequence<Dafny.Rune> _350_exprString;
          bool _351___v21;
          bool _352_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _353_recIdents;
          Dafny.ISequence<Dafny.Rune> _out103;
          bool _out104;
          bool _out105;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out106;
          DCOMP.COMP.GenExpr(_349_expr, @params, true, out _out103, out _out104, out _out105, out _out106);
          _350_exprString = _out103;
          _351___v21 = _out104;
          _352_recErased = _out105;
          _353_recIdents = _out106;
          _350_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _350_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _353_recIdents;
          if (isLast) {
            generated = _350_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _350_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
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
        DAST._IExpression _354___mcc_h17 = _source15.dtor_Print_a0;
        DAST._IExpression _355_e = _354___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _356_printedExpr;
          bool _357_isOwned;
          bool _358___v22;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _359_recIdents;
          Dafny.ISequence<Dafny.Rune> _out107;
          bool _out108;
          bool _out109;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out110;
          DCOMP.COMP.GenExpr(_355_e, @params, false, out _out107, out _out108, out _out109, out _out110);
          _356_printedExpr = _out107;
          _357_isOwned = _out108;
          _358___v22 = _out109;
          _359_recIdents = _out110;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_357_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _356_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _359_recIdents;
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
        DAST._ILiteral _360___mcc_h0 = _source19.dtor_Literal_a0;
        DAST._ILiteral _source20 = _360___mcc_h0;
        if (_source20.is_BoolLiteral) {
          bool _361___mcc_h1 = _source20.dtor_BoolLiteral_a0;
          if ((_361___mcc_h1) == (false)) {
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
          Dafny.ISequence<Dafny.Rune> _362___mcc_h2 = _source20.dtor_IntLiteral_a0;
          DAST._IType _363___mcc_h3 = _source20.dtor_IntLiteral_a1;
          DAST._IType _364_t = _363___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _365_i = _362___mcc_h2;
          {
            DAST._IType _source21 = _364_t;
            if (_source21.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _366___mcc_h60 = _source21.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _367___mcc_h61 = _source21.dtor_typeArgs;
              DAST._IResolvedType _368___mcc_h62 = _source21.dtor_resolved;
              {
                s = _365_i;
              }
            } else if (_source21.is_Tuple) {
              Dafny.ISequence<DAST._IType> _369___mcc_h66 = _source21.dtor_Tuple_a0;
              {
                s = _365_i;
              }
            } else if (_source21.is_Array) {
              DAST._IType _370___mcc_h68 = _source21.dtor_element;
              {
                s = _365_i;
              }
            } else if (_source21.is_Seq) {
              DAST._IType _371___mcc_h70 = _source21.dtor_element;
              {
                s = _365_i;
              }
            } else if (_source21.is_Set) {
              DAST._IType _372___mcc_h72 = _source21.dtor_element;
              {
                s = _365_i;
              }
            } else if (_source21.is_Multiset) {
              DAST._IType _373___mcc_h74 = _source21.dtor_element;
              {
                s = _365_i;
              }
            } else if (_source21.is_Map) {
              DAST._IType _374___mcc_h76 = _source21.dtor_key;
              DAST._IType _375___mcc_h77 = _source21.dtor_value;
              {
                s = _365_i;
              }
            } else if (_source21.is_Arrow) {
              Dafny.ISequence<DAST._IType> _376___mcc_h80 = _source21.dtor_args;
              DAST._IType _377___mcc_h81 = _source21.dtor_result;
              {
                s = _365_i;
              }
            } else if (_source21.is_Primitive) {
              DAST._IPrimitive _378___mcc_h84 = _source21.dtor_Primitive_a0;
              DAST._IPrimitive _source22 = _378___mcc_h84;
              if (_source22.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _365_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source22.is_Real) {
                {
                  s = _365_i;
                }
              } else if (_source22.is_String) {
                {
                  s = _365_i;
                }
              } else if (_source22.is_Bool) {
                {
                  s = _365_i;
                }
              } else {
                {
                  s = _365_i;
                }
              }
            } else if (_source21.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _379___mcc_h86 = _source21.dtor_Passthrough_a0;
              {
                s = _365_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _380___mcc_h88 = _source21.dtor_TypeArg_a0;
              {
                s = _365_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _381___mcc_h4 = _source20.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _382___mcc_h5 = _source20.dtor_DecLiteral_a1;
          DAST._IType _383___mcc_h6 = _source20.dtor_DecLiteral_a2;
          DAST._IType _384_t = _383___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _385_d = _382___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _386_n = _381___mcc_h4;
          {
            DAST._IType _source23 = _384_t;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _387___mcc_h90 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _388___mcc_h91 = _source23.dtor_typeArgs;
              DAST._IResolvedType _389___mcc_h92 = _source23.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _390___mcc_h96 = _source23.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Array) {
              DAST._IType _391___mcc_h98 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Seq) {
              DAST._IType _392___mcc_h100 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Set) {
              DAST._IType _393___mcc_h102 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _394___mcc_h104 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Map) {
              DAST._IType _395___mcc_h106 = _source23.dtor_key;
              DAST._IType _396___mcc_h107 = _source23.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _397___mcc_h110 = _source23.dtor_args;
              DAST._IType _398___mcc_h111 = _source23.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _399___mcc_h114 = _source23.dtor_Primitive_a0;
              DAST._IPrimitive _source24 = _399___mcc_h114;
              if (_source24.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _386_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source24.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _400___mcc_h116 = _source23.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _401___mcc_h118 = _source23.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_386_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _385_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _402___mcc_h7 = _source20.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _403_l = _402___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _403_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_CharLiteral) {
          Dafny.Rune _404___mcc_h8 = _source20.dtor_CharLiteral_a0;
          Dafny.Rune _405_c = _404___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_405_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _406___mcc_h9 = _source19.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _407_name = _406___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _407_name);
          if (!((@params).Contains(_407_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_407_name);
        }
      } else if (_source19.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _408___mcc_h10 = _source19.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _409_path = _408___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out111;
          _out111 = DCOMP.COMP.GenPath(_409_path);
          s = _out111;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source19.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _410___mcc_h11 = _source19.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _411_values = _410___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _412_i;
          _412_i = BigInteger.Zero;
          bool _413_allErased;
          _413_allErased = true;
          while ((_412_i) < (new BigInteger((_411_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _414___v25;
            bool _415___v26;
            bool _416_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _417___v27;
            Dafny.ISequence<Dafny.Rune> _out112;
            bool _out113;
            bool _out114;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out115;
            DCOMP.COMP.GenExpr((_411_values).Select(_412_i), @params, true, out _out112, out _out113, out _out114, out _out115);
            _414___v25 = _out112;
            _415___v26 = _out113;
            _416_isErased = _out114;
            _417___v27 = _out115;
            _413_allErased = (_413_allErased) && (_416_isErased);
            _412_i = (_412_i) + (BigInteger.One);
          }
          _412_i = BigInteger.Zero;
          while ((_412_i) < (new BigInteger((_411_values).Count))) {
            if ((_412_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _418_recursiveGen;
            bool _419___v28;
            bool _420_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _421_recIdents;
            Dafny.ISequence<Dafny.Rune> _out116;
            bool _out117;
            bool _out118;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out119;
            DCOMP.COMP.GenExpr((_411_values).Select(_412_i), @params, true, out _out116, out _out117, out _out118, out _out119);
            _418_recursiveGen = _out116;
            _419___v28 = _out117;
            _420_isErased = _out118;
            _421_recIdents = _out119;
            if ((_420_isErased) && (!(_413_allErased))) {
              _418_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _418_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _418_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _421_recIdents);
            _412_i = (_412_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _413_allErased;
        }
      } else if (_source19.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _422___mcc_h12 = _source19.dtor_path;
        Dafny.ISequence<DAST._IExpression> _423___mcc_h13 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _424_args = _423___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _425_path = _422___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _426_path;
          Dafny.ISequence<Dafny.Rune> _out120;
          _out120 = DCOMP.COMP.GenPath(_425_path);
          _426_path = _out120;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _426_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _427_i;
          _427_i = BigInteger.Zero;
          while ((_427_i) < (new BigInteger((_424_args).Count))) {
            if ((_427_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _428_recursiveGen;
            bool _429___v29;
            bool _430_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _431_recIdents;
            Dafny.ISequence<Dafny.Rune> _out121;
            bool _out122;
            bool _out123;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out124;
            DCOMP.COMP.GenExpr((_424_args).Select(_427_i), @params, true, out _out121, out _out122, out _out123, out _out124);
            _428_recursiveGen = _out121;
            _429___v29 = _out122;
            _430_isErased = _out123;
            _431_recIdents = _out124;
            if (_430_isErased) {
              _428_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _428_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _428_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _431_recIdents);
            _427_i = (_427_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _432___mcc_h14 = _source19.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _433_dims = _432___mcc_h14;
        {
          BigInteger _434_i;
          _434_i = (new BigInteger((_433_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_434_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _435_recursiveGen;
            bool _436___v30;
            bool _437_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _438_recIdents;
            Dafny.ISequence<Dafny.Rune> _out125;
            bool _out126;
            bool _out127;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out128;
            DCOMP.COMP.GenExpr((_433_dims).Select(_434_i), @params, true, out _out125, out _out126, out _out127, out _out128);
            _435_recursiveGen = _out125;
            _436___v30 = _out126;
            _437_isErased = _out127;
            _438_recIdents = _out128;
            if (!(_437_isErased)) {
              _435_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _435_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _435_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _438_recIdents);
            _434_i = (_434_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _439___mcc_h15 = _source19.dtor_path;
        Dafny.ISequence<Dafny.Rune> _440___mcc_h16 = _source19.dtor_variant;
        bool _441___mcc_h17 = _source19.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _442___mcc_h18 = _source19.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _443_values = _442___mcc_h18;
        bool _444_isCo = _441___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _445_variant = _440___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _446_path = _439___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _447_path;
          Dafny.ISequence<Dafny.Rune> _out129;
          _out129 = DCOMP.COMP.GenPath(_446_path);
          _447_path = _out129;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _447_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _445_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _448_i;
          _448_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_448_i) < (new BigInteger((_443_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_443_values).Select(_448_i);
            Dafny.ISequence<Dafny.Rune> _449_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _450_value = _let_tmp_rhs0.dtor__1;
            if ((_448_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_444_isCo) {
              Dafny.ISequence<Dafny.Rune> _451_recursiveGen;
              bool _452___v31;
              bool _453_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _454_recIdents;
              Dafny.ISequence<Dafny.Rune> _out130;
              bool _out131;
              bool _out132;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out133;
              DCOMP.COMP.GenExpr(_450_value, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out130, out _out131, out _out132, out _out133);
              _451_recursiveGen = _out130;
              _452___v31 = _out131;
              _453_isErased = _out132;
              _454_recIdents = _out133;
              if (!(_453_isErased)) {
                _451_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _451_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _451_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _451_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _454_recIdents);
              Dafny.ISequence<Dafny.Rune> _455_allReadCloned;
              _455_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_454_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _456_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_454_recIdents).Elements) {
                  _456_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_454_recIdents).Contains(_456_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1084)");
              after__ASSIGN_SUCH_THAT_0:;
                _455_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_455_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _456_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _456_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _454_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_454_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_456_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _449_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _455_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _451_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _457_recursiveGen;
              bool _458___v32;
              bool _459_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _460_recIdents;
              Dafny.ISequence<Dafny.Rune> _out134;
              bool _out135;
              bool _out136;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out137;
              DCOMP.COMP.GenExpr(_450_value, @params, true, out _out134, out _out135, out _out136, out _out137);
              _457_recursiveGen = _out134;
              _458___v32 = _out135;
              _459_isErased = _out136;
              _460_recIdents = _out137;
              if (!(_459_isErased)) {
                _457_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _457_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _457_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _457_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _449_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _457_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _460_recIdents);
            }
            _448_i = (_448_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_Convert) {
        DAST._IExpression _461___mcc_h19 = _source19.dtor_value;
        DAST._IType _462___mcc_h20 = _source19.dtor_from;
        DAST._IType _463___mcc_h21 = _source19.dtor_typ;
        DAST._IType _464_toTpe = _463___mcc_h21;
        DAST._IType _465_fromTpe = _462___mcc_h20;
        DAST._IExpression _466_expr = _461___mcc_h19;
        {
          if (object.Equals(_465_fromTpe, _464_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _467_recursiveGen;
            bool _468_recOwned;
            bool _469_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _470_recIdents;
            Dafny.ISequence<Dafny.Rune> _out138;
            bool _out139;
            bool _out140;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out141;
            DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out138, out _out139, out _out140, out _out141);
            _467_recursiveGen = _out138;
            _468_recOwned = _out139;
            _469_recErased = _out140;
            _470_recIdents = _out141;
            s = _467_recursiveGen;
            isOwned = _468_recOwned;
            isErased = _469_recErased;
            readIdents = _470_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source25 = _System.Tuple2<DAST._IType, DAST._IType>.create(_465_fromTpe, _464_toTpe);
            DAST._IType _471___mcc_h120 = _source25.dtor__0;
            DAST._IType _472___mcc_h121 = _source25.dtor__1;
            DAST._IType _source26 = _471___mcc_h120;
            if (_source26.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _473___mcc_h124 = _source26.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _474___mcc_h125 = _source26.dtor_typeArgs;
              DAST._IResolvedType _475___mcc_h126 = _source26.dtor_resolved;
              DAST._IResolvedType _source27 = _475___mcc_h126;
              if (_source27.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _476___mcc_h133 = _source27.dtor_path;
                DAST._IType _source28 = _472___mcc_h121;
                if (_source28.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _477___mcc_h136 = _source28.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _478___mcc_h137 = _source28.dtor_typeArgs;
                  DAST._IResolvedType _479___mcc_h138 = _source28.dtor_resolved;
                  DAST._IResolvedType _source29 = _479___mcc_h138;
                  if (_source29.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _480___mcc_h142 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _481_recursiveGen;
                      bool _482_recOwned;
                      bool _483_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _484_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out142;
                      bool _out143;
                      bool _out144;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out145;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out142, out _out143, out _out144, out _out145);
                      _481_recursiveGen = _out142;
                      _482_recOwned = _out143;
                      _483_recErased = _out144;
                      _484_recIdents = _out145;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _481_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _482_recOwned;
                      isErased = _483_recErased;
                      readIdents = _484_recIdents;
                    }
                  } else if (_source29.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _485___mcc_h144 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _486_recursiveGen;
                      bool _487_recOwned;
                      bool _488_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _489_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out146;
                      bool _out147;
                      bool _out148;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out149;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out146, out _out147, out _out148, out _out149);
                      _486_recursiveGen = _out146;
                      _487_recOwned = _out147;
                      _488_recErased = _out148;
                      _489_recIdents = _out149;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _487_recOwned;
                      isErased = _488_recErased;
                      readIdents = _489_recIdents;
                    }
                  } else {
                    DAST._IType _490___mcc_h146 = _source29.dtor_Newtype_a0;
                    DAST._IType _491_b = _490___mcc_h146;
                    {
                      if (object.Equals(_465_fromTpe, _491_b)) {
                        Dafny.ISequence<Dafny.Rune> _492_recursiveGen;
                        bool _493_recOwned;
                        bool _494_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _495_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out150;
                        bool _out151;
                        bool _out152;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out153;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out150, out _out151, out _out152, out _out153);
                        _492_recursiveGen = _out150;
                        _493_recOwned = _out151;
                        _494_recErased = _out152;
                        _495_recIdents = _out153;
                        Dafny.ISequence<Dafny.Rune> _496_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out154;
                        _out154 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                        _496_rhsType = _out154;
                        Dafny.ISequence<Dafny.Rune> _497_uneraseFn;
                        _497_uneraseFn = ((_493_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _496_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _497_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _493_recOwned;
                        isErased = false;
                        readIdents = _495_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out155;
                        bool _out156;
                        bool _out157;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out158;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _491_b), _491_b, _464_toTpe), @params, mustOwn, out _out155, out _out156, out _out157, out _out158);
                        s = _out155;
                        isOwned = _out156;
                        isErased = _out157;
                        readIdents = _out158;
                      }
                    }
                  }
                } else if (_source28.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _498___mcc_h148 = _source28.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _499_recursiveGen;
                    bool _500_recOwned;
                    bool _501_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _502_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out159;
                    bool _out160;
                    bool _out161;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out162;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out159, out _out160, out _out161, out _out162);
                    _499_recursiveGen = _out159;
                    _500_recOwned = _out160;
                    _501_recErased = _out161;
                    _502_recIdents = _out162;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _499_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _500_recOwned;
                    isErased = _501_recErased;
                    readIdents = _502_recIdents;
                  }
                } else if (_source28.is_Array) {
                  DAST._IType _503___mcc_h150 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _504_recursiveGen;
                    bool _505_recOwned;
                    bool _506_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _507_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out163;
                    bool _out164;
                    bool _out165;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out166;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out163, out _out164, out _out165, out _out166);
                    _504_recursiveGen = _out163;
                    _505_recOwned = _out164;
                    _506_recErased = _out165;
                    _507_recIdents = _out166;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _504_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _505_recOwned;
                    isErased = _506_recErased;
                    readIdents = _507_recIdents;
                  }
                } else if (_source28.is_Seq) {
                  DAST._IType _508___mcc_h152 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _509_recursiveGen;
                    bool _510_recOwned;
                    bool _511_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _512_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out167;
                    bool _out168;
                    bool _out169;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out170;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out167, out _out168, out _out169, out _out170);
                    _509_recursiveGen = _out167;
                    _510_recOwned = _out168;
                    _511_recErased = _out169;
                    _512_recIdents = _out170;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _509_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _510_recOwned;
                    isErased = _511_recErased;
                    readIdents = _512_recIdents;
                  }
                } else if (_source28.is_Set) {
                  DAST._IType _513___mcc_h154 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _514_recursiveGen;
                    bool _515_recOwned;
                    bool _516_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _517_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out171;
                    bool _out172;
                    bool _out173;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out174;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out171, out _out172, out _out173, out _out174);
                    _514_recursiveGen = _out171;
                    _515_recOwned = _out172;
                    _516_recErased = _out173;
                    _517_recIdents = _out174;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _514_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _515_recOwned;
                    isErased = _516_recErased;
                    readIdents = _517_recIdents;
                  }
                } else if (_source28.is_Multiset) {
                  DAST._IType _518___mcc_h156 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _519_recursiveGen;
                    bool _520_recOwned;
                    bool _521_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _522_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out175;
                    bool _out176;
                    bool _out177;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out178;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out175, out _out176, out _out177, out _out178);
                    _519_recursiveGen = _out175;
                    _520_recOwned = _out176;
                    _521_recErased = _out177;
                    _522_recIdents = _out178;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _519_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _520_recOwned;
                    isErased = _521_recErased;
                    readIdents = _522_recIdents;
                  }
                } else if (_source28.is_Map) {
                  DAST._IType _523___mcc_h158 = _source28.dtor_key;
                  DAST._IType _524___mcc_h159 = _source28.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _525_recursiveGen;
                    bool _526_recOwned;
                    bool _527_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _528_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out179;
                    bool _out180;
                    bool _out181;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out182;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out179, out _out180, out _out181, out _out182);
                    _525_recursiveGen = _out179;
                    _526_recOwned = _out180;
                    _527_recErased = _out181;
                    _528_recIdents = _out182;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _525_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _526_recOwned;
                    isErased = _527_recErased;
                    readIdents = _528_recIdents;
                  }
                } else if (_source28.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _529___mcc_h162 = _source28.dtor_args;
                  DAST._IType _530___mcc_h163 = _source28.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _531_recursiveGen;
                    bool _532_recOwned;
                    bool _533_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _534_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out183;
                    bool _out184;
                    bool _out185;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out186;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out183, out _out184, out _out185, out _out186);
                    _531_recursiveGen = _out183;
                    _532_recOwned = _out184;
                    _533_recErased = _out185;
                    _534_recIdents = _out186;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _531_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _532_recOwned;
                    isErased = _533_recErased;
                    readIdents = _534_recIdents;
                  }
                } else if (_source28.is_Primitive) {
                  DAST._IPrimitive _535___mcc_h166 = _source28.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _536_recursiveGen;
                    bool _537_recOwned;
                    bool _538_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _539_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out187;
                    bool _out188;
                    bool _out189;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out190;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out187, out _out188, out _out189, out _out190);
                    _536_recursiveGen = _out187;
                    _537_recOwned = _out188;
                    _538_recErased = _out189;
                    _539_recIdents = _out190;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _536_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _537_recOwned;
                    isErased = _538_recErased;
                    readIdents = _539_recIdents;
                  }
                } else if (_source28.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _540___mcc_h168 = _source28.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _541_recursiveGen;
                    bool _542_recOwned;
                    bool _543_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _544_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out191;
                    bool _out192;
                    bool _out193;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out194;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out191, out _out192, out _out193, out _out194);
                    _541_recursiveGen = _out191;
                    _542_recOwned = _out192;
                    _543_recErased = _out193;
                    _544_recIdents = _out194;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _541_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _542_recOwned;
                    isErased = _543_recErased;
                    readIdents = _544_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _545___mcc_h170 = _source28.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _546_recursiveGen;
                    bool _547_recOwned;
                    bool _548_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _549_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out195;
                    bool _out196;
                    bool _out197;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out198;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out195, out _out196, out _out197, out _out198);
                    _546_recursiveGen = _out195;
                    _547_recOwned = _out196;
                    _548_recErased = _out197;
                    _549_recIdents = _out198;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _547_recOwned;
                    isErased = _548_recErased;
                    readIdents = _549_recIdents;
                  }
                }
              } else if (_source27.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _550___mcc_h172 = _source27.dtor_path;
                DAST._IType _source30 = _472___mcc_h121;
                if (_source30.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _551___mcc_h175 = _source30.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _552___mcc_h176 = _source30.dtor_typeArgs;
                  DAST._IResolvedType _553___mcc_h177 = _source30.dtor_resolved;
                  DAST._IResolvedType _source31 = _553___mcc_h177;
                  if (_source31.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _554___mcc_h181 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _555_recursiveGen;
                      bool _556_recOwned;
                      bool _557_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _558_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out199;
                      bool _out200;
                      bool _out201;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out202;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out199, out _out200, out _out201, out _out202);
                      _555_recursiveGen = _out199;
                      _556_recOwned = _out200;
                      _557_recErased = _out201;
                      _558_recIdents = _out202;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _555_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _556_recOwned;
                      isErased = _557_recErased;
                      readIdents = _558_recIdents;
                    }
                  } else if (_source31.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _559___mcc_h183 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _560_recursiveGen;
                      bool _561_recOwned;
                      bool _562_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _563_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out203;
                      bool _out204;
                      bool _out205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out206;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out203, out _out204, out _out205, out _out206);
                      _560_recursiveGen = _out203;
                      _561_recOwned = _out204;
                      _562_recErased = _out205;
                      _563_recIdents = _out206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _561_recOwned;
                      isErased = _562_recErased;
                      readIdents = _563_recIdents;
                    }
                  } else {
                    DAST._IType _564___mcc_h185 = _source31.dtor_Newtype_a0;
                    DAST._IType _565_b = _564___mcc_h185;
                    {
                      if (object.Equals(_465_fromTpe, _565_b)) {
                        Dafny.ISequence<Dafny.Rune> _566_recursiveGen;
                        bool _567_recOwned;
                        bool _568_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _569_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out207;
                        bool _out208;
                        bool _out209;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out210;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out207, out _out208, out _out209, out _out210);
                        _566_recursiveGen = _out207;
                        _567_recOwned = _out208;
                        _568_recErased = _out209;
                        _569_recIdents = _out210;
                        Dafny.ISequence<Dafny.Rune> _570_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out211;
                        _out211 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                        _570_rhsType = _out211;
                        Dafny.ISequence<Dafny.Rune> _571_uneraseFn;
                        _571_uneraseFn = ((_567_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _570_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _571_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _566_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _567_recOwned;
                        isErased = false;
                        readIdents = _569_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out212;
                        bool _out213;
                        bool _out214;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out215;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _565_b), _565_b, _464_toTpe), @params, mustOwn, out _out212, out _out213, out _out214, out _out215);
                        s = _out212;
                        isOwned = _out213;
                        isErased = _out214;
                        readIdents = _out215;
                      }
                    }
                  }
                } else if (_source30.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _572___mcc_h187 = _source30.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _573_recursiveGen;
                    bool _574_recOwned;
                    bool _575_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _576_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out216;
                    bool _out217;
                    bool _out218;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out219;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out216, out _out217, out _out218, out _out219);
                    _573_recursiveGen = _out216;
                    _574_recOwned = _out217;
                    _575_recErased = _out218;
                    _576_recIdents = _out219;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _573_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _574_recOwned;
                    isErased = _575_recErased;
                    readIdents = _576_recIdents;
                  }
                } else if (_source30.is_Array) {
                  DAST._IType _577___mcc_h189 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _578_recursiveGen;
                    bool _579_recOwned;
                    bool _580_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _581_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out220;
                    bool _out221;
                    bool _out222;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out223;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out220, out _out221, out _out222, out _out223);
                    _578_recursiveGen = _out220;
                    _579_recOwned = _out221;
                    _580_recErased = _out222;
                    _581_recIdents = _out223;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _578_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _579_recOwned;
                    isErased = _580_recErased;
                    readIdents = _581_recIdents;
                  }
                } else if (_source30.is_Seq) {
                  DAST._IType _582___mcc_h191 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _583_recursiveGen;
                    bool _584_recOwned;
                    bool _585_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _586_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out224;
                    bool _out225;
                    bool _out226;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out227;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out224, out _out225, out _out226, out _out227);
                    _583_recursiveGen = _out224;
                    _584_recOwned = _out225;
                    _585_recErased = _out226;
                    _586_recIdents = _out227;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _583_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _584_recOwned;
                    isErased = _585_recErased;
                    readIdents = _586_recIdents;
                  }
                } else if (_source30.is_Set) {
                  DAST._IType _587___mcc_h193 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _588_recursiveGen;
                    bool _589_recOwned;
                    bool _590_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _591_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out228;
                    bool _out229;
                    bool _out230;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out231;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out228, out _out229, out _out230, out _out231);
                    _588_recursiveGen = _out228;
                    _589_recOwned = _out229;
                    _590_recErased = _out230;
                    _591_recIdents = _out231;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _588_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _589_recOwned;
                    isErased = _590_recErased;
                    readIdents = _591_recIdents;
                  }
                } else if (_source30.is_Multiset) {
                  DAST._IType _592___mcc_h195 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _593_recursiveGen;
                    bool _594_recOwned;
                    bool _595_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _596_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out232;
                    bool _out233;
                    bool _out234;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out235;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out232, out _out233, out _out234, out _out235);
                    _593_recursiveGen = _out232;
                    _594_recOwned = _out233;
                    _595_recErased = _out234;
                    _596_recIdents = _out235;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _593_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _594_recOwned;
                    isErased = _595_recErased;
                    readIdents = _596_recIdents;
                  }
                } else if (_source30.is_Map) {
                  DAST._IType _597___mcc_h197 = _source30.dtor_key;
                  DAST._IType _598___mcc_h198 = _source30.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _599_recursiveGen;
                    bool _600_recOwned;
                    bool _601_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _602_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out236;
                    bool _out237;
                    bool _out238;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out239;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out236, out _out237, out _out238, out _out239);
                    _599_recursiveGen = _out236;
                    _600_recOwned = _out237;
                    _601_recErased = _out238;
                    _602_recIdents = _out239;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _599_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _600_recOwned;
                    isErased = _601_recErased;
                    readIdents = _602_recIdents;
                  }
                } else if (_source30.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _603___mcc_h201 = _source30.dtor_args;
                  DAST._IType _604___mcc_h202 = _source30.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _605_recursiveGen;
                    bool _606_recOwned;
                    bool _607_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _608_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out240;
                    bool _out241;
                    bool _out242;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out243;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out240, out _out241, out _out242, out _out243);
                    _605_recursiveGen = _out240;
                    _606_recOwned = _out241;
                    _607_recErased = _out242;
                    _608_recIdents = _out243;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _605_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _606_recOwned;
                    isErased = _607_recErased;
                    readIdents = _608_recIdents;
                  }
                } else if (_source30.is_Primitive) {
                  DAST._IPrimitive _609___mcc_h205 = _source30.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _610_recursiveGen;
                    bool _611_recOwned;
                    bool _612_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _613_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out244;
                    bool _out245;
                    bool _out246;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out247;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out244, out _out245, out _out246, out _out247);
                    _610_recursiveGen = _out244;
                    _611_recOwned = _out245;
                    _612_recErased = _out246;
                    _613_recIdents = _out247;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _610_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _611_recOwned;
                    isErased = _612_recErased;
                    readIdents = _613_recIdents;
                  }
                } else if (_source30.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _614___mcc_h207 = _source30.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _615_recursiveGen;
                    bool _616_recOwned;
                    bool _617_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _618_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out248;
                    bool _out249;
                    bool _out250;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out251;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out248, out _out249, out _out250, out _out251);
                    _615_recursiveGen = _out248;
                    _616_recOwned = _out249;
                    _617_recErased = _out250;
                    _618_recIdents = _out251;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _615_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _616_recOwned;
                    isErased = _617_recErased;
                    readIdents = _618_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _619___mcc_h209 = _source30.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _620_recursiveGen;
                    bool _621_recOwned;
                    bool _622_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _623_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out252;
                    bool _out253;
                    bool _out254;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out255;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out252, out _out253, out _out254, out _out255);
                    _620_recursiveGen = _out252;
                    _621_recOwned = _out253;
                    _622_recErased = _out254;
                    _623_recIdents = _out255;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _620_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _621_recOwned;
                    isErased = _622_recErased;
                    readIdents = _623_recIdents;
                  }
                }
              } else {
                DAST._IType _624___mcc_h211 = _source27.dtor_Newtype_a0;
                DAST._IType _source32 = _472___mcc_h121;
                if (_source32.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _625___mcc_h214 = _source32.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _626___mcc_h215 = _source32.dtor_typeArgs;
                  DAST._IResolvedType _627___mcc_h216 = _source32.dtor_resolved;
                  DAST._IResolvedType _source33 = _627___mcc_h216;
                  if (_source33.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _628___mcc_h223 = _source33.dtor_path;
                    DAST._IType _629_b = _624___mcc_h211;
                    {
                      if (object.Equals(_629_b, _464_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _630_recursiveGen;
                        bool _631_recOwned;
                        bool _632_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _633_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out256;
                        bool _out257;
                        bool _out258;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out259;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out256, out _out257, out _out258, out _out259);
                        _630_recursiveGen = _out256;
                        _631_recOwned = _out257;
                        _632_recErased = _out258;
                        _633_recIdents = _out259;
                        Dafny.ISequence<Dafny.Rune> _634_uneraseFn;
                        _634_uneraseFn = ((_631_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _634_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _630_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _631_recOwned;
                        isErased = true;
                        readIdents = _633_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out260;
                        bool _out261;
                        bool _out262;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out263;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _629_b), _629_b, _464_toTpe), @params, mustOwn, out _out260, out _out261, out _out262, out _out263);
                        s = _out260;
                        isOwned = _out261;
                        isErased = _out262;
                        readIdents = _out263;
                      }
                    }
                  } else if (_source33.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _635___mcc_h226 = _source33.dtor_path;
                    DAST._IType _636_b = _624___mcc_h211;
                    {
                      if (object.Equals(_636_b, _464_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _637_recursiveGen;
                        bool _638_recOwned;
                        bool _639_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _640_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out264;
                        bool _out265;
                        bool _out266;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out267;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out264, out _out265, out _out266, out _out267);
                        _637_recursiveGen = _out264;
                        _638_recOwned = _out265;
                        _639_recErased = _out266;
                        _640_recIdents = _out267;
                        Dafny.ISequence<Dafny.Rune> _641_uneraseFn;
                        _641_uneraseFn = ((_638_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _641_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _637_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _638_recOwned;
                        isErased = true;
                        readIdents = _640_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out268;
                        bool _out269;
                        bool _out270;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out271;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _636_b), _636_b, _464_toTpe), @params, mustOwn, out _out268, out _out269, out _out270, out _out271);
                        s = _out268;
                        isOwned = _out269;
                        isErased = _out270;
                        readIdents = _out271;
                      }
                    }
                  } else {
                    DAST._IType _642___mcc_h229 = _source33.dtor_Newtype_a0;
                    DAST._IType _643_b = _642___mcc_h229;
                    {
                      if (object.Equals(_465_fromTpe, _643_b)) {
                        Dafny.ISequence<Dafny.Rune> _644_recursiveGen;
                        bool _645_recOwned;
                        bool _646_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _647_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out272;
                        bool _out273;
                        bool _out274;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out275;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out272, out _out273, out _out274, out _out275);
                        _644_recursiveGen = _out272;
                        _645_recOwned = _out273;
                        _646_recErased = _out274;
                        _647_recIdents = _out275;
                        Dafny.ISequence<Dafny.Rune> _648_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out276;
                        _out276 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                        _648_rhsType = _out276;
                        Dafny.ISequence<Dafny.Rune> _649_uneraseFn;
                        _649_uneraseFn = ((_645_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _648_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _649_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _644_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _645_recOwned;
                        isErased = false;
                        readIdents = _647_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out277;
                        bool _out278;
                        bool _out279;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out280;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _643_b), _643_b, _464_toTpe), @params, mustOwn, out _out277, out _out278, out _out279, out _out280);
                        s = _out277;
                        isOwned = _out278;
                        isErased = _out279;
                        readIdents = _out280;
                      }
                    }
                  }
                } else if (_source32.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _650___mcc_h232 = _source32.dtor_Tuple_a0;
                  DAST._IType _651_b = _624___mcc_h211;
                  {
                    if (object.Equals(_651_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _652_recursiveGen;
                      bool _653_recOwned;
                      bool _654_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _655_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out281;
                      bool _out282;
                      bool _out283;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out284;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out281, out _out282, out _out283, out _out284);
                      _652_recursiveGen = _out281;
                      _653_recOwned = _out282;
                      _654_recErased = _out283;
                      _655_recIdents = _out284;
                      Dafny.ISequence<Dafny.Rune> _656_uneraseFn;
                      _656_uneraseFn = ((_653_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _656_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _652_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _653_recOwned;
                      isErased = true;
                      readIdents = _655_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out285;
                      bool _out286;
                      bool _out287;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out288;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _651_b), _651_b, _464_toTpe), @params, mustOwn, out _out285, out _out286, out _out287, out _out288);
                      s = _out285;
                      isOwned = _out286;
                      isErased = _out287;
                      readIdents = _out288;
                    }
                  }
                } else if (_source32.is_Array) {
                  DAST._IType _657___mcc_h235 = _source32.dtor_element;
                  DAST._IType _658_b = _624___mcc_h211;
                  {
                    if (object.Equals(_658_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _659_recursiveGen;
                      bool _660_recOwned;
                      bool _661_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _662_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out289;
                      bool _out290;
                      bool _out291;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out292;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out289, out _out290, out _out291, out _out292);
                      _659_recursiveGen = _out289;
                      _660_recOwned = _out290;
                      _661_recErased = _out291;
                      _662_recIdents = _out292;
                      Dafny.ISequence<Dafny.Rune> _663_uneraseFn;
                      _663_uneraseFn = ((_660_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _663_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _659_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _660_recOwned;
                      isErased = true;
                      readIdents = _662_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out293;
                      bool _out294;
                      bool _out295;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out296;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _658_b), _658_b, _464_toTpe), @params, mustOwn, out _out293, out _out294, out _out295, out _out296);
                      s = _out293;
                      isOwned = _out294;
                      isErased = _out295;
                      readIdents = _out296;
                    }
                  }
                } else if (_source32.is_Seq) {
                  DAST._IType _664___mcc_h238 = _source32.dtor_element;
                  DAST._IType _665_b = _624___mcc_h211;
                  {
                    if (object.Equals(_665_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _666_recursiveGen;
                      bool _667_recOwned;
                      bool _668_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _669_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out297;
                      bool _out298;
                      bool _out299;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out300;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out297, out _out298, out _out299, out _out300);
                      _666_recursiveGen = _out297;
                      _667_recOwned = _out298;
                      _668_recErased = _out299;
                      _669_recIdents = _out300;
                      Dafny.ISequence<Dafny.Rune> _670_uneraseFn;
                      _670_uneraseFn = ((_667_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _670_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _666_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _667_recOwned;
                      isErased = true;
                      readIdents = _669_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out301;
                      bool _out302;
                      bool _out303;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out304;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _665_b), _665_b, _464_toTpe), @params, mustOwn, out _out301, out _out302, out _out303, out _out304);
                      s = _out301;
                      isOwned = _out302;
                      isErased = _out303;
                      readIdents = _out304;
                    }
                  }
                } else if (_source32.is_Set) {
                  DAST._IType _671___mcc_h241 = _source32.dtor_element;
                  DAST._IType _672_b = _624___mcc_h211;
                  {
                    if (object.Equals(_672_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _673_recursiveGen;
                      bool _674_recOwned;
                      bool _675_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _676_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out305;
                      bool _out306;
                      bool _out307;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out308;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out305, out _out306, out _out307, out _out308);
                      _673_recursiveGen = _out305;
                      _674_recOwned = _out306;
                      _675_recErased = _out307;
                      _676_recIdents = _out308;
                      Dafny.ISequence<Dafny.Rune> _677_uneraseFn;
                      _677_uneraseFn = ((_674_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _677_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _673_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _674_recOwned;
                      isErased = true;
                      readIdents = _676_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out309;
                      bool _out310;
                      bool _out311;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out312;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _672_b), _672_b, _464_toTpe), @params, mustOwn, out _out309, out _out310, out _out311, out _out312);
                      s = _out309;
                      isOwned = _out310;
                      isErased = _out311;
                      readIdents = _out312;
                    }
                  }
                } else if (_source32.is_Multiset) {
                  DAST._IType _678___mcc_h244 = _source32.dtor_element;
                  DAST._IType _679_b = _624___mcc_h211;
                  {
                    if (object.Equals(_679_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _680_recursiveGen;
                      bool _681_recOwned;
                      bool _682_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _683_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out313;
                      bool _out314;
                      bool _out315;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out316;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out313, out _out314, out _out315, out _out316);
                      _680_recursiveGen = _out313;
                      _681_recOwned = _out314;
                      _682_recErased = _out315;
                      _683_recIdents = _out316;
                      Dafny.ISequence<Dafny.Rune> _684_uneraseFn;
                      _684_uneraseFn = ((_681_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _684_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _680_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _681_recOwned;
                      isErased = true;
                      readIdents = _683_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out317;
                      bool _out318;
                      bool _out319;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out320;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _679_b), _679_b, _464_toTpe), @params, mustOwn, out _out317, out _out318, out _out319, out _out320);
                      s = _out317;
                      isOwned = _out318;
                      isErased = _out319;
                      readIdents = _out320;
                    }
                  }
                } else if (_source32.is_Map) {
                  DAST._IType _685___mcc_h247 = _source32.dtor_key;
                  DAST._IType _686___mcc_h248 = _source32.dtor_value;
                  DAST._IType _687_b = _624___mcc_h211;
                  {
                    if (object.Equals(_687_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _688_recursiveGen;
                      bool _689_recOwned;
                      bool _690_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _691_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out321;
                      bool _out322;
                      bool _out323;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out324;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out321, out _out322, out _out323, out _out324);
                      _688_recursiveGen = _out321;
                      _689_recOwned = _out322;
                      _690_recErased = _out323;
                      _691_recIdents = _out324;
                      Dafny.ISequence<Dafny.Rune> _692_uneraseFn;
                      _692_uneraseFn = ((_689_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _692_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _688_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _689_recOwned;
                      isErased = true;
                      readIdents = _691_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out325;
                      bool _out326;
                      bool _out327;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out328;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _687_b), _687_b, _464_toTpe), @params, mustOwn, out _out325, out _out326, out _out327, out _out328);
                      s = _out325;
                      isOwned = _out326;
                      isErased = _out327;
                      readIdents = _out328;
                    }
                  }
                } else if (_source32.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _693___mcc_h253 = _source32.dtor_args;
                  DAST._IType _694___mcc_h254 = _source32.dtor_result;
                  DAST._IType _695_b = _624___mcc_h211;
                  {
                    if (object.Equals(_695_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _696_recursiveGen;
                      bool _697_recOwned;
                      bool _698_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _699_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out329;
                      bool _out330;
                      bool _out331;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out332;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out329, out _out330, out _out331, out _out332);
                      _696_recursiveGen = _out329;
                      _697_recOwned = _out330;
                      _698_recErased = _out331;
                      _699_recIdents = _out332;
                      Dafny.ISequence<Dafny.Rune> _700_uneraseFn;
                      _700_uneraseFn = ((_697_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _700_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _696_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _697_recOwned;
                      isErased = true;
                      readIdents = _699_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out333;
                      bool _out334;
                      bool _out335;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out336;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _695_b), _695_b, _464_toTpe), @params, mustOwn, out _out333, out _out334, out _out335, out _out336);
                      s = _out333;
                      isOwned = _out334;
                      isErased = _out335;
                      readIdents = _out336;
                    }
                  }
                } else if (_source32.is_Primitive) {
                  DAST._IPrimitive _701___mcc_h259 = _source32.dtor_Primitive_a0;
                  DAST._IType _702_b = _624___mcc_h211;
                  {
                    if (object.Equals(_702_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _703_recursiveGen;
                      bool _704_recOwned;
                      bool _705_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _706_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out337;
                      bool _out338;
                      bool _out339;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out340;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out337, out _out338, out _out339, out _out340);
                      _703_recursiveGen = _out337;
                      _704_recOwned = _out338;
                      _705_recErased = _out339;
                      _706_recIdents = _out340;
                      Dafny.ISequence<Dafny.Rune> _707_uneraseFn;
                      _707_uneraseFn = ((_704_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _707_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _704_recOwned;
                      isErased = true;
                      readIdents = _706_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out341;
                      bool _out342;
                      bool _out343;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out344;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _702_b), _702_b, _464_toTpe), @params, mustOwn, out _out341, out _out342, out _out343, out _out344);
                      s = _out341;
                      isOwned = _out342;
                      isErased = _out343;
                      readIdents = _out344;
                    }
                  }
                } else if (_source32.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _708___mcc_h262 = _source32.dtor_Passthrough_a0;
                  DAST._IType _709_b = _624___mcc_h211;
                  {
                    if (object.Equals(_709_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _710_recursiveGen;
                      bool _711_recOwned;
                      bool _712_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _713_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out345;
                      bool _out346;
                      bool _out347;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out348;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out345, out _out346, out _out347, out _out348);
                      _710_recursiveGen = _out345;
                      _711_recOwned = _out346;
                      _712_recErased = _out347;
                      _713_recIdents = _out348;
                      Dafny.ISequence<Dafny.Rune> _714_uneraseFn;
                      _714_uneraseFn = ((_711_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _714_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _710_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _711_recOwned;
                      isErased = true;
                      readIdents = _713_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out349;
                      bool _out350;
                      bool _out351;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out352;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _709_b), _709_b, _464_toTpe), @params, mustOwn, out _out349, out _out350, out _out351, out _out352);
                      s = _out349;
                      isOwned = _out350;
                      isErased = _out351;
                      readIdents = _out352;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _715___mcc_h265 = _source32.dtor_TypeArg_a0;
                  DAST._IType _716_b = _624___mcc_h211;
                  {
                    if (object.Equals(_716_b, _464_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _717_recursiveGen;
                      bool _718_recOwned;
                      bool _719_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _720_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out353;
                      bool _out354;
                      bool _out355;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out356;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out353, out _out354, out _out355, out _out356);
                      _717_recursiveGen = _out353;
                      _718_recOwned = _out354;
                      _719_recErased = _out355;
                      _720_recIdents = _out356;
                      Dafny.ISequence<Dafny.Rune> _721_uneraseFn;
                      _721_uneraseFn = ((_718_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _721_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _717_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _718_recOwned;
                      isErased = true;
                      readIdents = _720_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out357;
                      bool _out358;
                      bool _out359;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out360;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _716_b), _716_b, _464_toTpe), @params, mustOwn, out _out357, out _out358, out _out359, out _out360);
                      s = _out357;
                      isOwned = _out358;
                      isErased = _out359;
                      readIdents = _out360;
                    }
                  }
                }
              }
            } else if (_source26.is_Tuple) {
              Dafny.ISequence<DAST._IType> _722___mcc_h268 = _source26.dtor_Tuple_a0;
              DAST._IType _source34 = _472___mcc_h121;
              if (_source34.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _723___mcc_h271 = _source34.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _724___mcc_h272 = _source34.dtor_typeArgs;
                DAST._IResolvedType _725___mcc_h273 = _source34.dtor_resolved;
                DAST._IResolvedType _source35 = _725___mcc_h273;
                if (_source35.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _726___mcc_h277 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _727_recursiveGen;
                    bool _728_recOwned;
                    bool _729_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _730_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out361;
                    bool _out362;
                    bool _out363;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out364;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out361, out _out362, out _out363, out _out364);
                    _727_recursiveGen = _out361;
                    _728_recOwned = _out362;
                    _729_recErased = _out363;
                    _730_recIdents = _out364;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _727_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _728_recOwned;
                    isErased = _729_recErased;
                    readIdents = _730_recIdents;
                  }
                } else if (_source35.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _731___mcc_h279 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _732_recursiveGen;
                    bool _733_recOwned;
                    bool _734_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _735_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out365;
                    bool _out366;
                    bool _out367;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out368;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out365, out _out366, out _out367, out _out368);
                    _732_recursiveGen = _out365;
                    _733_recOwned = _out366;
                    _734_recErased = _out367;
                    _735_recIdents = _out368;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _732_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _733_recOwned;
                    isErased = _734_recErased;
                    readIdents = _735_recIdents;
                  }
                } else {
                  DAST._IType _736___mcc_h281 = _source35.dtor_Newtype_a0;
                  DAST._IType _737_b = _736___mcc_h281;
                  {
                    if (object.Equals(_465_fromTpe, _737_b)) {
                      Dafny.ISequence<Dafny.Rune> _738_recursiveGen;
                      bool _739_recOwned;
                      bool _740_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _741_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out369;
                      bool _out370;
                      bool _out371;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out372;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out369, out _out370, out _out371, out _out372);
                      _738_recursiveGen = _out369;
                      _739_recOwned = _out370;
                      _740_recErased = _out371;
                      _741_recIdents = _out372;
                      Dafny.ISequence<Dafny.Rune> _742_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out373;
                      _out373 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _742_rhsType = _out373;
                      Dafny.ISequence<Dafny.Rune> _743_uneraseFn;
                      _743_uneraseFn = ((_739_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _742_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _743_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _738_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _739_recOwned;
                      isErased = false;
                      readIdents = _741_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out374;
                      bool _out375;
                      bool _out376;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out377;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _737_b), _737_b, _464_toTpe), @params, mustOwn, out _out374, out _out375, out _out376, out _out377);
                      s = _out374;
                      isOwned = _out375;
                      isErased = _out376;
                      readIdents = _out377;
                    }
                  }
                }
              } else if (_source34.is_Tuple) {
                Dafny.ISequence<DAST._IType> _744___mcc_h283 = _source34.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _745_recursiveGen;
                  bool _746_recOwned;
                  bool _747_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _748_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out378;
                  bool _out379;
                  bool _out380;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out381;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out378, out _out379, out _out380, out _out381);
                  _745_recursiveGen = _out378;
                  _746_recOwned = _out379;
                  _747_recErased = _out380;
                  _748_recIdents = _out381;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _745_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _746_recOwned;
                  isErased = _747_recErased;
                  readIdents = _748_recIdents;
                }
              } else if (_source34.is_Array) {
                DAST._IType _749___mcc_h285 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _750_recursiveGen;
                  bool _751_recOwned;
                  bool _752_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _753_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out382;
                  bool _out383;
                  bool _out384;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out385;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out382, out _out383, out _out384, out _out385);
                  _750_recursiveGen = _out382;
                  _751_recOwned = _out383;
                  _752_recErased = _out384;
                  _753_recIdents = _out385;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _750_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _751_recOwned;
                  isErased = _752_recErased;
                  readIdents = _753_recIdents;
                }
              } else if (_source34.is_Seq) {
                DAST._IType _754___mcc_h287 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _755_recursiveGen;
                  bool _756_recOwned;
                  bool _757_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _758_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out386;
                  bool _out387;
                  bool _out388;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out389;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out386, out _out387, out _out388, out _out389);
                  _755_recursiveGen = _out386;
                  _756_recOwned = _out387;
                  _757_recErased = _out388;
                  _758_recIdents = _out389;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _755_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _756_recOwned;
                  isErased = _757_recErased;
                  readIdents = _758_recIdents;
                }
              } else if (_source34.is_Set) {
                DAST._IType _759___mcc_h289 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _760_recursiveGen;
                  bool _761_recOwned;
                  bool _762_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _763_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out390;
                  bool _out391;
                  bool _out392;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out393;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out390, out _out391, out _out392, out _out393);
                  _760_recursiveGen = _out390;
                  _761_recOwned = _out391;
                  _762_recErased = _out392;
                  _763_recIdents = _out393;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _760_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _761_recOwned;
                  isErased = _762_recErased;
                  readIdents = _763_recIdents;
                }
              } else if (_source34.is_Multiset) {
                DAST._IType _764___mcc_h291 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _765_recursiveGen;
                  bool _766_recOwned;
                  bool _767_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _768_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out394;
                  bool _out395;
                  bool _out396;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out397;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out394, out _out395, out _out396, out _out397);
                  _765_recursiveGen = _out394;
                  _766_recOwned = _out395;
                  _767_recErased = _out396;
                  _768_recIdents = _out397;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _765_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _766_recOwned;
                  isErased = _767_recErased;
                  readIdents = _768_recIdents;
                }
              } else if (_source34.is_Map) {
                DAST._IType _769___mcc_h293 = _source34.dtor_key;
                DAST._IType _770___mcc_h294 = _source34.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _771_recursiveGen;
                  bool _772_recOwned;
                  bool _773_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _774_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out398;
                  bool _out399;
                  bool _out400;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out401;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out398, out _out399, out _out400, out _out401);
                  _771_recursiveGen = _out398;
                  _772_recOwned = _out399;
                  _773_recErased = _out400;
                  _774_recIdents = _out401;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _771_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _772_recOwned;
                  isErased = _773_recErased;
                  readIdents = _774_recIdents;
                }
              } else if (_source34.is_Arrow) {
                Dafny.ISequence<DAST._IType> _775___mcc_h297 = _source34.dtor_args;
                DAST._IType _776___mcc_h298 = _source34.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _777_recursiveGen;
                  bool _778_recOwned;
                  bool _779_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _780_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out402;
                  bool _out403;
                  bool _out404;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out405;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out402, out _out403, out _out404, out _out405);
                  _777_recursiveGen = _out402;
                  _778_recOwned = _out403;
                  _779_recErased = _out404;
                  _780_recIdents = _out405;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _777_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _778_recOwned;
                  isErased = _779_recErased;
                  readIdents = _780_recIdents;
                }
              } else if (_source34.is_Primitive) {
                DAST._IPrimitive _781___mcc_h301 = _source34.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _782_recursiveGen;
                  bool _783_recOwned;
                  bool _784_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _785_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out406;
                  bool _out407;
                  bool _out408;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out409;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out406, out _out407, out _out408, out _out409);
                  _782_recursiveGen = _out406;
                  _783_recOwned = _out407;
                  _784_recErased = _out408;
                  _785_recIdents = _out409;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _782_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _783_recOwned;
                  isErased = _784_recErased;
                  readIdents = _785_recIdents;
                }
              } else if (_source34.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _786___mcc_h303 = _source34.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _787_recursiveGen;
                  bool _788_recOwned;
                  bool _789_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _790_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out410;
                  bool _out411;
                  bool _out412;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out413;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out410, out _out411, out _out412, out _out413);
                  _787_recursiveGen = _out410;
                  _788_recOwned = _out411;
                  _789_recErased = _out412;
                  _790_recIdents = _out413;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _787_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _788_recOwned;
                  isErased = _789_recErased;
                  readIdents = _790_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _791___mcc_h305 = _source34.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _792_recursiveGen;
                  bool _793_recOwned;
                  bool _794_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _795_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out414;
                  bool _out415;
                  bool _out416;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out417;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out414, out _out415, out _out416, out _out417);
                  _792_recursiveGen = _out414;
                  _793_recOwned = _out415;
                  _794_recErased = _out416;
                  _795_recIdents = _out417;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _792_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _793_recOwned;
                  isErased = _794_recErased;
                  readIdents = _795_recIdents;
                }
              }
            } else if (_source26.is_Array) {
              DAST._IType _796___mcc_h307 = _source26.dtor_element;
              DAST._IType _source36 = _472___mcc_h121;
              if (_source36.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _797___mcc_h310 = _source36.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _798___mcc_h311 = _source36.dtor_typeArgs;
                DAST._IResolvedType _799___mcc_h312 = _source36.dtor_resolved;
                DAST._IResolvedType _source37 = _799___mcc_h312;
                if (_source37.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _800___mcc_h316 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _801_recursiveGen;
                    bool _802_recOwned;
                    bool _803_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _804_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out418;
                    bool _out419;
                    bool _out420;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out421;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out418, out _out419, out _out420, out _out421);
                    _801_recursiveGen = _out418;
                    _802_recOwned = _out419;
                    _803_recErased = _out420;
                    _804_recIdents = _out421;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _801_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _802_recOwned;
                    isErased = _803_recErased;
                    readIdents = _804_recIdents;
                  }
                } else if (_source37.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _805___mcc_h318 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _806_recursiveGen;
                    bool _807_recOwned;
                    bool _808_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _809_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out422;
                    bool _out423;
                    bool _out424;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out425;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out422, out _out423, out _out424, out _out425);
                    _806_recursiveGen = _out422;
                    _807_recOwned = _out423;
                    _808_recErased = _out424;
                    _809_recIdents = _out425;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _806_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _807_recOwned;
                    isErased = _808_recErased;
                    readIdents = _809_recIdents;
                  }
                } else {
                  DAST._IType _810___mcc_h320 = _source37.dtor_Newtype_a0;
                  DAST._IType _811_b = _810___mcc_h320;
                  {
                    if (object.Equals(_465_fromTpe, _811_b)) {
                      Dafny.ISequence<Dafny.Rune> _812_recursiveGen;
                      bool _813_recOwned;
                      bool _814_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _815_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out426;
                      bool _out427;
                      bool _out428;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out429;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out426, out _out427, out _out428, out _out429);
                      _812_recursiveGen = _out426;
                      _813_recOwned = _out427;
                      _814_recErased = _out428;
                      _815_recIdents = _out429;
                      Dafny.ISequence<Dafny.Rune> _816_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out430;
                      _out430 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _816_rhsType = _out430;
                      Dafny.ISequence<Dafny.Rune> _817_uneraseFn;
                      _817_uneraseFn = ((_813_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _816_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _817_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _812_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _813_recOwned;
                      isErased = false;
                      readIdents = _815_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out431;
                      bool _out432;
                      bool _out433;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out434;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _811_b), _811_b, _464_toTpe), @params, mustOwn, out _out431, out _out432, out _out433, out _out434);
                      s = _out431;
                      isOwned = _out432;
                      isErased = _out433;
                      readIdents = _out434;
                    }
                  }
                }
              } else if (_source36.is_Tuple) {
                Dafny.ISequence<DAST._IType> _818___mcc_h322 = _source36.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _819_recursiveGen;
                  bool _820_recOwned;
                  bool _821_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _822_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out435;
                  bool _out436;
                  bool _out437;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out438;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out435, out _out436, out _out437, out _out438);
                  _819_recursiveGen = _out435;
                  _820_recOwned = _out436;
                  _821_recErased = _out437;
                  _822_recIdents = _out438;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _819_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _820_recOwned;
                  isErased = _821_recErased;
                  readIdents = _822_recIdents;
                }
              } else if (_source36.is_Array) {
                DAST._IType _823___mcc_h324 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _824_recursiveGen;
                  bool _825_recOwned;
                  bool _826_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _827_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out439;
                  bool _out440;
                  bool _out441;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out442;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out439, out _out440, out _out441, out _out442);
                  _824_recursiveGen = _out439;
                  _825_recOwned = _out440;
                  _826_recErased = _out441;
                  _827_recIdents = _out442;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _824_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _825_recOwned;
                  isErased = _826_recErased;
                  readIdents = _827_recIdents;
                }
              } else if (_source36.is_Seq) {
                DAST._IType _828___mcc_h326 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _829_recursiveGen;
                  bool _830_recOwned;
                  bool _831_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _832_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out443;
                  bool _out444;
                  bool _out445;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out446;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out443, out _out444, out _out445, out _out446);
                  _829_recursiveGen = _out443;
                  _830_recOwned = _out444;
                  _831_recErased = _out445;
                  _832_recIdents = _out446;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _829_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _830_recOwned;
                  isErased = _831_recErased;
                  readIdents = _832_recIdents;
                }
              } else if (_source36.is_Set) {
                DAST._IType _833___mcc_h328 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _834_recursiveGen;
                  bool _835_recOwned;
                  bool _836_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _837_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out447;
                  bool _out448;
                  bool _out449;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out450;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out447, out _out448, out _out449, out _out450);
                  _834_recursiveGen = _out447;
                  _835_recOwned = _out448;
                  _836_recErased = _out449;
                  _837_recIdents = _out450;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _834_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _835_recOwned;
                  isErased = _836_recErased;
                  readIdents = _837_recIdents;
                }
              } else if (_source36.is_Multiset) {
                DAST._IType _838___mcc_h330 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _839_recursiveGen;
                  bool _840_recOwned;
                  bool _841_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _842_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out451;
                  bool _out452;
                  bool _out453;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out454;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out451, out _out452, out _out453, out _out454);
                  _839_recursiveGen = _out451;
                  _840_recOwned = _out452;
                  _841_recErased = _out453;
                  _842_recIdents = _out454;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _839_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _840_recOwned;
                  isErased = _841_recErased;
                  readIdents = _842_recIdents;
                }
              } else if (_source36.is_Map) {
                DAST._IType _843___mcc_h332 = _source36.dtor_key;
                DAST._IType _844___mcc_h333 = _source36.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _845_recursiveGen;
                  bool _846_recOwned;
                  bool _847_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _848_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out455;
                  bool _out456;
                  bool _out457;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out458;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out455, out _out456, out _out457, out _out458);
                  _845_recursiveGen = _out455;
                  _846_recOwned = _out456;
                  _847_recErased = _out457;
                  _848_recIdents = _out458;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _845_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _846_recOwned;
                  isErased = _847_recErased;
                  readIdents = _848_recIdents;
                }
              } else if (_source36.is_Arrow) {
                Dafny.ISequence<DAST._IType> _849___mcc_h336 = _source36.dtor_args;
                DAST._IType _850___mcc_h337 = _source36.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _851_recursiveGen;
                  bool _852_recOwned;
                  bool _853_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _854_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out459;
                  bool _out460;
                  bool _out461;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out462;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out459, out _out460, out _out461, out _out462);
                  _851_recursiveGen = _out459;
                  _852_recOwned = _out460;
                  _853_recErased = _out461;
                  _854_recIdents = _out462;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _851_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _852_recOwned;
                  isErased = _853_recErased;
                  readIdents = _854_recIdents;
                }
              } else if (_source36.is_Primitive) {
                DAST._IPrimitive _855___mcc_h340 = _source36.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _856_recursiveGen;
                  bool _857_recOwned;
                  bool _858_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _859_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out463;
                  bool _out464;
                  bool _out465;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out466;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out463, out _out464, out _out465, out _out466);
                  _856_recursiveGen = _out463;
                  _857_recOwned = _out464;
                  _858_recErased = _out465;
                  _859_recIdents = _out466;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _856_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _857_recOwned;
                  isErased = _858_recErased;
                  readIdents = _859_recIdents;
                }
              } else if (_source36.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _860___mcc_h342 = _source36.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _861_recursiveGen;
                  bool _862_recOwned;
                  bool _863_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _864_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out467;
                  bool _out468;
                  bool _out469;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out470;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out467, out _out468, out _out469, out _out470);
                  _861_recursiveGen = _out467;
                  _862_recOwned = _out468;
                  _863_recErased = _out469;
                  _864_recIdents = _out470;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _861_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _862_recOwned;
                  isErased = _863_recErased;
                  readIdents = _864_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _865___mcc_h344 = _source36.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _866_recursiveGen;
                  bool _867_recOwned;
                  bool _868_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _869_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out471;
                  bool _out472;
                  bool _out473;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out474;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out471, out _out472, out _out473, out _out474);
                  _866_recursiveGen = _out471;
                  _867_recOwned = _out472;
                  _868_recErased = _out473;
                  _869_recIdents = _out474;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _866_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _867_recOwned;
                  isErased = _868_recErased;
                  readIdents = _869_recIdents;
                }
              }
            } else if (_source26.is_Seq) {
              DAST._IType _870___mcc_h346 = _source26.dtor_element;
              DAST._IType _source38 = _472___mcc_h121;
              if (_source38.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _871___mcc_h349 = _source38.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _872___mcc_h350 = _source38.dtor_typeArgs;
                DAST._IResolvedType _873___mcc_h351 = _source38.dtor_resolved;
                DAST._IResolvedType _source39 = _873___mcc_h351;
                if (_source39.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _874___mcc_h355 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _875_recursiveGen;
                    bool _876_recOwned;
                    bool _877_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _878_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out475;
                    bool _out476;
                    bool _out477;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out478;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out475, out _out476, out _out477, out _out478);
                    _875_recursiveGen = _out475;
                    _876_recOwned = _out476;
                    _877_recErased = _out477;
                    _878_recIdents = _out478;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _875_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _876_recOwned;
                    isErased = _877_recErased;
                    readIdents = _878_recIdents;
                  }
                } else if (_source39.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _879___mcc_h357 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _880_recursiveGen;
                    bool _881_recOwned;
                    bool _882_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _883_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out479;
                    bool _out480;
                    bool _out481;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out482;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out479, out _out480, out _out481, out _out482);
                    _880_recursiveGen = _out479;
                    _881_recOwned = _out480;
                    _882_recErased = _out481;
                    _883_recIdents = _out482;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _880_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _881_recOwned;
                    isErased = _882_recErased;
                    readIdents = _883_recIdents;
                  }
                } else {
                  DAST._IType _884___mcc_h359 = _source39.dtor_Newtype_a0;
                  DAST._IType _885_b = _884___mcc_h359;
                  {
                    if (object.Equals(_465_fromTpe, _885_b)) {
                      Dafny.ISequence<Dafny.Rune> _886_recursiveGen;
                      bool _887_recOwned;
                      bool _888_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _889_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out483;
                      bool _out484;
                      bool _out485;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out486;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out483, out _out484, out _out485, out _out486);
                      _886_recursiveGen = _out483;
                      _887_recOwned = _out484;
                      _888_recErased = _out485;
                      _889_recIdents = _out486;
                      Dafny.ISequence<Dafny.Rune> _890_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out487;
                      _out487 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _890_rhsType = _out487;
                      Dafny.ISequence<Dafny.Rune> _891_uneraseFn;
                      _891_uneraseFn = ((_887_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _890_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _891_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _886_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _887_recOwned;
                      isErased = false;
                      readIdents = _889_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out488;
                      bool _out489;
                      bool _out490;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out491;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _885_b), _885_b, _464_toTpe), @params, mustOwn, out _out488, out _out489, out _out490, out _out491);
                      s = _out488;
                      isOwned = _out489;
                      isErased = _out490;
                      readIdents = _out491;
                    }
                  }
                }
              } else if (_source38.is_Tuple) {
                Dafny.ISequence<DAST._IType> _892___mcc_h361 = _source38.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _893_recursiveGen;
                  bool _894_recOwned;
                  bool _895_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _896_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out492;
                  bool _out493;
                  bool _out494;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out495;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out492, out _out493, out _out494, out _out495);
                  _893_recursiveGen = _out492;
                  _894_recOwned = _out493;
                  _895_recErased = _out494;
                  _896_recIdents = _out495;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _893_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _894_recOwned;
                  isErased = _895_recErased;
                  readIdents = _896_recIdents;
                }
              } else if (_source38.is_Array) {
                DAST._IType _897___mcc_h363 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _898_recursiveGen;
                  bool _899_recOwned;
                  bool _900_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _901_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out496;
                  bool _out497;
                  bool _out498;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out499;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out496, out _out497, out _out498, out _out499);
                  _898_recursiveGen = _out496;
                  _899_recOwned = _out497;
                  _900_recErased = _out498;
                  _901_recIdents = _out499;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _898_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _899_recOwned;
                  isErased = _900_recErased;
                  readIdents = _901_recIdents;
                }
              } else if (_source38.is_Seq) {
                DAST._IType _902___mcc_h365 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _903_recursiveGen;
                  bool _904_recOwned;
                  bool _905_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _906_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out500;
                  bool _out501;
                  bool _out502;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out503;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out500, out _out501, out _out502, out _out503);
                  _903_recursiveGen = _out500;
                  _904_recOwned = _out501;
                  _905_recErased = _out502;
                  _906_recIdents = _out503;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _903_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _904_recOwned;
                  isErased = _905_recErased;
                  readIdents = _906_recIdents;
                }
              } else if (_source38.is_Set) {
                DAST._IType _907___mcc_h367 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _908_recursiveGen;
                  bool _909_recOwned;
                  bool _910_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _911_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out504;
                  bool _out505;
                  bool _out506;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out507;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out504, out _out505, out _out506, out _out507);
                  _908_recursiveGen = _out504;
                  _909_recOwned = _out505;
                  _910_recErased = _out506;
                  _911_recIdents = _out507;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _908_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _909_recOwned;
                  isErased = _910_recErased;
                  readIdents = _911_recIdents;
                }
              } else if (_source38.is_Multiset) {
                DAST._IType _912___mcc_h369 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _913_recursiveGen;
                  bool _914_recOwned;
                  bool _915_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _916_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out508;
                  bool _out509;
                  bool _out510;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out511;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out508, out _out509, out _out510, out _out511);
                  _913_recursiveGen = _out508;
                  _914_recOwned = _out509;
                  _915_recErased = _out510;
                  _916_recIdents = _out511;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _913_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _914_recOwned;
                  isErased = _915_recErased;
                  readIdents = _916_recIdents;
                }
              } else if (_source38.is_Map) {
                DAST._IType _917___mcc_h371 = _source38.dtor_key;
                DAST._IType _918___mcc_h372 = _source38.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _919_recursiveGen;
                  bool _920_recOwned;
                  bool _921_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _922_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out512;
                  bool _out513;
                  bool _out514;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out515;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out512, out _out513, out _out514, out _out515);
                  _919_recursiveGen = _out512;
                  _920_recOwned = _out513;
                  _921_recErased = _out514;
                  _922_recIdents = _out515;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _919_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _920_recOwned;
                  isErased = _921_recErased;
                  readIdents = _922_recIdents;
                }
              } else if (_source38.is_Arrow) {
                Dafny.ISequence<DAST._IType> _923___mcc_h375 = _source38.dtor_args;
                DAST._IType _924___mcc_h376 = _source38.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _925_recursiveGen;
                  bool _926_recOwned;
                  bool _927_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _928_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out516;
                  bool _out517;
                  bool _out518;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out519;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out516, out _out517, out _out518, out _out519);
                  _925_recursiveGen = _out516;
                  _926_recOwned = _out517;
                  _927_recErased = _out518;
                  _928_recIdents = _out519;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _926_recOwned;
                  isErased = _927_recErased;
                  readIdents = _928_recIdents;
                }
              } else if (_source38.is_Primitive) {
                DAST._IPrimitive _929___mcc_h379 = _source38.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _930_recursiveGen;
                  bool _931_recOwned;
                  bool _932_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _933_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out520;
                  bool _out521;
                  bool _out522;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out523;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out520, out _out521, out _out522, out _out523);
                  _930_recursiveGen = _out520;
                  _931_recOwned = _out521;
                  _932_recErased = _out522;
                  _933_recIdents = _out523;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _931_recOwned;
                  isErased = _932_recErased;
                  readIdents = _933_recIdents;
                }
              } else if (_source38.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _934___mcc_h381 = _source38.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _935_recursiveGen;
                  bool _936_recOwned;
                  bool _937_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _938_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out524;
                  bool _out525;
                  bool _out526;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out527;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out524, out _out525, out _out526, out _out527);
                  _935_recursiveGen = _out524;
                  _936_recOwned = _out525;
                  _937_recErased = _out526;
                  _938_recIdents = _out527;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _935_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _936_recOwned;
                  isErased = _937_recErased;
                  readIdents = _938_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _939___mcc_h383 = _source38.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _940_recursiveGen;
                  bool _941_recOwned;
                  bool _942_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _943_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out528;
                  bool _out529;
                  bool _out530;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out531;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out528, out _out529, out _out530, out _out531);
                  _940_recursiveGen = _out528;
                  _941_recOwned = _out529;
                  _942_recErased = _out530;
                  _943_recIdents = _out531;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _940_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _941_recOwned;
                  isErased = _942_recErased;
                  readIdents = _943_recIdents;
                }
              }
            } else if (_source26.is_Set) {
              DAST._IType _944___mcc_h385 = _source26.dtor_element;
              DAST._IType _source40 = _472___mcc_h121;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _945___mcc_h388 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _946___mcc_h389 = _source40.dtor_typeArgs;
                DAST._IResolvedType _947___mcc_h390 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _947___mcc_h390;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _948___mcc_h394 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _949_recursiveGen;
                    bool _950_recOwned;
                    bool _951_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _952_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out532;
                    bool _out533;
                    bool _out534;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out535;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out532, out _out533, out _out534, out _out535);
                    _949_recursiveGen = _out532;
                    _950_recOwned = _out533;
                    _951_recErased = _out534;
                    _952_recIdents = _out535;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _949_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _950_recOwned;
                    isErased = _951_recErased;
                    readIdents = _952_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _953___mcc_h396 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _954_recursiveGen;
                    bool _955_recOwned;
                    bool _956_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _957_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out536;
                    bool _out537;
                    bool _out538;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out539;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out536, out _out537, out _out538, out _out539);
                    _954_recursiveGen = _out536;
                    _955_recOwned = _out537;
                    _956_recErased = _out538;
                    _957_recIdents = _out539;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _954_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _955_recOwned;
                    isErased = _956_recErased;
                    readIdents = _957_recIdents;
                  }
                } else {
                  DAST._IType _958___mcc_h398 = _source41.dtor_Newtype_a0;
                  DAST._IType _959_b = _958___mcc_h398;
                  {
                    if (object.Equals(_465_fromTpe, _959_b)) {
                      Dafny.ISequence<Dafny.Rune> _960_recursiveGen;
                      bool _961_recOwned;
                      bool _962_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _963_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out540;
                      bool _out541;
                      bool _out542;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out543;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out540, out _out541, out _out542, out _out543);
                      _960_recursiveGen = _out540;
                      _961_recOwned = _out541;
                      _962_recErased = _out542;
                      _963_recIdents = _out543;
                      Dafny.ISequence<Dafny.Rune> _964_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out544;
                      _out544 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _964_rhsType = _out544;
                      Dafny.ISequence<Dafny.Rune> _965_uneraseFn;
                      _965_uneraseFn = ((_961_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _964_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _965_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _960_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _961_recOwned;
                      isErased = false;
                      readIdents = _963_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out545;
                      bool _out546;
                      bool _out547;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out548;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _959_b), _959_b, _464_toTpe), @params, mustOwn, out _out545, out _out546, out _out547, out _out548);
                      s = _out545;
                      isOwned = _out546;
                      isErased = _out547;
                      readIdents = _out548;
                    }
                  }
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _966___mcc_h400 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _967_recursiveGen;
                  bool _968_recOwned;
                  bool _969_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _970_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out549;
                  bool _out550;
                  bool _out551;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out552;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out549, out _out550, out _out551, out _out552);
                  _967_recursiveGen = _out549;
                  _968_recOwned = _out550;
                  _969_recErased = _out551;
                  _970_recIdents = _out552;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _967_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _968_recOwned;
                  isErased = _969_recErased;
                  readIdents = _970_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _971___mcc_h402 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _972_recursiveGen;
                  bool _973_recOwned;
                  bool _974_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _975_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out553;
                  bool _out554;
                  bool _out555;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out556;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out553, out _out554, out _out555, out _out556);
                  _972_recursiveGen = _out553;
                  _973_recOwned = _out554;
                  _974_recErased = _out555;
                  _975_recIdents = _out556;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _972_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _973_recOwned;
                  isErased = _974_recErased;
                  readIdents = _975_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _976___mcc_h404 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _977_recursiveGen;
                  bool _978_recOwned;
                  bool _979_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _980_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out557;
                  bool _out558;
                  bool _out559;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out560;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out557, out _out558, out _out559, out _out560);
                  _977_recursiveGen = _out557;
                  _978_recOwned = _out558;
                  _979_recErased = _out559;
                  _980_recIdents = _out560;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _977_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _978_recOwned;
                  isErased = _979_recErased;
                  readIdents = _980_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _981___mcc_h406 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _982_recursiveGen;
                  bool _983_recOwned;
                  bool _984_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _985_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out561;
                  bool _out562;
                  bool _out563;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out564;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out561, out _out562, out _out563, out _out564);
                  _982_recursiveGen = _out561;
                  _983_recOwned = _out562;
                  _984_recErased = _out563;
                  _985_recIdents = _out564;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _982_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _983_recOwned;
                  isErased = _984_recErased;
                  readIdents = _985_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _986___mcc_h408 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _987_recursiveGen;
                  bool _988_recOwned;
                  bool _989_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _990_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out565;
                  bool _out566;
                  bool _out567;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out568;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out565, out _out566, out _out567, out _out568);
                  _987_recursiveGen = _out565;
                  _988_recOwned = _out566;
                  _989_recErased = _out567;
                  _990_recIdents = _out568;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _987_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _988_recOwned;
                  isErased = _989_recErased;
                  readIdents = _990_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _991___mcc_h410 = _source40.dtor_key;
                DAST._IType _992___mcc_h411 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _993_recursiveGen;
                  bool _994_recOwned;
                  bool _995_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _996_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out569;
                  bool _out570;
                  bool _out571;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out572;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out569, out _out570, out _out571, out _out572);
                  _993_recursiveGen = _out569;
                  _994_recOwned = _out570;
                  _995_recErased = _out571;
                  _996_recIdents = _out572;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _993_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _994_recOwned;
                  isErased = _995_recErased;
                  readIdents = _996_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _997___mcc_h414 = _source40.dtor_args;
                DAST._IType _998___mcc_h415 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _999_recursiveGen;
                  bool _1000_recOwned;
                  bool _1001_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1002_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out573;
                  bool _out574;
                  bool _out575;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out576;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out573, out _out574, out _out575, out _out576);
                  _999_recursiveGen = _out573;
                  _1000_recOwned = _out574;
                  _1001_recErased = _out575;
                  _1002_recIdents = _out576;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _999_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1000_recOwned;
                  isErased = _1001_recErased;
                  readIdents = _1002_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _1003___mcc_h418 = _source40.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1004_recursiveGen;
                  bool _1005_recOwned;
                  bool _1006_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1007_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out577;
                  bool _out578;
                  bool _out579;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out580;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out577, out _out578, out _out579, out _out580);
                  _1004_recursiveGen = _out577;
                  _1005_recOwned = _out578;
                  _1006_recErased = _out579;
                  _1007_recIdents = _out580;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1004_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1005_recOwned;
                  isErased = _1006_recErased;
                  readIdents = _1007_recIdents;
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1008___mcc_h420 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1009_recursiveGen;
                  bool _1010_recOwned;
                  bool _1011_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1012_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out581;
                  bool _out582;
                  bool _out583;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out584;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out581, out _out582, out _out583, out _out584);
                  _1009_recursiveGen = _out581;
                  _1010_recOwned = _out582;
                  _1011_recErased = _out583;
                  _1012_recIdents = _out584;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1010_recOwned;
                  isErased = _1011_recErased;
                  readIdents = _1012_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1013___mcc_h422 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1014_recursiveGen;
                  bool _1015_recOwned;
                  bool _1016_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1017_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out585;
                  bool _out586;
                  bool _out587;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out588;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out585, out _out586, out _out587, out _out588);
                  _1014_recursiveGen = _out585;
                  _1015_recOwned = _out586;
                  _1016_recErased = _out587;
                  _1017_recIdents = _out588;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1014_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1015_recOwned;
                  isErased = _1016_recErased;
                  readIdents = _1017_recIdents;
                }
              }
            } else if (_source26.is_Multiset) {
              DAST._IType _1018___mcc_h424 = _source26.dtor_element;
              DAST._IType _source42 = _472___mcc_h121;
              if (_source42.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1019___mcc_h427 = _source42.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1020___mcc_h428 = _source42.dtor_typeArgs;
                DAST._IResolvedType _1021___mcc_h429 = _source42.dtor_resolved;
                DAST._IResolvedType _source43 = _1021___mcc_h429;
                if (_source43.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1022___mcc_h433 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1023_recursiveGen;
                    bool _1024_recOwned;
                    bool _1025_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1026_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out589;
                    bool _out590;
                    bool _out591;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out592;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out589, out _out590, out _out591, out _out592);
                    _1023_recursiveGen = _out589;
                    _1024_recOwned = _out590;
                    _1025_recErased = _out591;
                    _1026_recIdents = _out592;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1023_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1024_recOwned;
                    isErased = _1025_recErased;
                    readIdents = _1026_recIdents;
                  }
                } else if (_source43.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1027___mcc_h435 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1028_recursiveGen;
                    bool _1029_recOwned;
                    bool _1030_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1031_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out593;
                    bool _out594;
                    bool _out595;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out596;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out593, out _out594, out _out595, out _out596);
                    _1028_recursiveGen = _out593;
                    _1029_recOwned = _out594;
                    _1030_recErased = _out595;
                    _1031_recIdents = _out596;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1028_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1029_recOwned;
                    isErased = _1030_recErased;
                    readIdents = _1031_recIdents;
                  }
                } else {
                  DAST._IType _1032___mcc_h437 = _source43.dtor_Newtype_a0;
                  DAST._IType _1033_b = _1032___mcc_h437;
                  {
                    if (object.Equals(_465_fromTpe, _1033_b)) {
                      Dafny.ISequence<Dafny.Rune> _1034_recursiveGen;
                      bool _1035_recOwned;
                      bool _1036_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1037_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out597;
                      bool _out598;
                      bool _out599;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out600;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out597, out _out598, out _out599, out _out600);
                      _1034_recursiveGen = _out597;
                      _1035_recOwned = _out598;
                      _1036_recErased = _out599;
                      _1037_recIdents = _out600;
                      Dafny.ISequence<Dafny.Rune> _1038_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out601;
                      _out601 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _1038_rhsType = _out601;
                      Dafny.ISequence<Dafny.Rune> _1039_uneraseFn;
                      _1039_uneraseFn = ((_1035_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1038_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1039_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1034_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1035_recOwned;
                      isErased = false;
                      readIdents = _1037_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out602;
                      bool _out603;
                      bool _out604;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out605;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1033_b), _1033_b, _464_toTpe), @params, mustOwn, out _out602, out _out603, out _out604, out _out605);
                      s = _out602;
                      isOwned = _out603;
                      isErased = _out604;
                      readIdents = _out605;
                    }
                  }
                }
              } else if (_source42.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1040___mcc_h439 = _source42.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1041_recursiveGen;
                  bool _1042_recOwned;
                  bool _1043_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1044_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out606;
                  bool _out607;
                  bool _out608;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out609;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out606, out _out607, out _out608, out _out609);
                  _1041_recursiveGen = _out606;
                  _1042_recOwned = _out607;
                  _1043_recErased = _out608;
                  _1044_recIdents = _out609;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1041_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1042_recOwned;
                  isErased = _1043_recErased;
                  readIdents = _1044_recIdents;
                }
              } else if (_source42.is_Array) {
                DAST._IType _1045___mcc_h441 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1046_recursiveGen;
                  bool _1047_recOwned;
                  bool _1048_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1049_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out610;
                  bool _out611;
                  bool _out612;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out613;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out610, out _out611, out _out612, out _out613);
                  _1046_recursiveGen = _out610;
                  _1047_recOwned = _out611;
                  _1048_recErased = _out612;
                  _1049_recIdents = _out613;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1046_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1047_recOwned;
                  isErased = _1048_recErased;
                  readIdents = _1049_recIdents;
                }
              } else if (_source42.is_Seq) {
                DAST._IType _1050___mcc_h443 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1051_recursiveGen;
                  bool _1052_recOwned;
                  bool _1053_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1054_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out614;
                  bool _out615;
                  bool _out616;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out617;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out614, out _out615, out _out616, out _out617);
                  _1051_recursiveGen = _out614;
                  _1052_recOwned = _out615;
                  _1053_recErased = _out616;
                  _1054_recIdents = _out617;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1051_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1052_recOwned;
                  isErased = _1053_recErased;
                  readIdents = _1054_recIdents;
                }
              } else if (_source42.is_Set) {
                DAST._IType _1055___mcc_h445 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1056_recursiveGen;
                  bool _1057_recOwned;
                  bool _1058_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1059_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out618;
                  bool _out619;
                  bool _out620;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out621;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out618, out _out619, out _out620, out _out621);
                  _1056_recursiveGen = _out618;
                  _1057_recOwned = _out619;
                  _1058_recErased = _out620;
                  _1059_recIdents = _out621;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1056_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1057_recOwned;
                  isErased = _1058_recErased;
                  readIdents = _1059_recIdents;
                }
              } else if (_source42.is_Multiset) {
                DAST._IType _1060___mcc_h447 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1061_recursiveGen;
                  bool _1062_recOwned;
                  bool _1063_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1064_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out622;
                  bool _out623;
                  bool _out624;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out625;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out622, out _out623, out _out624, out _out625);
                  _1061_recursiveGen = _out622;
                  _1062_recOwned = _out623;
                  _1063_recErased = _out624;
                  _1064_recIdents = _out625;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1061_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1062_recOwned;
                  isErased = _1063_recErased;
                  readIdents = _1064_recIdents;
                }
              } else if (_source42.is_Map) {
                DAST._IType _1065___mcc_h449 = _source42.dtor_key;
                DAST._IType _1066___mcc_h450 = _source42.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1067_recursiveGen;
                  bool _1068_recOwned;
                  bool _1069_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1070_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out626;
                  bool _out627;
                  bool _out628;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out629;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out626, out _out627, out _out628, out _out629);
                  _1067_recursiveGen = _out626;
                  _1068_recOwned = _out627;
                  _1069_recErased = _out628;
                  _1070_recIdents = _out629;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1067_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1068_recOwned;
                  isErased = _1069_recErased;
                  readIdents = _1070_recIdents;
                }
              } else if (_source42.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1071___mcc_h453 = _source42.dtor_args;
                DAST._IType _1072___mcc_h454 = _source42.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1073_recursiveGen;
                  bool _1074_recOwned;
                  bool _1075_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1076_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out630;
                  bool _out631;
                  bool _out632;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out633;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out630, out _out631, out _out632, out _out633);
                  _1073_recursiveGen = _out630;
                  _1074_recOwned = _out631;
                  _1075_recErased = _out632;
                  _1076_recIdents = _out633;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1073_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1074_recOwned;
                  isErased = _1075_recErased;
                  readIdents = _1076_recIdents;
                }
              } else if (_source42.is_Primitive) {
                DAST._IPrimitive _1077___mcc_h457 = _source42.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1078_recursiveGen;
                  bool _1079_recOwned;
                  bool _1080_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1081_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out634;
                  bool _out635;
                  bool _out636;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out637;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out634, out _out635, out _out636, out _out637);
                  _1078_recursiveGen = _out634;
                  _1079_recOwned = _out635;
                  _1080_recErased = _out636;
                  _1081_recIdents = _out637;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1078_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1079_recOwned;
                  isErased = _1080_recErased;
                  readIdents = _1081_recIdents;
                }
              } else if (_source42.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1082___mcc_h459 = _source42.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1083_recursiveGen;
                  bool _1084_recOwned;
                  bool _1085_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1086_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out638;
                  bool _out639;
                  bool _out640;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out641;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out638, out _out639, out _out640, out _out641);
                  _1083_recursiveGen = _out638;
                  _1084_recOwned = _out639;
                  _1085_recErased = _out640;
                  _1086_recIdents = _out641;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1083_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1084_recOwned;
                  isErased = _1085_recErased;
                  readIdents = _1086_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1087___mcc_h461 = _source42.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1088_recursiveGen;
                  bool _1089_recOwned;
                  bool _1090_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1091_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out642;
                  bool _out643;
                  bool _out644;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out645;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out642, out _out643, out _out644, out _out645);
                  _1088_recursiveGen = _out642;
                  _1089_recOwned = _out643;
                  _1090_recErased = _out644;
                  _1091_recIdents = _out645;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1088_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1089_recOwned;
                  isErased = _1090_recErased;
                  readIdents = _1091_recIdents;
                }
              }
            } else if (_source26.is_Map) {
              DAST._IType _1092___mcc_h463 = _source26.dtor_key;
              DAST._IType _1093___mcc_h464 = _source26.dtor_value;
              DAST._IType _source44 = _472___mcc_h121;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1094___mcc_h469 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1095___mcc_h470 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1096___mcc_h471 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1096___mcc_h471;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1097___mcc_h475 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1098_recursiveGen;
                    bool _1099_recOwned;
                    bool _1100_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1101_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out646;
                    bool _out647;
                    bool _out648;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out649;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out646, out _out647, out _out648, out _out649);
                    _1098_recursiveGen = _out646;
                    _1099_recOwned = _out647;
                    _1100_recErased = _out648;
                    _1101_recIdents = _out649;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1098_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1099_recOwned;
                    isErased = _1100_recErased;
                    readIdents = _1101_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1102___mcc_h477 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1103_recursiveGen;
                    bool _1104_recOwned;
                    bool _1105_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1106_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out650;
                    bool _out651;
                    bool _out652;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out653;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out650, out _out651, out _out652, out _out653);
                    _1103_recursiveGen = _out650;
                    _1104_recOwned = _out651;
                    _1105_recErased = _out652;
                    _1106_recIdents = _out653;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1103_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1104_recOwned;
                    isErased = _1105_recErased;
                    readIdents = _1106_recIdents;
                  }
                } else {
                  DAST._IType _1107___mcc_h479 = _source45.dtor_Newtype_a0;
                  DAST._IType _1108_b = _1107___mcc_h479;
                  {
                    if (object.Equals(_465_fromTpe, _1108_b)) {
                      Dafny.ISequence<Dafny.Rune> _1109_recursiveGen;
                      bool _1110_recOwned;
                      bool _1111_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1112_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out654;
                      bool _out655;
                      bool _out656;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out657;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out654, out _out655, out _out656, out _out657);
                      _1109_recursiveGen = _out654;
                      _1110_recOwned = _out655;
                      _1111_recErased = _out656;
                      _1112_recIdents = _out657;
                      Dafny.ISequence<Dafny.Rune> _1113_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out658;
                      _out658 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _1113_rhsType = _out658;
                      Dafny.ISequence<Dafny.Rune> _1114_uneraseFn;
                      _1114_uneraseFn = ((_1110_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1113_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1114_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1109_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1110_recOwned;
                      isErased = false;
                      readIdents = _1112_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out659;
                      bool _out660;
                      bool _out661;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out662;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1108_b), _1108_b, _464_toTpe), @params, mustOwn, out _out659, out _out660, out _out661, out _out662);
                      s = _out659;
                      isOwned = _out660;
                      isErased = _out661;
                      readIdents = _out662;
                    }
                  }
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1115___mcc_h481 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1116_recursiveGen;
                  bool _1117_recOwned;
                  bool _1118_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1119_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out663;
                  bool _out664;
                  bool _out665;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out666;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out663, out _out664, out _out665, out _out666);
                  _1116_recursiveGen = _out663;
                  _1117_recOwned = _out664;
                  _1118_recErased = _out665;
                  _1119_recIdents = _out666;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1116_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1117_recOwned;
                  isErased = _1118_recErased;
                  readIdents = _1119_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1120___mcc_h483 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1121_recursiveGen;
                  bool _1122_recOwned;
                  bool _1123_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1124_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out667;
                  bool _out668;
                  bool _out669;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out670;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out667, out _out668, out _out669, out _out670);
                  _1121_recursiveGen = _out667;
                  _1122_recOwned = _out668;
                  _1123_recErased = _out669;
                  _1124_recIdents = _out670;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1121_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1122_recOwned;
                  isErased = _1123_recErased;
                  readIdents = _1124_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1125___mcc_h485 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1126_recursiveGen;
                  bool _1127_recOwned;
                  bool _1128_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1129_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out671;
                  bool _out672;
                  bool _out673;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out674;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out671, out _out672, out _out673, out _out674);
                  _1126_recursiveGen = _out671;
                  _1127_recOwned = _out672;
                  _1128_recErased = _out673;
                  _1129_recIdents = _out674;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1126_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1127_recOwned;
                  isErased = _1128_recErased;
                  readIdents = _1129_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1130___mcc_h487 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1131_recursiveGen;
                  bool _1132_recOwned;
                  bool _1133_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1134_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out675;
                  bool _out676;
                  bool _out677;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out678;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out675, out _out676, out _out677, out _out678);
                  _1131_recursiveGen = _out675;
                  _1132_recOwned = _out676;
                  _1133_recErased = _out677;
                  _1134_recIdents = _out678;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1131_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1132_recOwned;
                  isErased = _1133_recErased;
                  readIdents = _1134_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1135___mcc_h489 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1136_recursiveGen;
                  bool _1137_recOwned;
                  bool _1138_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1139_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out679;
                  bool _out680;
                  bool _out681;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out682;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out679, out _out680, out _out681, out _out682);
                  _1136_recursiveGen = _out679;
                  _1137_recOwned = _out680;
                  _1138_recErased = _out681;
                  _1139_recIdents = _out682;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1136_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1137_recOwned;
                  isErased = _1138_recErased;
                  readIdents = _1139_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1140___mcc_h491 = _source44.dtor_key;
                DAST._IType _1141___mcc_h492 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1142_recursiveGen;
                  bool _1143_recOwned;
                  bool _1144_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1145_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out683;
                  bool _out684;
                  bool _out685;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out686;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out683, out _out684, out _out685, out _out686);
                  _1142_recursiveGen = _out683;
                  _1143_recOwned = _out684;
                  _1144_recErased = _out685;
                  _1145_recIdents = _out686;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1142_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1143_recOwned;
                  isErased = _1144_recErased;
                  readIdents = _1145_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1146___mcc_h495 = _source44.dtor_args;
                DAST._IType _1147___mcc_h496 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1148_recursiveGen;
                  bool _1149_recOwned;
                  bool _1150_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1151_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out687;
                  bool _out688;
                  bool _out689;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out690;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out687, out _out688, out _out689, out _out690);
                  _1148_recursiveGen = _out687;
                  _1149_recOwned = _out688;
                  _1150_recErased = _out689;
                  _1151_recIdents = _out690;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1148_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1149_recOwned;
                  isErased = _1150_recErased;
                  readIdents = _1151_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1152___mcc_h499 = _source44.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1153_recursiveGen;
                  bool _1154_recOwned;
                  bool _1155_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1156_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out691;
                  bool _out692;
                  bool _out693;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out694;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out691, out _out692, out _out693, out _out694);
                  _1153_recursiveGen = _out691;
                  _1154_recOwned = _out692;
                  _1155_recErased = _out693;
                  _1156_recIdents = _out694;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1153_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1154_recOwned;
                  isErased = _1155_recErased;
                  readIdents = _1156_recIdents;
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1157___mcc_h501 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1158_recursiveGen;
                  bool _1159_recOwned;
                  bool _1160_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1161_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out695;
                  bool _out696;
                  bool _out697;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out698;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out695, out _out696, out _out697, out _out698);
                  _1158_recursiveGen = _out695;
                  _1159_recOwned = _out696;
                  _1160_recErased = _out697;
                  _1161_recIdents = _out698;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1158_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1159_recOwned;
                  isErased = _1160_recErased;
                  readIdents = _1161_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1162___mcc_h503 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1163_recursiveGen;
                  bool _1164_recOwned;
                  bool _1165_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1166_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out699;
                  bool _out700;
                  bool _out701;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out702;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out699, out _out700, out _out701, out _out702);
                  _1163_recursiveGen = _out699;
                  _1164_recOwned = _out700;
                  _1165_recErased = _out701;
                  _1166_recIdents = _out702;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1163_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1164_recOwned;
                  isErased = _1165_recErased;
                  readIdents = _1166_recIdents;
                }
              }
            } else if (_source26.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1167___mcc_h505 = _source26.dtor_args;
              DAST._IType _1168___mcc_h506 = _source26.dtor_result;
              DAST._IType _source46 = _472___mcc_h121;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1169___mcc_h511 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1170___mcc_h512 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1171___mcc_h513 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1171___mcc_h513;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1172___mcc_h517 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1173_recursiveGen;
                    bool _1174_recOwned;
                    bool _1175_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1176_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out703;
                    bool _out704;
                    bool _out705;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out706;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out703, out _out704, out _out705, out _out706);
                    _1173_recursiveGen = _out703;
                    _1174_recOwned = _out704;
                    _1175_recErased = _out705;
                    _1176_recIdents = _out706;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1173_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1174_recOwned;
                    isErased = _1175_recErased;
                    readIdents = _1176_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1177___mcc_h519 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1178_recursiveGen;
                    bool _1179_recOwned;
                    bool _1180_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1181_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out707;
                    bool _out708;
                    bool _out709;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out710;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out707, out _out708, out _out709, out _out710);
                    _1178_recursiveGen = _out707;
                    _1179_recOwned = _out708;
                    _1180_recErased = _out709;
                    _1181_recIdents = _out710;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1178_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1179_recOwned;
                    isErased = _1180_recErased;
                    readIdents = _1181_recIdents;
                  }
                } else {
                  DAST._IType _1182___mcc_h521 = _source47.dtor_Newtype_a0;
                  DAST._IType _1183_b = _1182___mcc_h521;
                  {
                    if (object.Equals(_465_fromTpe, _1183_b)) {
                      Dafny.ISequence<Dafny.Rune> _1184_recursiveGen;
                      bool _1185_recOwned;
                      bool _1186_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1187_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out711;
                      bool _out712;
                      bool _out713;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out714;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out711, out _out712, out _out713, out _out714);
                      _1184_recursiveGen = _out711;
                      _1185_recOwned = _out712;
                      _1186_recErased = _out713;
                      _1187_recIdents = _out714;
                      Dafny.ISequence<Dafny.Rune> _1188_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out715;
                      _out715 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _1188_rhsType = _out715;
                      Dafny.ISequence<Dafny.Rune> _1189_uneraseFn;
                      _1189_uneraseFn = ((_1185_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1188_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1189_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1184_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1185_recOwned;
                      isErased = false;
                      readIdents = _1187_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out716;
                      bool _out717;
                      bool _out718;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out719;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1183_b), _1183_b, _464_toTpe), @params, mustOwn, out _out716, out _out717, out _out718, out _out719);
                      s = _out716;
                      isOwned = _out717;
                      isErased = _out718;
                      readIdents = _out719;
                    }
                  }
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1190___mcc_h523 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1191_recursiveGen;
                  bool _1192_recOwned;
                  bool _1193_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1194_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out720;
                  bool _out721;
                  bool _out722;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out723;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out720, out _out721, out _out722, out _out723);
                  _1191_recursiveGen = _out720;
                  _1192_recOwned = _out721;
                  _1193_recErased = _out722;
                  _1194_recIdents = _out723;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1191_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1192_recOwned;
                  isErased = _1193_recErased;
                  readIdents = _1194_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1195___mcc_h525 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1196_recursiveGen;
                  bool _1197_recOwned;
                  bool _1198_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1199_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out724;
                  bool _out725;
                  bool _out726;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out727;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out724, out _out725, out _out726, out _out727);
                  _1196_recursiveGen = _out724;
                  _1197_recOwned = _out725;
                  _1198_recErased = _out726;
                  _1199_recIdents = _out727;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1196_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1197_recOwned;
                  isErased = _1198_recErased;
                  readIdents = _1199_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1200___mcc_h527 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1201_recursiveGen;
                  bool _1202_recOwned;
                  bool _1203_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1204_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out728;
                  bool _out729;
                  bool _out730;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out731;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out728, out _out729, out _out730, out _out731);
                  _1201_recursiveGen = _out728;
                  _1202_recOwned = _out729;
                  _1203_recErased = _out730;
                  _1204_recIdents = _out731;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1201_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1202_recOwned;
                  isErased = _1203_recErased;
                  readIdents = _1204_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1205___mcc_h529 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1206_recursiveGen;
                  bool _1207_recOwned;
                  bool _1208_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1209_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out732;
                  bool _out733;
                  bool _out734;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out735;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out732, out _out733, out _out734, out _out735);
                  _1206_recursiveGen = _out732;
                  _1207_recOwned = _out733;
                  _1208_recErased = _out734;
                  _1209_recIdents = _out735;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1206_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1207_recOwned;
                  isErased = _1208_recErased;
                  readIdents = _1209_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1210___mcc_h531 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1211_recursiveGen;
                  bool _1212_recOwned;
                  bool _1213_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1214_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out736;
                  bool _out737;
                  bool _out738;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out739;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out736, out _out737, out _out738, out _out739);
                  _1211_recursiveGen = _out736;
                  _1212_recOwned = _out737;
                  _1213_recErased = _out738;
                  _1214_recIdents = _out739;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1211_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1212_recOwned;
                  isErased = _1213_recErased;
                  readIdents = _1214_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1215___mcc_h533 = _source46.dtor_key;
                DAST._IType _1216___mcc_h534 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1217_recursiveGen;
                  bool _1218_recOwned;
                  bool _1219_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1220_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out740;
                  bool _out741;
                  bool _out742;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out743;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out740, out _out741, out _out742, out _out743);
                  _1217_recursiveGen = _out740;
                  _1218_recOwned = _out741;
                  _1219_recErased = _out742;
                  _1220_recIdents = _out743;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1217_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1218_recOwned;
                  isErased = _1219_recErased;
                  readIdents = _1220_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1221___mcc_h537 = _source46.dtor_args;
                DAST._IType _1222___mcc_h538 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1223_recursiveGen;
                  bool _1224_recOwned;
                  bool _1225_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1226_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out744;
                  bool _out745;
                  bool _out746;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out747;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out744, out _out745, out _out746, out _out747);
                  _1223_recursiveGen = _out744;
                  _1224_recOwned = _out745;
                  _1225_recErased = _out746;
                  _1226_recIdents = _out747;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1223_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1224_recOwned;
                  isErased = _1225_recErased;
                  readIdents = _1226_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1227___mcc_h541 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1228_recursiveGen;
                  bool _1229_recOwned;
                  bool _1230_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1231_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out748;
                  bool _out749;
                  bool _out750;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out751;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out748, out _out749, out _out750, out _out751);
                  _1228_recursiveGen = _out748;
                  _1229_recOwned = _out749;
                  _1230_recErased = _out750;
                  _1231_recIdents = _out751;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1228_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1229_recOwned;
                  isErased = _1230_recErased;
                  readIdents = _1231_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1232___mcc_h543 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1233_recursiveGen;
                  bool _1234_recOwned;
                  bool _1235_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1236_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out752;
                  bool _out753;
                  bool _out754;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out755;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out752, out _out753, out _out754, out _out755);
                  _1233_recursiveGen = _out752;
                  _1234_recOwned = _out753;
                  _1235_recErased = _out754;
                  _1236_recIdents = _out755;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1233_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1234_recOwned;
                  isErased = _1235_recErased;
                  readIdents = _1236_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1237___mcc_h545 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1238_recursiveGen;
                  bool _1239_recOwned;
                  bool _1240_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1241_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out756;
                  bool _out757;
                  bool _out758;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out759;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out756, out _out757, out _out758, out _out759);
                  _1238_recursiveGen = _out756;
                  _1239_recOwned = _out757;
                  _1240_recErased = _out758;
                  _1241_recIdents = _out759;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1238_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1239_recOwned;
                  isErased = _1240_recErased;
                  readIdents = _1241_recIdents;
                }
              }
            } else if (_source26.is_Primitive) {
              DAST._IPrimitive _1242___mcc_h547 = _source26.dtor_Primitive_a0;
              DAST._IPrimitive _source48 = _1242___mcc_h547;
              if (_source48.is_Int) {
                DAST._IType _source49 = _472___mcc_h121;
                if (_source49.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1243___mcc_h550 = _source49.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1244___mcc_h551 = _source49.dtor_typeArgs;
                  DAST._IResolvedType _1245___mcc_h552 = _source49.dtor_resolved;
                  DAST._IResolvedType _source50 = _1245___mcc_h552;
                  if (_source50.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1246___mcc_h556 = _source50.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1247_recursiveGen;
                      bool _1248_recOwned;
                      bool _1249_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1250_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out760;
                      bool _out761;
                      bool _out762;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out763;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out760, out _out761, out _out762, out _out763);
                      _1247_recursiveGen = _out760;
                      _1248_recOwned = _out761;
                      _1249_recErased = _out762;
                      _1250_recIdents = _out763;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1247_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1248_recOwned;
                      isErased = _1249_recErased;
                      readIdents = _1250_recIdents;
                    }
                  } else if (_source50.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1251___mcc_h558 = _source50.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1252_recursiveGen;
                      bool _1253_recOwned;
                      bool _1254_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1255_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out764;
                      bool _out765;
                      bool _out766;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out767;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out764, out _out765, out _out766, out _out767);
                      _1252_recursiveGen = _out764;
                      _1253_recOwned = _out765;
                      _1254_recErased = _out766;
                      _1255_recIdents = _out767;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1252_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1253_recOwned;
                      isErased = _1254_recErased;
                      readIdents = _1255_recIdents;
                    }
                  } else {
                    DAST._IType _1256___mcc_h560 = _source50.dtor_Newtype_a0;
                    DAST._IType _1257_b = _1256___mcc_h560;
                    {
                      if (object.Equals(_465_fromTpe, _1257_b)) {
                        Dafny.ISequence<Dafny.Rune> _1258_recursiveGen;
                        bool _1259_recOwned;
                        bool _1260_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1261_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out768;
                        bool _out769;
                        bool _out770;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out771;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out768, out _out769, out _out770, out _out771);
                        _1258_recursiveGen = _out768;
                        _1259_recOwned = _out769;
                        _1260_recErased = _out770;
                        _1261_recIdents = _out771;
                        Dafny.ISequence<Dafny.Rune> _1262_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out772;
                        _out772 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                        _1262_rhsType = _out772;
                        Dafny.ISequence<Dafny.Rune> _1263_uneraseFn;
                        _1263_uneraseFn = ((_1259_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1262_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1263_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1258_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1259_recOwned;
                        isErased = false;
                        readIdents = _1261_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out773;
                        bool _out774;
                        bool _out775;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out776;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1257_b), _1257_b, _464_toTpe), @params, mustOwn, out _out773, out _out774, out _out775, out _out776);
                        s = _out773;
                        isOwned = _out774;
                        isErased = _out775;
                        readIdents = _out776;
                      }
                    }
                  }
                } else if (_source49.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1264___mcc_h562 = _source49.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1265_recursiveGen;
                    bool _1266_recOwned;
                    bool _1267_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1268_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out777;
                    bool _out778;
                    bool _out779;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out780;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out777, out _out778, out _out779, out _out780);
                    _1265_recursiveGen = _out777;
                    _1266_recOwned = _out778;
                    _1267_recErased = _out779;
                    _1268_recIdents = _out780;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1265_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1266_recOwned;
                    isErased = _1267_recErased;
                    readIdents = _1268_recIdents;
                  }
                } else if (_source49.is_Array) {
                  DAST._IType _1269___mcc_h564 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1270_recursiveGen;
                    bool _1271_recOwned;
                    bool _1272_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1273_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out781;
                    bool _out782;
                    bool _out783;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out784;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out781, out _out782, out _out783, out _out784);
                    _1270_recursiveGen = _out781;
                    _1271_recOwned = _out782;
                    _1272_recErased = _out783;
                    _1273_recIdents = _out784;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1270_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1271_recOwned;
                    isErased = _1272_recErased;
                    readIdents = _1273_recIdents;
                  }
                } else if (_source49.is_Seq) {
                  DAST._IType _1274___mcc_h566 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1275_recursiveGen;
                    bool _1276_recOwned;
                    bool _1277_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1278_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out785;
                    bool _out786;
                    bool _out787;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out788;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out785, out _out786, out _out787, out _out788);
                    _1275_recursiveGen = _out785;
                    _1276_recOwned = _out786;
                    _1277_recErased = _out787;
                    _1278_recIdents = _out788;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1275_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1276_recOwned;
                    isErased = _1277_recErased;
                    readIdents = _1278_recIdents;
                  }
                } else if (_source49.is_Set) {
                  DAST._IType _1279___mcc_h568 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1280_recursiveGen;
                    bool _1281_recOwned;
                    bool _1282_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1283_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out789;
                    bool _out790;
                    bool _out791;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out792;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out789, out _out790, out _out791, out _out792);
                    _1280_recursiveGen = _out789;
                    _1281_recOwned = _out790;
                    _1282_recErased = _out791;
                    _1283_recIdents = _out792;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1280_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1281_recOwned;
                    isErased = _1282_recErased;
                    readIdents = _1283_recIdents;
                  }
                } else if (_source49.is_Multiset) {
                  DAST._IType _1284___mcc_h570 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1285_recursiveGen;
                    bool _1286_recOwned;
                    bool _1287_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1288_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out793;
                    bool _out794;
                    bool _out795;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out796;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out793, out _out794, out _out795, out _out796);
                    _1285_recursiveGen = _out793;
                    _1286_recOwned = _out794;
                    _1287_recErased = _out795;
                    _1288_recIdents = _out796;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1285_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1286_recOwned;
                    isErased = _1287_recErased;
                    readIdents = _1288_recIdents;
                  }
                } else if (_source49.is_Map) {
                  DAST._IType _1289___mcc_h572 = _source49.dtor_key;
                  DAST._IType _1290___mcc_h573 = _source49.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1291_recursiveGen;
                    bool _1292_recOwned;
                    bool _1293_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1294_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out797;
                    bool _out798;
                    bool _out799;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out800;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out797, out _out798, out _out799, out _out800);
                    _1291_recursiveGen = _out797;
                    _1292_recOwned = _out798;
                    _1293_recErased = _out799;
                    _1294_recIdents = _out800;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1291_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1292_recOwned;
                    isErased = _1293_recErased;
                    readIdents = _1294_recIdents;
                  }
                } else if (_source49.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1295___mcc_h576 = _source49.dtor_args;
                  DAST._IType _1296___mcc_h577 = _source49.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1297_recursiveGen;
                    bool _1298_recOwned;
                    bool _1299_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1300_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out801;
                    bool _out802;
                    bool _out803;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out804;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out801, out _out802, out _out803, out _out804);
                    _1297_recursiveGen = _out801;
                    _1298_recOwned = _out802;
                    _1299_recErased = _out803;
                    _1300_recIdents = _out804;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1297_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1298_recOwned;
                    isErased = _1299_recErased;
                    readIdents = _1300_recIdents;
                  }
                } else if (_source49.is_Primitive) {
                  DAST._IPrimitive _1301___mcc_h580 = _source49.dtor_Primitive_a0;
                  DAST._IPrimitive _source51 = _1301___mcc_h580;
                  if (_source51.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1302_recursiveGen;
                      bool _1303_recOwned;
                      bool _1304_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1305_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out805;
                      bool _out806;
                      bool _out807;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out808;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out805, out _out806, out _out807, out _out808);
                      _1302_recursiveGen = _out805;
                      _1303_recOwned = _out806;
                      _1304_recErased = _out807;
                      _1305_recIdents = _out808;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1302_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1303_recOwned;
                      isErased = _1304_recErased;
                      readIdents = _1305_recIdents;
                    }
                  } else if (_source51.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1306_recursiveGen;
                      bool _1307___v39;
                      bool _1308___v40;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1309_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out809;
                      bool _out810;
                      bool _out811;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out812;
                      DCOMP.COMP.GenExpr(_466_expr, @params, true, out _out809, out _out810, out _out811, out _out812);
                      _1306_recursiveGen = _out809;
                      _1307___v39 = _out810;
                      _1308___v40 = _out811;
                      _1309_recIdents = _out812;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1306_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1309_recIdents;
                    }
                  } else if (_source51.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1310_recursiveGen;
                      bool _1311_recOwned;
                      bool _1312_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1313_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out813;
                      bool _out814;
                      bool _out815;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out816;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out813, out _out814, out _out815, out _out816);
                      _1310_recursiveGen = _out813;
                      _1311_recOwned = _out814;
                      _1312_recErased = _out815;
                      _1313_recIdents = _out816;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1310_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1311_recOwned;
                      isErased = _1312_recErased;
                      readIdents = _1313_recIdents;
                    }
                  } else if (_source51.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1314_recursiveGen;
                      bool _1315_recOwned;
                      bool _1316_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1317_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out817;
                      bool _out818;
                      bool _out819;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out820;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out817, out _out818, out _out819, out _out820);
                      _1314_recursiveGen = _out817;
                      _1315_recOwned = _out818;
                      _1316_recErased = _out819;
                      _1317_recIdents = _out820;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1314_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1315_recOwned;
                      isErased = _1316_recErased;
                      readIdents = _1317_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1318_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out821;
                      _out821 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _1318_rhsType = _out821;
                      Dafny.ISequence<Dafny.Rune> _1319_recursiveGen;
                      bool _1320___v49;
                      bool _1321___v50;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1322_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out822;
                      bool _out823;
                      bool _out824;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out825;
                      DCOMP.COMP.GenExpr(_466_expr, @params, true, out _out822, out _out823, out _out824, out _out825);
                      _1319_recursiveGen = _out822;
                      _1320___v49 = _out823;
                      _1321___v50 = _out824;
                      _1322_recIdents = _out825;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1319_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1322_recIdents;
                    }
                  }
                } else if (_source49.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1323___mcc_h582 = _source49.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1324_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out826;
                    _out826 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                    _1324_rhsType = _out826;
                    Dafny.ISequence<Dafny.Rune> _1325_recursiveGen;
                    bool _1326___v44;
                    bool _1327___v45;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1328_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out827;
                    bool _out828;
                    bool _out829;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                    DCOMP.COMP.GenExpr(_466_expr, @params, true, out _out827, out _out828, out _out829, out _out830);
                    _1325_recursiveGen = _out827;
                    _1326___v44 = _out828;
                    _1327___v45 = _out829;
                    _1328_recIdents = _out830;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1324_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1325_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1328_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1329___mcc_h584 = _source49.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1330_recursiveGen;
                    bool _1331_recOwned;
                    bool _1332_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1333_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out831;
                    bool _out832;
                    bool _out833;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                    _1330_recursiveGen = _out831;
                    _1331_recOwned = _out832;
                    _1332_recErased = _out833;
                    _1333_recIdents = _out834;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1330_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1331_recOwned;
                    isErased = _1332_recErased;
                    readIdents = _1333_recIdents;
                  }
                }
              } else if (_source48.is_Real) {
                DAST._IType _source52 = _472___mcc_h121;
                if (_source52.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1334___mcc_h586 = _source52.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1335___mcc_h587 = _source52.dtor_typeArgs;
                  DAST._IResolvedType _1336___mcc_h588 = _source52.dtor_resolved;
                  DAST._IResolvedType _source53 = _1336___mcc_h588;
                  if (_source53.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1337___mcc_h592 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1338_recursiveGen;
                      bool _1339_recOwned;
                      bool _1340_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1341_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out835;
                      bool _out836;
                      bool _out837;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                      _1338_recursiveGen = _out835;
                      _1339_recOwned = _out836;
                      _1340_recErased = _out837;
                      _1341_recIdents = _out838;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1338_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1339_recOwned;
                      isErased = _1340_recErased;
                      readIdents = _1341_recIdents;
                    }
                  } else if (_source53.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1342___mcc_h594 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1343_recursiveGen;
                      bool _1344_recOwned;
                      bool _1345_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1346_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out839;
                      bool _out840;
                      bool _out841;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                      _1343_recursiveGen = _out839;
                      _1344_recOwned = _out840;
                      _1345_recErased = _out841;
                      _1346_recIdents = _out842;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1343_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1344_recOwned;
                      isErased = _1345_recErased;
                      readIdents = _1346_recIdents;
                    }
                  } else {
                    DAST._IType _1347___mcc_h596 = _source53.dtor_Newtype_a0;
                    DAST._IType _1348_b = _1347___mcc_h596;
                    {
                      if (object.Equals(_465_fromTpe, _1348_b)) {
                        Dafny.ISequence<Dafny.Rune> _1349_recursiveGen;
                        bool _1350_recOwned;
                        bool _1351_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1352_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out843;
                        bool _out844;
                        bool _out845;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                        _1349_recursiveGen = _out843;
                        _1350_recOwned = _out844;
                        _1351_recErased = _out845;
                        _1352_recIdents = _out846;
                        Dafny.ISequence<Dafny.Rune> _1353_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out847;
                        _out847 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                        _1353_rhsType = _out847;
                        Dafny.ISequence<Dafny.Rune> _1354_uneraseFn;
                        _1354_uneraseFn = ((_1350_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1353_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1354_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1349_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1350_recOwned;
                        isErased = false;
                        readIdents = _1352_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out848;
                        bool _out849;
                        bool _out850;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out851;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1348_b), _1348_b, _464_toTpe), @params, mustOwn, out _out848, out _out849, out _out850, out _out851);
                        s = _out848;
                        isOwned = _out849;
                        isErased = _out850;
                        readIdents = _out851;
                      }
                    }
                  }
                } else if (_source52.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1355___mcc_h598 = _source52.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1356_recursiveGen;
                    bool _1357_recOwned;
                    bool _1358_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1359_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out852;
                    bool _out853;
                    bool _out854;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out855;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out852, out _out853, out _out854, out _out855);
                    _1356_recursiveGen = _out852;
                    _1357_recOwned = _out853;
                    _1358_recErased = _out854;
                    _1359_recIdents = _out855;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1356_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1357_recOwned;
                    isErased = _1358_recErased;
                    readIdents = _1359_recIdents;
                  }
                } else if (_source52.is_Array) {
                  DAST._IType _1360___mcc_h600 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1361_recursiveGen;
                    bool _1362_recOwned;
                    bool _1363_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1364_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out856;
                    bool _out857;
                    bool _out858;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out859;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out856, out _out857, out _out858, out _out859);
                    _1361_recursiveGen = _out856;
                    _1362_recOwned = _out857;
                    _1363_recErased = _out858;
                    _1364_recIdents = _out859;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1361_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1362_recOwned;
                    isErased = _1363_recErased;
                    readIdents = _1364_recIdents;
                  }
                } else if (_source52.is_Seq) {
                  DAST._IType _1365___mcc_h602 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1366_recursiveGen;
                    bool _1367_recOwned;
                    bool _1368_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1369_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out860;
                    bool _out861;
                    bool _out862;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out863;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out860, out _out861, out _out862, out _out863);
                    _1366_recursiveGen = _out860;
                    _1367_recOwned = _out861;
                    _1368_recErased = _out862;
                    _1369_recIdents = _out863;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1366_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1367_recOwned;
                    isErased = _1368_recErased;
                    readIdents = _1369_recIdents;
                  }
                } else if (_source52.is_Set) {
                  DAST._IType _1370___mcc_h604 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1371_recursiveGen;
                    bool _1372_recOwned;
                    bool _1373_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1374_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out864;
                    bool _out865;
                    bool _out866;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out867;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out864, out _out865, out _out866, out _out867);
                    _1371_recursiveGen = _out864;
                    _1372_recOwned = _out865;
                    _1373_recErased = _out866;
                    _1374_recIdents = _out867;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1371_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1372_recOwned;
                    isErased = _1373_recErased;
                    readIdents = _1374_recIdents;
                  }
                } else if (_source52.is_Multiset) {
                  DAST._IType _1375___mcc_h606 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1376_recursiveGen;
                    bool _1377_recOwned;
                    bool _1378_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1379_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out868;
                    bool _out869;
                    bool _out870;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out871;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out868, out _out869, out _out870, out _out871);
                    _1376_recursiveGen = _out868;
                    _1377_recOwned = _out869;
                    _1378_recErased = _out870;
                    _1379_recIdents = _out871;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1376_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1377_recOwned;
                    isErased = _1378_recErased;
                    readIdents = _1379_recIdents;
                  }
                } else if (_source52.is_Map) {
                  DAST._IType _1380___mcc_h608 = _source52.dtor_key;
                  DAST._IType _1381___mcc_h609 = _source52.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1382_recursiveGen;
                    bool _1383_recOwned;
                    bool _1384_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1385_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out872;
                    bool _out873;
                    bool _out874;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out875;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out872, out _out873, out _out874, out _out875);
                    _1382_recursiveGen = _out872;
                    _1383_recOwned = _out873;
                    _1384_recErased = _out874;
                    _1385_recIdents = _out875;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1382_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1383_recOwned;
                    isErased = _1384_recErased;
                    readIdents = _1385_recIdents;
                  }
                } else if (_source52.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1386___mcc_h612 = _source52.dtor_args;
                  DAST._IType _1387___mcc_h613 = _source52.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1388_recursiveGen;
                    bool _1389_recOwned;
                    bool _1390_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1391_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out876;
                    bool _out877;
                    bool _out878;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out879;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out876, out _out877, out _out878, out _out879);
                    _1388_recursiveGen = _out876;
                    _1389_recOwned = _out877;
                    _1390_recErased = _out878;
                    _1391_recIdents = _out879;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1388_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1389_recOwned;
                    isErased = _1390_recErased;
                    readIdents = _1391_recIdents;
                  }
                } else if (_source52.is_Primitive) {
                  DAST._IPrimitive _1392___mcc_h616 = _source52.dtor_Primitive_a0;
                  DAST._IPrimitive _source54 = _1392___mcc_h616;
                  if (_source54.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1393_recursiveGen;
                      bool _1394___v41;
                      bool _1395___v42;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1396_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out880;
                      bool _out881;
                      bool _out882;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                      DCOMP.COMP.GenExpr(_466_expr, @params, false, out _out880, out _out881, out _out882, out _out883);
                      _1393_recursiveGen = _out880;
                      _1394___v41 = _out881;
                      _1395___v42 = _out882;
                      _1396_recIdents = _out883;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1393_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1396_recIdents;
                    }
                  } else if (_source54.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1397_recursiveGen;
                      bool _1398_recOwned;
                      bool _1399_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1400_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out884;
                      bool _out885;
                      bool _out886;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                      _1397_recursiveGen = _out884;
                      _1398_recOwned = _out885;
                      _1399_recErased = _out886;
                      _1400_recIdents = _out887;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1397_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1398_recOwned;
                      isErased = _1399_recErased;
                      readIdents = _1400_recIdents;
                    }
                  } else if (_source54.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1401_recursiveGen;
                      bool _1402_recOwned;
                      bool _1403_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1404_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out888;
                      bool _out889;
                      bool _out890;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                      _1401_recursiveGen = _out888;
                      _1402_recOwned = _out889;
                      _1403_recErased = _out890;
                      _1404_recIdents = _out891;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1401_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1402_recOwned;
                      isErased = _1403_recErased;
                      readIdents = _1404_recIdents;
                    }
                  } else if (_source54.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1405_recursiveGen;
                      bool _1406_recOwned;
                      bool _1407_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1408_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out892;
                      bool _out893;
                      bool _out894;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                      _1405_recursiveGen = _out892;
                      _1406_recOwned = _out893;
                      _1407_recErased = _out894;
                      _1408_recIdents = _out895;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1405_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1406_recOwned;
                      isErased = _1407_recErased;
                      readIdents = _1408_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1409_recursiveGen;
                      bool _1410_recOwned;
                      bool _1411_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1412_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out896;
                      bool _out897;
                      bool _out898;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                      _1409_recursiveGen = _out896;
                      _1410_recOwned = _out897;
                      _1411_recErased = _out898;
                      _1412_recIdents = _out899;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1409_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1410_recOwned;
                      isErased = _1411_recErased;
                      readIdents = _1412_recIdents;
                    }
                  }
                } else if (_source52.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1413___mcc_h618 = _source52.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1414_recursiveGen;
                    bool _1415_recOwned;
                    bool _1416_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1417_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1414_recursiveGen = _out900;
                    _1415_recOwned = _out901;
                    _1416_recErased = _out902;
                    _1417_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1414_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1415_recOwned;
                    isErased = _1416_recErased;
                    readIdents = _1417_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1418___mcc_h620 = _source52.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1419_recursiveGen;
                    bool _1420_recOwned;
                    bool _1421_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1422_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1419_recursiveGen = _out904;
                    _1420_recOwned = _out905;
                    _1421_recErased = _out906;
                    _1422_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1419_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1420_recOwned;
                    isErased = _1421_recErased;
                    readIdents = _1422_recIdents;
                  }
                }
              } else if (_source48.is_String) {
                DAST._IType _source55 = _472___mcc_h121;
                if (_source55.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1423___mcc_h622 = _source55.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1424___mcc_h623 = _source55.dtor_typeArgs;
                  DAST._IResolvedType _1425___mcc_h624 = _source55.dtor_resolved;
                  DAST._IResolvedType _source56 = _1425___mcc_h624;
                  if (_source56.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1426___mcc_h628 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1427_recursiveGen;
                      bool _1428_recOwned;
                      bool _1429_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1430_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out908;
                      bool _out909;
                      bool _out910;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                      _1427_recursiveGen = _out908;
                      _1428_recOwned = _out909;
                      _1429_recErased = _out910;
                      _1430_recIdents = _out911;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1427_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1428_recOwned;
                      isErased = _1429_recErased;
                      readIdents = _1430_recIdents;
                    }
                  } else if (_source56.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1431___mcc_h630 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1432_recursiveGen;
                      bool _1433_recOwned;
                      bool _1434_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1435_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out912;
                      bool _out913;
                      bool _out914;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out912, out _out913, out _out914, out _out915);
                      _1432_recursiveGen = _out912;
                      _1433_recOwned = _out913;
                      _1434_recErased = _out914;
                      _1435_recIdents = _out915;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1432_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1433_recOwned;
                      isErased = _1434_recErased;
                      readIdents = _1435_recIdents;
                    }
                  } else {
                    DAST._IType _1436___mcc_h632 = _source56.dtor_Newtype_a0;
                    DAST._IType _1437_b = _1436___mcc_h632;
                    {
                      if (object.Equals(_465_fromTpe, _1437_b)) {
                        Dafny.ISequence<Dafny.Rune> _1438_recursiveGen;
                        bool _1439_recOwned;
                        bool _1440_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1441_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out916;
                        bool _out917;
                        bool _out918;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                        _1438_recursiveGen = _out916;
                        _1439_recOwned = _out917;
                        _1440_recErased = _out918;
                        _1441_recIdents = _out919;
                        Dafny.ISequence<Dafny.Rune> _1442_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out920;
                        _out920 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                        _1442_rhsType = _out920;
                        Dafny.ISequence<Dafny.Rune> _1443_uneraseFn;
                        _1443_uneraseFn = ((_1439_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1442_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1443_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1438_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1439_recOwned;
                        isErased = false;
                        readIdents = _1441_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out921;
                        bool _out922;
                        bool _out923;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out924;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1437_b), _1437_b, _464_toTpe), @params, mustOwn, out _out921, out _out922, out _out923, out _out924);
                        s = _out921;
                        isOwned = _out922;
                        isErased = _out923;
                        readIdents = _out924;
                      }
                    }
                  }
                } else if (_source55.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1444___mcc_h634 = _source55.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1445_recursiveGen;
                    bool _1446_recOwned;
                    bool _1447_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1448_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out925;
                    bool _out926;
                    bool _out927;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out928;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out925, out _out926, out _out927, out _out928);
                    _1445_recursiveGen = _out925;
                    _1446_recOwned = _out926;
                    _1447_recErased = _out927;
                    _1448_recIdents = _out928;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1445_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1446_recOwned;
                    isErased = _1447_recErased;
                    readIdents = _1448_recIdents;
                  }
                } else if (_source55.is_Array) {
                  DAST._IType _1449___mcc_h636 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1450_recursiveGen;
                    bool _1451_recOwned;
                    bool _1452_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1453_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out929;
                    bool _out930;
                    bool _out931;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out932;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out929, out _out930, out _out931, out _out932);
                    _1450_recursiveGen = _out929;
                    _1451_recOwned = _out930;
                    _1452_recErased = _out931;
                    _1453_recIdents = _out932;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1450_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1451_recOwned;
                    isErased = _1452_recErased;
                    readIdents = _1453_recIdents;
                  }
                } else if (_source55.is_Seq) {
                  DAST._IType _1454___mcc_h638 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1455_recursiveGen;
                    bool _1456_recOwned;
                    bool _1457_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1458_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out933;
                    bool _out934;
                    bool _out935;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out933, out _out934, out _out935, out _out936);
                    _1455_recursiveGen = _out933;
                    _1456_recOwned = _out934;
                    _1457_recErased = _out935;
                    _1458_recIdents = _out936;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1455_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1456_recOwned;
                    isErased = _1457_recErased;
                    readIdents = _1458_recIdents;
                  }
                } else if (_source55.is_Set) {
                  DAST._IType _1459___mcc_h640 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1460_recursiveGen;
                    bool _1461_recOwned;
                    bool _1462_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1463_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out937;
                    bool _out938;
                    bool _out939;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out940;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out937, out _out938, out _out939, out _out940);
                    _1460_recursiveGen = _out937;
                    _1461_recOwned = _out938;
                    _1462_recErased = _out939;
                    _1463_recIdents = _out940;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1460_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1461_recOwned;
                    isErased = _1462_recErased;
                    readIdents = _1463_recIdents;
                  }
                } else if (_source55.is_Multiset) {
                  DAST._IType _1464___mcc_h642 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1465_recursiveGen;
                    bool _1466_recOwned;
                    bool _1467_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1468_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out941;
                    bool _out942;
                    bool _out943;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out944;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out941, out _out942, out _out943, out _out944);
                    _1465_recursiveGen = _out941;
                    _1466_recOwned = _out942;
                    _1467_recErased = _out943;
                    _1468_recIdents = _out944;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1465_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1466_recOwned;
                    isErased = _1467_recErased;
                    readIdents = _1468_recIdents;
                  }
                } else if (_source55.is_Map) {
                  DAST._IType _1469___mcc_h644 = _source55.dtor_key;
                  DAST._IType _1470___mcc_h645 = _source55.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1471_recursiveGen;
                    bool _1472_recOwned;
                    bool _1473_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1474_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out945;
                    bool _out946;
                    bool _out947;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out948;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out945, out _out946, out _out947, out _out948);
                    _1471_recursiveGen = _out945;
                    _1472_recOwned = _out946;
                    _1473_recErased = _out947;
                    _1474_recIdents = _out948;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1471_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1472_recOwned;
                    isErased = _1473_recErased;
                    readIdents = _1474_recIdents;
                  }
                } else if (_source55.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1475___mcc_h648 = _source55.dtor_args;
                  DAST._IType _1476___mcc_h649 = _source55.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1477_recursiveGen;
                    bool _1478_recOwned;
                    bool _1479_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1480_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out949;
                    bool _out950;
                    bool _out951;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out952;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out949, out _out950, out _out951, out _out952);
                    _1477_recursiveGen = _out949;
                    _1478_recOwned = _out950;
                    _1479_recErased = _out951;
                    _1480_recIdents = _out952;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1477_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1478_recOwned;
                    isErased = _1479_recErased;
                    readIdents = _1480_recIdents;
                  }
                } else if (_source55.is_Primitive) {
                  DAST._IPrimitive _1481___mcc_h652 = _source55.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1482_recursiveGen;
                    bool _1483_recOwned;
                    bool _1484_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1485_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out953;
                    bool _out954;
                    bool _out955;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out956;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out953, out _out954, out _out955, out _out956);
                    _1482_recursiveGen = _out953;
                    _1483_recOwned = _out954;
                    _1484_recErased = _out955;
                    _1485_recIdents = _out956;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1482_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1483_recOwned;
                    isErased = _1484_recErased;
                    readIdents = _1485_recIdents;
                  }
                } else if (_source55.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1486___mcc_h654 = _source55.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1487_recursiveGen;
                    bool _1488_recOwned;
                    bool _1489_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1490_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out957;
                    bool _out958;
                    bool _out959;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out960;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out957, out _out958, out _out959, out _out960);
                    _1487_recursiveGen = _out957;
                    _1488_recOwned = _out958;
                    _1489_recErased = _out959;
                    _1490_recIdents = _out960;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1487_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1488_recOwned;
                    isErased = _1489_recErased;
                    readIdents = _1490_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1491___mcc_h656 = _source55.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1492_recursiveGen;
                    bool _1493_recOwned;
                    bool _1494_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1495_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out961;
                    bool _out962;
                    bool _out963;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out964;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out961, out _out962, out _out963, out _out964);
                    _1492_recursiveGen = _out961;
                    _1493_recOwned = _out962;
                    _1494_recErased = _out963;
                    _1495_recIdents = _out964;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1493_recOwned;
                    isErased = _1494_recErased;
                    readIdents = _1495_recIdents;
                  }
                }
              } else if (_source48.is_Bool) {
                DAST._IType _source57 = _472___mcc_h121;
                if (_source57.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1496___mcc_h658 = _source57.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1497___mcc_h659 = _source57.dtor_typeArgs;
                  DAST._IResolvedType _1498___mcc_h660 = _source57.dtor_resolved;
                  DAST._IResolvedType _source58 = _1498___mcc_h660;
                  if (_source58.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1499___mcc_h664 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1500_recursiveGen;
                      bool _1501_recOwned;
                      bool _1502_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1503_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out965;
                      bool _out966;
                      bool _out967;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out968;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out965, out _out966, out _out967, out _out968);
                      _1500_recursiveGen = _out965;
                      _1501_recOwned = _out966;
                      _1502_recErased = _out967;
                      _1503_recIdents = _out968;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1500_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1501_recOwned;
                      isErased = _1502_recErased;
                      readIdents = _1503_recIdents;
                    }
                  } else if (_source58.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1504___mcc_h666 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1505_recursiveGen;
                      bool _1506_recOwned;
                      bool _1507_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1508_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out969;
                      bool _out970;
                      bool _out971;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out972;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out969, out _out970, out _out971, out _out972);
                      _1505_recursiveGen = _out969;
                      _1506_recOwned = _out970;
                      _1507_recErased = _out971;
                      _1508_recIdents = _out972;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1505_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1506_recOwned;
                      isErased = _1507_recErased;
                      readIdents = _1508_recIdents;
                    }
                  } else {
                    DAST._IType _1509___mcc_h668 = _source58.dtor_Newtype_a0;
                    DAST._IType _1510_b = _1509___mcc_h668;
                    {
                      if (object.Equals(_465_fromTpe, _1510_b)) {
                        Dafny.ISequence<Dafny.Rune> _1511_recursiveGen;
                        bool _1512_recOwned;
                        bool _1513_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1514_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out973;
                        bool _out974;
                        bool _out975;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out976;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out973, out _out974, out _out975, out _out976);
                        _1511_recursiveGen = _out973;
                        _1512_recOwned = _out974;
                        _1513_recErased = _out975;
                        _1514_recIdents = _out976;
                        Dafny.ISequence<Dafny.Rune> _1515_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out977;
                        _out977 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                        _1515_rhsType = _out977;
                        Dafny.ISequence<Dafny.Rune> _1516_uneraseFn;
                        _1516_uneraseFn = ((_1512_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1515_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1516_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1511_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1512_recOwned;
                        isErased = false;
                        readIdents = _1514_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out978;
                        bool _out979;
                        bool _out980;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out981;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1510_b), _1510_b, _464_toTpe), @params, mustOwn, out _out978, out _out979, out _out980, out _out981);
                        s = _out978;
                        isOwned = _out979;
                        isErased = _out980;
                        readIdents = _out981;
                      }
                    }
                  }
                } else if (_source57.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1517___mcc_h670 = _source57.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1518_recursiveGen;
                    bool _1519_recOwned;
                    bool _1520_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1521_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out982;
                    bool _out983;
                    bool _out984;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out985;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out982, out _out983, out _out984, out _out985);
                    _1518_recursiveGen = _out982;
                    _1519_recOwned = _out983;
                    _1520_recErased = _out984;
                    _1521_recIdents = _out985;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1518_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1519_recOwned;
                    isErased = _1520_recErased;
                    readIdents = _1521_recIdents;
                  }
                } else if (_source57.is_Array) {
                  DAST._IType _1522___mcc_h672 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1523_recursiveGen;
                    bool _1524_recOwned;
                    bool _1525_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1526_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out986;
                    bool _out987;
                    bool _out988;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out989;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out986, out _out987, out _out988, out _out989);
                    _1523_recursiveGen = _out986;
                    _1524_recOwned = _out987;
                    _1525_recErased = _out988;
                    _1526_recIdents = _out989;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1523_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1524_recOwned;
                    isErased = _1525_recErased;
                    readIdents = _1526_recIdents;
                  }
                } else if (_source57.is_Seq) {
                  DAST._IType _1527___mcc_h674 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1528_recursiveGen;
                    bool _1529_recOwned;
                    bool _1530_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1531_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out990;
                    bool _out991;
                    bool _out992;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out993;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out990, out _out991, out _out992, out _out993);
                    _1528_recursiveGen = _out990;
                    _1529_recOwned = _out991;
                    _1530_recErased = _out992;
                    _1531_recIdents = _out993;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1528_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1529_recOwned;
                    isErased = _1530_recErased;
                    readIdents = _1531_recIdents;
                  }
                } else if (_source57.is_Set) {
                  DAST._IType _1532___mcc_h676 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1533_recursiveGen;
                    bool _1534_recOwned;
                    bool _1535_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1536_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out994;
                    bool _out995;
                    bool _out996;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out997;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out994, out _out995, out _out996, out _out997);
                    _1533_recursiveGen = _out994;
                    _1534_recOwned = _out995;
                    _1535_recErased = _out996;
                    _1536_recIdents = _out997;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1533_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1534_recOwned;
                    isErased = _1535_recErased;
                    readIdents = _1536_recIdents;
                  }
                } else if (_source57.is_Multiset) {
                  DAST._IType _1537___mcc_h678 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1538_recursiveGen;
                    bool _1539_recOwned;
                    bool _1540_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1541_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out998;
                    bool _out999;
                    bool _out1000;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1001;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out998, out _out999, out _out1000, out _out1001);
                    _1538_recursiveGen = _out998;
                    _1539_recOwned = _out999;
                    _1540_recErased = _out1000;
                    _1541_recIdents = _out1001;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1538_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1539_recOwned;
                    isErased = _1540_recErased;
                    readIdents = _1541_recIdents;
                  }
                } else if (_source57.is_Map) {
                  DAST._IType _1542___mcc_h680 = _source57.dtor_key;
                  DAST._IType _1543___mcc_h681 = _source57.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1544_recursiveGen;
                    bool _1545_recOwned;
                    bool _1546_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1547_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1002;
                    bool _out1003;
                    bool _out1004;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1005;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1002, out _out1003, out _out1004, out _out1005);
                    _1544_recursiveGen = _out1002;
                    _1545_recOwned = _out1003;
                    _1546_recErased = _out1004;
                    _1547_recIdents = _out1005;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1544_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1545_recOwned;
                    isErased = _1546_recErased;
                    readIdents = _1547_recIdents;
                  }
                } else if (_source57.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1548___mcc_h684 = _source57.dtor_args;
                  DAST._IType _1549___mcc_h685 = _source57.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1550_recursiveGen;
                    bool _1551_recOwned;
                    bool _1552_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1553_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1006;
                    bool _out1007;
                    bool _out1008;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1009;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1006, out _out1007, out _out1008, out _out1009);
                    _1550_recursiveGen = _out1006;
                    _1551_recOwned = _out1007;
                    _1552_recErased = _out1008;
                    _1553_recIdents = _out1009;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1550_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1551_recOwned;
                    isErased = _1552_recErased;
                    readIdents = _1553_recIdents;
                  }
                } else if (_source57.is_Primitive) {
                  DAST._IPrimitive _1554___mcc_h688 = _source57.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1555_recursiveGen;
                    bool _1556_recOwned;
                    bool _1557_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1558_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1010;
                    bool _out1011;
                    bool _out1012;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1013;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1010, out _out1011, out _out1012, out _out1013);
                    _1555_recursiveGen = _out1010;
                    _1556_recOwned = _out1011;
                    _1557_recErased = _out1012;
                    _1558_recIdents = _out1013;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1555_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1556_recOwned;
                    isErased = _1557_recErased;
                    readIdents = _1558_recIdents;
                  }
                } else if (_source57.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1559___mcc_h690 = _source57.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1560_recursiveGen;
                    bool _1561_recOwned;
                    bool _1562_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1563_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1014;
                    bool _out1015;
                    bool _out1016;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1017;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1014, out _out1015, out _out1016, out _out1017);
                    _1560_recursiveGen = _out1014;
                    _1561_recOwned = _out1015;
                    _1562_recErased = _out1016;
                    _1563_recIdents = _out1017;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1561_recOwned;
                    isErased = _1562_recErased;
                    readIdents = _1563_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1564___mcc_h692 = _source57.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1565_recursiveGen;
                    bool _1566_recOwned;
                    bool _1567_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1568_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1018;
                    bool _out1019;
                    bool _out1020;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1021;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1018, out _out1019, out _out1020, out _out1021);
                    _1565_recursiveGen = _out1018;
                    _1566_recOwned = _out1019;
                    _1567_recErased = _out1020;
                    _1568_recIdents = _out1021;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1565_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1566_recOwned;
                    isErased = _1567_recErased;
                    readIdents = _1568_recIdents;
                  }
                }
              } else {
                DAST._IType _source59 = _472___mcc_h121;
                if (_source59.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1569___mcc_h694 = _source59.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1570___mcc_h695 = _source59.dtor_typeArgs;
                  DAST._IResolvedType _1571___mcc_h696 = _source59.dtor_resolved;
                  DAST._IResolvedType _source60 = _1571___mcc_h696;
                  if (_source60.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1572___mcc_h700 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1573_recursiveGen;
                      bool _1574_recOwned;
                      bool _1575_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1576_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1022;
                      bool _out1023;
                      bool _out1024;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1025;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1022, out _out1023, out _out1024, out _out1025);
                      _1573_recursiveGen = _out1022;
                      _1574_recOwned = _out1023;
                      _1575_recErased = _out1024;
                      _1576_recIdents = _out1025;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1573_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1574_recOwned;
                      isErased = _1575_recErased;
                      readIdents = _1576_recIdents;
                    }
                  } else if (_source60.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1577___mcc_h702 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1578_recursiveGen;
                      bool _1579_recOwned;
                      bool _1580_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1581_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1026;
                      bool _out1027;
                      bool _out1028;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1029;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1026, out _out1027, out _out1028, out _out1029);
                      _1578_recursiveGen = _out1026;
                      _1579_recOwned = _out1027;
                      _1580_recErased = _out1028;
                      _1581_recIdents = _out1029;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1578_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1579_recOwned;
                      isErased = _1580_recErased;
                      readIdents = _1581_recIdents;
                    }
                  } else {
                    DAST._IType _1582___mcc_h704 = _source60.dtor_Newtype_a0;
                    DAST._IType _1583_b = _1582___mcc_h704;
                    {
                      if (object.Equals(_465_fromTpe, _1583_b)) {
                        Dafny.ISequence<Dafny.Rune> _1584_recursiveGen;
                        bool _1585_recOwned;
                        bool _1586_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1587_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1030;
                        bool _out1031;
                        bool _out1032;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1033;
                        DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1030, out _out1031, out _out1032, out _out1033);
                        _1584_recursiveGen = _out1030;
                        _1585_recOwned = _out1031;
                        _1586_recErased = _out1032;
                        _1587_recIdents = _out1033;
                        Dafny.ISequence<Dafny.Rune> _1588_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1034;
                        _out1034 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                        _1588_rhsType = _out1034;
                        Dafny.ISequence<Dafny.Rune> _1589_uneraseFn;
                        _1589_uneraseFn = ((_1585_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1588_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1589_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1584_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1585_recOwned;
                        isErased = false;
                        readIdents = _1587_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1035;
                        bool _out1036;
                        bool _out1037;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1038;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1583_b), _1583_b, _464_toTpe), @params, mustOwn, out _out1035, out _out1036, out _out1037, out _out1038);
                        s = _out1035;
                        isOwned = _out1036;
                        isErased = _out1037;
                        readIdents = _out1038;
                      }
                    }
                  }
                } else if (_source59.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1590___mcc_h706 = _source59.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1591_recursiveGen;
                    bool _1592_recOwned;
                    bool _1593_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1594_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1039;
                    bool _out1040;
                    bool _out1041;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1042;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1039, out _out1040, out _out1041, out _out1042);
                    _1591_recursiveGen = _out1039;
                    _1592_recOwned = _out1040;
                    _1593_recErased = _out1041;
                    _1594_recIdents = _out1042;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1591_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1592_recOwned;
                    isErased = _1593_recErased;
                    readIdents = _1594_recIdents;
                  }
                } else if (_source59.is_Array) {
                  DAST._IType _1595___mcc_h708 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1596_recursiveGen;
                    bool _1597_recOwned;
                    bool _1598_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1599_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1043;
                    bool _out1044;
                    bool _out1045;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1046;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1043, out _out1044, out _out1045, out _out1046);
                    _1596_recursiveGen = _out1043;
                    _1597_recOwned = _out1044;
                    _1598_recErased = _out1045;
                    _1599_recIdents = _out1046;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1596_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1597_recOwned;
                    isErased = _1598_recErased;
                    readIdents = _1599_recIdents;
                  }
                } else if (_source59.is_Seq) {
                  DAST._IType _1600___mcc_h710 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1601_recursiveGen;
                    bool _1602_recOwned;
                    bool _1603_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1604_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1047;
                    bool _out1048;
                    bool _out1049;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1050;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1047, out _out1048, out _out1049, out _out1050);
                    _1601_recursiveGen = _out1047;
                    _1602_recOwned = _out1048;
                    _1603_recErased = _out1049;
                    _1604_recIdents = _out1050;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1601_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1602_recOwned;
                    isErased = _1603_recErased;
                    readIdents = _1604_recIdents;
                  }
                } else if (_source59.is_Set) {
                  DAST._IType _1605___mcc_h712 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1606_recursiveGen;
                    bool _1607_recOwned;
                    bool _1608_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1609_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1051;
                    bool _out1052;
                    bool _out1053;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1054;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1051, out _out1052, out _out1053, out _out1054);
                    _1606_recursiveGen = _out1051;
                    _1607_recOwned = _out1052;
                    _1608_recErased = _out1053;
                    _1609_recIdents = _out1054;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1606_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1607_recOwned;
                    isErased = _1608_recErased;
                    readIdents = _1609_recIdents;
                  }
                } else if (_source59.is_Multiset) {
                  DAST._IType _1610___mcc_h714 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1611_recursiveGen;
                    bool _1612_recOwned;
                    bool _1613_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1614_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1055;
                    bool _out1056;
                    bool _out1057;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1058;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1055, out _out1056, out _out1057, out _out1058);
                    _1611_recursiveGen = _out1055;
                    _1612_recOwned = _out1056;
                    _1613_recErased = _out1057;
                    _1614_recIdents = _out1058;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1611_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1612_recOwned;
                    isErased = _1613_recErased;
                    readIdents = _1614_recIdents;
                  }
                } else if (_source59.is_Map) {
                  DAST._IType _1615___mcc_h716 = _source59.dtor_key;
                  DAST._IType _1616___mcc_h717 = _source59.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1617_recursiveGen;
                    bool _1618_recOwned;
                    bool _1619_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1620_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1059;
                    bool _out1060;
                    bool _out1061;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1062;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1059, out _out1060, out _out1061, out _out1062);
                    _1617_recursiveGen = _out1059;
                    _1618_recOwned = _out1060;
                    _1619_recErased = _out1061;
                    _1620_recIdents = _out1062;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1617_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1618_recOwned;
                    isErased = _1619_recErased;
                    readIdents = _1620_recIdents;
                  }
                } else if (_source59.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1621___mcc_h720 = _source59.dtor_args;
                  DAST._IType _1622___mcc_h721 = _source59.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1623_recursiveGen;
                    bool _1624_recOwned;
                    bool _1625_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1626_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1063;
                    bool _out1064;
                    bool _out1065;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1066;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1063, out _out1064, out _out1065, out _out1066);
                    _1623_recursiveGen = _out1063;
                    _1624_recOwned = _out1064;
                    _1625_recErased = _out1065;
                    _1626_recIdents = _out1066;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1623_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1624_recOwned;
                    isErased = _1625_recErased;
                    readIdents = _1626_recIdents;
                  }
                } else if (_source59.is_Primitive) {
                  DAST._IPrimitive _1627___mcc_h724 = _source59.dtor_Primitive_a0;
                  DAST._IPrimitive _source61 = _1627___mcc_h724;
                  if (_source61.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1628_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1067;
                      _out1067 = DCOMP.COMP.GenType(_465_fromTpe, true, false);
                      _1628_rhsType = _out1067;
                      Dafny.ISequence<Dafny.Rune> _1629_recursiveGen;
                      bool _1630___v51;
                      bool _1631___v52;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1632_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1068;
                      bool _out1069;
                      bool _out1070;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                      DCOMP.COMP.GenExpr(_466_expr, @params, true, out _out1068, out _out1069, out _out1070, out _out1071);
                      _1629_recursiveGen = _out1068;
                      _1630___v51 = _out1069;
                      _1631___v52 = _out1070;
                      _1632_recIdents = _out1071;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1629_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1632_recIdents;
                    }
                  } else if (_source61.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1633_recursiveGen;
                      bool _1634_recOwned;
                      bool _1635_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1636_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1072;
                      bool _out1073;
                      bool _out1074;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                      _1633_recursiveGen = _out1072;
                      _1634_recOwned = _out1073;
                      _1635_recErased = _out1074;
                      _1636_recIdents = _out1075;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1633_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1634_recOwned;
                      isErased = _1635_recErased;
                      readIdents = _1636_recIdents;
                    }
                  } else if (_source61.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1637_recursiveGen;
                      bool _1638_recOwned;
                      bool _1639_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1640_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1076;
                      bool _out1077;
                      bool _out1078;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                      _1637_recursiveGen = _out1076;
                      _1638_recOwned = _out1077;
                      _1639_recErased = _out1078;
                      _1640_recIdents = _out1079;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1637_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1638_recOwned;
                      isErased = _1639_recErased;
                      readIdents = _1640_recIdents;
                    }
                  } else if (_source61.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1641_recursiveGen;
                      bool _1642_recOwned;
                      bool _1643_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1644_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1080;
                      bool _out1081;
                      bool _out1082;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                      _1641_recursiveGen = _out1080;
                      _1642_recOwned = _out1081;
                      _1643_recErased = _out1082;
                      _1644_recIdents = _out1083;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1641_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1642_recOwned;
                      isErased = _1643_recErased;
                      readIdents = _1644_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1645_recursiveGen;
                      bool _1646_recOwned;
                      bool _1647_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1648_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1084;
                      bool _out1085;
                      bool _out1086;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                      _1645_recursiveGen = _out1084;
                      _1646_recOwned = _out1085;
                      _1647_recErased = _out1086;
                      _1648_recIdents = _out1087;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1646_recOwned;
                      isErased = _1647_recErased;
                      readIdents = _1648_recIdents;
                    }
                  }
                } else if (_source59.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1649___mcc_h726 = _source59.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1650_recursiveGen;
                    bool _1651_recOwned;
                    bool _1652_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1653_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1088;
                    bool _out1089;
                    bool _out1090;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1091;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1088, out _out1089, out _out1090, out _out1091);
                    _1650_recursiveGen = _out1088;
                    _1651_recOwned = _out1089;
                    _1652_recErased = _out1090;
                    _1653_recIdents = _out1091;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1650_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1651_recOwned;
                    isErased = _1652_recErased;
                    readIdents = _1653_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1654___mcc_h728 = _source59.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1655_recursiveGen;
                    bool _1656_recOwned;
                    bool _1657_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1658_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1092;
                    bool _out1093;
                    bool _out1094;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1095;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1092, out _out1093, out _out1094, out _out1095);
                    _1655_recursiveGen = _out1092;
                    _1656_recOwned = _out1093;
                    _1657_recErased = _out1094;
                    _1658_recIdents = _out1095;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1655_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1656_recOwned;
                    isErased = _1657_recErased;
                    readIdents = _1658_recIdents;
                  }
                }
              }
            } else if (_source26.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1659___mcc_h730 = _source26.dtor_Passthrough_a0;
              DAST._IType _source62 = _472___mcc_h121;
              if (_source62.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1660___mcc_h733 = _source62.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1661___mcc_h734 = _source62.dtor_typeArgs;
                DAST._IResolvedType _1662___mcc_h735 = _source62.dtor_resolved;
                DAST._IResolvedType _source63 = _1662___mcc_h735;
                if (_source63.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1663___mcc_h739 = _source63.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1664_recursiveGen;
                    bool _1665_recOwned;
                    bool _1666_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1667_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1096;
                    bool _out1097;
                    bool _out1098;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1099;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1096, out _out1097, out _out1098, out _out1099);
                    _1664_recursiveGen = _out1096;
                    _1665_recOwned = _out1097;
                    _1666_recErased = _out1098;
                    _1667_recIdents = _out1099;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1664_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1665_recOwned;
                    isErased = _1666_recErased;
                    readIdents = _1667_recIdents;
                  }
                } else if (_source63.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1668___mcc_h741 = _source63.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1669_recursiveGen;
                    bool _1670_recOwned;
                    bool _1671_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1672_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1100;
                    bool _out1101;
                    bool _out1102;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1103;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1100, out _out1101, out _out1102, out _out1103);
                    _1669_recursiveGen = _out1100;
                    _1670_recOwned = _out1101;
                    _1671_recErased = _out1102;
                    _1672_recIdents = _out1103;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1669_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1670_recOwned;
                    isErased = _1671_recErased;
                    readIdents = _1672_recIdents;
                  }
                } else {
                  DAST._IType _1673___mcc_h743 = _source63.dtor_Newtype_a0;
                  DAST._IType _1674_b = _1673___mcc_h743;
                  {
                    if (object.Equals(_465_fromTpe, _1674_b)) {
                      Dafny.ISequence<Dafny.Rune> _1675_recursiveGen;
                      bool _1676_recOwned;
                      bool _1677_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1678_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1104;
                      bool _out1105;
                      bool _out1106;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1107;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1104, out _out1105, out _out1106, out _out1107);
                      _1675_recursiveGen = _out1104;
                      _1676_recOwned = _out1105;
                      _1677_recErased = _out1106;
                      _1678_recIdents = _out1107;
                      Dafny.ISequence<Dafny.Rune> _1679_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1108;
                      _out1108 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _1679_rhsType = _out1108;
                      Dafny.ISequence<Dafny.Rune> _1680_uneraseFn;
                      _1680_uneraseFn = ((_1676_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1679_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1680_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1675_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1676_recOwned;
                      isErased = false;
                      readIdents = _1678_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1109;
                      bool _out1110;
                      bool _out1111;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1674_b), _1674_b, _464_toTpe), @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                      s = _out1109;
                      isOwned = _out1110;
                      isErased = _out1111;
                      readIdents = _out1112;
                    }
                  }
                }
              } else if (_source62.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1681___mcc_h745 = _source62.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1682_recursiveGen;
                  bool _1683_recOwned;
                  bool _1684_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1685_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1113;
                  bool _out1114;
                  bool _out1115;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                  _1682_recursiveGen = _out1113;
                  _1683_recOwned = _out1114;
                  _1684_recErased = _out1115;
                  _1685_recIdents = _out1116;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1683_recOwned;
                  isErased = _1684_recErased;
                  readIdents = _1685_recIdents;
                }
              } else if (_source62.is_Array) {
                DAST._IType _1686___mcc_h747 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1687_recursiveGen;
                  bool _1688_recOwned;
                  bool _1689_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1690_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1117;
                  bool _out1118;
                  bool _out1119;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                  _1687_recursiveGen = _out1117;
                  _1688_recOwned = _out1118;
                  _1689_recErased = _out1119;
                  _1690_recIdents = _out1120;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1687_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1688_recOwned;
                  isErased = _1689_recErased;
                  readIdents = _1690_recIdents;
                }
              } else if (_source62.is_Seq) {
                DAST._IType _1691___mcc_h749 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1692_recursiveGen;
                  bool _1693_recOwned;
                  bool _1694_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1695_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1121;
                  bool _out1122;
                  bool _out1123;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                  _1692_recursiveGen = _out1121;
                  _1693_recOwned = _out1122;
                  _1694_recErased = _out1123;
                  _1695_recIdents = _out1124;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1692_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1693_recOwned;
                  isErased = _1694_recErased;
                  readIdents = _1695_recIdents;
                }
              } else if (_source62.is_Set) {
                DAST._IType _1696___mcc_h751 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1697_recursiveGen;
                  bool _1698_recOwned;
                  bool _1699_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1700_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1125;
                  bool _out1126;
                  bool _out1127;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                  _1697_recursiveGen = _out1125;
                  _1698_recOwned = _out1126;
                  _1699_recErased = _out1127;
                  _1700_recIdents = _out1128;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1697_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1698_recOwned;
                  isErased = _1699_recErased;
                  readIdents = _1700_recIdents;
                }
              } else if (_source62.is_Multiset) {
                DAST._IType _1701___mcc_h753 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1702_recursiveGen;
                  bool _1703_recOwned;
                  bool _1704_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1705_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1129;
                  bool _out1130;
                  bool _out1131;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                  _1702_recursiveGen = _out1129;
                  _1703_recOwned = _out1130;
                  _1704_recErased = _out1131;
                  _1705_recIdents = _out1132;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1702_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1703_recOwned;
                  isErased = _1704_recErased;
                  readIdents = _1705_recIdents;
                }
              } else if (_source62.is_Map) {
                DAST._IType _1706___mcc_h755 = _source62.dtor_key;
                DAST._IType _1707___mcc_h756 = _source62.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1708_recursiveGen;
                  bool _1709_recOwned;
                  bool _1710_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1711_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1133;
                  bool _out1134;
                  bool _out1135;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                  _1708_recursiveGen = _out1133;
                  _1709_recOwned = _out1134;
                  _1710_recErased = _out1135;
                  _1711_recIdents = _out1136;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1708_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1709_recOwned;
                  isErased = _1710_recErased;
                  readIdents = _1711_recIdents;
                }
              } else if (_source62.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1712___mcc_h759 = _source62.dtor_args;
                DAST._IType _1713___mcc_h760 = _source62.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1714_recursiveGen;
                  bool _1715_recOwned;
                  bool _1716_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1717_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1137;
                  bool _out1138;
                  bool _out1139;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                  _1714_recursiveGen = _out1137;
                  _1715_recOwned = _out1138;
                  _1716_recErased = _out1139;
                  _1717_recIdents = _out1140;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1714_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1715_recOwned;
                  isErased = _1716_recErased;
                  readIdents = _1717_recIdents;
                }
              } else if (_source62.is_Primitive) {
                DAST._IPrimitive _1718___mcc_h763 = _source62.dtor_Primitive_a0;
                DAST._IPrimitive _source64 = _1718___mcc_h763;
                if (_source64.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1719_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1141;
                    _out1141 = DCOMP.COMP.GenType(_465_fromTpe, true, false);
                    _1719_rhsType = _out1141;
                    Dafny.ISequence<Dafny.Rune> _1720_recursiveGen;
                    bool _1721___v47;
                    bool _1722___v48;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1723_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1142;
                    bool _out1143;
                    bool _out1144;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1145;
                    DCOMP.COMP.GenExpr(_466_expr, @params, true, out _out1142, out _out1143, out _out1144, out _out1145);
                    _1720_recursiveGen = _out1142;
                    _1721___v47 = _out1143;
                    _1722___v48 = _out1144;
                    _1723_recIdents = _out1145;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1720_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1723_recIdents;
                  }
                } else if (_source64.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1724_recursiveGen;
                    bool _1725_recOwned;
                    bool _1726_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1727_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1146;
                    bool _out1147;
                    bool _out1148;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1149;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1146, out _out1147, out _out1148, out _out1149);
                    _1724_recursiveGen = _out1146;
                    _1725_recOwned = _out1147;
                    _1726_recErased = _out1148;
                    _1727_recIdents = _out1149;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1724_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1725_recOwned;
                    isErased = _1726_recErased;
                    readIdents = _1727_recIdents;
                  }
                } else if (_source64.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1728_recursiveGen;
                    bool _1729_recOwned;
                    bool _1730_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1731_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1150;
                    bool _out1151;
                    bool _out1152;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1153;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1150, out _out1151, out _out1152, out _out1153);
                    _1728_recursiveGen = _out1150;
                    _1729_recOwned = _out1151;
                    _1730_recErased = _out1152;
                    _1731_recIdents = _out1153;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1728_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1729_recOwned;
                    isErased = _1730_recErased;
                    readIdents = _1731_recIdents;
                  }
                } else if (_source64.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1732_recursiveGen;
                    bool _1733_recOwned;
                    bool _1734_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1735_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1154;
                    bool _out1155;
                    bool _out1156;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1157;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1154, out _out1155, out _out1156, out _out1157);
                    _1732_recursiveGen = _out1154;
                    _1733_recOwned = _out1155;
                    _1734_recErased = _out1156;
                    _1735_recIdents = _out1157;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1732_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1733_recOwned;
                    isErased = _1734_recErased;
                    readIdents = _1735_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1736_recursiveGen;
                    bool _1737_recOwned;
                    bool _1738_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1739_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1158;
                    bool _out1159;
                    bool _out1160;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                    _1736_recursiveGen = _out1158;
                    _1737_recOwned = _out1159;
                    _1738_recErased = _out1160;
                    _1739_recIdents = _out1161;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1736_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1737_recOwned;
                    isErased = _1738_recErased;
                    readIdents = _1739_recIdents;
                  }
                }
              } else if (_source62.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1740___mcc_h765 = _source62.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1741_recursiveGen;
                  bool _1742___v55;
                  bool _1743___v56;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1744_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1162;
                  bool _out1163;
                  bool _out1164;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                  DCOMP.COMP.GenExpr(_466_expr, @params, true, out _out1162, out _out1163, out _out1164, out _out1165);
                  _1741_recursiveGen = _out1162;
                  _1742___v55 = _out1163;
                  _1743___v56 = _out1164;
                  _1744_recIdents = _out1165;
                  Dafny.ISequence<Dafny.Rune> _1745_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1166;
                  _out1166 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                  _1745_toTpeGen = _out1166;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1741_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1745_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1744_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1746___mcc_h767 = _source62.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1747_recursiveGen;
                  bool _1748_recOwned;
                  bool _1749_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1750_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1167;
                  bool _out1168;
                  bool _out1169;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1170;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1167, out _out1168, out _out1169, out _out1170);
                  _1747_recursiveGen = _out1167;
                  _1748_recOwned = _out1168;
                  _1749_recErased = _out1169;
                  _1750_recIdents = _out1170;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1747_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1748_recOwned;
                  isErased = _1749_recErased;
                  readIdents = _1750_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1751___mcc_h769 = _source26.dtor_TypeArg_a0;
              DAST._IType _source65 = _472___mcc_h121;
              if (_source65.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1752___mcc_h772 = _source65.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1753___mcc_h773 = _source65.dtor_typeArgs;
                DAST._IResolvedType _1754___mcc_h774 = _source65.dtor_resolved;
                DAST._IResolvedType _source66 = _1754___mcc_h774;
                if (_source66.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1755___mcc_h778 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1756_recursiveGen;
                    bool _1757_recOwned;
                    bool _1758_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1759_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1171;
                    bool _out1172;
                    bool _out1173;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1174;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1171, out _out1172, out _out1173, out _out1174);
                    _1756_recursiveGen = _out1171;
                    _1757_recOwned = _out1172;
                    _1758_recErased = _out1173;
                    _1759_recIdents = _out1174;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1756_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1757_recOwned;
                    isErased = _1758_recErased;
                    readIdents = _1759_recIdents;
                  }
                } else if (_source66.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1760___mcc_h780 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1761_recursiveGen;
                    bool _1762_recOwned;
                    bool _1763_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1764_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1175;
                    bool _out1176;
                    bool _out1177;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1178;
                    DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1175, out _out1176, out _out1177, out _out1178);
                    _1761_recursiveGen = _out1175;
                    _1762_recOwned = _out1176;
                    _1763_recErased = _out1177;
                    _1764_recIdents = _out1178;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1761_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1762_recOwned;
                    isErased = _1763_recErased;
                    readIdents = _1764_recIdents;
                  }
                } else {
                  DAST._IType _1765___mcc_h782 = _source66.dtor_Newtype_a0;
                  DAST._IType _1766_b = _1765___mcc_h782;
                  {
                    if (object.Equals(_465_fromTpe, _1766_b)) {
                      Dafny.ISequence<Dafny.Rune> _1767_recursiveGen;
                      bool _1768_recOwned;
                      bool _1769_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1770_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1179;
                      bool _out1180;
                      bool _out1181;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1182;
                      DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1179, out _out1180, out _out1181, out _out1182);
                      _1767_recursiveGen = _out1179;
                      _1768_recOwned = _out1180;
                      _1769_recErased = _out1181;
                      _1770_recIdents = _out1182;
                      Dafny.ISequence<Dafny.Rune> _1771_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1183;
                      _out1183 = DCOMP.COMP.GenType(_464_toTpe, true, false);
                      _1771_rhsType = _out1183;
                      Dafny.ISequence<Dafny.Rune> _1772_uneraseFn;
                      _1772_uneraseFn = ((_1768_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1771_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1772_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1767_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1768_recOwned;
                      isErased = false;
                      readIdents = _1770_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1184;
                      bool _out1185;
                      bool _out1186;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1187;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_466_expr, _465_fromTpe, _1766_b), _1766_b, _464_toTpe), @params, mustOwn, out _out1184, out _out1185, out _out1186, out _out1187);
                      s = _out1184;
                      isOwned = _out1185;
                      isErased = _out1186;
                      readIdents = _out1187;
                    }
                  }
                }
              } else if (_source65.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1773___mcc_h784 = _source65.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1774_recursiveGen;
                  bool _1775_recOwned;
                  bool _1776_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1777_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1188;
                  bool _out1189;
                  bool _out1190;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1191;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1188, out _out1189, out _out1190, out _out1191);
                  _1774_recursiveGen = _out1188;
                  _1775_recOwned = _out1189;
                  _1776_recErased = _out1190;
                  _1777_recIdents = _out1191;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1774_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1775_recOwned;
                  isErased = _1776_recErased;
                  readIdents = _1777_recIdents;
                }
              } else if (_source65.is_Array) {
                DAST._IType _1778___mcc_h786 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1779_recursiveGen;
                  bool _1780_recOwned;
                  bool _1781_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1782_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1192;
                  bool _out1193;
                  bool _out1194;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1195;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1192, out _out1193, out _out1194, out _out1195);
                  _1779_recursiveGen = _out1192;
                  _1780_recOwned = _out1193;
                  _1781_recErased = _out1194;
                  _1782_recIdents = _out1195;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1779_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1780_recOwned;
                  isErased = _1781_recErased;
                  readIdents = _1782_recIdents;
                }
              } else if (_source65.is_Seq) {
                DAST._IType _1783___mcc_h788 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1784_recursiveGen;
                  bool _1785_recOwned;
                  bool _1786_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1787_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1196;
                  bool _out1197;
                  bool _out1198;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1199;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1196, out _out1197, out _out1198, out _out1199);
                  _1784_recursiveGen = _out1196;
                  _1785_recOwned = _out1197;
                  _1786_recErased = _out1198;
                  _1787_recIdents = _out1199;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1784_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1785_recOwned;
                  isErased = _1786_recErased;
                  readIdents = _1787_recIdents;
                }
              } else if (_source65.is_Set) {
                DAST._IType _1788___mcc_h790 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1789_recursiveGen;
                  bool _1790_recOwned;
                  bool _1791_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1792_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1200;
                  bool _out1201;
                  bool _out1202;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1203;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1200, out _out1201, out _out1202, out _out1203);
                  _1789_recursiveGen = _out1200;
                  _1790_recOwned = _out1201;
                  _1791_recErased = _out1202;
                  _1792_recIdents = _out1203;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1789_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1790_recOwned;
                  isErased = _1791_recErased;
                  readIdents = _1792_recIdents;
                }
              } else if (_source65.is_Multiset) {
                DAST._IType _1793___mcc_h792 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1794_recursiveGen;
                  bool _1795_recOwned;
                  bool _1796_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1797_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1204;
                  bool _out1205;
                  bool _out1206;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1207;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1204, out _out1205, out _out1206, out _out1207);
                  _1794_recursiveGen = _out1204;
                  _1795_recOwned = _out1205;
                  _1796_recErased = _out1206;
                  _1797_recIdents = _out1207;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1794_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1795_recOwned;
                  isErased = _1796_recErased;
                  readIdents = _1797_recIdents;
                }
              } else if (_source65.is_Map) {
                DAST._IType _1798___mcc_h794 = _source65.dtor_key;
                DAST._IType _1799___mcc_h795 = _source65.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1800_recursiveGen;
                  bool _1801_recOwned;
                  bool _1802_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1803_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1208;
                  bool _out1209;
                  bool _out1210;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1211;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1208, out _out1209, out _out1210, out _out1211);
                  _1800_recursiveGen = _out1208;
                  _1801_recOwned = _out1209;
                  _1802_recErased = _out1210;
                  _1803_recIdents = _out1211;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1800_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1801_recOwned;
                  isErased = _1802_recErased;
                  readIdents = _1803_recIdents;
                }
              } else if (_source65.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1804___mcc_h798 = _source65.dtor_args;
                DAST._IType _1805___mcc_h799 = _source65.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1806_recursiveGen;
                  bool _1807_recOwned;
                  bool _1808_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1809_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1212;
                  bool _out1213;
                  bool _out1214;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1215;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1212, out _out1213, out _out1214, out _out1215);
                  _1806_recursiveGen = _out1212;
                  _1807_recOwned = _out1213;
                  _1808_recErased = _out1214;
                  _1809_recIdents = _out1215;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1806_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1807_recOwned;
                  isErased = _1808_recErased;
                  readIdents = _1809_recIdents;
                }
              } else if (_source65.is_Primitive) {
                DAST._IPrimitive _1810___mcc_h802 = _source65.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1811_recursiveGen;
                  bool _1812_recOwned;
                  bool _1813_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1814_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1216;
                  bool _out1217;
                  bool _out1218;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1219;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1216, out _out1217, out _out1218, out _out1219);
                  _1811_recursiveGen = _out1216;
                  _1812_recOwned = _out1217;
                  _1813_recErased = _out1218;
                  _1814_recIdents = _out1219;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1811_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1812_recOwned;
                  isErased = _1813_recErased;
                  readIdents = _1814_recIdents;
                }
              } else if (_source65.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1815___mcc_h804 = _source65.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1816_recursiveGen;
                  bool _1817_recOwned;
                  bool _1818_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1819_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1220;
                  bool _out1221;
                  bool _out1222;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1223;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1220, out _out1221, out _out1222, out _out1223);
                  _1816_recursiveGen = _out1220;
                  _1817_recOwned = _out1221;
                  _1818_recErased = _out1222;
                  _1819_recIdents = _out1223;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1816_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1817_recOwned;
                  isErased = _1818_recErased;
                  readIdents = _1819_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1820___mcc_h806 = _source65.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1821_recursiveGen;
                  bool _1822_recOwned;
                  bool _1823_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1824_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1224;
                  bool _out1225;
                  bool _out1226;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1227;
                  DCOMP.COMP.GenExpr(_466_expr, @params, mustOwn, out _out1224, out _out1225, out _out1226, out _out1227);
                  _1821_recursiveGen = _out1224;
                  _1822_recOwned = _out1225;
                  _1823_recErased = _out1226;
                  _1824_recIdents = _out1227;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1821_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1822_recOwned;
                  isErased = _1823_recErased;
                  readIdents = _1824_recIdents;
                }
              }
            }
          }
        }
      } else if (_source19.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _1825___mcc_h22 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1826_exprs = _1825___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1827_generatedValues;
          _1827_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1828_i;
          _1828_i = BigInteger.Zero;
          bool _1829_allErased;
          _1829_allErased = true;
          while ((_1828_i) < (new BigInteger((_1826_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1830_recursiveGen;
            bool _1831___v58;
            bool _1832_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1833_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1228;
            bool _out1229;
            bool _out1230;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1231;
            DCOMP.COMP.GenExpr((_1826_exprs).Select(_1828_i), @params, true, out _out1228, out _out1229, out _out1230, out _out1231);
            _1830_recursiveGen = _out1228;
            _1831___v58 = _out1229;
            _1832_isErased = _out1230;
            _1833_recIdents = _out1231;
            _1829_allErased = (_1829_allErased) && (_1832_isErased);
            _1827_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1827_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1830_recursiveGen, _1832_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1833_recIdents);
            _1828_i = (_1828_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1828_i = BigInteger.Zero;
          while ((_1828_i) < (new BigInteger((_1827_generatedValues).Count))) {
            if ((_1828_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1834_gen;
            _1834_gen = ((_1827_generatedValues).Select(_1828_i)).dtor__0;
            if ((((_1827_generatedValues).Select(_1828_i)).dtor__1) && (!(_1829_allErased))) {
              _1834_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1834_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1834_gen);
            _1828_i = (_1828_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _1829_allErased;
        }
      } else if (_source19.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _1835___mcc_h23 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1836_exprs = _1835___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1837_generatedValues;
          _1837_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1838_i;
          _1838_i = BigInteger.Zero;
          bool _1839_allErased;
          _1839_allErased = true;
          while ((_1838_i) < (new BigInteger((_1836_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1840_recursiveGen;
            bool _1841___v59;
            bool _1842_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1843_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1232;
            bool _out1233;
            bool _out1234;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1235;
            DCOMP.COMP.GenExpr((_1836_exprs).Select(_1838_i), @params, true, out _out1232, out _out1233, out _out1234, out _out1235);
            _1840_recursiveGen = _out1232;
            _1841___v59 = _out1233;
            _1842_isErased = _out1234;
            _1843_recIdents = _out1235;
            _1839_allErased = (_1839_allErased) && (_1842_isErased);
            _1837_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1837_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1840_recursiveGen, _1842_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1843_recIdents);
            _1838_i = (_1838_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1838_i = BigInteger.Zero;
          while ((_1838_i) < (new BigInteger((_1837_generatedValues).Count))) {
            if ((_1838_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1844_gen;
            _1844_gen = ((_1837_generatedValues).Select(_1838_i)).dtor__0;
            if ((((_1837_generatedValues).Select(_1838_i)).dtor__1) && (!(_1839_allErased))) {
              _1844_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1844_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1844_gen);
            _1838_i = (_1838_i) + (BigInteger.One);
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
        DAST._IExpression _1845___mcc_h24 = _source19.dtor_cond;
        DAST._IExpression _1846___mcc_h25 = _source19.dtor_thn;
        DAST._IExpression _1847___mcc_h26 = _source19.dtor_els;
        DAST._IExpression _1848_f = _1847___mcc_h26;
        DAST._IExpression _1849_t = _1846___mcc_h25;
        DAST._IExpression _1850_cond = _1845___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _1851_condString;
          bool _1852___v60;
          bool _1853_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1854_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1236;
          bool _out1237;
          bool _out1238;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
          DCOMP.COMP.GenExpr(_1850_cond, @params, true, out _out1236, out _out1237, out _out1238, out _out1239);
          _1851_condString = _out1236;
          _1852___v60 = _out1237;
          _1853_condErased = _out1238;
          _1854_recIdentsCond = _out1239;
          if (!(_1853_condErased)) {
            _1851_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1851_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _1855___v61;
          bool _1856_tHasToBeOwned;
          bool _1857___v62;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1858___v63;
          Dafny.ISequence<Dafny.Rune> _out1240;
          bool _out1241;
          bool _out1242;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
          DCOMP.COMP.GenExpr(_1849_t, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
          _1855___v61 = _out1240;
          _1856_tHasToBeOwned = _out1241;
          _1857___v62 = _out1242;
          _1858___v63 = _out1243;
          Dafny.ISequence<Dafny.Rune> _1859_fString;
          bool _1860_fOwned;
          bool _1861_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1862_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1244;
          bool _out1245;
          bool _out1246;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
          DCOMP.COMP.GenExpr(_1848_f, @params, _1856_tHasToBeOwned, out _out1244, out _out1245, out _out1246, out _out1247);
          _1859_fString = _out1244;
          _1860_fOwned = _out1245;
          _1861_fErased = _out1246;
          _1862_recIdentsF = _out1247;
          Dafny.ISequence<Dafny.Rune> _1863_tString;
          bool _1864___v64;
          bool _1865_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1866_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1248;
          bool _out1249;
          bool _out1250;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
          DCOMP.COMP.GenExpr(_1849_t, @params, _1860_fOwned, out _out1248, out _out1249, out _out1250, out _out1251);
          _1863_tString = _out1248;
          _1864___v64 = _out1249;
          _1865_tErased = _out1250;
          _1866_recIdentsT = _out1251;
          if ((!(_1861_fErased)) || (!(_1865_tErased))) {
            if (_1861_fErased) {
              _1859_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1859_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_1865_tErased) {
              _1863_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1863_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _1851_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _1863_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _1859_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _1860_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1854_recIdentsCond, _1866_recIdentsT), _1862_recIdentsF);
          isErased = (_1861_fErased) || (_1865_tErased);
        }
      } else if (_source19.is_UnOp) {
        DAST._IUnaryOp _1867___mcc_h27 = _source19.dtor_unOp;
        DAST._IExpression _1868___mcc_h28 = _source19.dtor_expr;
        DAST._IUnaryOp _source67 = _1867___mcc_h27;
        if (_source67.is_Not) {
          DAST._IExpression _1869_e = _1868___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _1870_recursiveGen;
            bool _1871___v65;
            bool _1872_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1873_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1252;
            bool _out1253;
            bool _out1254;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
            DCOMP.COMP.GenExpr(_1869_e, @params, true, out _out1252, out _out1253, out _out1254, out _out1255);
            _1870_recursiveGen = _out1252;
            _1871___v65 = _out1253;
            _1872_recErased = _out1254;
            _1873_recIdents = _out1255;
            if (!(_1872_recErased)) {
              _1870_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1870_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _1870_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1873_recIdents;
            isErased = true;
          }
        } else if (_source67.is_BitwiseNot) {
          DAST._IExpression _1874_e = _1868___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _1875_recursiveGen;
            bool _1876___v66;
            bool _1877_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1878_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1256;
            bool _out1257;
            bool _out1258;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
            DCOMP.COMP.GenExpr(_1874_e, @params, true, out _out1256, out _out1257, out _out1258, out _out1259);
            _1875_recursiveGen = _out1256;
            _1876___v66 = _out1257;
            _1877_recErased = _out1258;
            _1878_recIdents = _out1259;
            if (!(_1877_recErased)) {
              _1875_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1875_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _1875_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1878_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _1879_e = _1868___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _1880_recursiveGen;
            bool _1881___v67;
            bool _1882_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1883_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1260;
            bool _out1261;
            bool _out1262;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
            DCOMP.COMP.GenExpr(_1879_e, @params, false, out _out1260, out _out1261, out _out1262, out _out1263);
            _1880_recursiveGen = _out1260;
            _1881___v67 = _out1261;
            _1882_recErased = _out1262;
            _1883_recIdents = _out1263;
            if (!(_1882_recErased)) {
              _1880_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1880_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1880_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len()"));
            isOwned = true;
            readIdents = _1883_recIdents;
            isErased = true;
          }
        }
      } else if (_source19.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _1884___mcc_h29 = _source19.dtor_op;
        DAST._IExpression _1885___mcc_h30 = _source19.dtor_left;
        DAST._IExpression _1886___mcc_h31 = _source19.dtor_right;
        DAST._IExpression _1887_r = _1886___mcc_h31;
        DAST._IExpression _1888_l = _1885___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _1889_op = _1884___mcc_h29;
        {
          Dafny.ISequence<Dafny.Rune> _1890_left;
          bool _1891___v68;
          bool _1892_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1893_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1264;
          bool _out1265;
          bool _out1266;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1267;
          DCOMP.COMP.GenExpr(_1888_l, @params, true, out _out1264, out _out1265, out _out1266, out _out1267);
          _1890_left = _out1264;
          _1891___v68 = _out1265;
          _1892_leftErased = _out1266;
          _1893_recIdentsL = _out1267;
          Dafny.ISequence<Dafny.Rune> _1894_right;
          bool _1895___v69;
          bool _1896_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1897_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1268;
          bool _out1269;
          bool _out1270;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1271;
          DCOMP.COMP.GenExpr(_1887_r, @params, true, out _out1268, out _out1269, out _out1270, out _out1271);
          _1894_right = _out1268;
          _1895___v69 = _out1269;
          _1896_rightErased = _out1270;
          _1897_recIdentsR = _out1271;
          if (!(_1892_leftErased)) {
            _1890_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1890_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_1896_rightErased)) {
            _1894_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1894_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1889_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _1890_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1894_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_1889_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _1890_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1894_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1890_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1889_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1894_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1893_recIdentsL, _1897_recIdentsR);
          isErased = true;
        }
      } else if (_source19.is_Select) {
        DAST._IExpression _1898___mcc_h32 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1899___mcc_h33 = _source19.dtor_field;
        bool _1900___mcc_h34 = _source19.dtor_isConstant;
        bool _1901___mcc_h35 = _source19.dtor_onDatatype;
        bool _1902_isDatatype = _1901___mcc_h35;
        bool _1903_isConstant = _1900___mcc_h34;
        Dafny.ISequence<Dafny.Rune> _1904_field = _1899___mcc_h33;
        DAST._IExpression _1905_on = _1898___mcc_h32;
        {
          Dafny.ISequence<Dafny.Rune> _1906_onString;
          bool _1907_onOwned;
          bool _1908_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1909_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1272;
          bool _out1273;
          bool _out1274;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1275;
          DCOMP.COMP.GenExpr(_1905_on, @params, false, out _out1272, out _out1273, out _out1274, out _out1275);
          _1906_onString = _out1272;
          _1907_onOwned = _out1273;
          _1908_onErased = _out1274;
          _1909_recIdents = _out1275;
          if (!(_1908_onErased)) {
            Dafny.ISequence<Dafny.Rune> _1910_eraseFn;
            _1910_eraseFn = ((_1907_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _1906_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1910_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1906_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1902_isDatatype) || (_1903_isConstant)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1906_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1904_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            if (_1903_isConstant) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            }
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _1906_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1904_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          }
          isErased = false;
          readIdents = _1909_recIdents;
        }
      } else if (_source19.is_SelectFn) {
        DAST._IExpression _1911___mcc_h36 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1912___mcc_h37 = _source19.dtor_field;
        bool _1913___mcc_h38 = _source19.dtor_onDatatype;
        bool _1914___mcc_h39 = _source19.dtor_isStatic;
        BigInteger _1915___mcc_h40 = _source19.dtor_arity;
        BigInteger _1916_arity = _1915___mcc_h40;
        bool _1917_isStatic = _1914___mcc_h39;
        bool _1918_isDatatype = _1913___mcc_h38;
        Dafny.ISequence<Dafny.Rune> _1919_field = _1912___mcc_h37;
        DAST._IExpression _1920_on = _1911___mcc_h36;
        {
          Dafny.ISequence<Dafny.Rune> _1921_onString;
          bool _1922_onOwned;
          bool _1923___v70;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1924_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1276;
          bool _out1277;
          bool _out1278;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1279;
          DCOMP.COMP.GenExpr(_1920_on, @params, false, out _out1276, out _out1277, out _out1278, out _out1279);
          _1921_onString = _out1276;
          _1922_onOwned = _out1277;
          _1923___v70 = _out1278;
          _1924_recIdents = _out1279;
          if (_1917_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1921_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _1919_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _1921_onString), ((_1922_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _1925_args;
            _1925_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _1926_i;
            _1926_i = BigInteger.Zero;
            while ((_1926_i) < (_1916_arity)) {
              if ((_1926_i).Sign == 1) {
                _1925_args = Dafny.Sequence<Dafny.Rune>.Concat(_1925_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _1925_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1925_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_1926_i));
              _1926_i = (_1926_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _1925_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _1919_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1925_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _1924_recIdents;
        }
      } else if (_source19.is_TupleSelect) {
        DAST._IExpression _1927___mcc_h41 = _source19.dtor_expr;
        BigInteger _1928___mcc_h42 = _source19.dtor_index;
        BigInteger _1929_idx = _1928___mcc_h42;
        DAST._IExpression _1930_on = _1927___mcc_h41;
        {
          Dafny.ISequence<Dafny.Rune> _1931_onString;
          bool _1932___v71;
          bool _1933_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1934_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1280;
          bool _out1281;
          bool _out1282;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1283;
          DCOMP.COMP.GenExpr(_1930_on, @params, false, out _out1280, out _out1281, out _out1282, out _out1283);
          _1931_onString = _out1280;
          _1932___v71 = _out1281;
          _1933_tupErased = _out1282;
          _1934_recIdents = _out1283;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1931_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_1929_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _1933_tupErased;
          readIdents = _1934_recIdents;
        }
      } else if (_source19.is_Call) {
        DAST._IExpression _1935___mcc_h43 = _source19.dtor_on;
        Dafny.ISequence<Dafny.Rune> _1936___mcc_h44 = _source19.dtor_name;
        Dafny.ISequence<DAST._IType> _1937___mcc_h45 = _source19.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _1938___mcc_h46 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _1939_args = _1938___mcc_h46;
        Dafny.ISequence<DAST._IType> _1940_typeArgs = _1937___mcc_h45;
        Dafny.ISequence<Dafny.Rune> _1941_name = _1936___mcc_h44;
        DAST._IExpression _1942_on = _1935___mcc_h43;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _1943_typeArgString;
          _1943_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_1940_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _1944_typeI;
            _1944_typeI = BigInteger.Zero;
            _1943_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_1944_typeI) < (new BigInteger((_1940_typeArgs).Count))) {
              if ((_1944_typeI).Sign == 1) {
                _1943_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1943_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _1945_typeString;
              Dafny.ISequence<Dafny.Rune> _out1284;
              _out1284 = DCOMP.COMP.GenType((_1940_typeArgs).Select(_1944_typeI), false, false);
              _1945_typeString = _out1284;
              _1943_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1943_typeArgString, _1945_typeString);
              _1944_typeI = (_1944_typeI) + (BigInteger.One);
            }
            _1943_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1943_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _1946_argString;
          _1946_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _1947_i;
          _1947_i = BigInteger.Zero;
          while ((_1947_i) < (new BigInteger((_1939_args).Count))) {
            if ((_1947_i).Sign == 1) {
              _1946_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1946_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1948_argExpr;
            bool _1949_isOwned;
            bool _1950_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1951_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1285;
            bool _out1286;
            bool _out1287;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1288;
            DCOMP.COMP.GenExpr((_1939_args).Select(_1947_i), @params, false, out _out1285, out _out1286, out _out1287, out _out1288);
            _1948_argExpr = _out1285;
            _1949_isOwned = _out1286;
            _1950_argErased = _out1287;
            _1951_argIdents = _out1288;
            if (_1949_isOwned) {
              _1948_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _1948_argExpr);
            }
            _1946_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1946_argString, _1948_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1951_argIdents);
            _1947_i = (_1947_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _1952_enclosingString;
          bool _1953___v72;
          bool _1954___v73;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1955_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1289;
          bool _out1290;
          bool _out1291;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1292;
          DCOMP.COMP.GenExpr(_1942_on, @params, false, out _out1289, out _out1290, out _out1291, out _out1292);
          _1952_enclosingString = _out1289;
          _1953___v72 = _out1290;
          _1954___v73 = _out1291;
          _1955_recIdents = _out1292;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1955_recIdents);
          DAST._IExpression _source68 = _1942_on;
          if (_source68.is_Literal) {
            DAST._ILiteral _1956___mcc_h808 = _source68.dtor_Literal_a0;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _1957___mcc_h810 = _source68.dtor_Ident_a0;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1958___mcc_h812 = _source68.dtor_Companion_a0;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_1952_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source68.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _1959___mcc_h814 = _source68.dtor_Tuple_a0;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1960___mcc_h816 = _source68.dtor_path;
            Dafny.ISequence<DAST._IExpression> _1961___mcc_h817 = _source68.dtor_args;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _1962___mcc_h820 = _source68.dtor_dims;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1963___mcc_h822 = _source68.dtor_path;
            Dafny.ISequence<Dafny.Rune> _1964___mcc_h823 = _source68.dtor_variant;
            bool _1965___mcc_h824 = _source68.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _1966___mcc_h825 = _source68.dtor_contents;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Convert) {
            DAST._IExpression _1967___mcc_h830 = _source68.dtor_value;
            DAST._IType _1968___mcc_h831 = _source68.dtor_from;
            DAST._IType _1969___mcc_h832 = _source68.dtor_typ;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _1970___mcc_h836 = _source68.dtor_elements;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _1971___mcc_h838 = _source68.dtor_elements;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_This) {
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Ite) {
            DAST._IExpression _1972___mcc_h840 = _source68.dtor_cond;
            DAST._IExpression _1973___mcc_h841 = _source68.dtor_thn;
            DAST._IExpression _1974___mcc_h842 = _source68.dtor_els;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_UnOp) {
            DAST._IUnaryOp _1975___mcc_h846 = _source68.dtor_unOp;
            DAST._IExpression _1976___mcc_h847 = _source68.dtor_expr;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _1977___mcc_h850 = _source68.dtor_op;
            DAST._IExpression _1978___mcc_h851 = _source68.dtor_left;
            DAST._IExpression _1979___mcc_h852 = _source68.dtor_right;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Select) {
            DAST._IExpression _1980___mcc_h856 = _source68.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _1981___mcc_h857 = _source68.dtor_field;
            bool _1982___mcc_h858 = _source68.dtor_isConstant;
            bool _1983___mcc_h859 = _source68.dtor_onDatatype;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_SelectFn) {
            DAST._IExpression _1984___mcc_h864 = _source68.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _1985___mcc_h865 = _source68.dtor_field;
            bool _1986___mcc_h866 = _source68.dtor_onDatatype;
            bool _1987___mcc_h867 = _source68.dtor_isStatic;
            BigInteger _1988___mcc_h868 = _source68.dtor_arity;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_TupleSelect) {
            DAST._IExpression _1989___mcc_h874 = _source68.dtor_expr;
            BigInteger _1990___mcc_h875 = _source68.dtor_index;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Call) {
            DAST._IExpression _1991___mcc_h878 = _source68.dtor_on;
            Dafny.ISequence<Dafny.Rune> _1992___mcc_h879 = _source68.dtor_name;
            Dafny.ISequence<DAST._IType> _1993___mcc_h880 = _source68.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _1994___mcc_h881 = _source68.dtor_args;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _1995___mcc_h886 = _source68.dtor_params;
            DAST._IType _1996___mcc_h887 = _source68.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _1997___mcc_h888 = _source68.dtor_body;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _1998___mcc_h892 = _source68.dtor_name;
            DAST._IType _1999___mcc_h893 = _source68.dtor_typ;
            DAST._IExpression _2000___mcc_h894 = _source68.dtor_value;
            DAST._IExpression _2001___mcc_h895 = _source68.dtor_iifeBody;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Apply) {
            DAST._IExpression _2002___mcc_h900 = _source68.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2003___mcc_h901 = _source68.dtor_args;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_TypeTest) {
            DAST._IExpression _2004___mcc_h904 = _source68.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2005___mcc_h905 = _source68.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2006___mcc_h906 = _source68.dtor_variant;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _2007___mcc_h910 = _source68.dtor_typ;
            {
              _1952_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1952_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_1941_name)), _1943_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1946_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2008___mcc_h47 = _source19.dtor_params;
        DAST._IType _2009___mcc_h48 = _source19.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2010___mcc_h49 = _source19.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2011_body = _2010___mcc_h49;
        DAST._IType _2012_retType = _2009___mcc_h48;
        Dafny.ISequence<DAST._IFormal> _2013_params = _2008___mcc_h47;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2014_paramNames;
          _2014_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2015_i;
          _2015_i = BigInteger.Zero;
          while ((_2015_i) < (new BigInteger((_2013_params).Count))) {
            _2014_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2014_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2013_params).Select(_2015_i)).dtor_name));
            _2015_i = (_2015_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2016_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2017_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1293;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1294;
          DCOMP.COMP.GenStmts(_2011_body, _2014_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1293, out _out1294);
          _2016_recursiveGen = _out1293;
          _2017_recIdents = _out1294;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2018_allReadCloned;
          _2018_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2017_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2019_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2017_recIdents).Elements) {
              _2019_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2017_recIdents).Contains(_2019_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1506)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2014_paramNames).Contains(_2019_next))) {
              _2018_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2018_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2019_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2019_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2019_next));
            }
            _2017_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2017_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2019_next));
          }
          Dafny.ISequence<Dafny.Rune> _2020_paramsString;
          _2020_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2015_i = BigInteger.Zero;
          while ((_2015_i) < (new BigInteger((_2013_params).Count))) {
            if ((_2015_i).Sign == 1) {
              _2020_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2020_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2021_typStr;
            Dafny.ISequence<Dafny.Rune> _out1295;
            _out1295 = DCOMP.COMP.GenType(((_2013_params).Select(_2015_i)).dtor_typ, false, true);
            _2021_typStr = _out1295;
            _2020_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2020_paramsString, ((_2013_params).Select(_2015_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2021_typStr);
            _2015_i = (_2015_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2022_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1296;
          _out1296 = DCOMP.COMP.GenType(_2012_retType, false, true);
          _2022_retTypeGen = _out1296;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _2018_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _2020_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2022_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2016_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2023___mcc_h50 = _source19.dtor_name;
        DAST._IType _2024___mcc_h51 = _source19.dtor_typ;
        DAST._IExpression _2025___mcc_h52 = _source19.dtor_value;
        DAST._IExpression _2026___mcc_h53 = _source19.dtor_iifeBody;
        DAST._IExpression _2027_iifeBody = _2026___mcc_h53;
        DAST._IExpression _2028_value = _2025___mcc_h52;
        DAST._IType _2029_tpe = _2024___mcc_h51;
        Dafny.ISequence<Dafny.Rune> _2030_name = _2023___mcc_h50;
        {
          Dafny.ISequence<Dafny.Rune> _2031_valueGen;
          bool _2032_valueOwned;
          bool _2033_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2034_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1297;
          bool _out1298;
          bool _out1299;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1300;
          DCOMP.COMP.GenExpr(_2028_value, @params, false, out _out1297, out _out1298, out _out1299, out _out1300);
          _2031_valueGen = _out1297;
          _2032_valueOwned = _out1298;
          _2033_valueErased = _out1299;
          _2034_recIdents = _out1300;
          if (_2033_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2035_eraseFn;
            _2035_eraseFn = ((_2032_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2031_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2035_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2031_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2034_recIdents;
          Dafny.ISequence<Dafny.Rune> _2036_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1301;
          _out1301 = DCOMP.COMP.GenType(_2029_tpe, false, true);
          _2036_valueTypeGen = _out1301;
          Dafny.ISequence<Dafny.Rune> _2037_bodyGen;
          bool _2038_bodyOwned;
          bool _2039_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2040_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1302;
          bool _out1303;
          bool _out1304;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
          DCOMP.COMP.GenExpr(_2027_iifeBody, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2032_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2030_name))))), mustOwn, out _out1302, out _out1303, out _out1304, out _out1305);
          _2037_bodyGen = _out1302;
          _2038_bodyOwned = _out1303;
          _2039_bodyErased = _out1304;
          _2040_bodyIdents = _out1305;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2040_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _2041_eraseFn;
          _2041_eraseFn = ((_2032_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2030_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2032_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2036_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2031_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2037_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2038_bodyOwned;
          isErased = _2039_bodyErased;
        }
      } else if (_source19.is_Apply) {
        DAST._IExpression _2042___mcc_h54 = _source19.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2043___mcc_h55 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2044_args = _2043___mcc_h55;
        DAST._IExpression _2045_func = _2042___mcc_h54;
        {
          Dafny.ISequence<Dafny.Rune> _2046_funcString;
          bool _2047___v76;
          bool _2048_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2049_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1306;
          bool _out1307;
          bool _out1308;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1309;
          DCOMP.COMP.GenExpr(_2045_func, @params, false, out _out1306, out _out1307, out _out1308, out _out1309);
          _2046_funcString = _out1306;
          _2047___v76 = _out1307;
          _2048_funcErased = _out1308;
          _2049_recIdents = _out1309;
          readIdents = _2049_recIdents;
          Dafny.ISequence<Dafny.Rune> _2050_argString;
          _2050_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2051_i;
          _2051_i = BigInteger.Zero;
          while ((_2051_i) < (new BigInteger((_2044_args).Count))) {
            if ((_2051_i).Sign == 1) {
              _2050_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2050_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2052_argExpr;
            bool _2053_isOwned;
            bool _2054_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2055_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1310;
            bool _out1311;
            bool _out1312;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1313;
            DCOMP.COMP.GenExpr((_2044_args).Select(_2051_i), @params, false, out _out1310, out _out1311, out _out1312, out _out1313);
            _2052_argExpr = _out1310;
            _2053_isOwned = _out1311;
            _2054_argErased = _out1312;
            _2055_argIdents = _out1313;
            if (_2053_isOwned) {
              _2052_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2052_argExpr);
            }
            _2050_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2050_argString, _2052_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2055_argIdents);
            _2051_i = (_2051_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2046_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2050_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_TypeTest) {
        DAST._IExpression _2056___mcc_h56 = _source19.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2057___mcc_h57 = _source19.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2058___mcc_h58 = _source19.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2059_variant = _2058___mcc_h58;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2060_dType = _2057___mcc_h57;
        DAST._IExpression _2061_on = _2056___mcc_h56;
        {
          Dafny.ISequence<Dafny.Rune> _2062_exprGen;
          bool _2063___v77;
          bool _2064_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2065_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1314;
          bool _out1315;
          bool _out1316;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1317;
          DCOMP.COMP.GenExpr(_2061_on, @params, false, out _out1314, out _out1315, out _out1316, out _out1317);
          _2062_exprGen = _out1314;
          _2063___v77 = _out1315;
          _2064_exprErased = _out1316;
          _2065_recIdents = _out1317;
          Dafny.ISequence<Dafny.Rune> _2066_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1318;
          _out1318 = DCOMP.COMP.GenPath(_2060_dType);
          _2066_dTypePath = _out1318;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2062_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2066_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2059_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2065_recIdents;
        }
      } else {
        DAST._IType _2067___mcc_h59 = _source19.dtor_typ;
        DAST._IType _2068_typ = _2067___mcc_h59;
        {
          Dafny.ISequence<Dafny.Rune> _2069_typString;
          Dafny.ISequence<Dafny.Rune> _out1319;
          _out1319 = DCOMP.COMP.GenType(_2068_typ, false, false);
          _2069_typString = _out1319;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2069_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2070_i;
      _2070_i = BigInteger.Zero;
      while ((_2070_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2071_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1320;
        _out1320 = DCOMP.COMP.GenModule((p).Select(_2070_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2071_generated = _out1320;
        if ((_2070_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2071_generated);
        _2070_i = (_2070_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2072_i;
      _2072_i = BigInteger.Zero;
      while ((_2072_i) < (new BigInteger((fullName).Count))) {
        if ((_2072_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2072_i));
        _2072_i = (_2072_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

