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
    DAST._IOptional<Dafny.ISequence<Dafny.Rune>> dtor_lbl { get; }
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
    public static _IStatement create_While(DAST._IOptional<Dafny.ISequence<Dafny.Rune>> lbl, DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> body) {
      return new Statement_While(lbl, cond, body);
    }
    public static _IStatement create_Foreach(DAST._IOptional<Dafny.ISequence<Dafny.Rune>> lbl, Dafny.ISequence<Dafny.Rune> boundName, DAST._IExpression over, Dafny.ISequence<DAST._IStatement> body) {
      return new Statement_Foreach(lbl, boundName, over, body);
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
    public DAST._IOptional<Dafny.ISequence<Dafny.Rune>> dtor_lbl {
      get {
        var d = this;
        if (d is Statement_While) { return ((Statement_While)d)._lbl; }
        return ((Statement_Foreach)d)._lbl;
      }
    }
    public Dafny.ISequence<DAST._IStatement> dtor_body {
      get {
        var d = this;
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
  public class Statement_While : Statement {
    public readonly DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _lbl;
    public readonly DAST._IExpression _cond;
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public Statement_While(DAST._IOptional<Dafny.ISequence<Dafny.Rune>> lbl, DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> body) : base() {
      this._lbl = lbl;
      this._cond = cond;
      this._body = body;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_While(_lbl, _cond, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_While;
      return oth != null && object.Equals(this._lbl, oth._lbl) && object.Equals(this._cond, oth._cond) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._lbl));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._cond));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.While";
      s += "(";
      s += Dafny.Helpers.ToString(this._lbl);
      s += ", ";
      s += Dafny.Helpers.ToString(this._cond);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
  }
  public class Statement_Foreach : Statement {
    public readonly DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _lbl;
    public readonly Dafny.ISequence<Dafny.Rune> _boundName;
    public readonly DAST._IExpression _over;
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public Statement_Foreach(DAST._IOptional<Dafny.ISequence<Dafny.Rune>> lbl, Dafny.ISequence<Dafny.Rune> boundName, DAST._IExpression over, Dafny.ISequence<DAST._IStatement> body) : base() {
      this._lbl = lbl;
      this._boundName = boundName;
      this._over = over;
      this._body = body;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Foreach(_lbl, _boundName, _over, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Foreach;
      return oth != null && object.Equals(this._lbl, oth._lbl) && object.Equals(this._boundName, oth._boundName) && object.Equals(this._over, oth._over) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 4;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._lbl));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._boundName));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._over));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Foreach";
      s += "(";
      s += Dafny.Helpers.ToString(this._lbl);
      s += ", ";
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
      hash = ((hash << 5) + hash) + 5;
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
      hash = ((hash << 5) + hash) + 6;
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
      hash = ((hash << 5) + hash) + 7;
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
      hash = ((hash << 5) + hash) + 8;
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
      hash = ((hash << 5) + hash) + 9;
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
      hash = ((hash << 5) + hash) + 10;
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
      hash = ((hash << 5) + hash) + 11;
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
      hash = ((hash << 5) + hash) + 12;
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
        } else if (_source13.is_While) {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _219___mcc_h16 = _source13.dtor_lbl;
          DAST._IExpression _220___mcc_h17 = _source13.dtor_cond;
          Dafny.ISequence<DAST._IStatement> _221___mcc_h18 = _source13.dtor_body;
        } else if (_source13.is_Foreach) {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _222___mcc_h22 = _source13.dtor_lbl;
          Dafny.ISequence<Dafny.Rune> _223___mcc_h23 = _source13.dtor_boundName;
          DAST._IExpression _224___mcc_h24 = _source13.dtor_over;
          Dafny.ISequence<DAST._IStatement> _225___mcc_h25 = _source13.dtor_body;
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
      } else if (_source16.is_While) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _301___mcc_h9 = _source16.dtor_lbl;
        DAST._IExpression _302___mcc_h10 = _source16.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _303___mcc_h11 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _304_body = _303___mcc_h11;
        DAST._IExpression _305_cond = _302___mcc_h10;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _306_lbl = _301___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _307_condString;
          bool _308___v20;
          bool _309_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _310_recIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          bool _out98;
          bool _out99;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out100;
          DCOMP.COMP.GenExpr(_305_cond, selfIdent, @params, true, out _out97, out _out98, out _out99, out _out100);
          _307_condString = _out97;
          _308___v20 = _out98;
          _309_condErased = _out99;
          _310_recIdents = _out100;
          if (!(_309_condErased)) {
            _307_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _307_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _310_recIdents;
          Dafny.ISequence<Dafny.Rune> _311_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _312_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenStmts(_304_body, selfIdent, @params, false, earlyReturn, out _out101, out _out102);
          _311_bodyString = _out101;
          _312_bodyIdents = _out102;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _312_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _313_lblString;
          _313_lblString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source18 = _306_lbl;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.Rune> _314___mcc_h25 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _315_id = _314___mcc_h25;
            {
              _313_lblString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _315_id), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": "));
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_313_lblString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while ")), _307_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _311_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Foreach) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _316___mcc_h12 = _source16.dtor_lbl;
        Dafny.ISequence<Dafny.Rune> _317___mcc_h13 = _source16.dtor_boundName;
        DAST._IExpression _318___mcc_h14 = _source16.dtor_over;
        Dafny.ISequence<DAST._IStatement> _319___mcc_h15 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _320_body = _319___mcc_h15;
        DAST._IExpression _321_over = _318___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _322_boundName = _317___mcc_h13;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _323_lbl = _316___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _324_overString;
          bool _325___v21;
          bool _326_overErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _327_recIdents;
          Dafny.ISequence<Dafny.Rune> _out103;
          bool _out104;
          bool _out105;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out106;
          DCOMP.COMP.GenExpr(_321_over, selfIdent, @params, true, out _out103, out _out104, out _out105, out _out106);
          _324_overString = _out103;
          _325___v21 = _out104;
          _326_overErased = _out105;
          _327_recIdents = _out106;
          if (!(_326_overErased)) {
            _324_overString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _324_overString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _327_recIdents;
          Dafny.ISequence<Dafny.Rune> _328_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _329_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out107;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out108;
          DCOMP.COMP.GenStmts(_320_body, selfIdent, @params, false, earlyReturn, out _out107, out _out108);
          _328_bodyString = _out107;
          _329_bodyIdents = _out108;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _329_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _330_lblString;
          _330_lblString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source19 = _323_lbl;
          if (_source19.is_Some) {
            Dafny.ISequence<Dafny.Rune> _331___mcc_h26 = _source19.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _332_id = _331___mcc_h26;
            {
              _330_lblString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _332_id), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": "));
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_330_lblString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("for r#")), _322_boundName), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" in ")), _324_overString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _328_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Call) {
        DAST._IExpression _333___mcc_h16 = _source16.dtor_on;
        Dafny.ISequence<Dafny.Rune> _334___mcc_h17 = _source16.dtor_name;
        Dafny.ISequence<DAST._IType> _335___mcc_h18 = _source16.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _336___mcc_h19 = _source16.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _337___mcc_h20 = _source16.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _338_maybeOutVars = _337___mcc_h20;
        Dafny.ISequence<DAST._IExpression> _339_args = _336___mcc_h19;
        Dafny.ISequence<DAST._IType> _340_typeArgs = _335___mcc_h18;
        Dafny.ISequence<Dafny.Rune> _341_name = _334___mcc_h17;
        DAST._IExpression _342_on = _333___mcc_h16;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _343_typeArgString;
          _343_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_340_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _344_typeI;
            _344_typeI = BigInteger.Zero;
            _343_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_344_typeI) < (new BigInteger((_340_typeArgs).Count))) {
              if ((_344_typeI).Sign == 1) {
                _343_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_343_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _345_typeString;
              Dafny.ISequence<Dafny.Rune> _out109;
              _out109 = DCOMP.COMP.GenType((_340_typeArgs).Select(_344_typeI), false, false);
              _345_typeString = _out109;
              _343_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_343_typeArgString, _345_typeString);
              _344_typeI = (_344_typeI) + (BigInteger.One);
            }
            _343_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_343_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _346_argString;
          _346_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _347_i;
          _347_i = BigInteger.Zero;
          while ((_347_i) < (new BigInteger((_339_args).Count))) {
            if ((_347_i).Sign == 1) {
              _346_argString = Dafny.Sequence<Dafny.Rune>.Concat(_346_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _348_argExpr;
            bool _349_isOwned;
            bool _350_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _351_argIdents;
            Dafny.ISequence<Dafny.Rune> _out110;
            bool _out111;
            bool _out112;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out113;
            DCOMP.COMP.GenExpr((_339_args).Select(_347_i), selfIdent, @params, false, out _out110, out _out111, out _out112, out _out113);
            _348_argExpr = _out110;
            _349_isOwned = _out111;
            _350_argErased = _out112;
            _351_argIdents = _out113;
            if (_349_isOwned) {
              _348_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _348_argExpr);
            }
            _346_argString = Dafny.Sequence<Dafny.Rune>.Concat(_346_argString, _348_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _351_argIdents);
            _347_i = (_347_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _352_enclosingString;
          bool _353___v22;
          bool _354___v23;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _355_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out114;
          bool _out115;
          bool _out116;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out117;
          DCOMP.COMP.GenExpr(_342_on, selfIdent, @params, false, out _out114, out _out115, out _out116, out _out117);
          _352_enclosingString = _out114;
          _353___v22 = _out115;
          _354___v23 = _out116;
          _355_enclosingIdents = _out117;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _355_enclosingIdents);
          DAST._IExpression _source20 = _342_on;
          if (_source20.is_Literal) {
            DAST._ILiteral _356___mcc_h27 = _source20.dtor_Literal_a0;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _357___mcc_h29 = _source20.dtor_Ident_a0;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _358___mcc_h31 = _source20.dtor_Companion_a0;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_352_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source20.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _359___mcc_h33 = _source20.dtor_Tuple_a0;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _360___mcc_h35 = _source20.dtor_path;
            Dafny.ISequence<DAST._IExpression> _361___mcc_h36 = _source20.dtor_args;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _362___mcc_h39 = _source20.dtor_dims;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _363___mcc_h41 = _source20.dtor_path;
            Dafny.ISequence<Dafny.Rune> _364___mcc_h42 = _source20.dtor_variant;
            bool _365___mcc_h43 = _source20.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _366___mcc_h44 = _source20.dtor_contents;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_Convert) {
            DAST._IExpression _367___mcc_h49 = _source20.dtor_value;
            DAST._IType _368___mcc_h50 = _source20.dtor_from;
            DAST._IType _369___mcc_h51 = _source20.dtor_typ;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _370___mcc_h55 = _source20.dtor_elements;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _371___mcc_h57 = _source20.dtor_elements;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _372___mcc_h59 = _source20.dtor_mapElems;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_This) {
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_Ite) {
            DAST._IExpression _373___mcc_h61 = _source20.dtor_cond;
            DAST._IExpression _374___mcc_h62 = _source20.dtor_thn;
            DAST._IExpression _375___mcc_h63 = _source20.dtor_els;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_UnOp) {
            DAST._IUnaryOp _376___mcc_h67 = _source20.dtor_unOp;
            DAST._IExpression _377___mcc_h68 = _source20.dtor_expr;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _378___mcc_h71 = _source20.dtor_op;
            DAST._IExpression _379___mcc_h72 = _source20.dtor_left;
            DAST._IExpression _380___mcc_h73 = _source20.dtor_right;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_ArrayLen) {
            DAST._IExpression _381___mcc_h77 = _source20.dtor_expr;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_Select) {
            DAST._IExpression _382___mcc_h79 = _source20.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _383___mcc_h80 = _source20.dtor_field;
            bool _384___mcc_h81 = _source20.dtor_isConstant;
            bool _385___mcc_h82 = _source20.dtor_onDatatype;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_SelectFn) {
            DAST._IExpression _386___mcc_h87 = _source20.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _387___mcc_h88 = _source20.dtor_field;
            bool _388___mcc_h89 = _source20.dtor_onDatatype;
            bool _389___mcc_h90 = _source20.dtor_isStatic;
            BigInteger _390___mcc_h91 = _source20.dtor_arity;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_Index) {
            DAST._IExpression _391___mcc_h97 = _source20.dtor_expr;
            DAST._ICollKind _392___mcc_h98 = _source20.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _393___mcc_h99 = _source20.dtor_indices;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_IndexRange) {
            DAST._IExpression _394___mcc_h103 = _source20.dtor_expr;
            bool _395___mcc_h104 = _source20.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _396___mcc_h105 = _source20.dtor_low;
            DAST._IOptional<DAST._IExpression> _397___mcc_h106 = _source20.dtor_high;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_TupleSelect) {
            DAST._IExpression _398___mcc_h111 = _source20.dtor_expr;
            BigInteger _399___mcc_h112 = _source20.dtor_index;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_Call) {
            DAST._IExpression _400___mcc_h115 = _source20.dtor_on;
            Dafny.ISequence<Dafny.Rune> _401___mcc_h116 = _source20.dtor_name;
            Dafny.ISequence<DAST._IType> _402___mcc_h117 = _source20.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _403___mcc_h118 = _source20.dtor_args;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _404___mcc_h123 = _source20.dtor_params;
            DAST._IType _405___mcc_h124 = _source20.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _406___mcc_h125 = _source20.dtor_body;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _407___mcc_h129 = _source20.dtor_values;
            DAST._IType _408___mcc_h130 = _source20.dtor_retType;
            DAST._IExpression _409___mcc_h131 = _source20.dtor_expr;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _410___mcc_h135 = _source20.dtor_name;
            DAST._IType _411___mcc_h136 = _source20.dtor_typ;
            DAST._IExpression _412___mcc_h137 = _source20.dtor_value;
            DAST._IExpression _413___mcc_h138 = _source20.dtor_iifeBody;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_Apply) {
            DAST._IExpression _414___mcc_h143 = _source20.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _415___mcc_h144 = _source20.dtor_args;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source20.is_TypeTest) {
            DAST._IExpression _416___mcc_h147 = _source20.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _417___mcc_h148 = _source20.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _418___mcc_h149 = _source20.dtor_variant;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _419___mcc_h153 = _source20.dtor_typ;
            {
              _352_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _420_receiver;
          _420_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source21 = _338_maybeOutVars;
          if (_source21.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _421___mcc_h155 = _source21.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _422_outVars = _421___mcc_h155;
            {
              if ((new BigInteger((_422_outVars).Count)) > (BigInteger.One)) {
                _420_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _423_outI;
              _423_outI = BigInteger.Zero;
              while ((_423_outI) < (new BigInteger((_422_outVars).Count))) {
                if ((_423_outI).Sign == 1) {
                  _420_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_420_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _424_outVar;
                _424_outVar = (_422_outVars).Select(_423_outI);
                _420_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_420_receiver, (_424_outVar));
                _423_outI = (_423_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_422_outVars).Count)) > (BigInteger.One)) {
                _420_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_420_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_420_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_420_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _352_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _341_name), _343_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _346_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source16.is_Return) {
        DAST._IExpression _425___mcc_h21 = _source16.dtor_expr;
        DAST._IExpression _426_expr = _425___mcc_h21;
        {
          Dafny.ISequence<Dafny.Rune> _427_exprString;
          bool _428___v26;
          bool _429_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _430_recIdents;
          Dafny.ISequence<Dafny.Rune> _out118;
          bool _out119;
          bool _out120;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out121;
          DCOMP.COMP.GenExpr(_426_expr, selfIdent, @params, true, out _out118, out _out119, out _out120, out _out121);
          _427_exprString = _out118;
          _428___v26 = _out119;
          _429_recErased = _out120;
          _430_recIdents = _out121;
          _427_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _427_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _430_recIdents;
          if (isLast) {
            generated = _427_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _427_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source16.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_Break) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _431___mcc_h22 = _source16.dtor_toLabel;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _432_toLabel = _431___mcc_h22;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source22 = _432_toLabel;
          if (_source22.is_Some) {
            Dafny.ISequence<Dafny.Rune> _433___mcc_h156 = _source22.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _434_lbl = _433___mcc_h156;
            {
              generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break 'label_"), _434_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            }
          } else {
            {
              generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break;");
            }
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _435___mcc_h23 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _436_body = _435___mcc_h23;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _437_paramI;
          _437_paramI = BigInteger.Zero;
          while ((_437_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _438_param;
            _438_param = (@params).Select(_437_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _438_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _438_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _437_paramI = (_437_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _439_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _440_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out122;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out123;
          DCOMP.COMP.GenStmts(_436_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out122, out _out123);
          _439_bodyString = _out122;
          _440_bodyIdents = _out123;
          readIdents = _440_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _439_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
        DAST._IExpression _441___mcc_h24 = _source16.dtor_Print_a0;
        DAST._IExpression _442_e = _441___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _443_printedExpr;
          bool _444_isOwned;
          bool _445___v27;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _446_recIdents;
          Dafny.ISequence<Dafny.Rune> _out124;
          bool _out125;
          bool _out126;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out127;
          DCOMP.COMP.GenExpr(_442_e, selfIdent, @params, false, out _out124, out _out125, out _out126, out _out127);
          _443_printedExpr = _out124;
          _444_isOwned = _out125;
          _445___v27 = _out126;
          _446_recIdents = _out127;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_444_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _443_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _446_recIdents;
        }
      }
    }
    public static void GenExpr(DAST._IExpression e, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool mustOwn, out Dafny.ISequence<Dafny.Rune> s, out bool isOwned, out bool isErased, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      isOwned = false;
      isErased = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IExpression _source23 = e;
      if (_source23.is_Literal) {
        DAST._ILiteral _447___mcc_h0 = _source23.dtor_Literal_a0;
        DAST._ILiteral _source24 = _447___mcc_h0;
        if (_source24.is_BoolLiteral) {
          bool _448___mcc_h1 = _source24.dtor_BoolLiteral_a0;
          if ((_448___mcc_h1) == (false)) {
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
        } else if (_source24.is_IntLiteral) {
          Dafny.ISequence<Dafny.Rune> _449___mcc_h2 = _source24.dtor_IntLiteral_a0;
          DAST._IType _450___mcc_h3 = _source24.dtor_IntLiteral_a1;
          DAST._IType _451_t = _450___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _452_i = _449___mcc_h2;
          {
            DAST._IType _source25 = _451_t;
            if (_source25.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _453___mcc_h200 = _source25.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _454___mcc_h201 = _source25.dtor_typeArgs;
              DAST._IResolvedType _455___mcc_h202 = _source25.dtor_resolved;
              {
                s = _452_i;
              }
            } else if (_source25.is_Nullable) {
              DAST._IType _456___mcc_h206 = _source25.dtor_Nullable_a0;
              {
                s = _452_i;
              }
            } else if (_source25.is_Tuple) {
              Dafny.ISequence<DAST._IType> _457___mcc_h208 = _source25.dtor_Tuple_a0;
              {
                s = _452_i;
              }
            } else if (_source25.is_Array) {
              DAST._IType _458___mcc_h210 = _source25.dtor_element;
              {
                s = _452_i;
              }
            } else if (_source25.is_Seq) {
              DAST._IType _459___mcc_h212 = _source25.dtor_element;
              {
                s = _452_i;
              }
            } else if (_source25.is_Set) {
              DAST._IType _460___mcc_h214 = _source25.dtor_element;
              {
                s = _452_i;
              }
            } else if (_source25.is_Multiset) {
              DAST._IType _461___mcc_h216 = _source25.dtor_element;
              {
                s = _452_i;
              }
            } else if (_source25.is_Map) {
              DAST._IType _462___mcc_h218 = _source25.dtor_key;
              DAST._IType _463___mcc_h219 = _source25.dtor_value;
              {
                s = _452_i;
              }
            } else if (_source25.is_Arrow) {
              Dafny.ISequence<DAST._IType> _464___mcc_h222 = _source25.dtor_args;
              DAST._IType _465___mcc_h223 = _source25.dtor_result;
              {
                s = _452_i;
              }
            } else if (_source25.is_Primitive) {
              DAST._IPrimitive _466___mcc_h226 = _source25.dtor_Primitive_a0;
              DAST._IPrimitive _source26 = _466___mcc_h226;
              if (_source26.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _452_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source26.is_Real) {
                {
                  s = _452_i;
                }
              } else if (_source26.is_String) {
                {
                  s = _452_i;
                }
              } else if (_source26.is_Bool) {
                {
                  s = _452_i;
                }
              } else {
                {
                  s = _452_i;
                }
              }
            } else if (_source25.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _467___mcc_h228 = _source25.dtor_Passthrough_a0;
              {
                s = _452_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _468___mcc_h230 = _source25.dtor_TypeArg_a0;
              {
                s = _452_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source24.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _469___mcc_h4 = _source24.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _470___mcc_h5 = _source24.dtor_DecLiteral_a1;
          DAST._IType _471___mcc_h6 = _source24.dtor_DecLiteral_a2;
          DAST._IType _472_t = _471___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _473_d = _470___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _474_n = _469___mcc_h4;
          {
            DAST._IType _source27 = _472_t;
            if (_source27.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _475___mcc_h232 = _source27.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _476___mcc_h233 = _source27.dtor_typeArgs;
              DAST._IResolvedType _477___mcc_h234 = _source27.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source27.is_Nullable) {
              DAST._IType _478___mcc_h238 = _source27.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source27.is_Tuple) {
              Dafny.ISequence<DAST._IType> _479___mcc_h240 = _source27.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source27.is_Array) {
              DAST._IType _480___mcc_h242 = _source27.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source27.is_Seq) {
              DAST._IType _481___mcc_h244 = _source27.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source27.is_Set) {
              DAST._IType _482___mcc_h246 = _source27.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source27.is_Multiset) {
              DAST._IType _483___mcc_h248 = _source27.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source27.is_Map) {
              DAST._IType _484___mcc_h250 = _source27.dtor_key;
              DAST._IType _485___mcc_h251 = _source27.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source27.is_Arrow) {
              Dafny.ISequence<DAST._IType> _486___mcc_h254 = _source27.dtor_args;
              DAST._IType _487___mcc_h255 = _source27.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source27.is_Primitive) {
              DAST._IPrimitive _488___mcc_h258 = _source27.dtor_Primitive_a0;
              DAST._IPrimitive _source28 = _488___mcc_h258;
              if (_source28.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source28.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _474_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source28.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source28.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source27.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _489___mcc_h260 = _source27.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _490___mcc_h262 = _source27.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_474_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _473_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source24.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _491___mcc_h7 = _source24.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _492_l = _491___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _492_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source24.is_CharLiteral) {
          Dafny.Rune _493___mcc_h8 = _source24.dtor_CharLiteral_a0;
          Dafny.Rune _494_c = _493___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_494_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
      } else if (_source23.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _495___mcc_h9 = _source23.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _496_name = _495___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _496_name);
          if (!((@params).Contains(_496_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_496_name);
        }
      } else if (_source23.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _497___mcc_h10 = _source23.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _498_path = _497___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out128;
          _out128 = DCOMP.COMP.GenPath(_498_path);
          s = _out128;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source23.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _499___mcc_h11 = _source23.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _500_values = _499___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _501_i;
          _501_i = BigInteger.Zero;
          bool _502_allErased;
          _502_allErased = true;
          while ((_501_i) < (new BigInteger((_500_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _503___v30;
            bool _504___v31;
            bool _505_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _506___v32;
            Dafny.ISequence<Dafny.Rune> _out129;
            bool _out130;
            bool _out131;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out132;
            DCOMP.COMP.GenExpr((_500_values).Select(_501_i), selfIdent, @params, true, out _out129, out _out130, out _out131, out _out132);
            _503___v30 = _out129;
            _504___v31 = _out130;
            _505_isErased = _out131;
            _506___v32 = _out132;
            _502_allErased = (_502_allErased) && (_505_isErased);
            _501_i = (_501_i) + (BigInteger.One);
          }
          _501_i = BigInteger.Zero;
          while ((_501_i) < (new BigInteger((_500_values).Count))) {
            if ((_501_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _507_recursiveGen;
            bool _508___v33;
            bool _509_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _510_recIdents;
            Dafny.ISequence<Dafny.Rune> _out133;
            bool _out134;
            bool _out135;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out136;
            DCOMP.COMP.GenExpr((_500_values).Select(_501_i), selfIdent, @params, true, out _out133, out _out134, out _out135, out _out136);
            _507_recursiveGen = _out133;
            _508___v33 = _out134;
            _509_isErased = _out135;
            _510_recIdents = _out136;
            if ((_509_isErased) && (!(_502_allErased))) {
              _507_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _507_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _507_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _510_recIdents);
            _501_i = (_501_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _502_allErased;
        }
      } else if (_source23.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _511___mcc_h12 = _source23.dtor_path;
        Dafny.ISequence<DAST._IExpression> _512___mcc_h13 = _source23.dtor_args;
        Dafny.ISequence<DAST._IExpression> _513_args = _512___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _514_path = _511___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _515_path;
          Dafny.ISequence<Dafny.Rune> _out137;
          _out137 = DCOMP.COMP.GenPath(_514_path);
          _515_path = _out137;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _515_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _516_i;
          _516_i = BigInteger.Zero;
          while ((_516_i) < (new BigInteger((_513_args).Count))) {
            if ((_516_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _517_recursiveGen;
            bool _518___v34;
            bool _519_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _520_recIdents;
            Dafny.ISequence<Dafny.Rune> _out138;
            bool _out139;
            bool _out140;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out141;
            DCOMP.COMP.GenExpr((_513_args).Select(_516_i), selfIdent, @params, true, out _out138, out _out139, out _out140, out _out141);
            _517_recursiveGen = _out138;
            _518___v34 = _out139;
            _519_isErased = _out140;
            _520_recIdents = _out141;
            if (_519_isErased) {
              _517_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _517_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _517_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _520_recIdents);
            _516_i = (_516_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source23.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _521___mcc_h14 = _source23.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _522_dims = _521___mcc_h14;
        {
          BigInteger _523_i;
          _523_i = (new BigInteger((_522_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_523_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _524_recursiveGen;
            bool _525___v35;
            bool _526_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _527_recIdents;
            Dafny.ISequence<Dafny.Rune> _out142;
            bool _out143;
            bool _out144;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out145;
            DCOMP.COMP.GenExpr((_522_dims).Select(_523_i), selfIdent, @params, true, out _out142, out _out143, out _out144, out _out145);
            _524_recursiveGen = _out142;
            _525___v35 = _out143;
            _526_isErased = _out144;
            _527_recIdents = _out145;
            if (!(_526_isErased)) {
              _524_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _524_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _524_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _527_recIdents);
            _523_i = (_523_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source23.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _528___mcc_h15 = _source23.dtor_path;
        Dafny.ISequence<Dafny.Rune> _529___mcc_h16 = _source23.dtor_variant;
        bool _530___mcc_h17 = _source23.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _531___mcc_h18 = _source23.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _532_values = _531___mcc_h18;
        bool _533_isCo = _530___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _534_variant = _529___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _535_path = _528___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _536_path;
          Dafny.ISequence<Dafny.Rune> _out146;
          _out146 = DCOMP.COMP.GenPath(_535_path);
          _536_path = _out146;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _536_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _534_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _537_i;
          _537_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_537_i) < (new BigInteger((_532_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_532_values).Select(_537_i);
            Dafny.ISequence<Dafny.Rune> _538_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _539_value = _let_tmp_rhs0.dtor__1;
            if ((_537_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_533_isCo) {
              Dafny.ISequence<Dafny.Rune> _540_recursiveGen;
              bool _541___v36;
              bool _542_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _543_recIdents;
              Dafny.ISequence<Dafny.Rune> _out147;
              bool _out148;
              bool _out149;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out150;
              DCOMP.COMP.GenExpr(_539_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out147, out _out148, out _out149, out _out150);
              _540_recursiveGen = _out147;
              _541___v36 = _out148;
              _542_isErased = _out149;
              _543_recIdents = _out150;
              if (!(_542_isErased)) {
                _540_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _540_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _540_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _540_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _543_recIdents);
              Dafny.ISequence<Dafny.Rune> _544_allReadCloned;
              _544_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_543_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _545_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_543_recIdents).Elements) {
                  _545_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_543_recIdents).Contains(_545_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1188)");
              after__ASSIGN_SUCH_THAT_0:;
                _544_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_544_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _545_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _545_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _543_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_543_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_545_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _538_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _544_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _540_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _546_recursiveGen;
              bool _547___v37;
              bool _548_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _549_recIdents;
              Dafny.ISequence<Dafny.Rune> _out151;
              bool _out152;
              bool _out153;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out154;
              DCOMP.COMP.GenExpr(_539_value, selfIdent, @params, true, out _out151, out _out152, out _out153, out _out154);
              _546_recursiveGen = _out151;
              _547___v37 = _out152;
              _548_isErased = _out153;
              _549_recIdents = _out154;
              if (!(_548_isErased)) {
                _546_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _546_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _538_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _549_recIdents);
            }
            _537_i = (_537_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source23.is_Convert) {
        DAST._IExpression _550___mcc_h19 = _source23.dtor_value;
        DAST._IType _551___mcc_h20 = _source23.dtor_from;
        DAST._IType _552___mcc_h21 = _source23.dtor_typ;
        DAST._IType _553_toTpe = _552___mcc_h21;
        DAST._IType _554_fromTpe = _551___mcc_h20;
        DAST._IExpression _555_expr = _550___mcc_h19;
        {
          if (object.Equals(_554_fromTpe, _553_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _556_recursiveGen;
            bool _557_recOwned;
            bool _558_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _559_recIdents;
            Dafny.ISequence<Dafny.Rune> _out155;
            bool _out156;
            bool _out157;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out158;
            DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out155, out _out156, out _out157, out _out158);
            _556_recursiveGen = _out155;
            _557_recOwned = _out156;
            _558_recErased = _out157;
            _559_recIdents = _out158;
            s = _556_recursiveGen;
            isOwned = _557_recOwned;
            isErased = _558_recErased;
            readIdents = _559_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source29 = _System.Tuple2<DAST._IType, DAST._IType>.create(_554_fromTpe, _553_toTpe);
            DAST._IType _560___mcc_h264 = _source29.dtor__0;
            DAST._IType _561___mcc_h265 = _source29.dtor__1;
            DAST._IType _source30 = _560___mcc_h264;
            if (_source30.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _562___mcc_h268 = _source30.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _563___mcc_h269 = _source30.dtor_typeArgs;
              DAST._IResolvedType _564___mcc_h270 = _source30.dtor_resolved;
              DAST._IResolvedType _source31 = _564___mcc_h270;
              if (_source31.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _565___mcc_h280 = _source31.dtor_path;
                DAST._IType _source32 = _561___mcc_h265;
                if (_source32.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _566___mcc_h284 = _source32.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _567___mcc_h285 = _source32.dtor_typeArgs;
                  DAST._IResolvedType _568___mcc_h286 = _source32.dtor_resolved;
                  DAST._IResolvedType _source33 = _568___mcc_h286;
                  if (_source33.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _569___mcc_h290 = _source33.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _570_recursiveGen;
                      bool _571_recOwned;
                      bool _572_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _573_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out159;
                      bool _out160;
                      bool _out161;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out162;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out159, out _out160, out _out161, out _out162);
                      _570_recursiveGen = _out159;
                      _571_recOwned = _out160;
                      _572_recErased = _out161;
                      _573_recIdents = _out162;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _570_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _571_recOwned;
                      isErased = _572_recErased;
                      readIdents = _573_recIdents;
                    }
                  } else if (_source33.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _574___mcc_h292 = _source33.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _575_recursiveGen;
                      bool _576_recOwned;
                      bool _577_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _578_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out163;
                      bool _out164;
                      bool _out165;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out166;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out163, out _out164, out _out165, out _out166);
                      _575_recursiveGen = _out163;
                      _576_recOwned = _out164;
                      _577_recErased = _out165;
                      _578_recIdents = _out166;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _575_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _576_recOwned;
                      isErased = _577_recErased;
                      readIdents = _578_recIdents;
                    }
                  } else {
                    DAST._IType _579___mcc_h294 = _source33.dtor_Newtype_a0;
                    DAST._IType _580_b = _579___mcc_h294;
                    {
                      if (object.Equals(_554_fromTpe, _580_b)) {
                        Dafny.ISequence<Dafny.Rune> _581_recursiveGen;
                        bool _582_recOwned;
                        bool _583_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _584_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out167;
                        bool _out168;
                        bool _out169;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out170;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out167, out _out168, out _out169, out _out170);
                        _581_recursiveGen = _out167;
                        _582_recOwned = _out168;
                        _583_recErased = _out169;
                        _584_recIdents = _out170;
                        Dafny.ISequence<Dafny.Rune> _585_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out171;
                        _out171 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                        _585_rhsType = _out171;
                        Dafny.ISequence<Dafny.Rune> _586_uneraseFn;
                        _586_uneraseFn = ((_582_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _585_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _586_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _581_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _582_recOwned;
                        isErased = false;
                        readIdents = _584_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out172;
                        bool _out173;
                        bool _out174;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out175;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _580_b), _580_b, _553_toTpe), selfIdent, @params, mustOwn, out _out172, out _out173, out _out174, out _out175);
                        s = _out172;
                        isOwned = _out173;
                        isErased = _out174;
                        readIdents = _out175;
                      }
                    }
                  }
                } else if (_source32.is_Nullable) {
                  DAST._IType _587___mcc_h296 = _source32.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _588_recursiveGen;
                    bool _589_recOwned;
                    bool _590_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _591_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out176;
                    bool _out177;
                    bool _out178;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out179;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out176, out _out177, out _out178, out _out179);
                    _588_recursiveGen = _out176;
                    _589_recOwned = _out177;
                    _590_recErased = _out178;
                    _591_recIdents = _out179;
                    if (!(_589_recOwned)) {
                      _588_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_588_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _588_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _590_recErased;
                    readIdents = _591_recIdents;
                  }
                } else if (_source32.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _592___mcc_h298 = _source32.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _593_recursiveGen;
                    bool _594_recOwned;
                    bool _595_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _596_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out180;
                    bool _out181;
                    bool _out182;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out183;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out180, out _out181, out _out182, out _out183);
                    _593_recursiveGen = _out180;
                    _594_recOwned = _out181;
                    _595_recErased = _out182;
                    _596_recIdents = _out183;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _593_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _594_recOwned;
                    isErased = _595_recErased;
                    readIdents = _596_recIdents;
                  }
                } else if (_source32.is_Array) {
                  DAST._IType _597___mcc_h300 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _598_recursiveGen;
                    bool _599_recOwned;
                    bool _600_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _601_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out184;
                    bool _out185;
                    bool _out186;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out187;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out184, out _out185, out _out186, out _out187);
                    _598_recursiveGen = _out184;
                    _599_recOwned = _out185;
                    _600_recErased = _out186;
                    _601_recIdents = _out187;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _598_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _599_recOwned;
                    isErased = _600_recErased;
                    readIdents = _601_recIdents;
                  }
                } else if (_source32.is_Seq) {
                  DAST._IType _602___mcc_h302 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _603_recursiveGen;
                    bool _604_recOwned;
                    bool _605_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _606_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out188;
                    bool _out189;
                    bool _out190;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out191;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out188, out _out189, out _out190, out _out191);
                    _603_recursiveGen = _out188;
                    _604_recOwned = _out189;
                    _605_recErased = _out190;
                    _606_recIdents = _out191;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _603_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _604_recOwned;
                    isErased = _605_recErased;
                    readIdents = _606_recIdents;
                  }
                } else if (_source32.is_Set) {
                  DAST._IType _607___mcc_h304 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _608_recursiveGen;
                    bool _609_recOwned;
                    bool _610_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _611_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out192;
                    bool _out193;
                    bool _out194;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out195;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out192, out _out193, out _out194, out _out195);
                    _608_recursiveGen = _out192;
                    _609_recOwned = _out193;
                    _610_recErased = _out194;
                    _611_recIdents = _out195;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _608_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _609_recOwned;
                    isErased = _610_recErased;
                    readIdents = _611_recIdents;
                  }
                } else if (_source32.is_Multiset) {
                  DAST._IType _612___mcc_h306 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _613_recursiveGen;
                    bool _614_recOwned;
                    bool _615_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _616_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out196;
                    bool _out197;
                    bool _out198;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out199;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out196, out _out197, out _out198, out _out199);
                    _613_recursiveGen = _out196;
                    _614_recOwned = _out197;
                    _615_recErased = _out198;
                    _616_recIdents = _out199;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _614_recOwned;
                    isErased = _615_recErased;
                    readIdents = _616_recIdents;
                  }
                } else if (_source32.is_Map) {
                  DAST._IType _617___mcc_h308 = _source32.dtor_key;
                  DAST._IType _618___mcc_h309 = _source32.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _619_recursiveGen;
                    bool _620_recOwned;
                    bool _621_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _622_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out200;
                    bool _out201;
                    bool _out202;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out203;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out200, out _out201, out _out202, out _out203);
                    _619_recursiveGen = _out200;
                    _620_recOwned = _out201;
                    _621_recErased = _out202;
                    _622_recIdents = _out203;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _619_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _620_recOwned;
                    isErased = _621_recErased;
                    readIdents = _622_recIdents;
                  }
                } else if (_source32.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _623___mcc_h312 = _source32.dtor_args;
                  DAST._IType _624___mcc_h313 = _source32.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _625_recursiveGen;
                    bool _626_recOwned;
                    bool _627_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _628_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out204;
                    bool _out205;
                    bool _out206;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out207;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out204, out _out205, out _out206, out _out207);
                    _625_recursiveGen = _out204;
                    _626_recOwned = _out205;
                    _627_recErased = _out206;
                    _628_recIdents = _out207;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _625_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _626_recOwned;
                    isErased = _627_recErased;
                    readIdents = _628_recIdents;
                  }
                } else if (_source32.is_Primitive) {
                  DAST._IPrimitive _629___mcc_h316 = _source32.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _630_recursiveGen;
                    bool _631_recOwned;
                    bool _632_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _633_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out208;
                    bool _out209;
                    bool _out210;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out211;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out208, out _out209, out _out210, out _out211);
                    _630_recursiveGen = _out208;
                    _631_recOwned = _out209;
                    _632_recErased = _out210;
                    _633_recIdents = _out211;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _630_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _631_recOwned;
                    isErased = _632_recErased;
                    readIdents = _633_recIdents;
                  }
                } else if (_source32.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _634___mcc_h318 = _source32.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _635_recursiveGen;
                    bool _636_recOwned;
                    bool _637_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _638_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out212;
                    bool _out213;
                    bool _out214;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out215;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out212, out _out213, out _out214, out _out215);
                    _635_recursiveGen = _out212;
                    _636_recOwned = _out213;
                    _637_recErased = _out214;
                    _638_recIdents = _out215;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _635_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _636_recOwned;
                    isErased = _637_recErased;
                    readIdents = _638_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _639___mcc_h320 = _source32.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _640_recursiveGen;
                    bool _641_recOwned;
                    bool _642_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _643_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out216;
                    bool _out217;
                    bool _out218;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out219;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out216, out _out217, out _out218, out _out219);
                    _640_recursiveGen = _out216;
                    _641_recOwned = _out217;
                    _642_recErased = _out218;
                    _643_recIdents = _out219;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _641_recOwned;
                    isErased = _642_recErased;
                    readIdents = _643_recIdents;
                  }
                }
              } else if (_source31.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _644___mcc_h322 = _source31.dtor_path;
                DAST._IType _source34 = _561___mcc_h265;
                if (_source34.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _645___mcc_h326 = _source34.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _646___mcc_h327 = _source34.dtor_typeArgs;
                  DAST._IResolvedType _647___mcc_h328 = _source34.dtor_resolved;
                  DAST._IResolvedType _source35 = _647___mcc_h328;
                  if (_source35.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _648___mcc_h332 = _source35.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _649_recursiveGen;
                      bool _650_recOwned;
                      bool _651_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _652_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out220;
                      bool _out221;
                      bool _out222;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out223;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out220, out _out221, out _out222, out _out223);
                      _649_recursiveGen = _out220;
                      _650_recOwned = _out221;
                      _651_recErased = _out222;
                      _652_recIdents = _out223;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _649_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _650_recOwned;
                      isErased = _651_recErased;
                      readIdents = _652_recIdents;
                    }
                  } else if (_source35.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _653___mcc_h334 = _source35.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _654_recursiveGen;
                      bool _655_recOwned;
                      bool _656_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _657_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out224;
                      bool _out225;
                      bool _out226;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out227;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out224, out _out225, out _out226, out _out227);
                      _654_recursiveGen = _out224;
                      _655_recOwned = _out225;
                      _656_recErased = _out226;
                      _657_recIdents = _out227;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _654_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _655_recOwned;
                      isErased = _656_recErased;
                      readIdents = _657_recIdents;
                    }
                  } else {
                    DAST._IType _658___mcc_h336 = _source35.dtor_Newtype_a0;
                    DAST._IType _659_b = _658___mcc_h336;
                    {
                      if (object.Equals(_554_fromTpe, _659_b)) {
                        Dafny.ISequence<Dafny.Rune> _660_recursiveGen;
                        bool _661_recOwned;
                        bool _662_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _663_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out228;
                        bool _out229;
                        bool _out230;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out231;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out228, out _out229, out _out230, out _out231);
                        _660_recursiveGen = _out228;
                        _661_recOwned = _out229;
                        _662_recErased = _out230;
                        _663_recIdents = _out231;
                        Dafny.ISequence<Dafny.Rune> _664_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out232;
                        _out232 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                        _664_rhsType = _out232;
                        Dafny.ISequence<Dafny.Rune> _665_uneraseFn;
                        _665_uneraseFn = ((_661_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _664_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _665_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _660_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _661_recOwned;
                        isErased = false;
                        readIdents = _663_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out233;
                        bool _out234;
                        bool _out235;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out236;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _659_b), _659_b, _553_toTpe), selfIdent, @params, mustOwn, out _out233, out _out234, out _out235, out _out236);
                        s = _out233;
                        isOwned = _out234;
                        isErased = _out235;
                        readIdents = _out236;
                      }
                    }
                  }
                } else if (_source34.is_Nullable) {
                  DAST._IType _666___mcc_h338 = _source34.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _667_recursiveGen;
                    bool _668_recOwned;
                    bool _669_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _670_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out237;
                    bool _out238;
                    bool _out239;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out240;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out237, out _out238, out _out239, out _out240);
                    _667_recursiveGen = _out237;
                    _668_recOwned = _out238;
                    _669_recErased = _out239;
                    _670_recIdents = _out240;
                    if (!(_668_recOwned)) {
                      _667_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_667_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _667_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _669_recErased;
                    readIdents = _670_recIdents;
                  }
                } else if (_source34.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _671___mcc_h340 = _source34.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _672_recursiveGen;
                    bool _673_recOwned;
                    bool _674_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _675_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out241;
                    bool _out242;
                    bool _out243;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out244;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out241, out _out242, out _out243, out _out244);
                    _672_recursiveGen = _out241;
                    _673_recOwned = _out242;
                    _674_recErased = _out243;
                    _675_recIdents = _out244;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _672_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _673_recOwned;
                    isErased = _674_recErased;
                    readIdents = _675_recIdents;
                  }
                } else if (_source34.is_Array) {
                  DAST._IType _676___mcc_h342 = _source34.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _677_recursiveGen;
                    bool _678_recOwned;
                    bool _679_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _680_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out245;
                    bool _out246;
                    bool _out247;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out248;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out245, out _out246, out _out247, out _out248);
                    _677_recursiveGen = _out245;
                    _678_recOwned = _out246;
                    _679_recErased = _out247;
                    _680_recIdents = _out248;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _677_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _678_recOwned;
                    isErased = _679_recErased;
                    readIdents = _680_recIdents;
                  }
                } else if (_source34.is_Seq) {
                  DAST._IType _681___mcc_h344 = _source34.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _682_recursiveGen;
                    bool _683_recOwned;
                    bool _684_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _685_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out249;
                    bool _out250;
                    bool _out251;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out252;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out249, out _out250, out _out251, out _out252);
                    _682_recursiveGen = _out249;
                    _683_recOwned = _out250;
                    _684_recErased = _out251;
                    _685_recIdents = _out252;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _683_recOwned;
                    isErased = _684_recErased;
                    readIdents = _685_recIdents;
                  }
                } else if (_source34.is_Set) {
                  DAST._IType _686___mcc_h346 = _source34.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _687_recursiveGen;
                    bool _688_recOwned;
                    bool _689_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _690_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out253;
                    bool _out254;
                    bool _out255;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out256;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out253, out _out254, out _out255, out _out256);
                    _687_recursiveGen = _out253;
                    _688_recOwned = _out254;
                    _689_recErased = _out255;
                    _690_recIdents = _out256;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _687_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _688_recOwned;
                    isErased = _689_recErased;
                    readIdents = _690_recIdents;
                  }
                } else if (_source34.is_Multiset) {
                  DAST._IType _691___mcc_h348 = _source34.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _692_recursiveGen;
                    bool _693_recOwned;
                    bool _694_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _695_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out257;
                    bool _out258;
                    bool _out259;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out260;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out257, out _out258, out _out259, out _out260);
                    _692_recursiveGen = _out257;
                    _693_recOwned = _out258;
                    _694_recErased = _out259;
                    _695_recIdents = _out260;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _692_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _693_recOwned;
                    isErased = _694_recErased;
                    readIdents = _695_recIdents;
                  }
                } else if (_source34.is_Map) {
                  DAST._IType _696___mcc_h350 = _source34.dtor_key;
                  DAST._IType _697___mcc_h351 = _source34.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _698_recursiveGen;
                    bool _699_recOwned;
                    bool _700_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _701_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out261;
                    bool _out262;
                    bool _out263;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out264;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out261, out _out262, out _out263, out _out264);
                    _698_recursiveGen = _out261;
                    _699_recOwned = _out262;
                    _700_recErased = _out263;
                    _701_recIdents = _out264;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _698_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _699_recOwned;
                    isErased = _700_recErased;
                    readIdents = _701_recIdents;
                  }
                } else if (_source34.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _702___mcc_h354 = _source34.dtor_args;
                  DAST._IType _703___mcc_h355 = _source34.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _704_recursiveGen;
                    bool _705_recOwned;
                    bool _706_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _707_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out265;
                    bool _out266;
                    bool _out267;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out268;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out265, out _out266, out _out267, out _out268);
                    _704_recursiveGen = _out265;
                    _705_recOwned = _out266;
                    _706_recErased = _out267;
                    _707_recIdents = _out268;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _704_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _705_recOwned;
                    isErased = _706_recErased;
                    readIdents = _707_recIdents;
                  }
                } else if (_source34.is_Primitive) {
                  DAST._IPrimitive _708___mcc_h358 = _source34.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _709_recursiveGen;
                    bool _710_recOwned;
                    bool _711_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _712_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out269;
                    bool _out270;
                    bool _out271;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out272;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out269, out _out270, out _out271, out _out272);
                    _709_recursiveGen = _out269;
                    _710_recOwned = _out270;
                    _711_recErased = _out271;
                    _712_recIdents = _out272;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _709_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _710_recOwned;
                    isErased = _711_recErased;
                    readIdents = _712_recIdents;
                  }
                } else if (_source34.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _713___mcc_h360 = _source34.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _714_recursiveGen;
                    bool _715_recOwned;
                    bool _716_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _717_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out273;
                    bool _out274;
                    bool _out275;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out276;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out273, out _out274, out _out275, out _out276);
                    _714_recursiveGen = _out273;
                    _715_recOwned = _out274;
                    _716_recErased = _out275;
                    _717_recIdents = _out276;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _714_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _715_recOwned;
                    isErased = _716_recErased;
                    readIdents = _717_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _718___mcc_h362 = _source34.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _719_recursiveGen;
                    bool _720_recOwned;
                    bool _721_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _722_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out277;
                    bool _out278;
                    bool _out279;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out280;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out277, out _out278, out _out279, out _out280);
                    _719_recursiveGen = _out277;
                    _720_recOwned = _out278;
                    _721_recErased = _out279;
                    _722_recIdents = _out280;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _719_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _720_recOwned;
                    isErased = _721_recErased;
                    readIdents = _722_recIdents;
                  }
                }
              } else {
                DAST._IType _723___mcc_h364 = _source31.dtor_Newtype_a0;
                DAST._IType _source36 = _561___mcc_h265;
                if (_source36.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _724___mcc_h368 = _source36.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _725___mcc_h369 = _source36.dtor_typeArgs;
                  DAST._IResolvedType _726___mcc_h370 = _source36.dtor_resolved;
                  DAST._IResolvedType _source37 = _726___mcc_h370;
                  if (_source37.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _727___mcc_h377 = _source37.dtor_path;
                    DAST._IType _728_b = _723___mcc_h364;
                    {
                      if (object.Equals(_728_b, _553_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _729_recursiveGen;
                        bool _730_recOwned;
                        bool _731_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _732_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out281;
                        bool _out282;
                        bool _out283;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out284;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out281, out _out282, out _out283, out _out284);
                        _729_recursiveGen = _out281;
                        _730_recOwned = _out282;
                        _731_recErased = _out283;
                        _732_recIdents = _out284;
                        Dafny.ISequence<Dafny.Rune> _733_uneraseFn;
                        _733_uneraseFn = ((_730_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _733_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _729_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _730_recOwned;
                        isErased = true;
                        readIdents = _732_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out285;
                        bool _out286;
                        bool _out287;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out288;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _728_b), _728_b, _553_toTpe), selfIdent, @params, mustOwn, out _out285, out _out286, out _out287, out _out288);
                        s = _out285;
                        isOwned = _out286;
                        isErased = _out287;
                        readIdents = _out288;
                      }
                    }
                  } else if (_source37.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _734___mcc_h380 = _source37.dtor_path;
                    DAST._IType _735_b = _723___mcc_h364;
                    {
                      if (object.Equals(_735_b, _553_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _736_recursiveGen;
                        bool _737_recOwned;
                        bool _738_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _739_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out289;
                        bool _out290;
                        bool _out291;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out292;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out289, out _out290, out _out291, out _out292);
                        _736_recursiveGen = _out289;
                        _737_recOwned = _out290;
                        _738_recErased = _out291;
                        _739_recIdents = _out292;
                        Dafny.ISequence<Dafny.Rune> _740_uneraseFn;
                        _740_uneraseFn = ((_737_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _740_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _736_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _737_recOwned;
                        isErased = true;
                        readIdents = _739_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out293;
                        bool _out294;
                        bool _out295;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out296;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _735_b), _735_b, _553_toTpe), selfIdent, @params, mustOwn, out _out293, out _out294, out _out295, out _out296);
                        s = _out293;
                        isOwned = _out294;
                        isErased = _out295;
                        readIdents = _out296;
                      }
                    }
                  } else {
                    DAST._IType _741___mcc_h383 = _source37.dtor_Newtype_a0;
                    DAST._IType _742_b = _741___mcc_h383;
                    {
                      if (object.Equals(_554_fromTpe, _742_b)) {
                        Dafny.ISequence<Dafny.Rune> _743_recursiveGen;
                        bool _744_recOwned;
                        bool _745_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _746_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out297;
                        bool _out298;
                        bool _out299;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out300;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out297, out _out298, out _out299, out _out300);
                        _743_recursiveGen = _out297;
                        _744_recOwned = _out298;
                        _745_recErased = _out299;
                        _746_recIdents = _out300;
                        Dafny.ISequence<Dafny.Rune> _747_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out301;
                        _out301 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                        _747_rhsType = _out301;
                        Dafny.ISequence<Dafny.Rune> _748_uneraseFn;
                        _748_uneraseFn = ((_744_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _747_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _748_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _743_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _744_recOwned;
                        isErased = false;
                        readIdents = _746_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out302;
                        bool _out303;
                        bool _out304;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out305;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _742_b), _742_b, _553_toTpe), selfIdent, @params, mustOwn, out _out302, out _out303, out _out304, out _out305);
                        s = _out302;
                        isOwned = _out303;
                        isErased = _out304;
                        readIdents = _out305;
                      }
                    }
                  }
                } else if (_source36.is_Nullable) {
                  DAST._IType _749___mcc_h386 = _source36.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _750_recursiveGen;
                    bool _751_recOwned;
                    bool _752_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _753_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out306;
                    bool _out307;
                    bool _out308;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out309;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out306, out _out307, out _out308, out _out309);
                    _750_recursiveGen = _out306;
                    _751_recOwned = _out307;
                    _752_recErased = _out308;
                    _753_recIdents = _out309;
                    if (!(_751_recOwned)) {
                      _750_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_750_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _750_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _752_recErased;
                    readIdents = _753_recIdents;
                  }
                } else if (_source36.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _754___mcc_h389 = _source36.dtor_Tuple_a0;
                  DAST._IType _755_b = _723___mcc_h364;
                  {
                    if (object.Equals(_755_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _756_recursiveGen;
                      bool _757_recOwned;
                      bool _758_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _759_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out310;
                      bool _out311;
                      bool _out312;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out313;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out310, out _out311, out _out312, out _out313);
                      _756_recursiveGen = _out310;
                      _757_recOwned = _out311;
                      _758_recErased = _out312;
                      _759_recIdents = _out313;
                      Dafny.ISequence<Dafny.Rune> _760_uneraseFn;
                      _760_uneraseFn = ((_757_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _760_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _756_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _757_recOwned;
                      isErased = true;
                      readIdents = _759_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out314;
                      bool _out315;
                      bool _out316;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out317;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _755_b), _755_b, _553_toTpe), selfIdent, @params, mustOwn, out _out314, out _out315, out _out316, out _out317);
                      s = _out314;
                      isOwned = _out315;
                      isErased = _out316;
                      readIdents = _out317;
                    }
                  }
                } else if (_source36.is_Array) {
                  DAST._IType _761___mcc_h392 = _source36.dtor_element;
                  DAST._IType _762_b = _723___mcc_h364;
                  {
                    if (object.Equals(_762_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _763_recursiveGen;
                      bool _764_recOwned;
                      bool _765_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _766_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out318;
                      bool _out319;
                      bool _out320;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out321;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out318, out _out319, out _out320, out _out321);
                      _763_recursiveGen = _out318;
                      _764_recOwned = _out319;
                      _765_recErased = _out320;
                      _766_recIdents = _out321;
                      Dafny.ISequence<Dafny.Rune> _767_uneraseFn;
                      _767_uneraseFn = ((_764_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _767_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _763_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _764_recOwned;
                      isErased = true;
                      readIdents = _766_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out322;
                      bool _out323;
                      bool _out324;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out325;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _762_b), _762_b, _553_toTpe), selfIdent, @params, mustOwn, out _out322, out _out323, out _out324, out _out325);
                      s = _out322;
                      isOwned = _out323;
                      isErased = _out324;
                      readIdents = _out325;
                    }
                  }
                } else if (_source36.is_Seq) {
                  DAST._IType _768___mcc_h395 = _source36.dtor_element;
                  DAST._IType _769_b = _723___mcc_h364;
                  {
                    if (object.Equals(_769_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _770_recursiveGen;
                      bool _771_recOwned;
                      bool _772_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _773_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out326;
                      bool _out327;
                      bool _out328;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out329;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out326, out _out327, out _out328, out _out329);
                      _770_recursiveGen = _out326;
                      _771_recOwned = _out327;
                      _772_recErased = _out328;
                      _773_recIdents = _out329;
                      Dafny.ISequence<Dafny.Rune> _774_uneraseFn;
                      _774_uneraseFn = ((_771_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _774_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _770_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _771_recOwned;
                      isErased = true;
                      readIdents = _773_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out330;
                      bool _out331;
                      bool _out332;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out333;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _769_b), _769_b, _553_toTpe), selfIdent, @params, mustOwn, out _out330, out _out331, out _out332, out _out333);
                      s = _out330;
                      isOwned = _out331;
                      isErased = _out332;
                      readIdents = _out333;
                    }
                  }
                } else if (_source36.is_Set) {
                  DAST._IType _775___mcc_h398 = _source36.dtor_element;
                  DAST._IType _776_b = _723___mcc_h364;
                  {
                    if (object.Equals(_776_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _777_recursiveGen;
                      bool _778_recOwned;
                      bool _779_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _780_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out334;
                      bool _out335;
                      bool _out336;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out337;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out334, out _out335, out _out336, out _out337);
                      _777_recursiveGen = _out334;
                      _778_recOwned = _out335;
                      _779_recErased = _out336;
                      _780_recIdents = _out337;
                      Dafny.ISequence<Dafny.Rune> _781_uneraseFn;
                      _781_uneraseFn = ((_778_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _781_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _777_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _778_recOwned;
                      isErased = true;
                      readIdents = _780_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out338;
                      bool _out339;
                      bool _out340;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out341;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _776_b), _776_b, _553_toTpe), selfIdent, @params, mustOwn, out _out338, out _out339, out _out340, out _out341);
                      s = _out338;
                      isOwned = _out339;
                      isErased = _out340;
                      readIdents = _out341;
                    }
                  }
                } else if (_source36.is_Multiset) {
                  DAST._IType _782___mcc_h401 = _source36.dtor_element;
                  DAST._IType _783_b = _723___mcc_h364;
                  {
                    if (object.Equals(_783_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _784_recursiveGen;
                      bool _785_recOwned;
                      bool _786_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _787_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out342;
                      bool _out343;
                      bool _out344;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out345;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out342, out _out343, out _out344, out _out345);
                      _784_recursiveGen = _out342;
                      _785_recOwned = _out343;
                      _786_recErased = _out344;
                      _787_recIdents = _out345;
                      Dafny.ISequence<Dafny.Rune> _788_uneraseFn;
                      _788_uneraseFn = ((_785_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _788_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _784_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _785_recOwned;
                      isErased = true;
                      readIdents = _787_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out346;
                      bool _out347;
                      bool _out348;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out349;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _783_b), _783_b, _553_toTpe), selfIdent, @params, mustOwn, out _out346, out _out347, out _out348, out _out349);
                      s = _out346;
                      isOwned = _out347;
                      isErased = _out348;
                      readIdents = _out349;
                    }
                  }
                } else if (_source36.is_Map) {
                  DAST._IType _789___mcc_h404 = _source36.dtor_key;
                  DAST._IType _790___mcc_h405 = _source36.dtor_value;
                  DAST._IType _791_b = _723___mcc_h364;
                  {
                    if (object.Equals(_791_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _792_recursiveGen;
                      bool _793_recOwned;
                      bool _794_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _795_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out350;
                      bool _out351;
                      bool _out352;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out353;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out350, out _out351, out _out352, out _out353);
                      _792_recursiveGen = _out350;
                      _793_recOwned = _out351;
                      _794_recErased = _out352;
                      _795_recIdents = _out353;
                      Dafny.ISequence<Dafny.Rune> _796_uneraseFn;
                      _796_uneraseFn = ((_793_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _796_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _792_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _793_recOwned;
                      isErased = true;
                      readIdents = _795_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out354;
                      bool _out355;
                      bool _out356;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out357;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _791_b), _791_b, _553_toTpe), selfIdent, @params, mustOwn, out _out354, out _out355, out _out356, out _out357);
                      s = _out354;
                      isOwned = _out355;
                      isErased = _out356;
                      readIdents = _out357;
                    }
                  }
                } else if (_source36.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _797___mcc_h410 = _source36.dtor_args;
                  DAST._IType _798___mcc_h411 = _source36.dtor_result;
                  DAST._IType _799_b = _723___mcc_h364;
                  {
                    if (object.Equals(_799_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _800_recursiveGen;
                      bool _801_recOwned;
                      bool _802_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _803_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out358;
                      bool _out359;
                      bool _out360;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out361;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out358, out _out359, out _out360, out _out361);
                      _800_recursiveGen = _out358;
                      _801_recOwned = _out359;
                      _802_recErased = _out360;
                      _803_recIdents = _out361;
                      Dafny.ISequence<Dafny.Rune> _804_uneraseFn;
                      _804_uneraseFn = ((_801_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _804_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _800_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _801_recOwned;
                      isErased = true;
                      readIdents = _803_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out362;
                      bool _out363;
                      bool _out364;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out365;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _799_b), _799_b, _553_toTpe), selfIdent, @params, mustOwn, out _out362, out _out363, out _out364, out _out365);
                      s = _out362;
                      isOwned = _out363;
                      isErased = _out364;
                      readIdents = _out365;
                    }
                  }
                } else if (_source36.is_Primitive) {
                  DAST._IPrimitive _805___mcc_h416 = _source36.dtor_Primitive_a0;
                  DAST._IType _806_b = _723___mcc_h364;
                  {
                    if (object.Equals(_806_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _807_recursiveGen;
                      bool _808_recOwned;
                      bool _809_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _810_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out366;
                      bool _out367;
                      bool _out368;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out369;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out366, out _out367, out _out368, out _out369);
                      _807_recursiveGen = _out366;
                      _808_recOwned = _out367;
                      _809_recErased = _out368;
                      _810_recIdents = _out369;
                      Dafny.ISequence<Dafny.Rune> _811_uneraseFn;
                      _811_uneraseFn = ((_808_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _811_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _807_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _808_recOwned;
                      isErased = true;
                      readIdents = _810_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out370;
                      bool _out371;
                      bool _out372;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out373;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _806_b), _806_b, _553_toTpe), selfIdent, @params, mustOwn, out _out370, out _out371, out _out372, out _out373);
                      s = _out370;
                      isOwned = _out371;
                      isErased = _out372;
                      readIdents = _out373;
                    }
                  }
                } else if (_source36.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _812___mcc_h419 = _source36.dtor_Passthrough_a0;
                  DAST._IType _813_b = _723___mcc_h364;
                  {
                    if (object.Equals(_813_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _814_recursiveGen;
                      bool _815_recOwned;
                      bool _816_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _817_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out374;
                      bool _out375;
                      bool _out376;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out377;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out374, out _out375, out _out376, out _out377);
                      _814_recursiveGen = _out374;
                      _815_recOwned = _out375;
                      _816_recErased = _out376;
                      _817_recIdents = _out377;
                      Dafny.ISequence<Dafny.Rune> _818_uneraseFn;
                      _818_uneraseFn = ((_815_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _818_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _814_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _815_recOwned;
                      isErased = true;
                      readIdents = _817_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out378;
                      bool _out379;
                      bool _out380;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out381;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _813_b), _813_b, _553_toTpe), selfIdent, @params, mustOwn, out _out378, out _out379, out _out380, out _out381);
                      s = _out378;
                      isOwned = _out379;
                      isErased = _out380;
                      readIdents = _out381;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _819___mcc_h422 = _source36.dtor_TypeArg_a0;
                  DAST._IType _820_b = _723___mcc_h364;
                  {
                    if (object.Equals(_820_b, _553_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _821_recursiveGen;
                      bool _822_recOwned;
                      bool _823_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _824_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out382;
                      bool _out383;
                      bool _out384;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out385;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out382, out _out383, out _out384, out _out385);
                      _821_recursiveGen = _out382;
                      _822_recOwned = _out383;
                      _823_recErased = _out384;
                      _824_recIdents = _out385;
                      Dafny.ISequence<Dafny.Rune> _825_uneraseFn;
                      _825_uneraseFn = ((_822_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _825_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _821_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _822_recOwned;
                      isErased = true;
                      readIdents = _824_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out386;
                      bool _out387;
                      bool _out388;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out389;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _820_b), _820_b, _553_toTpe), selfIdent, @params, mustOwn, out _out386, out _out387, out _out388, out _out389);
                      s = _out386;
                      isOwned = _out387;
                      isErased = _out388;
                      readIdents = _out389;
                    }
                  }
                }
              }
            } else if (_source30.is_Nullable) {
              DAST._IType _826___mcc_h425 = _source30.dtor_Nullable_a0;
              DAST._IType _source38 = _561___mcc_h265;
              if (_source38.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _827___mcc_h429 = _source38.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _828___mcc_h430 = _source38.dtor_typeArgs;
                DAST._IResolvedType _829___mcc_h431 = _source38.dtor_resolved;
                DAST._IResolvedType _source39 = _829___mcc_h431;
                if (_source39.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _830___mcc_h438 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _831_recursiveGen;
                    bool _832_recOwned;
                    bool _833_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _834_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out390;
                    bool _out391;
                    bool _out392;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out393;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out390, out _out391, out _out392, out _out393);
                    _831_recursiveGen = _out390;
                    _832_recOwned = _out391;
                    _833_recErased = _out392;
                    _834_recIdents = _out393;
                    if (!(_832_recOwned)) {
                      _831_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_831_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_831_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _832_recOwned;
                    isErased = _833_recErased;
                    readIdents = _834_recIdents;
                  }
                } else if (_source39.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _835___mcc_h441 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _836_recursiveGen;
                    bool _837_recOwned;
                    bool _838_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _839_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out394;
                    bool _out395;
                    bool _out396;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out397;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out394, out _out395, out _out396, out _out397);
                    _836_recursiveGen = _out394;
                    _837_recOwned = _out395;
                    _838_recErased = _out396;
                    _839_recIdents = _out397;
                    if (!(_837_recOwned)) {
                      _836_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_836_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_836_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _837_recOwned;
                    isErased = _838_recErased;
                    readIdents = _839_recIdents;
                  }
                } else {
                  DAST._IType _840___mcc_h444 = _source39.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _841_recursiveGen;
                    bool _842_recOwned;
                    bool _843_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _844_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out398;
                    bool _out399;
                    bool _out400;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out401;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out398, out _out399, out _out400, out _out401);
                    _841_recursiveGen = _out398;
                    _842_recOwned = _out399;
                    _843_recErased = _out400;
                    _844_recIdents = _out401;
                    if (!(_842_recOwned)) {
                      _841_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_841_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_841_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _842_recOwned;
                    isErased = _843_recErased;
                    readIdents = _844_recIdents;
                  }
                }
              } else if (_source38.is_Nullable) {
                DAST._IType _845___mcc_h447 = _source38.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _846_recursiveGen;
                  bool _847_recOwned;
                  bool _848_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _849_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out402;
                  bool _out403;
                  bool _out404;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out405;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out402, out _out403, out _out404, out _out405);
                  _846_recursiveGen = _out402;
                  _847_recOwned = _out403;
                  _848_recErased = _out404;
                  _849_recIdents = _out405;
                  if (!(_847_recOwned)) {
                    _846_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_846_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_846_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _847_recOwned;
                  isErased = _848_recErased;
                  readIdents = _849_recIdents;
                }
              } else if (_source38.is_Tuple) {
                Dafny.ISequence<DAST._IType> _850___mcc_h450 = _source38.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _851_recursiveGen;
                  bool _852_recOwned;
                  bool _853_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _854_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out406;
                  bool _out407;
                  bool _out408;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out409;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out406, out _out407, out _out408, out _out409);
                  _851_recursiveGen = _out406;
                  _852_recOwned = _out407;
                  _853_recErased = _out408;
                  _854_recIdents = _out409;
                  if (!(_852_recOwned)) {
                    _851_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_851_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_851_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _852_recOwned;
                  isErased = _853_recErased;
                  readIdents = _854_recIdents;
                }
              } else if (_source38.is_Array) {
                DAST._IType _855___mcc_h453 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _856_recursiveGen;
                  bool _857_recOwned;
                  bool _858_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _859_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out410;
                  bool _out411;
                  bool _out412;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out413;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out410, out _out411, out _out412, out _out413);
                  _856_recursiveGen = _out410;
                  _857_recOwned = _out411;
                  _858_recErased = _out412;
                  _859_recIdents = _out413;
                  if (!(_857_recOwned)) {
                    _856_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_856_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_856_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _857_recOwned;
                  isErased = _858_recErased;
                  readIdents = _859_recIdents;
                }
              } else if (_source38.is_Seq) {
                DAST._IType _860___mcc_h456 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _861_recursiveGen;
                  bool _862_recOwned;
                  bool _863_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _864_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out414;
                  bool _out415;
                  bool _out416;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out417;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out414, out _out415, out _out416, out _out417);
                  _861_recursiveGen = _out414;
                  _862_recOwned = _out415;
                  _863_recErased = _out416;
                  _864_recIdents = _out417;
                  if (!(_862_recOwned)) {
                    _861_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_861_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_861_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _862_recOwned;
                  isErased = _863_recErased;
                  readIdents = _864_recIdents;
                }
              } else if (_source38.is_Set) {
                DAST._IType _865___mcc_h459 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _866_recursiveGen;
                  bool _867_recOwned;
                  bool _868_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _869_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out418;
                  bool _out419;
                  bool _out420;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out421;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out418, out _out419, out _out420, out _out421);
                  _866_recursiveGen = _out418;
                  _867_recOwned = _out419;
                  _868_recErased = _out420;
                  _869_recIdents = _out421;
                  if (!(_867_recOwned)) {
                    _866_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_866_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_866_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _867_recOwned;
                  isErased = _868_recErased;
                  readIdents = _869_recIdents;
                }
              } else if (_source38.is_Multiset) {
                DAST._IType _870___mcc_h462 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _871_recursiveGen;
                  bool _872_recOwned;
                  bool _873_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _874_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out422;
                  bool _out423;
                  bool _out424;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out425;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out422, out _out423, out _out424, out _out425);
                  _871_recursiveGen = _out422;
                  _872_recOwned = _out423;
                  _873_recErased = _out424;
                  _874_recIdents = _out425;
                  if (!(_872_recOwned)) {
                    _871_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_871_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_871_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _872_recOwned;
                  isErased = _873_recErased;
                  readIdents = _874_recIdents;
                }
              } else if (_source38.is_Map) {
                DAST._IType _875___mcc_h465 = _source38.dtor_key;
                DAST._IType _876___mcc_h466 = _source38.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _877_recursiveGen;
                  bool _878_recOwned;
                  bool _879_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _880_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out426;
                  bool _out427;
                  bool _out428;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out429;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out426, out _out427, out _out428, out _out429);
                  _877_recursiveGen = _out426;
                  _878_recOwned = _out427;
                  _879_recErased = _out428;
                  _880_recIdents = _out429;
                  if (!(_878_recOwned)) {
                    _877_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_877_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_877_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _878_recOwned;
                  isErased = _879_recErased;
                  readIdents = _880_recIdents;
                }
              } else if (_source38.is_Arrow) {
                Dafny.ISequence<DAST._IType> _881___mcc_h471 = _source38.dtor_args;
                DAST._IType _882___mcc_h472 = _source38.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _883_recursiveGen;
                  bool _884_recOwned;
                  bool _885_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _886_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out430;
                  bool _out431;
                  bool _out432;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out433;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out430, out _out431, out _out432, out _out433);
                  _883_recursiveGen = _out430;
                  _884_recOwned = _out431;
                  _885_recErased = _out432;
                  _886_recIdents = _out433;
                  if (!(_884_recOwned)) {
                    _883_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_883_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_883_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _884_recOwned;
                  isErased = _885_recErased;
                  readIdents = _886_recIdents;
                }
              } else if (_source38.is_Primitive) {
                DAST._IPrimitive _887___mcc_h477 = _source38.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _888_recursiveGen;
                  bool _889_recOwned;
                  bool _890_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _891_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out434;
                  bool _out435;
                  bool _out436;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out437;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out434, out _out435, out _out436, out _out437);
                  _888_recursiveGen = _out434;
                  _889_recOwned = _out435;
                  _890_recErased = _out436;
                  _891_recIdents = _out437;
                  if (!(_889_recOwned)) {
                    _888_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_888_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_888_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _889_recOwned;
                  isErased = _890_recErased;
                  readIdents = _891_recIdents;
                }
              } else if (_source38.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _892___mcc_h480 = _source38.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _893_recursiveGen;
                  bool _894_recOwned;
                  bool _895_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _896_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out438;
                  bool _out439;
                  bool _out440;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out441;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out438, out _out439, out _out440, out _out441);
                  _893_recursiveGen = _out438;
                  _894_recOwned = _out439;
                  _895_recErased = _out440;
                  _896_recIdents = _out441;
                  if (!(_894_recOwned)) {
                    _893_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_893_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_893_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _894_recOwned;
                  isErased = _895_recErased;
                  readIdents = _896_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _897___mcc_h483 = _source38.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _898_recursiveGen;
                  bool _899_recOwned;
                  bool _900_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _901_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out442;
                  bool _out443;
                  bool _out444;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out445;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out442, out _out443, out _out444, out _out445);
                  _898_recursiveGen = _out442;
                  _899_recOwned = _out443;
                  _900_recErased = _out444;
                  _901_recIdents = _out445;
                  if (!(_899_recOwned)) {
                    _898_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_898_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_898_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _899_recOwned;
                  isErased = _900_recErased;
                  readIdents = _901_recIdents;
                }
              }
            } else if (_source30.is_Tuple) {
              Dafny.ISequence<DAST._IType> _902___mcc_h486 = _source30.dtor_Tuple_a0;
              DAST._IType _source40 = _561___mcc_h265;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _903___mcc_h490 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _904___mcc_h491 = _source40.dtor_typeArgs;
                DAST._IResolvedType _905___mcc_h492 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _905___mcc_h492;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _906___mcc_h496 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _907_recursiveGen;
                    bool _908_recOwned;
                    bool _909_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _910_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out446;
                    bool _out447;
                    bool _out448;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out449;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out446, out _out447, out _out448, out _out449);
                    _907_recursiveGen = _out446;
                    _908_recOwned = _out447;
                    _909_recErased = _out448;
                    _910_recIdents = _out449;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _907_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _908_recOwned;
                    isErased = _909_recErased;
                    readIdents = _910_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _911___mcc_h498 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _912_recursiveGen;
                    bool _913_recOwned;
                    bool _914_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _915_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out450;
                    bool _out451;
                    bool _out452;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out453;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out450, out _out451, out _out452, out _out453);
                    _912_recursiveGen = _out450;
                    _913_recOwned = _out451;
                    _914_recErased = _out452;
                    _915_recIdents = _out453;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _912_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _913_recOwned;
                    isErased = _914_recErased;
                    readIdents = _915_recIdents;
                  }
                } else {
                  DAST._IType _916___mcc_h500 = _source41.dtor_Newtype_a0;
                  DAST._IType _917_b = _916___mcc_h500;
                  {
                    if (object.Equals(_554_fromTpe, _917_b)) {
                      Dafny.ISequence<Dafny.Rune> _918_recursiveGen;
                      bool _919_recOwned;
                      bool _920_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _921_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out454;
                      bool _out455;
                      bool _out456;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out457;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out454, out _out455, out _out456, out _out457);
                      _918_recursiveGen = _out454;
                      _919_recOwned = _out455;
                      _920_recErased = _out456;
                      _921_recIdents = _out457;
                      Dafny.ISequence<Dafny.Rune> _922_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out458;
                      _out458 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _922_rhsType = _out458;
                      Dafny.ISequence<Dafny.Rune> _923_uneraseFn;
                      _923_uneraseFn = ((_919_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _922_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _923_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _918_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _919_recOwned;
                      isErased = false;
                      readIdents = _921_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out459;
                      bool _out460;
                      bool _out461;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out462;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _917_b), _917_b, _553_toTpe), selfIdent, @params, mustOwn, out _out459, out _out460, out _out461, out _out462);
                      s = _out459;
                      isOwned = _out460;
                      isErased = _out461;
                      readIdents = _out462;
                    }
                  }
                }
              } else if (_source40.is_Nullable) {
                DAST._IType _924___mcc_h502 = _source40.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _925_recursiveGen;
                  bool _926_recOwned;
                  bool _927_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _928_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out463;
                  bool _out464;
                  bool _out465;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out466;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out463, out _out464, out _out465, out _out466);
                  _925_recursiveGen = _out463;
                  _926_recOwned = _out464;
                  _927_recErased = _out465;
                  _928_recIdents = _out466;
                  if (!(_926_recOwned)) {
                    _925_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_925_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _927_recErased;
                  readIdents = _928_recIdents;
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _929___mcc_h504 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _930_recursiveGen;
                  bool _931_recOwned;
                  bool _932_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _933_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out467;
                  bool _out468;
                  bool _out469;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out470;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out467, out _out468, out _out469, out _out470);
                  _930_recursiveGen = _out467;
                  _931_recOwned = _out468;
                  _932_recErased = _out469;
                  _933_recIdents = _out470;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _931_recOwned;
                  isErased = _932_recErased;
                  readIdents = _933_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _934___mcc_h506 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _935_recursiveGen;
                  bool _936_recOwned;
                  bool _937_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _938_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out471;
                  bool _out472;
                  bool _out473;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out474;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out471, out _out472, out _out473, out _out474);
                  _935_recursiveGen = _out471;
                  _936_recOwned = _out472;
                  _937_recErased = _out473;
                  _938_recIdents = _out474;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _935_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _936_recOwned;
                  isErased = _937_recErased;
                  readIdents = _938_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _939___mcc_h508 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _940_recursiveGen;
                  bool _941_recOwned;
                  bool _942_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _943_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out475;
                  bool _out476;
                  bool _out477;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out478;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out475, out _out476, out _out477, out _out478);
                  _940_recursiveGen = _out475;
                  _941_recOwned = _out476;
                  _942_recErased = _out477;
                  _943_recIdents = _out478;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _940_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _941_recOwned;
                  isErased = _942_recErased;
                  readIdents = _943_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _944___mcc_h510 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _945_recursiveGen;
                  bool _946_recOwned;
                  bool _947_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _948_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out479;
                  bool _out480;
                  bool _out481;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out482;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out479, out _out480, out _out481, out _out482);
                  _945_recursiveGen = _out479;
                  _946_recOwned = _out480;
                  _947_recErased = _out481;
                  _948_recIdents = _out482;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _945_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _946_recOwned;
                  isErased = _947_recErased;
                  readIdents = _948_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _949___mcc_h512 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _950_recursiveGen;
                  bool _951_recOwned;
                  bool _952_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _953_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out483;
                  bool _out484;
                  bool _out485;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out486;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out483, out _out484, out _out485, out _out486);
                  _950_recursiveGen = _out483;
                  _951_recOwned = _out484;
                  _952_recErased = _out485;
                  _953_recIdents = _out486;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _950_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _951_recOwned;
                  isErased = _952_recErased;
                  readIdents = _953_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _954___mcc_h514 = _source40.dtor_key;
                DAST._IType _955___mcc_h515 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _956_recursiveGen;
                  bool _957_recOwned;
                  bool _958_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _959_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out487;
                  bool _out488;
                  bool _out489;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out490;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out487, out _out488, out _out489, out _out490);
                  _956_recursiveGen = _out487;
                  _957_recOwned = _out488;
                  _958_recErased = _out489;
                  _959_recIdents = _out490;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _956_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _957_recOwned;
                  isErased = _958_recErased;
                  readIdents = _959_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _960___mcc_h518 = _source40.dtor_args;
                DAST._IType _961___mcc_h519 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _962_recursiveGen;
                  bool _963_recOwned;
                  bool _964_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _965_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out491;
                  bool _out492;
                  bool _out493;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out494;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out491, out _out492, out _out493, out _out494);
                  _962_recursiveGen = _out491;
                  _963_recOwned = _out492;
                  _964_recErased = _out493;
                  _965_recIdents = _out494;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _962_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _963_recOwned;
                  isErased = _964_recErased;
                  readIdents = _965_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _966___mcc_h522 = _source40.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _967_recursiveGen;
                  bool _968_recOwned;
                  bool _969_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _970_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out495;
                  bool _out496;
                  bool _out497;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out498;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out495, out _out496, out _out497, out _out498);
                  _967_recursiveGen = _out495;
                  _968_recOwned = _out496;
                  _969_recErased = _out497;
                  _970_recIdents = _out498;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _967_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _968_recOwned;
                  isErased = _969_recErased;
                  readIdents = _970_recIdents;
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _971___mcc_h524 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _972_recursiveGen;
                  bool _973_recOwned;
                  bool _974_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _975_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out499;
                  bool _out500;
                  bool _out501;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out502;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out499, out _out500, out _out501, out _out502);
                  _972_recursiveGen = _out499;
                  _973_recOwned = _out500;
                  _974_recErased = _out501;
                  _975_recIdents = _out502;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _972_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _973_recOwned;
                  isErased = _974_recErased;
                  readIdents = _975_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _976___mcc_h526 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _977_recursiveGen;
                  bool _978_recOwned;
                  bool _979_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _980_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out503;
                  bool _out504;
                  bool _out505;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out506;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out503, out _out504, out _out505, out _out506);
                  _977_recursiveGen = _out503;
                  _978_recOwned = _out504;
                  _979_recErased = _out505;
                  _980_recIdents = _out506;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _977_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _978_recOwned;
                  isErased = _979_recErased;
                  readIdents = _980_recIdents;
                }
              }
            } else if (_source30.is_Array) {
              DAST._IType _981___mcc_h528 = _source30.dtor_element;
              DAST._IType _source42 = _561___mcc_h265;
              if (_source42.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _982___mcc_h532 = _source42.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _983___mcc_h533 = _source42.dtor_typeArgs;
                DAST._IResolvedType _984___mcc_h534 = _source42.dtor_resolved;
                DAST._IResolvedType _source43 = _984___mcc_h534;
                if (_source43.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _985___mcc_h538 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _986_recursiveGen;
                    bool _987_recOwned;
                    bool _988_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _989_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out507;
                    bool _out508;
                    bool _out509;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out510;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out507, out _out508, out _out509, out _out510);
                    _986_recursiveGen = _out507;
                    _987_recOwned = _out508;
                    _988_recErased = _out509;
                    _989_recIdents = _out510;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _986_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _987_recOwned;
                    isErased = _988_recErased;
                    readIdents = _989_recIdents;
                  }
                } else if (_source43.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _990___mcc_h540 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _991_recursiveGen;
                    bool _992_recOwned;
                    bool _993_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _994_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out511;
                    bool _out512;
                    bool _out513;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out514;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out511, out _out512, out _out513, out _out514);
                    _991_recursiveGen = _out511;
                    _992_recOwned = _out512;
                    _993_recErased = _out513;
                    _994_recIdents = _out514;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _991_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _992_recOwned;
                    isErased = _993_recErased;
                    readIdents = _994_recIdents;
                  }
                } else {
                  DAST._IType _995___mcc_h542 = _source43.dtor_Newtype_a0;
                  DAST._IType _996_b = _995___mcc_h542;
                  {
                    if (object.Equals(_554_fromTpe, _996_b)) {
                      Dafny.ISequence<Dafny.Rune> _997_recursiveGen;
                      bool _998_recOwned;
                      bool _999_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1000_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out515;
                      bool _out516;
                      bool _out517;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out518;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out515, out _out516, out _out517, out _out518);
                      _997_recursiveGen = _out515;
                      _998_recOwned = _out516;
                      _999_recErased = _out517;
                      _1000_recIdents = _out518;
                      Dafny.ISequence<Dafny.Rune> _1001_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out519;
                      _out519 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _1001_rhsType = _out519;
                      Dafny.ISequence<Dafny.Rune> _1002_uneraseFn;
                      _1002_uneraseFn = ((_998_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1001_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1002_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _997_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _998_recOwned;
                      isErased = false;
                      readIdents = _1000_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out520;
                      bool _out521;
                      bool _out522;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out523;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _996_b), _996_b, _553_toTpe), selfIdent, @params, mustOwn, out _out520, out _out521, out _out522, out _out523);
                      s = _out520;
                      isOwned = _out521;
                      isErased = _out522;
                      readIdents = _out523;
                    }
                  }
                }
              } else if (_source42.is_Nullable) {
                DAST._IType _1003___mcc_h544 = _source42.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1004_recursiveGen;
                  bool _1005_recOwned;
                  bool _1006_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1007_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out524;
                  bool _out525;
                  bool _out526;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out527;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out524, out _out525, out _out526, out _out527);
                  _1004_recursiveGen = _out524;
                  _1005_recOwned = _out525;
                  _1006_recErased = _out526;
                  _1007_recIdents = _out527;
                  if (!(_1005_recOwned)) {
                    _1004_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1004_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1004_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1006_recErased;
                  readIdents = _1007_recIdents;
                }
              } else if (_source42.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1008___mcc_h546 = _source42.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1009_recursiveGen;
                  bool _1010_recOwned;
                  bool _1011_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1012_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out528;
                  bool _out529;
                  bool _out530;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out531;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out528, out _out529, out _out530, out _out531);
                  _1009_recursiveGen = _out528;
                  _1010_recOwned = _out529;
                  _1011_recErased = _out530;
                  _1012_recIdents = _out531;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1010_recOwned;
                  isErased = _1011_recErased;
                  readIdents = _1012_recIdents;
                }
              } else if (_source42.is_Array) {
                DAST._IType _1013___mcc_h548 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1014_recursiveGen;
                  bool _1015_recOwned;
                  bool _1016_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1017_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out532;
                  bool _out533;
                  bool _out534;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out535;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out532, out _out533, out _out534, out _out535);
                  _1014_recursiveGen = _out532;
                  _1015_recOwned = _out533;
                  _1016_recErased = _out534;
                  _1017_recIdents = _out535;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1014_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1015_recOwned;
                  isErased = _1016_recErased;
                  readIdents = _1017_recIdents;
                }
              } else if (_source42.is_Seq) {
                DAST._IType _1018___mcc_h550 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1019_recursiveGen;
                  bool _1020_recOwned;
                  bool _1021_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1022_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out536;
                  bool _out537;
                  bool _out538;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out539;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out536, out _out537, out _out538, out _out539);
                  _1019_recursiveGen = _out536;
                  _1020_recOwned = _out537;
                  _1021_recErased = _out538;
                  _1022_recIdents = _out539;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1019_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1020_recOwned;
                  isErased = _1021_recErased;
                  readIdents = _1022_recIdents;
                }
              } else if (_source42.is_Set) {
                DAST._IType _1023___mcc_h552 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1024_recursiveGen;
                  bool _1025_recOwned;
                  bool _1026_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1027_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out540;
                  bool _out541;
                  bool _out542;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out543;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out540, out _out541, out _out542, out _out543);
                  _1024_recursiveGen = _out540;
                  _1025_recOwned = _out541;
                  _1026_recErased = _out542;
                  _1027_recIdents = _out543;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1024_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1025_recOwned;
                  isErased = _1026_recErased;
                  readIdents = _1027_recIdents;
                }
              } else if (_source42.is_Multiset) {
                DAST._IType _1028___mcc_h554 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1029_recursiveGen;
                  bool _1030_recOwned;
                  bool _1031_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1032_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out544;
                  bool _out545;
                  bool _out546;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out547;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out544, out _out545, out _out546, out _out547);
                  _1029_recursiveGen = _out544;
                  _1030_recOwned = _out545;
                  _1031_recErased = _out546;
                  _1032_recIdents = _out547;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1029_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1030_recOwned;
                  isErased = _1031_recErased;
                  readIdents = _1032_recIdents;
                }
              } else if (_source42.is_Map) {
                DAST._IType _1033___mcc_h556 = _source42.dtor_key;
                DAST._IType _1034___mcc_h557 = _source42.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1035_recursiveGen;
                  bool _1036_recOwned;
                  bool _1037_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1038_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out548;
                  bool _out549;
                  bool _out550;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out551;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out548, out _out549, out _out550, out _out551);
                  _1035_recursiveGen = _out548;
                  _1036_recOwned = _out549;
                  _1037_recErased = _out550;
                  _1038_recIdents = _out551;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1035_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1036_recOwned;
                  isErased = _1037_recErased;
                  readIdents = _1038_recIdents;
                }
              } else if (_source42.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1039___mcc_h560 = _source42.dtor_args;
                DAST._IType _1040___mcc_h561 = _source42.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1041_recursiveGen;
                  bool _1042_recOwned;
                  bool _1043_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1044_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out552;
                  bool _out553;
                  bool _out554;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out555;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out552, out _out553, out _out554, out _out555);
                  _1041_recursiveGen = _out552;
                  _1042_recOwned = _out553;
                  _1043_recErased = _out554;
                  _1044_recIdents = _out555;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1041_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1042_recOwned;
                  isErased = _1043_recErased;
                  readIdents = _1044_recIdents;
                }
              } else if (_source42.is_Primitive) {
                DAST._IPrimitive _1045___mcc_h564 = _source42.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1046_recursiveGen;
                  bool _1047_recOwned;
                  bool _1048_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1049_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out556;
                  bool _out557;
                  bool _out558;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out559;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out556, out _out557, out _out558, out _out559);
                  _1046_recursiveGen = _out556;
                  _1047_recOwned = _out557;
                  _1048_recErased = _out558;
                  _1049_recIdents = _out559;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1046_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1047_recOwned;
                  isErased = _1048_recErased;
                  readIdents = _1049_recIdents;
                }
              } else if (_source42.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1050___mcc_h566 = _source42.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1051_recursiveGen;
                  bool _1052_recOwned;
                  bool _1053_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1054_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out560;
                  bool _out561;
                  bool _out562;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out563;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out560, out _out561, out _out562, out _out563);
                  _1051_recursiveGen = _out560;
                  _1052_recOwned = _out561;
                  _1053_recErased = _out562;
                  _1054_recIdents = _out563;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1051_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1052_recOwned;
                  isErased = _1053_recErased;
                  readIdents = _1054_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1055___mcc_h568 = _source42.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1056_recursiveGen;
                  bool _1057_recOwned;
                  bool _1058_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1059_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out564;
                  bool _out565;
                  bool _out566;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out567;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out564, out _out565, out _out566, out _out567);
                  _1056_recursiveGen = _out564;
                  _1057_recOwned = _out565;
                  _1058_recErased = _out566;
                  _1059_recIdents = _out567;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1056_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1057_recOwned;
                  isErased = _1058_recErased;
                  readIdents = _1059_recIdents;
                }
              }
            } else if (_source30.is_Seq) {
              DAST._IType _1060___mcc_h570 = _source30.dtor_element;
              DAST._IType _source44 = _561___mcc_h265;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1061___mcc_h574 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1062___mcc_h575 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1063___mcc_h576 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1063___mcc_h576;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1064___mcc_h580 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1065_recursiveGen;
                    bool _1066_recOwned;
                    bool _1067_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1068_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out568;
                    bool _out569;
                    bool _out570;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out571;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out568, out _out569, out _out570, out _out571);
                    _1065_recursiveGen = _out568;
                    _1066_recOwned = _out569;
                    _1067_recErased = _out570;
                    _1068_recIdents = _out571;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1065_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1066_recOwned;
                    isErased = _1067_recErased;
                    readIdents = _1068_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1069___mcc_h582 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1070_recursiveGen;
                    bool _1071_recOwned;
                    bool _1072_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1073_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out572;
                    bool _out573;
                    bool _out574;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out575;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out572, out _out573, out _out574, out _out575);
                    _1070_recursiveGen = _out572;
                    _1071_recOwned = _out573;
                    _1072_recErased = _out574;
                    _1073_recIdents = _out575;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1070_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1071_recOwned;
                    isErased = _1072_recErased;
                    readIdents = _1073_recIdents;
                  }
                } else {
                  DAST._IType _1074___mcc_h584 = _source45.dtor_Newtype_a0;
                  DAST._IType _1075_b = _1074___mcc_h584;
                  {
                    if (object.Equals(_554_fromTpe, _1075_b)) {
                      Dafny.ISequence<Dafny.Rune> _1076_recursiveGen;
                      bool _1077_recOwned;
                      bool _1078_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1079_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out576;
                      bool _out577;
                      bool _out578;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out579;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out576, out _out577, out _out578, out _out579);
                      _1076_recursiveGen = _out576;
                      _1077_recOwned = _out577;
                      _1078_recErased = _out578;
                      _1079_recIdents = _out579;
                      Dafny.ISequence<Dafny.Rune> _1080_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out580;
                      _out580 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _1080_rhsType = _out580;
                      Dafny.ISequence<Dafny.Rune> _1081_uneraseFn;
                      _1081_uneraseFn = ((_1077_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1080_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1081_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1076_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1077_recOwned;
                      isErased = false;
                      readIdents = _1079_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out581;
                      bool _out582;
                      bool _out583;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out584;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1075_b), _1075_b, _553_toTpe), selfIdent, @params, mustOwn, out _out581, out _out582, out _out583, out _out584);
                      s = _out581;
                      isOwned = _out582;
                      isErased = _out583;
                      readIdents = _out584;
                    }
                  }
                }
              } else if (_source44.is_Nullable) {
                DAST._IType _1082___mcc_h586 = _source44.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1083_recursiveGen;
                  bool _1084_recOwned;
                  bool _1085_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1086_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out585;
                  bool _out586;
                  bool _out587;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out588;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out585, out _out586, out _out587, out _out588);
                  _1083_recursiveGen = _out585;
                  _1084_recOwned = _out586;
                  _1085_recErased = _out587;
                  _1086_recIdents = _out588;
                  if (!(_1084_recOwned)) {
                    _1083_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1083_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1083_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1085_recErased;
                  readIdents = _1086_recIdents;
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1087___mcc_h588 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1088_recursiveGen;
                  bool _1089_recOwned;
                  bool _1090_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1091_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out589;
                  bool _out590;
                  bool _out591;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out592;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out589, out _out590, out _out591, out _out592);
                  _1088_recursiveGen = _out589;
                  _1089_recOwned = _out590;
                  _1090_recErased = _out591;
                  _1091_recIdents = _out592;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1088_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1089_recOwned;
                  isErased = _1090_recErased;
                  readIdents = _1091_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1092___mcc_h590 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1093_recursiveGen;
                  bool _1094_recOwned;
                  bool _1095_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1096_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out593;
                  bool _out594;
                  bool _out595;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out596;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out593, out _out594, out _out595, out _out596);
                  _1093_recursiveGen = _out593;
                  _1094_recOwned = _out594;
                  _1095_recErased = _out595;
                  _1096_recIdents = _out596;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1093_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1094_recOwned;
                  isErased = _1095_recErased;
                  readIdents = _1096_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1097___mcc_h592 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1098_recursiveGen;
                  bool _1099_recOwned;
                  bool _1100_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1101_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out597;
                  bool _out598;
                  bool _out599;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out600;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out597, out _out598, out _out599, out _out600);
                  _1098_recursiveGen = _out597;
                  _1099_recOwned = _out598;
                  _1100_recErased = _out599;
                  _1101_recIdents = _out600;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1098_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1099_recOwned;
                  isErased = _1100_recErased;
                  readIdents = _1101_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1102___mcc_h594 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1103_recursiveGen;
                  bool _1104_recOwned;
                  bool _1105_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1106_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out601;
                  bool _out602;
                  bool _out603;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out604;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out601, out _out602, out _out603, out _out604);
                  _1103_recursiveGen = _out601;
                  _1104_recOwned = _out602;
                  _1105_recErased = _out603;
                  _1106_recIdents = _out604;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1103_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1104_recOwned;
                  isErased = _1105_recErased;
                  readIdents = _1106_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1107___mcc_h596 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1108_recursiveGen;
                  bool _1109_recOwned;
                  bool _1110_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1111_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out605;
                  bool _out606;
                  bool _out607;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out608;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out605, out _out606, out _out607, out _out608);
                  _1108_recursiveGen = _out605;
                  _1109_recOwned = _out606;
                  _1110_recErased = _out607;
                  _1111_recIdents = _out608;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1108_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1109_recOwned;
                  isErased = _1110_recErased;
                  readIdents = _1111_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1112___mcc_h598 = _source44.dtor_key;
                DAST._IType _1113___mcc_h599 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1114_recursiveGen;
                  bool _1115_recOwned;
                  bool _1116_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1117_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out609;
                  bool _out610;
                  bool _out611;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out612;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out609, out _out610, out _out611, out _out612);
                  _1114_recursiveGen = _out609;
                  _1115_recOwned = _out610;
                  _1116_recErased = _out611;
                  _1117_recIdents = _out612;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1114_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1115_recOwned;
                  isErased = _1116_recErased;
                  readIdents = _1117_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1118___mcc_h602 = _source44.dtor_args;
                DAST._IType _1119___mcc_h603 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1120_recursiveGen;
                  bool _1121_recOwned;
                  bool _1122_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1123_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out613;
                  bool _out614;
                  bool _out615;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out616;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out613, out _out614, out _out615, out _out616);
                  _1120_recursiveGen = _out613;
                  _1121_recOwned = _out614;
                  _1122_recErased = _out615;
                  _1123_recIdents = _out616;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1120_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1121_recOwned;
                  isErased = _1122_recErased;
                  readIdents = _1123_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1124___mcc_h606 = _source44.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1125_recursiveGen;
                  bool _1126_recOwned;
                  bool _1127_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1128_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out617;
                  bool _out618;
                  bool _out619;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out620;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out617, out _out618, out _out619, out _out620);
                  _1125_recursiveGen = _out617;
                  _1126_recOwned = _out618;
                  _1127_recErased = _out619;
                  _1128_recIdents = _out620;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1125_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1126_recOwned;
                  isErased = _1127_recErased;
                  readIdents = _1128_recIdents;
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1129___mcc_h608 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1130_recursiveGen;
                  bool _1131_recOwned;
                  bool _1132_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1133_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out621;
                  bool _out622;
                  bool _out623;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out624;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out621, out _out622, out _out623, out _out624);
                  _1130_recursiveGen = _out621;
                  _1131_recOwned = _out622;
                  _1132_recErased = _out623;
                  _1133_recIdents = _out624;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1130_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1131_recOwned;
                  isErased = _1132_recErased;
                  readIdents = _1133_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1134___mcc_h610 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1135_recursiveGen;
                  bool _1136_recOwned;
                  bool _1137_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1138_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out625;
                  bool _out626;
                  bool _out627;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out628;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out625, out _out626, out _out627, out _out628);
                  _1135_recursiveGen = _out625;
                  _1136_recOwned = _out626;
                  _1137_recErased = _out627;
                  _1138_recIdents = _out628;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1135_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1136_recOwned;
                  isErased = _1137_recErased;
                  readIdents = _1138_recIdents;
                }
              }
            } else if (_source30.is_Set) {
              DAST._IType _1139___mcc_h612 = _source30.dtor_element;
              DAST._IType _source46 = _561___mcc_h265;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1140___mcc_h616 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1141___mcc_h617 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1142___mcc_h618 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1142___mcc_h618;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1143___mcc_h622 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1144_recursiveGen;
                    bool _1145_recOwned;
                    bool _1146_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1147_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out629;
                    bool _out630;
                    bool _out631;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out632;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out629, out _out630, out _out631, out _out632);
                    _1144_recursiveGen = _out629;
                    _1145_recOwned = _out630;
                    _1146_recErased = _out631;
                    _1147_recIdents = _out632;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1144_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1145_recOwned;
                    isErased = _1146_recErased;
                    readIdents = _1147_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1148___mcc_h624 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1149_recursiveGen;
                    bool _1150_recOwned;
                    bool _1151_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1152_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out633;
                    bool _out634;
                    bool _out635;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out636;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out633, out _out634, out _out635, out _out636);
                    _1149_recursiveGen = _out633;
                    _1150_recOwned = _out634;
                    _1151_recErased = _out635;
                    _1152_recIdents = _out636;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1149_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1150_recOwned;
                    isErased = _1151_recErased;
                    readIdents = _1152_recIdents;
                  }
                } else {
                  DAST._IType _1153___mcc_h626 = _source47.dtor_Newtype_a0;
                  DAST._IType _1154_b = _1153___mcc_h626;
                  {
                    if (object.Equals(_554_fromTpe, _1154_b)) {
                      Dafny.ISequence<Dafny.Rune> _1155_recursiveGen;
                      bool _1156_recOwned;
                      bool _1157_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1158_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out637;
                      bool _out638;
                      bool _out639;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out640;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out637, out _out638, out _out639, out _out640);
                      _1155_recursiveGen = _out637;
                      _1156_recOwned = _out638;
                      _1157_recErased = _out639;
                      _1158_recIdents = _out640;
                      Dafny.ISequence<Dafny.Rune> _1159_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out641;
                      _out641 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _1159_rhsType = _out641;
                      Dafny.ISequence<Dafny.Rune> _1160_uneraseFn;
                      _1160_uneraseFn = ((_1156_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1159_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1160_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1155_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1156_recOwned;
                      isErased = false;
                      readIdents = _1158_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out642;
                      bool _out643;
                      bool _out644;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out645;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1154_b), _1154_b, _553_toTpe), selfIdent, @params, mustOwn, out _out642, out _out643, out _out644, out _out645);
                      s = _out642;
                      isOwned = _out643;
                      isErased = _out644;
                      readIdents = _out645;
                    }
                  }
                }
              } else if (_source46.is_Nullable) {
                DAST._IType _1161___mcc_h628 = _source46.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1162_recursiveGen;
                  bool _1163_recOwned;
                  bool _1164_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1165_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out646;
                  bool _out647;
                  bool _out648;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out649;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out646, out _out647, out _out648, out _out649);
                  _1162_recursiveGen = _out646;
                  _1163_recOwned = _out647;
                  _1164_recErased = _out648;
                  _1165_recIdents = _out649;
                  if (!(_1163_recOwned)) {
                    _1162_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1162_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1162_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1164_recErased;
                  readIdents = _1165_recIdents;
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1166___mcc_h630 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1167_recursiveGen;
                  bool _1168_recOwned;
                  bool _1169_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1170_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out650;
                  bool _out651;
                  bool _out652;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out653;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out650, out _out651, out _out652, out _out653);
                  _1167_recursiveGen = _out650;
                  _1168_recOwned = _out651;
                  _1169_recErased = _out652;
                  _1170_recIdents = _out653;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1167_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1168_recOwned;
                  isErased = _1169_recErased;
                  readIdents = _1170_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1171___mcc_h632 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1172_recursiveGen;
                  bool _1173_recOwned;
                  bool _1174_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1175_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out654;
                  bool _out655;
                  bool _out656;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out657;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out654, out _out655, out _out656, out _out657);
                  _1172_recursiveGen = _out654;
                  _1173_recOwned = _out655;
                  _1174_recErased = _out656;
                  _1175_recIdents = _out657;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1172_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1173_recOwned;
                  isErased = _1174_recErased;
                  readIdents = _1175_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1176___mcc_h634 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1177_recursiveGen;
                  bool _1178_recOwned;
                  bool _1179_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1180_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out658;
                  bool _out659;
                  bool _out660;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out661;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out658, out _out659, out _out660, out _out661);
                  _1177_recursiveGen = _out658;
                  _1178_recOwned = _out659;
                  _1179_recErased = _out660;
                  _1180_recIdents = _out661;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1177_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1178_recOwned;
                  isErased = _1179_recErased;
                  readIdents = _1180_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1181___mcc_h636 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1182_recursiveGen;
                  bool _1183_recOwned;
                  bool _1184_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1185_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out662;
                  bool _out663;
                  bool _out664;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out665;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out662, out _out663, out _out664, out _out665);
                  _1182_recursiveGen = _out662;
                  _1183_recOwned = _out663;
                  _1184_recErased = _out664;
                  _1185_recIdents = _out665;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1182_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1183_recOwned;
                  isErased = _1184_recErased;
                  readIdents = _1185_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1186___mcc_h638 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1187_recursiveGen;
                  bool _1188_recOwned;
                  bool _1189_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1190_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out666;
                  bool _out667;
                  bool _out668;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out669;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out666, out _out667, out _out668, out _out669);
                  _1187_recursiveGen = _out666;
                  _1188_recOwned = _out667;
                  _1189_recErased = _out668;
                  _1190_recIdents = _out669;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1187_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1188_recOwned;
                  isErased = _1189_recErased;
                  readIdents = _1190_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1191___mcc_h640 = _source46.dtor_key;
                DAST._IType _1192___mcc_h641 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1193_recursiveGen;
                  bool _1194_recOwned;
                  bool _1195_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1196_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out670;
                  bool _out671;
                  bool _out672;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out673;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out670, out _out671, out _out672, out _out673);
                  _1193_recursiveGen = _out670;
                  _1194_recOwned = _out671;
                  _1195_recErased = _out672;
                  _1196_recIdents = _out673;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1193_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1194_recOwned;
                  isErased = _1195_recErased;
                  readIdents = _1196_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1197___mcc_h644 = _source46.dtor_args;
                DAST._IType _1198___mcc_h645 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1199_recursiveGen;
                  bool _1200_recOwned;
                  bool _1201_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1202_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out674;
                  bool _out675;
                  bool _out676;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out677;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out674, out _out675, out _out676, out _out677);
                  _1199_recursiveGen = _out674;
                  _1200_recOwned = _out675;
                  _1201_recErased = _out676;
                  _1202_recIdents = _out677;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1199_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1200_recOwned;
                  isErased = _1201_recErased;
                  readIdents = _1202_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1203___mcc_h648 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1204_recursiveGen;
                  bool _1205_recOwned;
                  bool _1206_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1207_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out678;
                  bool _out679;
                  bool _out680;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out681;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out678, out _out679, out _out680, out _out681);
                  _1204_recursiveGen = _out678;
                  _1205_recOwned = _out679;
                  _1206_recErased = _out680;
                  _1207_recIdents = _out681;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1204_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1205_recOwned;
                  isErased = _1206_recErased;
                  readIdents = _1207_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1208___mcc_h650 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1209_recursiveGen;
                  bool _1210_recOwned;
                  bool _1211_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1212_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out682;
                  bool _out683;
                  bool _out684;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out685;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out682, out _out683, out _out684, out _out685);
                  _1209_recursiveGen = _out682;
                  _1210_recOwned = _out683;
                  _1211_recErased = _out684;
                  _1212_recIdents = _out685;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1209_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1210_recOwned;
                  isErased = _1211_recErased;
                  readIdents = _1212_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1213___mcc_h652 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1214_recursiveGen;
                  bool _1215_recOwned;
                  bool _1216_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1217_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out686;
                  bool _out687;
                  bool _out688;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out689;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out686, out _out687, out _out688, out _out689);
                  _1214_recursiveGen = _out686;
                  _1215_recOwned = _out687;
                  _1216_recErased = _out688;
                  _1217_recIdents = _out689;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1214_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1215_recOwned;
                  isErased = _1216_recErased;
                  readIdents = _1217_recIdents;
                }
              }
            } else if (_source30.is_Multiset) {
              DAST._IType _1218___mcc_h654 = _source30.dtor_element;
              DAST._IType _source48 = _561___mcc_h265;
              if (_source48.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1219___mcc_h658 = _source48.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1220___mcc_h659 = _source48.dtor_typeArgs;
                DAST._IResolvedType _1221___mcc_h660 = _source48.dtor_resolved;
                DAST._IResolvedType _source49 = _1221___mcc_h660;
                if (_source49.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1222___mcc_h664 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1223_recursiveGen;
                    bool _1224_recOwned;
                    bool _1225_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1226_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out690;
                    bool _out691;
                    bool _out692;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out693;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out690, out _out691, out _out692, out _out693);
                    _1223_recursiveGen = _out690;
                    _1224_recOwned = _out691;
                    _1225_recErased = _out692;
                    _1226_recIdents = _out693;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1223_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1224_recOwned;
                    isErased = _1225_recErased;
                    readIdents = _1226_recIdents;
                  }
                } else if (_source49.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1227___mcc_h666 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1228_recursiveGen;
                    bool _1229_recOwned;
                    bool _1230_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1231_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out694;
                    bool _out695;
                    bool _out696;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out697;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out694, out _out695, out _out696, out _out697);
                    _1228_recursiveGen = _out694;
                    _1229_recOwned = _out695;
                    _1230_recErased = _out696;
                    _1231_recIdents = _out697;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1228_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1229_recOwned;
                    isErased = _1230_recErased;
                    readIdents = _1231_recIdents;
                  }
                } else {
                  DAST._IType _1232___mcc_h668 = _source49.dtor_Newtype_a0;
                  DAST._IType _1233_b = _1232___mcc_h668;
                  {
                    if (object.Equals(_554_fromTpe, _1233_b)) {
                      Dafny.ISequence<Dafny.Rune> _1234_recursiveGen;
                      bool _1235_recOwned;
                      bool _1236_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1237_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out698;
                      bool _out699;
                      bool _out700;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out701;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out698, out _out699, out _out700, out _out701);
                      _1234_recursiveGen = _out698;
                      _1235_recOwned = _out699;
                      _1236_recErased = _out700;
                      _1237_recIdents = _out701;
                      Dafny.ISequence<Dafny.Rune> _1238_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out702;
                      _out702 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _1238_rhsType = _out702;
                      Dafny.ISequence<Dafny.Rune> _1239_uneraseFn;
                      _1239_uneraseFn = ((_1235_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1238_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1239_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1234_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1235_recOwned;
                      isErased = false;
                      readIdents = _1237_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out703;
                      bool _out704;
                      bool _out705;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out706;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1233_b), _1233_b, _553_toTpe), selfIdent, @params, mustOwn, out _out703, out _out704, out _out705, out _out706);
                      s = _out703;
                      isOwned = _out704;
                      isErased = _out705;
                      readIdents = _out706;
                    }
                  }
                }
              } else if (_source48.is_Nullable) {
                DAST._IType _1240___mcc_h670 = _source48.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1241_recursiveGen;
                  bool _1242_recOwned;
                  bool _1243_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1244_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out707;
                  bool _out708;
                  bool _out709;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out710;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out707, out _out708, out _out709, out _out710);
                  _1241_recursiveGen = _out707;
                  _1242_recOwned = _out708;
                  _1243_recErased = _out709;
                  _1244_recIdents = _out710;
                  if (!(_1242_recOwned)) {
                    _1241_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1241_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1241_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1243_recErased;
                  readIdents = _1244_recIdents;
                }
              } else if (_source48.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1245___mcc_h672 = _source48.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1246_recursiveGen;
                  bool _1247_recOwned;
                  bool _1248_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1249_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out711;
                  bool _out712;
                  bool _out713;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out714;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out711, out _out712, out _out713, out _out714);
                  _1246_recursiveGen = _out711;
                  _1247_recOwned = _out712;
                  _1248_recErased = _out713;
                  _1249_recIdents = _out714;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1246_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1247_recOwned;
                  isErased = _1248_recErased;
                  readIdents = _1249_recIdents;
                }
              } else if (_source48.is_Array) {
                DAST._IType _1250___mcc_h674 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1251_recursiveGen;
                  bool _1252_recOwned;
                  bool _1253_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1254_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out715;
                  bool _out716;
                  bool _out717;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out718;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out715, out _out716, out _out717, out _out718);
                  _1251_recursiveGen = _out715;
                  _1252_recOwned = _out716;
                  _1253_recErased = _out717;
                  _1254_recIdents = _out718;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1251_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1252_recOwned;
                  isErased = _1253_recErased;
                  readIdents = _1254_recIdents;
                }
              } else if (_source48.is_Seq) {
                DAST._IType _1255___mcc_h676 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1256_recursiveGen;
                  bool _1257_recOwned;
                  bool _1258_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1259_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out719;
                  bool _out720;
                  bool _out721;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out722;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out719, out _out720, out _out721, out _out722);
                  _1256_recursiveGen = _out719;
                  _1257_recOwned = _out720;
                  _1258_recErased = _out721;
                  _1259_recIdents = _out722;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1256_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1257_recOwned;
                  isErased = _1258_recErased;
                  readIdents = _1259_recIdents;
                }
              } else if (_source48.is_Set) {
                DAST._IType _1260___mcc_h678 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1261_recursiveGen;
                  bool _1262_recOwned;
                  bool _1263_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1264_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out723;
                  bool _out724;
                  bool _out725;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out726;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out723, out _out724, out _out725, out _out726);
                  _1261_recursiveGen = _out723;
                  _1262_recOwned = _out724;
                  _1263_recErased = _out725;
                  _1264_recIdents = _out726;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1261_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1262_recOwned;
                  isErased = _1263_recErased;
                  readIdents = _1264_recIdents;
                }
              } else if (_source48.is_Multiset) {
                DAST._IType _1265___mcc_h680 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1266_recursiveGen;
                  bool _1267_recOwned;
                  bool _1268_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1269_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out727;
                  bool _out728;
                  bool _out729;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out730;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out727, out _out728, out _out729, out _out730);
                  _1266_recursiveGen = _out727;
                  _1267_recOwned = _out728;
                  _1268_recErased = _out729;
                  _1269_recIdents = _out730;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1266_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1267_recOwned;
                  isErased = _1268_recErased;
                  readIdents = _1269_recIdents;
                }
              } else if (_source48.is_Map) {
                DAST._IType _1270___mcc_h682 = _source48.dtor_key;
                DAST._IType _1271___mcc_h683 = _source48.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1272_recursiveGen;
                  bool _1273_recOwned;
                  bool _1274_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1275_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out731;
                  bool _out732;
                  bool _out733;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out734;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out731, out _out732, out _out733, out _out734);
                  _1272_recursiveGen = _out731;
                  _1273_recOwned = _out732;
                  _1274_recErased = _out733;
                  _1275_recIdents = _out734;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1272_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1273_recOwned;
                  isErased = _1274_recErased;
                  readIdents = _1275_recIdents;
                }
              } else if (_source48.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1276___mcc_h686 = _source48.dtor_args;
                DAST._IType _1277___mcc_h687 = _source48.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1278_recursiveGen;
                  bool _1279_recOwned;
                  bool _1280_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1281_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out735;
                  bool _out736;
                  bool _out737;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out738;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out735, out _out736, out _out737, out _out738);
                  _1278_recursiveGen = _out735;
                  _1279_recOwned = _out736;
                  _1280_recErased = _out737;
                  _1281_recIdents = _out738;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1278_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1279_recOwned;
                  isErased = _1280_recErased;
                  readIdents = _1281_recIdents;
                }
              } else if (_source48.is_Primitive) {
                DAST._IPrimitive _1282___mcc_h690 = _source48.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1283_recursiveGen;
                  bool _1284_recOwned;
                  bool _1285_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1286_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out739;
                  bool _out740;
                  bool _out741;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out742;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out739, out _out740, out _out741, out _out742);
                  _1283_recursiveGen = _out739;
                  _1284_recOwned = _out740;
                  _1285_recErased = _out741;
                  _1286_recIdents = _out742;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1283_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1284_recOwned;
                  isErased = _1285_recErased;
                  readIdents = _1286_recIdents;
                }
              } else if (_source48.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1287___mcc_h692 = _source48.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1288_recursiveGen;
                  bool _1289_recOwned;
                  bool _1290_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1291_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out743;
                  bool _out744;
                  bool _out745;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out746;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out743, out _out744, out _out745, out _out746);
                  _1288_recursiveGen = _out743;
                  _1289_recOwned = _out744;
                  _1290_recErased = _out745;
                  _1291_recIdents = _out746;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1288_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1289_recOwned;
                  isErased = _1290_recErased;
                  readIdents = _1291_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1292___mcc_h694 = _source48.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1293_recursiveGen;
                  bool _1294_recOwned;
                  bool _1295_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1296_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out747;
                  bool _out748;
                  bool _out749;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out750;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out747, out _out748, out _out749, out _out750);
                  _1293_recursiveGen = _out747;
                  _1294_recOwned = _out748;
                  _1295_recErased = _out749;
                  _1296_recIdents = _out750;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1293_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1294_recOwned;
                  isErased = _1295_recErased;
                  readIdents = _1296_recIdents;
                }
              }
            } else if (_source30.is_Map) {
              DAST._IType _1297___mcc_h696 = _source30.dtor_key;
              DAST._IType _1298___mcc_h697 = _source30.dtor_value;
              DAST._IType _source50 = _561___mcc_h265;
              if (_source50.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1299___mcc_h704 = _source50.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1300___mcc_h705 = _source50.dtor_typeArgs;
                DAST._IResolvedType _1301___mcc_h706 = _source50.dtor_resolved;
                DAST._IResolvedType _source51 = _1301___mcc_h706;
                if (_source51.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1302___mcc_h710 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1303_recursiveGen;
                    bool _1304_recOwned;
                    bool _1305_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1306_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out751;
                    bool _out752;
                    bool _out753;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out754;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out751, out _out752, out _out753, out _out754);
                    _1303_recursiveGen = _out751;
                    _1304_recOwned = _out752;
                    _1305_recErased = _out753;
                    _1306_recIdents = _out754;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1303_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1304_recOwned;
                    isErased = _1305_recErased;
                    readIdents = _1306_recIdents;
                  }
                } else if (_source51.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1307___mcc_h712 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1308_recursiveGen;
                    bool _1309_recOwned;
                    bool _1310_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1311_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out755;
                    bool _out756;
                    bool _out757;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out758;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out755, out _out756, out _out757, out _out758);
                    _1308_recursiveGen = _out755;
                    _1309_recOwned = _out756;
                    _1310_recErased = _out757;
                    _1311_recIdents = _out758;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1308_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1309_recOwned;
                    isErased = _1310_recErased;
                    readIdents = _1311_recIdents;
                  }
                } else {
                  DAST._IType _1312___mcc_h714 = _source51.dtor_Newtype_a0;
                  DAST._IType _1313_b = _1312___mcc_h714;
                  {
                    if (object.Equals(_554_fromTpe, _1313_b)) {
                      Dafny.ISequence<Dafny.Rune> _1314_recursiveGen;
                      bool _1315_recOwned;
                      bool _1316_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1317_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out759;
                      bool _out760;
                      bool _out761;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out762;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out759, out _out760, out _out761, out _out762);
                      _1314_recursiveGen = _out759;
                      _1315_recOwned = _out760;
                      _1316_recErased = _out761;
                      _1317_recIdents = _out762;
                      Dafny.ISequence<Dafny.Rune> _1318_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out763;
                      _out763 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _1318_rhsType = _out763;
                      Dafny.ISequence<Dafny.Rune> _1319_uneraseFn;
                      _1319_uneraseFn = ((_1315_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1318_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1319_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1314_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1315_recOwned;
                      isErased = false;
                      readIdents = _1317_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out764;
                      bool _out765;
                      bool _out766;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out767;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1313_b), _1313_b, _553_toTpe), selfIdent, @params, mustOwn, out _out764, out _out765, out _out766, out _out767);
                      s = _out764;
                      isOwned = _out765;
                      isErased = _out766;
                      readIdents = _out767;
                    }
                  }
                }
              } else if (_source50.is_Nullable) {
                DAST._IType _1320___mcc_h716 = _source50.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1321_recursiveGen;
                  bool _1322_recOwned;
                  bool _1323_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1324_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out768;
                  bool _out769;
                  bool _out770;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out771;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out768, out _out769, out _out770, out _out771);
                  _1321_recursiveGen = _out768;
                  _1322_recOwned = _out769;
                  _1323_recErased = _out770;
                  _1324_recIdents = _out771;
                  if (!(_1322_recOwned)) {
                    _1321_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1321_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1321_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1323_recErased;
                  readIdents = _1324_recIdents;
                }
              } else if (_source50.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1325___mcc_h718 = _source50.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1326_recursiveGen;
                  bool _1327_recOwned;
                  bool _1328_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1329_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out772;
                  bool _out773;
                  bool _out774;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out775;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out772, out _out773, out _out774, out _out775);
                  _1326_recursiveGen = _out772;
                  _1327_recOwned = _out773;
                  _1328_recErased = _out774;
                  _1329_recIdents = _out775;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1326_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1327_recOwned;
                  isErased = _1328_recErased;
                  readIdents = _1329_recIdents;
                }
              } else if (_source50.is_Array) {
                DAST._IType _1330___mcc_h720 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1331_recursiveGen;
                  bool _1332_recOwned;
                  bool _1333_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1334_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out776;
                  bool _out777;
                  bool _out778;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out779;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out776, out _out777, out _out778, out _out779);
                  _1331_recursiveGen = _out776;
                  _1332_recOwned = _out777;
                  _1333_recErased = _out778;
                  _1334_recIdents = _out779;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1331_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1332_recOwned;
                  isErased = _1333_recErased;
                  readIdents = _1334_recIdents;
                }
              } else if (_source50.is_Seq) {
                DAST._IType _1335___mcc_h722 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1336_recursiveGen;
                  bool _1337_recOwned;
                  bool _1338_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1339_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out780;
                  bool _out781;
                  bool _out782;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out783;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out780, out _out781, out _out782, out _out783);
                  _1336_recursiveGen = _out780;
                  _1337_recOwned = _out781;
                  _1338_recErased = _out782;
                  _1339_recIdents = _out783;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1336_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1337_recOwned;
                  isErased = _1338_recErased;
                  readIdents = _1339_recIdents;
                }
              } else if (_source50.is_Set) {
                DAST._IType _1340___mcc_h724 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1341_recursiveGen;
                  bool _1342_recOwned;
                  bool _1343_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1344_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out784;
                  bool _out785;
                  bool _out786;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out787;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out784, out _out785, out _out786, out _out787);
                  _1341_recursiveGen = _out784;
                  _1342_recOwned = _out785;
                  _1343_recErased = _out786;
                  _1344_recIdents = _out787;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1341_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1342_recOwned;
                  isErased = _1343_recErased;
                  readIdents = _1344_recIdents;
                }
              } else if (_source50.is_Multiset) {
                DAST._IType _1345___mcc_h726 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1346_recursiveGen;
                  bool _1347_recOwned;
                  bool _1348_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1349_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out788;
                  bool _out789;
                  bool _out790;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out791;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out788, out _out789, out _out790, out _out791);
                  _1346_recursiveGen = _out788;
                  _1347_recOwned = _out789;
                  _1348_recErased = _out790;
                  _1349_recIdents = _out791;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1346_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1347_recOwned;
                  isErased = _1348_recErased;
                  readIdents = _1349_recIdents;
                }
              } else if (_source50.is_Map) {
                DAST._IType _1350___mcc_h728 = _source50.dtor_key;
                DAST._IType _1351___mcc_h729 = _source50.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1352_recursiveGen;
                  bool _1353_recOwned;
                  bool _1354_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1355_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out792;
                  bool _out793;
                  bool _out794;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out795;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out792, out _out793, out _out794, out _out795);
                  _1352_recursiveGen = _out792;
                  _1353_recOwned = _out793;
                  _1354_recErased = _out794;
                  _1355_recIdents = _out795;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1352_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1353_recOwned;
                  isErased = _1354_recErased;
                  readIdents = _1355_recIdents;
                }
              } else if (_source50.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1356___mcc_h732 = _source50.dtor_args;
                DAST._IType _1357___mcc_h733 = _source50.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1358_recursiveGen;
                  bool _1359_recOwned;
                  bool _1360_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1361_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out796;
                  bool _out797;
                  bool _out798;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out799;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out796, out _out797, out _out798, out _out799);
                  _1358_recursiveGen = _out796;
                  _1359_recOwned = _out797;
                  _1360_recErased = _out798;
                  _1361_recIdents = _out799;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1358_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1359_recOwned;
                  isErased = _1360_recErased;
                  readIdents = _1361_recIdents;
                }
              } else if (_source50.is_Primitive) {
                DAST._IPrimitive _1362___mcc_h736 = _source50.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1363_recursiveGen;
                  bool _1364_recOwned;
                  bool _1365_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1366_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out800;
                  bool _out801;
                  bool _out802;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out803;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out800, out _out801, out _out802, out _out803);
                  _1363_recursiveGen = _out800;
                  _1364_recOwned = _out801;
                  _1365_recErased = _out802;
                  _1366_recIdents = _out803;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1363_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1364_recOwned;
                  isErased = _1365_recErased;
                  readIdents = _1366_recIdents;
                }
              } else if (_source50.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1367___mcc_h738 = _source50.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1368_recursiveGen;
                  bool _1369_recOwned;
                  bool _1370_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1371_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out804;
                  bool _out805;
                  bool _out806;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out807;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out804, out _out805, out _out806, out _out807);
                  _1368_recursiveGen = _out804;
                  _1369_recOwned = _out805;
                  _1370_recErased = _out806;
                  _1371_recIdents = _out807;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1368_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1369_recOwned;
                  isErased = _1370_recErased;
                  readIdents = _1371_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1372___mcc_h740 = _source50.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1373_recursiveGen;
                  bool _1374_recOwned;
                  bool _1375_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1376_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out808;
                  bool _out809;
                  bool _out810;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out811;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out808, out _out809, out _out810, out _out811);
                  _1373_recursiveGen = _out808;
                  _1374_recOwned = _out809;
                  _1375_recErased = _out810;
                  _1376_recIdents = _out811;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1373_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1374_recOwned;
                  isErased = _1375_recErased;
                  readIdents = _1376_recIdents;
                }
              }
            } else if (_source30.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1377___mcc_h742 = _source30.dtor_args;
              DAST._IType _1378___mcc_h743 = _source30.dtor_result;
              DAST._IType _source52 = _561___mcc_h265;
              if (_source52.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1379___mcc_h750 = _source52.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1380___mcc_h751 = _source52.dtor_typeArgs;
                DAST._IResolvedType _1381___mcc_h752 = _source52.dtor_resolved;
                DAST._IResolvedType _source53 = _1381___mcc_h752;
                if (_source53.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1382___mcc_h756 = _source53.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1383_recursiveGen;
                    bool _1384_recOwned;
                    bool _1385_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1386_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out812;
                    bool _out813;
                    bool _out814;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out815;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out812, out _out813, out _out814, out _out815);
                    _1383_recursiveGen = _out812;
                    _1384_recOwned = _out813;
                    _1385_recErased = _out814;
                    _1386_recIdents = _out815;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1383_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1384_recOwned;
                    isErased = _1385_recErased;
                    readIdents = _1386_recIdents;
                  }
                } else if (_source53.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1387___mcc_h758 = _source53.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1388_recursiveGen;
                    bool _1389_recOwned;
                    bool _1390_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1391_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out816;
                    bool _out817;
                    bool _out818;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out819;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out816, out _out817, out _out818, out _out819);
                    _1388_recursiveGen = _out816;
                    _1389_recOwned = _out817;
                    _1390_recErased = _out818;
                    _1391_recIdents = _out819;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1388_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1389_recOwned;
                    isErased = _1390_recErased;
                    readIdents = _1391_recIdents;
                  }
                } else {
                  DAST._IType _1392___mcc_h760 = _source53.dtor_Newtype_a0;
                  DAST._IType _1393_b = _1392___mcc_h760;
                  {
                    if (object.Equals(_554_fromTpe, _1393_b)) {
                      Dafny.ISequence<Dafny.Rune> _1394_recursiveGen;
                      bool _1395_recOwned;
                      bool _1396_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1397_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out820;
                      bool _out821;
                      bool _out822;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out823;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out820, out _out821, out _out822, out _out823);
                      _1394_recursiveGen = _out820;
                      _1395_recOwned = _out821;
                      _1396_recErased = _out822;
                      _1397_recIdents = _out823;
                      Dafny.ISequence<Dafny.Rune> _1398_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out824;
                      _out824 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _1398_rhsType = _out824;
                      Dafny.ISequence<Dafny.Rune> _1399_uneraseFn;
                      _1399_uneraseFn = ((_1395_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1398_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1399_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1394_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1395_recOwned;
                      isErased = false;
                      readIdents = _1397_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out825;
                      bool _out826;
                      bool _out827;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out828;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1393_b), _1393_b, _553_toTpe), selfIdent, @params, mustOwn, out _out825, out _out826, out _out827, out _out828);
                      s = _out825;
                      isOwned = _out826;
                      isErased = _out827;
                      readIdents = _out828;
                    }
                  }
                }
              } else if (_source52.is_Nullable) {
                DAST._IType _1400___mcc_h762 = _source52.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1401_recursiveGen;
                  bool _1402_recOwned;
                  bool _1403_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1404_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out829;
                  bool _out830;
                  bool _out831;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out832;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out829, out _out830, out _out831, out _out832);
                  _1401_recursiveGen = _out829;
                  _1402_recOwned = _out830;
                  _1403_recErased = _out831;
                  _1404_recIdents = _out832;
                  if (!(_1402_recOwned)) {
                    _1401_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1401_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1401_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1403_recErased;
                  readIdents = _1404_recIdents;
                }
              } else if (_source52.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1405___mcc_h764 = _source52.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1406_recursiveGen;
                  bool _1407_recOwned;
                  bool _1408_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1409_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out833;
                  bool _out834;
                  bool _out835;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out836;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out833, out _out834, out _out835, out _out836);
                  _1406_recursiveGen = _out833;
                  _1407_recOwned = _out834;
                  _1408_recErased = _out835;
                  _1409_recIdents = _out836;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1406_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1407_recOwned;
                  isErased = _1408_recErased;
                  readIdents = _1409_recIdents;
                }
              } else if (_source52.is_Array) {
                DAST._IType _1410___mcc_h766 = _source52.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1411_recursiveGen;
                  bool _1412_recOwned;
                  bool _1413_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1414_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out837;
                  bool _out838;
                  bool _out839;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out840;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out837, out _out838, out _out839, out _out840);
                  _1411_recursiveGen = _out837;
                  _1412_recOwned = _out838;
                  _1413_recErased = _out839;
                  _1414_recIdents = _out840;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1411_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1412_recOwned;
                  isErased = _1413_recErased;
                  readIdents = _1414_recIdents;
                }
              } else if (_source52.is_Seq) {
                DAST._IType _1415___mcc_h768 = _source52.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1416_recursiveGen;
                  bool _1417_recOwned;
                  bool _1418_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1419_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out841;
                  bool _out842;
                  bool _out843;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out844;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out841, out _out842, out _out843, out _out844);
                  _1416_recursiveGen = _out841;
                  _1417_recOwned = _out842;
                  _1418_recErased = _out843;
                  _1419_recIdents = _out844;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1416_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1417_recOwned;
                  isErased = _1418_recErased;
                  readIdents = _1419_recIdents;
                }
              } else if (_source52.is_Set) {
                DAST._IType _1420___mcc_h770 = _source52.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1421_recursiveGen;
                  bool _1422_recOwned;
                  bool _1423_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1424_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out845;
                  bool _out846;
                  bool _out847;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out848;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out845, out _out846, out _out847, out _out848);
                  _1421_recursiveGen = _out845;
                  _1422_recOwned = _out846;
                  _1423_recErased = _out847;
                  _1424_recIdents = _out848;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1421_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1422_recOwned;
                  isErased = _1423_recErased;
                  readIdents = _1424_recIdents;
                }
              } else if (_source52.is_Multiset) {
                DAST._IType _1425___mcc_h772 = _source52.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1426_recursiveGen;
                  bool _1427_recOwned;
                  bool _1428_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1429_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out849;
                  bool _out850;
                  bool _out851;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out852;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out849, out _out850, out _out851, out _out852);
                  _1426_recursiveGen = _out849;
                  _1427_recOwned = _out850;
                  _1428_recErased = _out851;
                  _1429_recIdents = _out852;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1426_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1427_recOwned;
                  isErased = _1428_recErased;
                  readIdents = _1429_recIdents;
                }
              } else if (_source52.is_Map) {
                DAST._IType _1430___mcc_h774 = _source52.dtor_key;
                DAST._IType _1431___mcc_h775 = _source52.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1432_recursiveGen;
                  bool _1433_recOwned;
                  bool _1434_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1435_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out853;
                  bool _out854;
                  bool _out855;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out856;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out853, out _out854, out _out855, out _out856);
                  _1432_recursiveGen = _out853;
                  _1433_recOwned = _out854;
                  _1434_recErased = _out855;
                  _1435_recIdents = _out856;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1432_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1433_recOwned;
                  isErased = _1434_recErased;
                  readIdents = _1435_recIdents;
                }
              } else if (_source52.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1436___mcc_h778 = _source52.dtor_args;
                DAST._IType _1437___mcc_h779 = _source52.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1438_recursiveGen;
                  bool _1439_recOwned;
                  bool _1440_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1441_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out857;
                  bool _out858;
                  bool _out859;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out860;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out857, out _out858, out _out859, out _out860);
                  _1438_recursiveGen = _out857;
                  _1439_recOwned = _out858;
                  _1440_recErased = _out859;
                  _1441_recIdents = _out860;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1438_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1439_recOwned;
                  isErased = _1440_recErased;
                  readIdents = _1441_recIdents;
                }
              } else if (_source52.is_Primitive) {
                DAST._IPrimitive _1442___mcc_h782 = _source52.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1443_recursiveGen;
                  bool _1444_recOwned;
                  bool _1445_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1446_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out861;
                  bool _out862;
                  bool _out863;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out864;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out861, out _out862, out _out863, out _out864);
                  _1443_recursiveGen = _out861;
                  _1444_recOwned = _out862;
                  _1445_recErased = _out863;
                  _1446_recIdents = _out864;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1443_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1444_recOwned;
                  isErased = _1445_recErased;
                  readIdents = _1446_recIdents;
                }
              } else if (_source52.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1447___mcc_h784 = _source52.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1448_recursiveGen;
                  bool _1449_recOwned;
                  bool _1450_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1451_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out865;
                  bool _out866;
                  bool _out867;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out868;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out865, out _out866, out _out867, out _out868);
                  _1448_recursiveGen = _out865;
                  _1449_recOwned = _out866;
                  _1450_recErased = _out867;
                  _1451_recIdents = _out868;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1448_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1449_recOwned;
                  isErased = _1450_recErased;
                  readIdents = _1451_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1452___mcc_h786 = _source52.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1453_recursiveGen;
                  bool _1454_recOwned;
                  bool _1455_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1456_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out869;
                  bool _out870;
                  bool _out871;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out872;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out869, out _out870, out _out871, out _out872);
                  _1453_recursiveGen = _out869;
                  _1454_recOwned = _out870;
                  _1455_recErased = _out871;
                  _1456_recIdents = _out872;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1453_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1454_recOwned;
                  isErased = _1455_recErased;
                  readIdents = _1456_recIdents;
                }
              }
            } else if (_source30.is_Primitive) {
              DAST._IPrimitive _1457___mcc_h788 = _source30.dtor_Primitive_a0;
              DAST._IPrimitive _source54 = _1457___mcc_h788;
              if (_source54.is_Int) {
                DAST._IType _source55 = _561___mcc_h265;
                if (_source55.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1458___mcc_h792 = _source55.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1459___mcc_h793 = _source55.dtor_typeArgs;
                  DAST._IResolvedType _1460___mcc_h794 = _source55.dtor_resolved;
                  DAST._IResolvedType _source56 = _1460___mcc_h794;
                  if (_source56.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1461___mcc_h798 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1462_recursiveGen;
                      bool _1463_recOwned;
                      bool _1464_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1465_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out873;
                      bool _out874;
                      bool _out875;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out876;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out873, out _out874, out _out875, out _out876);
                      _1462_recursiveGen = _out873;
                      _1463_recOwned = _out874;
                      _1464_recErased = _out875;
                      _1465_recIdents = _out876;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1462_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1463_recOwned;
                      isErased = _1464_recErased;
                      readIdents = _1465_recIdents;
                    }
                  } else if (_source56.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1466___mcc_h800 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1467_recursiveGen;
                      bool _1468_recOwned;
                      bool _1469_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1470_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out877;
                      bool _out878;
                      bool _out879;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out880;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out877, out _out878, out _out879, out _out880);
                      _1467_recursiveGen = _out877;
                      _1468_recOwned = _out878;
                      _1469_recErased = _out879;
                      _1470_recIdents = _out880;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1467_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1468_recOwned;
                      isErased = _1469_recErased;
                      readIdents = _1470_recIdents;
                    }
                  } else {
                    DAST._IType _1471___mcc_h802 = _source56.dtor_Newtype_a0;
                    DAST._IType _1472_b = _1471___mcc_h802;
                    {
                      if (object.Equals(_554_fromTpe, _1472_b)) {
                        Dafny.ISequence<Dafny.Rune> _1473_recursiveGen;
                        bool _1474_recOwned;
                        bool _1475_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1476_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out881;
                        bool _out882;
                        bool _out883;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out884;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out881, out _out882, out _out883, out _out884);
                        _1473_recursiveGen = _out881;
                        _1474_recOwned = _out882;
                        _1475_recErased = _out883;
                        _1476_recIdents = _out884;
                        Dafny.ISequence<Dafny.Rune> _1477_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out885;
                        _out885 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                        _1477_rhsType = _out885;
                        Dafny.ISequence<Dafny.Rune> _1478_uneraseFn;
                        _1478_uneraseFn = ((_1474_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1477_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1478_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1474_recOwned;
                        isErased = false;
                        readIdents = _1476_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out886;
                        bool _out887;
                        bool _out888;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out889;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1472_b), _1472_b, _553_toTpe), selfIdent, @params, mustOwn, out _out886, out _out887, out _out888, out _out889);
                        s = _out886;
                        isOwned = _out887;
                        isErased = _out888;
                        readIdents = _out889;
                      }
                    }
                  }
                } else if (_source55.is_Nullable) {
                  DAST._IType _1479___mcc_h804 = _source55.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1480_recursiveGen;
                    bool _1481_recOwned;
                    bool _1482_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1483_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out890;
                    bool _out891;
                    bool _out892;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out893;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out890, out _out891, out _out892, out _out893);
                    _1480_recursiveGen = _out890;
                    _1481_recOwned = _out891;
                    _1482_recErased = _out892;
                    _1483_recIdents = _out893;
                    if (!(_1481_recOwned)) {
                      _1480_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1480_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1480_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1482_recErased;
                    readIdents = _1483_recIdents;
                  }
                } else if (_source55.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1484___mcc_h806 = _source55.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1485_recursiveGen;
                    bool _1486_recOwned;
                    bool _1487_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1488_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out894;
                    bool _out895;
                    bool _out896;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out897;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out894, out _out895, out _out896, out _out897);
                    _1485_recursiveGen = _out894;
                    _1486_recOwned = _out895;
                    _1487_recErased = _out896;
                    _1488_recIdents = _out897;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1485_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1486_recOwned;
                    isErased = _1487_recErased;
                    readIdents = _1488_recIdents;
                  }
                } else if (_source55.is_Array) {
                  DAST._IType _1489___mcc_h808 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1490_recursiveGen;
                    bool _1491_recOwned;
                    bool _1492_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1493_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out898;
                    bool _out899;
                    bool _out900;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out901;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out898, out _out899, out _out900, out _out901);
                    _1490_recursiveGen = _out898;
                    _1491_recOwned = _out899;
                    _1492_recErased = _out900;
                    _1493_recIdents = _out901;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1490_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1491_recOwned;
                    isErased = _1492_recErased;
                    readIdents = _1493_recIdents;
                  }
                } else if (_source55.is_Seq) {
                  DAST._IType _1494___mcc_h810 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1495_recursiveGen;
                    bool _1496_recOwned;
                    bool _1497_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1498_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out902;
                    bool _out903;
                    bool _out904;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out905;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out902, out _out903, out _out904, out _out905);
                    _1495_recursiveGen = _out902;
                    _1496_recOwned = _out903;
                    _1497_recErased = _out904;
                    _1498_recIdents = _out905;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1495_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1496_recOwned;
                    isErased = _1497_recErased;
                    readIdents = _1498_recIdents;
                  }
                } else if (_source55.is_Set) {
                  DAST._IType _1499___mcc_h812 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1500_recursiveGen;
                    bool _1501_recOwned;
                    bool _1502_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1503_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out906;
                    bool _out907;
                    bool _out908;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out909;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out906, out _out907, out _out908, out _out909);
                    _1500_recursiveGen = _out906;
                    _1501_recOwned = _out907;
                    _1502_recErased = _out908;
                    _1503_recIdents = _out909;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1500_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1501_recOwned;
                    isErased = _1502_recErased;
                    readIdents = _1503_recIdents;
                  }
                } else if (_source55.is_Multiset) {
                  DAST._IType _1504___mcc_h814 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1505_recursiveGen;
                    bool _1506_recOwned;
                    bool _1507_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1508_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out910;
                    bool _out911;
                    bool _out912;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out913;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out910, out _out911, out _out912, out _out913);
                    _1505_recursiveGen = _out910;
                    _1506_recOwned = _out911;
                    _1507_recErased = _out912;
                    _1508_recIdents = _out913;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1505_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1506_recOwned;
                    isErased = _1507_recErased;
                    readIdents = _1508_recIdents;
                  }
                } else if (_source55.is_Map) {
                  DAST._IType _1509___mcc_h816 = _source55.dtor_key;
                  DAST._IType _1510___mcc_h817 = _source55.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1511_recursiveGen;
                    bool _1512_recOwned;
                    bool _1513_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1514_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out914;
                    bool _out915;
                    bool _out916;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out917;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out914, out _out915, out _out916, out _out917);
                    _1511_recursiveGen = _out914;
                    _1512_recOwned = _out915;
                    _1513_recErased = _out916;
                    _1514_recIdents = _out917;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1511_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1512_recOwned;
                    isErased = _1513_recErased;
                    readIdents = _1514_recIdents;
                  }
                } else if (_source55.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1515___mcc_h820 = _source55.dtor_args;
                  DAST._IType _1516___mcc_h821 = _source55.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1517_recursiveGen;
                    bool _1518_recOwned;
                    bool _1519_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1520_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out918;
                    bool _out919;
                    bool _out920;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out921;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out918, out _out919, out _out920, out _out921);
                    _1517_recursiveGen = _out918;
                    _1518_recOwned = _out919;
                    _1519_recErased = _out920;
                    _1520_recIdents = _out921;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1517_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1518_recOwned;
                    isErased = _1519_recErased;
                    readIdents = _1520_recIdents;
                  }
                } else if (_source55.is_Primitive) {
                  DAST._IPrimitive _1521___mcc_h824 = _source55.dtor_Primitive_a0;
                  DAST._IPrimitive _source57 = _1521___mcc_h824;
                  if (_source57.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1522_recursiveGen;
                      bool _1523_recOwned;
                      bool _1524_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1525_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out922;
                      bool _out923;
                      bool _out924;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out925;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out922, out _out923, out _out924, out _out925);
                      _1522_recursiveGen = _out922;
                      _1523_recOwned = _out923;
                      _1524_recErased = _out924;
                      _1525_recIdents = _out925;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1522_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1523_recOwned;
                      isErased = _1524_recErased;
                      readIdents = _1525_recIdents;
                    }
                  } else if (_source57.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1526_recursiveGen;
                      bool _1527___v48;
                      bool _1528___v49;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1529_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out926;
                      bool _out927;
                      bool _out928;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out929;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, true, out _out926, out _out927, out _out928, out _out929);
                      _1526_recursiveGen = _out926;
                      _1527___v48 = _out927;
                      _1528___v49 = _out928;
                      _1529_recIdents = _out929;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1526_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1529_recIdents;
                    }
                  } else if (_source57.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1530_recursiveGen;
                      bool _1531_recOwned;
                      bool _1532_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1533_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out930;
                      bool _out931;
                      bool _out932;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out933;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out930, out _out931, out _out932, out _out933);
                      _1530_recursiveGen = _out930;
                      _1531_recOwned = _out931;
                      _1532_recErased = _out932;
                      _1533_recIdents = _out933;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1530_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1531_recOwned;
                      isErased = _1532_recErased;
                      readIdents = _1533_recIdents;
                    }
                  } else if (_source57.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1534_recursiveGen;
                      bool _1535_recOwned;
                      bool _1536_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1537_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out934;
                      bool _out935;
                      bool _out936;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out937;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out934, out _out935, out _out936, out _out937);
                      _1534_recursiveGen = _out934;
                      _1535_recOwned = _out935;
                      _1536_recErased = _out936;
                      _1537_recIdents = _out937;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1535_recOwned;
                      isErased = _1536_recErased;
                      readIdents = _1537_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1538_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out938;
                      _out938 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _1538_rhsType = _out938;
                      Dafny.ISequence<Dafny.Rune> _1539_recursiveGen;
                      bool _1540___v58;
                      bool _1541___v59;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1542_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out939;
                      bool _out940;
                      bool _out941;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out942;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, true, out _out939, out _out940, out _out941, out _out942);
                      _1539_recursiveGen = _out939;
                      _1540___v58 = _out940;
                      _1541___v59 = _out941;
                      _1542_recIdents = _out942;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1539_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1542_recIdents;
                    }
                  }
                } else if (_source55.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1543___mcc_h826 = _source55.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1544_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out943;
                    _out943 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                    _1544_rhsType = _out943;
                    Dafny.ISequence<Dafny.Rune> _1545_recursiveGen;
                    bool _1546___v53;
                    bool _1547___v54;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1548_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out944;
                    bool _out945;
                    bool _out946;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out947;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, true, out _out944, out _out945, out _out946, out _out947);
                    _1545_recursiveGen = _out944;
                    _1546___v53 = _out945;
                    _1547___v54 = _out946;
                    _1548_recIdents = _out947;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1544_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1545_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1548_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1549___mcc_h828 = _source55.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1550_recursiveGen;
                    bool _1551_recOwned;
                    bool _1552_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1553_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out948;
                    bool _out949;
                    bool _out950;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out951;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out948, out _out949, out _out950, out _out951);
                    _1550_recursiveGen = _out948;
                    _1551_recOwned = _out949;
                    _1552_recErased = _out950;
                    _1553_recIdents = _out951;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1550_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1551_recOwned;
                    isErased = _1552_recErased;
                    readIdents = _1553_recIdents;
                  }
                }
              } else if (_source54.is_Real) {
                DAST._IType _source58 = _561___mcc_h265;
                if (_source58.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1554___mcc_h830 = _source58.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1555___mcc_h831 = _source58.dtor_typeArgs;
                  DAST._IResolvedType _1556___mcc_h832 = _source58.dtor_resolved;
                  DAST._IResolvedType _source59 = _1556___mcc_h832;
                  if (_source59.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1557___mcc_h836 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1558_recursiveGen;
                      bool _1559_recOwned;
                      bool _1560_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1561_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out952;
                      bool _out953;
                      bool _out954;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out955;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out952, out _out953, out _out954, out _out955);
                      _1558_recursiveGen = _out952;
                      _1559_recOwned = _out953;
                      _1560_recErased = _out954;
                      _1561_recIdents = _out955;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1558_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1559_recOwned;
                      isErased = _1560_recErased;
                      readIdents = _1561_recIdents;
                    }
                  } else if (_source59.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1562___mcc_h838 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1563_recursiveGen;
                      bool _1564_recOwned;
                      bool _1565_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1566_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out956;
                      bool _out957;
                      bool _out958;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out959;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out956, out _out957, out _out958, out _out959);
                      _1563_recursiveGen = _out956;
                      _1564_recOwned = _out957;
                      _1565_recErased = _out958;
                      _1566_recIdents = _out959;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1563_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1564_recOwned;
                      isErased = _1565_recErased;
                      readIdents = _1566_recIdents;
                    }
                  } else {
                    DAST._IType _1567___mcc_h840 = _source59.dtor_Newtype_a0;
                    DAST._IType _1568_b = _1567___mcc_h840;
                    {
                      if (object.Equals(_554_fromTpe, _1568_b)) {
                        Dafny.ISequence<Dafny.Rune> _1569_recursiveGen;
                        bool _1570_recOwned;
                        bool _1571_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1572_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out960;
                        bool _out961;
                        bool _out962;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out963;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out960, out _out961, out _out962, out _out963);
                        _1569_recursiveGen = _out960;
                        _1570_recOwned = _out961;
                        _1571_recErased = _out962;
                        _1572_recIdents = _out963;
                        Dafny.ISequence<Dafny.Rune> _1573_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out964;
                        _out964 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                        _1573_rhsType = _out964;
                        Dafny.ISequence<Dafny.Rune> _1574_uneraseFn;
                        _1574_uneraseFn = ((_1570_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1573_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1574_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1569_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1570_recOwned;
                        isErased = false;
                        readIdents = _1572_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out965;
                        bool _out966;
                        bool _out967;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out968;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1568_b), _1568_b, _553_toTpe), selfIdent, @params, mustOwn, out _out965, out _out966, out _out967, out _out968);
                        s = _out965;
                        isOwned = _out966;
                        isErased = _out967;
                        readIdents = _out968;
                      }
                    }
                  }
                } else if (_source58.is_Nullable) {
                  DAST._IType _1575___mcc_h842 = _source58.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1576_recursiveGen;
                    bool _1577_recOwned;
                    bool _1578_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1579_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out969;
                    bool _out970;
                    bool _out971;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out972;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out969, out _out970, out _out971, out _out972);
                    _1576_recursiveGen = _out969;
                    _1577_recOwned = _out970;
                    _1578_recErased = _out971;
                    _1579_recIdents = _out972;
                    if (!(_1577_recOwned)) {
                      _1576_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1576_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1576_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1578_recErased;
                    readIdents = _1579_recIdents;
                  }
                } else if (_source58.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1580___mcc_h844 = _source58.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1581_recursiveGen;
                    bool _1582_recOwned;
                    bool _1583_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1584_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out973;
                    bool _out974;
                    bool _out975;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out976;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out973, out _out974, out _out975, out _out976);
                    _1581_recursiveGen = _out973;
                    _1582_recOwned = _out974;
                    _1583_recErased = _out975;
                    _1584_recIdents = _out976;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1581_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1582_recOwned;
                    isErased = _1583_recErased;
                    readIdents = _1584_recIdents;
                  }
                } else if (_source58.is_Array) {
                  DAST._IType _1585___mcc_h846 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1586_recursiveGen;
                    bool _1587_recOwned;
                    bool _1588_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1589_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out977;
                    bool _out978;
                    bool _out979;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out980;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out977, out _out978, out _out979, out _out980);
                    _1586_recursiveGen = _out977;
                    _1587_recOwned = _out978;
                    _1588_recErased = _out979;
                    _1589_recIdents = _out980;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1586_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1587_recOwned;
                    isErased = _1588_recErased;
                    readIdents = _1589_recIdents;
                  }
                } else if (_source58.is_Seq) {
                  DAST._IType _1590___mcc_h848 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1591_recursiveGen;
                    bool _1592_recOwned;
                    bool _1593_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1594_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out981;
                    bool _out982;
                    bool _out983;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out984;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out981, out _out982, out _out983, out _out984);
                    _1591_recursiveGen = _out981;
                    _1592_recOwned = _out982;
                    _1593_recErased = _out983;
                    _1594_recIdents = _out984;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1591_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1592_recOwned;
                    isErased = _1593_recErased;
                    readIdents = _1594_recIdents;
                  }
                } else if (_source58.is_Set) {
                  DAST._IType _1595___mcc_h850 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1596_recursiveGen;
                    bool _1597_recOwned;
                    bool _1598_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1599_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out985;
                    bool _out986;
                    bool _out987;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out988;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out985, out _out986, out _out987, out _out988);
                    _1596_recursiveGen = _out985;
                    _1597_recOwned = _out986;
                    _1598_recErased = _out987;
                    _1599_recIdents = _out988;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1596_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1597_recOwned;
                    isErased = _1598_recErased;
                    readIdents = _1599_recIdents;
                  }
                } else if (_source58.is_Multiset) {
                  DAST._IType _1600___mcc_h852 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1601_recursiveGen;
                    bool _1602_recOwned;
                    bool _1603_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1604_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out989;
                    bool _out990;
                    bool _out991;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out992;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out989, out _out990, out _out991, out _out992);
                    _1601_recursiveGen = _out989;
                    _1602_recOwned = _out990;
                    _1603_recErased = _out991;
                    _1604_recIdents = _out992;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1601_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1602_recOwned;
                    isErased = _1603_recErased;
                    readIdents = _1604_recIdents;
                  }
                } else if (_source58.is_Map) {
                  DAST._IType _1605___mcc_h854 = _source58.dtor_key;
                  DAST._IType _1606___mcc_h855 = _source58.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1607_recursiveGen;
                    bool _1608_recOwned;
                    bool _1609_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1610_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out993;
                    bool _out994;
                    bool _out995;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out996;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out993, out _out994, out _out995, out _out996);
                    _1607_recursiveGen = _out993;
                    _1608_recOwned = _out994;
                    _1609_recErased = _out995;
                    _1610_recIdents = _out996;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1607_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1608_recOwned;
                    isErased = _1609_recErased;
                    readIdents = _1610_recIdents;
                  }
                } else if (_source58.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1611___mcc_h858 = _source58.dtor_args;
                  DAST._IType _1612___mcc_h859 = _source58.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1613_recursiveGen;
                    bool _1614_recOwned;
                    bool _1615_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1616_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out997;
                    bool _out998;
                    bool _out999;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1000;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out997, out _out998, out _out999, out _out1000);
                    _1613_recursiveGen = _out997;
                    _1614_recOwned = _out998;
                    _1615_recErased = _out999;
                    _1616_recIdents = _out1000;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1614_recOwned;
                    isErased = _1615_recErased;
                    readIdents = _1616_recIdents;
                  }
                } else if (_source58.is_Primitive) {
                  DAST._IPrimitive _1617___mcc_h862 = _source58.dtor_Primitive_a0;
                  DAST._IPrimitive _source60 = _1617___mcc_h862;
                  if (_source60.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1618_recursiveGen;
                      bool _1619___v50;
                      bool _1620___v51;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1621_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1001;
                      bool _out1002;
                      bool _out1003;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1004;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, false, out _out1001, out _out1002, out _out1003, out _out1004);
                      _1618_recursiveGen = _out1001;
                      _1619___v50 = _out1002;
                      _1620___v51 = _out1003;
                      _1621_recIdents = _out1004;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1618_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1621_recIdents;
                    }
                  } else if (_source60.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1622_recursiveGen;
                      bool _1623_recOwned;
                      bool _1624_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1625_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1005;
                      bool _out1006;
                      bool _out1007;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1008;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1005, out _out1006, out _out1007, out _out1008);
                      _1622_recursiveGen = _out1005;
                      _1623_recOwned = _out1006;
                      _1624_recErased = _out1007;
                      _1625_recIdents = _out1008;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1622_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1623_recOwned;
                      isErased = _1624_recErased;
                      readIdents = _1625_recIdents;
                    }
                  } else if (_source60.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1626_recursiveGen;
                      bool _1627_recOwned;
                      bool _1628_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1629_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1009;
                      bool _out1010;
                      bool _out1011;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1012;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1009, out _out1010, out _out1011, out _out1012);
                      _1626_recursiveGen = _out1009;
                      _1627_recOwned = _out1010;
                      _1628_recErased = _out1011;
                      _1629_recIdents = _out1012;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1626_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1627_recOwned;
                      isErased = _1628_recErased;
                      readIdents = _1629_recIdents;
                    }
                  } else if (_source60.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1630_recursiveGen;
                      bool _1631_recOwned;
                      bool _1632_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1633_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1013;
                      bool _out1014;
                      bool _out1015;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1016;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1013, out _out1014, out _out1015, out _out1016);
                      _1630_recursiveGen = _out1013;
                      _1631_recOwned = _out1014;
                      _1632_recErased = _out1015;
                      _1633_recIdents = _out1016;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1630_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1631_recOwned;
                      isErased = _1632_recErased;
                      readIdents = _1633_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1634_recursiveGen;
                      bool _1635_recOwned;
                      bool _1636_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1637_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1017;
                      bool _out1018;
                      bool _out1019;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1020;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1017, out _out1018, out _out1019, out _out1020);
                      _1634_recursiveGen = _out1017;
                      _1635_recOwned = _out1018;
                      _1636_recErased = _out1019;
                      _1637_recIdents = _out1020;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1634_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1635_recOwned;
                      isErased = _1636_recErased;
                      readIdents = _1637_recIdents;
                    }
                  }
                } else if (_source58.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1638___mcc_h864 = _source58.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1639_recursiveGen;
                    bool _1640_recOwned;
                    bool _1641_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1642_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1021;
                    bool _out1022;
                    bool _out1023;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1024;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1021, out _out1022, out _out1023, out _out1024);
                    _1639_recursiveGen = _out1021;
                    _1640_recOwned = _out1022;
                    _1641_recErased = _out1023;
                    _1642_recIdents = _out1024;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1639_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1640_recOwned;
                    isErased = _1641_recErased;
                    readIdents = _1642_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1643___mcc_h866 = _source58.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1644_recursiveGen;
                    bool _1645_recOwned;
                    bool _1646_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1647_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1025;
                    bool _out1026;
                    bool _out1027;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1028;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1025, out _out1026, out _out1027, out _out1028);
                    _1644_recursiveGen = _out1025;
                    _1645_recOwned = _out1026;
                    _1646_recErased = _out1027;
                    _1647_recIdents = _out1028;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1644_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1645_recOwned;
                    isErased = _1646_recErased;
                    readIdents = _1647_recIdents;
                  }
                }
              } else if (_source54.is_String) {
                DAST._IType _source61 = _561___mcc_h265;
                if (_source61.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1648___mcc_h868 = _source61.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1649___mcc_h869 = _source61.dtor_typeArgs;
                  DAST._IResolvedType _1650___mcc_h870 = _source61.dtor_resolved;
                  DAST._IResolvedType _source62 = _1650___mcc_h870;
                  if (_source62.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1651___mcc_h874 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1652_recursiveGen;
                      bool _1653_recOwned;
                      bool _1654_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1655_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1029;
                      bool _out1030;
                      bool _out1031;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1032;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1029, out _out1030, out _out1031, out _out1032);
                      _1652_recursiveGen = _out1029;
                      _1653_recOwned = _out1030;
                      _1654_recErased = _out1031;
                      _1655_recIdents = _out1032;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1652_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1653_recOwned;
                      isErased = _1654_recErased;
                      readIdents = _1655_recIdents;
                    }
                  } else if (_source62.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1656___mcc_h876 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1657_recursiveGen;
                      bool _1658_recOwned;
                      bool _1659_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1660_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1033;
                      bool _out1034;
                      bool _out1035;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1036;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1033, out _out1034, out _out1035, out _out1036);
                      _1657_recursiveGen = _out1033;
                      _1658_recOwned = _out1034;
                      _1659_recErased = _out1035;
                      _1660_recIdents = _out1036;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1657_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1658_recOwned;
                      isErased = _1659_recErased;
                      readIdents = _1660_recIdents;
                    }
                  } else {
                    DAST._IType _1661___mcc_h878 = _source62.dtor_Newtype_a0;
                    DAST._IType _1662_b = _1661___mcc_h878;
                    {
                      if (object.Equals(_554_fromTpe, _1662_b)) {
                        Dafny.ISequence<Dafny.Rune> _1663_recursiveGen;
                        bool _1664_recOwned;
                        bool _1665_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1666_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1037;
                        bool _out1038;
                        bool _out1039;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1040;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1037, out _out1038, out _out1039, out _out1040);
                        _1663_recursiveGen = _out1037;
                        _1664_recOwned = _out1038;
                        _1665_recErased = _out1039;
                        _1666_recIdents = _out1040;
                        Dafny.ISequence<Dafny.Rune> _1667_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1041;
                        _out1041 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                        _1667_rhsType = _out1041;
                        Dafny.ISequence<Dafny.Rune> _1668_uneraseFn;
                        _1668_uneraseFn = ((_1664_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1667_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1668_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1663_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1664_recOwned;
                        isErased = false;
                        readIdents = _1666_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1042;
                        bool _out1043;
                        bool _out1044;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1045;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1662_b), _1662_b, _553_toTpe), selfIdent, @params, mustOwn, out _out1042, out _out1043, out _out1044, out _out1045);
                        s = _out1042;
                        isOwned = _out1043;
                        isErased = _out1044;
                        readIdents = _out1045;
                      }
                    }
                  }
                } else if (_source61.is_Nullable) {
                  DAST._IType _1669___mcc_h880 = _source61.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1670_recursiveGen;
                    bool _1671_recOwned;
                    bool _1672_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1673_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1046;
                    bool _out1047;
                    bool _out1048;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1049;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1046, out _out1047, out _out1048, out _out1049);
                    _1670_recursiveGen = _out1046;
                    _1671_recOwned = _out1047;
                    _1672_recErased = _out1048;
                    _1673_recIdents = _out1049;
                    if (!(_1671_recOwned)) {
                      _1670_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1670_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1670_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1672_recErased;
                    readIdents = _1673_recIdents;
                  }
                } else if (_source61.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1674___mcc_h882 = _source61.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1675_recursiveGen;
                    bool _1676_recOwned;
                    bool _1677_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1678_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1050;
                    bool _out1051;
                    bool _out1052;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1053;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1050, out _out1051, out _out1052, out _out1053);
                    _1675_recursiveGen = _out1050;
                    _1676_recOwned = _out1051;
                    _1677_recErased = _out1052;
                    _1678_recIdents = _out1053;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1675_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1676_recOwned;
                    isErased = _1677_recErased;
                    readIdents = _1678_recIdents;
                  }
                } else if (_source61.is_Array) {
                  DAST._IType _1679___mcc_h884 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1680_recursiveGen;
                    bool _1681_recOwned;
                    bool _1682_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1683_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1054;
                    bool _out1055;
                    bool _out1056;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1057;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1054, out _out1055, out _out1056, out _out1057);
                    _1680_recursiveGen = _out1054;
                    _1681_recOwned = _out1055;
                    _1682_recErased = _out1056;
                    _1683_recIdents = _out1057;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1680_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1681_recOwned;
                    isErased = _1682_recErased;
                    readIdents = _1683_recIdents;
                  }
                } else if (_source61.is_Seq) {
                  DAST._IType _1684___mcc_h886 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1685_recursiveGen;
                    bool _1686_recOwned;
                    bool _1687_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1688_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1058;
                    bool _out1059;
                    bool _out1060;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1061;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1058, out _out1059, out _out1060, out _out1061);
                    _1685_recursiveGen = _out1058;
                    _1686_recOwned = _out1059;
                    _1687_recErased = _out1060;
                    _1688_recIdents = _out1061;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1685_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1686_recOwned;
                    isErased = _1687_recErased;
                    readIdents = _1688_recIdents;
                  }
                } else if (_source61.is_Set) {
                  DAST._IType _1689___mcc_h888 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1690_recursiveGen;
                    bool _1691_recOwned;
                    bool _1692_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1693_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1062;
                    bool _out1063;
                    bool _out1064;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1065;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1062, out _out1063, out _out1064, out _out1065);
                    _1690_recursiveGen = _out1062;
                    _1691_recOwned = _out1063;
                    _1692_recErased = _out1064;
                    _1693_recIdents = _out1065;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1690_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1691_recOwned;
                    isErased = _1692_recErased;
                    readIdents = _1693_recIdents;
                  }
                } else if (_source61.is_Multiset) {
                  DAST._IType _1694___mcc_h890 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1695_recursiveGen;
                    bool _1696_recOwned;
                    bool _1697_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1698_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1066;
                    bool _out1067;
                    bool _out1068;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1069;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1066, out _out1067, out _out1068, out _out1069);
                    _1695_recursiveGen = _out1066;
                    _1696_recOwned = _out1067;
                    _1697_recErased = _out1068;
                    _1698_recIdents = _out1069;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1695_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1696_recOwned;
                    isErased = _1697_recErased;
                    readIdents = _1698_recIdents;
                  }
                } else if (_source61.is_Map) {
                  DAST._IType _1699___mcc_h892 = _source61.dtor_key;
                  DAST._IType _1700___mcc_h893 = _source61.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1701_recursiveGen;
                    bool _1702_recOwned;
                    bool _1703_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1704_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1070;
                    bool _out1071;
                    bool _out1072;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1073;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1070, out _out1071, out _out1072, out _out1073);
                    _1701_recursiveGen = _out1070;
                    _1702_recOwned = _out1071;
                    _1703_recErased = _out1072;
                    _1704_recIdents = _out1073;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1701_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1702_recOwned;
                    isErased = _1703_recErased;
                    readIdents = _1704_recIdents;
                  }
                } else if (_source61.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1705___mcc_h896 = _source61.dtor_args;
                  DAST._IType _1706___mcc_h897 = _source61.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1707_recursiveGen;
                    bool _1708_recOwned;
                    bool _1709_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1710_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1074;
                    bool _out1075;
                    bool _out1076;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1077;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1074, out _out1075, out _out1076, out _out1077);
                    _1707_recursiveGen = _out1074;
                    _1708_recOwned = _out1075;
                    _1709_recErased = _out1076;
                    _1710_recIdents = _out1077;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1707_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1708_recOwned;
                    isErased = _1709_recErased;
                    readIdents = _1710_recIdents;
                  }
                } else if (_source61.is_Primitive) {
                  DAST._IPrimitive _1711___mcc_h900 = _source61.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1712_recursiveGen;
                    bool _1713_recOwned;
                    bool _1714_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1715_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1078;
                    bool _out1079;
                    bool _out1080;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1081;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1078, out _out1079, out _out1080, out _out1081);
                    _1712_recursiveGen = _out1078;
                    _1713_recOwned = _out1079;
                    _1714_recErased = _out1080;
                    _1715_recIdents = _out1081;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1712_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1713_recOwned;
                    isErased = _1714_recErased;
                    readIdents = _1715_recIdents;
                  }
                } else if (_source61.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1716___mcc_h902 = _source61.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1717_recursiveGen;
                    bool _1718_recOwned;
                    bool _1719_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1720_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1082;
                    bool _out1083;
                    bool _out1084;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1085;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1082, out _out1083, out _out1084, out _out1085);
                    _1717_recursiveGen = _out1082;
                    _1718_recOwned = _out1083;
                    _1719_recErased = _out1084;
                    _1720_recIdents = _out1085;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1717_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1718_recOwned;
                    isErased = _1719_recErased;
                    readIdents = _1720_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1721___mcc_h904 = _source61.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1722_recursiveGen;
                    bool _1723_recOwned;
                    bool _1724_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1725_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1086;
                    bool _out1087;
                    bool _out1088;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1089;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1086, out _out1087, out _out1088, out _out1089);
                    _1722_recursiveGen = _out1086;
                    _1723_recOwned = _out1087;
                    _1724_recErased = _out1088;
                    _1725_recIdents = _out1089;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1722_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1723_recOwned;
                    isErased = _1724_recErased;
                    readIdents = _1725_recIdents;
                  }
                }
              } else if (_source54.is_Bool) {
                DAST._IType _source63 = _561___mcc_h265;
                if (_source63.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1726___mcc_h906 = _source63.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1727___mcc_h907 = _source63.dtor_typeArgs;
                  DAST._IResolvedType _1728___mcc_h908 = _source63.dtor_resolved;
                  DAST._IResolvedType _source64 = _1728___mcc_h908;
                  if (_source64.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1729___mcc_h912 = _source64.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1730_recursiveGen;
                      bool _1731_recOwned;
                      bool _1732_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1733_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1090;
                      bool _out1091;
                      bool _out1092;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1093;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1090, out _out1091, out _out1092, out _out1093);
                      _1730_recursiveGen = _out1090;
                      _1731_recOwned = _out1091;
                      _1732_recErased = _out1092;
                      _1733_recIdents = _out1093;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1730_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1731_recOwned;
                      isErased = _1732_recErased;
                      readIdents = _1733_recIdents;
                    }
                  } else if (_source64.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1734___mcc_h914 = _source64.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1735_recursiveGen;
                      bool _1736_recOwned;
                      bool _1737_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1738_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1094;
                      bool _out1095;
                      bool _out1096;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1097;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1094, out _out1095, out _out1096, out _out1097);
                      _1735_recursiveGen = _out1094;
                      _1736_recOwned = _out1095;
                      _1737_recErased = _out1096;
                      _1738_recIdents = _out1097;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1735_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1736_recOwned;
                      isErased = _1737_recErased;
                      readIdents = _1738_recIdents;
                    }
                  } else {
                    DAST._IType _1739___mcc_h916 = _source64.dtor_Newtype_a0;
                    DAST._IType _1740_b = _1739___mcc_h916;
                    {
                      if (object.Equals(_554_fromTpe, _1740_b)) {
                        Dafny.ISequence<Dafny.Rune> _1741_recursiveGen;
                        bool _1742_recOwned;
                        bool _1743_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1744_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1098;
                        bool _out1099;
                        bool _out1100;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1101;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1098, out _out1099, out _out1100, out _out1101);
                        _1741_recursiveGen = _out1098;
                        _1742_recOwned = _out1099;
                        _1743_recErased = _out1100;
                        _1744_recIdents = _out1101;
                        Dafny.ISequence<Dafny.Rune> _1745_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1102;
                        _out1102 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                        _1745_rhsType = _out1102;
                        Dafny.ISequence<Dafny.Rune> _1746_uneraseFn;
                        _1746_uneraseFn = ((_1742_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1745_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1746_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1741_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1742_recOwned;
                        isErased = false;
                        readIdents = _1744_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1103;
                        bool _out1104;
                        bool _out1105;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1106;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1740_b), _1740_b, _553_toTpe), selfIdent, @params, mustOwn, out _out1103, out _out1104, out _out1105, out _out1106);
                        s = _out1103;
                        isOwned = _out1104;
                        isErased = _out1105;
                        readIdents = _out1106;
                      }
                    }
                  }
                } else if (_source63.is_Nullable) {
                  DAST._IType _1747___mcc_h918 = _source63.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1748_recursiveGen;
                    bool _1749_recOwned;
                    bool _1750_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1751_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1107;
                    bool _out1108;
                    bool _out1109;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1110;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1107, out _out1108, out _out1109, out _out1110);
                    _1748_recursiveGen = _out1107;
                    _1749_recOwned = _out1108;
                    _1750_recErased = _out1109;
                    _1751_recIdents = _out1110;
                    if (!(_1749_recOwned)) {
                      _1748_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1748_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1748_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1750_recErased;
                    readIdents = _1751_recIdents;
                  }
                } else if (_source63.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1752___mcc_h920 = _source63.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1753_recursiveGen;
                    bool _1754_recOwned;
                    bool _1755_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1756_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1111;
                    bool _out1112;
                    bool _out1113;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1114;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1111, out _out1112, out _out1113, out _out1114);
                    _1753_recursiveGen = _out1111;
                    _1754_recOwned = _out1112;
                    _1755_recErased = _out1113;
                    _1756_recIdents = _out1114;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1753_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1754_recOwned;
                    isErased = _1755_recErased;
                    readIdents = _1756_recIdents;
                  }
                } else if (_source63.is_Array) {
                  DAST._IType _1757___mcc_h922 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1758_recursiveGen;
                    bool _1759_recOwned;
                    bool _1760_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1761_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1115;
                    bool _out1116;
                    bool _out1117;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1118;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1115, out _out1116, out _out1117, out _out1118);
                    _1758_recursiveGen = _out1115;
                    _1759_recOwned = _out1116;
                    _1760_recErased = _out1117;
                    _1761_recIdents = _out1118;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1758_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1759_recOwned;
                    isErased = _1760_recErased;
                    readIdents = _1761_recIdents;
                  }
                } else if (_source63.is_Seq) {
                  DAST._IType _1762___mcc_h924 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1763_recursiveGen;
                    bool _1764_recOwned;
                    bool _1765_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1766_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1119;
                    bool _out1120;
                    bool _out1121;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1122;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1119, out _out1120, out _out1121, out _out1122);
                    _1763_recursiveGen = _out1119;
                    _1764_recOwned = _out1120;
                    _1765_recErased = _out1121;
                    _1766_recIdents = _out1122;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1763_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1764_recOwned;
                    isErased = _1765_recErased;
                    readIdents = _1766_recIdents;
                  }
                } else if (_source63.is_Set) {
                  DAST._IType _1767___mcc_h926 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1768_recursiveGen;
                    bool _1769_recOwned;
                    bool _1770_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1771_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1123;
                    bool _out1124;
                    bool _out1125;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1126;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1123, out _out1124, out _out1125, out _out1126);
                    _1768_recursiveGen = _out1123;
                    _1769_recOwned = _out1124;
                    _1770_recErased = _out1125;
                    _1771_recIdents = _out1126;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1768_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1769_recOwned;
                    isErased = _1770_recErased;
                    readIdents = _1771_recIdents;
                  }
                } else if (_source63.is_Multiset) {
                  DAST._IType _1772___mcc_h928 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1773_recursiveGen;
                    bool _1774_recOwned;
                    bool _1775_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1776_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1127;
                    bool _out1128;
                    bool _out1129;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1130;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1127, out _out1128, out _out1129, out _out1130);
                    _1773_recursiveGen = _out1127;
                    _1774_recOwned = _out1128;
                    _1775_recErased = _out1129;
                    _1776_recIdents = _out1130;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1773_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1774_recOwned;
                    isErased = _1775_recErased;
                    readIdents = _1776_recIdents;
                  }
                } else if (_source63.is_Map) {
                  DAST._IType _1777___mcc_h930 = _source63.dtor_key;
                  DAST._IType _1778___mcc_h931 = _source63.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1779_recursiveGen;
                    bool _1780_recOwned;
                    bool _1781_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1782_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1131;
                    bool _out1132;
                    bool _out1133;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1134;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1131, out _out1132, out _out1133, out _out1134);
                    _1779_recursiveGen = _out1131;
                    _1780_recOwned = _out1132;
                    _1781_recErased = _out1133;
                    _1782_recIdents = _out1134;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1779_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1780_recOwned;
                    isErased = _1781_recErased;
                    readIdents = _1782_recIdents;
                  }
                } else if (_source63.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1783___mcc_h934 = _source63.dtor_args;
                  DAST._IType _1784___mcc_h935 = _source63.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1785_recursiveGen;
                    bool _1786_recOwned;
                    bool _1787_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1788_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1135;
                    bool _out1136;
                    bool _out1137;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1138;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1135, out _out1136, out _out1137, out _out1138);
                    _1785_recursiveGen = _out1135;
                    _1786_recOwned = _out1136;
                    _1787_recErased = _out1137;
                    _1788_recIdents = _out1138;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1785_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1786_recOwned;
                    isErased = _1787_recErased;
                    readIdents = _1788_recIdents;
                  }
                } else if (_source63.is_Primitive) {
                  DAST._IPrimitive _1789___mcc_h938 = _source63.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1790_recursiveGen;
                    bool _1791_recOwned;
                    bool _1792_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1793_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1139;
                    bool _out1140;
                    bool _out1141;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1142;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1139, out _out1140, out _out1141, out _out1142);
                    _1790_recursiveGen = _out1139;
                    _1791_recOwned = _out1140;
                    _1792_recErased = _out1141;
                    _1793_recIdents = _out1142;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1790_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1791_recOwned;
                    isErased = _1792_recErased;
                    readIdents = _1793_recIdents;
                  }
                } else if (_source63.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1794___mcc_h940 = _source63.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1795_recursiveGen;
                    bool _1796_recOwned;
                    bool _1797_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1798_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1143;
                    bool _out1144;
                    bool _out1145;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1146;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1143, out _out1144, out _out1145, out _out1146);
                    _1795_recursiveGen = _out1143;
                    _1796_recOwned = _out1144;
                    _1797_recErased = _out1145;
                    _1798_recIdents = _out1146;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1795_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1796_recOwned;
                    isErased = _1797_recErased;
                    readIdents = _1798_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1799___mcc_h942 = _source63.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1800_recursiveGen;
                    bool _1801_recOwned;
                    bool _1802_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1803_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1147;
                    bool _out1148;
                    bool _out1149;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1150;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1147, out _out1148, out _out1149, out _out1150);
                    _1800_recursiveGen = _out1147;
                    _1801_recOwned = _out1148;
                    _1802_recErased = _out1149;
                    _1803_recIdents = _out1150;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1800_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1801_recOwned;
                    isErased = _1802_recErased;
                    readIdents = _1803_recIdents;
                  }
                }
              } else {
                DAST._IType _source65 = _561___mcc_h265;
                if (_source65.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1804___mcc_h944 = _source65.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1805___mcc_h945 = _source65.dtor_typeArgs;
                  DAST._IResolvedType _1806___mcc_h946 = _source65.dtor_resolved;
                  DAST._IResolvedType _source66 = _1806___mcc_h946;
                  if (_source66.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1807___mcc_h950 = _source66.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1808_recursiveGen;
                      bool _1809_recOwned;
                      bool _1810_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1811_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1151;
                      bool _out1152;
                      bool _out1153;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1154;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1151, out _out1152, out _out1153, out _out1154);
                      _1808_recursiveGen = _out1151;
                      _1809_recOwned = _out1152;
                      _1810_recErased = _out1153;
                      _1811_recIdents = _out1154;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1808_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1809_recOwned;
                      isErased = _1810_recErased;
                      readIdents = _1811_recIdents;
                    }
                  } else if (_source66.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1812___mcc_h952 = _source66.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1813_recursiveGen;
                      bool _1814_recOwned;
                      bool _1815_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1816_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1155;
                      bool _out1156;
                      bool _out1157;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1158;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1155, out _out1156, out _out1157, out _out1158);
                      _1813_recursiveGen = _out1155;
                      _1814_recOwned = _out1156;
                      _1815_recErased = _out1157;
                      _1816_recIdents = _out1158;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1813_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1814_recOwned;
                      isErased = _1815_recErased;
                      readIdents = _1816_recIdents;
                    }
                  } else {
                    DAST._IType _1817___mcc_h954 = _source66.dtor_Newtype_a0;
                    DAST._IType _1818_b = _1817___mcc_h954;
                    {
                      if (object.Equals(_554_fromTpe, _1818_b)) {
                        Dafny.ISequence<Dafny.Rune> _1819_recursiveGen;
                        bool _1820_recOwned;
                        bool _1821_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1822_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1159;
                        bool _out1160;
                        bool _out1161;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1162;
                        DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1159, out _out1160, out _out1161, out _out1162);
                        _1819_recursiveGen = _out1159;
                        _1820_recOwned = _out1160;
                        _1821_recErased = _out1161;
                        _1822_recIdents = _out1162;
                        Dafny.ISequence<Dafny.Rune> _1823_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1163;
                        _out1163 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                        _1823_rhsType = _out1163;
                        Dafny.ISequence<Dafny.Rune> _1824_uneraseFn;
                        _1824_uneraseFn = ((_1820_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1823_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1824_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1819_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1820_recOwned;
                        isErased = false;
                        readIdents = _1822_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1164;
                        bool _out1165;
                        bool _out1166;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1167;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1818_b), _1818_b, _553_toTpe), selfIdent, @params, mustOwn, out _out1164, out _out1165, out _out1166, out _out1167);
                        s = _out1164;
                        isOwned = _out1165;
                        isErased = _out1166;
                        readIdents = _out1167;
                      }
                    }
                  }
                } else if (_source65.is_Nullable) {
                  DAST._IType _1825___mcc_h956 = _source65.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1826_recursiveGen;
                    bool _1827_recOwned;
                    bool _1828_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1829_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1168;
                    bool _out1169;
                    bool _out1170;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1171;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1168, out _out1169, out _out1170, out _out1171);
                    _1826_recursiveGen = _out1168;
                    _1827_recOwned = _out1169;
                    _1828_recErased = _out1170;
                    _1829_recIdents = _out1171;
                    if (!(_1827_recOwned)) {
                      _1826_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1826_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1826_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1828_recErased;
                    readIdents = _1829_recIdents;
                  }
                } else if (_source65.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1830___mcc_h958 = _source65.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1831_recursiveGen;
                    bool _1832_recOwned;
                    bool _1833_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1834_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1172;
                    bool _out1173;
                    bool _out1174;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1175;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1172, out _out1173, out _out1174, out _out1175);
                    _1831_recursiveGen = _out1172;
                    _1832_recOwned = _out1173;
                    _1833_recErased = _out1174;
                    _1834_recIdents = _out1175;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1831_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1832_recOwned;
                    isErased = _1833_recErased;
                    readIdents = _1834_recIdents;
                  }
                } else if (_source65.is_Array) {
                  DAST._IType _1835___mcc_h960 = _source65.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1836_recursiveGen;
                    bool _1837_recOwned;
                    bool _1838_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1839_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1176;
                    bool _out1177;
                    bool _out1178;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1179;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1176, out _out1177, out _out1178, out _out1179);
                    _1836_recursiveGen = _out1176;
                    _1837_recOwned = _out1177;
                    _1838_recErased = _out1178;
                    _1839_recIdents = _out1179;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1836_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1837_recOwned;
                    isErased = _1838_recErased;
                    readIdents = _1839_recIdents;
                  }
                } else if (_source65.is_Seq) {
                  DAST._IType _1840___mcc_h962 = _source65.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1841_recursiveGen;
                    bool _1842_recOwned;
                    bool _1843_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1844_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1180;
                    bool _out1181;
                    bool _out1182;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1183;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1180, out _out1181, out _out1182, out _out1183);
                    _1841_recursiveGen = _out1180;
                    _1842_recOwned = _out1181;
                    _1843_recErased = _out1182;
                    _1844_recIdents = _out1183;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1841_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1842_recOwned;
                    isErased = _1843_recErased;
                    readIdents = _1844_recIdents;
                  }
                } else if (_source65.is_Set) {
                  DAST._IType _1845___mcc_h964 = _source65.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1846_recursiveGen;
                    bool _1847_recOwned;
                    bool _1848_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1849_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1184;
                    bool _out1185;
                    bool _out1186;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1187;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1184, out _out1185, out _out1186, out _out1187);
                    _1846_recursiveGen = _out1184;
                    _1847_recOwned = _out1185;
                    _1848_recErased = _out1186;
                    _1849_recIdents = _out1187;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1846_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1847_recOwned;
                    isErased = _1848_recErased;
                    readIdents = _1849_recIdents;
                  }
                } else if (_source65.is_Multiset) {
                  DAST._IType _1850___mcc_h966 = _source65.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1851_recursiveGen;
                    bool _1852_recOwned;
                    bool _1853_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1854_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1188;
                    bool _out1189;
                    bool _out1190;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1191;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1188, out _out1189, out _out1190, out _out1191);
                    _1851_recursiveGen = _out1188;
                    _1852_recOwned = _out1189;
                    _1853_recErased = _out1190;
                    _1854_recIdents = _out1191;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1851_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1852_recOwned;
                    isErased = _1853_recErased;
                    readIdents = _1854_recIdents;
                  }
                } else if (_source65.is_Map) {
                  DAST._IType _1855___mcc_h968 = _source65.dtor_key;
                  DAST._IType _1856___mcc_h969 = _source65.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1857_recursiveGen;
                    bool _1858_recOwned;
                    bool _1859_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1860_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1192;
                    bool _out1193;
                    bool _out1194;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1195;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1192, out _out1193, out _out1194, out _out1195);
                    _1857_recursiveGen = _out1192;
                    _1858_recOwned = _out1193;
                    _1859_recErased = _out1194;
                    _1860_recIdents = _out1195;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1857_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1858_recOwned;
                    isErased = _1859_recErased;
                    readIdents = _1860_recIdents;
                  }
                } else if (_source65.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1861___mcc_h972 = _source65.dtor_args;
                  DAST._IType _1862___mcc_h973 = _source65.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1863_recursiveGen;
                    bool _1864_recOwned;
                    bool _1865_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1866_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1196;
                    bool _out1197;
                    bool _out1198;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1199;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1196, out _out1197, out _out1198, out _out1199);
                    _1863_recursiveGen = _out1196;
                    _1864_recOwned = _out1197;
                    _1865_recErased = _out1198;
                    _1866_recIdents = _out1199;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1863_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1864_recOwned;
                    isErased = _1865_recErased;
                    readIdents = _1866_recIdents;
                  }
                } else if (_source65.is_Primitive) {
                  DAST._IPrimitive _1867___mcc_h976 = _source65.dtor_Primitive_a0;
                  DAST._IPrimitive _source67 = _1867___mcc_h976;
                  if (_source67.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1868_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1200;
                      _out1200 = DCOMP.COMP.GenType(_554_fromTpe, true, false);
                      _1868_rhsType = _out1200;
                      Dafny.ISequence<Dafny.Rune> _1869_recursiveGen;
                      bool _1870___v60;
                      bool _1871___v61;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1872_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1201;
                      bool _out1202;
                      bool _out1203;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1204;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, true, out _out1201, out _out1202, out _out1203, out _out1204);
                      _1869_recursiveGen = _out1201;
                      _1870___v60 = _out1202;
                      _1871___v61 = _out1203;
                      _1872_recIdents = _out1204;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1869_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1872_recIdents;
                    }
                  } else if (_source67.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1873_recursiveGen;
                      bool _1874_recOwned;
                      bool _1875_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1876_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1205;
                      bool _out1206;
                      bool _out1207;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1208;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1205, out _out1206, out _out1207, out _out1208);
                      _1873_recursiveGen = _out1205;
                      _1874_recOwned = _out1206;
                      _1875_recErased = _out1207;
                      _1876_recIdents = _out1208;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1873_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1874_recOwned;
                      isErased = _1875_recErased;
                      readIdents = _1876_recIdents;
                    }
                  } else if (_source67.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1877_recursiveGen;
                      bool _1878_recOwned;
                      bool _1879_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1880_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1209;
                      bool _out1210;
                      bool _out1211;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1212;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1209, out _out1210, out _out1211, out _out1212);
                      _1877_recursiveGen = _out1209;
                      _1878_recOwned = _out1210;
                      _1879_recErased = _out1211;
                      _1880_recIdents = _out1212;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1877_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1878_recOwned;
                      isErased = _1879_recErased;
                      readIdents = _1880_recIdents;
                    }
                  } else if (_source67.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1881_recursiveGen;
                      bool _1882_recOwned;
                      bool _1883_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1884_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1213;
                      bool _out1214;
                      bool _out1215;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1216;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1213, out _out1214, out _out1215, out _out1216);
                      _1881_recursiveGen = _out1213;
                      _1882_recOwned = _out1214;
                      _1883_recErased = _out1215;
                      _1884_recIdents = _out1216;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1881_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1882_recOwned;
                      isErased = _1883_recErased;
                      readIdents = _1884_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1885_recursiveGen;
                      bool _1886_recOwned;
                      bool _1887_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1888_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1217;
                      bool _out1218;
                      bool _out1219;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1220;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1217, out _out1218, out _out1219, out _out1220);
                      _1885_recursiveGen = _out1217;
                      _1886_recOwned = _out1218;
                      _1887_recErased = _out1219;
                      _1888_recIdents = _out1220;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1885_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1886_recOwned;
                      isErased = _1887_recErased;
                      readIdents = _1888_recIdents;
                    }
                  }
                } else if (_source65.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1889___mcc_h978 = _source65.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1890_recursiveGen;
                    bool _1891_recOwned;
                    bool _1892_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1893_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1221;
                    bool _out1222;
                    bool _out1223;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1224;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1221, out _out1222, out _out1223, out _out1224);
                    _1890_recursiveGen = _out1221;
                    _1891_recOwned = _out1222;
                    _1892_recErased = _out1223;
                    _1893_recIdents = _out1224;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1890_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1891_recOwned;
                    isErased = _1892_recErased;
                    readIdents = _1893_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1894___mcc_h980 = _source65.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1895_recursiveGen;
                    bool _1896_recOwned;
                    bool _1897_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1898_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1225;
                    bool _out1226;
                    bool _out1227;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1228;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1225, out _out1226, out _out1227, out _out1228);
                    _1895_recursiveGen = _out1225;
                    _1896_recOwned = _out1226;
                    _1897_recErased = _out1227;
                    _1898_recIdents = _out1228;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1895_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1896_recOwned;
                    isErased = _1897_recErased;
                    readIdents = _1898_recIdents;
                  }
                }
              }
            } else if (_source30.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1899___mcc_h982 = _source30.dtor_Passthrough_a0;
              DAST._IType _source68 = _561___mcc_h265;
              if (_source68.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1900___mcc_h986 = _source68.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1901___mcc_h987 = _source68.dtor_typeArgs;
                DAST._IResolvedType _1902___mcc_h988 = _source68.dtor_resolved;
                DAST._IResolvedType _source69 = _1902___mcc_h988;
                if (_source69.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1903___mcc_h992 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1904_recursiveGen;
                    bool _1905_recOwned;
                    bool _1906_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1907_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1229;
                    bool _out1230;
                    bool _out1231;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1232;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1229, out _out1230, out _out1231, out _out1232);
                    _1904_recursiveGen = _out1229;
                    _1905_recOwned = _out1230;
                    _1906_recErased = _out1231;
                    _1907_recIdents = _out1232;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1904_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1905_recOwned;
                    isErased = _1906_recErased;
                    readIdents = _1907_recIdents;
                  }
                } else if (_source69.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1908___mcc_h994 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1909_recursiveGen;
                    bool _1910_recOwned;
                    bool _1911_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1912_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1233;
                    bool _out1234;
                    bool _out1235;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1236;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1233, out _out1234, out _out1235, out _out1236);
                    _1909_recursiveGen = _out1233;
                    _1910_recOwned = _out1234;
                    _1911_recErased = _out1235;
                    _1912_recIdents = _out1236;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1909_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1910_recOwned;
                    isErased = _1911_recErased;
                    readIdents = _1912_recIdents;
                  }
                } else {
                  DAST._IType _1913___mcc_h996 = _source69.dtor_Newtype_a0;
                  DAST._IType _1914_b = _1913___mcc_h996;
                  {
                    if (object.Equals(_554_fromTpe, _1914_b)) {
                      Dafny.ISequence<Dafny.Rune> _1915_recursiveGen;
                      bool _1916_recOwned;
                      bool _1917_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1918_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1237;
                      bool _out1238;
                      bool _out1239;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1240;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1237, out _out1238, out _out1239, out _out1240);
                      _1915_recursiveGen = _out1237;
                      _1916_recOwned = _out1238;
                      _1917_recErased = _out1239;
                      _1918_recIdents = _out1240;
                      Dafny.ISequence<Dafny.Rune> _1919_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1241;
                      _out1241 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _1919_rhsType = _out1241;
                      Dafny.ISequence<Dafny.Rune> _1920_uneraseFn;
                      _1920_uneraseFn = ((_1916_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1919_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1920_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1915_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1916_recOwned;
                      isErased = false;
                      readIdents = _1918_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1242;
                      bool _out1243;
                      bool _out1244;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1245;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _1914_b), _1914_b, _553_toTpe), selfIdent, @params, mustOwn, out _out1242, out _out1243, out _out1244, out _out1245);
                      s = _out1242;
                      isOwned = _out1243;
                      isErased = _out1244;
                      readIdents = _out1245;
                    }
                  }
                }
              } else if (_source68.is_Nullable) {
                DAST._IType _1921___mcc_h998 = _source68.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1922_recursiveGen;
                  bool _1923_recOwned;
                  bool _1924_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1925_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1246;
                  bool _out1247;
                  bool _out1248;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1249;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1246, out _out1247, out _out1248, out _out1249);
                  _1922_recursiveGen = _out1246;
                  _1923_recOwned = _out1247;
                  _1924_recErased = _out1248;
                  _1925_recIdents = _out1249;
                  if (!(_1923_recOwned)) {
                    _1922_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1922_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1922_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1924_recErased;
                  readIdents = _1925_recIdents;
                }
              } else if (_source68.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1926___mcc_h1000 = _source68.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1927_recursiveGen;
                  bool _1928_recOwned;
                  bool _1929_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1930_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1250;
                  bool _out1251;
                  bool _out1252;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1253;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1250, out _out1251, out _out1252, out _out1253);
                  _1927_recursiveGen = _out1250;
                  _1928_recOwned = _out1251;
                  _1929_recErased = _out1252;
                  _1930_recIdents = _out1253;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1927_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1928_recOwned;
                  isErased = _1929_recErased;
                  readIdents = _1930_recIdents;
                }
              } else if (_source68.is_Array) {
                DAST._IType _1931___mcc_h1002 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1932_recursiveGen;
                  bool _1933_recOwned;
                  bool _1934_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1935_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1254;
                  bool _out1255;
                  bool _out1256;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1257;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1254, out _out1255, out _out1256, out _out1257);
                  _1932_recursiveGen = _out1254;
                  _1933_recOwned = _out1255;
                  _1934_recErased = _out1256;
                  _1935_recIdents = _out1257;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1932_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1933_recOwned;
                  isErased = _1934_recErased;
                  readIdents = _1935_recIdents;
                }
              } else if (_source68.is_Seq) {
                DAST._IType _1936___mcc_h1004 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1937_recursiveGen;
                  bool _1938_recOwned;
                  bool _1939_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1940_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1258;
                  bool _out1259;
                  bool _out1260;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1261;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1258, out _out1259, out _out1260, out _out1261);
                  _1937_recursiveGen = _out1258;
                  _1938_recOwned = _out1259;
                  _1939_recErased = _out1260;
                  _1940_recIdents = _out1261;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1937_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1938_recOwned;
                  isErased = _1939_recErased;
                  readIdents = _1940_recIdents;
                }
              } else if (_source68.is_Set) {
                DAST._IType _1941___mcc_h1006 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1942_recursiveGen;
                  bool _1943_recOwned;
                  bool _1944_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1945_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1262;
                  bool _out1263;
                  bool _out1264;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1265;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1262, out _out1263, out _out1264, out _out1265);
                  _1942_recursiveGen = _out1262;
                  _1943_recOwned = _out1263;
                  _1944_recErased = _out1264;
                  _1945_recIdents = _out1265;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1942_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1943_recOwned;
                  isErased = _1944_recErased;
                  readIdents = _1945_recIdents;
                }
              } else if (_source68.is_Multiset) {
                DAST._IType _1946___mcc_h1008 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1947_recursiveGen;
                  bool _1948_recOwned;
                  bool _1949_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1950_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1266;
                  bool _out1267;
                  bool _out1268;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1269;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1266, out _out1267, out _out1268, out _out1269);
                  _1947_recursiveGen = _out1266;
                  _1948_recOwned = _out1267;
                  _1949_recErased = _out1268;
                  _1950_recIdents = _out1269;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1947_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1948_recOwned;
                  isErased = _1949_recErased;
                  readIdents = _1950_recIdents;
                }
              } else if (_source68.is_Map) {
                DAST._IType _1951___mcc_h1010 = _source68.dtor_key;
                DAST._IType _1952___mcc_h1011 = _source68.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1953_recursiveGen;
                  bool _1954_recOwned;
                  bool _1955_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1956_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1270;
                  bool _out1271;
                  bool _out1272;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1273;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1270, out _out1271, out _out1272, out _out1273);
                  _1953_recursiveGen = _out1270;
                  _1954_recOwned = _out1271;
                  _1955_recErased = _out1272;
                  _1956_recIdents = _out1273;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1953_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1954_recOwned;
                  isErased = _1955_recErased;
                  readIdents = _1956_recIdents;
                }
              } else if (_source68.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1957___mcc_h1014 = _source68.dtor_args;
                DAST._IType _1958___mcc_h1015 = _source68.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1959_recursiveGen;
                  bool _1960_recOwned;
                  bool _1961_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1962_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1274;
                  bool _out1275;
                  bool _out1276;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1277;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1274, out _out1275, out _out1276, out _out1277);
                  _1959_recursiveGen = _out1274;
                  _1960_recOwned = _out1275;
                  _1961_recErased = _out1276;
                  _1962_recIdents = _out1277;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1959_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1960_recOwned;
                  isErased = _1961_recErased;
                  readIdents = _1962_recIdents;
                }
              } else if (_source68.is_Primitive) {
                DAST._IPrimitive _1963___mcc_h1018 = _source68.dtor_Primitive_a0;
                DAST._IPrimitive _source70 = _1963___mcc_h1018;
                if (_source70.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1964_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1278;
                    _out1278 = DCOMP.COMP.GenType(_554_fromTpe, true, false);
                    _1964_rhsType = _out1278;
                    Dafny.ISequence<Dafny.Rune> _1965_recursiveGen;
                    bool _1966___v56;
                    bool _1967___v57;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1968_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1279;
                    bool _out1280;
                    bool _out1281;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1282;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, true, out _out1279, out _out1280, out _out1281, out _out1282);
                    _1965_recursiveGen = _out1279;
                    _1966___v56 = _out1280;
                    _1967___v57 = _out1281;
                    _1968_recIdents = _out1282;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1965_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1968_recIdents;
                  }
                } else if (_source70.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1969_recursiveGen;
                    bool _1970_recOwned;
                    bool _1971_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1972_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1283;
                    bool _out1284;
                    bool _out1285;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1286;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1283, out _out1284, out _out1285, out _out1286);
                    _1969_recursiveGen = _out1283;
                    _1970_recOwned = _out1284;
                    _1971_recErased = _out1285;
                    _1972_recIdents = _out1286;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1970_recOwned;
                    isErased = _1971_recErased;
                    readIdents = _1972_recIdents;
                  }
                } else if (_source70.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1973_recursiveGen;
                    bool _1974_recOwned;
                    bool _1975_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1976_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1287;
                    bool _out1288;
                    bool _out1289;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1290;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1287, out _out1288, out _out1289, out _out1290);
                    _1973_recursiveGen = _out1287;
                    _1974_recOwned = _out1288;
                    _1975_recErased = _out1289;
                    _1976_recIdents = _out1290;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1973_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1974_recOwned;
                    isErased = _1975_recErased;
                    readIdents = _1976_recIdents;
                  }
                } else if (_source70.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1977_recursiveGen;
                    bool _1978_recOwned;
                    bool _1979_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1980_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1291;
                    bool _out1292;
                    bool _out1293;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1294;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1291, out _out1292, out _out1293, out _out1294);
                    _1977_recursiveGen = _out1291;
                    _1978_recOwned = _out1292;
                    _1979_recErased = _out1293;
                    _1980_recIdents = _out1294;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1977_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1978_recOwned;
                    isErased = _1979_recErased;
                    readIdents = _1980_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1981_recursiveGen;
                    bool _1982_recOwned;
                    bool _1983_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1984_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1295;
                    bool _out1296;
                    bool _out1297;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1298;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1295, out _out1296, out _out1297, out _out1298);
                    _1981_recursiveGen = _out1295;
                    _1982_recOwned = _out1296;
                    _1983_recErased = _out1297;
                    _1984_recIdents = _out1298;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1981_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1982_recOwned;
                    isErased = _1983_recErased;
                    readIdents = _1984_recIdents;
                  }
                }
              } else if (_source68.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1985___mcc_h1020 = _source68.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1986_recursiveGen;
                  bool _1987___v64;
                  bool _1988___v65;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1989_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1299;
                  bool _out1300;
                  bool _out1301;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1302;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, true, out _out1299, out _out1300, out _out1301, out _out1302);
                  _1986_recursiveGen = _out1299;
                  _1987___v64 = _out1300;
                  _1988___v65 = _out1301;
                  _1989_recIdents = _out1302;
                  Dafny.ISequence<Dafny.Rune> _1990_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1303;
                  _out1303 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                  _1990_toTpeGen = _out1303;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1986_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1990_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1989_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1991___mcc_h1022 = _source68.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1992_recursiveGen;
                  bool _1993_recOwned;
                  bool _1994_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1995_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1304;
                  bool _out1305;
                  bool _out1306;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1307;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1304, out _out1305, out _out1306, out _out1307);
                  _1992_recursiveGen = _out1304;
                  _1993_recOwned = _out1305;
                  _1994_recErased = _out1306;
                  _1995_recIdents = _out1307;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1992_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1993_recOwned;
                  isErased = _1994_recErased;
                  readIdents = _1995_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1996___mcc_h1024 = _source30.dtor_TypeArg_a0;
              DAST._IType _source71 = _561___mcc_h265;
              if (_source71.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1997___mcc_h1028 = _source71.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1998___mcc_h1029 = _source71.dtor_typeArgs;
                DAST._IResolvedType _1999___mcc_h1030 = _source71.dtor_resolved;
                DAST._IResolvedType _source72 = _1999___mcc_h1030;
                if (_source72.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2000___mcc_h1034 = _source72.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _2001_recursiveGen;
                    bool _2002_recOwned;
                    bool _2003_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2004_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1308;
                    bool _out1309;
                    bool _out1310;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1311;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1308, out _out1309, out _out1310, out _out1311);
                    _2001_recursiveGen = _out1308;
                    _2002_recOwned = _out1309;
                    _2003_recErased = _out1310;
                    _2004_recIdents = _out1311;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2001_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2002_recOwned;
                    isErased = _2003_recErased;
                    readIdents = _2004_recIdents;
                  }
                } else if (_source72.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2005___mcc_h1036 = _source72.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _2006_recursiveGen;
                    bool _2007_recOwned;
                    bool _2008_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2009_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1312;
                    bool _out1313;
                    bool _out1314;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1315;
                    DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1312, out _out1313, out _out1314, out _out1315);
                    _2006_recursiveGen = _out1312;
                    _2007_recOwned = _out1313;
                    _2008_recErased = _out1314;
                    _2009_recIdents = _out1315;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2006_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2007_recOwned;
                    isErased = _2008_recErased;
                    readIdents = _2009_recIdents;
                  }
                } else {
                  DAST._IType _2010___mcc_h1038 = _source72.dtor_Newtype_a0;
                  DAST._IType _2011_b = _2010___mcc_h1038;
                  {
                    if (object.Equals(_554_fromTpe, _2011_b)) {
                      Dafny.ISequence<Dafny.Rune> _2012_recursiveGen;
                      bool _2013_recOwned;
                      bool _2014_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2015_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1316;
                      bool _out1317;
                      bool _out1318;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1319;
                      DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1316, out _out1317, out _out1318, out _out1319);
                      _2012_recursiveGen = _out1316;
                      _2013_recOwned = _out1317;
                      _2014_recErased = _out1318;
                      _2015_recIdents = _out1319;
                      Dafny.ISequence<Dafny.Rune> _2016_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1320;
                      _out1320 = DCOMP.COMP.GenType(_553_toTpe, true, false);
                      _2016_rhsType = _out1320;
                      Dafny.ISequence<Dafny.Rune> _2017_uneraseFn;
                      _2017_uneraseFn = ((_2013_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2016_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _2017_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2012_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _2013_recOwned;
                      isErased = false;
                      readIdents = _2015_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1321;
                      bool _out1322;
                      bool _out1323;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1324;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_555_expr, _554_fromTpe, _2011_b), _2011_b, _553_toTpe), selfIdent, @params, mustOwn, out _out1321, out _out1322, out _out1323, out _out1324);
                      s = _out1321;
                      isOwned = _out1322;
                      isErased = _out1323;
                      readIdents = _out1324;
                    }
                  }
                }
              } else if (_source71.is_Nullable) {
                DAST._IType _2018___mcc_h1040 = _source71.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2019_recursiveGen;
                  bool _2020_recOwned;
                  bool _2021_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2022_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1325;
                  bool _out1326;
                  bool _out1327;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1328;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1325, out _out1326, out _out1327, out _out1328);
                  _2019_recursiveGen = _out1325;
                  _2020_recOwned = _out1326;
                  _2021_recErased = _out1327;
                  _2022_recIdents = _out1328;
                  if (!(_2020_recOwned)) {
                    _2019_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_2019_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _2019_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _2021_recErased;
                  readIdents = _2022_recIdents;
                }
              } else if (_source71.is_Tuple) {
                Dafny.ISequence<DAST._IType> _2023___mcc_h1042 = _source71.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2024_recursiveGen;
                  bool _2025_recOwned;
                  bool _2026_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2027_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1329;
                  bool _out1330;
                  bool _out1331;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1332;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1329, out _out1330, out _out1331, out _out1332);
                  _2024_recursiveGen = _out1329;
                  _2025_recOwned = _out1330;
                  _2026_recErased = _out1331;
                  _2027_recIdents = _out1332;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2024_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2025_recOwned;
                  isErased = _2026_recErased;
                  readIdents = _2027_recIdents;
                }
              } else if (_source71.is_Array) {
                DAST._IType _2028___mcc_h1044 = _source71.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2029_recursiveGen;
                  bool _2030_recOwned;
                  bool _2031_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2032_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1333;
                  bool _out1334;
                  bool _out1335;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1336;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1333, out _out1334, out _out1335, out _out1336);
                  _2029_recursiveGen = _out1333;
                  _2030_recOwned = _out1334;
                  _2031_recErased = _out1335;
                  _2032_recIdents = _out1336;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2029_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2030_recOwned;
                  isErased = _2031_recErased;
                  readIdents = _2032_recIdents;
                }
              } else if (_source71.is_Seq) {
                DAST._IType _2033___mcc_h1046 = _source71.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2034_recursiveGen;
                  bool _2035_recOwned;
                  bool _2036_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2037_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1337;
                  bool _out1338;
                  bool _out1339;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1340;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1337, out _out1338, out _out1339, out _out1340);
                  _2034_recursiveGen = _out1337;
                  _2035_recOwned = _out1338;
                  _2036_recErased = _out1339;
                  _2037_recIdents = _out1340;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2034_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2035_recOwned;
                  isErased = _2036_recErased;
                  readIdents = _2037_recIdents;
                }
              } else if (_source71.is_Set) {
                DAST._IType _2038___mcc_h1048 = _source71.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2039_recursiveGen;
                  bool _2040_recOwned;
                  bool _2041_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2042_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1341;
                  bool _out1342;
                  bool _out1343;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1344;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1341, out _out1342, out _out1343, out _out1344);
                  _2039_recursiveGen = _out1341;
                  _2040_recOwned = _out1342;
                  _2041_recErased = _out1343;
                  _2042_recIdents = _out1344;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2039_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2040_recOwned;
                  isErased = _2041_recErased;
                  readIdents = _2042_recIdents;
                }
              } else if (_source71.is_Multiset) {
                DAST._IType _2043___mcc_h1050 = _source71.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2044_recursiveGen;
                  bool _2045_recOwned;
                  bool _2046_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2047_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1345;
                  bool _out1346;
                  bool _out1347;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1348;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1345, out _out1346, out _out1347, out _out1348);
                  _2044_recursiveGen = _out1345;
                  _2045_recOwned = _out1346;
                  _2046_recErased = _out1347;
                  _2047_recIdents = _out1348;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2044_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2045_recOwned;
                  isErased = _2046_recErased;
                  readIdents = _2047_recIdents;
                }
              } else if (_source71.is_Map) {
                DAST._IType _2048___mcc_h1052 = _source71.dtor_key;
                DAST._IType _2049___mcc_h1053 = _source71.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _2050_recursiveGen;
                  bool _2051_recOwned;
                  bool _2052_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2053_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1349;
                  bool _out1350;
                  bool _out1351;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1352;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1349, out _out1350, out _out1351, out _out1352);
                  _2050_recursiveGen = _out1349;
                  _2051_recOwned = _out1350;
                  _2052_recErased = _out1351;
                  _2053_recIdents = _out1352;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2050_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2051_recOwned;
                  isErased = _2052_recErased;
                  readIdents = _2053_recIdents;
                }
              } else if (_source71.is_Arrow) {
                Dafny.ISequence<DAST._IType> _2054___mcc_h1056 = _source71.dtor_args;
                DAST._IType _2055___mcc_h1057 = _source71.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _2056_recursiveGen;
                  bool _2057_recOwned;
                  bool _2058_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2059_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1353;
                  bool _out1354;
                  bool _out1355;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1356;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1353, out _out1354, out _out1355, out _out1356);
                  _2056_recursiveGen = _out1353;
                  _2057_recOwned = _out1354;
                  _2058_recErased = _out1355;
                  _2059_recIdents = _out1356;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2056_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2057_recOwned;
                  isErased = _2058_recErased;
                  readIdents = _2059_recIdents;
                }
              } else if (_source71.is_Primitive) {
                DAST._IPrimitive _2060___mcc_h1060 = _source71.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2061_recursiveGen;
                  bool _2062_recOwned;
                  bool _2063_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2064_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1357;
                  bool _out1358;
                  bool _out1359;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1360;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1357, out _out1358, out _out1359, out _out1360);
                  _2061_recursiveGen = _out1357;
                  _2062_recOwned = _out1358;
                  _2063_recErased = _out1359;
                  _2064_recIdents = _out1360;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2061_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2062_recOwned;
                  isErased = _2063_recErased;
                  readIdents = _2064_recIdents;
                }
              } else if (_source71.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2065___mcc_h1062 = _source71.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2066_recursiveGen;
                  bool _2067_recOwned;
                  bool _2068_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2069_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1361;
                  bool _out1362;
                  bool _out1363;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1364;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1361, out _out1362, out _out1363, out _out1364);
                  _2066_recursiveGen = _out1361;
                  _2067_recOwned = _out1362;
                  _2068_recErased = _out1363;
                  _2069_recIdents = _out1364;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2066_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2067_recOwned;
                  isErased = _2068_recErased;
                  readIdents = _2069_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2070___mcc_h1064 = _source71.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2071_recursiveGen;
                  bool _2072_recOwned;
                  bool _2073_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2074_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1365;
                  bool _out1366;
                  bool _out1367;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1368;
                  DCOMP.COMP.GenExpr(_555_expr, selfIdent, @params, mustOwn, out _out1365, out _out1366, out _out1367, out _out1368);
                  _2071_recursiveGen = _out1365;
                  _2072_recOwned = _out1366;
                  _2073_recErased = _out1367;
                  _2074_recIdents = _out1368;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2071_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2072_recOwned;
                  isErased = _2073_recErased;
                  readIdents = _2074_recIdents;
                }
              }
            }
          }
        }
      } else if (_source23.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2075___mcc_h22 = _source23.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2076_exprs = _2075___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2077_generatedValues;
          _2077_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2078_i;
          _2078_i = BigInteger.Zero;
          bool _2079_allErased;
          _2079_allErased = true;
          while ((_2078_i) < (new BigInteger((_2076_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2080_recursiveGen;
            bool _2081___v67;
            bool _2082_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2083_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1369;
            bool _out1370;
            bool _out1371;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1372;
            DCOMP.COMP.GenExpr((_2076_exprs).Select(_2078_i), selfIdent, @params, true, out _out1369, out _out1370, out _out1371, out _out1372);
            _2080_recursiveGen = _out1369;
            _2081___v67 = _out1370;
            _2082_isErased = _out1371;
            _2083_recIdents = _out1372;
            _2079_allErased = (_2079_allErased) && (_2082_isErased);
            _2077_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2077_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2080_recursiveGen, _2082_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2083_recIdents);
            _2078_i = (_2078_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2078_i = BigInteger.Zero;
          while ((_2078_i) < (new BigInteger((_2077_generatedValues).Count))) {
            if ((_2078_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2084_gen;
            _2084_gen = ((_2077_generatedValues).Select(_2078_i)).dtor__0;
            if ((((_2077_generatedValues).Select(_2078_i)).dtor__1) && (!(_2079_allErased))) {
              _2084_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2084_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2084_gen);
            _2078_i = (_2078_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2079_allErased;
        }
      } else if (_source23.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2085___mcc_h23 = _source23.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2086_exprs = _2085___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2087_generatedValues;
          _2087_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2088_i;
          _2088_i = BigInteger.Zero;
          bool _2089_allErased;
          _2089_allErased = true;
          while ((_2088_i) < (new BigInteger((_2086_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2090_recursiveGen;
            bool _2091___v68;
            bool _2092_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2093_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1373;
            bool _out1374;
            bool _out1375;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1376;
            DCOMP.COMP.GenExpr((_2086_exprs).Select(_2088_i), selfIdent, @params, true, out _out1373, out _out1374, out _out1375, out _out1376);
            _2090_recursiveGen = _out1373;
            _2091___v68 = _out1374;
            _2092_isErased = _out1375;
            _2093_recIdents = _out1376;
            _2089_allErased = (_2089_allErased) && (_2092_isErased);
            _2087_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2087_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2090_recursiveGen, _2092_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2093_recIdents);
            _2088_i = (_2088_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2088_i = BigInteger.Zero;
          while ((_2088_i) < (new BigInteger((_2087_generatedValues).Count))) {
            if ((_2088_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2094_gen;
            _2094_gen = ((_2087_generatedValues).Select(_2088_i)).dtor__0;
            if ((((_2087_generatedValues).Select(_2088_i)).dtor__1) && (!(_2089_allErased))) {
              _2094_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2094_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2094_gen);
            _2088_i = (_2088_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = _2089_allErased;
        }
      } else if (_source23.is_MapValue) {
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2095___mcc_h24 = _source23.dtor_mapElems;
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2096_mapElems = _2095___mcc_h24;
        {
          Dafny.ISequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>> _2097_generatedValues;
          _2097_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2098_i;
          _2098_i = BigInteger.Zero;
          bool _2099_allErased;
          _2099_allErased = true;
          while ((_2098_i) < (new BigInteger((_2096_mapElems).Count))) {
            Dafny.ISequence<Dafny.Rune> _2100_recursiveGenKey;
            bool _2101___v69;
            bool _2102_isErasedKey;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2103_recIdentsKey;
            Dafny.ISequence<Dafny.Rune> _out1377;
            bool _out1378;
            bool _out1379;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1380;
            DCOMP.COMP.GenExpr(((_2096_mapElems).Select(_2098_i)).dtor__0, selfIdent, @params, true, out _out1377, out _out1378, out _out1379, out _out1380);
            _2100_recursiveGenKey = _out1377;
            _2101___v69 = _out1378;
            _2102_isErasedKey = _out1379;
            _2103_recIdentsKey = _out1380;
            Dafny.ISequence<Dafny.Rune> _2104_recursiveGenValue;
            bool _2105___v70;
            bool _2106_isErasedValue;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2107_recIdentsValue;
            Dafny.ISequence<Dafny.Rune> _out1381;
            bool _out1382;
            bool _out1383;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1384;
            DCOMP.COMP.GenExpr(((_2096_mapElems).Select(_2098_i)).dtor__1, selfIdent, @params, true, out _out1381, out _out1382, out _out1383, out _out1384);
            _2104_recursiveGenValue = _out1381;
            _2105___v70 = _out1382;
            _2106_isErasedValue = _out1383;
            _2107_recIdentsValue = _out1384;
            _2099_allErased = ((_2099_allErased) && (_2102_isErasedKey)) && (_2106_isErasedValue);
            _2097_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.Concat(_2097_generatedValues, Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements(_System.Tuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>.create(_2100_recursiveGenKey, _2104_recursiveGenValue, _2102_isErasedKey, _2106_isErasedValue)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2103_recIdentsKey), _2107_recIdentsValue);
            _2098_i = (_2098_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2098_i = BigInteger.Zero;
          while ((_2098_i) < (new BigInteger((_2097_generatedValues).Count))) {
            if ((_2098_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2108_genKey;
            _2108_genKey = ((_2097_generatedValues).Select(_2098_i)).dtor__0;
            Dafny.ISequence<Dafny.Rune> _2109_genValue;
            _2109_genValue = ((_2097_generatedValues).Select(_2098_i)).dtor__1;
            if ((((_2097_generatedValues).Select(_2098_i)).dtor__2) && (!(_2099_allErased))) {
              _2108_genKey = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2108_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((((_2097_generatedValues).Select(_2098_i)).dtor__3) && (!(_2099_allErased))) {
              _2109_genValue = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2109_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2108_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2109_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            _2098_i = (_2098_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashMap<_, _>>()"));
          isOwned = true;
          isErased = _2099_allErased;
        }
      } else if (_source23.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source73 = selfIdent;
          if (_source73.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2110___mcc_h1066 = _source73.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2111_id = _2110___mcc_h1066;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2111_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2111_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2111_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2111_id);
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
      } else if (_source23.is_Ite) {
        DAST._IExpression _2112___mcc_h25 = _source23.dtor_cond;
        DAST._IExpression _2113___mcc_h26 = _source23.dtor_thn;
        DAST._IExpression _2114___mcc_h27 = _source23.dtor_els;
        DAST._IExpression _2115_f = _2114___mcc_h27;
        DAST._IExpression _2116_t = _2113___mcc_h26;
        DAST._IExpression _2117_cond = _2112___mcc_h25;
        {
          Dafny.ISequence<Dafny.Rune> _2118_condString;
          bool _2119___v71;
          bool _2120_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2121_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1385;
          bool _out1386;
          bool _out1387;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1388;
          DCOMP.COMP.GenExpr(_2117_cond, selfIdent, @params, true, out _out1385, out _out1386, out _out1387, out _out1388);
          _2118_condString = _out1385;
          _2119___v71 = _out1386;
          _2120_condErased = _out1387;
          _2121_recIdentsCond = _out1388;
          if (!(_2120_condErased)) {
            _2118_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2118_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2122___v72;
          bool _2123_tHasToBeOwned;
          bool _2124___v73;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2125___v74;
          Dafny.ISequence<Dafny.Rune> _out1389;
          bool _out1390;
          bool _out1391;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1392;
          DCOMP.COMP.GenExpr(_2116_t, selfIdent, @params, mustOwn, out _out1389, out _out1390, out _out1391, out _out1392);
          _2122___v72 = _out1389;
          _2123_tHasToBeOwned = _out1390;
          _2124___v73 = _out1391;
          _2125___v74 = _out1392;
          Dafny.ISequence<Dafny.Rune> _2126_fString;
          bool _2127_fOwned;
          bool _2128_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2129_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1393;
          bool _out1394;
          bool _out1395;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1396;
          DCOMP.COMP.GenExpr(_2115_f, selfIdent, @params, _2123_tHasToBeOwned, out _out1393, out _out1394, out _out1395, out _out1396);
          _2126_fString = _out1393;
          _2127_fOwned = _out1394;
          _2128_fErased = _out1395;
          _2129_recIdentsF = _out1396;
          Dafny.ISequence<Dafny.Rune> _2130_tString;
          bool _2131___v75;
          bool _2132_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2133_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1397;
          bool _out1398;
          bool _out1399;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1400;
          DCOMP.COMP.GenExpr(_2116_t, selfIdent, @params, _2127_fOwned, out _out1397, out _out1398, out _out1399, out _out1400);
          _2130_tString = _out1397;
          _2131___v75 = _out1398;
          _2132_tErased = _out1399;
          _2133_recIdentsT = _out1400;
          if ((!(_2128_fErased)) || (!(_2132_tErased))) {
            if (_2128_fErased) {
              _2126_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2126_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2132_tErased) {
              _2130_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2130_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2118_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2130_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2126_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2127_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2121_recIdentsCond, _2133_recIdentsT), _2129_recIdentsF);
          isErased = (_2128_fErased) || (_2132_tErased);
        }
      } else if (_source23.is_UnOp) {
        DAST._IUnaryOp _2134___mcc_h28 = _source23.dtor_unOp;
        DAST._IExpression _2135___mcc_h29 = _source23.dtor_expr;
        DAST._IUnaryOp _source74 = _2134___mcc_h28;
        if (_source74.is_Not) {
          DAST._IExpression _2136_e = _2135___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2137_recursiveGen;
            bool _2138___v76;
            bool _2139_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2140_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1401;
            bool _out1402;
            bool _out1403;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1404;
            DCOMP.COMP.GenExpr(_2136_e, selfIdent, @params, true, out _out1401, out _out1402, out _out1403, out _out1404);
            _2137_recursiveGen = _out1401;
            _2138___v76 = _out1402;
            _2139_recErased = _out1403;
            _2140_recIdents = _out1404;
            if (!(_2139_recErased)) {
              _2137_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2137_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2137_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2140_recIdents;
            isErased = true;
          }
        } else if (_source74.is_BitwiseNot) {
          DAST._IExpression _2141_e = _2135___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2142_recursiveGen;
            bool _2143___v77;
            bool _2144_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2145_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1405;
            bool _out1406;
            bool _out1407;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1408;
            DCOMP.COMP.GenExpr(_2141_e, selfIdent, @params, true, out _out1405, out _out1406, out _out1407, out _out1408);
            _2142_recursiveGen = _out1405;
            _2143___v77 = _out1406;
            _2144_recErased = _out1407;
            _2145_recIdents = _out1408;
            if (!(_2144_recErased)) {
              _2142_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2142_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2142_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2145_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2146_e = _2135___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2147_recursiveGen;
            bool _2148_recOwned;
            bool _2149_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2150_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1409;
            bool _out1410;
            bool _out1411;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1412;
            DCOMP.COMP.GenExpr(_2146_e, selfIdent, @params, false, out _out1409, out _out1410, out _out1411, out _out1412);
            _2147_recursiveGen = _out1409;
            _2148_recOwned = _out1410;
            _2149_recErased = _out1411;
            _2150_recIdents = _out1412;
            if (!(_2149_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2151_eraseFn;
              _2151_eraseFn = ((_2148_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2147_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2151_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2147_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2147_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2150_recIdents;
            isErased = true;
          }
        }
      } else if (_source23.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2152___mcc_h30 = _source23.dtor_op;
        DAST._IExpression _2153___mcc_h31 = _source23.dtor_left;
        DAST._IExpression _2154___mcc_h32 = _source23.dtor_right;
        DAST._IExpression _2155_r = _2154___mcc_h32;
        DAST._IExpression _2156_l = _2153___mcc_h31;
        Dafny.ISequence<Dafny.Rune> _2157_op = _2152___mcc_h30;
        {
          Dafny.ISequence<Dafny.Rune> _2158_left;
          bool _2159___v78;
          bool _2160_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2161_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1413;
          bool _out1414;
          bool _out1415;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1416;
          DCOMP.COMP.GenExpr(_2156_l, selfIdent, @params, true, out _out1413, out _out1414, out _out1415, out _out1416);
          _2158_left = _out1413;
          _2159___v78 = _out1414;
          _2160_leftErased = _out1415;
          _2161_recIdentsL = _out1416;
          Dafny.ISequence<Dafny.Rune> _2162_right;
          bool _2163___v79;
          bool _2164_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2165_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1417;
          bool _out1418;
          bool _out1419;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1420;
          DCOMP.COMP.GenExpr(_2155_r, selfIdent, @params, true, out _out1417, out _out1418, out _out1419, out _out1420);
          _2162_right = _out1417;
          _2163___v79 = _out1418;
          _2164_rightErased = _out1419;
          _2165_recIdentsR = _out1420;
          if (!(_2160_leftErased)) {
            _2158_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2158_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2164_rightErased)) {
            _2162_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2162_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2157_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2158_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2162_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2157_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2158_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2162_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2158_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2157_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2162_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2161_recIdentsL, _2165_recIdentsR);
          isErased = true;
        }
      } else if (_source23.is_ArrayLen) {
        DAST._IExpression _2166___mcc_h33 = _source23.dtor_expr;
        DAST._IExpression _2167_expr = _2166___mcc_h33;
        {
          Dafny.ISequence<Dafny.Rune> _2168_recursiveGen;
          bool _2169___v80;
          bool _2170_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2171_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1421;
          bool _out1422;
          bool _out1423;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1424;
          DCOMP.COMP.GenExpr(_2167_expr, selfIdent, @params, true, out _out1421, out _out1422, out _out1423, out _out1424);
          _2168_recursiveGen = _out1421;
          _2169___v80 = _out1422;
          _2170_recErased = _out1423;
          _2171_recIdents = _out1424;
          if (!(_2170_recErased)) {
            _2168_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2168_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2168_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow().len())"));
          isOwned = true;
          readIdents = _2171_recIdents;
          isErased = true;
        }
      } else if (_source23.is_Select) {
        DAST._IExpression _2172___mcc_h34 = _source23.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2173___mcc_h35 = _source23.dtor_field;
        bool _2174___mcc_h36 = _source23.dtor_isConstant;
        bool _2175___mcc_h37 = _source23.dtor_onDatatype;
        DAST._IExpression _source75 = _2172___mcc_h34;
        if (_source75.is_Literal) {
          DAST._ILiteral _2176___mcc_h38 = _source75.dtor_Literal_a0;
          bool _2177_isDatatype = _2175___mcc_h37;
          bool _2178_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2179_field = _2173___mcc_h35;
          DAST._IExpression _2180_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2181_onString;
            bool _2182_onOwned;
            bool _2183_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2184_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1425;
            bool _out1426;
            bool _out1427;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1428;
            DCOMP.COMP.GenExpr(_2180_on, selfIdent, @params, false, out _out1425, out _out1426, out _out1427, out _out1428);
            _2181_onString = _out1425;
            _2182_onOwned = _out1426;
            _2183_onErased = _out1427;
            _2184_recIdents = _out1428;
            if (!(_2183_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2185_eraseFn;
              _2185_eraseFn = ((_2182_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2181_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2185_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2181_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2177_isDatatype) || (_2178_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2181_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2179_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2178_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2181_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2179_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2184_recIdents;
          }
        } else if (_source75.is_Ident) {
          Dafny.ISequence<Dafny.Rune> _2186___mcc_h40 = _source75.dtor_Ident_a0;
          bool _2187_isDatatype = _2175___mcc_h37;
          bool _2188_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2189_field = _2173___mcc_h35;
          DAST._IExpression _2190_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2191_onString;
            bool _2192_onOwned;
            bool _2193_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2194_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1429;
            bool _out1430;
            bool _out1431;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1432;
            DCOMP.COMP.GenExpr(_2190_on, selfIdent, @params, false, out _out1429, out _out1430, out _out1431, out _out1432);
            _2191_onString = _out1429;
            _2192_onOwned = _out1430;
            _2193_onErased = _out1431;
            _2194_recIdents = _out1432;
            if (!(_2193_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2195_eraseFn;
              _2195_eraseFn = ((_2192_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2191_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2195_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2191_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2187_isDatatype) || (_2188_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2191_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2189_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2188_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2191_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2189_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2194_recIdents;
          }
        } else if (_source75.is_Companion) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2196___mcc_h42 = _source75.dtor_Companion_a0;
          bool _2197_isDatatype = _2175___mcc_h37;
          bool _2198_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2199_field = _2173___mcc_h35;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2200_c = _2196___mcc_h42;
          {
            Dafny.ISequence<Dafny.Rune> _2201_onString;
            bool _2202_onOwned;
            bool _2203_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2204_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1433;
            bool _out1434;
            bool _out1435;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1436;
            DCOMP.COMP.GenExpr(DAST.Expression.create_Companion(_2200_c), selfIdent, @params, false, out _out1433, out _out1434, out _out1435, out _out1436);
            _2201_onString = _out1433;
            _2202_onOwned = _out1434;
            _2203_onErased = _out1435;
            _2204_recIdents = _out1436;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2201_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2199_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            isOwned = true;
            isErased = false;
            readIdents = _2204_recIdents;
          }
        } else if (_source75.is_Tuple) {
          Dafny.ISequence<DAST._IExpression> _2205___mcc_h44 = _source75.dtor_Tuple_a0;
          bool _2206_isDatatype = _2175___mcc_h37;
          bool _2207_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2208_field = _2173___mcc_h35;
          DAST._IExpression _2209_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2210_onString;
            bool _2211_onOwned;
            bool _2212_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2213_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1437;
            bool _out1438;
            bool _out1439;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1440;
            DCOMP.COMP.GenExpr(_2209_on, selfIdent, @params, false, out _out1437, out _out1438, out _out1439, out _out1440);
            _2210_onString = _out1437;
            _2211_onOwned = _out1438;
            _2212_onErased = _out1439;
            _2213_recIdents = _out1440;
            if (!(_2212_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2214_eraseFn;
              _2214_eraseFn = ((_2211_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2210_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2214_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2210_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2206_isDatatype) || (_2207_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2210_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2208_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2207_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2210_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2208_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2213_recIdents;
          }
        } else if (_source75.is_New) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2215___mcc_h46 = _source75.dtor_path;
          Dafny.ISequence<DAST._IExpression> _2216___mcc_h47 = _source75.dtor_args;
          bool _2217_isDatatype = _2175___mcc_h37;
          bool _2218_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2219_field = _2173___mcc_h35;
          DAST._IExpression _2220_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2221_onString;
            bool _2222_onOwned;
            bool _2223_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2224_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1441;
            bool _out1442;
            bool _out1443;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1444;
            DCOMP.COMP.GenExpr(_2220_on, selfIdent, @params, false, out _out1441, out _out1442, out _out1443, out _out1444);
            _2221_onString = _out1441;
            _2222_onOwned = _out1442;
            _2223_onErased = _out1443;
            _2224_recIdents = _out1444;
            if (!(_2223_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2225_eraseFn;
              _2225_eraseFn = ((_2222_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2221_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2225_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2221_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2217_isDatatype) || (_2218_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2221_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2219_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2218_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2221_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2219_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2224_recIdents;
          }
        } else if (_source75.is_NewArray) {
          Dafny.ISequence<DAST._IExpression> _2226___mcc_h50 = _source75.dtor_dims;
          bool _2227_isDatatype = _2175___mcc_h37;
          bool _2228_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2229_field = _2173___mcc_h35;
          DAST._IExpression _2230_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2231_onString;
            bool _2232_onOwned;
            bool _2233_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2234_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1445;
            bool _out1446;
            bool _out1447;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1448;
            DCOMP.COMP.GenExpr(_2230_on, selfIdent, @params, false, out _out1445, out _out1446, out _out1447, out _out1448);
            _2231_onString = _out1445;
            _2232_onOwned = _out1446;
            _2233_onErased = _out1447;
            _2234_recIdents = _out1448;
            if (!(_2233_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2235_eraseFn;
              _2235_eraseFn = ((_2232_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2231_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2235_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2231_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2227_isDatatype) || (_2228_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2231_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2229_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2231_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2229_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2234_recIdents;
          }
        } else if (_source75.is_DatatypeValue) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2236___mcc_h52 = _source75.dtor_path;
          Dafny.ISequence<Dafny.Rune> _2237___mcc_h53 = _source75.dtor_variant;
          bool _2238___mcc_h54 = _source75.dtor_isCo;
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2239___mcc_h55 = _source75.dtor_contents;
          bool _2240_isDatatype = _2175___mcc_h37;
          bool _2241_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2242_field = _2173___mcc_h35;
          DAST._IExpression _2243_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2244_onString;
            bool _2245_onOwned;
            bool _2246_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2247_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1449;
            bool _out1450;
            bool _out1451;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1452;
            DCOMP.COMP.GenExpr(_2243_on, selfIdent, @params, false, out _out1449, out _out1450, out _out1451, out _out1452);
            _2244_onString = _out1449;
            _2245_onOwned = _out1450;
            _2246_onErased = _out1451;
            _2247_recIdents = _out1452;
            if (!(_2246_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2248_eraseFn;
              _2248_eraseFn = ((_2245_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2244_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2248_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2244_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2240_isDatatype) || (_2241_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2244_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2242_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2241_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2244_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2242_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2247_recIdents;
          }
        } else if (_source75.is_Convert) {
          DAST._IExpression _2249___mcc_h60 = _source75.dtor_value;
          DAST._IType _2250___mcc_h61 = _source75.dtor_from;
          DAST._IType _2251___mcc_h62 = _source75.dtor_typ;
          bool _2252_isDatatype = _2175___mcc_h37;
          bool _2253_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2254_field = _2173___mcc_h35;
          DAST._IExpression _2255_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2256_onString;
            bool _2257_onOwned;
            bool _2258_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2259_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1453;
            bool _out1454;
            bool _out1455;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1456;
            DCOMP.COMP.GenExpr(_2255_on, selfIdent, @params, false, out _out1453, out _out1454, out _out1455, out _out1456);
            _2256_onString = _out1453;
            _2257_onOwned = _out1454;
            _2258_onErased = _out1455;
            _2259_recIdents = _out1456;
            if (!(_2258_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2260_eraseFn;
              _2260_eraseFn = ((_2257_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2256_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2260_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2256_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2252_isDatatype) || (_2253_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2256_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2254_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2253_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2256_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2254_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2259_recIdents;
          }
        } else if (_source75.is_SeqValue) {
          Dafny.ISequence<DAST._IExpression> _2261___mcc_h66 = _source75.dtor_elements;
          bool _2262_isDatatype = _2175___mcc_h37;
          bool _2263_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2264_field = _2173___mcc_h35;
          DAST._IExpression _2265_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2266_onString;
            bool _2267_onOwned;
            bool _2268_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2269_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1457;
            bool _out1458;
            bool _out1459;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1460;
            DCOMP.COMP.GenExpr(_2265_on, selfIdent, @params, false, out _out1457, out _out1458, out _out1459, out _out1460);
            _2266_onString = _out1457;
            _2267_onOwned = _out1458;
            _2268_onErased = _out1459;
            _2269_recIdents = _out1460;
            if (!(_2268_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2270_eraseFn;
              _2270_eraseFn = ((_2267_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2266_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2270_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2266_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2262_isDatatype) || (_2263_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2266_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2264_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2263_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2266_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2264_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2269_recIdents;
          }
        } else if (_source75.is_SetValue) {
          Dafny.ISequence<DAST._IExpression> _2271___mcc_h68 = _source75.dtor_elements;
          bool _2272_isDatatype = _2175___mcc_h37;
          bool _2273_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2274_field = _2173___mcc_h35;
          DAST._IExpression _2275_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2276_onString;
            bool _2277_onOwned;
            bool _2278_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2279_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1461;
            bool _out1462;
            bool _out1463;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1464;
            DCOMP.COMP.GenExpr(_2275_on, selfIdent, @params, false, out _out1461, out _out1462, out _out1463, out _out1464);
            _2276_onString = _out1461;
            _2277_onOwned = _out1462;
            _2278_onErased = _out1463;
            _2279_recIdents = _out1464;
            if (!(_2278_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2280_eraseFn;
              _2280_eraseFn = ((_2277_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2276_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2280_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2276_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2272_isDatatype) || (_2273_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2276_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2274_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2273_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2276_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2274_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2279_recIdents;
          }
        } else if (_source75.is_MapValue) {
          Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2281___mcc_h70 = _source75.dtor_mapElems;
          bool _2282_isDatatype = _2175___mcc_h37;
          bool _2283_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2284_field = _2173___mcc_h35;
          DAST._IExpression _2285_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2286_onString;
            bool _2287_onOwned;
            bool _2288_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2289_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1465;
            bool _out1466;
            bool _out1467;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1468;
            DCOMP.COMP.GenExpr(_2285_on, selfIdent, @params, false, out _out1465, out _out1466, out _out1467, out _out1468);
            _2286_onString = _out1465;
            _2287_onOwned = _out1466;
            _2288_onErased = _out1467;
            _2289_recIdents = _out1468;
            if (!(_2288_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2290_eraseFn;
              _2290_eraseFn = ((_2287_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2286_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2290_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2286_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2282_isDatatype) || (_2283_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2286_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2284_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2283_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2286_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2284_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2289_recIdents;
          }
        } else if (_source75.is_This) {
          bool _2291_isDatatype = _2175___mcc_h37;
          bool _2292_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2293_field = _2173___mcc_h35;
          DAST._IExpression _2294_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2295_onString;
            bool _2296_onOwned;
            bool _2297_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2298_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1469;
            bool _out1470;
            bool _out1471;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1472;
            DCOMP.COMP.GenExpr(_2294_on, selfIdent, @params, false, out _out1469, out _out1470, out _out1471, out _out1472);
            _2295_onString = _out1469;
            _2296_onOwned = _out1470;
            _2297_onErased = _out1471;
            _2298_recIdents = _out1472;
            if (!(_2297_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2299_eraseFn;
              _2299_eraseFn = ((_2296_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2295_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2299_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2295_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2291_isDatatype) || (_2292_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2295_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2293_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2292_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2295_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2293_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2298_recIdents;
          }
        } else if (_source75.is_Ite) {
          DAST._IExpression _2300___mcc_h72 = _source75.dtor_cond;
          DAST._IExpression _2301___mcc_h73 = _source75.dtor_thn;
          DAST._IExpression _2302___mcc_h74 = _source75.dtor_els;
          bool _2303_isDatatype = _2175___mcc_h37;
          bool _2304_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2305_field = _2173___mcc_h35;
          DAST._IExpression _2306_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2307_onString;
            bool _2308_onOwned;
            bool _2309_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2310_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1473;
            bool _out1474;
            bool _out1475;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1476;
            DCOMP.COMP.GenExpr(_2306_on, selfIdent, @params, false, out _out1473, out _out1474, out _out1475, out _out1476);
            _2307_onString = _out1473;
            _2308_onOwned = _out1474;
            _2309_onErased = _out1475;
            _2310_recIdents = _out1476;
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
        } else if (_source75.is_UnOp) {
          DAST._IUnaryOp _2312___mcc_h78 = _source75.dtor_unOp;
          DAST._IExpression _2313___mcc_h79 = _source75.dtor_expr;
          bool _2314_isDatatype = _2175___mcc_h37;
          bool _2315_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2316_field = _2173___mcc_h35;
          DAST._IExpression _2317_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2318_onString;
            bool _2319_onOwned;
            bool _2320_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2321_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1477;
            bool _out1478;
            bool _out1479;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1480;
            DCOMP.COMP.GenExpr(_2317_on, selfIdent, @params, false, out _out1477, out _out1478, out _out1479, out _out1480);
            _2318_onString = _out1477;
            _2319_onOwned = _out1478;
            _2320_onErased = _out1479;
            _2321_recIdents = _out1480;
            if (!(_2320_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2322_eraseFn;
              _2322_eraseFn = ((_2319_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2318_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2322_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2318_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2314_isDatatype) || (_2315_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2318_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2316_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2315_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2318_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2316_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2321_recIdents;
          }
        } else if (_source75.is_BinOp) {
          Dafny.ISequence<Dafny.Rune> _2323___mcc_h82 = _source75.dtor_op;
          DAST._IExpression _2324___mcc_h83 = _source75.dtor_left;
          DAST._IExpression _2325___mcc_h84 = _source75.dtor_right;
          bool _2326_isDatatype = _2175___mcc_h37;
          bool _2327_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2328_field = _2173___mcc_h35;
          DAST._IExpression _2329_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2330_onString;
            bool _2331_onOwned;
            bool _2332_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2333_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1481;
            bool _out1482;
            bool _out1483;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1484;
            DCOMP.COMP.GenExpr(_2329_on, selfIdent, @params, false, out _out1481, out _out1482, out _out1483, out _out1484);
            _2330_onString = _out1481;
            _2331_onOwned = _out1482;
            _2332_onErased = _out1483;
            _2333_recIdents = _out1484;
            if (!(_2332_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2334_eraseFn;
              _2334_eraseFn = ((_2331_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2330_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2334_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2330_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2326_isDatatype) || (_2327_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2330_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2328_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2327_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2330_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2328_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2333_recIdents;
          }
        } else if (_source75.is_ArrayLen) {
          DAST._IExpression _2335___mcc_h88 = _source75.dtor_expr;
          bool _2336_isDatatype = _2175___mcc_h37;
          bool _2337_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2338_field = _2173___mcc_h35;
          DAST._IExpression _2339_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2340_onString;
            bool _2341_onOwned;
            bool _2342_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2343_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1485;
            bool _out1486;
            bool _out1487;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1488;
            DCOMP.COMP.GenExpr(_2339_on, selfIdent, @params, false, out _out1485, out _out1486, out _out1487, out _out1488);
            _2340_onString = _out1485;
            _2341_onOwned = _out1486;
            _2342_onErased = _out1487;
            _2343_recIdents = _out1488;
            if (!(_2342_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2344_eraseFn;
              _2344_eraseFn = ((_2341_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2340_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2344_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2340_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2336_isDatatype) || (_2337_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2340_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2338_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2337_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2340_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2338_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2343_recIdents;
          }
        } else if (_source75.is_Select) {
          DAST._IExpression _2345___mcc_h90 = _source75.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2346___mcc_h91 = _source75.dtor_field;
          bool _2347___mcc_h92 = _source75.dtor_isConstant;
          bool _2348___mcc_h93 = _source75.dtor_onDatatype;
          bool _2349_isDatatype = _2175___mcc_h37;
          bool _2350_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2351_field = _2173___mcc_h35;
          DAST._IExpression _2352_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2353_onString;
            bool _2354_onOwned;
            bool _2355_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2356_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1489;
            bool _out1490;
            bool _out1491;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1492;
            DCOMP.COMP.GenExpr(_2352_on, selfIdent, @params, false, out _out1489, out _out1490, out _out1491, out _out1492);
            _2353_onString = _out1489;
            _2354_onOwned = _out1490;
            _2355_onErased = _out1491;
            _2356_recIdents = _out1492;
            if (!(_2355_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2357_eraseFn;
              _2357_eraseFn = ((_2354_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2353_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2357_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2353_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2349_isDatatype) || (_2350_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2353_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2351_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2350_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2353_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2351_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2356_recIdents;
          }
        } else if (_source75.is_SelectFn) {
          DAST._IExpression _2358___mcc_h98 = _source75.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2359___mcc_h99 = _source75.dtor_field;
          bool _2360___mcc_h100 = _source75.dtor_onDatatype;
          bool _2361___mcc_h101 = _source75.dtor_isStatic;
          BigInteger _2362___mcc_h102 = _source75.dtor_arity;
          bool _2363_isDatatype = _2175___mcc_h37;
          bool _2364_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2365_field = _2173___mcc_h35;
          DAST._IExpression _2366_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2367_onString;
            bool _2368_onOwned;
            bool _2369_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2370_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1493;
            bool _out1494;
            bool _out1495;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1496;
            DCOMP.COMP.GenExpr(_2366_on, selfIdent, @params, false, out _out1493, out _out1494, out _out1495, out _out1496);
            _2367_onString = _out1493;
            _2368_onOwned = _out1494;
            _2369_onErased = _out1495;
            _2370_recIdents = _out1496;
            if (!(_2369_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2371_eraseFn;
              _2371_eraseFn = ((_2368_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2367_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2371_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2367_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2363_isDatatype) || (_2364_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2367_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2365_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2364_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2367_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2365_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2370_recIdents;
          }
        } else if (_source75.is_Index) {
          DAST._IExpression _2372___mcc_h108 = _source75.dtor_expr;
          DAST._ICollKind _2373___mcc_h109 = _source75.dtor_collKind;
          Dafny.ISequence<DAST._IExpression> _2374___mcc_h110 = _source75.dtor_indices;
          bool _2375_isDatatype = _2175___mcc_h37;
          bool _2376_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2377_field = _2173___mcc_h35;
          DAST._IExpression _2378_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2379_onString;
            bool _2380_onOwned;
            bool _2381_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2382_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1497;
            bool _out1498;
            bool _out1499;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1500;
            DCOMP.COMP.GenExpr(_2378_on, selfIdent, @params, false, out _out1497, out _out1498, out _out1499, out _out1500);
            _2379_onString = _out1497;
            _2380_onOwned = _out1498;
            _2381_onErased = _out1499;
            _2382_recIdents = _out1500;
            if (!(_2381_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2383_eraseFn;
              _2383_eraseFn = ((_2380_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2379_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2383_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2379_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2375_isDatatype) || (_2376_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2379_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2377_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2379_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2377_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2382_recIdents;
          }
        } else if (_source75.is_IndexRange) {
          DAST._IExpression _2384___mcc_h114 = _source75.dtor_expr;
          bool _2385___mcc_h115 = _source75.dtor_isArray;
          DAST._IOptional<DAST._IExpression> _2386___mcc_h116 = _source75.dtor_low;
          DAST._IOptional<DAST._IExpression> _2387___mcc_h117 = _source75.dtor_high;
          bool _2388_isDatatype = _2175___mcc_h37;
          bool _2389_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2390_field = _2173___mcc_h35;
          DAST._IExpression _2391_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2392_onString;
            bool _2393_onOwned;
            bool _2394_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2395_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1501;
            bool _out1502;
            bool _out1503;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1504;
            DCOMP.COMP.GenExpr(_2391_on, selfIdent, @params, false, out _out1501, out _out1502, out _out1503, out _out1504);
            _2392_onString = _out1501;
            _2393_onOwned = _out1502;
            _2394_onErased = _out1503;
            _2395_recIdents = _out1504;
            if (!(_2394_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2396_eraseFn;
              _2396_eraseFn = ((_2393_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2392_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2396_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2392_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2388_isDatatype) || (_2389_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2392_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2390_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2389_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2392_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2390_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2395_recIdents;
          }
        } else if (_source75.is_TupleSelect) {
          DAST._IExpression _2397___mcc_h122 = _source75.dtor_expr;
          BigInteger _2398___mcc_h123 = _source75.dtor_index;
          bool _2399_isDatatype = _2175___mcc_h37;
          bool _2400_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2401_field = _2173___mcc_h35;
          DAST._IExpression _2402_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2403_onString;
            bool _2404_onOwned;
            bool _2405_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2406_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1505;
            bool _out1506;
            bool _out1507;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1508;
            DCOMP.COMP.GenExpr(_2402_on, selfIdent, @params, false, out _out1505, out _out1506, out _out1507, out _out1508);
            _2403_onString = _out1505;
            _2404_onOwned = _out1506;
            _2405_onErased = _out1507;
            _2406_recIdents = _out1508;
            if (!(_2405_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2407_eraseFn;
              _2407_eraseFn = ((_2404_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2403_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2407_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2403_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2399_isDatatype) || (_2400_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2403_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2401_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2400_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2403_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2401_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2406_recIdents;
          }
        } else if (_source75.is_Call) {
          DAST._IExpression _2408___mcc_h126 = _source75.dtor_on;
          Dafny.ISequence<Dafny.Rune> _2409___mcc_h127 = _source75.dtor_name;
          Dafny.ISequence<DAST._IType> _2410___mcc_h128 = _source75.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _2411___mcc_h129 = _source75.dtor_args;
          bool _2412_isDatatype = _2175___mcc_h37;
          bool _2413_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2414_field = _2173___mcc_h35;
          DAST._IExpression _2415_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2416_onString;
            bool _2417_onOwned;
            bool _2418_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2419_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1509;
            bool _out1510;
            bool _out1511;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1512;
            DCOMP.COMP.GenExpr(_2415_on, selfIdent, @params, false, out _out1509, out _out1510, out _out1511, out _out1512);
            _2416_onString = _out1509;
            _2417_onOwned = _out1510;
            _2418_onErased = _out1511;
            _2419_recIdents = _out1512;
            if (!(_2418_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2420_eraseFn;
              _2420_eraseFn = ((_2417_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2416_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2420_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2416_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2412_isDatatype) || (_2413_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2416_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2414_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2413_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2416_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2414_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2419_recIdents;
          }
        } else if (_source75.is_Lambda) {
          Dafny.ISequence<DAST._IFormal> _2421___mcc_h134 = _source75.dtor_params;
          DAST._IType _2422___mcc_h135 = _source75.dtor_retType;
          Dafny.ISequence<DAST._IStatement> _2423___mcc_h136 = _source75.dtor_body;
          bool _2424_isDatatype = _2175___mcc_h37;
          bool _2425_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2426_field = _2173___mcc_h35;
          DAST._IExpression _2427_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2428_onString;
            bool _2429_onOwned;
            bool _2430_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2431_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1513;
            bool _out1514;
            bool _out1515;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1516;
            DCOMP.COMP.GenExpr(_2427_on, selfIdent, @params, false, out _out1513, out _out1514, out _out1515, out _out1516);
            _2428_onString = _out1513;
            _2429_onOwned = _out1514;
            _2430_onErased = _out1515;
            _2431_recIdents = _out1516;
            if (!(_2430_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2432_eraseFn;
              _2432_eraseFn = ((_2429_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2428_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2432_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2428_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2424_isDatatype) || (_2425_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2428_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2426_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2425_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2428_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2426_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2431_recIdents;
          }
        } else if (_source75.is_BetaRedex) {
          Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2433___mcc_h140 = _source75.dtor_values;
          DAST._IType _2434___mcc_h141 = _source75.dtor_retType;
          DAST._IExpression _2435___mcc_h142 = _source75.dtor_expr;
          bool _2436_isDatatype = _2175___mcc_h37;
          bool _2437_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2438_field = _2173___mcc_h35;
          DAST._IExpression _2439_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2440_onString;
            bool _2441_onOwned;
            bool _2442_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2443_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1517;
            bool _out1518;
            bool _out1519;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1520;
            DCOMP.COMP.GenExpr(_2439_on, selfIdent, @params, false, out _out1517, out _out1518, out _out1519, out _out1520);
            _2440_onString = _out1517;
            _2441_onOwned = _out1518;
            _2442_onErased = _out1519;
            _2443_recIdents = _out1520;
            if (!(_2442_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2444_eraseFn;
              _2444_eraseFn = ((_2441_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2440_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2444_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2440_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2436_isDatatype) || (_2437_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2440_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2438_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2437_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2440_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2438_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2443_recIdents;
          }
        } else if (_source75.is_IIFE) {
          Dafny.ISequence<Dafny.Rune> _2445___mcc_h146 = _source75.dtor_name;
          DAST._IType _2446___mcc_h147 = _source75.dtor_typ;
          DAST._IExpression _2447___mcc_h148 = _source75.dtor_value;
          DAST._IExpression _2448___mcc_h149 = _source75.dtor_iifeBody;
          bool _2449_isDatatype = _2175___mcc_h37;
          bool _2450_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2451_field = _2173___mcc_h35;
          DAST._IExpression _2452_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2453_onString;
            bool _2454_onOwned;
            bool _2455_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2456_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1521;
            bool _out1522;
            bool _out1523;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1524;
            DCOMP.COMP.GenExpr(_2452_on, selfIdent, @params, false, out _out1521, out _out1522, out _out1523, out _out1524);
            _2453_onString = _out1521;
            _2454_onOwned = _out1522;
            _2455_onErased = _out1523;
            _2456_recIdents = _out1524;
            if (!(_2455_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2457_eraseFn;
              _2457_eraseFn = ((_2454_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2453_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2457_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2453_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2449_isDatatype) || (_2450_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2453_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2451_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2450_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2453_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2451_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2456_recIdents;
          }
        } else if (_source75.is_Apply) {
          DAST._IExpression _2458___mcc_h154 = _source75.dtor_expr;
          Dafny.ISequence<DAST._IExpression> _2459___mcc_h155 = _source75.dtor_args;
          bool _2460_isDatatype = _2175___mcc_h37;
          bool _2461_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2462_field = _2173___mcc_h35;
          DAST._IExpression _2463_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2464_onString;
            bool _2465_onOwned;
            bool _2466_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2467_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1525;
            bool _out1526;
            bool _out1527;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1528;
            DCOMP.COMP.GenExpr(_2463_on, selfIdent, @params, false, out _out1525, out _out1526, out _out1527, out _out1528);
            _2464_onString = _out1525;
            _2465_onOwned = _out1526;
            _2466_onErased = _out1527;
            _2467_recIdents = _out1528;
            if (!(_2466_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2468_eraseFn;
              _2468_eraseFn = ((_2465_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2464_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2468_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2464_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2460_isDatatype) || (_2461_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2464_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2462_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2461_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2464_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2462_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2467_recIdents;
          }
        } else if (_source75.is_TypeTest) {
          DAST._IExpression _2469___mcc_h158 = _source75.dtor_on;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2470___mcc_h159 = _source75.dtor_dType;
          Dafny.ISequence<Dafny.Rune> _2471___mcc_h160 = _source75.dtor_variant;
          bool _2472_isDatatype = _2175___mcc_h37;
          bool _2473_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2474_field = _2173___mcc_h35;
          DAST._IExpression _2475_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2476_onString;
            bool _2477_onOwned;
            bool _2478_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2479_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1529;
            bool _out1530;
            bool _out1531;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1532;
            DCOMP.COMP.GenExpr(_2475_on, selfIdent, @params, false, out _out1529, out _out1530, out _out1531, out _out1532);
            _2476_onString = _out1529;
            _2477_onOwned = _out1530;
            _2478_onErased = _out1531;
            _2479_recIdents = _out1532;
            if (!(_2478_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2480_eraseFn;
              _2480_eraseFn = ((_2477_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2476_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2480_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2476_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2472_isDatatype) || (_2473_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2476_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2474_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2473_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2476_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2474_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2479_recIdents;
          }
        } else {
          DAST._IType _2481___mcc_h164 = _source75.dtor_typ;
          bool _2482_isDatatype = _2175___mcc_h37;
          bool _2483_isConstant = _2174___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2484_field = _2173___mcc_h35;
          DAST._IExpression _2485_on = _2172___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2486_onString;
            bool _2487_onOwned;
            bool _2488_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2489_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1533;
            bool _out1534;
            bool _out1535;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1536;
            DCOMP.COMP.GenExpr(_2485_on, selfIdent, @params, false, out _out1533, out _out1534, out _out1535, out _out1536);
            _2486_onString = _out1533;
            _2487_onOwned = _out1534;
            _2488_onErased = _out1535;
            _2489_recIdents = _out1536;
            if (!(_2488_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2490_eraseFn;
              _2490_eraseFn = ((_2487_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2486_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2490_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2486_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2482_isDatatype) || (_2483_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2486_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2484_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2483_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2486_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2484_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2489_recIdents;
          }
        }
      } else if (_source23.is_SelectFn) {
        DAST._IExpression _2491___mcc_h166 = _source23.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2492___mcc_h167 = _source23.dtor_field;
        bool _2493___mcc_h168 = _source23.dtor_onDatatype;
        bool _2494___mcc_h169 = _source23.dtor_isStatic;
        BigInteger _2495___mcc_h170 = _source23.dtor_arity;
        BigInteger _2496_arity = _2495___mcc_h170;
        bool _2497_isStatic = _2494___mcc_h169;
        bool _2498_isDatatype = _2493___mcc_h168;
        Dafny.ISequence<Dafny.Rune> _2499_field = _2492___mcc_h167;
        DAST._IExpression _2500_on = _2491___mcc_h166;
        {
          Dafny.ISequence<Dafny.Rune> _2501_onString;
          bool _2502_onOwned;
          bool _2503___v81;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2504_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1537;
          bool _out1538;
          bool _out1539;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1540;
          DCOMP.COMP.GenExpr(_2500_on, selfIdent, @params, false, out _out1537, out _out1538, out _out1539, out _out1540);
          _2501_onString = _out1537;
          _2502_onOwned = _out1538;
          _2503___v81 = _out1539;
          _2504_recIdents = _out1540;
          if (_2497_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2501_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2499_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2501_onString), ((_2502_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2505_args;
            _2505_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2506_i;
            _2506_i = BigInteger.Zero;
            while ((_2506_i) < (_2496_arity)) {
              if ((_2506_i).Sign == 1) {
                _2505_args = Dafny.Sequence<Dafny.Rune>.Concat(_2505_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2505_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2505_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2506_i));
              _2506_i = (_2506_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2505_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2499_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2505_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper(::std::rc::Rc::new("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
          readIdents = _2504_recIdents;
        }
      } else if (_source23.is_Index) {
        DAST._IExpression _2507___mcc_h171 = _source23.dtor_expr;
        DAST._ICollKind _2508___mcc_h172 = _source23.dtor_collKind;
        Dafny.ISequence<DAST._IExpression> _2509___mcc_h173 = _source23.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _2510_indices = _2509___mcc_h173;
        DAST._ICollKind _2511_collKind = _2508___mcc_h172;
        DAST._IExpression _2512_on = _2507___mcc_h171;
        {
          Dafny.ISequence<Dafny.Rune> _2513_onString;
          bool _2514_onOwned;
          bool _2515_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2516_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1541;
          bool _out1542;
          bool _out1543;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1544;
          DCOMP.COMP.GenExpr(_2512_on, selfIdent, @params, false, out _out1541, out _out1542, out _out1543, out _out1544);
          _2513_onString = _out1541;
          _2514_onOwned = _out1542;
          _2515_onErased = _out1543;
          _2516_recIdents = _out1544;
          readIdents = _2516_recIdents;
          if (!(_2515_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2517_eraseFn;
            _2517_eraseFn = ((_2514_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2513_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2517_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2513_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2513_onString;
          BigInteger _2518_i;
          _2518_i = BigInteger.Zero;
          while ((_2518_i) < (new BigInteger((_2510_indices).Count))) {
            if (object.Equals(_2511_collKind, DAST.CollKind.create_Array())) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
            }
            if (object.Equals(_2511_collKind, DAST.CollKind.create_Map())) {
              Dafny.ISequence<Dafny.Rune> _2519_idx;
              bool _2520_idxOwned;
              bool _2521_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2522_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1545;
              bool _out1546;
              bool _out1547;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1548;
              DCOMP.COMP.GenExpr((_2510_indices).Select(_2518_i), selfIdent, @params, false, out _out1545, out _out1546, out _out1547, out _out1548);
              _2519_idx = _out1545;
              _2520_idxOwned = _out1546;
              _2521_idxErased = _out1547;
              _2522_recIdentsIdx = _out1548;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[")), ((_2520_idxOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _2519_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2522_recIdentsIdx);
            } else {
              Dafny.ISequence<Dafny.Rune> _2523_idx;
              bool _2524___v82;
              bool _2525_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2526_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1549;
              bool _out1550;
              bool _out1551;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1552;
              DCOMP.COMP.GenExpr((_2510_indices).Select(_2518_i), selfIdent, @params, true, out _out1549, out _out1550, out _out1551, out _out1552);
              _2523_idx = _out1549;
              _2524___v82 = _out1550;
              _2525_idxErased = _out1551;
              _2526_recIdentsIdx = _out1552;
              if (!(_2525_idxErased)) {
                _2523_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2523_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[<usize as ::dafny_runtime::NumCast>::from(")), _2523_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2526_recIdentsIdx);
            }
            _2518_i = (_2518_i) + (BigInteger.One);
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = _2515_onErased;
        }
      } else if (_source23.is_IndexRange) {
        DAST._IExpression _2527___mcc_h174 = _source23.dtor_expr;
        bool _2528___mcc_h175 = _source23.dtor_isArray;
        DAST._IOptional<DAST._IExpression> _2529___mcc_h176 = _source23.dtor_low;
        DAST._IOptional<DAST._IExpression> _2530___mcc_h177 = _source23.dtor_high;
        DAST._IOptional<DAST._IExpression> _2531_high = _2530___mcc_h177;
        DAST._IOptional<DAST._IExpression> _2532_low = _2529___mcc_h176;
        bool _2533_isArray = _2528___mcc_h175;
        DAST._IExpression _2534_on = _2527___mcc_h174;
        {
          Dafny.ISequence<Dafny.Rune> _2535_onString;
          bool _2536_onOwned;
          bool _2537_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2538_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1553;
          bool _out1554;
          bool _out1555;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1556;
          DCOMP.COMP.GenExpr(_2534_on, selfIdent, @params, false, out _out1553, out _out1554, out _out1555, out _out1556);
          _2535_onString = _out1553;
          _2536_onOwned = _out1554;
          _2537_onErased = _out1555;
          _2538_recIdents = _out1556;
          readIdents = _2538_recIdents;
          if (!(_2537_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2539_eraseFn;
            _2539_eraseFn = ((_2536_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2535_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2539_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2535_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2535_onString;
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2540_lowString;
          _2540_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source76 = _2532_low;
          if (_source76.is_Some) {
            DAST._IExpression _2541___mcc_h1067 = _source76.dtor_Some_a0;
            DAST._IExpression _2542_l = _2541___mcc_h1067;
            {
              Dafny.ISequence<Dafny.Rune> _2543_lString;
              bool _2544___v83;
              bool _2545_lErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2546_recIdentsL;
              Dafny.ISequence<Dafny.Rune> _out1557;
              bool _out1558;
              bool _out1559;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1560;
              DCOMP.COMP.GenExpr(_2542_l, selfIdent, @params, true, out _out1557, out _out1558, out _out1559, out _out1560);
              _2543_lString = _out1557;
              _2544___v83 = _out1558;
              _2545_lErased = _out1559;
              _2546_recIdentsL = _out1560;
              if (!(_2545_lErased)) {
                _2543_lString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2543_lString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2540_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2543_lString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2546_recIdentsL);
            }
          } else {
          }
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2547_highString;
          _2547_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source77 = _2531_high;
          if (_source77.is_Some) {
            DAST._IExpression _2548___mcc_h1068 = _source77.dtor_Some_a0;
            DAST._IExpression _2549_h = _2548___mcc_h1068;
            {
              Dafny.ISequence<Dafny.Rune> _2550_hString;
              bool _2551___v84;
              bool _2552_hErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2553_recIdentsH;
              Dafny.ISequence<Dafny.Rune> _out1561;
              bool _out1562;
              bool _out1563;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1564;
              DCOMP.COMP.GenExpr(_2549_h, selfIdent, @params, true, out _out1561, out _out1562, out _out1563, out _out1564);
              _2550_hString = _out1561;
              _2551___v84 = _out1562;
              _2552_hErased = _out1563;
              _2553_recIdentsH = _out1564;
              if (!(_2552_hErased)) {
                _2550_hString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2550_hString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2547_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2550_hString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2553_recIdentsH);
            }
          } else {
          }
          if (_2533_isArray) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source78) => {
            if (_source78.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2554___mcc_h1069 = _source78.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2554___mcc_h1069, _pat_let0_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let0_0, _2555_l => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2555_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2540_lowString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("..")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source79) => {
            if (_source79.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2556___mcc_h1070 = _source79.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2556___mcc_h1070, _pat_let1_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let1_0, _2557_h => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2557_h), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2547_highString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isErased = _2537_onErased;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".to_vec())"));
          isOwned = true;
        }
      } else if (_source23.is_TupleSelect) {
        DAST._IExpression _2558___mcc_h178 = _source23.dtor_expr;
        BigInteger _2559___mcc_h179 = _source23.dtor_index;
        BigInteger _2560_idx = _2559___mcc_h179;
        DAST._IExpression _2561_on = _2558___mcc_h178;
        {
          Dafny.ISequence<Dafny.Rune> _2562_onString;
          bool _2563___v85;
          bool _2564_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2565_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1565;
          bool _out1566;
          bool _out1567;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1568;
          DCOMP.COMP.GenExpr(_2561_on, selfIdent, @params, false, out _out1565, out _out1566, out _out1567, out _out1568);
          _2562_onString = _out1565;
          _2563___v85 = _out1566;
          _2564_tupErased = _out1567;
          _2565_recIdents = _out1568;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2560_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2564_tupErased;
          readIdents = _2565_recIdents;
        }
      } else if (_source23.is_Call) {
        DAST._IExpression _2566___mcc_h180 = _source23.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2567___mcc_h181 = _source23.dtor_name;
        Dafny.ISequence<DAST._IType> _2568___mcc_h182 = _source23.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2569___mcc_h183 = _source23.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2570_args = _2569___mcc_h183;
        Dafny.ISequence<DAST._IType> _2571_typeArgs = _2568___mcc_h182;
        Dafny.ISequence<Dafny.Rune> _2572_name = _2567___mcc_h181;
        DAST._IExpression _2573_on = _2566___mcc_h180;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2574_typeArgString;
          _2574_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2571_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2575_typeI;
            _2575_typeI = BigInteger.Zero;
            _2574_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2575_typeI) < (new BigInteger((_2571_typeArgs).Count))) {
              if ((_2575_typeI).Sign == 1) {
                _2574_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2574_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2576_typeString;
              Dafny.ISequence<Dafny.Rune> _out1569;
              _out1569 = DCOMP.COMP.GenType((_2571_typeArgs).Select(_2575_typeI), false, false);
              _2576_typeString = _out1569;
              _2574_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2574_typeArgString, _2576_typeString);
              _2575_typeI = (_2575_typeI) + (BigInteger.One);
            }
            _2574_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2574_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2577_argString;
          _2577_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2578_i;
          _2578_i = BigInteger.Zero;
          while ((_2578_i) < (new BigInteger((_2570_args).Count))) {
            if ((_2578_i).Sign == 1) {
              _2577_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2577_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2579_argExpr;
            bool _2580_isOwned;
            bool _2581_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2582_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1570;
            bool _out1571;
            bool _out1572;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1573;
            DCOMP.COMP.GenExpr((_2570_args).Select(_2578_i), selfIdent, @params, false, out _out1570, out _out1571, out _out1572, out _out1573);
            _2579_argExpr = _out1570;
            _2580_isOwned = _out1571;
            _2581_argErased = _out1572;
            _2582_argIdents = _out1573;
            if (_2580_isOwned) {
              _2579_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2579_argExpr);
            }
            _2577_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2577_argString, _2579_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2582_argIdents);
            _2578_i = (_2578_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2583_enclosingString;
          bool _2584___v86;
          bool _2585___v87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2586_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1574;
          bool _out1575;
          bool _out1576;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1577;
          DCOMP.COMP.GenExpr(_2573_on, selfIdent, @params, false, out _out1574, out _out1575, out _out1576, out _out1577);
          _2583_enclosingString = _out1574;
          _2584___v86 = _out1575;
          _2585___v87 = _out1576;
          _2586_recIdents = _out1577;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2586_recIdents);
          DAST._IExpression _source80 = _2573_on;
          if (_source80.is_Literal) {
            DAST._ILiteral _2587___mcc_h1071 = _source80.dtor_Literal_a0;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2588___mcc_h1073 = _source80.dtor_Ident_a0;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2589___mcc_h1075 = _source80.dtor_Companion_a0;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2583_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (_2572_name));
            }
          } else if (_source80.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2590___mcc_h1077 = _source80.dtor_Tuple_a0;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2591___mcc_h1079 = _source80.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2592___mcc_h1080 = _source80.dtor_args;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2593___mcc_h1083 = _source80.dtor_dims;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2594___mcc_h1085 = _source80.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2595___mcc_h1086 = _source80.dtor_variant;
            bool _2596___mcc_h1087 = _source80.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2597___mcc_h1088 = _source80.dtor_contents;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_Convert) {
            DAST._IExpression _2598___mcc_h1093 = _source80.dtor_value;
            DAST._IType _2599___mcc_h1094 = _source80.dtor_from;
            DAST._IType _2600___mcc_h1095 = _source80.dtor_typ;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2601___mcc_h1099 = _source80.dtor_elements;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2602___mcc_h1101 = _source80.dtor_elements;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2603___mcc_h1103 = _source80.dtor_mapElems;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_This) {
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_Ite) {
            DAST._IExpression _2604___mcc_h1105 = _source80.dtor_cond;
            DAST._IExpression _2605___mcc_h1106 = _source80.dtor_thn;
            DAST._IExpression _2606___mcc_h1107 = _source80.dtor_els;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_UnOp) {
            DAST._IUnaryOp _2607___mcc_h1111 = _source80.dtor_unOp;
            DAST._IExpression _2608___mcc_h1112 = _source80.dtor_expr;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2609___mcc_h1115 = _source80.dtor_op;
            DAST._IExpression _2610___mcc_h1116 = _source80.dtor_left;
            DAST._IExpression _2611___mcc_h1117 = _source80.dtor_right;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_ArrayLen) {
            DAST._IExpression _2612___mcc_h1121 = _source80.dtor_expr;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_Select) {
            DAST._IExpression _2613___mcc_h1123 = _source80.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2614___mcc_h1124 = _source80.dtor_field;
            bool _2615___mcc_h1125 = _source80.dtor_isConstant;
            bool _2616___mcc_h1126 = _source80.dtor_onDatatype;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_SelectFn) {
            DAST._IExpression _2617___mcc_h1131 = _source80.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2618___mcc_h1132 = _source80.dtor_field;
            bool _2619___mcc_h1133 = _source80.dtor_onDatatype;
            bool _2620___mcc_h1134 = _source80.dtor_isStatic;
            BigInteger _2621___mcc_h1135 = _source80.dtor_arity;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_Index) {
            DAST._IExpression _2622___mcc_h1141 = _source80.dtor_expr;
            DAST._ICollKind _2623___mcc_h1142 = _source80.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _2624___mcc_h1143 = _source80.dtor_indices;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_IndexRange) {
            DAST._IExpression _2625___mcc_h1147 = _source80.dtor_expr;
            bool _2626___mcc_h1148 = _source80.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _2627___mcc_h1149 = _source80.dtor_low;
            DAST._IOptional<DAST._IExpression> _2628___mcc_h1150 = _source80.dtor_high;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_TupleSelect) {
            DAST._IExpression _2629___mcc_h1155 = _source80.dtor_expr;
            BigInteger _2630___mcc_h1156 = _source80.dtor_index;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_Call) {
            DAST._IExpression _2631___mcc_h1159 = _source80.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2632___mcc_h1160 = _source80.dtor_name;
            Dafny.ISequence<DAST._IType> _2633___mcc_h1161 = _source80.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2634___mcc_h1162 = _source80.dtor_args;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2635___mcc_h1167 = _source80.dtor_params;
            DAST._IType _2636___mcc_h1168 = _source80.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2637___mcc_h1169 = _source80.dtor_body;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2638___mcc_h1173 = _source80.dtor_values;
            DAST._IType _2639___mcc_h1174 = _source80.dtor_retType;
            DAST._IExpression _2640___mcc_h1175 = _source80.dtor_expr;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2641___mcc_h1179 = _source80.dtor_name;
            DAST._IType _2642___mcc_h1180 = _source80.dtor_typ;
            DAST._IExpression _2643___mcc_h1181 = _source80.dtor_value;
            DAST._IExpression _2644___mcc_h1182 = _source80.dtor_iifeBody;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_Apply) {
            DAST._IExpression _2645___mcc_h1187 = _source80.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2646___mcc_h1188 = _source80.dtor_args;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else if (_source80.is_TypeTest) {
            DAST._IExpression _2647___mcc_h1191 = _source80.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2648___mcc_h1192 = _source80.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2649___mcc_h1193 = _source80.dtor_variant;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          } else {
            DAST._IType _2650___mcc_h1197 = _source80.dtor_typ;
            {
              _2583_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2583_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2572_name));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2583_enclosingString, _2574_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2577_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source23.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2651___mcc_h184 = _source23.dtor_params;
        DAST._IType _2652___mcc_h185 = _source23.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2653___mcc_h186 = _source23.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2654_body = _2653___mcc_h186;
        DAST._IType _2655_retType = _2652___mcc_h185;
        Dafny.ISequence<DAST._IFormal> _2656_params = _2651___mcc_h184;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2657_paramNames;
          _2657_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2658_i;
          _2658_i = BigInteger.Zero;
          while ((_2658_i) < (new BigInteger((_2656_params).Count))) {
            _2657_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2657_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2656_params).Select(_2658_i)).dtor_name));
            _2658_i = (_2658_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2659_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2660_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1578;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1579;
          DCOMP.COMP.GenStmts(_2654_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2657_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1578, out _out1579);
          _2659_recursiveGen = _out1578;
          _2660_recIdents = _out1579;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2661_allReadCloned;
          _2661_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2660_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2662_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2660_recIdents).Elements) {
              _2662_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2660_recIdents).Contains(_2662_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1804)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2657_paramNames).Contains(_2662_next))) {
              _2661_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2661_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2662_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2662_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2662_next));
            }
            _2660_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2660_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2662_next));
          }
          Dafny.ISequence<Dafny.Rune> _2663_paramsString;
          _2663_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          Dafny.ISequence<Dafny.Rune> _2664_paramTypes;
          _2664_paramTypes = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2658_i = BigInteger.Zero;
          while ((_2658_i) < (new BigInteger((_2656_params).Count))) {
            if ((_2658_i).Sign == 1) {
              _2663_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2663_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              _2664_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(_2664_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2665_typStr;
            Dafny.ISequence<Dafny.Rune> _out1580;
            _out1580 = DCOMP.COMP.GenType(((_2656_params).Select(_2658_i)).dtor_typ, false, true);
            _2665_typStr = _out1580;
            _2663_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2663_paramsString, ((_2656_params).Select(_2658_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2665_typStr);
            _2664_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2664_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _2665_typStr);
            _2658_i = (_2658_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2666_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1581;
          _out1581 = DCOMP.COMP.GenType(_2655_retType, false, true);
          _2666_retTypeGen = _out1581;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper::<::std::rc::Rc<dyn Fn("), _2664_paramTypes), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _2666_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>({\n")), _2661_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(move |")), _2663_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2666_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2659_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source23.is_BetaRedex) {
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2667___mcc_h187 = _source23.dtor_values;
        DAST._IType _2668___mcc_h188 = _source23.dtor_retType;
        DAST._IExpression _2669___mcc_h189 = _source23.dtor_expr;
        DAST._IExpression _2670_expr = _2669___mcc_h189;
        DAST._IType _2671_retType = _2668___mcc_h188;
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2672_values = _2667___mcc_h187;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2673_paramNames;
          _2673_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2674_paramNamesSet;
          _2674_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2675_i;
          _2675_i = BigInteger.Zero;
          while ((_2675_i) < (new BigInteger((_2672_values).Count))) {
            _2673_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2673_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2672_values).Select(_2675_i)).dtor__0).dtor_name));
            _2674_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2674_paramNamesSet, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2672_values).Select(_2675_i)).dtor__0).dtor_name));
            _2675_i = (_2675_i) + (BigInteger.One);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          Dafny.ISequence<Dafny.Rune> _2676_paramsString;
          _2676_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2675_i = BigInteger.Zero;
          while ((_2675_i) < (new BigInteger((_2672_values).Count))) {
            if ((_2675_i).Sign == 1) {
              _2676_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2676_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2677_typStr;
            Dafny.ISequence<Dafny.Rune> _out1582;
            _out1582 = DCOMP.COMP.GenType((((_2672_values).Select(_2675_i)).dtor__0).dtor_typ, false, true);
            _2677_typStr = _out1582;
            Dafny.ISequence<Dafny.Rune> _2678_valueGen;
            bool _2679___v90;
            bool _2680_valueErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2681_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1583;
            bool _out1584;
            bool _out1585;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1586;
            DCOMP.COMP.GenExpr(((_2672_values).Select(_2675_i)).dtor__1, selfIdent, @params, true, out _out1583, out _out1584, out _out1585, out _out1586);
            _2678_valueGen = _out1583;
            _2679___v90 = _out1584;
            _2680_valueErased = _out1585;
            _2681_recIdents = _out1586;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), (((_2672_values).Select(_2675_i)).dtor__0).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _2677_typStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2681_recIdents);
            if (_2680_valueErased) {
              _2678_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2678_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2678_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            _2675_i = (_2675_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2682_recGen;
          bool _2683_recOwned;
          bool _2684_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2685_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1587;
          bool _out1588;
          bool _out1589;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1590;
          DCOMP.COMP.GenExpr(_2670_expr, selfIdent, _2673_paramNames, mustOwn, out _out1587, out _out1588, out _out1589, out _out1590);
          _2682_recGen = _out1587;
          _2683_recOwned = _out1588;
          _2684_recErased = _out1589;
          _2685_recIdents = _out1590;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2685_recIdents, _2674_paramNamesSet);
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2682_recGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2683_recOwned;
          isErased = _2684_recErased;
        }
      } else if (_source23.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2686___mcc_h190 = _source23.dtor_name;
        DAST._IType _2687___mcc_h191 = _source23.dtor_typ;
        DAST._IExpression _2688___mcc_h192 = _source23.dtor_value;
        DAST._IExpression _2689___mcc_h193 = _source23.dtor_iifeBody;
        DAST._IExpression _2690_iifeBody = _2689___mcc_h193;
        DAST._IExpression _2691_value = _2688___mcc_h192;
        DAST._IType _2692_tpe = _2687___mcc_h191;
        Dafny.ISequence<Dafny.Rune> _2693_name = _2686___mcc_h190;
        {
          Dafny.ISequence<Dafny.Rune> _2694_valueGen;
          bool _2695_valueOwned;
          bool _2696_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2697_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1591;
          bool _out1592;
          bool _out1593;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1594;
          DCOMP.COMP.GenExpr(_2691_value, selfIdent, @params, false, out _out1591, out _out1592, out _out1593, out _out1594);
          _2694_valueGen = _out1591;
          _2695_valueOwned = _out1592;
          _2696_valueErased = _out1593;
          _2697_recIdents = _out1594;
          if (_2696_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2698_eraseFn;
            _2698_eraseFn = ((_2695_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2694_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2698_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2694_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2697_recIdents;
          Dafny.ISequence<Dafny.Rune> _2699_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1595;
          _out1595 = DCOMP.COMP.GenType(_2692_tpe, false, true);
          _2699_valueTypeGen = _out1595;
          Dafny.ISequence<Dafny.Rune> _2700_bodyGen;
          bool _2701_bodyOwned;
          bool _2702_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2703_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1596;
          bool _out1597;
          bool _out1598;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1599;
          DCOMP.COMP.GenExpr(_2690_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2695_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2693_name))))), mustOwn, out _out1596, out _out1597, out _out1598, out _out1599);
          _2700_bodyGen = _out1596;
          _2701_bodyOwned = _out1597;
          _2702_bodyErased = _out1598;
          _2703_bodyIdents = _out1599;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2703_bodyIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_2693_name))));
          Dafny.ISequence<Dafny.Rune> _2704_eraseFn;
          _2704_eraseFn = ((_2695_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2693_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2695_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2699_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2694_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2700_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2701_bodyOwned;
          isErased = _2702_bodyErased;
        }
      } else if (_source23.is_Apply) {
        DAST._IExpression _2705___mcc_h194 = _source23.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2706___mcc_h195 = _source23.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2707_args = _2706___mcc_h195;
        DAST._IExpression _2708_func = _2705___mcc_h194;
        {
          Dafny.ISequence<Dafny.Rune> _2709_funcString;
          bool _2710___v91;
          bool _2711_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2712_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1600;
          bool _out1601;
          bool _out1602;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1603;
          DCOMP.COMP.GenExpr(_2708_func, selfIdent, @params, false, out _out1600, out _out1601, out _out1602, out _out1603);
          _2709_funcString = _out1600;
          _2710___v91 = _out1601;
          _2711_funcErased = _out1602;
          _2712_recIdents = _out1603;
          readIdents = _2712_recIdents;
          Dafny.ISequence<Dafny.Rune> _2713_argString;
          _2713_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2714_i;
          _2714_i = BigInteger.Zero;
          while ((_2714_i) < (new BigInteger((_2707_args).Count))) {
            if ((_2714_i).Sign == 1) {
              _2713_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2713_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2715_argExpr;
            bool _2716_isOwned;
            bool _2717_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2718_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1604;
            bool _out1605;
            bool _out1606;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1607;
            DCOMP.COMP.GenExpr((_2707_args).Select(_2714_i), selfIdent, @params, false, out _out1604, out _out1605, out _out1606, out _out1607);
            _2715_argExpr = _out1604;
            _2716_isOwned = _out1605;
            _2717_argErased = _out1606;
            _2718_argIdents = _out1607;
            if (_2716_isOwned) {
              _2715_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2715_argExpr);
            }
            _2713_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2713_argString, _2715_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2718_argIdents);
            _2714_i = (_2714_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2709_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2713_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source23.is_TypeTest) {
        DAST._IExpression _2719___mcc_h196 = _source23.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2720___mcc_h197 = _source23.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2721___mcc_h198 = _source23.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2722_variant = _2721___mcc_h198;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2723_dType = _2720___mcc_h197;
        DAST._IExpression _2724_on = _2719___mcc_h196;
        {
          Dafny.ISequence<Dafny.Rune> _2725_exprGen;
          bool _2726___v92;
          bool _2727_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2728_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1608;
          bool _out1609;
          bool _out1610;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1611;
          DCOMP.COMP.GenExpr(_2724_on, selfIdent, @params, false, out _out1608, out _out1609, out _out1610, out _out1611);
          _2725_exprGen = _out1608;
          _2726___v92 = _out1609;
          _2727_exprErased = _out1610;
          _2728_recIdents = _out1611;
          Dafny.ISequence<Dafny.Rune> _2729_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1612;
          _out1612 = DCOMP.COMP.GenPath(_2723_dType);
          _2729_dTypePath = _out1612;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2725_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2729_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2722_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2728_recIdents;
        }
      } else {
        DAST._IType _2730___mcc_h199 = _source23.dtor_typ;
        DAST._IType _2731_typ = _2730___mcc_h199;
        {
          Dafny.ISequence<Dafny.Rune> _2732_typString;
          Dafny.ISequence<Dafny.Rune> _out1613;
          _out1613 = DCOMP.COMP.GenType(_2731_typ, false, false);
          _2732_typString = _out1613;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2732_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2733_i;
      _2733_i = BigInteger.Zero;
      while ((_2733_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2734_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1614;
        _out1614 = DCOMP.COMP.GenModule((p).Select(_2733_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2734_generated = _out1614;
        if ((_2733_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2734_generated);
        _2733_i = (_2733_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2735_i;
      _2735_i = BigInteger.Zero;
      while ((_2735_i) < (new BigInteger((fullName).Count))) {
        if ((_2735_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2735_i));
        _2735_i = (_2735_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

