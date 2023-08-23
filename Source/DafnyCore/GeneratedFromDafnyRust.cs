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
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _145_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
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
    public static void GenAssignLhs(DAST._IAssignLhs lhs, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
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
      } else {
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
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _218_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _216_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut())"));
          readIdents = _221_recIdents;
          needsIIFE = true;
        }
      }
    }
    public static void GenStmt(DAST._IStatement stmt, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IStatement _source15 = stmt;
      if (_source15.is_DeclareVar) {
        Dafny.ISequence<Dafny.Rune> _223___mcc_h0 = _source15.dtor_name;
        DAST._IType _224___mcc_h1 = _source15.dtor_typ;
        DAST._IOptional<DAST._IExpression> _225___mcc_h2 = _source15.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source16 = _225___mcc_h2;
        if (_source16.is_Some) {
          DAST._IExpression _226___mcc_h3 = _source16.dtor_Some_a0;
          DAST._IExpression _227_expression = _226___mcc_h3;
          DAST._IType _228_typ = _224___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _229_name = _223___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _230_expr;
            bool _231___v13;
            bool _232_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _233_recIdents;
            Dafny.ISequence<Dafny.Rune> _out68;
            bool _out69;
            bool _out70;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out71;
            DCOMP.COMP.GenExpr(_227_expression, selfIdent, @params, true, out _out68, out _out69, out _out70, out _out71);
            _230_expr = _out68;
            _231___v13 = _out69;
            _232_recErased = _out70;
            _233_recIdents = _out71;
            if (_232_recErased) {
              _230_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _230_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _234_typeString;
            Dafny.ISequence<Dafny.Rune> _out72;
            _out72 = DCOMP.COMP.GenType(_228_typ, true, false);
            _234_typeString = _out72;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _229_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _234_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _230_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _233_recIdents;
          }
        } else {
          DAST._IType _235_typ = _224___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _236_name = _223___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _237_typeString;
            Dafny.ISequence<Dafny.Rune> _out73;
            _out73 = DCOMP.COMP.GenType(_235_typ, true, false);
            _237_typeString = _out73;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _236_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _237_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source15.is_Assign) {
        DAST._IAssignLhs _238___mcc_h4 = _source15.dtor_lhs;
        DAST._IExpression _239___mcc_h5 = _source15.dtor_value;
        DAST._IExpression _240_expression = _239___mcc_h5;
        DAST._IAssignLhs _241_lhs = _238___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _242_lhsGen;
          bool _243_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _244_recIdents;
          Dafny.ISequence<Dafny.Rune> _out74;
          bool _out75;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out76;
          DCOMP.COMP.GenAssignLhs(_241_lhs, selfIdent, @params, out _out74, out _out75, out _out76);
          _242_lhsGen = _out74;
          _243_needsIIFE = _out75;
          _244_recIdents = _out76;
          Dafny.ISequence<Dafny.Rune> _245_exprGen;
          bool _246___v14;
          bool _247_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _248_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out77;
          bool _out78;
          bool _out79;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out80;
          DCOMP.COMP.GenExpr(_240_expression, selfIdent, @params, true, out _out77, out _out78, out _out79, out _out80);
          _245_exprGen = _out77;
          _246___v14 = _out78;
          _247_exprErased = _out79;
          _248_exprIdents = _out80;
          if (_247_exprErased) {
            _245_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _245_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_243_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ let __rhs = "), _245_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; ")), _242_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = __rhs; }"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_242_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _245_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_244_recIdents, _248_exprIdents);
        }
      } else if (_source15.is_If) {
        DAST._IExpression _249___mcc_h6 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _250___mcc_h7 = _source15.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _251___mcc_h8 = _source15.dtor_els;
        Dafny.ISequence<DAST._IStatement> _252_els = _251___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _253_thn = _250___mcc_h7;
        DAST._IExpression _254_cond = _249___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _255_condString;
          bool _256___v15;
          bool _257_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _258_recIdents;
          Dafny.ISequence<Dafny.Rune> _out81;
          bool _out82;
          bool _out83;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out84;
          DCOMP.COMP.GenExpr(_254_cond, selfIdent, @params, true, out _out81, out _out82, out _out83, out _out84);
          _255_condString = _out81;
          _256___v15 = _out82;
          _257_condErased = _out83;
          _258_recIdents = _out84;
          if (!(_257_condErased)) {
            _255_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _255_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _258_recIdents;
          Dafny.ISequence<Dafny.Rune> _259_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _260_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out85;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out86;
          DCOMP.COMP.GenStmts(_253_thn, selfIdent, @params, isLast, earlyReturn, out _out85, out _out86);
          _259_thnString = _out85;
          _260_thnIdents = _out86;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _260_thnIdents);
          Dafny.ISequence<Dafny.Rune> _261_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _262_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out88;
          DCOMP.COMP.GenStmts(_252_els, selfIdent, @params, isLast, earlyReturn, out _out87, out _out88);
          _261_elsString = _out87;
          _262_elsIdents = _out88;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _262_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _255_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _259_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _261_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_While) {
        DAST._IExpression _263___mcc_h9 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _264___mcc_h10 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _265_body = _264___mcc_h10;
        DAST._IExpression _266_cond = _263___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _267_condString;
          bool _268___v16;
          bool _269_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _270_recIdents;
          Dafny.ISequence<Dafny.Rune> _out89;
          bool _out90;
          bool _out91;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out92;
          DCOMP.COMP.GenExpr(_266_cond, selfIdent, @params, true, out _out89, out _out90, out _out91, out _out92);
          _267_condString = _out89;
          _268___v16 = _out90;
          _269_condErased = _out91;
          _270_recIdents = _out92;
          if (!(_269_condErased)) {
            _267_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _267_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _270_recIdents;
          Dafny.ISequence<Dafny.Rune> _271_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _272_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out93;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
          DCOMP.COMP.GenStmts(_265_body, selfIdent, @params, false, earlyReturn, out _out93, out _out94);
          _271_bodyString = _out93;
          _272_bodyIdents = _out94;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _272_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _267_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _271_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _273___mcc_h11 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _274___mcc_h12 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _275___mcc_h13 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _276___mcc_h14 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _277___mcc_h15 = _source15.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _278_maybeOutVars = _277___mcc_h15;
        Dafny.ISequence<DAST._IExpression> _279_args = _276___mcc_h14;
        Dafny.ISequence<DAST._IType> _280_typeArgs = _275___mcc_h13;
        Dafny.ISequence<Dafny.Rune> _281_name = _274___mcc_h12;
        DAST._IExpression _282_on = _273___mcc_h11;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _283_typeArgString;
          _283_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_280_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _284_typeI;
            _284_typeI = BigInteger.Zero;
            _283_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_284_typeI) < (new BigInteger((_280_typeArgs).Count))) {
              if ((_284_typeI).Sign == 1) {
                _283_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_283_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _285_typeString;
              Dafny.ISequence<Dafny.Rune> _out95;
              _out95 = DCOMP.COMP.GenType((_280_typeArgs).Select(_284_typeI), false, false);
              _285_typeString = _out95;
              _283_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_283_typeArgString, _285_typeString);
              _284_typeI = (_284_typeI) + (BigInteger.One);
            }
            _283_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_283_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _286_argString;
          _286_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _287_i;
          _287_i = BigInteger.Zero;
          while ((_287_i) < (new BigInteger((_279_args).Count))) {
            if ((_287_i).Sign == 1) {
              _286_argString = Dafny.Sequence<Dafny.Rune>.Concat(_286_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _288_argExpr;
            bool _289_isOwned;
            bool _290_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _291_argIdents;
            Dafny.ISequence<Dafny.Rune> _out96;
            bool _out97;
            bool _out98;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out99;
            DCOMP.COMP.GenExpr((_279_args).Select(_287_i), selfIdent, @params, false, out _out96, out _out97, out _out98, out _out99);
            _288_argExpr = _out96;
            _289_isOwned = _out97;
            _290_argErased = _out98;
            _291_argIdents = _out99;
            if (_289_isOwned) {
              _288_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _288_argExpr);
            }
            _286_argString = Dafny.Sequence<Dafny.Rune>.Concat(_286_argString, _288_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _291_argIdents);
            _287_i = (_287_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _292_enclosingString;
          bool _293___v17;
          bool _294___v18;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _295_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out100;
          bool _out101;
          bool _out102;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out103;
          DCOMP.COMP.GenExpr(_282_on, selfIdent, @params, false, out _out100, out _out101, out _out102, out _out103);
          _292_enclosingString = _out100;
          _293___v17 = _out101;
          _294___v18 = _out102;
          _295_enclosingIdents = _out103;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _295_enclosingIdents);
          DAST._IExpression _source17 = _282_on;
          if (_source17.is_Literal) {
            DAST._ILiteral _296___mcc_h19 = _source17.dtor_Literal_a0;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _297___mcc_h21 = _source17.dtor_Ident_a0;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _298___mcc_h23 = _source17.dtor_Companion_a0;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_292_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source17.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _299___mcc_h25 = _source17.dtor_Tuple_a0;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _300___mcc_h27 = _source17.dtor_path;
            Dafny.ISequence<DAST._IExpression> _301___mcc_h28 = _source17.dtor_args;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _302___mcc_h31 = _source17.dtor_dims;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _303___mcc_h33 = _source17.dtor_path;
            Dafny.ISequence<Dafny.Rune> _304___mcc_h34 = _source17.dtor_variant;
            bool _305___mcc_h35 = _source17.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _306___mcc_h36 = _source17.dtor_contents;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Convert) {
            DAST._IExpression _307___mcc_h41 = _source17.dtor_value;
            DAST._IType _308___mcc_h42 = _source17.dtor_from;
            DAST._IType _309___mcc_h43 = _source17.dtor_typ;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _310___mcc_h47 = _source17.dtor_elements;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _311___mcc_h49 = _source17.dtor_elements;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_This) {
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ite) {
            DAST._IExpression _312___mcc_h51 = _source17.dtor_cond;
            DAST._IExpression _313___mcc_h52 = _source17.dtor_thn;
            DAST._IExpression _314___mcc_h53 = _source17.dtor_els;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_UnOp) {
            DAST._IUnaryOp _315___mcc_h57 = _source17.dtor_unOp;
            DAST._IExpression _316___mcc_h58 = _source17.dtor_expr;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _317___mcc_h61 = _source17.dtor_op;
            DAST._IExpression _318___mcc_h62 = _source17.dtor_left;
            DAST._IExpression _319___mcc_h63 = _source17.dtor_right;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Select) {
            DAST._IExpression _320___mcc_h67 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _321___mcc_h68 = _source17.dtor_field;
            bool _322___mcc_h69 = _source17.dtor_isConstant;
            bool _323___mcc_h70 = _source17.dtor_onDatatype;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SelectFn) {
            DAST._IExpression _324___mcc_h75 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _325___mcc_h76 = _source17.dtor_field;
            bool _326___mcc_h77 = _source17.dtor_onDatatype;
            bool _327___mcc_h78 = _source17.dtor_isStatic;
            BigInteger _328___mcc_h79 = _source17.dtor_arity;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Index) {
            DAST._IExpression _329___mcc_h85 = _source17.dtor_expr;
            DAST._IExpression _330___mcc_h86 = _source17.dtor_idx;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TupleSelect) {
            DAST._IExpression _331___mcc_h89 = _source17.dtor_expr;
            BigInteger _332___mcc_h90 = _source17.dtor_index;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Call) {
            DAST._IExpression _333___mcc_h93 = _source17.dtor_on;
            Dafny.ISequence<Dafny.Rune> _334___mcc_h94 = _source17.dtor_name;
            Dafny.ISequence<DAST._IType> _335___mcc_h95 = _source17.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _336___mcc_h96 = _source17.dtor_args;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _337___mcc_h101 = _source17.dtor_params;
            DAST._IType _338___mcc_h102 = _source17.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _339___mcc_h103 = _source17.dtor_body;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _340___mcc_h107 = _source17.dtor_name;
            DAST._IType _341___mcc_h108 = _source17.dtor_typ;
            DAST._IExpression _342___mcc_h109 = _source17.dtor_value;
            DAST._IExpression _343___mcc_h110 = _source17.dtor_iifeBody;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Apply) {
            DAST._IExpression _344___mcc_h115 = _source17.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _345___mcc_h116 = _source17.dtor_args;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TypeTest) {
            DAST._IExpression _346___mcc_h119 = _source17.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _347___mcc_h120 = _source17.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _348___mcc_h121 = _source17.dtor_variant;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _349___mcc_h125 = _source17.dtor_typ;
            {
              _292_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _350_receiver;
          _350_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source18 = _278_maybeOutVars;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _351___mcc_h127 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _352_outVars = _351___mcc_h127;
            {
              if ((new BigInteger((_352_outVars).Count)) > (BigInteger.One)) {
                _350_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _353_outI;
              _353_outI = BigInteger.Zero;
              while ((_353_outI) < (new BigInteger((_352_outVars).Count))) {
                if ((_353_outI).Sign == 1) {
                  _350_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_350_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _354_outVar;
                _354_outVar = (_352_outVars).Select(_353_outI);
                _350_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_350_receiver, (_354_outVar));
                _353_outI = (_353_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_352_outVars).Count)) > (BigInteger.One)) {
                _350_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_350_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_350_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_350_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _292_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _281_name), _283_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _286_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _355___mcc_h16 = _source15.dtor_expr;
        DAST._IExpression _356_expr = _355___mcc_h16;
        {
          Dafny.ISequence<Dafny.Rune> _357_exprString;
          bool _358___v21;
          bool _359_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _360_recIdents;
          Dafny.ISequence<Dafny.Rune> _out104;
          bool _out105;
          bool _out106;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out107;
          DCOMP.COMP.GenExpr(_356_expr, selfIdent, @params, true, out _out104, out _out105, out _out106, out _out107);
          _357_exprString = _out104;
          _358___v21 = _out105;
          _359_recErased = _out106;
          _360_recIdents = _out107;
          _357_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _357_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _360_recIdents;
          if (isLast) {
            generated = _357_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _357_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source15.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _361___mcc_h17 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _362_body = _361___mcc_h17;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _363_paramI;
          _363_paramI = BigInteger.Zero;
          while ((_363_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _364_param;
            _364_param = (@params).Select(_363_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _364_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _364_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _363_paramI = (_363_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _365_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _366_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out108;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out109;
          DCOMP.COMP.GenStmts(_362_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out108, out _out109);
          _365_bodyString = _out108;
          _366_bodyIdents = _out109;
          readIdents = _366_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _365_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
        DAST._IExpression _367___mcc_h18 = _source15.dtor_Print_a0;
        DAST._IExpression _368_e = _367___mcc_h18;
        {
          Dafny.ISequence<Dafny.Rune> _369_printedExpr;
          bool _370_isOwned;
          bool _371___v22;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _372_recIdents;
          Dafny.ISequence<Dafny.Rune> _out110;
          bool _out111;
          bool _out112;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out113;
          DCOMP.COMP.GenExpr(_368_e, selfIdent, @params, false, out _out110, out _out111, out _out112, out _out113);
          _369_printedExpr = _out110;
          _370_isOwned = _out111;
          _371___v22 = _out112;
          _372_recIdents = _out113;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_370_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _369_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _372_recIdents;
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
        DAST._ILiteral _373___mcc_h0 = _source19.dtor_Literal_a0;
        DAST._ILiteral _source20 = _373___mcc_h0;
        if (_source20.is_BoolLiteral) {
          bool _374___mcc_h1 = _source20.dtor_BoolLiteral_a0;
          if ((_374___mcc_h1) == (false)) {
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
          Dafny.ISequence<Dafny.Rune> _375___mcc_h2 = _source20.dtor_IntLiteral_a0;
          DAST._IType _376___mcc_h3 = _source20.dtor_IntLiteral_a1;
          DAST._IType _377_t = _376___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _378_i = _375___mcc_h2;
          {
            DAST._IType _source21 = _377_t;
            if (_source21.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _379___mcc_h62 = _source21.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _380___mcc_h63 = _source21.dtor_typeArgs;
              DAST._IResolvedType _381___mcc_h64 = _source21.dtor_resolved;
              {
                s = _378_i;
              }
            } else if (_source21.is_Nullable) {
              DAST._IType _382___mcc_h68 = _source21.dtor_Nullable_a0;
              {
                s = _378_i;
              }
            } else if (_source21.is_Tuple) {
              Dafny.ISequence<DAST._IType> _383___mcc_h70 = _source21.dtor_Tuple_a0;
              {
                s = _378_i;
              }
            } else if (_source21.is_Array) {
              DAST._IType _384___mcc_h72 = _source21.dtor_element;
              {
                s = _378_i;
              }
            } else if (_source21.is_Seq) {
              DAST._IType _385___mcc_h74 = _source21.dtor_element;
              {
                s = _378_i;
              }
            } else if (_source21.is_Set) {
              DAST._IType _386___mcc_h76 = _source21.dtor_element;
              {
                s = _378_i;
              }
            } else if (_source21.is_Multiset) {
              DAST._IType _387___mcc_h78 = _source21.dtor_element;
              {
                s = _378_i;
              }
            } else if (_source21.is_Map) {
              DAST._IType _388___mcc_h80 = _source21.dtor_key;
              DAST._IType _389___mcc_h81 = _source21.dtor_value;
              {
                s = _378_i;
              }
            } else if (_source21.is_Arrow) {
              Dafny.ISequence<DAST._IType> _390___mcc_h84 = _source21.dtor_args;
              DAST._IType _391___mcc_h85 = _source21.dtor_result;
              {
                s = _378_i;
              }
            } else if (_source21.is_Primitive) {
              DAST._IPrimitive _392___mcc_h88 = _source21.dtor_Primitive_a0;
              DAST._IPrimitive _source22 = _392___mcc_h88;
              if (_source22.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _378_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source22.is_Real) {
                {
                  s = _378_i;
                }
              } else if (_source22.is_String) {
                {
                  s = _378_i;
                }
              } else if (_source22.is_Bool) {
                {
                  s = _378_i;
                }
              } else {
                {
                  s = _378_i;
                }
              }
            } else if (_source21.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _393___mcc_h90 = _source21.dtor_Passthrough_a0;
              {
                s = _378_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _394___mcc_h92 = _source21.dtor_TypeArg_a0;
              {
                s = _378_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _395___mcc_h4 = _source20.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _396___mcc_h5 = _source20.dtor_DecLiteral_a1;
          DAST._IType _397___mcc_h6 = _source20.dtor_DecLiteral_a2;
          DAST._IType _398_t = _397___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _399_d = _396___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _400_n = _395___mcc_h4;
          {
            DAST._IType _source23 = _398_t;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _401___mcc_h94 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _402___mcc_h95 = _source23.dtor_typeArgs;
              DAST._IResolvedType _403___mcc_h96 = _source23.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Nullable) {
              DAST._IType _404___mcc_h100 = _source23.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _405___mcc_h102 = _source23.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Array) {
              DAST._IType _406___mcc_h104 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Seq) {
              DAST._IType _407___mcc_h106 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Set) {
              DAST._IType _408___mcc_h108 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _409___mcc_h110 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Map) {
              DAST._IType _410___mcc_h112 = _source23.dtor_key;
              DAST._IType _411___mcc_h113 = _source23.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _412___mcc_h116 = _source23.dtor_args;
              DAST._IType _413___mcc_h117 = _source23.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _414___mcc_h120 = _source23.dtor_Primitive_a0;
              DAST._IPrimitive _source24 = _414___mcc_h120;
              if (_source24.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _400_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source24.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _415___mcc_h122 = _source23.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _416___mcc_h124 = _source23.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_400_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _399_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _417___mcc_h7 = _source20.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _418_l = _417___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _418_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_CharLiteral) {
          Dafny.Rune _419___mcc_h8 = _source20.dtor_CharLiteral_a0;
          Dafny.Rune _420_c = _419___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_420_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _421___mcc_h9 = _source19.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _422_name = _421___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _422_name);
          if (!((@params).Contains(_422_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_422_name);
        }
      } else if (_source19.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _423___mcc_h10 = _source19.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _424_path = _423___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out114;
          _out114 = DCOMP.COMP.GenPath(_424_path);
          s = _out114;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source19.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _425___mcc_h11 = _source19.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _426_values = _425___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _427_i;
          _427_i = BigInteger.Zero;
          bool _428_allErased;
          _428_allErased = true;
          while ((_427_i) < (new BigInteger((_426_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _429___v25;
            bool _430___v26;
            bool _431_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _432___v27;
            Dafny.ISequence<Dafny.Rune> _out115;
            bool _out116;
            bool _out117;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out118;
            DCOMP.COMP.GenExpr((_426_values).Select(_427_i), selfIdent, @params, true, out _out115, out _out116, out _out117, out _out118);
            _429___v25 = _out115;
            _430___v26 = _out116;
            _431_isErased = _out117;
            _432___v27 = _out118;
            _428_allErased = (_428_allErased) && (_431_isErased);
            _427_i = (_427_i) + (BigInteger.One);
          }
          _427_i = BigInteger.Zero;
          while ((_427_i) < (new BigInteger((_426_values).Count))) {
            if ((_427_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _433_recursiveGen;
            bool _434___v28;
            bool _435_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _436_recIdents;
            Dafny.ISequence<Dafny.Rune> _out119;
            bool _out120;
            bool _out121;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out122;
            DCOMP.COMP.GenExpr((_426_values).Select(_427_i), selfIdent, @params, true, out _out119, out _out120, out _out121, out _out122);
            _433_recursiveGen = _out119;
            _434___v28 = _out120;
            _435_isErased = _out121;
            _436_recIdents = _out122;
            if ((_435_isErased) && (!(_428_allErased))) {
              _433_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _433_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _433_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _436_recIdents);
            _427_i = (_427_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _428_allErased;
        }
      } else if (_source19.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _437___mcc_h12 = _source19.dtor_path;
        Dafny.ISequence<DAST._IExpression> _438___mcc_h13 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _439_args = _438___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _440_path = _437___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _441_path;
          Dafny.ISequence<Dafny.Rune> _out123;
          _out123 = DCOMP.COMP.GenPath(_440_path);
          _441_path = _out123;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _441_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _442_i;
          _442_i = BigInteger.Zero;
          while ((_442_i) < (new BigInteger((_439_args).Count))) {
            if ((_442_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _443_recursiveGen;
            bool _444___v29;
            bool _445_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _446_recIdents;
            Dafny.ISequence<Dafny.Rune> _out124;
            bool _out125;
            bool _out126;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out127;
            DCOMP.COMP.GenExpr((_439_args).Select(_442_i), selfIdent, @params, true, out _out124, out _out125, out _out126, out _out127);
            _443_recursiveGen = _out124;
            _444___v29 = _out125;
            _445_isErased = _out126;
            _446_recIdents = _out127;
            if (_445_isErased) {
              _443_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _443_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _443_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _446_recIdents);
            _442_i = (_442_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _447___mcc_h14 = _source19.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _448_dims = _447___mcc_h14;
        {
          BigInteger _449_i;
          _449_i = (new BigInteger((_448_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_449_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _450_recursiveGen;
            bool _451___v30;
            bool _452_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _453_recIdents;
            Dafny.ISequence<Dafny.Rune> _out128;
            bool _out129;
            bool _out130;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out131;
            DCOMP.COMP.GenExpr((_448_dims).Select(_449_i), selfIdent, @params, true, out _out128, out _out129, out _out130, out _out131);
            _450_recursiveGen = _out128;
            _451___v30 = _out129;
            _452_isErased = _out130;
            _453_recIdents = _out131;
            if (!(_452_isErased)) {
              _450_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _450_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _450_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _453_recIdents);
            _449_i = (_449_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _454___mcc_h15 = _source19.dtor_path;
        Dafny.ISequence<Dafny.Rune> _455___mcc_h16 = _source19.dtor_variant;
        bool _456___mcc_h17 = _source19.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _457___mcc_h18 = _source19.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _458_values = _457___mcc_h18;
        bool _459_isCo = _456___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _460_variant = _455___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _461_path = _454___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _462_path;
          Dafny.ISequence<Dafny.Rune> _out132;
          _out132 = DCOMP.COMP.GenPath(_461_path);
          _462_path = _out132;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _462_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _460_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _463_i;
          _463_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_463_i) < (new BigInteger((_458_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_458_values).Select(_463_i);
            Dafny.ISequence<Dafny.Rune> _464_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _465_value = _let_tmp_rhs0.dtor__1;
            if ((_463_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_459_isCo) {
              Dafny.ISequence<Dafny.Rune> _466_recursiveGen;
              bool _467___v31;
              bool _468_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _469_recIdents;
              Dafny.ISequence<Dafny.Rune> _out133;
              bool _out134;
              bool _out135;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out136;
              DCOMP.COMP.GenExpr(_465_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out133, out _out134, out _out135, out _out136);
              _466_recursiveGen = _out133;
              _467___v31 = _out134;
              _468_isErased = _out135;
              _469_recIdents = _out136;
              if (!(_468_isErased)) {
                _466_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _466_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _466_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _466_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _469_recIdents);
              Dafny.ISequence<Dafny.Rune> _470_allReadCloned;
              _470_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_469_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _471_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_469_recIdents).Elements) {
                  _471_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_469_recIdents).Contains(_471_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1122)");
              after__ASSIGN_SUCH_THAT_0:;
                _470_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _471_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _471_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _469_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_469_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_471_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _464_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _470_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _466_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _472_recursiveGen;
              bool _473___v32;
              bool _474_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _475_recIdents;
              Dafny.ISequence<Dafny.Rune> _out137;
              bool _out138;
              bool _out139;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out140;
              DCOMP.COMP.GenExpr(_465_value, selfIdent, @params, true, out _out137, out _out138, out _out139, out _out140);
              _472_recursiveGen = _out137;
              _473___v32 = _out138;
              _474_isErased = _out139;
              _475_recIdents = _out140;
              if (!(_474_isErased)) {
                _472_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _472_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _472_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _472_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _464_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _472_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _475_recIdents);
            }
            _463_i = (_463_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_Convert) {
        DAST._IExpression _476___mcc_h19 = _source19.dtor_value;
        DAST._IType _477___mcc_h20 = _source19.dtor_from;
        DAST._IType _478___mcc_h21 = _source19.dtor_typ;
        DAST._IType _479_toTpe = _478___mcc_h21;
        DAST._IType _480_fromTpe = _477___mcc_h20;
        DAST._IExpression _481_expr = _476___mcc_h19;
        {
          if (object.Equals(_480_fromTpe, _479_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _482_recursiveGen;
            bool _483_recOwned;
            bool _484_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _485_recIdents;
            Dafny.ISequence<Dafny.Rune> _out141;
            bool _out142;
            bool _out143;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out144;
            DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out141, out _out142, out _out143, out _out144);
            _482_recursiveGen = _out141;
            _483_recOwned = _out142;
            _484_recErased = _out143;
            _485_recIdents = _out144;
            s = _482_recursiveGen;
            isOwned = _483_recOwned;
            isErased = _484_recErased;
            readIdents = _485_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source25 = _System.Tuple2<DAST._IType, DAST._IType>.create(_480_fromTpe, _479_toTpe);
            DAST._IType _486___mcc_h126 = _source25.dtor__0;
            DAST._IType _487___mcc_h127 = _source25.dtor__1;
            DAST._IType _source26 = _486___mcc_h126;
            if (_source26.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _488___mcc_h130 = _source26.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _489___mcc_h131 = _source26.dtor_typeArgs;
              DAST._IResolvedType _490___mcc_h132 = _source26.dtor_resolved;
              DAST._IResolvedType _source27 = _490___mcc_h132;
              if (_source27.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _491___mcc_h142 = _source27.dtor_path;
                DAST._IType _source28 = _487___mcc_h127;
                if (_source28.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _492___mcc_h146 = _source28.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _493___mcc_h147 = _source28.dtor_typeArgs;
                  DAST._IResolvedType _494___mcc_h148 = _source28.dtor_resolved;
                  DAST._IResolvedType _source29 = _494___mcc_h148;
                  if (_source29.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _495___mcc_h152 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _496_recursiveGen;
                      bool _497_recOwned;
                      bool _498_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _499_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out145;
                      bool _out146;
                      bool _out147;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out145, out _out146, out _out147, out _out148);
                      _496_recursiveGen = _out145;
                      _497_recOwned = _out146;
                      _498_recErased = _out147;
                      _499_recIdents = _out148;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _496_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _497_recOwned;
                      isErased = _498_recErased;
                      readIdents = _499_recIdents;
                    }
                  } else if (_source29.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _500___mcc_h154 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _501_recursiveGen;
                      bool _502_recOwned;
                      bool _503_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _504_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out149;
                      bool _out150;
                      bool _out151;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out149, out _out150, out _out151, out _out152);
                      _501_recursiveGen = _out149;
                      _502_recOwned = _out150;
                      _503_recErased = _out151;
                      _504_recIdents = _out152;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _501_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _502_recOwned;
                      isErased = _503_recErased;
                      readIdents = _504_recIdents;
                    }
                  } else {
                    DAST._IType _505___mcc_h156 = _source29.dtor_Newtype_a0;
                    DAST._IType _506_b = _505___mcc_h156;
                    {
                      if (object.Equals(_480_fromTpe, _506_b)) {
                        Dafny.ISequence<Dafny.Rune> _507_recursiveGen;
                        bool _508_recOwned;
                        bool _509_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _510_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out153;
                        bool _out154;
                        bool _out155;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out153, out _out154, out _out155, out _out156);
                        _507_recursiveGen = _out153;
                        _508_recOwned = _out154;
                        _509_recErased = _out155;
                        _510_recIdents = _out156;
                        Dafny.ISequence<Dafny.Rune> _511_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out157;
                        _out157 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                        _511_rhsType = _out157;
                        Dafny.ISequence<Dafny.Rune> _512_uneraseFn;
                        _512_uneraseFn = ((_508_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _511_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _512_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _507_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _508_recOwned;
                        isErased = false;
                        readIdents = _510_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out158;
                        bool _out159;
                        bool _out160;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out161;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _506_b), _506_b, _479_toTpe), selfIdent, @params, mustOwn, out _out158, out _out159, out _out160, out _out161);
                        s = _out158;
                        isOwned = _out159;
                        isErased = _out160;
                        readIdents = _out161;
                      }
                    }
                  }
                } else if (_source28.is_Nullable) {
                  DAST._IType _513___mcc_h158 = _source28.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _514_recursiveGen;
                    bool _515_recOwned;
                    bool _516_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _517_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out162;
                    bool _out163;
                    bool _out164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out165;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out162, out _out163, out _out164, out _out165);
                    _514_recursiveGen = _out162;
                    _515_recOwned = _out163;
                    _516_recErased = _out164;
                    _517_recIdents = _out165;
                    if (!(_515_recOwned)) {
                      _514_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_514_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _514_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _516_recErased;
                    readIdents = _517_recIdents;
                  }
                } else if (_source28.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _518___mcc_h160 = _source28.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _519_recursiveGen;
                    bool _520_recOwned;
                    bool _521_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _522_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out166;
                    bool _out167;
                    bool _out168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out169;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out166, out _out167, out _out168, out _out169);
                    _519_recursiveGen = _out166;
                    _520_recOwned = _out167;
                    _521_recErased = _out168;
                    _522_recIdents = _out169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _519_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _520_recOwned;
                    isErased = _521_recErased;
                    readIdents = _522_recIdents;
                  }
                } else if (_source28.is_Array) {
                  DAST._IType _523___mcc_h162 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _524_recursiveGen;
                    bool _525_recOwned;
                    bool _526_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _527_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out170;
                    bool _out171;
                    bool _out172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out173;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out170, out _out171, out _out172, out _out173);
                    _524_recursiveGen = _out170;
                    _525_recOwned = _out171;
                    _526_recErased = _out172;
                    _527_recIdents = _out173;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _524_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _525_recOwned;
                    isErased = _526_recErased;
                    readIdents = _527_recIdents;
                  }
                } else if (_source28.is_Seq) {
                  DAST._IType _528___mcc_h164 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _529_recursiveGen;
                    bool _530_recOwned;
                    bool _531_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _532_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out174;
                    bool _out175;
                    bool _out176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out177;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out174, out _out175, out _out176, out _out177);
                    _529_recursiveGen = _out174;
                    _530_recOwned = _out175;
                    _531_recErased = _out176;
                    _532_recIdents = _out177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _529_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _530_recOwned;
                    isErased = _531_recErased;
                    readIdents = _532_recIdents;
                  }
                } else if (_source28.is_Set) {
                  DAST._IType _533___mcc_h166 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _534_recursiveGen;
                    bool _535_recOwned;
                    bool _536_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _537_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out178;
                    bool _out179;
                    bool _out180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out181;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out178, out _out179, out _out180, out _out181);
                    _534_recursiveGen = _out178;
                    _535_recOwned = _out179;
                    _536_recErased = _out180;
                    _537_recIdents = _out181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _535_recOwned;
                    isErased = _536_recErased;
                    readIdents = _537_recIdents;
                  }
                } else if (_source28.is_Multiset) {
                  DAST._IType _538___mcc_h168 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _539_recursiveGen;
                    bool _540_recOwned;
                    bool _541_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _542_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out182;
                    bool _out183;
                    bool _out184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out185;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out182, out _out183, out _out184, out _out185);
                    _539_recursiveGen = _out182;
                    _540_recOwned = _out183;
                    _541_recErased = _out184;
                    _542_recIdents = _out185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _539_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _540_recOwned;
                    isErased = _541_recErased;
                    readIdents = _542_recIdents;
                  }
                } else if (_source28.is_Map) {
                  DAST._IType _543___mcc_h170 = _source28.dtor_key;
                  DAST._IType _544___mcc_h171 = _source28.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _545_recursiveGen;
                    bool _546_recOwned;
                    bool _547_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _548_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out186;
                    bool _out187;
                    bool _out188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out189;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out186, out _out187, out _out188, out _out189);
                    _545_recursiveGen = _out186;
                    _546_recOwned = _out187;
                    _547_recErased = _out188;
                    _548_recIdents = _out189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _545_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _546_recOwned;
                    isErased = _547_recErased;
                    readIdents = _548_recIdents;
                  }
                } else if (_source28.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _549___mcc_h174 = _source28.dtor_args;
                  DAST._IType _550___mcc_h175 = _source28.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _551_recursiveGen;
                    bool _552_recOwned;
                    bool _553_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _554_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out190;
                    bool _out191;
                    bool _out192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out193;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out190, out _out191, out _out192, out _out193);
                    _551_recursiveGen = _out190;
                    _552_recOwned = _out191;
                    _553_recErased = _out192;
                    _554_recIdents = _out193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _551_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _552_recOwned;
                    isErased = _553_recErased;
                    readIdents = _554_recIdents;
                  }
                } else if (_source28.is_Primitive) {
                  DAST._IPrimitive _555___mcc_h178 = _source28.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _556_recursiveGen;
                    bool _557_recOwned;
                    bool _558_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _559_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out194;
                    bool _out195;
                    bool _out196;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out197;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out194, out _out195, out _out196, out _out197);
                    _556_recursiveGen = _out194;
                    _557_recOwned = _out195;
                    _558_recErased = _out196;
                    _559_recIdents = _out197;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _556_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _557_recOwned;
                    isErased = _558_recErased;
                    readIdents = _559_recIdents;
                  }
                } else if (_source28.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _560___mcc_h180 = _source28.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _561_recursiveGen;
                    bool _562_recOwned;
                    bool _563_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _564_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out198;
                    bool _out199;
                    bool _out200;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out198, out _out199, out _out200, out _out201);
                    _561_recursiveGen = _out198;
                    _562_recOwned = _out199;
                    _563_recErased = _out200;
                    _564_recIdents = _out201;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _561_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _562_recOwned;
                    isErased = _563_recErased;
                    readIdents = _564_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _565___mcc_h182 = _source28.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _566_recursiveGen;
                    bool _567_recOwned;
                    bool _568_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _569_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out202;
                    bool _out203;
                    bool _out204;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out202, out _out203, out _out204, out _out205);
                    _566_recursiveGen = _out202;
                    _567_recOwned = _out203;
                    _568_recErased = _out204;
                    _569_recIdents = _out205;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _566_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _567_recOwned;
                    isErased = _568_recErased;
                    readIdents = _569_recIdents;
                  }
                }
              } else if (_source27.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _570___mcc_h184 = _source27.dtor_path;
                DAST._IType _source30 = _487___mcc_h127;
                if (_source30.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _571___mcc_h188 = _source30.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _572___mcc_h189 = _source30.dtor_typeArgs;
                  DAST._IResolvedType _573___mcc_h190 = _source30.dtor_resolved;
                  DAST._IResolvedType _source31 = _573___mcc_h190;
                  if (_source31.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _574___mcc_h194 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _575_recursiveGen;
                      bool _576_recOwned;
                      bool _577_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _578_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out206;
                      bool _out207;
                      bool _out208;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out206, out _out207, out _out208, out _out209);
                      _575_recursiveGen = _out206;
                      _576_recOwned = _out207;
                      _577_recErased = _out208;
                      _578_recIdents = _out209;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _575_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _576_recOwned;
                      isErased = _577_recErased;
                      readIdents = _578_recIdents;
                    }
                  } else if (_source31.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _579___mcc_h196 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _580_recursiveGen;
                      bool _581_recOwned;
                      bool _582_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _583_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out210;
                      bool _out211;
                      bool _out212;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out210, out _out211, out _out212, out _out213);
                      _580_recursiveGen = _out210;
                      _581_recOwned = _out211;
                      _582_recErased = _out212;
                      _583_recIdents = _out213;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _580_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _581_recOwned;
                      isErased = _582_recErased;
                      readIdents = _583_recIdents;
                    }
                  } else {
                    DAST._IType _584___mcc_h198 = _source31.dtor_Newtype_a0;
                    DAST._IType _585_b = _584___mcc_h198;
                    {
                      if (object.Equals(_480_fromTpe, _585_b)) {
                        Dafny.ISequence<Dafny.Rune> _586_recursiveGen;
                        bool _587_recOwned;
                        bool _588_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _589_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out214;
                        bool _out215;
                        bool _out216;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out214, out _out215, out _out216, out _out217);
                        _586_recursiveGen = _out214;
                        _587_recOwned = _out215;
                        _588_recErased = _out216;
                        _589_recIdents = _out217;
                        Dafny.ISequence<Dafny.Rune> _590_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out218;
                        _out218 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                        _590_rhsType = _out218;
                        Dafny.ISequence<Dafny.Rune> _591_uneraseFn;
                        _591_uneraseFn = ((_587_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _590_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _591_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _586_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _587_recOwned;
                        isErased = false;
                        readIdents = _589_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out219;
                        bool _out220;
                        bool _out221;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out222;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _585_b), _585_b, _479_toTpe), selfIdent, @params, mustOwn, out _out219, out _out220, out _out221, out _out222);
                        s = _out219;
                        isOwned = _out220;
                        isErased = _out221;
                        readIdents = _out222;
                      }
                    }
                  }
                } else if (_source30.is_Nullable) {
                  DAST._IType _592___mcc_h200 = _source30.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _593_recursiveGen;
                    bool _594_recOwned;
                    bool _595_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _596_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out223;
                    bool _out224;
                    bool _out225;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out226;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out223, out _out224, out _out225, out _out226);
                    _593_recursiveGen = _out223;
                    _594_recOwned = _out224;
                    _595_recErased = _out225;
                    _596_recIdents = _out226;
                    if (!(_594_recOwned)) {
                      _593_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_593_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _593_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _595_recErased;
                    readIdents = _596_recIdents;
                  }
                } else if (_source30.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _597___mcc_h202 = _source30.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _598_recursiveGen;
                    bool _599_recOwned;
                    bool _600_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _601_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out227;
                    bool _out228;
                    bool _out229;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out230;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out227, out _out228, out _out229, out _out230);
                    _598_recursiveGen = _out227;
                    _599_recOwned = _out228;
                    _600_recErased = _out229;
                    _601_recIdents = _out230;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _598_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _599_recOwned;
                    isErased = _600_recErased;
                    readIdents = _601_recIdents;
                  }
                } else if (_source30.is_Array) {
                  DAST._IType _602___mcc_h204 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _603_recursiveGen;
                    bool _604_recOwned;
                    bool _605_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _606_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out231;
                    bool _out232;
                    bool _out233;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out234;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out231, out _out232, out _out233, out _out234);
                    _603_recursiveGen = _out231;
                    _604_recOwned = _out232;
                    _605_recErased = _out233;
                    _606_recIdents = _out234;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _603_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _604_recOwned;
                    isErased = _605_recErased;
                    readIdents = _606_recIdents;
                  }
                } else if (_source30.is_Seq) {
                  DAST._IType _607___mcc_h206 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _608_recursiveGen;
                    bool _609_recOwned;
                    bool _610_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _611_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out235;
                    bool _out236;
                    bool _out237;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out238;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out235, out _out236, out _out237, out _out238);
                    _608_recursiveGen = _out235;
                    _609_recOwned = _out236;
                    _610_recErased = _out237;
                    _611_recIdents = _out238;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _608_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _609_recOwned;
                    isErased = _610_recErased;
                    readIdents = _611_recIdents;
                  }
                } else if (_source30.is_Set) {
                  DAST._IType _612___mcc_h208 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _613_recursiveGen;
                    bool _614_recOwned;
                    bool _615_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _616_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out239;
                    bool _out240;
                    bool _out241;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out242;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out239, out _out240, out _out241, out _out242);
                    _613_recursiveGen = _out239;
                    _614_recOwned = _out240;
                    _615_recErased = _out241;
                    _616_recIdents = _out242;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _614_recOwned;
                    isErased = _615_recErased;
                    readIdents = _616_recIdents;
                  }
                } else if (_source30.is_Multiset) {
                  DAST._IType _617___mcc_h210 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _618_recursiveGen;
                    bool _619_recOwned;
                    bool _620_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _621_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out243;
                    bool _out244;
                    bool _out245;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out246;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out243, out _out244, out _out245, out _out246);
                    _618_recursiveGen = _out243;
                    _619_recOwned = _out244;
                    _620_recErased = _out245;
                    _621_recIdents = _out246;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _618_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _619_recOwned;
                    isErased = _620_recErased;
                    readIdents = _621_recIdents;
                  }
                } else if (_source30.is_Map) {
                  DAST._IType _622___mcc_h212 = _source30.dtor_key;
                  DAST._IType _623___mcc_h213 = _source30.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _624_recursiveGen;
                    bool _625_recOwned;
                    bool _626_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _627_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out247;
                    bool _out248;
                    bool _out249;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out250;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out247, out _out248, out _out249, out _out250);
                    _624_recursiveGen = _out247;
                    _625_recOwned = _out248;
                    _626_recErased = _out249;
                    _627_recIdents = _out250;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _624_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _625_recOwned;
                    isErased = _626_recErased;
                    readIdents = _627_recIdents;
                  }
                } else if (_source30.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _628___mcc_h216 = _source30.dtor_args;
                  DAST._IType _629___mcc_h217 = _source30.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _630_recursiveGen;
                    bool _631_recOwned;
                    bool _632_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _633_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out251;
                    bool _out252;
                    bool _out253;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out251, out _out252, out _out253, out _out254);
                    _630_recursiveGen = _out251;
                    _631_recOwned = _out252;
                    _632_recErased = _out253;
                    _633_recIdents = _out254;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _630_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _631_recOwned;
                    isErased = _632_recErased;
                    readIdents = _633_recIdents;
                  }
                } else if (_source30.is_Primitive) {
                  DAST._IPrimitive _634___mcc_h220 = _source30.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _635_recursiveGen;
                    bool _636_recOwned;
                    bool _637_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _638_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out255;
                    bool _out256;
                    bool _out257;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out255, out _out256, out _out257, out _out258);
                    _635_recursiveGen = _out255;
                    _636_recOwned = _out256;
                    _637_recErased = _out257;
                    _638_recIdents = _out258;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _635_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _636_recOwned;
                    isErased = _637_recErased;
                    readIdents = _638_recIdents;
                  }
                } else if (_source30.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _639___mcc_h222 = _source30.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _640_recursiveGen;
                    bool _641_recOwned;
                    bool _642_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _643_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out259;
                    bool _out260;
                    bool _out261;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out259, out _out260, out _out261, out _out262);
                    _640_recursiveGen = _out259;
                    _641_recOwned = _out260;
                    _642_recErased = _out261;
                    _643_recIdents = _out262;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _641_recOwned;
                    isErased = _642_recErased;
                    readIdents = _643_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _644___mcc_h224 = _source30.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _645_recursiveGen;
                    bool _646_recOwned;
                    bool _647_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _648_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out263;
                    bool _out264;
                    bool _out265;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out263, out _out264, out _out265, out _out266);
                    _645_recursiveGen = _out263;
                    _646_recOwned = _out264;
                    _647_recErased = _out265;
                    _648_recIdents = _out266;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _646_recOwned;
                    isErased = _647_recErased;
                    readIdents = _648_recIdents;
                  }
                }
              } else {
                DAST._IType _649___mcc_h226 = _source27.dtor_Newtype_a0;
                DAST._IType _source32 = _487___mcc_h127;
                if (_source32.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _650___mcc_h230 = _source32.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _651___mcc_h231 = _source32.dtor_typeArgs;
                  DAST._IResolvedType _652___mcc_h232 = _source32.dtor_resolved;
                  DAST._IResolvedType _source33 = _652___mcc_h232;
                  if (_source33.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _653___mcc_h239 = _source33.dtor_path;
                    DAST._IType _654_b = _649___mcc_h226;
                    {
                      if (object.Equals(_654_b, _479_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _655_recursiveGen;
                        bool _656_recOwned;
                        bool _657_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _658_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out267;
                        bool _out268;
                        bool _out269;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out267, out _out268, out _out269, out _out270);
                        _655_recursiveGen = _out267;
                        _656_recOwned = _out268;
                        _657_recErased = _out269;
                        _658_recIdents = _out270;
                        Dafny.ISequence<Dafny.Rune> _659_uneraseFn;
                        _659_uneraseFn = ((_656_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _659_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _655_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _656_recOwned;
                        isErased = true;
                        readIdents = _658_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out271;
                        bool _out272;
                        bool _out273;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _654_b), _654_b, _479_toTpe), selfIdent, @params, mustOwn, out _out271, out _out272, out _out273, out _out274);
                        s = _out271;
                        isOwned = _out272;
                        isErased = _out273;
                        readIdents = _out274;
                      }
                    }
                  } else if (_source33.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _660___mcc_h242 = _source33.dtor_path;
                    DAST._IType _661_b = _649___mcc_h226;
                    {
                      if (object.Equals(_661_b, _479_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _662_recursiveGen;
                        bool _663_recOwned;
                        bool _664_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _665_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out275;
                        bool _out276;
                        bool _out277;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out275, out _out276, out _out277, out _out278);
                        _662_recursiveGen = _out275;
                        _663_recOwned = _out276;
                        _664_recErased = _out277;
                        _665_recIdents = _out278;
                        Dafny.ISequence<Dafny.Rune> _666_uneraseFn;
                        _666_uneraseFn = ((_663_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _666_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _662_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _663_recOwned;
                        isErased = true;
                        readIdents = _665_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out279;
                        bool _out280;
                        bool _out281;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _661_b), _661_b, _479_toTpe), selfIdent, @params, mustOwn, out _out279, out _out280, out _out281, out _out282);
                        s = _out279;
                        isOwned = _out280;
                        isErased = _out281;
                        readIdents = _out282;
                      }
                    }
                  } else {
                    DAST._IType _667___mcc_h245 = _source33.dtor_Newtype_a0;
                    DAST._IType _668_b = _667___mcc_h245;
                    {
                      if (object.Equals(_480_fromTpe, _668_b)) {
                        Dafny.ISequence<Dafny.Rune> _669_recursiveGen;
                        bool _670_recOwned;
                        bool _671_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _672_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out283;
                        bool _out284;
                        bool _out285;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out283, out _out284, out _out285, out _out286);
                        _669_recursiveGen = _out283;
                        _670_recOwned = _out284;
                        _671_recErased = _out285;
                        _672_recIdents = _out286;
                        Dafny.ISequence<Dafny.Rune> _673_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out287;
                        _out287 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                        _673_rhsType = _out287;
                        Dafny.ISequence<Dafny.Rune> _674_uneraseFn;
                        _674_uneraseFn = ((_670_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _673_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _674_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _669_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _670_recOwned;
                        isErased = false;
                        readIdents = _672_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out288;
                        bool _out289;
                        bool _out290;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out291;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _668_b), _668_b, _479_toTpe), selfIdent, @params, mustOwn, out _out288, out _out289, out _out290, out _out291);
                        s = _out288;
                        isOwned = _out289;
                        isErased = _out290;
                        readIdents = _out291;
                      }
                    }
                  }
                } else if (_source32.is_Nullable) {
                  DAST._IType _675___mcc_h248 = _source32.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _676_recursiveGen;
                    bool _677_recOwned;
                    bool _678_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _679_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out292;
                    bool _out293;
                    bool _out294;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out295;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out292, out _out293, out _out294, out _out295);
                    _676_recursiveGen = _out292;
                    _677_recOwned = _out293;
                    _678_recErased = _out294;
                    _679_recIdents = _out295;
                    if (!(_677_recOwned)) {
                      _676_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_676_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _676_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _678_recErased;
                    readIdents = _679_recIdents;
                  }
                } else if (_source32.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _680___mcc_h251 = _source32.dtor_Tuple_a0;
                  DAST._IType _681_b = _649___mcc_h226;
                  {
                    if (object.Equals(_681_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _682_recursiveGen;
                      bool _683_recOwned;
                      bool _684_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _685_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out296;
                      bool _out297;
                      bool _out298;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out299;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out296, out _out297, out _out298, out _out299);
                      _682_recursiveGen = _out296;
                      _683_recOwned = _out297;
                      _684_recErased = _out298;
                      _685_recIdents = _out299;
                      Dafny.ISequence<Dafny.Rune> _686_uneraseFn;
                      _686_uneraseFn = ((_683_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _686_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _683_recOwned;
                      isErased = true;
                      readIdents = _685_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out300;
                      bool _out301;
                      bool _out302;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out303;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _681_b), _681_b, _479_toTpe), selfIdent, @params, mustOwn, out _out300, out _out301, out _out302, out _out303);
                      s = _out300;
                      isOwned = _out301;
                      isErased = _out302;
                      readIdents = _out303;
                    }
                  }
                } else if (_source32.is_Array) {
                  DAST._IType _687___mcc_h254 = _source32.dtor_element;
                  DAST._IType _688_b = _649___mcc_h226;
                  {
                    if (object.Equals(_688_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _689_recursiveGen;
                      bool _690_recOwned;
                      bool _691_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _692_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out304;
                      bool _out305;
                      bool _out306;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out304, out _out305, out _out306, out _out307);
                      _689_recursiveGen = _out304;
                      _690_recOwned = _out305;
                      _691_recErased = _out306;
                      _692_recIdents = _out307;
                      Dafny.ISequence<Dafny.Rune> _693_uneraseFn;
                      _693_uneraseFn = ((_690_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _693_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _689_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _690_recOwned;
                      isErased = true;
                      readIdents = _692_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out308;
                      bool _out309;
                      bool _out310;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _688_b), _688_b, _479_toTpe), selfIdent, @params, mustOwn, out _out308, out _out309, out _out310, out _out311);
                      s = _out308;
                      isOwned = _out309;
                      isErased = _out310;
                      readIdents = _out311;
                    }
                  }
                } else if (_source32.is_Seq) {
                  DAST._IType _694___mcc_h257 = _source32.dtor_element;
                  DAST._IType _695_b = _649___mcc_h226;
                  {
                    if (object.Equals(_695_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _696_recursiveGen;
                      bool _697_recOwned;
                      bool _698_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _699_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out312;
                      bool _out313;
                      bool _out314;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out312, out _out313, out _out314, out _out315);
                      _696_recursiveGen = _out312;
                      _697_recOwned = _out313;
                      _698_recErased = _out314;
                      _699_recIdents = _out315;
                      Dafny.ISequence<Dafny.Rune> _700_uneraseFn;
                      _700_uneraseFn = ((_697_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _700_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _696_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _697_recOwned;
                      isErased = true;
                      readIdents = _699_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out316;
                      bool _out317;
                      bool _out318;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _695_b), _695_b, _479_toTpe), selfIdent, @params, mustOwn, out _out316, out _out317, out _out318, out _out319);
                      s = _out316;
                      isOwned = _out317;
                      isErased = _out318;
                      readIdents = _out319;
                    }
                  }
                } else if (_source32.is_Set) {
                  DAST._IType _701___mcc_h260 = _source32.dtor_element;
                  DAST._IType _702_b = _649___mcc_h226;
                  {
                    if (object.Equals(_702_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _703_recursiveGen;
                      bool _704_recOwned;
                      bool _705_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _706_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out320;
                      bool _out321;
                      bool _out322;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out320, out _out321, out _out322, out _out323);
                      _703_recursiveGen = _out320;
                      _704_recOwned = _out321;
                      _705_recErased = _out322;
                      _706_recIdents = _out323;
                      Dafny.ISequence<Dafny.Rune> _707_uneraseFn;
                      _707_uneraseFn = ((_704_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _707_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _704_recOwned;
                      isErased = true;
                      readIdents = _706_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out324;
                      bool _out325;
                      bool _out326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _702_b), _702_b, _479_toTpe), selfIdent, @params, mustOwn, out _out324, out _out325, out _out326, out _out327);
                      s = _out324;
                      isOwned = _out325;
                      isErased = _out326;
                      readIdents = _out327;
                    }
                  }
                } else if (_source32.is_Multiset) {
                  DAST._IType _708___mcc_h263 = _source32.dtor_element;
                  DAST._IType _709_b = _649___mcc_h226;
                  {
                    if (object.Equals(_709_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _710_recursiveGen;
                      bool _711_recOwned;
                      bool _712_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _713_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out328;
                      bool _out329;
                      bool _out330;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out328, out _out329, out _out330, out _out331);
                      _710_recursiveGen = _out328;
                      _711_recOwned = _out329;
                      _712_recErased = _out330;
                      _713_recIdents = _out331;
                      Dafny.ISequence<Dafny.Rune> _714_uneraseFn;
                      _714_uneraseFn = ((_711_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _714_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _710_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _711_recOwned;
                      isErased = true;
                      readIdents = _713_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out332;
                      bool _out333;
                      bool _out334;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _709_b), _709_b, _479_toTpe), selfIdent, @params, mustOwn, out _out332, out _out333, out _out334, out _out335);
                      s = _out332;
                      isOwned = _out333;
                      isErased = _out334;
                      readIdents = _out335;
                    }
                  }
                } else if (_source32.is_Map) {
                  DAST._IType _715___mcc_h266 = _source32.dtor_key;
                  DAST._IType _716___mcc_h267 = _source32.dtor_value;
                  DAST._IType _717_b = _649___mcc_h226;
                  {
                    if (object.Equals(_717_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _718_recursiveGen;
                      bool _719_recOwned;
                      bool _720_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _721_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out336;
                      bool _out337;
                      bool _out338;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out336, out _out337, out _out338, out _out339);
                      _718_recursiveGen = _out336;
                      _719_recOwned = _out337;
                      _720_recErased = _out338;
                      _721_recIdents = _out339;
                      Dafny.ISequence<Dafny.Rune> _722_uneraseFn;
                      _722_uneraseFn = ((_719_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _722_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _718_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _719_recOwned;
                      isErased = true;
                      readIdents = _721_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out340;
                      bool _out341;
                      bool _out342;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _717_b), _717_b, _479_toTpe), selfIdent, @params, mustOwn, out _out340, out _out341, out _out342, out _out343);
                      s = _out340;
                      isOwned = _out341;
                      isErased = _out342;
                      readIdents = _out343;
                    }
                  }
                } else if (_source32.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _723___mcc_h272 = _source32.dtor_args;
                  DAST._IType _724___mcc_h273 = _source32.dtor_result;
                  DAST._IType _725_b = _649___mcc_h226;
                  {
                    if (object.Equals(_725_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _726_recursiveGen;
                      bool _727_recOwned;
                      bool _728_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _729_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out344;
                      bool _out345;
                      bool _out346;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out344, out _out345, out _out346, out _out347);
                      _726_recursiveGen = _out344;
                      _727_recOwned = _out345;
                      _728_recErased = _out346;
                      _729_recIdents = _out347;
                      Dafny.ISequence<Dafny.Rune> _730_uneraseFn;
                      _730_uneraseFn = ((_727_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _730_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _726_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _727_recOwned;
                      isErased = true;
                      readIdents = _729_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out348;
                      bool _out349;
                      bool _out350;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _725_b), _725_b, _479_toTpe), selfIdent, @params, mustOwn, out _out348, out _out349, out _out350, out _out351);
                      s = _out348;
                      isOwned = _out349;
                      isErased = _out350;
                      readIdents = _out351;
                    }
                  }
                } else if (_source32.is_Primitive) {
                  DAST._IPrimitive _731___mcc_h278 = _source32.dtor_Primitive_a0;
                  DAST._IType _732_b = _649___mcc_h226;
                  {
                    if (object.Equals(_732_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _733_recursiveGen;
                      bool _734_recOwned;
                      bool _735_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _736_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out352;
                      bool _out353;
                      bool _out354;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out352, out _out353, out _out354, out _out355);
                      _733_recursiveGen = _out352;
                      _734_recOwned = _out353;
                      _735_recErased = _out354;
                      _736_recIdents = _out355;
                      Dafny.ISequence<Dafny.Rune> _737_uneraseFn;
                      _737_uneraseFn = ((_734_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _737_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _733_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _734_recOwned;
                      isErased = true;
                      readIdents = _736_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out356;
                      bool _out357;
                      bool _out358;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out359;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _732_b), _732_b, _479_toTpe), selfIdent, @params, mustOwn, out _out356, out _out357, out _out358, out _out359);
                      s = _out356;
                      isOwned = _out357;
                      isErased = _out358;
                      readIdents = _out359;
                    }
                  }
                } else if (_source32.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _738___mcc_h281 = _source32.dtor_Passthrough_a0;
                  DAST._IType _739_b = _649___mcc_h226;
                  {
                    if (object.Equals(_739_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _740_recursiveGen;
                      bool _741_recOwned;
                      bool _742_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _743_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out360;
                      bool _out361;
                      bool _out362;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out363;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out360, out _out361, out _out362, out _out363);
                      _740_recursiveGen = _out360;
                      _741_recOwned = _out361;
                      _742_recErased = _out362;
                      _743_recIdents = _out363;
                      Dafny.ISequence<Dafny.Rune> _744_uneraseFn;
                      _744_uneraseFn = ((_741_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _744_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _740_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _741_recOwned;
                      isErased = true;
                      readIdents = _743_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out364;
                      bool _out365;
                      bool _out366;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out367;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _739_b), _739_b, _479_toTpe), selfIdent, @params, mustOwn, out _out364, out _out365, out _out366, out _out367);
                      s = _out364;
                      isOwned = _out365;
                      isErased = _out366;
                      readIdents = _out367;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _745___mcc_h284 = _source32.dtor_TypeArg_a0;
                  DAST._IType _746_b = _649___mcc_h226;
                  {
                    if (object.Equals(_746_b, _479_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _747_recursiveGen;
                      bool _748_recOwned;
                      bool _749_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _750_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out368;
                      bool _out369;
                      bool _out370;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out371;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out368, out _out369, out _out370, out _out371);
                      _747_recursiveGen = _out368;
                      _748_recOwned = _out369;
                      _749_recErased = _out370;
                      _750_recIdents = _out371;
                      Dafny.ISequence<Dafny.Rune> _751_uneraseFn;
                      _751_uneraseFn = ((_748_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _751_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _747_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _748_recOwned;
                      isErased = true;
                      readIdents = _750_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out372;
                      bool _out373;
                      bool _out374;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out375;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _746_b), _746_b, _479_toTpe), selfIdent, @params, mustOwn, out _out372, out _out373, out _out374, out _out375);
                      s = _out372;
                      isOwned = _out373;
                      isErased = _out374;
                      readIdents = _out375;
                    }
                  }
                }
              }
            } else if (_source26.is_Nullable) {
              DAST._IType _752___mcc_h287 = _source26.dtor_Nullable_a0;
              DAST._IType _source34 = _487___mcc_h127;
              if (_source34.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _753___mcc_h291 = _source34.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _754___mcc_h292 = _source34.dtor_typeArgs;
                DAST._IResolvedType _755___mcc_h293 = _source34.dtor_resolved;
                DAST._IResolvedType _source35 = _755___mcc_h293;
                if (_source35.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _756___mcc_h300 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _757_recursiveGen;
                    bool _758_recOwned;
                    bool _759_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _760_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out376;
                    bool _out377;
                    bool _out378;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out379;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out376, out _out377, out _out378, out _out379);
                    _757_recursiveGen = _out376;
                    _758_recOwned = _out377;
                    _759_recErased = _out378;
                    _760_recIdents = _out379;
                    if (!(_758_recOwned)) {
                      _757_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_757_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_757_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _758_recOwned;
                    isErased = _759_recErased;
                    readIdents = _760_recIdents;
                  }
                } else if (_source35.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _761___mcc_h303 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _762_recursiveGen;
                    bool _763_recOwned;
                    bool _764_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _765_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out380;
                    bool _out381;
                    bool _out382;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out383;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out380, out _out381, out _out382, out _out383);
                    _762_recursiveGen = _out380;
                    _763_recOwned = _out381;
                    _764_recErased = _out382;
                    _765_recIdents = _out383;
                    if (!(_763_recOwned)) {
                      _762_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_762_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_762_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _763_recOwned;
                    isErased = _764_recErased;
                    readIdents = _765_recIdents;
                  }
                } else {
                  DAST._IType _766___mcc_h306 = _source35.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _767_recursiveGen;
                    bool _768_recOwned;
                    bool _769_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _770_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out384;
                    bool _out385;
                    bool _out386;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out387;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out384, out _out385, out _out386, out _out387);
                    _767_recursiveGen = _out384;
                    _768_recOwned = _out385;
                    _769_recErased = _out386;
                    _770_recIdents = _out387;
                    if (!(_768_recOwned)) {
                      _767_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_767_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_767_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _768_recOwned;
                    isErased = _769_recErased;
                    readIdents = _770_recIdents;
                  }
                }
              } else if (_source34.is_Nullable) {
                DAST._IType _771___mcc_h309 = _source34.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _772_recursiveGen;
                  bool _773_recOwned;
                  bool _774_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _775_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out388;
                  bool _out389;
                  bool _out390;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out391;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out388, out _out389, out _out390, out _out391);
                  _772_recursiveGen = _out388;
                  _773_recOwned = _out389;
                  _774_recErased = _out390;
                  _775_recIdents = _out391;
                  if (!(_773_recOwned)) {
                    _772_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_772_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_772_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _773_recOwned;
                  isErased = _774_recErased;
                  readIdents = _775_recIdents;
                }
              } else if (_source34.is_Tuple) {
                Dafny.ISequence<DAST._IType> _776___mcc_h312 = _source34.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _777_recursiveGen;
                  bool _778_recOwned;
                  bool _779_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _780_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out392;
                  bool _out393;
                  bool _out394;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out395;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out392, out _out393, out _out394, out _out395);
                  _777_recursiveGen = _out392;
                  _778_recOwned = _out393;
                  _779_recErased = _out394;
                  _780_recIdents = _out395;
                  if (!(_778_recOwned)) {
                    _777_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_777_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_777_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _778_recOwned;
                  isErased = _779_recErased;
                  readIdents = _780_recIdents;
                }
              } else if (_source34.is_Array) {
                DAST._IType _781___mcc_h315 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _782_recursiveGen;
                  bool _783_recOwned;
                  bool _784_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _785_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out396;
                  bool _out397;
                  bool _out398;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out399;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out396, out _out397, out _out398, out _out399);
                  _782_recursiveGen = _out396;
                  _783_recOwned = _out397;
                  _784_recErased = _out398;
                  _785_recIdents = _out399;
                  if (!(_783_recOwned)) {
                    _782_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_782_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_782_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _783_recOwned;
                  isErased = _784_recErased;
                  readIdents = _785_recIdents;
                }
              } else if (_source34.is_Seq) {
                DAST._IType _786___mcc_h318 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _787_recursiveGen;
                  bool _788_recOwned;
                  bool _789_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _790_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out400;
                  bool _out401;
                  bool _out402;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out403;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out400, out _out401, out _out402, out _out403);
                  _787_recursiveGen = _out400;
                  _788_recOwned = _out401;
                  _789_recErased = _out402;
                  _790_recIdents = _out403;
                  if (!(_788_recOwned)) {
                    _787_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_787_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_787_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _788_recOwned;
                  isErased = _789_recErased;
                  readIdents = _790_recIdents;
                }
              } else if (_source34.is_Set) {
                DAST._IType _791___mcc_h321 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _792_recursiveGen;
                  bool _793_recOwned;
                  bool _794_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _795_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out404;
                  bool _out405;
                  bool _out406;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out407;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out404, out _out405, out _out406, out _out407);
                  _792_recursiveGen = _out404;
                  _793_recOwned = _out405;
                  _794_recErased = _out406;
                  _795_recIdents = _out407;
                  if (!(_793_recOwned)) {
                    _792_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_792_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_792_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _793_recOwned;
                  isErased = _794_recErased;
                  readIdents = _795_recIdents;
                }
              } else if (_source34.is_Multiset) {
                DAST._IType _796___mcc_h324 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _797_recursiveGen;
                  bool _798_recOwned;
                  bool _799_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _800_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out408;
                  bool _out409;
                  bool _out410;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out411;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out408, out _out409, out _out410, out _out411);
                  _797_recursiveGen = _out408;
                  _798_recOwned = _out409;
                  _799_recErased = _out410;
                  _800_recIdents = _out411;
                  if (!(_798_recOwned)) {
                    _797_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_797_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_797_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _798_recOwned;
                  isErased = _799_recErased;
                  readIdents = _800_recIdents;
                }
              } else if (_source34.is_Map) {
                DAST._IType _801___mcc_h327 = _source34.dtor_key;
                DAST._IType _802___mcc_h328 = _source34.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _803_recursiveGen;
                  bool _804_recOwned;
                  bool _805_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _806_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out412;
                  bool _out413;
                  bool _out414;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out415;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out412, out _out413, out _out414, out _out415);
                  _803_recursiveGen = _out412;
                  _804_recOwned = _out413;
                  _805_recErased = _out414;
                  _806_recIdents = _out415;
                  if (!(_804_recOwned)) {
                    _803_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_803_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_803_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _804_recOwned;
                  isErased = _805_recErased;
                  readIdents = _806_recIdents;
                }
              } else if (_source34.is_Arrow) {
                Dafny.ISequence<DAST._IType> _807___mcc_h333 = _source34.dtor_args;
                DAST._IType _808___mcc_h334 = _source34.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _809_recursiveGen;
                  bool _810_recOwned;
                  bool _811_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _812_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out416;
                  bool _out417;
                  bool _out418;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out419;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out416, out _out417, out _out418, out _out419);
                  _809_recursiveGen = _out416;
                  _810_recOwned = _out417;
                  _811_recErased = _out418;
                  _812_recIdents = _out419;
                  if (!(_810_recOwned)) {
                    _809_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_809_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_809_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _810_recOwned;
                  isErased = _811_recErased;
                  readIdents = _812_recIdents;
                }
              } else if (_source34.is_Primitive) {
                DAST._IPrimitive _813___mcc_h339 = _source34.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _814_recursiveGen;
                  bool _815_recOwned;
                  bool _816_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _817_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out420;
                  bool _out421;
                  bool _out422;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out423;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out420, out _out421, out _out422, out _out423);
                  _814_recursiveGen = _out420;
                  _815_recOwned = _out421;
                  _816_recErased = _out422;
                  _817_recIdents = _out423;
                  if (!(_815_recOwned)) {
                    _814_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_814_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_814_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _815_recOwned;
                  isErased = _816_recErased;
                  readIdents = _817_recIdents;
                }
              } else if (_source34.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _818___mcc_h342 = _source34.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _819_recursiveGen;
                  bool _820_recOwned;
                  bool _821_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _822_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out424;
                  bool _out425;
                  bool _out426;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out427;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out424, out _out425, out _out426, out _out427);
                  _819_recursiveGen = _out424;
                  _820_recOwned = _out425;
                  _821_recErased = _out426;
                  _822_recIdents = _out427;
                  if (!(_820_recOwned)) {
                    _819_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_819_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_819_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _820_recOwned;
                  isErased = _821_recErased;
                  readIdents = _822_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _823___mcc_h345 = _source34.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _824_recursiveGen;
                  bool _825_recOwned;
                  bool _826_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _827_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out428;
                  bool _out429;
                  bool _out430;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out431;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out428, out _out429, out _out430, out _out431);
                  _824_recursiveGen = _out428;
                  _825_recOwned = _out429;
                  _826_recErased = _out430;
                  _827_recIdents = _out431;
                  if (!(_825_recOwned)) {
                    _824_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_824_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_824_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _825_recOwned;
                  isErased = _826_recErased;
                  readIdents = _827_recIdents;
                }
              }
            } else if (_source26.is_Tuple) {
              Dafny.ISequence<DAST._IType> _828___mcc_h348 = _source26.dtor_Tuple_a0;
              DAST._IType _source36 = _487___mcc_h127;
              if (_source36.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _829___mcc_h352 = _source36.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _830___mcc_h353 = _source36.dtor_typeArgs;
                DAST._IResolvedType _831___mcc_h354 = _source36.dtor_resolved;
                DAST._IResolvedType _source37 = _831___mcc_h354;
                if (_source37.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _832___mcc_h358 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _833_recursiveGen;
                    bool _834_recOwned;
                    bool _835_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _836_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out432;
                    bool _out433;
                    bool _out434;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out435;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out432, out _out433, out _out434, out _out435);
                    _833_recursiveGen = _out432;
                    _834_recOwned = _out433;
                    _835_recErased = _out434;
                    _836_recIdents = _out435;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _833_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _834_recOwned;
                    isErased = _835_recErased;
                    readIdents = _836_recIdents;
                  }
                } else if (_source37.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _837___mcc_h360 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _838_recursiveGen;
                    bool _839_recOwned;
                    bool _840_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _841_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out436;
                    bool _out437;
                    bool _out438;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out439;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out436, out _out437, out _out438, out _out439);
                    _838_recursiveGen = _out436;
                    _839_recOwned = _out437;
                    _840_recErased = _out438;
                    _841_recIdents = _out439;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _838_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _839_recOwned;
                    isErased = _840_recErased;
                    readIdents = _841_recIdents;
                  }
                } else {
                  DAST._IType _842___mcc_h362 = _source37.dtor_Newtype_a0;
                  DAST._IType _843_b = _842___mcc_h362;
                  {
                    if (object.Equals(_480_fromTpe, _843_b)) {
                      Dafny.ISequence<Dafny.Rune> _844_recursiveGen;
                      bool _845_recOwned;
                      bool _846_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _847_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out440;
                      bool _out441;
                      bool _out442;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out443;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out440, out _out441, out _out442, out _out443);
                      _844_recursiveGen = _out440;
                      _845_recOwned = _out441;
                      _846_recErased = _out442;
                      _847_recIdents = _out443;
                      Dafny.ISequence<Dafny.Rune> _848_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out444;
                      _out444 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _848_rhsType = _out444;
                      Dafny.ISequence<Dafny.Rune> _849_uneraseFn;
                      _849_uneraseFn = ((_845_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _848_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _849_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _844_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _845_recOwned;
                      isErased = false;
                      readIdents = _847_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out445;
                      bool _out446;
                      bool _out447;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out448;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _843_b), _843_b, _479_toTpe), selfIdent, @params, mustOwn, out _out445, out _out446, out _out447, out _out448);
                      s = _out445;
                      isOwned = _out446;
                      isErased = _out447;
                      readIdents = _out448;
                    }
                  }
                }
              } else if (_source36.is_Nullable) {
                DAST._IType _850___mcc_h364 = _source36.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _851_recursiveGen;
                  bool _852_recOwned;
                  bool _853_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _854_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out449;
                  bool _out450;
                  bool _out451;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out452;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out449, out _out450, out _out451, out _out452);
                  _851_recursiveGen = _out449;
                  _852_recOwned = _out450;
                  _853_recErased = _out451;
                  _854_recIdents = _out452;
                  if (!(_852_recOwned)) {
                    _851_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_851_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _851_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _853_recErased;
                  readIdents = _854_recIdents;
                }
              } else if (_source36.is_Tuple) {
                Dafny.ISequence<DAST._IType> _855___mcc_h366 = _source36.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _856_recursiveGen;
                  bool _857_recOwned;
                  bool _858_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _859_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out453;
                  bool _out454;
                  bool _out455;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out456;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out453, out _out454, out _out455, out _out456);
                  _856_recursiveGen = _out453;
                  _857_recOwned = _out454;
                  _858_recErased = _out455;
                  _859_recIdents = _out456;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _856_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _857_recOwned;
                  isErased = _858_recErased;
                  readIdents = _859_recIdents;
                }
              } else if (_source36.is_Array) {
                DAST._IType _860___mcc_h368 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _861_recursiveGen;
                  bool _862_recOwned;
                  bool _863_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _864_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out457;
                  bool _out458;
                  bool _out459;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out460;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out457, out _out458, out _out459, out _out460);
                  _861_recursiveGen = _out457;
                  _862_recOwned = _out458;
                  _863_recErased = _out459;
                  _864_recIdents = _out460;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _861_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _862_recOwned;
                  isErased = _863_recErased;
                  readIdents = _864_recIdents;
                }
              } else if (_source36.is_Seq) {
                DAST._IType _865___mcc_h370 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _866_recursiveGen;
                  bool _867_recOwned;
                  bool _868_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _869_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out461;
                  bool _out462;
                  bool _out463;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out464;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out461, out _out462, out _out463, out _out464);
                  _866_recursiveGen = _out461;
                  _867_recOwned = _out462;
                  _868_recErased = _out463;
                  _869_recIdents = _out464;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _866_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _867_recOwned;
                  isErased = _868_recErased;
                  readIdents = _869_recIdents;
                }
              } else if (_source36.is_Set) {
                DAST._IType _870___mcc_h372 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _871_recursiveGen;
                  bool _872_recOwned;
                  bool _873_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _874_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out465;
                  bool _out466;
                  bool _out467;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out468;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out465, out _out466, out _out467, out _out468);
                  _871_recursiveGen = _out465;
                  _872_recOwned = _out466;
                  _873_recErased = _out467;
                  _874_recIdents = _out468;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _871_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _872_recOwned;
                  isErased = _873_recErased;
                  readIdents = _874_recIdents;
                }
              } else if (_source36.is_Multiset) {
                DAST._IType _875___mcc_h374 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _876_recursiveGen;
                  bool _877_recOwned;
                  bool _878_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _879_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out469;
                  bool _out470;
                  bool _out471;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out472;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out469, out _out470, out _out471, out _out472);
                  _876_recursiveGen = _out469;
                  _877_recOwned = _out470;
                  _878_recErased = _out471;
                  _879_recIdents = _out472;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _876_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _877_recOwned;
                  isErased = _878_recErased;
                  readIdents = _879_recIdents;
                }
              } else if (_source36.is_Map) {
                DAST._IType _880___mcc_h376 = _source36.dtor_key;
                DAST._IType _881___mcc_h377 = _source36.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _882_recursiveGen;
                  bool _883_recOwned;
                  bool _884_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _885_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out473;
                  bool _out474;
                  bool _out475;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out476;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out473, out _out474, out _out475, out _out476);
                  _882_recursiveGen = _out473;
                  _883_recOwned = _out474;
                  _884_recErased = _out475;
                  _885_recIdents = _out476;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _882_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _883_recOwned;
                  isErased = _884_recErased;
                  readIdents = _885_recIdents;
                }
              } else if (_source36.is_Arrow) {
                Dafny.ISequence<DAST._IType> _886___mcc_h380 = _source36.dtor_args;
                DAST._IType _887___mcc_h381 = _source36.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _888_recursiveGen;
                  bool _889_recOwned;
                  bool _890_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _891_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out477;
                  bool _out478;
                  bool _out479;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out480;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out477, out _out478, out _out479, out _out480);
                  _888_recursiveGen = _out477;
                  _889_recOwned = _out478;
                  _890_recErased = _out479;
                  _891_recIdents = _out480;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _888_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _889_recOwned;
                  isErased = _890_recErased;
                  readIdents = _891_recIdents;
                }
              } else if (_source36.is_Primitive) {
                DAST._IPrimitive _892___mcc_h384 = _source36.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _893_recursiveGen;
                  bool _894_recOwned;
                  bool _895_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _896_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out481;
                  bool _out482;
                  bool _out483;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out484;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out481, out _out482, out _out483, out _out484);
                  _893_recursiveGen = _out481;
                  _894_recOwned = _out482;
                  _895_recErased = _out483;
                  _896_recIdents = _out484;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _893_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _894_recOwned;
                  isErased = _895_recErased;
                  readIdents = _896_recIdents;
                }
              } else if (_source36.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _897___mcc_h386 = _source36.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _898_recursiveGen;
                  bool _899_recOwned;
                  bool _900_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _901_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out485;
                  bool _out486;
                  bool _out487;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out488;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out485, out _out486, out _out487, out _out488);
                  _898_recursiveGen = _out485;
                  _899_recOwned = _out486;
                  _900_recErased = _out487;
                  _901_recIdents = _out488;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _898_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _899_recOwned;
                  isErased = _900_recErased;
                  readIdents = _901_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _902___mcc_h388 = _source36.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _903_recursiveGen;
                  bool _904_recOwned;
                  bool _905_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _906_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out489;
                  bool _out490;
                  bool _out491;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out492;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out489, out _out490, out _out491, out _out492);
                  _903_recursiveGen = _out489;
                  _904_recOwned = _out490;
                  _905_recErased = _out491;
                  _906_recIdents = _out492;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _903_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _904_recOwned;
                  isErased = _905_recErased;
                  readIdents = _906_recIdents;
                }
              }
            } else if (_source26.is_Array) {
              DAST._IType _907___mcc_h390 = _source26.dtor_element;
              DAST._IType _source38 = _487___mcc_h127;
              if (_source38.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _908___mcc_h394 = _source38.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _909___mcc_h395 = _source38.dtor_typeArgs;
                DAST._IResolvedType _910___mcc_h396 = _source38.dtor_resolved;
                DAST._IResolvedType _source39 = _910___mcc_h396;
                if (_source39.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _911___mcc_h400 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _912_recursiveGen;
                    bool _913_recOwned;
                    bool _914_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _915_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out493;
                    bool _out494;
                    bool _out495;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out496;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out493, out _out494, out _out495, out _out496);
                    _912_recursiveGen = _out493;
                    _913_recOwned = _out494;
                    _914_recErased = _out495;
                    _915_recIdents = _out496;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _912_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _913_recOwned;
                    isErased = _914_recErased;
                    readIdents = _915_recIdents;
                  }
                } else if (_source39.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _916___mcc_h402 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _917_recursiveGen;
                    bool _918_recOwned;
                    bool _919_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _920_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out497;
                    bool _out498;
                    bool _out499;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out500;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out497, out _out498, out _out499, out _out500);
                    _917_recursiveGen = _out497;
                    _918_recOwned = _out498;
                    _919_recErased = _out499;
                    _920_recIdents = _out500;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _917_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _918_recOwned;
                    isErased = _919_recErased;
                    readIdents = _920_recIdents;
                  }
                } else {
                  DAST._IType _921___mcc_h404 = _source39.dtor_Newtype_a0;
                  DAST._IType _922_b = _921___mcc_h404;
                  {
                    if (object.Equals(_480_fromTpe, _922_b)) {
                      Dafny.ISequence<Dafny.Rune> _923_recursiveGen;
                      bool _924_recOwned;
                      bool _925_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _926_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out501;
                      bool _out502;
                      bool _out503;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out504;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out501, out _out502, out _out503, out _out504);
                      _923_recursiveGen = _out501;
                      _924_recOwned = _out502;
                      _925_recErased = _out503;
                      _926_recIdents = _out504;
                      Dafny.ISequence<Dafny.Rune> _927_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out505;
                      _out505 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _927_rhsType = _out505;
                      Dafny.ISequence<Dafny.Rune> _928_uneraseFn;
                      _928_uneraseFn = ((_924_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _927_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _928_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _923_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _924_recOwned;
                      isErased = false;
                      readIdents = _926_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out506;
                      bool _out507;
                      bool _out508;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out509;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _922_b), _922_b, _479_toTpe), selfIdent, @params, mustOwn, out _out506, out _out507, out _out508, out _out509);
                      s = _out506;
                      isOwned = _out507;
                      isErased = _out508;
                      readIdents = _out509;
                    }
                  }
                }
              } else if (_source38.is_Nullable) {
                DAST._IType _929___mcc_h406 = _source38.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _930_recursiveGen;
                  bool _931_recOwned;
                  bool _932_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _933_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out510;
                  bool _out511;
                  bool _out512;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out513;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out510, out _out511, out _out512, out _out513);
                  _930_recursiveGen = _out510;
                  _931_recOwned = _out511;
                  _932_recErased = _out512;
                  _933_recIdents = _out513;
                  if (!(_931_recOwned)) {
                    _930_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_930_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _932_recErased;
                  readIdents = _933_recIdents;
                }
              } else if (_source38.is_Tuple) {
                Dafny.ISequence<DAST._IType> _934___mcc_h408 = _source38.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _935_recursiveGen;
                  bool _936_recOwned;
                  bool _937_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _938_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out514;
                  bool _out515;
                  bool _out516;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out517;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out514, out _out515, out _out516, out _out517);
                  _935_recursiveGen = _out514;
                  _936_recOwned = _out515;
                  _937_recErased = _out516;
                  _938_recIdents = _out517;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _935_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _936_recOwned;
                  isErased = _937_recErased;
                  readIdents = _938_recIdents;
                }
              } else if (_source38.is_Array) {
                DAST._IType _939___mcc_h410 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _940_recursiveGen;
                  bool _941_recOwned;
                  bool _942_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _943_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out518;
                  bool _out519;
                  bool _out520;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out521;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out518, out _out519, out _out520, out _out521);
                  _940_recursiveGen = _out518;
                  _941_recOwned = _out519;
                  _942_recErased = _out520;
                  _943_recIdents = _out521;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _940_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _941_recOwned;
                  isErased = _942_recErased;
                  readIdents = _943_recIdents;
                }
              } else if (_source38.is_Seq) {
                DAST._IType _944___mcc_h412 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _945_recursiveGen;
                  bool _946_recOwned;
                  bool _947_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _948_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out522;
                  bool _out523;
                  bool _out524;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out525;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out522, out _out523, out _out524, out _out525);
                  _945_recursiveGen = _out522;
                  _946_recOwned = _out523;
                  _947_recErased = _out524;
                  _948_recIdents = _out525;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _945_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _946_recOwned;
                  isErased = _947_recErased;
                  readIdents = _948_recIdents;
                }
              } else if (_source38.is_Set) {
                DAST._IType _949___mcc_h414 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _950_recursiveGen;
                  bool _951_recOwned;
                  bool _952_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _953_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out526;
                  bool _out527;
                  bool _out528;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out529;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out526, out _out527, out _out528, out _out529);
                  _950_recursiveGen = _out526;
                  _951_recOwned = _out527;
                  _952_recErased = _out528;
                  _953_recIdents = _out529;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _950_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _951_recOwned;
                  isErased = _952_recErased;
                  readIdents = _953_recIdents;
                }
              } else if (_source38.is_Multiset) {
                DAST._IType _954___mcc_h416 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _955_recursiveGen;
                  bool _956_recOwned;
                  bool _957_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _958_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out530;
                  bool _out531;
                  bool _out532;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out533;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out530, out _out531, out _out532, out _out533);
                  _955_recursiveGen = _out530;
                  _956_recOwned = _out531;
                  _957_recErased = _out532;
                  _958_recIdents = _out533;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _955_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _956_recOwned;
                  isErased = _957_recErased;
                  readIdents = _958_recIdents;
                }
              } else if (_source38.is_Map) {
                DAST._IType _959___mcc_h418 = _source38.dtor_key;
                DAST._IType _960___mcc_h419 = _source38.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _961_recursiveGen;
                  bool _962_recOwned;
                  bool _963_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _964_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out534;
                  bool _out535;
                  bool _out536;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out537;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out534, out _out535, out _out536, out _out537);
                  _961_recursiveGen = _out534;
                  _962_recOwned = _out535;
                  _963_recErased = _out536;
                  _964_recIdents = _out537;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _961_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _962_recOwned;
                  isErased = _963_recErased;
                  readIdents = _964_recIdents;
                }
              } else if (_source38.is_Arrow) {
                Dafny.ISequence<DAST._IType> _965___mcc_h422 = _source38.dtor_args;
                DAST._IType _966___mcc_h423 = _source38.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _967_recursiveGen;
                  bool _968_recOwned;
                  bool _969_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _970_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out538;
                  bool _out539;
                  bool _out540;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out541;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out538, out _out539, out _out540, out _out541);
                  _967_recursiveGen = _out538;
                  _968_recOwned = _out539;
                  _969_recErased = _out540;
                  _970_recIdents = _out541;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _967_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _968_recOwned;
                  isErased = _969_recErased;
                  readIdents = _970_recIdents;
                }
              } else if (_source38.is_Primitive) {
                DAST._IPrimitive _971___mcc_h426 = _source38.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _972_recursiveGen;
                  bool _973_recOwned;
                  bool _974_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _975_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out542;
                  bool _out543;
                  bool _out544;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out545;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out542, out _out543, out _out544, out _out545);
                  _972_recursiveGen = _out542;
                  _973_recOwned = _out543;
                  _974_recErased = _out544;
                  _975_recIdents = _out545;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _972_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _973_recOwned;
                  isErased = _974_recErased;
                  readIdents = _975_recIdents;
                }
              } else if (_source38.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _976___mcc_h428 = _source38.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _977_recursiveGen;
                  bool _978_recOwned;
                  bool _979_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _980_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out546;
                  bool _out547;
                  bool _out548;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out549;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out546, out _out547, out _out548, out _out549);
                  _977_recursiveGen = _out546;
                  _978_recOwned = _out547;
                  _979_recErased = _out548;
                  _980_recIdents = _out549;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _977_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _978_recOwned;
                  isErased = _979_recErased;
                  readIdents = _980_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _981___mcc_h430 = _source38.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _982_recursiveGen;
                  bool _983_recOwned;
                  bool _984_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _985_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out550;
                  bool _out551;
                  bool _out552;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out553;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out550, out _out551, out _out552, out _out553);
                  _982_recursiveGen = _out550;
                  _983_recOwned = _out551;
                  _984_recErased = _out552;
                  _985_recIdents = _out553;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _982_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _983_recOwned;
                  isErased = _984_recErased;
                  readIdents = _985_recIdents;
                }
              }
            } else if (_source26.is_Seq) {
              DAST._IType _986___mcc_h432 = _source26.dtor_element;
              DAST._IType _source40 = _487___mcc_h127;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _987___mcc_h436 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _988___mcc_h437 = _source40.dtor_typeArgs;
                DAST._IResolvedType _989___mcc_h438 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _989___mcc_h438;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _990___mcc_h442 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _991_recursiveGen;
                    bool _992_recOwned;
                    bool _993_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _994_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out554;
                    bool _out555;
                    bool _out556;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out557;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out554, out _out555, out _out556, out _out557);
                    _991_recursiveGen = _out554;
                    _992_recOwned = _out555;
                    _993_recErased = _out556;
                    _994_recIdents = _out557;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _991_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _992_recOwned;
                    isErased = _993_recErased;
                    readIdents = _994_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _995___mcc_h444 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _996_recursiveGen;
                    bool _997_recOwned;
                    bool _998_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _999_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out558;
                    bool _out559;
                    bool _out560;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out561;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out558, out _out559, out _out560, out _out561);
                    _996_recursiveGen = _out558;
                    _997_recOwned = _out559;
                    _998_recErased = _out560;
                    _999_recIdents = _out561;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _996_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _997_recOwned;
                    isErased = _998_recErased;
                    readIdents = _999_recIdents;
                  }
                } else {
                  DAST._IType _1000___mcc_h446 = _source41.dtor_Newtype_a0;
                  DAST._IType _1001_b = _1000___mcc_h446;
                  {
                    if (object.Equals(_480_fromTpe, _1001_b)) {
                      Dafny.ISequence<Dafny.Rune> _1002_recursiveGen;
                      bool _1003_recOwned;
                      bool _1004_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1005_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out562;
                      bool _out563;
                      bool _out564;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out565;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out562, out _out563, out _out564, out _out565);
                      _1002_recursiveGen = _out562;
                      _1003_recOwned = _out563;
                      _1004_recErased = _out564;
                      _1005_recIdents = _out565;
                      Dafny.ISequence<Dafny.Rune> _1006_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out566;
                      _out566 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _1006_rhsType = _out566;
                      Dafny.ISequence<Dafny.Rune> _1007_uneraseFn;
                      _1007_uneraseFn = ((_1003_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1006_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1007_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1002_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1003_recOwned;
                      isErased = false;
                      readIdents = _1005_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out567;
                      bool _out568;
                      bool _out569;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out570;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1001_b), _1001_b, _479_toTpe), selfIdent, @params, mustOwn, out _out567, out _out568, out _out569, out _out570);
                      s = _out567;
                      isOwned = _out568;
                      isErased = _out569;
                      readIdents = _out570;
                    }
                  }
                }
              } else if (_source40.is_Nullable) {
                DAST._IType _1008___mcc_h448 = _source40.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1009_recursiveGen;
                  bool _1010_recOwned;
                  bool _1011_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1012_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out571;
                  bool _out572;
                  bool _out573;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out574;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out571, out _out572, out _out573, out _out574);
                  _1009_recursiveGen = _out571;
                  _1010_recOwned = _out572;
                  _1011_recErased = _out573;
                  _1012_recIdents = _out574;
                  if (!(_1010_recOwned)) {
                    _1009_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1009_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1011_recErased;
                  readIdents = _1012_recIdents;
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1013___mcc_h450 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1014_recursiveGen;
                  bool _1015_recOwned;
                  bool _1016_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1017_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out575;
                  bool _out576;
                  bool _out577;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out578;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out575, out _out576, out _out577, out _out578);
                  _1014_recursiveGen = _out575;
                  _1015_recOwned = _out576;
                  _1016_recErased = _out577;
                  _1017_recIdents = _out578;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1014_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1015_recOwned;
                  isErased = _1016_recErased;
                  readIdents = _1017_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _1018___mcc_h452 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1019_recursiveGen;
                  bool _1020_recOwned;
                  bool _1021_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1022_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out579;
                  bool _out580;
                  bool _out581;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out582;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out579, out _out580, out _out581, out _out582);
                  _1019_recursiveGen = _out579;
                  _1020_recOwned = _out580;
                  _1021_recErased = _out581;
                  _1022_recIdents = _out582;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1019_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1020_recOwned;
                  isErased = _1021_recErased;
                  readIdents = _1022_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _1023___mcc_h454 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1024_recursiveGen;
                  bool _1025_recOwned;
                  bool _1026_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1027_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out583;
                  bool _out584;
                  bool _out585;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out586;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out583, out _out584, out _out585, out _out586);
                  _1024_recursiveGen = _out583;
                  _1025_recOwned = _out584;
                  _1026_recErased = _out585;
                  _1027_recIdents = _out586;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1024_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1025_recOwned;
                  isErased = _1026_recErased;
                  readIdents = _1027_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _1028___mcc_h456 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1029_recursiveGen;
                  bool _1030_recOwned;
                  bool _1031_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1032_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out587;
                  bool _out588;
                  bool _out589;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out590;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out587, out _out588, out _out589, out _out590);
                  _1029_recursiveGen = _out587;
                  _1030_recOwned = _out588;
                  _1031_recErased = _out589;
                  _1032_recIdents = _out590;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1029_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1030_recOwned;
                  isErased = _1031_recErased;
                  readIdents = _1032_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _1033___mcc_h458 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1034_recursiveGen;
                  bool _1035_recOwned;
                  bool _1036_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1037_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out591;
                  bool _out592;
                  bool _out593;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out594;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out591, out _out592, out _out593, out _out594);
                  _1034_recursiveGen = _out591;
                  _1035_recOwned = _out592;
                  _1036_recErased = _out593;
                  _1037_recIdents = _out594;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1034_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1035_recOwned;
                  isErased = _1036_recErased;
                  readIdents = _1037_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _1038___mcc_h460 = _source40.dtor_key;
                DAST._IType _1039___mcc_h461 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1040_recursiveGen;
                  bool _1041_recOwned;
                  bool _1042_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1043_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out595;
                  bool _out596;
                  bool _out597;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out598;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out595, out _out596, out _out597, out _out598);
                  _1040_recursiveGen = _out595;
                  _1041_recOwned = _out596;
                  _1042_recErased = _out597;
                  _1043_recIdents = _out598;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1040_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1041_recOwned;
                  isErased = _1042_recErased;
                  readIdents = _1043_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1044___mcc_h464 = _source40.dtor_args;
                DAST._IType _1045___mcc_h465 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1046_recursiveGen;
                  bool _1047_recOwned;
                  bool _1048_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1049_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out599;
                  bool _out600;
                  bool _out601;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out602;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out599, out _out600, out _out601, out _out602);
                  _1046_recursiveGen = _out599;
                  _1047_recOwned = _out600;
                  _1048_recErased = _out601;
                  _1049_recIdents = _out602;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1046_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1047_recOwned;
                  isErased = _1048_recErased;
                  readIdents = _1049_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _1050___mcc_h468 = _source40.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1051_recursiveGen;
                  bool _1052_recOwned;
                  bool _1053_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1054_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out603;
                  bool _out604;
                  bool _out605;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out606;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out603, out _out604, out _out605, out _out606);
                  _1051_recursiveGen = _out603;
                  _1052_recOwned = _out604;
                  _1053_recErased = _out605;
                  _1054_recIdents = _out606;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1051_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1052_recOwned;
                  isErased = _1053_recErased;
                  readIdents = _1054_recIdents;
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1055___mcc_h470 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1056_recursiveGen;
                  bool _1057_recOwned;
                  bool _1058_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1059_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out607;
                  bool _out608;
                  bool _out609;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out610;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out607, out _out608, out _out609, out _out610);
                  _1056_recursiveGen = _out607;
                  _1057_recOwned = _out608;
                  _1058_recErased = _out609;
                  _1059_recIdents = _out610;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1056_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1057_recOwned;
                  isErased = _1058_recErased;
                  readIdents = _1059_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1060___mcc_h472 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1061_recursiveGen;
                  bool _1062_recOwned;
                  bool _1063_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1064_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out611;
                  bool _out612;
                  bool _out613;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out614;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out611, out _out612, out _out613, out _out614);
                  _1061_recursiveGen = _out611;
                  _1062_recOwned = _out612;
                  _1063_recErased = _out613;
                  _1064_recIdents = _out614;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1061_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1062_recOwned;
                  isErased = _1063_recErased;
                  readIdents = _1064_recIdents;
                }
              }
            } else if (_source26.is_Set) {
              DAST._IType _1065___mcc_h474 = _source26.dtor_element;
              DAST._IType _source42 = _487___mcc_h127;
              if (_source42.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1066___mcc_h478 = _source42.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1067___mcc_h479 = _source42.dtor_typeArgs;
                DAST._IResolvedType _1068___mcc_h480 = _source42.dtor_resolved;
                DAST._IResolvedType _source43 = _1068___mcc_h480;
                if (_source43.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1069___mcc_h484 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1070_recursiveGen;
                    bool _1071_recOwned;
                    bool _1072_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1073_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out615;
                    bool _out616;
                    bool _out617;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out618;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out615, out _out616, out _out617, out _out618);
                    _1070_recursiveGen = _out615;
                    _1071_recOwned = _out616;
                    _1072_recErased = _out617;
                    _1073_recIdents = _out618;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1070_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1071_recOwned;
                    isErased = _1072_recErased;
                    readIdents = _1073_recIdents;
                  }
                } else if (_source43.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1074___mcc_h486 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1075_recursiveGen;
                    bool _1076_recOwned;
                    bool _1077_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1078_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out619;
                    bool _out620;
                    bool _out621;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out622;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out619, out _out620, out _out621, out _out622);
                    _1075_recursiveGen = _out619;
                    _1076_recOwned = _out620;
                    _1077_recErased = _out621;
                    _1078_recIdents = _out622;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1075_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1076_recOwned;
                    isErased = _1077_recErased;
                    readIdents = _1078_recIdents;
                  }
                } else {
                  DAST._IType _1079___mcc_h488 = _source43.dtor_Newtype_a0;
                  DAST._IType _1080_b = _1079___mcc_h488;
                  {
                    if (object.Equals(_480_fromTpe, _1080_b)) {
                      Dafny.ISequence<Dafny.Rune> _1081_recursiveGen;
                      bool _1082_recOwned;
                      bool _1083_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1084_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out623;
                      bool _out624;
                      bool _out625;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out626;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out623, out _out624, out _out625, out _out626);
                      _1081_recursiveGen = _out623;
                      _1082_recOwned = _out624;
                      _1083_recErased = _out625;
                      _1084_recIdents = _out626;
                      Dafny.ISequence<Dafny.Rune> _1085_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out627;
                      _out627 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _1085_rhsType = _out627;
                      Dafny.ISequence<Dafny.Rune> _1086_uneraseFn;
                      _1086_uneraseFn = ((_1082_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1085_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1086_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1081_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1082_recOwned;
                      isErased = false;
                      readIdents = _1084_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out628;
                      bool _out629;
                      bool _out630;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out631;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1080_b), _1080_b, _479_toTpe), selfIdent, @params, mustOwn, out _out628, out _out629, out _out630, out _out631);
                      s = _out628;
                      isOwned = _out629;
                      isErased = _out630;
                      readIdents = _out631;
                    }
                  }
                }
              } else if (_source42.is_Nullable) {
                DAST._IType _1087___mcc_h490 = _source42.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1088_recursiveGen;
                  bool _1089_recOwned;
                  bool _1090_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1091_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out632;
                  bool _out633;
                  bool _out634;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out635;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out632, out _out633, out _out634, out _out635);
                  _1088_recursiveGen = _out632;
                  _1089_recOwned = _out633;
                  _1090_recErased = _out634;
                  _1091_recIdents = _out635;
                  if (!(_1089_recOwned)) {
                    _1088_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1088_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1088_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1090_recErased;
                  readIdents = _1091_recIdents;
                }
              } else if (_source42.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1092___mcc_h492 = _source42.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1093_recursiveGen;
                  bool _1094_recOwned;
                  bool _1095_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1096_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out636;
                  bool _out637;
                  bool _out638;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out639;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out636, out _out637, out _out638, out _out639);
                  _1093_recursiveGen = _out636;
                  _1094_recOwned = _out637;
                  _1095_recErased = _out638;
                  _1096_recIdents = _out639;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1093_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1094_recOwned;
                  isErased = _1095_recErased;
                  readIdents = _1096_recIdents;
                }
              } else if (_source42.is_Array) {
                DAST._IType _1097___mcc_h494 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1098_recursiveGen;
                  bool _1099_recOwned;
                  bool _1100_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1101_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out640;
                  bool _out641;
                  bool _out642;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out643;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out640, out _out641, out _out642, out _out643);
                  _1098_recursiveGen = _out640;
                  _1099_recOwned = _out641;
                  _1100_recErased = _out642;
                  _1101_recIdents = _out643;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1098_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1099_recOwned;
                  isErased = _1100_recErased;
                  readIdents = _1101_recIdents;
                }
              } else if (_source42.is_Seq) {
                DAST._IType _1102___mcc_h496 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1103_recursiveGen;
                  bool _1104_recOwned;
                  bool _1105_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1106_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out644;
                  bool _out645;
                  bool _out646;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out647;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out644, out _out645, out _out646, out _out647);
                  _1103_recursiveGen = _out644;
                  _1104_recOwned = _out645;
                  _1105_recErased = _out646;
                  _1106_recIdents = _out647;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1103_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1104_recOwned;
                  isErased = _1105_recErased;
                  readIdents = _1106_recIdents;
                }
              } else if (_source42.is_Set) {
                DAST._IType _1107___mcc_h498 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1108_recursiveGen;
                  bool _1109_recOwned;
                  bool _1110_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1111_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out648;
                  bool _out649;
                  bool _out650;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out651;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out648, out _out649, out _out650, out _out651);
                  _1108_recursiveGen = _out648;
                  _1109_recOwned = _out649;
                  _1110_recErased = _out650;
                  _1111_recIdents = _out651;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1108_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1109_recOwned;
                  isErased = _1110_recErased;
                  readIdents = _1111_recIdents;
                }
              } else if (_source42.is_Multiset) {
                DAST._IType _1112___mcc_h500 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1113_recursiveGen;
                  bool _1114_recOwned;
                  bool _1115_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1116_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out652;
                  bool _out653;
                  bool _out654;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out655;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out652, out _out653, out _out654, out _out655);
                  _1113_recursiveGen = _out652;
                  _1114_recOwned = _out653;
                  _1115_recErased = _out654;
                  _1116_recIdents = _out655;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1113_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1114_recOwned;
                  isErased = _1115_recErased;
                  readIdents = _1116_recIdents;
                }
              } else if (_source42.is_Map) {
                DAST._IType _1117___mcc_h502 = _source42.dtor_key;
                DAST._IType _1118___mcc_h503 = _source42.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1119_recursiveGen;
                  bool _1120_recOwned;
                  bool _1121_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1122_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out656;
                  bool _out657;
                  bool _out658;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out659;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out656, out _out657, out _out658, out _out659);
                  _1119_recursiveGen = _out656;
                  _1120_recOwned = _out657;
                  _1121_recErased = _out658;
                  _1122_recIdents = _out659;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1119_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1120_recOwned;
                  isErased = _1121_recErased;
                  readIdents = _1122_recIdents;
                }
              } else if (_source42.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1123___mcc_h506 = _source42.dtor_args;
                DAST._IType _1124___mcc_h507 = _source42.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1125_recursiveGen;
                  bool _1126_recOwned;
                  bool _1127_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1128_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out660;
                  bool _out661;
                  bool _out662;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out663;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out660, out _out661, out _out662, out _out663);
                  _1125_recursiveGen = _out660;
                  _1126_recOwned = _out661;
                  _1127_recErased = _out662;
                  _1128_recIdents = _out663;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1125_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1126_recOwned;
                  isErased = _1127_recErased;
                  readIdents = _1128_recIdents;
                }
              } else if (_source42.is_Primitive) {
                DAST._IPrimitive _1129___mcc_h510 = _source42.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1130_recursiveGen;
                  bool _1131_recOwned;
                  bool _1132_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1133_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out664;
                  bool _out665;
                  bool _out666;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out667;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out664, out _out665, out _out666, out _out667);
                  _1130_recursiveGen = _out664;
                  _1131_recOwned = _out665;
                  _1132_recErased = _out666;
                  _1133_recIdents = _out667;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1130_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1131_recOwned;
                  isErased = _1132_recErased;
                  readIdents = _1133_recIdents;
                }
              } else if (_source42.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1134___mcc_h512 = _source42.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1135_recursiveGen;
                  bool _1136_recOwned;
                  bool _1137_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1138_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out668;
                  bool _out669;
                  bool _out670;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out671;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out668, out _out669, out _out670, out _out671);
                  _1135_recursiveGen = _out668;
                  _1136_recOwned = _out669;
                  _1137_recErased = _out670;
                  _1138_recIdents = _out671;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1135_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1136_recOwned;
                  isErased = _1137_recErased;
                  readIdents = _1138_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1139___mcc_h514 = _source42.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1140_recursiveGen;
                  bool _1141_recOwned;
                  bool _1142_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1143_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out672;
                  bool _out673;
                  bool _out674;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out675;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out672, out _out673, out _out674, out _out675);
                  _1140_recursiveGen = _out672;
                  _1141_recOwned = _out673;
                  _1142_recErased = _out674;
                  _1143_recIdents = _out675;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1140_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1141_recOwned;
                  isErased = _1142_recErased;
                  readIdents = _1143_recIdents;
                }
              }
            } else if (_source26.is_Multiset) {
              DAST._IType _1144___mcc_h516 = _source26.dtor_element;
              DAST._IType _source44 = _487___mcc_h127;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1145___mcc_h520 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1146___mcc_h521 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1147___mcc_h522 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1147___mcc_h522;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1148___mcc_h526 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1149_recursiveGen;
                    bool _1150_recOwned;
                    bool _1151_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1152_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out676;
                    bool _out677;
                    bool _out678;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out679;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out676, out _out677, out _out678, out _out679);
                    _1149_recursiveGen = _out676;
                    _1150_recOwned = _out677;
                    _1151_recErased = _out678;
                    _1152_recIdents = _out679;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1149_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1150_recOwned;
                    isErased = _1151_recErased;
                    readIdents = _1152_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1153___mcc_h528 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1154_recursiveGen;
                    bool _1155_recOwned;
                    bool _1156_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1157_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out680;
                    bool _out681;
                    bool _out682;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out683;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out680, out _out681, out _out682, out _out683);
                    _1154_recursiveGen = _out680;
                    _1155_recOwned = _out681;
                    _1156_recErased = _out682;
                    _1157_recIdents = _out683;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1154_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1155_recOwned;
                    isErased = _1156_recErased;
                    readIdents = _1157_recIdents;
                  }
                } else {
                  DAST._IType _1158___mcc_h530 = _source45.dtor_Newtype_a0;
                  DAST._IType _1159_b = _1158___mcc_h530;
                  {
                    if (object.Equals(_480_fromTpe, _1159_b)) {
                      Dafny.ISequence<Dafny.Rune> _1160_recursiveGen;
                      bool _1161_recOwned;
                      bool _1162_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1163_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out684;
                      bool _out685;
                      bool _out686;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out687;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out684, out _out685, out _out686, out _out687);
                      _1160_recursiveGen = _out684;
                      _1161_recOwned = _out685;
                      _1162_recErased = _out686;
                      _1163_recIdents = _out687;
                      Dafny.ISequence<Dafny.Rune> _1164_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out688;
                      _out688 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _1164_rhsType = _out688;
                      Dafny.ISequence<Dafny.Rune> _1165_uneraseFn;
                      _1165_uneraseFn = ((_1161_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1164_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1165_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1160_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1161_recOwned;
                      isErased = false;
                      readIdents = _1163_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out689;
                      bool _out690;
                      bool _out691;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out692;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1159_b), _1159_b, _479_toTpe), selfIdent, @params, mustOwn, out _out689, out _out690, out _out691, out _out692);
                      s = _out689;
                      isOwned = _out690;
                      isErased = _out691;
                      readIdents = _out692;
                    }
                  }
                }
              } else if (_source44.is_Nullable) {
                DAST._IType _1166___mcc_h532 = _source44.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1167_recursiveGen;
                  bool _1168_recOwned;
                  bool _1169_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1170_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out693;
                  bool _out694;
                  bool _out695;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out696;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out693, out _out694, out _out695, out _out696);
                  _1167_recursiveGen = _out693;
                  _1168_recOwned = _out694;
                  _1169_recErased = _out695;
                  _1170_recIdents = _out696;
                  if (!(_1168_recOwned)) {
                    _1167_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1167_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1167_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1169_recErased;
                  readIdents = _1170_recIdents;
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1171___mcc_h534 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1172_recursiveGen;
                  bool _1173_recOwned;
                  bool _1174_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1175_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out697;
                  bool _out698;
                  bool _out699;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out700;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out697, out _out698, out _out699, out _out700);
                  _1172_recursiveGen = _out697;
                  _1173_recOwned = _out698;
                  _1174_recErased = _out699;
                  _1175_recIdents = _out700;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1172_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1173_recOwned;
                  isErased = _1174_recErased;
                  readIdents = _1175_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1176___mcc_h536 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1177_recursiveGen;
                  bool _1178_recOwned;
                  bool _1179_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1180_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out701;
                  bool _out702;
                  bool _out703;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out704;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out701, out _out702, out _out703, out _out704);
                  _1177_recursiveGen = _out701;
                  _1178_recOwned = _out702;
                  _1179_recErased = _out703;
                  _1180_recIdents = _out704;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1177_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1178_recOwned;
                  isErased = _1179_recErased;
                  readIdents = _1180_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1181___mcc_h538 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1182_recursiveGen;
                  bool _1183_recOwned;
                  bool _1184_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1185_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out705;
                  bool _out706;
                  bool _out707;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out708;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out705, out _out706, out _out707, out _out708);
                  _1182_recursiveGen = _out705;
                  _1183_recOwned = _out706;
                  _1184_recErased = _out707;
                  _1185_recIdents = _out708;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1182_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1183_recOwned;
                  isErased = _1184_recErased;
                  readIdents = _1185_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1186___mcc_h540 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1187_recursiveGen;
                  bool _1188_recOwned;
                  bool _1189_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1190_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out709;
                  bool _out710;
                  bool _out711;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out712;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out709, out _out710, out _out711, out _out712);
                  _1187_recursiveGen = _out709;
                  _1188_recOwned = _out710;
                  _1189_recErased = _out711;
                  _1190_recIdents = _out712;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1187_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1188_recOwned;
                  isErased = _1189_recErased;
                  readIdents = _1190_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1191___mcc_h542 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1192_recursiveGen;
                  bool _1193_recOwned;
                  bool _1194_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1195_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out713;
                  bool _out714;
                  bool _out715;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out716;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out713, out _out714, out _out715, out _out716);
                  _1192_recursiveGen = _out713;
                  _1193_recOwned = _out714;
                  _1194_recErased = _out715;
                  _1195_recIdents = _out716;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1192_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1193_recOwned;
                  isErased = _1194_recErased;
                  readIdents = _1195_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1196___mcc_h544 = _source44.dtor_key;
                DAST._IType _1197___mcc_h545 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1198_recursiveGen;
                  bool _1199_recOwned;
                  bool _1200_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1201_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out717;
                  bool _out718;
                  bool _out719;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out720;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out717, out _out718, out _out719, out _out720);
                  _1198_recursiveGen = _out717;
                  _1199_recOwned = _out718;
                  _1200_recErased = _out719;
                  _1201_recIdents = _out720;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1198_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1199_recOwned;
                  isErased = _1200_recErased;
                  readIdents = _1201_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1202___mcc_h548 = _source44.dtor_args;
                DAST._IType _1203___mcc_h549 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1204_recursiveGen;
                  bool _1205_recOwned;
                  bool _1206_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1207_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out721;
                  bool _out722;
                  bool _out723;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out724;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out721, out _out722, out _out723, out _out724);
                  _1204_recursiveGen = _out721;
                  _1205_recOwned = _out722;
                  _1206_recErased = _out723;
                  _1207_recIdents = _out724;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1204_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1205_recOwned;
                  isErased = _1206_recErased;
                  readIdents = _1207_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1208___mcc_h552 = _source44.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1209_recursiveGen;
                  bool _1210_recOwned;
                  bool _1211_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1212_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out725;
                  bool _out726;
                  bool _out727;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out728;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out725, out _out726, out _out727, out _out728);
                  _1209_recursiveGen = _out725;
                  _1210_recOwned = _out726;
                  _1211_recErased = _out727;
                  _1212_recIdents = _out728;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1209_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1210_recOwned;
                  isErased = _1211_recErased;
                  readIdents = _1212_recIdents;
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1213___mcc_h554 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1214_recursiveGen;
                  bool _1215_recOwned;
                  bool _1216_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1217_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out729;
                  bool _out730;
                  bool _out731;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out732;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out729, out _out730, out _out731, out _out732);
                  _1214_recursiveGen = _out729;
                  _1215_recOwned = _out730;
                  _1216_recErased = _out731;
                  _1217_recIdents = _out732;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1214_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1215_recOwned;
                  isErased = _1216_recErased;
                  readIdents = _1217_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1218___mcc_h556 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1219_recursiveGen;
                  bool _1220_recOwned;
                  bool _1221_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1222_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out733;
                  bool _out734;
                  bool _out735;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out736;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out733, out _out734, out _out735, out _out736);
                  _1219_recursiveGen = _out733;
                  _1220_recOwned = _out734;
                  _1221_recErased = _out735;
                  _1222_recIdents = _out736;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1219_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1220_recOwned;
                  isErased = _1221_recErased;
                  readIdents = _1222_recIdents;
                }
              }
            } else if (_source26.is_Map) {
              DAST._IType _1223___mcc_h558 = _source26.dtor_key;
              DAST._IType _1224___mcc_h559 = _source26.dtor_value;
              DAST._IType _source46 = _487___mcc_h127;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1225___mcc_h566 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1226___mcc_h567 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1227___mcc_h568 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1227___mcc_h568;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1228___mcc_h572 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1229_recursiveGen;
                    bool _1230_recOwned;
                    bool _1231_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1232_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out737;
                    bool _out738;
                    bool _out739;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out740;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out737, out _out738, out _out739, out _out740);
                    _1229_recursiveGen = _out737;
                    _1230_recOwned = _out738;
                    _1231_recErased = _out739;
                    _1232_recIdents = _out740;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1229_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1230_recOwned;
                    isErased = _1231_recErased;
                    readIdents = _1232_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1233___mcc_h574 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1234_recursiveGen;
                    bool _1235_recOwned;
                    bool _1236_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1237_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out741;
                    bool _out742;
                    bool _out743;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out744;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out741, out _out742, out _out743, out _out744);
                    _1234_recursiveGen = _out741;
                    _1235_recOwned = _out742;
                    _1236_recErased = _out743;
                    _1237_recIdents = _out744;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1234_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1235_recOwned;
                    isErased = _1236_recErased;
                    readIdents = _1237_recIdents;
                  }
                } else {
                  DAST._IType _1238___mcc_h576 = _source47.dtor_Newtype_a0;
                  DAST._IType _1239_b = _1238___mcc_h576;
                  {
                    if (object.Equals(_480_fromTpe, _1239_b)) {
                      Dafny.ISequence<Dafny.Rune> _1240_recursiveGen;
                      bool _1241_recOwned;
                      bool _1242_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1243_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out745;
                      bool _out746;
                      bool _out747;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out748;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out745, out _out746, out _out747, out _out748);
                      _1240_recursiveGen = _out745;
                      _1241_recOwned = _out746;
                      _1242_recErased = _out747;
                      _1243_recIdents = _out748;
                      Dafny.ISequence<Dafny.Rune> _1244_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out749;
                      _out749 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _1244_rhsType = _out749;
                      Dafny.ISequence<Dafny.Rune> _1245_uneraseFn;
                      _1245_uneraseFn = ((_1241_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1244_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1245_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1240_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1241_recOwned;
                      isErased = false;
                      readIdents = _1243_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out750;
                      bool _out751;
                      bool _out752;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out753;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1239_b), _1239_b, _479_toTpe), selfIdent, @params, mustOwn, out _out750, out _out751, out _out752, out _out753);
                      s = _out750;
                      isOwned = _out751;
                      isErased = _out752;
                      readIdents = _out753;
                    }
                  }
                }
              } else if (_source46.is_Nullable) {
                DAST._IType _1246___mcc_h578 = _source46.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1247_recursiveGen;
                  bool _1248_recOwned;
                  bool _1249_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1250_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out754;
                  bool _out755;
                  bool _out756;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out757;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out754, out _out755, out _out756, out _out757);
                  _1247_recursiveGen = _out754;
                  _1248_recOwned = _out755;
                  _1249_recErased = _out756;
                  _1250_recIdents = _out757;
                  if (!(_1248_recOwned)) {
                    _1247_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1247_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1247_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1249_recErased;
                  readIdents = _1250_recIdents;
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1251___mcc_h580 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1252_recursiveGen;
                  bool _1253_recOwned;
                  bool _1254_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1255_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out758;
                  bool _out759;
                  bool _out760;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out761;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out758, out _out759, out _out760, out _out761);
                  _1252_recursiveGen = _out758;
                  _1253_recOwned = _out759;
                  _1254_recErased = _out760;
                  _1255_recIdents = _out761;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1252_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1253_recOwned;
                  isErased = _1254_recErased;
                  readIdents = _1255_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1256___mcc_h582 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1257_recursiveGen;
                  bool _1258_recOwned;
                  bool _1259_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1260_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out762;
                  bool _out763;
                  bool _out764;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out765;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out762, out _out763, out _out764, out _out765);
                  _1257_recursiveGen = _out762;
                  _1258_recOwned = _out763;
                  _1259_recErased = _out764;
                  _1260_recIdents = _out765;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1257_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1258_recOwned;
                  isErased = _1259_recErased;
                  readIdents = _1260_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1261___mcc_h584 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1262_recursiveGen;
                  bool _1263_recOwned;
                  bool _1264_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1265_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out766;
                  bool _out767;
                  bool _out768;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out769;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out766, out _out767, out _out768, out _out769);
                  _1262_recursiveGen = _out766;
                  _1263_recOwned = _out767;
                  _1264_recErased = _out768;
                  _1265_recIdents = _out769;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1262_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1263_recOwned;
                  isErased = _1264_recErased;
                  readIdents = _1265_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1266___mcc_h586 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1267_recursiveGen;
                  bool _1268_recOwned;
                  bool _1269_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1270_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out770;
                  bool _out771;
                  bool _out772;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out773;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out770, out _out771, out _out772, out _out773);
                  _1267_recursiveGen = _out770;
                  _1268_recOwned = _out771;
                  _1269_recErased = _out772;
                  _1270_recIdents = _out773;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1267_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1268_recOwned;
                  isErased = _1269_recErased;
                  readIdents = _1270_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1271___mcc_h588 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1272_recursiveGen;
                  bool _1273_recOwned;
                  bool _1274_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1275_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out774;
                  bool _out775;
                  bool _out776;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out777;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out774, out _out775, out _out776, out _out777);
                  _1272_recursiveGen = _out774;
                  _1273_recOwned = _out775;
                  _1274_recErased = _out776;
                  _1275_recIdents = _out777;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1272_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1273_recOwned;
                  isErased = _1274_recErased;
                  readIdents = _1275_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1276___mcc_h590 = _source46.dtor_key;
                DAST._IType _1277___mcc_h591 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1278_recursiveGen;
                  bool _1279_recOwned;
                  bool _1280_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1281_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out778;
                  bool _out779;
                  bool _out780;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out781;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out778, out _out779, out _out780, out _out781);
                  _1278_recursiveGen = _out778;
                  _1279_recOwned = _out779;
                  _1280_recErased = _out780;
                  _1281_recIdents = _out781;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1278_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1279_recOwned;
                  isErased = _1280_recErased;
                  readIdents = _1281_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1282___mcc_h594 = _source46.dtor_args;
                DAST._IType _1283___mcc_h595 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1284_recursiveGen;
                  bool _1285_recOwned;
                  bool _1286_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1287_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out782;
                  bool _out783;
                  bool _out784;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out785;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out782, out _out783, out _out784, out _out785);
                  _1284_recursiveGen = _out782;
                  _1285_recOwned = _out783;
                  _1286_recErased = _out784;
                  _1287_recIdents = _out785;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1284_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1285_recOwned;
                  isErased = _1286_recErased;
                  readIdents = _1287_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1288___mcc_h598 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1289_recursiveGen;
                  bool _1290_recOwned;
                  bool _1291_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1292_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out786;
                  bool _out787;
                  bool _out788;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out789;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out786, out _out787, out _out788, out _out789);
                  _1289_recursiveGen = _out786;
                  _1290_recOwned = _out787;
                  _1291_recErased = _out788;
                  _1292_recIdents = _out789;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1289_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1290_recOwned;
                  isErased = _1291_recErased;
                  readIdents = _1292_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1293___mcc_h600 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1294_recursiveGen;
                  bool _1295_recOwned;
                  bool _1296_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1297_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out790;
                  bool _out791;
                  bool _out792;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out793;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out790, out _out791, out _out792, out _out793);
                  _1294_recursiveGen = _out790;
                  _1295_recOwned = _out791;
                  _1296_recErased = _out792;
                  _1297_recIdents = _out793;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1294_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1295_recOwned;
                  isErased = _1296_recErased;
                  readIdents = _1297_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1298___mcc_h602 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1299_recursiveGen;
                  bool _1300_recOwned;
                  bool _1301_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1302_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out794;
                  bool _out795;
                  bool _out796;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out797;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out794, out _out795, out _out796, out _out797);
                  _1299_recursiveGen = _out794;
                  _1300_recOwned = _out795;
                  _1301_recErased = _out796;
                  _1302_recIdents = _out797;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1299_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1300_recOwned;
                  isErased = _1301_recErased;
                  readIdents = _1302_recIdents;
                }
              }
            } else if (_source26.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1303___mcc_h604 = _source26.dtor_args;
              DAST._IType _1304___mcc_h605 = _source26.dtor_result;
              DAST._IType _source48 = _487___mcc_h127;
              if (_source48.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1305___mcc_h612 = _source48.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1306___mcc_h613 = _source48.dtor_typeArgs;
                DAST._IResolvedType _1307___mcc_h614 = _source48.dtor_resolved;
                DAST._IResolvedType _source49 = _1307___mcc_h614;
                if (_source49.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1308___mcc_h618 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1309_recursiveGen;
                    bool _1310_recOwned;
                    bool _1311_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1312_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out798;
                    bool _out799;
                    bool _out800;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out801;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out798, out _out799, out _out800, out _out801);
                    _1309_recursiveGen = _out798;
                    _1310_recOwned = _out799;
                    _1311_recErased = _out800;
                    _1312_recIdents = _out801;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1309_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1310_recOwned;
                    isErased = _1311_recErased;
                    readIdents = _1312_recIdents;
                  }
                } else if (_source49.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1313___mcc_h620 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1314_recursiveGen;
                    bool _1315_recOwned;
                    bool _1316_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1317_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out802;
                    bool _out803;
                    bool _out804;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out805;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out802, out _out803, out _out804, out _out805);
                    _1314_recursiveGen = _out802;
                    _1315_recOwned = _out803;
                    _1316_recErased = _out804;
                    _1317_recIdents = _out805;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1314_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1315_recOwned;
                    isErased = _1316_recErased;
                    readIdents = _1317_recIdents;
                  }
                } else {
                  DAST._IType _1318___mcc_h622 = _source49.dtor_Newtype_a0;
                  DAST._IType _1319_b = _1318___mcc_h622;
                  {
                    if (object.Equals(_480_fromTpe, _1319_b)) {
                      Dafny.ISequence<Dafny.Rune> _1320_recursiveGen;
                      bool _1321_recOwned;
                      bool _1322_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1323_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out806;
                      bool _out807;
                      bool _out808;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out809;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out806, out _out807, out _out808, out _out809);
                      _1320_recursiveGen = _out806;
                      _1321_recOwned = _out807;
                      _1322_recErased = _out808;
                      _1323_recIdents = _out809;
                      Dafny.ISequence<Dafny.Rune> _1324_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out810;
                      _out810 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _1324_rhsType = _out810;
                      Dafny.ISequence<Dafny.Rune> _1325_uneraseFn;
                      _1325_uneraseFn = ((_1321_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1324_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1325_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1320_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1321_recOwned;
                      isErased = false;
                      readIdents = _1323_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out811;
                      bool _out812;
                      bool _out813;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out814;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1319_b), _1319_b, _479_toTpe), selfIdent, @params, mustOwn, out _out811, out _out812, out _out813, out _out814);
                      s = _out811;
                      isOwned = _out812;
                      isErased = _out813;
                      readIdents = _out814;
                    }
                  }
                }
              } else if (_source48.is_Nullable) {
                DAST._IType _1326___mcc_h624 = _source48.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1327_recursiveGen;
                  bool _1328_recOwned;
                  bool _1329_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1330_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out815;
                  bool _out816;
                  bool _out817;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out818;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out815, out _out816, out _out817, out _out818);
                  _1327_recursiveGen = _out815;
                  _1328_recOwned = _out816;
                  _1329_recErased = _out817;
                  _1330_recIdents = _out818;
                  if (!(_1328_recOwned)) {
                    _1327_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1327_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1327_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1329_recErased;
                  readIdents = _1330_recIdents;
                }
              } else if (_source48.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1331___mcc_h626 = _source48.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1332_recursiveGen;
                  bool _1333_recOwned;
                  bool _1334_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1335_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out819;
                  bool _out820;
                  bool _out821;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out822;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out819, out _out820, out _out821, out _out822);
                  _1332_recursiveGen = _out819;
                  _1333_recOwned = _out820;
                  _1334_recErased = _out821;
                  _1335_recIdents = _out822;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1332_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1333_recOwned;
                  isErased = _1334_recErased;
                  readIdents = _1335_recIdents;
                }
              } else if (_source48.is_Array) {
                DAST._IType _1336___mcc_h628 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1337_recursiveGen;
                  bool _1338_recOwned;
                  bool _1339_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1340_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out823;
                  bool _out824;
                  bool _out825;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out826;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out823, out _out824, out _out825, out _out826);
                  _1337_recursiveGen = _out823;
                  _1338_recOwned = _out824;
                  _1339_recErased = _out825;
                  _1340_recIdents = _out826;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1337_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1338_recOwned;
                  isErased = _1339_recErased;
                  readIdents = _1340_recIdents;
                }
              } else if (_source48.is_Seq) {
                DAST._IType _1341___mcc_h630 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1342_recursiveGen;
                  bool _1343_recOwned;
                  bool _1344_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1345_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out827;
                  bool _out828;
                  bool _out829;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out827, out _out828, out _out829, out _out830);
                  _1342_recursiveGen = _out827;
                  _1343_recOwned = _out828;
                  _1344_recErased = _out829;
                  _1345_recIdents = _out830;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1342_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1343_recOwned;
                  isErased = _1344_recErased;
                  readIdents = _1345_recIdents;
                }
              } else if (_source48.is_Set) {
                DAST._IType _1346___mcc_h632 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1347_recursiveGen;
                  bool _1348_recOwned;
                  bool _1349_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1350_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out831;
                  bool _out832;
                  bool _out833;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                  _1347_recursiveGen = _out831;
                  _1348_recOwned = _out832;
                  _1349_recErased = _out833;
                  _1350_recIdents = _out834;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1347_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1348_recOwned;
                  isErased = _1349_recErased;
                  readIdents = _1350_recIdents;
                }
              } else if (_source48.is_Multiset) {
                DAST._IType _1351___mcc_h634 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1352_recursiveGen;
                  bool _1353_recOwned;
                  bool _1354_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1355_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out835;
                  bool _out836;
                  bool _out837;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                  _1352_recursiveGen = _out835;
                  _1353_recOwned = _out836;
                  _1354_recErased = _out837;
                  _1355_recIdents = _out838;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1352_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1353_recOwned;
                  isErased = _1354_recErased;
                  readIdents = _1355_recIdents;
                }
              } else if (_source48.is_Map) {
                DAST._IType _1356___mcc_h636 = _source48.dtor_key;
                DAST._IType _1357___mcc_h637 = _source48.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1358_recursiveGen;
                  bool _1359_recOwned;
                  bool _1360_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1361_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out839;
                  bool _out840;
                  bool _out841;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                  _1358_recursiveGen = _out839;
                  _1359_recOwned = _out840;
                  _1360_recErased = _out841;
                  _1361_recIdents = _out842;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1358_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1359_recOwned;
                  isErased = _1360_recErased;
                  readIdents = _1361_recIdents;
                }
              } else if (_source48.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1362___mcc_h640 = _source48.dtor_args;
                DAST._IType _1363___mcc_h641 = _source48.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1364_recursiveGen;
                  bool _1365_recOwned;
                  bool _1366_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1367_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out843;
                  bool _out844;
                  bool _out845;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                  _1364_recursiveGen = _out843;
                  _1365_recOwned = _out844;
                  _1366_recErased = _out845;
                  _1367_recIdents = _out846;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1364_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1365_recOwned;
                  isErased = _1366_recErased;
                  readIdents = _1367_recIdents;
                }
              } else if (_source48.is_Primitive) {
                DAST._IPrimitive _1368___mcc_h644 = _source48.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1369_recursiveGen;
                  bool _1370_recOwned;
                  bool _1371_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1372_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out847;
                  bool _out848;
                  bool _out849;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out850;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out847, out _out848, out _out849, out _out850);
                  _1369_recursiveGen = _out847;
                  _1370_recOwned = _out848;
                  _1371_recErased = _out849;
                  _1372_recIdents = _out850;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1369_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1370_recOwned;
                  isErased = _1371_recErased;
                  readIdents = _1372_recIdents;
                }
              } else if (_source48.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1373___mcc_h646 = _source48.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1374_recursiveGen;
                  bool _1375_recOwned;
                  bool _1376_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1377_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out851;
                  bool _out852;
                  bool _out853;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out854;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out851, out _out852, out _out853, out _out854);
                  _1374_recursiveGen = _out851;
                  _1375_recOwned = _out852;
                  _1376_recErased = _out853;
                  _1377_recIdents = _out854;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1374_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1375_recOwned;
                  isErased = _1376_recErased;
                  readIdents = _1377_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1378___mcc_h648 = _source48.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1379_recursiveGen;
                  bool _1380_recOwned;
                  bool _1381_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1382_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out855;
                  bool _out856;
                  bool _out857;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out858;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out855, out _out856, out _out857, out _out858);
                  _1379_recursiveGen = _out855;
                  _1380_recOwned = _out856;
                  _1381_recErased = _out857;
                  _1382_recIdents = _out858;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1379_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1380_recOwned;
                  isErased = _1381_recErased;
                  readIdents = _1382_recIdents;
                }
              }
            } else if (_source26.is_Primitive) {
              DAST._IPrimitive _1383___mcc_h650 = _source26.dtor_Primitive_a0;
              DAST._IPrimitive _source50 = _1383___mcc_h650;
              if (_source50.is_Int) {
                DAST._IType _source51 = _487___mcc_h127;
                if (_source51.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1384___mcc_h654 = _source51.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1385___mcc_h655 = _source51.dtor_typeArgs;
                  DAST._IResolvedType _1386___mcc_h656 = _source51.dtor_resolved;
                  DAST._IResolvedType _source52 = _1386___mcc_h656;
                  if (_source52.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1387___mcc_h660 = _source52.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1388_recursiveGen;
                      bool _1389_recOwned;
                      bool _1390_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1391_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out859;
                      bool _out860;
                      bool _out861;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out862;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out859, out _out860, out _out861, out _out862);
                      _1388_recursiveGen = _out859;
                      _1389_recOwned = _out860;
                      _1390_recErased = _out861;
                      _1391_recIdents = _out862;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1388_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1389_recOwned;
                      isErased = _1390_recErased;
                      readIdents = _1391_recIdents;
                    }
                  } else if (_source52.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1392___mcc_h662 = _source52.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1393_recursiveGen;
                      bool _1394_recOwned;
                      bool _1395_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1396_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out863;
                      bool _out864;
                      bool _out865;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out866;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out863, out _out864, out _out865, out _out866);
                      _1393_recursiveGen = _out863;
                      _1394_recOwned = _out864;
                      _1395_recErased = _out865;
                      _1396_recIdents = _out866;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1393_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1394_recOwned;
                      isErased = _1395_recErased;
                      readIdents = _1396_recIdents;
                    }
                  } else {
                    DAST._IType _1397___mcc_h664 = _source52.dtor_Newtype_a0;
                    DAST._IType _1398_b = _1397___mcc_h664;
                    {
                      if (object.Equals(_480_fromTpe, _1398_b)) {
                        Dafny.ISequence<Dafny.Rune> _1399_recursiveGen;
                        bool _1400_recOwned;
                        bool _1401_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1402_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out867;
                        bool _out868;
                        bool _out869;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out870;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out867, out _out868, out _out869, out _out870);
                        _1399_recursiveGen = _out867;
                        _1400_recOwned = _out868;
                        _1401_recErased = _out869;
                        _1402_recIdents = _out870;
                        Dafny.ISequence<Dafny.Rune> _1403_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out871;
                        _out871 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                        _1403_rhsType = _out871;
                        Dafny.ISequence<Dafny.Rune> _1404_uneraseFn;
                        _1404_uneraseFn = ((_1400_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1403_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1404_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1399_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1400_recOwned;
                        isErased = false;
                        readIdents = _1402_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out872;
                        bool _out873;
                        bool _out874;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out875;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1398_b), _1398_b, _479_toTpe), selfIdent, @params, mustOwn, out _out872, out _out873, out _out874, out _out875);
                        s = _out872;
                        isOwned = _out873;
                        isErased = _out874;
                        readIdents = _out875;
                      }
                    }
                  }
                } else if (_source51.is_Nullable) {
                  DAST._IType _1405___mcc_h666 = _source51.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1406_recursiveGen;
                    bool _1407_recOwned;
                    bool _1408_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1409_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out876;
                    bool _out877;
                    bool _out878;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out879;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out876, out _out877, out _out878, out _out879);
                    _1406_recursiveGen = _out876;
                    _1407_recOwned = _out877;
                    _1408_recErased = _out878;
                    _1409_recIdents = _out879;
                    if (!(_1407_recOwned)) {
                      _1406_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1406_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1406_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1408_recErased;
                    readIdents = _1409_recIdents;
                  }
                } else if (_source51.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1410___mcc_h668 = _source51.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1411_recursiveGen;
                    bool _1412_recOwned;
                    bool _1413_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1414_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out880;
                    bool _out881;
                    bool _out882;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                    _1411_recursiveGen = _out880;
                    _1412_recOwned = _out881;
                    _1413_recErased = _out882;
                    _1414_recIdents = _out883;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1411_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1412_recOwned;
                    isErased = _1413_recErased;
                    readIdents = _1414_recIdents;
                  }
                } else if (_source51.is_Array) {
                  DAST._IType _1415___mcc_h670 = _source51.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1416_recursiveGen;
                    bool _1417_recOwned;
                    bool _1418_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1419_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out884;
                    bool _out885;
                    bool _out886;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                    _1416_recursiveGen = _out884;
                    _1417_recOwned = _out885;
                    _1418_recErased = _out886;
                    _1419_recIdents = _out887;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1416_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1417_recOwned;
                    isErased = _1418_recErased;
                    readIdents = _1419_recIdents;
                  }
                } else if (_source51.is_Seq) {
                  DAST._IType _1420___mcc_h672 = _source51.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1421_recursiveGen;
                    bool _1422_recOwned;
                    bool _1423_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1424_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out888;
                    bool _out889;
                    bool _out890;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                    _1421_recursiveGen = _out888;
                    _1422_recOwned = _out889;
                    _1423_recErased = _out890;
                    _1424_recIdents = _out891;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1421_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1422_recOwned;
                    isErased = _1423_recErased;
                    readIdents = _1424_recIdents;
                  }
                } else if (_source51.is_Set) {
                  DAST._IType _1425___mcc_h674 = _source51.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1426_recursiveGen;
                    bool _1427_recOwned;
                    bool _1428_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1429_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out892;
                    bool _out893;
                    bool _out894;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                    _1426_recursiveGen = _out892;
                    _1427_recOwned = _out893;
                    _1428_recErased = _out894;
                    _1429_recIdents = _out895;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1426_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1427_recOwned;
                    isErased = _1428_recErased;
                    readIdents = _1429_recIdents;
                  }
                } else if (_source51.is_Multiset) {
                  DAST._IType _1430___mcc_h676 = _source51.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1431_recursiveGen;
                    bool _1432_recOwned;
                    bool _1433_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1434_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out896;
                    bool _out897;
                    bool _out898;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                    _1431_recursiveGen = _out896;
                    _1432_recOwned = _out897;
                    _1433_recErased = _out898;
                    _1434_recIdents = _out899;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1431_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1432_recOwned;
                    isErased = _1433_recErased;
                    readIdents = _1434_recIdents;
                  }
                } else if (_source51.is_Map) {
                  DAST._IType _1435___mcc_h678 = _source51.dtor_key;
                  DAST._IType _1436___mcc_h679 = _source51.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1437_recursiveGen;
                    bool _1438_recOwned;
                    bool _1439_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1440_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1437_recursiveGen = _out900;
                    _1438_recOwned = _out901;
                    _1439_recErased = _out902;
                    _1440_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1437_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1438_recOwned;
                    isErased = _1439_recErased;
                    readIdents = _1440_recIdents;
                  }
                } else if (_source51.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1441___mcc_h682 = _source51.dtor_args;
                  DAST._IType _1442___mcc_h683 = _source51.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1443_recursiveGen;
                    bool _1444_recOwned;
                    bool _1445_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1446_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1443_recursiveGen = _out904;
                    _1444_recOwned = _out905;
                    _1445_recErased = _out906;
                    _1446_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1443_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1444_recOwned;
                    isErased = _1445_recErased;
                    readIdents = _1446_recIdents;
                  }
                } else if (_source51.is_Primitive) {
                  DAST._IPrimitive _1447___mcc_h686 = _source51.dtor_Primitive_a0;
                  DAST._IPrimitive _source53 = _1447___mcc_h686;
                  if (_source53.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1448_recursiveGen;
                      bool _1449_recOwned;
                      bool _1450_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1451_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out908;
                      bool _out909;
                      bool _out910;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                      _1448_recursiveGen = _out908;
                      _1449_recOwned = _out909;
                      _1450_recErased = _out910;
                      _1451_recIdents = _out911;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1448_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1449_recOwned;
                      isErased = _1450_recErased;
                      readIdents = _1451_recIdents;
                    }
                  } else if (_source53.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1452_recursiveGen;
                      bool _1453___v43;
                      bool _1454___v44;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1455_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out912;
                      bool _out913;
                      bool _out914;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, true, out _out912, out _out913, out _out914, out _out915);
                      _1452_recursiveGen = _out912;
                      _1453___v43 = _out913;
                      _1454___v44 = _out914;
                      _1455_recIdents = _out915;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1452_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1455_recIdents;
                    }
                  } else if (_source53.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1456_recursiveGen;
                      bool _1457_recOwned;
                      bool _1458_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1459_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out916;
                      bool _out917;
                      bool _out918;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                      _1456_recursiveGen = _out916;
                      _1457_recOwned = _out917;
                      _1458_recErased = _out918;
                      _1459_recIdents = _out919;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1456_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1457_recOwned;
                      isErased = _1458_recErased;
                      readIdents = _1459_recIdents;
                    }
                  } else if (_source53.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1460_recursiveGen;
                      bool _1461_recOwned;
                      bool _1462_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1463_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out920;
                      bool _out921;
                      bool _out922;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out920, out _out921, out _out922, out _out923);
                      _1460_recursiveGen = _out920;
                      _1461_recOwned = _out921;
                      _1462_recErased = _out922;
                      _1463_recIdents = _out923;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1460_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1461_recOwned;
                      isErased = _1462_recErased;
                      readIdents = _1463_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1464_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out924;
                      _out924 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _1464_rhsType = _out924;
                      Dafny.ISequence<Dafny.Rune> _1465_recursiveGen;
                      bool _1466___v53;
                      bool _1467___v54;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1468_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out925;
                      bool _out926;
                      bool _out927;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out928;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, true, out _out925, out _out926, out _out927, out _out928);
                      _1465_recursiveGen = _out925;
                      _1466___v53 = _out926;
                      _1467___v54 = _out927;
                      _1468_recIdents = _out928;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1465_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1468_recIdents;
                    }
                  }
                } else if (_source51.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1469___mcc_h688 = _source51.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1470_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out929;
                    _out929 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                    _1470_rhsType = _out929;
                    Dafny.ISequence<Dafny.Rune> _1471_recursiveGen;
                    bool _1472___v48;
                    bool _1473___v49;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1474_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out930;
                    bool _out931;
                    bool _out932;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out933;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, true, out _out930, out _out931, out _out932, out _out933);
                    _1471_recursiveGen = _out930;
                    _1472___v48 = _out931;
                    _1473___v49 = _out932;
                    _1474_recIdents = _out933;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1470_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1471_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1474_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1475___mcc_h690 = _source51.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1476_recursiveGen;
                    bool _1477_recOwned;
                    bool _1478_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1479_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out934;
                    bool _out935;
                    bool _out936;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out937;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out934, out _out935, out _out936, out _out937);
                    _1476_recursiveGen = _out934;
                    _1477_recOwned = _out935;
                    _1478_recErased = _out936;
                    _1479_recIdents = _out937;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1476_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1477_recOwned;
                    isErased = _1478_recErased;
                    readIdents = _1479_recIdents;
                  }
                }
              } else if (_source50.is_Real) {
                DAST._IType _source54 = _487___mcc_h127;
                if (_source54.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1480___mcc_h692 = _source54.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1481___mcc_h693 = _source54.dtor_typeArgs;
                  DAST._IResolvedType _1482___mcc_h694 = _source54.dtor_resolved;
                  DAST._IResolvedType _source55 = _1482___mcc_h694;
                  if (_source55.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1483___mcc_h698 = _source55.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1484_recursiveGen;
                      bool _1485_recOwned;
                      bool _1486_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1487_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out938;
                      bool _out939;
                      bool _out940;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out941;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out938, out _out939, out _out940, out _out941);
                      _1484_recursiveGen = _out938;
                      _1485_recOwned = _out939;
                      _1486_recErased = _out940;
                      _1487_recIdents = _out941;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1484_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1485_recOwned;
                      isErased = _1486_recErased;
                      readIdents = _1487_recIdents;
                    }
                  } else if (_source55.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1488___mcc_h700 = _source55.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1489_recursiveGen;
                      bool _1490_recOwned;
                      bool _1491_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1492_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out942;
                      bool _out943;
                      bool _out944;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out945;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out942, out _out943, out _out944, out _out945);
                      _1489_recursiveGen = _out942;
                      _1490_recOwned = _out943;
                      _1491_recErased = _out944;
                      _1492_recIdents = _out945;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1489_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1490_recOwned;
                      isErased = _1491_recErased;
                      readIdents = _1492_recIdents;
                    }
                  } else {
                    DAST._IType _1493___mcc_h702 = _source55.dtor_Newtype_a0;
                    DAST._IType _1494_b = _1493___mcc_h702;
                    {
                      if (object.Equals(_480_fromTpe, _1494_b)) {
                        Dafny.ISequence<Dafny.Rune> _1495_recursiveGen;
                        bool _1496_recOwned;
                        bool _1497_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1498_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out946;
                        bool _out947;
                        bool _out948;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out949;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out946, out _out947, out _out948, out _out949);
                        _1495_recursiveGen = _out946;
                        _1496_recOwned = _out947;
                        _1497_recErased = _out948;
                        _1498_recIdents = _out949;
                        Dafny.ISequence<Dafny.Rune> _1499_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out950;
                        _out950 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                        _1499_rhsType = _out950;
                        Dafny.ISequence<Dafny.Rune> _1500_uneraseFn;
                        _1500_uneraseFn = ((_1496_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1499_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1500_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1495_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1496_recOwned;
                        isErased = false;
                        readIdents = _1498_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out951;
                        bool _out952;
                        bool _out953;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out954;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1494_b), _1494_b, _479_toTpe), selfIdent, @params, mustOwn, out _out951, out _out952, out _out953, out _out954);
                        s = _out951;
                        isOwned = _out952;
                        isErased = _out953;
                        readIdents = _out954;
                      }
                    }
                  }
                } else if (_source54.is_Nullable) {
                  DAST._IType _1501___mcc_h704 = _source54.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1502_recursiveGen;
                    bool _1503_recOwned;
                    bool _1504_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1505_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out955;
                    bool _out956;
                    bool _out957;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out958;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out955, out _out956, out _out957, out _out958);
                    _1502_recursiveGen = _out955;
                    _1503_recOwned = _out956;
                    _1504_recErased = _out957;
                    _1505_recIdents = _out958;
                    if (!(_1503_recOwned)) {
                      _1502_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1502_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1502_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1504_recErased;
                    readIdents = _1505_recIdents;
                  }
                } else if (_source54.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1506___mcc_h706 = _source54.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1507_recursiveGen;
                    bool _1508_recOwned;
                    bool _1509_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1510_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out959;
                    bool _out960;
                    bool _out961;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out962;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out959, out _out960, out _out961, out _out962);
                    _1507_recursiveGen = _out959;
                    _1508_recOwned = _out960;
                    _1509_recErased = _out961;
                    _1510_recIdents = _out962;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1507_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1508_recOwned;
                    isErased = _1509_recErased;
                    readIdents = _1510_recIdents;
                  }
                } else if (_source54.is_Array) {
                  DAST._IType _1511___mcc_h708 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1512_recursiveGen;
                    bool _1513_recOwned;
                    bool _1514_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1515_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out963;
                    bool _out964;
                    bool _out965;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out966;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out963, out _out964, out _out965, out _out966);
                    _1512_recursiveGen = _out963;
                    _1513_recOwned = _out964;
                    _1514_recErased = _out965;
                    _1515_recIdents = _out966;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1512_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1513_recOwned;
                    isErased = _1514_recErased;
                    readIdents = _1515_recIdents;
                  }
                } else if (_source54.is_Seq) {
                  DAST._IType _1516___mcc_h710 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1517_recursiveGen;
                    bool _1518_recOwned;
                    bool _1519_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1520_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out967;
                    bool _out968;
                    bool _out969;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out970;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out967, out _out968, out _out969, out _out970);
                    _1517_recursiveGen = _out967;
                    _1518_recOwned = _out968;
                    _1519_recErased = _out969;
                    _1520_recIdents = _out970;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1517_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1518_recOwned;
                    isErased = _1519_recErased;
                    readIdents = _1520_recIdents;
                  }
                } else if (_source54.is_Set) {
                  DAST._IType _1521___mcc_h712 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1522_recursiveGen;
                    bool _1523_recOwned;
                    bool _1524_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1525_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out971;
                    bool _out972;
                    bool _out973;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out974;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out971, out _out972, out _out973, out _out974);
                    _1522_recursiveGen = _out971;
                    _1523_recOwned = _out972;
                    _1524_recErased = _out973;
                    _1525_recIdents = _out974;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1522_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1523_recOwned;
                    isErased = _1524_recErased;
                    readIdents = _1525_recIdents;
                  }
                } else if (_source54.is_Multiset) {
                  DAST._IType _1526___mcc_h714 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1527_recursiveGen;
                    bool _1528_recOwned;
                    bool _1529_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1530_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out975;
                    bool _out976;
                    bool _out977;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out978;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out975, out _out976, out _out977, out _out978);
                    _1527_recursiveGen = _out975;
                    _1528_recOwned = _out976;
                    _1529_recErased = _out977;
                    _1530_recIdents = _out978;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1527_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1528_recOwned;
                    isErased = _1529_recErased;
                    readIdents = _1530_recIdents;
                  }
                } else if (_source54.is_Map) {
                  DAST._IType _1531___mcc_h716 = _source54.dtor_key;
                  DAST._IType _1532___mcc_h717 = _source54.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1533_recursiveGen;
                    bool _1534_recOwned;
                    bool _1535_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1536_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out979;
                    bool _out980;
                    bool _out981;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out982;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out979, out _out980, out _out981, out _out982);
                    _1533_recursiveGen = _out979;
                    _1534_recOwned = _out980;
                    _1535_recErased = _out981;
                    _1536_recIdents = _out982;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1533_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1534_recOwned;
                    isErased = _1535_recErased;
                    readIdents = _1536_recIdents;
                  }
                } else if (_source54.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1537___mcc_h720 = _source54.dtor_args;
                  DAST._IType _1538___mcc_h721 = _source54.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1539_recursiveGen;
                    bool _1540_recOwned;
                    bool _1541_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1542_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out983;
                    bool _out984;
                    bool _out985;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out986;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out983, out _out984, out _out985, out _out986);
                    _1539_recursiveGen = _out983;
                    _1540_recOwned = _out984;
                    _1541_recErased = _out985;
                    _1542_recIdents = _out986;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1539_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1540_recOwned;
                    isErased = _1541_recErased;
                    readIdents = _1542_recIdents;
                  }
                } else if (_source54.is_Primitive) {
                  DAST._IPrimitive _1543___mcc_h724 = _source54.dtor_Primitive_a0;
                  DAST._IPrimitive _source56 = _1543___mcc_h724;
                  if (_source56.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1544_recursiveGen;
                      bool _1545___v45;
                      bool _1546___v46;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1547_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out987;
                      bool _out988;
                      bool _out989;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out990;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, false, out _out987, out _out988, out _out989, out _out990);
                      _1544_recursiveGen = _out987;
                      _1545___v45 = _out988;
                      _1546___v46 = _out989;
                      _1547_recIdents = _out990;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1544_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1547_recIdents;
                    }
                  } else if (_source56.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1548_recursiveGen;
                      bool _1549_recOwned;
                      bool _1550_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1551_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out991;
                      bool _out992;
                      bool _out993;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out994;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out991, out _out992, out _out993, out _out994);
                      _1548_recursiveGen = _out991;
                      _1549_recOwned = _out992;
                      _1550_recErased = _out993;
                      _1551_recIdents = _out994;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1548_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1549_recOwned;
                      isErased = _1550_recErased;
                      readIdents = _1551_recIdents;
                    }
                  } else if (_source56.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1552_recursiveGen;
                      bool _1553_recOwned;
                      bool _1554_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1555_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out995;
                      bool _out996;
                      bool _out997;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out998;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out995, out _out996, out _out997, out _out998);
                      _1552_recursiveGen = _out995;
                      _1553_recOwned = _out996;
                      _1554_recErased = _out997;
                      _1555_recIdents = _out998;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1552_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1553_recOwned;
                      isErased = _1554_recErased;
                      readIdents = _1555_recIdents;
                    }
                  } else if (_source56.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1556_recursiveGen;
                      bool _1557_recOwned;
                      bool _1558_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1559_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out999;
                      bool _out1000;
                      bool _out1001;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1002;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out999, out _out1000, out _out1001, out _out1002);
                      _1556_recursiveGen = _out999;
                      _1557_recOwned = _out1000;
                      _1558_recErased = _out1001;
                      _1559_recIdents = _out1002;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1556_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1557_recOwned;
                      isErased = _1558_recErased;
                      readIdents = _1559_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1560_recursiveGen;
                      bool _1561_recOwned;
                      bool _1562_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1563_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1003;
                      bool _out1004;
                      bool _out1005;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1006;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1003, out _out1004, out _out1005, out _out1006);
                      _1560_recursiveGen = _out1003;
                      _1561_recOwned = _out1004;
                      _1562_recErased = _out1005;
                      _1563_recIdents = _out1006;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1561_recOwned;
                      isErased = _1562_recErased;
                      readIdents = _1563_recIdents;
                    }
                  }
                } else if (_source54.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1564___mcc_h726 = _source54.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1565_recursiveGen;
                    bool _1566_recOwned;
                    bool _1567_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1568_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1007;
                    bool _out1008;
                    bool _out1009;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1010;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1007, out _out1008, out _out1009, out _out1010);
                    _1565_recursiveGen = _out1007;
                    _1566_recOwned = _out1008;
                    _1567_recErased = _out1009;
                    _1568_recIdents = _out1010;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1565_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1566_recOwned;
                    isErased = _1567_recErased;
                    readIdents = _1568_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1569___mcc_h728 = _source54.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1570_recursiveGen;
                    bool _1571_recOwned;
                    bool _1572_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1573_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1011;
                    bool _out1012;
                    bool _out1013;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1014;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1011, out _out1012, out _out1013, out _out1014);
                    _1570_recursiveGen = _out1011;
                    _1571_recOwned = _out1012;
                    _1572_recErased = _out1013;
                    _1573_recIdents = _out1014;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1570_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1571_recOwned;
                    isErased = _1572_recErased;
                    readIdents = _1573_recIdents;
                  }
                }
              } else if (_source50.is_String) {
                DAST._IType _source57 = _487___mcc_h127;
                if (_source57.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1574___mcc_h730 = _source57.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1575___mcc_h731 = _source57.dtor_typeArgs;
                  DAST._IResolvedType _1576___mcc_h732 = _source57.dtor_resolved;
                  DAST._IResolvedType _source58 = _1576___mcc_h732;
                  if (_source58.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1577___mcc_h736 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1578_recursiveGen;
                      bool _1579_recOwned;
                      bool _1580_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1581_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1015;
                      bool _out1016;
                      bool _out1017;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1018;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1015, out _out1016, out _out1017, out _out1018);
                      _1578_recursiveGen = _out1015;
                      _1579_recOwned = _out1016;
                      _1580_recErased = _out1017;
                      _1581_recIdents = _out1018;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1578_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1579_recOwned;
                      isErased = _1580_recErased;
                      readIdents = _1581_recIdents;
                    }
                  } else if (_source58.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1582___mcc_h738 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1583_recursiveGen;
                      bool _1584_recOwned;
                      bool _1585_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1586_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1019;
                      bool _out1020;
                      bool _out1021;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1022;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1019, out _out1020, out _out1021, out _out1022);
                      _1583_recursiveGen = _out1019;
                      _1584_recOwned = _out1020;
                      _1585_recErased = _out1021;
                      _1586_recIdents = _out1022;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1583_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1584_recOwned;
                      isErased = _1585_recErased;
                      readIdents = _1586_recIdents;
                    }
                  } else {
                    DAST._IType _1587___mcc_h740 = _source58.dtor_Newtype_a0;
                    DAST._IType _1588_b = _1587___mcc_h740;
                    {
                      if (object.Equals(_480_fromTpe, _1588_b)) {
                        Dafny.ISequence<Dafny.Rune> _1589_recursiveGen;
                        bool _1590_recOwned;
                        bool _1591_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1592_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1023;
                        bool _out1024;
                        bool _out1025;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1026;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1023, out _out1024, out _out1025, out _out1026);
                        _1589_recursiveGen = _out1023;
                        _1590_recOwned = _out1024;
                        _1591_recErased = _out1025;
                        _1592_recIdents = _out1026;
                        Dafny.ISequence<Dafny.Rune> _1593_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1027;
                        _out1027 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                        _1593_rhsType = _out1027;
                        Dafny.ISequence<Dafny.Rune> _1594_uneraseFn;
                        _1594_uneraseFn = ((_1590_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1593_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1594_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1589_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1590_recOwned;
                        isErased = false;
                        readIdents = _1592_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1028;
                        bool _out1029;
                        bool _out1030;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1031;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1588_b), _1588_b, _479_toTpe), selfIdent, @params, mustOwn, out _out1028, out _out1029, out _out1030, out _out1031);
                        s = _out1028;
                        isOwned = _out1029;
                        isErased = _out1030;
                        readIdents = _out1031;
                      }
                    }
                  }
                } else if (_source57.is_Nullable) {
                  DAST._IType _1595___mcc_h742 = _source57.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1596_recursiveGen;
                    bool _1597_recOwned;
                    bool _1598_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1599_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1032;
                    bool _out1033;
                    bool _out1034;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1035;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1032, out _out1033, out _out1034, out _out1035);
                    _1596_recursiveGen = _out1032;
                    _1597_recOwned = _out1033;
                    _1598_recErased = _out1034;
                    _1599_recIdents = _out1035;
                    if (!(_1597_recOwned)) {
                      _1596_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1596_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1596_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1598_recErased;
                    readIdents = _1599_recIdents;
                  }
                } else if (_source57.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1600___mcc_h744 = _source57.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1601_recursiveGen;
                    bool _1602_recOwned;
                    bool _1603_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1604_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1036;
                    bool _out1037;
                    bool _out1038;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1039;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1036, out _out1037, out _out1038, out _out1039);
                    _1601_recursiveGen = _out1036;
                    _1602_recOwned = _out1037;
                    _1603_recErased = _out1038;
                    _1604_recIdents = _out1039;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1601_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1602_recOwned;
                    isErased = _1603_recErased;
                    readIdents = _1604_recIdents;
                  }
                } else if (_source57.is_Array) {
                  DAST._IType _1605___mcc_h746 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1606_recursiveGen;
                    bool _1607_recOwned;
                    bool _1608_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1609_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1040;
                    bool _out1041;
                    bool _out1042;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1043;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1040, out _out1041, out _out1042, out _out1043);
                    _1606_recursiveGen = _out1040;
                    _1607_recOwned = _out1041;
                    _1608_recErased = _out1042;
                    _1609_recIdents = _out1043;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1606_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1607_recOwned;
                    isErased = _1608_recErased;
                    readIdents = _1609_recIdents;
                  }
                } else if (_source57.is_Seq) {
                  DAST._IType _1610___mcc_h748 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1611_recursiveGen;
                    bool _1612_recOwned;
                    bool _1613_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1614_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1044;
                    bool _out1045;
                    bool _out1046;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1047;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1044, out _out1045, out _out1046, out _out1047);
                    _1611_recursiveGen = _out1044;
                    _1612_recOwned = _out1045;
                    _1613_recErased = _out1046;
                    _1614_recIdents = _out1047;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1611_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1612_recOwned;
                    isErased = _1613_recErased;
                    readIdents = _1614_recIdents;
                  }
                } else if (_source57.is_Set) {
                  DAST._IType _1615___mcc_h750 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1616_recursiveGen;
                    bool _1617_recOwned;
                    bool _1618_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1619_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1048;
                    bool _out1049;
                    bool _out1050;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1051;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1048, out _out1049, out _out1050, out _out1051);
                    _1616_recursiveGen = _out1048;
                    _1617_recOwned = _out1049;
                    _1618_recErased = _out1050;
                    _1619_recIdents = _out1051;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1616_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1617_recOwned;
                    isErased = _1618_recErased;
                    readIdents = _1619_recIdents;
                  }
                } else if (_source57.is_Multiset) {
                  DAST._IType _1620___mcc_h752 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1621_recursiveGen;
                    bool _1622_recOwned;
                    bool _1623_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1624_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1052;
                    bool _out1053;
                    bool _out1054;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1055;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1052, out _out1053, out _out1054, out _out1055);
                    _1621_recursiveGen = _out1052;
                    _1622_recOwned = _out1053;
                    _1623_recErased = _out1054;
                    _1624_recIdents = _out1055;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1621_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1622_recOwned;
                    isErased = _1623_recErased;
                    readIdents = _1624_recIdents;
                  }
                } else if (_source57.is_Map) {
                  DAST._IType _1625___mcc_h754 = _source57.dtor_key;
                  DAST._IType _1626___mcc_h755 = _source57.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1627_recursiveGen;
                    bool _1628_recOwned;
                    bool _1629_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1630_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1056;
                    bool _out1057;
                    bool _out1058;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1059;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1056, out _out1057, out _out1058, out _out1059);
                    _1627_recursiveGen = _out1056;
                    _1628_recOwned = _out1057;
                    _1629_recErased = _out1058;
                    _1630_recIdents = _out1059;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1627_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1628_recOwned;
                    isErased = _1629_recErased;
                    readIdents = _1630_recIdents;
                  }
                } else if (_source57.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1631___mcc_h758 = _source57.dtor_args;
                  DAST._IType _1632___mcc_h759 = _source57.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1633_recursiveGen;
                    bool _1634_recOwned;
                    bool _1635_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1636_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1060;
                    bool _out1061;
                    bool _out1062;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1063;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1060, out _out1061, out _out1062, out _out1063);
                    _1633_recursiveGen = _out1060;
                    _1634_recOwned = _out1061;
                    _1635_recErased = _out1062;
                    _1636_recIdents = _out1063;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1633_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1634_recOwned;
                    isErased = _1635_recErased;
                    readIdents = _1636_recIdents;
                  }
                } else if (_source57.is_Primitive) {
                  DAST._IPrimitive _1637___mcc_h762 = _source57.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1638_recursiveGen;
                    bool _1639_recOwned;
                    bool _1640_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1641_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1064;
                    bool _out1065;
                    bool _out1066;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1067;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1064, out _out1065, out _out1066, out _out1067);
                    _1638_recursiveGen = _out1064;
                    _1639_recOwned = _out1065;
                    _1640_recErased = _out1066;
                    _1641_recIdents = _out1067;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1638_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1639_recOwned;
                    isErased = _1640_recErased;
                    readIdents = _1641_recIdents;
                  }
                } else if (_source57.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1642___mcc_h764 = _source57.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1643_recursiveGen;
                    bool _1644_recOwned;
                    bool _1645_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1646_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1068;
                    bool _out1069;
                    bool _out1070;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1068, out _out1069, out _out1070, out _out1071);
                    _1643_recursiveGen = _out1068;
                    _1644_recOwned = _out1069;
                    _1645_recErased = _out1070;
                    _1646_recIdents = _out1071;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1643_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1644_recOwned;
                    isErased = _1645_recErased;
                    readIdents = _1646_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1647___mcc_h766 = _source57.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1648_recursiveGen;
                    bool _1649_recOwned;
                    bool _1650_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1651_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1072;
                    bool _out1073;
                    bool _out1074;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                    _1648_recursiveGen = _out1072;
                    _1649_recOwned = _out1073;
                    _1650_recErased = _out1074;
                    _1651_recIdents = _out1075;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1648_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1649_recOwned;
                    isErased = _1650_recErased;
                    readIdents = _1651_recIdents;
                  }
                }
              } else if (_source50.is_Bool) {
                DAST._IType _source59 = _487___mcc_h127;
                if (_source59.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1652___mcc_h768 = _source59.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1653___mcc_h769 = _source59.dtor_typeArgs;
                  DAST._IResolvedType _1654___mcc_h770 = _source59.dtor_resolved;
                  DAST._IResolvedType _source60 = _1654___mcc_h770;
                  if (_source60.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1655___mcc_h774 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1656_recursiveGen;
                      bool _1657_recOwned;
                      bool _1658_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1659_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1076;
                      bool _out1077;
                      bool _out1078;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                      _1656_recursiveGen = _out1076;
                      _1657_recOwned = _out1077;
                      _1658_recErased = _out1078;
                      _1659_recIdents = _out1079;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1656_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1657_recOwned;
                      isErased = _1658_recErased;
                      readIdents = _1659_recIdents;
                    }
                  } else if (_source60.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1660___mcc_h776 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1661_recursiveGen;
                      bool _1662_recOwned;
                      bool _1663_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1664_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1080;
                      bool _out1081;
                      bool _out1082;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                      _1661_recursiveGen = _out1080;
                      _1662_recOwned = _out1081;
                      _1663_recErased = _out1082;
                      _1664_recIdents = _out1083;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1661_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1662_recOwned;
                      isErased = _1663_recErased;
                      readIdents = _1664_recIdents;
                    }
                  } else {
                    DAST._IType _1665___mcc_h778 = _source60.dtor_Newtype_a0;
                    DAST._IType _1666_b = _1665___mcc_h778;
                    {
                      if (object.Equals(_480_fromTpe, _1666_b)) {
                        Dafny.ISequence<Dafny.Rune> _1667_recursiveGen;
                        bool _1668_recOwned;
                        bool _1669_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1670_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1084;
                        bool _out1085;
                        bool _out1086;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                        _1667_recursiveGen = _out1084;
                        _1668_recOwned = _out1085;
                        _1669_recErased = _out1086;
                        _1670_recIdents = _out1087;
                        Dafny.ISequence<Dafny.Rune> _1671_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1088;
                        _out1088 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                        _1671_rhsType = _out1088;
                        Dafny.ISequence<Dafny.Rune> _1672_uneraseFn;
                        _1672_uneraseFn = ((_1668_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1671_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1672_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1667_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1668_recOwned;
                        isErased = false;
                        readIdents = _1670_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1089;
                        bool _out1090;
                        bool _out1091;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1092;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1666_b), _1666_b, _479_toTpe), selfIdent, @params, mustOwn, out _out1089, out _out1090, out _out1091, out _out1092);
                        s = _out1089;
                        isOwned = _out1090;
                        isErased = _out1091;
                        readIdents = _out1092;
                      }
                    }
                  }
                } else if (_source59.is_Nullable) {
                  DAST._IType _1673___mcc_h780 = _source59.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1674_recursiveGen;
                    bool _1675_recOwned;
                    bool _1676_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1677_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1093;
                    bool _out1094;
                    bool _out1095;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1096;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1093, out _out1094, out _out1095, out _out1096);
                    _1674_recursiveGen = _out1093;
                    _1675_recOwned = _out1094;
                    _1676_recErased = _out1095;
                    _1677_recIdents = _out1096;
                    if (!(_1675_recOwned)) {
                      _1674_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1674_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1674_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1676_recErased;
                    readIdents = _1677_recIdents;
                  }
                } else if (_source59.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1678___mcc_h782 = _source59.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1679_recursiveGen;
                    bool _1680_recOwned;
                    bool _1681_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1682_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1097;
                    bool _out1098;
                    bool _out1099;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1100;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1097, out _out1098, out _out1099, out _out1100);
                    _1679_recursiveGen = _out1097;
                    _1680_recOwned = _out1098;
                    _1681_recErased = _out1099;
                    _1682_recIdents = _out1100;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1679_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1680_recOwned;
                    isErased = _1681_recErased;
                    readIdents = _1682_recIdents;
                  }
                } else if (_source59.is_Array) {
                  DAST._IType _1683___mcc_h784 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1684_recursiveGen;
                    bool _1685_recOwned;
                    bool _1686_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1687_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1101;
                    bool _out1102;
                    bool _out1103;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1104;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1101, out _out1102, out _out1103, out _out1104);
                    _1684_recursiveGen = _out1101;
                    _1685_recOwned = _out1102;
                    _1686_recErased = _out1103;
                    _1687_recIdents = _out1104;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1684_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1685_recOwned;
                    isErased = _1686_recErased;
                    readIdents = _1687_recIdents;
                  }
                } else if (_source59.is_Seq) {
                  DAST._IType _1688___mcc_h786 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1689_recursiveGen;
                    bool _1690_recOwned;
                    bool _1691_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1692_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1105;
                    bool _out1106;
                    bool _out1107;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1108;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1105, out _out1106, out _out1107, out _out1108);
                    _1689_recursiveGen = _out1105;
                    _1690_recOwned = _out1106;
                    _1691_recErased = _out1107;
                    _1692_recIdents = _out1108;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1689_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1690_recOwned;
                    isErased = _1691_recErased;
                    readIdents = _1692_recIdents;
                  }
                } else if (_source59.is_Set) {
                  DAST._IType _1693___mcc_h788 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1694_recursiveGen;
                    bool _1695_recOwned;
                    bool _1696_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1697_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1109;
                    bool _out1110;
                    bool _out1111;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                    _1694_recursiveGen = _out1109;
                    _1695_recOwned = _out1110;
                    _1696_recErased = _out1111;
                    _1697_recIdents = _out1112;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1694_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1695_recOwned;
                    isErased = _1696_recErased;
                    readIdents = _1697_recIdents;
                  }
                } else if (_source59.is_Multiset) {
                  DAST._IType _1698___mcc_h790 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1699_recursiveGen;
                    bool _1700_recOwned;
                    bool _1701_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1702_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1113;
                    bool _out1114;
                    bool _out1115;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                    _1699_recursiveGen = _out1113;
                    _1700_recOwned = _out1114;
                    _1701_recErased = _out1115;
                    _1702_recIdents = _out1116;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1699_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1700_recOwned;
                    isErased = _1701_recErased;
                    readIdents = _1702_recIdents;
                  }
                } else if (_source59.is_Map) {
                  DAST._IType _1703___mcc_h792 = _source59.dtor_key;
                  DAST._IType _1704___mcc_h793 = _source59.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1705_recursiveGen;
                    bool _1706_recOwned;
                    bool _1707_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1708_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1117;
                    bool _out1118;
                    bool _out1119;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                    _1705_recursiveGen = _out1117;
                    _1706_recOwned = _out1118;
                    _1707_recErased = _out1119;
                    _1708_recIdents = _out1120;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1705_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1706_recOwned;
                    isErased = _1707_recErased;
                    readIdents = _1708_recIdents;
                  }
                } else if (_source59.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1709___mcc_h796 = _source59.dtor_args;
                  DAST._IType _1710___mcc_h797 = _source59.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1711_recursiveGen;
                    bool _1712_recOwned;
                    bool _1713_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1714_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1121;
                    bool _out1122;
                    bool _out1123;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                    _1711_recursiveGen = _out1121;
                    _1712_recOwned = _out1122;
                    _1713_recErased = _out1123;
                    _1714_recIdents = _out1124;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1712_recOwned;
                    isErased = _1713_recErased;
                    readIdents = _1714_recIdents;
                  }
                } else if (_source59.is_Primitive) {
                  DAST._IPrimitive _1715___mcc_h800 = _source59.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1716_recursiveGen;
                    bool _1717_recOwned;
                    bool _1718_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1719_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1125;
                    bool _out1126;
                    bool _out1127;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                    _1716_recursiveGen = _out1125;
                    _1717_recOwned = _out1126;
                    _1718_recErased = _out1127;
                    _1719_recIdents = _out1128;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1716_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1717_recOwned;
                    isErased = _1718_recErased;
                    readIdents = _1719_recIdents;
                  }
                } else if (_source59.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1720___mcc_h802 = _source59.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1721_recursiveGen;
                    bool _1722_recOwned;
                    bool _1723_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1724_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1129;
                    bool _out1130;
                    bool _out1131;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                    _1721_recursiveGen = _out1129;
                    _1722_recOwned = _out1130;
                    _1723_recErased = _out1131;
                    _1724_recIdents = _out1132;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1721_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1722_recOwned;
                    isErased = _1723_recErased;
                    readIdents = _1724_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1725___mcc_h804 = _source59.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1726_recursiveGen;
                    bool _1727_recOwned;
                    bool _1728_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1729_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1133;
                    bool _out1134;
                    bool _out1135;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                    _1726_recursiveGen = _out1133;
                    _1727_recOwned = _out1134;
                    _1728_recErased = _out1135;
                    _1729_recIdents = _out1136;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1726_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1727_recOwned;
                    isErased = _1728_recErased;
                    readIdents = _1729_recIdents;
                  }
                }
              } else {
                DAST._IType _source61 = _487___mcc_h127;
                if (_source61.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1730___mcc_h806 = _source61.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1731___mcc_h807 = _source61.dtor_typeArgs;
                  DAST._IResolvedType _1732___mcc_h808 = _source61.dtor_resolved;
                  DAST._IResolvedType _source62 = _1732___mcc_h808;
                  if (_source62.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1733___mcc_h812 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1734_recursiveGen;
                      bool _1735_recOwned;
                      bool _1736_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1737_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1137;
                      bool _out1138;
                      bool _out1139;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                      _1734_recursiveGen = _out1137;
                      _1735_recOwned = _out1138;
                      _1736_recErased = _out1139;
                      _1737_recIdents = _out1140;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1734_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1735_recOwned;
                      isErased = _1736_recErased;
                      readIdents = _1737_recIdents;
                    }
                  } else if (_source62.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1738___mcc_h814 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1739_recursiveGen;
                      bool _1740_recOwned;
                      bool _1741_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1742_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1141;
                      bool _out1142;
                      bool _out1143;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1144;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1141, out _out1142, out _out1143, out _out1144);
                      _1739_recursiveGen = _out1141;
                      _1740_recOwned = _out1142;
                      _1741_recErased = _out1143;
                      _1742_recIdents = _out1144;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1739_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1740_recOwned;
                      isErased = _1741_recErased;
                      readIdents = _1742_recIdents;
                    }
                  } else {
                    DAST._IType _1743___mcc_h816 = _source62.dtor_Newtype_a0;
                    DAST._IType _1744_b = _1743___mcc_h816;
                    {
                      if (object.Equals(_480_fromTpe, _1744_b)) {
                        Dafny.ISequence<Dafny.Rune> _1745_recursiveGen;
                        bool _1746_recOwned;
                        bool _1747_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1748_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1145;
                        bool _out1146;
                        bool _out1147;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1148;
                        DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1145, out _out1146, out _out1147, out _out1148);
                        _1745_recursiveGen = _out1145;
                        _1746_recOwned = _out1146;
                        _1747_recErased = _out1147;
                        _1748_recIdents = _out1148;
                        Dafny.ISequence<Dafny.Rune> _1749_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1149;
                        _out1149 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                        _1749_rhsType = _out1149;
                        Dafny.ISequence<Dafny.Rune> _1750_uneraseFn;
                        _1750_uneraseFn = ((_1746_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1749_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1750_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1745_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1746_recOwned;
                        isErased = false;
                        readIdents = _1748_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1150;
                        bool _out1151;
                        bool _out1152;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1153;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1744_b), _1744_b, _479_toTpe), selfIdent, @params, mustOwn, out _out1150, out _out1151, out _out1152, out _out1153);
                        s = _out1150;
                        isOwned = _out1151;
                        isErased = _out1152;
                        readIdents = _out1153;
                      }
                    }
                  }
                } else if (_source61.is_Nullable) {
                  DAST._IType _1751___mcc_h818 = _source61.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1752_recursiveGen;
                    bool _1753_recOwned;
                    bool _1754_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1755_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1154;
                    bool _out1155;
                    bool _out1156;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1157;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1154, out _out1155, out _out1156, out _out1157);
                    _1752_recursiveGen = _out1154;
                    _1753_recOwned = _out1155;
                    _1754_recErased = _out1156;
                    _1755_recIdents = _out1157;
                    if (!(_1753_recOwned)) {
                      _1752_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1752_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1752_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1754_recErased;
                    readIdents = _1755_recIdents;
                  }
                } else if (_source61.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1756___mcc_h820 = _source61.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1757_recursiveGen;
                    bool _1758_recOwned;
                    bool _1759_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1760_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1158;
                    bool _out1159;
                    bool _out1160;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                    _1757_recursiveGen = _out1158;
                    _1758_recOwned = _out1159;
                    _1759_recErased = _out1160;
                    _1760_recIdents = _out1161;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1757_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1758_recOwned;
                    isErased = _1759_recErased;
                    readIdents = _1760_recIdents;
                  }
                } else if (_source61.is_Array) {
                  DAST._IType _1761___mcc_h822 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1762_recursiveGen;
                    bool _1763_recOwned;
                    bool _1764_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1765_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1162;
                    bool _out1163;
                    bool _out1164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                    _1762_recursiveGen = _out1162;
                    _1763_recOwned = _out1163;
                    _1764_recErased = _out1164;
                    _1765_recIdents = _out1165;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1762_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1763_recOwned;
                    isErased = _1764_recErased;
                    readIdents = _1765_recIdents;
                  }
                } else if (_source61.is_Seq) {
                  DAST._IType _1766___mcc_h824 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1767_recursiveGen;
                    bool _1768_recOwned;
                    bool _1769_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1770_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1166;
                    bool _out1167;
                    bool _out1168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1169;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1166, out _out1167, out _out1168, out _out1169);
                    _1767_recursiveGen = _out1166;
                    _1768_recOwned = _out1167;
                    _1769_recErased = _out1168;
                    _1770_recIdents = _out1169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1767_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1768_recOwned;
                    isErased = _1769_recErased;
                    readIdents = _1770_recIdents;
                  }
                } else if (_source61.is_Set) {
                  DAST._IType _1771___mcc_h826 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1772_recursiveGen;
                    bool _1773_recOwned;
                    bool _1774_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1775_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1170;
                    bool _out1171;
                    bool _out1172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1173;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1170, out _out1171, out _out1172, out _out1173);
                    _1772_recursiveGen = _out1170;
                    _1773_recOwned = _out1171;
                    _1774_recErased = _out1172;
                    _1775_recIdents = _out1173;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1772_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1773_recOwned;
                    isErased = _1774_recErased;
                    readIdents = _1775_recIdents;
                  }
                } else if (_source61.is_Multiset) {
                  DAST._IType _1776___mcc_h828 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1777_recursiveGen;
                    bool _1778_recOwned;
                    bool _1779_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1780_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1174;
                    bool _out1175;
                    bool _out1176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1177;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1174, out _out1175, out _out1176, out _out1177);
                    _1777_recursiveGen = _out1174;
                    _1778_recOwned = _out1175;
                    _1779_recErased = _out1176;
                    _1780_recIdents = _out1177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1777_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1778_recOwned;
                    isErased = _1779_recErased;
                    readIdents = _1780_recIdents;
                  }
                } else if (_source61.is_Map) {
                  DAST._IType _1781___mcc_h830 = _source61.dtor_key;
                  DAST._IType _1782___mcc_h831 = _source61.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1783_recursiveGen;
                    bool _1784_recOwned;
                    bool _1785_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1786_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1178;
                    bool _out1179;
                    bool _out1180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1181;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1178, out _out1179, out _out1180, out _out1181);
                    _1783_recursiveGen = _out1178;
                    _1784_recOwned = _out1179;
                    _1785_recErased = _out1180;
                    _1786_recIdents = _out1181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1783_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1784_recOwned;
                    isErased = _1785_recErased;
                    readIdents = _1786_recIdents;
                  }
                } else if (_source61.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1787___mcc_h834 = _source61.dtor_args;
                  DAST._IType _1788___mcc_h835 = _source61.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1789_recursiveGen;
                    bool _1790_recOwned;
                    bool _1791_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1792_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1182;
                    bool _out1183;
                    bool _out1184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1185;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1182, out _out1183, out _out1184, out _out1185);
                    _1789_recursiveGen = _out1182;
                    _1790_recOwned = _out1183;
                    _1791_recErased = _out1184;
                    _1792_recIdents = _out1185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1789_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1790_recOwned;
                    isErased = _1791_recErased;
                    readIdents = _1792_recIdents;
                  }
                } else if (_source61.is_Primitive) {
                  DAST._IPrimitive _1793___mcc_h838 = _source61.dtor_Primitive_a0;
                  DAST._IPrimitive _source63 = _1793___mcc_h838;
                  if (_source63.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1794_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1186;
                      _out1186 = DCOMP.COMP.GenType(_480_fromTpe, true, false);
                      _1794_rhsType = _out1186;
                      Dafny.ISequence<Dafny.Rune> _1795_recursiveGen;
                      bool _1796___v55;
                      bool _1797___v56;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1798_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1187;
                      bool _out1188;
                      bool _out1189;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1190;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, true, out _out1187, out _out1188, out _out1189, out _out1190);
                      _1795_recursiveGen = _out1187;
                      _1796___v55 = _out1188;
                      _1797___v56 = _out1189;
                      _1798_recIdents = _out1190;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1795_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1798_recIdents;
                    }
                  } else if (_source63.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1799_recursiveGen;
                      bool _1800_recOwned;
                      bool _1801_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1802_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1191;
                      bool _out1192;
                      bool _out1193;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1194;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1191, out _out1192, out _out1193, out _out1194);
                      _1799_recursiveGen = _out1191;
                      _1800_recOwned = _out1192;
                      _1801_recErased = _out1193;
                      _1802_recIdents = _out1194;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1799_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1800_recOwned;
                      isErased = _1801_recErased;
                      readIdents = _1802_recIdents;
                    }
                  } else if (_source63.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1803_recursiveGen;
                      bool _1804_recOwned;
                      bool _1805_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1806_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1195;
                      bool _out1196;
                      bool _out1197;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1198;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1195, out _out1196, out _out1197, out _out1198);
                      _1803_recursiveGen = _out1195;
                      _1804_recOwned = _out1196;
                      _1805_recErased = _out1197;
                      _1806_recIdents = _out1198;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1803_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1804_recOwned;
                      isErased = _1805_recErased;
                      readIdents = _1806_recIdents;
                    }
                  } else if (_source63.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1807_recursiveGen;
                      bool _1808_recOwned;
                      bool _1809_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1810_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1199;
                      bool _out1200;
                      bool _out1201;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1202;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1199, out _out1200, out _out1201, out _out1202);
                      _1807_recursiveGen = _out1199;
                      _1808_recOwned = _out1200;
                      _1809_recErased = _out1201;
                      _1810_recIdents = _out1202;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1807_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1808_recOwned;
                      isErased = _1809_recErased;
                      readIdents = _1810_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1811_recursiveGen;
                      bool _1812_recOwned;
                      bool _1813_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1814_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      bool _out1204;
                      bool _out1205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1206;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1203, out _out1204, out _out1205, out _out1206);
                      _1811_recursiveGen = _out1203;
                      _1812_recOwned = _out1204;
                      _1813_recErased = _out1205;
                      _1814_recIdents = _out1206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1811_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1812_recOwned;
                      isErased = _1813_recErased;
                      readIdents = _1814_recIdents;
                    }
                  }
                } else if (_source61.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1815___mcc_h840 = _source61.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1816_recursiveGen;
                    bool _1817_recOwned;
                    bool _1818_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1819_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1207;
                    bool _out1208;
                    bool _out1209;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1210;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1207, out _out1208, out _out1209, out _out1210);
                    _1816_recursiveGen = _out1207;
                    _1817_recOwned = _out1208;
                    _1818_recErased = _out1209;
                    _1819_recIdents = _out1210;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1816_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1817_recOwned;
                    isErased = _1818_recErased;
                    readIdents = _1819_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1820___mcc_h842 = _source61.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1821_recursiveGen;
                    bool _1822_recOwned;
                    bool _1823_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1824_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1211;
                    bool _out1212;
                    bool _out1213;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1214;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1211, out _out1212, out _out1213, out _out1214);
                    _1821_recursiveGen = _out1211;
                    _1822_recOwned = _out1212;
                    _1823_recErased = _out1213;
                    _1824_recIdents = _out1214;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1821_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1822_recOwned;
                    isErased = _1823_recErased;
                    readIdents = _1824_recIdents;
                  }
                }
              }
            } else if (_source26.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1825___mcc_h844 = _source26.dtor_Passthrough_a0;
              DAST._IType _source64 = _487___mcc_h127;
              if (_source64.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1826___mcc_h848 = _source64.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1827___mcc_h849 = _source64.dtor_typeArgs;
                DAST._IResolvedType _1828___mcc_h850 = _source64.dtor_resolved;
                DAST._IResolvedType _source65 = _1828___mcc_h850;
                if (_source65.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1829___mcc_h854 = _source65.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1830_recursiveGen;
                    bool _1831_recOwned;
                    bool _1832_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1833_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1215;
                    bool _out1216;
                    bool _out1217;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1218;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1215, out _out1216, out _out1217, out _out1218);
                    _1830_recursiveGen = _out1215;
                    _1831_recOwned = _out1216;
                    _1832_recErased = _out1217;
                    _1833_recIdents = _out1218;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1830_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1831_recOwned;
                    isErased = _1832_recErased;
                    readIdents = _1833_recIdents;
                  }
                } else if (_source65.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1834___mcc_h856 = _source65.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1835_recursiveGen;
                    bool _1836_recOwned;
                    bool _1837_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1838_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1219;
                    bool _out1220;
                    bool _out1221;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1222;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1219, out _out1220, out _out1221, out _out1222);
                    _1835_recursiveGen = _out1219;
                    _1836_recOwned = _out1220;
                    _1837_recErased = _out1221;
                    _1838_recIdents = _out1222;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1835_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1836_recOwned;
                    isErased = _1837_recErased;
                    readIdents = _1838_recIdents;
                  }
                } else {
                  DAST._IType _1839___mcc_h858 = _source65.dtor_Newtype_a0;
                  DAST._IType _1840_b = _1839___mcc_h858;
                  {
                    if (object.Equals(_480_fromTpe, _1840_b)) {
                      Dafny.ISequence<Dafny.Rune> _1841_recursiveGen;
                      bool _1842_recOwned;
                      bool _1843_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1844_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1223;
                      bool _out1224;
                      bool _out1225;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1226;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1223, out _out1224, out _out1225, out _out1226);
                      _1841_recursiveGen = _out1223;
                      _1842_recOwned = _out1224;
                      _1843_recErased = _out1225;
                      _1844_recIdents = _out1226;
                      Dafny.ISequence<Dafny.Rune> _1845_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1227;
                      _out1227 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _1845_rhsType = _out1227;
                      Dafny.ISequence<Dafny.Rune> _1846_uneraseFn;
                      _1846_uneraseFn = ((_1842_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1845_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1846_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1841_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1842_recOwned;
                      isErased = false;
                      readIdents = _1844_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1228;
                      bool _out1229;
                      bool _out1230;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1231;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1840_b), _1840_b, _479_toTpe), selfIdent, @params, mustOwn, out _out1228, out _out1229, out _out1230, out _out1231);
                      s = _out1228;
                      isOwned = _out1229;
                      isErased = _out1230;
                      readIdents = _out1231;
                    }
                  }
                }
              } else if (_source64.is_Nullable) {
                DAST._IType _1847___mcc_h860 = _source64.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1848_recursiveGen;
                  bool _1849_recOwned;
                  bool _1850_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1851_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1232;
                  bool _out1233;
                  bool _out1234;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1235;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1232, out _out1233, out _out1234, out _out1235);
                  _1848_recursiveGen = _out1232;
                  _1849_recOwned = _out1233;
                  _1850_recErased = _out1234;
                  _1851_recIdents = _out1235;
                  if (!(_1849_recOwned)) {
                    _1848_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1848_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1848_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1850_recErased;
                  readIdents = _1851_recIdents;
                }
              } else if (_source64.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1852___mcc_h862 = _source64.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1853_recursiveGen;
                  bool _1854_recOwned;
                  bool _1855_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1856_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1236;
                  bool _out1237;
                  bool _out1238;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1236, out _out1237, out _out1238, out _out1239);
                  _1853_recursiveGen = _out1236;
                  _1854_recOwned = _out1237;
                  _1855_recErased = _out1238;
                  _1856_recIdents = _out1239;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1853_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1854_recOwned;
                  isErased = _1855_recErased;
                  readIdents = _1856_recIdents;
                }
              } else if (_source64.is_Array) {
                DAST._IType _1857___mcc_h864 = _source64.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1858_recursiveGen;
                  bool _1859_recOwned;
                  bool _1860_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1861_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1240;
                  bool _out1241;
                  bool _out1242;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
                  _1858_recursiveGen = _out1240;
                  _1859_recOwned = _out1241;
                  _1860_recErased = _out1242;
                  _1861_recIdents = _out1243;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1858_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1859_recOwned;
                  isErased = _1860_recErased;
                  readIdents = _1861_recIdents;
                }
              } else if (_source64.is_Seq) {
                DAST._IType _1862___mcc_h866 = _source64.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1863_recursiveGen;
                  bool _1864_recOwned;
                  bool _1865_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1866_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1244;
                  bool _out1245;
                  bool _out1246;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1244, out _out1245, out _out1246, out _out1247);
                  _1863_recursiveGen = _out1244;
                  _1864_recOwned = _out1245;
                  _1865_recErased = _out1246;
                  _1866_recIdents = _out1247;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1863_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1864_recOwned;
                  isErased = _1865_recErased;
                  readIdents = _1866_recIdents;
                }
              } else if (_source64.is_Set) {
                DAST._IType _1867___mcc_h868 = _source64.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1868_recursiveGen;
                  bool _1869_recOwned;
                  bool _1870_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1871_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1248;
                  bool _out1249;
                  bool _out1250;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1248, out _out1249, out _out1250, out _out1251);
                  _1868_recursiveGen = _out1248;
                  _1869_recOwned = _out1249;
                  _1870_recErased = _out1250;
                  _1871_recIdents = _out1251;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1868_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1869_recOwned;
                  isErased = _1870_recErased;
                  readIdents = _1871_recIdents;
                }
              } else if (_source64.is_Multiset) {
                DAST._IType _1872___mcc_h870 = _source64.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1873_recursiveGen;
                  bool _1874_recOwned;
                  bool _1875_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1876_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1252;
                  bool _out1253;
                  bool _out1254;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1252, out _out1253, out _out1254, out _out1255);
                  _1873_recursiveGen = _out1252;
                  _1874_recOwned = _out1253;
                  _1875_recErased = _out1254;
                  _1876_recIdents = _out1255;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1873_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1874_recOwned;
                  isErased = _1875_recErased;
                  readIdents = _1876_recIdents;
                }
              } else if (_source64.is_Map) {
                DAST._IType _1877___mcc_h872 = _source64.dtor_key;
                DAST._IType _1878___mcc_h873 = _source64.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1879_recursiveGen;
                  bool _1880_recOwned;
                  bool _1881_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1882_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1256;
                  bool _out1257;
                  bool _out1258;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1256, out _out1257, out _out1258, out _out1259);
                  _1879_recursiveGen = _out1256;
                  _1880_recOwned = _out1257;
                  _1881_recErased = _out1258;
                  _1882_recIdents = _out1259;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1879_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1880_recOwned;
                  isErased = _1881_recErased;
                  readIdents = _1882_recIdents;
                }
              } else if (_source64.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1883___mcc_h876 = _source64.dtor_args;
                DAST._IType _1884___mcc_h877 = _source64.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1885_recursiveGen;
                  bool _1886_recOwned;
                  bool _1887_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1888_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1260;
                  bool _out1261;
                  bool _out1262;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1260, out _out1261, out _out1262, out _out1263);
                  _1885_recursiveGen = _out1260;
                  _1886_recOwned = _out1261;
                  _1887_recErased = _out1262;
                  _1888_recIdents = _out1263;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1885_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1886_recOwned;
                  isErased = _1887_recErased;
                  readIdents = _1888_recIdents;
                }
              } else if (_source64.is_Primitive) {
                DAST._IPrimitive _1889___mcc_h880 = _source64.dtor_Primitive_a0;
                DAST._IPrimitive _source66 = _1889___mcc_h880;
                if (_source66.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1890_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1264;
                    _out1264 = DCOMP.COMP.GenType(_480_fromTpe, true, false);
                    _1890_rhsType = _out1264;
                    Dafny.ISequence<Dafny.Rune> _1891_recursiveGen;
                    bool _1892___v51;
                    bool _1893___v52;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1894_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1265;
                    bool _out1266;
                    bool _out1267;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1268;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, true, out _out1265, out _out1266, out _out1267, out _out1268);
                    _1891_recursiveGen = _out1265;
                    _1892___v51 = _out1266;
                    _1893___v52 = _out1267;
                    _1894_recIdents = _out1268;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1891_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1894_recIdents;
                  }
                } else if (_source66.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1895_recursiveGen;
                    bool _1896_recOwned;
                    bool _1897_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1898_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1269;
                    bool _out1270;
                    bool _out1271;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1272;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1269, out _out1270, out _out1271, out _out1272);
                    _1895_recursiveGen = _out1269;
                    _1896_recOwned = _out1270;
                    _1897_recErased = _out1271;
                    _1898_recIdents = _out1272;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1895_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1896_recOwned;
                    isErased = _1897_recErased;
                    readIdents = _1898_recIdents;
                  }
                } else if (_source66.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1899_recursiveGen;
                    bool _1900_recOwned;
                    bool _1901_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1902_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1273;
                    bool _out1274;
                    bool _out1275;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1276;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1273, out _out1274, out _out1275, out _out1276);
                    _1899_recursiveGen = _out1273;
                    _1900_recOwned = _out1274;
                    _1901_recErased = _out1275;
                    _1902_recIdents = _out1276;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1899_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1900_recOwned;
                    isErased = _1901_recErased;
                    readIdents = _1902_recIdents;
                  }
                } else if (_source66.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1903_recursiveGen;
                    bool _1904_recOwned;
                    bool _1905_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1906_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1277;
                    bool _out1278;
                    bool _out1279;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1280;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1277, out _out1278, out _out1279, out _out1280);
                    _1903_recursiveGen = _out1277;
                    _1904_recOwned = _out1278;
                    _1905_recErased = _out1279;
                    _1906_recIdents = _out1280;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1903_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1904_recOwned;
                    isErased = _1905_recErased;
                    readIdents = _1906_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1907_recursiveGen;
                    bool _1908_recOwned;
                    bool _1909_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1910_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    bool _out1282;
                    bool _out1283;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1284;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1281, out _out1282, out _out1283, out _out1284);
                    _1907_recursiveGen = _out1281;
                    _1908_recOwned = _out1282;
                    _1909_recErased = _out1283;
                    _1910_recIdents = _out1284;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1907_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1908_recOwned;
                    isErased = _1909_recErased;
                    readIdents = _1910_recIdents;
                  }
                }
              } else if (_source64.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1911___mcc_h882 = _source64.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1912_recursiveGen;
                  bool _1913___v59;
                  bool _1914___v60;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1915_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1285;
                  bool _out1286;
                  bool _out1287;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1288;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, true, out _out1285, out _out1286, out _out1287, out _out1288);
                  _1912_recursiveGen = _out1285;
                  _1913___v59 = _out1286;
                  _1914___v60 = _out1287;
                  _1915_recIdents = _out1288;
                  Dafny.ISequence<Dafny.Rune> _1916_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1289;
                  _out1289 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                  _1916_toTpeGen = _out1289;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1912_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1916_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1915_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1917___mcc_h884 = _source64.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1918_recursiveGen;
                  bool _1919_recOwned;
                  bool _1920_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1921_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1290;
                  bool _out1291;
                  bool _out1292;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1293;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1290, out _out1291, out _out1292, out _out1293);
                  _1918_recursiveGen = _out1290;
                  _1919_recOwned = _out1291;
                  _1920_recErased = _out1292;
                  _1921_recIdents = _out1293;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1918_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1919_recOwned;
                  isErased = _1920_recErased;
                  readIdents = _1921_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1922___mcc_h886 = _source26.dtor_TypeArg_a0;
              DAST._IType _source67 = _487___mcc_h127;
              if (_source67.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1923___mcc_h890 = _source67.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1924___mcc_h891 = _source67.dtor_typeArgs;
                DAST._IResolvedType _1925___mcc_h892 = _source67.dtor_resolved;
                DAST._IResolvedType _source68 = _1925___mcc_h892;
                if (_source68.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1926___mcc_h896 = _source68.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1927_recursiveGen;
                    bool _1928_recOwned;
                    bool _1929_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1930_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1294;
                    bool _out1295;
                    bool _out1296;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1297;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1294, out _out1295, out _out1296, out _out1297);
                    _1927_recursiveGen = _out1294;
                    _1928_recOwned = _out1295;
                    _1929_recErased = _out1296;
                    _1930_recIdents = _out1297;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1927_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1928_recOwned;
                    isErased = _1929_recErased;
                    readIdents = _1930_recIdents;
                  }
                } else if (_source68.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1931___mcc_h898 = _source68.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1932_recursiveGen;
                    bool _1933_recOwned;
                    bool _1934_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1935_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1298;
                    bool _out1299;
                    bool _out1300;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1301;
                    DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1298, out _out1299, out _out1300, out _out1301);
                    _1932_recursiveGen = _out1298;
                    _1933_recOwned = _out1299;
                    _1934_recErased = _out1300;
                    _1935_recIdents = _out1301;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1932_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1933_recOwned;
                    isErased = _1934_recErased;
                    readIdents = _1935_recIdents;
                  }
                } else {
                  DAST._IType _1936___mcc_h900 = _source68.dtor_Newtype_a0;
                  DAST._IType _1937_b = _1936___mcc_h900;
                  {
                    if (object.Equals(_480_fromTpe, _1937_b)) {
                      Dafny.ISequence<Dafny.Rune> _1938_recursiveGen;
                      bool _1939_recOwned;
                      bool _1940_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1941_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1302;
                      bool _out1303;
                      bool _out1304;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
                      DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1302, out _out1303, out _out1304, out _out1305);
                      _1938_recursiveGen = _out1302;
                      _1939_recOwned = _out1303;
                      _1940_recErased = _out1304;
                      _1941_recIdents = _out1305;
                      Dafny.ISequence<Dafny.Rune> _1942_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1306;
                      _out1306 = DCOMP.COMP.GenType(_479_toTpe, true, false);
                      _1942_rhsType = _out1306;
                      Dafny.ISequence<Dafny.Rune> _1943_uneraseFn;
                      _1943_uneraseFn = ((_1939_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1942_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1943_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1938_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1939_recOwned;
                      isErased = false;
                      readIdents = _1941_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1307;
                      bool _out1308;
                      bool _out1309;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1310;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_481_expr, _480_fromTpe, _1937_b), _1937_b, _479_toTpe), selfIdent, @params, mustOwn, out _out1307, out _out1308, out _out1309, out _out1310);
                      s = _out1307;
                      isOwned = _out1308;
                      isErased = _out1309;
                      readIdents = _out1310;
                    }
                  }
                }
              } else if (_source67.is_Nullable) {
                DAST._IType _1944___mcc_h902 = _source67.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1945_recursiveGen;
                  bool _1946_recOwned;
                  bool _1947_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1948_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1311;
                  bool _out1312;
                  bool _out1313;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1314;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1311, out _out1312, out _out1313, out _out1314);
                  _1945_recursiveGen = _out1311;
                  _1946_recOwned = _out1312;
                  _1947_recErased = _out1313;
                  _1948_recIdents = _out1314;
                  if (!(_1946_recOwned)) {
                    _1945_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1945_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1945_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1947_recErased;
                  readIdents = _1948_recIdents;
                }
              } else if (_source67.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1949___mcc_h904 = _source67.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1950_recursiveGen;
                  bool _1951_recOwned;
                  bool _1952_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1953_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1315;
                  bool _out1316;
                  bool _out1317;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1318;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1315, out _out1316, out _out1317, out _out1318);
                  _1950_recursiveGen = _out1315;
                  _1951_recOwned = _out1316;
                  _1952_recErased = _out1317;
                  _1953_recIdents = _out1318;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1950_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1951_recOwned;
                  isErased = _1952_recErased;
                  readIdents = _1953_recIdents;
                }
              } else if (_source67.is_Array) {
                DAST._IType _1954___mcc_h906 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1955_recursiveGen;
                  bool _1956_recOwned;
                  bool _1957_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1958_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1319;
                  bool _out1320;
                  bool _out1321;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1322;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1319, out _out1320, out _out1321, out _out1322);
                  _1955_recursiveGen = _out1319;
                  _1956_recOwned = _out1320;
                  _1957_recErased = _out1321;
                  _1958_recIdents = _out1322;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1955_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1956_recOwned;
                  isErased = _1957_recErased;
                  readIdents = _1958_recIdents;
                }
              } else if (_source67.is_Seq) {
                DAST._IType _1959___mcc_h908 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1960_recursiveGen;
                  bool _1961_recOwned;
                  bool _1962_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1963_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1323;
                  bool _out1324;
                  bool _out1325;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1326;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1323, out _out1324, out _out1325, out _out1326);
                  _1960_recursiveGen = _out1323;
                  _1961_recOwned = _out1324;
                  _1962_recErased = _out1325;
                  _1963_recIdents = _out1326;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1960_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1961_recOwned;
                  isErased = _1962_recErased;
                  readIdents = _1963_recIdents;
                }
              } else if (_source67.is_Set) {
                DAST._IType _1964___mcc_h910 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1965_recursiveGen;
                  bool _1966_recOwned;
                  bool _1967_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1968_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1327;
                  bool _out1328;
                  bool _out1329;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1330;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1327, out _out1328, out _out1329, out _out1330);
                  _1965_recursiveGen = _out1327;
                  _1966_recOwned = _out1328;
                  _1967_recErased = _out1329;
                  _1968_recIdents = _out1330;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1965_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1966_recOwned;
                  isErased = _1967_recErased;
                  readIdents = _1968_recIdents;
                }
              } else if (_source67.is_Multiset) {
                DAST._IType _1969___mcc_h912 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1970_recursiveGen;
                  bool _1971_recOwned;
                  bool _1972_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1973_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1331;
                  bool _out1332;
                  bool _out1333;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1334;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1331, out _out1332, out _out1333, out _out1334);
                  _1970_recursiveGen = _out1331;
                  _1971_recOwned = _out1332;
                  _1972_recErased = _out1333;
                  _1973_recIdents = _out1334;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1970_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1971_recOwned;
                  isErased = _1972_recErased;
                  readIdents = _1973_recIdents;
                }
              } else if (_source67.is_Map) {
                DAST._IType _1974___mcc_h914 = _source67.dtor_key;
                DAST._IType _1975___mcc_h915 = _source67.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1976_recursiveGen;
                  bool _1977_recOwned;
                  bool _1978_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1979_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1335;
                  bool _out1336;
                  bool _out1337;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1338;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1335, out _out1336, out _out1337, out _out1338);
                  _1976_recursiveGen = _out1335;
                  _1977_recOwned = _out1336;
                  _1978_recErased = _out1337;
                  _1979_recIdents = _out1338;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1976_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1977_recOwned;
                  isErased = _1978_recErased;
                  readIdents = _1979_recIdents;
                }
              } else if (_source67.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1980___mcc_h918 = _source67.dtor_args;
                DAST._IType _1981___mcc_h919 = _source67.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1982_recursiveGen;
                  bool _1983_recOwned;
                  bool _1984_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1985_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1339;
                  bool _out1340;
                  bool _out1341;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1342;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1339, out _out1340, out _out1341, out _out1342);
                  _1982_recursiveGen = _out1339;
                  _1983_recOwned = _out1340;
                  _1984_recErased = _out1341;
                  _1985_recIdents = _out1342;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1983_recOwned;
                  isErased = _1984_recErased;
                  readIdents = _1985_recIdents;
                }
              } else if (_source67.is_Primitive) {
                DAST._IPrimitive _1986___mcc_h922 = _source67.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1987_recursiveGen;
                  bool _1988_recOwned;
                  bool _1989_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1990_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1343;
                  bool _out1344;
                  bool _out1345;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1346;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1343, out _out1344, out _out1345, out _out1346);
                  _1987_recursiveGen = _out1343;
                  _1988_recOwned = _out1344;
                  _1989_recErased = _out1345;
                  _1990_recIdents = _out1346;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1987_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1988_recOwned;
                  isErased = _1989_recErased;
                  readIdents = _1990_recIdents;
                }
              } else if (_source67.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1991___mcc_h924 = _source67.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1992_recursiveGen;
                  bool _1993_recOwned;
                  bool _1994_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1995_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1347;
                  bool _out1348;
                  bool _out1349;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1350;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1347, out _out1348, out _out1349, out _out1350);
                  _1992_recursiveGen = _out1347;
                  _1993_recOwned = _out1348;
                  _1994_recErased = _out1349;
                  _1995_recIdents = _out1350;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1992_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1993_recOwned;
                  isErased = _1994_recErased;
                  readIdents = _1995_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1996___mcc_h926 = _source67.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1997_recursiveGen;
                  bool _1998_recOwned;
                  bool _1999_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2000_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1351;
                  bool _out1352;
                  bool _out1353;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1354;
                  DCOMP.COMP.GenExpr(_481_expr, selfIdent, @params, mustOwn, out _out1351, out _out1352, out _out1353, out _out1354);
                  _1997_recursiveGen = _out1351;
                  _1998_recOwned = _out1352;
                  _1999_recErased = _out1353;
                  _2000_recIdents = _out1354;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1997_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1998_recOwned;
                  isErased = _1999_recErased;
                  readIdents = _2000_recIdents;
                }
              }
            }
          }
        }
      } else if (_source19.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2001___mcc_h22 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2002_exprs = _2001___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2003_generatedValues;
          _2003_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2004_i;
          _2004_i = BigInteger.Zero;
          bool _2005_allErased;
          _2005_allErased = true;
          while ((_2004_i) < (new BigInteger((_2002_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2006_recursiveGen;
            bool _2007___v62;
            bool _2008_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2009_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1355;
            bool _out1356;
            bool _out1357;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1358;
            DCOMP.COMP.GenExpr((_2002_exprs).Select(_2004_i), selfIdent, @params, true, out _out1355, out _out1356, out _out1357, out _out1358);
            _2006_recursiveGen = _out1355;
            _2007___v62 = _out1356;
            _2008_isErased = _out1357;
            _2009_recIdents = _out1358;
            _2005_allErased = (_2005_allErased) && (_2008_isErased);
            _2003_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2003_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2006_recursiveGen, _2008_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2009_recIdents);
            _2004_i = (_2004_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2004_i = BigInteger.Zero;
          while ((_2004_i) < (new BigInteger((_2003_generatedValues).Count))) {
            if ((_2004_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2010_gen;
            _2010_gen = ((_2003_generatedValues).Select(_2004_i)).dtor__0;
            if ((((_2003_generatedValues).Select(_2004_i)).dtor__1) && (!(_2005_allErased))) {
              _2010_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2010_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2010_gen);
            _2004_i = (_2004_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2005_allErased;
        }
      } else if (_source19.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2011___mcc_h23 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2012_exprs = _2011___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2013_generatedValues;
          _2013_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2014_i;
          _2014_i = BigInteger.Zero;
          bool _2015_allErased;
          _2015_allErased = true;
          while ((_2014_i) < (new BigInteger((_2012_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2016_recursiveGen;
            bool _2017___v63;
            bool _2018_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2019_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1359;
            bool _out1360;
            bool _out1361;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1362;
            DCOMP.COMP.GenExpr((_2012_exprs).Select(_2014_i), selfIdent, @params, true, out _out1359, out _out1360, out _out1361, out _out1362);
            _2016_recursiveGen = _out1359;
            _2017___v63 = _out1360;
            _2018_isErased = _out1361;
            _2019_recIdents = _out1362;
            _2015_allErased = (_2015_allErased) && (_2018_isErased);
            _2013_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2013_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2016_recursiveGen, _2018_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2019_recIdents);
            _2014_i = (_2014_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2014_i = BigInteger.Zero;
          while ((_2014_i) < (new BigInteger((_2013_generatedValues).Count))) {
            if ((_2014_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2020_gen;
            _2020_gen = ((_2013_generatedValues).Select(_2014_i)).dtor__0;
            if ((((_2013_generatedValues).Select(_2014_i)).dtor__1) && (!(_2015_allErased))) {
              _2020_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2020_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2020_gen);
            _2014_i = (_2014_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source69 = selfIdent;
          if (_source69.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2021___mcc_h928 = _source69.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2022_id = _2021___mcc_h928;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2022_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2022_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2022_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2022_id);
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
        DAST._IExpression _2023___mcc_h24 = _source19.dtor_cond;
        DAST._IExpression _2024___mcc_h25 = _source19.dtor_thn;
        DAST._IExpression _2025___mcc_h26 = _source19.dtor_els;
        DAST._IExpression _2026_f = _2025___mcc_h26;
        DAST._IExpression _2027_t = _2024___mcc_h25;
        DAST._IExpression _2028_cond = _2023___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _2029_condString;
          bool _2030___v64;
          bool _2031_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2032_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1363;
          bool _out1364;
          bool _out1365;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1366;
          DCOMP.COMP.GenExpr(_2028_cond, selfIdent, @params, true, out _out1363, out _out1364, out _out1365, out _out1366);
          _2029_condString = _out1363;
          _2030___v64 = _out1364;
          _2031_condErased = _out1365;
          _2032_recIdentsCond = _out1366;
          if (!(_2031_condErased)) {
            _2029_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2029_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2033___v65;
          bool _2034_tHasToBeOwned;
          bool _2035___v66;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2036___v67;
          Dafny.ISequence<Dafny.Rune> _out1367;
          bool _out1368;
          bool _out1369;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1370;
          DCOMP.COMP.GenExpr(_2027_t, selfIdent, @params, mustOwn, out _out1367, out _out1368, out _out1369, out _out1370);
          _2033___v65 = _out1367;
          _2034_tHasToBeOwned = _out1368;
          _2035___v66 = _out1369;
          _2036___v67 = _out1370;
          Dafny.ISequence<Dafny.Rune> _2037_fString;
          bool _2038_fOwned;
          bool _2039_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2040_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1371;
          bool _out1372;
          bool _out1373;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1374;
          DCOMP.COMP.GenExpr(_2026_f, selfIdent, @params, _2034_tHasToBeOwned, out _out1371, out _out1372, out _out1373, out _out1374);
          _2037_fString = _out1371;
          _2038_fOwned = _out1372;
          _2039_fErased = _out1373;
          _2040_recIdentsF = _out1374;
          Dafny.ISequence<Dafny.Rune> _2041_tString;
          bool _2042___v68;
          bool _2043_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2044_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1375;
          bool _out1376;
          bool _out1377;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1378;
          DCOMP.COMP.GenExpr(_2027_t, selfIdent, @params, _2038_fOwned, out _out1375, out _out1376, out _out1377, out _out1378);
          _2041_tString = _out1375;
          _2042___v68 = _out1376;
          _2043_tErased = _out1377;
          _2044_recIdentsT = _out1378;
          if ((!(_2039_fErased)) || (!(_2043_tErased))) {
            if (_2039_fErased) {
              _2037_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2037_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2043_tErased) {
              _2041_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2041_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2029_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2041_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2037_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2038_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2032_recIdentsCond, _2044_recIdentsT), _2040_recIdentsF);
          isErased = (_2039_fErased) || (_2043_tErased);
        }
      } else if (_source19.is_UnOp) {
        DAST._IUnaryOp _2045___mcc_h27 = _source19.dtor_unOp;
        DAST._IExpression _2046___mcc_h28 = _source19.dtor_expr;
        DAST._IUnaryOp _source70 = _2045___mcc_h27;
        if (_source70.is_Not) {
          DAST._IExpression _2047_e = _2046___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2048_recursiveGen;
            bool _2049___v69;
            bool _2050_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2051_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1379;
            bool _out1380;
            bool _out1381;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1382;
            DCOMP.COMP.GenExpr(_2047_e, selfIdent, @params, true, out _out1379, out _out1380, out _out1381, out _out1382);
            _2048_recursiveGen = _out1379;
            _2049___v69 = _out1380;
            _2050_recErased = _out1381;
            _2051_recIdents = _out1382;
            if (!(_2050_recErased)) {
              _2048_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2048_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2048_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2051_recIdents;
            isErased = true;
          }
        } else if (_source70.is_BitwiseNot) {
          DAST._IExpression _2052_e = _2046___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2053_recursiveGen;
            bool _2054___v70;
            bool _2055_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2056_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1383;
            bool _out1384;
            bool _out1385;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1386;
            DCOMP.COMP.GenExpr(_2052_e, selfIdent, @params, true, out _out1383, out _out1384, out _out1385, out _out1386);
            _2053_recursiveGen = _out1383;
            _2054___v70 = _out1384;
            _2055_recErased = _out1385;
            _2056_recIdents = _out1386;
            if (!(_2055_recErased)) {
              _2053_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2053_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2053_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2056_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2057_e = _2046___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2058_recursiveGen;
            bool _2059_recOwned;
            bool _2060_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2061_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1387;
            bool _out1388;
            bool _out1389;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1390;
            DCOMP.COMP.GenExpr(_2057_e, selfIdent, @params, false, out _out1387, out _out1388, out _out1389, out _out1390);
            _2058_recursiveGen = _out1387;
            _2059_recOwned = _out1388;
            _2060_recErased = _out1389;
            _2061_recIdents = _out1390;
            if (!(_2060_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2062_eraseFn;
              _2062_eraseFn = ((_2059_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2058_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2062_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2058_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2058_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2061_recIdents;
            isErased = true;
          }
        }
      } else if (_source19.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2063___mcc_h29 = _source19.dtor_op;
        DAST._IExpression _2064___mcc_h30 = _source19.dtor_left;
        DAST._IExpression _2065___mcc_h31 = _source19.dtor_right;
        DAST._IExpression _2066_r = _2065___mcc_h31;
        DAST._IExpression _2067_l = _2064___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _2068_op = _2063___mcc_h29;
        {
          Dafny.ISequence<Dafny.Rune> _2069_left;
          bool _2070___v71;
          bool _2071_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2072_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1391;
          bool _out1392;
          bool _out1393;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1394;
          DCOMP.COMP.GenExpr(_2067_l, selfIdent, @params, true, out _out1391, out _out1392, out _out1393, out _out1394);
          _2069_left = _out1391;
          _2070___v71 = _out1392;
          _2071_leftErased = _out1393;
          _2072_recIdentsL = _out1394;
          Dafny.ISequence<Dafny.Rune> _2073_right;
          bool _2074___v72;
          bool _2075_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2076_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1395;
          bool _out1396;
          bool _out1397;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1398;
          DCOMP.COMP.GenExpr(_2066_r, selfIdent, @params, true, out _out1395, out _out1396, out _out1397, out _out1398);
          _2073_right = _out1395;
          _2074___v72 = _out1396;
          _2075_rightErased = _out1397;
          _2076_recIdentsR = _out1398;
          if (!(_2071_leftErased)) {
            _2069_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2069_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2075_rightErased)) {
            _2073_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2073_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2068_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2069_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2073_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2068_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2069_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2073_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2069_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2068_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2073_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2072_recIdentsL, _2076_recIdentsR);
          isErased = true;
        }
      } else if (_source19.is_Select) {
        DAST._IExpression _2077___mcc_h32 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2078___mcc_h33 = _source19.dtor_field;
        bool _2079___mcc_h34 = _source19.dtor_isConstant;
        bool _2080___mcc_h35 = _source19.dtor_onDatatype;
        bool _2081_isDatatype = _2080___mcc_h35;
        bool _2082_isConstant = _2079___mcc_h34;
        Dafny.ISequence<Dafny.Rune> _2083_field = _2078___mcc_h33;
        DAST._IExpression _2084_on = _2077___mcc_h32;
        {
          Dafny.ISequence<Dafny.Rune> _2085_onString;
          bool _2086_onOwned;
          bool _2087_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2088_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1399;
          bool _out1400;
          bool _out1401;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1402;
          DCOMP.COMP.GenExpr(_2084_on, selfIdent, @params, false, out _out1399, out _out1400, out _out1401, out _out1402);
          _2085_onString = _out1399;
          _2086_onOwned = _out1400;
          _2087_onErased = _out1401;
          _2088_recIdents = _out1402;
          if (!(_2087_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2089_eraseFn;
            _2089_eraseFn = ((_2086_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2085_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2089_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2085_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2081_isDatatype) || (_2082_isConstant)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2085_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2083_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            if (_2082_isConstant) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            }
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2085_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2083_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          }
          isErased = false;
          readIdents = _2088_recIdents;
        }
      } else if (_source19.is_SelectFn) {
        DAST._IExpression _2090___mcc_h36 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2091___mcc_h37 = _source19.dtor_field;
        bool _2092___mcc_h38 = _source19.dtor_onDatatype;
        bool _2093___mcc_h39 = _source19.dtor_isStatic;
        BigInteger _2094___mcc_h40 = _source19.dtor_arity;
        BigInteger _2095_arity = _2094___mcc_h40;
        bool _2096_isStatic = _2093___mcc_h39;
        bool _2097_isDatatype = _2092___mcc_h38;
        Dafny.ISequence<Dafny.Rune> _2098_field = _2091___mcc_h37;
        DAST._IExpression _2099_on = _2090___mcc_h36;
        {
          Dafny.ISequence<Dafny.Rune> _2100_onString;
          bool _2101_onOwned;
          bool _2102___v73;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2103_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1403;
          bool _out1404;
          bool _out1405;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1406;
          DCOMP.COMP.GenExpr(_2099_on, selfIdent, @params, false, out _out1403, out _out1404, out _out1405, out _out1406);
          _2100_onString = _out1403;
          _2101_onOwned = _out1404;
          _2102___v73 = _out1405;
          _2103_recIdents = _out1406;
          if (_2096_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2100_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2098_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2100_onString), ((_2101_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2104_args;
            _2104_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2105_i;
            _2105_i = BigInteger.Zero;
            while ((_2105_i) < (_2095_arity)) {
              if ((_2105_i).Sign == 1) {
                _2104_args = Dafny.Sequence<Dafny.Rune>.Concat(_2104_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2104_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2104_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2105_i));
              _2105_i = (_2105_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2104_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2098_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2104_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _2103_recIdents;
        }
      } else if (_source19.is_Index) {
        DAST._IExpression _2106___mcc_h41 = _source19.dtor_expr;
        DAST._IExpression _2107___mcc_h42 = _source19.dtor_idx;
        DAST._IExpression _2108_idx = _2107___mcc_h42;
        DAST._IExpression _2109_on = _2106___mcc_h41;
        {
          Dafny.ISequence<Dafny.Rune> _2110_onString;
          bool _2111_onOwned;
          bool _2112_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2113_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1407;
          bool _out1408;
          bool _out1409;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1410;
          DCOMP.COMP.GenExpr(_2109_on, selfIdent, @params, false, out _out1407, out _out1408, out _out1409, out _out1410);
          _2110_onString = _out1407;
          _2111_onOwned = _out1408;
          _2112_onErased = _out1409;
          _2113_recIdents = _out1410;
          if (!(_2112_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2114_eraseFn;
            _2114_eraseFn = ((_2111_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2110_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2114_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2110_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2115_idxString;
          bool _2116___v74;
          bool _2117_idxErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2118_recIdentsIdx;
          Dafny.ISequence<Dafny.Rune> _out1411;
          bool _out1412;
          bool _out1413;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1414;
          DCOMP.COMP.GenExpr(_2108_idx, selfIdent, @params, true, out _out1411, out _out1412, out _out1413, out _out1414);
          _2115_idxString = _out1411;
          _2116___v74 = _out1412;
          _2117_idxErased = _out1413;
          _2118_recIdentsIdx = _out1414;
          if (!(_2117_idxErased)) {
            _2115_idxString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2115_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2110_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[<usize as ::dafny_runtime::NumCast>::from(")), _2115_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2113_recIdents, _2118_recIdentsIdx);
        }
      } else if (_source19.is_TupleSelect) {
        DAST._IExpression _2119___mcc_h43 = _source19.dtor_expr;
        BigInteger _2120___mcc_h44 = _source19.dtor_index;
        BigInteger _2121_idx = _2120___mcc_h44;
        DAST._IExpression _2122_on = _2119___mcc_h43;
        {
          Dafny.ISequence<Dafny.Rune> _2123_onString;
          bool _2124___v75;
          bool _2125_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2126_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1415;
          bool _out1416;
          bool _out1417;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1418;
          DCOMP.COMP.GenExpr(_2122_on, selfIdent, @params, false, out _out1415, out _out1416, out _out1417, out _out1418);
          _2123_onString = _out1415;
          _2124___v75 = _out1416;
          _2125_tupErased = _out1417;
          _2126_recIdents = _out1418;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2123_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2121_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2125_tupErased;
          readIdents = _2126_recIdents;
        }
      } else if (_source19.is_Call) {
        DAST._IExpression _2127___mcc_h45 = _source19.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2128___mcc_h46 = _source19.dtor_name;
        Dafny.ISequence<DAST._IType> _2129___mcc_h47 = _source19.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2130___mcc_h48 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2131_args = _2130___mcc_h48;
        Dafny.ISequence<DAST._IType> _2132_typeArgs = _2129___mcc_h47;
        Dafny.ISequence<Dafny.Rune> _2133_name = _2128___mcc_h46;
        DAST._IExpression _2134_on = _2127___mcc_h45;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2135_typeArgString;
          _2135_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2132_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2136_typeI;
            _2136_typeI = BigInteger.Zero;
            _2135_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2136_typeI) < (new BigInteger((_2132_typeArgs).Count))) {
              if ((_2136_typeI).Sign == 1) {
                _2135_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2135_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2137_typeString;
              Dafny.ISequence<Dafny.Rune> _out1419;
              _out1419 = DCOMP.COMP.GenType((_2132_typeArgs).Select(_2136_typeI), false, false);
              _2137_typeString = _out1419;
              _2135_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2135_typeArgString, _2137_typeString);
              _2136_typeI = (_2136_typeI) + (BigInteger.One);
            }
            _2135_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2135_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2138_argString;
          _2138_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2139_i;
          _2139_i = BigInteger.Zero;
          while ((_2139_i) < (new BigInteger((_2131_args).Count))) {
            if ((_2139_i).Sign == 1) {
              _2138_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2138_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2140_argExpr;
            bool _2141_isOwned;
            bool _2142_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2143_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1420;
            bool _out1421;
            bool _out1422;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1423;
            DCOMP.COMP.GenExpr((_2131_args).Select(_2139_i), selfIdent, @params, false, out _out1420, out _out1421, out _out1422, out _out1423);
            _2140_argExpr = _out1420;
            _2141_isOwned = _out1421;
            _2142_argErased = _out1422;
            _2143_argIdents = _out1423;
            if (_2141_isOwned) {
              _2140_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2140_argExpr);
            }
            _2138_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2138_argString, _2140_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2143_argIdents);
            _2139_i = (_2139_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2144_enclosingString;
          bool _2145___v76;
          bool _2146___v77;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2147_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1424;
          bool _out1425;
          bool _out1426;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1427;
          DCOMP.COMP.GenExpr(_2134_on, selfIdent, @params, false, out _out1424, out _out1425, out _out1426, out _out1427);
          _2144_enclosingString = _out1424;
          _2145___v76 = _out1425;
          _2146___v77 = _out1426;
          _2147_recIdents = _out1427;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2147_recIdents);
          DAST._IExpression _source71 = _2134_on;
          if (_source71.is_Literal) {
            DAST._ILiteral _2148___mcc_h929 = _source71.dtor_Literal_a0;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2149___mcc_h931 = _source71.dtor_Ident_a0;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2150___mcc_h933 = _source71.dtor_Companion_a0;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_2144_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source71.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2151___mcc_h935 = _source71.dtor_Tuple_a0;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2152___mcc_h937 = _source71.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2153___mcc_h938 = _source71.dtor_args;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2154___mcc_h941 = _source71.dtor_dims;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2155___mcc_h943 = _source71.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2156___mcc_h944 = _source71.dtor_variant;
            bool _2157___mcc_h945 = _source71.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2158___mcc_h946 = _source71.dtor_contents;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Convert) {
            DAST._IExpression _2159___mcc_h951 = _source71.dtor_value;
            DAST._IType _2160___mcc_h952 = _source71.dtor_from;
            DAST._IType _2161___mcc_h953 = _source71.dtor_typ;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2162___mcc_h957 = _source71.dtor_elements;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2163___mcc_h959 = _source71.dtor_elements;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_This) {
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Ite) {
            DAST._IExpression _2164___mcc_h961 = _source71.dtor_cond;
            DAST._IExpression _2165___mcc_h962 = _source71.dtor_thn;
            DAST._IExpression _2166___mcc_h963 = _source71.dtor_els;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_UnOp) {
            DAST._IUnaryOp _2167___mcc_h967 = _source71.dtor_unOp;
            DAST._IExpression _2168___mcc_h968 = _source71.dtor_expr;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2169___mcc_h971 = _source71.dtor_op;
            DAST._IExpression _2170___mcc_h972 = _source71.dtor_left;
            DAST._IExpression _2171___mcc_h973 = _source71.dtor_right;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Select) {
            DAST._IExpression _2172___mcc_h977 = _source71.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2173___mcc_h978 = _source71.dtor_field;
            bool _2174___mcc_h979 = _source71.dtor_isConstant;
            bool _2175___mcc_h980 = _source71.dtor_onDatatype;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_SelectFn) {
            DAST._IExpression _2176___mcc_h985 = _source71.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2177___mcc_h986 = _source71.dtor_field;
            bool _2178___mcc_h987 = _source71.dtor_onDatatype;
            bool _2179___mcc_h988 = _source71.dtor_isStatic;
            BigInteger _2180___mcc_h989 = _source71.dtor_arity;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Index) {
            DAST._IExpression _2181___mcc_h995 = _source71.dtor_expr;
            DAST._IExpression _2182___mcc_h996 = _source71.dtor_idx;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_TupleSelect) {
            DAST._IExpression _2183___mcc_h999 = _source71.dtor_expr;
            BigInteger _2184___mcc_h1000 = _source71.dtor_index;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Call) {
            DAST._IExpression _2185___mcc_h1003 = _source71.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2186___mcc_h1004 = _source71.dtor_name;
            Dafny.ISequence<DAST._IType> _2187___mcc_h1005 = _source71.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2188___mcc_h1006 = _source71.dtor_args;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2189___mcc_h1011 = _source71.dtor_params;
            DAST._IType _2190___mcc_h1012 = _source71.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2191___mcc_h1013 = _source71.dtor_body;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2192___mcc_h1017 = _source71.dtor_name;
            DAST._IType _2193___mcc_h1018 = _source71.dtor_typ;
            DAST._IExpression _2194___mcc_h1019 = _source71.dtor_value;
            DAST._IExpression _2195___mcc_h1020 = _source71.dtor_iifeBody;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Apply) {
            DAST._IExpression _2196___mcc_h1025 = _source71.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2197___mcc_h1026 = _source71.dtor_args;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_TypeTest) {
            DAST._IExpression _2198___mcc_h1029 = _source71.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2199___mcc_h1030 = _source71.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2200___mcc_h1031 = _source71.dtor_variant;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _2201___mcc_h1035 = _source71.dtor_typ;
            {
              _2144_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2144_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2144_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_2133_name)), _2135_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2138_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2202___mcc_h49 = _source19.dtor_params;
        DAST._IType _2203___mcc_h50 = _source19.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2204___mcc_h51 = _source19.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2205_body = _2204___mcc_h51;
        DAST._IType _2206_retType = _2203___mcc_h50;
        Dafny.ISequence<DAST._IFormal> _2207_params = _2202___mcc_h49;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2208_paramNames;
          _2208_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2209_i;
          _2209_i = BigInteger.Zero;
          while ((_2209_i) < (new BigInteger((_2207_params).Count))) {
            _2208_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2208_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2207_params).Select(_2209_i)).dtor_name));
            _2209_i = (_2209_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2210_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2211_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1428;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1429;
          DCOMP.COMP.GenStmts(_2205_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2208_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1428, out _out1429);
          _2210_recursiveGen = _out1428;
          _2211_recIdents = _out1429;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2212_allReadCloned;
          _2212_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2211_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2213_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2211_recIdents).Elements) {
              _2213_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2211_recIdents).Contains(_2213_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1605)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2208_paramNames).Contains(_2213_next))) {
              _2212_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2212_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2213_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2213_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2213_next));
            }
            _2211_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2211_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2213_next));
          }
          Dafny.ISequence<Dafny.Rune> _2214_paramsString;
          _2214_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2209_i = BigInteger.Zero;
          while ((_2209_i) < (new BigInteger((_2207_params).Count))) {
            if ((_2209_i).Sign == 1) {
              _2214_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2214_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2215_typStr;
            Dafny.ISequence<Dafny.Rune> _out1430;
            _out1430 = DCOMP.COMP.GenType(((_2207_params).Select(_2209_i)).dtor_typ, false, true);
            _2215_typStr = _out1430;
            _2214_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2214_paramsString, ((_2207_params).Select(_2209_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2215_typStr);
            _2209_i = (_2209_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2216_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1431;
          _out1431 = DCOMP.COMP.GenType(_2206_retType, false, true);
          _2216_retTypeGen = _out1431;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _2212_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _2214_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2216_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2210_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2217___mcc_h52 = _source19.dtor_name;
        DAST._IType _2218___mcc_h53 = _source19.dtor_typ;
        DAST._IExpression _2219___mcc_h54 = _source19.dtor_value;
        DAST._IExpression _2220___mcc_h55 = _source19.dtor_iifeBody;
        DAST._IExpression _2221_iifeBody = _2220___mcc_h55;
        DAST._IExpression _2222_value = _2219___mcc_h54;
        DAST._IType _2223_tpe = _2218___mcc_h53;
        Dafny.ISequence<Dafny.Rune> _2224_name = _2217___mcc_h52;
        {
          Dafny.ISequence<Dafny.Rune> _2225_valueGen;
          bool _2226_valueOwned;
          bool _2227_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2228_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1432;
          bool _out1433;
          bool _out1434;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1435;
          DCOMP.COMP.GenExpr(_2222_value, selfIdent, @params, false, out _out1432, out _out1433, out _out1434, out _out1435);
          _2225_valueGen = _out1432;
          _2226_valueOwned = _out1433;
          _2227_valueErased = _out1434;
          _2228_recIdents = _out1435;
          if (_2227_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2229_eraseFn;
            _2229_eraseFn = ((_2226_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2225_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2229_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2225_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2228_recIdents;
          Dafny.ISequence<Dafny.Rune> _2230_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1436;
          _out1436 = DCOMP.COMP.GenType(_2223_tpe, false, true);
          _2230_valueTypeGen = _out1436;
          Dafny.ISequence<Dafny.Rune> _2231_bodyGen;
          bool _2232_bodyOwned;
          bool _2233_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2234_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1437;
          bool _out1438;
          bool _out1439;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1440;
          DCOMP.COMP.GenExpr(_2221_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2226_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2224_name))))), mustOwn, out _out1437, out _out1438, out _out1439, out _out1440);
          _2231_bodyGen = _out1437;
          _2232_bodyOwned = _out1438;
          _2233_bodyErased = _out1439;
          _2234_bodyIdents = _out1440;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2234_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _2235_eraseFn;
          _2235_eraseFn = ((_2226_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2224_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2226_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2230_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2225_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2231_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2232_bodyOwned;
          isErased = _2233_bodyErased;
        }
      } else if (_source19.is_Apply) {
        DAST._IExpression _2236___mcc_h56 = _source19.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2237___mcc_h57 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2238_args = _2237___mcc_h57;
        DAST._IExpression _2239_func = _2236___mcc_h56;
        {
          Dafny.ISequence<Dafny.Rune> _2240_funcString;
          bool _2241___v80;
          bool _2242_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2243_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1441;
          bool _out1442;
          bool _out1443;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1444;
          DCOMP.COMP.GenExpr(_2239_func, selfIdent, @params, false, out _out1441, out _out1442, out _out1443, out _out1444);
          _2240_funcString = _out1441;
          _2241___v80 = _out1442;
          _2242_funcErased = _out1443;
          _2243_recIdents = _out1444;
          readIdents = _2243_recIdents;
          Dafny.ISequence<Dafny.Rune> _2244_argString;
          _2244_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2245_i;
          _2245_i = BigInteger.Zero;
          while ((_2245_i) < (new BigInteger((_2238_args).Count))) {
            if ((_2245_i).Sign == 1) {
              _2244_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2244_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2246_argExpr;
            bool _2247_isOwned;
            bool _2248_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2249_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1445;
            bool _out1446;
            bool _out1447;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1448;
            DCOMP.COMP.GenExpr((_2238_args).Select(_2245_i), selfIdent, @params, false, out _out1445, out _out1446, out _out1447, out _out1448);
            _2246_argExpr = _out1445;
            _2247_isOwned = _out1446;
            _2248_argErased = _out1447;
            _2249_argIdents = _out1448;
            if (_2247_isOwned) {
              _2246_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2246_argExpr);
            }
            _2244_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2244_argString, _2246_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2249_argIdents);
            _2245_i = (_2245_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2240_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2244_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_TypeTest) {
        DAST._IExpression _2250___mcc_h58 = _source19.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2251___mcc_h59 = _source19.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2252___mcc_h60 = _source19.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2253_variant = _2252___mcc_h60;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2254_dType = _2251___mcc_h59;
        DAST._IExpression _2255_on = _2250___mcc_h58;
        {
          Dafny.ISequence<Dafny.Rune> _2256_exprGen;
          bool _2257___v81;
          bool _2258_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2259_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1449;
          bool _out1450;
          bool _out1451;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1452;
          DCOMP.COMP.GenExpr(_2255_on, selfIdent, @params, false, out _out1449, out _out1450, out _out1451, out _out1452);
          _2256_exprGen = _out1449;
          _2257___v81 = _out1450;
          _2258_exprErased = _out1451;
          _2259_recIdents = _out1452;
          Dafny.ISequence<Dafny.Rune> _2260_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1453;
          _out1453 = DCOMP.COMP.GenPath(_2254_dType);
          _2260_dTypePath = _out1453;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2256_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2260_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2253_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2259_recIdents;
        }
      } else {
        DAST._IType _2261___mcc_h61 = _source19.dtor_typ;
        DAST._IType _2262_typ = _2261___mcc_h61;
        {
          Dafny.ISequence<Dafny.Rune> _2263_typString;
          Dafny.ISequence<Dafny.Rune> _out1454;
          _out1454 = DCOMP.COMP.GenType(_2262_typ, false, false);
          _2263_typString = _out1454;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2263_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2264_i;
      _2264_i = BigInteger.Zero;
      while ((_2264_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2265_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1455;
        _out1455 = DCOMP.COMP.GenModule((p).Select(_2264_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2265_generated = _out1455;
        if ((_2264_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2265_generated);
        _2264_i = (_2264_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2266_i;
      _2266_i = BigInteger.Zero;
      while ((_2266_i) < (new BigInteger((fullName).Count))) {
        if ((_2266_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2266_i));
        _2266_i = (_2266_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

