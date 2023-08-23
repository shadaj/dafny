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
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _276___mcc_h9 = _source15.dtor_lbl;
        DAST._IExpression _277___mcc_h10 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _278___mcc_h11 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _279_body = _278___mcc_h11;
        DAST._IExpression _280_cond = _277___mcc_h10;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _281_lbl = _276___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _282_condString;
          bool _283___v17;
          bool _284_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _285_recIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          bool _out98;
          bool _out99;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out100;
          DCOMP.COMP.GenExpr(_280_cond, selfIdent, @params, true, out _out97, out _out98, out _out99, out _out100);
          _282_condString = _out97;
          _283___v17 = _out98;
          _284_condErased = _out99;
          _285_recIdents = _out100;
          if (!(_284_condErased)) {
            _282_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _282_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _285_recIdents;
          Dafny.ISequence<Dafny.Rune> _286_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _287_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenStmts(_279_body, selfIdent, @params, false, earlyReturn, out _out101, out _out102);
          _286_bodyString = _out101;
          _287_bodyIdents = _out102;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _287_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _288_lblString;
          _288_lblString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source17 = _281_lbl;
          if (_source17.is_Some) {
            Dafny.ISequence<Dafny.Rune> _289___mcc_h21 = _source17.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _290_id = _289___mcc_h21;
            {
              _288_lblString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _290_id), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": "));
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_288_lblString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while ")), _282_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _286_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _291___mcc_h12 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _292___mcc_h13 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _293___mcc_h14 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _294___mcc_h15 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _295___mcc_h16 = _source15.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _296_maybeOutVars = _295___mcc_h16;
        Dafny.ISequence<DAST._IExpression> _297_args = _294___mcc_h15;
        Dafny.ISequence<DAST._IType> _298_typeArgs = _293___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _299_name = _292___mcc_h13;
        DAST._IExpression _300_on = _291___mcc_h12;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _301_typeArgString;
          _301_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_298_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _302_typeI;
            _302_typeI = BigInteger.Zero;
            _301_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_302_typeI) < (new BigInteger((_298_typeArgs).Count))) {
              if ((_302_typeI).Sign == 1) {
                _301_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_301_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _303_typeString;
              Dafny.ISequence<Dafny.Rune> _out103;
              _out103 = DCOMP.COMP.GenType((_298_typeArgs).Select(_302_typeI), false, false);
              _303_typeString = _out103;
              _301_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_301_typeArgString, _303_typeString);
              _302_typeI = (_302_typeI) + (BigInteger.One);
            }
            _301_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_301_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _304_argString;
          _304_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _305_i;
          _305_i = BigInteger.Zero;
          while ((_305_i) < (new BigInteger((_297_args).Count))) {
            if ((_305_i).Sign == 1) {
              _304_argString = Dafny.Sequence<Dafny.Rune>.Concat(_304_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _306_argExpr;
            bool _307_isOwned;
            bool _308_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _309_argIdents;
            Dafny.ISequence<Dafny.Rune> _out104;
            bool _out105;
            bool _out106;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out107;
            DCOMP.COMP.GenExpr((_297_args).Select(_305_i), selfIdent, @params, false, out _out104, out _out105, out _out106, out _out107);
            _306_argExpr = _out104;
            _307_isOwned = _out105;
            _308_argErased = _out106;
            _309_argIdents = _out107;
            if (_307_isOwned) {
              _306_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _306_argExpr);
            }
            _304_argString = Dafny.Sequence<Dafny.Rune>.Concat(_304_argString, _306_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _309_argIdents);
            _305_i = (_305_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _310_enclosingString;
          bool _311___v18;
          bool _312___v19;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _313_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out108;
          bool _out109;
          bool _out110;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out111;
          DCOMP.COMP.GenExpr(_300_on, selfIdent, @params, false, out _out108, out _out109, out _out110, out _out111);
          _310_enclosingString = _out108;
          _311___v18 = _out109;
          _312___v19 = _out110;
          _313_enclosingIdents = _out111;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _313_enclosingIdents);
          DAST._IExpression _source18 = _300_on;
          if (_source18.is_Literal) {
            DAST._ILiteral _314___mcc_h22 = _source18.dtor_Literal_a0;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _315___mcc_h24 = _source18.dtor_Ident_a0;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _316___mcc_h26 = _source18.dtor_Companion_a0;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_310_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source18.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _317___mcc_h28 = _source18.dtor_Tuple_a0;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _318___mcc_h30 = _source18.dtor_path;
            Dafny.ISequence<DAST._IExpression> _319___mcc_h31 = _source18.dtor_args;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _320___mcc_h34 = _source18.dtor_dims;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _321___mcc_h36 = _source18.dtor_path;
            Dafny.ISequence<Dafny.Rune> _322___mcc_h37 = _source18.dtor_variant;
            bool _323___mcc_h38 = _source18.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _324___mcc_h39 = _source18.dtor_contents;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Convert) {
            DAST._IExpression _325___mcc_h44 = _source18.dtor_value;
            DAST._IType _326___mcc_h45 = _source18.dtor_from;
            DAST._IType _327___mcc_h46 = _source18.dtor_typ;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _328___mcc_h50 = _source18.dtor_elements;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _329___mcc_h52 = _source18.dtor_elements;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_This) {
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ite) {
            DAST._IExpression _330___mcc_h54 = _source18.dtor_cond;
            DAST._IExpression _331___mcc_h55 = _source18.dtor_thn;
            DAST._IExpression _332___mcc_h56 = _source18.dtor_els;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_UnOp) {
            DAST._IUnaryOp _333___mcc_h60 = _source18.dtor_unOp;
            DAST._IExpression _334___mcc_h61 = _source18.dtor_expr;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _335___mcc_h64 = _source18.dtor_op;
            DAST._IExpression _336___mcc_h65 = _source18.dtor_left;
            DAST._IExpression _337___mcc_h66 = _source18.dtor_right;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Select) {
            DAST._IExpression _338___mcc_h70 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _339___mcc_h71 = _source18.dtor_field;
            bool _340___mcc_h72 = _source18.dtor_isConstant;
            bool _341___mcc_h73 = _source18.dtor_onDatatype;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SelectFn) {
            DAST._IExpression _342___mcc_h78 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _343___mcc_h79 = _source18.dtor_field;
            bool _344___mcc_h80 = _source18.dtor_onDatatype;
            bool _345___mcc_h81 = _source18.dtor_isStatic;
            BigInteger _346___mcc_h82 = _source18.dtor_arity;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Index) {
            DAST._IExpression _347___mcc_h88 = _source18.dtor_expr;
            DAST._IExpression _348___mcc_h89 = _source18.dtor_idx;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TupleSelect) {
            DAST._IExpression _349___mcc_h92 = _source18.dtor_expr;
            BigInteger _350___mcc_h93 = _source18.dtor_index;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Call) {
            DAST._IExpression _351___mcc_h96 = _source18.dtor_on;
            Dafny.ISequence<Dafny.Rune> _352___mcc_h97 = _source18.dtor_name;
            Dafny.ISequence<DAST._IType> _353___mcc_h98 = _source18.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _354___mcc_h99 = _source18.dtor_args;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _355___mcc_h104 = _source18.dtor_params;
            DAST._IType _356___mcc_h105 = _source18.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _357___mcc_h106 = _source18.dtor_body;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _358___mcc_h110 = _source18.dtor_name;
            DAST._IType _359___mcc_h111 = _source18.dtor_typ;
            DAST._IExpression _360___mcc_h112 = _source18.dtor_value;
            DAST._IExpression _361___mcc_h113 = _source18.dtor_iifeBody;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Apply) {
            DAST._IExpression _362___mcc_h118 = _source18.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _363___mcc_h119 = _source18.dtor_args;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TypeTest) {
            DAST._IExpression _364___mcc_h122 = _source18.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _365___mcc_h123 = _source18.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _366___mcc_h124 = _source18.dtor_variant;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _367___mcc_h128 = _source18.dtor_typ;
            {
              _310_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _368_receiver;
          _368_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source19 = _296_maybeOutVars;
          if (_source19.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _369___mcc_h130 = _source19.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _370_outVars = _369___mcc_h130;
            {
              if ((new BigInteger((_370_outVars).Count)) > (BigInteger.One)) {
                _368_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _371_outI;
              _371_outI = BigInteger.Zero;
              while ((_371_outI) < (new BigInteger((_370_outVars).Count))) {
                if ((_371_outI).Sign == 1) {
                  _368_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_368_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _372_outVar;
                _372_outVar = (_370_outVars).Select(_371_outI);
                _368_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_368_receiver, (_372_outVar));
                _371_outI = (_371_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_370_outVars).Count)) > (BigInteger.One)) {
                _368_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_368_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_368_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_368_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _310_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _299_name), _301_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _304_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _373___mcc_h17 = _source15.dtor_expr;
        DAST._IExpression _374_expr = _373___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _375_exprString;
          bool _376___v22;
          bool _377_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _378_recIdents;
          Dafny.ISequence<Dafny.Rune> _out112;
          bool _out113;
          bool _out114;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out115;
          DCOMP.COMP.GenExpr(_374_expr, selfIdent, @params, true, out _out112, out _out113, out _out114, out _out115);
          _375_exprString = _out112;
          _376___v22 = _out113;
          _377_recErased = _out114;
          _378_recIdents = _out115;
          _375_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _375_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _378_recIdents;
          if (isLast) {
            generated = _375_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _375_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source15.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_Break) {
        Dafny.ISequence<Dafny.Rune> _379___mcc_h18 = _source15.dtor_toLabel;
        Dafny.ISequence<Dafny.Rune> _380_toLabel = _379___mcc_h18;
        {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break 'label_"), _380_toLabel), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _381___mcc_h19 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _382_body = _381___mcc_h19;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _383_paramI;
          _383_paramI = BigInteger.Zero;
          while ((_383_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _384_param;
            _384_param = (@params).Select(_383_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _384_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _384_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _383_paramI = (_383_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _385_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _386_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out116;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out117;
          DCOMP.COMP.GenStmts(_382_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out116, out _out117);
          _385_bodyString = _out116;
          _386_bodyIdents = _out117;
          readIdents = _386_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _385_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
        DAST._IExpression _387___mcc_h20 = _source15.dtor_Print_a0;
        DAST._IExpression _388_e = _387___mcc_h20;
        {
          Dafny.ISequence<Dafny.Rune> _389_printedExpr;
          bool _390_isOwned;
          bool _391___v23;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _392_recIdents;
          Dafny.ISequence<Dafny.Rune> _out118;
          bool _out119;
          bool _out120;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out121;
          DCOMP.COMP.GenExpr(_388_e, selfIdent, @params, false, out _out118, out _out119, out _out120, out _out121);
          _389_printedExpr = _out118;
          _390_isOwned = _out119;
          _391___v23 = _out120;
          _392_recIdents = _out121;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_390_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _389_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _392_recIdents;
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
        DAST._ILiteral _393___mcc_h0 = _source20.dtor_Literal_a0;
        DAST._ILiteral _source21 = _393___mcc_h0;
        if (_source21.is_BoolLiteral) {
          bool _394___mcc_h1 = _source21.dtor_BoolLiteral_a0;
          if ((_394___mcc_h1) == (false)) {
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
          Dafny.ISequence<Dafny.Rune> _395___mcc_h2 = _source21.dtor_IntLiteral_a0;
          DAST._IType _396___mcc_h3 = _source21.dtor_IntLiteral_a1;
          DAST._IType _397_t = _396___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _398_i = _395___mcc_h2;
          {
            DAST._IType _source22 = _397_t;
            if (_source22.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _399___mcc_h170 = _source22.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _400___mcc_h171 = _source22.dtor_typeArgs;
              DAST._IResolvedType _401___mcc_h172 = _source22.dtor_resolved;
              {
                s = _398_i;
              }
            } else if (_source22.is_Nullable) {
              DAST._IType _402___mcc_h176 = _source22.dtor_Nullable_a0;
              {
                s = _398_i;
              }
            } else if (_source22.is_Tuple) {
              Dafny.ISequence<DAST._IType> _403___mcc_h178 = _source22.dtor_Tuple_a0;
              {
                s = _398_i;
              }
            } else if (_source22.is_Array) {
              DAST._IType _404___mcc_h180 = _source22.dtor_element;
              {
                s = _398_i;
              }
            } else if (_source22.is_Seq) {
              DAST._IType _405___mcc_h182 = _source22.dtor_element;
              {
                s = _398_i;
              }
            } else if (_source22.is_Set) {
              DAST._IType _406___mcc_h184 = _source22.dtor_element;
              {
                s = _398_i;
              }
            } else if (_source22.is_Multiset) {
              DAST._IType _407___mcc_h186 = _source22.dtor_element;
              {
                s = _398_i;
              }
            } else if (_source22.is_Map) {
              DAST._IType _408___mcc_h188 = _source22.dtor_key;
              DAST._IType _409___mcc_h189 = _source22.dtor_value;
              {
                s = _398_i;
              }
            } else if (_source22.is_Arrow) {
              Dafny.ISequence<DAST._IType> _410___mcc_h192 = _source22.dtor_args;
              DAST._IType _411___mcc_h193 = _source22.dtor_result;
              {
                s = _398_i;
              }
            } else if (_source22.is_Primitive) {
              DAST._IPrimitive _412___mcc_h196 = _source22.dtor_Primitive_a0;
              DAST._IPrimitive _source23 = _412___mcc_h196;
              if (_source23.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _398_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source23.is_Real) {
                {
                  s = _398_i;
                }
              } else if (_source23.is_String) {
                {
                  s = _398_i;
                }
              } else if (_source23.is_Bool) {
                {
                  s = _398_i;
                }
              } else {
                {
                  s = _398_i;
                }
              }
            } else if (_source22.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _413___mcc_h198 = _source22.dtor_Passthrough_a0;
              {
                s = _398_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _414___mcc_h200 = _source22.dtor_TypeArg_a0;
              {
                s = _398_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _415___mcc_h4 = _source21.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _416___mcc_h5 = _source21.dtor_DecLiteral_a1;
          DAST._IType _417___mcc_h6 = _source21.dtor_DecLiteral_a2;
          DAST._IType _418_t = _417___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _419_d = _416___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _420_n = _415___mcc_h4;
          {
            DAST._IType _source24 = _418_t;
            if (_source24.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _421___mcc_h202 = _source24.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _422___mcc_h203 = _source24.dtor_typeArgs;
              DAST._IResolvedType _423___mcc_h204 = _source24.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Nullable) {
              DAST._IType _424___mcc_h208 = _source24.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Tuple) {
              Dafny.ISequence<DAST._IType> _425___mcc_h210 = _source24.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Array) {
              DAST._IType _426___mcc_h212 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Seq) {
              DAST._IType _427___mcc_h214 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Set) {
              DAST._IType _428___mcc_h216 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Multiset) {
              DAST._IType _429___mcc_h218 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Map) {
              DAST._IType _430___mcc_h220 = _source24.dtor_key;
              DAST._IType _431___mcc_h221 = _source24.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Arrow) {
              Dafny.ISequence<DAST._IType> _432___mcc_h224 = _source24.dtor_args;
              DAST._IType _433___mcc_h225 = _source24.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Primitive) {
              DAST._IPrimitive _434___mcc_h228 = _source24.dtor_Primitive_a0;
              DAST._IPrimitive _source25 = _434___mcc_h228;
              if (_source25.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source25.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _420_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source25.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source25.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source24.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _435___mcc_h230 = _source24.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _436___mcc_h232 = _source24.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_420_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _419_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _437___mcc_h7 = _source21.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _438_l = _437___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _438_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_CharLiteral) {
          Dafny.Rune _439___mcc_h8 = _source21.dtor_CharLiteral_a0;
          Dafny.Rune _440_c = _439___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_440_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _441___mcc_h9 = _source20.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _442_name = _441___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _442_name);
          if (!((@params).Contains(_442_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_442_name);
        }
      } else if (_source20.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _443___mcc_h10 = _source20.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _444_path = _443___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out122;
          _out122 = DCOMP.COMP.GenPath(_444_path);
          s = _out122;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source20.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _445___mcc_h11 = _source20.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _446_values = _445___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _447_i;
          _447_i = BigInteger.Zero;
          bool _448_allErased;
          _448_allErased = true;
          while ((_447_i) < (new BigInteger((_446_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _449___v26;
            bool _450___v27;
            bool _451_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _452___v28;
            Dafny.ISequence<Dafny.Rune> _out123;
            bool _out124;
            bool _out125;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out126;
            DCOMP.COMP.GenExpr((_446_values).Select(_447_i), selfIdent, @params, true, out _out123, out _out124, out _out125, out _out126);
            _449___v26 = _out123;
            _450___v27 = _out124;
            _451_isErased = _out125;
            _452___v28 = _out126;
            _448_allErased = (_448_allErased) && (_451_isErased);
            _447_i = (_447_i) + (BigInteger.One);
          }
          _447_i = BigInteger.Zero;
          while ((_447_i) < (new BigInteger((_446_values).Count))) {
            if ((_447_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _453_recursiveGen;
            bool _454___v29;
            bool _455_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _456_recIdents;
            Dafny.ISequence<Dafny.Rune> _out127;
            bool _out128;
            bool _out129;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out130;
            DCOMP.COMP.GenExpr((_446_values).Select(_447_i), selfIdent, @params, true, out _out127, out _out128, out _out129, out _out130);
            _453_recursiveGen = _out127;
            _454___v29 = _out128;
            _455_isErased = _out129;
            _456_recIdents = _out130;
            if ((_455_isErased) && (!(_448_allErased))) {
              _453_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _453_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _453_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _456_recIdents);
            _447_i = (_447_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _448_allErased;
        }
      } else if (_source20.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _457___mcc_h12 = _source20.dtor_path;
        Dafny.ISequence<DAST._IExpression> _458___mcc_h13 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _459_args = _458___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _460_path = _457___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _461_path;
          Dafny.ISequence<Dafny.Rune> _out131;
          _out131 = DCOMP.COMP.GenPath(_460_path);
          _461_path = _out131;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _461_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _462_i;
          _462_i = BigInteger.Zero;
          while ((_462_i) < (new BigInteger((_459_args).Count))) {
            if ((_462_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _463_recursiveGen;
            bool _464___v30;
            bool _465_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _466_recIdents;
            Dafny.ISequence<Dafny.Rune> _out132;
            bool _out133;
            bool _out134;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out135;
            DCOMP.COMP.GenExpr((_459_args).Select(_462_i), selfIdent, @params, true, out _out132, out _out133, out _out134, out _out135);
            _463_recursiveGen = _out132;
            _464___v30 = _out133;
            _465_isErased = _out134;
            _466_recIdents = _out135;
            if (_465_isErased) {
              _463_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _463_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _463_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _466_recIdents);
            _462_i = (_462_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _467___mcc_h14 = _source20.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _468_dims = _467___mcc_h14;
        {
          BigInteger _469_i;
          _469_i = (new BigInteger((_468_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_469_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _470_recursiveGen;
            bool _471___v31;
            bool _472_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _473_recIdents;
            Dafny.ISequence<Dafny.Rune> _out136;
            bool _out137;
            bool _out138;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out139;
            DCOMP.COMP.GenExpr((_468_dims).Select(_469_i), selfIdent, @params, true, out _out136, out _out137, out _out138, out _out139);
            _470_recursiveGen = _out136;
            _471___v31 = _out137;
            _472_isErased = _out138;
            _473_recIdents = _out139;
            if (!(_472_isErased)) {
              _470_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _470_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _470_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _473_recIdents);
            _469_i = (_469_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _474___mcc_h15 = _source20.dtor_path;
        Dafny.ISequence<Dafny.Rune> _475___mcc_h16 = _source20.dtor_variant;
        bool _476___mcc_h17 = _source20.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _477___mcc_h18 = _source20.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _478_values = _477___mcc_h18;
        bool _479_isCo = _476___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _480_variant = _475___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _481_path = _474___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _482_path;
          Dafny.ISequence<Dafny.Rune> _out140;
          _out140 = DCOMP.COMP.GenPath(_481_path);
          _482_path = _out140;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _482_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _480_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _483_i;
          _483_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_483_i) < (new BigInteger((_478_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_478_values).Select(_483_i);
            Dafny.ISequence<Dafny.Rune> _484_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _485_value = _let_tmp_rhs0.dtor__1;
            if ((_483_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_479_isCo) {
              Dafny.ISequence<Dafny.Rune> _486_recursiveGen;
              bool _487___v32;
              bool _488_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _489_recIdents;
              Dafny.ISequence<Dafny.Rune> _out141;
              bool _out142;
              bool _out143;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out144;
              DCOMP.COMP.GenExpr(_485_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out141, out _out142, out _out143, out _out144);
              _486_recursiveGen = _out141;
              _487___v32 = _out142;
              _488_isErased = _out143;
              _489_recIdents = _out144;
              if (!(_488_isErased)) {
                _486_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _486_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _486_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _486_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _489_recIdents);
              Dafny.ISequence<Dafny.Rune> _490_allReadCloned;
              _490_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_489_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _491_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_489_recIdents).Elements) {
                  _491_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_489_recIdents).Contains(_491_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1153)");
              after__ASSIGN_SUCH_THAT_0:;
                _490_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_490_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _491_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _491_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _489_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_489_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_491_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _484_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _490_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _486_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _492_recursiveGen;
              bool _493___v33;
              bool _494_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _495_recIdents;
              Dafny.ISequence<Dafny.Rune> _out145;
              bool _out146;
              bool _out147;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
              DCOMP.COMP.GenExpr(_485_value, selfIdent, @params, true, out _out145, out _out146, out _out147, out _out148);
              _492_recursiveGen = _out145;
              _493___v33 = _out146;
              _494_isErased = _out147;
              _495_recIdents = _out148;
              if (!(_494_isErased)) {
                _492_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _492_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _484_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _495_recIdents);
            }
            _483_i = (_483_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_Convert) {
        DAST._IExpression _496___mcc_h19 = _source20.dtor_value;
        DAST._IType _497___mcc_h20 = _source20.dtor_from;
        DAST._IType _498___mcc_h21 = _source20.dtor_typ;
        DAST._IType _499_toTpe = _498___mcc_h21;
        DAST._IType _500_fromTpe = _497___mcc_h20;
        DAST._IExpression _501_expr = _496___mcc_h19;
        {
          if (object.Equals(_500_fromTpe, _499_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _502_recursiveGen;
            bool _503_recOwned;
            bool _504_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _505_recIdents;
            Dafny.ISequence<Dafny.Rune> _out149;
            bool _out150;
            bool _out151;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
            DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out149, out _out150, out _out151, out _out152);
            _502_recursiveGen = _out149;
            _503_recOwned = _out150;
            _504_recErased = _out151;
            _505_recIdents = _out152;
            s = _502_recursiveGen;
            isOwned = _503_recOwned;
            isErased = _504_recErased;
            readIdents = _505_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source26 = _System.Tuple2<DAST._IType, DAST._IType>.create(_500_fromTpe, _499_toTpe);
            DAST._IType _506___mcc_h234 = _source26.dtor__0;
            DAST._IType _507___mcc_h235 = _source26.dtor__1;
            DAST._IType _source27 = _506___mcc_h234;
            if (_source27.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _508___mcc_h238 = _source27.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _509___mcc_h239 = _source27.dtor_typeArgs;
              DAST._IResolvedType _510___mcc_h240 = _source27.dtor_resolved;
              DAST._IResolvedType _source28 = _510___mcc_h240;
              if (_source28.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _511___mcc_h250 = _source28.dtor_path;
                DAST._IType _source29 = _507___mcc_h235;
                if (_source29.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _512___mcc_h254 = _source29.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _513___mcc_h255 = _source29.dtor_typeArgs;
                  DAST._IResolvedType _514___mcc_h256 = _source29.dtor_resolved;
                  DAST._IResolvedType _source30 = _514___mcc_h256;
                  if (_source30.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _515___mcc_h260 = _source30.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _516_recursiveGen;
                      bool _517_recOwned;
                      bool _518_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _519_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out153;
                      bool _out154;
                      bool _out155;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out153, out _out154, out _out155, out _out156);
                      _516_recursiveGen = _out153;
                      _517_recOwned = _out154;
                      _518_recErased = _out155;
                      _519_recIdents = _out156;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _516_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _517_recOwned;
                      isErased = _518_recErased;
                      readIdents = _519_recIdents;
                    }
                  } else if (_source30.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _520___mcc_h262 = _source30.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _521_recursiveGen;
                      bool _522_recOwned;
                      bool _523_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _524_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out157;
                      bool _out158;
                      bool _out159;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out160;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out157, out _out158, out _out159, out _out160);
                      _521_recursiveGen = _out157;
                      _522_recOwned = _out158;
                      _523_recErased = _out159;
                      _524_recIdents = _out160;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _521_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _522_recOwned;
                      isErased = _523_recErased;
                      readIdents = _524_recIdents;
                    }
                  } else {
                    DAST._IType _525___mcc_h264 = _source30.dtor_Newtype_a0;
                    DAST._IType _526_b = _525___mcc_h264;
                    {
                      if (object.Equals(_500_fromTpe, _526_b)) {
                        Dafny.ISequence<Dafny.Rune> _527_recursiveGen;
                        bool _528_recOwned;
                        bool _529_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _530_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out161;
                        bool _out162;
                        bool _out163;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out164;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out161, out _out162, out _out163, out _out164);
                        _527_recursiveGen = _out161;
                        _528_recOwned = _out162;
                        _529_recErased = _out163;
                        _530_recIdents = _out164;
                        Dafny.ISequence<Dafny.Rune> _531_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out165;
                        _out165 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                        _531_rhsType = _out165;
                        Dafny.ISequence<Dafny.Rune> _532_uneraseFn;
                        _532_uneraseFn = ((_528_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _531_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _532_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _527_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _528_recOwned;
                        isErased = false;
                        readIdents = _530_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out166;
                        bool _out167;
                        bool _out168;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out169;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _526_b), _526_b, _499_toTpe), selfIdent, @params, mustOwn, out _out166, out _out167, out _out168, out _out169);
                        s = _out166;
                        isOwned = _out167;
                        isErased = _out168;
                        readIdents = _out169;
                      }
                    }
                  }
                } else if (_source29.is_Nullable) {
                  DAST._IType _533___mcc_h266 = _source29.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _534_recursiveGen;
                    bool _535_recOwned;
                    bool _536_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _537_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out170;
                    bool _out171;
                    bool _out172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out173;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out170, out _out171, out _out172, out _out173);
                    _534_recursiveGen = _out170;
                    _535_recOwned = _out171;
                    _536_recErased = _out172;
                    _537_recIdents = _out173;
                    if (!(_535_recOwned)) {
                      _534_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_534_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _536_recErased;
                    readIdents = _537_recIdents;
                  }
                } else if (_source29.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _538___mcc_h268 = _source29.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _539_recursiveGen;
                    bool _540_recOwned;
                    bool _541_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _542_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out174;
                    bool _out175;
                    bool _out176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out177;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out174, out _out175, out _out176, out _out177);
                    _539_recursiveGen = _out174;
                    _540_recOwned = _out175;
                    _541_recErased = _out176;
                    _542_recIdents = _out177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _539_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _540_recOwned;
                    isErased = _541_recErased;
                    readIdents = _542_recIdents;
                  }
                } else if (_source29.is_Array) {
                  DAST._IType _543___mcc_h270 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _544_recursiveGen;
                    bool _545_recOwned;
                    bool _546_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _547_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out178;
                    bool _out179;
                    bool _out180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out181;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out178, out _out179, out _out180, out _out181);
                    _544_recursiveGen = _out178;
                    _545_recOwned = _out179;
                    _546_recErased = _out180;
                    _547_recIdents = _out181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _544_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _545_recOwned;
                    isErased = _546_recErased;
                    readIdents = _547_recIdents;
                  }
                } else if (_source29.is_Seq) {
                  DAST._IType _548___mcc_h272 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _549_recursiveGen;
                    bool _550_recOwned;
                    bool _551_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _552_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out182;
                    bool _out183;
                    bool _out184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out185;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out182, out _out183, out _out184, out _out185);
                    _549_recursiveGen = _out182;
                    _550_recOwned = _out183;
                    _551_recErased = _out184;
                    _552_recIdents = _out185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _549_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _550_recOwned;
                    isErased = _551_recErased;
                    readIdents = _552_recIdents;
                  }
                } else if (_source29.is_Set) {
                  DAST._IType _553___mcc_h274 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _554_recursiveGen;
                    bool _555_recOwned;
                    bool _556_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _557_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out186;
                    bool _out187;
                    bool _out188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out189;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out186, out _out187, out _out188, out _out189);
                    _554_recursiveGen = _out186;
                    _555_recOwned = _out187;
                    _556_recErased = _out188;
                    _557_recIdents = _out189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _554_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _555_recOwned;
                    isErased = _556_recErased;
                    readIdents = _557_recIdents;
                  }
                } else if (_source29.is_Multiset) {
                  DAST._IType _558___mcc_h276 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _559_recursiveGen;
                    bool _560_recOwned;
                    bool _561_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _562_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out190;
                    bool _out191;
                    bool _out192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out193;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out190, out _out191, out _out192, out _out193);
                    _559_recursiveGen = _out190;
                    _560_recOwned = _out191;
                    _561_recErased = _out192;
                    _562_recIdents = _out193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _559_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _560_recOwned;
                    isErased = _561_recErased;
                    readIdents = _562_recIdents;
                  }
                } else if (_source29.is_Map) {
                  DAST._IType _563___mcc_h278 = _source29.dtor_key;
                  DAST._IType _564___mcc_h279 = _source29.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _565_recursiveGen;
                    bool _566_recOwned;
                    bool _567_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _568_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out194;
                    bool _out195;
                    bool _out196;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out197;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out194, out _out195, out _out196, out _out197);
                    _565_recursiveGen = _out194;
                    _566_recOwned = _out195;
                    _567_recErased = _out196;
                    _568_recIdents = _out197;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _565_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _566_recOwned;
                    isErased = _567_recErased;
                    readIdents = _568_recIdents;
                  }
                } else if (_source29.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _569___mcc_h282 = _source29.dtor_args;
                  DAST._IType _570___mcc_h283 = _source29.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _571_recursiveGen;
                    bool _572_recOwned;
                    bool _573_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _574_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out198;
                    bool _out199;
                    bool _out200;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out198, out _out199, out _out200, out _out201);
                    _571_recursiveGen = _out198;
                    _572_recOwned = _out199;
                    _573_recErased = _out200;
                    _574_recIdents = _out201;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _571_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _572_recOwned;
                    isErased = _573_recErased;
                    readIdents = _574_recIdents;
                  }
                } else if (_source29.is_Primitive) {
                  DAST._IPrimitive _575___mcc_h286 = _source29.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _576_recursiveGen;
                    bool _577_recOwned;
                    bool _578_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _579_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out202;
                    bool _out203;
                    bool _out204;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out202, out _out203, out _out204, out _out205);
                    _576_recursiveGen = _out202;
                    _577_recOwned = _out203;
                    _578_recErased = _out204;
                    _579_recIdents = _out205;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _576_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _577_recOwned;
                    isErased = _578_recErased;
                    readIdents = _579_recIdents;
                  }
                } else if (_source29.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _580___mcc_h288 = _source29.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _581_recursiveGen;
                    bool _582_recOwned;
                    bool _583_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _584_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out206;
                    bool _out207;
                    bool _out208;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out206, out _out207, out _out208, out _out209);
                    _581_recursiveGen = _out206;
                    _582_recOwned = _out207;
                    _583_recErased = _out208;
                    _584_recIdents = _out209;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _581_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _582_recOwned;
                    isErased = _583_recErased;
                    readIdents = _584_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _585___mcc_h290 = _source29.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _586_recursiveGen;
                    bool _587_recOwned;
                    bool _588_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _589_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out210;
                    bool _out211;
                    bool _out212;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out210, out _out211, out _out212, out _out213);
                    _586_recursiveGen = _out210;
                    _587_recOwned = _out211;
                    _588_recErased = _out212;
                    _589_recIdents = _out213;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _586_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _587_recOwned;
                    isErased = _588_recErased;
                    readIdents = _589_recIdents;
                  }
                }
              } else if (_source28.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _590___mcc_h292 = _source28.dtor_path;
                DAST._IType _source31 = _507___mcc_h235;
                if (_source31.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _591___mcc_h296 = _source31.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _592___mcc_h297 = _source31.dtor_typeArgs;
                  DAST._IResolvedType _593___mcc_h298 = _source31.dtor_resolved;
                  DAST._IResolvedType _source32 = _593___mcc_h298;
                  if (_source32.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _594___mcc_h302 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _595_recursiveGen;
                      bool _596_recOwned;
                      bool _597_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _598_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out214;
                      bool _out215;
                      bool _out216;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out214, out _out215, out _out216, out _out217);
                      _595_recursiveGen = _out214;
                      _596_recOwned = _out215;
                      _597_recErased = _out216;
                      _598_recIdents = _out217;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _595_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _596_recOwned;
                      isErased = _597_recErased;
                      readIdents = _598_recIdents;
                    }
                  } else if (_source32.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _599___mcc_h304 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _600_recursiveGen;
                      bool _601_recOwned;
                      bool _602_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _603_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out218;
                      bool _out219;
                      bool _out220;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out221;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out218, out _out219, out _out220, out _out221);
                      _600_recursiveGen = _out218;
                      _601_recOwned = _out219;
                      _602_recErased = _out220;
                      _603_recIdents = _out221;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _600_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _601_recOwned;
                      isErased = _602_recErased;
                      readIdents = _603_recIdents;
                    }
                  } else {
                    DAST._IType _604___mcc_h306 = _source32.dtor_Newtype_a0;
                    DAST._IType _605_b = _604___mcc_h306;
                    {
                      if (object.Equals(_500_fromTpe, _605_b)) {
                        Dafny.ISequence<Dafny.Rune> _606_recursiveGen;
                        bool _607_recOwned;
                        bool _608_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _609_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out222;
                        bool _out223;
                        bool _out224;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out225;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out222, out _out223, out _out224, out _out225);
                        _606_recursiveGen = _out222;
                        _607_recOwned = _out223;
                        _608_recErased = _out224;
                        _609_recIdents = _out225;
                        Dafny.ISequence<Dafny.Rune> _610_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out226;
                        _out226 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                        _610_rhsType = _out226;
                        Dafny.ISequence<Dafny.Rune> _611_uneraseFn;
                        _611_uneraseFn = ((_607_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _610_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _611_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _606_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _607_recOwned;
                        isErased = false;
                        readIdents = _609_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out227;
                        bool _out228;
                        bool _out229;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out230;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _605_b), _605_b, _499_toTpe), selfIdent, @params, mustOwn, out _out227, out _out228, out _out229, out _out230);
                        s = _out227;
                        isOwned = _out228;
                        isErased = _out229;
                        readIdents = _out230;
                      }
                    }
                  }
                } else if (_source31.is_Nullable) {
                  DAST._IType _612___mcc_h308 = _source31.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _613_recursiveGen;
                    bool _614_recOwned;
                    bool _615_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _616_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out231;
                    bool _out232;
                    bool _out233;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out234;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out231, out _out232, out _out233, out _out234);
                    _613_recursiveGen = _out231;
                    _614_recOwned = _out232;
                    _615_recErased = _out233;
                    _616_recIdents = _out234;
                    if (!(_614_recOwned)) {
                      _613_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_613_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _615_recErased;
                    readIdents = _616_recIdents;
                  }
                } else if (_source31.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _617___mcc_h310 = _source31.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _618_recursiveGen;
                    bool _619_recOwned;
                    bool _620_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _621_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out235;
                    bool _out236;
                    bool _out237;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out238;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out235, out _out236, out _out237, out _out238);
                    _618_recursiveGen = _out235;
                    _619_recOwned = _out236;
                    _620_recErased = _out237;
                    _621_recIdents = _out238;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _618_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _619_recOwned;
                    isErased = _620_recErased;
                    readIdents = _621_recIdents;
                  }
                } else if (_source31.is_Array) {
                  DAST._IType _622___mcc_h312 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _623_recursiveGen;
                    bool _624_recOwned;
                    bool _625_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _626_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out239;
                    bool _out240;
                    bool _out241;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out242;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out239, out _out240, out _out241, out _out242);
                    _623_recursiveGen = _out239;
                    _624_recOwned = _out240;
                    _625_recErased = _out241;
                    _626_recIdents = _out242;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _623_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _624_recOwned;
                    isErased = _625_recErased;
                    readIdents = _626_recIdents;
                  }
                } else if (_source31.is_Seq) {
                  DAST._IType _627___mcc_h314 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _628_recursiveGen;
                    bool _629_recOwned;
                    bool _630_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _631_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out243;
                    bool _out244;
                    bool _out245;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out246;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out243, out _out244, out _out245, out _out246);
                    _628_recursiveGen = _out243;
                    _629_recOwned = _out244;
                    _630_recErased = _out245;
                    _631_recIdents = _out246;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _628_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _629_recOwned;
                    isErased = _630_recErased;
                    readIdents = _631_recIdents;
                  }
                } else if (_source31.is_Set) {
                  DAST._IType _632___mcc_h316 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _633_recursiveGen;
                    bool _634_recOwned;
                    bool _635_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _636_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out247;
                    bool _out248;
                    bool _out249;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out250;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out247, out _out248, out _out249, out _out250);
                    _633_recursiveGen = _out247;
                    _634_recOwned = _out248;
                    _635_recErased = _out249;
                    _636_recIdents = _out250;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _633_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _634_recOwned;
                    isErased = _635_recErased;
                    readIdents = _636_recIdents;
                  }
                } else if (_source31.is_Multiset) {
                  DAST._IType _637___mcc_h318 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _638_recursiveGen;
                    bool _639_recOwned;
                    bool _640_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _641_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out251;
                    bool _out252;
                    bool _out253;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out251, out _out252, out _out253, out _out254);
                    _638_recursiveGen = _out251;
                    _639_recOwned = _out252;
                    _640_recErased = _out253;
                    _641_recIdents = _out254;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _638_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _639_recOwned;
                    isErased = _640_recErased;
                    readIdents = _641_recIdents;
                  }
                } else if (_source31.is_Map) {
                  DAST._IType _642___mcc_h320 = _source31.dtor_key;
                  DAST._IType _643___mcc_h321 = _source31.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _644_recursiveGen;
                    bool _645_recOwned;
                    bool _646_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _647_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out255;
                    bool _out256;
                    bool _out257;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out255, out _out256, out _out257, out _out258);
                    _644_recursiveGen = _out255;
                    _645_recOwned = _out256;
                    _646_recErased = _out257;
                    _647_recIdents = _out258;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _644_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _645_recOwned;
                    isErased = _646_recErased;
                    readIdents = _647_recIdents;
                  }
                } else if (_source31.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _648___mcc_h324 = _source31.dtor_args;
                  DAST._IType _649___mcc_h325 = _source31.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _650_recursiveGen;
                    bool _651_recOwned;
                    bool _652_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _653_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out259;
                    bool _out260;
                    bool _out261;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out259, out _out260, out _out261, out _out262);
                    _650_recursiveGen = _out259;
                    _651_recOwned = _out260;
                    _652_recErased = _out261;
                    _653_recIdents = _out262;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _650_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _651_recOwned;
                    isErased = _652_recErased;
                    readIdents = _653_recIdents;
                  }
                } else if (_source31.is_Primitive) {
                  DAST._IPrimitive _654___mcc_h328 = _source31.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _655_recursiveGen;
                    bool _656_recOwned;
                    bool _657_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _658_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out263;
                    bool _out264;
                    bool _out265;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out263, out _out264, out _out265, out _out266);
                    _655_recursiveGen = _out263;
                    _656_recOwned = _out264;
                    _657_recErased = _out265;
                    _658_recIdents = _out266;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _655_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _656_recOwned;
                    isErased = _657_recErased;
                    readIdents = _658_recIdents;
                  }
                } else if (_source31.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _659___mcc_h330 = _source31.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _660_recursiveGen;
                    bool _661_recOwned;
                    bool _662_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _663_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out267;
                    bool _out268;
                    bool _out269;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out267, out _out268, out _out269, out _out270);
                    _660_recursiveGen = _out267;
                    _661_recOwned = _out268;
                    _662_recErased = _out269;
                    _663_recIdents = _out270;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _660_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _661_recOwned;
                    isErased = _662_recErased;
                    readIdents = _663_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _664___mcc_h332 = _source31.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _665_recursiveGen;
                    bool _666_recOwned;
                    bool _667_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _668_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out271;
                    bool _out272;
                    bool _out273;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out271, out _out272, out _out273, out _out274);
                    _665_recursiveGen = _out271;
                    _666_recOwned = _out272;
                    _667_recErased = _out273;
                    _668_recIdents = _out274;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _665_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _666_recOwned;
                    isErased = _667_recErased;
                    readIdents = _668_recIdents;
                  }
                }
              } else {
                DAST._IType _669___mcc_h334 = _source28.dtor_Newtype_a0;
                DAST._IType _source33 = _507___mcc_h235;
                if (_source33.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _670___mcc_h338 = _source33.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _671___mcc_h339 = _source33.dtor_typeArgs;
                  DAST._IResolvedType _672___mcc_h340 = _source33.dtor_resolved;
                  DAST._IResolvedType _source34 = _672___mcc_h340;
                  if (_source34.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _673___mcc_h347 = _source34.dtor_path;
                    DAST._IType _674_b = _669___mcc_h334;
                    {
                      if (object.Equals(_674_b, _499_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _675_recursiveGen;
                        bool _676_recOwned;
                        bool _677_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _678_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out275;
                        bool _out276;
                        bool _out277;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out275, out _out276, out _out277, out _out278);
                        _675_recursiveGen = _out275;
                        _676_recOwned = _out276;
                        _677_recErased = _out277;
                        _678_recIdents = _out278;
                        Dafny.ISequence<Dafny.Rune> _679_uneraseFn;
                        _679_uneraseFn = ((_676_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _679_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _675_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _676_recOwned;
                        isErased = true;
                        readIdents = _678_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out279;
                        bool _out280;
                        bool _out281;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _674_b), _674_b, _499_toTpe), selfIdent, @params, mustOwn, out _out279, out _out280, out _out281, out _out282);
                        s = _out279;
                        isOwned = _out280;
                        isErased = _out281;
                        readIdents = _out282;
                      }
                    }
                  } else if (_source34.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _680___mcc_h350 = _source34.dtor_path;
                    DAST._IType _681_b = _669___mcc_h334;
                    {
                      if (object.Equals(_681_b, _499_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _682_recursiveGen;
                        bool _683_recOwned;
                        bool _684_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _685_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out283;
                        bool _out284;
                        bool _out285;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out283, out _out284, out _out285, out _out286);
                        _682_recursiveGen = _out283;
                        _683_recOwned = _out284;
                        _684_recErased = _out285;
                        _685_recIdents = _out286;
                        Dafny.ISequence<Dafny.Rune> _686_uneraseFn;
                        _686_uneraseFn = ((_683_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _686_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _683_recOwned;
                        isErased = true;
                        readIdents = _685_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out287;
                        bool _out288;
                        bool _out289;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out290;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _681_b), _681_b, _499_toTpe), selfIdent, @params, mustOwn, out _out287, out _out288, out _out289, out _out290);
                        s = _out287;
                        isOwned = _out288;
                        isErased = _out289;
                        readIdents = _out290;
                      }
                    }
                  } else {
                    DAST._IType _687___mcc_h353 = _source34.dtor_Newtype_a0;
                    DAST._IType _688_b = _687___mcc_h353;
                    {
                      if (object.Equals(_500_fromTpe, _688_b)) {
                        Dafny.ISequence<Dafny.Rune> _689_recursiveGen;
                        bool _690_recOwned;
                        bool _691_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _692_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out291;
                        bool _out292;
                        bool _out293;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out294;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out291, out _out292, out _out293, out _out294);
                        _689_recursiveGen = _out291;
                        _690_recOwned = _out292;
                        _691_recErased = _out293;
                        _692_recIdents = _out294;
                        Dafny.ISequence<Dafny.Rune> _693_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out295;
                        _out295 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                        _693_rhsType = _out295;
                        Dafny.ISequence<Dafny.Rune> _694_uneraseFn;
                        _694_uneraseFn = ((_690_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _693_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _694_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _689_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _690_recOwned;
                        isErased = false;
                        readIdents = _692_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out296;
                        bool _out297;
                        bool _out298;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out299;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _688_b), _688_b, _499_toTpe), selfIdent, @params, mustOwn, out _out296, out _out297, out _out298, out _out299);
                        s = _out296;
                        isOwned = _out297;
                        isErased = _out298;
                        readIdents = _out299;
                      }
                    }
                  }
                } else if (_source33.is_Nullable) {
                  DAST._IType _695___mcc_h356 = _source33.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _696_recursiveGen;
                    bool _697_recOwned;
                    bool _698_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _699_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out300;
                    bool _out301;
                    bool _out302;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out303;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out300, out _out301, out _out302, out _out303);
                    _696_recursiveGen = _out300;
                    _697_recOwned = _out301;
                    _698_recErased = _out302;
                    _699_recIdents = _out303;
                    if (!(_697_recOwned)) {
                      _696_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_696_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _696_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _698_recErased;
                    readIdents = _699_recIdents;
                  }
                } else if (_source33.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _700___mcc_h359 = _source33.dtor_Tuple_a0;
                  DAST._IType _701_b = _669___mcc_h334;
                  {
                    if (object.Equals(_701_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _702_recursiveGen;
                      bool _703_recOwned;
                      bool _704_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _705_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out304;
                      bool _out305;
                      bool _out306;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out304, out _out305, out _out306, out _out307);
                      _702_recursiveGen = _out304;
                      _703_recOwned = _out305;
                      _704_recErased = _out306;
                      _705_recIdents = _out307;
                      Dafny.ISequence<Dafny.Rune> _706_uneraseFn;
                      _706_uneraseFn = ((_703_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _706_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _702_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _703_recOwned;
                      isErased = true;
                      readIdents = _705_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out308;
                      bool _out309;
                      bool _out310;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _701_b), _701_b, _499_toTpe), selfIdent, @params, mustOwn, out _out308, out _out309, out _out310, out _out311);
                      s = _out308;
                      isOwned = _out309;
                      isErased = _out310;
                      readIdents = _out311;
                    }
                  }
                } else if (_source33.is_Array) {
                  DAST._IType _707___mcc_h362 = _source33.dtor_element;
                  DAST._IType _708_b = _669___mcc_h334;
                  {
                    if (object.Equals(_708_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _709_recursiveGen;
                      bool _710_recOwned;
                      bool _711_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _712_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out312;
                      bool _out313;
                      bool _out314;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out312, out _out313, out _out314, out _out315);
                      _709_recursiveGen = _out312;
                      _710_recOwned = _out313;
                      _711_recErased = _out314;
                      _712_recIdents = _out315;
                      Dafny.ISequence<Dafny.Rune> _713_uneraseFn;
                      _713_uneraseFn = ((_710_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _713_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _709_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _710_recOwned;
                      isErased = true;
                      readIdents = _712_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out316;
                      bool _out317;
                      bool _out318;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _708_b), _708_b, _499_toTpe), selfIdent, @params, mustOwn, out _out316, out _out317, out _out318, out _out319);
                      s = _out316;
                      isOwned = _out317;
                      isErased = _out318;
                      readIdents = _out319;
                    }
                  }
                } else if (_source33.is_Seq) {
                  DAST._IType _714___mcc_h365 = _source33.dtor_element;
                  DAST._IType _715_b = _669___mcc_h334;
                  {
                    if (object.Equals(_715_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _716_recursiveGen;
                      bool _717_recOwned;
                      bool _718_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _719_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out320;
                      bool _out321;
                      bool _out322;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out320, out _out321, out _out322, out _out323);
                      _716_recursiveGen = _out320;
                      _717_recOwned = _out321;
                      _718_recErased = _out322;
                      _719_recIdents = _out323;
                      Dafny.ISequence<Dafny.Rune> _720_uneraseFn;
                      _720_uneraseFn = ((_717_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _720_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _716_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _717_recOwned;
                      isErased = true;
                      readIdents = _719_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out324;
                      bool _out325;
                      bool _out326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _715_b), _715_b, _499_toTpe), selfIdent, @params, mustOwn, out _out324, out _out325, out _out326, out _out327);
                      s = _out324;
                      isOwned = _out325;
                      isErased = _out326;
                      readIdents = _out327;
                    }
                  }
                } else if (_source33.is_Set) {
                  DAST._IType _721___mcc_h368 = _source33.dtor_element;
                  DAST._IType _722_b = _669___mcc_h334;
                  {
                    if (object.Equals(_722_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _723_recursiveGen;
                      bool _724_recOwned;
                      bool _725_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _726_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out328;
                      bool _out329;
                      bool _out330;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out328, out _out329, out _out330, out _out331);
                      _723_recursiveGen = _out328;
                      _724_recOwned = _out329;
                      _725_recErased = _out330;
                      _726_recIdents = _out331;
                      Dafny.ISequence<Dafny.Rune> _727_uneraseFn;
                      _727_uneraseFn = ((_724_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _727_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _723_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _724_recOwned;
                      isErased = true;
                      readIdents = _726_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out332;
                      bool _out333;
                      bool _out334;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _722_b), _722_b, _499_toTpe), selfIdent, @params, mustOwn, out _out332, out _out333, out _out334, out _out335);
                      s = _out332;
                      isOwned = _out333;
                      isErased = _out334;
                      readIdents = _out335;
                    }
                  }
                } else if (_source33.is_Multiset) {
                  DAST._IType _728___mcc_h371 = _source33.dtor_element;
                  DAST._IType _729_b = _669___mcc_h334;
                  {
                    if (object.Equals(_729_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _730_recursiveGen;
                      bool _731_recOwned;
                      bool _732_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _733_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out336;
                      bool _out337;
                      bool _out338;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out336, out _out337, out _out338, out _out339);
                      _730_recursiveGen = _out336;
                      _731_recOwned = _out337;
                      _732_recErased = _out338;
                      _733_recIdents = _out339;
                      Dafny.ISequence<Dafny.Rune> _734_uneraseFn;
                      _734_uneraseFn = ((_731_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _734_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _730_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _731_recOwned;
                      isErased = true;
                      readIdents = _733_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out340;
                      bool _out341;
                      bool _out342;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _729_b), _729_b, _499_toTpe), selfIdent, @params, mustOwn, out _out340, out _out341, out _out342, out _out343);
                      s = _out340;
                      isOwned = _out341;
                      isErased = _out342;
                      readIdents = _out343;
                    }
                  }
                } else if (_source33.is_Map) {
                  DAST._IType _735___mcc_h374 = _source33.dtor_key;
                  DAST._IType _736___mcc_h375 = _source33.dtor_value;
                  DAST._IType _737_b = _669___mcc_h334;
                  {
                    if (object.Equals(_737_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _738_recursiveGen;
                      bool _739_recOwned;
                      bool _740_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _741_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out344;
                      bool _out345;
                      bool _out346;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out344, out _out345, out _out346, out _out347);
                      _738_recursiveGen = _out344;
                      _739_recOwned = _out345;
                      _740_recErased = _out346;
                      _741_recIdents = _out347;
                      Dafny.ISequence<Dafny.Rune> _742_uneraseFn;
                      _742_uneraseFn = ((_739_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _742_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _738_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _739_recOwned;
                      isErased = true;
                      readIdents = _741_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out348;
                      bool _out349;
                      bool _out350;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _737_b), _737_b, _499_toTpe), selfIdent, @params, mustOwn, out _out348, out _out349, out _out350, out _out351);
                      s = _out348;
                      isOwned = _out349;
                      isErased = _out350;
                      readIdents = _out351;
                    }
                  }
                } else if (_source33.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _743___mcc_h380 = _source33.dtor_args;
                  DAST._IType _744___mcc_h381 = _source33.dtor_result;
                  DAST._IType _745_b = _669___mcc_h334;
                  {
                    if (object.Equals(_745_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _746_recursiveGen;
                      bool _747_recOwned;
                      bool _748_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _749_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out352;
                      bool _out353;
                      bool _out354;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out352, out _out353, out _out354, out _out355);
                      _746_recursiveGen = _out352;
                      _747_recOwned = _out353;
                      _748_recErased = _out354;
                      _749_recIdents = _out355;
                      Dafny.ISequence<Dafny.Rune> _750_uneraseFn;
                      _750_uneraseFn = ((_747_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _750_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _746_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _747_recOwned;
                      isErased = true;
                      readIdents = _749_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out356;
                      bool _out357;
                      bool _out358;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out359;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _745_b), _745_b, _499_toTpe), selfIdent, @params, mustOwn, out _out356, out _out357, out _out358, out _out359);
                      s = _out356;
                      isOwned = _out357;
                      isErased = _out358;
                      readIdents = _out359;
                    }
                  }
                } else if (_source33.is_Primitive) {
                  DAST._IPrimitive _751___mcc_h386 = _source33.dtor_Primitive_a0;
                  DAST._IType _752_b = _669___mcc_h334;
                  {
                    if (object.Equals(_752_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _753_recursiveGen;
                      bool _754_recOwned;
                      bool _755_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _756_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out360;
                      bool _out361;
                      bool _out362;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out363;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out360, out _out361, out _out362, out _out363);
                      _753_recursiveGen = _out360;
                      _754_recOwned = _out361;
                      _755_recErased = _out362;
                      _756_recIdents = _out363;
                      Dafny.ISequence<Dafny.Rune> _757_uneraseFn;
                      _757_uneraseFn = ((_754_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _757_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _753_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _754_recOwned;
                      isErased = true;
                      readIdents = _756_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out364;
                      bool _out365;
                      bool _out366;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out367;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _752_b), _752_b, _499_toTpe), selfIdent, @params, mustOwn, out _out364, out _out365, out _out366, out _out367);
                      s = _out364;
                      isOwned = _out365;
                      isErased = _out366;
                      readIdents = _out367;
                    }
                  }
                } else if (_source33.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _758___mcc_h389 = _source33.dtor_Passthrough_a0;
                  DAST._IType _759_b = _669___mcc_h334;
                  {
                    if (object.Equals(_759_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _760_recursiveGen;
                      bool _761_recOwned;
                      bool _762_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _763_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out368;
                      bool _out369;
                      bool _out370;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out371;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out368, out _out369, out _out370, out _out371);
                      _760_recursiveGen = _out368;
                      _761_recOwned = _out369;
                      _762_recErased = _out370;
                      _763_recIdents = _out371;
                      Dafny.ISequence<Dafny.Rune> _764_uneraseFn;
                      _764_uneraseFn = ((_761_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _764_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _760_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _761_recOwned;
                      isErased = true;
                      readIdents = _763_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out372;
                      bool _out373;
                      bool _out374;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out375;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _759_b), _759_b, _499_toTpe), selfIdent, @params, mustOwn, out _out372, out _out373, out _out374, out _out375);
                      s = _out372;
                      isOwned = _out373;
                      isErased = _out374;
                      readIdents = _out375;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _765___mcc_h392 = _source33.dtor_TypeArg_a0;
                  DAST._IType _766_b = _669___mcc_h334;
                  {
                    if (object.Equals(_766_b, _499_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _767_recursiveGen;
                      bool _768_recOwned;
                      bool _769_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _770_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out376;
                      bool _out377;
                      bool _out378;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out379;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out376, out _out377, out _out378, out _out379);
                      _767_recursiveGen = _out376;
                      _768_recOwned = _out377;
                      _769_recErased = _out378;
                      _770_recIdents = _out379;
                      Dafny.ISequence<Dafny.Rune> _771_uneraseFn;
                      _771_uneraseFn = ((_768_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _771_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _767_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _768_recOwned;
                      isErased = true;
                      readIdents = _770_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out380;
                      bool _out381;
                      bool _out382;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out383;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _766_b), _766_b, _499_toTpe), selfIdent, @params, mustOwn, out _out380, out _out381, out _out382, out _out383);
                      s = _out380;
                      isOwned = _out381;
                      isErased = _out382;
                      readIdents = _out383;
                    }
                  }
                }
              }
            } else if (_source27.is_Nullable) {
              DAST._IType _772___mcc_h395 = _source27.dtor_Nullable_a0;
              DAST._IType _source35 = _507___mcc_h235;
              if (_source35.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _773___mcc_h399 = _source35.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _774___mcc_h400 = _source35.dtor_typeArgs;
                DAST._IResolvedType _775___mcc_h401 = _source35.dtor_resolved;
                DAST._IResolvedType _source36 = _775___mcc_h401;
                if (_source36.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _776___mcc_h408 = _source36.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _777_recursiveGen;
                    bool _778_recOwned;
                    bool _779_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _780_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out384;
                    bool _out385;
                    bool _out386;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out387;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out384, out _out385, out _out386, out _out387);
                    _777_recursiveGen = _out384;
                    _778_recOwned = _out385;
                    _779_recErased = _out386;
                    _780_recIdents = _out387;
                    if (!(_778_recOwned)) {
                      _777_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_777_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_777_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _778_recOwned;
                    isErased = _779_recErased;
                    readIdents = _780_recIdents;
                  }
                } else if (_source36.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _781___mcc_h411 = _source36.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _782_recursiveGen;
                    bool _783_recOwned;
                    bool _784_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _785_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out388;
                    bool _out389;
                    bool _out390;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out391;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out388, out _out389, out _out390, out _out391);
                    _782_recursiveGen = _out388;
                    _783_recOwned = _out389;
                    _784_recErased = _out390;
                    _785_recIdents = _out391;
                    if (!(_783_recOwned)) {
                      _782_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_782_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_782_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _783_recOwned;
                    isErased = _784_recErased;
                    readIdents = _785_recIdents;
                  }
                } else {
                  DAST._IType _786___mcc_h414 = _source36.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _787_recursiveGen;
                    bool _788_recOwned;
                    bool _789_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _790_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out392;
                    bool _out393;
                    bool _out394;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out395;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out392, out _out393, out _out394, out _out395);
                    _787_recursiveGen = _out392;
                    _788_recOwned = _out393;
                    _789_recErased = _out394;
                    _790_recIdents = _out395;
                    if (!(_788_recOwned)) {
                      _787_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_787_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_787_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _788_recOwned;
                    isErased = _789_recErased;
                    readIdents = _790_recIdents;
                  }
                }
              } else if (_source35.is_Nullable) {
                DAST._IType _791___mcc_h417 = _source35.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _792_recursiveGen;
                  bool _793_recOwned;
                  bool _794_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _795_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out396;
                  bool _out397;
                  bool _out398;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out399;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out396, out _out397, out _out398, out _out399);
                  _792_recursiveGen = _out396;
                  _793_recOwned = _out397;
                  _794_recErased = _out398;
                  _795_recIdents = _out399;
                  if (!(_793_recOwned)) {
                    _792_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_792_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_792_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _793_recOwned;
                  isErased = _794_recErased;
                  readIdents = _795_recIdents;
                }
              } else if (_source35.is_Tuple) {
                Dafny.ISequence<DAST._IType> _796___mcc_h420 = _source35.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _797_recursiveGen;
                  bool _798_recOwned;
                  bool _799_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _800_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out400;
                  bool _out401;
                  bool _out402;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out403;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out400, out _out401, out _out402, out _out403);
                  _797_recursiveGen = _out400;
                  _798_recOwned = _out401;
                  _799_recErased = _out402;
                  _800_recIdents = _out403;
                  if (!(_798_recOwned)) {
                    _797_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_797_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_797_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _798_recOwned;
                  isErased = _799_recErased;
                  readIdents = _800_recIdents;
                }
              } else if (_source35.is_Array) {
                DAST._IType _801___mcc_h423 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _802_recursiveGen;
                  bool _803_recOwned;
                  bool _804_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _805_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out404;
                  bool _out405;
                  bool _out406;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out407;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out404, out _out405, out _out406, out _out407);
                  _802_recursiveGen = _out404;
                  _803_recOwned = _out405;
                  _804_recErased = _out406;
                  _805_recIdents = _out407;
                  if (!(_803_recOwned)) {
                    _802_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_802_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_802_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _803_recOwned;
                  isErased = _804_recErased;
                  readIdents = _805_recIdents;
                }
              } else if (_source35.is_Seq) {
                DAST._IType _806___mcc_h426 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _807_recursiveGen;
                  bool _808_recOwned;
                  bool _809_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _810_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out408;
                  bool _out409;
                  bool _out410;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out411;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out408, out _out409, out _out410, out _out411);
                  _807_recursiveGen = _out408;
                  _808_recOwned = _out409;
                  _809_recErased = _out410;
                  _810_recIdents = _out411;
                  if (!(_808_recOwned)) {
                    _807_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_807_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_807_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _808_recOwned;
                  isErased = _809_recErased;
                  readIdents = _810_recIdents;
                }
              } else if (_source35.is_Set) {
                DAST._IType _811___mcc_h429 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _812_recursiveGen;
                  bool _813_recOwned;
                  bool _814_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _815_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out412;
                  bool _out413;
                  bool _out414;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out415;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out412, out _out413, out _out414, out _out415);
                  _812_recursiveGen = _out412;
                  _813_recOwned = _out413;
                  _814_recErased = _out414;
                  _815_recIdents = _out415;
                  if (!(_813_recOwned)) {
                    _812_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_812_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_812_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _813_recOwned;
                  isErased = _814_recErased;
                  readIdents = _815_recIdents;
                }
              } else if (_source35.is_Multiset) {
                DAST._IType _816___mcc_h432 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _817_recursiveGen;
                  bool _818_recOwned;
                  bool _819_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _820_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out416;
                  bool _out417;
                  bool _out418;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out419;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out416, out _out417, out _out418, out _out419);
                  _817_recursiveGen = _out416;
                  _818_recOwned = _out417;
                  _819_recErased = _out418;
                  _820_recIdents = _out419;
                  if (!(_818_recOwned)) {
                    _817_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_817_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_817_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _818_recOwned;
                  isErased = _819_recErased;
                  readIdents = _820_recIdents;
                }
              } else if (_source35.is_Map) {
                DAST._IType _821___mcc_h435 = _source35.dtor_key;
                DAST._IType _822___mcc_h436 = _source35.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _823_recursiveGen;
                  bool _824_recOwned;
                  bool _825_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _826_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out420;
                  bool _out421;
                  bool _out422;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out423;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out420, out _out421, out _out422, out _out423);
                  _823_recursiveGen = _out420;
                  _824_recOwned = _out421;
                  _825_recErased = _out422;
                  _826_recIdents = _out423;
                  if (!(_824_recOwned)) {
                    _823_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_823_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_823_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _824_recOwned;
                  isErased = _825_recErased;
                  readIdents = _826_recIdents;
                }
              } else if (_source35.is_Arrow) {
                Dafny.ISequence<DAST._IType> _827___mcc_h441 = _source35.dtor_args;
                DAST._IType _828___mcc_h442 = _source35.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _829_recursiveGen;
                  bool _830_recOwned;
                  bool _831_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _832_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out424;
                  bool _out425;
                  bool _out426;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out427;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out424, out _out425, out _out426, out _out427);
                  _829_recursiveGen = _out424;
                  _830_recOwned = _out425;
                  _831_recErased = _out426;
                  _832_recIdents = _out427;
                  if (!(_830_recOwned)) {
                    _829_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_829_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_829_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _830_recOwned;
                  isErased = _831_recErased;
                  readIdents = _832_recIdents;
                }
              } else if (_source35.is_Primitive) {
                DAST._IPrimitive _833___mcc_h447 = _source35.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _834_recursiveGen;
                  bool _835_recOwned;
                  bool _836_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _837_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out428;
                  bool _out429;
                  bool _out430;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out431;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out428, out _out429, out _out430, out _out431);
                  _834_recursiveGen = _out428;
                  _835_recOwned = _out429;
                  _836_recErased = _out430;
                  _837_recIdents = _out431;
                  if (!(_835_recOwned)) {
                    _834_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_834_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_834_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _835_recOwned;
                  isErased = _836_recErased;
                  readIdents = _837_recIdents;
                }
              } else if (_source35.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _838___mcc_h450 = _source35.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _839_recursiveGen;
                  bool _840_recOwned;
                  bool _841_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _842_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out432;
                  bool _out433;
                  bool _out434;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out435;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out432, out _out433, out _out434, out _out435);
                  _839_recursiveGen = _out432;
                  _840_recOwned = _out433;
                  _841_recErased = _out434;
                  _842_recIdents = _out435;
                  if (!(_840_recOwned)) {
                    _839_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_839_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_839_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _840_recOwned;
                  isErased = _841_recErased;
                  readIdents = _842_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _843___mcc_h453 = _source35.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _844_recursiveGen;
                  bool _845_recOwned;
                  bool _846_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _847_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out436;
                  bool _out437;
                  bool _out438;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out439;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out436, out _out437, out _out438, out _out439);
                  _844_recursiveGen = _out436;
                  _845_recOwned = _out437;
                  _846_recErased = _out438;
                  _847_recIdents = _out439;
                  if (!(_845_recOwned)) {
                    _844_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_844_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_844_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _845_recOwned;
                  isErased = _846_recErased;
                  readIdents = _847_recIdents;
                }
              }
            } else if (_source27.is_Tuple) {
              Dafny.ISequence<DAST._IType> _848___mcc_h456 = _source27.dtor_Tuple_a0;
              DAST._IType _source37 = _507___mcc_h235;
              if (_source37.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _849___mcc_h460 = _source37.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _850___mcc_h461 = _source37.dtor_typeArgs;
                DAST._IResolvedType _851___mcc_h462 = _source37.dtor_resolved;
                DAST._IResolvedType _source38 = _851___mcc_h462;
                if (_source38.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _852___mcc_h466 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _853_recursiveGen;
                    bool _854_recOwned;
                    bool _855_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _856_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out440;
                    bool _out441;
                    bool _out442;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out443;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out440, out _out441, out _out442, out _out443);
                    _853_recursiveGen = _out440;
                    _854_recOwned = _out441;
                    _855_recErased = _out442;
                    _856_recIdents = _out443;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _853_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _854_recOwned;
                    isErased = _855_recErased;
                    readIdents = _856_recIdents;
                  }
                } else if (_source38.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _857___mcc_h468 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _858_recursiveGen;
                    bool _859_recOwned;
                    bool _860_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _861_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out444;
                    bool _out445;
                    bool _out446;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out447;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out444, out _out445, out _out446, out _out447);
                    _858_recursiveGen = _out444;
                    _859_recOwned = _out445;
                    _860_recErased = _out446;
                    _861_recIdents = _out447;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _858_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _859_recOwned;
                    isErased = _860_recErased;
                    readIdents = _861_recIdents;
                  }
                } else {
                  DAST._IType _862___mcc_h470 = _source38.dtor_Newtype_a0;
                  DAST._IType _863_b = _862___mcc_h470;
                  {
                    if (object.Equals(_500_fromTpe, _863_b)) {
                      Dafny.ISequence<Dafny.Rune> _864_recursiveGen;
                      bool _865_recOwned;
                      bool _866_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _867_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out448;
                      bool _out449;
                      bool _out450;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out451;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out448, out _out449, out _out450, out _out451);
                      _864_recursiveGen = _out448;
                      _865_recOwned = _out449;
                      _866_recErased = _out450;
                      _867_recIdents = _out451;
                      Dafny.ISequence<Dafny.Rune> _868_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out452;
                      _out452 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _868_rhsType = _out452;
                      Dafny.ISequence<Dafny.Rune> _869_uneraseFn;
                      _869_uneraseFn = ((_865_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _868_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _869_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _864_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _865_recOwned;
                      isErased = false;
                      readIdents = _867_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out453;
                      bool _out454;
                      bool _out455;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out456;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _863_b), _863_b, _499_toTpe), selfIdent, @params, mustOwn, out _out453, out _out454, out _out455, out _out456);
                      s = _out453;
                      isOwned = _out454;
                      isErased = _out455;
                      readIdents = _out456;
                    }
                  }
                }
              } else if (_source37.is_Nullable) {
                DAST._IType _870___mcc_h472 = _source37.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _871_recursiveGen;
                  bool _872_recOwned;
                  bool _873_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _874_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out457;
                  bool _out458;
                  bool _out459;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out460;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out457, out _out458, out _out459, out _out460);
                  _871_recursiveGen = _out457;
                  _872_recOwned = _out458;
                  _873_recErased = _out459;
                  _874_recIdents = _out460;
                  if (!(_872_recOwned)) {
                    _871_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_871_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _871_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _873_recErased;
                  readIdents = _874_recIdents;
                }
              } else if (_source37.is_Tuple) {
                Dafny.ISequence<DAST._IType> _875___mcc_h474 = _source37.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _876_recursiveGen;
                  bool _877_recOwned;
                  bool _878_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _879_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out461;
                  bool _out462;
                  bool _out463;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out464;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out461, out _out462, out _out463, out _out464);
                  _876_recursiveGen = _out461;
                  _877_recOwned = _out462;
                  _878_recErased = _out463;
                  _879_recIdents = _out464;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _876_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _877_recOwned;
                  isErased = _878_recErased;
                  readIdents = _879_recIdents;
                }
              } else if (_source37.is_Array) {
                DAST._IType _880___mcc_h476 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _881_recursiveGen;
                  bool _882_recOwned;
                  bool _883_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _884_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out465;
                  bool _out466;
                  bool _out467;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out468;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out465, out _out466, out _out467, out _out468);
                  _881_recursiveGen = _out465;
                  _882_recOwned = _out466;
                  _883_recErased = _out467;
                  _884_recIdents = _out468;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _881_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _882_recOwned;
                  isErased = _883_recErased;
                  readIdents = _884_recIdents;
                }
              } else if (_source37.is_Seq) {
                DAST._IType _885___mcc_h478 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _886_recursiveGen;
                  bool _887_recOwned;
                  bool _888_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _889_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out469;
                  bool _out470;
                  bool _out471;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out472;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out469, out _out470, out _out471, out _out472);
                  _886_recursiveGen = _out469;
                  _887_recOwned = _out470;
                  _888_recErased = _out471;
                  _889_recIdents = _out472;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _886_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _887_recOwned;
                  isErased = _888_recErased;
                  readIdents = _889_recIdents;
                }
              } else if (_source37.is_Set) {
                DAST._IType _890___mcc_h480 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _891_recursiveGen;
                  bool _892_recOwned;
                  bool _893_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _894_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out473;
                  bool _out474;
                  bool _out475;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out476;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out473, out _out474, out _out475, out _out476);
                  _891_recursiveGen = _out473;
                  _892_recOwned = _out474;
                  _893_recErased = _out475;
                  _894_recIdents = _out476;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _891_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _892_recOwned;
                  isErased = _893_recErased;
                  readIdents = _894_recIdents;
                }
              } else if (_source37.is_Multiset) {
                DAST._IType _895___mcc_h482 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _896_recursiveGen;
                  bool _897_recOwned;
                  bool _898_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _899_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out477;
                  bool _out478;
                  bool _out479;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out480;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out477, out _out478, out _out479, out _out480);
                  _896_recursiveGen = _out477;
                  _897_recOwned = _out478;
                  _898_recErased = _out479;
                  _899_recIdents = _out480;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _896_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _897_recOwned;
                  isErased = _898_recErased;
                  readIdents = _899_recIdents;
                }
              } else if (_source37.is_Map) {
                DAST._IType _900___mcc_h484 = _source37.dtor_key;
                DAST._IType _901___mcc_h485 = _source37.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _902_recursiveGen;
                  bool _903_recOwned;
                  bool _904_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _905_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out481;
                  bool _out482;
                  bool _out483;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out484;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out481, out _out482, out _out483, out _out484);
                  _902_recursiveGen = _out481;
                  _903_recOwned = _out482;
                  _904_recErased = _out483;
                  _905_recIdents = _out484;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _902_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _903_recOwned;
                  isErased = _904_recErased;
                  readIdents = _905_recIdents;
                }
              } else if (_source37.is_Arrow) {
                Dafny.ISequence<DAST._IType> _906___mcc_h488 = _source37.dtor_args;
                DAST._IType _907___mcc_h489 = _source37.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _908_recursiveGen;
                  bool _909_recOwned;
                  bool _910_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _911_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out485;
                  bool _out486;
                  bool _out487;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out488;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out485, out _out486, out _out487, out _out488);
                  _908_recursiveGen = _out485;
                  _909_recOwned = _out486;
                  _910_recErased = _out487;
                  _911_recIdents = _out488;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _908_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _909_recOwned;
                  isErased = _910_recErased;
                  readIdents = _911_recIdents;
                }
              } else if (_source37.is_Primitive) {
                DAST._IPrimitive _912___mcc_h492 = _source37.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _913_recursiveGen;
                  bool _914_recOwned;
                  bool _915_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _916_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out489;
                  bool _out490;
                  bool _out491;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out492;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out489, out _out490, out _out491, out _out492);
                  _913_recursiveGen = _out489;
                  _914_recOwned = _out490;
                  _915_recErased = _out491;
                  _916_recIdents = _out492;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _913_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _914_recOwned;
                  isErased = _915_recErased;
                  readIdents = _916_recIdents;
                }
              } else if (_source37.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _917___mcc_h494 = _source37.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _918_recursiveGen;
                  bool _919_recOwned;
                  bool _920_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _921_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out493;
                  bool _out494;
                  bool _out495;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out496;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out493, out _out494, out _out495, out _out496);
                  _918_recursiveGen = _out493;
                  _919_recOwned = _out494;
                  _920_recErased = _out495;
                  _921_recIdents = _out496;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _918_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _919_recOwned;
                  isErased = _920_recErased;
                  readIdents = _921_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _922___mcc_h496 = _source37.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _923_recursiveGen;
                  bool _924_recOwned;
                  bool _925_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _926_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out497;
                  bool _out498;
                  bool _out499;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out500;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out497, out _out498, out _out499, out _out500);
                  _923_recursiveGen = _out497;
                  _924_recOwned = _out498;
                  _925_recErased = _out499;
                  _926_recIdents = _out500;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _923_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _924_recOwned;
                  isErased = _925_recErased;
                  readIdents = _926_recIdents;
                }
              }
            } else if (_source27.is_Array) {
              DAST._IType _927___mcc_h498 = _source27.dtor_element;
              DAST._IType _source39 = _507___mcc_h235;
              if (_source39.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _928___mcc_h502 = _source39.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _929___mcc_h503 = _source39.dtor_typeArgs;
                DAST._IResolvedType _930___mcc_h504 = _source39.dtor_resolved;
                DAST._IResolvedType _source40 = _930___mcc_h504;
                if (_source40.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _931___mcc_h508 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _932_recursiveGen;
                    bool _933_recOwned;
                    bool _934_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _935_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out501;
                    bool _out502;
                    bool _out503;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out504;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out501, out _out502, out _out503, out _out504);
                    _932_recursiveGen = _out501;
                    _933_recOwned = _out502;
                    _934_recErased = _out503;
                    _935_recIdents = _out504;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _932_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _933_recOwned;
                    isErased = _934_recErased;
                    readIdents = _935_recIdents;
                  }
                } else if (_source40.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _936___mcc_h510 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _937_recursiveGen;
                    bool _938_recOwned;
                    bool _939_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _940_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out505;
                    bool _out506;
                    bool _out507;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out508;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out505, out _out506, out _out507, out _out508);
                    _937_recursiveGen = _out505;
                    _938_recOwned = _out506;
                    _939_recErased = _out507;
                    _940_recIdents = _out508;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _937_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _938_recOwned;
                    isErased = _939_recErased;
                    readIdents = _940_recIdents;
                  }
                } else {
                  DAST._IType _941___mcc_h512 = _source40.dtor_Newtype_a0;
                  DAST._IType _942_b = _941___mcc_h512;
                  {
                    if (object.Equals(_500_fromTpe, _942_b)) {
                      Dafny.ISequence<Dafny.Rune> _943_recursiveGen;
                      bool _944_recOwned;
                      bool _945_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _946_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out509;
                      bool _out510;
                      bool _out511;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out512;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out509, out _out510, out _out511, out _out512);
                      _943_recursiveGen = _out509;
                      _944_recOwned = _out510;
                      _945_recErased = _out511;
                      _946_recIdents = _out512;
                      Dafny.ISequence<Dafny.Rune> _947_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out513;
                      _out513 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _947_rhsType = _out513;
                      Dafny.ISequence<Dafny.Rune> _948_uneraseFn;
                      _948_uneraseFn = ((_944_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _947_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _948_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _943_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _944_recOwned;
                      isErased = false;
                      readIdents = _946_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out514;
                      bool _out515;
                      bool _out516;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out517;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _942_b), _942_b, _499_toTpe), selfIdent, @params, mustOwn, out _out514, out _out515, out _out516, out _out517);
                      s = _out514;
                      isOwned = _out515;
                      isErased = _out516;
                      readIdents = _out517;
                    }
                  }
                }
              } else if (_source39.is_Nullable) {
                DAST._IType _949___mcc_h514 = _source39.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _950_recursiveGen;
                  bool _951_recOwned;
                  bool _952_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _953_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out518;
                  bool _out519;
                  bool _out520;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out521;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out518, out _out519, out _out520, out _out521);
                  _950_recursiveGen = _out518;
                  _951_recOwned = _out519;
                  _952_recErased = _out520;
                  _953_recIdents = _out521;
                  if (!(_951_recOwned)) {
                    _950_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_950_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _950_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _952_recErased;
                  readIdents = _953_recIdents;
                }
              } else if (_source39.is_Tuple) {
                Dafny.ISequence<DAST._IType> _954___mcc_h516 = _source39.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _955_recursiveGen;
                  bool _956_recOwned;
                  bool _957_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _958_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out522;
                  bool _out523;
                  bool _out524;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out525;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out522, out _out523, out _out524, out _out525);
                  _955_recursiveGen = _out522;
                  _956_recOwned = _out523;
                  _957_recErased = _out524;
                  _958_recIdents = _out525;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _955_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _956_recOwned;
                  isErased = _957_recErased;
                  readIdents = _958_recIdents;
                }
              } else if (_source39.is_Array) {
                DAST._IType _959___mcc_h518 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _960_recursiveGen;
                  bool _961_recOwned;
                  bool _962_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _963_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out526;
                  bool _out527;
                  bool _out528;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out529;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out526, out _out527, out _out528, out _out529);
                  _960_recursiveGen = _out526;
                  _961_recOwned = _out527;
                  _962_recErased = _out528;
                  _963_recIdents = _out529;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _960_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _961_recOwned;
                  isErased = _962_recErased;
                  readIdents = _963_recIdents;
                }
              } else if (_source39.is_Seq) {
                DAST._IType _964___mcc_h520 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _965_recursiveGen;
                  bool _966_recOwned;
                  bool _967_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _968_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out530;
                  bool _out531;
                  bool _out532;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out533;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out530, out _out531, out _out532, out _out533);
                  _965_recursiveGen = _out530;
                  _966_recOwned = _out531;
                  _967_recErased = _out532;
                  _968_recIdents = _out533;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _965_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _966_recOwned;
                  isErased = _967_recErased;
                  readIdents = _968_recIdents;
                }
              } else if (_source39.is_Set) {
                DAST._IType _969___mcc_h522 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _970_recursiveGen;
                  bool _971_recOwned;
                  bool _972_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _973_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out534;
                  bool _out535;
                  bool _out536;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out537;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out534, out _out535, out _out536, out _out537);
                  _970_recursiveGen = _out534;
                  _971_recOwned = _out535;
                  _972_recErased = _out536;
                  _973_recIdents = _out537;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _970_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _971_recOwned;
                  isErased = _972_recErased;
                  readIdents = _973_recIdents;
                }
              } else if (_source39.is_Multiset) {
                DAST._IType _974___mcc_h524 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _975_recursiveGen;
                  bool _976_recOwned;
                  bool _977_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _978_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out538;
                  bool _out539;
                  bool _out540;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out541;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out538, out _out539, out _out540, out _out541);
                  _975_recursiveGen = _out538;
                  _976_recOwned = _out539;
                  _977_recErased = _out540;
                  _978_recIdents = _out541;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _975_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _976_recOwned;
                  isErased = _977_recErased;
                  readIdents = _978_recIdents;
                }
              } else if (_source39.is_Map) {
                DAST._IType _979___mcc_h526 = _source39.dtor_key;
                DAST._IType _980___mcc_h527 = _source39.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _981_recursiveGen;
                  bool _982_recOwned;
                  bool _983_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _984_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out542;
                  bool _out543;
                  bool _out544;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out545;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out542, out _out543, out _out544, out _out545);
                  _981_recursiveGen = _out542;
                  _982_recOwned = _out543;
                  _983_recErased = _out544;
                  _984_recIdents = _out545;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _981_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _982_recOwned;
                  isErased = _983_recErased;
                  readIdents = _984_recIdents;
                }
              } else if (_source39.is_Arrow) {
                Dafny.ISequence<DAST._IType> _985___mcc_h530 = _source39.dtor_args;
                DAST._IType _986___mcc_h531 = _source39.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _987_recursiveGen;
                  bool _988_recOwned;
                  bool _989_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _990_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out546;
                  bool _out547;
                  bool _out548;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out549;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out546, out _out547, out _out548, out _out549);
                  _987_recursiveGen = _out546;
                  _988_recOwned = _out547;
                  _989_recErased = _out548;
                  _990_recIdents = _out549;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _987_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _988_recOwned;
                  isErased = _989_recErased;
                  readIdents = _990_recIdents;
                }
              } else if (_source39.is_Primitive) {
                DAST._IPrimitive _991___mcc_h534 = _source39.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _992_recursiveGen;
                  bool _993_recOwned;
                  bool _994_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _995_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out550;
                  bool _out551;
                  bool _out552;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out553;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out550, out _out551, out _out552, out _out553);
                  _992_recursiveGen = _out550;
                  _993_recOwned = _out551;
                  _994_recErased = _out552;
                  _995_recIdents = _out553;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _992_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _993_recOwned;
                  isErased = _994_recErased;
                  readIdents = _995_recIdents;
                }
              } else if (_source39.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _996___mcc_h536 = _source39.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _997_recursiveGen;
                  bool _998_recOwned;
                  bool _999_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1000_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out554;
                  bool _out555;
                  bool _out556;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out557;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out554, out _out555, out _out556, out _out557);
                  _997_recursiveGen = _out554;
                  _998_recOwned = _out555;
                  _999_recErased = _out556;
                  _1000_recIdents = _out557;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _997_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _998_recOwned;
                  isErased = _999_recErased;
                  readIdents = _1000_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1001___mcc_h538 = _source39.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1002_recursiveGen;
                  bool _1003_recOwned;
                  bool _1004_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1005_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out558;
                  bool _out559;
                  bool _out560;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out561;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out558, out _out559, out _out560, out _out561);
                  _1002_recursiveGen = _out558;
                  _1003_recOwned = _out559;
                  _1004_recErased = _out560;
                  _1005_recIdents = _out561;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1002_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1003_recOwned;
                  isErased = _1004_recErased;
                  readIdents = _1005_recIdents;
                }
              }
            } else if (_source27.is_Seq) {
              DAST._IType _1006___mcc_h540 = _source27.dtor_element;
              DAST._IType _source41 = _507___mcc_h235;
              if (_source41.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1007___mcc_h544 = _source41.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1008___mcc_h545 = _source41.dtor_typeArgs;
                DAST._IResolvedType _1009___mcc_h546 = _source41.dtor_resolved;
                DAST._IResolvedType _source42 = _1009___mcc_h546;
                if (_source42.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1010___mcc_h550 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1011_recursiveGen;
                    bool _1012_recOwned;
                    bool _1013_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1014_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out562;
                    bool _out563;
                    bool _out564;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out565;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out562, out _out563, out _out564, out _out565);
                    _1011_recursiveGen = _out562;
                    _1012_recOwned = _out563;
                    _1013_recErased = _out564;
                    _1014_recIdents = _out565;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1011_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1012_recOwned;
                    isErased = _1013_recErased;
                    readIdents = _1014_recIdents;
                  }
                } else if (_source42.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1015___mcc_h552 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1016_recursiveGen;
                    bool _1017_recOwned;
                    bool _1018_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1019_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out566;
                    bool _out567;
                    bool _out568;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out569;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out566, out _out567, out _out568, out _out569);
                    _1016_recursiveGen = _out566;
                    _1017_recOwned = _out567;
                    _1018_recErased = _out568;
                    _1019_recIdents = _out569;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1016_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1017_recOwned;
                    isErased = _1018_recErased;
                    readIdents = _1019_recIdents;
                  }
                } else {
                  DAST._IType _1020___mcc_h554 = _source42.dtor_Newtype_a0;
                  DAST._IType _1021_b = _1020___mcc_h554;
                  {
                    if (object.Equals(_500_fromTpe, _1021_b)) {
                      Dafny.ISequence<Dafny.Rune> _1022_recursiveGen;
                      bool _1023_recOwned;
                      bool _1024_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1025_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out570;
                      bool _out571;
                      bool _out572;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out573;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out570, out _out571, out _out572, out _out573);
                      _1022_recursiveGen = _out570;
                      _1023_recOwned = _out571;
                      _1024_recErased = _out572;
                      _1025_recIdents = _out573;
                      Dafny.ISequence<Dafny.Rune> _1026_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out574;
                      _out574 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _1026_rhsType = _out574;
                      Dafny.ISequence<Dafny.Rune> _1027_uneraseFn;
                      _1027_uneraseFn = ((_1023_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1026_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1027_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1022_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1023_recOwned;
                      isErased = false;
                      readIdents = _1025_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out575;
                      bool _out576;
                      bool _out577;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out578;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1021_b), _1021_b, _499_toTpe), selfIdent, @params, mustOwn, out _out575, out _out576, out _out577, out _out578);
                      s = _out575;
                      isOwned = _out576;
                      isErased = _out577;
                      readIdents = _out578;
                    }
                  }
                }
              } else if (_source41.is_Nullable) {
                DAST._IType _1028___mcc_h556 = _source41.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1029_recursiveGen;
                  bool _1030_recOwned;
                  bool _1031_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1032_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out579;
                  bool _out580;
                  bool _out581;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out582;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out579, out _out580, out _out581, out _out582);
                  _1029_recursiveGen = _out579;
                  _1030_recOwned = _out580;
                  _1031_recErased = _out581;
                  _1032_recIdents = _out582;
                  if (!(_1030_recOwned)) {
                    _1029_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1029_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1029_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1031_recErased;
                  readIdents = _1032_recIdents;
                }
              } else if (_source41.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1033___mcc_h558 = _source41.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1034_recursiveGen;
                  bool _1035_recOwned;
                  bool _1036_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1037_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out583;
                  bool _out584;
                  bool _out585;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out586;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out583, out _out584, out _out585, out _out586);
                  _1034_recursiveGen = _out583;
                  _1035_recOwned = _out584;
                  _1036_recErased = _out585;
                  _1037_recIdents = _out586;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1034_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1035_recOwned;
                  isErased = _1036_recErased;
                  readIdents = _1037_recIdents;
                }
              } else if (_source41.is_Array) {
                DAST._IType _1038___mcc_h560 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1039_recursiveGen;
                  bool _1040_recOwned;
                  bool _1041_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1042_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out587;
                  bool _out588;
                  bool _out589;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out590;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out587, out _out588, out _out589, out _out590);
                  _1039_recursiveGen = _out587;
                  _1040_recOwned = _out588;
                  _1041_recErased = _out589;
                  _1042_recIdents = _out590;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1039_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1040_recOwned;
                  isErased = _1041_recErased;
                  readIdents = _1042_recIdents;
                }
              } else if (_source41.is_Seq) {
                DAST._IType _1043___mcc_h562 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1044_recursiveGen;
                  bool _1045_recOwned;
                  bool _1046_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1047_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out591;
                  bool _out592;
                  bool _out593;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out594;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out591, out _out592, out _out593, out _out594);
                  _1044_recursiveGen = _out591;
                  _1045_recOwned = _out592;
                  _1046_recErased = _out593;
                  _1047_recIdents = _out594;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1044_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1045_recOwned;
                  isErased = _1046_recErased;
                  readIdents = _1047_recIdents;
                }
              } else if (_source41.is_Set) {
                DAST._IType _1048___mcc_h564 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1049_recursiveGen;
                  bool _1050_recOwned;
                  bool _1051_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1052_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out595;
                  bool _out596;
                  bool _out597;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out598;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out595, out _out596, out _out597, out _out598);
                  _1049_recursiveGen = _out595;
                  _1050_recOwned = _out596;
                  _1051_recErased = _out597;
                  _1052_recIdents = _out598;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1049_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1050_recOwned;
                  isErased = _1051_recErased;
                  readIdents = _1052_recIdents;
                }
              } else if (_source41.is_Multiset) {
                DAST._IType _1053___mcc_h566 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1054_recursiveGen;
                  bool _1055_recOwned;
                  bool _1056_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1057_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out599;
                  bool _out600;
                  bool _out601;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out602;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out599, out _out600, out _out601, out _out602);
                  _1054_recursiveGen = _out599;
                  _1055_recOwned = _out600;
                  _1056_recErased = _out601;
                  _1057_recIdents = _out602;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1054_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1055_recOwned;
                  isErased = _1056_recErased;
                  readIdents = _1057_recIdents;
                }
              } else if (_source41.is_Map) {
                DAST._IType _1058___mcc_h568 = _source41.dtor_key;
                DAST._IType _1059___mcc_h569 = _source41.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1060_recursiveGen;
                  bool _1061_recOwned;
                  bool _1062_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1063_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out603;
                  bool _out604;
                  bool _out605;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out606;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out603, out _out604, out _out605, out _out606);
                  _1060_recursiveGen = _out603;
                  _1061_recOwned = _out604;
                  _1062_recErased = _out605;
                  _1063_recIdents = _out606;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1060_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1061_recOwned;
                  isErased = _1062_recErased;
                  readIdents = _1063_recIdents;
                }
              } else if (_source41.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1064___mcc_h572 = _source41.dtor_args;
                DAST._IType _1065___mcc_h573 = _source41.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1066_recursiveGen;
                  bool _1067_recOwned;
                  bool _1068_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1069_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out607;
                  bool _out608;
                  bool _out609;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out610;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out607, out _out608, out _out609, out _out610);
                  _1066_recursiveGen = _out607;
                  _1067_recOwned = _out608;
                  _1068_recErased = _out609;
                  _1069_recIdents = _out610;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1066_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1067_recOwned;
                  isErased = _1068_recErased;
                  readIdents = _1069_recIdents;
                }
              } else if (_source41.is_Primitive) {
                DAST._IPrimitive _1070___mcc_h576 = _source41.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1071_recursiveGen;
                  bool _1072_recOwned;
                  bool _1073_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1074_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out611;
                  bool _out612;
                  bool _out613;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out614;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out611, out _out612, out _out613, out _out614);
                  _1071_recursiveGen = _out611;
                  _1072_recOwned = _out612;
                  _1073_recErased = _out613;
                  _1074_recIdents = _out614;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1071_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1072_recOwned;
                  isErased = _1073_recErased;
                  readIdents = _1074_recIdents;
                }
              } else if (_source41.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1075___mcc_h578 = _source41.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1076_recursiveGen;
                  bool _1077_recOwned;
                  bool _1078_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1079_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out615;
                  bool _out616;
                  bool _out617;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out618;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out615, out _out616, out _out617, out _out618);
                  _1076_recursiveGen = _out615;
                  _1077_recOwned = _out616;
                  _1078_recErased = _out617;
                  _1079_recIdents = _out618;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1076_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1077_recOwned;
                  isErased = _1078_recErased;
                  readIdents = _1079_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1080___mcc_h580 = _source41.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1081_recursiveGen;
                  bool _1082_recOwned;
                  bool _1083_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1084_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out619;
                  bool _out620;
                  bool _out621;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out622;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out619, out _out620, out _out621, out _out622);
                  _1081_recursiveGen = _out619;
                  _1082_recOwned = _out620;
                  _1083_recErased = _out621;
                  _1084_recIdents = _out622;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1081_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1082_recOwned;
                  isErased = _1083_recErased;
                  readIdents = _1084_recIdents;
                }
              }
            } else if (_source27.is_Set) {
              DAST._IType _1085___mcc_h582 = _source27.dtor_element;
              DAST._IType _source43 = _507___mcc_h235;
              if (_source43.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1086___mcc_h586 = _source43.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1087___mcc_h587 = _source43.dtor_typeArgs;
                DAST._IResolvedType _1088___mcc_h588 = _source43.dtor_resolved;
                DAST._IResolvedType _source44 = _1088___mcc_h588;
                if (_source44.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1089___mcc_h592 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1090_recursiveGen;
                    bool _1091_recOwned;
                    bool _1092_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1093_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out623;
                    bool _out624;
                    bool _out625;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out626;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out623, out _out624, out _out625, out _out626);
                    _1090_recursiveGen = _out623;
                    _1091_recOwned = _out624;
                    _1092_recErased = _out625;
                    _1093_recIdents = _out626;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1090_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1091_recOwned;
                    isErased = _1092_recErased;
                    readIdents = _1093_recIdents;
                  }
                } else if (_source44.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1094___mcc_h594 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1095_recursiveGen;
                    bool _1096_recOwned;
                    bool _1097_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1098_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out627;
                    bool _out628;
                    bool _out629;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out630;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out627, out _out628, out _out629, out _out630);
                    _1095_recursiveGen = _out627;
                    _1096_recOwned = _out628;
                    _1097_recErased = _out629;
                    _1098_recIdents = _out630;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1095_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1096_recOwned;
                    isErased = _1097_recErased;
                    readIdents = _1098_recIdents;
                  }
                } else {
                  DAST._IType _1099___mcc_h596 = _source44.dtor_Newtype_a0;
                  DAST._IType _1100_b = _1099___mcc_h596;
                  {
                    if (object.Equals(_500_fromTpe, _1100_b)) {
                      Dafny.ISequence<Dafny.Rune> _1101_recursiveGen;
                      bool _1102_recOwned;
                      bool _1103_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1104_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out631;
                      bool _out632;
                      bool _out633;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out634;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out631, out _out632, out _out633, out _out634);
                      _1101_recursiveGen = _out631;
                      _1102_recOwned = _out632;
                      _1103_recErased = _out633;
                      _1104_recIdents = _out634;
                      Dafny.ISequence<Dafny.Rune> _1105_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out635;
                      _out635 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _1105_rhsType = _out635;
                      Dafny.ISequence<Dafny.Rune> _1106_uneraseFn;
                      _1106_uneraseFn = ((_1102_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1105_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1106_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1101_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1102_recOwned;
                      isErased = false;
                      readIdents = _1104_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out636;
                      bool _out637;
                      bool _out638;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out639;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1100_b), _1100_b, _499_toTpe), selfIdent, @params, mustOwn, out _out636, out _out637, out _out638, out _out639);
                      s = _out636;
                      isOwned = _out637;
                      isErased = _out638;
                      readIdents = _out639;
                    }
                  }
                }
              } else if (_source43.is_Nullable) {
                DAST._IType _1107___mcc_h598 = _source43.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1108_recursiveGen;
                  bool _1109_recOwned;
                  bool _1110_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1111_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out640;
                  bool _out641;
                  bool _out642;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out643;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out640, out _out641, out _out642, out _out643);
                  _1108_recursiveGen = _out640;
                  _1109_recOwned = _out641;
                  _1110_recErased = _out642;
                  _1111_recIdents = _out643;
                  if (!(_1109_recOwned)) {
                    _1108_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1108_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1108_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1110_recErased;
                  readIdents = _1111_recIdents;
                }
              } else if (_source43.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1112___mcc_h600 = _source43.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1113_recursiveGen;
                  bool _1114_recOwned;
                  bool _1115_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1116_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out644;
                  bool _out645;
                  bool _out646;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out647;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out644, out _out645, out _out646, out _out647);
                  _1113_recursiveGen = _out644;
                  _1114_recOwned = _out645;
                  _1115_recErased = _out646;
                  _1116_recIdents = _out647;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1113_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1114_recOwned;
                  isErased = _1115_recErased;
                  readIdents = _1116_recIdents;
                }
              } else if (_source43.is_Array) {
                DAST._IType _1117___mcc_h602 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1118_recursiveGen;
                  bool _1119_recOwned;
                  bool _1120_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1121_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out648;
                  bool _out649;
                  bool _out650;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out651;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out648, out _out649, out _out650, out _out651);
                  _1118_recursiveGen = _out648;
                  _1119_recOwned = _out649;
                  _1120_recErased = _out650;
                  _1121_recIdents = _out651;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1118_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1119_recOwned;
                  isErased = _1120_recErased;
                  readIdents = _1121_recIdents;
                }
              } else if (_source43.is_Seq) {
                DAST._IType _1122___mcc_h604 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1123_recursiveGen;
                  bool _1124_recOwned;
                  bool _1125_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1126_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out652;
                  bool _out653;
                  bool _out654;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out655;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out652, out _out653, out _out654, out _out655);
                  _1123_recursiveGen = _out652;
                  _1124_recOwned = _out653;
                  _1125_recErased = _out654;
                  _1126_recIdents = _out655;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1123_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1124_recOwned;
                  isErased = _1125_recErased;
                  readIdents = _1126_recIdents;
                }
              } else if (_source43.is_Set) {
                DAST._IType _1127___mcc_h606 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1128_recursiveGen;
                  bool _1129_recOwned;
                  bool _1130_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1131_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out656;
                  bool _out657;
                  bool _out658;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out659;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out656, out _out657, out _out658, out _out659);
                  _1128_recursiveGen = _out656;
                  _1129_recOwned = _out657;
                  _1130_recErased = _out658;
                  _1131_recIdents = _out659;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1128_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1129_recOwned;
                  isErased = _1130_recErased;
                  readIdents = _1131_recIdents;
                }
              } else if (_source43.is_Multiset) {
                DAST._IType _1132___mcc_h608 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1133_recursiveGen;
                  bool _1134_recOwned;
                  bool _1135_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1136_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out660;
                  bool _out661;
                  bool _out662;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out663;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out660, out _out661, out _out662, out _out663);
                  _1133_recursiveGen = _out660;
                  _1134_recOwned = _out661;
                  _1135_recErased = _out662;
                  _1136_recIdents = _out663;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1133_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1134_recOwned;
                  isErased = _1135_recErased;
                  readIdents = _1136_recIdents;
                }
              } else if (_source43.is_Map) {
                DAST._IType _1137___mcc_h610 = _source43.dtor_key;
                DAST._IType _1138___mcc_h611 = _source43.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1139_recursiveGen;
                  bool _1140_recOwned;
                  bool _1141_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1142_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out664;
                  bool _out665;
                  bool _out666;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out667;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out664, out _out665, out _out666, out _out667);
                  _1139_recursiveGen = _out664;
                  _1140_recOwned = _out665;
                  _1141_recErased = _out666;
                  _1142_recIdents = _out667;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1139_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1140_recOwned;
                  isErased = _1141_recErased;
                  readIdents = _1142_recIdents;
                }
              } else if (_source43.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1143___mcc_h614 = _source43.dtor_args;
                DAST._IType _1144___mcc_h615 = _source43.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1145_recursiveGen;
                  bool _1146_recOwned;
                  bool _1147_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1148_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out668;
                  bool _out669;
                  bool _out670;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out671;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out668, out _out669, out _out670, out _out671);
                  _1145_recursiveGen = _out668;
                  _1146_recOwned = _out669;
                  _1147_recErased = _out670;
                  _1148_recIdents = _out671;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1145_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1146_recOwned;
                  isErased = _1147_recErased;
                  readIdents = _1148_recIdents;
                }
              } else if (_source43.is_Primitive) {
                DAST._IPrimitive _1149___mcc_h618 = _source43.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1150_recursiveGen;
                  bool _1151_recOwned;
                  bool _1152_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1153_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out672;
                  bool _out673;
                  bool _out674;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out675;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out672, out _out673, out _out674, out _out675);
                  _1150_recursiveGen = _out672;
                  _1151_recOwned = _out673;
                  _1152_recErased = _out674;
                  _1153_recIdents = _out675;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1150_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1151_recOwned;
                  isErased = _1152_recErased;
                  readIdents = _1153_recIdents;
                }
              } else if (_source43.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1154___mcc_h620 = _source43.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1155_recursiveGen;
                  bool _1156_recOwned;
                  bool _1157_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1158_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out676;
                  bool _out677;
                  bool _out678;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out679;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out676, out _out677, out _out678, out _out679);
                  _1155_recursiveGen = _out676;
                  _1156_recOwned = _out677;
                  _1157_recErased = _out678;
                  _1158_recIdents = _out679;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1155_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1156_recOwned;
                  isErased = _1157_recErased;
                  readIdents = _1158_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1159___mcc_h622 = _source43.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1160_recursiveGen;
                  bool _1161_recOwned;
                  bool _1162_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1163_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out680;
                  bool _out681;
                  bool _out682;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out683;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out680, out _out681, out _out682, out _out683);
                  _1160_recursiveGen = _out680;
                  _1161_recOwned = _out681;
                  _1162_recErased = _out682;
                  _1163_recIdents = _out683;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1160_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1161_recOwned;
                  isErased = _1162_recErased;
                  readIdents = _1163_recIdents;
                }
              }
            } else if (_source27.is_Multiset) {
              DAST._IType _1164___mcc_h624 = _source27.dtor_element;
              DAST._IType _source45 = _507___mcc_h235;
              if (_source45.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1165___mcc_h628 = _source45.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1166___mcc_h629 = _source45.dtor_typeArgs;
                DAST._IResolvedType _1167___mcc_h630 = _source45.dtor_resolved;
                DAST._IResolvedType _source46 = _1167___mcc_h630;
                if (_source46.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1168___mcc_h634 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1169_recursiveGen;
                    bool _1170_recOwned;
                    bool _1171_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1172_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out684;
                    bool _out685;
                    bool _out686;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out687;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out684, out _out685, out _out686, out _out687);
                    _1169_recursiveGen = _out684;
                    _1170_recOwned = _out685;
                    _1171_recErased = _out686;
                    _1172_recIdents = _out687;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1169_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1170_recOwned;
                    isErased = _1171_recErased;
                    readIdents = _1172_recIdents;
                  }
                } else if (_source46.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1173___mcc_h636 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1174_recursiveGen;
                    bool _1175_recOwned;
                    bool _1176_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1177_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out688;
                    bool _out689;
                    bool _out690;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out691;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out688, out _out689, out _out690, out _out691);
                    _1174_recursiveGen = _out688;
                    _1175_recOwned = _out689;
                    _1176_recErased = _out690;
                    _1177_recIdents = _out691;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1174_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1175_recOwned;
                    isErased = _1176_recErased;
                    readIdents = _1177_recIdents;
                  }
                } else {
                  DAST._IType _1178___mcc_h638 = _source46.dtor_Newtype_a0;
                  DAST._IType _1179_b = _1178___mcc_h638;
                  {
                    if (object.Equals(_500_fromTpe, _1179_b)) {
                      Dafny.ISequence<Dafny.Rune> _1180_recursiveGen;
                      bool _1181_recOwned;
                      bool _1182_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1183_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out692;
                      bool _out693;
                      bool _out694;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out695;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out692, out _out693, out _out694, out _out695);
                      _1180_recursiveGen = _out692;
                      _1181_recOwned = _out693;
                      _1182_recErased = _out694;
                      _1183_recIdents = _out695;
                      Dafny.ISequence<Dafny.Rune> _1184_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out696;
                      _out696 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _1184_rhsType = _out696;
                      Dafny.ISequence<Dafny.Rune> _1185_uneraseFn;
                      _1185_uneraseFn = ((_1181_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1184_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1185_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1180_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1181_recOwned;
                      isErased = false;
                      readIdents = _1183_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out697;
                      bool _out698;
                      bool _out699;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out700;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1179_b), _1179_b, _499_toTpe), selfIdent, @params, mustOwn, out _out697, out _out698, out _out699, out _out700);
                      s = _out697;
                      isOwned = _out698;
                      isErased = _out699;
                      readIdents = _out700;
                    }
                  }
                }
              } else if (_source45.is_Nullable) {
                DAST._IType _1186___mcc_h640 = _source45.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1187_recursiveGen;
                  bool _1188_recOwned;
                  bool _1189_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1190_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out701;
                  bool _out702;
                  bool _out703;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out704;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out701, out _out702, out _out703, out _out704);
                  _1187_recursiveGen = _out701;
                  _1188_recOwned = _out702;
                  _1189_recErased = _out703;
                  _1190_recIdents = _out704;
                  if (!(_1188_recOwned)) {
                    _1187_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1187_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1187_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1189_recErased;
                  readIdents = _1190_recIdents;
                }
              } else if (_source45.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1191___mcc_h642 = _source45.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1192_recursiveGen;
                  bool _1193_recOwned;
                  bool _1194_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1195_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out705;
                  bool _out706;
                  bool _out707;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out708;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out705, out _out706, out _out707, out _out708);
                  _1192_recursiveGen = _out705;
                  _1193_recOwned = _out706;
                  _1194_recErased = _out707;
                  _1195_recIdents = _out708;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1192_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1193_recOwned;
                  isErased = _1194_recErased;
                  readIdents = _1195_recIdents;
                }
              } else if (_source45.is_Array) {
                DAST._IType _1196___mcc_h644 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1197_recursiveGen;
                  bool _1198_recOwned;
                  bool _1199_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1200_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out709;
                  bool _out710;
                  bool _out711;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out712;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out709, out _out710, out _out711, out _out712);
                  _1197_recursiveGen = _out709;
                  _1198_recOwned = _out710;
                  _1199_recErased = _out711;
                  _1200_recIdents = _out712;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1197_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1198_recOwned;
                  isErased = _1199_recErased;
                  readIdents = _1200_recIdents;
                }
              } else if (_source45.is_Seq) {
                DAST._IType _1201___mcc_h646 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1202_recursiveGen;
                  bool _1203_recOwned;
                  bool _1204_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1205_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out713;
                  bool _out714;
                  bool _out715;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out716;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out713, out _out714, out _out715, out _out716);
                  _1202_recursiveGen = _out713;
                  _1203_recOwned = _out714;
                  _1204_recErased = _out715;
                  _1205_recIdents = _out716;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1202_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1203_recOwned;
                  isErased = _1204_recErased;
                  readIdents = _1205_recIdents;
                }
              } else if (_source45.is_Set) {
                DAST._IType _1206___mcc_h648 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1207_recursiveGen;
                  bool _1208_recOwned;
                  bool _1209_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1210_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out717;
                  bool _out718;
                  bool _out719;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out720;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out717, out _out718, out _out719, out _out720);
                  _1207_recursiveGen = _out717;
                  _1208_recOwned = _out718;
                  _1209_recErased = _out719;
                  _1210_recIdents = _out720;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1207_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1208_recOwned;
                  isErased = _1209_recErased;
                  readIdents = _1210_recIdents;
                }
              } else if (_source45.is_Multiset) {
                DAST._IType _1211___mcc_h650 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1212_recursiveGen;
                  bool _1213_recOwned;
                  bool _1214_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1215_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out721;
                  bool _out722;
                  bool _out723;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out724;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out721, out _out722, out _out723, out _out724);
                  _1212_recursiveGen = _out721;
                  _1213_recOwned = _out722;
                  _1214_recErased = _out723;
                  _1215_recIdents = _out724;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1212_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1213_recOwned;
                  isErased = _1214_recErased;
                  readIdents = _1215_recIdents;
                }
              } else if (_source45.is_Map) {
                DAST._IType _1216___mcc_h652 = _source45.dtor_key;
                DAST._IType _1217___mcc_h653 = _source45.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1218_recursiveGen;
                  bool _1219_recOwned;
                  bool _1220_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1221_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out725;
                  bool _out726;
                  bool _out727;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out728;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out725, out _out726, out _out727, out _out728);
                  _1218_recursiveGen = _out725;
                  _1219_recOwned = _out726;
                  _1220_recErased = _out727;
                  _1221_recIdents = _out728;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1218_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1219_recOwned;
                  isErased = _1220_recErased;
                  readIdents = _1221_recIdents;
                }
              } else if (_source45.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1222___mcc_h656 = _source45.dtor_args;
                DAST._IType _1223___mcc_h657 = _source45.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1224_recursiveGen;
                  bool _1225_recOwned;
                  bool _1226_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1227_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out729;
                  bool _out730;
                  bool _out731;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out732;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out729, out _out730, out _out731, out _out732);
                  _1224_recursiveGen = _out729;
                  _1225_recOwned = _out730;
                  _1226_recErased = _out731;
                  _1227_recIdents = _out732;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1224_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1225_recOwned;
                  isErased = _1226_recErased;
                  readIdents = _1227_recIdents;
                }
              } else if (_source45.is_Primitive) {
                DAST._IPrimitive _1228___mcc_h660 = _source45.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1229_recursiveGen;
                  bool _1230_recOwned;
                  bool _1231_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1232_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out733;
                  bool _out734;
                  bool _out735;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out736;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out733, out _out734, out _out735, out _out736);
                  _1229_recursiveGen = _out733;
                  _1230_recOwned = _out734;
                  _1231_recErased = _out735;
                  _1232_recIdents = _out736;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1229_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1230_recOwned;
                  isErased = _1231_recErased;
                  readIdents = _1232_recIdents;
                }
              } else if (_source45.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1233___mcc_h662 = _source45.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1234_recursiveGen;
                  bool _1235_recOwned;
                  bool _1236_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1237_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out737;
                  bool _out738;
                  bool _out739;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out740;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out737, out _out738, out _out739, out _out740);
                  _1234_recursiveGen = _out737;
                  _1235_recOwned = _out738;
                  _1236_recErased = _out739;
                  _1237_recIdents = _out740;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1234_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1235_recOwned;
                  isErased = _1236_recErased;
                  readIdents = _1237_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1238___mcc_h664 = _source45.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1239_recursiveGen;
                  bool _1240_recOwned;
                  bool _1241_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1242_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out741;
                  bool _out742;
                  bool _out743;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out744;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out741, out _out742, out _out743, out _out744);
                  _1239_recursiveGen = _out741;
                  _1240_recOwned = _out742;
                  _1241_recErased = _out743;
                  _1242_recIdents = _out744;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1239_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1240_recOwned;
                  isErased = _1241_recErased;
                  readIdents = _1242_recIdents;
                }
              }
            } else if (_source27.is_Map) {
              DAST._IType _1243___mcc_h666 = _source27.dtor_key;
              DAST._IType _1244___mcc_h667 = _source27.dtor_value;
              DAST._IType _source47 = _507___mcc_h235;
              if (_source47.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1245___mcc_h674 = _source47.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1246___mcc_h675 = _source47.dtor_typeArgs;
                DAST._IResolvedType _1247___mcc_h676 = _source47.dtor_resolved;
                DAST._IResolvedType _source48 = _1247___mcc_h676;
                if (_source48.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1248___mcc_h680 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1249_recursiveGen;
                    bool _1250_recOwned;
                    bool _1251_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1252_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out745;
                    bool _out746;
                    bool _out747;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out748;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out745, out _out746, out _out747, out _out748);
                    _1249_recursiveGen = _out745;
                    _1250_recOwned = _out746;
                    _1251_recErased = _out747;
                    _1252_recIdents = _out748;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1249_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1250_recOwned;
                    isErased = _1251_recErased;
                    readIdents = _1252_recIdents;
                  }
                } else if (_source48.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1253___mcc_h682 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1254_recursiveGen;
                    bool _1255_recOwned;
                    bool _1256_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1257_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out749;
                    bool _out750;
                    bool _out751;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out752;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out749, out _out750, out _out751, out _out752);
                    _1254_recursiveGen = _out749;
                    _1255_recOwned = _out750;
                    _1256_recErased = _out751;
                    _1257_recIdents = _out752;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1254_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1255_recOwned;
                    isErased = _1256_recErased;
                    readIdents = _1257_recIdents;
                  }
                } else {
                  DAST._IType _1258___mcc_h684 = _source48.dtor_Newtype_a0;
                  DAST._IType _1259_b = _1258___mcc_h684;
                  {
                    if (object.Equals(_500_fromTpe, _1259_b)) {
                      Dafny.ISequence<Dafny.Rune> _1260_recursiveGen;
                      bool _1261_recOwned;
                      bool _1262_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1263_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out753;
                      bool _out754;
                      bool _out755;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out756;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out753, out _out754, out _out755, out _out756);
                      _1260_recursiveGen = _out753;
                      _1261_recOwned = _out754;
                      _1262_recErased = _out755;
                      _1263_recIdents = _out756;
                      Dafny.ISequence<Dafny.Rune> _1264_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out757;
                      _out757 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _1264_rhsType = _out757;
                      Dafny.ISequence<Dafny.Rune> _1265_uneraseFn;
                      _1265_uneraseFn = ((_1261_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1264_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1265_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1260_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1261_recOwned;
                      isErased = false;
                      readIdents = _1263_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out758;
                      bool _out759;
                      bool _out760;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out761;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1259_b), _1259_b, _499_toTpe), selfIdent, @params, mustOwn, out _out758, out _out759, out _out760, out _out761);
                      s = _out758;
                      isOwned = _out759;
                      isErased = _out760;
                      readIdents = _out761;
                    }
                  }
                }
              } else if (_source47.is_Nullable) {
                DAST._IType _1266___mcc_h686 = _source47.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1267_recursiveGen;
                  bool _1268_recOwned;
                  bool _1269_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1270_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out762;
                  bool _out763;
                  bool _out764;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out765;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out762, out _out763, out _out764, out _out765);
                  _1267_recursiveGen = _out762;
                  _1268_recOwned = _out763;
                  _1269_recErased = _out764;
                  _1270_recIdents = _out765;
                  if (!(_1268_recOwned)) {
                    _1267_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1267_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1267_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1269_recErased;
                  readIdents = _1270_recIdents;
                }
              } else if (_source47.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1271___mcc_h688 = _source47.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1272_recursiveGen;
                  bool _1273_recOwned;
                  bool _1274_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1275_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out766;
                  bool _out767;
                  bool _out768;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out769;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out766, out _out767, out _out768, out _out769);
                  _1272_recursiveGen = _out766;
                  _1273_recOwned = _out767;
                  _1274_recErased = _out768;
                  _1275_recIdents = _out769;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1272_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1273_recOwned;
                  isErased = _1274_recErased;
                  readIdents = _1275_recIdents;
                }
              } else if (_source47.is_Array) {
                DAST._IType _1276___mcc_h690 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1277_recursiveGen;
                  bool _1278_recOwned;
                  bool _1279_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1280_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out770;
                  bool _out771;
                  bool _out772;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out773;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out770, out _out771, out _out772, out _out773);
                  _1277_recursiveGen = _out770;
                  _1278_recOwned = _out771;
                  _1279_recErased = _out772;
                  _1280_recIdents = _out773;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1277_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1278_recOwned;
                  isErased = _1279_recErased;
                  readIdents = _1280_recIdents;
                }
              } else if (_source47.is_Seq) {
                DAST._IType _1281___mcc_h692 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1282_recursiveGen;
                  bool _1283_recOwned;
                  bool _1284_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1285_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out774;
                  bool _out775;
                  bool _out776;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out777;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out774, out _out775, out _out776, out _out777);
                  _1282_recursiveGen = _out774;
                  _1283_recOwned = _out775;
                  _1284_recErased = _out776;
                  _1285_recIdents = _out777;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1282_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1283_recOwned;
                  isErased = _1284_recErased;
                  readIdents = _1285_recIdents;
                }
              } else if (_source47.is_Set) {
                DAST._IType _1286___mcc_h694 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1287_recursiveGen;
                  bool _1288_recOwned;
                  bool _1289_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1290_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out778;
                  bool _out779;
                  bool _out780;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out781;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out778, out _out779, out _out780, out _out781);
                  _1287_recursiveGen = _out778;
                  _1288_recOwned = _out779;
                  _1289_recErased = _out780;
                  _1290_recIdents = _out781;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1287_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1288_recOwned;
                  isErased = _1289_recErased;
                  readIdents = _1290_recIdents;
                }
              } else if (_source47.is_Multiset) {
                DAST._IType _1291___mcc_h696 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1292_recursiveGen;
                  bool _1293_recOwned;
                  bool _1294_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1295_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out782;
                  bool _out783;
                  bool _out784;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out785;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out782, out _out783, out _out784, out _out785);
                  _1292_recursiveGen = _out782;
                  _1293_recOwned = _out783;
                  _1294_recErased = _out784;
                  _1295_recIdents = _out785;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1292_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1293_recOwned;
                  isErased = _1294_recErased;
                  readIdents = _1295_recIdents;
                }
              } else if (_source47.is_Map) {
                DAST._IType _1296___mcc_h698 = _source47.dtor_key;
                DAST._IType _1297___mcc_h699 = _source47.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1298_recursiveGen;
                  bool _1299_recOwned;
                  bool _1300_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1301_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out786;
                  bool _out787;
                  bool _out788;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out789;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out786, out _out787, out _out788, out _out789);
                  _1298_recursiveGen = _out786;
                  _1299_recOwned = _out787;
                  _1300_recErased = _out788;
                  _1301_recIdents = _out789;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1298_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1299_recOwned;
                  isErased = _1300_recErased;
                  readIdents = _1301_recIdents;
                }
              } else if (_source47.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1302___mcc_h702 = _source47.dtor_args;
                DAST._IType _1303___mcc_h703 = _source47.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1304_recursiveGen;
                  bool _1305_recOwned;
                  bool _1306_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1307_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out790;
                  bool _out791;
                  bool _out792;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out793;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out790, out _out791, out _out792, out _out793);
                  _1304_recursiveGen = _out790;
                  _1305_recOwned = _out791;
                  _1306_recErased = _out792;
                  _1307_recIdents = _out793;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1304_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1305_recOwned;
                  isErased = _1306_recErased;
                  readIdents = _1307_recIdents;
                }
              } else if (_source47.is_Primitive) {
                DAST._IPrimitive _1308___mcc_h706 = _source47.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1309_recursiveGen;
                  bool _1310_recOwned;
                  bool _1311_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1312_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out794;
                  bool _out795;
                  bool _out796;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out797;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out794, out _out795, out _out796, out _out797);
                  _1309_recursiveGen = _out794;
                  _1310_recOwned = _out795;
                  _1311_recErased = _out796;
                  _1312_recIdents = _out797;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1309_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1310_recOwned;
                  isErased = _1311_recErased;
                  readIdents = _1312_recIdents;
                }
              } else if (_source47.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1313___mcc_h708 = _source47.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1314_recursiveGen;
                  bool _1315_recOwned;
                  bool _1316_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1317_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out798;
                  bool _out799;
                  bool _out800;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out801;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out798, out _out799, out _out800, out _out801);
                  _1314_recursiveGen = _out798;
                  _1315_recOwned = _out799;
                  _1316_recErased = _out800;
                  _1317_recIdents = _out801;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1314_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1315_recOwned;
                  isErased = _1316_recErased;
                  readIdents = _1317_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1318___mcc_h710 = _source47.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1319_recursiveGen;
                  bool _1320_recOwned;
                  bool _1321_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1322_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out802;
                  bool _out803;
                  bool _out804;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out805;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out802, out _out803, out _out804, out _out805);
                  _1319_recursiveGen = _out802;
                  _1320_recOwned = _out803;
                  _1321_recErased = _out804;
                  _1322_recIdents = _out805;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1319_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1320_recOwned;
                  isErased = _1321_recErased;
                  readIdents = _1322_recIdents;
                }
              }
            } else if (_source27.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1323___mcc_h712 = _source27.dtor_args;
              DAST._IType _1324___mcc_h713 = _source27.dtor_result;
              DAST._IType _source49 = _507___mcc_h235;
              if (_source49.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1325___mcc_h720 = _source49.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1326___mcc_h721 = _source49.dtor_typeArgs;
                DAST._IResolvedType _1327___mcc_h722 = _source49.dtor_resolved;
                DAST._IResolvedType _source50 = _1327___mcc_h722;
                if (_source50.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1328___mcc_h726 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1329_recursiveGen;
                    bool _1330_recOwned;
                    bool _1331_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1332_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out806;
                    bool _out807;
                    bool _out808;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out809;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out806, out _out807, out _out808, out _out809);
                    _1329_recursiveGen = _out806;
                    _1330_recOwned = _out807;
                    _1331_recErased = _out808;
                    _1332_recIdents = _out809;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1329_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1330_recOwned;
                    isErased = _1331_recErased;
                    readIdents = _1332_recIdents;
                  }
                } else if (_source50.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1333___mcc_h728 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1334_recursiveGen;
                    bool _1335_recOwned;
                    bool _1336_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1337_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out810;
                    bool _out811;
                    bool _out812;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out813;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out810, out _out811, out _out812, out _out813);
                    _1334_recursiveGen = _out810;
                    _1335_recOwned = _out811;
                    _1336_recErased = _out812;
                    _1337_recIdents = _out813;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1334_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1335_recOwned;
                    isErased = _1336_recErased;
                    readIdents = _1337_recIdents;
                  }
                } else {
                  DAST._IType _1338___mcc_h730 = _source50.dtor_Newtype_a0;
                  DAST._IType _1339_b = _1338___mcc_h730;
                  {
                    if (object.Equals(_500_fromTpe, _1339_b)) {
                      Dafny.ISequence<Dafny.Rune> _1340_recursiveGen;
                      bool _1341_recOwned;
                      bool _1342_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1343_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out814;
                      bool _out815;
                      bool _out816;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out817;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out814, out _out815, out _out816, out _out817);
                      _1340_recursiveGen = _out814;
                      _1341_recOwned = _out815;
                      _1342_recErased = _out816;
                      _1343_recIdents = _out817;
                      Dafny.ISequence<Dafny.Rune> _1344_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out818;
                      _out818 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _1344_rhsType = _out818;
                      Dafny.ISequence<Dafny.Rune> _1345_uneraseFn;
                      _1345_uneraseFn = ((_1341_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1344_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1345_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1340_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1341_recOwned;
                      isErased = false;
                      readIdents = _1343_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out819;
                      bool _out820;
                      bool _out821;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out822;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1339_b), _1339_b, _499_toTpe), selfIdent, @params, mustOwn, out _out819, out _out820, out _out821, out _out822);
                      s = _out819;
                      isOwned = _out820;
                      isErased = _out821;
                      readIdents = _out822;
                    }
                  }
                }
              } else if (_source49.is_Nullable) {
                DAST._IType _1346___mcc_h732 = _source49.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1347_recursiveGen;
                  bool _1348_recOwned;
                  bool _1349_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1350_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out823;
                  bool _out824;
                  bool _out825;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out826;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out823, out _out824, out _out825, out _out826);
                  _1347_recursiveGen = _out823;
                  _1348_recOwned = _out824;
                  _1349_recErased = _out825;
                  _1350_recIdents = _out826;
                  if (!(_1348_recOwned)) {
                    _1347_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1347_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1347_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1349_recErased;
                  readIdents = _1350_recIdents;
                }
              } else if (_source49.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1351___mcc_h734 = _source49.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1352_recursiveGen;
                  bool _1353_recOwned;
                  bool _1354_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1355_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out827;
                  bool _out828;
                  bool _out829;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out827, out _out828, out _out829, out _out830);
                  _1352_recursiveGen = _out827;
                  _1353_recOwned = _out828;
                  _1354_recErased = _out829;
                  _1355_recIdents = _out830;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1352_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1353_recOwned;
                  isErased = _1354_recErased;
                  readIdents = _1355_recIdents;
                }
              } else if (_source49.is_Array) {
                DAST._IType _1356___mcc_h736 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1357_recursiveGen;
                  bool _1358_recOwned;
                  bool _1359_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1360_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out831;
                  bool _out832;
                  bool _out833;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                  _1357_recursiveGen = _out831;
                  _1358_recOwned = _out832;
                  _1359_recErased = _out833;
                  _1360_recIdents = _out834;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1357_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1358_recOwned;
                  isErased = _1359_recErased;
                  readIdents = _1360_recIdents;
                }
              } else if (_source49.is_Seq) {
                DAST._IType _1361___mcc_h738 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1362_recursiveGen;
                  bool _1363_recOwned;
                  bool _1364_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1365_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out835;
                  bool _out836;
                  bool _out837;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                  _1362_recursiveGen = _out835;
                  _1363_recOwned = _out836;
                  _1364_recErased = _out837;
                  _1365_recIdents = _out838;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1362_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1363_recOwned;
                  isErased = _1364_recErased;
                  readIdents = _1365_recIdents;
                }
              } else if (_source49.is_Set) {
                DAST._IType _1366___mcc_h740 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1367_recursiveGen;
                  bool _1368_recOwned;
                  bool _1369_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1370_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out839;
                  bool _out840;
                  bool _out841;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                  _1367_recursiveGen = _out839;
                  _1368_recOwned = _out840;
                  _1369_recErased = _out841;
                  _1370_recIdents = _out842;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1367_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1368_recOwned;
                  isErased = _1369_recErased;
                  readIdents = _1370_recIdents;
                }
              } else if (_source49.is_Multiset) {
                DAST._IType _1371___mcc_h742 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1372_recursiveGen;
                  bool _1373_recOwned;
                  bool _1374_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1375_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out843;
                  bool _out844;
                  bool _out845;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                  _1372_recursiveGen = _out843;
                  _1373_recOwned = _out844;
                  _1374_recErased = _out845;
                  _1375_recIdents = _out846;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1372_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1373_recOwned;
                  isErased = _1374_recErased;
                  readIdents = _1375_recIdents;
                }
              } else if (_source49.is_Map) {
                DAST._IType _1376___mcc_h744 = _source49.dtor_key;
                DAST._IType _1377___mcc_h745 = _source49.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1378_recursiveGen;
                  bool _1379_recOwned;
                  bool _1380_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1381_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out847;
                  bool _out848;
                  bool _out849;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out850;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out847, out _out848, out _out849, out _out850);
                  _1378_recursiveGen = _out847;
                  _1379_recOwned = _out848;
                  _1380_recErased = _out849;
                  _1381_recIdents = _out850;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1378_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1379_recOwned;
                  isErased = _1380_recErased;
                  readIdents = _1381_recIdents;
                }
              } else if (_source49.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1382___mcc_h748 = _source49.dtor_args;
                DAST._IType _1383___mcc_h749 = _source49.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1384_recursiveGen;
                  bool _1385_recOwned;
                  bool _1386_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1387_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out851;
                  bool _out852;
                  bool _out853;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out854;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out851, out _out852, out _out853, out _out854);
                  _1384_recursiveGen = _out851;
                  _1385_recOwned = _out852;
                  _1386_recErased = _out853;
                  _1387_recIdents = _out854;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1384_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1385_recOwned;
                  isErased = _1386_recErased;
                  readIdents = _1387_recIdents;
                }
              } else if (_source49.is_Primitive) {
                DAST._IPrimitive _1388___mcc_h752 = _source49.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1389_recursiveGen;
                  bool _1390_recOwned;
                  bool _1391_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1392_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out855;
                  bool _out856;
                  bool _out857;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out858;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out855, out _out856, out _out857, out _out858);
                  _1389_recursiveGen = _out855;
                  _1390_recOwned = _out856;
                  _1391_recErased = _out857;
                  _1392_recIdents = _out858;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1389_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1390_recOwned;
                  isErased = _1391_recErased;
                  readIdents = _1392_recIdents;
                }
              } else if (_source49.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1393___mcc_h754 = _source49.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1394_recursiveGen;
                  bool _1395_recOwned;
                  bool _1396_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1397_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out859;
                  bool _out860;
                  bool _out861;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out862;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out859, out _out860, out _out861, out _out862);
                  _1394_recursiveGen = _out859;
                  _1395_recOwned = _out860;
                  _1396_recErased = _out861;
                  _1397_recIdents = _out862;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1394_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1395_recOwned;
                  isErased = _1396_recErased;
                  readIdents = _1397_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1398___mcc_h756 = _source49.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1399_recursiveGen;
                  bool _1400_recOwned;
                  bool _1401_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1402_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out863;
                  bool _out864;
                  bool _out865;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out866;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out863, out _out864, out _out865, out _out866);
                  _1399_recursiveGen = _out863;
                  _1400_recOwned = _out864;
                  _1401_recErased = _out865;
                  _1402_recIdents = _out866;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1399_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1400_recOwned;
                  isErased = _1401_recErased;
                  readIdents = _1402_recIdents;
                }
              }
            } else if (_source27.is_Primitive) {
              DAST._IPrimitive _1403___mcc_h758 = _source27.dtor_Primitive_a0;
              DAST._IPrimitive _source51 = _1403___mcc_h758;
              if (_source51.is_Int) {
                DAST._IType _source52 = _507___mcc_h235;
                if (_source52.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1404___mcc_h762 = _source52.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1405___mcc_h763 = _source52.dtor_typeArgs;
                  DAST._IResolvedType _1406___mcc_h764 = _source52.dtor_resolved;
                  DAST._IResolvedType _source53 = _1406___mcc_h764;
                  if (_source53.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1407___mcc_h768 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1408_recursiveGen;
                      bool _1409_recOwned;
                      bool _1410_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1411_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out867;
                      bool _out868;
                      bool _out869;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out870;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out867, out _out868, out _out869, out _out870);
                      _1408_recursiveGen = _out867;
                      _1409_recOwned = _out868;
                      _1410_recErased = _out869;
                      _1411_recIdents = _out870;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1408_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1409_recOwned;
                      isErased = _1410_recErased;
                      readIdents = _1411_recIdents;
                    }
                  } else if (_source53.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1412___mcc_h770 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1413_recursiveGen;
                      bool _1414_recOwned;
                      bool _1415_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1416_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out871;
                      bool _out872;
                      bool _out873;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out874;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out871, out _out872, out _out873, out _out874);
                      _1413_recursiveGen = _out871;
                      _1414_recOwned = _out872;
                      _1415_recErased = _out873;
                      _1416_recIdents = _out874;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1413_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1414_recOwned;
                      isErased = _1415_recErased;
                      readIdents = _1416_recIdents;
                    }
                  } else {
                    DAST._IType _1417___mcc_h772 = _source53.dtor_Newtype_a0;
                    DAST._IType _1418_b = _1417___mcc_h772;
                    {
                      if (object.Equals(_500_fromTpe, _1418_b)) {
                        Dafny.ISequence<Dafny.Rune> _1419_recursiveGen;
                        bool _1420_recOwned;
                        bool _1421_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1422_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out875;
                        bool _out876;
                        bool _out877;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out878;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out875, out _out876, out _out877, out _out878);
                        _1419_recursiveGen = _out875;
                        _1420_recOwned = _out876;
                        _1421_recErased = _out877;
                        _1422_recIdents = _out878;
                        Dafny.ISequence<Dafny.Rune> _1423_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out879;
                        _out879 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                        _1423_rhsType = _out879;
                        Dafny.ISequence<Dafny.Rune> _1424_uneraseFn;
                        _1424_uneraseFn = ((_1420_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1423_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1424_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1419_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1420_recOwned;
                        isErased = false;
                        readIdents = _1422_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out880;
                        bool _out881;
                        bool _out882;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1418_b), _1418_b, _499_toTpe), selfIdent, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                        s = _out880;
                        isOwned = _out881;
                        isErased = _out882;
                        readIdents = _out883;
                      }
                    }
                  }
                } else if (_source52.is_Nullable) {
                  DAST._IType _1425___mcc_h774 = _source52.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1426_recursiveGen;
                    bool _1427_recOwned;
                    bool _1428_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1429_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out884;
                    bool _out885;
                    bool _out886;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                    _1426_recursiveGen = _out884;
                    _1427_recOwned = _out885;
                    _1428_recErased = _out886;
                    _1429_recIdents = _out887;
                    if (!(_1427_recOwned)) {
                      _1426_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1426_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1426_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1428_recErased;
                    readIdents = _1429_recIdents;
                  }
                } else if (_source52.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1430___mcc_h776 = _source52.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1431_recursiveGen;
                    bool _1432_recOwned;
                    bool _1433_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1434_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out888;
                    bool _out889;
                    bool _out890;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                    _1431_recursiveGen = _out888;
                    _1432_recOwned = _out889;
                    _1433_recErased = _out890;
                    _1434_recIdents = _out891;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1431_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1432_recOwned;
                    isErased = _1433_recErased;
                    readIdents = _1434_recIdents;
                  }
                } else if (_source52.is_Array) {
                  DAST._IType _1435___mcc_h778 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1436_recursiveGen;
                    bool _1437_recOwned;
                    bool _1438_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1439_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out892;
                    bool _out893;
                    bool _out894;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                    _1436_recursiveGen = _out892;
                    _1437_recOwned = _out893;
                    _1438_recErased = _out894;
                    _1439_recIdents = _out895;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1436_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1437_recOwned;
                    isErased = _1438_recErased;
                    readIdents = _1439_recIdents;
                  }
                } else if (_source52.is_Seq) {
                  DAST._IType _1440___mcc_h780 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1441_recursiveGen;
                    bool _1442_recOwned;
                    bool _1443_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1444_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out896;
                    bool _out897;
                    bool _out898;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                    _1441_recursiveGen = _out896;
                    _1442_recOwned = _out897;
                    _1443_recErased = _out898;
                    _1444_recIdents = _out899;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1441_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1442_recOwned;
                    isErased = _1443_recErased;
                    readIdents = _1444_recIdents;
                  }
                } else if (_source52.is_Set) {
                  DAST._IType _1445___mcc_h782 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1446_recursiveGen;
                    bool _1447_recOwned;
                    bool _1448_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1449_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1446_recursiveGen = _out900;
                    _1447_recOwned = _out901;
                    _1448_recErased = _out902;
                    _1449_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1446_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1447_recOwned;
                    isErased = _1448_recErased;
                    readIdents = _1449_recIdents;
                  }
                } else if (_source52.is_Multiset) {
                  DAST._IType _1450___mcc_h784 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1451_recursiveGen;
                    bool _1452_recOwned;
                    bool _1453_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1454_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1451_recursiveGen = _out904;
                    _1452_recOwned = _out905;
                    _1453_recErased = _out906;
                    _1454_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1451_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1452_recOwned;
                    isErased = _1453_recErased;
                    readIdents = _1454_recIdents;
                  }
                } else if (_source52.is_Map) {
                  DAST._IType _1455___mcc_h786 = _source52.dtor_key;
                  DAST._IType _1456___mcc_h787 = _source52.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1457_recursiveGen;
                    bool _1458_recOwned;
                    bool _1459_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1460_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out908;
                    bool _out909;
                    bool _out910;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                    _1457_recursiveGen = _out908;
                    _1458_recOwned = _out909;
                    _1459_recErased = _out910;
                    _1460_recIdents = _out911;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1457_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1458_recOwned;
                    isErased = _1459_recErased;
                    readIdents = _1460_recIdents;
                  }
                } else if (_source52.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1461___mcc_h790 = _source52.dtor_args;
                  DAST._IType _1462___mcc_h791 = _source52.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1463_recursiveGen;
                    bool _1464_recOwned;
                    bool _1465_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1466_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out912;
                    bool _out913;
                    bool _out914;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out912, out _out913, out _out914, out _out915);
                    _1463_recursiveGen = _out912;
                    _1464_recOwned = _out913;
                    _1465_recErased = _out914;
                    _1466_recIdents = _out915;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1463_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1464_recOwned;
                    isErased = _1465_recErased;
                    readIdents = _1466_recIdents;
                  }
                } else if (_source52.is_Primitive) {
                  DAST._IPrimitive _1467___mcc_h794 = _source52.dtor_Primitive_a0;
                  DAST._IPrimitive _source54 = _1467___mcc_h794;
                  if (_source54.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1468_recursiveGen;
                      bool _1469_recOwned;
                      bool _1470_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1471_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out916;
                      bool _out917;
                      bool _out918;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                      _1468_recursiveGen = _out916;
                      _1469_recOwned = _out917;
                      _1470_recErased = _out918;
                      _1471_recIdents = _out919;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1468_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1469_recOwned;
                      isErased = _1470_recErased;
                      readIdents = _1471_recIdents;
                    }
                  } else if (_source54.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1472_recursiveGen;
                      bool _1473___v44;
                      bool _1474___v45;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1475_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out920;
                      bool _out921;
                      bool _out922;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, true, out _out920, out _out921, out _out922, out _out923);
                      _1472_recursiveGen = _out920;
                      _1473___v44 = _out921;
                      _1474___v45 = _out922;
                      _1475_recIdents = _out923;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1472_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1475_recIdents;
                    }
                  } else if (_source54.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1476_recursiveGen;
                      bool _1477_recOwned;
                      bool _1478_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1479_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out924;
                      bool _out925;
                      bool _out926;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out927;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out924, out _out925, out _out926, out _out927);
                      _1476_recursiveGen = _out924;
                      _1477_recOwned = _out925;
                      _1478_recErased = _out926;
                      _1479_recIdents = _out927;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1476_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1477_recOwned;
                      isErased = _1478_recErased;
                      readIdents = _1479_recIdents;
                    }
                  } else if (_source54.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1480_recursiveGen;
                      bool _1481_recOwned;
                      bool _1482_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1483_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out928;
                      bool _out929;
                      bool _out930;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out931;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out928, out _out929, out _out930, out _out931);
                      _1480_recursiveGen = _out928;
                      _1481_recOwned = _out929;
                      _1482_recErased = _out930;
                      _1483_recIdents = _out931;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1480_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1481_recOwned;
                      isErased = _1482_recErased;
                      readIdents = _1483_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1484_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out932;
                      _out932 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _1484_rhsType = _out932;
                      Dafny.ISequence<Dafny.Rune> _1485_recursiveGen;
                      bool _1486___v54;
                      bool _1487___v55;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1488_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out933;
                      bool _out934;
                      bool _out935;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, true, out _out933, out _out934, out _out935, out _out936);
                      _1485_recursiveGen = _out933;
                      _1486___v54 = _out934;
                      _1487___v55 = _out935;
                      _1488_recIdents = _out936;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1485_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1488_recIdents;
                    }
                  }
                } else if (_source52.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1489___mcc_h796 = _source52.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1490_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out937;
                    _out937 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                    _1490_rhsType = _out937;
                    Dafny.ISequence<Dafny.Rune> _1491_recursiveGen;
                    bool _1492___v49;
                    bool _1493___v50;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1494_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out938;
                    bool _out939;
                    bool _out940;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out941;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, true, out _out938, out _out939, out _out940, out _out941);
                    _1491_recursiveGen = _out938;
                    _1492___v49 = _out939;
                    _1493___v50 = _out940;
                    _1494_recIdents = _out941;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1490_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1491_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1494_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1495___mcc_h798 = _source52.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1496_recursiveGen;
                    bool _1497_recOwned;
                    bool _1498_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1499_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out942;
                    bool _out943;
                    bool _out944;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out945;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out942, out _out943, out _out944, out _out945);
                    _1496_recursiveGen = _out942;
                    _1497_recOwned = _out943;
                    _1498_recErased = _out944;
                    _1499_recIdents = _out945;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1496_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1497_recOwned;
                    isErased = _1498_recErased;
                    readIdents = _1499_recIdents;
                  }
                }
              } else if (_source51.is_Real) {
                DAST._IType _source55 = _507___mcc_h235;
                if (_source55.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1500___mcc_h800 = _source55.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1501___mcc_h801 = _source55.dtor_typeArgs;
                  DAST._IResolvedType _1502___mcc_h802 = _source55.dtor_resolved;
                  DAST._IResolvedType _source56 = _1502___mcc_h802;
                  if (_source56.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1503___mcc_h806 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1504_recursiveGen;
                      bool _1505_recOwned;
                      bool _1506_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1507_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out946;
                      bool _out947;
                      bool _out948;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out949;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out946, out _out947, out _out948, out _out949);
                      _1504_recursiveGen = _out946;
                      _1505_recOwned = _out947;
                      _1506_recErased = _out948;
                      _1507_recIdents = _out949;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1504_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1505_recOwned;
                      isErased = _1506_recErased;
                      readIdents = _1507_recIdents;
                    }
                  } else if (_source56.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1508___mcc_h808 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1509_recursiveGen;
                      bool _1510_recOwned;
                      bool _1511_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1512_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out950;
                      bool _out951;
                      bool _out952;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out953;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out950, out _out951, out _out952, out _out953);
                      _1509_recursiveGen = _out950;
                      _1510_recOwned = _out951;
                      _1511_recErased = _out952;
                      _1512_recIdents = _out953;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1509_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1510_recOwned;
                      isErased = _1511_recErased;
                      readIdents = _1512_recIdents;
                    }
                  } else {
                    DAST._IType _1513___mcc_h810 = _source56.dtor_Newtype_a0;
                    DAST._IType _1514_b = _1513___mcc_h810;
                    {
                      if (object.Equals(_500_fromTpe, _1514_b)) {
                        Dafny.ISequence<Dafny.Rune> _1515_recursiveGen;
                        bool _1516_recOwned;
                        bool _1517_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1518_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out954;
                        bool _out955;
                        bool _out956;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out957;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out954, out _out955, out _out956, out _out957);
                        _1515_recursiveGen = _out954;
                        _1516_recOwned = _out955;
                        _1517_recErased = _out956;
                        _1518_recIdents = _out957;
                        Dafny.ISequence<Dafny.Rune> _1519_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out958;
                        _out958 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                        _1519_rhsType = _out958;
                        Dafny.ISequence<Dafny.Rune> _1520_uneraseFn;
                        _1520_uneraseFn = ((_1516_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1519_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1520_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1515_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1516_recOwned;
                        isErased = false;
                        readIdents = _1518_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out959;
                        bool _out960;
                        bool _out961;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out962;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1514_b), _1514_b, _499_toTpe), selfIdent, @params, mustOwn, out _out959, out _out960, out _out961, out _out962);
                        s = _out959;
                        isOwned = _out960;
                        isErased = _out961;
                        readIdents = _out962;
                      }
                    }
                  }
                } else if (_source55.is_Nullable) {
                  DAST._IType _1521___mcc_h812 = _source55.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1522_recursiveGen;
                    bool _1523_recOwned;
                    bool _1524_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1525_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out963;
                    bool _out964;
                    bool _out965;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out966;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out963, out _out964, out _out965, out _out966);
                    _1522_recursiveGen = _out963;
                    _1523_recOwned = _out964;
                    _1524_recErased = _out965;
                    _1525_recIdents = _out966;
                    if (!(_1523_recOwned)) {
                      _1522_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1522_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1522_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1524_recErased;
                    readIdents = _1525_recIdents;
                  }
                } else if (_source55.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1526___mcc_h814 = _source55.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1527_recursiveGen;
                    bool _1528_recOwned;
                    bool _1529_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1530_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out967;
                    bool _out968;
                    bool _out969;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out970;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out967, out _out968, out _out969, out _out970);
                    _1527_recursiveGen = _out967;
                    _1528_recOwned = _out968;
                    _1529_recErased = _out969;
                    _1530_recIdents = _out970;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1527_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1528_recOwned;
                    isErased = _1529_recErased;
                    readIdents = _1530_recIdents;
                  }
                } else if (_source55.is_Array) {
                  DAST._IType _1531___mcc_h816 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1532_recursiveGen;
                    bool _1533_recOwned;
                    bool _1534_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1535_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out971;
                    bool _out972;
                    bool _out973;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out974;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out971, out _out972, out _out973, out _out974);
                    _1532_recursiveGen = _out971;
                    _1533_recOwned = _out972;
                    _1534_recErased = _out973;
                    _1535_recIdents = _out974;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1532_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1533_recOwned;
                    isErased = _1534_recErased;
                    readIdents = _1535_recIdents;
                  }
                } else if (_source55.is_Seq) {
                  DAST._IType _1536___mcc_h818 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1537_recursiveGen;
                    bool _1538_recOwned;
                    bool _1539_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1540_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out975;
                    bool _out976;
                    bool _out977;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out978;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out975, out _out976, out _out977, out _out978);
                    _1537_recursiveGen = _out975;
                    _1538_recOwned = _out976;
                    _1539_recErased = _out977;
                    _1540_recIdents = _out978;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1537_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1538_recOwned;
                    isErased = _1539_recErased;
                    readIdents = _1540_recIdents;
                  }
                } else if (_source55.is_Set) {
                  DAST._IType _1541___mcc_h820 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1542_recursiveGen;
                    bool _1543_recOwned;
                    bool _1544_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1545_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out979;
                    bool _out980;
                    bool _out981;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out982;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out979, out _out980, out _out981, out _out982);
                    _1542_recursiveGen = _out979;
                    _1543_recOwned = _out980;
                    _1544_recErased = _out981;
                    _1545_recIdents = _out982;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1542_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1543_recOwned;
                    isErased = _1544_recErased;
                    readIdents = _1545_recIdents;
                  }
                } else if (_source55.is_Multiset) {
                  DAST._IType _1546___mcc_h822 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1547_recursiveGen;
                    bool _1548_recOwned;
                    bool _1549_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1550_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out983;
                    bool _out984;
                    bool _out985;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out986;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out983, out _out984, out _out985, out _out986);
                    _1547_recursiveGen = _out983;
                    _1548_recOwned = _out984;
                    _1549_recErased = _out985;
                    _1550_recIdents = _out986;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1547_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1548_recOwned;
                    isErased = _1549_recErased;
                    readIdents = _1550_recIdents;
                  }
                } else if (_source55.is_Map) {
                  DAST._IType _1551___mcc_h824 = _source55.dtor_key;
                  DAST._IType _1552___mcc_h825 = _source55.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1553_recursiveGen;
                    bool _1554_recOwned;
                    bool _1555_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1556_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out987;
                    bool _out988;
                    bool _out989;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out990;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out987, out _out988, out _out989, out _out990);
                    _1553_recursiveGen = _out987;
                    _1554_recOwned = _out988;
                    _1555_recErased = _out989;
                    _1556_recIdents = _out990;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1553_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1554_recOwned;
                    isErased = _1555_recErased;
                    readIdents = _1556_recIdents;
                  }
                } else if (_source55.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1557___mcc_h828 = _source55.dtor_args;
                  DAST._IType _1558___mcc_h829 = _source55.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1559_recursiveGen;
                    bool _1560_recOwned;
                    bool _1561_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1562_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out991;
                    bool _out992;
                    bool _out993;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out994;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out991, out _out992, out _out993, out _out994);
                    _1559_recursiveGen = _out991;
                    _1560_recOwned = _out992;
                    _1561_recErased = _out993;
                    _1562_recIdents = _out994;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1559_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1560_recOwned;
                    isErased = _1561_recErased;
                    readIdents = _1562_recIdents;
                  }
                } else if (_source55.is_Primitive) {
                  DAST._IPrimitive _1563___mcc_h832 = _source55.dtor_Primitive_a0;
                  DAST._IPrimitive _source57 = _1563___mcc_h832;
                  if (_source57.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1564_recursiveGen;
                      bool _1565___v46;
                      bool _1566___v47;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1567_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out995;
                      bool _out996;
                      bool _out997;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out998;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, false, out _out995, out _out996, out _out997, out _out998);
                      _1564_recursiveGen = _out995;
                      _1565___v46 = _out996;
                      _1566___v47 = _out997;
                      _1567_recIdents = _out998;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1564_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1567_recIdents;
                    }
                  } else if (_source57.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1568_recursiveGen;
                      bool _1569_recOwned;
                      bool _1570_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1571_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out999;
                      bool _out1000;
                      bool _out1001;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1002;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out999, out _out1000, out _out1001, out _out1002);
                      _1568_recursiveGen = _out999;
                      _1569_recOwned = _out1000;
                      _1570_recErased = _out1001;
                      _1571_recIdents = _out1002;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1568_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1569_recOwned;
                      isErased = _1570_recErased;
                      readIdents = _1571_recIdents;
                    }
                  } else if (_source57.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1572_recursiveGen;
                      bool _1573_recOwned;
                      bool _1574_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1575_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1003;
                      bool _out1004;
                      bool _out1005;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1006;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1003, out _out1004, out _out1005, out _out1006);
                      _1572_recursiveGen = _out1003;
                      _1573_recOwned = _out1004;
                      _1574_recErased = _out1005;
                      _1575_recIdents = _out1006;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1572_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1573_recOwned;
                      isErased = _1574_recErased;
                      readIdents = _1575_recIdents;
                    }
                  } else if (_source57.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1576_recursiveGen;
                      bool _1577_recOwned;
                      bool _1578_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1579_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1007;
                      bool _out1008;
                      bool _out1009;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1010;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1007, out _out1008, out _out1009, out _out1010);
                      _1576_recursiveGen = _out1007;
                      _1577_recOwned = _out1008;
                      _1578_recErased = _out1009;
                      _1579_recIdents = _out1010;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1576_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1577_recOwned;
                      isErased = _1578_recErased;
                      readIdents = _1579_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1580_recursiveGen;
                      bool _1581_recOwned;
                      bool _1582_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1583_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1011;
                      bool _out1012;
                      bool _out1013;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1014;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1011, out _out1012, out _out1013, out _out1014);
                      _1580_recursiveGen = _out1011;
                      _1581_recOwned = _out1012;
                      _1582_recErased = _out1013;
                      _1583_recIdents = _out1014;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1580_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1581_recOwned;
                      isErased = _1582_recErased;
                      readIdents = _1583_recIdents;
                    }
                  }
                } else if (_source55.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1584___mcc_h834 = _source55.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1585_recursiveGen;
                    bool _1586_recOwned;
                    bool _1587_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1588_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1015;
                    bool _out1016;
                    bool _out1017;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1018;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1015, out _out1016, out _out1017, out _out1018);
                    _1585_recursiveGen = _out1015;
                    _1586_recOwned = _out1016;
                    _1587_recErased = _out1017;
                    _1588_recIdents = _out1018;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1585_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1586_recOwned;
                    isErased = _1587_recErased;
                    readIdents = _1588_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1589___mcc_h836 = _source55.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1590_recursiveGen;
                    bool _1591_recOwned;
                    bool _1592_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1593_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1019;
                    bool _out1020;
                    bool _out1021;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1022;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1019, out _out1020, out _out1021, out _out1022);
                    _1590_recursiveGen = _out1019;
                    _1591_recOwned = _out1020;
                    _1592_recErased = _out1021;
                    _1593_recIdents = _out1022;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1590_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1591_recOwned;
                    isErased = _1592_recErased;
                    readIdents = _1593_recIdents;
                  }
                }
              } else if (_source51.is_String) {
                DAST._IType _source58 = _507___mcc_h235;
                if (_source58.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1594___mcc_h838 = _source58.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1595___mcc_h839 = _source58.dtor_typeArgs;
                  DAST._IResolvedType _1596___mcc_h840 = _source58.dtor_resolved;
                  DAST._IResolvedType _source59 = _1596___mcc_h840;
                  if (_source59.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1597___mcc_h844 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1598_recursiveGen;
                      bool _1599_recOwned;
                      bool _1600_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1601_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1023;
                      bool _out1024;
                      bool _out1025;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1026;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1023, out _out1024, out _out1025, out _out1026);
                      _1598_recursiveGen = _out1023;
                      _1599_recOwned = _out1024;
                      _1600_recErased = _out1025;
                      _1601_recIdents = _out1026;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1598_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1599_recOwned;
                      isErased = _1600_recErased;
                      readIdents = _1601_recIdents;
                    }
                  } else if (_source59.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1602___mcc_h846 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1603_recursiveGen;
                      bool _1604_recOwned;
                      bool _1605_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1606_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1027;
                      bool _out1028;
                      bool _out1029;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1030;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1027, out _out1028, out _out1029, out _out1030);
                      _1603_recursiveGen = _out1027;
                      _1604_recOwned = _out1028;
                      _1605_recErased = _out1029;
                      _1606_recIdents = _out1030;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1603_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1604_recOwned;
                      isErased = _1605_recErased;
                      readIdents = _1606_recIdents;
                    }
                  } else {
                    DAST._IType _1607___mcc_h848 = _source59.dtor_Newtype_a0;
                    DAST._IType _1608_b = _1607___mcc_h848;
                    {
                      if (object.Equals(_500_fromTpe, _1608_b)) {
                        Dafny.ISequence<Dafny.Rune> _1609_recursiveGen;
                        bool _1610_recOwned;
                        bool _1611_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1612_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1031;
                        bool _out1032;
                        bool _out1033;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1034;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1031, out _out1032, out _out1033, out _out1034);
                        _1609_recursiveGen = _out1031;
                        _1610_recOwned = _out1032;
                        _1611_recErased = _out1033;
                        _1612_recIdents = _out1034;
                        Dafny.ISequence<Dafny.Rune> _1613_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1035;
                        _out1035 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                        _1613_rhsType = _out1035;
                        Dafny.ISequence<Dafny.Rune> _1614_uneraseFn;
                        _1614_uneraseFn = ((_1610_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1613_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1614_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1610_recOwned;
                        isErased = false;
                        readIdents = _1612_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1036;
                        bool _out1037;
                        bool _out1038;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1039;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1608_b), _1608_b, _499_toTpe), selfIdent, @params, mustOwn, out _out1036, out _out1037, out _out1038, out _out1039);
                        s = _out1036;
                        isOwned = _out1037;
                        isErased = _out1038;
                        readIdents = _out1039;
                      }
                    }
                  }
                } else if (_source58.is_Nullable) {
                  DAST._IType _1615___mcc_h850 = _source58.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1616_recursiveGen;
                    bool _1617_recOwned;
                    bool _1618_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1619_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1040;
                    bool _out1041;
                    bool _out1042;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1043;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1040, out _out1041, out _out1042, out _out1043);
                    _1616_recursiveGen = _out1040;
                    _1617_recOwned = _out1041;
                    _1618_recErased = _out1042;
                    _1619_recIdents = _out1043;
                    if (!(_1617_recOwned)) {
                      _1616_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1616_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1616_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1618_recErased;
                    readIdents = _1619_recIdents;
                  }
                } else if (_source58.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1620___mcc_h852 = _source58.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1621_recursiveGen;
                    bool _1622_recOwned;
                    bool _1623_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1624_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1044;
                    bool _out1045;
                    bool _out1046;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1047;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1044, out _out1045, out _out1046, out _out1047);
                    _1621_recursiveGen = _out1044;
                    _1622_recOwned = _out1045;
                    _1623_recErased = _out1046;
                    _1624_recIdents = _out1047;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1621_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1622_recOwned;
                    isErased = _1623_recErased;
                    readIdents = _1624_recIdents;
                  }
                } else if (_source58.is_Array) {
                  DAST._IType _1625___mcc_h854 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1626_recursiveGen;
                    bool _1627_recOwned;
                    bool _1628_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1629_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1048;
                    bool _out1049;
                    bool _out1050;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1051;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1048, out _out1049, out _out1050, out _out1051);
                    _1626_recursiveGen = _out1048;
                    _1627_recOwned = _out1049;
                    _1628_recErased = _out1050;
                    _1629_recIdents = _out1051;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1626_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1627_recOwned;
                    isErased = _1628_recErased;
                    readIdents = _1629_recIdents;
                  }
                } else if (_source58.is_Seq) {
                  DAST._IType _1630___mcc_h856 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1631_recursiveGen;
                    bool _1632_recOwned;
                    bool _1633_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1634_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1052;
                    bool _out1053;
                    bool _out1054;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1055;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1052, out _out1053, out _out1054, out _out1055);
                    _1631_recursiveGen = _out1052;
                    _1632_recOwned = _out1053;
                    _1633_recErased = _out1054;
                    _1634_recIdents = _out1055;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1631_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1632_recOwned;
                    isErased = _1633_recErased;
                    readIdents = _1634_recIdents;
                  }
                } else if (_source58.is_Set) {
                  DAST._IType _1635___mcc_h858 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1636_recursiveGen;
                    bool _1637_recOwned;
                    bool _1638_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1639_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1056;
                    bool _out1057;
                    bool _out1058;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1059;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1056, out _out1057, out _out1058, out _out1059);
                    _1636_recursiveGen = _out1056;
                    _1637_recOwned = _out1057;
                    _1638_recErased = _out1058;
                    _1639_recIdents = _out1059;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1636_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1637_recOwned;
                    isErased = _1638_recErased;
                    readIdents = _1639_recIdents;
                  }
                } else if (_source58.is_Multiset) {
                  DAST._IType _1640___mcc_h860 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1641_recursiveGen;
                    bool _1642_recOwned;
                    bool _1643_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1644_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1060;
                    bool _out1061;
                    bool _out1062;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1063;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1060, out _out1061, out _out1062, out _out1063);
                    _1641_recursiveGen = _out1060;
                    _1642_recOwned = _out1061;
                    _1643_recErased = _out1062;
                    _1644_recIdents = _out1063;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1641_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1642_recOwned;
                    isErased = _1643_recErased;
                    readIdents = _1644_recIdents;
                  }
                } else if (_source58.is_Map) {
                  DAST._IType _1645___mcc_h862 = _source58.dtor_key;
                  DAST._IType _1646___mcc_h863 = _source58.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1647_recursiveGen;
                    bool _1648_recOwned;
                    bool _1649_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1650_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1064;
                    bool _out1065;
                    bool _out1066;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1067;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1064, out _out1065, out _out1066, out _out1067);
                    _1647_recursiveGen = _out1064;
                    _1648_recOwned = _out1065;
                    _1649_recErased = _out1066;
                    _1650_recIdents = _out1067;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1647_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1648_recOwned;
                    isErased = _1649_recErased;
                    readIdents = _1650_recIdents;
                  }
                } else if (_source58.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1651___mcc_h866 = _source58.dtor_args;
                  DAST._IType _1652___mcc_h867 = _source58.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1653_recursiveGen;
                    bool _1654_recOwned;
                    bool _1655_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1656_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1068;
                    bool _out1069;
                    bool _out1070;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1068, out _out1069, out _out1070, out _out1071);
                    _1653_recursiveGen = _out1068;
                    _1654_recOwned = _out1069;
                    _1655_recErased = _out1070;
                    _1656_recIdents = _out1071;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1653_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1654_recOwned;
                    isErased = _1655_recErased;
                    readIdents = _1656_recIdents;
                  }
                } else if (_source58.is_Primitive) {
                  DAST._IPrimitive _1657___mcc_h870 = _source58.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1658_recursiveGen;
                    bool _1659_recOwned;
                    bool _1660_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1661_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1072;
                    bool _out1073;
                    bool _out1074;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                    _1658_recursiveGen = _out1072;
                    _1659_recOwned = _out1073;
                    _1660_recErased = _out1074;
                    _1661_recIdents = _out1075;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1658_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1659_recOwned;
                    isErased = _1660_recErased;
                    readIdents = _1661_recIdents;
                  }
                } else if (_source58.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1662___mcc_h872 = _source58.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1663_recursiveGen;
                    bool _1664_recOwned;
                    bool _1665_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1666_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1076;
                    bool _out1077;
                    bool _out1078;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                    _1663_recursiveGen = _out1076;
                    _1664_recOwned = _out1077;
                    _1665_recErased = _out1078;
                    _1666_recIdents = _out1079;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1663_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1664_recOwned;
                    isErased = _1665_recErased;
                    readIdents = _1666_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1667___mcc_h874 = _source58.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1668_recursiveGen;
                    bool _1669_recOwned;
                    bool _1670_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1671_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1080;
                    bool _out1081;
                    bool _out1082;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                    _1668_recursiveGen = _out1080;
                    _1669_recOwned = _out1081;
                    _1670_recErased = _out1082;
                    _1671_recIdents = _out1083;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1668_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1669_recOwned;
                    isErased = _1670_recErased;
                    readIdents = _1671_recIdents;
                  }
                }
              } else if (_source51.is_Bool) {
                DAST._IType _source60 = _507___mcc_h235;
                if (_source60.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1672___mcc_h876 = _source60.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1673___mcc_h877 = _source60.dtor_typeArgs;
                  DAST._IResolvedType _1674___mcc_h878 = _source60.dtor_resolved;
                  DAST._IResolvedType _source61 = _1674___mcc_h878;
                  if (_source61.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1675___mcc_h882 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1676_recursiveGen;
                      bool _1677_recOwned;
                      bool _1678_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1679_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1084;
                      bool _out1085;
                      bool _out1086;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                      _1676_recursiveGen = _out1084;
                      _1677_recOwned = _out1085;
                      _1678_recErased = _out1086;
                      _1679_recIdents = _out1087;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1676_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1677_recOwned;
                      isErased = _1678_recErased;
                      readIdents = _1679_recIdents;
                    }
                  } else if (_source61.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1680___mcc_h884 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1681_recursiveGen;
                      bool _1682_recOwned;
                      bool _1683_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1684_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1088;
                      bool _out1089;
                      bool _out1090;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1091;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1088, out _out1089, out _out1090, out _out1091);
                      _1681_recursiveGen = _out1088;
                      _1682_recOwned = _out1089;
                      _1683_recErased = _out1090;
                      _1684_recIdents = _out1091;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1681_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1682_recOwned;
                      isErased = _1683_recErased;
                      readIdents = _1684_recIdents;
                    }
                  } else {
                    DAST._IType _1685___mcc_h886 = _source61.dtor_Newtype_a0;
                    DAST._IType _1686_b = _1685___mcc_h886;
                    {
                      if (object.Equals(_500_fromTpe, _1686_b)) {
                        Dafny.ISequence<Dafny.Rune> _1687_recursiveGen;
                        bool _1688_recOwned;
                        bool _1689_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1690_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1092;
                        bool _out1093;
                        bool _out1094;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1095;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1092, out _out1093, out _out1094, out _out1095);
                        _1687_recursiveGen = _out1092;
                        _1688_recOwned = _out1093;
                        _1689_recErased = _out1094;
                        _1690_recIdents = _out1095;
                        Dafny.ISequence<Dafny.Rune> _1691_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1096;
                        _out1096 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                        _1691_rhsType = _out1096;
                        Dafny.ISequence<Dafny.Rune> _1692_uneraseFn;
                        _1692_uneraseFn = ((_1688_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1691_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1692_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1687_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1688_recOwned;
                        isErased = false;
                        readIdents = _1690_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1097;
                        bool _out1098;
                        bool _out1099;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1100;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1686_b), _1686_b, _499_toTpe), selfIdent, @params, mustOwn, out _out1097, out _out1098, out _out1099, out _out1100);
                        s = _out1097;
                        isOwned = _out1098;
                        isErased = _out1099;
                        readIdents = _out1100;
                      }
                    }
                  }
                } else if (_source60.is_Nullable) {
                  DAST._IType _1693___mcc_h888 = _source60.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1694_recursiveGen;
                    bool _1695_recOwned;
                    bool _1696_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1697_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1101;
                    bool _out1102;
                    bool _out1103;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1104;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1101, out _out1102, out _out1103, out _out1104);
                    _1694_recursiveGen = _out1101;
                    _1695_recOwned = _out1102;
                    _1696_recErased = _out1103;
                    _1697_recIdents = _out1104;
                    if (!(_1695_recOwned)) {
                      _1694_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1694_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1694_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1696_recErased;
                    readIdents = _1697_recIdents;
                  }
                } else if (_source60.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1698___mcc_h890 = _source60.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1699_recursiveGen;
                    bool _1700_recOwned;
                    bool _1701_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1702_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1105;
                    bool _out1106;
                    bool _out1107;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1108;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1105, out _out1106, out _out1107, out _out1108);
                    _1699_recursiveGen = _out1105;
                    _1700_recOwned = _out1106;
                    _1701_recErased = _out1107;
                    _1702_recIdents = _out1108;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1699_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1700_recOwned;
                    isErased = _1701_recErased;
                    readIdents = _1702_recIdents;
                  }
                } else if (_source60.is_Array) {
                  DAST._IType _1703___mcc_h892 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1704_recursiveGen;
                    bool _1705_recOwned;
                    bool _1706_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1707_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1109;
                    bool _out1110;
                    bool _out1111;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                    _1704_recursiveGen = _out1109;
                    _1705_recOwned = _out1110;
                    _1706_recErased = _out1111;
                    _1707_recIdents = _out1112;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1704_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1705_recOwned;
                    isErased = _1706_recErased;
                    readIdents = _1707_recIdents;
                  }
                } else if (_source60.is_Seq) {
                  DAST._IType _1708___mcc_h894 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1709_recursiveGen;
                    bool _1710_recOwned;
                    bool _1711_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1712_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1113;
                    bool _out1114;
                    bool _out1115;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                    _1709_recursiveGen = _out1113;
                    _1710_recOwned = _out1114;
                    _1711_recErased = _out1115;
                    _1712_recIdents = _out1116;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1709_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1710_recOwned;
                    isErased = _1711_recErased;
                    readIdents = _1712_recIdents;
                  }
                } else if (_source60.is_Set) {
                  DAST._IType _1713___mcc_h896 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1714_recursiveGen;
                    bool _1715_recOwned;
                    bool _1716_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1717_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1117;
                    bool _out1118;
                    bool _out1119;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                    _1714_recursiveGen = _out1117;
                    _1715_recOwned = _out1118;
                    _1716_recErased = _out1119;
                    _1717_recIdents = _out1120;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1714_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1715_recOwned;
                    isErased = _1716_recErased;
                    readIdents = _1717_recIdents;
                  }
                } else if (_source60.is_Multiset) {
                  DAST._IType _1718___mcc_h898 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1719_recursiveGen;
                    bool _1720_recOwned;
                    bool _1721_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1722_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1121;
                    bool _out1122;
                    bool _out1123;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                    _1719_recursiveGen = _out1121;
                    _1720_recOwned = _out1122;
                    _1721_recErased = _out1123;
                    _1722_recIdents = _out1124;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1719_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1720_recOwned;
                    isErased = _1721_recErased;
                    readIdents = _1722_recIdents;
                  }
                } else if (_source60.is_Map) {
                  DAST._IType _1723___mcc_h900 = _source60.dtor_key;
                  DAST._IType _1724___mcc_h901 = _source60.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1725_recursiveGen;
                    bool _1726_recOwned;
                    bool _1727_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1728_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1125;
                    bool _out1126;
                    bool _out1127;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                    _1725_recursiveGen = _out1125;
                    _1726_recOwned = _out1126;
                    _1727_recErased = _out1127;
                    _1728_recIdents = _out1128;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1725_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1726_recOwned;
                    isErased = _1727_recErased;
                    readIdents = _1728_recIdents;
                  }
                } else if (_source60.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1729___mcc_h904 = _source60.dtor_args;
                  DAST._IType _1730___mcc_h905 = _source60.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1731_recursiveGen;
                    bool _1732_recOwned;
                    bool _1733_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1734_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1129;
                    bool _out1130;
                    bool _out1131;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                    _1731_recursiveGen = _out1129;
                    _1732_recOwned = _out1130;
                    _1733_recErased = _out1131;
                    _1734_recIdents = _out1132;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1731_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1732_recOwned;
                    isErased = _1733_recErased;
                    readIdents = _1734_recIdents;
                  }
                } else if (_source60.is_Primitive) {
                  DAST._IPrimitive _1735___mcc_h908 = _source60.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1736_recursiveGen;
                    bool _1737_recOwned;
                    bool _1738_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1739_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1133;
                    bool _out1134;
                    bool _out1135;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                    _1736_recursiveGen = _out1133;
                    _1737_recOwned = _out1134;
                    _1738_recErased = _out1135;
                    _1739_recIdents = _out1136;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1736_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1737_recOwned;
                    isErased = _1738_recErased;
                    readIdents = _1739_recIdents;
                  }
                } else if (_source60.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1740___mcc_h910 = _source60.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1741_recursiveGen;
                    bool _1742_recOwned;
                    bool _1743_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1744_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1137;
                    bool _out1138;
                    bool _out1139;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                    _1741_recursiveGen = _out1137;
                    _1742_recOwned = _out1138;
                    _1743_recErased = _out1139;
                    _1744_recIdents = _out1140;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1741_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1742_recOwned;
                    isErased = _1743_recErased;
                    readIdents = _1744_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1745___mcc_h912 = _source60.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1746_recursiveGen;
                    bool _1747_recOwned;
                    bool _1748_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1749_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1141;
                    bool _out1142;
                    bool _out1143;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1144;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1141, out _out1142, out _out1143, out _out1144);
                    _1746_recursiveGen = _out1141;
                    _1747_recOwned = _out1142;
                    _1748_recErased = _out1143;
                    _1749_recIdents = _out1144;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1746_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1747_recOwned;
                    isErased = _1748_recErased;
                    readIdents = _1749_recIdents;
                  }
                }
              } else {
                DAST._IType _source62 = _507___mcc_h235;
                if (_source62.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1750___mcc_h914 = _source62.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1751___mcc_h915 = _source62.dtor_typeArgs;
                  DAST._IResolvedType _1752___mcc_h916 = _source62.dtor_resolved;
                  DAST._IResolvedType _source63 = _1752___mcc_h916;
                  if (_source63.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1753___mcc_h920 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1754_recursiveGen;
                      bool _1755_recOwned;
                      bool _1756_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1757_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1145;
                      bool _out1146;
                      bool _out1147;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1148;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1145, out _out1146, out _out1147, out _out1148);
                      _1754_recursiveGen = _out1145;
                      _1755_recOwned = _out1146;
                      _1756_recErased = _out1147;
                      _1757_recIdents = _out1148;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1754_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1755_recOwned;
                      isErased = _1756_recErased;
                      readIdents = _1757_recIdents;
                    }
                  } else if (_source63.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1758___mcc_h922 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1759_recursiveGen;
                      bool _1760_recOwned;
                      bool _1761_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1762_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1149;
                      bool _out1150;
                      bool _out1151;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1152;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1149, out _out1150, out _out1151, out _out1152);
                      _1759_recursiveGen = _out1149;
                      _1760_recOwned = _out1150;
                      _1761_recErased = _out1151;
                      _1762_recIdents = _out1152;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1760_recOwned;
                      isErased = _1761_recErased;
                      readIdents = _1762_recIdents;
                    }
                  } else {
                    DAST._IType _1763___mcc_h924 = _source63.dtor_Newtype_a0;
                    DAST._IType _1764_b = _1763___mcc_h924;
                    {
                      if (object.Equals(_500_fromTpe, _1764_b)) {
                        Dafny.ISequence<Dafny.Rune> _1765_recursiveGen;
                        bool _1766_recOwned;
                        bool _1767_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1768_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1153;
                        bool _out1154;
                        bool _out1155;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1156;
                        DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1153, out _out1154, out _out1155, out _out1156);
                        _1765_recursiveGen = _out1153;
                        _1766_recOwned = _out1154;
                        _1767_recErased = _out1155;
                        _1768_recIdents = _out1156;
                        Dafny.ISequence<Dafny.Rune> _1769_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1157;
                        _out1157 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                        _1769_rhsType = _out1157;
                        Dafny.ISequence<Dafny.Rune> _1770_uneraseFn;
                        _1770_uneraseFn = ((_1766_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1769_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1770_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1765_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1766_recOwned;
                        isErased = false;
                        readIdents = _1768_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1158;
                        bool _out1159;
                        bool _out1160;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1764_b), _1764_b, _499_toTpe), selfIdent, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                        s = _out1158;
                        isOwned = _out1159;
                        isErased = _out1160;
                        readIdents = _out1161;
                      }
                    }
                  }
                } else if (_source62.is_Nullable) {
                  DAST._IType _1771___mcc_h926 = _source62.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1772_recursiveGen;
                    bool _1773_recOwned;
                    bool _1774_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1775_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1162;
                    bool _out1163;
                    bool _out1164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                    _1772_recursiveGen = _out1162;
                    _1773_recOwned = _out1163;
                    _1774_recErased = _out1164;
                    _1775_recIdents = _out1165;
                    if (!(_1773_recOwned)) {
                      _1772_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1772_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1772_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1774_recErased;
                    readIdents = _1775_recIdents;
                  }
                } else if (_source62.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1776___mcc_h928 = _source62.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1777_recursiveGen;
                    bool _1778_recOwned;
                    bool _1779_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1780_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1166;
                    bool _out1167;
                    bool _out1168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1169;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1166, out _out1167, out _out1168, out _out1169);
                    _1777_recursiveGen = _out1166;
                    _1778_recOwned = _out1167;
                    _1779_recErased = _out1168;
                    _1780_recIdents = _out1169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1777_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1778_recOwned;
                    isErased = _1779_recErased;
                    readIdents = _1780_recIdents;
                  }
                } else if (_source62.is_Array) {
                  DAST._IType _1781___mcc_h930 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1782_recursiveGen;
                    bool _1783_recOwned;
                    bool _1784_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1785_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1170;
                    bool _out1171;
                    bool _out1172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1173;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1170, out _out1171, out _out1172, out _out1173);
                    _1782_recursiveGen = _out1170;
                    _1783_recOwned = _out1171;
                    _1784_recErased = _out1172;
                    _1785_recIdents = _out1173;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1782_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1783_recOwned;
                    isErased = _1784_recErased;
                    readIdents = _1785_recIdents;
                  }
                } else if (_source62.is_Seq) {
                  DAST._IType _1786___mcc_h932 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1787_recursiveGen;
                    bool _1788_recOwned;
                    bool _1789_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1790_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1174;
                    bool _out1175;
                    bool _out1176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1177;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1174, out _out1175, out _out1176, out _out1177);
                    _1787_recursiveGen = _out1174;
                    _1788_recOwned = _out1175;
                    _1789_recErased = _out1176;
                    _1790_recIdents = _out1177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1787_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1788_recOwned;
                    isErased = _1789_recErased;
                    readIdents = _1790_recIdents;
                  }
                } else if (_source62.is_Set) {
                  DAST._IType _1791___mcc_h934 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1792_recursiveGen;
                    bool _1793_recOwned;
                    bool _1794_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1795_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1178;
                    bool _out1179;
                    bool _out1180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1181;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1178, out _out1179, out _out1180, out _out1181);
                    _1792_recursiveGen = _out1178;
                    _1793_recOwned = _out1179;
                    _1794_recErased = _out1180;
                    _1795_recIdents = _out1181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1792_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1793_recOwned;
                    isErased = _1794_recErased;
                    readIdents = _1795_recIdents;
                  }
                } else if (_source62.is_Multiset) {
                  DAST._IType _1796___mcc_h936 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1797_recursiveGen;
                    bool _1798_recOwned;
                    bool _1799_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1800_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1182;
                    bool _out1183;
                    bool _out1184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1185;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1182, out _out1183, out _out1184, out _out1185);
                    _1797_recursiveGen = _out1182;
                    _1798_recOwned = _out1183;
                    _1799_recErased = _out1184;
                    _1800_recIdents = _out1185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1797_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1798_recOwned;
                    isErased = _1799_recErased;
                    readIdents = _1800_recIdents;
                  }
                } else if (_source62.is_Map) {
                  DAST._IType _1801___mcc_h938 = _source62.dtor_key;
                  DAST._IType _1802___mcc_h939 = _source62.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1803_recursiveGen;
                    bool _1804_recOwned;
                    bool _1805_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1806_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1186;
                    bool _out1187;
                    bool _out1188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1189;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1186, out _out1187, out _out1188, out _out1189);
                    _1803_recursiveGen = _out1186;
                    _1804_recOwned = _out1187;
                    _1805_recErased = _out1188;
                    _1806_recIdents = _out1189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1803_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1804_recOwned;
                    isErased = _1805_recErased;
                    readIdents = _1806_recIdents;
                  }
                } else if (_source62.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1807___mcc_h942 = _source62.dtor_args;
                  DAST._IType _1808___mcc_h943 = _source62.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1809_recursiveGen;
                    bool _1810_recOwned;
                    bool _1811_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1812_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1190;
                    bool _out1191;
                    bool _out1192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1193;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1190, out _out1191, out _out1192, out _out1193);
                    _1809_recursiveGen = _out1190;
                    _1810_recOwned = _out1191;
                    _1811_recErased = _out1192;
                    _1812_recIdents = _out1193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1809_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1810_recOwned;
                    isErased = _1811_recErased;
                    readIdents = _1812_recIdents;
                  }
                } else if (_source62.is_Primitive) {
                  DAST._IPrimitive _1813___mcc_h946 = _source62.dtor_Primitive_a0;
                  DAST._IPrimitive _source64 = _1813___mcc_h946;
                  if (_source64.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1814_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1194;
                      _out1194 = DCOMP.COMP.GenType(_500_fromTpe, true, false);
                      _1814_rhsType = _out1194;
                      Dafny.ISequence<Dafny.Rune> _1815_recursiveGen;
                      bool _1816___v56;
                      bool _1817___v57;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1818_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1195;
                      bool _out1196;
                      bool _out1197;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1198;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, true, out _out1195, out _out1196, out _out1197, out _out1198);
                      _1815_recursiveGen = _out1195;
                      _1816___v56 = _out1196;
                      _1817___v57 = _out1197;
                      _1818_recIdents = _out1198;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1815_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1818_recIdents;
                    }
                  } else if (_source64.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1819_recursiveGen;
                      bool _1820_recOwned;
                      bool _1821_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1822_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1199;
                      bool _out1200;
                      bool _out1201;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1202;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1199, out _out1200, out _out1201, out _out1202);
                      _1819_recursiveGen = _out1199;
                      _1820_recOwned = _out1200;
                      _1821_recErased = _out1201;
                      _1822_recIdents = _out1202;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1819_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1820_recOwned;
                      isErased = _1821_recErased;
                      readIdents = _1822_recIdents;
                    }
                  } else if (_source64.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1823_recursiveGen;
                      bool _1824_recOwned;
                      bool _1825_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1826_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      bool _out1204;
                      bool _out1205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1206;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1203, out _out1204, out _out1205, out _out1206);
                      _1823_recursiveGen = _out1203;
                      _1824_recOwned = _out1204;
                      _1825_recErased = _out1205;
                      _1826_recIdents = _out1206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1823_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1824_recOwned;
                      isErased = _1825_recErased;
                      readIdents = _1826_recIdents;
                    }
                  } else if (_source64.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1827_recursiveGen;
                      bool _1828_recOwned;
                      bool _1829_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1830_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1207;
                      bool _out1208;
                      bool _out1209;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1210;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1207, out _out1208, out _out1209, out _out1210);
                      _1827_recursiveGen = _out1207;
                      _1828_recOwned = _out1208;
                      _1829_recErased = _out1209;
                      _1830_recIdents = _out1210;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1827_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1828_recOwned;
                      isErased = _1829_recErased;
                      readIdents = _1830_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1831_recursiveGen;
                      bool _1832_recOwned;
                      bool _1833_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1834_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1211;
                      bool _out1212;
                      bool _out1213;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1214;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1211, out _out1212, out _out1213, out _out1214);
                      _1831_recursiveGen = _out1211;
                      _1832_recOwned = _out1212;
                      _1833_recErased = _out1213;
                      _1834_recIdents = _out1214;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1831_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1832_recOwned;
                      isErased = _1833_recErased;
                      readIdents = _1834_recIdents;
                    }
                  }
                } else if (_source62.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1835___mcc_h948 = _source62.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1836_recursiveGen;
                    bool _1837_recOwned;
                    bool _1838_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1839_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1215;
                    bool _out1216;
                    bool _out1217;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1218;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1215, out _out1216, out _out1217, out _out1218);
                    _1836_recursiveGen = _out1215;
                    _1837_recOwned = _out1216;
                    _1838_recErased = _out1217;
                    _1839_recIdents = _out1218;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1836_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1837_recOwned;
                    isErased = _1838_recErased;
                    readIdents = _1839_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1840___mcc_h950 = _source62.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1841_recursiveGen;
                    bool _1842_recOwned;
                    bool _1843_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1844_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1219;
                    bool _out1220;
                    bool _out1221;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1222;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1219, out _out1220, out _out1221, out _out1222);
                    _1841_recursiveGen = _out1219;
                    _1842_recOwned = _out1220;
                    _1843_recErased = _out1221;
                    _1844_recIdents = _out1222;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1841_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1842_recOwned;
                    isErased = _1843_recErased;
                    readIdents = _1844_recIdents;
                  }
                }
              }
            } else if (_source27.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1845___mcc_h952 = _source27.dtor_Passthrough_a0;
              DAST._IType _source65 = _507___mcc_h235;
              if (_source65.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1846___mcc_h956 = _source65.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1847___mcc_h957 = _source65.dtor_typeArgs;
                DAST._IResolvedType _1848___mcc_h958 = _source65.dtor_resolved;
                DAST._IResolvedType _source66 = _1848___mcc_h958;
                if (_source66.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1849___mcc_h962 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1850_recursiveGen;
                    bool _1851_recOwned;
                    bool _1852_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1853_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1223;
                    bool _out1224;
                    bool _out1225;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1226;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1223, out _out1224, out _out1225, out _out1226);
                    _1850_recursiveGen = _out1223;
                    _1851_recOwned = _out1224;
                    _1852_recErased = _out1225;
                    _1853_recIdents = _out1226;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1850_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1851_recOwned;
                    isErased = _1852_recErased;
                    readIdents = _1853_recIdents;
                  }
                } else if (_source66.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1854___mcc_h964 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1855_recursiveGen;
                    bool _1856_recOwned;
                    bool _1857_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1858_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1227;
                    bool _out1228;
                    bool _out1229;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1230;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1227, out _out1228, out _out1229, out _out1230);
                    _1855_recursiveGen = _out1227;
                    _1856_recOwned = _out1228;
                    _1857_recErased = _out1229;
                    _1858_recIdents = _out1230;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1855_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1856_recOwned;
                    isErased = _1857_recErased;
                    readIdents = _1858_recIdents;
                  }
                } else {
                  DAST._IType _1859___mcc_h966 = _source66.dtor_Newtype_a0;
                  DAST._IType _1860_b = _1859___mcc_h966;
                  {
                    if (object.Equals(_500_fromTpe, _1860_b)) {
                      Dafny.ISequence<Dafny.Rune> _1861_recursiveGen;
                      bool _1862_recOwned;
                      bool _1863_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1864_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1231;
                      bool _out1232;
                      bool _out1233;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1234;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1231, out _out1232, out _out1233, out _out1234);
                      _1861_recursiveGen = _out1231;
                      _1862_recOwned = _out1232;
                      _1863_recErased = _out1233;
                      _1864_recIdents = _out1234;
                      Dafny.ISequence<Dafny.Rune> _1865_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1235;
                      _out1235 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _1865_rhsType = _out1235;
                      Dafny.ISequence<Dafny.Rune> _1866_uneraseFn;
                      _1866_uneraseFn = ((_1862_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1865_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1866_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1861_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1862_recOwned;
                      isErased = false;
                      readIdents = _1864_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1236;
                      bool _out1237;
                      bool _out1238;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1860_b), _1860_b, _499_toTpe), selfIdent, @params, mustOwn, out _out1236, out _out1237, out _out1238, out _out1239);
                      s = _out1236;
                      isOwned = _out1237;
                      isErased = _out1238;
                      readIdents = _out1239;
                    }
                  }
                }
              } else if (_source65.is_Nullable) {
                DAST._IType _1867___mcc_h968 = _source65.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1868_recursiveGen;
                  bool _1869_recOwned;
                  bool _1870_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1871_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1240;
                  bool _out1241;
                  bool _out1242;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
                  _1868_recursiveGen = _out1240;
                  _1869_recOwned = _out1241;
                  _1870_recErased = _out1242;
                  _1871_recIdents = _out1243;
                  if (!(_1869_recOwned)) {
                    _1868_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1868_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1868_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1870_recErased;
                  readIdents = _1871_recIdents;
                }
              } else if (_source65.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1872___mcc_h970 = _source65.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1873_recursiveGen;
                  bool _1874_recOwned;
                  bool _1875_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1876_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1244;
                  bool _out1245;
                  bool _out1246;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1244, out _out1245, out _out1246, out _out1247);
                  _1873_recursiveGen = _out1244;
                  _1874_recOwned = _out1245;
                  _1875_recErased = _out1246;
                  _1876_recIdents = _out1247;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1873_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1874_recOwned;
                  isErased = _1875_recErased;
                  readIdents = _1876_recIdents;
                }
              } else if (_source65.is_Array) {
                DAST._IType _1877___mcc_h972 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1878_recursiveGen;
                  bool _1879_recOwned;
                  bool _1880_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1881_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1248;
                  bool _out1249;
                  bool _out1250;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1248, out _out1249, out _out1250, out _out1251);
                  _1878_recursiveGen = _out1248;
                  _1879_recOwned = _out1249;
                  _1880_recErased = _out1250;
                  _1881_recIdents = _out1251;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1878_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1879_recOwned;
                  isErased = _1880_recErased;
                  readIdents = _1881_recIdents;
                }
              } else if (_source65.is_Seq) {
                DAST._IType _1882___mcc_h974 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1883_recursiveGen;
                  bool _1884_recOwned;
                  bool _1885_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1886_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1252;
                  bool _out1253;
                  bool _out1254;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1252, out _out1253, out _out1254, out _out1255);
                  _1883_recursiveGen = _out1252;
                  _1884_recOwned = _out1253;
                  _1885_recErased = _out1254;
                  _1886_recIdents = _out1255;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1883_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1884_recOwned;
                  isErased = _1885_recErased;
                  readIdents = _1886_recIdents;
                }
              } else if (_source65.is_Set) {
                DAST._IType _1887___mcc_h976 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1888_recursiveGen;
                  bool _1889_recOwned;
                  bool _1890_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1891_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1256;
                  bool _out1257;
                  bool _out1258;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1256, out _out1257, out _out1258, out _out1259);
                  _1888_recursiveGen = _out1256;
                  _1889_recOwned = _out1257;
                  _1890_recErased = _out1258;
                  _1891_recIdents = _out1259;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1888_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1889_recOwned;
                  isErased = _1890_recErased;
                  readIdents = _1891_recIdents;
                }
              } else if (_source65.is_Multiset) {
                DAST._IType _1892___mcc_h978 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1893_recursiveGen;
                  bool _1894_recOwned;
                  bool _1895_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1896_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1260;
                  bool _out1261;
                  bool _out1262;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1260, out _out1261, out _out1262, out _out1263);
                  _1893_recursiveGen = _out1260;
                  _1894_recOwned = _out1261;
                  _1895_recErased = _out1262;
                  _1896_recIdents = _out1263;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1893_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1894_recOwned;
                  isErased = _1895_recErased;
                  readIdents = _1896_recIdents;
                }
              } else if (_source65.is_Map) {
                DAST._IType _1897___mcc_h980 = _source65.dtor_key;
                DAST._IType _1898___mcc_h981 = _source65.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1899_recursiveGen;
                  bool _1900_recOwned;
                  bool _1901_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1902_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1264;
                  bool _out1265;
                  bool _out1266;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1267;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1264, out _out1265, out _out1266, out _out1267);
                  _1899_recursiveGen = _out1264;
                  _1900_recOwned = _out1265;
                  _1901_recErased = _out1266;
                  _1902_recIdents = _out1267;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1899_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1900_recOwned;
                  isErased = _1901_recErased;
                  readIdents = _1902_recIdents;
                }
              } else if (_source65.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1903___mcc_h984 = _source65.dtor_args;
                DAST._IType _1904___mcc_h985 = _source65.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1905_recursiveGen;
                  bool _1906_recOwned;
                  bool _1907_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1908_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1268;
                  bool _out1269;
                  bool _out1270;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1271;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1268, out _out1269, out _out1270, out _out1271);
                  _1905_recursiveGen = _out1268;
                  _1906_recOwned = _out1269;
                  _1907_recErased = _out1270;
                  _1908_recIdents = _out1271;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1905_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1906_recOwned;
                  isErased = _1907_recErased;
                  readIdents = _1908_recIdents;
                }
              } else if (_source65.is_Primitive) {
                DAST._IPrimitive _1909___mcc_h988 = _source65.dtor_Primitive_a0;
                DAST._IPrimitive _source67 = _1909___mcc_h988;
                if (_source67.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1910_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1272;
                    _out1272 = DCOMP.COMP.GenType(_500_fromTpe, true, false);
                    _1910_rhsType = _out1272;
                    Dafny.ISequence<Dafny.Rune> _1911_recursiveGen;
                    bool _1912___v52;
                    bool _1913___v53;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1914_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1273;
                    bool _out1274;
                    bool _out1275;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1276;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, true, out _out1273, out _out1274, out _out1275, out _out1276);
                    _1911_recursiveGen = _out1273;
                    _1912___v52 = _out1274;
                    _1913___v53 = _out1275;
                    _1914_recIdents = _out1276;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1911_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1914_recIdents;
                  }
                } else if (_source67.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1915_recursiveGen;
                    bool _1916_recOwned;
                    bool _1917_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1918_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1277;
                    bool _out1278;
                    bool _out1279;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1280;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1277, out _out1278, out _out1279, out _out1280);
                    _1915_recursiveGen = _out1277;
                    _1916_recOwned = _out1278;
                    _1917_recErased = _out1279;
                    _1918_recIdents = _out1280;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1915_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1916_recOwned;
                    isErased = _1917_recErased;
                    readIdents = _1918_recIdents;
                  }
                } else if (_source67.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1919_recursiveGen;
                    bool _1920_recOwned;
                    bool _1921_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1922_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    bool _out1282;
                    bool _out1283;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1284;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1281, out _out1282, out _out1283, out _out1284);
                    _1919_recursiveGen = _out1281;
                    _1920_recOwned = _out1282;
                    _1921_recErased = _out1283;
                    _1922_recIdents = _out1284;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1919_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1920_recOwned;
                    isErased = _1921_recErased;
                    readIdents = _1922_recIdents;
                  }
                } else if (_source67.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1923_recursiveGen;
                    bool _1924_recOwned;
                    bool _1925_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1926_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1285;
                    bool _out1286;
                    bool _out1287;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1288;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1285, out _out1286, out _out1287, out _out1288);
                    _1923_recursiveGen = _out1285;
                    _1924_recOwned = _out1286;
                    _1925_recErased = _out1287;
                    _1926_recIdents = _out1288;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1923_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1924_recOwned;
                    isErased = _1925_recErased;
                    readIdents = _1926_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1927_recursiveGen;
                    bool _1928_recOwned;
                    bool _1929_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1930_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1289;
                    bool _out1290;
                    bool _out1291;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1292;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1289, out _out1290, out _out1291, out _out1292);
                    _1927_recursiveGen = _out1289;
                    _1928_recOwned = _out1290;
                    _1929_recErased = _out1291;
                    _1930_recIdents = _out1292;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1927_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1928_recOwned;
                    isErased = _1929_recErased;
                    readIdents = _1930_recIdents;
                  }
                }
              } else if (_source65.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1931___mcc_h990 = _source65.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1932_recursiveGen;
                  bool _1933___v60;
                  bool _1934___v61;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1935_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1293;
                  bool _out1294;
                  bool _out1295;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1296;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, true, out _out1293, out _out1294, out _out1295, out _out1296);
                  _1932_recursiveGen = _out1293;
                  _1933___v60 = _out1294;
                  _1934___v61 = _out1295;
                  _1935_recIdents = _out1296;
                  Dafny.ISequence<Dafny.Rune> _1936_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1297;
                  _out1297 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                  _1936_toTpeGen = _out1297;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1932_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1936_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1935_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1937___mcc_h992 = _source65.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1938_recursiveGen;
                  bool _1939_recOwned;
                  bool _1940_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1941_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1298;
                  bool _out1299;
                  bool _out1300;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1301;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1298, out _out1299, out _out1300, out _out1301);
                  _1938_recursiveGen = _out1298;
                  _1939_recOwned = _out1299;
                  _1940_recErased = _out1300;
                  _1941_recIdents = _out1301;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1938_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1939_recOwned;
                  isErased = _1940_recErased;
                  readIdents = _1941_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1942___mcc_h994 = _source27.dtor_TypeArg_a0;
              DAST._IType _source68 = _507___mcc_h235;
              if (_source68.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1943___mcc_h998 = _source68.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1944___mcc_h999 = _source68.dtor_typeArgs;
                DAST._IResolvedType _1945___mcc_h1000 = _source68.dtor_resolved;
                DAST._IResolvedType _source69 = _1945___mcc_h1000;
                if (_source69.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1946___mcc_h1004 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1947_recursiveGen;
                    bool _1948_recOwned;
                    bool _1949_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1950_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1302;
                    bool _out1303;
                    bool _out1304;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1302, out _out1303, out _out1304, out _out1305);
                    _1947_recursiveGen = _out1302;
                    _1948_recOwned = _out1303;
                    _1949_recErased = _out1304;
                    _1950_recIdents = _out1305;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1947_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1948_recOwned;
                    isErased = _1949_recErased;
                    readIdents = _1950_recIdents;
                  }
                } else if (_source69.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1951___mcc_h1006 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1952_recursiveGen;
                    bool _1953_recOwned;
                    bool _1954_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1955_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1306;
                    bool _out1307;
                    bool _out1308;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1309;
                    DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1306, out _out1307, out _out1308, out _out1309);
                    _1952_recursiveGen = _out1306;
                    _1953_recOwned = _out1307;
                    _1954_recErased = _out1308;
                    _1955_recIdents = _out1309;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1953_recOwned;
                    isErased = _1954_recErased;
                    readIdents = _1955_recIdents;
                  }
                } else {
                  DAST._IType _1956___mcc_h1008 = _source69.dtor_Newtype_a0;
                  DAST._IType _1957_b = _1956___mcc_h1008;
                  {
                    if (object.Equals(_500_fromTpe, _1957_b)) {
                      Dafny.ISequence<Dafny.Rune> _1958_recursiveGen;
                      bool _1959_recOwned;
                      bool _1960_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1961_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1310;
                      bool _out1311;
                      bool _out1312;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1313;
                      DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1310, out _out1311, out _out1312, out _out1313);
                      _1958_recursiveGen = _out1310;
                      _1959_recOwned = _out1311;
                      _1960_recErased = _out1312;
                      _1961_recIdents = _out1313;
                      Dafny.ISequence<Dafny.Rune> _1962_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1314;
                      _out1314 = DCOMP.COMP.GenType(_499_toTpe, true, false);
                      _1962_rhsType = _out1314;
                      Dafny.ISequence<Dafny.Rune> _1963_uneraseFn;
                      _1963_uneraseFn = ((_1959_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1962_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1963_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1958_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1959_recOwned;
                      isErased = false;
                      readIdents = _1961_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1315;
                      bool _out1316;
                      bool _out1317;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1318;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_501_expr, _500_fromTpe, _1957_b), _1957_b, _499_toTpe), selfIdent, @params, mustOwn, out _out1315, out _out1316, out _out1317, out _out1318);
                      s = _out1315;
                      isOwned = _out1316;
                      isErased = _out1317;
                      readIdents = _out1318;
                    }
                  }
                }
              } else if (_source68.is_Nullable) {
                DAST._IType _1964___mcc_h1010 = _source68.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1965_recursiveGen;
                  bool _1966_recOwned;
                  bool _1967_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1968_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1319;
                  bool _out1320;
                  bool _out1321;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1322;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1319, out _out1320, out _out1321, out _out1322);
                  _1965_recursiveGen = _out1319;
                  _1966_recOwned = _out1320;
                  _1967_recErased = _out1321;
                  _1968_recIdents = _out1322;
                  if (!(_1966_recOwned)) {
                    _1965_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1965_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1965_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1967_recErased;
                  readIdents = _1968_recIdents;
                }
              } else if (_source68.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1969___mcc_h1012 = _source68.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1970_recursiveGen;
                  bool _1971_recOwned;
                  bool _1972_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1973_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1323;
                  bool _out1324;
                  bool _out1325;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1326;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1323, out _out1324, out _out1325, out _out1326);
                  _1970_recursiveGen = _out1323;
                  _1971_recOwned = _out1324;
                  _1972_recErased = _out1325;
                  _1973_recIdents = _out1326;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1970_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1971_recOwned;
                  isErased = _1972_recErased;
                  readIdents = _1973_recIdents;
                }
              } else if (_source68.is_Array) {
                DAST._IType _1974___mcc_h1014 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1975_recursiveGen;
                  bool _1976_recOwned;
                  bool _1977_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1978_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1327;
                  bool _out1328;
                  bool _out1329;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1330;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1327, out _out1328, out _out1329, out _out1330);
                  _1975_recursiveGen = _out1327;
                  _1976_recOwned = _out1328;
                  _1977_recErased = _out1329;
                  _1978_recIdents = _out1330;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1975_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1976_recOwned;
                  isErased = _1977_recErased;
                  readIdents = _1978_recIdents;
                }
              } else if (_source68.is_Seq) {
                DAST._IType _1979___mcc_h1016 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1980_recursiveGen;
                  bool _1981_recOwned;
                  bool _1982_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1983_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1331;
                  bool _out1332;
                  bool _out1333;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1334;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1331, out _out1332, out _out1333, out _out1334);
                  _1980_recursiveGen = _out1331;
                  _1981_recOwned = _out1332;
                  _1982_recErased = _out1333;
                  _1983_recIdents = _out1334;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1980_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1981_recOwned;
                  isErased = _1982_recErased;
                  readIdents = _1983_recIdents;
                }
              } else if (_source68.is_Set) {
                DAST._IType _1984___mcc_h1018 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1985_recursiveGen;
                  bool _1986_recOwned;
                  bool _1987_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1988_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1335;
                  bool _out1336;
                  bool _out1337;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1338;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1335, out _out1336, out _out1337, out _out1338);
                  _1985_recursiveGen = _out1335;
                  _1986_recOwned = _out1336;
                  _1987_recErased = _out1337;
                  _1988_recIdents = _out1338;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1985_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1986_recOwned;
                  isErased = _1987_recErased;
                  readIdents = _1988_recIdents;
                }
              } else if (_source68.is_Multiset) {
                DAST._IType _1989___mcc_h1020 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1990_recursiveGen;
                  bool _1991_recOwned;
                  bool _1992_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1993_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1339;
                  bool _out1340;
                  bool _out1341;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1342;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1339, out _out1340, out _out1341, out _out1342);
                  _1990_recursiveGen = _out1339;
                  _1991_recOwned = _out1340;
                  _1992_recErased = _out1341;
                  _1993_recIdents = _out1342;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1990_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1991_recOwned;
                  isErased = _1992_recErased;
                  readIdents = _1993_recIdents;
                }
              } else if (_source68.is_Map) {
                DAST._IType _1994___mcc_h1022 = _source68.dtor_key;
                DAST._IType _1995___mcc_h1023 = _source68.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1996_recursiveGen;
                  bool _1997_recOwned;
                  bool _1998_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1999_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1343;
                  bool _out1344;
                  bool _out1345;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1346;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1343, out _out1344, out _out1345, out _out1346);
                  _1996_recursiveGen = _out1343;
                  _1997_recOwned = _out1344;
                  _1998_recErased = _out1345;
                  _1999_recIdents = _out1346;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1996_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1997_recOwned;
                  isErased = _1998_recErased;
                  readIdents = _1999_recIdents;
                }
              } else if (_source68.is_Arrow) {
                Dafny.ISequence<DAST._IType> _2000___mcc_h1026 = _source68.dtor_args;
                DAST._IType _2001___mcc_h1027 = _source68.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _2002_recursiveGen;
                  bool _2003_recOwned;
                  bool _2004_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2005_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1347;
                  bool _out1348;
                  bool _out1349;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1350;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1347, out _out1348, out _out1349, out _out1350);
                  _2002_recursiveGen = _out1347;
                  _2003_recOwned = _out1348;
                  _2004_recErased = _out1349;
                  _2005_recIdents = _out1350;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2002_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2003_recOwned;
                  isErased = _2004_recErased;
                  readIdents = _2005_recIdents;
                }
              } else if (_source68.is_Primitive) {
                DAST._IPrimitive _2006___mcc_h1030 = _source68.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2007_recursiveGen;
                  bool _2008_recOwned;
                  bool _2009_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2010_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1351;
                  bool _out1352;
                  bool _out1353;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1354;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1351, out _out1352, out _out1353, out _out1354);
                  _2007_recursiveGen = _out1351;
                  _2008_recOwned = _out1352;
                  _2009_recErased = _out1353;
                  _2010_recIdents = _out1354;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2007_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2008_recOwned;
                  isErased = _2009_recErased;
                  readIdents = _2010_recIdents;
                }
              } else if (_source68.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2011___mcc_h1032 = _source68.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2012_recursiveGen;
                  bool _2013_recOwned;
                  bool _2014_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2015_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1355;
                  bool _out1356;
                  bool _out1357;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1358;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1355, out _out1356, out _out1357, out _out1358);
                  _2012_recursiveGen = _out1355;
                  _2013_recOwned = _out1356;
                  _2014_recErased = _out1357;
                  _2015_recIdents = _out1358;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2012_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2013_recOwned;
                  isErased = _2014_recErased;
                  readIdents = _2015_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2016___mcc_h1034 = _source68.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2017_recursiveGen;
                  bool _2018_recOwned;
                  bool _2019_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2020_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1359;
                  bool _out1360;
                  bool _out1361;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1362;
                  DCOMP.COMP.GenExpr(_501_expr, selfIdent, @params, mustOwn, out _out1359, out _out1360, out _out1361, out _out1362);
                  _2017_recursiveGen = _out1359;
                  _2018_recOwned = _out1360;
                  _2019_recErased = _out1361;
                  _2020_recIdents = _out1362;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2017_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2018_recOwned;
                  isErased = _2019_recErased;
                  readIdents = _2020_recIdents;
                }
              }
            }
          }
        }
      } else if (_source20.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2021___mcc_h22 = _source20.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2022_exprs = _2021___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2023_generatedValues;
          _2023_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2024_i;
          _2024_i = BigInteger.Zero;
          bool _2025_allErased;
          _2025_allErased = true;
          while ((_2024_i) < (new BigInteger((_2022_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2026_recursiveGen;
            bool _2027___v63;
            bool _2028_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2029_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1363;
            bool _out1364;
            bool _out1365;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1366;
            DCOMP.COMP.GenExpr((_2022_exprs).Select(_2024_i), selfIdent, @params, true, out _out1363, out _out1364, out _out1365, out _out1366);
            _2026_recursiveGen = _out1363;
            _2027___v63 = _out1364;
            _2028_isErased = _out1365;
            _2029_recIdents = _out1366;
            _2025_allErased = (_2025_allErased) && (_2028_isErased);
            _2023_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2023_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2026_recursiveGen, _2028_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2029_recIdents);
            _2024_i = (_2024_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2024_i = BigInteger.Zero;
          while ((_2024_i) < (new BigInteger((_2023_generatedValues).Count))) {
            if ((_2024_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2030_gen;
            _2030_gen = ((_2023_generatedValues).Select(_2024_i)).dtor__0;
            if ((((_2023_generatedValues).Select(_2024_i)).dtor__1) && (!(_2025_allErased))) {
              _2030_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2030_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2030_gen);
            _2024_i = (_2024_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2025_allErased;
        }
      } else if (_source20.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2031___mcc_h23 = _source20.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2032_exprs = _2031___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2033_generatedValues;
          _2033_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2034_i;
          _2034_i = BigInteger.Zero;
          bool _2035_allErased;
          _2035_allErased = true;
          while ((_2034_i) < (new BigInteger((_2032_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2036_recursiveGen;
            bool _2037___v64;
            bool _2038_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2039_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1367;
            bool _out1368;
            bool _out1369;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1370;
            DCOMP.COMP.GenExpr((_2032_exprs).Select(_2034_i), selfIdent, @params, true, out _out1367, out _out1368, out _out1369, out _out1370);
            _2036_recursiveGen = _out1367;
            _2037___v64 = _out1368;
            _2038_isErased = _out1369;
            _2039_recIdents = _out1370;
            _2035_allErased = (_2035_allErased) && (_2038_isErased);
            _2033_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2033_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2036_recursiveGen, _2038_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2039_recIdents);
            _2034_i = (_2034_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2034_i = BigInteger.Zero;
          while ((_2034_i) < (new BigInteger((_2033_generatedValues).Count))) {
            if ((_2034_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2040_gen;
            _2040_gen = ((_2033_generatedValues).Select(_2034_i)).dtor__0;
            if ((((_2033_generatedValues).Select(_2034_i)).dtor__1) && (!(_2035_allErased))) {
              _2040_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2040_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2040_gen);
            _2034_i = (_2034_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source70 = selfIdent;
          if (_source70.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2041___mcc_h1036 = _source70.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2042_id = _2041___mcc_h1036;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2042_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2042_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2042_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2042_id);
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
        DAST._IExpression _2043___mcc_h24 = _source20.dtor_cond;
        DAST._IExpression _2044___mcc_h25 = _source20.dtor_thn;
        DAST._IExpression _2045___mcc_h26 = _source20.dtor_els;
        DAST._IExpression _2046_f = _2045___mcc_h26;
        DAST._IExpression _2047_t = _2044___mcc_h25;
        DAST._IExpression _2048_cond = _2043___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _2049_condString;
          bool _2050___v65;
          bool _2051_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2052_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1371;
          bool _out1372;
          bool _out1373;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1374;
          DCOMP.COMP.GenExpr(_2048_cond, selfIdent, @params, true, out _out1371, out _out1372, out _out1373, out _out1374);
          _2049_condString = _out1371;
          _2050___v65 = _out1372;
          _2051_condErased = _out1373;
          _2052_recIdentsCond = _out1374;
          if (!(_2051_condErased)) {
            _2049_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2049_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2053___v66;
          bool _2054_tHasToBeOwned;
          bool _2055___v67;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2056___v68;
          Dafny.ISequence<Dafny.Rune> _out1375;
          bool _out1376;
          bool _out1377;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1378;
          DCOMP.COMP.GenExpr(_2047_t, selfIdent, @params, mustOwn, out _out1375, out _out1376, out _out1377, out _out1378);
          _2053___v66 = _out1375;
          _2054_tHasToBeOwned = _out1376;
          _2055___v67 = _out1377;
          _2056___v68 = _out1378;
          Dafny.ISequence<Dafny.Rune> _2057_fString;
          bool _2058_fOwned;
          bool _2059_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2060_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1379;
          bool _out1380;
          bool _out1381;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1382;
          DCOMP.COMP.GenExpr(_2046_f, selfIdent, @params, _2054_tHasToBeOwned, out _out1379, out _out1380, out _out1381, out _out1382);
          _2057_fString = _out1379;
          _2058_fOwned = _out1380;
          _2059_fErased = _out1381;
          _2060_recIdentsF = _out1382;
          Dafny.ISequence<Dafny.Rune> _2061_tString;
          bool _2062___v69;
          bool _2063_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2064_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1383;
          bool _out1384;
          bool _out1385;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1386;
          DCOMP.COMP.GenExpr(_2047_t, selfIdent, @params, _2058_fOwned, out _out1383, out _out1384, out _out1385, out _out1386);
          _2061_tString = _out1383;
          _2062___v69 = _out1384;
          _2063_tErased = _out1385;
          _2064_recIdentsT = _out1386;
          if ((!(_2059_fErased)) || (!(_2063_tErased))) {
            if (_2059_fErased) {
              _2057_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2057_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2063_tErased) {
              _2061_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2061_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2049_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2061_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2057_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2058_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2052_recIdentsCond, _2064_recIdentsT), _2060_recIdentsF);
          isErased = (_2059_fErased) || (_2063_tErased);
        }
      } else if (_source20.is_UnOp) {
        DAST._IUnaryOp _2065___mcc_h27 = _source20.dtor_unOp;
        DAST._IExpression _2066___mcc_h28 = _source20.dtor_expr;
        DAST._IUnaryOp _source71 = _2065___mcc_h27;
        if (_source71.is_Not) {
          DAST._IExpression _2067_e = _2066___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2068_recursiveGen;
            bool _2069___v70;
            bool _2070_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2071_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1387;
            bool _out1388;
            bool _out1389;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1390;
            DCOMP.COMP.GenExpr(_2067_e, selfIdent, @params, true, out _out1387, out _out1388, out _out1389, out _out1390);
            _2068_recursiveGen = _out1387;
            _2069___v70 = _out1388;
            _2070_recErased = _out1389;
            _2071_recIdents = _out1390;
            if (!(_2070_recErased)) {
              _2068_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2068_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2068_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2071_recIdents;
            isErased = true;
          }
        } else if (_source71.is_BitwiseNot) {
          DAST._IExpression _2072_e = _2066___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2073_recursiveGen;
            bool _2074___v71;
            bool _2075_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2076_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1391;
            bool _out1392;
            bool _out1393;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1394;
            DCOMP.COMP.GenExpr(_2072_e, selfIdent, @params, true, out _out1391, out _out1392, out _out1393, out _out1394);
            _2073_recursiveGen = _out1391;
            _2074___v71 = _out1392;
            _2075_recErased = _out1393;
            _2076_recIdents = _out1394;
            if (!(_2075_recErased)) {
              _2073_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2073_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2073_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2076_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2077_e = _2066___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2078_recursiveGen;
            bool _2079_recOwned;
            bool _2080_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2081_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1395;
            bool _out1396;
            bool _out1397;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1398;
            DCOMP.COMP.GenExpr(_2077_e, selfIdent, @params, false, out _out1395, out _out1396, out _out1397, out _out1398);
            _2078_recursiveGen = _out1395;
            _2079_recOwned = _out1396;
            _2080_recErased = _out1397;
            _2081_recIdents = _out1398;
            if (!(_2080_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2082_eraseFn;
              _2082_eraseFn = ((_2079_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2078_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2082_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2078_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2078_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2081_recIdents;
            isErased = true;
          }
        }
      } else if (_source20.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2083___mcc_h29 = _source20.dtor_op;
        DAST._IExpression _2084___mcc_h30 = _source20.dtor_left;
        DAST._IExpression _2085___mcc_h31 = _source20.dtor_right;
        DAST._IExpression _2086_r = _2085___mcc_h31;
        DAST._IExpression _2087_l = _2084___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _2088_op = _2083___mcc_h29;
        {
          Dafny.ISequence<Dafny.Rune> _2089_left;
          bool _2090___v72;
          bool _2091_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2092_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1399;
          bool _out1400;
          bool _out1401;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1402;
          DCOMP.COMP.GenExpr(_2087_l, selfIdent, @params, true, out _out1399, out _out1400, out _out1401, out _out1402);
          _2089_left = _out1399;
          _2090___v72 = _out1400;
          _2091_leftErased = _out1401;
          _2092_recIdentsL = _out1402;
          Dafny.ISequence<Dafny.Rune> _2093_right;
          bool _2094___v73;
          bool _2095_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2096_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1403;
          bool _out1404;
          bool _out1405;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1406;
          DCOMP.COMP.GenExpr(_2086_r, selfIdent, @params, true, out _out1403, out _out1404, out _out1405, out _out1406);
          _2093_right = _out1403;
          _2094___v73 = _out1404;
          _2095_rightErased = _out1405;
          _2096_recIdentsR = _out1406;
          if (!(_2091_leftErased)) {
            _2089_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2089_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2095_rightErased)) {
            _2093_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2093_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2088_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2089_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2093_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2088_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2089_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2093_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2089_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2088_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2093_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2092_recIdentsL, _2096_recIdentsR);
          isErased = true;
        }
      } else if (_source20.is_Select) {
        DAST._IExpression _2097___mcc_h32 = _source20.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2098___mcc_h33 = _source20.dtor_field;
        bool _2099___mcc_h34 = _source20.dtor_isConstant;
        bool _2100___mcc_h35 = _source20.dtor_onDatatype;
        DAST._IExpression _source72 = _2097___mcc_h32;
        if (_source72.is_Literal) {
          DAST._ILiteral _2101___mcc_h36 = _source72.dtor_Literal_a0;
          bool _2102_isDatatype = _2100___mcc_h35;
          bool _2103_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2104_field = _2098___mcc_h33;
          DAST._IExpression _2105_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2106_onString;
            bool _2107_onOwned;
            bool _2108_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2109_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1407;
            bool _out1408;
            bool _out1409;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1410;
            DCOMP.COMP.GenExpr(_2105_on, selfIdent, @params, false, out _out1407, out _out1408, out _out1409, out _out1410);
            _2106_onString = _out1407;
            _2107_onOwned = _out1408;
            _2108_onErased = _out1409;
            _2109_recIdents = _out1410;
            if (!(_2108_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2110_eraseFn;
              _2110_eraseFn = ((_2107_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2106_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2110_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2106_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2102_isDatatype) || (_2103_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2106_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2104_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2103_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2106_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2104_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2109_recIdents;
          }
        } else if (_source72.is_Ident) {
          Dafny.ISequence<Dafny.Rune> _2111___mcc_h38 = _source72.dtor_Ident_a0;
          bool _2112_isDatatype = _2100___mcc_h35;
          bool _2113_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2114_field = _2098___mcc_h33;
          DAST._IExpression _2115_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2116_onString;
            bool _2117_onOwned;
            bool _2118_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2119_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1411;
            bool _out1412;
            bool _out1413;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1414;
            DCOMP.COMP.GenExpr(_2115_on, selfIdent, @params, false, out _out1411, out _out1412, out _out1413, out _out1414);
            _2116_onString = _out1411;
            _2117_onOwned = _out1412;
            _2118_onErased = _out1413;
            _2119_recIdents = _out1414;
            if (!(_2118_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2120_eraseFn;
              _2120_eraseFn = ((_2117_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2116_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2120_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2116_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2112_isDatatype) || (_2113_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2116_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2114_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2113_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2116_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2114_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2119_recIdents;
          }
        } else if (_source72.is_Companion) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2121___mcc_h40 = _source72.dtor_Companion_a0;
          bool _2122_isDatatype = _2100___mcc_h35;
          bool _2123_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2124_field = _2098___mcc_h33;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2125_c = _2121___mcc_h40;
          {
            Dafny.ISequence<Dafny.Rune> _2126_onString;
            bool _2127_onOwned;
            bool _2128_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2129_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1415;
            bool _out1416;
            bool _out1417;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1418;
            DCOMP.COMP.GenExpr(DAST.Expression.create_Companion(_2125_c), selfIdent, @params, false, out _out1415, out _out1416, out _out1417, out _out1418);
            _2126_onString = _out1415;
            _2127_onOwned = _out1416;
            _2128_onErased = _out1417;
            _2129_recIdents = _out1418;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2126_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2124_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            isOwned = true;
            isErased = false;
            readIdents = _2129_recIdents;
          }
        } else if (_source72.is_Tuple) {
          Dafny.ISequence<DAST._IExpression> _2130___mcc_h42 = _source72.dtor_Tuple_a0;
          bool _2131_isDatatype = _2100___mcc_h35;
          bool _2132_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2133_field = _2098___mcc_h33;
          DAST._IExpression _2134_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2135_onString;
            bool _2136_onOwned;
            bool _2137_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2138_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1419;
            bool _out1420;
            bool _out1421;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1422;
            DCOMP.COMP.GenExpr(_2134_on, selfIdent, @params, false, out _out1419, out _out1420, out _out1421, out _out1422);
            _2135_onString = _out1419;
            _2136_onOwned = _out1420;
            _2137_onErased = _out1421;
            _2138_recIdents = _out1422;
            if (!(_2137_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2139_eraseFn;
              _2139_eraseFn = ((_2136_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2135_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2139_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2135_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2131_isDatatype) || (_2132_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2135_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2133_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2132_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2135_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2133_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2138_recIdents;
          }
        } else if (_source72.is_New) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2140___mcc_h44 = _source72.dtor_path;
          Dafny.ISequence<DAST._IExpression> _2141___mcc_h45 = _source72.dtor_args;
          bool _2142_isDatatype = _2100___mcc_h35;
          bool _2143_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2144_field = _2098___mcc_h33;
          DAST._IExpression _2145_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2146_onString;
            bool _2147_onOwned;
            bool _2148_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2149_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1423;
            bool _out1424;
            bool _out1425;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1426;
            DCOMP.COMP.GenExpr(_2145_on, selfIdent, @params, false, out _out1423, out _out1424, out _out1425, out _out1426);
            _2146_onString = _out1423;
            _2147_onOwned = _out1424;
            _2148_onErased = _out1425;
            _2149_recIdents = _out1426;
            if (!(_2148_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2150_eraseFn;
              _2150_eraseFn = ((_2147_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2146_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2150_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2146_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2142_isDatatype) || (_2143_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2146_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2144_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2143_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2146_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2144_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2149_recIdents;
          }
        } else if (_source72.is_NewArray) {
          Dafny.ISequence<DAST._IExpression> _2151___mcc_h48 = _source72.dtor_dims;
          bool _2152_isDatatype = _2100___mcc_h35;
          bool _2153_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2154_field = _2098___mcc_h33;
          DAST._IExpression _2155_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2156_onString;
            bool _2157_onOwned;
            bool _2158_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2159_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1427;
            bool _out1428;
            bool _out1429;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1430;
            DCOMP.COMP.GenExpr(_2155_on, selfIdent, @params, false, out _out1427, out _out1428, out _out1429, out _out1430);
            _2156_onString = _out1427;
            _2157_onOwned = _out1428;
            _2158_onErased = _out1429;
            _2159_recIdents = _out1430;
            if (!(_2158_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2160_eraseFn;
              _2160_eraseFn = ((_2157_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2156_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2160_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2156_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2152_isDatatype) || (_2153_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2156_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2154_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2153_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2156_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2154_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2159_recIdents;
          }
        } else if (_source72.is_DatatypeValue) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2161___mcc_h50 = _source72.dtor_path;
          Dafny.ISequence<Dafny.Rune> _2162___mcc_h51 = _source72.dtor_variant;
          bool _2163___mcc_h52 = _source72.dtor_isCo;
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2164___mcc_h53 = _source72.dtor_contents;
          bool _2165_isDatatype = _2100___mcc_h35;
          bool _2166_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2167_field = _2098___mcc_h33;
          DAST._IExpression _2168_on = _2097___mcc_h32;
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
        } else if (_source72.is_Convert) {
          DAST._IExpression _2174___mcc_h58 = _source72.dtor_value;
          DAST._IType _2175___mcc_h59 = _source72.dtor_from;
          DAST._IType _2176___mcc_h60 = _source72.dtor_typ;
          bool _2177_isDatatype = _2100___mcc_h35;
          bool _2178_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2179_field = _2098___mcc_h33;
          DAST._IExpression _2180_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2181_onString;
            bool _2182_onOwned;
            bool _2183_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2184_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1435;
            bool _out1436;
            bool _out1437;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1438;
            DCOMP.COMP.GenExpr(_2180_on, selfIdent, @params, false, out _out1435, out _out1436, out _out1437, out _out1438);
            _2181_onString = _out1435;
            _2182_onOwned = _out1436;
            _2183_onErased = _out1437;
            _2184_recIdents = _out1438;
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
        } else if (_source72.is_SeqValue) {
          Dafny.ISequence<DAST._IExpression> _2186___mcc_h64 = _source72.dtor_elements;
          bool _2187_isDatatype = _2100___mcc_h35;
          bool _2188_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2189_field = _2098___mcc_h33;
          DAST._IExpression _2190_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2191_onString;
            bool _2192_onOwned;
            bool _2193_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2194_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1439;
            bool _out1440;
            bool _out1441;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1442;
            DCOMP.COMP.GenExpr(_2190_on, selfIdent, @params, false, out _out1439, out _out1440, out _out1441, out _out1442);
            _2191_onString = _out1439;
            _2192_onOwned = _out1440;
            _2193_onErased = _out1441;
            _2194_recIdents = _out1442;
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
        } else if (_source72.is_SetValue) {
          Dafny.ISequence<DAST._IExpression> _2196___mcc_h66 = _source72.dtor_elements;
          bool _2197_isDatatype = _2100___mcc_h35;
          bool _2198_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2199_field = _2098___mcc_h33;
          DAST._IExpression _2200_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2201_onString;
            bool _2202_onOwned;
            bool _2203_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2204_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1443;
            bool _out1444;
            bool _out1445;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1446;
            DCOMP.COMP.GenExpr(_2200_on, selfIdent, @params, false, out _out1443, out _out1444, out _out1445, out _out1446);
            _2201_onString = _out1443;
            _2202_onOwned = _out1444;
            _2203_onErased = _out1445;
            _2204_recIdents = _out1446;
            if (!(_2203_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2205_eraseFn;
              _2205_eraseFn = ((_2202_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2201_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2205_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2201_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2197_isDatatype) || (_2198_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2201_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2199_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2198_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2201_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2199_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2204_recIdents;
          }
        } else if (_source72.is_This) {
          bool _2206_isDatatype = _2100___mcc_h35;
          bool _2207_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2208_field = _2098___mcc_h33;
          DAST._IExpression _2209_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2210_onString;
            bool _2211_onOwned;
            bool _2212_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2213_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1447;
            bool _out1448;
            bool _out1449;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1450;
            DCOMP.COMP.GenExpr(_2209_on, selfIdent, @params, false, out _out1447, out _out1448, out _out1449, out _out1450);
            _2210_onString = _out1447;
            _2211_onOwned = _out1448;
            _2212_onErased = _out1449;
            _2213_recIdents = _out1450;
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
        } else if (_source72.is_Ite) {
          DAST._IExpression _2215___mcc_h68 = _source72.dtor_cond;
          DAST._IExpression _2216___mcc_h69 = _source72.dtor_thn;
          DAST._IExpression _2217___mcc_h70 = _source72.dtor_els;
          bool _2218_isDatatype = _2100___mcc_h35;
          bool _2219_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2220_field = _2098___mcc_h33;
          DAST._IExpression _2221_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2222_onString;
            bool _2223_onOwned;
            bool _2224_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2225_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1451;
            bool _out1452;
            bool _out1453;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1454;
            DCOMP.COMP.GenExpr(_2221_on, selfIdent, @params, false, out _out1451, out _out1452, out _out1453, out _out1454);
            _2222_onString = _out1451;
            _2223_onOwned = _out1452;
            _2224_onErased = _out1453;
            _2225_recIdents = _out1454;
            if (!(_2224_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2226_eraseFn;
              _2226_eraseFn = ((_2223_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2222_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2226_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2222_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2218_isDatatype) || (_2219_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2222_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2220_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2219_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2222_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2220_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2225_recIdents;
          }
        } else if (_source72.is_UnOp) {
          DAST._IUnaryOp _2227___mcc_h74 = _source72.dtor_unOp;
          DAST._IExpression _2228___mcc_h75 = _source72.dtor_expr;
          bool _2229_isDatatype = _2100___mcc_h35;
          bool _2230_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2231_field = _2098___mcc_h33;
          DAST._IExpression _2232_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2233_onString;
            bool _2234_onOwned;
            bool _2235_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2236_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1455;
            bool _out1456;
            bool _out1457;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1458;
            DCOMP.COMP.GenExpr(_2232_on, selfIdent, @params, false, out _out1455, out _out1456, out _out1457, out _out1458);
            _2233_onString = _out1455;
            _2234_onOwned = _out1456;
            _2235_onErased = _out1457;
            _2236_recIdents = _out1458;
            if (!(_2235_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2237_eraseFn;
              _2237_eraseFn = ((_2234_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2233_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2237_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2233_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2229_isDatatype) || (_2230_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2233_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2231_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2230_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2233_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2231_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2236_recIdents;
          }
        } else if (_source72.is_BinOp) {
          Dafny.ISequence<Dafny.Rune> _2238___mcc_h78 = _source72.dtor_op;
          DAST._IExpression _2239___mcc_h79 = _source72.dtor_left;
          DAST._IExpression _2240___mcc_h80 = _source72.dtor_right;
          bool _2241_isDatatype = _2100___mcc_h35;
          bool _2242_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2243_field = _2098___mcc_h33;
          DAST._IExpression _2244_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2245_onString;
            bool _2246_onOwned;
            bool _2247_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2248_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1459;
            bool _out1460;
            bool _out1461;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1462;
            DCOMP.COMP.GenExpr(_2244_on, selfIdent, @params, false, out _out1459, out _out1460, out _out1461, out _out1462);
            _2245_onString = _out1459;
            _2246_onOwned = _out1460;
            _2247_onErased = _out1461;
            _2248_recIdents = _out1462;
            if (!(_2247_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2249_eraseFn;
              _2249_eraseFn = ((_2246_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2245_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2249_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2245_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2241_isDatatype) || (_2242_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2245_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2243_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2242_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2245_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2243_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2248_recIdents;
          }
        } else if (_source72.is_Select) {
          DAST._IExpression _2250___mcc_h84 = _source72.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2251___mcc_h85 = _source72.dtor_field;
          bool _2252___mcc_h86 = _source72.dtor_isConstant;
          bool _2253___mcc_h87 = _source72.dtor_onDatatype;
          bool _2254_isDatatype = _2100___mcc_h35;
          bool _2255_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2256_field = _2098___mcc_h33;
          DAST._IExpression _2257_on = _2097___mcc_h32;
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
        } else if (_source72.is_SelectFn) {
          DAST._IExpression _2263___mcc_h92 = _source72.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2264___mcc_h93 = _source72.dtor_field;
          bool _2265___mcc_h94 = _source72.dtor_onDatatype;
          bool _2266___mcc_h95 = _source72.dtor_isStatic;
          BigInteger _2267___mcc_h96 = _source72.dtor_arity;
          bool _2268_isDatatype = _2100___mcc_h35;
          bool _2269_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2270_field = _2098___mcc_h33;
          DAST._IExpression _2271_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2272_onString;
            bool _2273_onOwned;
            bool _2274_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2275_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1467;
            bool _out1468;
            bool _out1469;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1470;
            DCOMP.COMP.GenExpr(_2271_on, selfIdent, @params, false, out _out1467, out _out1468, out _out1469, out _out1470);
            _2272_onString = _out1467;
            _2273_onOwned = _out1468;
            _2274_onErased = _out1469;
            _2275_recIdents = _out1470;
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
        } else if (_source72.is_Index) {
          DAST._IExpression _2277___mcc_h102 = _source72.dtor_expr;
          DAST._IExpression _2278___mcc_h103 = _source72.dtor_idx;
          bool _2279_isDatatype = _2100___mcc_h35;
          bool _2280_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2281_field = _2098___mcc_h33;
          DAST._IExpression _2282_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2283_onString;
            bool _2284_onOwned;
            bool _2285_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2286_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1471;
            bool _out1472;
            bool _out1473;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1474;
            DCOMP.COMP.GenExpr(_2282_on, selfIdent, @params, false, out _out1471, out _out1472, out _out1473, out _out1474);
            _2283_onString = _out1471;
            _2284_onOwned = _out1472;
            _2285_onErased = _out1473;
            _2286_recIdents = _out1474;
            if (!(_2285_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2287_eraseFn;
              _2287_eraseFn = ((_2284_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2283_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2287_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2283_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2279_isDatatype) || (_2280_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2283_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2281_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2280_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2283_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2281_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2286_recIdents;
          }
        } else if (_source72.is_TupleSelect) {
          DAST._IExpression _2288___mcc_h106 = _source72.dtor_expr;
          BigInteger _2289___mcc_h107 = _source72.dtor_index;
          bool _2290_isDatatype = _2100___mcc_h35;
          bool _2291_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2292_field = _2098___mcc_h33;
          DAST._IExpression _2293_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2294_onString;
            bool _2295_onOwned;
            bool _2296_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2297_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1475;
            bool _out1476;
            bool _out1477;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1478;
            DCOMP.COMP.GenExpr(_2293_on, selfIdent, @params, false, out _out1475, out _out1476, out _out1477, out _out1478);
            _2294_onString = _out1475;
            _2295_onOwned = _out1476;
            _2296_onErased = _out1477;
            _2297_recIdents = _out1478;
            if (!(_2296_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2298_eraseFn;
              _2298_eraseFn = ((_2295_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2294_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2298_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2294_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2290_isDatatype) || (_2291_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2294_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2292_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2291_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2294_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2292_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2297_recIdents;
          }
        } else if (_source72.is_Call) {
          DAST._IExpression _2299___mcc_h110 = _source72.dtor_on;
          Dafny.ISequence<Dafny.Rune> _2300___mcc_h111 = _source72.dtor_name;
          Dafny.ISequence<DAST._IType> _2301___mcc_h112 = _source72.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _2302___mcc_h113 = _source72.dtor_args;
          bool _2303_isDatatype = _2100___mcc_h35;
          bool _2304_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2305_field = _2098___mcc_h33;
          DAST._IExpression _2306_on = _2097___mcc_h32;
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
        } else if (_source72.is_Lambda) {
          Dafny.ISequence<DAST._IFormal> _2312___mcc_h118 = _source72.dtor_params;
          DAST._IType _2313___mcc_h119 = _source72.dtor_retType;
          Dafny.ISequence<DAST._IStatement> _2314___mcc_h120 = _source72.dtor_body;
          bool _2315_isDatatype = _2100___mcc_h35;
          bool _2316_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2317_field = _2098___mcc_h33;
          DAST._IExpression _2318_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2319_onString;
            bool _2320_onOwned;
            bool _2321_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2322_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1483;
            bool _out1484;
            bool _out1485;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1486;
            DCOMP.COMP.GenExpr(_2318_on, selfIdent, @params, false, out _out1483, out _out1484, out _out1485, out _out1486);
            _2319_onString = _out1483;
            _2320_onOwned = _out1484;
            _2321_onErased = _out1485;
            _2322_recIdents = _out1486;
            if (!(_2321_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2323_eraseFn;
              _2323_eraseFn = ((_2320_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2319_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2323_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2319_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2315_isDatatype) || (_2316_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2319_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2317_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2316_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2319_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2317_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2322_recIdents;
          }
        } else if (_source72.is_IIFE) {
          Dafny.ISequence<Dafny.Rune> _2324___mcc_h124 = _source72.dtor_name;
          DAST._IType _2325___mcc_h125 = _source72.dtor_typ;
          DAST._IExpression _2326___mcc_h126 = _source72.dtor_value;
          DAST._IExpression _2327___mcc_h127 = _source72.dtor_iifeBody;
          bool _2328_isDatatype = _2100___mcc_h35;
          bool _2329_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2330_field = _2098___mcc_h33;
          DAST._IExpression _2331_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2332_onString;
            bool _2333_onOwned;
            bool _2334_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2335_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1487;
            bool _out1488;
            bool _out1489;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1490;
            DCOMP.COMP.GenExpr(_2331_on, selfIdent, @params, false, out _out1487, out _out1488, out _out1489, out _out1490);
            _2332_onString = _out1487;
            _2333_onOwned = _out1488;
            _2334_onErased = _out1489;
            _2335_recIdents = _out1490;
            if (!(_2334_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2336_eraseFn;
              _2336_eraseFn = ((_2333_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2332_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2336_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2332_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2328_isDatatype) || (_2329_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2332_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2330_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2329_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2332_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2330_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2335_recIdents;
          }
        } else if (_source72.is_Apply) {
          DAST._IExpression _2337___mcc_h132 = _source72.dtor_expr;
          Dafny.ISequence<DAST._IExpression> _2338___mcc_h133 = _source72.dtor_args;
          bool _2339_isDatatype = _2100___mcc_h35;
          bool _2340_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2341_field = _2098___mcc_h33;
          DAST._IExpression _2342_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2343_onString;
            bool _2344_onOwned;
            bool _2345_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2346_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1491;
            bool _out1492;
            bool _out1493;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1494;
            DCOMP.COMP.GenExpr(_2342_on, selfIdent, @params, false, out _out1491, out _out1492, out _out1493, out _out1494);
            _2343_onString = _out1491;
            _2344_onOwned = _out1492;
            _2345_onErased = _out1493;
            _2346_recIdents = _out1494;
            if (!(_2345_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2347_eraseFn;
              _2347_eraseFn = ((_2344_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2343_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2347_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2343_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2339_isDatatype) || (_2340_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2343_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2341_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2340_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2343_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2341_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2346_recIdents;
          }
        } else if (_source72.is_TypeTest) {
          DAST._IExpression _2348___mcc_h136 = _source72.dtor_on;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2349___mcc_h137 = _source72.dtor_dType;
          Dafny.ISequence<Dafny.Rune> _2350___mcc_h138 = _source72.dtor_variant;
          bool _2351_isDatatype = _2100___mcc_h35;
          bool _2352_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2353_field = _2098___mcc_h33;
          DAST._IExpression _2354_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2355_onString;
            bool _2356_onOwned;
            bool _2357_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2358_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1495;
            bool _out1496;
            bool _out1497;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1498;
            DCOMP.COMP.GenExpr(_2354_on, selfIdent, @params, false, out _out1495, out _out1496, out _out1497, out _out1498);
            _2355_onString = _out1495;
            _2356_onOwned = _out1496;
            _2357_onErased = _out1497;
            _2358_recIdents = _out1498;
            if (!(_2357_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2359_eraseFn;
              _2359_eraseFn = ((_2356_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2355_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2359_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2355_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2351_isDatatype) || (_2352_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2355_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2353_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2352_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2355_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2353_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2358_recIdents;
          }
        } else {
          DAST._IType _2360___mcc_h142 = _source72.dtor_typ;
          bool _2361_isDatatype = _2100___mcc_h35;
          bool _2362_isConstant = _2099___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2363_field = _2098___mcc_h33;
          DAST._IExpression _2364_on = _2097___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2365_onString;
            bool _2366_onOwned;
            bool _2367_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2368_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1499;
            bool _out1500;
            bool _out1501;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1502;
            DCOMP.COMP.GenExpr(_2364_on, selfIdent, @params, false, out _out1499, out _out1500, out _out1501, out _out1502);
            _2365_onString = _out1499;
            _2366_onOwned = _out1500;
            _2367_onErased = _out1501;
            _2368_recIdents = _out1502;
            if (!(_2367_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2369_eraseFn;
              _2369_eraseFn = ((_2366_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2365_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2369_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2365_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2361_isDatatype) || (_2362_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2365_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2363_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2362_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2365_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2363_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2368_recIdents;
          }
        }
      } else if (_source20.is_SelectFn) {
        DAST._IExpression _2370___mcc_h144 = _source20.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2371___mcc_h145 = _source20.dtor_field;
        bool _2372___mcc_h146 = _source20.dtor_onDatatype;
        bool _2373___mcc_h147 = _source20.dtor_isStatic;
        BigInteger _2374___mcc_h148 = _source20.dtor_arity;
        BigInteger _2375_arity = _2374___mcc_h148;
        bool _2376_isStatic = _2373___mcc_h147;
        bool _2377_isDatatype = _2372___mcc_h146;
        Dafny.ISequence<Dafny.Rune> _2378_field = _2371___mcc_h145;
        DAST._IExpression _2379_on = _2370___mcc_h144;
        {
          Dafny.ISequence<Dafny.Rune> _2380_onString;
          bool _2381_onOwned;
          bool _2382___v74;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2383_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1503;
          bool _out1504;
          bool _out1505;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1506;
          DCOMP.COMP.GenExpr(_2379_on, selfIdent, @params, false, out _out1503, out _out1504, out _out1505, out _out1506);
          _2380_onString = _out1503;
          _2381_onOwned = _out1504;
          _2382___v74 = _out1505;
          _2383_recIdents = _out1506;
          if (_2376_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2380_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2378_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2380_onString), ((_2381_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2384_args;
            _2384_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2385_i;
            _2385_i = BigInteger.Zero;
            while ((_2385_i) < (_2375_arity)) {
              if ((_2385_i).Sign == 1) {
                _2384_args = Dafny.Sequence<Dafny.Rune>.Concat(_2384_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2384_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2384_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2385_i));
              _2385_i = (_2385_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2384_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2378_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2384_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _2383_recIdents;
        }
      } else if (_source20.is_Index) {
        DAST._IExpression _2386___mcc_h149 = _source20.dtor_expr;
        DAST._IExpression _2387___mcc_h150 = _source20.dtor_idx;
        DAST._IExpression _2388_idx = _2387___mcc_h150;
        DAST._IExpression _2389_on = _2386___mcc_h149;
        {
          Dafny.ISequence<Dafny.Rune> _2390_onString;
          bool _2391_onOwned;
          bool _2392_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2393_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1507;
          bool _out1508;
          bool _out1509;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1510;
          DCOMP.COMP.GenExpr(_2389_on, selfIdent, @params, false, out _out1507, out _out1508, out _out1509, out _out1510);
          _2390_onString = _out1507;
          _2391_onOwned = _out1508;
          _2392_onErased = _out1509;
          _2393_recIdents = _out1510;
          if (!(_2392_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2394_eraseFn;
            _2394_eraseFn = ((_2391_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2390_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2394_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2390_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2395_idxString;
          bool _2396___v75;
          bool _2397_idxErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2398_recIdentsIdx;
          Dafny.ISequence<Dafny.Rune> _out1511;
          bool _out1512;
          bool _out1513;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1514;
          DCOMP.COMP.GenExpr(_2388_idx, selfIdent, @params, true, out _out1511, out _out1512, out _out1513, out _out1514);
          _2395_idxString = _out1511;
          _2396___v75 = _out1512;
          _2397_idxErased = _out1513;
          _2398_recIdentsIdx = _out1514;
          if (!(_2397_idxErased)) {
            _2395_idxString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2395_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2390_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[<usize as ::dafny_runtime::NumCast>::from(")), _2395_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2393_recIdents, _2398_recIdentsIdx);
        }
      } else if (_source20.is_TupleSelect) {
        DAST._IExpression _2399___mcc_h151 = _source20.dtor_expr;
        BigInteger _2400___mcc_h152 = _source20.dtor_index;
        BigInteger _2401_idx = _2400___mcc_h152;
        DAST._IExpression _2402_on = _2399___mcc_h151;
        {
          Dafny.ISequence<Dafny.Rune> _2403_onString;
          bool _2404___v76;
          bool _2405_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2406_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1515;
          bool _out1516;
          bool _out1517;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1518;
          DCOMP.COMP.GenExpr(_2402_on, selfIdent, @params, false, out _out1515, out _out1516, out _out1517, out _out1518);
          _2403_onString = _out1515;
          _2404___v76 = _out1516;
          _2405_tupErased = _out1517;
          _2406_recIdents = _out1518;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2403_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2401_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2405_tupErased;
          readIdents = _2406_recIdents;
        }
      } else if (_source20.is_Call) {
        DAST._IExpression _2407___mcc_h153 = _source20.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2408___mcc_h154 = _source20.dtor_name;
        Dafny.ISequence<DAST._IType> _2409___mcc_h155 = _source20.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2410___mcc_h156 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2411_args = _2410___mcc_h156;
        Dafny.ISequence<DAST._IType> _2412_typeArgs = _2409___mcc_h155;
        Dafny.ISequence<Dafny.Rune> _2413_name = _2408___mcc_h154;
        DAST._IExpression _2414_on = _2407___mcc_h153;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2415_typeArgString;
          _2415_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2412_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2416_typeI;
            _2416_typeI = BigInteger.Zero;
            _2415_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2416_typeI) < (new BigInteger((_2412_typeArgs).Count))) {
              if ((_2416_typeI).Sign == 1) {
                _2415_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2415_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2417_typeString;
              Dafny.ISequence<Dafny.Rune> _out1519;
              _out1519 = DCOMP.COMP.GenType((_2412_typeArgs).Select(_2416_typeI), false, false);
              _2417_typeString = _out1519;
              _2415_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2415_typeArgString, _2417_typeString);
              _2416_typeI = (_2416_typeI) + (BigInteger.One);
            }
            _2415_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2415_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2418_argString;
          _2418_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2419_i;
          _2419_i = BigInteger.Zero;
          while ((_2419_i) < (new BigInteger((_2411_args).Count))) {
            if ((_2419_i).Sign == 1) {
              _2418_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2418_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2420_argExpr;
            bool _2421_isOwned;
            bool _2422_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2423_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1520;
            bool _out1521;
            bool _out1522;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1523;
            DCOMP.COMP.GenExpr((_2411_args).Select(_2419_i), selfIdent, @params, false, out _out1520, out _out1521, out _out1522, out _out1523);
            _2420_argExpr = _out1520;
            _2421_isOwned = _out1521;
            _2422_argErased = _out1522;
            _2423_argIdents = _out1523;
            if (_2421_isOwned) {
              _2420_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2420_argExpr);
            }
            _2418_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2418_argString, _2420_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2423_argIdents);
            _2419_i = (_2419_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2424_enclosingString;
          bool _2425___v77;
          bool _2426___v78;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2427_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1524;
          bool _out1525;
          bool _out1526;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1527;
          DCOMP.COMP.GenExpr(_2414_on, selfIdent, @params, false, out _out1524, out _out1525, out _out1526, out _out1527);
          _2424_enclosingString = _out1524;
          _2425___v77 = _out1525;
          _2426___v78 = _out1526;
          _2427_recIdents = _out1527;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2427_recIdents);
          DAST._IExpression _source73 = _2414_on;
          if (_source73.is_Literal) {
            DAST._ILiteral _2428___mcc_h1037 = _source73.dtor_Literal_a0;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2429___mcc_h1039 = _source73.dtor_Ident_a0;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2430___mcc_h1041 = _source73.dtor_Companion_a0;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_2424_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source73.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2431___mcc_h1043 = _source73.dtor_Tuple_a0;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2432___mcc_h1045 = _source73.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2433___mcc_h1046 = _source73.dtor_args;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2434___mcc_h1049 = _source73.dtor_dims;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2435___mcc_h1051 = _source73.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2436___mcc_h1052 = _source73.dtor_variant;
            bool _2437___mcc_h1053 = _source73.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2438___mcc_h1054 = _source73.dtor_contents;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Convert) {
            DAST._IExpression _2439___mcc_h1059 = _source73.dtor_value;
            DAST._IType _2440___mcc_h1060 = _source73.dtor_from;
            DAST._IType _2441___mcc_h1061 = _source73.dtor_typ;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2442___mcc_h1065 = _source73.dtor_elements;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2443___mcc_h1067 = _source73.dtor_elements;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_This) {
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Ite) {
            DAST._IExpression _2444___mcc_h1069 = _source73.dtor_cond;
            DAST._IExpression _2445___mcc_h1070 = _source73.dtor_thn;
            DAST._IExpression _2446___mcc_h1071 = _source73.dtor_els;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_UnOp) {
            DAST._IUnaryOp _2447___mcc_h1075 = _source73.dtor_unOp;
            DAST._IExpression _2448___mcc_h1076 = _source73.dtor_expr;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2449___mcc_h1079 = _source73.dtor_op;
            DAST._IExpression _2450___mcc_h1080 = _source73.dtor_left;
            DAST._IExpression _2451___mcc_h1081 = _source73.dtor_right;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Select) {
            DAST._IExpression _2452___mcc_h1085 = _source73.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2453___mcc_h1086 = _source73.dtor_field;
            bool _2454___mcc_h1087 = _source73.dtor_isConstant;
            bool _2455___mcc_h1088 = _source73.dtor_onDatatype;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_SelectFn) {
            DAST._IExpression _2456___mcc_h1093 = _source73.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2457___mcc_h1094 = _source73.dtor_field;
            bool _2458___mcc_h1095 = _source73.dtor_onDatatype;
            bool _2459___mcc_h1096 = _source73.dtor_isStatic;
            BigInteger _2460___mcc_h1097 = _source73.dtor_arity;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Index) {
            DAST._IExpression _2461___mcc_h1103 = _source73.dtor_expr;
            DAST._IExpression _2462___mcc_h1104 = _source73.dtor_idx;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_TupleSelect) {
            DAST._IExpression _2463___mcc_h1107 = _source73.dtor_expr;
            BigInteger _2464___mcc_h1108 = _source73.dtor_index;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Call) {
            DAST._IExpression _2465___mcc_h1111 = _source73.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2466___mcc_h1112 = _source73.dtor_name;
            Dafny.ISequence<DAST._IType> _2467___mcc_h1113 = _source73.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2468___mcc_h1114 = _source73.dtor_args;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2469___mcc_h1119 = _source73.dtor_params;
            DAST._IType _2470___mcc_h1120 = _source73.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2471___mcc_h1121 = _source73.dtor_body;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2472___mcc_h1125 = _source73.dtor_name;
            DAST._IType _2473___mcc_h1126 = _source73.dtor_typ;
            DAST._IExpression _2474___mcc_h1127 = _source73.dtor_value;
            DAST._IExpression _2475___mcc_h1128 = _source73.dtor_iifeBody;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Apply) {
            DAST._IExpression _2476___mcc_h1133 = _source73.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2477___mcc_h1134 = _source73.dtor_args;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_TypeTest) {
            DAST._IExpression _2478___mcc_h1137 = _source73.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2479___mcc_h1138 = _source73.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2480___mcc_h1139 = _source73.dtor_variant;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _2481___mcc_h1143 = _source73.dtor_typ;
            {
              _2424_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2424_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_2413_name)), _2415_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2418_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source20.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2482___mcc_h157 = _source20.dtor_params;
        DAST._IType _2483___mcc_h158 = _source20.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2484___mcc_h159 = _source20.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2485_body = _2484___mcc_h159;
        DAST._IType _2486_retType = _2483___mcc_h158;
        Dafny.ISequence<DAST._IFormal> _2487_params = _2482___mcc_h157;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2488_paramNames;
          _2488_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2489_i;
          _2489_i = BigInteger.Zero;
          while ((_2489_i) < (new BigInteger((_2487_params).Count))) {
            _2488_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2488_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2487_params).Select(_2489_i)).dtor_name));
            _2489_i = (_2489_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2490_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2491_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1528;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1529;
          DCOMP.COMP.GenStmts(_2485_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2488_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1528, out _out1529);
          _2490_recursiveGen = _out1528;
          _2491_recIdents = _out1529;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2492_allReadCloned;
          _2492_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2491_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2493_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2491_recIdents).Elements) {
              _2493_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2491_recIdents).Contains(_2493_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1645)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2488_paramNames).Contains(_2493_next))) {
              _2492_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2492_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2493_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2493_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2493_next));
            }
            _2491_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2491_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2493_next));
          }
          Dafny.ISequence<Dafny.Rune> _2494_paramsString;
          _2494_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2489_i = BigInteger.Zero;
          while ((_2489_i) < (new BigInteger((_2487_params).Count))) {
            if ((_2489_i).Sign == 1) {
              _2494_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2494_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2495_typStr;
            Dafny.ISequence<Dafny.Rune> _out1530;
            _out1530 = DCOMP.COMP.GenType(((_2487_params).Select(_2489_i)).dtor_typ, false, true);
            _2495_typStr = _out1530;
            _2494_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2494_paramsString, ((_2487_params).Select(_2489_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2495_typStr);
            _2489_i = (_2489_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2496_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1531;
          _out1531 = DCOMP.COMP.GenType(_2486_retType, false, true);
          _2496_retTypeGen = _out1531;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _2492_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _2494_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2496_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2490_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2497___mcc_h160 = _source20.dtor_name;
        DAST._IType _2498___mcc_h161 = _source20.dtor_typ;
        DAST._IExpression _2499___mcc_h162 = _source20.dtor_value;
        DAST._IExpression _2500___mcc_h163 = _source20.dtor_iifeBody;
        DAST._IExpression _2501_iifeBody = _2500___mcc_h163;
        DAST._IExpression _2502_value = _2499___mcc_h162;
        DAST._IType _2503_tpe = _2498___mcc_h161;
        Dafny.ISequence<Dafny.Rune> _2504_name = _2497___mcc_h160;
        {
          Dafny.ISequence<Dafny.Rune> _2505_valueGen;
          bool _2506_valueOwned;
          bool _2507_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2508_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1532;
          bool _out1533;
          bool _out1534;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1535;
          DCOMP.COMP.GenExpr(_2502_value, selfIdent, @params, false, out _out1532, out _out1533, out _out1534, out _out1535);
          _2505_valueGen = _out1532;
          _2506_valueOwned = _out1533;
          _2507_valueErased = _out1534;
          _2508_recIdents = _out1535;
          if (_2507_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2509_eraseFn;
            _2509_eraseFn = ((_2506_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2505_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2509_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2505_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2508_recIdents;
          Dafny.ISequence<Dafny.Rune> _2510_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1536;
          _out1536 = DCOMP.COMP.GenType(_2503_tpe, false, true);
          _2510_valueTypeGen = _out1536;
          Dafny.ISequence<Dafny.Rune> _2511_bodyGen;
          bool _2512_bodyOwned;
          bool _2513_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2514_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1537;
          bool _out1538;
          bool _out1539;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1540;
          DCOMP.COMP.GenExpr(_2501_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2506_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2504_name))))), mustOwn, out _out1537, out _out1538, out _out1539, out _out1540);
          _2511_bodyGen = _out1537;
          _2512_bodyOwned = _out1538;
          _2513_bodyErased = _out1539;
          _2514_bodyIdents = _out1540;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2514_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _2515_eraseFn;
          _2515_eraseFn = ((_2506_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2504_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2506_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2510_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2505_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2511_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2512_bodyOwned;
          isErased = _2513_bodyErased;
        }
      } else if (_source20.is_Apply) {
        DAST._IExpression _2516___mcc_h164 = _source20.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2517___mcc_h165 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2518_args = _2517___mcc_h165;
        DAST._IExpression _2519_func = _2516___mcc_h164;
        {
          Dafny.ISequence<Dafny.Rune> _2520_funcString;
          bool _2521___v81;
          bool _2522_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2523_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1541;
          bool _out1542;
          bool _out1543;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1544;
          DCOMP.COMP.GenExpr(_2519_func, selfIdent, @params, false, out _out1541, out _out1542, out _out1543, out _out1544);
          _2520_funcString = _out1541;
          _2521___v81 = _out1542;
          _2522_funcErased = _out1543;
          _2523_recIdents = _out1544;
          readIdents = _2523_recIdents;
          Dafny.ISequence<Dafny.Rune> _2524_argString;
          _2524_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2525_i;
          _2525_i = BigInteger.Zero;
          while ((_2525_i) < (new BigInteger((_2518_args).Count))) {
            if ((_2525_i).Sign == 1) {
              _2524_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2524_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2526_argExpr;
            bool _2527_isOwned;
            bool _2528_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2529_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1545;
            bool _out1546;
            bool _out1547;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1548;
            DCOMP.COMP.GenExpr((_2518_args).Select(_2525_i), selfIdent, @params, false, out _out1545, out _out1546, out _out1547, out _out1548);
            _2526_argExpr = _out1545;
            _2527_isOwned = _out1546;
            _2528_argErased = _out1547;
            _2529_argIdents = _out1548;
            if (_2527_isOwned) {
              _2526_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2526_argExpr);
            }
            _2524_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2524_argString, _2526_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2529_argIdents);
            _2525_i = (_2525_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2520_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2524_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source20.is_TypeTest) {
        DAST._IExpression _2530___mcc_h166 = _source20.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2531___mcc_h167 = _source20.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2532___mcc_h168 = _source20.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2533_variant = _2532___mcc_h168;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2534_dType = _2531___mcc_h167;
        DAST._IExpression _2535_on = _2530___mcc_h166;
        {
          Dafny.ISequence<Dafny.Rune> _2536_exprGen;
          bool _2537___v82;
          bool _2538_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2539_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1549;
          bool _out1550;
          bool _out1551;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1552;
          DCOMP.COMP.GenExpr(_2535_on, selfIdent, @params, false, out _out1549, out _out1550, out _out1551, out _out1552);
          _2536_exprGen = _out1549;
          _2537___v82 = _out1550;
          _2538_exprErased = _out1551;
          _2539_recIdents = _out1552;
          Dafny.ISequence<Dafny.Rune> _2540_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1553;
          _out1553 = DCOMP.COMP.GenPath(_2534_dType);
          _2540_dTypePath = _out1553;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2536_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2540_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2533_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2539_recIdents;
        }
      } else {
        DAST._IType _2541___mcc_h169 = _source20.dtor_typ;
        DAST._IType _2542_typ = _2541___mcc_h169;
        {
          Dafny.ISequence<Dafny.Rune> _2543_typString;
          Dafny.ISequence<Dafny.Rune> _out1554;
          _out1554 = DCOMP.COMP.GenType(_2542_typ, false, false);
          _2543_typString = _out1554;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2543_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2544_i;
      _2544_i = BigInteger.Zero;
      while ((_2544_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2545_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1555;
        _out1555 = DCOMP.COMP.GenModule((p).Select(_2544_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2545_generated = _out1555;
        if ((_2544_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2545_generated);
        _2544_i = (_2544_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2546_i;
      _2546_i = BigInteger.Zero;
      while ((_2546_i) < (new BigInteger((fullName).Count))) {
        if ((_2546_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2546_i));
        _2546_i = (_2546_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

