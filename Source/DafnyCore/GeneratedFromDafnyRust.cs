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
    DAST._IExpression dtor_on { get; }
    Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
    Dafny.ISequence<DAST._IExpression> dtor_args { get; }
    DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outs { get; }
    DAST._IExpression dtor_expr { get; }
    Dafny.ISequence<Dafny.Rune> dtor_toLabel { get; }
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
    public static _IStatement create_Call(DAST._IExpression @on, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outs) {
      return new Statement_Call(@on, name, typeArgs, args, outs);
    }
    public static _IStatement create_Return(DAST._IExpression expr) {
      return new Statement_Return(expr);
    }
    public static _IStatement create_EarlyReturn() {
      return new Statement_EarlyReturn();
    }
    public static _IStatement create_Break(Dafny.ISequence<Dafny.Rune> toLabel) {
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
        return ((Statement_While)d)._lbl;
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
    public Dafny.ISequence<Dafny.Rune> dtor_toLabel {
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
  public class Statement_Break : Statement {
    public readonly Dafny.ISequence<Dafny.Rune> _toLabel;
    public Statement_Break(Dafny.ISequence<Dafny.Rune> toLabel) : base() {
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
      hash = ((hash << 5) + hash) + 7;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._toLabel));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Break";
      s += "(";
      s += this._toLabel.ToVerbatimString(true);
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
      hash = ((hash << 5) + hash) + 8;
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
      hash = ((hash << 5) + hash) + 9;
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
      hash = ((hash << 5) + hash) + 10;
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
      hash = ((hash << 5) + hash) + 11;
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
    bool is_ArrayLen { get; }
    bool is_Select { get; }
    bool is_SelectFn { get; }
    bool is_Index { get; }
    bool is_IndexRange { get; }
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
    bool dtor_isArray { get; }
    Dafny.ISequence<DAST._IExpression> dtor_indices { get; }
    DAST._IOptional<DAST._IExpression> dtor_low { get; }
    DAST._IOptional<DAST._IExpression> dtor_high { get; }
    BigInteger dtor_index { get; }
    DAST._IExpression dtor_on { get; }
    DAST._IOptional<Dafny.ISequence<Dafny.Rune>> dtor_maybeName { get; }
    Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
    Dafny.ISequence<DAST._IFormal> dtor_params { get; }
    DAST._IType dtor_retType { get; }
    Dafny.ISequence<DAST._IStatement> dtor_body { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
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
    public static _IExpression create_ArrayLen(DAST._IExpression expr) {
      return new Expression_ArrayLen(expr);
    }
    public static _IExpression create_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool isConstant, bool onDatatype) {
      return new Expression_Select(expr, field, isConstant, onDatatype);
    }
    public static _IExpression create_SelectFn(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype, bool isStatic, BigInteger arity) {
      return new Expression_SelectFn(expr, field, onDatatype, isStatic, arity);
    }
    public static _IExpression create_Index(DAST._IExpression expr, bool isArray, Dafny.ISequence<DAST._IExpression> indices) {
      return new Expression_Index(expr, isArray, indices);
    }
    public static _IExpression create_IndexRange(DAST._IExpression expr, bool isArray, DAST._IOptional<DAST._IExpression> low, DAST._IOptional<DAST._IExpression> high) {
      return new Expression_IndexRange(expr, isArray, low, high);
    }
    public static _IExpression create_TupleSelect(DAST._IExpression expr, BigInteger index) {
      return new Expression_TupleSelect(expr, index);
    }
    public static _IExpression create_Call(DAST._IExpression @on, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> maybeName, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args) {
      return new Expression_Call(@on, maybeName, typeArgs, args);
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
    public bool is_ArrayLen { get { return this is Expression_ArrayLen; } }
    public bool is_Select { get { return this is Expression_Select; } }
    public bool is_SelectFn { get { return this is Expression_SelectFn; } }
    public bool is_Index { get { return this is Expression_Index; } }
    public bool is_IndexRange { get { return this is Expression_IndexRange; } }
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
        if (d is Expression_ArrayLen) { return ((Expression_ArrayLen)d)._expr; }
        if (d is Expression_Select) { return ((Expression_Select)d)._expr; }
        if (d is Expression_SelectFn) { return ((Expression_SelectFn)d)._expr; }
        if (d is Expression_Index) { return ((Expression_Index)d)._expr; }
        if (d is Expression_IndexRange) { return ((Expression_IndexRange)d)._expr; }
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
    public bool dtor_isArray {
      get {
        var d = this;
        if (d is Expression_Index) { return ((Expression_Index)d)._isArray; }
        return ((Expression_IndexRange)d)._isArray;
      }
    }
    public Dafny.ISequence<DAST._IExpression> dtor_indices {
      get {
        var d = this;
        return ((Expression_Index)d)._indices;
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
    public DAST._IOptional<Dafny.ISequence<Dafny.Rune>> dtor_maybeName {
      get {
        var d = this;
        return ((Expression_Call)d)._maybeName;
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
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        var d = this;
        return ((Expression_IIFE)d)._name;
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
      hash = ((hash << 5) + hash) + 14;
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
  public class Expression_Index : Expression {
    public readonly DAST._IExpression _expr;
    public readonly bool _isArray;
    public readonly Dafny.ISequence<DAST._IExpression> _indices;
    public Expression_Index(DAST._IExpression expr, bool isArray, Dafny.ISequence<DAST._IExpression> indices) : base() {
      this._expr = expr;
      this._isArray = isArray;
      this._indices = indices;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Index(_expr, _isArray, _indices);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Index;
      return oth != null && object.Equals(this._expr, oth._expr) && this._isArray == oth._isArray && object.Equals(this._indices, oth._indices);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 17;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._isArray));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._indices));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Index";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._isArray);
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
      hash = ((hash << 5) + hash) + 18;
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
      hash = ((hash << 5) + hash) + 19;
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
    public readonly DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _maybeName;
    public readonly Dafny.ISequence<DAST._IType> _typeArgs;
    public readonly Dafny.ISequence<DAST._IExpression> _args;
    public Expression_Call(DAST._IExpression @on, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> maybeName, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args) : base() {
      this._on = @on;
      this._maybeName = maybeName;
      this._typeArgs = typeArgs;
      this._args = args;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Call(_on, _maybeName, _typeArgs, _args);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Call;
      return oth != null && object.Equals(this._on, oth._on) && object.Equals(this._maybeName, oth._maybeName) && object.Equals(this._typeArgs, oth._typeArgs) && object.Equals(this._args, oth._args);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 20;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._on));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._maybeName));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeArgs));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._args));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Call";
      s += "(";
      s += Dafny.Helpers.ToString(this._on);
      s += ", ";
      s += Dafny.Helpers.ToString(this._maybeName);
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
      hash = ((hash << 5) + hash) + 21;
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
      hash = ((hash << 5) + hash) + 22;
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
      hash = ((hash << 5) + hash) + 23;
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
      hash = ((hash << 5) + hash) + 24;
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
      hash = ((hash << 5) + hash) + 25;
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
        Dafny.ISequence<DAST._IExpression> _224___mcc_h5 = _source13.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _225_indices = _224___mcc_h5;
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
          readIdents = _230_recIdents;
          if (!(_229_onErased)) {
            Dafny.ISequence<Dafny.Rune> _231_eraseFn;
            _231_eraseFn = ((_228_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _227_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _231_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _227_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          BigInteger _232_i;
          _232_i = BigInteger.Zero;
          while ((_232_i) < (new BigInteger((_225_indices).Count))) {
            Dafny.ISequence<Dafny.Rune> _233_idx;
            bool _234___v13;
            bool _235_idxErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _236_recIdentsIdx;
            Dafny.ISequence<Dafny.Rune> _out72;
            bool _out73;
            bool _out74;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out75;
            DCOMP.COMP.GenExpr((_225_indices).Select(_232_i), selfIdent, @params, true, out _out72, out _out73, out _out74, out _out75);
            _233_idx = _out72;
            _234___v13 = _out73;
            _235_idxErased = _out74;
            _236_recIdentsIdx = _out75;
            if (!(_235_idxErased)) {
              _233_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _233_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let __idx")), DCOMP.__default.natToString(_232_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = <usize as ::dafny_runtime::NumCast>::from(")), _233_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap();\n"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _236_recIdentsIdx);
            _232_i = (_232_i) + (BigInteger.One);
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, _227_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()"));
          _232_i = BigInteger.Zero;
          while ((_232_i) < (new BigInteger((_225_indices).Count))) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[__idx")), DCOMP.__default.natToString(_232_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
            _232_i = (_232_i) + (BigInteger.One);
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
        Dafny.ISequence<Dafny.Rune> _237___mcc_h0 = _source15.dtor_name;
        DAST._IType _238___mcc_h1 = _source15.dtor_typ;
        DAST._IOptional<DAST._IExpression> _239___mcc_h2 = _source15.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source16 = _239___mcc_h2;
        if (_source16.is_Some) {
          DAST._IExpression _240___mcc_h3 = _source16.dtor_Some_a0;
          DAST._IExpression _241_expression = _240___mcc_h3;
          DAST._IType _242_typ = _238___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _243_name = _237___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _244_expr;
            bool _245___v14;
            bool _246_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _247_recIdents;
            Dafny.ISequence<Dafny.Rune> _out76;
            bool _out77;
            bool _out78;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out79;
            DCOMP.COMP.GenExpr(_241_expression, selfIdent, @params, true, out _out76, out _out77, out _out78, out _out79);
            _244_expr = _out76;
            _245___v14 = _out77;
            _246_recErased = _out78;
            _247_recIdents = _out79;
            if (_246_recErased) {
              _244_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _244_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _248_typeString;
            Dafny.ISequence<Dafny.Rune> _out80;
            _out80 = DCOMP.COMP.GenType(_242_typ, true, false);
            _248_typeString = _out80;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _243_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _248_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _244_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _247_recIdents;
          }
        } else {
          DAST._IType _249_typ = _238___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _250_name = _237___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _251_typeString;
            Dafny.ISequence<Dafny.Rune> _out81;
            _out81 = DCOMP.COMP.GenType(_249_typ, true, false);
            _251_typeString = _out81;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _250_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _251_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source15.is_Assign) {
        DAST._IAssignLhs _252___mcc_h4 = _source15.dtor_lhs;
        DAST._IExpression _253___mcc_h5 = _source15.dtor_value;
        DAST._IExpression _254_expression = _253___mcc_h5;
        DAST._IAssignLhs _255_lhs = _252___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _256_lhsGen;
          bool _257_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _258_recIdents;
          Dafny.ISequence<Dafny.Rune> _out82;
          bool _out83;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out84;
          DCOMP.COMP.GenAssignLhs(_255_lhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("__rhs"), selfIdent, @params, out _out82, out _out83, out _out84);
          _256_lhsGen = _out82;
          _257_needsIIFE = _out83;
          _258_recIdents = _out84;
          Dafny.ISequence<Dafny.Rune> _259_exprGen;
          bool _260___v15;
          bool _261_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _262_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out85;
          bool _out86;
          bool _out87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out88;
          DCOMP.COMP.GenExpr(_254_expression, selfIdent, @params, true, out _out85, out _out86, out _out87, out _out88);
          _259_exprGen = _out85;
          _260___v15 = _out86;
          _261_exprErased = _out87;
          _262_exprIdents = _out88;
          if (_261_exprErased) {
            _259_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _259_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_257_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __rhs = "), _259_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _256_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_256_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _259_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_258_recIdents, _262_exprIdents);
        }
      } else if (_source15.is_If) {
        DAST._IExpression _263___mcc_h6 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _264___mcc_h7 = _source15.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _265___mcc_h8 = _source15.dtor_els;
        Dafny.ISequence<DAST._IStatement> _266_els = _265___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _267_thn = _264___mcc_h7;
        DAST._IExpression _268_cond = _263___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _269_condString;
          bool _270___v16;
          bool _271_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _272_recIdents;
          Dafny.ISequence<Dafny.Rune> _out89;
          bool _out90;
          bool _out91;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out92;
          DCOMP.COMP.GenExpr(_268_cond, selfIdent, @params, true, out _out89, out _out90, out _out91, out _out92);
          _269_condString = _out89;
          _270___v16 = _out90;
          _271_condErased = _out91;
          _272_recIdents = _out92;
          if (!(_271_condErased)) {
            _269_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _269_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _272_recIdents;
          Dafny.ISequence<Dafny.Rune> _273_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _274_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out93;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
          DCOMP.COMP.GenStmts(_267_thn, selfIdent, @params, isLast, earlyReturn, out _out93, out _out94);
          _273_thnString = _out93;
          _274_thnIdents = _out94;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _274_thnIdents);
          Dafny.ISequence<Dafny.Rune> _275_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _276_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out95;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out96;
          DCOMP.COMP.GenStmts(_266_els, selfIdent, @params, isLast, earlyReturn, out _out95, out _out96);
          _275_elsString = _out95;
          _276_elsIdents = _out96;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _276_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _269_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _273_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _275_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_While) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _277___mcc_h9 = _source15.dtor_lbl;
        DAST._IExpression _278___mcc_h10 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _279___mcc_h11 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _280_body = _279___mcc_h11;
        DAST._IExpression _281_cond = _278___mcc_h10;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _282_lbl = _277___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _283_condString;
          bool _284___v17;
          bool _285_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _286_recIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          bool _out98;
          bool _out99;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out100;
          DCOMP.COMP.GenExpr(_281_cond, selfIdent, @params, true, out _out97, out _out98, out _out99, out _out100);
          _283_condString = _out97;
          _284___v17 = _out98;
          _285_condErased = _out99;
          _286_recIdents = _out100;
          if (!(_285_condErased)) {
            _283_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _283_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _286_recIdents;
          Dafny.ISequence<Dafny.Rune> _287_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _288_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenStmts(_280_body, selfIdent, @params, false, earlyReturn, out _out101, out _out102);
          _287_bodyString = _out101;
          _288_bodyIdents = _out102;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _288_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _289_lblString;
          _289_lblString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source17 = _282_lbl;
          if (_source17.is_Some) {
            Dafny.ISequence<Dafny.Rune> _290___mcc_h21 = _source17.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _291_id = _290___mcc_h21;
            {
              _289_lblString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _291_id), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": "));
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_289_lblString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while ")), _283_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _287_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _292___mcc_h12 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _293___mcc_h13 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _294___mcc_h14 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _295___mcc_h15 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _296___mcc_h16 = _source15.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _297_maybeOutVars = _296___mcc_h16;
        Dafny.ISequence<DAST._IExpression> _298_args = _295___mcc_h15;
        Dafny.ISequence<DAST._IType> _299_typeArgs = _294___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _300_name = _293___mcc_h13;
        DAST._IExpression _301_on = _292___mcc_h12;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _302_typeArgString;
          _302_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_299_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _303_typeI;
            _303_typeI = BigInteger.Zero;
            _302_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_303_typeI) < (new BigInteger((_299_typeArgs).Count))) {
              if ((_303_typeI).Sign == 1) {
                _302_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_302_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _304_typeString;
              Dafny.ISequence<Dafny.Rune> _out103;
              _out103 = DCOMP.COMP.GenType((_299_typeArgs).Select(_303_typeI), false, false);
              _304_typeString = _out103;
              _302_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_302_typeArgString, _304_typeString);
              _303_typeI = (_303_typeI) + (BigInteger.One);
            }
            _302_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_302_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _305_argString;
          _305_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _306_i;
          _306_i = BigInteger.Zero;
          while ((_306_i) < (new BigInteger((_298_args).Count))) {
            if ((_306_i).Sign == 1) {
              _305_argString = Dafny.Sequence<Dafny.Rune>.Concat(_305_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _307_argExpr;
            bool _308_isOwned;
            bool _309_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _310_argIdents;
            Dafny.ISequence<Dafny.Rune> _out104;
            bool _out105;
            bool _out106;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out107;
            DCOMP.COMP.GenExpr((_298_args).Select(_306_i), selfIdent, @params, false, out _out104, out _out105, out _out106, out _out107);
            _307_argExpr = _out104;
            _308_isOwned = _out105;
            _309_argErased = _out106;
            _310_argIdents = _out107;
            if (_308_isOwned) {
              _307_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _307_argExpr);
            }
            _305_argString = Dafny.Sequence<Dafny.Rune>.Concat(_305_argString, _307_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _310_argIdents);
            _306_i = (_306_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _311_enclosingString;
          bool _312___v18;
          bool _313___v19;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _314_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out108;
          bool _out109;
          bool _out110;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out111;
          DCOMP.COMP.GenExpr(_301_on, selfIdent, @params, false, out _out108, out _out109, out _out110, out _out111);
          _311_enclosingString = _out108;
          _312___v18 = _out109;
          _313___v19 = _out110;
          _314_enclosingIdents = _out111;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _314_enclosingIdents);
          DAST._IExpression _source18 = _301_on;
          if (_source18.is_Literal) {
            DAST._ILiteral _315___mcc_h22 = _source18.dtor_Literal_a0;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _316___mcc_h24 = _source18.dtor_Ident_a0;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _317___mcc_h26 = _source18.dtor_Companion_a0;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_311_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source18.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _318___mcc_h28 = _source18.dtor_Tuple_a0;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _319___mcc_h30 = _source18.dtor_path;
            Dafny.ISequence<DAST._IExpression> _320___mcc_h31 = _source18.dtor_args;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _321___mcc_h34 = _source18.dtor_dims;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _322___mcc_h36 = _source18.dtor_path;
            Dafny.ISequence<Dafny.Rune> _323___mcc_h37 = _source18.dtor_variant;
            bool _324___mcc_h38 = _source18.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _325___mcc_h39 = _source18.dtor_contents;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Convert) {
            DAST._IExpression _326___mcc_h44 = _source18.dtor_value;
            DAST._IType _327___mcc_h45 = _source18.dtor_from;
            DAST._IType _328___mcc_h46 = _source18.dtor_typ;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _329___mcc_h50 = _source18.dtor_elements;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _330___mcc_h52 = _source18.dtor_elements;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_This) {
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ite) {
            DAST._IExpression _331___mcc_h54 = _source18.dtor_cond;
            DAST._IExpression _332___mcc_h55 = _source18.dtor_thn;
            DAST._IExpression _333___mcc_h56 = _source18.dtor_els;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_UnOp) {
            DAST._IUnaryOp _334___mcc_h60 = _source18.dtor_unOp;
            DAST._IExpression _335___mcc_h61 = _source18.dtor_expr;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _336___mcc_h64 = _source18.dtor_op;
            DAST._IExpression _337___mcc_h65 = _source18.dtor_left;
            DAST._IExpression _338___mcc_h66 = _source18.dtor_right;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_ArrayLen) {
            DAST._IExpression _339___mcc_h70 = _source18.dtor_expr;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Select) {
            DAST._IExpression _340___mcc_h72 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _341___mcc_h73 = _source18.dtor_field;
            bool _342___mcc_h74 = _source18.dtor_isConstant;
            bool _343___mcc_h75 = _source18.dtor_onDatatype;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SelectFn) {
            DAST._IExpression _344___mcc_h80 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _345___mcc_h81 = _source18.dtor_field;
            bool _346___mcc_h82 = _source18.dtor_onDatatype;
            bool _347___mcc_h83 = _source18.dtor_isStatic;
            BigInteger _348___mcc_h84 = _source18.dtor_arity;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Index) {
            DAST._IExpression _349___mcc_h90 = _source18.dtor_expr;
            bool _350___mcc_h91 = _source18.dtor_isArray;
            Dafny.ISequence<DAST._IExpression> _351___mcc_h92 = _source18.dtor_indices;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_IndexRange) {
            DAST._IExpression _352___mcc_h96 = _source18.dtor_expr;
            bool _353___mcc_h97 = _source18.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _354___mcc_h98 = _source18.dtor_low;
            DAST._IOptional<DAST._IExpression> _355___mcc_h99 = _source18.dtor_high;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TupleSelect) {
            DAST._IExpression _356___mcc_h104 = _source18.dtor_expr;
            BigInteger _357___mcc_h105 = _source18.dtor_index;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Call) {
            DAST._IExpression _358___mcc_h108 = _source18.dtor_on;
            DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _359___mcc_h109 = _source18.dtor_maybeName;
            Dafny.ISequence<DAST._IType> _360___mcc_h110 = _source18.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _361___mcc_h111 = _source18.dtor_args;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _362___mcc_h116 = _source18.dtor_params;
            DAST._IType _363___mcc_h117 = _source18.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _364___mcc_h118 = _source18.dtor_body;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _365___mcc_h122 = _source18.dtor_name;
            DAST._IType _366___mcc_h123 = _source18.dtor_typ;
            DAST._IExpression _367___mcc_h124 = _source18.dtor_value;
            DAST._IExpression _368___mcc_h125 = _source18.dtor_iifeBody;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Apply) {
            DAST._IExpression _369___mcc_h130 = _source18.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _370___mcc_h131 = _source18.dtor_args;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TypeTest) {
            DAST._IExpression _371___mcc_h134 = _source18.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _372___mcc_h135 = _source18.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _373___mcc_h136 = _source18.dtor_variant;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _374___mcc_h140 = _source18.dtor_typ;
            {
              _311_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _375_receiver;
          _375_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source19 = _297_maybeOutVars;
          if (_source19.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _376___mcc_h142 = _source19.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _377_outVars = _376___mcc_h142;
            {
              if ((new BigInteger((_377_outVars).Count)) > (BigInteger.One)) {
                _375_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _378_outI;
              _378_outI = BigInteger.Zero;
              while ((_378_outI) < (new BigInteger((_377_outVars).Count))) {
                if ((_378_outI).Sign == 1) {
                  _375_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_375_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _379_outVar;
                _379_outVar = (_377_outVars).Select(_378_outI);
                _375_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_375_receiver, (_379_outVar));
                _378_outI = (_378_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_377_outVars).Count)) > (BigInteger.One)) {
                _375_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_375_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_375_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_375_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _311_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _300_name), _302_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _305_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _380___mcc_h17 = _source15.dtor_expr;
        DAST._IExpression _381_expr = _380___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _382_exprString;
          bool _383___v22;
          bool _384_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _385_recIdents;
          Dafny.ISequence<Dafny.Rune> _out112;
          bool _out113;
          bool _out114;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out115;
          DCOMP.COMP.GenExpr(_381_expr, selfIdent, @params, true, out _out112, out _out113, out _out114, out _out115);
          _382_exprString = _out112;
          _383___v22 = _out113;
          _384_recErased = _out114;
          _385_recIdents = _out115;
          _382_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _382_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _385_recIdents;
          if (isLast) {
            generated = _382_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _382_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source15.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_Break) {
        Dafny.ISequence<Dafny.Rune> _386___mcc_h18 = _source15.dtor_toLabel;
        Dafny.ISequence<Dafny.Rune> _387_toLabel = _386___mcc_h18;
        {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break 'label_"), _387_toLabel), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _388___mcc_h19 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _389_body = _388___mcc_h19;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _390_paramI;
          _390_paramI = BigInteger.Zero;
          while ((_390_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _391_param;
            _391_param = (@params).Select(_390_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _391_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _391_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _390_paramI = (_390_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _392_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _393_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out116;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out117;
          DCOMP.COMP.GenStmts(_389_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out116, out _out117);
          _392_bodyString = _out116;
          _393_bodyIdents = _out117;
          readIdents = _393_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _392_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
        DAST._IExpression _394___mcc_h20 = _source15.dtor_Print_a0;
        DAST._IExpression _395_e = _394___mcc_h20;
        {
          Dafny.ISequence<Dafny.Rune> _396_printedExpr;
          bool _397_isOwned;
          bool _398___v23;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _399_recIdents;
          Dafny.ISequence<Dafny.Rune> _out118;
          bool _out119;
          bool _out120;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out121;
          DCOMP.COMP.GenExpr(_395_e, selfIdent, @params, false, out _out118, out _out119, out _out120, out _out121);
          _396_printedExpr = _out118;
          _397_isOwned = _out119;
          _398___v23 = _out120;
          _399_recIdents = _out121;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_397_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _396_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _399_recIdents;
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
        DAST._ILiteral _400___mcc_h0 = _source20.dtor_Literal_a0;
        DAST._ILiteral _source21 = _400___mcc_h0;
        if (_source21.is_BoolLiteral) {
          bool _401___mcc_h1 = _source21.dtor_BoolLiteral_a0;
          if ((_401___mcc_h1) == (false)) {
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
          Dafny.ISequence<Dafny.Rune> _402___mcc_h2 = _source21.dtor_IntLiteral_a0;
          DAST._IType _403___mcc_h3 = _source21.dtor_IntLiteral_a1;
          DAST._IType _404_t = _403___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _405_i = _402___mcc_h2;
          {
            DAST._IType _source22 = _404_t;
            if (_source22.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _406___mcc_h188 = _source22.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _407___mcc_h189 = _source22.dtor_typeArgs;
              DAST._IResolvedType _408___mcc_h190 = _source22.dtor_resolved;
              {
                s = _405_i;
              }
            } else if (_source22.is_Nullable) {
              DAST._IType _409___mcc_h194 = _source22.dtor_Nullable_a0;
              {
                s = _405_i;
              }
            } else if (_source22.is_Tuple) {
              Dafny.ISequence<DAST._IType> _410___mcc_h196 = _source22.dtor_Tuple_a0;
              {
                s = _405_i;
              }
            } else if (_source22.is_Array) {
              DAST._IType _411___mcc_h198 = _source22.dtor_element;
              {
                s = _405_i;
              }
            } else if (_source22.is_Seq) {
              DAST._IType _412___mcc_h200 = _source22.dtor_element;
              {
                s = _405_i;
              }
            } else if (_source22.is_Set) {
              DAST._IType _413___mcc_h202 = _source22.dtor_element;
              {
                s = _405_i;
              }
            } else if (_source22.is_Multiset) {
              DAST._IType _414___mcc_h204 = _source22.dtor_element;
              {
                s = _405_i;
              }
            } else if (_source22.is_Map) {
              DAST._IType _415___mcc_h206 = _source22.dtor_key;
              DAST._IType _416___mcc_h207 = _source22.dtor_value;
              {
                s = _405_i;
              }
            } else if (_source22.is_Arrow) {
              Dafny.ISequence<DAST._IType> _417___mcc_h210 = _source22.dtor_args;
              DAST._IType _418___mcc_h211 = _source22.dtor_result;
              {
                s = _405_i;
              }
            } else if (_source22.is_Primitive) {
              DAST._IPrimitive _419___mcc_h214 = _source22.dtor_Primitive_a0;
              DAST._IPrimitive _source23 = _419___mcc_h214;
              if (_source23.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _405_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source23.is_Real) {
                {
                  s = _405_i;
                }
              } else if (_source23.is_String) {
                {
                  s = _405_i;
                }
              } else if (_source23.is_Bool) {
                {
                  s = _405_i;
                }
              } else {
                {
                  s = _405_i;
                }
              }
            } else if (_source22.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _420___mcc_h216 = _source22.dtor_Passthrough_a0;
              {
                s = _405_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _421___mcc_h218 = _source22.dtor_TypeArg_a0;
              {
                s = _405_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _422___mcc_h4 = _source21.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _423___mcc_h5 = _source21.dtor_DecLiteral_a1;
          DAST._IType _424___mcc_h6 = _source21.dtor_DecLiteral_a2;
          DAST._IType _425_t = _424___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _426_d = _423___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _427_n = _422___mcc_h4;
          {
            DAST._IType _source24 = _425_t;
            if (_source24.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _428___mcc_h220 = _source24.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _429___mcc_h221 = _source24.dtor_typeArgs;
              DAST._IResolvedType _430___mcc_h222 = _source24.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Nullable) {
              DAST._IType _431___mcc_h226 = _source24.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Tuple) {
              Dafny.ISequence<DAST._IType> _432___mcc_h228 = _source24.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Array) {
              DAST._IType _433___mcc_h230 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Seq) {
              DAST._IType _434___mcc_h232 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Set) {
              DAST._IType _435___mcc_h234 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Multiset) {
              DAST._IType _436___mcc_h236 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Map) {
              DAST._IType _437___mcc_h238 = _source24.dtor_key;
              DAST._IType _438___mcc_h239 = _source24.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Arrow) {
              Dafny.ISequence<DAST._IType> _439___mcc_h242 = _source24.dtor_args;
              DAST._IType _440___mcc_h243 = _source24.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Primitive) {
              DAST._IPrimitive _441___mcc_h246 = _source24.dtor_Primitive_a0;
              DAST._IPrimitive _source25 = _441___mcc_h246;
              if (_source25.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source25.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _427_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source25.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source25.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source24.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _442___mcc_h248 = _source24.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _443___mcc_h250 = _source24.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_427_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _426_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _444___mcc_h7 = _source21.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _445_l = _444___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _445_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_CharLiteral) {
          Dafny.Rune _446___mcc_h8 = _source21.dtor_CharLiteral_a0;
          Dafny.Rune _447_c = _446___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_447_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _448___mcc_h9 = _source20.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _449_name = _448___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _449_name);
          if (!((@params).Contains(_449_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_449_name);
        }
      } else if (_source20.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _450___mcc_h10 = _source20.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _451_path = _450___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out122;
          _out122 = DCOMP.COMP.GenPath(_451_path);
          s = _out122;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source20.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _452___mcc_h11 = _source20.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _453_values = _452___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _454_i;
          _454_i = BigInteger.Zero;
          bool _455_allErased;
          _455_allErased = true;
          while ((_454_i) < (new BigInteger((_453_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _456___v26;
            bool _457___v27;
            bool _458_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _459___v28;
            Dafny.ISequence<Dafny.Rune> _out123;
            bool _out124;
            bool _out125;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out126;
            DCOMP.COMP.GenExpr((_453_values).Select(_454_i), selfIdent, @params, true, out _out123, out _out124, out _out125, out _out126);
            _456___v26 = _out123;
            _457___v27 = _out124;
            _458_isErased = _out125;
            _459___v28 = _out126;
            _455_allErased = (_455_allErased) && (_458_isErased);
            _454_i = (_454_i) + (BigInteger.One);
          }
          _454_i = BigInteger.Zero;
          while ((_454_i) < (new BigInteger((_453_values).Count))) {
            if ((_454_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _460_recursiveGen;
            bool _461___v29;
            bool _462_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _463_recIdents;
            Dafny.ISequence<Dafny.Rune> _out127;
            bool _out128;
            bool _out129;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out130;
            DCOMP.COMP.GenExpr((_453_values).Select(_454_i), selfIdent, @params, true, out _out127, out _out128, out _out129, out _out130);
            _460_recursiveGen = _out127;
            _461___v29 = _out128;
            _462_isErased = _out129;
            _463_recIdents = _out130;
            if ((_462_isErased) && (!(_455_allErased))) {
              _460_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _460_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _460_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _463_recIdents);
            _454_i = (_454_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _455_allErased;
        }
      } else if (_source20.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _464___mcc_h12 = _source20.dtor_path;
        Dafny.ISequence<DAST._IExpression> _465___mcc_h13 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _466_args = _465___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _467_path = _464___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _468_path;
          Dafny.ISequence<Dafny.Rune> _out131;
          _out131 = DCOMP.COMP.GenPath(_467_path);
          _468_path = _out131;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _468_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _469_i;
          _469_i = BigInteger.Zero;
          while ((_469_i) < (new BigInteger((_466_args).Count))) {
            if ((_469_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _470_recursiveGen;
            bool _471___v30;
            bool _472_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _473_recIdents;
            Dafny.ISequence<Dafny.Rune> _out132;
            bool _out133;
            bool _out134;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out135;
            DCOMP.COMP.GenExpr((_466_args).Select(_469_i), selfIdent, @params, true, out _out132, out _out133, out _out134, out _out135);
            _470_recursiveGen = _out132;
            _471___v30 = _out133;
            _472_isErased = _out134;
            _473_recIdents = _out135;
            if (_472_isErased) {
              _470_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _470_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _470_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _473_recIdents);
            _469_i = (_469_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _474___mcc_h14 = _source20.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _475_dims = _474___mcc_h14;
        {
          BigInteger _476_i;
          _476_i = (new BigInteger((_475_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_476_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _477_recursiveGen;
            bool _478___v31;
            bool _479_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _480_recIdents;
            Dafny.ISequence<Dafny.Rune> _out136;
            bool _out137;
            bool _out138;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out139;
            DCOMP.COMP.GenExpr((_475_dims).Select(_476_i), selfIdent, @params, true, out _out136, out _out137, out _out138, out _out139);
            _477_recursiveGen = _out136;
            _478___v31 = _out137;
            _479_isErased = _out138;
            _480_recIdents = _out139;
            if (!(_479_isErased)) {
              _477_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _477_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _477_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _480_recIdents);
            _476_i = (_476_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _481___mcc_h15 = _source20.dtor_path;
        Dafny.ISequence<Dafny.Rune> _482___mcc_h16 = _source20.dtor_variant;
        bool _483___mcc_h17 = _source20.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _484___mcc_h18 = _source20.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _485_values = _484___mcc_h18;
        bool _486_isCo = _483___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _487_variant = _482___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _488_path = _481___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _489_path;
          Dafny.ISequence<Dafny.Rune> _out140;
          _out140 = DCOMP.COMP.GenPath(_488_path);
          _489_path = _out140;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _489_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _487_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _490_i;
          _490_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_490_i) < (new BigInteger((_485_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_485_values).Select(_490_i);
            Dafny.ISequence<Dafny.Rune> _491_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _492_value = _let_tmp_rhs0.dtor__1;
            if ((_490_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_486_isCo) {
              Dafny.ISequence<Dafny.Rune> _493_recursiveGen;
              bool _494___v32;
              bool _495_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _496_recIdents;
              Dafny.ISequence<Dafny.Rune> _out141;
              bool _out142;
              bool _out143;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out144;
              DCOMP.COMP.GenExpr(_492_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out141, out _out142, out _out143, out _out144);
              _493_recursiveGen = _out141;
              _494___v32 = _out142;
              _495_isErased = _out143;
              _496_recIdents = _out144;
              if (!(_495_isErased)) {
                _493_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _493_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _493_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _493_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _496_recIdents);
              Dafny.ISequence<Dafny.Rune> _497_allReadCloned;
              _497_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_496_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _498_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_496_recIdents).Elements) {
                  _498_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_496_recIdents).Contains(_498_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1170)");
              after__ASSIGN_SUCH_THAT_0:;
                _497_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_497_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _498_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _498_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _496_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_496_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_498_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _491_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _497_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _493_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _499_recursiveGen;
              bool _500___v33;
              bool _501_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _502_recIdents;
              Dafny.ISequence<Dafny.Rune> _out145;
              bool _out146;
              bool _out147;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
              DCOMP.COMP.GenExpr(_492_value, selfIdent, @params, true, out _out145, out _out146, out _out147, out _out148);
              _499_recursiveGen = _out145;
              _500___v33 = _out146;
              _501_isErased = _out147;
              _502_recIdents = _out148;
              if (!(_501_isErased)) {
                _499_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _499_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _499_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _499_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _491_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _499_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _502_recIdents);
            }
            _490_i = (_490_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_Convert) {
        DAST._IExpression _503___mcc_h19 = _source20.dtor_value;
        DAST._IType _504___mcc_h20 = _source20.dtor_from;
        DAST._IType _505___mcc_h21 = _source20.dtor_typ;
        DAST._IType _506_toTpe = _505___mcc_h21;
        DAST._IType _507_fromTpe = _504___mcc_h20;
        DAST._IExpression _508_expr = _503___mcc_h19;
        {
          if (object.Equals(_507_fromTpe, _506_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _509_recursiveGen;
            bool _510_recOwned;
            bool _511_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _512_recIdents;
            Dafny.ISequence<Dafny.Rune> _out149;
            bool _out150;
            bool _out151;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
            DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out149, out _out150, out _out151, out _out152);
            _509_recursiveGen = _out149;
            _510_recOwned = _out150;
            _511_recErased = _out151;
            _512_recIdents = _out152;
            s = _509_recursiveGen;
            isOwned = _510_recOwned;
            isErased = _511_recErased;
            readIdents = _512_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source26 = _System.Tuple2<DAST._IType, DAST._IType>.create(_507_fromTpe, _506_toTpe);
            DAST._IType _513___mcc_h252 = _source26.dtor__0;
            DAST._IType _514___mcc_h253 = _source26.dtor__1;
            DAST._IType _source27 = _513___mcc_h252;
            if (_source27.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _515___mcc_h256 = _source27.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _516___mcc_h257 = _source27.dtor_typeArgs;
              DAST._IResolvedType _517___mcc_h258 = _source27.dtor_resolved;
              DAST._IResolvedType _source28 = _517___mcc_h258;
              if (_source28.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _518___mcc_h268 = _source28.dtor_path;
                DAST._IType _source29 = _514___mcc_h253;
                if (_source29.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _519___mcc_h272 = _source29.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _520___mcc_h273 = _source29.dtor_typeArgs;
                  DAST._IResolvedType _521___mcc_h274 = _source29.dtor_resolved;
                  DAST._IResolvedType _source30 = _521___mcc_h274;
                  if (_source30.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _522___mcc_h278 = _source30.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _523_recursiveGen;
                      bool _524_recOwned;
                      bool _525_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _526_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out153;
                      bool _out154;
                      bool _out155;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out153, out _out154, out _out155, out _out156);
                      _523_recursiveGen = _out153;
                      _524_recOwned = _out154;
                      _525_recErased = _out155;
                      _526_recIdents = _out156;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _523_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _524_recOwned;
                      isErased = _525_recErased;
                      readIdents = _526_recIdents;
                    }
                  } else if (_source30.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _527___mcc_h280 = _source30.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _528_recursiveGen;
                      bool _529_recOwned;
                      bool _530_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _531_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out157;
                      bool _out158;
                      bool _out159;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out160;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out157, out _out158, out _out159, out _out160);
                      _528_recursiveGen = _out157;
                      _529_recOwned = _out158;
                      _530_recErased = _out159;
                      _531_recIdents = _out160;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _528_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _529_recOwned;
                      isErased = _530_recErased;
                      readIdents = _531_recIdents;
                    }
                  } else {
                    DAST._IType _532___mcc_h282 = _source30.dtor_Newtype_a0;
                    DAST._IType _533_b = _532___mcc_h282;
                    {
                      if (object.Equals(_507_fromTpe, _533_b)) {
                        Dafny.ISequence<Dafny.Rune> _534_recursiveGen;
                        bool _535_recOwned;
                        bool _536_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _537_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out161;
                        bool _out162;
                        bool _out163;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out164;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out161, out _out162, out _out163, out _out164);
                        _534_recursiveGen = _out161;
                        _535_recOwned = _out162;
                        _536_recErased = _out163;
                        _537_recIdents = _out164;
                        Dafny.ISequence<Dafny.Rune> _538_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out165;
                        _out165 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                        _538_rhsType = _out165;
                        Dafny.ISequence<Dafny.Rune> _539_uneraseFn;
                        _539_uneraseFn = ((_535_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _538_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _539_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _535_recOwned;
                        isErased = false;
                        readIdents = _537_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out166;
                        bool _out167;
                        bool _out168;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out169;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _533_b), _533_b, _506_toTpe), selfIdent, @params, mustOwn, out _out166, out _out167, out _out168, out _out169);
                        s = _out166;
                        isOwned = _out167;
                        isErased = _out168;
                        readIdents = _out169;
                      }
                    }
                  }
                } else if (_source29.is_Nullable) {
                  DAST._IType _540___mcc_h284 = _source29.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _541_recursiveGen;
                    bool _542_recOwned;
                    bool _543_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _544_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out170;
                    bool _out171;
                    bool _out172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out173;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out170, out _out171, out _out172, out _out173);
                    _541_recursiveGen = _out170;
                    _542_recOwned = _out171;
                    _543_recErased = _out172;
                    _544_recIdents = _out173;
                    if (!(_542_recOwned)) {
                      _541_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_541_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _541_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _543_recErased;
                    readIdents = _544_recIdents;
                  }
                } else if (_source29.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _545___mcc_h286 = _source29.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _546_recursiveGen;
                    bool _547_recOwned;
                    bool _548_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _549_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out174;
                    bool _out175;
                    bool _out176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out177;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out174, out _out175, out _out176, out _out177);
                    _546_recursiveGen = _out174;
                    _547_recOwned = _out175;
                    _548_recErased = _out176;
                    _549_recIdents = _out177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _547_recOwned;
                    isErased = _548_recErased;
                    readIdents = _549_recIdents;
                  }
                } else if (_source29.is_Array) {
                  DAST._IType _550___mcc_h288 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _551_recursiveGen;
                    bool _552_recOwned;
                    bool _553_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _554_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out178;
                    bool _out179;
                    bool _out180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out181;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out178, out _out179, out _out180, out _out181);
                    _551_recursiveGen = _out178;
                    _552_recOwned = _out179;
                    _553_recErased = _out180;
                    _554_recIdents = _out181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _551_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _552_recOwned;
                    isErased = _553_recErased;
                    readIdents = _554_recIdents;
                  }
                } else if (_source29.is_Seq) {
                  DAST._IType _555___mcc_h290 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _556_recursiveGen;
                    bool _557_recOwned;
                    bool _558_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _559_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out182;
                    bool _out183;
                    bool _out184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out185;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out182, out _out183, out _out184, out _out185);
                    _556_recursiveGen = _out182;
                    _557_recOwned = _out183;
                    _558_recErased = _out184;
                    _559_recIdents = _out185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _556_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _557_recOwned;
                    isErased = _558_recErased;
                    readIdents = _559_recIdents;
                  }
                } else if (_source29.is_Set) {
                  DAST._IType _560___mcc_h292 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _561_recursiveGen;
                    bool _562_recOwned;
                    bool _563_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _564_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out186;
                    bool _out187;
                    bool _out188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out189;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out186, out _out187, out _out188, out _out189);
                    _561_recursiveGen = _out186;
                    _562_recOwned = _out187;
                    _563_recErased = _out188;
                    _564_recIdents = _out189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _561_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _562_recOwned;
                    isErased = _563_recErased;
                    readIdents = _564_recIdents;
                  }
                } else if (_source29.is_Multiset) {
                  DAST._IType _565___mcc_h294 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _566_recursiveGen;
                    bool _567_recOwned;
                    bool _568_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _569_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out190;
                    bool _out191;
                    bool _out192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out193;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out190, out _out191, out _out192, out _out193);
                    _566_recursiveGen = _out190;
                    _567_recOwned = _out191;
                    _568_recErased = _out192;
                    _569_recIdents = _out193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _566_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _567_recOwned;
                    isErased = _568_recErased;
                    readIdents = _569_recIdents;
                  }
                } else if (_source29.is_Map) {
                  DAST._IType _570___mcc_h296 = _source29.dtor_key;
                  DAST._IType _571___mcc_h297 = _source29.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _572_recursiveGen;
                    bool _573_recOwned;
                    bool _574_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _575_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out194;
                    bool _out195;
                    bool _out196;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out197;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out194, out _out195, out _out196, out _out197);
                    _572_recursiveGen = _out194;
                    _573_recOwned = _out195;
                    _574_recErased = _out196;
                    _575_recIdents = _out197;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _572_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _573_recOwned;
                    isErased = _574_recErased;
                    readIdents = _575_recIdents;
                  }
                } else if (_source29.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _576___mcc_h300 = _source29.dtor_args;
                  DAST._IType _577___mcc_h301 = _source29.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _578_recursiveGen;
                    bool _579_recOwned;
                    bool _580_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _581_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out198;
                    bool _out199;
                    bool _out200;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out198, out _out199, out _out200, out _out201);
                    _578_recursiveGen = _out198;
                    _579_recOwned = _out199;
                    _580_recErased = _out200;
                    _581_recIdents = _out201;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _578_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _579_recOwned;
                    isErased = _580_recErased;
                    readIdents = _581_recIdents;
                  }
                } else if (_source29.is_Primitive) {
                  DAST._IPrimitive _582___mcc_h304 = _source29.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _583_recursiveGen;
                    bool _584_recOwned;
                    bool _585_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _586_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out202;
                    bool _out203;
                    bool _out204;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out202, out _out203, out _out204, out _out205);
                    _583_recursiveGen = _out202;
                    _584_recOwned = _out203;
                    _585_recErased = _out204;
                    _586_recIdents = _out205;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _583_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _584_recOwned;
                    isErased = _585_recErased;
                    readIdents = _586_recIdents;
                  }
                } else if (_source29.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _587___mcc_h306 = _source29.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _588_recursiveGen;
                    bool _589_recOwned;
                    bool _590_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _591_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out206;
                    bool _out207;
                    bool _out208;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out206, out _out207, out _out208, out _out209);
                    _588_recursiveGen = _out206;
                    _589_recOwned = _out207;
                    _590_recErased = _out208;
                    _591_recIdents = _out209;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _588_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _589_recOwned;
                    isErased = _590_recErased;
                    readIdents = _591_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _592___mcc_h308 = _source29.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _593_recursiveGen;
                    bool _594_recOwned;
                    bool _595_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _596_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out210;
                    bool _out211;
                    bool _out212;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out210, out _out211, out _out212, out _out213);
                    _593_recursiveGen = _out210;
                    _594_recOwned = _out211;
                    _595_recErased = _out212;
                    _596_recIdents = _out213;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _593_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _594_recOwned;
                    isErased = _595_recErased;
                    readIdents = _596_recIdents;
                  }
                }
              } else if (_source28.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _597___mcc_h310 = _source28.dtor_path;
                DAST._IType _source31 = _514___mcc_h253;
                if (_source31.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _598___mcc_h314 = _source31.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _599___mcc_h315 = _source31.dtor_typeArgs;
                  DAST._IResolvedType _600___mcc_h316 = _source31.dtor_resolved;
                  DAST._IResolvedType _source32 = _600___mcc_h316;
                  if (_source32.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _601___mcc_h320 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _602_recursiveGen;
                      bool _603_recOwned;
                      bool _604_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _605_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out214;
                      bool _out215;
                      bool _out216;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out214, out _out215, out _out216, out _out217);
                      _602_recursiveGen = _out214;
                      _603_recOwned = _out215;
                      _604_recErased = _out216;
                      _605_recIdents = _out217;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _602_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _603_recOwned;
                      isErased = _604_recErased;
                      readIdents = _605_recIdents;
                    }
                  } else if (_source32.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _606___mcc_h322 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _607_recursiveGen;
                      bool _608_recOwned;
                      bool _609_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _610_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out218;
                      bool _out219;
                      bool _out220;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out221;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out218, out _out219, out _out220, out _out221);
                      _607_recursiveGen = _out218;
                      _608_recOwned = _out219;
                      _609_recErased = _out220;
                      _610_recIdents = _out221;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _607_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _608_recOwned;
                      isErased = _609_recErased;
                      readIdents = _610_recIdents;
                    }
                  } else {
                    DAST._IType _611___mcc_h324 = _source32.dtor_Newtype_a0;
                    DAST._IType _612_b = _611___mcc_h324;
                    {
                      if (object.Equals(_507_fromTpe, _612_b)) {
                        Dafny.ISequence<Dafny.Rune> _613_recursiveGen;
                        bool _614_recOwned;
                        bool _615_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _616_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out222;
                        bool _out223;
                        bool _out224;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out225;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out222, out _out223, out _out224, out _out225);
                        _613_recursiveGen = _out222;
                        _614_recOwned = _out223;
                        _615_recErased = _out224;
                        _616_recIdents = _out225;
                        Dafny.ISequence<Dafny.Rune> _617_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out226;
                        _out226 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                        _617_rhsType = _out226;
                        Dafny.ISequence<Dafny.Rune> _618_uneraseFn;
                        _618_uneraseFn = ((_614_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _617_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _618_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _614_recOwned;
                        isErased = false;
                        readIdents = _616_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out227;
                        bool _out228;
                        bool _out229;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out230;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _612_b), _612_b, _506_toTpe), selfIdent, @params, mustOwn, out _out227, out _out228, out _out229, out _out230);
                        s = _out227;
                        isOwned = _out228;
                        isErased = _out229;
                        readIdents = _out230;
                      }
                    }
                  }
                } else if (_source31.is_Nullable) {
                  DAST._IType _619___mcc_h326 = _source31.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _620_recursiveGen;
                    bool _621_recOwned;
                    bool _622_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _623_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out231;
                    bool _out232;
                    bool _out233;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out234;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out231, out _out232, out _out233, out _out234);
                    _620_recursiveGen = _out231;
                    _621_recOwned = _out232;
                    _622_recErased = _out233;
                    _623_recIdents = _out234;
                    if (!(_621_recOwned)) {
                      _620_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_620_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _620_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _622_recErased;
                    readIdents = _623_recIdents;
                  }
                } else if (_source31.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _624___mcc_h328 = _source31.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _625_recursiveGen;
                    bool _626_recOwned;
                    bool _627_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _628_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out235;
                    bool _out236;
                    bool _out237;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out238;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out235, out _out236, out _out237, out _out238);
                    _625_recursiveGen = _out235;
                    _626_recOwned = _out236;
                    _627_recErased = _out237;
                    _628_recIdents = _out238;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _625_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _626_recOwned;
                    isErased = _627_recErased;
                    readIdents = _628_recIdents;
                  }
                } else if (_source31.is_Array) {
                  DAST._IType _629___mcc_h330 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _630_recursiveGen;
                    bool _631_recOwned;
                    bool _632_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _633_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out239;
                    bool _out240;
                    bool _out241;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out242;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out239, out _out240, out _out241, out _out242);
                    _630_recursiveGen = _out239;
                    _631_recOwned = _out240;
                    _632_recErased = _out241;
                    _633_recIdents = _out242;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _630_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _631_recOwned;
                    isErased = _632_recErased;
                    readIdents = _633_recIdents;
                  }
                } else if (_source31.is_Seq) {
                  DAST._IType _634___mcc_h332 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _635_recursiveGen;
                    bool _636_recOwned;
                    bool _637_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _638_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out243;
                    bool _out244;
                    bool _out245;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out246;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out243, out _out244, out _out245, out _out246);
                    _635_recursiveGen = _out243;
                    _636_recOwned = _out244;
                    _637_recErased = _out245;
                    _638_recIdents = _out246;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _635_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _636_recOwned;
                    isErased = _637_recErased;
                    readIdents = _638_recIdents;
                  }
                } else if (_source31.is_Set) {
                  DAST._IType _639___mcc_h334 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _640_recursiveGen;
                    bool _641_recOwned;
                    bool _642_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _643_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out247;
                    bool _out248;
                    bool _out249;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out250;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out247, out _out248, out _out249, out _out250);
                    _640_recursiveGen = _out247;
                    _641_recOwned = _out248;
                    _642_recErased = _out249;
                    _643_recIdents = _out250;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _641_recOwned;
                    isErased = _642_recErased;
                    readIdents = _643_recIdents;
                  }
                } else if (_source31.is_Multiset) {
                  DAST._IType _644___mcc_h336 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _645_recursiveGen;
                    bool _646_recOwned;
                    bool _647_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _648_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out251;
                    bool _out252;
                    bool _out253;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out251, out _out252, out _out253, out _out254);
                    _645_recursiveGen = _out251;
                    _646_recOwned = _out252;
                    _647_recErased = _out253;
                    _648_recIdents = _out254;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _646_recOwned;
                    isErased = _647_recErased;
                    readIdents = _648_recIdents;
                  }
                } else if (_source31.is_Map) {
                  DAST._IType _649___mcc_h338 = _source31.dtor_key;
                  DAST._IType _650___mcc_h339 = _source31.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _651_recursiveGen;
                    bool _652_recOwned;
                    bool _653_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _654_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out255;
                    bool _out256;
                    bool _out257;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out255, out _out256, out _out257, out _out258);
                    _651_recursiveGen = _out255;
                    _652_recOwned = _out256;
                    _653_recErased = _out257;
                    _654_recIdents = _out258;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _651_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _652_recOwned;
                    isErased = _653_recErased;
                    readIdents = _654_recIdents;
                  }
                } else if (_source31.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _655___mcc_h342 = _source31.dtor_args;
                  DAST._IType _656___mcc_h343 = _source31.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _657_recursiveGen;
                    bool _658_recOwned;
                    bool _659_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _660_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out259;
                    bool _out260;
                    bool _out261;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out259, out _out260, out _out261, out _out262);
                    _657_recursiveGen = _out259;
                    _658_recOwned = _out260;
                    _659_recErased = _out261;
                    _660_recIdents = _out262;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _657_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _658_recOwned;
                    isErased = _659_recErased;
                    readIdents = _660_recIdents;
                  }
                } else if (_source31.is_Primitive) {
                  DAST._IPrimitive _661___mcc_h346 = _source31.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _662_recursiveGen;
                    bool _663_recOwned;
                    bool _664_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _665_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out263;
                    bool _out264;
                    bool _out265;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out263, out _out264, out _out265, out _out266);
                    _662_recursiveGen = _out263;
                    _663_recOwned = _out264;
                    _664_recErased = _out265;
                    _665_recIdents = _out266;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _662_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _663_recOwned;
                    isErased = _664_recErased;
                    readIdents = _665_recIdents;
                  }
                } else if (_source31.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _666___mcc_h348 = _source31.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _667_recursiveGen;
                    bool _668_recOwned;
                    bool _669_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _670_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out267;
                    bool _out268;
                    bool _out269;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out267, out _out268, out _out269, out _out270);
                    _667_recursiveGen = _out267;
                    _668_recOwned = _out268;
                    _669_recErased = _out269;
                    _670_recIdents = _out270;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _667_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _668_recOwned;
                    isErased = _669_recErased;
                    readIdents = _670_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _671___mcc_h350 = _source31.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _672_recursiveGen;
                    bool _673_recOwned;
                    bool _674_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _675_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out271;
                    bool _out272;
                    bool _out273;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out271, out _out272, out _out273, out _out274);
                    _672_recursiveGen = _out271;
                    _673_recOwned = _out272;
                    _674_recErased = _out273;
                    _675_recIdents = _out274;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _672_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _673_recOwned;
                    isErased = _674_recErased;
                    readIdents = _675_recIdents;
                  }
                }
              } else {
                DAST._IType _676___mcc_h352 = _source28.dtor_Newtype_a0;
                DAST._IType _source33 = _514___mcc_h253;
                if (_source33.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _677___mcc_h356 = _source33.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _678___mcc_h357 = _source33.dtor_typeArgs;
                  DAST._IResolvedType _679___mcc_h358 = _source33.dtor_resolved;
                  DAST._IResolvedType _source34 = _679___mcc_h358;
                  if (_source34.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _680___mcc_h365 = _source34.dtor_path;
                    DAST._IType _681_b = _676___mcc_h352;
                    {
                      if (object.Equals(_681_b, _506_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _682_recursiveGen;
                        bool _683_recOwned;
                        bool _684_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _685_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out275;
                        bool _out276;
                        bool _out277;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out275, out _out276, out _out277, out _out278);
                        _682_recursiveGen = _out275;
                        _683_recOwned = _out276;
                        _684_recErased = _out277;
                        _685_recIdents = _out278;
                        Dafny.ISequence<Dafny.Rune> _686_uneraseFn;
                        _686_uneraseFn = ((_683_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _686_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _683_recOwned;
                        isErased = true;
                        readIdents = _685_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out279;
                        bool _out280;
                        bool _out281;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _681_b), _681_b, _506_toTpe), selfIdent, @params, mustOwn, out _out279, out _out280, out _out281, out _out282);
                        s = _out279;
                        isOwned = _out280;
                        isErased = _out281;
                        readIdents = _out282;
                      }
                    }
                  } else if (_source34.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _687___mcc_h368 = _source34.dtor_path;
                    DAST._IType _688_b = _676___mcc_h352;
                    {
                      if (object.Equals(_688_b, _506_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _689_recursiveGen;
                        bool _690_recOwned;
                        bool _691_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _692_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out283;
                        bool _out284;
                        bool _out285;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out283, out _out284, out _out285, out _out286);
                        _689_recursiveGen = _out283;
                        _690_recOwned = _out284;
                        _691_recErased = _out285;
                        _692_recIdents = _out286;
                        Dafny.ISequence<Dafny.Rune> _693_uneraseFn;
                        _693_uneraseFn = ((_690_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _693_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _689_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _690_recOwned;
                        isErased = true;
                        readIdents = _692_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out287;
                        bool _out288;
                        bool _out289;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out290;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _688_b), _688_b, _506_toTpe), selfIdent, @params, mustOwn, out _out287, out _out288, out _out289, out _out290);
                        s = _out287;
                        isOwned = _out288;
                        isErased = _out289;
                        readIdents = _out290;
                      }
                    }
                  } else {
                    DAST._IType _694___mcc_h371 = _source34.dtor_Newtype_a0;
                    DAST._IType _695_b = _694___mcc_h371;
                    {
                      if (object.Equals(_507_fromTpe, _695_b)) {
                        Dafny.ISequence<Dafny.Rune> _696_recursiveGen;
                        bool _697_recOwned;
                        bool _698_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _699_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out291;
                        bool _out292;
                        bool _out293;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out294;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out291, out _out292, out _out293, out _out294);
                        _696_recursiveGen = _out291;
                        _697_recOwned = _out292;
                        _698_recErased = _out293;
                        _699_recIdents = _out294;
                        Dafny.ISequence<Dafny.Rune> _700_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out295;
                        _out295 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                        _700_rhsType = _out295;
                        Dafny.ISequence<Dafny.Rune> _701_uneraseFn;
                        _701_uneraseFn = ((_697_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _700_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _701_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _696_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _697_recOwned;
                        isErased = false;
                        readIdents = _699_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out296;
                        bool _out297;
                        bool _out298;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out299;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _695_b), _695_b, _506_toTpe), selfIdent, @params, mustOwn, out _out296, out _out297, out _out298, out _out299);
                        s = _out296;
                        isOwned = _out297;
                        isErased = _out298;
                        readIdents = _out299;
                      }
                    }
                  }
                } else if (_source33.is_Nullable) {
                  DAST._IType _702___mcc_h374 = _source33.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _703_recursiveGen;
                    bool _704_recOwned;
                    bool _705_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _706_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out300;
                    bool _out301;
                    bool _out302;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out303;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out300, out _out301, out _out302, out _out303);
                    _703_recursiveGen = _out300;
                    _704_recOwned = _out301;
                    _705_recErased = _out302;
                    _706_recIdents = _out303;
                    if (!(_704_recOwned)) {
                      _703_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_703_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _705_recErased;
                    readIdents = _706_recIdents;
                  }
                } else if (_source33.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _707___mcc_h377 = _source33.dtor_Tuple_a0;
                  DAST._IType _708_b = _676___mcc_h352;
                  {
                    if (object.Equals(_708_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _709_recursiveGen;
                      bool _710_recOwned;
                      bool _711_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _712_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out304;
                      bool _out305;
                      bool _out306;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out304, out _out305, out _out306, out _out307);
                      _709_recursiveGen = _out304;
                      _710_recOwned = _out305;
                      _711_recErased = _out306;
                      _712_recIdents = _out307;
                      Dafny.ISequence<Dafny.Rune> _713_uneraseFn;
                      _713_uneraseFn = ((_710_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _713_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _709_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _710_recOwned;
                      isErased = true;
                      readIdents = _712_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out308;
                      bool _out309;
                      bool _out310;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _708_b), _708_b, _506_toTpe), selfIdent, @params, mustOwn, out _out308, out _out309, out _out310, out _out311);
                      s = _out308;
                      isOwned = _out309;
                      isErased = _out310;
                      readIdents = _out311;
                    }
                  }
                } else if (_source33.is_Array) {
                  DAST._IType _714___mcc_h380 = _source33.dtor_element;
                  DAST._IType _715_b = _676___mcc_h352;
                  {
                    if (object.Equals(_715_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _716_recursiveGen;
                      bool _717_recOwned;
                      bool _718_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _719_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out312;
                      bool _out313;
                      bool _out314;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out312, out _out313, out _out314, out _out315);
                      _716_recursiveGen = _out312;
                      _717_recOwned = _out313;
                      _718_recErased = _out314;
                      _719_recIdents = _out315;
                      Dafny.ISequence<Dafny.Rune> _720_uneraseFn;
                      _720_uneraseFn = ((_717_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _720_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _716_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _717_recOwned;
                      isErased = true;
                      readIdents = _719_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out316;
                      bool _out317;
                      bool _out318;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _715_b), _715_b, _506_toTpe), selfIdent, @params, mustOwn, out _out316, out _out317, out _out318, out _out319);
                      s = _out316;
                      isOwned = _out317;
                      isErased = _out318;
                      readIdents = _out319;
                    }
                  }
                } else if (_source33.is_Seq) {
                  DAST._IType _721___mcc_h383 = _source33.dtor_element;
                  DAST._IType _722_b = _676___mcc_h352;
                  {
                    if (object.Equals(_722_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _723_recursiveGen;
                      bool _724_recOwned;
                      bool _725_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _726_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out320;
                      bool _out321;
                      bool _out322;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out320, out _out321, out _out322, out _out323);
                      _723_recursiveGen = _out320;
                      _724_recOwned = _out321;
                      _725_recErased = _out322;
                      _726_recIdents = _out323;
                      Dafny.ISequence<Dafny.Rune> _727_uneraseFn;
                      _727_uneraseFn = ((_724_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _727_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _723_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _724_recOwned;
                      isErased = true;
                      readIdents = _726_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out324;
                      bool _out325;
                      bool _out326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _722_b), _722_b, _506_toTpe), selfIdent, @params, mustOwn, out _out324, out _out325, out _out326, out _out327);
                      s = _out324;
                      isOwned = _out325;
                      isErased = _out326;
                      readIdents = _out327;
                    }
                  }
                } else if (_source33.is_Set) {
                  DAST._IType _728___mcc_h386 = _source33.dtor_element;
                  DAST._IType _729_b = _676___mcc_h352;
                  {
                    if (object.Equals(_729_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _730_recursiveGen;
                      bool _731_recOwned;
                      bool _732_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _733_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out328;
                      bool _out329;
                      bool _out330;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out328, out _out329, out _out330, out _out331);
                      _730_recursiveGen = _out328;
                      _731_recOwned = _out329;
                      _732_recErased = _out330;
                      _733_recIdents = _out331;
                      Dafny.ISequence<Dafny.Rune> _734_uneraseFn;
                      _734_uneraseFn = ((_731_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _734_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _730_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _731_recOwned;
                      isErased = true;
                      readIdents = _733_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out332;
                      bool _out333;
                      bool _out334;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _729_b), _729_b, _506_toTpe), selfIdent, @params, mustOwn, out _out332, out _out333, out _out334, out _out335);
                      s = _out332;
                      isOwned = _out333;
                      isErased = _out334;
                      readIdents = _out335;
                    }
                  }
                } else if (_source33.is_Multiset) {
                  DAST._IType _735___mcc_h389 = _source33.dtor_element;
                  DAST._IType _736_b = _676___mcc_h352;
                  {
                    if (object.Equals(_736_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _737_recursiveGen;
                      bool _738_recOwned;
                      bool _739_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _740_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out336;
                      bool _out337;
                      bool _out338;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out336, out _out337, out _out338, out _out339);
                      _737_recursiveGen = _out336;
                      _738_recOwned = _out337;
                      _739_recErased = _out338;
                      _740_recIdents = _out339;
                      Dafny.ISequence<Dafny.Rune> _741_uneraseFn;
                      _741_uneraseFn = ((_738_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _741_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _737_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _738_recOwned;
                      isErased = true;
                      readIdents = _740_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out340;
                      bool _out341;
                      bool _out342;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _736_b), _736_b, _506_toTpe), selfIdent, @params, mustOwn, out _out340, out _out341, out _out342, out _out343);
                      s = _out340;
                      isOwned = _out341;
                      isErased = _out342;
                      readIdents = _out343;
                    }
                  }
                } else if (_source33.is_Map) {
                  DAST._IType _742___mcc_h392 = _source33.dtor_key;
                  DAST._IType _743___mcc_h393 = _source33.dtor_value;
                  DAST._IType _744_b = _676___mcc_h352;
                  {
                    if (object.Equals(_744_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _745_recursiveGen;
                      bool _746_recOwned;
                      bool _747_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _748_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out344;
                      bool _out345;
                      bool _out346;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out344, out _out345, out _out346, out _out347);
                      _745_recursiveGen = _out344;
                      _746_recOwned = _out345;
                      _747_recErased = _out346;
                      _748_recIdents = _out347;
                      Dafny.ISequence<Dafny.Rune> _749_uneraseFn;
                      _749_uneraseFn = ((_746_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _749_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _745_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _746_recOwned;
                      isErased = true;
                      readIdents = _748_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out348;
                      bool _out349;
                      bool _out350;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _744_b), _744_b, _506_toTpe), selfIdent, @params, mustOwn, out _out348, out _out349, out _out350, out _out351);
                      s = _out348;
                      isOwned = _out349;
                      isErased = _out350;
                      readIdents = _out351;
                    }
                  }
                } else if (_source33.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _750___mcc_h398 = _source33.dtor_args;
                  DAST._IType _751___mcc_h399 = _source33.dtor_result;
                  DAST._IType _752_b = _676___mcc_h352;
                  {
                    if (object.Equals(_752_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _753_recursiveGen;
                      bool _754_recOwned;
                      bool _755_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _756_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out352;
                      bool _out353;
                      bool _out354;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out352, out _out353, out _out354, out _out355);
                      _753_recursiveGen = _out352;
                      _754_recOwned = _out353;
                      _755_recErased = _out354;
                      _756_recIdents = _out355;
                      Dafny.ISequence<Dafny.Rune> _757_uneraseFn;
                      _757_uneraseFn = ((_754_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _757_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _753_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _754_recOwned;
                      isErased = true;
                      readIdents = _756_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out356;
                      bool _out357;
                      bool _out358;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out359;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _752_b), _752_b, _506_toTpe), selfIdent, @params, mustOwn, out _out356, out _out357, out _out358, out _out359);
                      s = _out356;
                      isOwned = _out357;
                      isErased = _out358;
                      readIdents = _out359;
                    }
                  }
                } else if (_source33.is_Primitive) {
                  DAST._IPrimitive _758___mcc_h404 = _source33.dtor_Primitive_a0;
                  DAST._IType _759_b = _676___mcc_h352;
                  {
                    if (object.Equals(_759_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _760_recursiveGen;
                      bool _761_recOwned;
                      bool _762_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _763_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out360;
                      bool _out361;
                      bool _out362;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out363;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out360, out _out361, out _out362, out _out363);
                      _760_recursiveGen = _out360;
                      _761_recOwned = _out361;
                      _762_recErased = _out362;
                      _763_recIdents = _out363;
                      Dafny.ISequence<Dafny.Rune> _764_uneraseFn;
                      _764_uneraseFn = ((_761_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _764_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _760_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _761_recOwned;
                      isErased = true;
                      readIdents = _763_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out364;
                      bool _out365;
                      bool _out366;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out367;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _759_b), _759_b, _506_toTpe), selfIdent, @params, mustOwn, out _out364, out _out365, out _out366, out _out367);
                      s = _out364;
                      isOwned = _out365;
                      isErased = _out366;
                      readIdents = _out367;
                    }
                  }
                } else if (_source33.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _765___mcc_h407 = _source33.dtor_Passthrough_a0;
                  DAST._IType _766_b = _676___mcc_h352;
                  {
                    if (object.Equals(_766_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _767_recursiveGen;
                      bool _768_recOwned;
                      bool _769_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _770_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out368;
                      bool _out369;
                      bool _out370;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out371;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out368, out _out369, out _out370, out _out371);
                      _767_recursiveGen = _out368;
                      _768_recOwned = _out369;
                      _769_recErased = _out370;
                      _770_recIdents = _out371;
                      Dafny.ISequence<Dafny.Rune> _771_uneraseFn;
                      _771_uneraseFn = ((_768_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _771_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _767_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _768_recOwned;
                      isErased = true;
                      readIdents = _770_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out372;
                      bool _out373;
                      bool _out374;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out375;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _766_b), _766_b, _506_toTpe), selfIdent, @params, mustOwn, out _out372, out _out373, out _out374, out _out375);
                      s = _out372;
                      isOwned = _out373;
                      isErased = _out374;
                      readIdents = _out375;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _772___mcc_h410 = _source33.dtor_TypeArg_a0;
                  DAST._IType _773_b = _676___mcc_h352;
                  {
                    if (object.Equals(_773_b, _506_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _774_recursiveGen;
                      bool _775_recOwned;
                      bool _776_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _777_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out376;
                      bool _out377;
                      bool _out378;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out379;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out376, out _out377, out _out378, out _out379);
                      _774_recursiveGen = _out376;
                      _775_recOwned = _out377;
                      _776_recErased = _out378;
                      _777_recIdents = _out379;
                      Dafny.ISequence<Dafny.Rune> _778_uneraseFn;
                      _778_uneraseFn = ((_775_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _778_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _774_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _775_recOwned;
                      isErased = true;
                      readIdents = _777_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out380;
                      bool _out381;
                      bool _out382;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out383;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _773_b), _773_b, _506_toTpe), selfIdent, @params, mustOwn, out _out380, out _out381, out _out382, out _out383);
                      s = _out380;
                      isOwned = _out381;
                      isErased = _out382;
                      readIdents = _out383;
                    }
                  }
                }
              }
            } else if (_source27.is_Nullable) {
              DAST._IType _779___mcc_h413 = _source27.dtor_Nullable_a0;
              DAST._IType _source35 = _514___mcc_h253;
              if (_source35.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _780___mcc_h417 = _source35.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _781___mcc_h418 = _source35.dtor_typeArgs;
                DAST._IResolvedType _782___mcc_h419 = _source35.dtor_resolved;
                DAST._IResolvedType _source36 = _782___mcc_h419;
                if (_source36.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _783___mcc_h426 = _source36.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _784_recursiveGen;
                    bool _785_recOwned;
                    bool _786_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _787_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out384;
                    bool _out385;
                    bool _out386;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out387;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out384, out _out385, out _out386, out _out387);
                    _784_recursiveGen = _out384;
                    _785_recOwned = _out385;
                    _786_recErased = _out386;
                    _787_recIdents = _out387;
                    if (!(_785_recOwned)) {
                      _784_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_784_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_784_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _785_recOwned;
                    isErased = _786_recErased;
                    readIdents = _787_recIdents;
                  }
                } else if (_source36.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _788___mcc_h429 = _source36.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _789_recursiveGen;
                    bool _790_recOwned;
                    bool _791_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _792_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out388;
                    bool _out389;
                    bool _out390;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out391;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out388, out _out389, out _out390, out _out391);
                    _789_recursiveGen = _out388;
                    _790_recOwned = _out389;
                    _791_recErased = _out390;
                    _792_recIdents = _out391;
                    if (!(_790_recOwned)) {
                      _789_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_789_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_789_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _790_recOwned;
                    isErased = _791_recErased;
                    readIdents = _792_recIdents;
                  }
                } else {
                  DAST._IType _793___mcc_h432 = _source36.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _794_recursiveGen;
                    bool _795_recOwned;
                    bool _796_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _797_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out392;
                    bool _out393;
                    bool _out394;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out395;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out392, out _out393, out _out394, out _out395);
                    _794_recursiveGen = _out392;
                    _795_recOwned = _out393;
                    _796_recErased = _out394;
                    _797_recIdents = _out395;
                    if (!(_795_recOwned)) {
                      _794_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_794_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_794_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _795_recOwned;
                    isErased = _796_recErased;
                    readIdents = _797_recIdents;
                  }
                }
              } else if (_source35.is_Nullable) {
                DAST._IType _798___mcc_h435 = _source35.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _799_recursiveGen;
                  bool _800_recOwned;
                  bool _801_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _802_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out396;
                  bool _out397;
                  bool _out398;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out399;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out396, out _out397, out _out398, out _out399);
                  _799_recursiveGen = _out396;
                  _800_recOwned = _out397;
                  _801_recErased = _out398;
                  _802_recIdents = _out399;
                  if (!(_800_recOwned)) {
                    _799_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_799_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_799_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _800_recOwned;
                  isErased = _801_recErased;
                  readIdents = _802_recIdents;
                }
              } else if (_source35.is_Tuple) {
                Dafny.ISequence<DAST._IType> _803___mcc_h438 = _source35.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _804_recursiveGen;
                  bool _805_recOwned;
                  bool _806_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _807_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out400;
                  bool _out401;
                  bool _out402;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out403;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out400, out _out401, out _out402, out _out403);
                  _804_recursiveGen = _out400;
                  _805_recOwned = _out401;
                  _806_recErased = _out402;
                  _807_recIdents = _out403;
                  if (!(_805_recOwned)) {
                    _804_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_804_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_804_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _805_recOwned;
                  isErased = _806_recErased;
                  readIdents = _807_recIdents;
                }
              } else if (_source35.is_Array) {
                DAST._IType _808___mcc_h441 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _809_recursiveGen;
                  bool _810_recOwned;
                  bool _811_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _812_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out404;
                  bool _out405;
                  bool _out406;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out407;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out404, out _out405, out _out406, out _out407);
                  _809_recursiveGen = _out404;
                  _810_recOwned = _out405;
                  _811_recErased = _out406;
                  _812_recIdents = _out407;
                  if (!(_810_recOwned)) {
                    _809_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_809_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_809_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _810_recOwned;
                  isErased = _811_recErased;
                  readIdents = _812_recIdents;
                }
              } else if (_source35.is_Seq) {
                DAST._IType _813___mcc_h444 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _814_recursiveGen;
                  bool _815_recOwned;
                  bool _816_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _817_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out408;
                  bool _out409;
                  bool _out410;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out411;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out408, out _out409, out _out410, out _out411);
                  _814_recursiveGen = _out408;
                  _815_recOwned = _out409;
                  _816_recErased = _out410;
                  _817_recIdents = _out411;
                  if (!(_815_recOwned)) {
                    _814_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_814_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_814_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _815_recOwned;
                  isErased = _816_recErased;
                  readIdents = _817_recIdents;
                }
              } else if (_source35.is_Set) {
                DAST._IType _818___mcc_h447 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _819_recursiveGen;
                  bool _820_recOwned;
                  bool _821_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _822_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out412;
                  bool _out413;
                  bool _out414;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out415;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out412, out _out413, out _out414, out _out415);
                  _819_recursiveGen = _out412;
                  _820_recOwned = _out413;
                  _821_recErased = _out414;
                  _822_recIdents = _out415;
                  if (!(_820_recOwned)) {
                    _819_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_819_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_819_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _820_recOwned;
                  isErased = _821_recErased;
                  readIdents = _822_recIdents;
                }
              } else if (_source35.is_Multiset) {
                DAST._IType _823___mcc_h450 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _824_recursiveGen;
                  bool _825_recOwned;
                  bool _826_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _827_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out416;
                  bool _out417;
                  bool _out418;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out419;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out416, out _out417, out _out418, out _out419);
                  _824_recursiveGen = _out416;
                  _825_recOwned = _out417;
                  _826_recErased = _out418;
                  _827_recIdents = _out419;
                  if (!(_825_recOwned)) {
                    _824_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_824_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_824_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _825_recOwned;
                  isErased = _826_recErased;
                  readIdents = _827_recIdents;
                }
              } else if (_source35.is_Map) {
                DAST._IType _828___mcc_h453 = _source35.dtor_key;
                DAST._IType _829___mcc_h454 = _source35.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _830_recursiveGen;
                  bool _831_recOwned;
                  bool _832_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _833_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out420;
                  bool _out421;
                  bool _out422;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out423;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out420, out _out421, out _out422, out _out423);
                  _830_recursiveGen = _out420;
                  _831_recOwned = _out421;
                  _832_recErased = _out422;
                  _833_recIdents = _out423;
                  if (!(_831_recOwned)) {
                    _830_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_830_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_830_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _831_recOwned;
                  isErased = _832_recErased;
                  readIdents = _833_recIdents;
                }
              } else if (_source35.is_Arrow) {
                Dafny.ISequence<DAST._IType> _834___mcc_h459 = _source35.dtor_args;
                DAST._IType _835___mcc_h460 = _source35.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _836_recursiveGen;
                  bool _837_recOwned;
                  bool _838_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _839_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out424;
                  bool _out425;
                  bool _out426;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out427;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out424, out _out425, out _out426, out _out427);
                  _836_recursiveGen = _out424;
                  _837_recOwned = _out425;
                  _838_recErased = _out426;
                  _839_recIdents = _out427;
                  if (!(_837_recOwned)) {
                    _836_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_836_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_836_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _837_recOwned;
                  isErased = _838_recErased;
                  readIdents = _839_recIdents;
                }
              } else if (_source35.is_Primitive) {
                DAST._IPrimitive _840___mcc_h465 = _source35.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _841_recursiveGen;
                  bool _842_recOwned;
                  bool _843_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _844_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out428;
                  bool _out429;
                  bool _out430;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out431;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out428, out _out429, out _out430, out _out431);
                  _841_recursiveGen = _out428;
                  _842_recOwned = _out429;
                  _843_recErased = _out430;
                  _844_recIdents = _out431;
                  if (!(_842_recOwned)) {
                    _841_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_841_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_841_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _842_recOwned;
                  isErased = _843_recErased;
                  readIdents = _844_recIdents;
                }
              } else if (_source35.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _845___mcc_h468 = _source35.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _846_recursiveGen;
                  bool _847_recOwned;
                  bool _848_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _849_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out432;
                  bool _out433;
                  bool _out434;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out435;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out432, out _out433, out _out434, out _out435);
                  _846_recursiveGen = _out432;
                  _847_recOwned = _out433;
                  _848_recErased = _out434;
                  _849_recIdents = _out435;
                  if (!(_847_recOwned)) {
                    _846_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_846_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_846_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _847_recOwned;
                  isErased = _848_recErased;
                  readIdents = _849_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _850___mcc_h471 = _source35.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _851_recursiveGen;
                  bool _852_recOwned;
                  bool _853_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _854_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out436;
                  bool _out437;
                  bool _out438;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out439;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out436, out _out437, out _out438, out _out439);
                  _851_recursiveGen = _out436;
                  _852_recOwned = _out437;
                  _853_recErased = _out438;
                  _854_recIdents = _out439;
                  if (!(_852_recOwned)) {
                    _851_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_851_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_851_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _852_recOwned;
                  isErased = _853_recErased;
                  readIdents = _854_recIdents;
                }
              }
            } else if (_source27.is_Tuple) {
              Dafny.ISequence<DAST._IType> _855___mcc_h474 = _source27.dtor_Tuple_a0;
              DAST._IType _source37 = _514___mcc_h253;
              if (_source37.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _856___mcc_h478 = _source37.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _857___mcc_h479 = _source37.dtor_typeArgs;
                DAST._IResolvedType _858___mcc_h480 = _source37.dtor_resolved;
                DAST._IResolvedType _source38 = _858___mcc_h480;
                if (_source38.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _859___mcc_h484 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _860_recursiveGen;
                    bool _861_recOwned;
                    bool _862_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _863_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out440;
                    bool _out441;
                    bool _out442;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out443;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out440, out _out441, out _out442, out _out443);
                    _860_recursiveGen = _out440;
                    _861_recOwned = _out441;
                    _862_recErased = _out442;
                    _863_recIdents = _out443;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _860_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _861_recOwned;
                    isErased = _862_recErased;
                    readIdents = _863_recIdents;
                  }
                } else if (_source38.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _864___mcc_h486 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _865_recursiveGen;
                    bool _866_recOwned;
                    bool _867_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _868_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out444;
                    bool _out445;
                    bool _out446;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out447;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out444, out _out445, out _out446, out _out447);
                    _865_recursiveGen = _out444;
                    _866_recOwned = _out445;
                    _867_recErased = _out446;
                    _868_recIdents = _out447;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _865_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _866_recOwned;
                    isErased = _867_recErased;
                    readIdents = _868_recIdents;
                  }
                } else {
                  DAST._IType _869___mcc_h488 = _source38.dtor_Newtype_a0;
                  DAST._IType _870_b = _869___mcc_h488;
                  {
                    if (object.Equals(_507_fromTpe, _870_b)) {
                      Dafny.ISequence<Dafny.Rune> _871_recursiveGen;
                      bool _872_recOwned;
                      bool _873_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _874_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out448;
                      bool _out449;
                      bool _out450;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out451;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out448, out _out449, out _out450, out _out451);
                      _871_recursiveGen = _out448;
                      _872_recOwned = _out449;
                      _873_recErased = _out450;
                      _874_recIdents = _out451;
                      Dafny.ISequence<Dafny.Rune> _875_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out452;
                      _out452 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _875_rhsType = _out452;
                      Dafny.ISequence<Dafny.Rune> _876_uneraseFn;
                      _876_uneraseFn = ((_872_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _875_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _876_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _871_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _872_recOwned;
                      isErased = false;
                      readIdents = _874_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out453;
                      bool _out454;
                      bool _out455;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out456;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _870_b), _870_b, _506_toTpe), selfIdent, @params, mustOwn, out _out453, out _out454, out _out455, out _out456);
                      s = _out453;
                      isOwned = _out454;
                      isErased = _out455;
                      readIdents = _out456;
                    }
                  }
                }
              } else if (_source37.is_Nullable) {
                DAST._IType _877___mcc_h490 = _source37.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _878_recursiveGen;
                  bool _879_recOwned;
                  bool _880_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _881_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out457;
                  bool _out458;
                  bool _out459;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out460;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out457, out _out458, out _out459, out _out460);
                  _878_recursiveGen = _out457;
                  _879_recOwned = _out458;
                  _880_recErased = _out459;
                  _881_recIdents = _out460;
                  if (!(_879_recOwned)) {
                    _878_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_878_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _878_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _880_recErased;
                  readIdents = _881_recIdents;
                }
              } else if (_source37.is_Tuple) {
                Dafny.ISequence<DAST._IType> _882___mcc_h492 = _source37.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _883_recursiveGen;
                  bool _884_recOwned;
                  bool _885_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _886_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out461;
                  bool _out462;
                  bool _out463;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out464;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out461, out _out462, out _out463, out _out464);
                  _883_recursiveGen = _out461;
                  _884_recOwned = _out462;
                  _885_recErased = _out463;
                  _886_recIdents = _out464;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _883_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _884_recOwned;
                  isErased = _885_recErased;
                  readIdents = _886_recIdents;
                }
              } else if (_source37.is_Array) {
                DAST._IType _887___mcc_h494 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _888_recursiveGen;
                  bool _889_recOwned;
                  bool _890_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _891_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out465;
                  bool _out466;
                  bool _out467;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out468;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out465, out _out466, out _out467, out _out468);
                  _888_recursiveGen = _out465;
                  _889_recOwned = _out466;
                  _890_recErased = _out467;
                  _891_recIdents = _out468;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _888_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _889_recOwned;
                  isErased = _890_recErased;
                  readIdents = _891_recIdents;
                }
              } else if (_source37.is_Seq) {
                DAST._IType _892___mcc_h496 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _893_recursiveGen;
                  bool _894_recOwned;
                  bool _895_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _896_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out469;
                  bool _out470;
                  bool _out471;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out472;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out469, out _out470, out _out471, out _out472);
                  _893_recursiveGen = _out469;
                  _894_recOwned = _out470;
                  _895_recErased = _out471;
                  _896_recIdents = _out472;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _893_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _894_recOwned;
                  isErased = _895_recErased;
                  readIdents = _896_recIdents;
                }
              } else if (_source37.is_Set) {
                DAST._IType _897___mcc_h498 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _898_recursiveGen;
                  bool _899_recOwned;
                  bool _900_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _901_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out473;
                  bool _out474;
                  bool _out475;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out476;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out473, out _out474, out _out475, out _out476);
                  _898_recursiveGen = _out473;
                  _899_recOwned = _out474;
                  _900_recErased = _out475;
                  _901_recIdents = _out476;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _898_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _899_recOwned;
                  isErased = _900_recErased;
                  readIdents = _901_recIdents;
                }
              } else if (_source37.is_Multiset) {
                DAST._IType _902___mcc_h500 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _903_recursiveGen;
                  bool _904_recOwned;
                  bool _905_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _906_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out477;
                  bool _out478;
                  bool _out479;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out480;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out477, out _out478, out _out479, out _out480);
                  _903_recursiveGen = _out477;
                  _904_recOwned = _out478;
                  _905_recErased = _out479;
                  _906_recIdents = _out480;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _903_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _904_recOwned;
                  isErased = _905_recErased;
                  readIdents = _906_recIdents;
                }
              } else if (_source37.is_Map) {
                DAST._IType _907___mcc_h502 = _source37.dtor_key;
                DAST._IType _908___mcc_h503 = _source37.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _909_recursiveGen;
                  bool _910_recOwned;
                  bool _911_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _912_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out481;
                  bool _out482;
                  bool _out483;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out484;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out481, out _out482, out _out483, out _out484);
                  _909_recursiveGen = _out481;
                  _910_recOwned = _out482;
                  _911_recErased = _out483;
                  _912_recIdents = _out484;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _909_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _910_recOwned;
                  isErased = _911_recErased;
                  readIdents = _912_recIdents;
                }
              } else if (_source37.is_Arrow) {
                Dafny.ISequence<DAST._IType> _913___mcc_h506 = _source37.dtor_args;
                DAST._IType _914___mcc_h507 = _source37.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _915_recursiveGen;
                  bool _916_recOwned;
                  bool _917_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _918_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out485;
                  bool _out486;
                  bool _out487;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out488;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out485, out _out486, out _out487, out _out488);
                  _915_recursiveGen = _out485;
                  _916_recOwned = _out486;
                  _917_recErased = _out487;
                  _918_recIdents = _out488;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _915_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _916_recOwned;
                  isErased = _917_recErased;
                  readIdents = _918_recIdents;
                }
              } else if (_source37.is_Primitive) {
                DAST._IPrimitive _919___mcc_h510 = _source37.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _920_recursiveGen;
                  bool _921_recOwned;
                  bool _922_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _923_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out489;
                  bool _out490;
                  bool _out491;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out492;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out489, out _out490, out _out491, out _out492);
                  _920_recursiveGen = _out489;
                  _921_recOwned = _out490;
                  _922_recErased = _out491;
                  _923_recIdents = _out492;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _920_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _921_recOwned;
                  isErased = _922_recErased;
                  readIdents = _923_recIdents;
                }
              } else if (_source37.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _924___mcc_h512 = _source37.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _925_recursiveGen;
                  bool _926_recOwned;
                  bool _927_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _928_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out493;
                  bool _out494;
                  bool _out495;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out496;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out493, out _out494, out _out495, out _out496);
                  _925_recursiveGen = _out493;
                  _926_recOwned = _out494;
                  _927_recErased = _out495;
                  _928_recIdents = _out496;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _926_recOwned;
                  isErased = _927_recErased;
                  readIdents = _928_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _929___mcc_h514 = _source37.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _930_recursiveGen;
                  bool _931_recOwned;
                  bool _932_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _933_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out497;
                  bool _out498;
                  bool _out499;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out500;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out497, out _out498, out _out499, out _out500);
                  _930_recursiveGen = _out497;
                  _931_recOwned = _out498;
                  _932_recErased = _out499;
                  _933_recIdents = _out500;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _931_recOwned;
                  isErased = _932_recErased;
                  readIdents = _933_recIdents;
                }
              }
            } else if (_source27.is_Array) {
              DAST._IType _934___mcc_h516 = _source27.dtor_element;
              DAST._IType _source39 = _514___mcc_h253;
              if (_source39.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _935___mcc_h520 = _source39.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _936___mcc_h521 = _source39.dtor_typeArgs;
                DAST._IResolvedType _937___mcc_h522 = _source39.dtor_resolved;
                DAST._IResolvedType _source40 = _937___mcc_h522;
                if (_source40.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _938___mcc_h526 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _939_recursiveGen;
                    bool _940_recOwned;
                    bool _941_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _942_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out501;
                    bool _out502;
                    bool _out503;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out504;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out501, out _out502, out _out503, out _out504);
                    _939_recursiveGen = _out501;
                    _940_recOwned = _out502;
                    _941_recErased = _out503;
                    _942_recIdents = _out504;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _939_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _940_recOwned;
                    isErased = _941_recErased;
                    readIdents = _942_recIdents;
                  }
                } else if (_source40.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _943___mcc_h528 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _944_recursiveGen;
                    bool _945_recOwned;
                    bool _946_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _947_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out505;
                    bool _out506;
                    bool _out507;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out508;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out505, out _out506, out _out507, out _out508);
                    _944_recursiveGen = _out505;
                    _945_recOwned = _out506;
                    _946_recErased = _out507;
                    _947_recIdents = _out508;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _944_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _945_recOwned;
                    isErased = _946_recErased;
                    readIdents = _947_recIdents;
                  }
                } else {
                  DAST._IType _948___mcc_h530 = _source40.dtor_Newtype_a0;
                  DAST._IType _949_b = _948___mcc_h530;
                  {
                    if (object.Equals(_507_fromTpe, _949_b)) {
                      Dafny.ISequence<Dafny.Rune> _950_recursiveGen;
                      bool _951_recOwned;
                      bool _952_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _953_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out509;
                      bool _out510;
                      bool _out511;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out512;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out509, out _out510, out _out511, out _out512);
                      _950_recursiveGen = _out509;
                      _951_recOwned = _out510;
                      _952_recErased = _out511;
                      _953_recIdents = _out512;
                      Dafny.ISequence<Dafny.Rune> _954_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out513;
                      _out513 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _954_rhsType = _out513;
                      Dafny.ISequence<Dafny.Rune> _955_uneraseFn;
                      _955_uneraseFn = ((_951_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _954_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _955_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _950_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _951_recOwned;
                      isErased = false;
                      readIdents = _953_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out514;
                      bool _out515;
                      bool _out516;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out517;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _949_b), _949_b, _506_toTpe), selfIdent, @params, mustOwn, out _out514, out _out515, out _out516, out _out517);
                      s = _out514;
                      isOwned = _out515;
                      isErased = _out516;
                      readIdents = _out517;
                    }
                  }
                }
              } else if (_source39.is_Nullable) {
                DAST._IType _956___mcc_h532 = _source39.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _957_recursiveGen;
                  bool _958_recOwned;
                  bool _959_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _960_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out518;
                  bool _out519;
                  bool _out520;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out521;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out518, out _out519, out _out520, out _out521);
                  _957_recursiveGen = _out518;
                  _958_recOwned = _out519;
                  _959_recErased = _out520;
                  _960_recIdents = _out521;
                  if (!(_958_recOwned)) {
                    _957_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_957_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _957_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _959_recErased;
                  readIdents = _960_recIdents;
                }
              } else if (_source39.is_Tuple) {
                Dafny.ISequence<DAST._IType> _961___mcc_h534 = _source39.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _962_recursiveGen;
                  bool _963_recOwned;
                  bool _964_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _965_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out522;
                  bool _out523;
                  bool _out524;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out525;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out522, out _out523, out _out524, out _out525);
                  _962_recursiveGen = _out522;
                  _963_recOwned = _out523;
                  _964_recErased = _out524;
                  _965_recIdents = _out525;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _962_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _963_recOwned;
                  isErased = _964_recErased;
                  readIdents = _965_recIdents;
                }
              } else if (_source39.is_Array) {
                DAST._IType _966___mcc_h536 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _967_recursiveGen;
                  bool _968_recOwned;
                  bool _969_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _970_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out526;
                  bool _out527;
                  bool _out528;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out529;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out526, out _out527, out _out528, out _out529);
                  _967_recursiveGen = _out526;
                  _968_recOwned = _out527;
                  _969_recErased = _out528;
                  _970_recIdents = _out529;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _967_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _968_recOwned;
                  isErased = _969_recErased;
                  readIdents = _970_recIdents;
                }
              } else if (_source39.is_Seq) {
                DAST._IType _971___mcc_h538 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _972_recursiveGen;
                  bool _973_recOwned;
                  bool _974_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _975_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out530;
                  bool _out531;
                  bool _out532;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out533;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out530, out _out531, out _out532, out _out533);
                  _972_recursiveGen = _out530;
                  _973_recOwned = _out531;
                  _974_recErased = _out532;
                  _975_recIdents = _out533;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _972_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _973_recOwned;
                  isErased = _974_recErased;
                  readIdents = _975_recIdents;
                }
              } else if (_source39.is_Set) {
                DAST._IType _976___mcc_h540 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _977_recursiveGen;
                  bool _978_recOwned;
                  bool _979_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _980_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out534;
                  bool _out535;
                  bool _out536;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out537;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out534, out _out535, out _out536, out _out537);
                  _977_recursiveGen = _out534;
                  _978_recOwned = _out535;
                  _979_recErased = _out536;
                  _980_recIdents = _out537;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _977_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _978_recOwned;
                  isErased = _979_recErased;
                  readIdents = _980_recIdents;
                }
              } else if (_source39.is_Multiset) {
                DAST._IType _981___mcc_h542 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _982_recursiveGen;
                  bool _983_recOwned;
                  bool _984_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _985_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out538;
                  bool _out539;
                  bool _out540;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out541;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out538, out _out539, out _out540, out _out541);
                  _982_recursiveGen = _out538;
                  _983_recOwned = _out539;
                  _984_recErased = _out540;
                  _985_recIdents = _out541;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _982_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _983_recOwned;
                  isErased = _984_recErased;
                  readIdents = _985_recIdents;
                }
              } else if (_source39.is_Map) {
                DAST._IType _986___mcc_h544 = _source39.dtor_key;
                DAST._IType _987___mcc_h545 = _source39.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _988_recursiveGen;
                  bool _989_recOwned;
                  bool _990_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _991_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out542;
                  bool _out543;
                  bool _out544;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out545;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out542, out _out543, out _out544, out _out545);
                  _988_recursiveGen = _out542;
                  _989_recOwned = _out543;
                  _990_recErased = _out544;
                  _991_recIdents = _out545;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _988_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _989_recOwned;
                  isErased = _990_recErased;
                  readIdents = _991_recIdents;
                }
              } else if (_source39.is_Arrow) {
                Dafny.ISequence<DAST._IType> _992___mcc_h548 = _source39.dtor_args;
                DAST._IType _993___mcc_h549 = _source39.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _994_recursiveGen;
                  bool _995_recOwned;
                  bool _996_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _997_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out546;
                  bool _out547;
                  bool _out548;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out549;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out546, out _out547, out _out548, out _out549);
                  _994_recursiveGen = _out546;
                  _995_recOwned = _out547;
                  _996_recErased = _out548;
                  _997_recIdents = _out549;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _994_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _995_recOwned;
                  isErased = _996_recErased;
                  readIdents = _997_recIdents;
                }
              } else if (_source39.is_Primitive) {
                DAST._IPrimitive _998___mcc_h552 = _source39.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _999_recursiveGen;
                  bool _1000_recOwned;
                  bool _1001_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1002_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out550;
                  bool _out551;
                  bool _out552;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out553;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out550, out _out551, out _out552, out _out553);
                  _999_recursiveGen = _out550;
                  _1000_recOwned = _out551;
                  _1001_recErased = _out552;
                  _1002_recIdents = _out553;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _999_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1000_recOwned;
                  isErased = _1001_recErased;
                  readIdents = _1002_recIdents;
                }
              } else if (_source39.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1003___mcc_h554 = _source39.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1004_recursiveGen;
                  bool _1005_recOwned;
                  bool _1006_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1007_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out554;
                  bool _out555;
                  bool _out556;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out557;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out554, out _out555, out _out556, out _out557);
                  _1004_recursiveGen = _out554;
                  _1005_recOwned = _out555;
                  _1006_recErased = _out556;
                  _1007_recIdents = _out557;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1004_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1005_recOwned;
                  isErased = _1006_recErased;
                  readIdents = _1007_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1008___mcc_h556 = _source39.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1009_recursiveGen;
                  bool _1010_recOwned;
                  bool _1011_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1012_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out558;
                  bool _out559;
                  bool _out560;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out561;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out558, out _out559, out _out560, out _out561);
                  _1009_recursiveGen = _out558;
                  _1010_recOwned = _out559;
                  _1011_recErased = _out560;
                  _1012_recIdents = _out561;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1010_recOwned;
                  isErased = _1011_recErased;
                  readIdents = _1012_recIdents;
                }
              }
            } else if (_source27.is_Seq) {
              DAST._IType _1013___mcc_h558 = _source27.dtor_element;
              DAST._IType _source41 = _514___mcc_h253;
              if (_source41.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1014___mcc_h562 = _source41.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1015___mcc_h563 = _source41.dtor_typeArgs;
                DAST._IResolvedType _1016___mcc_h564 = _source41.dtor_resolved;
                DAST._IResolvedType _source42 = _1016___mcc_h564;
                if (_source42.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1017___mcc_h568 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1018_recursiveGen;
                    bool _1019_recOwned;
                    bool _1020_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1021_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out562;
                    bool _out563;
                    bool _out564;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out565;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out562, out _out563, out _out564, out _out565);
                    _1018_recursiveGen = _out562;
                    _1019_recOwned = _out563;
                    _1020_recErased = _out564;
                    _1021_recIdents = _out565;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1018_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1019_recOwned;
                    isErased = _1020_recErased;
                    readIdents = _1021_recIdents;
                  }
                } else if (_source42.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1022___mcc_h570 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1023_recursiveGen;
                    bool _1024_recOwned;
                    bool _1025_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1026_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out566;
                    bool _out567;
                    bool _out568;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out569;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out566, out _out567, out _out568, out _out569);
                    _1023_recursiveGen = _out566;
                    _1024_recOwned = _out567;
                    _1025_recErased = _out568;
                    _1026_recIdents = _out569;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1023_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1024_recOwned;
                    isErased = _1025_recErased;
                    readIdents = _1026_recIdents;
                  }
                } else {
                  DAST._IType _1027___mcc_h572 = _source42.dtor_Newtype_a0;
                  DAST._IType _1028_b = _1027___mcc_h572;
                  {
                    if (object.Equals(_507_fromTpe, _1028_b)) {
                      Dafny.ISequence<Dafny.Rune> _1029_recursiveGen;
                      bool _1030_recOwned;
                      bool _1031_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1032_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out570;
                      bool _out571;
                      bool _out572;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out573;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out570, out _out571, out _out572, out _out573);
                      _1029_recursiveGen = _out570;
                      _1030_recOwned = _out571;
                      _1031_recErased = _out572;
                      _1032_recIdents = _out573;
                      Dafny.ISequence<Dafny.Rune> _1033_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out574;
                      _out574 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _1033_rhsType = _out574;
                      Dafny.ISequence<Dafny.Rune> _1034_uneraseFn;
                      _1034_uneraseFn = ((_1030_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1033_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1034_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1029_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1030_recOwned;
                      isErased = false;
                      readIdents = _1032_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out575;
                      bool _out576;
                      bool _out577;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out578;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1028_b), _1028_b, _506_toTpe), selfIdent, @params, mustOwn, out _out575, out _out576, out _out577, out _out578);
                      s = _out575;
                      isOwned = _out576;
                      isErased = _out577;
                      readIdents = _out578;
                    }
                  }
                }
              } else if (_source41.is_Nullable) {
                DAST._IType _1035___mcc_h574 = _source41.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1036_recursiveGen;
                  bool _1037_recOwned;
                  bool _1038_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1039_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out579;
                  bool _out580;
                  bool _out581;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out582;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out579, out _out580, out _out581, out _out582);
                  _1036_recursiveGen = _out579;
                  _1037_recOwned = _out580;
                  _1038_recErased = _out581;
                  _1039_recIdents = _out582;
                  if (!(_1037_recOwned)) {
                    _1036_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1036_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1036_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1038_recErased;
                  readIdents = _1039_recIdents;
                }
              } else if (_source41.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1040___mcc_h576 = _source41.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1041_recursiveGen;
                  bool _1042_recOwned;
                  bool _1043_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1044_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out583;
                  bool _out584;
                  bool _out585;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out586;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out583, out _out584, out _out585, out _out586);
                  _1041_recursiveGen = _out583;
                  _1042_recOwned = _out584;
                  _1043_recErased = _out585;
                  _1044_recIdents = _out586;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1041_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1042_recOwned;
                  isErased = _1043_recErased;
                  readIdents = _1044_recIdents;
                }
              } else if (_source41.is_Array) {
                DAST._IType _1045___mcc_h578 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1046_recursiveGen;
                  bool _1047_recOwned;
                  bool _1048_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1049_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out587;
                  bool _out588;
                  bool _out589;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out590;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out587, out _out588, out _out589, out _out590);
                  _1046_recursiveGen = _out587;
                  _1047_recOwned = _out588;
                  _1048_recErased = _out589;
                  _1049_recIdents = _out590;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1046_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1047_recOwned;
                  isErased = _1048_recErased;
                  readIdents = _1049_recIdents;
                }
              } else if (_source41.is_Seq) {
                DAST._IType _1050___mcc_h580 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1051_recursiveGen;
                  bool _1052_recOwned;
                  bool _1053_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1054_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out591;
                  bool _out592;
                  bool _out593;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out594;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out591, out _out592, out _out593, out _out594);
                  _1051_recursiveGen = _out591;
                  _1052_recOwned = _out592;
                  _1053_recErased = _out593;
                  _1054_recIdents = _out594;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1051_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1052_recOwned;
                  isErased = _1053_recErased;
                  readIdents = _1054_recIdents;
                }
              } else if (_source41.is_Set) {
                DAST._IType _1055___mcc_h582 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1056_recursiveGen;
                  bool _1057_recOwned;
                  bool _1058_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1059_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out595;
                  bool _out596;
                  bool _out597;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out598;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out595, out _out596, out _out597, out _out598);
                  _1056_recursiveGen = _out595;
                  _1057_recOwned = _out596;
                  _1058_recErased = _out597;
                  _1059_recIdents = _out598;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1056_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1057_recOwned;
                  isErased = _1058_recErased;
                  readIdents = _1059_recIdents;
                }
              } else if (_source41.is_Multiset) {
                DAST._IType _1060___mcc_h584 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1061_recursiveGen;
                  bool _1062_recOwned;
                  bool _1063_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1064_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out599;
                  bool _out600;
                  bool _out601;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out602;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out599, out _out600, out _out601, out _out602);
                  _1061_recursiveGen = _out599;
                  _1062_recOwned = _out600;
                  _1063_recErased = _out601;
                  _1064_recIdents = _out602;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1061_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1062_recOwned;
                  isErased = _1063_recErased;
                  readIdents = _1064_recIdents;
                }
              } else if (_source41.is_Map) {
                DAST._IType _1065___mcc_h586 = _source41.dtor_key;
                DAST._IType _1066___mcc_h587 = _source41.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1067_recursiveGen;
                  bool _1068_recOwned;
                  bool _1069_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1070_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out603;
                  bool _out604;
                  bool _out605;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out606;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out603, out _out604, out _out605, out _out606);
                  _1067_recursiveGen = _out603;
                  _1068_recOwned = _out604;
                  _1069_recErased = _out605;
                  _1070_recIdents = _out606;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1067_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1068_recOwned;
                  isErased = _1069_recErased;
                  readIdents = _1070_recIdents;
                }
              } else if (_source41.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1071___mcc_h590 = _source41.dtor_args;
                DAST._IType _1072___mcc_h591 = _source41.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1073_recursiveGen;
                  bool _1074_recOwned;
                  bool _1075_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1076_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out607;
                  bool _out608;
                  bool _out609;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out610;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out607, out _out608, out _out609, out _out610);
                  _1073_recursiveGen = _out607;
                  _1074_recOwned = _out608;
                  _1075_recErased = _out609;
                  _1076_recIdents = _out610;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1073_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1074_recOwned;
                  isErased = _1075_recErased;
                  readIdents = _1076_recIdents;
                }
              } else if (_source41.is_Primitive) {
                DAST._IPrimitive _1077___mcc_h594 = _source41.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1078_recursiveGen;
                  bool _1079_recOwned;
                  bool _1080_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1081_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out611;
                  bool _out612;
                  bool _out613;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out614;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out611, out _out612, out _out613, out _out614);
                  _1078_recursiveGen = _out611;
                  _1079_recOwned = _out612;
                  _1080_recErased = _out613;
                  _1081_recIdents = _out614;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1078_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1079_recOwned;
                  isErased = _1080_recErased;
                  readIdents = _1081_recIdents;
                }
              } else if (_source41.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1082___mcc_h596 = _source41.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1083_recursiveGen;
                  bool _1084_recOwned;
                  bool _1085_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1086_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out615;
                  bool _out616;
                  bool _out617;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out618;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out615, out _out616, out _out617, out _out618);
                  _1083_recursiveGen = _out615;
                  _1084_recOwned = _out616;
                  _1085_recErased = _out617;
                  _1086_recIdents = _out618;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1083_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1084_recOwned;
                  isErased = _1085_recErased;
                  readIdents = _1086_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1087___mcc_h598 = _source41.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1088_recursiveGen;
                  bool _1089_recOwned;
                  bool _1090_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1091_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out619;
                  bool _out620;
                  bool _out621;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out622;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out619, out _out620, out _out621, out _out622);
                  _1088_recursiveGen = _out619;
                  _1089_recOwned = _out620;
                  _1090_recErased = _out621;
                  _1091_recIdents = _out622;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1088_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1089_recOwned;
                  isErased = _1090_recErased;
                  readIdents = _1091_recIdents;
                }
              }
            } else if (_source27.is_Set) {
              DAST._IType _1092___mcc_h600 = _source27.dtor_element;
              DAST._IType _source43 = _514___mcc_h253;
              if (_source43.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1093___mcc_h604 = _source43.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1094___mcc_h605 = _source43.dtor_typeArgs;
                DAST._IResolvedType _1095___mcc_h606 = _source43.dtor_resolved;
                DAST._IResolvedType _source44 = _1095___mcc_h606;
                if (_source44.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1096___mcc_h610 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1097_recursiveGen;
                    bool _1098_recOwned;
                    bool _1099_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1100_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out623;
                    bool _out624;
                    bool _out625;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out626;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out623, out _out624, out _out625, out _out626);
                    _1097_recursiveGen = _out623;
                    _1098_recOwned = _out624;
                    _1099_recErased = _out625;
                    _1100_recIdents = _out626;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1097_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1098_recOwned;
                    isErased = _1099_recErased;
                    readIdents = _1100_recIdents;
                  }
                } else if (_source44.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1101___mcc_h612 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1102_recursiveGen;
                    bool _1103_recOwned;
                    bool _1104_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1105_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out627;
                    bool _out628;
                    bool _out629;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out630;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out627, out _out628, out _out629, out _out630);
                    _1102_recursiveGen = _out627;
                    _1103_recOwned = _out628;
                    _1104_recErased = _out629;
                    _1105_recIdents = _out630;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1102_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1103_recOwned;
                    isErased = _1104_recErased;
                    readIdents = _1105_recIdents;
                  }
                } else {
                  DAST._IType _1106___mcc_h614 = _source44.dtor_Newtype_a0;
                  DAST._IType _1107_b = _1106___mcc_h614;
                  {
                    if (object.Equals(_507_fromTpe, _1107_b)) {
                      Dafny.ISequence<Dafny.Rune> _1108_recursiveGen;
                      bool _1109_recOwned;
                      bool _1110_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1111_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out631;
                      bool _out632;
                      bool _out633;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out634;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out631, out _out632, out _out633, out _out634);
                      _1108_recursiveGen = _out631;
                      _1109_recOwned = _out632;
                      _1110_recErased = _out633;
                      _1111_recIdents = _out634;
                      Dafny.ISequence<Dafny.Rune> _1112_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out635;
                      _out635 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _1112_rhsType = _out635;
                      Dafny.ISequence<Dafny.Rune> _1113_uneraseFn;
                      _1113_uneraseFn = ((_1109_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1112_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1113_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1108_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1109_recOwned;
                      isErased = false;
                      readIdents = _1111_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out636;
                      bool _out637;
                      bool _out638;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out639;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1107_b), _1107_b, _506_toTpe), selfIdent, @params, mustOwn, out _out636, out _out637, out _out638, out _out639);
                      s = _out636;
                      isOwned = _out637;
                      isErased = _out638;
                      readIdents = _out639;
                    }
                  }
                }
              } else if (_source43.is_Nullable) {
                DAST._IType _1114___mcc_h616 = _source43.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1115_recursiveGen;
                  bool _1116_recOwned;
                  bool _1117_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1118_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out640;
                  bool _out641;
                  bool _out642;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out643;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out640, out _out641, out _out642, out _out643);
                  _1115_recursiveGen = _out640;
                  _1116_recOwned = _out641;
                  _1117_recErased = _out642;
                  _1118_recIdents = _out643;
                  if (!(_1116_recOwned)) {
                    _1115_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1115_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1115_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1117_recErased;
                  readIdents = _1118_recIdents;
                }
              } else if (_source43.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1119___mcc_h618 = _source43.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1120_recursiveGen;
                  bool _1121_recOwned;
                  bool _1122_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1123_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out644;
                  bool _out645;
                  bool _out646;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out647;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out644, out _out645, out _out646, out _out647);
                  _1120_recursiveGen = _out644;
                  _1121_recOwned = _out645;
                  _1122_recErased = _out646;
                  _1123_recIdents = _out647;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1120_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1121_recOwned;
                  isErased = _1122_recErased;
                  readIdents = _1123_recIdents;
                }
              } else if (_source43.is_Array) {
                DAST._IType _1124___mcc_h620 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1125_recursiveGen;
                  bool _1126_recOwned;
                  bool _1127_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1128_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out648;
                  bool _out649;
                  bool _out650;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out651;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out648, out _out649, out _out650, out _out651);
                  _1125_recursiveGen = _out648;
                  _1126_recOwned = _out649;
                  _1127_recErased = _out650;
                  _1128_recIdents = _out651;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1125_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1126_recOwned;
                  isErased = _1127_recErased;
                  readIdents = _1128_recIdents;
                }
              } else if (_source43.is_Seq) {
                DAST._IType _1129___mcc_h622 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1130_recursiveGen;
                  bool _1131_recOwned;
                  bool _1132_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1133_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out652;
                  bool _out653;
                  bool _out654;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out655;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out652, out _out653, out _out654, out _out655);
                  _1130_recursiveGen = _out652;
                  _1131_recOwned = _out653;
                  _1132_recErased = _out654;
                  _1133_recIdents = _out655;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1130_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1131_recOwned;
                  isErased = _1132_recErased;
                  readIdents = _1133_recIdents;
                }
              } else if (_source43.is_Set) {
                DAST._IType _1134___mcc_h624 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1135_recursiveGen;
                  bool _1136_recOwned;
                  bool _1137_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1138_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out656;
                  bool _out657;
                  bool _out658;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out659;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out656, out _out657, out _out658, out _out659);
                  _1135_recursiveGen = _out656;
                  _1136_recOwned = _out657;
                  _1137_recErased = _out658;
                  _1138_recIdents = _out659;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1135_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1136_recOwned;
                  isErased = _1137_recErased;
                  readIdents = _1138_recIdents;
                }
              } else if (_source43.is_Multiset) {
                DAST._IType _1139___mcc_h626 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1140_recursiveGen;
                  bool _1141_recOwned;
                  bool _1142_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1143_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out660;
                  bool _out661;
                  bool _out662;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out663;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out660, out _out661, out _out662, out _out663);
                  _1140_recursiveGen = _out660;
                  _1141_recOwned = _out661;
                  _1142_recErased = _out662;
                  _1143_recIdents = _out663;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1140_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1141_recOwned;
                  isErased = _1142_recErased;
                  readIdents = _1143_recIdents;
                }
              } else if (_source43.is_Map) {
                DAST._IType _1144___mcc_h628 = _source43.dtor_key;
                DAST._IType _1145___mcc_h629 = _source43.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1146_recursiveGen;
                  bool _1147_recOwned;
                  bool _1148_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1149_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out664;
                  bool _out665;
                  bool _out666;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out667;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out664, out _out665, out _out666, out _out667);
                  _1146_recursiveGen = _out664;
                  _1147_recOwned = _out665;
                  _1148_recErased = _out666;
                  _1149_recIdents = _out667;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1146_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1147_recOwned;
                  isErased = _1148_recErased;
                  readIdents = _1149_recIdents;
                }
              } else if (_source43.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1150___mcc_h632 = _source43.dtor_args;
                DAST._IType _1151___mcc_h633 = _source43.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1152_recursiveGen;
                  bool _1153_recOwned;
                  bool _1154_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1155_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out668;
                  bool _out669;
                  bool _out670;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out671;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out668, out _out669, out _out670, out _out671);
                  _1152_recursiveGen = _out668;
                  _1153_recOwned = _out669;
                  _1154_recErased = _out670;
                  _1155_recIdents = _out671;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1152_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1153_recOwned;
                  isErased = _1154_recErased;
                  readIdents = _1155_recIdents;
                }
              } else if (_source43.is_Primitive) {
                DAST._IPrimitive _1156___mcc_h636 = _source43.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1157_recursiveGen;
                  bool _1158_recOwned;
                  bool _1159_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1160_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out672;
                  bool _out673;
                  bool _out674;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out675;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out672, out _out673, out _out674, out _out675);
                  _1157_recursiveGen = _out672;
                  _1158_recOwned = _out673;
                  _1159_recErased = _out674;
                  _1160_recIdents = _out675;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1157_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1158_recOwned;
                  isErased = _1159_recErased;
                  readIdents = _1160_recIdents;
                }
              } else if (_source43.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1161___mcc_h638 = _source43.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1162_recursiveGen;
                  bool _1163_recOwned;
                  bool _1164_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1165_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out676;
                  bool _out677;
                  bool _out678;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out679;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out676, out _out677, out _out678, out _out679);
                  _1162_recursiveGen = _out676;
                  _1163_recOwned = _out677;
                  _1164_recErased = _out678;
                  _1165_recIdents = _out679;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1162_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1163_recOwned;
                  isErased = _1164_recErased;
                  readIdents = _1165_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1166___mcc_h640 = _source43.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1167_recursiveGen;
                  bool _1168_recOwned;
                  bool _1169_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1170_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out680;
                  bool _out681;
                  bool _out682;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out683;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out680, out _out681, out _out682, out _out683);
                  _1167_recursiveGen = _out680;
                  _1168_recOwned = _out681;
                  _1169_recErased = _out682;
                  _1170_recIdents = _out683;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1167_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1168_recOwned;
                  isErased = _1169_recErased;
                  readIdents = _1170_recIdents;
                }
              }
            } else if (_source27.is_Multiset) {
              DAST._IType _1171___mcc_h642 = _source27.dtor_element;
              DAST._IType _source45 = _514___mcc_h253;
              if (_source45.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1172___mcc_h646 = _source45.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1173___mcc_h647 = _source45.dtor_typeArgs;
                DAST._IResolvedType _1174___mcc_h648 = _source45.dtor_resolved;
                DAST._IResolvedType _source46 = _1174___mcc_h648;
                if (_source46.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1175___mcc_h652 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1176_recursiveGen;
                    bool _1177_recOwned;
                    bool _1178_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1179_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out684;
                    bool _out685;
                    bool _out686;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out687;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out684, out _out685, out _out686, out _out687);
                    _1176_recursiveGen = _out684;
                    _1177_recOwned = _out685;
                    _1178_recErased = _out686;
                    _1179_recIdents = _out687;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1176_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1177_recOwned;
                    isErased = _1178_recErased;
                    readIdents = _1179_recIdents;
                  }
                } else if (_source46.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1180___mcc_h654 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1181_recursiveGen;
                    bool _1182_recOwned;
                    bool _1183_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1184_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out688;
                    bool _out689;
                    bool _out690;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out691;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out688, out _out689, out _out690, out _out691);
                    _1181_recursiveGen = _out688;
                    _1182_recOwned = _out689;
                    _1183_recErased = _out690;
                    _1184_recIdents = _out691;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1181_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1182_recOwned;
                    isErased = _1183_recErased;
                    readIdents = _1184_recIdents;
                  }
                } else {
                  DAST._IType _1185___mcc_h656 = _source46.dtor_Newtype_a0;
                  DAST._IType _1186_b = _1185___mcc_h656;
                  {
                    if (object.Equals(_507_fromTpe, _1186_b)) {
                      Dafny.ISequence<Dafny.Rune> _1187_recursiveGen;
                      bool _1188_recOwned;
                      bool _1189_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1190_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out692;
                      bool _out693;
                      bool _out694;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out695;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out692, out _out693, out _out694, out _out695);
                      _1187_recursiveGen = _out692;
                      _1188_recOwned = _out693;
                      _1189_recErased = _out694;
                      _1190_recIdents = _out695;
                      Dafny.ISequence<Dafny.Rune> _1191_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out696;
                      _out696 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _1191_rhsType = _out696;
                      Dafny.ISequence<Dafny.Rune> _1192_uneraseFn;
                      _1192_uneraseFn = ((_1188_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1191_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1192_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1187_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1188_recOwned;
                      isErased = false;
                      readIdents = _1190_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out697;
                      bool _out698;
                      bool _out699;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out700;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1186_b), _1186_b, _506_toTpe), selfIdent, @params, mustOwn, out _out697, out _out698, out _out699, out _out700);
                      s = _out697;
                      isOwned = _out698;
                      isErased = _out699;
                      readIdents = _out700;
                    }
                  }
                }
              } else if (_source45.is_Nullable) {
                DAST._IType _1193___mcc_h658 = _source45.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1194_recursiveGen;
                  bool _1195_recOwned;
                  bool _1196_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1197_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out701;
                  bool _out702;
                  bool _out703;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out704;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out701, out _out702, out _out703, out _out704);
                  _1194_recursiveGen = _out701;
                  _1195_recOwned = _out702;
                  _1196_recErased = _out703;
                  _1197_recIdents = _out704;
                  if (!(_1195_recOwned)) {
                    _1194_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1194_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1194_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1196_recErased;
                  readIdents = _1197_recIdents;
                }
              } else if (_source45.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1198___mcc_h660 = _source45.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1199_recursiveGen;
                  bool _1200_recOwned;
                  bool _1201_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1202_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out705;
                  bool _out706;
                  bool _out707;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out708;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out705, out _out706, out _out707, out _out708);
                  _1199_recursiveGen = _out705;
                  _1200_recOwned = _out706;
                  _1201_recErased = _out707;
                  _1202_recIdents = _out708;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1199_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1200_recOwned;
                  isErased = _1201_recErased;
                  readIdents = _1202_recIdents;
                }
              } else if (_source45.is_Array) {
                DAST._IType _1203___mcc_h662 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1204_recursiveGen;
                  bool _1205_recOwned;
                  bool _1206_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1207_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out709;
                  bool _out710;
                  bool _out711;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out712;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out709, out _out710, out _out711, out _out712);
                  _1204_recursiveGen = _out709;
                  _1205_recOwned = _out710;
                  _1206_recErased = _out711;
                  _1207_recIdents = _out712;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1204_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1205_recOwned;
                  isErased = _1206_recErased;
                  readIdents = _1207_recIdents;
                }
              } else if (_source45.is_Seq) {
                DAST._IType _1208___mcc_h664 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1209_recursiveGen;
                  bool _1210_recOwned;
                  bool _1211_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1212_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out713;
                  bool _out714;
                  bool _out715;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out716;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out713, out _out714, out _out715, out _out716);
                  _1209_recursiveGen = _out713;
                  _1210_recOwned = _out714;
                  _1211_recErased = _out715;
                  _1212_recIdents = _out716;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1209_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1210_recOwned;
                  isErased = _1211_recErased;
                  readIdents = _1212_recIdents;
                }
              } else if (_source45.is_Set) {
                DAST._IType _1213___mcc_h666 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1214_recursiveGen;
                  bool _1215_recOwned;
                  bool _1216_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1217_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out717;
                  bool _out718;
                  bool _out719;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out720;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out717, out _out718, out _out719, out _out720);
                  _1214_recursiveGen = _out717;
                  _1215_recOwned = _out718;
                  _1216_recErased = _out719;
                  _1217_recIdents = _out720;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1214_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1215_recOwned;
                  isErased = _1216_recErased;
                  readIdents = _1217_recIdents;
                }
              } else if (_source45.is_Multiset) {
                DAST._IType _1218___mcc_h668 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1219_recursiveGen;
                  bool _1220_recOwned;
                  bool _1221_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1222_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out721;
                  bool _out722;
                  bool _out723;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out724;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out721, out _out722, out _out723, out _out724);
                  _1219_recursiveGen = _out721;
                  _1220_recOwned = _out722;
                  _1221_recErased = _out723;
                  _1222_recIdents = _out724;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1219_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1220_recOwned;
                  isErased = _1221_recErased;
                  readIdents = _1222_recIdents;
                }
              } else if (_source45.is_Map) {
                DAST._IType _1223___mcc_h670 = _source45.dtor_key;
                DAST._IType _1224___mcc_h671 = _source45.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1225_recursiveGen;
                  bool _1226_recOwned;
                  bool _1227_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1228_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out725;
                  bool _out726;
                  bool _out727;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out728;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out725, out _out726, out _out727, out _out728);
                  _1225_recursiveGen = _out725;
                  _1226_recOwned = _out726;
                  _1227_recErased = _out727;
                  _1228_recIdents = _out728;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1225_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1226_recOwned;
                  isErased = _1227_recErased;
                  readIdents = _1228_recIdents;
                }
              } else if (_source45.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1229___mcc_h674 = _source45.dtor_args;
                DAST._IType _1230___mcc_h675 = _source45.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1231_recursiveGen;
                  bool _1232_recOwned;
                  bool _1233_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1234_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out729;
                  bool _out730;
                  bool _out731;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out732;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out729, out _out730, out _out731, out _out732);
                  _1231_recursiveGen = _out729;
                  _1232_recOwned = _out730;
                  _1233_recErased = _out731;
                  _1234_recIdents = _out732;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1231_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1232_recOwned;
                  isErased = _1233_recErased;
                  readIdents = _1234_recIdents;
                }
              } else if (_source45.is_Primitive) {
                DAST._IPrimitive _1235___mcc_h678 = _source45.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1236_recursiveGen;
                  bool _1237_recOwned;
                  bool _1238_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1239_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out733;
                  bool _out734;
                  bool _out735;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out736;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out733, out _out734, out _out735, out _out736);
                  _1236_recursiveGen = _out733;
                  _1237_recOwned = _out734;
                  _1238_recErased = _out735;
                  _1239_recIdents = _out736;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1236_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1237_recOwned;
                  isErased = _1238_recErased;
                  readIdents = _1239_recIdents;
                }
              } else if (_source45.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1240___mcc_h680 = _source45.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1241_recursiveGen;
                  bool _1242_recOwned;
                  bool _1243_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1244_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out737;
                  bool _out738;
                  bool _out739;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out740;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out737, out _out738, out _out739, out _out740);
                  _1241_recursiveGen = _out737;
                  _1242_recOwned = _out738;
                  _1243_recErased = _out739;
                  _1244_recIdents = _out740;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1241_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1242_recOwned;
                  isErased = _1243_recErased;
                  readIdents = _1244_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1245___mcc_h682 = _source45.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1246_recursiveGen;
                  bool _1247_recOwned;
                  bool _1248_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1249_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out741;
                  bool _out742;
                  bool _out743;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out744;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out741, out _out742, out _out743, out _out744);
                  _1246_recursiveGen = _out741;
                  _1247_recOwned = _out742;
                  _1248_recErased = _out743;
                  _1249_recIdents = _out744;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1246_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1247_recOwned;
                  isErased = _1248_recErased;
                  readIdents = _1249_recIdents;
                }
              }
            } else if (_source27.is_Map) {
              DAST._IType _1250___mcc_h684 = _source27.dtor_key;
              DAST._IType _1251___mcc_h685 = _source27.dtor_value;
              DAST._IType _source47 = _514___mcc_h253;
              if (_source47.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1252___mcc_h692 = _source47.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1253___mcc_h693 = _source47.dtor_typeArgs;
                DAST._IResolvedType _1254___mcc_h694 = _source47.dtor_resolved;
                DAST._IResolvedType _source48 = _1254___mcc_h694;
                if (_source48.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1255___mcc_h698 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1256_recursiveGen;
                    bool _1257_recOwned;
                    bool _1258_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1259_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out745;
                    bool _out746;
                    bool _out747;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out748;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out745, out _out746, out _out747, out _out748);
                    _1256_recursiveGen = _out745;
                    _1257_recOwned = _out746;
                    _1258_recErased = _out747;
                    _1259_recIdents = _out748;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1256_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1257_recOwned;
                    isErased = _1258_recErased;
                    readIdents = _1259_recIdents;
                  }
                } else if (_source48.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1260___mcc_h700 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1261_recursiveGen;
                    bool _1262_recOwned;
                    bool _1263_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1264_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out749;
                    bool _out750;
                    bool _out751;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out752;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out749, out _out750, out _out751, out _out752);
                    _1261_recursiveGen = _out749;
                    _1262_recOwned = _out750;
                    _1263_recErased = _out751;
                    _1264_recIdents = _out752;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1261_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1262_recOwned;
                    isErased = _1263_recErased;
                    readIdents = _1264_recIdents;
                  }
                } else {
                  DAST._IType _1265___mcc_h702 = _source48.dtor_Newtype_a0;
                  DAST._IType _1266_b = _1265___mcc_h702;
                  {
                    if (object.Equals(_507_fromTpe, _1266_b)) {
                      Dafny.ISequence<Dafny.Rune> _1267_recursiveGen;
                      bool _1268_recOwned;
                      bool _1269_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1270_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out753;
                      bool _out754;
                      bool _out755;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out756;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out753, out _out754, out _out755, out _out756);
                      _1267_recursiveGen = _out753;
                      _1268_recOwned = _out754;
                      _1269_recErased = _out755;
                      _1270_recIdents = _out756;
                      Dafny.ISequence<Dafny.Rune> _1271_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out757;
                      _out757 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _1271_rhsType = _out757;
                      Dafny.ISequence<Dafny.Rune> _1272_uneraseFn;
                      _1272_uneraseFn = ((_1268_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1271_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1272_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1267_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1268_recOwned;
                      isErased = false;
                      readIdents = _1270_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out758;
                      bool _out759;
                      bool _out760;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out761;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1266_b), _1266_b, _506_toTpe), selfIdent, @params, mustOwn, out _out758, out _out759, out _out760, out _out761);
                      s = _out758;
                      isOwned = _out759;
                      isErased = _out760;
                      readIdents = _out761;
                    }
                  }
                }
              } else if (_source47.is_Nullable) {
                DAST._IType _1273___mcc_h704 = _source47.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1274_recursiveGen;
                  bool _1275_recOwned;
                  bool _1276_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1277_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out762;
                  bool _out763;
                  bool _out764;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out765;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out762, out _out763, out _out764, out _out765);
                  _1274_recursiveGen = _out762;
                  _1275_recOwned = _out763;
                  _1276_recErased = _out764;
                  _1277_recIdents = _out765;
                  if (!(_1275_recOwned)) {
                    _1274_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1274_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1274_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1276_recErased;
                  readIdents = _1277_recIdents;
                }
              } else if (_source47.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1278___mcc_h706 = _source47.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1279_recursiveGen;
                  bool _1280_recOwned;
                  bool _1281_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1282_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out766;
                  bool _out767;
                  bool _out768;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out769;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out766, out _out767, out _out768, out _out769);
                  _1279_recursiveGen = _out766;
                  _1280_recOwned = _out767;
                  _1281_recErased = _out768;
                  _1282_recIdents = _out769;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1279_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1280_recOwned;
                  isErased = _1281_recErased;
                  readIdents = _1282_recIdents;
                }
              } else if (_source47.is_Array) {
                DAST._IType _1283___mcc_h708 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1284_recursiveGen;
                  bool _1285_recOwned;
                  bool _1286_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1287_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out770;
                  bool _out771;
                  bool _out772;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out773;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out770, out _out771, out _out772, out _out773);
                  _1284_recursiveGen = _out770;
                  _1285_recOwned = _out771;
                  _1286_recErased = _out772;
                  _1287_recIdents = _out773;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1284_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1285_recOwned;
                  isErased = _1286_recErased;
                  readIdents = _1287_recIdents;
                }
              } else if (_source47.is_Seq) {
                DAST._IType _1288___mcc_h710 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1289_recursiveGen;
                  bool _1290_recOwned;
                  bool _1291_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1292_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out774;
                  bool _out775;
                  bool _out776;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out777;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out774, out _out775, out _out776, out _out777);
                  _1289_recursiveGen = _out774;
                  _1290_recOwned = _out775;
                  _1291_recErased = _out776;
                  _1292_recIdents = _out777;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1289_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1290_recOwned;
                  isErased = _1291_recErased;
                  readIdents = _1292_recIdents;
                }
              } else if (_source47.is_Set) {
                DAST._IType _1293___mcc_h712 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1294_recursiveGen;
                  bool _1295_recOwned;
                  bool _1296_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1297_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out778;
                  bool _out779;
                  bool _out780;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out781;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out778, out _out779, out _out780, out _out781);
                  _1294_recursiveGen = _out778;
                  _1295_recOwned = _out779;
                  _1296_recErased = _out780;
                  _1297_recIdents = _out781;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1294_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1295_recOwned;
                  isErased = _1296_recErased;
                  readIdents = _1297_recIdents;
                }
              } else if (_source47.is_Multiset) {
                DAST._IType _1298___mcc_h714 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1299_recursiveGen;
                  bool _1300_recOwned;
                  bool _1301_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1302_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out782;
                  bool _out783;
                  bool _out784;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out785;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out782, out _out783, out _out784, out _out785);
                  _1299_recursiveGen = _out782;
                  _1300_recOwned = _out783;
                  _1301_recErased = _out784;
                  _1302_recIdents = _out785;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1299_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1300_recOwned;
                  isErased = _1301_recErased;
                  readIdents = _1302_recIdents;
                }
              } else if (_source47.is_Map) {
                DAST._IType _1303___mcc_h716 = _source47.dtor_key;
                DAST._IType _1304___mcc_h717 = _source47.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1305_recursiveGen;
                  bool _1306_recOwned;
                  bool _1307_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1308_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out786;
                  bool _out787;
                  bool _out788;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out789;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out786, out _out787, out _out788, out _out789);
                  _1305_recursiveGen = _out786;
                  _1306_recOwned = _out787;
                  _1307_recErased = _out788;
                  _1308_recIdents = _out789;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1305_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1306_recOwned;
                  isErased = _1307_recErased;
                  readIdents = _1308_recIdents;
                }
              } else if (_source47.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1309___mcc_h720 = _source47.dtor_args;
                DAST._IType _1310___mcc_h721 = _source47.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1311_recursiveGen;
                  bool _1312_recOwned;
                  bool _1313_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1314_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out790;
                  bool _out791;
                  bool _out792;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out793;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out790, out _out791, out _out792, out _out793);
                  _1311_recursiveGen = _out790;
                  _1312_recOwned = _out791;
                  _1313_recErased = _out792;
                  _1314_recIdents = _out793;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1311_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1312_recOwned;
                  isErased = _1313_recErased;
                  readIdents = _1314_recIdents;
                }
              } else if (_source47.is_Primitive) {
                DAST._IPrimitive _1315___mcc_h724 = _source47.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1316_recursiveGen;
                  bool _1317_recOwned;
                  bool _1318_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1319_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out794;
                  bool _out795;
                  bool _out796;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out797;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out794, out _out795, out _out796, out _out797);
                  _1316_recursiveGen = _out794;
                  _1317_recOwned = _out795;
                  _1318_recErased = _out796;
                  _1319_recIdents = _out797;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1316_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1317_recOwned;
                  isErased = _1318_recErased;
                  readIdents = _1319_recIdents;
                }
              } else if (_source47.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1320___mcc_h726 = _source47.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1321_recursiveGen;
                  bool _1322_recOwned;
                  bool _1323_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1324_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out798;
                  bool _out799;
                  bool _out800;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out801;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out798, out _out799, out _out800, out _out801);
                  _1321_recursiveGen = _out798;
                  _1322_recOwned = _out799;
                  _1323_recErased = _out800;
                  _1324_recIdents = _out801;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1321_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1322_recOwned;
                  isErased = _1323_recErased;
                  readIdents = _1324_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1325___mcc_h728 = _source47.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1326_recursiveGen;
                  bool _1327_recOwned;
                  bool _1328_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1329_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out802;
                  bool _out803;
                  bool _out804;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out805;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out802, out _out803, out _out804, out _out805);
                  _1326_recursiveGen = _out802;
                  _1327_recOwned = _out803;
                  _1328_recErased = _out804;
                  _1329_recIdents = _out805;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1326_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1327_recOwned;
                  isErased = _1328_recErased;
                  readIdents = _1329_recIdents;
                }
              }
            } else if (_source27.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1330___mcc_h730 = _source27.dtor_args;
              DAST._IType _1331___mcc_h731 = _source27.dtor_result;
              DAST._IType _source49 = _514___mcc_h253;
              if (_source49.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1332___mcc_h738 = _source49.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1333___mcc_h739 = _source49.dtor_typeArgs;
                DAST._IResolvedType _1334___mcc_h740 = _source49.dtor_resolved;
                DAST._IResolvedType _source50 = _1334___mcc_h740;
                if (_source50.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1335___mcc_h744 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1336_recursiveGen;
                    bool _1337_recOwned;
                    bool _1338_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1339_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out806;
                    bool _out807;
                    bool _out808;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out809;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out806, out _out807, out _out808, out _out809);
                    _1336_recursiveGen = _out806;
                    _1337_recOwned = _out807;
                    _1338_recErased = _out808;
                    _1339_recIdents = _out809;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1336_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1337_recOwned;
                    isErased = _1338_recErased;
                    readIdents = _1339_recIdents;
                  }
                } else if (_source50.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1340___mcc_h746 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1341_recursiveGen;
                    bool _1342_recOwned;
                    bool _1343_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1344_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out810;
                    bool _out811;
                    bool _out812;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out813;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out810, out _out811, out _out812, out _out813);
                    _1341_recursiveGen = _out810;
                    _1342_recOwned = _out811;
                    _1343_recErased = _out812;
                    _1344_recIdents = _out813;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1341_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1342_recOwned;
                    isErased = _1343_recErased;
                    readIdents = _1344_recIdents;
                  }
                } else {
                  DAST._IType _1345___mcc_h748 = _source50.dtor_Newtype_a0;
                  DAST._IType _1346_b = _1345___mcc_h748;
                  {
                    if (object.Equals(_507_fromTpe, _1346_b)) {
                      Dafny.ISequence<Dafny.Rune> _1347_recursiveGen;
                      bool _1348_recOwned;
                      bool _1349_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1350_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out814;
                      bool _out815;
                      bool _out816;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out817;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out814, out _out815, out _out816, out _out817);
                      _1347_recursiveGen = _out814;
                      _1348_recOwned = _out815;
                      _1349_recErased = _out816;
                      _1350_recIdents = _out817;
                      Dafny.ISequence<Dafny.Rune> _1351_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out818;
                      _out818 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _1351_rhsType = _out818;
                      Dafny.ISequence<Dafny.Rune> _1352_uneraseFn;
                      _1352_uneraseFn = ((_1348_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1351_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1352_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1347_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1348_recOwned;
                      isErased = false;
                      readIdents = _1350_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out819;
                      bool _out820;
                      bool _out821;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out822;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1346_b), _1346_b, _506_toTpe), selfIdent, @params, mustOwn, out _out819, out _out820, out _out821, out _out822);
                      s = _out819;
                      isOwned = _out820;
                      isErased = _out821;
                      readIdents = _out822;
                    }
                  }
                }
              } else if (_source49.is_Nullable) {
                DAST._IType _1353___mcc_h750 = _source49.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1354_recursiveGen;
                  bool _1355_recOwned;
                  bool _1356_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1357_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out823;
                  bool _out824;
                  bool _out825;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out826;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out823, out _out824, out _out825, out _out826);
                  _1354_recursiveGen = _out823;
                  _1355_recOwned = _out824;
                  _1356_recErased = _out825;
                  _1357_recIdents = _out826;
                  if (!(_1355_recOwned)) {
                    _1354_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1354_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1354_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1356_recErased;
                  readIdents = _1357_recIdents;
                }
              } else if (_source49.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1358___mcc_h752 = _source49.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1359_recursiveGen;
                  bool _1360_recOwned;
                  bool _1361_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1362_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out827;
                  bool _out828;
                  bool _out829;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out827, out _out828, out _out829, out _out830);
                  _1359_recursiveGen = _out827;
                  _1360_recOwned = _out828;
                  _1361_recErased = _out829;
                  _1362_recIdents = _out830;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1359_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1360_recOwned;
                  isErased = _1361_recErased;
                  readIdents = _1362_recIdents;
                }
              } else if (_source49.is_Array) {
                DAST._IType _1363___mcc_h754 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1364_recursiveGen;
                  bool _1365_recOwned;
                  bool _1366_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1367_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out831;
                  bool _out832;
                  bool _out833;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                  _1364_recursiveGen = _out831;
                  _1365_recOwned = _out832;
                  _1366_recErased = _out833;
                  _1367_recIdents = _out834;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1364_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1365_recOwned;
                  isErased = _1366_recErased;
                  readIdents = _1367_recIdents;
                }
              } else if (_source49.is_Seq) {
                DAST._IType _1368___mcc_h756 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1369_recursiveGen;
                  bool _1370_recOwned;
                  bool _1371_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1372_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out835;
                  bool _out836;
                  bool _out837;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                  _1369_recursiveGen = _out835;
                  _1370_recOwned = _out836;
                  _1371_recErased = _out837;
                  _1372_recIdents = _out838;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1369_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1370_recOwned;
                  isErased = _1371_recErased;
                  readIdents = _1372_recIdents;
                }
              } else if (_source49.is_Set) {
                DAST._IType _1373___mcc_h758 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1374_recursiveGen;
                  bool _1375_recOwned;
                  bool _1376_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1377_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out839;
                  bool _out840;
                  bool _out841;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                  _1374_recursiveGen = _out839;
                  _1375_recOwned = _out840;
                  _1376_recErased = _out841;
                  _1377_recIdents = _out842;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1374_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1375_recOwned;
                  isErased = _1376_recErased;
                  readIdents = _1377_recIdents;
                }
              } else if (_source49.is_Multiset) {
                DAST._IType _1378___mcc_h760 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1379_recursiveGen;
                  bool _1380_recOwned;
                  bool _1381_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1382_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out843;
                  bool _out844;
                  bool _out845;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                  _1379_recursiveGen = _out843;
                  _1380_recOwned = _out844;
                  _1381_recErased = _out845;
                  _1382_recIdents = _out846;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1379_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1380_recOwned;
                  isErased = _1381_recErased;
                  readIdents = _1382_recIdents;
                }
              } else if (_source49.is_Map) {
                DAST._IType _1383___mcc_h762 = _source49.dtor_key;
                DAST._IType _1384___mcc_h763 = _source49.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1385_recursiveGen;
                  bool _1386_recOwned;
                  bool _1387_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1388_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out847;
                  bool _out848;
                  bool _out849;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out850;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out847, out _out848, out _out849, out _out850);
                  _1385_recursiveGen = _out847;
                  _1386_recOwned = _out848;
                  _1387_recErased = _out849;
                  _1388_recIdents = _out850;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1385_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1386_recOwned;
                  isErased = _1387_recErased;
                  readIdents = _1388_recIdents;
                }
              } else if (_source49.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1389___mcc_h766 = _source49.dtor_args;
                DAST._IType _1390___mcc_h767 = _source49.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1391_recursiveGen;
                  bool _1392_recOwned;
                  bool _1393_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1394_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out851;
                  bool _out852;
                  bool _out853;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out854;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out851, out _out852, out _out853, out _out854);
                  _1391_recursiveGen = _out851;
                  _1392_recOwned = _out852;
                  _1393_recErased = _out853;
                  _1394_recIdents = _out854;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1391_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1392_recOwned;
                  isErased = _1393_recErased;
                  readIdents = _1394_recIdents;
                }
              } else if (_source49.is_Primitive) {
                DAST._IPrimitive _1395___mcc_h770 = _source49.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1396_recursiveGen;
                  bool _1397_recOwned;
                  bool _1398_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1399_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out855;
                  bool _out856;
                  bool _out857;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out858;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out855, out _out856, out _out857, out _out858);
                  _1396_recursiveGen = _out855;
                  _1397_recOwned = _out856;
                  _1398_recErased = _out857;
                  _1399_recIdents = _out858;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1396_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1397_recOwned;
                  isErased = _1398_recErased;
                  readIdents = _1399_recIdents;
                }
              } else if (_source49.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1400___mcc_h772 = _source49.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1401_recursiveGen;
                  bool _1402_recOwned;
                  bool _1403_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1404_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out859;
                  bool _out860;
                  bool _out861;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out862;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out859, out _out860, out _out861, out _out862);
                  _1401_recursiveGen = _out859;
                  _1402_recOwned = _out860;
                  _1403_recErased = _out861;
                  _1404_recIdents = _out862;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1401_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1402_recOwned;
                  isErased = _1403_recErased;
                  readIdents = _1404_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1405___mcc_h774 = _source49.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1406_recursiveGen;
                  bool _1407_recOwned;
                  bool _1408_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1409_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out863;
                  bool _out864;
                  bool _out865;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out866;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out863, out _out864, out _out865, out _out866);
                  _1406_recursiveGen = _out863;
                  _1407_recOwned = _out864;
                  _1408_recErased = _out865;
                  _1409_recIdents = _out866;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1406_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1407_recOwned;
                  isErased = _1408_recErased;
                  readIdents = _1409_recIdents;
                }
              }
            } else if (_source27.is_Primitive) {
              DAST._IPrimitive _1410___mcc_h776 = _source27.dtor_Primitive_a0;
              DAST._IPrimitive _source51 = _1410___mcc_h776;
              if (_source51.is_Int) {
                DAST._IType _source52 = _514___mcc_h253;
                if (_source52.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1411___mcc_h780 = _source52.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1412___mcc_h781 = _source52.dtor_typeArgs;
                  DAST._IResolvedType _1413___mcc_h782 = _source52.dtor_resolved;
                  DAST._IResolvedType _source53 = _1413___mcc_h782;
                  if (_source53.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1414___mcc_h786 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1415_recursiveGen;
                      bool _1416_recOwned;
                      bool _1417_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1418_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out867;
                      bool _out868;
                      bool _out869;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out870;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out867, out _out868, out _out869, out _out870);
                      _1415_recursiveGen = _out867;
                      _1416_recOwned = _out868;
                      _1417_recErased = _out869;
                      _1418_recIdents = _out870;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1415_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1416_recOwned;
                      isErased = _1417_recErased;
                      readIdents = _1418_recIdents;
                    }
                  } else if (_source53.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1419___mcc_h788 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1420_recursiveGen;
                      bool _1421_recOwned;
                      bool _1422_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1423_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out871;
                      bool _out872;
                      bool _out873;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out874;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out871, out _out872, out _out873, out _out874);
                      _1420_recursiveGen = _out871;
                      _1421_recOwned = _out872;
                      _1422_recErased = _out873;
                      _1423_recIdents = _out874;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1420_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1421_recOwned;
                      isErased = _1422_recErased;
                      readIdents = _1423_recIdents;
                    }
                  } else {
                    DAST._IType _1424___mcc_h790 = _source53.dtor_Newtype_a0;
                    DAST._IType _1425_b = _1424___mcc_h790;
                    {
                      if (object.Equals(_507_fromTpe, _1425_b)) {
                        Dafny.ISequence<Dafny.Rune> _1426_recursiveGen;
                        bool _1427_recOwned;
                        bool _1428_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1429_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out875;
                        bool _out876;
                        bool _out877;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out878;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out875, out _out876, out _out877, out _out878);
                        _1426_recursiveGen = _out875;
                        _1427_recOwned = _out876;
                        _1428_recErased = _out877;
                        _1429_recIdents = _out878;
                        Dafny.ISequence<Dafny.Rune> _1430_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out879;
                        _out879 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                        _1430_rhsType = _out879;
                        Dafny.ISequence<Dafny.Rune> _1431_uneraseFn;
                        _1431_uneraseFn = ((_1427_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1430_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1431_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1426_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1427_recOwned;
                        isErased = false;
                        readIdents = _1429_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out880;
                        bool _out881;
                        bool _out882;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1425_b), _1425_b, _506_toTpe), selfIdent, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                        s = _out880;
                        isOwned = _out881;
                        isErased = _out882;
                        readIdents = _out883;
                      }
                    }
                  }
                } else if (_source52.is_Nullable) {
                  DAST._IType _1432___mcc_h792 = _source52.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1433_recursiveGen;
                    bool _1434_recOwned;
                    bool _1435_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1436_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out884;
                    bool _out885;
                    bool _out886;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                    _1433_recursiveGen = _out884;
                    _1434_recOwned = _out885;
                    _1435_recErased = _out886;
                    _1436_recIdents = _out887;
                    if (!(_1434_recOwned)) {
                      _1433_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1433_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1433_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1435_recErased;
                    readIdents = _1436_recIdents;
                  }
                } else if (_source52.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1437___mcc_h794 = _source52.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1438_recursiveGen;
                    bool _1439_recOwned;
                    bool _1440_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1441_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out888;
                    bool _out889;
                    bool _out890;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                    _1438_recursiveGen = _out888;
                    _1439_recOwned = _out889;
                    _1440_recErased = _out890;
                    _1441_recIdents = _out891;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1438_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1439_recOwned;
                    isErased = _1440_recErased;
                    readIdents = _1441_recIdents;
                  }
                } else if (_source52.is_Array) {
                  DAST._IType _1442___mcc_h796 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1443_recursiveGen;
                    bool _1444_recOwned;
                    bool _1445_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1446_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out892;
                    bool _out893;
                    bool _out894;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                    _1443_recursiveGen = _out892;
                    _1444_recOwned = _out893;
                    _1445_recErased = _out894;
                    _1446_recIdents = _out895;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1443_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1444_recOwned;
                    isErased = _1445_recErased;
                    readIdents = _1446_recIdents;
                  }
                } else if (_source52.is_Seq) {
                  DAST._IType _1447___mcc_h798 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1448_recursiveGen;
                    bool _1449_recOwned;
                    bool _1450_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1451_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out896;
                    bool _out897;
                    bool _out898;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                    _1448_recursiveGen = _out896;
                    _1449_recOwned = _out897;
                    _1450_recErased = _out898;
                    _1451_recIdents = _out899;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1448_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1449_recOwned;
                    isErased = _1450_recErased;
                    readIdents = _1451_recIdents;
                  }
                } else if (_source52.is_Set) {
                  DAST._IType _1452___mcc_h800 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1453_recursiveGen;
                    bool _1454_recOwned;
                    bool _1455_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1456_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1453_recursiveGen = _out900;
                    _1454_recOwned = _out901;
                    _1455_recErased = _out902;
                    _1456_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1453_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1454_recOwned;
                    isErased = _1455_recErased;
                    readIdents = _1456_recIdents;
                  }
                } else if (_source52.is_Multiset) {
                  DAST._IType _1457___mcc_h802 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1458_recursiveGen;
                    bool _1459_recOwned;
                    bool _1460_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1461_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1458_recursiveGen = _out904;
                    _1459_recOwned = _out905;
                    _1460_recErased = _out906;
                    _1461_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1458_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1459_recOwned;
                    isErased = _1460_recErased;
                    readIdents = _1461_recIdents;
                  }
                } else if (_source52.is_Map) {
                  DAST._IType _1462___mcc_h804 = _source52.dtor_key;
                  DAST._IType _1463___mcc_h805 = _source52.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1464_recursiveGen;
                    bool _1465_recOwned;
                    bool _1466_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1467_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out908;
                    bool _out909;
                    bool _out910;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                    _1464_recursiveGen = _out908;
                    _1465_recOwned = _out909;
                    _1466_recErased = _out910;
                    _1467_recIdents = _out911;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1464_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1465_recOwned;
                    isErased = _1466_recErased;
                    readIdents = _1467_recIdents;
                  }
                } else if (_source52.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1468___mcc_h808 = _source52.dtor_args;
                  DAST._IType _1469___mcc_h809 = _source52.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1470_recursiveGen;
                    bool _1471_recOwned;
                    bool _1472_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1473_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out912;
                    bool _out913;
                    bool _out914;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out912, out _out913, out _out914, out _out915);
                    _1470_recursiveGen = _out912;
                    _1471_recOwned = _out913;
                    _1472_recErased = _out914;
                    _1473_recIdents = _out915;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1470_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1471_recOwned;
                    isErased = _1472_recErased;
                    readIdents = _1473_recIdents;
                  }
                } else if (_source52.is_Primitive) {
                  DAST._IPrimitive _1474___mcc_h812 = _source52.dtor_Primitive_a0;
                  DAST._IPrimitive _source54 = _1474___mcc_h812;
                  if (_source54.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1475_recursiveGen;
                      bool _1476_recOwned;
                      bool _1477_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1478_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out916;
                      bool _out917;
                      bool _out918;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                      _1475_recursiveGen = _out916;
                      _1476_recOwned = _out917;
                      _1477_recErased = _out918;
                      _1478_recIdents = _out919;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1475_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1476_recOwned;
                      isErased = _1477_recErased;
                      readIdents = _1478_recIdents;
                    }
                  } else if (_source54.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1479_recursiveGen;
                      bool _1480___v44;
                      bool _1481___v45;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1482_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out920;
                      bool _out921;
                      bool _out922;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, true, out _out920, out _out921, out _out922, out _out923);
                      _1479_recursiveGen = _out920;
                      _1480___v44 = _out921;
                      _1481___v45 = _out922;
                      _1482_recIdents = _out923;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1482_recIdents;
                    }
                  } else if (_source54.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1483_recursiveGen;
                      bool _1484_recOwned;
                      bool _1485_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1486_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out924;
                      bool _out925;
                      bool _out926;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out927;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out924, out _out925, out _out926, out _out927);
                      _1483_recursiveGen = _out924;
                      _1484_recOwned = _out925;
                      _1485_recErased = _out926;
                      _1486_recIdents = _out927;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1483_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1484_recOwned;
                      isErased = _1485_recErased;
                      readIdents = _1486_recIdents;
                    }
                  } else if (_source54.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1487_recursiveGen;
                      bool _1488_recOwned;
                      bool _1489_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1490_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out928;
                      bool _out929;
                      bool _out930;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out931;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out928, out _out929, out _out930, out _out931);
                      _1487_recursiveGen = _out928;
                      _1488_recOwned = _out929;
                      _1489_recErased = _out930;
                      _1490_recIdents = _out931;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1487_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1488_recOwned;
                      isErased = _1489_recErased;
                      readIdents = _1490_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1491_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out932;
                      _out932 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _1491_rhsType = _out932;
                      Dafny.ISequence<Dafny.Rune> _1492_recursiveGen;
                      bool _1493___v54;
                      bool _1494___v55;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1495_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out933;
                      bool _out934;
                      bool _out935;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, true, out _out933, out _out934, out _out935, out _out936);
                      _1492_recursiveGen = _out933;
                      _1493___v54 = _out934;
                      _1494___v55 = _out935;
                      _1495_recIdents = _out936;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1495_recIdents;
                    }
                  }
                } else if (_source52.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1496___mcc_h814 = _source52.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1497_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out937;
                    _out937 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                    _1497_rhsType = _out937;
                    Dafny.ISequence<Dafny.Rune> _1498_recursiveGen;
                    bool _1499___v49;
                    bool _1500___v50;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1501_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out938;
                    bool _out939;
                    bool _out940;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out941;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, true, out _out938, out _out939, out _out940, out _out941);
                    _1498_recursiveGen = _out938;
                    _1499___v49 = _out939;
                    _1500___v50 = _out940;
                    _1501_recIdents = _out941;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1497_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1498_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1501_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1502___mcc_h816 = _source52.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1503_recursiveGen;
                    bool _1504_recOwned;
                    bool _1505_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1506_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out942;
                    bool _out943;
                    bool _out944;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out945;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out942, out _out943, out _out944, out _out945);
                    _1503_recursiveGen = _out942;
                    _1504_recOwned = _out943;
                    _1505_recErased = _out944;
                    _1506_recIdents = _out945;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1503_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1504_recOwned;
                    isErased = _1505_recErased;
                    readIdents = _1506_recIdents;
                  }
                }
              } else if (_source51.is_Real) {
                DAST._IType _source55 = _514___mcc_h253;
                if (_source55.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1507___mcc_h818 = _source55.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1508___mcc_h819 = _source55.dtor_typeArgs;
                  DAST._IResolvedType _1509___mcc_h820 = _source55.dtor_resolved;
                  DAST._IResolvedType _source56 = _1509___mcc_h820;
                  if (_source56.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1510___mcc_h824 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1511_recursiveGen;
                      bool _1512_recOwned;
                      bool _1513_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1514_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out946;
                      bool _out947;
                      bool _out948;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out949;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out946, out _out947, out _out948, out _out949);
                      _1511_recursiveGen = _out946;
                      _1512_recOwned = _out947;
                      _1513_recErased = _out948;
                      _1514_recIdents = _out949;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1511_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1512_recOwned;
                      isErased = _1513_recErased;
                      readIdents = _1514_recIdents;
                    }
                  } else if (_source56.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1515___mcc_h826 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1516_recursiveGen;
                      bool _1517_recOwned;
                      bool _1518_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1519_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out950;
                      bool _out951;
                      bool _out952;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out953;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out950, out _out951, out _out952, out _out953);
                      _1516_recursiveGen = _out950;
                      _1517_recOwned = _out951;
                      _1518_recErased = _out952;
                      _1519_recIdents = _out953;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1516_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1517_recOwned;
                      isErased = _1518_recErased;
                      readIdents = _1519_recIdents;
                    }
                  } else {
                    DAST._IType _1520___mcc_h828 = _source56.dtor_Newtype_a0;
                    DAST._IType _1521_b = _1520___mcc_h828;
                    {
                      if (object.Equals(_507_fromTpe, _1521_b)) {
                        Dafny.ISequence<Dafny.Rune> _1522_recursiveGen;
                        bool _1523_recOwned;
                        bool _1524_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1525_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out954;
                        bool _out955;
                        bool _out956;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out957;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out954, out _out955, out _out956, out _out957);
                        _1522_recursiveGen = _out954;
                        _1523_recOwned = _out955;
                        _1524_recErased = _out956;
                        _1525_recIdents = _out957;
                        Dafny.ISequence<Dafny.Rune> _1526_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out958;
                        _out958 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                        _1526_rhsType = _out958;
                        Dafny.ISequence<Dafny.Rune> _1527_uneraseFn;
                        _1527_uneraseFn = ((_1523_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1526_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1527_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1522_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1523_recOwned;
                        isErased = false;
                        readIdents = _1525_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out959;
                        bool _out960;
                        bool _out961;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out962;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1521_b), _1521_b, _506_toTpe), selfIdent, @params, mustOwn, out _out959, out _out960, out _out961, out _out962);
                        s = _out959;
                        isOwned = _out960;
                        isErased = _out961;
                        readIdents = _out962;
                      }
                    }
                  }
                } else if (_source55.is_Nullable) {
                  DAST._IType _1528___mcc_h830 = _source55.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1529_recursiveGen;
                    bool _1530_recOwned;
                    bool _1531_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1532_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out963;
                    bool _out964;
                    bool _out965;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out966;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out963, out _out964, out _out965, out _out966);
                    _1529_recursiveGen = _out963;
                    _1530_recOwned = _out964;
                    _1531_recErased = _out965;
                    _1532_recIdents = _out966;
                    if (!(_1530_recOwned)) {
                      _1529_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1529_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1529_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1531_recErased;
                    readIdents = _1532_recIdents;
                  }
                } else if (_source55.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1533___mcc_h832 = _source55.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1534_recursiveGen;
                    bool _1535_recOwned;
                    bool _1536_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1537_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out967;
                    bool _out968;
                    bool _out969;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out970;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out967, out _out968, out _out969, out _out970);
                    _1534_recursiveGen = _out967;
                    _1535_recOwned = _out968;
                    _1536_recErased = _out969;
                    _1537_recIdents = _out970;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1535_recOwned;
                    isErased = _1536_recErased;
                    readIdents = _1537_recIdents;
                  }
                } else if (_source55.is_Array) {
                  DAST._IType _1538___mcc_h834 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1539_recursiveGen;
                    bool _1540_recOwned;
                    bool _1541_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1542_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out971;
                    bool _out972;
                    bool _out973;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out974;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out971, out _out972, out _out973, out _out974);
                    _1539_recursiveGen = _out971;
                    _1540_recOwned = _out972;
                    _1541_recErased = _out973;
                    _1542_recIdents = _out974;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1539_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1540_recOwned;
                    isErased = _1541_recErased;
                    readIdents = _1542_recIdents;
                  }
                } else if (_source55.is_Seq) {
                  DAST._IType _1543___mcc_h836 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1544_recursiveGen;
                    bool _1545_recOwned;
                    bool _1546_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1547_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out975;
                    bool _out976;
                    bool _out977;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out978;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out975, out _out976, out _out977, out _out978);
                    _1544_recursiveGen = _out975;
                    _1545_recOwned = _out976;
                    _1546_recErased = _out977;
                    _1547_recIdents = _out978;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1544_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1545_recOwned;
                    isErased = _1546_recErased;
                    readIdents = _1547_recIdents;
                  }
                } else if (_source55.is_Set) {
                  DAST._IType _1548___mcc_h838 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1549_recursiveGen;
                    bool _1550_recOwned;
                    bool _1551_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1552_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out979;
                    bool _out980;
                    bool _out981;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out982;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out979, out _out980, out _out981, out _out982);
                    _1549_recursiveGen = _out979;
                    _1550_recOwned = _out980;
                    _1551_recErased = _out981;
                    _1552_recIdents = _out982;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1549_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1550_recOwned;
                    isErased = _1551_recErased;
                    readIdents = _1552_recIdents;
                  }
                } else if (_source55.is_Multiset) {
                  DAST._IType _1553___mcc_h840 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1554_recursiveGen;
                    bool _1555_recOwned;
                    bool _1556_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1557_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out983;
                    bool _out984;
                    bool _out985;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out986;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out983, out _out984, out _out985, out _out986);
                    _1554_recursiveGen = _out983;
                    _1555_recOwned = _out984;
                    _1556_recErased = _out985;
                    _1557_recIdents = _out986;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1554_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1555_recOwned;
                    isErased = _1556_recErased;
                    readIdents = _1557_recIdents;
                  }
                } else if (_source55.is_Map) {
                  DAST._IType _1558___mcc_h842 = _source55.dtor_key;
                  DAST._IType _1559___mcc_h843 = _source55.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1560_recursiveGen;
                    bool _1561_recOwned;
                    bool _1562_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1563_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out987;
                    bool _out988;
                    bool _out989;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out990;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out987, out _out988, out _out989, out _out990);
                    _1560_recursiveGen = _out987;
                    _1561_recOwned = _out988;
                    _1562_recErased = _out989;
                    _1563_recIdents = _out990;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1561_recOwned;
                    isErased = _1562_recErased;
                    readIdents = _1563_recIdents;
                  }
                } else if (_source55.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1564___mcc_h846 = _source55.dtor_args;
                  DAST._IType _1565___mcc_h847 = _source55.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1566_recursiveGen;
                    bool _1567_recOwned;
                    bool _1568_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1569_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out991;
                    bool _out992;
                    bool _out993;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out994;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out991, out _out992, out _out993, out _out994);
                    _1566_recursiveGen = _out991;
                    _1567_recOwned = _out992;
                    _1568_recErased = _out993;
                    _1569_recIdents = _out994;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1566_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1567_recOwned;
                    isErased = _1568_recErased;
                    readIdents = _1569_recIdents;
                  }
                } else if (_source55.is_Primitive) {
                  DAST._IPrimitive _1570___mcc_h850 = _source55.dtor_Primitive_a0;
                  DAST._IPrimitive _source57 = _1570___mcc_h850;
                  if (_source57.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1571_recursiveGen;
                      bool _1572___v46;
                      bool _1573___v47;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1574_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out995;
                      bool _out996;
                      bool _out997;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out998;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, false, out _out995, out _out996, out _out997, out _out998);
                      _1571_recursiveGen = _out995;
                      _1572___v46 = _out996;
                      _1573___v47 = _out997;
                      _1574_recIdents = _out998;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1571_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1574_recIdents;
                    }
                  } else if (_source57.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1575_recursiveGen;
                      bool _1576_recOwned;
                      bool _1577_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1578_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out999;
                      bool _out1000;
                      bool _out1001;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1002;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out999, out _out1000, out _out1001, out _out1002);
                      _1575_recursiveGen = _out999;
                      _1576_recOwned = _out1000;
                      _1577_recErased = _out1001;
                      _1578_recIdents = _out1002;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1575_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1576_recOwned;
                      isErased = _1577_recErased;
                      readIdents = _1578_recIdents;
                    }
                  } else if (_source57.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1579_recursiveGen;
                      bool _1580_recOwned;
                      bool _1581_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1582_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1003;
                      bool _out1004;
                      bool _out1005;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1006;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1003, out _out1004, out _out1005, out _out1006);
                      _1579_recursiveGen = _out1003;
                      _1580_recOwned = _out1004;
                      _1581_recErased = _out1005;
                      _1582_recIdents = _out1006;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1579_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1580_recOwned;
                      isErased = _1581_recErased;
                      readIdents = _1582_recIdents;
                    }
                  } else if (_source57.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1583_recursiveGen;
                      bool _1584_recOwned;
                      bool _1585_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1586_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1007;
                      bool _out1008;
                      bool _out1009;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1010;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1007, out _out1008, out _out1009, out _out1010);
                      _1583_recursiveGen = _out1007;
                      _1584_recOwned = _out1008;
                      _1585_recErased = _out1009;
                      _1586_recIdents = _out1010;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1583_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1584_recOwned;
                      isErased = _1585_recErased;
                      readIdents = _1586_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1587_recursiveGen;
                      bool _1588_recOwned;
                      bool _1589_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1590_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1011;
                      bool _out1012;
                      bool _out1013;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1014;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1011, out _out1012, out _out1013, out _out1014);
                      _1587_recursiveGen = _out1011;
                      _1588_recOwned = _out1012;
                      _1589_recErased = _out1013;
                      _1590_recIdents = _out1014;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1587_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1588_recOwned;
                      isErased = _1589_recErased;
                      readIdents = _1590_recIdents;
                    }
                  }
                } else if (_source55.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1591___mcc_h852 = _source55.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1592_recursiveGen;
                    bool _1593_recOwned;
                    bool _1594_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1595_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1015;
                    bool _out1016;
                    bool _out1017;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1018;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1015, out _out1016, out _out1017, out _out1018);
                    _1592_recursiveGen = _out1015;
                    _1593_recOwned = _out1016;
                    _1594_recErased = _out1017;
                    _1595_recIdents = _out1018;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1592_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1593_recOwned;
                    isErased = _1594_recErased;
                    readIdents = _1595_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1596___mcc_h854 = _source55.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1597_recursiveGen;
                    bool _1598_recOwned;
                    bool _1599_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1600_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1019;
                    bool _out1020;
                    bool _out1021;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1022;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1019, out _out1020, out _out1021, out _out1022);
                    _1597_recursiveGen = _out1019;
                    _1598_recOwned = _out1020;
                    _1599_recErased = _out1021;
                    _1600_recIdents = _out1022;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1597_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1598_recOwned;
                    isErased = _1599_recErased;
                    readIdents = _1600_recIdents;
                  }
                }
              } else if (_source51.is_String) {
                DAST._IType _source58 = _514___mcc_h253;
                if (_source58.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1601___mcc_h856 = _source58.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1602___mcc_h857 = _source58.dtor_typeArgs;
                  DAST._IResolvedType _1603___mcc_h858 = _source58.dtor_resolved;
                  DAST._IResolvedType _source59 = _1603___mcc_h858;
                  if (_source59.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1604___mcc_h862 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1605_recursiveGen;
                      bool _1606_recOwned;
                      bool _1607_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1608_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1023;
                      bool _out1024;
                      bool _out1025;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1026;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1023, out _out1024, out _out1025, out _out1026);
                      _1605_recursiveGen = _out1023;
                      _1606_recOwned = _out1024;
                      _1607_recErased = _out1025;
                      _1608_recIdents = _out1026;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1605_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1606_recOwned;
                      isErased = _1607_recErased;
                      readIdents = _1608_recIdents;
                    }
                  } else if (_source59.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1609___mcc_h864 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1610_recursiveGen;
                      bool _1611_recOwned;
                      bool _1612_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1613_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1027;
                      bool _out1028;
                      bool _out1029;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1030;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1027, out _out1028, out _out1029, out _out1030);
                      _1610_recursiveGen = _out1027;
                      _1611_recOwned = _out1028;
                      _1612_recErased = _out1029;
                      _1613_recIdents = _out1030;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1610_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1611_recOwned;
                      isErased = _1612_recErased;
                      readIdents = _1613_recIdents;
                    }
                  } else {
                    DAST._IType _1614___mcc_h866 = _source59.dtor_Newtype_a0;
                    DAST._IType _1615_b = _1614___mcc_h866;
                    {
                      if (object.Equals(_507_fromTpe, _1615_b)) {
                        Dafny.ISequence<Dafny.Rune> _1616_recursiveGen;
                        bool _1617_recOwned;
                        bool _1618_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1619_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1031;
                        bool _out1032;
                        bool _out1033;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1034;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1031, out _out1032, out _out1033, out _out1034);
                        _1616_recursiveGen = _out1031;
                        _1617_recOwned = _out1032;
                        _1618_recErased = _out1033;
                        _1619_recIdents = _out1034;
                        Dafny.ISequence<Dafny.Rune> _1620_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1035;
                        _out1035 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                        _1620_rhsType = _out1035;
                        Dafny.ISequence<Dafny.Rune> _1621_uneraseFn;
                        _1621_uneraseFn = ((_1617_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1620_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1621_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1616_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1617_recOwned;
                        isErased = false;
                        readIdents = _1619_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1036;
                        bool _out1037;
                        bool _out1038;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1039;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1615_b), _1615_b, _506_toTpe), selfIdent, @params, mustOwn, out _out1036, out _out1037, out _out1038, out _out1039);
                        s = _out1036;
                        isOwned = _out1037;
                        isErased = _out1038;
                        readIdents = _out1039;
                      }
                    }
                  }
                } else if (_source58.is_Nullable) {
                  DAST._IType _1622___mcc_h868 = _source58.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1623_recursiveGen;
                    bool _1624_recOwned;
                    bool _1625_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1626_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1040;
                    bool _out1041;
                    bool _out1042;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1043;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1040, out _out1041, out _out1042, out _out1043);
                    _1623_recursiveGen = _out1040;
                    _1624_recOwned = _out1041;
                    _1625_recErased = _out1042;
                    _1626_recIdents = _out1043;
                    if (!(_1624_recOwned)) {
                      _1623_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1623_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1623_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1625_recErased;
                    readIdents = _1626_recIdents;
                  }
                } else if (_source58.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1627___mcc_h870 = _source58.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1628_recursiveGen;
                    bool _1629_recOwned;
                    bool _1630_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1631_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1044;
                    bool _out1045;
                    bool _out1046;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1047;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1044, out _out1045, out _out1046, out _out1047);
                    _1628_recursiveGen = _out1044;
                    _1629_recOwned = _out1045;
                    _1630_recErased = _out1046;
                    _1631_recIdents = _out1047;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1628_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1629_recOwned;
                    isErased = _1630_recErased;
                    readIdents = _1631_recIdents;
                  }
                } else if (_source58.is_Array) {
                  DAST._IType _1632___mcc_h872 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1633_recursiveGen;
                    bool _1634_recOwned;
                    bool _1635_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1636_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1048;
                    bool _out1049;
                    bool _out1050;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1051;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1048, out _out1049, out _out1050, out _out1051);
                    _1633_recursiveGen = _out1048;
                    _1634_recOwned = _out1049;
                    _1635_recErased = _out1050;
                    _1636_recIdents = _out1051;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1633_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1634_recOwned;
                    isErased = _1635_recErased;
                    readIdents = _1636_recIdents;
                  }
                } else if (_source58.is_Seq) {
                  DAST._IType _1637___mcc_h874 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1638_recursiveGen;
                    bool _1639_recOwned;
                    bool _1640_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1641_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1052;
                    bool _out1053;
                    bool _out1054;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1055;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1052, out _out1053, out _out1054, out _out1055);
                    _1638_recursiveGen = _out1052;
                    _1639_recOwned = _out1053;
                    _1640_recErased = _out1054;
                    _1641_recIdents = _out1055;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1638_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1639_recOwned;
                    isErased = _1640_recErased;
                    readIdents = _1641_recIdents;
                  }
                } else if (_source58.is_Set) {
                  DAST._IType _1642___mcc_h876 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1643_recursiveGen;
                    bool _1644_recOwned;
                    bool _1645_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1646_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1056;
                    bool _out1057;
                    bool _out1058;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1059;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1056, out _out1057, out _out1058, out _out1059);
                    _1643_recursiveGen = _out1056;
                    _1644_recOwned = _out1057;
                    _1645_recErased = _out1058;
                    _1646_recIdents = _out1059;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1643_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1644_recOwned;
                    isErased = _1645_recErased;
                    readIdents = _1646_recIdents;
                  }
                } else if (_source58.is_Multiset) {
                  DAST._IType _1647___mcc_h878 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1648_recursiveGen;
                    bool _1649_recOwned;
                    bool _1650_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1651_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1060;
                    bool _out1061;
                    bool _out1062;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1063;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1060, out _out1061, out _out1062, out _out1063);
                    _1648_recursiveGen = _out1060;
                    _1649_recOwned = _out1061;
                    _1650_recErased = _out1062;
                    _1651_recIdents = _out1063;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1648_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1649_recOwned;
                    isErased = _1650_recErased;
                    readIdents = _1651_recIdents;
                  }
                } else if (_source58.is_Map) {
                  DAST._IType _1652___mcc_h880 = _source58.dtor_key;
                  DAST._IType _1653___mcc_h881 = _source58.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1654_recursiveGen;
                    bool _1655_recOwned;
                    bool _1656_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1657_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1064;
                    bool _out1065;
                    bool _out1066;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1067;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1064, out _out1065, out _out1066, out _out1067);
                    _1654_recursiveGen = _out1064;
                    _1655_recOwned = _out1065;
                    _1656_recErased = _out1066;
                    _1657_recIdents = _out1067;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1654_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1655_recOwned;
                    isErased = _1656_recErased;
                    readIdents = _1657_recIdents;
                  }
                } else if (_source58.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1658___mcc_h884 = _source58.dtor_args;
                  DAST._IType _1659___mcc_h885 = _source58.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1660_recursiveGen;
                    bool _1661_recOwned;
                    bool _1662_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1663_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1068;
                    bool _out1069;
                    bool _out1070;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1068, out _out1069, out _out1070, out _out1071);
                    _1660_recursiveGen = _out1068;
                    _1661_recOwned = _out1069;
                    _1662_recErased = _out1070;
                    _1663_recIdents = _out1071;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1660_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1661_recOwned;
                    isErased = _1662_recErased;
                    readIdents = _1663_recIdents;
                  }
                } else if (_source58.is_Primitive) {
                  DAST._IPrimitive _1664___mcc_h888 = _source58.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1665_recursiveGen;
                    bool _1666_recOwned;
                    bool _1667_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1668_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1072;
                    bool _out1073;
                    bool _out1074;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                    _1665_recursiveGen = _out1072;
                    _1666_recOwned = _out1073;
                    _1667_recErased = _out1074;
                    _1668_recIdents = _out1075;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1665_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1666_recOwned;
                    isErased = _1667_recErased;
                    readIdents = _1668_recIdents;
                  }
                } else if (_source58.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1669___mcc_h890 = _source58.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1670_recursiveGen;
                    bool _1671_recOwned;
                    bool _1672_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1673_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1076;
                    bool _out1077;
                    bool _out1078;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                    _1670_recursiveGen = _out1076;
                    _1671_recOwned = _out1077;
                    _1672_recErased = _out1078;
                    _1673_recIdents = _out1079;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1670_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1671_recOwned;
                    isErased = _1672_recErased;
                    readIdents = _1673_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1674___mcc_h892 = _source58.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1675_recursiveGen;
                    bool _1676_recOwned;
                    bool _1677_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1678_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1080;
                    bool _out1081;
                    bool _out1082;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                    _1675_recursiveGen = _out1080;
                    _1676_recOwned = _out1081;
                    _1677_recErased = _out1082;
                    _1678_recIdents = _out1083;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1675_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1676_recOwned;
                    isErased = _1677_recErased;
                    readIdents = _1678_recIdents;
                  }
                }
              } else if (_source51.is_Bool) {
                DAST._IType _source60 = _514___mcc_h253;
                if (_source60.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1679___mcc_h894 = _source60.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1680___mcc_h895 = _source60.dtor_typeArgs;
                  DAST._IResolvedType _1681___mcc_h896 = _source60.dtor_resolved;
                  DAST._IResolvedType _source61 = _1681___mcc_h896;
                  if (_source61.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1682___mcc_h900 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1683_recursiveGen;
                      bool _1684_recOwned;
                      bool _1685_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1686_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1084;
                      bool _out1085;
                      bool _out1086;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                      _1683_recursiveGen = _out1084;
                      _1684_recOwned = _out1085;
                      _1685_recErased = _out1086;
                      _1686_recIdents = _out1087;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1683_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1684_recOwned;
                      isErased = _1685_recErased;
                      readIdents = _1686_recIdents;
                    }
                  } else if (_source61.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1687___mcc_h902 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1688_recursiveGen;
                      bool _1689_recOwned;
                      bool _1690_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1691_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1088;
                      bool _out1089;
                      bool _out1090;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1091;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1088, out _out1089, out _out1090, out _out1091);
                      _1688_recursiveGen = _out1088;
                      _1689_recOwned = _out1089;
                      _1690_recErased = _out1090;
                      _1691_recIdents = _out1091;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1688_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1689_recOwned;
                      isErased = _1690_recErased;
                      readIdents = _1691_recIdents;
                    }
                  } else {
                    DAST._IType _1692___mcc_h904 = _source61.dtor_Newtype_a0;
                    DAST._IType _1693_b = _1692___mcc_h904;
                    {
                      if (object.Equals(_507_fromTpe, _1693_b)) {
                        Dafny.ISequence<Dafny.Rune> _1694_recursiveGen;
                        bool _1695_recOwned;
                        bool _1696_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1697_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1092;
                        bool _out1093;
                        bool _out1094;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1095;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1092, out _out1093, out _out1094, out _out1095);
                        _1694_recursiveGen = _out1092;
                        _1695_recOwned = _out1093;
                        _1696_recErased = _out1094;
                        _1697_recIdents = _out1095;
                        Dafny.ISequence<Dafny.Rune> _1698_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1096;
                        _out1096 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                        _1698_rhsType = _out1096;
                        Dafny.ISequence<Dafny.Rune> _1699_uneraseFn;
                        _1699_uneraseFn = ((_1695_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1698_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1699_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1694_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1695_recOwned;
                        isErased = false;
                        readIdents = _1697_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1097;
                        bool _out1098;
                        bool _out1099;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1100;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1693_b), _1693_b, _506_toTpe), selfIdent, @params, mustOwn, out _out1097, out _out1098, out _out1099, out _out1100);
                        s = _out1097;
                        isOwned = _out1098;
                        isErased = _out1099;
                        readIdents = _out1100;
                      }
                    }
                  }
                } else if (_source60.is_Nullable) {
                  DAST._IType _1700___mcc_h906 = _source60.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1701_recursiveGen;
                    bool _1702_recOwned;
                    bool _1703_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1704_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1101;
                    bool _out1102;
                    bool _out1103;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1104;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1101, out _out1102, out _out1103, out _out1104);
                    _1701_recursiveGen = _out1101;
                    _1702_recOwned = _out1102;
                    _1703_recErased = _out1103;
                    _1704_recIdents = _out1104;
                    if (!(_1702_recOwned)) {
                      _1701_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1701_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1701_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1703_recErased;
                    readIdents = _1704_recIdents;
                  }
                } else if (_source60.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1705___mcc_h908 = _source60.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1706_recursiveGen;
                    bool _1707_recOwned;
                    bool _1708_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1709_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1105;
                    bool _out1106;
                    bool _out1107;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1108;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1105, out _out1106, out _out1107, out _out1108);
                    _1706_recursiveGen = _out1105;
                    _1707_recOwned = _out1106;
                    _1708_recErased = _out1107;
                    _1709_recIdents = _out1108;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1706_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1707_recOwned;
                    isErased = _1708_recErased;
                    readIdents = _1709_recIdents;
                  }
                } else if (_source60.is_Array) {
                  DAST._IType _1710___mcc_h910 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1711_recursiveGen;
                    bool _1712_recOwned;
                    bool _1713_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1714_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1109;
                    bool _out1110;
                    bool _out1111;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                    _1711_recursiveGen = _out1109;
                    _1712_recOwned = _out1110;
                    _1713_recErased = _out1111;
                    _1714_recIdents = _out1112;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1712_recOwned;
                    isErased = _1713_recErased;
                    readIdents = _1714_recIdents;
                  }
                } else if (_source60.is_Seq) {
                  DAST._IType _1715___mcc_h912 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1716_recursiveGen;
                    bool _1717_recOwned;
                    bool _1718_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1719_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1113;
                    bool _out1114;
                    bool _out1115;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                    _1716_recursiveGen = _out1113;
                    _1717_recOwned = _out1114;
                    _1718_recErased = _out1115;
                    _1719_recIdents = _out1116;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1716_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1717_recOwned;
                    isErased = _1718_recErased;
                    readIdents = _1719_recIdents;
                  }
                } else if (_source60.is_Set) {
                  DAST._IType _1720___mcc_h914 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1721_recursiveGen;
                    bool _1722_recOwned;
                    bool _1723_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1724_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1117;
                    bool _out1118;
                    bool _out1119;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                    _1721_recursiveGen = _out1117;
                    _1722_recOwned = _out1118;
                    _1723_recErased = _out1119;
                    _1724_recIdents = _out1120;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1721_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1722_recOwned;
                    isErased = _1723_recErased;
                    readIdents = _1724_recIdents;
                  }
                } else if (_source60.is_Multiset) {
                  DAST._IType _1725___mcc_h916 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1726_recursiveGen;
                    bool _1727_recOwned;
                    bool _1728_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1729_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1121;
                    bool _out1122;
                    bool _out1123;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                    _1726_recursiveGen = _out1121;
                    _1727_recOwned = _out1122;
                    _1728_recErased = _out1123;
                    _1729_recIdents = _out1124;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1726_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1727_recOwned;
                    isErased = _1728_recErased;
                    readIdents = _1729_recIdents;
                  }
                } else if (_source60.is_Map) {
                  DAST._IType _1730___mcc_h918 = _source60.dtor_key;
                  DAST._IType _1731___mcc_h919 = _source60.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1732_recursiveGen;
                    bool _1733_recOwned;
                    bool _1734_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1735_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1125;
                    bool _out1126;
                    bool _out1127;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                    _1732_recursiveGen = _out1125;
                    _1733_recOwned = _out1126;
                    _1734_recErased = _out1127;
                    _1735_recIdents = _out1128;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1732_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1733_recOwned;
                    isErased = _1734_recErased;
                    readIdents = _1735_recIdents;
                  }
                } else if (_source60.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1736___mcc_h922 = _source60.dtor_args;
                  DAST._IType _1737___mcc_h923 = _source60.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1738_recursiveGen;
                    bool _1739_recOwned;
                    bool _1740_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1741_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1129;
                    bool _out1130;
                    bool _out1131;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                    _1738_recursiveGen = _out1129;
                    _1739_recOwned = _out1130;
                    _1740_recErased = _out1131;
                    _1741_recIdents = _out1132;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1738_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1739_recOwned;
                    isErased = _1740_recErased;
                    readIdents = _1741_recIdents;
                  }
                } else if (_source60.is_Primitive) {
                  DAST._IPrimitive _1742___mcc_h926 = _source60.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1743_recursiveGen;
                    bool _1744_recOwned;
                    bool _1745_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1746_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1133;
                    bool _out1134;
                    bool _out1135;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                    _1743_recursiveGen = _out1133;
                    _1744_recOwned = _out1134;
                    _1745_recErased = _out1135;
                    _1746_recIdents = _out1136;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1743_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1744_recOwned;
                    isErased = _1745_recErased;
                    readIdents = _1746_recIdents;
                  }
                } else if (_source60.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1747___mcc_h928 = _source60.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1748_recursiveGen;
                    bool _1749_recOwned;
                    bool _1750_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1751_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1137;
                    bool _out1138;
                    bool _out1139;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                    _1748_recursiveGen = _out1137;
                    _1749_recOwned = _out1138;
                    _1750_recErased = _out1139;
                    _1751_recIdents = _out1140;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1748_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1749_recOwned;
                    isErased = _1750_recErased;
                    readIdents = _1751_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1752___mcc_h930 = _source60.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1753_recursiveGen;
                    bool _1754_recOwned;
                    bool _1755_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1756_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1141;
                    bool _out1142;
                    bool _out1143;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1144;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1141, out _out1142, out _out1143, out _out1144);
                    _1753_recursiveGen = _out1141;
                    _1754_recOwned = _out1142;
                    _1755_recErased = _out1143;
                    _1756_recIdents = _out1144;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1753_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1754_recOwned;
                    isErased = _1755_recErased;
                    readIdents = _1756_recIdents;
                  }
                }
              } else {
                DAST._IType _source62 = _514___mcc_h253;
                if (_source62.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1757___mcc_h932 = _source62.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1758___mcc_h933 = _source62.dtor_typeArgs;
                  DAST._IResolvedType _1759___mcc_h934 = _source62.dtor_resolved;
                  DAST._IResolvedType _source63 = _1759___mcc_h934;
                  if (_source63.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1760___mcc_h938 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1761_recursiveGen;
                      bool _1762_recOwned;
                      bool _1763_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1764_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1145;
                      bool _out1146;
                      bool _out1147;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1148;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1145, out _out1146, out _out1147, out _out1148);
                      _1761_recursiveGen = _out1145;
                      _1762_recOwned = _out1146;
                      _1763_recErased = _out1147;
                      _1764_recIdents = _out1148;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1761_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1762_recOwned;
                      isErased = _1763_recErased;
                      readIdents = _1764_recIdents;
                    }
                  } else if (_source63.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1765___mcc_h940 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1766_recursiveGen;
                      bool _1767_recOwned;
                      bool _1768_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1769_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1149;
                      bool _out1150;
                      bool _out1151;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1152;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1149, out _out1150, out _out1151, out _out1152);
                      _1766_recursiveGen = _out1149;
                      _1767_recOwned = _out1150;
                      _1768_recErased = _out1151;
                      _1769_recIdents = _out1152;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1766_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1767_recOwned;
                      isErased = _1768_recErased;
                      readIdents = _1769_recIdents;
                    }
                  } else {
                    DAST._IType _1770___mcc_h942 = _source63.dtor_Newtype_a0;
                    DAST._IType _1771_b = _1770___mcc_h942;
                    {
                      if (object.Equals(_507_fromTpe, _1771_b)) {
                        Dafny.ISequence<Dafny.Rune> _1772_recursiveGen;
                        bool _1773_recOwned;
                        bool _1774_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1775_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1153;
                        bool _out1154;
                        bool _out1155;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1156;
                        DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1153, out _out1154, out _out1155, out _out1156);
                        _1772_recursiveGen = _out1153;
                        _1773_recOwned = _out1154;
                        _1774_recErased = _out1155;
                        _1775_recIdents = _out1156;
                        Dafny.ISequence<Dafny.Rune> _1776_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1157;
                        _out1157 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                        _1776_rhsType = _out1157;
                        Dafny.ISequence<Dafny.Rune> _1777_uneraseFn;
                        _1777_uneraseFn = ((_1773_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1776_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1777_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1772_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1773_recOwned;
                        isErased = false;
                        readIdents = _1775_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1158;
                        bool _out1159;
                        bool _out1160;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1771_b), _1771_b, _506_toTpe), selfIdent, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                        s = _out1158;
                        isOwned = _out1159;
                        isErased = _out1160;
                        readIdents = _out1161;
                      }
                    }
                  }
                } else if (_source62.is_Nullable) {
                  DAST._IType _1778___mcc_h944 = _source62.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1779_recursiveGen;
                    bool _1780_recOwned;
                    bool _1781_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1782_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1162;
                    bool _out1163;
                    bool _out1164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                    _1779_recursiveGen = _out1162;
                    _1780_recOwned = _out1163;
                    _1781_recErased = _out1164;
                    _1782_recIdents = _out1165;
                    if (!(_1780_recOwned)) {
                      _1779_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1779_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1779_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1781_recErased;
                    readIdents = _1782_recIdents;
                  }
                } else if (_source62.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1783___mcc_h946 = _source62.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1784_recursiveGen;
                    bool _1785_recOwned;
                    bool _1786_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1787_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1166;
                    bool _out1167;
                    bool _out1168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1169;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1166, out _out1167, out _out1168, out _out1169);
                    _1784_recursiveGen = _out1166;
                    _1785_recOwned = _out1167;
                    _1786_recErased = _out1168;
                    _1787_recIdents = _out1169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1784_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1785_recOwned;
                    isErased = _1786_recErased;
                    readIdents = _1787_recIdents;
                  }
                } else if (_source62.is_Array) {
                  DAST._IType _1788___mcc_h948 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1789_recursiveGen;
                    bool _1790_recOwned;
                    bool _1791_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1792_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1170;
                    bool _out1171;
                    bool _out1172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1173;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1170, out _out1171, out _out1172, out _out1173);
                    _1789_recursiveGen = _out1170;
                    _1790_recOwned = _out1171;
                    _1791_recErased = _out1172;
                    _1792_recIdents = _out1173;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1789_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1790_recOwned;
                    isErased = _1791_recErased;
                    readIdents = _1792_recIdents;
                  }
                } else if (_source62.is_Seq) {
                  DAST._IType _1793___mcc_h950 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1794_recursiveGen;
                    bool _1795_recOwned;
                    bool _1796_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1797_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1174;
                    bool _out1175;
                    bool _out1176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1177;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1174, out _out1175, out _out1176, out _out1177);
                    _1794_recursiveGen = _out1174;
                    _1795_recOwned = _out1175;
                    _1796_recErased = _out1176;
                    _1797_recIdents = _out1177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1794_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1795_recOwned;
                    isErased = _1796_recErased;
                    readIdents = _1797_recIdents;
                  }
                } else if (_source62.is_Set) {
                  DAST._IType _1798___mcc_h952 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1799_recursiveGen;
                    bool _1800_recOwned;
                    bool _1801_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1802_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1178;
                    bool _out1179;
                    bool _out1180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1181;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1178, out _out1179, out _out1180, out _out1181);
                    _1799_recursiveGen = _out1178;
                    _1800_recOwned = _out1179;
                    _1801_recErased = _out1180;
                    _1802_recIdents = _out1181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1799_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1800_recOwned;
                    isErased = _1801_recErased;
                    readIdents = _1802_recIdents;
                  }
                } else if (_source62.is_Multiset) {
                  DAST._IType _1803___mcc_h954 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1804_recursiveGen;
                    bool _1805_recOwned;
                    bool _1806_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1807_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1182;
                    bool _out1183;
                    bool _out1184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1185;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1182, out _out1183, out _out1184, out _out1185);
                    _1804_recursiveGen = _out1182;
                    _1805_recOwned = _out1183;
                    _1806_recErased = _out1184;
                    _1807_recIdents = _out1185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1804_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1805_recOwned;
                    isErased = _1806_recErased;
                    readIdents = _1807_recIdents;
                  }
                } else if (_source62.is_Map) {
                  DAST._IType _1808___mcc_h956 = _source62.dtor_key;
                  DAST._IType _1809___mcc_h957 = _source62.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1810_recursiveGen;
                    bool _1811_recOwned;
                    bool _1812_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1813_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1186;
                    bool _out1187;
                    bool _out1188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1189;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1186, out _out1187, out _out1188, out _out1189);
                    _1810_recursiveGen = _out1186;
                    _1811_recOwned = _out1187;
                    _1812_recErased = _out1188;
                    _1813_recIdents = _out1189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1810_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1811_recOwned;
                    isErased = _1812_recErased;
                    readIdents = _1813_recIdents;
                  }
                } else if (_source62.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1814___mcc_h960 = _source62.dtor_args;
                  DAST._IType _1815___mcc_h961 = _source62.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1816_recursiveGen;
                    bool _1817_recOwned;
                    bool _1818_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1819_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1190;
                    bool _out1191;
                    bool _out1192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1193;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1190, out _out1191, out _out1192, out _out1193);
                    _1816_recursiveGen = _out1190;
                    _1817_recOwned = _out1191;
                    _1818_recErased = _out1192;
                    _1819_recIdents = _out1193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1816_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1817_recOwned;
                    isErased = _1818_recErased;
                    readIdents = _1819_recIdents;
                  }
                } else if (_source62.is_Primitive) {
                  DAST._IPrimitive _1820___mcc_h964 = _source62.dtor_Primitive_a0;
                  DAST._IPrimitive _source64 = _1820___mcc_h964;
                  if (_source64.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1821_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1194;
                      _out1194 = DCOMP.COMP.GenType(_507_fromTpe, true, false);
                      _1821_rhsType = _out1194;
                      Dafny.ISequence<Dafny.Rune> _1822_recursiveGen;
                      bool _1823___v56;
                      bool _1824___v57;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1825_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1195;
                      bool _out1196;
                      bool _out1197;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1198;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, true, out _out1195, out _out1196, out _out1197, out _out1198);
                      _1822_recursiveGen = _out1195;
                      _1823___v56 = _out1196;
                      _1824___v57 = _out1197;
                      _1825_recIdents = _out1198;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1822_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1825_recIdents;
                    }
                  } else if (_source64.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1826_recursiveGen;
                      bool _1827_recOwned;
                      bool _1828_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1829_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1199;
                      bool _out1200;
                      bool _out1201;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1202;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1199, out _out1200, out _out1201, out _out1202);
                      _1826_recursiveGen = _out1199;
                      _1827_recOwned = _out1200;
                      _1828_recErased = _out1201;
                      _1829_recIdents = _out1202;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1826_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1827_recOwned;
                      isErased = _1828_recErased;
                      readIdents = _1829_recIdents;
                    }
                  } else if (_source64.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1830_recursiveGen;
                      bool _1831_recOwned;
                      bool _1832_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1833_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      bool _out1204;
                      bool _out1205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1206;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1203, out _out1204, out _out1205, out _out1206);
                      _1830_recursiveGen = _out1203;
                      _1831_recOwned = _out1204;
                      _1832_recErased = _out1205;
                      _1833_recIdents = _out1206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1830_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1831_recOwned;
                      isErased = _1832_recErased;
                      readIdents = _1833_recIdents;
                    }
                  } else if (_source64.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1834_recursiveGen;
                      bool _1835_recOwned;
                      bool _1836_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1837_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1207;
                      bool _out1208;
                      bool _out1209;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1210;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1207, out _out1208, out _out1209, out _out1210);
                      _1834_recursiveGen = _out1207;
                      _1835_recOwned = _out1208;
                      _1836_recErased = _out1209;
                      _1837_recIdents = _out1210;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1834_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1835_recOwned;
                      isErased = _1836_recErased;
                      readIdents = _1837_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1838_recursiveGen;
                      bool _1839_recOwned;
                      bool _1840_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1841_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1211;
                      bool _out1212;
                      bool _out1213;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1214;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1211, out _out1212, out _out1213, out _out1214);
                      _1838_recursiveGen = _out1211;
                      _1839_recOwned = _out1212;
                      _1840_recErased = _out1213;
                      _1841_recIdents = _out1214;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1838_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1839_recOwned;
                      isErased = _1840_recErased;
                      readIdents = _1841_recIdents;
                    }
                  }
                } else if (_source62.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1842___mcc_h966 = _source62.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1843_recursiveGen;
                    bool _1844_recOwned;
                    bool _1845_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1846_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1215;
                    bool _out1216;
                    bool _out1217;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1218;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1215, out _out1216, out _out1217, out _out1218);
                    _1843_recursiveGen = _out1215;
                    _1844_recOwned = _out1216;
                    _1845_recErased = _out1217;
                    _1846_recIdents = _out1218;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1843_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1844_recOwned;
                    isErased = _1845_recErased;
                    readIdents = _1846_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1847___mcc_h968 = _source62.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1848_recursiveGen;
                    bool _1849_recOwned;
                    bool _1850_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1851_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1219;
                    bool _out1220;
                    bool _out1221;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1222;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1219, out _out1220, out _out1221, out _out1222);
                    _1848_recursiveGen = _out1219;
                    _1849_recOwned = _out1220;
                    _1850_recErased = _out1221;
                    _1851_recIdents = _out1222;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1848_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1849_recOwned;
                    isErased = _1850_recErased;
                    readIdents = _1851_recIdents;
                  }
                }
              }
            } else if (_source27.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1852___mcc_h970 = _source27.dtor_Passthrough_a0;
              DAST._IType _source65 = _514___mcc_h253;
              if (_source65.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1853___mcc_h974 = _source65.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1854___mcc_h975 = _source65.dtor_typeArgs;
                DAST._IResolvedType _1855___mcc_h976 = _source65.dtor_resolved;
                DAST._IResolvedType _source66 = _1855___mcc_h976;
                if (_source66.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1856___mcc_h980 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1857_recursiveGen;
                    bool _1858_recOwned;
                    bool _1859_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1860_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1223;
                    bool _out1224;
                    bool _out1225;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1226;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1223, out _out1224, out _out1225, out _out1226);
                    _1857_recursiveGen = _out1223;
                    _1858_recOwned = _out1224;
                    _1859_recErased = _out1225;
                    _1860_recIdents = _out1226;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1857_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1858_recOwned;
                    isErased = _1859_recErased;
                    readIdents = _1860_recIdents;
                  }
                } else if (_source66.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1861___mcc_h982 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1862_recursiveGen;
                    bool _1863_recOwned;
                    bool _1864_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1865_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1227;
                    bool _out1228;
                    bool _out1229;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1230;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1227, out _out1228, out _out1229, out _out1230);
                    _1862_recursiveGen = _out1227;
                    _1863_recOwned = _out1228;
                    _1864_recErased = _out1229;
                    _1865_recIdents = _out1230;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1862_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1863_recOwned;
                    isErased = _1864_recErased;
                    readIdents = _1865_recIdents;
                  }
                } else {
                  DAST._IType _1866___mcc_h984 = _source66.dtor_Newtype_a0;
                  DAST._IType _1867_b = _1866___mcc_h984;
                  {
                    if (object.Equals(_507_fromTpe, _1867_b)) {
                      Dafny.ISequence<Dafny.Rune> _1868_recursiveGen;
                      bool _1869_recOwned;
                      bool _1870_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1871_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1231;
                      bool _out1232;
                      bool _out1233;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1234;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1231, out _out1232, out _out1233, out _out1234);
                      _1868_recursiveGen = _out1231;
                      _1869_recOwned = _out1232;
                      _1870_recErased = _out1233;
                      _1871_recIdents = _out1234;
                      Dafny.ISequence<Dafny.Rune> _1872_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1235;
                      _out1235 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _1872_rhsType = _out1235;
                      Dafny.ISequence<Dafny.Rune> _1873_uneraseFn;
                      _1873_uneraseFn = ((_1869_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1872_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1873_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1868_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1869_recOwned;
                      isErased = false;
                      readIdents = _1871_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1236;
                      bool _out1237;
                      bool _out1238;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1867_b), _1867_b, _506_toTpe), selfIdent, @params, mustOwn, out _out1236, out _out1237, out _out1238, out _out1239);
                      s = _out1236;
                      isOwned = _out1237;
                      isErased = _out1238;
                      readIdents = _out1239;
                    }
                  }
                }
              } else if (_source65.is_Nullable) {
                DAST._IType _1874___mcc_h986 = _source65.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1875_recursiveGen;
                  bool _1876_recOwned;
                  bool _1877_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1878_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1240;
                  bool _out1241;
                  bool _out1242;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
                  _1875_recursiveGen = _out1240;
                  _1876_recOwned = _out1241;
                  _1877_recErased = _out1242;
                  _1878_recIdents = _out1243;
                  if (!(_1876_recOwned)) {
                    _1875_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1875_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1875_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1877_recErased;
                  readIdents = _1878_recIdents;
                }
              } else if (_source65.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1879___mcc_h988 = _source65.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1880_recursiveGen;
                  bool _1881_recOwned;
                  bool _1882_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1883_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1244;
                  bool _out1245;
                  bool _out1246;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1244, out _out1245, out _out1246, out _out1247);
                  _1880_recursiveGen = _out1244;
                  _1881_recOwned = _out1245;
                  _1882_recErased = _out1246;
                  _1883_recIdents = _out1247;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1880_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1881_recOwned;
                  isErased = _1882_recErased;
                  readIdents = _1883_recIdents;
                }
              } else if (_source65.is_Array) {
                DAST._IType _1884___mcc_h990 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1885_recursiveGen;
                  bool _1886_recOwned;
                  bool _1887_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1888_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1248;
                  bool _out1249;
                  bool _out1250;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1248, out _out1249, out _out1250, out _out1251);
                  _1885_recursiveGen = _out1248;
                  _1886_recOwned = _out1249;
                  _1887_recErased = _out1250;
                  _1888_recIdents = _out1251;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1885_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1886_recOwned;
                  isErased = _1887_recErased;
                  readIdents = _1888_recIdents;
                }
              } else if (_source65.is_Seq) {
                DAST._IType _1889___mcc_h992 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1890_recursiveGen;
                  bool _1891_recOwned;
                  bool _1892_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1893_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1252;
                  bool _out1253;
                  bool _out1254;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1252, out _out1253, out _out1254, out _out1255);
                  _1890_recursiveGen = _out1252;
                  _1891_recOwned = _out1253;
                  _1892_recErased = _out1254;
                  _1893_recIdents = _out1255;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1890_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1891_recOwned;
                  isErased = _1892_recErased;
                  readIdents = _1893_recIdents;
                }
              } else if (_source65.is_Set) {
                DAST._IType _1894___mcc_h994 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1895_recursiveGen;
                  bool _1896_recOwned;
                  bool _1897_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1898_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1256;
                  bool _out1257;
                  bool _out1258;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1256, out _out1257, out _out1258, out _out1259);
                  _1895_recursiveGen = _out1256;
                  _1896_recOwned = _out1257;
                  _1897_recErased = _out1258;
                  _1898_recIdents = _out1259;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1895_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1896_recOwned;
                  isErased = _1897_recErased;
                  readIdents = _1898_recIdents;
                }
              } else if (_source65.is_Multiset) {
                DAST._IType _1899___mcc_h996 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1900_recursiveGen;
                  bool _1901_recOwned;
                  bool _1902_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1903_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1260;
                  bool _out1261;
                  bool _out1262;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1260, out _out1261, out _out1262, out _out1263);
                  _1900_recursiveGen = _out1260;
                  _1901_recOwned = _out1261;
                  _1902_recErased = _out1262;
                  _1903_recIdents = _out1263;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1900_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1901_recOwned;
                  isErased = _1902_recErased;
                  readIdents = _1903_recIdents;
                }
              } else if (_source65.is_Map) {
                DAST._IType _1904___mcc_h998 = _source65.dtor_key;
                DAST._IType _1905___mcc_h999 = _source65.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1906_recursiveGen;
                  bool _1907_recOwned;
                  bool _1908_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1909_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1264;
                  bool _out1265;
                  bool _out1266;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1267;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1264, out _out1265, out _out1266, out _out1267);
                  _1906_recursiveGen = _out1264;
                  _1907_recOwned = _out1265;
                  _1908_recErased = _out1266;
                  _1909_recIdents = _out1267;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1906_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1907_recOwned;
                  isErased = _1908_recErased;
                  readIdents = _1909_recIdents;
                }
              } else if (_source65.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1910___mcc_h1002 = _source65.dtor_args;
                DAST._IType _1911___mcc_h1003 = _source65.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1912_recursiveGen;
                  bool _1913_recOwned;
                  bool _1914_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1915_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1268;
                  bool _out1269;
                  bool _out1270;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1271;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1268, out _out1269, out _out1270, out _out1271);
                  _1912_recursiveGen = _out1268;
                  _1913_recOwned = _out1269;
                  _1914_recErased = _out1270;
                  _1915_recIdents = _out1271;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1912_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1913_recOwned;
                  isErased = _1914_recErased;
                  readIdents = _1915_recIdents;
                }
              } else if (_source65.is_Primitive) {
                DAST._IPrimitive _1916___mcc_h1006 = _source65.dtor_Primitive_a0;
                DAST._IPrimitive _source67 = _1916___mcc_h1006;
                if (_source67.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1917_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1272;
                    _out1272 = DCOMP.COMP.GenType(_507_fromTpe, true, false);
                    _1917_rhsType = _out1272;
                    Dafny.ISequence<Dafny.Rune> _1918_recursiveGen;
                    bool _1919___v52;
                    bool _1920___v53;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1921_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1273;
                    bool _out1274;
                    bool _out1275;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1276;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, true, out _out1273, out _out1274, out _out1275, out _out1276);
                    _1918_recursiveGen = _out1273;
                    _1919___v52 = _out1274;
                    _1920___v53 = _out1275;
                    _1921_recIdents = _out1276;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1918_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1921_recIdents;
                  }
                } else if (_source67.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1922_recursiveGen;
                    bool _1923_recOwned;
                    bool _1924_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1925_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1277;
                    bool _out1278;
                    bool _out1279;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1280;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1277, out _out1278, out _out1279, out _out1280);
                    _1922_recursiveGen = _out1277;
                    _1923_recOwned = _out1278;
                    _1924_recErased = _out1279;
                    _1925_recIdents = _out1280;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1922_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1923_recOwned;
                    isErased = _1924_recErased;
                    readIdents = _1925_recIdents;
                  }
                } else if (_source67.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1926_recursiveGen;
                    bool _1927_recOwned;
                    bool _1928_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1929_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    bool _out1282;
                    bool _out1283;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1284;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1281, out _out1282, out _out1283, out _out1284);
                    _1926_recursiveGen = _out1281;
                    _1927_recOwned = _out1282;
                    _1928_recErased = _out1283;
                    _1929_recIdents = _out1284;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1926_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1927_recOwned;
                    isErased = _1928_recErased;
                    readIdents = _1929_recIdents;
                  }
                } else if (_source67.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1930_recursiveGen;
                    bool _1931_recOwned;
                    bool _1932_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1933_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1285;
                    bool _out1286;
                    bool _out1287;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1288;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1285, out _out1286, out _out1287, out _out1288);
                    _1930_recursiveGen = _out1285;
                    _1931_recOwned = _out1286;
                    _1932_recErased = _out1287;
                    _1933_recIdents = _out1288;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1931_recOwned;
                    isErased = _1932_recErased;
                    readIdents = _1933_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1934_recursiveGen;
                    bool _1935_recOwned;
                    bool _1936_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1937_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1289;
                    bool _out1290;
                    bool _out1291;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1292;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1289, out _out1290, out _out1291, out _out1292);
                    _1934_recursiveGen = _out1289;
                    _1935_recOwned = _out1290;
                    _1936_recErased = _out1291;
                    _1937_recIdents = _out1292;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1934_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1935_recOwned;
                    isErased = _1936_recErased;
                    readIdents = _1937_recIdents;
                  }
                }
              } else if (_source65.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1938___mcc_h1008 = _source65.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1939_recursiveGen;
                  bool _1940___v60;
                  bool _1941___v61;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1942_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1293;
                  bool _out1294;
                  bool _out1295;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1296;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, true, out _out1293, out _out1294, out _out1295, out _out1296);
                  _1939_recursiveGen = _out1293;
                  _1940___v60 = _out1294;
                  _1941___v61 = _out1295;
                  _1942_recIdents = _out1296;
                  Dafny.ISequence<Dafny.Rune> _1943_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1297;
                  _out1297 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                  _1943_toTpeGen = _out1297;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1939_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1943_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1942_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1944___mcc_h1010 = _source65.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1945_recursiveGen;
                  bool _1946_recOwned;
                  bool _1947_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1948_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1298;
                  bool _out1299;
                  bool _out1300;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1301;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1298, out _out1299, out _out1300, out _out1301);
                  _1945_recursiveGen = _out1298;
                  _1946_recOwned = _out1299;
                  _1947_recErased = _out1300;
                  _1948_recIdents = _out1301;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1945_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1946_recOwned;
                  isErased = _1947_recErased;
                  readIdents = _1948_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1949___mcc_h1012 = _source27.dtor_TypeArg_a0;
              DAST._IType _source68 = _514___mcc_h253;
              if (_source68.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1950___mcc_h1016 = _source68.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1951___mcc_h1017 = _source68.dtor_typeArgs;
                DAST._IResolvedType _1952___mcc_h1018 = _source68.dtor_resolved;
                DAST._IResolvedType _source69 = _1952___mcc_h1018;
                if (_source69.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1953___mcc_h1022 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1954_recursiveGen;
                    bool _1955_recOwned;
                    bool _1956_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1957_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1302;
                    bool _out1303;
                    bool _out1304;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1302, out _out1303, out _out1304, out _out1305);
                    _1954_recursiveGen = _out1302;
                    _1955_recOwned = _out1303;
                    _1956_recErased = _out1304;
                    _1957_recIdents = _out1305;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1954_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1955_recOwned;
                    isErased = _1956_recErased;
                    readIdents = _1957_recIdents;
                  }
                } else if (_source69.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1958___mcc_h1024 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1959_recursiveGen;
                    bool _1960_recOwned;
                    bool _1961_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1962_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1306;
                    bool _out1307;
                    bool _out1308;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1309;
                    DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1306, out _out1307, out _out1308, out _out1309);
                    _1959_recursiveGen = _out1306;
                    _1960_recOwned = _out1307;
                    _1961_recErased = _out1308;
                    _1962_recIdents = _out1309;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1959_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1960_recOwned;
                    isErased = _1961_recErased;
                    readIdents = _1962_recIdents;
                  }
                } else {
                  DAST._IType _1963___mcc_h1026 = _source69.dtor_Newtype_a0;
                  DAST._IType _1964_b = _1963___mcc_h1026;
                  {
                    if (object.Equals(_507_fromTpe, _1964_b)) {
                      Dafny.ISequence<Dafny.Rune> _1965_recursiveGen;
                      bool _1966_recOwned;
                      bool _1967_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1968_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1310;
                      bool _out1311;
                      bool _out1312;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1313;
                      DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1310, out _out1311, out _out1312, out _out1313);
                      _1965_recursiveGen = _out1310;
                      _1966_recOwned = _out1311;
                      _1967_recErased = _out1312;
                      _1968_recIdents = _out1313;
                      Dafny.ISequence<Dafny.Rune> _1969_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1314;
                      _out1314 = DCOMP.COMP.GenType(_506_toTpe, true, false);
                      _1969_rhsType = _out1314;
                      Dafny.ISequence<Dafny.Rune> _1970_uneraseFn;
                      _1970_uneraseFn = ((_1966_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1969_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1970_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1965_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1966_recOwned;
                      isErased = false;
                      readIdents = _1968_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1315;
                      bool _out1316;
                      bool _out1317;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1318;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_508_expr, _507_fromTpe, _1964_b), _1964_b, _506_toTpe), selfIdent, @params, mustOwn, out _out1315, out _out1316, out _out1317, out _out1318);
                      s = _out1315;
                      isOwned = _out1316;
                      isErased = _out1317;
                      readIdents = _out1318;
                    }
                  }
                }
              } else if (_source68.is_Nullable) {
                DAST._IType _1971___mcc_h1028 = _source68.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1972_recursiveGen;
                  bool _1973_recOwned;
                  bool _1974_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1975_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1319;
                  bool _out1320;
                  bool _out1321;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1322;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1319, out _out1320, out _out1321, out _out1322);
                  _1972_recursiveGen = _out1319;
                  _1973_recOwned = _out1320;
                  _1974_recErased = _out1321;
                  _1975_recIdents = _out1322;
                  if (!(_1973_recOwned)) {
                    _1972_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1972_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1972_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1974_recErased;
                  readIdents = _1975_recIdents;
                }
              } else if (_source68.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1976___mcc_h1030 = _source68.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1977_recursiveGen;
                  bool _1978_recOwned;
                  bool _1979_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1980_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1323;
                  bool _out1324;
                  bool _out1325;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1326;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1323, out _out1324, out _out1325, out _out1326);
                  _1977_recursiveGen = _out1323;
                  _1978_recOwned = _out1324;
                  _1979_recErased = _out1325;
                  _1980_recIdents = _out1326;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1977_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1978_recOwned;
                  isErased = _1979_recErased;
                  readIdents = _1980_recIdents;
                }
              } else if (_source68.is_Array) {
                DAST._IType _1981___mcc_h1032 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1982_recursiveGen;
                  bool _1983_recOwned;
                  bool _1984_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1985_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1327;
                  bool _out1328;
                  bool _out1329;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1330;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1327, out _out1328, out _out1329, out _out1330);
                  _1982_recursiveGen = _out1327;
                  _1983_recOwned = _out1328;
                  _1984_recErased = _out1329;
                  _1985_recIdents = _out1330;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1983_recOwned;
                  isErased = _1984_recErased;
                  readIdents = _1985_recIdents;
                }
              } else if (_source68.is_Seq) {
                DAST._IType _1986___mcc_h1034 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1987_recursiveGen;
                  bool _1988_recOwned;
                  bool _1989_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1990_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1331;
                  bool _out1332;
                  bool _out1333;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1334;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1331, out _out1332, out _out1333, out _out1334);
                  _1987_recursiveGen = _out1331;
                  _1988_recOwned = _out1332;
                  _1989_recErased = _out1333;
                  _1990_recIdents = _out1334;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1987_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1988_recOwned;
                  isErased = _1989_recErased;
                  readIdents = _1990_recIdents;
                }
              } else if (_source68.is_Set) {
                DAST._IType _1991___mcc_h1036 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1992_recursiveGen;
                  bool _1993_recOwned;
                  bool _1994_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1995_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1335;
                  bool _out1336;
                  bool _out1337;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1338;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1335, out _out1336, out _out1337, out _out1338);
                  _1992_recursiveGen = _out1335;
                  _1993_recOwned = _out1336;
                  _1994_recErased = _out1337;
                  _1995_recIdents = _out1338;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1992_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1993_recOwned;
                  isErased = _1994_recErased;
                  readIdents = _1995_recIdents;
                }
              } else if (_source68.is_Multiset) {
                DAST._IType _1996___mcc_h1038 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1997_recursiveGen;
                  bool _1998_recOwned;
                  bool _1999_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2000_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1339;
                  bool _out1340;
                  bool _out1341;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1342;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1339, out _out1340, out _out1341, out _out1342);
                  _1997_recursiveGen = _out1339;
                  _1998_recOwned = _out1340;
                  _1999_recErased = _out1341;
                  _2000_recIdents = _out1342;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1997_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1998_recOwned;
                  isErased = _1999_recErased;
                  readIdents = _2000_recIdents;
                }
              } else if (_source68.is_Map) {
                DAST._IType _2001___mcc_h1040 = _source68.dtor_key;
                DAST._IType _2002___mcc_h1041 = _source68.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _2003_recursiveGen;
                  bool _2004_recOwned;
                  bool _2005_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2006_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1343;
                  bool _out1344;
                  bool _out1345;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1346;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1343, out _out1344, out _out1345, out _out1346);
                  _2003_recursiveGen = _out1343;
                  _2004_recOwned = _out1344;
                  _2005_recErased = _out1345;
                  _2006_recIdents = _out1346;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2003_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2004_recOwned;
                  isErased = _2005_recErased;
                  readIdents = _2006_recIdents;
                }
              } else if (_source68.is_Arrow) {
                Dafny.ISequence<DAST._IType> _2007___mcc_h1044 = _source68.dtor_args;
                DAST._IType _2008___mcc_h1045 = _source68.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _2009_recursiveGen;
                  bool _2010_recOwned;
                  bool _2011_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2012_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1347;
                  bool _out1348;
                  bool _out1349;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1350;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1347, out _out1348, out _out1349, out _out1350);
                  _2009_recursiveGen = _out1347;
                  _2010_recOwned = _out1348;
                  _2011_recErased = _out1349;
                  _2012_recIdents = _out1350;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2010_recOwned;
                  isErased = _2011_recErased;
                  readIdents = _2012_recIdents;
                }
              } else if (_source68.is_Primitive) {
                DAST._IPrimitive _2013___mcc_h1048 = _source68.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2014_recursiveGen;
                  bool _2015_recOwned;
                  bool _2016_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2017_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1351;
                  bool _out1352;
                  bool _out1353;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1354;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1351, out _out1352, out _out1353, out _out1354);
                  _2014_recursiveGen = _out1351;
                  _2015_recOwned = _out1352;
                  _2016_recErased = _out1353;
                  _2017_recIdents = _out1354;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2014_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2015_recOwned;
                  isErased = _2016_recErased;
                  readIdents = _2017_recIdents;
                }
              } else if (_source68.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2018___mcc_h1050 = _source68.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2019_recursiveGen;
                  bool _2020_recOwned;
                  bool _2021_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2022_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1355;
                  bool _out1356;
                  bool _out1357;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1358;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1355, out _out1356, out _out1357, out _out1358);
                  _2019_recursiveGen = _out1355;
                  _2020_recOwned = _out1356;
                  _2021_recErased = _out1357;
                  _2022_recIdents = _out1358;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2019_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2020_recOwned;
                  isErased = _2021_recErased;
                  readIdents = _2022_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2023___mcc_h1052 = _source68.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2024_recursiveGen;
                  bool _2025_recOwned;
                  bool _2026_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2027_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1359;
                  bool _out1360;
                  bool _out1361;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1362;
                  DCOMP.COMP.GenExpr(_508_expr, selfIdent, @params, mustOwn, out _out1359, out _out1360, out _out1361, out _out1362);
                  _2024_recursiveGen = _out1359;
                  _2025_recOwned = _out1360;
                  _2026_recErased = _out1361;
                  _2027_recIdents = _out1362;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2024_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2025_recOwned;
                  isErased = _2026_recErased;
                  readIdents = _2027_recIdents;
                }
              }
            }
          }
        }
      } else if (_source20.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2028___mcc_h22 = _source20.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2029_exprs = _2028___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2030_generatedValues;
          _2030_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2031_i;
          _2031_i = BigInteger.Zero;
          bool _2032_allErased;
          _2032_allErased = true;
          while ((_2031_i) < (new BigInteger((_2029_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2033_recursiveGen;
            bool _2034___v63;
            bool _2035_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2036_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1363;
            bool _out1364;
            bool _out1365;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1366;
            DCOMP.COMP.GenExpr((_2029_exprs).Select(_2031_i), selfIdent, @params, true, out _out1363, out _out1364, out _out1365, out _out1366);
            _2033_recursiveGen = _out1363;
            _2034___v63 = _out1364;
            _2035_isErased = _out1365;
            _2036_recIdents = _out1366;
            _2032_allErased = (_2032_allErased) && (_2035_isErased);
            _2030_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2030_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2033_recursiveGen, _2035_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2036_recIdents);
            _2031_i = (_2031_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2031_i = BigInteger.Zero;
          while ((_2031_i) < (new BigInteger((_2030_generatedValues).Count))) {
            if ((_2031_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2037_gen;
            _2037_gen = ((_2030_generatedValues).Select(_2031_i)).dtor__0;
            if ((((_2030_generatedValues).Select(_2031_i)).dtor__1) && (!(_2032_allErased))) {
              _2037_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2037_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2037_gen);
            _2031_i = (_2031_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2032_allErased;
        }
      } else if (_source20.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2038___mcc_h23 = _source20.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2039_exprs = _2038___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2040_generatedValues;
          _2040_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2041_i;
          _2041_i = BigInteger.Zero;
          bool _2042_allErased;
          _2042_allErased = true;
          while ((_2041_i) < (new BigInteger((_2039_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2043_recursiveGen;
            bool _2044___v64;
            bool _2045_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2046_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1367;
            bool _out1368;
            bool _out1369;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1370;
            DCOMP.COMP.GenExpr((_2039_exprs).Select(_2041_i), selfIdent, @params, true, out _out1367, out _out1368, out _out1369, out _out1370);
            _2043_recursiveGen = _out1367;
            _2044___v64 = _out1368;
            _2045_isErased = _out1369;
            _2046_recIdents = _out1370;
            _2042_allErased = (_2042_allErased) && (_2045_isErased);
            _2040_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2040_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2043_recursiveGen, _2045_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2046_recIdents);
            _2041_i = (_2041_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2041_i = BigInteger.Zero;
          while ((_2041_i) < (new BigInteger((_2040_generatedValues).Count))) {
            if ((_2041_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2047_gen;
            _2047_gen = ((_2040_generatedValues).Select(_2041_i)).dtor__0;
            if ((((_2040_generatedValues).Select(_2041_i)).dtor__1) && (!(_2042_allErased))) {
              _2047_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2047_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2047_gen);
            _2041_i = (_2041_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source70 = selfIdent;
          if (_source70.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2048___mcc_h1054 = _source70.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2049_id = _2048___mcc_h1054;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2049_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2049_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2049_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2049_id);
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
        DAST._IExpression _2050___mcc_h24 = _source20.dtor_cond;
        DAST._IExpression _2051___mcc_h25 = _source20.dtor_thn;
        DAST._IExpression _2052___mcc_h26 = _source20.dtor_els;
        DAST._IExpression _2053_f = _2052___mcc_h26;
        DAST._IExpression _2054_t = _2051___mcc_h25;
        DAST._IExpression _2055_cond = _2050___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _2056_condString;
          bool _2057___v65;
          bool _2058_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2059_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1371;
          bool _out1372;
          bool _out1373;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1374;
          DCOMP.COMP.GenExpr(_2055_cond, selfIdent, @params, true, out _out1371, out _out1372, out _out1373, out _out1374);
          _2056_condString = _out1371;
          _2057___v65 = _out1372;
          _2058_condErased = _out1373;
          _2059_recIdentsCond = _out1374;
          if (!(_2058_condErased)) {
            _2056_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2056_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2060___v66;
          bool _2061_tHasToBeOwned;
          bool _2062___v67;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2063___v68;
          Dafny.ISequence<Dafny.Rune> _out1375;
          bool _out1376;
          bool _out1377;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1378;
          DCOMP.COMP.GenExpr(_2054_t, selfIdent, @params, mustOwn, out _out1375, out _out1376, out _out1377, out _out1378);
          _2060___v66 = _out1375;
          _2061_tHasToBeOwned = _out1376;
          _2062___v67 = _out1377;
          _2063___v68 = _out1378;
          Dafny.ISequence<Dafny.Rune> _2064_fString;
          bool _2065_fOwned;
          bool _2066_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2067_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1379;
          bool _out1380;
          bool _out1381;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1382;
          DCOMP.COMP.GenExpr(_2053_f, selfIdent, @params, _2061_tHasToBeOwned, out _out1379, out _out1380, out _out1381, out _out1382);
          _2064_fString = _out1379;
          _2065_fOwned = _out1380;
          _2066_fErased = _out1381;
          _2067_recIdentsF = _out1382;
          Dafny.ISequence<Dafny.Rune> _2068_tString;
          bool _2069___v69;
          bool _2070_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2071_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1383;
          bool _out1384;
          bool _out1385;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1386;
          DCOMP.COMP.GenExpr(_2054_t, selfIdent, @params, _2065_fOwned, out _out1383, out _out1384, out _out1385, out _out1386);
          _2068_tString = _out1383;
          _2069___v69 = _out1384;
          _2070_tErased = _out1385;
          _2071_recIdentsT = _out1386;
          if ((!(_2066_fErased)) || (!(_2070_tErased))) {
            if (_2066_fErased) {
              _2064_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2064_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2070_tErased) {
              _2068_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2068_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2056_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2068_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2064_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2065_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2059_recIdentsCond, _2071_recIdentsT), _2067_recIdentsF);
          isErased = (_2066_fErased) || (_2070_tErased);
        }
      } else if (_source20.is_UnOp) {
        DAST._IUnaryOp _2072___mcc_h27 = _source20.dtor_unOp;
        DAST._IExpression _2073___mcc_h28 = _source20.dtor_expr;
        DAST._IUnaryOp _source71 = _2072___mcc_h27;
        if (_source71.is_Not) {
          DAST._IExpression _2074_e = _2073___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2075_recursiveGen;
            bool _2076___v70;
            bool _2077_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2078_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1387;
            bool _out1388;
            bool _out1389;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1390;
            DCOMP.COMP.GenExpr(_2074_e, selfIdent, @params, true, out _out1387, out _out1388, out _out1389, out _out1390);
            _2075_recursiveGen = _out1387;
            _2076___v70 = _out1388;
            _2077_recErased = _out1389;
            _2078_recIdents = _out1390;
            if (!(_2077_recErased)) {
              _2075_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2075_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2075_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2078_recIdents;
            isErased = true;
          }
        } else if (_source71.is_BitwiseNot) {
          DAST._IExpression _2079_e = _2073___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2080_recursiveGen;
            bool _2081___v71;
            bool _2082_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2083_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1391;
            bool _out1392;
            bool _out1393;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1394;
            DCOMP.COMP.GenExpr(_2079_e, selfIdent, @params, true, out _out1391, out _out1392, out _out1393, out _out1394);
            _2080_recursiveGen = _out1391;
            _2081___v71 = _out1392;
            _2082_recErased = _out1393;
            _2083_recIdents = _out1394;
            if (!(_2082_recErased)) {
              _2080_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2080_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2080_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2083_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2084_e = _2073___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2085_recursiveGen;
            bool _2086_recOwned;
            bool _2087_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2088_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1395;
            bool _out1396;
            bool _out1397;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1398;
            DCOMP.COMP.GenExpr(_2084_e, selfIdent, @params, false, out _out1395, out _out1396, out _out1397, out _out1398);
            _2085_recursiveGen = _out1395;
            _2086_recOwned = _out1396;
            _2087_recErased = _out1397;
            _2088_recIdents = _out1398;
            if (!(_2087_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2089_eraseFn;
              _2089_eraseFn = ((_2086_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2085_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2089_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2085_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2085_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2088_recIdents;
            isErased = true;
          }
        }
      } else if (_source20.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2090___mcc_h29 = _source20.dtor_op;
        DAST._IExpression _2091___mcc_h30 = _source20.dtor_left;
        DAST._IExpression _2092___mcc_h31 = _source20.dtor_right;
        DAST._IExpression _2093_r = _2092___mcc_h31;
        DAST._IExpression _2094_l = _2091___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _2095_op = _2090___mcc_h29;
        {
          Dafny.ISequence<Dafny.Rune> _2096_left;
          bool _2097___v72;
          bool _2098_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2099_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1399;
          bool _out1400;
          bool _out1401;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1402;
          DCOMP.COMP.GenExpr(_2094_l, selfIdent, @params, true, out _out1399, out _out1400, out _out1401, out _out1402);
          _2096_left = _out1399;
          _2097___v72 = _out1400;
          _2098_leftErased = _out1401;
          _2099_recIdentsL = _out1402;
          Dafny.ISequence<Dafny.Rune> _2100_right;
          bool _2101___v73;
          bool _2102_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2103_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1403;
          bool _out1404;
          bool _out1405;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1406;
          DCOMP.COMP.GenExpr(_2093_r, selfIdent, @params, true, out _out1403, out _out1404, out _out1405, out _out1406);
          _2100_right = _out1403;
          _2101___v73 = _out1404;
          _2102_rightErased = _out1405;
          _2103_recIdentsR = _out1406;
          if (!(_2098_leftErased)) {
            _2096_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2096_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2102_rightErased)) {
            _2100_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2100_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2095_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2096_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2100_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2095_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2096_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2100_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2096_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2095_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2100_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2099_recIdentsL, _2103_recIdentsR);
          isErased = true;
        }
      } else if (_source20.is_ArrayLen) {
        DAST._IExpression _2104___mcc_h32 = _source20.dtor_expr;
        DAST._IExpression _2105_expr = _2104___mcc_h32;
        {
          Dafny.ISequence<Dafny.Rune> _2106_recursiveGen;
          bool _2107___v74;
          bool _2108_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2109_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1407;
          bool _out1408;
          bool _out1409;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1410;
          DCOMP.COMP.GenExpr(_2105_expr, selfIdent, @params, true, out _out1407, out _out1408, out _out1409, out _out1410);
          _2106_recursiveGen = _out1407;
          _2107___v74 = _out1408;
          _2108_recErased = _out1409;
          _2109_recIdents = _out1410;
          if (!(_2108_recErased)) {
            _2106_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2106_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2106_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow().len())"));
          isOwned = true;
          readIdents = _2109_recIdents;
          isErased = true;
        }
      } else if (_source20.is_Select) {
        DAST._IExpression _2110___mcc_h33 = _source20.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2111___mcc_h34 = _source20.dtor_field;
        bool _2112___mcc_h35 = _source20.dtor_isConstant;
        bool _2113___mcc_h36 = _source20.dtor_onDatatype;
        DAST._IExpression _source72 = _2110___mcc_h33;
        if (_source72.is_Literal) {
          DAST._ILiteral _2114___mcc_h37 = _source72.dtor_Literal_a0;
          bool _2115_isDatatype = _2113___mcc_h36;
          bool _2116_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2117_field = _2111___mcc_h34;
          DAST._IExpression _2118_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2119_onString;
            bool _2120_onOwned;
            bool _2121_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2122_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1411;
            bool _out1412;
            bool _out1413;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1414;
            DCOMP.COMP.GenExpr(_2118_on, selfIdent, @params, false, out _out1411, out _out1412, out _out1413, out _out1414);
            _2119_onString = _out1411;
            _2120_onOwned = _out1412;
            _2121_onErased = _out1413;
            _2122_recIdents = _out1414;
            if (!(_2121_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2123_eraseFn;
              _2123_eraseFn = ((_2120_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2119_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2123_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2119_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2115_isDatatype) || (_2116_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2119_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2117_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2116_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2119_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2117_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2122_recIdents;
          }
        } else if (_source72.is_Ident) {
          Dafny.ISequence<Dafny.Rune> _2124___mcc_h39 = _source72.dtor_Ident_a0;
          bool _2125_isDatatype = _2113___mcc_h36;
          bool _2126_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2127_field = _2111___mcc_h34;
          DAST._IExpression _2128_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2129_onString;
            bool _2130_onOwned;
            bool _2131_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2132_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1415;
            bool _out1416;
            bool _out1417;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1418;
            DCOMP.COMP.GenExpr(_2128_on, selfIdent, @params, false, out _out1415, out _out1416, out _out1417, out _out1418);
            _2129_onString = _out1415;
            _2130_onOwned = _out1416;
            _2131_onErased = _out1417;
            _2132_recIdents = _out1418;
            if (!(_2131_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2133_eraseFn;
              _2133_eraseFn = ((_2130_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2129_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2133_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2129_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2125_isDatatype) || (_2126_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2129_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2127_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2126_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2129_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2127_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2132_recIdents;
          }
        } else if (_source72.is_Companion) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2134___mcc_h41 = _source72.dtor_Companion_a0;
          bool _2135_isDatatype = _2113___mcc_h36;
          bool _2136_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2137_field = _2111___mcc_h34;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2138_c = _2134___mcc_h41;
          {
            Dafny.ISequence<Dafny.Rune> _2139_onString;
            bool _2140_onOwned;
            bool _2141_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2142_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1419;
            bool _out1420;
            bool _out1421;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1422;
            DCOMP.COMP.GenExpr(DAST.Expression.create_Companion(_2138_c), selfIdent, @params, false, out _out1419, out _out1420, out _out1421, out _out1422);
            _2139_onString = _out1419;
            _2140_onOwned = _out1420;
            _2141_onErased = _out1421;
            _2142_recIdents = _out1422;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2139_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2137_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            isOwned = true;
            isErased = false;
            readIdents = _2142_recIdents;
          }
        } else if (_source72.is_Tuple) {
          Dafny.ISequence<DAST._IExpression> _2143___mcc_h43 = _source72.dtor_Tuple_a0;
          bool _2144_isDatatype = _2113___mcc_h36;
          bool _2145_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2146_field = _2111___mcc_h34;
          DAST._IExpression _2147_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2148_onString;
            bool _2149_onOwned;
            bool _2150_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2151_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1423;
            bool _out1424;
            bool _out1425;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1426;
            DCOMP.COMP.GenExpr(_2147_on, selfIdent, @params, false, out _out1423, out _out1424, out _out1425, out _out1426);
            _2148_onString = _out1423;
            _2149_onOwned = _out1424;
            _2150_onErased = _out1425;
            _2151_recIdents = _out1426;
            if (!(_2150_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2152_eraseFn;
              _2152_eraseFn = ((_2149_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2148_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2152_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2148_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2144_isDatatype) || (_2145_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2148_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2146_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2145_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2148_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2146_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2151_recIdents;
          }
        } else if (_source72.is_New) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2153___mcc_h45 = _source72.dtor_path;
          Dafny.ISequence<DAST._IExpression> _2154___mcc_h46 = _source72.dtor_args;
          bool _2155_isDatatype = _2113___mcc_h36;
          bool _2156_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2157_field = _2111___mcc_h34;
          DAST._IExpression _2158_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2159_onString;
            bool _2160_onOwned;
            bool _2161_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2162_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1427;
            bool _out1428;
            bool _out1429;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1430;
            DCOMP.COMP.GenExpr(_2158_on, selfIdent, @params, false, out _out1427, out _out1428, out _out1429, out _out1430);
            _2159_onString = _out1427;
            _2160_onOwned = _out1428;
            _2161_onErased = _out1429;
            _2162_recIdents = _out1430;
            if (!(_2161_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2163_eraseFn;
              _2163_eraseFn = ((_2160_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2159_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2163_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2159_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2155_isDatatype) || (_2156_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2159_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2157_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2156_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2159_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2157_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2162_recIdents;
          }
        } else if (_source72.is_NewArray) {
          Dafny.ISequence<DAST._IExpression> _2164___mcc_h49 = _source72.dtor_dims;
          bool _2165_isDatatype = _2113___mcc_h36;
          bool _2166_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2167_field = _2111___mcc_h34;
          DAST._IExpression _2168_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2169_onString;
            bool _2170_onOwned;
            bool _2171_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2172_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1431;
            bool _out1432;
            bool _out1433;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1434;
            DCOMP.COMP.GenExpr(_2168_on, selfIdent, @params, false, out _out1431, out _out1432, out _out1433, out _out1434);
            _2169_onString = _out1431;
            _2170_onOwned = _out1432;
            _2171_onErased = _out1433;
            _2172_recIdents = _out1434;
            if (!(_2171_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2173_eraseFn;
              _2173_eraseFn = ((_2170_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2169_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2173_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2169_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2165_isDatatype) || (_2166_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2169_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2167_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2166_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2169_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2167_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2172_recIdents;
          }
        } else if (_source72.is_DatatypeValue) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2174___mcc_h51 = _source72.dtor_path;
          Dafny.ISequence<Dafny.Rune> _2175___mcc_h52 = _source72.dtor_variant;
          bool _2176___mcc_h53 = _source72.dtor_isCo;
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2177___mcc_h54 = _source72.dtor_contents;
          bool _2178_isDatatype = _2113___mcc_h36;
          bool _2179_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2180_field = _2111___mcc_h34;
          DAST._IExpression _2181_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2182_onString;
            bool _2183_onOwned;
            bool _2184_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2185_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1435;
            bool _out1436;
            bool _out1437;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1438;
            DCOMP.COMP.GenExpr(_2181_on, selfIdent, @params, false, out _out1435, out _out1436, out _out1437, out _out1438);
            _2182_onString = _out1435;
            _2183_onOwned = _out1436;
            _2184_onErased = _out1437;
            _2185_recIdents = _out1438;
            if (!(_2184_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2186_eraseFn;
              _2186_eraseFn = ((_2183_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2182_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2186_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2182_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2178_isDatatype) || (_2179_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2182_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2180_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2179_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2182_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2180_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2185_recIdents;
          }
        } else if (_source72.is_Convert) {
          DAST._IExpression _2187___mcc_h59 = _source72.dtor_value;
          DAST._IType _2188___mcc_h60 = _source72.dtor_from;
          DAST._IType _2189___mcc_h61 = _source72.dtor_typ;
          bool _2190_isDatatype = _2113___mcc_h36;
          bool _2191_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2192_field = _2111___mcc_h34;
          DAST._IExpression _2193_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2194_onString;
            bool _2195_onOwned;
            bool _2196_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2197_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1439;
            bool _out1440;
            bool _out1441;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1442;
            DCOMP.COMP.GenExpr(_2193_on, selfIdent, @params, false, out _out1439, out _out1440, out _out1441, out _out1442);
            _2194_onString = _out1439;
            _2195_onOwned = _out1440;
            _2196_onErased = _out1441;
            _2197_recIdents = _out1442;
            if (!(_2196_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2198_eraseFn;
              _2198_eraseFn = ((_2195_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2194_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2198_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2194_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2190_isDatatype) || (_2191_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2194_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2192_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2191_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2194_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2192_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2197_recIdents;
          }
        } else if (_source72.is_SeqValue) {
          Dafny.ISequence<DAST._IExpression> _2199___mcc_h65 = _source72.dtor_elements;
          bool _2200_isDatatype = _2113___mcc_h36;
          bool _2201_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2202_field = _2111___mcc_h34;
          DAST._IExpression _2203_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2204_onString;
            bool _2205_onOwned;
            bool _2206_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2207_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1443;
            bool _out1444;
            bool _out1445;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1446;
            DCOMP.COMP.GenExpr(_2203_on, selfIdent, @params, false, out _out1443, out _out1444, out _out1445, out _out1446);
            _2204_onString = _out1443;
            _2205_onOwned = _out1444;
            _2206_onErased = _out1445;
            _2207_recIdents = _out1446;
            if (!(_2206_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2208_eraseFn;
              _2208_eraseFn = ((_2205_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2204_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2208_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2204_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2200_isDatatype) || (_2201_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2204_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2202_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2201_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2204_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2202_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2207_recIdents;
          }
        } else if (_source72.is_SetValue) {
          Dafny.ISequence<DAST._IExpression> _2209___mcc_h67 = _source72.dtor_elements;
          bool _2210_isDatatype = _2113___mcc_h36;
          bool _2211_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2212_field = _2111___mcc_h34;
          DAST._IExpression _2213_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2214_onString;
            bool _2215_onOwned;
            bool _2216_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2217_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1447;
            bool _out1448;
            bool _out1449;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1450;
            DCOMP.COMP.GenExpr(_2213_on, selfIdent, @params, false, out _out1447, out _out1448, out _out1449, out _out1450);
            _2214_onString = _out1447;
            _2215_onOwned = _out1448;
            _2216_onErased = _out1449;
            _2217_recIdents = _out1450;
            if (!(_2216_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2218_eraseFn;
              _2218_eraseFn = ((_2215_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2214_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2218_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2214_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2210_isDatatype) || (_2211_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2214_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2212_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2211_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2214_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2212_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2217_recIdents;
          }
        } else if (_source72.is_This) {
          bool _2219_isDatatype = _2113___mcc_h36;
          bool _2220_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2221_field = _2111___mcc_h34;
          DAST._IExpression _2222_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2223_onString;
            bool _2224_onOwned;
            bool _2225_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2226_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1451;
            bool _out1452;
            bool _out1453;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1454;
            DCOMP.COMP.GenExpr(_2222_on, selfIdent, @params, false, out _out1451, out _out1452, out _out1453, out _out1454);
            _2223_onString = _out1451;
            _2224_onOwned = _out1452;
            _2225_onErased = _out1453;
            _2226_recIdents = _out1454;
            if (!(_2225_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2227_eraseFn;
              _2227_eraseFn = ((_2224_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2223_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2227_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2223_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2219_isDatatype) || (_2220_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2223_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2221_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2220_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2223_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2221_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2226_recIdents;
          }
        } else if (_source72.is_Ite) {
          DAST._IExpression _2228___mcc_h69 = _source72.dtor_cond;
          DAST._IExpression _2229___mcc_h70 = _source72.dtor_thn;
          DAST._IExpression _2230___mcc_h71 = _source72.dtor_els;
          bool _2231_isDatatype = _2113___mcc_h36;
          bool _2232_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2233_field = _2111___mcc_h34;
          DAST._IExpression _2234_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2235_onString;
            bool _2236_onOwned;
            bool _2237_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2238_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1455;
            bool _out1456;
            bool _out1457;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1458;
            DCOMP.COMP.GenExpr(_2234_on, selfIdent, @params, false, out _out1455, out _out1456, out _out1457, out _out1458);
            _2235_onString = _out1455;
            _2236_onOwned = _out1456;
            _2237_onErased = _out1457;
            _2238_recIdents = _out1458;
            if (!(_2237_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2239_eraseFn;
              _2239_eraseFn = ((_2236_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2235_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2239_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2235_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2231_isDatatype) || (_2232_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2235_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2233_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2232_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2235_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2233_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2238_recIdents;
          }
        } else if (_source72.is_UnOp) {
          DAST._IUnaryOp _2240___mcc_h75 = _source72.dtor_unOp;
          DAST._IExpression _2241___mcc_h76 = _source72.dtor_expr;
          bool _2242_isDatatype = _2113___mcc_h36;
          bool _2243_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2244_field = _2111___mcc_h34;
          DAST._IExpression _2245_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2246_onString;
            bool _2247_onOwned;
            bool _2248_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2249_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1459;
            bool _out1460;
            bool _out1461;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1462;
            DCOMP.COMP.GenExpr(_2245_on, selfIdent, @params, false, out _out1459, out _out1460, out _out1461, out _out1462);
            _2246_onString = _out1459;
            _2247_onOwned = _out1460;
            _2248_onErased = _out1461;
            _2249_recIdents = _out1462;
            if (!(_2248_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2250_eraseFn;
              _2250_eraseFn = ((_2247_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2246_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2250_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2246_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2242_isDatatype) || (_2243_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2246_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2244_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2243_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2246_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2244_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2249_recIdents;
          }
        } else if (_source72.is_BinOp) {
          Dafny.ISequence<Dafny.Rune> _2251___mcc_h79 = _source72.dtor_op;
          DAST._IExpression _2252___mcc_h80 = _source72.dtor_left;
          DAST._IExpression _2253___mcc_h81 = _source72.dtor_right;
          bool _2254_isDatatype = _2113___mcc_h36;
          bool _2255_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2256_field = _2111___mcc_h34;
          DAST._IExpression _2257_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2258_onString;
            bool _2259_onOwned;
            bool _2260_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2261_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1463;
            bool _out1464;
            bool _out1465;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1466;
            DCOMP.COMP.GenExpr(_2257_on, selfIdent, @params, false, out _out1463, out _out1464, out _out1465, out _out1466);
            _2258_onString = _out1463;
            _2259_onOwned = _out1464;
            _2260_onErased = _out1465;
            _2261_recIdents = _out1466;
            if (!(_2260_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2262_eraseFn;
              _2262_eraseFn = ((_2259_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2258_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2262_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2258_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2254_isDatatype) || (_2255_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2258_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2256_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2255_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2258_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2256_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2261_recIdents;
          }
        } else if (_source72.is_ArrayLen) {
          DAST._IExpression _2263___mcc_h85 = _source72.dtor_expr;
          bool _2264_isDatatype = _2113___mcc_h36;
          bool _2265_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2266_field = _2111___mcc_h34;
          DAST._IExpression _2267_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2268_onString;
            bool _2269_onOwned;
            bool _2270_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2271_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1467;
            bool _out1468;
            bool _out1469;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1470;
            DCOMP.COMP.GenExpr(_2267_on, selfIdent, @params, false, out _out1467, out _out1468, out _out1469, out _out1470);
            _2268_onString = _out1467;
            _2269_onOwned = _out1468;
            _2270_onErased = _out1469;
            _2271_recIdents = _out1470;
            if (!(_2270_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2272_eraseFn;
              _2272_eraseFn = ((_2269_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2268_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2272_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2268_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2264_isDatatype) || (_2265_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2268_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2266_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2265_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2268_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2266_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2271_recIdents;
          }
        } else if (_source72.is_Select) {
          DAST._IExpression _2273___mcc_h87 = _source72.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2274___mcc_h88 = _source72.dtor_field;
          bool _2275___mcc_h89 = _source72.dtor_isConstant;
          bool _2276___mcc_h90 = _source72.dtor_onDatatype;
          bool _2277_isDatatype = _2113___mcc_h36;
          bool _2278_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2279_field = _2111___mcc_h34;
          DAST._IExpression _2280_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2281_onString;
            bool _2282_onOwned;
            bool _2283_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2284_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1471;
            bool _out1472;
            bool _out1473;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1474;
            DCOMP.COMP.GenExpr(_2280_on, selfIdent, @params, false, out _out1471, out _out1472, out _out1473, out _out1474);
            _2281_onString = _out1471;
            _2282_onOwned = _out1472;
            _2283_onErased = _out1473;
            _2284_recIdents = _out1474;
            if (!(_2283_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2285_eraseFn;
              _2285_eraseFn = ((_2282_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2281_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2285_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2281_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2277_isDatatype) || (_2278_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2281_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2279_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2281_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2279_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2284_recIdents;
          }
        } else if (_source72.is_SelectFn) {
          DAST._IExpression _2286___mcc_h95 = _source72.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2287___mcc_h96 = _source72.dtor_field;
          bool _2288___mcc_h97 = _source72.dtor_onDatatype;
          bool _2289___mcc_h98 = _source72.dtor_isStatic;
          BigInteger _2290___mcc_h99 = _source72.dtor_arity;
          bool _2291_isDatatype = _2113___mcc_h36;
          bool _2292_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2293_field = _2111___mcc_h34;
          DAST._IExpression _2294_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2295_onString;
            bool _2296_onOwned;
            bool _2297_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2298_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1475;
            bool _out1476;
            bool _out1477;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1478;
            DCOMP.COMP.GenExpr(_2294_on, selfIdent, @params, false, out _out1475, out _out1476, out _out1477, out _out1478);
            _2295_onString = _out1475;
            _2296_onOwned = _out1476;
            _2297_onErased = _out1477;
            _2298_recIdents = _out1478;
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
        } else if (_source72.is_Index) {
          DAST._IExpression _2300___mcc_h105 = _source72.dtor_expr;
          bool _2301___mcc_h106 = _source72.dtor_isArray;
          Dafny.ISequence<DAST._IExpression> _2302___mcc_h107 = _source72.dtor_indices;
          bool _2303_isDatatype = _2113___mcc_h36;
          bool _2304_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2305_field = _2111___mcc_h34;
          DAST._IExpression _2306_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2307_onString;
            bool _2308_onOwned;
            bool _2309_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2310_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1479;
            bool _out1480;
            bool _out1481;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1482;
            DCOMP.COMP.GenExpr(_2306_on, selfIdent, @params, false, out _out1479, out _out1480, out _out1481, out _out1482);
            _2307_onString = _out1479;
            _2308_onOwned = _out1480;
            _2309_onErased = _out1481;
            _2310_recIdents = _out1482;
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
        } else if (_source72.is_IndexRange) {
          DAST._IExpression _2312___mcc_h111 = _source72.dtor_expr;
          bool _2313___mcc_h112 = _source72.dtor_isArray;
          DAST._IOptional<DAST._IExpression> _2314___mcc_h113 = _source72.dtor_low;
          DAST._IOptional<DAST._IExpression> _2315___mcc_h114 = _source72.dtor_high;
          bool _2316_isDatatype = _2113___mcc_h36;
          bool _2317_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2318_field = _2111___mcc_h34;
          DAST._IExpression _2319_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2320_onString;
            bool _2321_onOwned;
            bool _2322_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2323_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1483;
            bool _out1484;
            bool _out1485;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1486;
            DCOMP.COMP.GenExpr(_2319_on, selfIdent, @params, false, out _out1483, out _out1484, out _out1485, out _out1486);
            _2320_onString = _out1483;
            _2321_onOwned = _out1484;
            _2322_onErased = _out1485;
            _2323_recIdents = _out1486;
            if (!(_2322_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2324_eraseFn;
              _2324_eraseFn = ((_2321_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2320_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2324_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2320_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2316_isDatatype) || (_2317_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2320_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2318_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2317_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2320_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2318_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2323_recIdents;
          }
        } else if (_source72.is_TupleSelect) {
          DAST._IExpression _2325___mcc_h119 = _source72.dtor_expr;
          BigInteger _2326___mcc_h120 = _source72.dtor_index;
          bool _2327_isDatatype = _2113___mcc_h36;
          bool _2328_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2329_field = _2111___mcc_h34;
          DAST._IExpression _2330_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2331_onString;
            bool _2332_onOwned;
            bool _2333_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2334_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1487;
            bool _out1488;
            bool _out1489;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1490;
            DCOMP.COMP.GenExpr(_2330_on, selfIdent, @params, false, out _out1487, out _out1488, out _out1489, out _out1490);
            _2331_onString = _out1487;
            _2332_onOwned = _out1488;
            _2333_onErased = _out1489;
            _2334_recIdents = _out1490;
            if (!(_2333_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2335_eraseFn;
              _2335_eraseFn = ((_2332_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2331_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2335_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2331_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2327_isDatatype) || (_2328_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2331_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2329_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2328_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2331_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2329_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2334_recIdents;
          }
        } else if (_source72.is_Call) {
          DAST._IExpression _2336___mcc_h123 = _source72.dtor_on;
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2337___mcc_h124 = _source72.dtor_maybeName;
          Dafny.ISequence<DAST._IType> _2338___mcc_h125 = _source72.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _2339___mcc_h126 = _source72.dtor_args;
          bool _2340_isDatatype = _2113___mcc_h36;
          bool _2341_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2342_field = _2111___mcc_h34;
          DAST._IExpression _2343_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2344_onString;
            bool _2345_onOwned;
            bool _2346_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2347_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1491;
            bool _out1492;
            bool _out1493;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1494;
            DCOMP.COMP.GenExpr(_2343_on, selfIdent, @params, false, out _out1491, out _out1492, out _out1493, out _out1494);
            _2344_onString = _out1491;
            _2345_onOwned = _out1492;
            _2346_onErased = _out1493;
            _2347_recIdents = _out1494;
            if (!(_2346_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2348_eraseFn;
              _2348_eraseFn = ((_2345_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2344_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2348_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2344_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2340_isDatatype) || (_2341_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2344_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2342_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2341_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2344_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2342_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2347_recIdents;
          }
        } else if (_source72.is_Lambda) {
          Dafny.ISequence<DAST._IFormal> _2349___mcc_h131 = _source72.dtor_params;
          DAST._IType _2350___mcc_h132 = _source72.dtor_retType;
          Dafny.ISequence<DAST._IStatement> _2351___mcc_h133 = _source72.dtor_body;
          bool _2352_isDatatype = _2113___mcc_h36;
          bool _2353_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2354_field = _2111___mcc_h34;
          DAST._IExpression _2355_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2356_onString;
            bool _2357_onOwned;
            bool _2358_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2359_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1495;
            bool _out1496;
            bool _out1497;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1498;
            DCOMP.COMP.GenExpr(_2355_on, selfIdent, @params, false, out _out1495, out _out1496, out _out1497, out _out1498);
            _2356_onString = _out1495;
            _2357_onOwned = _out1496;
            _2358_onErased = _out1497;
            _2359_recIdents = _out1498;
            if (!(_2358_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2360_eraseFn;
              _2360_eraseFn = ((_2357_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2356_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2360_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2356_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2352_isDatatype) || (_2353_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2356_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2354_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2356_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2354_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2359_recIdents;
          }
        } else if (_source72.is_IIFE) {
          Dafny.ISequence<Dafny.Rune> _2361___mcc_h137 = _source72.dtor_name;
          DAST._IType _2362___mcc_h138 = _source72.dtor_typ;
          DAST._IExpression _2363___mcc_h139 = _source72.dtor_value;
          DAST._IExpression _2364___mcc_h140 = _source72.dtor_iifeBody;
          bool _2365_isDatatype = _2113___mcc_h36;
          bool _2366_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2367_field = _2111___mcc_h34;
          DAST._IExpression _2368_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2369_onString;
            bool _2370_onOwned;
            bool _2371_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2372_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1499;
            bool _out1500;
            bool _out1501;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1502;
            DCOMP.COMP.GenExpr(_2368_on, selfIdent, @params, false, out _out1499, out _out1500, out _out1501, out _out1502);
            _2369_onString = _out1499;
            _2370_onOwned = _out1500;
            _2371_onErased = _out1501;
            _2372_recIdents = _out1502;
            if (!(_2371_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2373_eraseFn;
              _2373_eraseFn = ((_2370_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2369_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2373_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2369_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2365_isDatatype) || (_2366_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2369_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2367_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2366_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2369_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2367_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2372_recIdents;
          }
        } else if (_source72.is_Apply) {
          DAST._IExpression _2374___mcc_h145 = _source72.dtor_expr;
          Dafny.ISequence<DAST._IExpression> _2375___mcc_h146 = _source72.dtor_args;
          bool _2376_isDatatype = _2113___mcc_h36;
          bool _2377_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2378_field = _2111___mcc_h34;
          DAST._IExpression _2379_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2380_onString;
            bool _2381_onOwned;
            bool _2382_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2383_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1503;
            bool _out1504;
            bool _out1505;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1506;
            DCOMP.COMP.GenExpr(_2379_on, selfIdent, @params, false, out _out1503, out _out1504, out _out1505, out _out1506);
            _2380_onString = _out1503;
            _2381_onOwned = _out1504;
            _2382_onErased = _out1505;
            _2383_recIdents = _out1506;
            if (!(_2382_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2384_eraseFn;
              _2384_eraseFn = ((_2381_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2380_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2384_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2380_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2376_isDatatype) || (_2377_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2380_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2378_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2377_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2380_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2378_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2383_recIdents;
          }
        } else if (_source72.is_TypeTest) {
          DAST._IExpression _2385___mcc_h149 = _source72.dtor_on;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2386___mcc_h150 = _source72.dtor_dType;
          Dafny.ISequence<Dafny.Rune> _2387___mcc_h151 = _source72.dtor_variant;
          bool _2388_isDatatype = _2113___mcc_h36;
          bool _2389_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2390_field = _2111___mcc_h34;
          DAST._IExpression _2391_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2392_onString;
            bool _2393_onOwned;
            bool _2394_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2395_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1507;
            bool _out1508;
            bool _out1509;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1510;
            DCOMP.COMP.GenExpr(_2391_on, selfIdent, @params, false, out _out1507, out _out1508, out _out1509, out _out1510);
            _2392_onString = _out1507;
            _2393_onOwned = _out1508;
            _2394_onErased = _out1509;
            _2395_recIdents = _out1510;
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
        } else {
          DAST._IType _2397___mcc_h155 = _source72.dtor_typ;
          bool _2398_isDatatype = _2113___mcc_h36;
          bool _2399_isConstant = _2112___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2400_field = _2111___mcc_h34;
          DAST._IExpression _2401_on = _2110___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2402_onString;
            bool _2403_onOwned;
            bool _2404_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2405_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1511;
            bool _out1512;
            bool _out1513;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1514;
            DCOMP.COMP.GenExpr(_2401_on, selfIdent, @params, false, out _out1511, out _out1512, out _out1513, out _out1514);
            _2402_onString = _out1511;
            _2403_onOwned = _out1512;
            _2404_onErased = _out1513;
            _2405_recIdents = _out1514;
            if (!(_2404_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2406_eraseFn;
              _2406_eraseFn = ((_2403_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2402_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2406_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2402_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2398_isDatatype) || (_2399_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2402_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2400_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2402_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2400_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2405_recIdents;
          }
        }
      } else if (_source20.is_SelectFn) {
        DAST._IExpression _2407___mcc_h157 = _source20.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2408___mcc_h158 = _source20.dtor_field;
        bool _2409___mcc_h159 = _source20.dtor_onDatatype;
        bool _2410___mcc_h160 = _source20.dtor_isStatic;
        BigInteger _2411___mcc_h161 = _source20.dtor_arity;
        BigInteger _2412_arity = _2411___mcc_h161;
        bool _2413_isStatic = _2410___mcc_h160;
        bool _2414_isDatatype = _2409___mcc_h159;
        Dafny.ISequence<Dafny.Rune> _2415_field = _2408___mcc_h158;
        DAST._IExpression _2416_on = _2407___mcc_h157;
        {
          Dafny.ISequence<Dafny.Rune> _2417_onString;
          bool _2418_onOwned;
          bool _2419___v75;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2420_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1515;
          bool _out1516;
          bool _out1517;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1518;
          DCOMP.COMP.GenExpr(_2416_on, selfIdent, @params, false, out _out1515, out _out1516, out _out1517, out _out1518);
          _2417_onString = _out1515;
          _2418_onOwned = _out1516;
          _2419___v75 = _out1517;
          _2420_recIdents = _out1518;
          if (_2413_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2417_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2415_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2417_onString), ((_2418_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2421_args;
            _2421_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2422_i;
            _2422_i = BigInteger.Zero;
            while ((_2422_i) < (_2412_arity)) {
              if ((_2422_i).Sign == 1) {
                _2421_args = Dafny.Sequence<Dafny.Rune>.Concat(_2421_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2421_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2421_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2422_i));
              _2422_i = (_2422_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2421_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2415_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2421_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _2420_recIdents;
        }
      } else if (_source20.is_Index) {
        DAST._IExpression _2423___mcc_h162 = _source20.dtor_expr;
        bool _2424___mcc_h163 = _source20.dtor_isArray;
        Dafny.ISequence<DAST._IExpression> _2425___mcc_h164 = _source20.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _2426_indices = _2425___mcc_h164;
        bool _2427_isArray = _2424___mcc_h163;
        DAST._IExpression _2428_on = _2423___mcc_h162;
        {
          Dafny.ISequence<Dafny.Rune> _2429_onString;
          bool _2430_onOwned;
          bool _2431_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2432_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1519;
          bool _out1520;
          bool _out1521;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1522;
          DCOMP.COMP.GenExpr(_2428_on, selfIdent, @params, false, out _out1519, out _out1520, out _out1521, out _out1522);
          _2429_onString = _out1519;
          _2430_onOwned = _out1520;
          _2431_onErased = _out1521;
          _2432_recIdents = _out1522;
          readIdents = _2432_recIdents;
          if (!(_2431_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2433_eraseFn;
            _2433_eraseFn = ((_2430_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2429_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2433_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2429_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2429_onString;
          BigInteger _2434_i;
          _2434_i = BigInteger.Zero;
          while ((_2434_i) < (new BigInteger((_2426_indices).Count))) {
            Dafny.ISequence<Dafny.Rune> _2435_idx;
            bool _2436___v76;
            bool _2437_idxErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2438_recIdentsIdx;
            Dafny.ISequence<Dafny.Rune> _out1523;
            bool _out1524;
            bool _out1525;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1526;
            DCOMP.COMP.GenExpr((_2426_indices).Select(_2434_i), selfIdent, @params, true, out _out1523, out _out1524, out _out1525, out _out1526);
            _2435_idx = _out1523;
            _2436___v76 = _out1524;
            _2437_idxErased = _out1525;
            _2438_recIdentsIdx = _out1526;
            if (!(_2437_idxErased)) {
              _2435_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2435_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2427_isArray) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[<usize as ::dafny_runtime::NumCast>::from(")), _2435_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2438_recIdentsIdx);
            _2434_i = (_2434_i) + (BigInteger.One);
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = _2431_onErased;
        }
      } else if (_source20.is_IndexRange) {
        DAST._IExpression _2439___mcc_h165 = _source20.dtor_expr;
        bool _2440___mcc_h166 = _source20.dtor_isArray;
        DAST._IOptional<DAST._IExpression> _2441___mcc_h167 = _source20.dtor_low;
        DAST._IOptional<DAST._IExpression> _2442___mcc_h168 = _source20.dtor_high;
        DAST._IOptional<DAST._IExpression> _2443_high = _2442___mcc_h168;
        DAST._IOptional<DAST._IExpression> _2444_low = _2441___mcc_h167;
        bool _2445_isArray = _2440___mcc_h166;
        DAST._IExpression _2446_on = _2439___mcc_h165;
        {
          Dafny.ISequence<Dafny.Rune> _2447_onString;
          bool _2448_onOwned;
          bool _2449_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2450_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1527;
          bool _out1528;
          bool _out1529;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1530;
          DCOMP.COMP.GenExpr(_2446_on, selfIdent, @params, false, out _out1527, out _out1528, out _out1529, out _out1530);
          _2447_onString = _out1527;
          _2448_onOwned = _out1528;
          _2449_onErased = _out1529;
          _2450_recIdents = _out1530;
          readIdents = _2450_recIdents;
          if (!(_2449_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2451_eraseFn;
            _2451_eraseFn = ((_2448_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2447_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2451_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2447_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2447_onString;
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2452_lowString;
          _2452_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source73 = _2444_low;
          if (_source73.is_Some) {
            DAST._IExpression _2453___mcc_h1055 = _source73.dtor_Some_a0;
            DAST._IExpression _2454_l = _2453___mcc_h1055;
            {
              Dafny.ISequence<Dafny.Rune> _2455_lString;
              bool _2456___v77;
              bool _2457_lErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2458_recIdentsL;
              Dafny.ISequence<Dafny.Rune> _out1531;
              bool _out1532;
              bool _out1533;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1534;
              DCOMP.COMP.GenExpr(_2454_l, selfIdent, @params, true, out _out1531, out _out1532, out _out1533, out _out1534);
              _2455_lString = _out1531;
              _2456___v77 = _out1532;
              _2457_lErased = _out1533;
              _2458_recIdentsL = _out1534;
              if (!(_2457_lErased)) {
                _2455_lString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2455_lString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2452_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2455_lString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2458_recIdentsL);
            }
          } else {
          }
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2459_highString;
          _2459_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source74 = _2443_high;
          if (_source74.is_Some) {
            DAST._IExpression _2460___mcc_h1056 = _source74.dtor_Some_a0;
            DAST._IExpression _2461_h = _2460___mcc_h1056;
            {
              Dafny.ISequence<Dafny.Rune> _2462_hString;
              bool _2463___v78;
              bool _2464_hErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2465_recIdentsH;
              Dafny.ISequence<Dafny.Rune> _out1535;
              bool _out1536;
              bool _out1537;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1538;
              DCOMP.COMP.GenExpr(_2461_h, selfIdent, @params, true, out _out1535, out _out1536, out _out1537, out _out1538);
              _2462_hString = _out1535;
              _2463___v78 = _out1536;
              _2464_hErased = _out1537;
              _2465_recIdentsH = _out1538;
              if (!(_2464_hErased)) {
                _2462_hString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2462_hString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2459_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2462_hString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2465_recIdentsH);
            }
          } else {
          }
          if (_2445_isArray) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source75) => {
            if (_source75.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2466___mcc_h1057 = _source75.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2466___mcc_h1057, _pat_let0_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let0_0, _2467_l => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2467_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2452_lowString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("..")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source76) => {
            if (_source76.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2468___mcc_h1058 = _source76.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2468___mcc_h1058, _pat_let1_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let1_0, _2469_h => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2469_h), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2459_highString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isErased = _2449_onErased;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".to_vec())"));
          isOwned = true;
        }
      } else if (_source20.is_TupleSelect) {
        DAST._IExpression _2470___mcc_h169 = _source20.dtor_expr;
        BigInteger _2471___mcc_h170 = _source20.dtor_index;
        BigInteger _2472_idx = _2471___mcc_h170;
        DAST._IExpression _2473_on = _2470___mcc_h169;
        {
          Dafny.ISequence<Dafny.Rune> _2474_onString;
          bool _2475___v79;
          bool _2476_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2477_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1539;
          bool _out1540;
          bool _out1541;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1542;
          DCOMP.COMP.GenExpr(_2473_on, selfIdent, @params, false, out _out1539, out _out1540, out _out1541, out _out1542);
          _2474_onString = _out1539;
          _2475___v79 = _out1540;
          _2476_tupErased = _out1541;
          _2477_recIdents = _out1542;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2474_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2472_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2476_tupErased;
          readIdents = _2477_recIdents;
        }
      } else if (_source20.is_Call) {
        DAST._IExpression _2478___mcc_h171 = _source20.dtor_on;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2479___mcc_h172 = _source20.dtor_maybeName;
        Dafny.ISequence<DAST._IType> _2480___mcc_h173 = _source20.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2481___mcc_h174 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2482_args = _2481___mcc_h174;
        Dafny.ISequence<DAST._IType> _2483_typeArgs = _2480___mcc_h173;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2484_maybeName = _2479___mcc_h172;
        DAST._IExpression _2485_on = _2478___mcc_h171;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2486_typeArgString;
          _2486_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2483_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2487_typeI;
            _2487_typeI = BigInteger.Zero;
            _2486_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2487_typeI) < (new BigInteger((_2483_typeArgs).Count))) {
              if ((_2487_typeI).Sign == 1) {
                _2486_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2486_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2488_typeString;
              Dafny.ISequence<Dafny.Rune> _out1543;
              _out1543 = DCOMP.COMP.GenType((_2483_typeArgs).Select(_2487_typeI), false, false);
              _2488_typeString = _out1543;
              _2486_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2486_typeArgString, _2488_typeString);
              _2487_typeI = (_2487_typeI) + (BigInteger.One);
            }
            _2486_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2486_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2489_argString;
          _2489_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2490_i;
          _2490_i = BigInteger.Zero;
          while ((_2490_i) < (new BigInteger((_2482_args).Count))) {
            if ((_2490_i).Sign == 1) {
              _2489_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2489_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2491_argExpr;
            bool _2492_isOwned;
            bool _2493_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2494_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1544;
            bool _out1545;
            bool _out1546;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1547;
            DCOMP.COMP.GenExpr((_2482_args).Select(_2490_i), selfIdent, @params, false, out _out1544, out _out1545, out _out1546, out _out1547);
            _2491_argExpr = _out1544;
            _2492_isOwned = _out1545;
            _2493_argErased = _out1546;
            _2494_argIdents = _out1547;
            if (_2492_isOwned) {
              _2491_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2491_argExpr);
            }
            _2489_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2489_argString, _2491_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2494_argIdents);
            _2490_i = (_2490_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2495_enclosingString;
          bool _2496___v80;
          bool _2497___v81;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2498_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1548;
          bool _out1549;
          bool _out1550;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1551;
          DCOMP.COMP.GenExpr(_2485_on, selfIdent, @params, false, out _out1548, out _out1549, out _out1550, out _out1551);
          _2495_enclosingString = _out1548;
          _2496___v80 = _out1549;
          _2497___v81 = _out1550;
          _2498_recIdents = _out1551;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2498_recIdents);
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source77 = _2484_maybeName;
          if (_source77.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2499___mcc_h1059 = _source77.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2500_name = _2499___mcc_h1059;
            {
              DAST._IExpression _source78 = _2485_on;
              if (_source78.is_Literal) {
                DAST._ILiteral _2501___mcc_h1060 = _source78.dtor_Literal_a0;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_Ident) {
                Dafny.ISequence<Dafny.Rune> _2502___mcc_h1062 = _source78.dtor_Ident_a0;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_Companion) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2503___mcc_h1064 = _source78.dtor_Companion_a0;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2495_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (_2500_name));
                }
              } else if (_source78.is_Tuple) {
                Dafny.ISequence<DAST._IExpression> _2504___mcc_h1066 = _source78.dtor_Tuple_a0;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_New) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2505___mcc_h1068 = _source78.dtor_path;
                Dafny.ISequence<DAST._IExpression> _2506___mcc_h1069 = _source78.dtor_args;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_NewArray) {
                Dafny.ISequence<DAST._IExpression> _2507___mcc_h1072 = _source78.dtor_dims;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_DatatypeValue) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2508___mcc_h1074 = _source78.dtor_path;
                Dafny.ISequence<Dafny.Rune> _2509___mcc_h1075 = _source78.dtor_variant;
                bool _2510___mcc_h1076 = _source78.dtor_isCo;
                Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2511___mcc_h1077 = _source78.dtor_contents;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_Convert) {
                DAST._IExpression _2512___mcc_h1082 = _source78.dtor_value;
                DAST._IType _2513___mcc_h1083 = _source78.dtor_from;
                DAST._IType _2514___mcc_h1084 = _source78.dtor_typ;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_SeqValue) {
                Dafny.ISequence<DAST._IExpression> _2515___mcc_h1088 = _source78.dtor_elements;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_SetValue) {
                Dafny.ISequence<DAST._IExpression> _2516___mcc_h1090 = _source78.dtor_elements;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_This) {
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_Ite) {
                DAST._IExpression _2517___mcc_h1092 = _source78.dtor_cond;
                DAST._IExpression _2518___mcc_h1093 = _source78.dtor_thn;
                DAST._IExpression _2519___mcc_h1094 = _source78.dtor_els;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_UnOp) {
                DAST._IUnaryOp _2520___mcc_h1098 = _source78.dtor_unOp;
                DAST._IExpression _2521___mcc_h1099 = _source78.dtor_expr;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_BinOp) {
                Dafny.ISequence<Dafny.Rune> _2522___mcc_h1102 = _source78.dtor_op;
                DAST._IExpression _2523___mcc_h1103 = _source78.dtor_left;
                DAST._IExpression _2524___mcc_h1104 = _source78.dtor_right;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_ArrayLen) {
                DAST._IExpression _2525___mcc_h1108 = _source78.dtor_expr;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_Select) {
                DAST._IExpression _2526___mcc_h1110 = _source78.dtor_expr;
                Dafny.ISequence<Dafny.Rune> _2527___mcc_h1111 = _source78.dtor_field;
                bool _2528___mcc_h1112 = _source78.dtor_isConstant;
                bool _2529___mcc_h1113 = _source78.dtor_onDatatype;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_SelectFn) {
                DAST._IExpression _2530___mcc_h1118 = _source78.dtor_expr;
                Dafny.ISequence<Dafny.Rune> _2531___mcc_h1119 = _source78.dtor_field;
                bool _2532___mcc_h1120 = _source78.dtor_onDatatype;
                bool _2533___mcc_h1121 = _source78.dtor_isStatic;
                BigInteger _2534___mcc_h1122 = _source78.dtor_arity;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_Index) {
                DAST._IExpression _2535___mcc_h1128 = _source78.dtor_expr;
                bool _2536___mcc_h1129 = _source78.dtor_isArray;
                Dafny.ISequence<DAST._IExpression> _2537___mcc_h1130 = _source78.dtor_indices;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_IndexRange) {
                DAST._IExpression _2538___mcc_h1134 = _source78.dtor_expr;
                bool _2539___mcc_h1135 = _source78.dtor_isArray;
                DAST._IOptional<DAST._IExpression> _2540___mcc_h1136 = _source78.dtor_low;
                DAST._IOptional<DAST._IExpression> _2541___mcc_h1137 = _source78.dtor_high;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_TupleSelect) {
                DAST._IExpression _2542___mcc_h1142 = _source78.dtor_expr;
                BigInteger _2543___mcc_h1143 = _source78.dtor_index;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_Call) {
                DAST._IExpression _2544___mcc_h1146 = _source78.dtor_on;
                DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2545___mcc_h1147 = _source78.dtor_maybeName;
                Dafny.ISequence<DAST._IType> _2546___mcc_h1148 = _source78.dtor_typeArgs;
                Dafny.ISequence<DAST._IExpression> _2547___mcc_h1149 = _source78.dtor_args;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_Lambda) {
                Dafny.ISequence<DAST._IFormal> _2548___mcc_h1154 = _source78.dtor_params;
                DAST._IType _2549___mcc_h1155 = _source78.dtor_retType;
                Dafny.ISequence<DAST._IStatement> _2550___mcc_h1156 = _source78.dtor_body;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_IIFE) {
                Dafny.ISequence<Dafny.Rune> _2551___mcc_h1160 = _source78.dtor_name;
                DAST._IType _2552___mcc_h1161 = _source78.dtor_typ;
                DAST._IExpression _2553___mcc_h1162 = _source78.dtor_value;
                DAST._IExpression _2554___mcc_h1163 = _source78.dtor_iifeBody;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_Apply) {
                DAST._IExpression _2555___mcc_h1168 = _source78.dtor_expr;
                Dafny.ISequence<DAST._IExpression> _2556___mcc_h1169 = _source78.dtor_args;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else if (_source78.is_TypeTest) {
                DAST._IExpression _2557___mcc_h1172 = _source78.dtor_on;
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2558___mcc_h1173 = _source78.dtor_dType;
                Dafny.ISequence<Dafny.Rune> _2559___mcc_h1174 = _source78.dtor_variant;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              } else {
                DAST._IType _2560___mcc_h1178 = _source78.dtor_typ;
                {
                  _2495_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2495_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2500_name));
                }
              }
            }
          } else {
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2495_enclosingString, _2486_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2489_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source20.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2561___mcc_h175 = _source20.dtor_params;
        DAST._IType _2562___mcc_h176 = _source20.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2563___mcc_h177 = _source20.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2564_body = _2563___mcc_h177;
        DAST._IType _2565_retType = _2562___mcc_h176;
        Dafny.ISequence<DAST._IFormal> _2566_params = _2561___mcc_h175;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2567_paramNames;
          _2567_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2568_i;
          _2568_i = BigInteger.Zero;
          while ((_2568_i) < (new BigInteger((_2566_params).Count))) {
            _2567_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2567_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2566_params).Select(_2568_i)).dtor_name));
            _2568_i = (_2568_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2569_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2570_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1552;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1553;
          DCOMP.COMP.GenStmts(_2564_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2567_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1552, out _out1553);
          _2569_recursiveGen = _out1552;
          _2570_recIdents = _out1553;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2571_allReadCloned;
          _2571_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2570_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2572_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2570_recIdents).Elements) {
              _2572_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2570_recIdents).Contains(_2572_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1747)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2567_paramNames).Contains(_2572_next))) {
              _2571_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2571_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2572_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2572_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2572_next));
            }
            _2570_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2570_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2572_next));
          }
          Dafny.ISequence<Dafny.Rune> _2573_paramsString;
          _2573_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2568_i = BigInteger.Zero;
          while ((_2568_i) < (new BigInteger((_2566_params).Count))) {
            if ((_2568_i).Sign == 1) {
              _2573_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2573_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2574_typStr;
            Dafny.ISequence<Dafny.Rune> _out1554;
            _out1554 = DCOMP.COMP.GenType(((_2566_params).Select(_2568_i)).dtor_typ, false, true);
            _2574_typStr = _out1554;
            _2573_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2573_paramsString, ((_2566_params).Select(_2568_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2574_typStr);
            _2568_i = (_2568_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2575_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1555;
          _out1555 = DCOMP.COMP.GenType(_2565_retType, false, true);
          _2575_retTypeGen = _out1555;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _2571_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _2573_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2575_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2569_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2576___mcc_h178 = _source20.dtor_name;
        DAST._IType _2577___mcc_h179 = _source20.dtor_typ;
        DAST._IExpression _2578___mcc_h180 = _source20.dtor_value;
        DAST._IExpression _2579___mcc_h181 = _source20.dtor_iifeBody;
        DAST._IExpression _2580_iifeBody = _2579___mcc_h181;
        DAST._IExpression _2581_value = _2578___mcc_h180;
        DAST._IType _2582_tpe = _2577___mcc_h179;
        Dafny.ISequence<Dafny.Rune> _2583_name = _2576___mcc_h178;
        {
          Dafny.ISequence<Dafny.Rune> _2584_valueGen;
          bool _2585_valueOwned;
          bool _2586_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2587_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1556;
          bool _out1557;
          bool _out1558;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1559;
          DCOMP.COMP.GenExpr(_2581_value, selfIdent, @params, false, out _out1556, out _out1557, out _out1558, out _out1559);
          _2584_valueGen = _out1556;
          _2585_valueOwned = _out1557;
          _2586_valueErased = _out1558;
          _2587_recIdents = _out1559;
          if (_2586_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2588_eraseFn;
            _2588_eraseFn = ((_2585_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2584_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2588_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2584_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2587_recIdents;
          Dafny.ISequence<Dafny.Rune> _2589_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1560;
          _out1560 = DCOMP.COMP.GenType(_2582_tpe, false, true);
          _2589_valueTypeGen = _out1560;
          Dafny.ISequence<Dafny.Rune> _2590_bodyGen;
          bool _2591_bodyOwned;
          bool _2592_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2593_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1561;
          bool _out1562;
          bool _out1563;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1564;
          DCOMP.COMP.GenExpr(_2580_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2585_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2583_name))))), mustOwn, out _out1561, out _out1562, out _out1563, out _out1564);
          _2590_bodyGen = _out1561;
          _2591_bodyOwned = _out1562;
          _2592_bodyErased = _out1563;
          _2593_bodyIdents = _out1564;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2593_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _2594_eraseFn;
          _2594_eraseFn = ((_2585_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2583_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2585_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2589_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2584_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2590_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2591_bodyOwned;
          isErased = _2592_bodyErased;
        }
      } else if (_source20.is_Apply) {
        DAST._IExpression _2595___mcc_h182 = _source20.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2596___mcc_h183 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2597_args = _2596___mcc_h183;
        DAST._IExpression _2598_func = _2595___mcc_h182;
        {
          Dafny.ISequence<Dafny.Rune> _2599_funcString;
          bool _2600___v84;
          bool _2601_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2602_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1565;
          bool _out1566;
          bool _out1567;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1568;
          DCOMP.COMP.GenExpr(_2598_func, selfIdent, @params, false, out _out1565, out _out1566, out _out1567, out _out1568);
          _2599_funcString = _out1565;
          _2600___v84 = _out1566;
          _2601_funcErased = _out1567;
          _2602_recIdents = _out1568;
          readIdents = _2602_recIdents;
          Dafny.ISequence<Dafny.Rune> _2603_argString;
          _2603_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2604_i;
          _2604_i = BigInteger.Zero;
          while ((_2604_i) < (new BigInteger((_2597_args).Count))) {
            if ((_2604_i).Sign == 1) {
              _2603_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2603_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2605_argExpr;
            bool _2606_isOwned;
            bool _2607_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2608_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1569;
            bool _out1570;
            bool _out1571;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1572;
            DCOMP.COMP.GenExpr((_2597_args).Select(_2604_i), selfIdent, @params, false, out _out1569, out _out1570, out _out1571, out _out1572);
            _2605_argExpr = _out1569;
            _2606_isOwned = _out1570;
            _2607_argErased = _out1571;
            _2608_argIdents = _out1572;
            if (_2606_isOwned) {
              _2605_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2605_argExpr);
            }
            _2603_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2603_argString, _2605_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2608_argIdents);
            _2604_i = (_2604_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2599_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2603_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source20.is_TypeTest) {
        DAST._IExpression _2609___mcc_h184 = _source20.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2610___mcc_h185 = _source20.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2611___mcc_h186 = _source20.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2612_variant = _2611___mcc_h186;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2613_dType = _2610___mcc_h185;
        DAST._IExpression _2614_on = _2609___mcc_h184;
        {
          Dafny.ISequence<Dafny.Rune> _2615_exprGen;
          bool _2616___v85;
          bool _2617_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2618_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1573;
          bool _out1574;
          bool _out1575;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1576;
          DCOMP.COMP.GenExpr(_2614_on, selfIdent, @params, false, out _out1573, out _out1574, out _out1575, out _out1576);
          _2615_exprGen = _out1573;
          _2616___v85 = _out1574;
          _2617_exprErased = _out1575;
          _2618_recIdents = _out1576;
          Dafny.ISequence<Dafny.Rune> _2619_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1577;
          _out1577 = DCOMP.COMP.GenPath(_2613_dType);
          _2619_dTypePath = _out1577;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2615_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2619_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2612_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2618_recIdents;
        }
      } else {
        DAST._IType _2620___mcc_h187 = _source20.dtor_typ;
        DAST._IType _2621_typ = _2620___mcc_h187;
        {
          Dafny.ISequence<Dafny.Rune> _2622_typString;
          Dafny.ISequence<Dafny.Rune> _out1578;
          _out1578 = DCOMP.COMP.GenType(_2621_typ, false, false);
          _2622_typString = _out1578;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2622_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2623_i;
      _2623_i = BigInteger.Zero;
      while ((_2623_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2624_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1579;
        _out1579 = DCOMP.COMP.GenModule((p).Select(_2623_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2624_generated = _out1579;
        if ((_2623_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2624_generated);
        _2623_i = (_2623_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2625_i;
      _2625_i = BigInteger.Zero;
      while ((_2625_i) < (new BigInteger((fullName).Count))) {
        if ((_2625_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2625_i));
        _2625_i = (_2625_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

