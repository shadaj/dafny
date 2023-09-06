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
      hash = ((hash << 5) + hash) + 20;
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
      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _207_declarations;
      _207_declarations = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _208_i;
      _208_i = BigInteger.Zero;
      while ((_208_i) < (new BigInteger((stmts).Count))) {
        DAST._IStatement _209_stmt;
        _209_stmt = (stmts).Select(_208_i);
        Dafny.ISequence<Dafny.Rune> _210_stmtString;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _211_recIdents;
        Dafny.ISequence<Dafny.Rune> _out62;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out63;
        DCOMP.COMP.GenStmt(_209_stmt, selfIdent, @params, (isLast) && ((_208_i) == ((new BigInteger((stmts).Count)) - (BigInteger.One))), earlyReturn, out _out62, out _out63);
        _210_stmtString = _out62;
        _211_recIdents = _out63;
        readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_211_recIdents, _207_declarations));
        DAST._IStatement _source13 = _209_stmt;
        if (_source13.is_DeclareVar) {
          Dafny.ISequence<Dafny.Rune> _212___mcc_h0 = _source13.dtor_name;
          DAST._IType _213___mcc_h1 = _source13.dtor_typ;
          DAST._IOptional<DAST._IExpression> _214___mcc_h2 = _source13.dtor_maybeValue;
          Dafny.ISequence<Dafny.Rune> _215_name = _212___mcc_h0;
          {
            _207_declarations = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_207_declarations, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_215_name));
          }
        } else if (_source13.is_Assign) {
          DAST._IAssignLhs _216___mcc_h6 = _source13.dtor_lhs;
          DAST._IExpression _217___mcc_h7 = _source13.dtor_value;
        } else if (_source13.is_If) {
          DAST._IExpression _218___mcc_h10 = _source13.dtor_cond;
          Dafny.ISequence<DAST._IStatement> _219___mcc_h11 = _source13.dtor_thn;
          Dafny.ISequence<DAST._IStatement> _220___mcc_h12 = _source13.dtor_els;
        } else if (_source13.is_While) {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _221___mcc_h16 = _source13.dtor_lbl;
          DAST._IExpression _222___mcc_h17 = _source13.dtor_cond;
          Dafny.ISequence<DAST._IStatement> _223___mcc_h18 = _source13.dtor_body;
        } else if (_source13.is_Call) {
          DAST._IExpression _224___mcc_h22 = _source13.dtor_on;
          Dafny.ISequence<Dafny.Rune> _225___mcc_h23 = _source13.dtor_name;
          Dafny.ISequence<DAST._IType> _226___mcc_h24 = _source13.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _227___mcc_h25 = _source13.dtor_args;
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _228___mcc_h26 = _source13.dtor_outs;
        } else if (_source13.is_Return) {
          DAST._IExpression _229___mcc_h32 = _source13.dtor_expr;
        } else if (_source13.is_EarlyReturn) {
        } else if (_source13.is_Break) {
          Dafny.ISequence<Dafny.Rune> _230___mcc_h34 = _source13.dtor_toLabel;
        } else if (_source13.is_TailRecursive) {
          Dafny.ISequence<DAST._IStatement> _231___mcc_h36 = _source13.dtor_body;
        } else if (_source13.is_JumpTailCallStart) {
        } else if (_source13.is_Halt) {
        } else {
          DAST._IExpression _232___mcc_h38 = _source13.dtor_Print_a0;
        }
        if ((_208_i).Sign == 1) {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, _210_stmtString);
        _208_i = (_208_i) + (BigInteger.One);
      }
    }
    public static void GenAssignLhs(DAST._IAssignLhs lhs, Dafny.ISequence<Dafny.Rune> rhs, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      needsIIFE = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IAssignLhs _source14 = lhs;
      if (_source14.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _233___mcc_h0 = _source14.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _source15 = _233___mcc_h0;
        Dafny.ISequence<Dafny.Rune> _234___mcc_h1 = _source15;
        Dafny.ISequence<Dafny.Rune> _235_id = _234___mcc_h1;
        {
          if ((@params).Contains(_235_id)) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*r#"), _235_id);
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _235_id);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_235_id);
          needsIIFE = false;
        }
      } else if (_source14.is_Select) {
        DAST._IExpression _236___mcc_h2 = _source14.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _237___mcc_h3 = _source14.dtor_field;
        Dafny.ISequence<Dafny.Rune> _238_field = _237___mcc_h3;
        DAST._IExpression _239_on = _236___mcc_h2;
        {
          Dafny.ISequence<Dafny.Rune> _240_onExpr;
          bool _241_onOwned;
          bool _242_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _243_recIdents;
          Dafny.ISequence<Dafny.Rune> _out64;
          bool _out65;
          bool _out66;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out67;
          DCOMP.COMP.GenExpr(_239_on, selfIdent, @params, false, out _out64, out _out65, out _out66, out _out67);
          _240_onExpr = _out64;
          _241_onOwned = _out65;
          _242_onErased = _out66;
          _243_recIdents = _out67;
          if (!(_242_onErased)) {
            Dafny.ISequence<Dafny.Rune> _244_eraseFn;
            _244_eraseFn = ((_241_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _240_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _244_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _240_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _240_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _238_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()) = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = _243_recIdents;
          needsIIFE = true;
        }
      } else {
        DAST._IExpression _245___mcc_h4 = _source14.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _246___mcc_h5 = _source14.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _247_indices = _246___mcc_h5;
        DAST._IExpression _248_on = _245___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _249_onExpr;
          bool _250_onOwned;
          bool _251_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _252_recIdents;
          Dafny.ISequence<Dafny.Rune> _out68;
          bool _out69;
          bool _out70;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out71;
          DCOMP.COMP.GenExpr(_248_on, selfIdent, @params, false, out _out68, out _out69, out _out70, out _out71);
          _249_onExpr = _out68;
          _250_onOwned = _out69;
          _251_onErased = _out70;
          _252_recIdents = _out71;
          readIdents = _252_recIdents;
          if (!(_251_onErased)) {
            Dafny.ISequence<Dafny.Rune> _253_eraseFn;
            _253_eraseFn = ((_250_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _249_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _253_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _249_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          BigInteger _254_i;
          _254_i = BigInteger.Zero;
          while ((_254_i) < (new BigInteger((_247_indices).Count))) {
            Dafny.ISequence<Dafny.Rune> _255_idx;
            bool _256___v16;
            bool _257_idxErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _258_recIdentsIdx;
            Dafny.ISequence<Dafny.Rune> _out72;
            bool _out73;
            bool _out74;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out75;
            DCOMP.COMP.GenExpr((_247_indices).Select(_254_i), selfIdent, @params, true, out _out72, out _out73, out _out74, out _out75);
            _255_idx = _out72;
            _256___v16 = _out73;
            _257_idxErased = _out74;
            _258_recIdentsIdx = _out75;
            if (!(_257_idxErased)) {
              _255_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _255_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let __idx")), DCOMP.__default.natToString(_254_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = <usize as ::dafny_runtime::NumCast>::from(")), _255_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap();\n"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _258_recIdentsIdx);
            _254_i = (_254_i) + (BigInteger.One);
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, _249_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()"));
          _254_i = BigInteger.Zero;
          while ((_254_i) < (new BigInteger((_247_indices).Count))) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[__idx")), DCOMP.__default.natToString(_254_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
            _254_i = (_254_i) + (BigInteger.One);
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
        Dafny.ISequence<Dafny.Rune> _259___mcc_h0 = _source16.dtor_name;
        DAST._IType _260___mcc_h1 = _source16.dtor_typ;
        DAST._IOptional<DAST._IExpression> _261___mcc_h2 = _source16.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source17 = _261___mcc_h2;
        if (_source17.is_Some) {
          DAST._IExpression _262___mcc_h3 = _source17.dtor_Some_a0;
          DAST._IExpression _263_expression = _262___mcc_h3;
          DAST._IType _264_typ = _260___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _265_name = _259___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _266_expr;
            bool _267___v17;
            bool _268_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _269_recIdents;
            Dafny.ISequence<Dafny.Rune> _out76;
            bool _out77;
            bool _out78;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out79;
            DCOMP.COMP.GenExpr(_263_expression, selfIdent, @params, true, out _out76, out _out77, out _out78, out _out79);
            _266_expr = _out76;
            _267___v17 = _out77;
            _268_recErased = _out78;
            _269_recIdents = _out79;
            if (_268_recErased) {
              _266_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _266_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _270_typeString;
            Dafny.ISequence<Dafny.Rune> _out80;
            _out80 = DCOMP.COMP.GenType(_264_typ, true, false);
            _270_typeString = _out80;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _265_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _270_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _266_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _269_recIdents;
          }
        } else {
          DAST._IType _271_typ = _260___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _272_name = _259___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _273_typeString;
            Dafny.ISequence<Dafny.Rune> _out81;
            _out81 = DCOMP.COMP.GenType(_271_typ, true, false);
            _273_typeString = _out81;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _272_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _273_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source16.is_Assign) {
        DAST._IAssignLhs _274___mcc_h4 = _source16.dtor_lhs;
        DAST._IExpression _275___mcc_h5 = _source16.dtor_value;
        DAST._IExpression _276_expression = _275___mcc_h5;
        DAST._IAssignLhs _277_lhs = _274___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _278_lhsGen;
          bool _279_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _280_recIdents;
          Dafny.ISequence<Dafny.Rune> _out82;
          bool _out83;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out84;
          DCOMP.COMP.GenAssignLhs(_277_lhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("__rhs"), selfIdent, @params, out _out82, out _out83, out _out84);
          _278_lhsGen = _out82;
          _279_needsIIFE = _out83;
          _280_recIdents = _out84;
          Dafny.ISequence<Dafny.Rune> _281_exprGen;
          bool _282___v18;
          bool _283_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _284_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out85;
          bool _out86;
          bool _out87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out88;
          DCOMP.COMP.GenExpr(_276_expression, selfIdent, @params, true, out _out85, out _out86, out _out87, out _out88);
          _281_exprGen = _out85;
          _282___v18 = _out86;
          _283_exprErased = _out87;
          _284_exprIdents = _out88;
          if (_283_exprErased) {
            _281_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _281_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_279_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __rhs = "), _281_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _278_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_278_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _281_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_280_recIdents, _284_exprIdents);
        }
      } else if (_source16.is_If) {
        DAST._IExpression _285___mcc_h6 = _source16.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _286___mcc_h7 = _source16.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _287___mcc_h8 = _source16.dtor_els;
        Dafny.ISequence<DAST._IStatement> _288_els = _287___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _289_thn = _286___mcc_h7;
        DAST._IExpression _290_cond = _285___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _291_condString;
          bool _292___v19;
          bool _293_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _294_recIdents;
          Dafny.ISequence<Dafny.Rune> _out89;
          bool _out90;
          bool _out91;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out92;
          DCOMP.COMP.GenExpr(_290_cond, selfIdent, @params, true, out _out89, out _out90, out _out91, out _out92);
          _291_condString = _out89;
          _292___v19 = _out90;
          _293_condErased = _out91;
          _294_recIdents = _out92;
          if (!(_293_condErased)) {
            _291_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _291_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _294_recIdents;
          Dafny.ISequence<Dafny.Rune> _295_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _296_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out93;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
          DCOMP.COMP.GenStmts(_289_thn, selfIdent, @params, isLast, earlyReturn, out _out93, out _out94);
          _295_thnString = _out93;
          _296_thnIdents = _out94;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _296_thnIdents);
          Dafny.ISequence<Dafny.Rune> _297_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _298_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out95;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out96;
          DCOMP.COMP.GenStmts(_288_els, selfIdent, @params, isLast, earlyReturn, out _out95, out _out96);
          _297_elsString = _out95;
          _298_elsIdents = _out96;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _298_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _291_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _295_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _297_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_While) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _299___mcc_h9 = _source16.dtor_lbl;
        DAST._IExpression _300___mcc_h10 = _source16.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _301___mcc_h11 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _302_body = _301___mcc_h11;
        DAST._IExpression _303_cond = _300___mcc_h10;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _304_lbl = _299___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _305_condString;
          bool _306___v20;
          bool _307_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _308_recIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          bool _out98;
          bool _out99;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out100;
          DCOMP.COMP.GenExpr(_303_cond, selfIdent, @params, true, out _out97, out _out98, out _out99, out _out100);
          _305_condString = _out97;
          _306___v20 = _out98;
          _307_condErased = _out99;
          _308_recIdents = _out100;
          if (!(_307_condErased)) {
            _305_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _305_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _308_recIdents;
          Dafny.ISequence<Dafny.Rune> _309_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _310_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenStmts(_302_body, selfIdent, @params, false, earlyReturn, out _out101, out _out102);
          _309_bodyString = _out101;
          _310_bodyIdents = _out102;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _310_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _311_lblString;
          _311_lblString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source18 = _304_lbl;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.Rune> _312___mcc_h21 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _313_id = _312___mcc_h21;
            {
              _311_lblString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _313_id), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": "));
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_311_lblString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while ")), _305_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _309_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Call) {
        DAST._IExpression _314___mcc_h12 = _source16.dtor_on;
        Dafny.ISequence<Dafny.Rune> _315___mcc_h13 = _source16.dtor_name;
        Dafny.ISequence<DAST._IType> _316___mcc_h14 = _source16.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _317___mcc_h15 = _source16.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _318___mcc_h16 = _source16.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _319_maybeOutVars = _318___mcc_h16;
        Dafny.ISequence<DAST._IExpression> _320_args = _317___mcc_h15;
        Dafny.ISequence<DAST._IType> _321_typeArgs = _316___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _322_name = _315___mcc_h13;
        DAST._IExpression _323_on = _314___mcc_h12;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _324_typeArgString;
          _324_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_321_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _325_typeI;
            _325_typeI = BigInteger.Zero;
            _324_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_325_typeI) < (new BigInteger((_321_typeArgs).Count))) {
              if ((_325_typeI).Sign == 1) {
                _324_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_324_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _326_typeString;
              Dafny.ISequence<Dafny.Rune> _out103;
              _out103 = DCOMP.COMP.GenType((_321_typeArgs).Select(_325_typeI), false, false);
              _326_typeString = _out103;
              _324_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_324_typeArgString, _326_typeString);
              _325_typeI = (_325_typeI) + (BigInteger.One);
            }
            _324_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_324_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _327_argString;
          _327_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _328_i;
          _328_i = BigInteger.Zero;
          while ((_328_i) < (new BigInteger((_320_args).Count))) {
            if ((_328_i).Sign == 1) {
              _327_argString = Dafny.Sequence<Dafny.Rune>.Concat(_327_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _329_argExpr;
            bool _330_isOwned;
            bool _331_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _332_argIdents;
            Dafny.ISequence<Dafny.Rune> _out104;
            bool _out105;
            bool _out106;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out107;
            DCOMP.COMP.GenExpr((_320_args).Select(_328_i), selfIdent, @params, false, out _out104, out _out105, out _out106, out _out107);
            _329_argExpr = _out104;
            _330_isOwned = _out105;
            _331_argErased = _out106;
            _332_argIdents = _out107;
            if (_330_isOwned) {
              _329_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _329_argExpr);
            }
            _327_argString = Dafny.Sequence<Dafny.Rune>.Concat(_327_argString, _329_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _332_argIdents);
            _328_i = (_328_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _333_enclosingString;
          bool _334___v21;
          bool _335___v22;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _336_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out108;
          bool _out109;
          bool _out110;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out111;
          DCOMP.COMP.GenExpr(_323_on, selfIdent, @params, false, out _out108, out _out109, out _out110, out _out111);
          _333_enclosingString = _out108;
          _334___v21 = _out109;
          _335___v22 = _out110;
          _336_enclosingIdents = _out111;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _336_enclosingIdents);
          DAST._IExpression _source19 = _323_on;
          if (_source19.is_Literal) {
            DAST._ILiteral _337___mcc_h22 = _source19.dtor_Literal_a0;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _338___mcc_h24 = _source19.dtor_Ident_a0;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _339___mcc_h26 = _source19.dtor_Companion_a0;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_333_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source19.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _340___mcc_h28 = _source19.dtor_Tuple_a0;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _341___mcc_h30 = _source19.dtor_path;
            Dafny.ISequence<DAST._IExpression> _342___mcc_h31 = _source19.dtor_args;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _343___mcc_h34 = _source19.dtor_dims;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _344___mcc_h36 = _source19.dtor_path;
            Dafny.ISequence<Dafny.Rune> _345___mcc_h37 = _source19.dtor_variant;
            bool _346___mcc_h38 = _source19.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _347___mcc_h39 = _source19.dtor_contents;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Convert) {
            DAST._IExpression _348___mcc_h44 = _source19.dtor_value;
            DAST._IType _349___mcc_h45 = _source19.dtor_from;
            DAST._IType _350___mcc_h46 = _source19.dtor_typ;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _351___mcc_h50 = _source19.dtor_elements;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _352___mcc_h52 = _source19.dtor_elements;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_This) {
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Ite) {
            DAST._IExpression _353___mcc_h54 = _source19.dtor_cond;
            DAST._IExpression _354___mcc_h55 = _source19.dtor_thn;
            DAST._IExpression _355___mcc_h56 = _source19.dtor_els;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_UnOp) {
            DAST._IUnaryOp _356___mcc_h60 = _source19.dtor_unOp;
            DAST._IExpression _357___mcc_h61 = _source19.dtor_expr;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _358___mcc_h64 = _source19.dtor_op;
            DAST._IExpression _359___mcc_h65 = _source19.dtor_left;
            DAST._IExpression _360___mcc_h66 = _source19.dtor_right;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_ArrayLen) {
            DAST._IExpression _361___mcc_h70 = _source19.dtor_expr;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Select) {
            DAST._IExpression _362___mcc_h72 = _source19.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _363___mcc_h73 = _source19.dtor_field;
            bool _364___mcc_h74 = _source19.dtor_isConstant;
            bool _365___mcc_h75 = _source19.dtor_onDatatype;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_SelectFn) {
            DAST._IExpression _366___mcc_h80 = _source19.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _367___mcc_h81 = _source19.dtor_field;
            bool _368___mcc_h82 = _source19.dtor_onDatatype;
            bool _369___mcc_h83 = _source19.dtor_isStatic;
            BigInteger _370___mcc_h84 = _source19.dtor_arity;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Index) {
            DAST._IExpression _371___mcc_h90 = _source19.dtor_expr;
            bool _372___mcc_h91 = _source19.dtor_isArray;
            Dafny.ISequence<DAST._IExpression> _373___mcc_h92 = _source19.dtor_indices;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_IndexRange) {
            DAST._IExpression _374___mcc_h96 = _source19.dtor_expr;
            bool _375___mcc_h97 = _source19.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _376___mcc_h98 = _source19.dtor_low;
            DAST._IOptional<DAST._IExpression> _377___mcc_h99 = _source19.dtor_high;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_TupleSelect) {
            DAST._IExpression _378___mcc_h104 = _source19.dtor_expr;
            BigInteger _379___mcc_h105 = _source19.dtor_index;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Call) {
            DAST._IExpression _380___mcc_h108 = _source19.dtor_on;
            Dafny.ISequence<Dafny.Rune> _381___mcc_h109 = _source19.dtor_name;
            Dafny.ISequence<DAST._IType> _382___mcc_h110 = _source19.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _383___mcc_h111 = _source19.dtor_args;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _384___mcc_h116 = _source19.dtor_params;
            DAST._IType _385___mcc_h117 = _source19.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _386___mcc_h118 = _source19.dtor_body;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _387___mcc_h122 = _source19.dtor_name;
            DAST._IType _388___mcc_h123 = _source19.dtor_typ;
            DAST._IExpression _389___mcc_h124 = _source19.dtor_value;
            DAST._IExpression _390___mcc_h125 = _source19.dtor_iifeBody;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Apply) {
            DAST._IExpression _391___mcc_h130 = _source19.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _392___mcc_h131 = _source19.dtor_args;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_TypeTest) {
            DAST._IExpression _393___mcc_h134 = _source19.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _394___mcc_h135 = _source19.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _395___mcc_h136 = _source19.dtor_variant;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _396___mcc_h140 = _source19.dtor_typ;
            {
              _333_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _397_receiver;
          _397_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source20 = _319_maybeOutVars;
          if (_source20.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _398___mcc_h142 = _source20.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _399_outVars = _398___mcc_h142;
            {
              if ((new BigInteger((_399_outVars).Count)) > (BigInteger.One)) {
                _397_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _400_outI;
              _400_outI = BigInteger.Zero;
              while ((_400_outI) < (new BigInteger((_399_outVars).Count))) {
                if ((_400_outI).Sign == 1) {
                  _397_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_397_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _401_outVar;
                _401_outVar = (_399_outVars).Select(_400_outI);
                _397_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_397_receiver, (_401_outVar));
                _400_outI = (_400_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_399_outVars).Count)) > (BigInteger.One)) {
                _397_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_397_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_397_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_397_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _333_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _322_name), _324_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _327_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source16.is_Return) {
        DAST._IExpression _402___mcc_h17 = _source16.dtor_expr;
        DAST._IExpression _403_expr = _402___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _404_exprString;
          bool _405___v25;
          bool _406_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _407_recIdents;
          Dafny.ISequence<Dafny.Rune> _out112;
          bool _out113;
          bool _out114;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out115;
          DCOMP.COMP.GenExpr(_403_expr, selfIdent, @params, true, out _out112, out _out113, out _out114, out _out115);
          _404_exprString = _out112;
          _405___v25 = _out113;
          _406_recErased = _out114;
          _407_recIdents = _out115;
          _404_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _404_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _407_recIdents;
          if (isLast) {
            generated = _404_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _404_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source16.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_Break) {
        Dafny.ISequence<Dafny.Rune> _408___mcc_h18 = _source16.dtor_toLabel;
        Dafny.ISequence<Dafny.Rune> _409_toLabel = _408___mcc_h18;
        {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break 'label_"), _409_toLabel), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _410___mcc_h19 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _411_body = _410___mcc_h19;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _412_paramI;
          _412_paramI = BigInteger.Zero;
          while ((_412_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _413_param;
            _413_param = (@params).Select(_412_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _413_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _413_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _412_paramI = (_412_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _414_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _415_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out116;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out117;
          DCOMP.COMP.GenStmts(_411_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out116, out _out117);
          _414_bodyString = _out116;
          _415_bodyIdents = _out117;
          readIdents = _415_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _414_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
        DAST._IExpression _416___mcc_h20 = _source16.dtor_Print_a0;
        DAST._IExpression _417_e = _416___mcc_h20;
        {
          Dafny.ISequence<Dafny.Rune> _418_printedExpr;
          bool _419_isOwned;
          bool _420___v26;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _421_recIdents;
          Dafny.ISequence<Dafny.Rune> _out118;
          bool _out119;
          bool _out120;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out121;
          DCOMP.COMP.GenExpr(_417_e, selfIdent, @params, false, out _out118, out _out119, out _out120, out _out121);
          _418_printedExpr = _out118;
          _419_isOwned = _out119;
          _420___v26 = _out120;
          _421_recIdents = _out121;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_419_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _418_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _421_recIdents;
        }
      }
    }
    public static void GenExpr(DAST._IExpression e, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool mustOwn, out Dafny.ISequence<Dafny.Rune> s, out bool isOwned, out bool isErased, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      isOwned = false;
      isErased = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IExpression _source21 = e;
      if (_source21.is_Literal) {
        DAST._ILiteral _422___mcc_h0 = _source21.dtor_Literal_a0;
        DAST._ILiteral _source22 = _422___mcc_h0;
        if (_source22.is_BoolLiteral) {
          bool _423___mcc_h1 = _source22.dtor_BoolLiteral_a0;
          if ((_423___mcc_h1) == (false)) {
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
        } else if (_source22.is_IntLiteral) {
          Dafny.ISequence<Dafny.Rune> _424___mcc_h2 = _source22.dtor_IntLiteral_a0;
          DAST._IType _425___mcc_h3 = _source22.dtor_IntLiteral_a1;
          DAST._IType _426_t = _425___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _427_i = _424___mcc_h2;
          {
            DAST._IType _source23 = _426_t;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _428___mcc_h188 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _429___mcc_h189 = _source23.dtor_typeArgs;
              DAST._IResolvedType _430___mcc_h190 = _source23.dtor_resolved;
              {
                s = _427_i;
              }
            } else if (_source23.is_Nullable) {
              DAST._IType _431___mcc_h194 = _source23.dtor_Nullable_a0;
              {
                s = _427_i;
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _432___mcc_h196 = _source23.dtor_Tuple_a0;
              {
                s = _427_i;
              }
            } else if (_source23.is_Array) {
              DAST._IType _433___mcc_h198 = _source23.dtor_element;
              {
                s = _427_i;
              }
            } else if (_source23.is_Seq) {
              DAST._IType _434___mcc_h200 = _source23.dtor_element;
              {
                s = _427_i;
              }
            } else if (_source23.is_Set) {
              DAST._IType _435___mcc_h202 = _source23.dtor_element;
              {
                s = _427_i;
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _436___mcc_h204 = _source23.dtor_element;
              {
                s = _427_i;
              }
            } else if (_source23.is_Map) {
              DAST._IType _437___mcc_h206 = _source23.dtor_key;
              DAST._IType _438___mcc_h207 = _source23.dtor_value;
              {
                s = _427_i;
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _439___mcc_h210 = _source23.dtor_args;
              DAST._IType _440___mcc_h211 = _source23.dtor_result;
              {
                s = _427_i;
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _441___mcc_h214 = _source23.dtor_Primitive_a0;
              DAST._IPrimitive _source24 = _441___mcc_h214;
              if (_source24.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _427_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source24.is_Real) {
                {
                  s = _427_i;
                }
              } else if (_source24.is_String) {
                {
                  s = _427_i;
                }
              } else if (_source24.is_Bool) {
                {
                  s = _427_i;
                }
              } else {
                {
                  s = _427_i;
                }
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _442___mcc_h216 = _source23.dtor_Passthrough_a0;
              {
                s = _427_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _443___mcc_h218 = _source23.dtor_TypeArg_a0;
              {
                s = _427_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source22.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _444___mcc_h4 = _source22.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _445___mcc_h5 = _source22.dtor_DecLiteral_a1;
          DAST._IType _446___mcc_h6 = _source22.dtor_DecLiteral_a2;
          DAST._IType _447_t = _446___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _448_d = _445___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _449_n = _444___mcc_h4;
          {
            DAST._IType _source25 = _447_t;
            if (_source25.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _450___mcc_h220 = _source25.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _451___mcc_h221 = _source25.dtor_typeArgs;
              DAST._IResolvedType _452___mcc_h222 = _source25.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Nullable) {
              DAST._IType _453___mcc_h226 = _source25.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Tuple) {
              Dafny.ISequence<DAST._IType> _454___mcc_h228 = _source25.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Array) {
              DAST._IType _455___mcc_h230 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Seq) {
              DAST._IType _456___mcc_h232 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Set) {
              DAST._IType _457___mcc_h234 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Multiset) {
              DAST._IType _458___mcc_h236 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Map) {
              DAST._IType _459___mcc_h238 = _source25.dtor_key;
              DAST._IType _460___mcc_h239 = _source25.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Arrow) {
              Dafny.ISequence<DAST._IType> _461___mcc_h242 = _source25.dtor_args;
              DAST._IType _462___mcc_h243 = _source25.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Primitive) {
              DAST._IPrimitive _463___mcc_h246 = _source25.dtor_Primitive_a0;
              DAST._IPrimitive _source26 = _463___mcc_h246;
              if (_source26.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source26.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _449_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source26.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source26.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source25.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _464___mcc_h248 = _source25.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _465___mcc_h250 = _source25.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_449_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _448_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source22.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _466___mcc_h7 = _source22.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _467_l = _466___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _467_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source22.is_CharLiteral) {
          Dafny.Rune _468___mcc_h8 = _source22.dtor_CharLiteral_a0;
          Dafny.Rune _469_c = _468___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_469_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
      } else if (_source21.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _470___mcc_h9 = _source21.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _471_name = _470___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _471_name);
          if (!((@params).Contains(_471_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_471_name);
        }
      } else if (_source21.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _472___mcc_h10 = _source21.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _473_path = _472___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out122;
          _out122 = DCOMP.COMP.GenPath(_473_path);
          s = _out122;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source21.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _474___mcc_h11 = _source21.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _475_values = _474___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _476_i;
          _476_i = BigInteger.Zero;
          bool _477_allErased;
          _477_allErased = true;
          while ((_476_i) < (new BigInteger((_475_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _478___v29;
            bool _479___v30;
            bool _480_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _481___v31;
            Dafny.ISequence<Dafny.Rune> _out123;
            bool _out124;
            bool _out125;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out126;
            DCOMP.COMP.GenExpr((_475_values).Select(_476_i), selfIdent, @params, true, out _out123, out _out124, out _out125, out _out126);
            _478___v29 = _out123;
            _479___v30 = _out124;
            _480_isErased = _out125;
            _481___v31 = _out126;
            _477_allErased = (_477_allErased) && (_480_isErased);
            _476_i = (_476_i) + (BigInteger.One);
          }
          _476_i = BigInteger.Zero;
          while ((_476_i) < (new BigInteger((_475_values).Count))) {
            if ((_476_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _482_recursiveGen;
            bool _483___v32;
            bool _484_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _485_recIdents;
            Dafny.ISequence<Dafny.Rune> _out127;
            bool _out128;
            bool _out129;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out130;
            DCOMP.COMP.GenExpr((_475_values).Select(_476_i), selfIdent, @params, true, out _out127, out _out128, out _out129, out _out130);
            _482_recursiveGen = _out127;
            _483___v32 = _out128;
            _484_isErased = _out129;
            _485_recIdents = _out130;
            if ((_484_isErased) && (!(_477_allErased))) {
              _482_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _482_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _482_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _485_recIdents);
            _476_i = (_476_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _477_allErased;
        }
      } else if (_source21.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _486___mcc_h12 = _source21.dtor_path;
        Dafny.ISequence<DAST._IExpression> _487___mcc_h13 = _source21.dtor_args;
        Dafny.ISequence<DAST._IExpression> _488_args = _487___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _489_path = _486___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _490_path;
          Dafny.ISequence<Dafny.Rune> _out131;
          _out131 = DCOMP.COMP.GenPath(_489_path);
          _490_path = _out131;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _490_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _491_i;
          _491_i = BigInteger.Zero;
          while ((_491_i) < (new BigInteger((_488_args).Count))) {
            if ((_491_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _492_recursiveGen;
            bool _493___v33;
            bool _494_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _495_recIdents;
            Dafny.ISequence<Dafny.Rune> _out132;
            bool _out133;
            bool _out134;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out135;
            DCOMP.COMP.GenExpr((_488_args).Select(_491_i), selfIdent, @params, true, out _out132, out _out133, out _out134, out _out135);
            _492_recursiveGen = _out132;
            _493___v33 = _out133;
            _494_isErased = _out134;
            _495_recIdents = _out135;
            if (_494_isErased) {
              _492_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _492_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _495_recIdents);
            _491_i = (_491_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _496___mcc_h14 = _source21.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _497_dims = _496___mcc_h14;
        {
          BigInteger _498_i;
          _498_i = (new BigInteger((_497_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_498_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _499_recursiveGen;
            bool _500___v34;
            bool _501_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _502_recIdents;
            Dafny.ISequence<Dafny.Rune> _out136;
            bool _out137;
            bool _out138;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out139;
            DCOMP.COMP.GenExpr((_497_dims).Select(_498_i), selfIdent, @params, true, out _out136, out _out137, out _out138, out _out139);
            _499_recursiveGen = _out136;
            _500___v34 = _out137;
            _501_isErased = _out138;
            _502_recIdents = _out139;
            if (!(_501_isErased)) {
              _499_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _499_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _499_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _502_recIdents);
            _498_i = (_498_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _503___mcc_h15 = _source21.dtor_path;
        Dafny.ISequence<Dafny.Rune> _504___mcc_h16 = _source21.dtor_variant;
        bool _505___mcc_h17 = _source21.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _506___mcc_h18 = _source21.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _507_values = _506___mcc_h18;
        bool _508_isCo = _505___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _509_variant = _504___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _510_path = _503___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _511_path;
          Dafny.ISequence<Dafny.Rune> _out140;
          _out140 = DCOMP.COMP.GenPath(_510_path);
          _511_path = _out140;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _511_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _509_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _512_i;
          _512_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_512_i) < (new BigInteger((_507_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_507_values).Select(_512_i);
            Dafny.ISequence<Dafny.Rune> _513_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _514_value = _let_tmp_rhs0.dtor__1;
            if ((_512_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_508_isCo) {
              Dafny.ISequence<Dafny.Rune> _515_recursiveGen;
              bool _516___v35;
              bool _517_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _518_recIdents;
              Dafny.ISequence<Dafny.Rune> _out141;
              bool _out142;
              bool _out143;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out144;
              DCOMP.COMP.GenExpr(_514_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out141, out _out142, out _out143, out _out144);
              _515_recursiveGen = _out141;
              _516___v35 = _out142;
              _517_isErased = _out143;
              _518_recIdents = _out144;
              if (!(_517_isErased)) {
                _515_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _515_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _515_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _515_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _518_recIdents);
              Dafny.ISequence<Dafny.Rune> _519_allReadCloned;
              _519_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_518_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _520_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_518_recIdents).Elements) {
                  _520_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_518_recIdents).Contains(_520_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1178)");
              after__ASSIGN_SUCH_THAT_0:;
                _519_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_519_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _520_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _520_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _518_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_518_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_520_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _513_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _519_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _515_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _521_recursiveGen;
              bool _522___v36;
              bool _523_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _524_recIdents;
              Dafny.ISequence<Dafny.Rune> _out145;
              bool _out146;
              bool _out147;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
              DCOMP.COMP.GenExpr(_514_value, selfIdent, @params, true, out _out145, out _out146, out _out147, out _out148);
              _521_recursiveGen = _out145;
              _522___v36 = _out146;
              _523_isErased = _out147;
              _524_recIdents = _out148;
              if (!(_523_isErased)) {
                _521_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _521_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _521_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _521_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _513_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _521_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _524_recIdents);
            }
            _512_i = (_512_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_Convert) {
        DAST._IExpression _525___mcc_h19 = _source21.dtor_value;
        DAST._IType _526___mcc_h20 = _source21.dtor_from;
        DAST._IType _527___mcc_h21 = _source21.dtor_typ;
        DAST._IType _528_toTpe = _527___mcc_h21;
        DAST._IType _529_fromTpe = _526___mcc_h20;
        DAST._IExpression _530_expr = _525___mcc_h19;
        {
          if (object.Equals(_529_fromTpe, _528_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _531_recursiveGen;
            bool _532_recOwned;
            bool _533_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _534_recIdents;
            Dafny.ISequence<Dafny.Rune> _out149;
            bool _out150;
            bool _out151;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
            DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out149, out _out150, out _out151, out _out152);
            _531_recursiveGen = _out149;
            _532_recOwned = _out150;
            _533_recErased = _out151;
            _534_recIdents = _out152;
            s = _531_recursiveGen;
            isOwned = _532_recOwned;
            isErased = _533_recErased;
            readIdents = _534_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source27 = _System.Tuple2<DAST._IType, DAST._IType>.create(_529_fromTpe, _528_toTpe);
            DAST._IType _535___mcc_h252 = _source27.dtor__0;
            DAST._IType _536___mcc_h253 = _source27.dtor__1;
            DAST._IType _source28 = _535___mcc_h252;
            if (_source28.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _537___mcc_h256 = _source28.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _538___mcc_h257 = _source28.dtor_typeArgs;
              DAST._IResolvedType _539___mcc_h258 = _source28.dtor_resolved;
              DAST._IResolvedType _source29 = _539___mcc_h258;
              if (_source29.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _540___mcc_h268 = _source29.dtor_path;
                DAST._IType _source30 = _536___mcc_h253;
                if (_source30.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _541___mcc_h272 = _source30.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _542___mcc_h273 = _source30.dtor_typeArgs;
                  DAST._IResolvedType _543___mcc_h274 = _source30.dtor_resolved;
                  DAST._IResolvedType _source31 = _543___mcc_h274;
                  if (_source31.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _544___mcc_h278 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _545_recursiveGen;
                      bool _546_recOwned;
                      bool _547_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _548_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out153;
                      bool _out154;
                      bool _out155;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out153, out _out154, out _out155, out _out156);
                      _545_recursiveGen = _out153;
                      _546_recOwned = _out154;
                      _547_recErased = _out155;
                      _548_recIdents = _out156;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _545_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _546_recOwned;
                      isErased = _547_recErased;
                      readIdents = _548_recIdents;
                    }
                  } else if (_source31.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _549___mcc_h280 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _550_recursiveGen;
                      bool _551_recOwned;
                      bool _552_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _553_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out157;
                      bool _out158;
                      bool _out159;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out160;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out157, out _out158, out _out159, out _out160);
                      _550_recursiveGen = _out157;
                      _551_recOwned = _out158;
                      _552_recErased = _out159;
                      _553_recIdents = _out160;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _550_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _551_recOwned;
                      isErased = _552_recErased;
                      readIdents = _553_recIdents;
                    }
                  } else {
                    DAST._IType _554___mcc_h282 = _source31.dtor_Newtype_a0;
                    DAST._IType _555_b = _554___mcc_h282;
                    {
                      if (object.Equals(_529_fromTpe, _555_b)) {
                        Dafny.ISequence<Dafny.Rune> _556_recursiveGen;
                        bool _557_recOwned;
                        bool _558_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _559_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out161;
                        bool _out162;
                        bool _out163;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out164;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out161, out _out162, out _out163, out _out164);
                        _556_recursiveGen = _out161;
                        _557_recOwned = _out162;
                        _558_recErased = _out163;
                        _559_recIdents = _out164;
                        Dafny.ISequence<Dafny.Rune> _560_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out165;
                        _out165 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                        _560_rhsType = _out165;
                        Dafny.ISequence<Dafny.Rune> _561_uneraseFn;
                        _561_uneraseFn = ((_557_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _560_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _561_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _556_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _557_recOwned;
                        isErased = false;
                        readIdents = _559_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out166;
                        bool _out167;
                        bool _out168;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out169;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _555_b), _555_b, _528_toTpe), selfIdent, @params, mustOwn, out _out166, out _out167, out _out168, out _out169);
                        s = _out166;
                        isOwned = _out167;
                        isErased = _out168;
                        readIdents = _out169;
                      }
                    }
                  }
                } else if (_source30.is_Nullable) {
                  DAST._IType _562___mcc_h284 = _source30.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _563_recursiveGen;
                    bool _564_recOwned;
                    bool _565_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _566_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out170;
                    bool _out171;
                    bool _out172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out173;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out170, out _out171, out _out172, out _out173);
                    _563_recursiveGen = _out170;
                    _564_recOwned = _out171;
                    _565_recErased = _out172;
                    _566_recIdents = _out173;
                    if (!(_564_recOwned)) {
                      _563_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_563_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _563_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _565_recErased;
                    readIdents = _566_recIdents;
                  }
                } else if (_source30.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _567___mcc_h286 = _source30.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _568_recursiveGen;
                    bool _569_recOwned;
                    bool _570_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _571_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out174;
                    bool _out175;
                    bool _out176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out177;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out174, out _out175, out _out176, out _out177);
                    _568_recursiveGen = _out174;
                    _569_recOwned = _out175;
                    _570_recErased = _out176;
                    _571_recIdents = _out177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _568_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _569_recOwned;
                    isErased = _570_recErased;
                    readIdents = _571_recIdents;
                  }
                } else if (_source30.is_Array) {
                  DAST._IType _572___mcc_h288 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _573_recursiveGen;
                    bool _574_recOwned;
                    bool _575_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _576_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out178;
                    bool _out179;
                    bool _out180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out181;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out178, out _out179, out _out180, out _out181);
                    _573_recursiveGen = _out178;
                    _574_recOwned = _out179;
                    _575_recErased = _out180;
                    _576_recIdents = _out181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _573_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _574_recOwned;
                    isErased = _575_recErased;
                    readIdents = _576_recIdents;
                  }
                } else if (_source30.is_Seq) {
                  DAST._IType _577___mcc_h290 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _578_recursiveGen;
                    bool _579_recOwned;
                    bool _580_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _581_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out182;
                    bool _out183;
                    bool _out184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out185;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out182, out _out183, out _out184, out _out185);
                    _578_recursiveGen = _out182;
                    _579_recOwned = _out183;
                    _580_recErased = _out184;
                    _581_recIdents = _out185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _578_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _579_recOwned;
                    isErased = _580_recErased;
                    readIdents = _581_recIdents;
                  }
                } else if (_source30.is_Set) {
                  DAST._IType _582___mcc_h292 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _583_recursiveGen;
                    bool _584_recOwned;
                    bool _585_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _586_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out186;
                    bool _out187;
                    bool _out188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out189;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out186, out _out187, out _out188, out _out189);
                    _583_recursiveGen = _out186;
                    _584_recOwned = _out187;
                    _585_recErased = _out188;
                    _586_recIdents = _out189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _583_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _584_recOwned;
                    isErased = _585_recErased;
                    readIdents = _586_recIdents;
                  }
                } else if (_source30.is_Multiset) {
                  DAST._IType _587___mcc_h294 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _588_recursiveGen;
                    bool _589_recOwned;
                    bool _590_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _591_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out190;
                    bool _out191;
                    bool _out192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out193;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out190, out _out191, out _out192, out _out193);
                    _588_recursiveGen = _out190;
                    _589_recOwned = _out191;
                    _590_recErased = _out192;
                    _591_recIdents = _out193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _588_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _589_recOwned;
                    isErased = _590_recErased;
                    readIdents = _591_recIdents;
                  }
                } else if (_source30.is_Map) {
                  DAST._IType _592___mcc_h296 = _source30.dtor_key;
                  DAST._IType _593___mcc_h297 = _source30.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _594_recursiveGen;
                    bool _595_recOwned;
                    bool _596_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _597_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out194;
                    bool _out195;
                    bool _out196;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out197;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out194, out _out195, out _out196, out _out197);
                    _594_recursiveGen = _out194;
                    _595_recOwned = _out195;
                    _596_recErased = _out196;
                    _597_recIdents = _out197;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _594_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _595_recOwned;
                    isErased = _596_recErased;
                    readIdents = _597_recIdents;
                  }
                } else if (_source30.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _598___mcc_h300 = _source30.dtor_args;
                  DAST._IType _599___mcc_h301 = _source30.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _600_recursiveGen;
                    bool _601_recOwned;
                    bool _602_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _603_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out198;
                    bool _out199;
                    bool _out200;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out198, out _out199, out _out200, out _out201);
                    _600_recursiveGen = _out198;
                    _601_recOwned = _out199;
                    _602_recErased = _out200;
                    _603_recIdents = _out201;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _600_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _601_recOwned;
                    isErased = _602_recErased;
                    readIdents = _603_recIdents;
                  }
                } else if (_source30.is_Primitive) {
                  DAST._IPrimitive _604___mcc_h304 = _source30.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _605_recursiveGen;
                    bool _606_recOwned;
                    bool _607_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _608_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out202;
                    bool _out203;
                    bool _out204;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out202, out _out203, out _out204, out _out205);
                    _605_recursiveGen = _out202;
                    _606_recOwned = _out203;
                    _607_recErased = _out204;
                    _608_recIdents = _out205;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _605_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _606_recOwned;
                    isErased = _607_recErased;
                    readIdents = _608_recIdents;
                  }
                } else if (_source30.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _609___mcc_h306 = _source30.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _610_recursiveGen;
                    bool _611_recOwned;
                    bool _612_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _613_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out206;
                    bool _out207;
                    bool _out208;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out206, out _out207, out _out208, out _out209);
                    _610_recursiveGen = _out206;
                    _611_recOwned = _out207;
                    _612_recErased = _out208;
                    _613_recIdents = _out209;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _610_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _611_recOwned;
                    isErased = _612_recErased;
                    readIdents = _613_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _614___mcc_h308 = _source30.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _615_recursiveGen;
                    bool _616_recOwned;
                    bool _617_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _618_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out210;
                    bool _out211;
                    bool _out212;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out210, out _out211, out _out212, out _out213);
                    _615_recursiveGen = _out210;
                    _616_recOwned = _out211;
                    _617_recErased = _out212;
                    _618_recIdents = _out213;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _615_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _616_recOwned;
                    isErased = _617_recErased;
                    readIdents = _618_recIdents;
                  }
                }
              } else if (_source29.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _619___mcc_h310 = _source29.dtor_path;
                DAST._IType _source32 = _536___mcc_h253;
                if (_source32.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _620___mcc_h314 = _source32.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _621___mcc_h315 = _source32.dtor_typeArgs;
                  DAST._IResolvedType _622___mcc_h316 = _source32.dtor_resolved;
                  DAST._IResolvedType _source33 = _622___mcc_h316;
                  if (_source33.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _623___mcc_h320 = _source33.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _624_recursiveGen;
                      bool _625_recOwned;
                      bool _626_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _627_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out214;
                      bool _out215;
                      bool _out216;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out214, out _out215, out _out216, out _out217);
                      _624_recursiveGen = _out214;
                      _625_recOwned = _out215;
                      _626_recErased = _out216;
                      _627_recIdents = _out217;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _624_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _625_recOwned;
                      isErased = _626_recErased;
                      readIdents = _627_recIdents;
                    }
                  } else if (_source33.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _628___mcc_h322 = _source33.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _629_recursiveGen;
                      bool _630_recOwned;
                      bool _631_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _632_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out218;
                      bool _out219;
                      bool _out220;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out221;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out218, out _out219, out _out220, out _out221);
                      _629_recursiveGen = _out218;
                      _630_recOwned = _out219;
                      _631_recErased = _out220;
                      _632_recIdents = _out221;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _629_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _630_recOwned;
                      isErased = _631_recErased;
                      readIdents = _632_recIdents;
                    }
                  } else {
                    DAST._IType _633___mcc_h324 = _source33.dtor_Newtype_a0;
                    DAST._IType _634_b = _633___mcc_h324;
                    {
                      if (object.Equals(_529_fromTpe, _634_b)) {
                        Dafny.ISequence<Dafny.Rune> _635_recursiveGen;
                        bool _636_recOwned;
                        bool _637_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _638_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out222;
                        bool _out223;
                        bool _out224;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out225;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out222, out _out223, out _out224, out _out225);
                        _635_recursiveGen = _out222;
                        _636_recOwned = _out223;
                        _637_recErased = _out224;
                        _638_recIdents = _out225;
                        Dafny.ISequence<Dafny.Rune> _639_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out226;
                        _out226 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                        _639_rhsType = _out226;
                        Dafny.ISequence<Dafny.Rune> _640_uneraseFn;
                        _640_uneraseFn = ((_636_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _639_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _640_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _635_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _636_recOwned;
                        isErased = false;
                        readIdents = _638_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out227;
                        bool _out228;
                        bool _out229;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out230;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _634_b), _634_b, _528_toTpe), selfIdent, @params, mustOwn, out _out227, out _out228, out _out229, out _out230);
                        s = _out227;
                        isOwned = _out228;
                        isErased = _out229;
                        readIdents = _out230;
                      }
                    }
                  }
                } else if (_source32.is_Nullable) {
                  DAST._IType _641___mcc_h326 = _source32.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _642_recursiveGen;
                    bool _643_recOwned;
                    bool _644_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _645_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out231;
                    bool _out232;
                    bool _out233;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out234;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out231, out _out232, out _out233, out _out234);
                    _642_recursiveGen = _out231;
                    _643_recOwned = _out232;
                    _644_recErased = _out233;
                    _645_recIdents = _out234;
                    if (!(_643_recOwned)) {
                      _642_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_642_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _642_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _644_recErased;
                    readIdents = _645_recIdents;
                  }
                } else if (_source32.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _646___mcc_h328 = _source32.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _647_recursiveGen;
                    bool _648_recOwned;
                    bool _649_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _650_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out235;
                    bool _out236;
                    bool _out237;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out238;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out235, out _out236, out _out237, out _out238);
                    _647_recursiveGen = _out235;
                    _648_recOwned = _out236;
                    _649_recErased = _out237;
                    _650_recIdents = _out238;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _647_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _648_recOwned;
                    isErased = _649_recErased;
                    readIdents = _650_recIdents;
                  }
                } else if (_source32.is_Array) {
                  DAST._IType _651___mcc_h330 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _652_recursiveGen;
                    bool _653_recOwned;
                    bool _654_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _655_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out239;
                    bool _out240;
                    bool _out241;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out242;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out239, out _out240, out _out241, out _out242);
                    _652_recursiveGen = _out239;
                    _653_recOwned = _out240;
                    _654_recErased = _out241;
                    _655_recIdents = _out242;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _652_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _653_recOwned;
                    isErased = _654_recErased;
                    readIdents = _655_recIdents;
                  }
                } else if (_source32.is_Seq) {
                  DAST._IType _656___mcc_h332 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _657_recursiveGen;
                    bool _658_recOwned;
                    bool _659_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _660_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out243;
                    bool _out244;
                    bool _out245;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out246;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out243, out _out244, out _out245, out _out246);
                    _657_recursiveGen = _out243;
                    _658_recOwned = _out244;
                    _659_recErased = _out245;
                    _660_recIdents = _out246;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _657_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _658_recOwned;
                    isErased = _659_recErased;
                    readIdents = _660_recIdents;
                  }
                } else if (_source32.is_Set) {
                  DAST._IType _661___mcc_h334 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _662_recursiveGen;
                    bool _663_recOwned;
                    bool _664_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _665_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out247;
                    bool _out248;
                    bool _out249;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out250;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out247, out _out248, out _out249, out _out250);
                    _662_recursiveGen = _out247;
                    _663_recOwned = _out248;
                    _664_recErased = _out249;
                    _665_recIdents = _out250;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _662_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _663_recOwned;
                    isErased = _664_recErased;
                    readIdents = _665_recIdents;
                  }
                } else if (_source32.is_Multiset) {
                  DAST._IType _666___mcc_h336 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _667_recursiveGen;
                    bool _668_recOwned;
                    bool _669_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _670_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out251;
                    bool _out252;
                    bool _out253;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out251, out _out252, out _out253, out _out254);
                    _667_recursiveGen = _out251;
                    _668_recOwned = _out252;
                    _669_recErased = _out253;
                    _670_recIdents = _out254;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _667_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _668_recOwned;
                    isErased = _669_recErased;
                    readIdents = _670_recIdents;
                  }
                } else if (_source32.is_Map) {
                  DAST._IType _671___mcc_h338 = _source32.dtor_key;
                  DAST._IType _672___mcc_h339 = _source32.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _673_recursiveGen;
                    bool _674_recOwned;
                    bool _675_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _676_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out255;
                    bool _out256;
                    bool _out257;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out255, out _out256, out _out257, out _out258);
                    _673_recursiveGen = _out255;
                    _674_recOwned = _out256;
                    _675_recErased = _out257;
                    _676_recIdents = _out258;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _673_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _674_recOwned;
                    isErased = _675_recErased;
                    readIdents = _676_recIdents;
                  }
                } else if (_source32.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _677___mcc_h342 = _source32.dtor_args;
                  DAST._IType _678___mcc_h343 = _source32.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _679_recursiveGen;
                    bool _680_recOwned;
                    bool _681_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _682_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out259;
                    bool _out260;
                    bool _out261;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out259, out _out260, out _out261, out _out262);
                    _679_recursiveGen = _out259;
                    _680_recOwned = _out260;
                    _681_recErased = _out261;
                    _682_recIdents = _out262;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _679_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _680_recOwned;
                    isErased = _681_recErased;
                    readIdents = _682_recIdents;
                  }
                } else if (_source32.is_Primitive) {
                  DAST._IPrimitive _683___mcc_h346 = _source32.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _684_recursiveGen;
                    bool _685_recOwned;
                    bool _686_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _687_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out263;
                    bool _out264;
                    bool _out265;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out263, out _out264, out _out265, out _out266);
                    _684_recursiveGen = _out263;
                    _685_recOwned = _out264;
                    _686_recErased = _out265;
                    _687_recIdents = _out266;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _684_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _685_recOwned;
                    isErased = _686_recErased;
                    readIdents = _687_recIdents;
                  }
                } else if (_source32.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _688___mcc_h348 = _source32.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _689_recursiveGen;
                    bool _690_recOwned;
                    bool _691_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _692_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out267;
                    bool _out268;
                    bool _out269;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out267, out _out268, out _out269, out _out270);
                    _689_recursiveGen = _out267;
                    _690_recOwned = _out268;
                    _691_recErased = _out269;
                    _692_recIdents = _out270;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _689_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _690_recOwned;
                    isErased = _691_recErased;
                    readIdents = _692_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _693___mcc_h350 = _source32.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _694_recursiveGen;
                    bool _695_recOwned;
                    bool _696_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _697_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out271;
                    bool _out272;
                    bool _out273;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out271, out _out272, out _out273, out _out274);
                    _694_recursiveGen = _out271;
                    _695_recOwned = _out272;
                    _696_recErased = _out273;
                    _697_recIdents = _out274;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _694_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _695_recOwned;
                    isErased = _696_recErased;
                    readIdents = _697_recIdents;
                  }
                }
              } else {
                DAST._IType _698___mcc_h352 = _source29.dtor_Newtype_a0;
                DAST._IType _source34 = _536___mcc_h253;
                if (_source34.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _699___mcc_h356 = _source34.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _700___mcc_h357 = _source34.dtor_typeArgs;
                  DAST._IResolvedType _701___mcc_h358 = _source34.dtor_resolved;
                  DAST._IResolvedType _source35 = _701___mcc_h358;
                  if (_source35.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _702___mcc_h365 = _source35.dtor_path;
                    DAST._IType _703_b = _698___mcc_h352;
                    {
                      if (object.Equals(_703_b, _528_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _704_recursiveGen;
                        bool _705_recOwned;
                        bool _706_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _707_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out275;
                        bool _out276;
                        bool _out277;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out275, out _out276, out _out277, out _out278);
                        _704_recursiveGen = _out275;
                        _705_recOwned = _out276;
                        _706_recErased = _out277;
                        _707_recIdents = _out278;
                        Dafny.ISequence<Dafny.Rune> _708_uneraseFn;
                        _708_uneraseFn = ((_705_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _708_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _704_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _705_recOwned;
                        isErased = true;
                        readIdents = _707_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out279;
                        bool _out280;
                        bool _out281;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _703_b), _703_b, _528_toTpe), selfIdent, @params, mustOwn, out _out279, out _out280, out _out281, out _out282);
                        s = _out279;
                        isOwned = _out280;
                        isErased = _out281;
                        readIdents = _out282;
                      }
                    }
                  } else if (_source35.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _709___mcc_h368 = _source35.dtor_path;
                    DAST._IType _710_b = _698___mcc_h352;
                    {
                      if (object.Equals(_710_b, _528_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _711_recursiveGen;
                        bool _712_recOwned;
                        bool _713_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _714_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out283;
                        bool _out284;
                        bool _out285;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out283, out _out284, out _out285, out _out286);
                        _711_recursiveGen = _out283;
                        _712_recOwned = _out284;
                        _713_recErased = _out285;
                        _714_recIdents = _out286;
                        Dafny.ISequence<Dafny.Rune> _715_uneraseFn;
                        _715_uneraseFn = ((_712_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _715_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _711_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _712_recOwned;
                        isErased = true;
                        readIdents = _714_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out287;
                        bool _out288;
                        bool _out289;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out290;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _710_b), _710_b, _528_toTpe), selfIdent, @params, mustOwn, out _out287, out _out288, out _out289, out _out290);
                        s = _out287;
                        isOwned = _out288;
                        isErased = _out289;
                        readIdents = _out290;
                      }
                    }
                  } else {
                    DAST._IType _716___mcc_h371 = _source35.dtor_Newtype_a0;
                    DAST._IType _717_b = _716___mcc_h371;
                    {
                      if (object.Equals(_529_fromTpe, _717_b)) {
                        Dafny.ISequence<Dafny.Rune> _718_recursiveGen;
                        bool _719_recOwned;
                        bool _720_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _721_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out291;
                        bool _out292;
                        bool _out293;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out294;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out291, out _out292, out _out293, out _out294);
                        _718_recursiveGen = _out291;
                        _719_recOwned = _out292;
                        _720_recErased = _out293;
                        _721_recIdents = _out294;
                        Dafny.ISequence<Dafny.Rune> _722_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out295;
                        _out295 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                        _722_rhsType = _out295;
                        Dafny.ISequence<Dafny.Rune> _723_uneraseFn;
                        _723_uneraseFn = ((_719_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _722_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _723_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _718_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _719_recOwned;
                        isErased = false;
                        readIdents = _721_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out296;
                        bool _out297;
                        bool _out298;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out299;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _717_b), _717_b, _528_toTpe), selfIdent, @params, mustOwn, out _out296, out _out297, out _out298, out _out299);
                        s = _out296;
                        isOwned = _out297;
                        isErased = _out298;
                        readIdents = _out299;
                      }
                    }
                  }
                } else if (_source34.is_Nullable) {
                  DAST._IType _724___mcc_h374 = _source34.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _725_recursiveGen;
                    bool _726_recOwned;
                    bool _727_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _728_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out300;
                    bool _out301;
                    bool _out302;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out303;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out300, out _out301, out _out302, out _out303);
                    _725_recursiveGen = _out300;
                    _726_recOwned = _out301;
                    _727_recErased = _out302;
                    _728_recIdents = _out303;
                    if (!(_726_recOwned)) {
                      _725_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_725_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _725_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _727_recErased;
                    readIdents = _728_recIdents;
                  }
                } else if (_source34.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _729___mcc_h377 = _source34.dtor_Tuple_a0;
                  DAST._IType _730_b = _698___mcc_h352;
                  {
                    if (object.Equals(_730_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _731_recursiveGen;
                      bool _732_recOwned;
                      bool _733_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _734_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out304;
                      bool _out305;
                      bool _out306;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out304, out _out305, out _out306, out _out307);
                      _731_recursiveGen = _out304;
                      _732_recOwned = _out305;
                      _733_recErased = _out306;
                      _734_recIdents = _out307;
                      Dafny.ISequence<Dafny.Rune> _735_uneraseFn;
                      _735_uneraseFn = ((_732_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _735_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _731_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _732_recOwned;
                      isErased = true;
                      readIdents = _734_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out308;
                      bool _out309;
                      bool _out310;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _730_b), _730_b, _528_toTpe), selfIdent, @params, mustOwn, out _out308, out _out309, out _out310, out _out311);
                      s = _out308;
                      isOwned = _out309;
                      isErased = _out310;
                      readIdents = _out311;
                    }
                  }
                } else if (_source34.is_Array) {
                  DAST._IType _736___mcc_h380 = _source34.dtor_element;
                  DAST._IType _737_b = _698___mcc_h352;
                  {
                    if (object.Equals(_737_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _738_recursiveGen;
                      bool _739_recOwned;
                      bool _740_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _741_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out312;
                      bool _out313;
                      bool _out314;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out312, out _out313, out _out314, out _out315);
                      _738_recursiveGen = _out312;
                      _739_recOwned = _out313;
                      _740_recErased = _out314;
                      _741_recIdents = _out315;
                      Dafny.ISequence<Dafny.Rune> _742_uneraseFn;
                      _742_uneraseFn = ((_739_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _742_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _738_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _739_recOwned;
                      isErased = true;
                      readIdents = _741_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out316;
                      bool _out317;
                      bool _out318;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _737_b), _737_b, _528_toTpe), selfIdent, @params, mustOwn, out _out316, out _out317, out _out318, out _out319);
                      s = _out316;
                      isOwned = _out317;
                      isErased = _out318;
                      readIdents = _out319;
                    }
                  }
                } else if (_source34.is_Seq) {
                  DAST._IType _743___mcc_h383 = _source34.dtor_element;
                  DAST._IType _744_b = _698___mcc_h352;
                  {
                    if (object.Equals(_744_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _745_recursiveGen;
                      bool _746_recOwned;
                      bool _747_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _748_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out320;
                      bool _out321;
                      bool _out322;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out320, out _out321, out _out322, out _out323);
                      _745_recursiveGen = _out320;
                      _746_recOwned = _out321;
                      _747_recErased = _out322;
                      _748_recIdents = _out323;
                      Dafny.ISequence<Dafny.Rune> _749_uneraseFn;
                      _749_uneraseFn = ((_746_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _749_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _745_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _746_recOwned;
                      isErased = true;
                      readIdents = _748_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out324;
                      bool _out325;
                      bool _out326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _744_b), _744_b, _528_toTpe), selfIdent, @params, mustOwn, out _out324, out _out325, out _out326, out _out327);
                      s = _out324;
                      isOwned = _out325;
                      isErased = _out326;
                      readIdents = _out327;
                    }
                  }
                } else if (_source34.is_Set) {
                  DAST._IType _750___mcc_h386 = _source34.dtor_element;
                  DAST._IType _751_b = _698___mcc_h352;
                  {
                    if (object.Equals(_751_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _752_recursiveGen;
                      bool _753_recOwned;
                      bool _754_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _755_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out328;
                      bool _out329;
                      bool _out330;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out328, out _out329, out _out330, out _out331);
                      _752_recursiveGen = _out328;
                      _753_recOwned = _out329;
                      _754_recErased = _out330;
                      _755_recIdents = _out331;
                      Dafny.ISequence<Dafny.Rune> _756_uneraseFn;
                      _756_uneraseFn = ((_753_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _756_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _752_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _753_recOwned;
                      isErased = true;
                      readIdents = _755_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out332;
                      bool _out333;
                      bool _out334;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _751_b), _751_b, _528_toTpe), selfIdent, @params, mustOwn, out _out332, out _out333, out _out334, out _out335);
                      s = _out332;
                      isOwned = _out333;
                      isErased = _out334;
                      readIdents = _out335;
                    }
                  }
                } else if (_source34.is_Multiset) {
                  DAST._IType _757___mcc_h389 = _source34.dtor_element;
                  DAST._IType _758_b = _698___mcc_h352;
                  {
                    if (object.Equals(_758_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _759_recursiveGen;
                      bool _760_recOwned;
                      bool _761_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _762_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out336;
                      bool _out337;
                      bool _out338;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out336, out _out337, out _out338, out _out339);
                      _759_recursiveGen = _out336;
                      _760_recOwned = _out337;
                      _761_recErased = _out338;
                      _762_recIdents = _out339;
                      Dafny.ISequence<Dafny.Rune> _763_uneraseFn;
                      _763_uneraseFn = ((_760_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _763_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _760_recOwned;
                      isErased = true;
                      readIdents = _762_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out340;
                      bool _out341;
                      bool _out342;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _758_b), _758_b, _528_toTpe), selfIdent, @params, mustOwn, out _out340, out _out341, out _out342, out _out343);
                      s = _out340;
                      isOwned = _out341;
                      isErased = _out342;
                      readIdents = _out343;
                    }
                  }
                } else if (_source34.is_Map) {
                  DAST._IType _764___mcc_h392 = _source34.dtor_key;
                  DAST._IType _765___mcc_h393 = _source34.dtor_value;
                  DAST._IType _766_b = _698___mcc_h352;
                  {
                    if (object.Equals(_766_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _767_recursiveGen;
                      bool _768_recOwned;
                      bool _769_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _770_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out344;
                      bool _out345;
                      bool _out346;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out344, out _out345, out _out346, out _out347);
                      _767_recursiveGen = _out344;
                      _768_recOwned = _out345;
                      _769_recErased = _out346;
                      _770_recIdents = _out347;
                      Dafny.ISequence<Dafny.Rune> _771_uneraseFn;
                      _771_uneraseFn = ((_768_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _771_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _767_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _768_recOwned;
                      isErased = true;
                      readIdents = _770_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out348;
                      bool _out349;
                      bool _out350;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _766_b), _766_b, _528_toTpe), selfIdent, @params, mustOwn, out _out348, out _out349, out _out350, out _out351);
                      s = _out348;
                      isOwned = _out349;
                      isErased = _out350;
                      readIdents = _out351;
                    }
                  }
                } else if (_source34.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _772___mcc_h398 = _source34.dtor_args;
                  DAST._IType _773___mcc_h399 = _source34.dtor_result;
                  DAST._IType _774_b = _698___mcc_h352;
                  {
                    if (object.Equals(_774_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _775_recursiveGen;
                      bool _776_recOwned;
                      bool _777_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _778_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out352;
                      bool _out353;
                      bool _out354;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out352, out _out353, out _out354, out _out355);
                      _775_recursiveGen = _out352;
                      _776_recOwned = _out353;
                      _777_recErased = _out354;
                      _778_recIdents = _out355;
                      Dafny.ISequence<Dafny.Rune> _779_uneraseFn;
                      _779_uneraseFn = ((_776_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _779_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _775_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _776_recOwned;
                      isErased = true;
                      readIdents = _778_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out356;
                      bool _out357;
                      bool _out358;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out359;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _774_b), _774_b, _528_toTpe), selfIdent, @params, mustOwn, out _out356, out _out357, out _out358, out _out359);
                      s = _out356;
                      isOwned = _out357;
                      isErased = _out358;
                      readIdents = _out359;
                    }
                  }
                } else if (_source34.is_Primitive) {
                  DAST._IPrimitive _780___mcc_h404 = _source34.dtor_Primitive_a0;
                  DAST._IType _781_b = _698___mcc_h352;
                  {
                    if (object.Equals(_781_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _782_recursiveGen;
                      bool _783_recOwned;
                      bool _784_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _785_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out360;
                      bool _out361;
                      bool _out362;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out363;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out360, out _out361, out _out362, out _out363);
                      _782_recursiveGen = _out360;
                      _783_recOwned = _out361;
                      _784_recErased = _out362;
                      _785_recIdents = _out363;
                      Dafny.ISequence<Dafny.Rune> _786_uneraseFn;
                      _786_uneraseFn = ((_783_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _786_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _782_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _783_recOwned;
                      isErased = true;
                      readIdents = _785_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out364;
                      bool _out365;
                      bool _out366;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out367;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _781_b), _781_b, _528_toTpe), selfIdent, @params, mustOwn, out _out364, out _out365, out _out366, out _out367);
                      s = _out364;
                      isOwned = _out365;
                      isErased = _out366;
                      readIdents = _out367;
                    }
                  }
                } else if (_source34.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _787___mcc_h407 = _source34.dtor_Passthrough_a0;
                  DAST._IType _788_b = _698___mcc_h352;
                  {
                    if (object.Equals(_788_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _789_recursiveGen;
                      bool _790_recOwned;
                      bool _791_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _792_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out368;
                      bool _out369;
                      bool _out370;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out371;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out368, out _out369, out _out370, out _out371);
                      _789_recursiveGen = _out368;
                      _790_recOwned = _out369;
                      _791_recErased = _out370;
                      _792_recIdents = _out371;
                      Dafny.ISequence<Dafny.Rune> _793_uneraseFn;
                      _793_uneraseFn = ((_790_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _793_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _789_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _790_recOwned;
                      isErased = true;
                      readIdents = _792_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out372;
                      bool _out373;
                      bool _out374;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out375;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _788_b), _788_b, _528_toTpe), selfIdent, @params, mustOwn, out _out372, out _out373, out _out374, out _out375);
                      s = _out372;
                      isOwned = _out373;
                      isErased = _out374;
                      readIdents = _out375;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _794___mcc_h410 = _source34.dtor_TypeArg_a0;
                  DAST._IType _795_b = _698___mcc_h352;
                  {
                    if (object.Equals(_795_b, _528_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _796_recursiveGen;
                      bool _797_recOwned;
                      bool _798_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _799_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out376;
                      bool _out377;
                      bool _out378;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out379;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out376, out _out377, out _out378, out _out379);
                      _796_recursiveGen = _out376;
                      _797_recOwned = _out377;
                      _798_recErased = _out378;
                      _799_recIdents = _out379;
                      Dafny.ISequence<Dafny.Rune> _800_uneraseFn;
                      _800_uneraseFn = ((_797_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _800_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _796_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _797_recOwned;
                      isErased = true;
                      readIdents = _799_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out380;
                      bool _out381;
                      bool _out382;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out383;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _795_b), _795_b, _528_toTpe), selfIdent, @params, mustOwn, out _out380, out _out381, out _out382, out _out383);
                      s = _out380;
                      isOwned = _out381;
                      isErased = _out382;
                      readIdents = _out383;
                    }
                  }
                }
              }
            } else if (_source28.is_Nullable) {
              DAST._IType _801___mcc_h413 = _source28.dtor_Nullable_a0;
              DAST._IType _source36 = _536___mcc_h253;
              if (_source36.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _802___mcc_h417 = _source36.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _803___mcc_h418 = _source36.dtor_typeArgs;
                DAST._IResolvedType _804___mcc_h419 = _source36.dtor_resolved;
                DAST._IResolvedType _source37 = _804___mcc_h419;
                if (_source37.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _805___mcc_h426 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _806_recursiveGen;
                    bool _807_recOwned;
                    bool _808_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _809_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out384;
                    bool _out385;
                    bool _out386;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out387;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out384, out _out385, out _out386, out _out387);
                    _806_recursiveGen = _out384;
                    _807_recOwned = _out385;
                    _808_recErased = _out386;
                    _809_recIdents = _out387;
                    if (!(_807_recOwned)) {
                      _806_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_806_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_806_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _807_recOwned;
                    isErased = _808_recErased;
                    readIdents = _809_recIdents;
                  }
                } else if (_source37.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _810___mcc_h429 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _811_recursiveGen;
                    bool _812_recOwned;
                    bool _813_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _814_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out388;
                    bool _out389;
                    bool _out390;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out391;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out388, out _out389, out _out390, out _out391);
                    _811_recursiveGen = _out388;
                    _812_recOwned = _out389;
                    _813_recErased = _out390;
                    _814_recIdents = _out391;
                    if (!(_812_recOwned)) {
                      _811_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_811_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_811_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _812_recOwned;
                    isErased = _813_recErased;
                    readIdents = _814_recIdents;
                  }
                } else {
                  DAST._IType _815___mcc_h432 = _source37.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _816_recursiveGen;
                    bool _817_recOwned;
                    bool _818_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _819_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out392;
                    bool _out393;
                    bool _out394;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out395;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out392, out _out393, out _out394, out _out395);
                    _816_recursiveGen = _out392;
                    _817_recOwned = _out393;
                    _818_recErased = _out394;
                    _819_recIdents = _out395;
                    if (!(_817_recOwned)) {
                      _816_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_816_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_816_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _817_recOwned;
                    isErased = _818_recErased;
                    readIdents = _819_recIdents;
                  }
                }
              } else if (_source36.is_Nullable) {
                DAST._IType _820___mcc_h435 = _source36.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _821_recursiveGen;
                  bool _822_recOwned;
                  bool _823_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _824_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out396;
                  bool _out397;
                  bool _out398;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out399;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out396, out _out397, out _out398, out _out399);
                  _821_recursiveGen = _out396;
                  _822_recOwned = _out397;
                  _823_recErased = _out398;
                  _824_recIdents = _out399;
                  if (!(_822_recOwned)) {
                    _821_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_821_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_821_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _822_recOwned;
                  isErased = _823_recErased;
                  readIdents = _824_recIdents;
                }
              } else if (_source36.is_Tuple) {
                Dafny.ISequence<DAST._IType> _825___mcc_h438 = _source36.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _826_recursiveGen;
                  bool _827_recOwned;
                  bool _828_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _829_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out400;
                  bool _out401;
                  bool _out402;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out403;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out400, out _out401, out _out402, out _out403);
                  _826_recursiveGen = _out400;
                  _827_recOwned = _out401;
                  _828_recErased = _out402;
                  _829_recIdents = _out403;
                  if (!(_827_recOwned)) {
                    _826_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_826_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_826_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _827_recOwned;
                  isErased = _828_recErased;
                  readIdents = _829_recIdents;
                }
              } else if (_source36.is_Array) {
                DAST._IType _830___mcc_h441 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _831_recursiveGen;
                  bool _832_recOwned;
                  bool _833_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _834_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out404;
                  bool _out405;
                  bool _out406;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out407;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out404, out _out405, out _out406, out _out407);
                  _831_recursiveGen = _out404;
                  _832_recOwned = _out405;
                  _833_recErased = _out406;
                  _834_recIdents = _out407;
                  if (!(_832_recOwned)) {
                    _831_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_831_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_831_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _832_recOwned;
                  isErased = _833_recErased;
                  readIdents = _834_recIdents;
                }
              } else if (_source36.is_Seq) {
                DAST._IType _835___mcc_h444 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _836_recursiveGen;
                  bool _837_recOwned;
                  bool _838_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _839_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out408;
                  bool _out409;
                  bool _out410;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out411;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out408, out _out409, out _out410, out _out411);
                  _836_recursiveGen = _out408;
                  _837_recOwned = _out409;
                  _838_recErased = _out410;
                  _839_recIdents = _out411;
                  if (!(_837_recOwned)) {
                    _836_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_836_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_836_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _837_recOwned;
                  isErased = _838_recErased;
                  readIdents = _839_recIdents;
                }
              } else if (_source36.is_Set) {
                DAST._IType _840___mcc_h447 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _841_recursiveGen;
                  bool _842_recOwned;
                  bool _843_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _844_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out412;
                  bool _out413;
                  bool _out414;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out415;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out412, out _out413, out _out414, out _out415);
                  _841_recursiveGen = _out412;
                  _842_recOwned = _out413;
                  _843_recErased = _out414;
                  _844_recIdents = _out415;
                  if (!(_842_recOwned)) {
                    _841_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_841_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_841_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _842_recOwned;
                  isErased = _843_recErased;
                  readIdents = _844_recIdents;
                }
              } else if (_source36.is_Multiset) {
                DAST._IType _845___mcc_h450 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _846_recursiveGen;
                  bool _847_recOwned;
                  bool _848_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _849_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out416;
                  bool _out417;
                  bool _out418;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out419;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out416, out _out417, out _out418, out _out419);
                  _846_recursiveGen = _out416;
                  _847_recOwned = _out417;
                  _848_recErased = _out418;
                  _849_recIdents = _out419;
                  if (!(_847_recOwned)) {
                    _846_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_846_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_846_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _847_recOwned;
                  isErased = _848_recErased;
                  readIdents = _849_recIdents;
                }
              } else if (_source36.is_Map) {
                DAST._IType _850___mcc_h453 = _source36.dtor_key;
                DAST._IType _851___mcc_h454 = _source36.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _852_recursiveGen;
                  bool _853_recOwned;
                  bool _854_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _855_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out420;
                  bool _out421;
                  bool _out422;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out423;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out420, out _out421, out _out422, out _out423);
                  _852_recursiveGen = _out420;
                  _853_recOwned = _out421;
                  _854_recErased = _out422;
                  _855_recIdents = _out423;
                  if (!(_853_recOwned)) {
                    _852_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_852_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_852_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _853_recOwned;
                  isErased = _854_recErased;
                  readIdents = _855_recIdents;
                }
              } else if (_source36.is_Arrow) {
                Dafny.ISequence<DAST._IType> _856___mcc_h459 = _source36.dtor_args;
                DAST._IType _857___mcc_h460 = _source36.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _858_recursiveGen;
                  bool _859_recOwned;
                  bool _860_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _861_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out424;
                  bool _out425;
                  bool _out426;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out427;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out424, out _out425, out _out426, out _out427);
                  _858_recursiveGen = _out424;
                  _859_recOwned = _out425;
                  _860_recErased = _out426;
                  _861_recIdents = _out427;
                  if (!(_859_recOwned)) {
                    _858_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_858_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_858_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _859_recOwned;
                  isErased = _860_recErased;
                  readIdents = _861_recIdents;
                }
              } else if (_source36.is_Primitive) {
                DAST._IPrimitive _862___mcc_h465 = _source36.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _863_recursiveGen;
                  bool _864_recOwned;
                  bool _865_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _866_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out428;
                  bool _out429;
                  bool _out430;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out431;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out428, out _out429, out _out430, out _out431);
                  _863_recursiveGen = _out428;
                  _864_recOwned = _out429;
                  _865_recErased = _out430;
                  _866_recIdents = _out431;
                  if (!(_864_recOwned)) {
                    _863_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_863_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_863_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _864_recOwned;
                  isErased = _865_recErased;
                  readIdents = _866_recIdents;
                }
              } else if (_source36.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _867___mcc_h468 = _source36.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _868_recursiveGen;
                  bool _869_recOwned;
                  bool _870_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _871_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out432;
                  bool _out433;
                  bool _out434;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out435;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out432, out _out433, out _out434, out _out435);
                  _868_recursiveGen = _out432;
                  _869_recOwned = _out433;
                  _870_recErased = _out434;
                  _871_recIdents = _out435;
                  if (!(_869_recOwned)) {
                    _868_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_868_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_868_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _869_recOwned;
                  isErased = _870_recErased;
                  readIdents = _871_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _872___mcc_h471 = _source36.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _873_recursiveGen;
                  bool _874_recOwned;
                  bool _875_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _876_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out436;
                  bool _out437;
                  bool _out438;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out439;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out436, out _out437, out _out438, out _out439);
                  _873_recursiveGen = _out436;
                  _874_recOwned = _out437;
                  _875_recErased = _out438;
                  _876_recIdents = _out439;
                  if (!(_874_recOwned)) {
                    _873_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_873_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_873_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _874_recOwned;
                  isErased = _875_recErased;
                  readIdents = _876_recIdents;
                }
              }
            } else if (_source28.is_Tuple) {
              Dafny.ISequence<DAST._IType> _877___mcc_h474 = _source28.dtor_Tuple_a0;
              DAST._IType _source38 = _536___mcc_h253;
              if (_source38.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _878___mcc_h478 = _source38.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _879___mcc_h479 = _source38.dtor_typeArgs;
                DAST._IResolvedType _880___mcc_h480 = _source38.dtor_resolved;
                DAST._IResolvedType _source39 = _880___mcc_h480;
                if (_source39.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _881___mcc_h484 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _882_recursiveGen;
                    bool _883_recOwned;
                    bool _884_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _885_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out440;
                    bool _out441;
                    bool _out442;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out443;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out440, out _out441, out _out442, out _out443);
                    _882_recursiveGen = _out440;
                    _883_recOwned = _out441;
                    _884_recErased = _out442;
                    _885_recIdents = _out443;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _882_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _883_recOwned;
                    isErased = _884_recErased;
                    readIdents = _885_recIdents;
                  }
                } else if (_source39.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _886___mcc_h486 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _887_recursiveGen;
                    bool _888_recOwned;
                    bool _889_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _890_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out444;
                    bool _out445;
                    bool _out446;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out447;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out444, out _out445, out _out446, out _out447);
                    _887_recursiveGen = _out444;
                    _888_recOwned = _out445;
                    _889_recErased = _out446;
                    _890_recIdents = _out447;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _887_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _888_recOwned;
                    isErased = _889_recErased;
                    readIdents = _890_recIdents;
                  }
                } else {
                  DAST._IType _891___mcc_h488 = _source39.dtor_Newtype_a0;
                  DAST._IType _892_b = _891___mcc_h488;
                  {
                    if (object.Equals(_529_fromTpe, _892_b)) {
                      Dafny.ISequence<Dafny.Rune> _893_recursiveGen;
                      bool _894_recOwned;
                      bool _895_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _896_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out448;
                      bool _out449;
                      bool _out450;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out451;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out448, out _out449, out _out450, out _out451);
                      _893_recursiveGen = _out448;
                      _894_recOwned = _out449;
                      _895_recErased = _out450;
                      _896_recIdents = _out451;
                      Dafny.ISequence<Dafny.Rune> _897_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out452;
                      _out452 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _897_rhsType = _out452;
                      Dafny.ISequence<Dafny.Rune> _898_uneraseFn;
                      _898_uneraseFn = ((_894_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _897_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _898_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _893_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _894_recOwned;
                      isErased = false;
                      readIdents = _896_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out453;
                      bool _out454;
                      bool _out455;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out456;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _892_b), _892_b, _528_toTpe), selfIdent, @params, mustOwn, out _out453, out _out454, out _out455, out _out456);
                      s = _out453;
                      isOwned = _out454;
                      isErased = _out455;
                      readIdents = _out456;
                    }
                  }
                }
              } else if (_source38.is_Nullable) {
                DAST._IType _899___mcc_h490 = _source38.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _900_recursiveGen;
                  bool _901_recOwned;
                  bool _902_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _903_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out457;
                  bool _out458;
                  bool _out459;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out460;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out457, out _out458, out _out459, out _out460);
                  _900_recursiveGen = _out457;
                  _901_recOwned = _out458;
                  _902_recErased = _out459;
                  _903_recIdents = _out460;
                  if (!(_901_recOwned)) {
                    _900_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_900_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _900_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _902_recErased;
                  readIdents = _903_recIdents;
                }
              } else if (_source38.is_Tuple) {
                Dafny.ISequence<DAST._IType> _904___mcc_h492 = _source38.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _905_recursiveGen;
                  bool _906_recOwned;
                  bool _907_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _908_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out461;
                  bool _out462;
                  bool _out463;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out464;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out461, out _out462, out _out463, out _out464);
                  _905_recursiveGen = _out461;
                  _906_recOwned = _out462;
                  _907_recErased = _out463;
                  _908_recIdents = _out464;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _905_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _906_recOwned;
                  isErased = _907_recErased;
                  readIdents = _908_recIdents;
                }
              } else if (_source38.is_Array) {
                DAST._IType _909___mcc_h494 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _910_recursiveGen;
                  bool _911_recOwned;
                  bool _912_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _913_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out465;
                  bool _out466;
                  bool _out467;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out468;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out465, out _out466, out _out467, out _out468);
                  _910_recursiveGen = _out465;
                  _911_recOwned = _out466;
                  _912_recErased = _out467;
                  _913_recIdents = _out468;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _910_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _911_recOwned;
                  isErased = _912_recErased;
                  readIdents = _913_recIdents;
                }
              } else if (_source38.is_Seq) {
                DAST._IType _914___mcc_h496 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _915_recursiveGen;
                  bool _916_recOwned;
                  bool _917_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _918_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out469;
                  bool _out470;
                  bool _out471;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out472;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out469, out _out470, out _out471, out _out472);
                  _915_recursiveGen = _out469;
                  _916_recOwned = _out470;
                  _917_recErased = _out471;
                  _918_recIdents = _out472;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _915_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _916_recOwned;
                  isErased = _917_recErased;
                  readIdents = _918_recIdents;
                }
              } else if (_source38.is_Set) {
                DAST._IType _919___mcc_h498 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _920_recursiveGen;
                  bool _921_recOwned;
                  bool _922_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _923_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out473;
                  bool _out474;
                  bool _out475;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out476;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out473, out _out474, out _out475, out _out476);
                  _920_recursiveGen = _out473;
                  _921_recOwned = _out474;
                  _922_recErased = _out475;
                  _923_recIdents = _out476;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _920_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _921_recOwned;
                  isErased = _922_recErased;
                  readIdents = _923_recIdents;
                }
              } else if (_source38.is_Multiset) {
                DAST._IType _924___mcc_h500 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _925_recursiveGen;
                  bool _926_recOwned;
                  bool _927_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _928_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out477;
                  bool _out478;
                  bool _out479;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out480;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out477, out _out478, out _out479, out _out480);
                  _925_recursiveGen = _out477;
                  _926_recOwned = _out478;
                  _927_recErased = _out479;
                  _928_recIdents = _out480;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _926_recOwned;
                  isErased = _927_recErased;
                  readIdents = _928_recIdents;
                }
              } else if (_source38.is_Map) {
                DAST._IType _929___mcc_h502 = _source38.dtor_key;
                DAST._IType _930___mcc_h503 = _source38.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _931_recursiveGen;
                  bool _932_recOwned;
                  bool _933_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _934_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out481;
                  bool _out482;
                  bool _out483;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out484;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out481, out _out482, out _out483, out _out484);
                  _931_recursiveGen = _out481;
                  _932_recOwned = _out482;
                  _933_recErased = _out483;
                  _934_recIdents = _out484;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _931_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _932_recOwned;
                  isErased = _933_recErased;
                  readIdents = _934_recIdents;
                }
              } else if (_source38.is_Arrow) {
                Dafny.ISequence<DAST._IType> _935___mcc_h506 = _source38.dtor_args;
                DAST._IType _936___mcc_h507 = _source38.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _937_recursiveGen;
                  bool _938_recOwned;
                  bool _939_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _940_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out485;
                  bool _out486;
                  bool _out487;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out488;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out485, out _out486, out _out487, out _out488);
                  _937_recursiveGen = _out485;
                  _938_recOwned = _out486;
                  _939_recErased = _out487;
                  _940_recIdents = _out488;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _937_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _938_recOwned;
                  isErased = _939_recErased;
                  readIdents = _940_recIdents;
                }
              } else if (_source38.is_Primitive) {
                DAST._IPrimitive _941___mcc_h510 = _source38.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _942_recursiveGen;
                  bool _943_recOwned;
                  bool _944_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _945_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out489;
                  bool _out490;
                  bool _out491;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out492;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out489, out _out490, out _out491, out _out492);
                  _942_recursiveGen = _out489;
                  _943_recOwned = _out490;
                  _944_recErased = _out491;
                  _945_recIdents = _out492;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _942_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _943_recOwned;
                  isErased = _944_recErased;
                  readIdents = _945_recIdents;
                }
              } else if (_source38.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _946___mcc_h512 = _source38.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _947_recursiveGen;
                  bool _948_recOwned;
                  bool _949_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _950_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out493;
                  bool _out494;
                  bool _out495;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out496;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out493, out _out494, out _out495, out _out496);
                  _947_recursiveGen = _out493;
                  _948_recOwned = _out494;
                  _949_recErased = _out495;
                  _950_recIdents = _out496;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _947_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _948_recOwned;
                  isErased = _949_recErased;
                  readIdents = _950_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _951___mcc_h514 = _source38.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _952_recursiveGen;
                  bool _953_recOwned;
                  bool _954_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _955_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out497;
                  bool _out498;
                  bool _out499;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out500;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out497, out _out498, out _out499, out _out500);
                  _952_recursiveGen = _out497;
                  _953_recOwned = _out498;
                  _954_recErased = _out499;
                  _955_recIdents = _out500;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _952_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _953_recOwned;
                  isErased = _954_recErased;
                  readIdents = _955_recIdents;
                }
              }
            } else if (_source28.is_Array) {
              DAST._IType _956___mcc_h516 = _source28.dtor_element;
              DAST._IType _source40 = _536___mcc_h253;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _957___mcc_h520 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _958___mcc_h521 = _source40.dtor_typeArgs;
                DAST._IResolvedType _959___mcc_h522 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _959___mcc_h522;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _960___mcc_h526 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _961_recursiveGen;
                    bool _962_recOwned;
                    bool _963_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _964_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out501;
                    bool _out502;
                    bool _out503;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out504;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out501, out _out502, out _out503, out _out504);
                    _961_recursiveGen = _out501;
                    _962_recOwned = _out502;
                    _963_recErased = _out503;
                    _964_recIdents = _out504;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _961_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _962_recOwned;
                    isErased = _963_recErased;
                    readIdents = _964_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _965___mcc_h528 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _966_recursiveGen;
                    bool _967_recOwned;
                    bool _968_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _969_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out505;
                    bool _out506;
                    bool _out507;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out508;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out505, out _out506, out _out507, out _out508);
                    _966_recursiveGen = _out505;
                    _967_recOwned = _out506;
                    _968_recErased = _out507;
                    _969_recIdents = _out508;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _966_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _967_recOwned;
                    isErased = _968_recErased;
                    readIdents = _969_recIdents;
                  }
                } else {
                  DAST._IType _970___mcc_h530 = _source41.dtor_Newtype_a0;
                  DAST._IType _971_b = _970___mcc_h530;
                  {
                    if (object.Equals(_529_fromTpe, _971_b)) {
                      Dafny.ISequence<Dafny.Rune> _972_recursiveGen;
                      bool _973_recOwned;
                      bool _974_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _975_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out509;
                      bool _out510;
                      bool _out511;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out512;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out509, out _out510, out _out511, out _out512);
                      _972_recursiveGen = _out509;
                      _973_recOwned = _out510;
                      _974_recErased = _out511;
                      _975_recIdents = _out512;
                      Dafny.ISequence<Dafny.Rune> _976_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out513;
                      _out513 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _976_rhsType = _out513;
                      Dafny.ISequence<Dafny.Rune> _977_uneraseFn;
                      _977_uneraseFn = ((_973_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _976_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _977_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _972_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _973_recOwned;
                      isErased = false;
                      readIdents = _975_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out514;
                      bool _out515;
                      bool _out516;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out517;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _971_b), _971_b, _528_toTpe), selfIdent, @params, mustOwn, out _out514, out _out515, out _out516, out _out517);
                      s = _out514;
                      isOwned = _out515;
                      isErased = _out516;
                      readIdents = _out517;
                    }
                  }
                }
              } else if (_source40.is_Nullable) {
                DAST._IType _978___mcc_h532 = _source40.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _979_recursiveGen;
                  bool _980_recOwned;
                  bool _981_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _982_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out518;
                  bool _out519;
                  bool _out520;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out521;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out518, out _out519, out _out520, out _out521);
                  _979_recursiveGen = _out518;
                  _980_recOwned = _out519;
                  _981_recErased = _out520;
                  _982_recIdents = _out521;
                  if (!(_980_recOwned)) {
                    _979_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_979_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _979_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _981_recErased;
                  readIdents = _982_recIdents;
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _983___mcc_h534 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _984_recursiveGen;
                  bool _985_recOwned;
                  bool _986_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _987_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out522;
                  bool _out523;
                  bool _out524;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out525;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out522, out _out523, out _out524, out _out525);
                  _984_recursiveGen = _out522;
                  _985_recOwned = _out523;
                  _986_recErased = _out524;
                  _987_recIdents = _out525;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _984_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _985_recOwned;
                  isErased = _986_recErased;
                  readIdents = _987_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _988___mcc_h536 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _989_recursiveGen;
                  bool _990_recOwned;
                  bool _991_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _992_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out526;
                  bool _out527;
                  bool _out528;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out529;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out526, out _out527, out _out528, out _out529);
                  _989_recursiveGen = _out526;
                  _990_recOwned = _out527;
                  _991_recErased = _out528;
                  _992_recIdents = _out529;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _989_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _990_recOwned;
                  isErased = _991_recErased;
                  readIdents = _992_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _993___mcc_h538 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _994_recursiveGen;
                  bool _995_recOwned;
                  bool _996_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _997_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out530;
                  bool _out531;
                  bool _out532;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out533;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out530, out _out531, out _out532, out _out533);
                  _994_recursiveGen = _out530;
                  _995_recOwned = _out531;
                  _996_recErased = _out532;
                  _997_recIdents = _out533;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _994_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _995_recOwned;
                  isErased = _996_recErased;
                  readIdents = _997_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _998___mcc_h540 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _999_recursiveGen;
                  bool _1000_recOwned;
                  bool _1001_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1002_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out534;
                  bool _out535;
                  bool _out536;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out537;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out534, out _out535, out _out536, out _out537);
                  _999_recursiveGen = _out534;
                  _1000_recOwned = _out535;
                  _1001_recErased = _out536;
                  _1002_recIdents = _out537;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _999_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1000_recOwned;
                  isErased = _1001_recErased;
                  readIdents = _1002_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _1003___mcc_h542 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1004_recursiveGen;
                  bool _1005_recOwned;
                  bool _1006_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1007_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out538;
                  bool _out539;
                  bool _out540;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out541;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out538, out _out539, out _out540, out _out541);
                  _1004_recursiveGen = _out538;
                  _1005_recOwned = _out539;
                  _1006_recErased = _out540;
                  _1007_recIdents = _out541;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1004_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1005_recOwned;
                  isErased = _1006_recErased;
                  readIdents = _1007_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _1008___mcc_h544 = _source40.dtor_key;
                DAST._IType _1009___mcc_h545 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1010_recursiveGen;
                  bool _1011_recOwned;
                  bool _1012_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1013_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out542;
                  bool _out543;
                  bool _out544;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out545;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out542, out _out543, out _out544, out _out545);
                  _1010_recursiveGen = _out542;
                  _1011_recOwned = _out543;
                  _1012_recErased = _out544;
                  _1013_recIdents = _out545;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1010_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1011_recOwned;
                  isErased = _1012_recErased;
                  readIdents = _1013_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1014___mcc_h548 = _source40.dtor_args;
                DAST._IType _1015___mcc_h549 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1016_recursiveGen;
                  bool _1017_recOwned;
                  bool _1018_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1019_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out546;
                  bool _out547;
                  bool _out548;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out549;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out546, out _out547, out _out548, out _out549);
                  _1016_recursiveGen = _out546;
                  _1017_recOwned = _out547;
                  _1018_recErased = _out548;
                  _1019_recIdents = _out549;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1016_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1017_recOwned;
                  isErased = _1018_recErased;
                  readIdents = _1019_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _1020___mcc_h552 = _source40.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1021_recursiveGen;
                  bool _1022_recOwned;
                  bool _1023_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1024_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out550;
                  bool _out551;
                  bool _out552;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out553;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out550, out _out551, out _out552, out _out553);
                  _1021_recursiveGen = _out550;
                  _1022_recOwned = _out551;
                  _1023_recErased = _out552;
                  _1024_recIdents = _out553;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1021_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1022_recOwned;
                  isErased = _1023_recErased;
                  readIdents = _1024_recIdents;
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1025___mcc_h554 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1026_recursiveGen;
                  bool _1027_recOwned;
                  bool _1028_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1029_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out554;
                  bool _out555;
                  bool _out556;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out557;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out554, out _out555, out _out556, out _out557);
                  _1026_recursiveGen = _out554;
                  _1027_recOwned = _out555;
                  _1028_recErased = _out556;
                  _1029_recIdents = _out557;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1026_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1027_recOwned;
                  isErased = _1028_recErased;
                  readIdents = _1029_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1030___mcc_h556 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1031_recursiveGen;
                  bool _1032_recOwned;
                  bool _1033_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1034_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out558;
                  bool _out559;
                  bool _out560;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out561;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out558, out _out559, out _out560, out _out561);
                  _1031_recursiveGen = _out558;
                  _1032_recOwned = _out559;
                  _1033_recErased = _out560;
                  _1034_recIdents = _out561;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1031_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1032_recOwned;
                  isErased = _1033_recErased;
                  readIdents = _1034_recIdents;
                }
              }
            } else if (_source28.is_Seq) {
              DAST._IType _1035___mcc_h558 = _source28.dtor_element;
              DAST._IType _source42 = _536___mcc_h253;
              if (_source42.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1036___mcc_h562 = _source42.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1037___mcc_h563 = _source42.dtor_typeArgs;
                DAST._IResolvedType _1038___mcc_h564 = _source42.dtor_resolved;
                DAST._IResolvedType _source43 = _1038___mcc_h564;
                if (_source43.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1039___mcc_h568 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1040_recursiveGen;
                    bool _1041_recOwned;
                    bool _1042_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1043_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out562;
                    bool _out563;
                    bool _out564;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out565;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out562, out _out563, out _out564, out _out565);
                    _1040_recursiveGen = _out562;
                    _1041_recOwned = _out563;
                    _1042_recErased = _out564;
                    _1043_recIdents = _out565;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1040_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1041_recOwned;
                    isErased = _1042_recErased;
                    readIdents = _1043_recIdents;
                  }
                } else if (_source43.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1044___mcc_h570 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1045_recursiveGen;
                    bool _1046_recOwned;
                    bool _1047_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1048_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out566;
                    bool _out567;
                    bool _out568;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out569;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out566, out _out567, out _out568, out _out569);
                    _1045_recursiveGen = _out566;
                    _1046_recOwned = _out567;
                    _1047_recErased = _out568;
                    _1048_recIdents = _out569;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1045_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1046_recOwned;
                    isErased = _1047_recErased;
                    readIdents = _1048_recIdents;
                  }
                } else {
                  DAST._IType _1049___mcc_h572 = _source43.dtor_Newtype_a0;
                  DAST._IType _1050_b = _1049___mcc_h572;
                  {
                    if (object.Equals(_529_fromTpe, _1050_b)) {
                      Dafny.ISequence<Dafny.Rune> _1051_recursiveGen;
                      bool _1052_recOwned;
                      bool _1053_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1054_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out570;
                      bool _out571;
                      bool _out572;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out573;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out570, out _out571, out _out572, out _out573);
                      _1051_recursiveGen = _out570;
                      _1052_recOwned = _out571;
                      _1053_recErased = _out572;
                      _1054_recIdents = _out573;
                      Dafny.ISequence<Dafny.Rune> _1055_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out574;
                      _out574 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _1055_rhsType = _out574;
                      Dafny.ISequence<Dafny.Rune> _1056_uneraseFn;
                      _1056_uneraseFn = ((_1052_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1055_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1056_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1051_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1052_recOwned;
                      isErased = false;
                      readIdents = _1054_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out575;
                      bool _out576;
                      bool _out577;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out578;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1050_b), _1050_b, _528_toTpe), selfIdent, @params, mustOwn, out _out575, out _out576, out _out577, out _out578);
                      s = _out575;
                      isOwned = _out576;
                      isErased = _out577;
                      readIdents = _out578;
                    }
                  }
                }
              } else if (_source42.is_Nullable) {
                DAST._IType _1057___mcc_h574 = _source42.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1058_recursiveGen;
                  bool _1059_recOwned;
                  bool _1060_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1061_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out579;
                  bool _out580;
                  bool _out581;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out582;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out579, out _out580, out _out581, out _out582);
                  _1058_recursiveGen = _out579;
                  _1059_recOwned = _out580;
                  _1060_recErased = _out581;
                  _1061_recIdents = _out582;
                  if (!(_1059_recOwned)) {
                    _1058_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1058_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1058_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1060_recErased;
                  readIdents = _1061_recIdents;
                }
              } else if (_source42.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1062___mcc_h576 = _source42.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1063_recursiveGen;
                  bool _1064_recOwned;
                  bool _1065_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1066_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out583;
                  bool _out584;
                  bool _out585;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out586;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out583, out _out584, out _out585, out _out586);
                  _1063_recursiveGen = _out583;
                  _1064_recOwned = _out584;
                  _1065_recErased = _out585;
                  _1066_recIdents = _out586;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1063_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1064_recOwned;
                  isErased = _1065_recErased;
                  readIdents = _1066_recIdents;
                }
              } else if (_source42.is_Array) {
                DAST._IType _1067___mcc_h578 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1068_recursiveGen;
                  bool _1069_recOwned;
                  bool _1070_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1071_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out587;
                  bool _out588;
                  bool _out589;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out590;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out587, out _out588, out _out589, out _out590);
                  _1068_recursiveGen = _out587;
                  _1069_recOwned = _out588;
                  _1070_recErased = _out589;
                  _1071_recIdents = _out590;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1068_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1069_recOwned;
                  isErased = _1070_recErased;
                  readIdents = _1071_recIdents;
                }
              } else if (_source42.is_Seq) {
                DAST._IType _1072___mcc_h580 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1073_recursiveGen;
                  bool _1074_recOwned;
                  bool _1075_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1076_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out591;
                  bool _out592;
                  bool _out593;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out594;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out591, out _out592, out _out593, out _out594);
                  _1073_recursiveGen = _out591;
                  _1074_recOwned = _out592;
                  _1075_recErased = _out593;
                  _1076_recIdents = _out594;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1073_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1074_recOwned;
                  isErased = _1075_recErased;
                  readIdents = _1076_recIdents;
                }
              } else if (_source42.is_Set) {
                DAST._IType _1077___mcc_h582 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1078_recursiveGen;
                  bool _1079_recOwned;
                  bool _1080_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1081_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out595;
                  bool _out596;
                  bool _out597;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out598;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out595, out _out596, out _out597, out _out598);
                  _1078_recursiveGen = _out595;
                  _1079_recOwned = _out596;
                  _1080_recErased = _out597;
                  _1081_recIdents = _out598;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1078_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1079_recOwned;
                  isErased = _1080_recErased;
                  readIdents = _1081_recIdents;
                }
              } else if (_source42.is_Multiset) {
                DAST._IType _1082___mcc_h584 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1083_recursiveGen;
                  bool _1084_recOwned;
                  bool _1085_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1086_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out599;
                  bool _out600;
                  bool _out601;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out602;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out599, out _out600, out _out601, out _out602);
                  _1083_recursiveGen = _out599;
                  _1084_recOwned = _out600;
                  _1085_recErased = _out601;
                  _1086_recIdents = _out602;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1083_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1084_recOwned;
                  isErased = _1085_recErased;
                  readIdents = _1086_recIdents;
                }
              } else if (_source42.is_Map) {
                DAST._IType _1087___mcc_h586 = _source42.dtor_key;
                DAST._IType _1088___mcc_h587 = _source42.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1089_recursiveGen;
                  bool _1090_recOwned;
                  bool _1091_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1092_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out603;
                  bool _out604;
                  bool _out605;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out606;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out603, out _out604, out _out605, out _out606);
                  _1089_recursiveGen = _out603;
                  _1090_recOwned = _out604;
                  _1091_recErased = _out605;
                  _1092_recIdents = _out606;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1089_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1090_recOwned;
                  isErased = _1091_recErased;
                  readIdents = _1092_recIdents;
                }
              } else if (_source42.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1093___mcc_h590 = _source42.dtor_args;
                DAST._IType _1094___mcc_h591 = _source42.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1095_recursiveGen;
                  bool _1096_recOwned;
                  bool _1097_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1098_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out607;
                  bool _out608;
                  bool _out609;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out610;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out607, out _out608, out _out609, out _out610);
                  _1095_recursiveGen = _out607;
                  _1096_recOwned = _out608;
                  _1097_recErased = _out609;
                  _1098_recIdents = _out610;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1095_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1096_recOwned;
                  isErased = _1097_recErased;
                  readIdents = _1098_recIdents;
                }
              } else if (_source42.is_Primitive) {
                DAST._IPrimitive _1099___mcc_h594 = _source42.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1100_recursiveGen;
                  bool _1101_recOwned;
                  bool _1102_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1103_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out611;
                  bool _out612;
                  bool _out613;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out614;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out611, out _out612, out _out613, out _out614);
                  _1100_recursiveGen = _out611;
                  _1101_recOwned = _out612;
                  _1102_recErased = _out613;
                  _1103_recIdents = _out614;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1100_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1101_recOwned;
                  isErased = _1102_recErased;
                  readIdents = _1103_recIdents;
                }
              } else if (_source42.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1104___mcc_h596 = _source42.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1105_recursiveGen;
                  bool _1106_recOwned;
                  bool _1107_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1108_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out615;
                  bool _out616;
                  bool _out617;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out618;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out615, out _out616, out _out617, out _out618);
                  _1105_recursiveGen = _out615;
                  _1106_recOwned = _out616;
                  _1107_recErased = _out617;
                  _1108_recIdents = _out618;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1105_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1106_recOwned;
                  isErased = _1107_recErased;
                  readIdents = _1108_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1109___mcc_h598 = _source42.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1110_recursiveGen;
                  bool _1111_recOwned;
                  bool _1112_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1113_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out619;
                  bool _out620;
                  bool _out621;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out622;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out619, out _out620, out _out621, out _out622);
                  _1110_recursiveGen = _out619;
                  _1111_recOwned = _out620;
                  _1112_recErased = _out621;
                  _1113_recIdents = _out622;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1110_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1111_recOwned;
                  isErased = _1112_recErased;
                  readIdents = _1113_recIdents;
                }
              }
            } else if (_source28.is_Set) {
              DAST._IType _1114___mcc_h600 = _source28.dtor_element;
              DAST._IType _source44 = _536___mcc_h253;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1115___mcc_h604 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1116___mcc_h605 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1117___mcc_h606 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1117___mcc_h606;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1118___mcc_h610 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1119_recursiveGen;
                    bool _1120_recOwned;
                    bool _1121_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1122_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out623;
                    bool _out624;
                    bool _out625;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out626;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out623, out _out624, out _out625, out _out626);
                    _1119_recursiveGen = _out623;
                    _1120_recOwned = _out624;
                    _1121_recErased = _out625;
                    _1122_recIdents = _out626;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1119_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1120_recOwned;
                    isErased = _1121_recErased;
                    readIdents = _1122_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1123___mcc_h612 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1124_recursiveGen;
                    bool _1125_recOwned;
                    bool _1126_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1127_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out627;
                    bool _out628;
                    bool _out629;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out630;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out627, out _out628, out _out629, out _out630);
                    _1124_recursiveGen = _out627;
                    _1125_recOwned = _out628;
                    _1126_recErased = _out629;
                    _1127_recIdents = _out630;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1124_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1125_recOwned;
                    isErased = _1126_recErased;
                    readIdents = _1127_recIdents;
                  }
                } else {
                  DAST._IType _1128___mcc_h614 = _source45.dtor_Newtype_a0;
                  DAST._IType _1129_b = _1128___mcc_h614;
                  {
                    if (object.Equals(_529_fromTpe, _1129_b)) {
                      Dafny.ISequence<Dafny.Rune> _1130_recursiveGen;
                      bool _1131_recOwned;
                      bool _1132_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1133_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out631;
                      bool _out632;
                      bool _out633;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out634;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out631, out _out632, out _out633, out _out634);
                      _1130_recursiveGen = _out631;
                      _1131_recOwned = _out632;
                      _1132_recErased = _out633;
                      _1133_recIdents = _out634;
                      Dafny.ISequence<Dafny.Rune> _1134_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out635;
                      _out635 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _1134_rhsType = _out635;
                      Dafny.ISequence<Dafny.Rune> _1135_uneraseFn;
                      _1135_uneraseFn = ((_1131_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1134_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1135_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1130_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1131_recOwned;
                      isErased = false;
                      readIdents = _1133_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out636;
                      bool _out637;
                      bool _out638;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out639;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1129_b), _1129_b, _528_toTpe), selfIdent, @params, mustOwn, out _out636, out _out637, out _out638, out _out639);
                      s = _out636;
                      isOwned = _out637;
                      isErased = _out638;
                      readIdents = _out639;
                    }
                  }
                }
              } else if (_source44.is_Nullable) {
                DAST._IType _1136___mcc_h616 = _source44.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1137_recursiveGen;
                  bool _1138_recOwned;
                  bool _1139_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1140_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out640;
                  bool _out641;
                  bool _out642;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out643;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out640, out _out641, out _out642, out _out643);
                  _1137_recursiveGen = _out640;
                  _1138_recOwned = _out641;
                  _1139_recErased = _out642;
                  _1140_recIdents = _out643;
                  if (!(_1138_recOwned)) {
                    _1137_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1137_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1137_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1139_recErased;
                  readIdents = _1140_recIdents;
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1141___mcc_h618 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1142_recursiveGen;
                  bool _1143_recOwned;
                  bool _1144_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1145_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out644;
                  bool _out645;
                  bool _out646;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out647;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out644, out _out645, out _out646, out _out647);
                  _1142_recursiveGen = _out644;
                  _1143_recOwned = _out645;
                  _1144_recErased = _out646;
                  _1145_recIdents = _out647;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1142_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1143_recOwned;
                  isErased = _1144_recErased;
                  readIdents = _1145_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1146___mcc_h620 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1147_recursiveGen;
                  bool _1148_recOwned;
                  bool _1149_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1150_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out648;
                  bool _out649;
                  bool _out650;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out651;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out648, out _out649, out _out650, out _out651);
                  _1147_recursiveGen = _out648;
                  _1148_recOwned = _out649;
                  _1149_recErased = _out650;
                  _1150_recIdents = _out651;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1147_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1148_recOwned;
                  isErased = _1149_recErased;
                  readIdents = _1150_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1151___mcc_h622 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1152_recursiveGen;
                  bool _1153_recOwned;
                  bool _1154_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1155_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out652;
                  bool _out653;
                  bool _out654;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out655;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out652, out _out653, out _out654, out _out655);
                  _1152_recursiveGen = _out652;
                  _1153_recOwned = _out653;
                  _1154_recErased = _out654;
                  _1155_recIdents = _out655;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1152_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1153_recOwned;
                  isErased = _1154_recErased;
                  readIdents = _1155_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1156___mcc_h624 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1157_recursiveGen;
                  bool _1158_recOwned;
                  bool _1159_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1160_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out656;
                  bool _out657;
                  bool _out658;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out659;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out656, out _out657, out _out658, out _out659);
                  _1157_recursiveGen = _out656;
                  _1158_recOwned = _out657;
                  _1159_recErased = _out658;
                  _1160_recIdents = _out659;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1157_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1158_recOwned;
                  isErased = _1159_recErased;
                  readIdents = _1160_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1161___mcc_h626 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1162_recursiveGen;
                  bool _1163_recOwned;
                  bool _1164_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1165_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out660;
                  bool _out661;
                  bool _out662;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out663;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out660, out _out661, out _out662, out _out663);
                  _1162_recursiveGen = _out660;
                  _1163_recOwned = _out661;
                  _1164_recErased = _out662;
                  _1165_recIdents = _out663;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1162_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1163_recOwned;
                  isErased = _1164_recErased;
                  readIdents = _1165_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1166___mcc_h628 = _source44.dtor_key;
                DAST._IType _1167___mcc_h629 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1168_recursiveGen;
                  bool _1169_recOwned;
                  bool _1170_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1171_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out664;
                  bool _out665;
                  bool _out666;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out667;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out664, out _out665, out _out666, out _out667);
                  _1168_recursiveGen = _out664;
                  _1169_recOwned = _out665;
                  _1170_recErased = _out666;
                  _1171_recIdents = _out667;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1168_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1169_recOwned;
                  isErased = _1170_recErased;
                  readIdents = _1171_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1172___mcc_h632 = _source44.dtor_args;
                DAST._IType _1173___mcc_h633 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1174_recursiveGen;
                  bool _1175_recOwned;
                  bool _1176_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1177_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out668;
                  bool _out669;
                  bool _out670;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out671;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out668, out _out669, out _out670, out _out671);
                  _1174_recursiveGen = _out668;
                  _1175_recOwned = _out669;
                  _1176_recErased = _out670;
                  _1177_recIdents = _out671;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1174_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1175_recOwned;
                  isErased = _1176_recErased;
                  readIdents = _1177_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1178___mcc_h636 = _source44.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1179_recursiveGen;
                  bool _1180_recOwned;
                  bool _1181_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1182_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out672;
                  bool _out673;
                  bool _out674;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out675;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out672, out _out673, out _out674, out _out675);
                  _1179_recursiveGen = _out672;
                  _1180_recOwned = _out673;
                  _1181_recErased = _out674;
                  _1182_recIdents = _out675;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1179_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1180_recOwned;
                  isErased = _1181_recErased;
                  readIdents = _1182_recIdents;
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1183___mcc_h638 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1184_recursiveGen;
                  bool _1185_recOwned;
                  bool _1186_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1187_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out676;
                  bool _out677;
                  bool _out678;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out679;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out676, out _out677, out _out678, out _out679);
                  _1184_recursiveGen = _out676;
                  _1185_recOwned = _out677;
                  _1186_recErased = _out678;
                  _1187_recIdents = _out679;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1184_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1185_recOwned;
                  isErased = _1186_recErased;
                  readIdents = _1187_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1188___mcc_h640 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1189_recursiveGen;
                  bool _1190_recOwned;
                  bool _1191_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1192_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out680;
                  bool _out681;
                  bool _out682;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out683;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out680, out _out681, out _out682, out _out683);
                  _1189_recursiveGen = _out680;
                  _1190_recOwned = _out681;
                  _1191_recErased = _out682;
                  _1192_recIdents = _out683;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1189_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1190_recOwned;
                  isErased = _1191_recErased;
                  readIdents = _1192_recIdents;
                }
              }
            } else if (_source28.is_Multiset) {
              DAST._IType _1193___mcc_h642 = _source28.dtor_element;
              DAST._IType _source46 = _536___mcc_h253;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1194___mcc_h646 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1195___mcc_h647 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1196___mcc_h648 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1196___mcc_h648;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1197___mcc_h652 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1198_recursiveGen;
                    bool _1199_recOwned;
                    bool _1200_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1201_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out684;
                    bool _out685;
                    bool _out686;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out687;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out684, out _out685, out _out686, out _out687);
                    _1198_recursiveGen = _out684;
                    _1199_recOwned = _out685;
                    _1200_recErased = _out686;
                    _1201_recIdents = _out687;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1198_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1199_recOwned;
                    isErased = _1200_recErased;
                    readIdents = _1201_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1202___mcc_h654 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1203_recursiveGen;
                    bool _1204_recOwned;
                    bool _1205_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1206_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out688;
                    bool _out689;
                    bool _out690;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out691;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out688, out _out689, out _out690, out _out691);
                    _1203_recursiveGen = _out688;
                    _1204_recOwned = _out689;
                    _1205_recErased = _out690;
                    _1206_recIdents = _out691;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1203_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1204_recOwned;
                    isErased = _1205_recErased;
                    readIdents = _1206_recIdents;
                  }
                } else {
                  DAST._IType _1207___mcc_h656 = _source47.dtor_Newtype_a0;
                  DAST._IType _1208_b = _1207___mcc_h656;
                  {
                    if (object.Equals(_529_fromTpe, _1208_b)) {
                      Dafny.ISequence<Dafny.Rune> _1209_recursiveGen;
                      bool _1210_recOwned;
                      bool _1211_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1212_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out692;
                      bool _out693;
                      bool _out694;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out695;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out692, out _out693, out _out694, out _out695);
                      _1209_recursiveGen = _out692;
                      _1210_recOwned = _out693;
                      _1211_recErased = _out694;
                      _1212_recIdents = _out695;
                      Dafny.ISequence<Dafny.Rune> _1213_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out696;
                      _out696 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _1213_rhsType = _out696;
                      Dafny.ISequence<Dafny.Rune> _1214_uneraseFn;
                      _1214_uneraseFn = ((_1210_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1213_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1214_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1209_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1210_recOwned;
                      isErased = false;
                      readIdents = _1212_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out697;
                      bool _out698;
                      bool _out699;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out700;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1208_b), _1208_b, _528_toTpe), selfIdent, @params, mustOwn, out _out697, out _out698, out _out699, out _out700);
                      s = _out697;
                      isOwned = _out698;
                      isErased = _out699;
                      readIdents = _out700;
                    }
                  }
                }
              } else if (_source46.is_Nullable) {
                DAST._IType _1215___mcc_h658 = _source46.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1216_recursiveGen;
                  bool _1217_recOwned;
                  bool _1218_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1219_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out701;
                  bool _out702;
                  bool _out703;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out704;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out701, out _out702, out _out703, out _out704);
                  _1216_recursiveGen = _out701;
                  _1217_recOwned = _out702;
                  _1218_recErased = _out703;
                  _1219_recIdents = _out704;
                  if (!(_1217_recOwned)) {
                    _1216_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1216_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1216_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1218_recErased;
                  readIdents = _1219_recIdents;
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1220___mcc_h660 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1221_recursiveGen;
                  bool _1222_recOwned;
                  bool _1223_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1224_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out705;
                  bool _out706;
                  bool _out707;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out708;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out705, out _out706, out _out707, out _out708);
                  _1221_recursiveGen = _out705;
                  _1222_recOwned = _out706;
                  _1223_recErased = _out707;
                  _1224_recIdents = _out708;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1221_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1222_recOwned;
                  isErased = _1223_recErased;
                  readIdents = _1224_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1225___mcc_h662 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1226_recursiveGen;
                  bool _1227_recOwned;
                  bool _1228_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1229_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out709;
                  bool _out710;
                  bool _out711;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out712;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out709, out _out710, out _out711, out _out712);
                  _1226_recursiveGen = _out709;
                  _1227_recOwned = _out710;
                  _1228_recErased = _out711;
                  _1229_recIdents = _out712;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1226_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1227_recOwned;
                  isErased = _1228_recErased;
                  readIdents = _1229_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1230___mcc_h664 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1231_recursiveGen;
                  bool _1232_recOwned;
                  bool _1233_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1234_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out713;
                  bool _out714;
                  bool _out715;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out716;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out713, out _out714, out _out715, out _out716);
                  _1231_recursiveGen = _out713;
                  _1232_recOwned = _out714;
                  _1233_recErased = _out715;
                  _1234_recIdents = _out716;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1231_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1232_recOwned;
                  isErased = _1233_recErased;
                  readIdents = _1234_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1235___mcc_h666 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1236_recursiveGen;
                  bool _1237_recOwned;
                  bool _1238_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1239_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out717;
                  bool _out718;
                  bool _out719;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out720;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out717, out _out718, out _out719, out _out720);
                  _1236_recursiveGen = _out717;
                  _1237_recOwned = _out718;
                  _1238_recErased = _out719;
                  _1239_recIdents = _out720;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1236_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1237_recOwned;
                  isErased = _1238_recErased;
                  readIdents = _1239_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1240___mcc_h668 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1241_recursiveGen;
                  bool _1242_recOwned;
                  bool _1243_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1244_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out721;
                  bool _out722;
                  bool _out723;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out724;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out721, out _out722, out _out723, out _out724);
                  _1241_recursiveGen = _out721;
                  _1242_recOwned = _out722;
                  _1243_recErased = _out723;
                  _1244_recIdents = _out724;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1241_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1242_recOwned;
                  isErased = _1243_recErased;
                  readIdents = _1244_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1245___mcc_h670 = _source46.dtor_key;
                DAST._IType _1246___mcc_h671 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1247_recursiveGen;
                  bool _1248_recOwned;
                  bool _1249_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1250_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out725;
                  bool _out726;
                  bool _out727;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out728;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out725, out _out726, out _out727, out _out728);
                  _1247_recursiveGen = _out725;
                  _1248_recOwned = _out726;
                  _1249_recErased = _out727;
                  _1250_recIdents = _out728;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1247_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1248_recOwned;
                  isErased = _1249_recErased;
                  readIdents = _1250_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1251___mcc_h674 = _source46.dtor_args;
                DAST._IType _1252___mcc_h675 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1253_recursiveGen;
                  bool _1254_recOwned;
                  bool _1255_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1256_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out729;
                  bool _out730;
                  bool _out731;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out732;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out729, out _out730, out _out731, out _out732);
                  _1253_recursiveGen = _out729;
                  _1254_recOwned = _out730;
                  _1255_recErased = _out731;
                  _1256_recIdents = _out732;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1253_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1254_recOwned;
                  isErased = _1255_recErased;
                  readIdents = _1256_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1257___mcc_h678 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1258_recursiveGen;
                  bool _1259_recOwned;
                  bool _1260_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1261_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out733;
                  bool _out734;
                  bool _out735;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out736;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out733, out _out734, out _out735, out _out736);
                  _1258_recursiveGen = _out733;
                  _1259_recOwned = _out734;
                  _1260_recErased = _out735;
                  _1261_recIdents = _out736;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1258_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1259_recOwned;
                  isErased = _1260_recErased;
                  readIdents = _1261_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1262___mcc_h680 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1263_recursiveGen;
                  bool _1264_recOwned;
                  bool _1265_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1266_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out737;
                  bool _out738;
                  bool _out739;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out740;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out737, out _out738, out _out739, out _out740);
                  _1263_recursiveGen = _out737;
                  _1264_recOwned = _out738;
                  _1265_recErased = _out739;
                  _1266_recIdents = _out740;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1263_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1264_recOwned;
                  isErased = _1265_recErased;
                  readIdents = _1266_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1267___mcc_h682 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1268_recursiveGen;
                  bool _1269_recOwned;
                  bool _1270_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1271_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out741;
                  bool _out742;
                  bool _out743;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out744;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out741, out _out742, out _out743, out _out744);
                  _1268_recursiveGen = _out741;
                  _1269_recOwned = _out742;
                  _1270_recErased = _out743;
                  _1271_recIdents = _out744;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1268_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1269_recOwned;
                  isErased = _1270_recErased;
                  readIdents = _1271_recIdents;
                }
              }
            } else if (_source28.is_Map) {
              DAST._IType _1272___mcc_h684 = _source28.dtor_key;
              DAST._IType _1273___mcc_h685 = _source28.dtor_value;
              DAST._IType _source48 = _536___mcc_h253;
              if (_source48.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1274___mcc_h692 = _source48.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1275___mcc_h693 = _source48.dtor_typeArgs;
                DAST._IResolvedType _1276___mcc_h694 = _source48.dtor_resolved;
                DAST._IResolvedType _source49 = _1276___mcc_h694;
                if (_source49.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1277___mcc_h698 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1278_recursiveGen;
                    bool _1279_recOwned;
                    bool _1280_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1281_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out745;
                    bool _out746;
                    bool _out747;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out748;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out745, out _out746, out _out747, out _out748);
                    _1278_recursiveGen = _out745;
                    _1279_recOwned = _out746;
                    _1280_recErased = _out747;
                    _1281_recIdents = _out748;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1278_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1279_recOwned;
                    isErased = _1280_recErased;
                    readIdents = _1281_recIdents;
                  }
                } else if (_source49.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1282___mcc_h700 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1283_recursiveGen;
                    bool _1284_recOwned;
                    bool _1285_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1286_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out749;
                    bool _out750;
                    bool _out751;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out752;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out749, out _out750, out _out751, out _out752);
                    _1283_recursiveGen = _out749;
                    _1284_recOwned = _out750;
                    _1285_recErased = _out751;
                    _1286_recIdents = _out752;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1283_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1284_recOwned;
                    isErased = _1285_recErased;
                    readIdents = _1286_recIdents;
                  }
                } else {
                  DAST._IType _1287___mcc_h702 = _source49.dtor_Newtype_a0;
                  DAST._IType _1288_b = _1287___mcc_h702;
                  {
                    if (object.Equals(_529_fromTpe, _1288_b)) {
                      Dafny.ISequence<Dafny.Rune> _1289_recursiveGen;
                      bool _1290_recOwned;
                      bool _1291_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1292_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out753;
                      bool _out754;
                      bool _out755;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out756;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out753, out _out754, out _out755, out _out756);
                      _1289_recursiveGen = _out753;
                      _1290_recOwned = _out754;
                      _1291_recErased = _out755;
                      _1292_recIdents = _out756;
                      Dafny.ISequence<Dafny.Rune> _1293_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out757;
                      _out757 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _1293_rhsType = _out757;
                      Dafny.ISequence<Dafny.Rune> _1294_uneraseFn;
                      _1294_uneraseFn = ((_1290_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1293_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1294_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1289_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1290_recOwned;
                      isErased = false;
                      readIdents = _1292_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out758;
                      bool _out759;
                      bool _out760;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out761;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1288_b), _1288_b, _528_toTpe), selfIdent, @params, mustOwn, out _out758, out _out759, out _out760, out _out761);
                      s = _out758;
                      isOwned = _out759;
                      isErased = _out760;
                      readIdents = _out761;
                    }
                  }
                }
              } else if (_source48.is_Nullable) {
                DAST._IType _1295___mcc_h704 = _source48.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1296_recursiveGen;
                  bool _1297_recOwned;
                  bool _1298_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1299_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out762;
                  bool _out763;
                  bool _out764;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out765;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out762, out _out763, out _out764, out _out765);
                  _1296_recursiveGen = _out762;
                  _1297_recOwned = _out763;
                  _1298_recErased = _out764;
                  _1299_recIdents = _out765;
                  if (!(_1297_recOwned)) {
                    _1296_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1296_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1296_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1298_recErased;
                  readIdents = _1299_recIdents;
                }
              } else if (_source48.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1300___mcc_h706 = _source48.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1301_recursiveGen;
                  bool _1302_recOwned;
                  bool _1303_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1304_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out766;
                  bool _out767;
                  bool _out768;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out769;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out766, out _out767, out _out768, out _out769);
                  _1301_recursiveGen = _out766;
                  _1302_recOwned = _out767;
                  _1303_recErased = _out768;
                  _1304_recIdents = _out769;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1301_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1302_recOwned;
                  isErased = _1303_recErased;
                  readIdents = _1304_recIdents;
                }
              } else if (_source48.is_Array) {
                DAST._IType _1305___mcc_h708 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1306_recursiveGen;
                  bool _1307_recOwned;
                  bool _1308_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1309_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out770;
                  bool _out771;
                  bool _out772;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out773;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out770, out _out771, out _out772, out _out773);
                  _1306_recursiveGen = _out770;
                  _1307_recOwned = _out771;
                  _1308_recErased = _out772;
                  _1309_recIdents = _out773;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1306_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1307_recOwned;
                  isErased = _1308_recErased;
                  readIdents = _1309_recIdents;
                }
              } else if (_source48.is_Seq) {
                DAST._IType _1310___mcc_h710 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1311_recursiveGen;
                  bool _1312_recOwned;
                  bool _1313_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1314_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out774;
                  bool _out775;
                  bool _out776;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out777;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out774, out _out775, out _out776, out _out777);
                  _1311_recursiveGen = _out774;
                  _1312_recOwned = _out775;
                  _1313_recErased = _out776;
                  _1314_recIdents = _out777;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1311_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1312_recOwned;
                  isErased = _1313_recErased;
                  readIdents = _1314_recIdents;
                }
              } else if (_source48.is_Set) {
                DAST._IType _1315___mcc_h712 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1316_recursiveGen;
                  bool _1317_recOwned;
                  bool _1318_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1319_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out778;
                  bool _out779;
                  bool _out780;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out781;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out778, out _out779, out _out780, out _out781);
                  _1316_recursiveGen = _out778;
                  _1317_recOwned = _out779;
                  _1318_recErased = _out780;
                  _1319_recIdents = _out781;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1316_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1317_recOwned;
                  isErased = _1318_recErased;
                  readIdents = _1319_recIdents;
                }
              } else if (_source48.is_Multiset) {
                DAST._IType _1320___mcc_h714 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1321_recursiveGen;
                  bool _1322_recOwned;
                  bool _1323_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1324_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out782;
                  bool _out783;
                  bool _out784;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out785;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out782, out _out783, out _out784, out _out785);
                  _1321_recursiveGen = _out782;
                  _1322_recOwned = _out783;
                  _1323_recErased = _out784;
                  _1324_recIdents = _out785;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1321_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1322_recOwned;
                  isErased = _1323_recErased;
                  readIdents = _1324_recIdents;
                }
              } else if (_source48.is_Map) {
                DAST._IType _1325___mcc_h716 = _source48.dtor_key;
                DAST._IType _1326___mcc_h717 = _source48.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1327_recursiveGen;
                  bool _1328_recOwned;
                  bool _1329_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1330_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out786;
                  bool _out787;
                  bool _out788;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out789;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out786, out _out787, out _out788, out _out789);
                  _1327_recursiveGen = _out786;
                  _1328_recOwned = _out787;
                  _1329_recErased = _out788;
                  _1330_recIdents = _out789;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1327_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1328_recOwned;
                  isErased = _1329_recErased;
                  readIdents = _1330_recIdents;
                }
              } else if (_source48.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1331___mcc_h720 = _source48.dtor_args;
                DAST._IType _1332___mcc_h721 = _source48.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1333_recursiveGen;
                  bool _1334_recOwned;
                  bool _1335_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1336_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out790;
                  bool _out791;
                  bool _out792;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out793;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out790, out _out791, out _out792, out _out793);
                  _1333_recursiveGen = _out790;
                  _1334_recOwned = _out791;
                  _1335_recErased = _out792;
                  _1336_recIdents = _out793;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1333_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1334_recOwned;
                  isErased = _1335_recErased;
                  readIdents = _1336_recIdents;
                }
              } else if (_source48.is_Primitive) {
                DAST._IPrimitive _1337___mcc_h724 = _source48.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1338_recursiveGen;
                  bool _1339_recOwned;
                  bool _1340_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1341_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out794;
                  bool _out795;
                  bool _out796;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out797;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out794, out _out795, out _out796, out _out797);
                  _1338_recursiveGen = _out794;
                  _1339_recOwned = _out795;
                  _1340_recErased = _out796;
                  _1341_recIdents = _out797;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1338_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1339_recOwned;
                  isErased = _1340_recErased;
                  readIdents = _1341_recIdents;
                }
              } else if (_source48.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1342___mcc_h726 = _source48.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1343_recursiveGen;
                  bool _1344_recOwned;
                  bool _1345_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1346_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out798;
                  bool _out799;
                  bool _out800;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out801;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out798, out _out799, out _out800, out _out801);
                  _1343_recursiveGen = _out798;
                  _1344_recOwned = _out799;
                  _1345_recErased = _out800;
                  _1346_recIdents = _out801;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1343_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1344_recOwned;
                  isErased = _1345_recErased;
                  readIdents = _1346_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1347___mcc_h728 = _source48.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1348_recursiveGen;
                  bool _1349_recOwned;
                  bool _1350_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1351_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out802;
                  bool _out803;
                  bool _out804;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out805;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out802, out _out803, out _out804, out _out805);
                  _1348_recursiveGen = _out802;
                  _1349_recOwned = _out803;
                  _1350_recErased = _out804;
                  _1351_recIdents = _out805;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1348_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1349_recOwned;
                  isErased = _1350_recErased;
                  readIdents = _1351_recIdents;
                }
              }
            } else if (_source28.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1352___mcc_h730 = _source28.dtor_args;
              DAST._IType _1353___mcc_h731 = _source28.dtor_result;
              DAST._IType _source50 = _536___mcc_h253;
              if (_source50.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1354___mcc_h738 = _source50.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1355___mcc_h739 = _source50.dtor_typeArgs;
                DAST._IResolvedType _1356___mcc_h740 = _source50.dtor_resolved;
                DAST._IResolvedType _source51 = _1356___mcc_h740;
                if (_source51.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1357___mcc_h744 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1358_recursiveGen;
                    bool _1359_recOwned;
                    bool _1360_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1361_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out806;
                    bool _out807;
                    bool _out808;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out809;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out806, out _out807, out _out808, out _out809);
                    _1358_recursiveGen = _out806;
                    _1359_recOwned = _out807;
                    _1360_recErased = _out808;
                    _1361_recIdents = _out809;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1358_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1359_recOwned;
                    isErased = _1360_recErased;
                    readIdents = _1361_recIdents;
                  }
                } else if (_source51.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1362___mcc_h746 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1363_recursiveGen;
                    bool _1364_recOwned;
                    bool _1365_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1366_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out810;
                    bool _out811;
                    bool _out812;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out813;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out810, out _out811, out _out812, out _out813);
                    _1363_recursiveGen = _out810;
                    _1364_recOwned = _out811;
                    _1365_recErased = _out812;
                    _1366_recIdents = _out813;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1363_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1364_recOwned;
                    isErased = _1365_recErased;
                    readIdents = _1366_recIdents;
                  }
                } else {
                  DAST._IType _1367___mcc_h748 = _source51.dtor_Newtype_a0;
                  DAST._IType _1368_b = _1367___mcc_h748;
                  {
                    if (object.Equals(_529_fromTpe, _1368_b)) {
                      Dafny.ISequence<Dafny.Rune> _1369_recursiveGen;
                      bool _1370_recOwned;
                      bool _1371_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1372_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out814;
                      bool _out815;
                      bool _out816;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out817;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out814, out _out815, out _out816, out _out817);
                      _1369_recursiveGen = _out814;
                      _1370_recOwned = _out815;
                      _1371_recErased = _out816;
                      _1372_recIdents = _out817;
                      Dafny.ISequence<Dafny.Rune> _1373_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out818;
                      _out818 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _1373_rhsType = _out818;
                      Dafny.ISequence<Dafny.Rune> _1374_uneraseFn;
                      _1374_uneraseFn = ((_1370_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1373_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1374_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1369_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1370_recOwned;
                      isErased = false;
                      readIdents = _1372_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out819;
                      bool _out820;
                      bool _out821;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out822;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1368_b), _1368_b, _528_toTpe), selfIdent, @params, mustOwn, out _out819, out _out820, out _out821, out _out822);
                      s = _out819;
                      isOwned = _out820;
                      isErased = _out821;
                      readIdents = _out822;
                    }
                  }
                }
              } else if (_source50.is_Nullable) {
                DAST._IType _1375___mcc_h750 = _source50.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1376_recursiveGen;
                  bool _1377_recOwned;
                  bool _1378_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1379_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out823;
                  bool _out824;
                  bool _out825;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out826;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out823, out _out824, out _out825, out _out826);
                  _1376_recursiveGen = _out823;
                  _1377_recOwned = _out824;
                  _1378_recErased = _out825;
                  _1379_recIdents = _out826;
                  if (!(_1377_recOwned)) {
                    _1376_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1376_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1376_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1378_recErased;
                  readIdents = _1379_recIdents;
                }
              } else if (_source50.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1380___mcc_h752 = _source50.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1381_recursiveGen;
                  bool _1382_recOwned;
                  bool _1383_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1384_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out827;
                  bool _out828;
                  bool _out829;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out827, out _out828, out _out829, out _out830);
                  _1381_recursiveGen = _out827;
                  _1382_recOwned = _out828;
                  _1383_recErased = _out829;
                  _1384_recIdents = _out830;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1381_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1382_recOwned;
                  isErased = _1383_recErased;
                  readIdents = _1384_recIdents;
                }
              } else if (_source50.is_Array) {
                DAST._IType _1385___mcc_h754 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1386_recursiveGen;
                  bool _1387_recOwned;
                  bool _1388_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1389_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out831;
                  bool _out832;
                  bool _out833;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                  _1386_recursiveGen = _out831;
                  _1387_recOwned = _out832;
                  _1388_recErased = _out833;
                  _1389_recIdents = _out834;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1386_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1387_recOwned;
                  isErased = _1388_recErased;
                  readIdents = _1389_recIdents;
                }
              } else if (_source50.is_Seq) {
                DAST._IType _1390___mcc_h756 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1391_recursiveGen;
                  bool _1392_recOwned;
                  bool _1393_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1394_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out835;
                  bool _out836;
                  bool _out837;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                  _1391_recursiveGen = _out835;
                  _1392_recOwned = _out836;
                  _1393_recErased = _out837;
                  _1394_recIdents = _out838;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1391_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1392_recOwned;
                  isErased = _1393_recErased;
                  readIdents = _1394_recIdents;
                }
              } else if (_source50.is_Set) {
                DAST._IType _1395___mcc_h758 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1396_recursiveGen;
                  bool _1397_recOwned;
                  bool _1398_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1399_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out839;
                  bool _out840;
                  bool _out841;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                  _1396_recursiveGen = _out839;
                  _1397_recOwned = _out840;
                  _1398_recErased = _out841;
                  _1399_recIdents = _out842;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1396_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1397_recOwned;
                  isErased = _1398_recErased;
                  readIdents = _1399_recIdents;
                }
              } else if (_source50.is_Multiset) {
                DAST._IType _1400___mcc_h760 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1401_recursiveGen;
                  bool _1402_recOwned;
                  bool _1403_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1404_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out843;
                  bool _out844;
                  bool _out845;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                  _1401_recursiveGen = _out843;
                  _1402_recOwned = _out844;
                  _1403_recErased = _out845;
                  _1404_recIdents = _out846;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1401_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1402_recOwned;
                  isErased = _1403_recErased;
                  readIdents = _1404_recIdents;
                }
              } else if (_source50.is_Map) {
                DAST._IType _1405___mcc_h762 = _source50.dtor_key;
                DAST._IType _1406___mcc_h763 = _source50.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1407_recursiveGen;
                  bool _1408_recOwned;
                  bool _1409_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1410_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out847;
                  bool _out848;
                  bool _out849;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out850;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out847, out _out848, out _out849, out _out850);
                  _1407_recursiveGen = _out847;
                  _1408_recOwned = _out848;
                  _1409_recErased = _out849;
                  _1410_recIdents = _out850;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1407_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1408_recOwned;
                  isErased = _1409_recErased;
                  readIdents = _1410_recIdents;
                }
              } else if (_source50.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1411___mcc_h766 = _source50.dtor_args;
                DAST._IType _1412___mcc_h767 = _source50.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1413_recursiveGen;
                  bool _1414_recOwned;
                  bool _1415_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1416_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out851;
                  bool _out852;
                  bool _out853;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out854;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out851, out _out852, out _out853, out _out854);
                  _1413_recursiveGen = _out851;
                  _1414_recOwned = _out852;
                  _1415_recErased = _out853;
                  _1416_recIdents = _out854;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1413_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1414_recOwned;
                  isErased = _1415_recErased;
                  readIdents = _1416_recIdents;
                }
              } else if (_source50.is_Primitive) {
                DAST._IPrimitive _1417___mcc_h770 = _source50.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1418_recursiveGen;
                  bool _1419_recOwned;
                  bool _1420_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1421_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out855;
                  bool _out856;
                  bool _out857;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out858;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out855, out _out856, out _out857, out _out858);
                  _1418_recursiveGen = _out855;
                  _1419_recOwned = _out856;
                  _1420_recErased = _out857;
                  _1421_recIdents = _out858;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1418_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1419_recOwned;
                  isErased = _1420_recErased;
                  readIdents = _1421_recIdents;
                }
              } else if (_source50.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1422___mcc_h772 = _source50.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1423_recursiveGen;
                  bool _1424_recOwned;
                  bool _1425_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1426_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out859;
                  bool _out860;
                  bool _out861;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out862;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out859, out _out860, out _out861, out _out862);
                  _1423_recursiveGen = _out859;
                  _1424_recOwned = _out860;
                  _1425_recErased = _out861;
                  _1426_recIdents = _out862;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1423_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1424_recOwned;
                  isErased = _1425_recErased;
                  readIdents = _1426_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1427___mcc_h774 = _source50.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1428_recursiveGen;
                  bool _1429_recOwned;
                  bool _1430_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1431_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out863;
                  bool _out864;
                  bool _out865;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out866;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out863, out _out864, out _out865, out _out866);
                  _1428_recursiveGen = _out863;
                  _1429_recOwned = _out864;
                  _1430_recErased = _out865;
                  _1431_recIdents = _out866;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1428_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1429_recOwned;
                  isErased = _1430_recErased;
                  readIdents = _1431_recIdents;
                }
              }
            } else if (_source28.is_Primitive) {
              DAST._IPrimitive _1432___mcc_h776 = _source28.dtor_Primitive_a0;
              DAST._IPrimitive _source52 = _1432___mcc_h776;
              if (_source52.is_Int) {
                DAST._IType _source53 = _536___mcc_h253;
                if (_source53.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1433___mcc_h780 = _source53.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1434___mcc_h781 = _source53.dtor_typeArgs;
                  DAST._IResolvedType _1435___mcc_h782 = _source53.dtor_resolved;
                  DAST._IResolvedType _source54 = _1435___mcc_h782;
                  if (_source54.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1436___mcc_h786 = _source54.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1437_recursiveGen;
                      bool _1438_recOwned;
                      bool _1439_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1440_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out867;
                      bool _out868;
                      bool _out869;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out870;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out867, out _out868, out _out869, out _out870);
                      _1437_recursiveGen = _out867;
                      _1438_recOwned = _out868;
                      _1439_recErased = _out869;
                      _1440_recIdents = _out870;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1437_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1438_recOwned;
                      isErased = _1439_recErased;
                      readIdents = _1440_recIdents;
                    }
                  } else if (_source54.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1441___mcc_h788 = _source54.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1442_recursiveGen;
                      bool _1443_recOwned;
                      bool _1444_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1445_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out871;
                      bool _out872;
                      bool _out873;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out874;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out871, out _out872, out _out873, out _out874);
                      _1442_recursiveGen = _out871;
                      _1443_recOwned = _out872;
                      _1444_recErased = _out873;
                      _1445_recIdents = _out874;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1442_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1443_recOwned;
                      isErased = _1444_recErased;
                      readIdents = _1445_recIdents;
                    }
                  } else {
                    DAST._IType _1446___mcc_h790 = _source54.dtor_Newtype_a0;
                    DAST._IType _1447_b = _1446___mcc_h790;
                    {
                      if (object.Equals(_529_fromTpe, _1447_b)) {
                        Dafny.ISequence<Dafny.Rune> _1448_recursiveGen;
                        bool _1449_recOwned;
                        bool _1450_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1451_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out875;
                        bool _out876;
                        bool _out877;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out878;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out875, out _out876, out _out877, out _out878);
                        _1448_recursiveGen = _out875;
                        _1449_recOwned = _out876;
                        _1450_recErased = _out877;
                        _1451_recIdents = _out878;
                        Dafny.ISequence<Dafny.Rune> _1452_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out879;
                        _out879 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                        _1452_rhsType = _out879;
                        Dafny.ISequence<Dafny.Rune> _1453_uneraseFn;
                        _1453_uneraseFn = ((_1449_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1452_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1453_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1448_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1449_recOwned;
                        isErased = false;
                        readIdents = _1451_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out880;
                        bool _out881;
                        bool _out882;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1447_b), _1447_b, _528_toTpe), selfIdent, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                        s = _out880;
                        isOwned = _out881;
                        isErased = _out882;
                        readIdents = _out883;
                      }
                    }
                  }
                } else if (_source53.is_Nullable) {
                  DAST._IType _1454___mcc_h792 = _source53.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1455_recursiveGen;
                    bool _1456_recOwned;
                    bool _1457_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1458_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out884;
                    bool _out885;
                    bool _out886;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                    _1455_recursiveGen = _out884;
                    _1456_recOwned = _out885;
                    _1457_recErased = _out886;
                    _1458_recIdents = _out887;
                    if (!(_1456_recOwned)) {
                      _1455_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1455_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1455_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1457_recErased;
                    readIdents = _1458_recIdents;
                  }
                } else if (_source53.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1459___mcc_h794 = _source53.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1460_recursiveGen;
                    bool _1461_recOwned;
                    bool _1462_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1463_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out888;
                    bool _out889;
                    bool _out890;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                    _1460_recursiveGen = _out888;
                    _1461_recOwned = _out889;
                    _1462_recErased = _out890;
                    _1463_recIdents = _out891;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1460_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1461_recOwned;
                    isErased = _1462_recErased;
                    readIdents = _1463_recIdents;
                  }
                } else if (_source53.is_Array) {
                  DAST._IType _1464___mcc_h796 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1465_recursiveGen;
                    bool _1466_recOwned;
                    bool _1467_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1468_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out892;
                    bool _out893;
                    bool _out894;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                    _1465_recursiveGen = _out892;
                    _1466_recOwned = _out893;
                    _1467_recErased = _out894;
                    _1468_recIdents = _out895;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1465_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1466_recOwned;
                    isErased = _1467_recErased;
                    readIdents = _1468_recIdents;
                  }
                } else if (_source53.is_Seq) {
                  DAST._IType _1469___mcc_h798 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1470_recursiveGen;
                    bool _1471_recOwned;
                    bool _1472_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1473_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out896;
                    bool _out897;
                    bool _out898;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                    _1470_recursiveGen = _out896;
                    _1471_recOwned = _out897;
                    _1472_recErased = _out898;
                    _1473_recIdents = _out899;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1470_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1471_recOwned;
                    isErased = _1472_recErased;
                    readIdents = _1473_recIdents;
                  }
                } else if (_source53.is_Set) {
                  DAST._IType _1474___mcc_h800 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1475_recursiveGen;
                    bool _1476_recOwned;
                    bool _1477_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1478_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1475_recursiveGen = _out900;
                    _1476_recOwned = _out901;
                    _1477_recErased = _out902;
                    _1478_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1475_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1476_recOwned;
                    isErased = _1477_recErased;
                    readIdents = _1478_recIdents;
                  }
                } else if (_source53.is_Multiset) {
                  DAST._IType _1479___mcc_h802 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1480_recursiveGen;
                    bool _1481_recOwned;
                    bool _1482_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1483_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1480_recursiveGen = _out904;
                    _1481_recOwned = _out905;
                    _1482_recErased = _out906;
                    _1483_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1480_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1481_recOwned;
                    isErased = _1482_recErased;
                    readIdents = _1483_recIdents;
                  }
                } else if (_source53.is_Map) {
                  DAST._IType _1484___mcc_h804 = _source53.dtor_key;
                  DAST._IType _1485___mcc_h805 = _source53.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1486_recursiveGen;
                    bool _1487_recOwned;
                    bool _1488_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1489_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out908;
                    bool _out909;
                    bool _out910;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                    _1486_recursiveGen = _out908;
                    _1487_recOwned = _out909;
                    _1488_recErased = _out910;
                    _1489_recIdents = _out911;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1486_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1487_recOwned;
                    isErased = _1488_recErased;
                    readIdents = _1489_recIdents;
                  }
                } else if (_source53.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1490___mcc_h808 = _source53.dtor_args;
                  DAST._IType _1491___mcc_h809 = _source53.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1492_recursiveGen;
                    bool _1493_recOwned;
                    bool _1494_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1495_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out912;
                    bool _out913;
                    bool _out914;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out912, out _out913, out _out914, out _out915);
                    _1492_recursiveGen = _out912;
                    _1493_recOwned = _out913;
                    _1494_recErased = _out914;
                    _1495_recIdents = _out915;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1493_recOwned;
                    isErased = _1494_recErased;
                    readIdents = _1495_recIdents;
                  }
                } else if (_source53.is_Primitive) {
                  DAST._IPrimitive _1496___mcc_h812 = _source53.dtor_Primitive_a0;
                  DAST._IPrimitive _source55 = _1496___mcc_h812;
                  if (_source55.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1497_recursiveGen;
                      bool _1498_recOwned;
                      bool _1499_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1500_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out916;
                      bool _out917;
                      bool _out918;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                      _1497_recursiveGen = _out916;
                      _1498_recOwned = _out917;
                      _1499_recErased = _out918;
                      _1500_recIdents = _out919;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1497_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1498_recOwned;
                      isErased = _1499_recErased;
                      readIdents = _1500_recIdents;
                    }
                  } else if (_source55.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1501_recursiveGen;
                      bool _1502___v47;
                      bool _1503___v48;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1504_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out920;
                      bool _out921;
                      bool _out922;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, true, out _out920, out _out921, out _out922, out _out923);
                      _1501_recursiveGen = _out920;
                      _1502___v47 = _out921;
                      _1503___v48 = _out922;
                      _1504_recIdents = _out923;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1501_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1504_recIdents;
                    }
                  } else if (_source55.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1505_recursiveGen;
                      bool _1506_recOwned;
                      bool _1507_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1508_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out924;
                      bool _out925;
                      bool _out926;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out927;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out924, out _out925, out _out926, out _out927);
                      _1505_recursiveGen = _out924;
                      _1506_recOwned = _out925;
                      _1507_recErased = _out926;
                      _1508_recIdents = _out927;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1505_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1506_recOwned;
                      isErased = _1507_recErased;
                      readIdents = _1508_recIdents;
                    }
                  } else if (_source55.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1509_recursiveGen;
                      bool _1510_recOwned;
                      bool _1511_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1512_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out928;
                      bool _out929;
                      bool _out930;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out931;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out928, out _out929, out _out930, out _out931);
                      _1509_recursiveGen = _out928;
                      _1510_recOwned = _out929;
                      _1511_recErased = _out930;
                      _1512_recIdents = _out931;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1509_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1510_recOwned;
                      isErased = _1511_recErased;
                      readIdents = _1512_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1513_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out932;
                      _out932 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _1513_rhsType = _out932;
                      Dafny.ISequence<Dafny.Rune> _1514_recursiveGen;
                      bool _1515___v57;
                      bool _1516___v58;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1517_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out933;
                      bool _out934;
                      bool _out935;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, true, out _out933, out _out934, out _out935, out _out936);
                      _1514_recursiveGen = _out933;
                      _1515___v57 = _out934;
                      _1516___v58 = _out935;
                      _1517_recIdents = _out936;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1514_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1517_recIdents;
                    }
                  }
                } else if (_source53.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1518___mcc_h814 = _source53.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1519_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out937;
                    _out937 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                    _1519_rhsType = _out937;
                    Dafny.ISequence<Dafny.Rune> _1520_recursiveGen;
                    bool _1521___v52;
                    bool _1522___v53;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1523_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out938;
                    bool _out939;
                    bool _out940;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out941;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, true, out _out938, out _out939, out _out940, out _out941);
                    _1520_recursiveGen = _out938;
                    _1521___v52 = _out939;
                    _1522___v53 = _out940;
                    _1523_recIdents = _out941;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1519_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1520_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1523_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1524___mcc_h816 = _source53.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1525_recursiveGen;
                    bool _1526_recOwned;
                    bool _1527_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1528_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out942;
                    bool _out943;
                    bool _out944;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out945;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out942, out _out943, out _out944, out _out945);
                    _1525_recursiveGen = _out942;
                    _1526_recOwned = _out943;
                    _1527_recErased = _out944;
                    _1528_recIdents = _out945;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1525_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1526_recOwned;
                    isErased = _1527_recErased;
                    readIdents = _1528_recIdents;
                  }
                }
              } else if (_source52.is_Real) {
                DAST._IType _source56 = _536___mcc_h253;
                if (_source56.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1529___mcc_h818 = _source56.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1530___mcc_h819 = _source56.dtor_typeArgs;
                  DAST._IResolvedType _1531___mcc_h820 = _source56.dtor_resolved;
                  DAST._IResolvedType _source57 = _1531___mcc_h820;
                  if (_source57.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1532___mcc_h824 = _source57.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1533_recursiveGen;
                      bool _1534_recOwned;
                      bool _1535_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1536_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out946;
                      bool _out947;
                      bool _out948;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out949;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out946, out _out947, out _out948, out _out949);
                      _1533_recursiveGen = _out946;
                      _1534_recOwned = _out947;
                      _1535_recErased = _out948;
                      _1536_recIdents = _out949;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1533_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1534_recOwned;
                      isErased = _1535_recErased;
                      readIdents = _1536_recIdents;
                    }
                  } else if (_source57.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1537___mcc_h826 = _source57.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1538_recursiveGen;
                      bool _1539_recOwned;
                      bool _1540_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1541_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out950;
                      bool _out951;
                      bool _out952;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out953;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out950, out _out951, out _out952, out _out953);
                      _1538_recursiveGen = _out950;
                      _1539_recOwned = _out951;
                      _1540_recErased = _out952;
                      _1541_recIdents = _out953;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1538_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1539_recOwned;
                      isErased = _1540_recErased;
                      readIdents = _1541_recIdents;
                    }
                  } else {
                    DAST._IType _1542___mcc_h828 = _source57.dtor_Newtype_a0;
                    DAST._IType _1543_b = _1542___mcc_h828;
                    {
                      if (object.Equals(_529_fromTpe, _1543_b)) {
                        Dafny.ISequence<Dafny.Rune> _1544_recursiveGen;
                        bool _1545_recOwned;
                        bool _1546_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1547_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out954;
                        bool _out955;
                        bool _out956;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out957;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out954, out _out955, out _out956, out _out957);
                        _1544_recursiveGen = _out954;
                        _1545_recOwned = _out955;
                        _1546_recErased = _out956;
                        _1547_recIdents = _out957;
                        Dafny.ISequence<Dafny.Rune> _1548_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out958;
                        _out958 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                        _1548_rhsType = _out958;
                        Dafny.ISequence<Dafny.Rune> _1549_uneraseFn;
                        _1549_uneraseFn = ((_1545_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1548_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1549_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1544_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1545_recOwned;
                        isErased = false;
                        readIdents = _1547_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out959;
                        bool _out960;
                        bool _out961;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out962;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1543_b), _1543_b, _528_toTpe), selfIdent, @params, mustOwn, out _out959, out _out960, out _out961, out _out962);
                        s = _out959;
                        isOwned = _out960;
                        isErased = _out961;
                        readIdents = _out962;
                      }
                    }
                  }
                } else if (_source56.is_Nullable) {
                  DAST._IType _1550___mcc_h830 = _source56.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1551_recursiveGen;
                    bool _1552_recOwned;
                    bool _1553_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1554_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out963;
                    bool _out964;
                    bool _out965;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out966;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out963, out _out964, out _out965, out _out966);
                    _1551_recursiveGen = _out963;
                    _1552_recOwned = _out964;
                    _1553_recErased = _out965;
                    _1554_recIdents = _out966;
                    if (!(_1552_recOwned)) {
                      _1551_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1551_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1551_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1553_recErased;
                    readIdents = _1554_recIdents;
                  }
                } else if (_source56.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1555___mcc_h832 = _source56.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1556_recursiveGen;
                    bool _1557_recOwned;
                    bool _1558_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1559_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out967;
                    bool _out968;
                    bool _out969;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out970;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out967, out _out968, out _out969, out _out970);
                    _1556_recursiveGen = _out967;
                    _1557_recOwned = _out968;
                    _1558_recErased = _out969;
                    _1559_recIdents = _out970;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1556_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1557_recOwned;
                    isErased = _1558_recErased;
                    readIdents = _1559_recIdents;
                  }
                } else if (_source56.is_Array) {
                  DAST._IType _1560___mcc_h834 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1561_recursiveGen;
                    bool _1562_recOwned;
                    bool _1563_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1564_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out971;
                    bool _out972;
                    bool _out973;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out974;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out971, out _out972, out _out973, out _out974);
                    _1561_recursiveGen = _out971;
                    _1562_recOwned = _out972;
                    _1563_recErased = _out973;
                    _1564_recIdents = _out974;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1561_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1562_recOwned;
                    isErased = _1563_recErased;
                    readIdents = _1564_recIdents;
                  }
                } else if (_source56.is_Seq) {
                  DAST._IType _1565___mcc_h836 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1566_recursiveGen;
                    bool _1567_recOwned;
                    bool _1568_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1569_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out975;
                    bool _out976;
                    bool _out977;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out978;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out975, out _out976, out _out977, out _out978);
                    _1566_recursiveGen = _out975;
                    _1567_recOwned = _out976;
                    _1568_recErased = _out977;
                    _1569_recIdents = _out978;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1566_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1567_recOwned;
                    isErased = _1568_recErased;
                    readIdents = _1569_recIdents;
                  }
                } else if (_source56.is_Set) {
                  DAST._IType _1570___mcc_h838 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1571_recursiveGen;
                    bool _1572_recOwned;
                    bool _1573_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1574_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out979;
                    bool _out980;
                    bool _out981;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out982;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out979, out _out980, out _out981, out _out982);
                    _1571_recursiveGen = _out979;
                    _1572_recOwned = _out980;
                    _1573_recErased = _out981;
                    _1574_recIdents = _out982;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1571_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1572_recOwned;
                    isErased = _1573_recErased;
                    readIdents = _1574_recIdents;
                  }
                } else if (_source56.is_Multiset) {
                  DAST._IType _1575___mcc_h840 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1576_recursiveGen;
                    bool _1577_recOwned;
                    bool _1578_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1579_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out983;
                    bool _out984;
                    bool _out985;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out986;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out983, out _out984, out _out985, out _out986);
                    _1576_recursiveGen = _out983;
                    _1577_recOwned = _out984;
                    _1578_recErased = _out985;
                    _1579_recIdents = _out986;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1576_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1577_recOwned;
                    isErased = _1578_recErased;
                    readIdents = _1579_recIdents;
                  }
                } else if (_source56.is_Map) {
                  DAST._IType _1580___mcc_h842 = _source56.dtor_key;
                  DAST._IType _1581___mcc_h843 = _source56.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1582_recursiveGen;
                    bool _1583_recOwned;
                    bool _1584_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1585_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out987;
                    bool _out988;
                    bool _out989;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out990;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out987, out _out988, out _out989, out _out990);
                    _1582_recursiveGen = _out987;
                    _1583_recOwned = _out988;
                    _1584_recErased = _out989;
                    _1585_recIdents = _out990;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1582_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1583_recOwned;
                    isErased = _1584_recErased;
                    readIdents = _1585_recIdents;
                  }
                } else if (_source56.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1586___mcc_h846 = _source56.dtor_args;
                  DAST._IType _1587___mcc_h847 = _source56.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1588_recursiveGen;
                    bool _1589_recOwned;
                    bool _1590_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1591_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out991;
                    bool _out992;
                    bool _out993;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out994;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out991, out _out992, out _out993, out _out994);
                    _1588_recursiveGen = _out991;
                    _1589_recOwned = _out992;
                    _1590_recErased = _out993;
                    _1591_recIdents = _out994;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1588_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1589_recOwned;
                    isErased = _1590_recErased;
                    readIdents = _1591_recIdents;
                  }
                } else if (_source56.is_Primitive) {
                  DAST._IPrimitive _1592___mcc_h850 = _source56.dtor_Primitive_a0;
                  DAST._IPrimitive _source58 = _1592___mcc_h850;
                  if (_source58.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1593_recursiveGen;
                      bool _1594___v49;
                      bool _1595___v50;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1596_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out995;
                      bool _out996;
                      bool _out997;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out998;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, false, out _out995, out _out996, out _out997, out _out998);
                      _1593_recursiveGen = _out995;
                      _1594___v49 = _out996;
                      _1595___v50 = _out997;
                      _1596_recIdents = _out998;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1593_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1596_recIdents;
                    }
                  } else if (_source58.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1597_recursiveGen;
                      bool _1598_recOwned;
                      bool _1599_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1600_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out999;
                      bool _out1000;
                      bool _out1001;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1002;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out999, out _out1000, out _out1001, out _out1002);
                      _1597_recursiveGen = _out999;
                      _1598_recOwned = _out1000;
                      _1599_recErased = _out1001;
                      _1600_recIdents = _out1002;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1597_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1598_recOwned;
                      isErased = _1599_recErased;
                      readIdents = _1600_recIdents;
                    }
                  } else if (_source58.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1601_recursiveGen;
                      bool _1602_recOwned;
                      bool _1603_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1604_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1003;
                      bool _out1004;
                      bool _out1005;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1006;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1003, out _out1004, out _out1005, out _out1006);
                      _1601_recursiveGen = _out1003;
                      _1602_recOwned = _out1004;
                      _1603_recErased = _out1005;
                      _1604_recIdents = _out1006;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1601_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1602_recOwned;
                      isErased = _1603_recErased;
                      readIdents = _1604_recIdents;
                    }
                  } else if (_source58.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1605_recursiveGen;
                      bool _1606_recOwned;
                      bool _1607_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1608_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1007;
                      bool _out1008;
                      bool _out1009;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1010;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1007, out _out1008, out _out1009, out _out1010);
                      _1605_recursiveGen = _out1007;
                      _1606_recOwned = _out1008;
                      _1607_recErased = _out1009;
                      _1608_recIdents = _out1010;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1605_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1606_recOwned;
                      isErased = _1607_recErased;
                      readIdents = _1608_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1609_recursiveGen;
                      bool _1610_recOwned;
                      bool _1611_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1612_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1011;
                      bool _out1012;
                      bool _out1013;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1014;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1011, out _out1012, out _out1013, out _out1014);
                      _1609_recursiveGen = _out1011;
                      _1610_recOwned = _out1012;
                      _1611_recErased = _out1013;
                      _1612_recIdents = _out1014;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1610_recOwned;
                      isErased = _1611_recErased;
                      readIdents = _1612_recIdents;
                    }
                  }
                } else if (_source56.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1613___mcc_h852 = _source56.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1614_recursiveGen;
                    bool _1615_recOwned;
                    bool _1616_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1617_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1015;
                    bool _out1016;
                    bool _out1017;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1018;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1015, out _out1016, out _out1017, out _out1018);
                    _1614_recursiveGen = _out1015;
                    _1615_recOwned = _out1016;
                    _1616_recErased = _out1017;
                    _1617_recIdents = _out1018;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1614_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1615_recOwned;
                    isErased = _1616_recErased;
                    readIdents = _1617_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1618___mcc_h854 = _source56.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1619_recursiveGen;
                    bool _1620_recOwned;
                    bool _1621_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1622_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1019;
                    bool _out1020;
                    bool _out1021;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1022;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1019, out _out1020, out _out1021, out _out1022);
                    _1619_recursiveGen = _out1019;
                    _1620_recOwned = _out1020;
                    _1621_recErased = _out1021;
                    _1622_recIdents = _out1022;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1619_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1620_recOwned;
                    isErased = _1621_recErased;
                    readIdents = _1622_recIdents;
                  }
                }
              } else if (_source52.is_String) {
                DAST._IType _source59 = _536___mcc_h253;
                if (_source59.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1623___mcc_h856 = _source59.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1624___mcc_h857 = _source59.dtor_typeArgs;
                  DAST._IResolvedType _1625___mcc_h858 = _source59.dtor_resolved;
                  DAST._IResolvedType _source60 = _1625___mcc_h858;
                  if (_source60.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1626___mcc_h862 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1627_recursiveGen;
                      bool _1628_recOwned;
                      bool _1629_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1630_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1023;
                      bool _out1024;
                      bool _out1025;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1026;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1023, out _out1024, out _out1025, out _out1026);
                      _1627_recursiveGen = _out1023;
                      _1628_recOwned = _out1024;
                      _1629_recErased = _out1025;
                      _1630_recIdents = _out1026;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1627_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1628_recOwned;
                      isErased = _1629_recErased;
                      readIdents = _1630_recIdents;
                    }
                  } else if (_source60.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1631___mcc_h864 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1632_recursiveGen;
                      bool _1633_recOwned;
                      bool _1634_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1635_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1027;
                      bool _out1028;
                      bool _out1029;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1030;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1027, out _out1028, out _out1029, out _out1030);
                      _1632_recursiveGen = _out1027;
                      _1633_recOwned = _out1028;
                      _1634_recErased = _out1029;
                      _1635_recIdents = _out1030;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1632_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1633_recOwned;
                      isErased = _1634_recErased;
                      readIdents = _1635_recIdents;
                    }
                  } else {
                    DAST._IType _1636___mcc_h866 = _source60.dtor_Newtype_a0;
                    DAST._IType _1637_b = _1636___mcc_h866;
                    {
                      if (object.Equals(_529_fromTpe, _1637_b)) {
                        Dafny.ISequence<Dafny.Rune> _1638_recursiveGen;
                        bool _1639_recOwned;
                        bool _1640_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1641_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1031;
                        bool _out1032;
                        bool _out1033;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1034;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1031, out _out1032, out _out1033, out _out1034);
                        _1638_recursiveGen = _out1031;
                        _1639_recOwned = _out1032;
                        _1640_recErased = _out1033;
                        _1641_recIdents = _out1034;
                        Dafny.ISequence<Dafny.Rune> _1642_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1035;
                        _out1035 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                        _1642_rhsType = _out1035;
                        Dafny.ISequence<Dafny.Rune> _1643_uneraseFn;
                        _1643_uneraseFn = ((_1639_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1642_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1643_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1638_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1639_recOwned;
                        isErased = false;
                        readIdents = _1641_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1036;
                        bool _out1037;
                        bool _out1038;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1039;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1637_b), _1637_b, _528_toTpe), selfIdent, @params, mustOwn, out _out1036, out _out1037, out _out1038, out _out1039);
                        s = _out1036;
                        isOwned = _out1037;
                        isErased = _out1038;
                        readIdents = _out1039;
                      }
                    }
                  }
                } else if (_source59.is_Nullable) {
                  DAST._IType _1644___mcc_h868 = _source59.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1645_recursiveGen;
                    bool _1646_recOwned;
                    bool _1647_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1648_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1040;
                    bool _out1041;
                    bool _out1042;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1043;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1040, out _out1041, out _out1042, out _out1043);
                    _1645_recursiveGen = _out1040;
                    _1646_recOwned = _out1041;
                    _1647_recErased = _out1042;
                    _1648_recIdents = _out1043;
                    if (!(_1646_recOwned)) {
                      _1645_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1645_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1647_recErased;
                    readIdents = _1648_recIdents;
                  }
                } else if (_source59.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1649___mcc_h870 = _source59.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1650_recursiveGen;
                    bool _1651_recOwned;
                    bool _1652_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1653_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1044;
                    bool _out1045;
                    bool _out1046;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1047;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1044, out _out1045, out _out1046, out _out1047);
                    _1650_recursiveGen = _out1044;
                    _1651_recOwned = _out1045;
                    _1652_recErased = _out1046;
                    _1653_recIdents = _out1047;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1650_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1651_recOwned;
                    isErased = _1652_recErased;
                    readIdents = _1653_recIdents;
                  }
                } else if (_source59.is_Array) {
                  DAST._IType _1654___mcc_h872 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1655_recursiveGen;
                    bool _1656_recOwned;
                    bool _1657_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1658_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1048;
                    bool _out1049;
                    bool _out1050;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1051;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1048, out _out1049, out _out1050, out _out1051);
                    _1655_recursiveGen = _out1048;
                    _1656_recOwned = _out1049;
                    _1657_recErased = _out1050;
                    _1658_recIdents = _out1051;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1655_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1656_recOwned;
                    isErased = _1657_recErased;
                    readIdents = _1658_recIdents;
                  }
                } else if (_source59.is_Seq) {
                  DAST._IType _1659___mcc_h874 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1660_recursiveGen;
                    bool _1661_recOwned;
                    bool _1662_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1663_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1052;
                    bool _out1053;
                    bool _out1054;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1055;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1052, out _out1053, out _out1054, out _out1055);
                    _1660_recursiveGen = _out1052;
                    _1661_recOwned = _out1053;
                    _1662_recErased = _out1054;
                    _1663_recIdents = _out1055;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1660_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1661_recOwned;
                    isErased = _1662_recErased;
                    readIdents = _1663_recIdents;
                  }
                } else if (_source59.is_Set) {
                  DAST._IType _1664___mcc_h876 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1665_recursiveGen;
                    bool _1666_recOwned;
                    bool _1667_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1668_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1056;
                    bool _out1057;
                    bool _out1058;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1059;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1056, out _out1057, out _out1058, out _out1059);
                    _1665_recursiveGen = _out1056;
                    _1666_recOwned = _out1057;
                    _1667_recErased = _out1058;
                    _1668_recIdents = _out1059;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1665_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1666_recOwned;
                    isErased = _1667_recErased;
                    readIdents = _1668_recIdents;
                  }
                } else if (_source59.is_Multiset) {
                  DAST._IType _1669___mcc_h878 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1670_recursiveGen;
                    bool _1671_recOwned;
                    bool _1672_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1673_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1060;
                    bool _out1061;
                    bool _out1062;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1063;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1060, out _out1061, out _out1062, out _out1063);
                    _1670_recursiveGen = _out1060;
                    _1671_recOwned = _out1061;
                    _1672_recErased = _out1062;
                    _1673_recIdents = _out1063;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1670_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1671_recOwned;
                    isErased = _1672_recErased;
                    readIdents = _1673_recIdents;
                  }
                } else if (_source59.is_Map) {
                  DAST._IType _1674___mcc_h880 = _source59.dtor_key;
                  DAST._IType _1675___mcc_h881 = _source59.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1676_recursiveGen;
                    bool _1677_recOwned;
                    bool _1678_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1679_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1064;
                    bool _out1065;
                    bool _out1066;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1067;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1064, out _out1065, out _out1066, out _out1067);
                    _1676_recursiveGen = _out1064;
                    _1677_recOwned = _out1065;
                    _1678_recErased = _out1066;
                    _1679_recIdents = _out1067;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1676_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1677_recOwned;
                    isErased = _1678_recErased;
                    readIdents = _1679_recIdents;
                  }
                } else if (_source59.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1680___mcc_h884 = _source59.dtor_args;
                  DAST._IType _1681___mcc_h885 = _source59.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1682_recursiveGen;
                    bool _1683_recOwned;
                    bool _1684_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1685_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1068;
                    bool _out1069;
                    bool _out1070;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1068, out _out1069, out _out1070, out _out1071);
                    _1682_recursiveGen = _out1068;
                    _1683_recOwned = _out1069;
                    _1684_recErased = _out1070;
                    _1685_recIdents = _out1071;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1683_recOwned;
                    isErased = _1684_recErased;
                    readIdents = _1685_recIdents;
                  }
                } else if (_source59.is_Primitive) {
                  DAST._IPrimitive _1686___mcc_h888 = _source59.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1687_recursiveGen;
                    bool _1688_recOwned;
                    bool _1689_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1690_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1072;
                    bool _out1073;
                    bool _out1074;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                    _1687_recursiveGen = _out1072;
                    _1688_recOwned = _out1073;
                    _1689_recErased = _out1074;
                    _1690_recIdents = _out1075;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1687_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1688_recOwned;
                    isErased = _1689_recErased;
                    readIdents = _1690_recIdents;
                  }
                } else if (_source59.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1691___mcc_h890 = _source59.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1692_recursiveGen;
                    bool _1693_recOwned;
                    bool _1694_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1695_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1076;
                    bool _out1077;
                    bool _out1078;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                    _1692_recursiveGen = _out1076;
                    _1693_recOwned = _out1077;
                    _1694_recErased = _out1078;
                    _1695_recIdents = _out1079;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1692_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1693_recOwned;
                    isErased = _1694_recErased;
                    readIdents = _1695_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1696___mcc_h892 = _source59.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1697_recursiveGen;
                    bool _1698_recOwned;
                    bool _1699_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1700_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1080;
                    bool _out1081;
                    bool _out1082;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                    _1697_recursiveGen = _out1080;
                    _1698_recOwned = _out1081;
                    _1699_recErased = _out1082;
                    _1700_recIdents = _out1083;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1697_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1698_recOwned;
                    isErased = _1699_recErased;
                    readIdents = _1700_recIdents;
                  }
                }
              } else if (_source52.is_Bool) {
                DAST._IType _source61 = _536___mcc_h253;
                if (_source61.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1701___mcc_h894 = _source61.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1702___mcc_h895 = _source61.dtor_typeArgs;
                  DAST._IResolvedType _1703___mcc_h896 = _source61.dtor_resolved;
                  DAST._IResolvedType _source62 = _1703___mcc_h896;
                  if (_source62.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1704___mcc_h900 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1705_recursiveGen;
                      bool _1706_recOwned;
                      bool _1707_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1708_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1084;
                      bool _out1085;
                      bool _out1086;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                      _1705_recursiveGen = _out1084;
                      _1706_recOwned = _out1085;
                      _1707_recErased = _out1086;
                      _1708_recIdents = _out1087;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1705_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1706_recOwned;
                      isErased = _1707_recErased;
                      readIdents = _1708_recIdents;
                    }
                  } else if (_source62.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1709___mcc_h902 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1710_recursiveGen;
                      bool _1711_recOwned;
                      bool _1712_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1713_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1088;
                      bool _out1089;
                      bool _out1090;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1091;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1088, out _out1089, out _out1090, out _out1091);
                      _1710_recursiveGen = _out1088;
                      _1711_recOwned = _out1089;
                      _1712_recErased = _out1090;
                      _1713_recIdents = _out1091;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1710_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1711_recOwned;
                      isErased = _1712_recErased;
                      readIdents = _1713_recIdents;
                    }
                  } else {
                    DAST._IType _1714___mcc_h904 = _source62.dtor_Newtype_a0;
                    DAST._IType _1715_b = _1714___mcc_h904;
                    {
                      if (object.Equals(_529_fromTpe, _1715_b)) {
                        Dafny.ISequence<Dafny.Rune> _1716_recursiveGen;
                        bool _1717_recOwned;
                        bool _1718_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1719_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1092;
                        bool _out1093;
                        bool _out1094;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1095;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1092, out _out1093, out _out1094, out _out1095);
                        _1716_recursiveGen = _out1092;
                        _1717_recOwned = _out1093;
                        _1718_recErased = _out1094;
                        _1719_recIdents = _out1095;
                        Dafny.ISequence<Dafny.Rune> _1720_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1096;
                        _out1096 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                        _1720_rhsType = _out1096;
                        Dafny.ISequence<Dafny.Rune> _1721_uneraseFn;
                        _1721_uneraseFn = ((_1717_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1720_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1721_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1716_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1717_recOwned;
                        isErased = false;
                        readIdents = _1719_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1097;
                        bool _out1098;
                        bool _out1099;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1100;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1715_b), _1715_b, _528_toTpe), selfIdent, @params, mustOwn, out _out1097, out _out1098, out _out1099, out _out1100);
                        s = _out1097;
                        isOwned = _out1098;
                        isErased = _out1099;
                        readIdents = _out1100;
                      }
                    }
                  }
                } else if (_source61.is_Nullable) {
                  DAST._IType _1722___mcc_h906 = _source61.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1723_recursiveGen;
                    bool _1724_recOwned;
                    bool _1725_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1726_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1101;
                    bool _out1102;
                    bool _out1103;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1104;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1101, out _out1102, out _out1103, out _out1104);
                    _1723_recursiveGen = _out1101;
                    _1724_recOwned = _out1102;
                    _1725_recErased = _out1103;
                    _1726_recIdents = _out1104;
                    if (!(_1724_recOwned)) {
                      _1723_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1723_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1723_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1725_recErased;
                    readIdents = _1726_recIdents;
                  }
                } else if (_source61.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1727___mcc_h908 = _source61.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1728_recursiveGen;
                    bool _1729_recOwned;
                    bool _1730_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1731_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1105;
                    bool _out1106;
                    bool _out1107;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1108;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1105, out _out1106, out _out1107, out _out1108);
                    _1728_recursiveGen = _out1105;
                    _1729_recOwned = _out1106;
                    _1730_recErased = _out1107;
                    _1731_recIdents = _out1108;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1728_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1729_recOwned;
                    isErased = _1730_recErased;
                    readIdents = _1731_recIdents;
                  }
                } else if (_source61.is_Array) {
                  DAST._IType _1732___mcc_h910 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1733_recursiveGen;
                    bool _1734_recOwned;
                    bool _1735_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1736_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1109;
                    bool _out1110;
                    bool _out1111;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                    _1733_recursiveGen = _out1109;
                    _1734_recOwned = _out1110;
                    _1735_recErased = _out1111;
                    _1736_recIdents = _out1112;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1733_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1734_recOwned;
                    isErased = _1735_recErased;
                    readIdents = _1736_recIdents;
                  }
                } else if (_source61.is_Seq) {
                  DAST._IType _1737___mcc_h912 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1738_recursiveGen;
                    bool _1739_recOwned;
                    bool _1740_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1741_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1113;
                    bool _out1114;
                    bool _out1115;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                    _1738_recursiveGen = _out1113;
                    _1739_recOwned = _out1114;
                    _1740_recErased = _out1115;
                    _1741_recIdents = _out1116;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1738_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1739_recOwned;
                    isErased = _1740_recErased;
                    readIdents = _1741_recIdents;
                  }
                } else if (_source61.is_Set) {
                  DAST._IType _1742___mcc_h914 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1743_recursiveGen;
                    bool _1744_recOwned;
                    bool _1745_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1746_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1117;
                    bool _out1118;
                    bool _out1119;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                    _1743_recursiveGen = _out1117;
                    _1744_recOwned = _out1118;
                    _1745_recErased = _out1119;
                    _1746_recIdents = _out1120;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1743_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1744_recOwned;
                    isErased = _1745_recErased;
                    readIdents = _1746_recIdents;
                  }
                } else if (_source61.is_Multiset) {
                  DAST._IType _1747___mcc_h916 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1748_recursiveGen;
                    bool _1749_recOwned;
                    bool _1750_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1751_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1121;
                    bool _out1122;
                    bool _out1123;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                    _1748_recursiveGen = _out1121;
                    _1749_recOwned = _out1122;
                    _1750_recErased = _out1123;
                    _1751_recIdents = _out1124;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1748_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1749_recOwned;
                    isErased = _1750_recErased;
                    readIdents = _1751_recIdents;
                  }
                } else if (_source61.is_Map) {
                  DAST._IType _1752___mcc_h918 = _source61.dtor_key;
                  DAST._IType _1753___mcc_h919 = _source61.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1754_recursiveGen;
                    bool _1755_recOwned;
                    bool _1756_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1757_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1125;
                    bool _out1126;
                    bool _out1127;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                    _1754_recursiveGen = _out1125;
                    _1755_recOwned = _out1126;
                    _1756_recErased = _out1127;
                    _1757_recIdents = _out1128;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1754_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1755_recOwned;
                    isErased = _1756_recErased;
                    readIdents = _1757_recIdents;
                  }
                } else if (_source61.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1758___mcc_h922 = _source61.dtor_args;
                  DAST._IType _1759___mcc_h923 = _source61.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1760_recursiveGen;
                    bool _1761_recOwned;
                    bool _1762_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1763_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1129;
                    bool _out1130;
                    bool _out1131;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                    _1760_recursiveGen = _out1129;
                    _1761_recOwned = _out1130;
                    _1762_recErased = _out1131;
                    _1763_recIdents = _out1132;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1760_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1761_recOwned;
                    isErased = _1762_recErased;
                    readIdents = _1763_recIdents;
                  }
                } else if (_source61.is_Primitive) {
                  DAST._IPrimitive _1764___mcc_h926 = _source61.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1765_recursiveGen;
                    bool _1766_recOwned;
                    bool _1767_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1768_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1133;
                    bool _out1134;
                    bool _out1135;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                    _1765_recursiveGen = _out1133;
                    _1766_recOwned = _out1134;
                    _1767_recErased = _out1135;
                    _1768_recIdents = _out1136;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1765_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1766_recOwned;
                    isErased = _1767_recErased;
                    readIdents = _1768_recIdents;
                  }
                } else if (_source61.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1769___mcc_h928 = _source61.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1770_recursiveGen;
                    bool _1771_recOwned;
                    bool _1772_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1773_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1137;
                    bool _out1138;
                    bool _out1139;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                    _1770_recursiveGen = _out1137;
                    _1771_recOwned = _out1138;
                    _1772_recErased = _out1139;
                    _1773_recIdents = _out1140;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1770_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1771_recOwned;
                    isErased = _1772_recErased;
                    readIdents = _1773_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1774___mcc_h930 = _source61.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1775_recursiveGen;
                    bool _1776_recOwned;
                    bool _1777_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1778_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1141;
                    bool _out1142;
                    bool _out1143;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1144;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1141, out _out1142, out _out1143, out _out1144);
                    _1775_recursiveGen = _out1141;
                    _1776_recOwned = _out1142;
                    _1777_recErased = _out1143;
                    _1778_recIdents = _out1144;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1775_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1776_recOwned;
                    isErased = _1777_recErased;
                    readIdents = _1778_recIdents;
                  }
                }
              } else {
                DAST._IType _source63 = _536___mcc_h253;
                if (_source63.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1779___mcc_h932 = _source63.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1780___mcc_h933 = _source63.dtor_typeArgs;
                  DAST._IResolvedType _1781___mcc_h934 = _source63.dtor_resolved;
                  DAST._IResolvedType _source64 = _1781___mcc_h934;
                  if (_source64.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1782___mcc_h938 = _source64.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1783_recursiveGen;
                      bool _1784_recOwned;
                      bool _1785_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1786_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1145;
                      bool _out1146;
                      bool _out1147;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1148;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1145, out _out1146, out _out1147, out _out1148);
                      _1783_recursiveGen = _out1145;
                      _1784_recOwned = _out1146;
                      _1785_recErased = _out1147;
                      _1786_recIdents = _out1148;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1783_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1784_recOwned;
                      isErased = _1785_recErased;
                      readIdents = _1786_recIdents;
                    }
                  } else if (_source64.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1787___mcc_h940 = _source64.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1788_recursiveGen;
                      bool _1789_recOwned;
                      bool _1790_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1791_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1149;
                      bool _out1150;
                      bool _out1151;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1152;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1149, out _out1150, out _out1151, out _out1152);
                      _1788_recursiveGen = _out1149;
                      _1789_recOwned = _out1150;
                      _1790_recErased = _out1151;
                      _1791_recIdents = _out1152;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1788_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1789_recOwned;
                      isErased = _1790_recErased;
                      readIdents = _1791_recIdents;
                    }
                  } else {
                    DAST._IType _1792___mcc_h942 = _source64.dtor_Newtype_a0;
                    DAST._IType _1793_b = _1792___mcc_h942;
                    {
                      if (object.Equals(_529_fromTpe, _1793_b)) {
                        Dafny.ISequence<Dafny.Rune> _1794_recursiveGen;
                        bool _1795_recOwned;
                        bool _1796_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1797_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1153;
                        bool _out1154;
                        bool _out1155;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1156;
                        DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1153, out _out1154, out _out1155, out _out1156);
                        _1794_recursiveGen = _out1153;
                        _1795_recOwned = _out1154;
                        _1796_recErased = _out1155;
                        _1797_recIdents = _out1156;
                        Dafny.ISequence<Dafny.Rune> _1798_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1157;
                        _out1157 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                        _1798_rhsType = _out1157;
                        Dafny.ISequence<Dafny.Rune> _1799_uneraseFn;
                        _1799_uneraseFn = ((_1795_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1798_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1799_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1794_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1795_recOwned;
                        isErased = false;
                        readIdents = _1797_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1158;
                        bool _out1159;
                        bool _out1160;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1793_b), _1793_b, _528_toTpe), selfIdent, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                        s = _out1158;
                        isOwned = _out1159;
                        isErased = _out1160;
                        readIdents = _out1161;
                      }
                    }
                  }
                } else if (_source63.is_Nullable) {
                  DAST._IType _1800___mcc_h944 = _source63.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1801_recursiveGen;
                    bool _1802_recOwned;
                    bool _1803_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1804_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1162;
                    bool _out1163;
                    bool _out1164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                    _1801_recursiveGen = _out1162;
                    _1802_recOwned = _out1163;
                    _1803_recErased = _out1164;
                    _1804_recIdents = _out1165;
                    if (!(_1802_recOwned)) {
                      _1801_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1801_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1801_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1803_recErased;
                    readIdents = _1804_recIdents;
                  }
                } else if (_source63.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1805___mcc_h946 = _source63.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1806_recursiveGen;
                    bool _1807_recOwned;
                    bool _1808_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1809_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1166;
                    bool _out1167;
                    bool _out1168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1169;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1166, out _out1167, out _out1168, out _out1169);
                    _1806_recursiveGen = _out1166;
                    _1807_recOwned = _out1167;
                    _1808_recErased = _out1168;
                    _1809_recIdents = _out1169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1806_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1807_recOwned;
                    isErased = _1808_recErased;
                    readIdents = _1809_recIdents;
                  }
                } else if (_source63.is_Array) {
                  DAST._IType _1810___mcc_h948 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1811_recursiveGen;
                    bool _1812_recOwned;
                    bool _1813_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1814_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1170;
                    bool _out1171;
                    bool _out1172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1173;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1170, out _out1171, out _out1172, out _out1173);
                    _1811_recursiveGen = _out1170;
                    _1812_recOwned = _out1171;
                    _1813_recErased = _out1172;
                    _1814_recIdents = _out1173;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1811_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1812_recOwned;
                    isErased = _1813_recErased;
                    readIdents = _1814_recIdents;
                  }
                } else if (_source63.is_Seq) {
                  DAST._IType _1815___mcc_h950 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1816_recursiveGen;
                    bool _1817_recOwned;
                    bool _1818_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1819_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1174;
                    bool _out1175;
                    bool _out1176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1177;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1174, out _out1175, out _out1176, out _out1177);
                    _1816_recursiveGen = _out1174;
                    _1817_recOwned = _out1175;
                    _1818_recErased = _out1176;
                    _1819_recIdents = _out1177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1816_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1817_recOwned;
                    isErased = _1818_recErased;
                    readIdents = _1819_recIdents;
                  }
                } else if (_source63.is_Set) {
                  DAST._IType _1820___mcc_h952 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1821_recursiveGen;
                    bool _1822_recOwned;
                    bool _1823_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1824_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1178;
                    bool _out1179;
                    bool _out1180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1181;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1178, out _out1179, out _out1180, out _out1181);
                    _1821_recursiveGen = _out1178;
                    _1822_recOwned = _out1179;
                    _1823_recErased = _out1180;
                    _1824_recIdents = _out1181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1821_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1822_recOwned;
                    isErased = _1823_recErased;
                    readIdents = _1824_recIdents;
                  }
                } else if (_source63.is_Multiset) {
                  DAST._IType _1825___mcc_h954 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1826_recursiveGen;
                    bool _1827_recOwned;
                    bool _1828_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1829_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1182;
                    bool _out1183;
                    bool _out1184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1185;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1182, out _out1183, out _out1184, out _out1185);
                    _1826_recursiveGen = _out1182;
                    _1827_recOwned = _out1183;
                    _1828_recErased = _out1184;
                    _1829_recIdents = _out1185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1826_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1827_recOwned;
                    isErased = _1828_recErased;
                    readIdents = _1829_recIdents;
                  }
                } else if (_source63.is_Map) {
                  DAST._IType _1830___mcc_h956 = _source63.dtor_key;
                  DAST._IType _1831___mcc_h957 = _source63.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1832_recursiveGen;
                    bool _1833_recOwned;
                    bool _1834_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1835_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1186;
                    bool _out1187;
                    bool _out1188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1189;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1186, out _out1187, out _out1188, out _out1189);
                    _1832_recursiveGen = _out1186;
                    _1833_recOwned = _out1187;
                    _1834_recErased = _out1188;
                    _1835_recIdents = _out1189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1832_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1833_recOwned;
                    isErased = _1834_recErased;
                    readIdents = _1835_recIdents;
                  }
                } else if (_source63.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1836___mcc_h960 = _source63.dtor_args;
                  DAST._IType _1837___mcc_h961 = _source63.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1838_recursiveGen;
                    bool _1839_recOwned;
                    bool _1840_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1841_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1190;
                    bool _out1191;
                    bool _out1192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1193;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1190, out _out1191, out _out1192, out _out1193);
                    _1838_recursiveGen = _out1190;
                    _1839_recOwned = _out1191;
                    _1840_recErased = _out1192;
                    _1841_recIdents = _out1193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1838_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1839_recOwned;
                    isErased = _1840_recErased;
                    readIdents = _1841_recIdents;
                  }
                } else if (_source63.is_Primitive) {
                  DAST._IPrimitive _1842___mcc_h964 = _source63.dtor_Primitive_a0;
                  DAST._IPrimitive _source65 = _1842___mcc_h964;
                  if (_source65.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1843_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1194;
                      _out1194 = DCOMP.COMP.GenType(_529_fromTpe, true, false);
                      _1843_rhsType = _out1194;
                      Dafny.ISequence<Dafny.Rune> _1844_recursiveGen;
                      bool _1845___v59;
                      bool _1846___v60;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1847_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1195;
                      bool _out1196;
                      bool _out1197;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1198;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, true, out _out1195, out _out1196, out _out1197, out _out1198);
                      _1844_recursiveGen = _out1195;
                      _1845___v59 = _out1196;
                      _1846___v60 = _out1197;
                      _1847_recIdents = _out1198;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1844_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1847_recIdents;
                    }
                  } else if (_source65.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1848_recursiveGen;
                      bool _1849_recOwned;
                      bool _1850_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1851_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1199;
                      bool _out1200;
                      bool _out1201;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1202;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1199, out _out1200, out _out1201, out _out1202);
                      _1848_recursiveGen = _out1199;
                      _1849_recOwned = _out1200;
                      _1850_recErased = _out1201;
                      _1851_recIdents = _out1202;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1848_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1849_recOwned;
                      isErased = _1850_recErased;
                      readIdents = _1851_recIdents;
                    }
                  } else if (_source65.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1852_recursiveGen;
                      bool _1853_recOwned;
                      bool _1854_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1855_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      bool _out1204;
                      bool _out1205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1206;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1203, out _out1204, out _out1205, out _out1206);
                      _1852_recursiveGen = _out1203;
                      _1853_recOwned = _out1204;
                      _1854_recErased = _out1205;
                      _1855_recIdents = _out1206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1852_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1853_recOwned;
                      isErased = _1854_recErased;
                      readIdents = _1855_recIdents;
                    }
                  } else if (_source65.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1856_recursiveGen;
                      bool _1857_recOwned;
                      bool _1858_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1859_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1207;
                      bool _out1208;
                      bool _out1209;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1210;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1207, out _out1208, out _out1209, out _out1210);
                      _1856_recursiveGen = _out1207;
                      _1857_recOwned = _out1208;
                      _1858_recErased = _out1209;
                      _1859_recIdents = _out1210;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1856_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1857_recOwned;
                      isErased = _1858_recErased;
                      readIdents = _1859_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1860_recursiveGen;
                      bool _1861_recOwned;
                      bool _1862_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1863_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1211;
                      bool _out1212;
                      bool _out1213;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1214;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1211, out _out1212, out _out1213, out _out1214);
                      _1860_recursiveGen = _out1211;
                      _1861_recOwned = _out1212;
                      _1862_recErased = _out1213;
                      _1863_recIdents = _out1214;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1860_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1861_recOwned;
                      isErased = _1862_recErased;
                      readIdents = _1863_recIdents;
                    }
                  }
                } else if (_source63.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1864___mcc_h966 = _source63.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1865_recursiveGen;
                    bool _1866_recOwned;
                    bool _1867_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1868_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1215;
                    bool _out1216;
                    bool _out1217;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1218;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1215, out _out1216, out _out1217, out _out1218);
                    _1865_recursiveGen = _out1215;
                    _1866_recOwned = _out1216;
                    _1867_recErased = _out1217;
                    _1868_recIdents = _out1218;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1865_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1866_recOwned;
                    isErased = _1867_recErased;
                    readIdents = _1868_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1869___mcc_h968 = _source63.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1870_recursiveGen;
                    bool _1871_recOwned;
                    bool _1872_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1873_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1219;
                    bool _out1220;
                    bool _out1221;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1222;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1219, out _out1220, out _out1221, out _out1222);
                    _1870_recursiveGen = _out1219;
                    _1871_recOwned = _out1220;
                    _1872_recErased = _out1221;
                    _1873_recIdents = _out1222;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1870_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1871_recOwned;
                    isErased = _1872_recErased;
                    readIdents = _1873_recIdents;
                  }
                }
              }
            } else if (_source28.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1874___mcc_h970 = _source28.dtor_Passthrough_a0;
              DAST._IType _source66 = _536___mcc_h253;
              if (_source66.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1875___mcc_h974 = _source66.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1876___mcc_h975 = _source66.dtor_typeArgs;
                DAST._IResolvedType _1877___mcc_h976 = _source66.dtor_resolved;
                DAST._IResolvedType _source67 = _1877___mcc_h976;
                if (_source67.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1878___mcc_h980 = _source67.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1879_recursiveGen;
                    bool _1880_recOwned;
                    bool _1881_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1882_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1223;
                    bool _out1224;
                    bool _out1225;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1226;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1223, out _out1224, out _out1225, out _out1226);
                    _1879_recursiveGen = _out1223;
                    _1880_recOwned = _out1224;
                    _1881_recErased = _out1225;
                    _1882_recIdents = _out1226;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1879_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1880_recOwned;
                    isErased = _1881_recErased;
                    readIdents = _1882_recIdents;
                  }
                } else if (_source67.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1883___mcc_h982 = _source67.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1884_recursiveGen;
                    bool _1885_recOwned;
                    bool _1886_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1887_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1227;
                    bool _out1228;
                    bool _out1229;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1230;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1227, out _out1228, out _out1229, out _out1230);
                    _1884_recursiveGen = _out1227;
                    _1885_recOwned = _out1228;
                    _1886_recErased = _out1229;
                    _1887_recIdents = _out1230;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1884_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1885_recOwned;
                    isErased = _1886_recErased;
                    readIdents = _1887_recIdents;
                  }
                } else {
                  DAST._IType _1888___mcc_h984 = _source67.dtor_Newtype_a0;
                  DAST._IType _1889_b = _1888___mcc_h984;
                  {
                    if (object.Equals(_529_fromTpe, _1889_b)) {
                      Dafny.ISequence<Dafny.Rune> _1890_recursiveGen;
                      bool _1891_recOwned;
                      bool _1892_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1893_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1231;
                      bool _out1232;
                      bool _out1233;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1234;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1231, out _out1232, out _out1233, out _out1234);
                      _1890_recursiveGen = _out1231;
                      _1891_recOwned = _out1232;
                      _1892_recErased = _out1233;
                      _1893_recIdents = _out1234;
                      Dafny.ISequence<Dafny.Rune> _1894_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1235;
                      _out1235 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _1894_rhsType = _out1235;
                      Dafny.ISequence<Dafny.Rune> _1895_uneraseFn;
                      _1895_uneraseFn = ((_1891_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1894_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1895_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1890_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1891_recOwned;
                      isErased = false;
                      readIdents = _1893_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1236;
                      bool _out1237;
                      bool _out1238;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1889_b), _1889_b, _528_toTpe), selfIdent, @params, mustOwn, out _out1236, out _out1237, out _out1238, out _out1239);
                      s = _out1236;
                      isOwned = _out1237;
                      isErased = _out1238;
                      readIdents = _out1239;
                    }
                  }
                }
              } else if (_source66.is_Nullable) {
                DAST._IType _1896___mcc_h986 = _source66.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1897_recursiveGen;
                  bool _1898_recOwned;
                  bool _1899_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1900_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1240;
                  bool _out1241;
                  bool _out1242;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
                  _1897_recursiveGen = _out1240;
                  _1898_recOwned = _out1241;
                  _1899_recErased = _out1242;
                  _1900_recIdents = _out1243;
                  if (!(_1898_recOwned)) {
                    _1897_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1897_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1897_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1899_recErased;
                  readIdents = _1900_recIdents;
                }
              } else if (_source66.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1901___mcc_h988 = _source66.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1902_recursiveGen;
                  bool _1903_recOwned;
                  bool _1904_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1905_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1244;
                  bool _out1245;
                  bool _out1246;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1244, out _out1245, out _out1246, out _out1247);
                  _1902_recursiveGen = _out1244;
                  _1903_recOwned = _out1245;
                  _1904_recErased = _out1246;
                  _1905_recIdents = _out1247;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1902_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1903_recOwned;
                  isErased = _1904_recErased;
                  readIdents = _1905_recIdents;
                }
              } else if (_source66.is_Array) {
                DAST._IType _1906___mcc_h990 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1907_recursiveGen;
                  bool _1908_recOwned;
                  bool _1909_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1910_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1248;
                  bool _out1249;
                  bool _out1250;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1248, out _out1249, out _out1250, out _out1251);
                  _1907_recursiveGen = _out1248;
                  _1908_recOwned = _out1249;
                  _1909_recErased = _out1250;
                  _1910_recIdents = _out1251;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1907_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1908_recOwned;
                  isErased = _1909_recErased;
                  readIdents = _1910_recIdents;
                }
              } else if (_source66.is_Seq) {
                DAST._IType _1911___mcc_h992 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1912_recursiveGen;
                  bool _1913_recOwned;
                  bool _1914_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1915_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1252;
                  bool _out1253;
                  bool _out1254;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1252, out _out1253, out _out1254, out _out1255);
                  _1912_recursiveGen = _out1252;
                  _1913_recOwned = _out1253;
                  _1914_recErased = _out1254;
                  _1915_recIdents = _out1255;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1912_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1913_recOwned;
                  isErased = _1914_recErased;
                  readIdents = _1915_recIdents;
                }
              } else if (_source66.is_Set) {
                DAST._IType _1916___mcc_h994 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1917_recursiveGen;
                  bool _1918_recOwned;
                  bool _1919_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1920_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1256;
                  bool _out1257;
                  bool _out1258;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1256, out _out1257, out _out1258, out _out1259);
                  _1917_recursiveGen = _out1256;
                  _1918_recOwned = _out1257;
                  _1919_recErased = _out1258;
                  _1920_recIdents = _out1259;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1917_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1918_recOwned;
                  isErased = _1919_recErased;
                  readIdents = _1920_recIdents;
                }
              } else if (_source66.is_Multiset) {
                DAST._IType _1921___mcc_h996 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1922_recursiveGen;
                  bool _1923_recOwned;
                  bool _1924_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1925_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1260;
                  bool _out1261;
                  bool _out1262;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1260, out _out1261, out _out1262, out _out1263);
                  _1922_recursiveGen = _out1260;
                  _1923_recOwned = _out1261;
                  _1924_recErased = _out1262;
                  _1925_recIdents = _out1263;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1922_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1923_recOwned;
                  isErased = _1924_recErased;
                  readIdents = _1925_recIdents;
                }
              } else if (_source66.is_Map) {
                DAST._IType _1926___mcc_h998 = _source66.dtor_key;
                DAST._IType _1927___mcc_h999 = _source66.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1928_recursiveGen;
                  bool _1929_recOwned;
                  bool _1930_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1931_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1264;
                  bool _out1265;
                  bool _out1266;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1267;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1264, out _out1265, out _out1266, out _out1267);
                  _1928_recursiveGen = _out1264;
                  _1929_recOwned = _out1265;
                  _1930_recErased = _out1266;
                  _1931_recIdents = _out1267;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1928_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1929_recOwned;
                  isErased = _1930_recErased;
                  readIdents = _1931_recIdents;
                }
              } else if (_source66.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1932___mcc_h1002 = _source66.dtor_args;
                DAST._IType _1933___mcc_h1003 = _source66.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1934_recursiveGen;
                  bool _1935_recOwned;
                  bool _1936_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1937_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1268;
                  bool _out1269;
                  bool _out1270;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1271;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1268, out _out1269, out _out1270, out _out1271);
                  _1934_recursiveGen = _out1268;
                  _1935_recOwned = _out1269;
                  _1936_recErased = _out1270;
                  _1937_recIdents = _out1271;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1934_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1935_recOwned;
                  isErased = _1936_recErased;
                  readIdents = _1937_recIdents;
                }
              } else if (_source66.is_Primitive) {
                DAST._IPrimitive _1938___mcc_h1006 = _source66.dtor_Primitive_a0;
                DAST._IPrimitive _source68 = _1938___mcc_h1006;
                if (_source68.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1939_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1272;
                    _out1272 = DCOMP.COMP.GenType(_529_fromTpe, true, false);
                    _1939_rhsType = _out1272;
                    Dafny.ISequence<Dafny.Rune> _1940_recursiveGen;
                    bool _1941___v55;
                    bool _1942___v56;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1943_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1273;
                    bool _out1274;
                    bool _out1275;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1276;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, true, out _out1273, out _out1274, out _out1275, out _out1276);
                    _1940_recursiveGen = _out1273;
                    _1941___v55 = _out1274;
                    _1942___v56 = _out1275;
                    _1943_recIdents = _out1276;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1940_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1943_recIdents;
                  }
                } else if (_source68.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1944_recursiveGen;
                    bool _1945_recOwned;
                    bool _1946_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1947_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1277;
                    bool _out1278;
                    bool _out1279;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1280;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1277, out _out1278, out _out1279, out _out1280);
                    _1944_recursiveGen = _out1277;
                    _1945_recOwned = _out1278;
                    _1946_recErased = _out1279;
                    _1947_recIdents = _out1280;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1944_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1945_recOwned;
                    isErased = _1946_recErased;
                    readIdents = _1947_recIdents;
                  }
                } else if (_source68.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1948_recursiveGen;
                    bool _1949_recOwned;
                    bool _1950_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1951_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    bool _out1282;
                    bool _out1283;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1284;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1281, out _out1282, out _out1283, out _out1284);
                    _1948_recursiveGen = _out1281;
                    _1949_recOwned = _out1282;
                    _1950_recErased = _out1283;
                    _1951_recIdents = _out1284;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1948_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1949_recOwned;
                    isErased = _1950_recErased;
                    readIdents = _1951_recIdents;
                  }
                } else if (_source68.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1952_recursiveGen;
                    bool _1953_recOwned;
                    bool _1954_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1955_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1285;
                    bool _out1286;
                    bool _out1287;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1288;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1285, out _out1286, out _out1287, out _out1288);
                    _1952_recursiveGen = _out1285;
                    _1953_recOwned = _out1286;
                    _1954_recErased = _out1287;
                    _1955_recIdents = _out1288;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1953_recOwned;
                    isErased = _1954_recErased;
                    readIdents = _1955_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1956_recursiveGen;
                    bool _1957_recOwned;
                    bool _1958_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1959_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1289;
                    bool _out1290;
                    bool _out1291;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1292;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1289, out _out1290, out _out1291, out _out1292);
                    _1956_recursiveGen = _out1289;
                    _1957_recOwned = _out1290;
                    _1958_recErased = _out1291;
                    _1959_recIdents = _out1292;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1956_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1957_recOwned;
                    isErased = _1958_recErased;
                    readIdents = _1959_recIdents;
                  }
                }
              } else if (_source66.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1960___mcc_h1008 = _source66.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1961_recursiveGen;
                  bool _1962___v63;
                  bool _1963___v64;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1964_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1293;
                  bool _out1294;
                  bool _out1295;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1296;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, true, out _out1293, out _out1294, out _out1295, out _out1296);
                  _1961_recursiveGen = _out1293;
                  _1962___v63 = _out1294;
                  _1963___v64 = _out1295;
                  _1964_recIdents = _out1296;
                  Dafny.ISequence<Dafny.Rune> _1965_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1297;
                  _out1297 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                  _1965_toTpeGen = _out1297;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1961_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1965_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1964_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1966___mcc_h1010 = _source66.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1967_recursiveGen;
                  bool _1968_recOwned;
                  bool _1969_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1970_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1298;
                  bool _out1299;
                  bool _out1300;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1301;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1298, out _out1299, out _out1300, out _out1301);
                  _1967_recursiveGen = _out1298;
                  _1968_recOwned = _out1299;
                  _1969_recErased = _out1300;
                  _1970_recIdents = _out1301;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1967_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1968_recOwned;
                  isErased = _1969_recErased;
                  readIdents = _1970_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1971___mcc_h1012 = _source28.dtor_TypeArg_a0;
              DAST._IType _source69 = _536___mcc_h253;
              if (_source69.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1972___mcc_h1016 = _source69.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1973___mcc_h1017 = _source69.dtor_typeArgs;
                DAST._IResolvedType _1974___mcc_h1018 = _source69.dtor_resolved;
                DAST._IResolvedType _source70 = _1974___mcc_h1018;
                if (_source70.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1975___mcc_h1022 = _source70.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1976_recursiveGen;
                    bool _1977_recOwned;
                    bool _1978_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1979_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1302;
                    bool _out1303;
                    bool _out1304;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1302, out _out1303, out _out1304, out _out1305);
                    _1976_recursiveGen = _out1302;
                    _1977_recOwned = _out1303;
                    _1978_recErased = _out1304;
                    _1979_recIdents = _out1305;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1976_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1977_recOwned;
                    isErased = _1978_recErased;
                    readIdents = _1979_recIdents;
                  }
                } else if (_source70.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1980___mcc_h1024 = _source70.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1981_recursiveGen;
                    bool _1982_recOwned;
                    bool _1983_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1984_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1306;
                    bool _out1307;
                    bool _out1308;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1309;
                    DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1306, out _out1307, out _out1308, out _out1309);
                    _1981_recursiveGen = _out1306;
                    _1982_recOwned = _out1307;
                    _1983_recErased = _out1308;
                    _1984_recIdents = _out1309;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1981_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1982_recOwned;
                    isErased = _1983_recErased;
                    readIdents = _1984_recIdents;
                  }
                } else {
                  DAST._IType _1985___mcc_h1026 = _source70.dtor_Newtype_a0;
                  DAST._IType _1986_b = _1985___mcc_h1026;
                  {
                    if (object.Equals(_529_fromTpe, _1986_b)) {
                      Dafny.ISequence<Dafny.Rune> _1987_recursiveGen;
                      bool _1988_recOwned;
                      bool _1989_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1990_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1310;
                      bool _out1311;
                      bool _out1312;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1313;
                      DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1310, out _out1311, out _out1312, out _out1313);
                      _1987_recursiveGen = _out1310;
                      _1988_recOwned = _out1311;
                      _1989_recErased = _out1312;
                      _1990_recIdents = _out1313;
                      Dafny.ISequence<Dafny.Rune> _1991_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1314;
                      _out1314 = DCOMP.COMP.GenType(_528_toTpe, true, false);
                      _1991_rhsType = _out1314;
                      Dafny.ISequence<Dafny.Rune> _1992_uneraseFn;
                      _1992_uneraseFn = ((_1988_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1991_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1992_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1987_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1988_recOwned;
                      isErased = false;
                      readIdents = _1990_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1315;
                      bool _out1316;
                      bool _out1317;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1318;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_530_expr, _529_fromTpe, _1986_b), _1986_b, _528_toTpe), selfIdent, @params, mustOwn, out _out1315, out _out1316, out _out1317, out _out1318);
                      s = _out1315;
                      isOwned = _out1316;
                      isErased = _out1317;
                      readIdents = _out1318;
                    }
                  }
                }
              } else if (_source69.is_Nullable) {
                DAST._IType _1993___mcc_h1028 = _source69.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1994_recursiveGen;
                  bool _1995_recOwned;
                  bool _1996_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1997_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1319;
                  bool _out1320;
                  bool _out1321;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1322;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1319, out _out1320, out _out1321, out _out1322);
                  _1994_recursiveGen = _out1319;
                  _1995_recOwned = _out1320;
                  _1996_recErased = _out1321;
                  _1997_recIdents = _out1322;
                  if (!(_1995_recOwned)) {
                    _1994_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1994_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1994_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1996_recErased;
                  readIdents = _1997_recIdents;
                }
              } else if (_source69.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1998___mcc_h1030 = _source69.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1999_recursiveGen;
                  bool _2000_recOwned;
                  bool _2001_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2002_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1323;
                  bool _out1324;
                  bool _out1325;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1326;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1323, out _out1324, out _out1325, out _out1326);
                  _1999_recursiveGen = _out1323;
                  _2000_recOwned = _out1324;
                  _2001_recErased = _out1325;
                  _2002_recIdents = _out1326;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1999_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2000_recOwned;
                  isErased = _2001_recErased;
                  readIdents = _2002_recIdents;
                }
              } else if (_source69.is_Array) {
                DAST._IType _2003___mcc_h1032 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2004_recursiveGen;
                  bool _2005_recOwned;
                  bool _2006_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2007_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1327;
                  bool _out1328;
                  bool _out1329;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1330;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1327, out _out1328, out _out1329, out _out1330);
                  _2004_recursiveGen = _out1327;
                  _2005_recOwned = _out1328;
                  _2006_recErased = _out1329;
                  _2007_recIdents = _out1330;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2004_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2005_recOwned;
                  isErased = _2006_recErased;
                  readIdents = _2007_recIdents;
                }
              } else if (_source69.is_Seq) {
                DAST._IType _2008___mcc_h1034 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2009_recursiveGen;
                  bool _2010_recOwned;
                  bool _2011_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2012_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1331;
                  bool _out1332;
                  bool _out1333;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1334;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1331, out _out1332, out _out1333, out _out1334);
                  _2009_recursiveGen = _out1331;
                  _2010_recOwned = _out1332;
                  _2011_recErased = _out1333;
                  _2012_recIdents = _out1334;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2010_recOwned;
                  isErased = _2011_recErased;
                  readIdents = _2012_recIdents;
                }
              } else if (_source69.is_Set) {
                DAST._IType _2013___mcc_h1036 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2014_recursiveGen;
                  bool _2015_recOwned;
                  bool _2016_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2017_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1335;
                  bool _out1336;
                  bool _out1337;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1338;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1335, out _out1336, out _out1337, out _out1338);
                  _2014_recursiveGen = _out1335;
                  _2015_recOwned = _out1336;
                  _2016_recErased = _out1337;
                  _2017_recIdents = _out1338;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2014_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2015_recOwned;
                  isErased = _2016_recErased;
                  readIdents = _2017_recIdents;
                }
              } else if (_source69.is_Multiset) {
                DAST._IType _2018___mcc_h1038 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2019_recursiveGen;
                  bool _2020_recOwned;
                  bool _2021_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2022_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1339;
                  bool _out1340;
                  bool _out1341;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1342;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1339, out _out1340, out _out1341, out _out1342);
                  _2019_recursiveGen = _out1339;
                  _2020_recOwned = _out1340;
                  _2021_recErased = _out1341;
                  _2022_recIdents = _out1342;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2019_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2020_recOwned;
                  isErased = _2021_recErased;
                  readIdents = _2022_recIdents;
                }
              } else if (_source69.is_Map) {
                DAST._IType _2023___mcc_h1040 = _source69.dtor_key;
                DAST._IType _2024___mcc_h1041 = _source69.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _2025_recursiveGen;
                  bool _2026_recOwned;
                  bool _2027_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2028_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1343;
                  bool _out1344;
                  bool _out1345;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1346;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1343, out _out1344, out _out1345, out _out1346);
                  _2025_recursiveGen = _out1343;
                  _2026_recOwned = _out1344;
                  _2027_recErased = _out1345;
                  _2028_recIdents = _out1346;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2025_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2026_recOwned;
                  isErased = _2027_recErased;
                  readIdents = _2028_recIdents;
                }
              } else if (_source69.is_Arrow) {
                Dafny.ISequence<DAST._IType> _2029___mcc_h1044 = _source69.dtor_args;
                DAST._IType _2030___mcc_h1045 = _source69.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _2031_recursiveGen;
                  bool _2032_recOwned;
                  bool _2033_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2034_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1347;
                  bool _out1348;
                  bool _out1349;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1350;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1347, out _out1348, out _out1349, out _out1350);
                  _2031_recursiveGen = _out1347;
                  _2032_recOwned = _out1348;
                  _2033_recErased = _out1349;
                  _2034_recIdents = _out1350;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2031_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2032_recOwned;
                  isErased = _2033_recErased;
                  readIdents = _2034_recIdents;
                }
              } else if (_source69.is_Primitive) {
                DAST._IPrimitive _2035___mcc_h1048 = _source69.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2036_recursiveGen;
                  bool _2037_recOwned;
                  bool _2038_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2039_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1351;
                  bool _out1352;
                  bool _out1353;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1354;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1351, out _out1352, out _out1353, out _out1354);
                  _2036_recursiveGen = _out1351;
                  _2037_recOwned = _out1352;
                  _2038_recErased = _out1353;
                  _2039_recIdents = _out1354;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2036_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2037_recOwned;
                  isErased = _2038_recErased;
                  readIdents = _2039_recIdents;
                }
              } else if (_source69.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2040___mcc_h1050 = _source69.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2041_recursiveGen;
                  bool _2042_recOwned;
                  bool _2043_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2044_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1355;
                  bool _out1356;
                  bool _out1357;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1358;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1355, out _out1356, out _out1357, out _out1358);
                  _2041_recursiveGen = _out1355;
                  _2042_recOwned = _out1356;
                  _2043_recErased = _out1357;
                  _2044_recIdents = _out1358;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2041_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2042_recOwned;
                  isErased = _2043_recErased;
                  readIdents = _2044_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2045___mcc_h1052 = _source69.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2046_recursiveGen;
                  bool _2047_recOwned;
                  bool _2048_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2049_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1359;
                  bool _out1360;
                  bool _out1361;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1362;
                  DCOMP.COMP.GenExpr(_530_expr, selfIdent, @params, mustOwn, out _out1359, out _out1360, out _out1361, out _out1362);
                  _2046_recursiveGen = _out1359;
                  _2047_recOwned = _out1360;
                  _2048_recErased = _out1361;
                  _2049_recIdents = _out1362;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2046_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2047_recOwned;
                  isErased = _2048_recErased;
                  readIdents = _2049_recIdents;
                }
              }
            }
          }
        }
      } else if (_source21.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2050___mcc_h22 = _source21.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2051_exprs = _2050___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2052_generatedValues;
          _2052_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2053_i;
          _2053_i = BigInteger.Zero;
          bool _2054_allErased;
          _2054_allErased = true;
          while ((_2053_i) < (new BigInteger((_2051_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2055_recursiveGen;
            bool _2056___v66;
            bool _2057_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2058_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1363;
            bool _out1364;
            bool _out1365;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1366;
            DCOMP.COMP.GenExpr((_2051_exprs).Select(_2053_i), selfIdent, @params, true, out _out1363, out _out1364, out _out1365, out _out1366);
            _2055_recursiveGen = _out1363;
            _2056___v66 = _out1364;
            _2057_isErased = _out1365;
            _2058_recIdents = _out1366;
            _2054_allErased = (_2054_allErased) && (_2057_isErased);
            _2052_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2052_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2055_recursiveGen, _2057_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2058_recIdents);
            _2053_i = (_2053_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2053_i = BigInteger.Zero;
          while ((_2053_i) < (new BigInteger((_2052_generatedValues).Count))) {
            if ((_2053_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2059_gen;
            _2059_gen = ((_2052_generatedValues).Select(_2053_i)).dtor__0;
            if ((((_2052_generatedValues).Select(_2053_i)).dtor__1) && (!(_2054_allErased))) {
              _2059_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2059_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2059_gen);
            _2053_i = (_2053_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2054_allErased;
        }
      } else if (_source21.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2060___mcc_h23 = _source21.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2061_exprs = _2060___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2062_generatedValues;
          _2062_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2063_i;
          _2063_i = BigInteger.Zero;
          bool _2064_allErased;
          _2064_allErased = true;
          while ((_2063_i) < (new BigInteger((_2061_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2065_recursiveGen;
            bool _2066___v67;
            bool _2067_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2068_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1367;
            bool _out1368;
            bool _out1369;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1370;
            DCOMP.COMP.GenExpr((_2061_exprs).Select(_2063_i), selfIdent, @params, true, out _out1367, out _out1368, out _out1369, out _out1370);
            _2065_recursiveGen = _out1367;
            _2066___v67 = _out1368;
            _2067_isErased = _out1369;
            _2068_recIdents = _out1370;
            _2064_allErased = (_2064_allErased) && (_2067_isErased);
            _2062_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2062_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2065_recursiveGen, _2067_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2068_recIdents);
            _2063_i = (_2063_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2063_i = BigInteger.Zero;
          while ((_2063_i) < (new BigInteger((_2062_generatedValues).Count))) {
            if ((_2063_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2069_gen;
            _2069_gen = ((_2062_generatedValues).Select(_2063_i)).dtor__0;
            if ((((_2062_generatedValues).Select(_2063_i)).dtor__1) && (!(_2064_allErased))) {
              _2069_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2069_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2069_gen);
            _2063_i = (_2063_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source71 = selfIdent;
          if (_source71.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2070___mcc_h1054 = _source71.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2071_id = _2070___mcc_h1054;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2071_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2071_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2071_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2071_id);
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
      } else if (_source21.is_Ite) {
        DAST._IExpression _2072___mcc_h24 = _source21.dtor_cond;
        DAST._IExpression _2073___mcc_h25 = _source21.dtor_thn;
        DAST._IExpression _2074___mcc_h26 = _source21.dtor_els;
        DAST._IExpression _2075_f = _2074___mcc_h26;
        DAST._IExpression _2076_t = _2073___mcc_h25;
        DAST._IExpression _2077_cond = _2072___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _2078_condString;
          bool _2079___v68;
          bool _2080_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2081_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1371;
          bool _out1372;
          bool _out1373;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1374;
          DCOMP.COMP.GenExpr(_2077_cond, selfIdent, @params, true, out _out1371, out _out1372, out _out1373, out _out1374);
          _2078_condString = _out1371;
          _2079___v68 = _out1372;
          _2080_condErased = _out1373;
          _2081_recIdentsCond = _out1374;
          if (!(_2080_condErased)) {
            _2078_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2078_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2082___v69;
          bool _2083_tHasToBeOwned;
          bool _2084___v70;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2085___v71;
          Dafny.ISequence<Dafny.Rune> _out1375;
          bool _out1376;
          bool _out1377;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1378;
          DCOMP.COMP.GenExpr(_2076_t, selfIdent, @params, mustOwn, out _out1375, out _out1376, out _out1377, out _out1378);
          _2082___v69 = _out1375;
          _2083_tHasToBeOwned = _out1376;
          _2084___v70 = _out1377;
          _2085___v71 = _out1378;
          Dafny.ISequence<Dafny.Rune> _2086_fString;
          bool _2087_fOwned;
          bool _2088_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2089_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1379;
          bool _out1380;
          bool _out1381;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1382;
          DCOMP.COMP.GenExpr(_2075_f, selfIdent, @params, _2083_tHasToBeOwned, out _out1379, out _out1380, out _out1381, out _out1382);
          _2086_fString = _out1379;
          _2087_fOwned = _out1380;
          _2088_fErased = _out1381;
          _2089_recIdentsF = _out1382;
          Dafny.ISequence<Dafny.Rune> _2090_tString;
          bool _2091___v72;
          bool _2092_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2093_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1383;
          bool _out1384;
          bool _out1385;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1386;
          DCOMP.COMP.GenExpr(_2076_t, selfIdent, @params, _2087_fOwned, out _out1383, out _out1384, out _out1385, out _out1386);
          _2090_tString = _out1383;
          _2091___v72 = _out1384;
          _2092_tErased = _out1385;
          _2093_recIdentsT = _out1386;
          if ((!(_2088_fErased)) || (!(_2092_tErased))) {
            if (_2088_fErased) {
              _2086_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2086_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2092_tErased) {
              _2090_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2090_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2078_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2090_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2086_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2087_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2081_recIdentsCond, _2093_recIdentsT), _2089_recIdentsF);
          isErased = (_2088_fErased) || (_2092_tErased);
        }
      } else if (_source21.is_UnOp) {
        DAST._IUnaryOp _2094___mcc_h27 = _source21.dtor_unOp;
        DAST._IExpression _2095___mcc_h28 = _source21.dtor_expr;
        DAST._IUnaryOp _source72 = _2094___mcc_h27;
        if (_source72.is_Not) {
          DAST._IExpression _2096_e = _2095___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2097_recursiveGen;
            bool _2098___v73;
            bool _2099_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2100_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1387;
            bool _out1388;
            bool _out1389;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1390;
            DCOMP.COMP.GenExpr(_2096_e, selfIdent, @params, true, out _out1387, out _out1388, out _out1389, out _out1390);
            _2097_recursiveGen = _out1387;
            _2098___v73 = _out1388;
            _2099_recErased = _out1389;
            _2100_recIdents = _out1390;
            if (!(_2099_recErased)) {
              _2097_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2097_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2097_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2100_recIdents;
            isErased = true;
          }
        } else if (_source72.is_BitwiseNot) {
          DAST._IExpression _2101_e = _2095___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2102_recursiveGen;
            bool _2103___v74;
            bool _2104_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2105_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1391;
            bool _out1392;
            bool _out1393;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1394;
            DCOMP.COMP.GenExpr(_2101_e, selfIdent, @params, true, out _out1391, out _out1392, out _out1393, out _out1394);
            _2102_recursiveGen = _out1391;
            _2103___v74 = _out1392;
            _2104_recErased = _out1393;
            _2105_recIdents = _out1394;
            if (!(_2104_recErased)) {
              _2102_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2102_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2102_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2105_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2106_e = _2095___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2107_recursiveGen;
            bool _2108_recOwned;
            bool _2109_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2110_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1395;
            bool _out1396;
            bool _out1397;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1398;
            DCOMP.COMP.GenExpr(_2106_e, selfIdent, @params, false, out _out1395, out _out1396, out _out1397, out _out1398);
            _2107_recursiveGen = _out1395;
            _2108_recOwned = _out1396;
            _2109_recErased = _out1397;
            _2110_recIdents = _out1398;
            if (!(_2109_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2111_eraseFn;
              _2111_eraseFn = ((_2108_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2107_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2111_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2107_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2107_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2110_recIdents;
            isErased = true;
          }
        }
      } else if (_source21.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2112___mcc_h29 = _source21.dtor_op;
        DAST._IExpression _2113___mcc_h30 = _source21.dtor_left;
        DAST._IExpression _2114___mcc_h31 = _source21.dtor_right;
        DAST._IExpression _2115_r = _2114___mcc_h31;
        DAST._IExpression _2116_l = _2113___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _2117_op = _2112___mcc_h29;
        {
          Dafny.ISequence<Dafny.Rune> _2118_left;
          bool _2119___v75;
          bool _2120_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2121_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1399;
          bool _out1400;
          bool _out1401;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1402;
          DCOMP.COMP.GenExpr(_2116_l, selfIdent, @params, true, out _out1399, out _out1400, out _out1401, out _out1402);
          _2118_left = _out1399;
          _2119___v75 = _out1400;
          _2120_leftErased = _out1401;
          _2121_recIdentsL = _out1402;
          Dafny.ISequence<Dafny.Rune> _2122_right;
          bool _2123___v76;
          bool _2124_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2125_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1403;
          bool _out1404;
          bool _out1405;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1406;
          DCOMP.COMP.GenExpr(_2115_r, selfIdent, @params, true, out _out1403, out _out1404, out _out1405, out _out1406);
          _2122_right = _out1403;
          _2123___v76 = _out1404;
          _2124_rightErased = _out1405;
          _2125_recIdentsR = _out1406;
          if (!(_2120_leftErased)) {
            _2118_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2118_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2124_rightErased)) {
            _2122_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2122_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2117_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2118_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2122_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2117_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2118_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2122_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2118_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2117_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2122_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2121_recIdentsL, _2125_recIdentsR);
          isErased = true;
        }
      } else if (_source21.is_ArrayLen) {
        DAST._IExpression _2126___mcc_h32 = _source21.dtor_expr;
        DAST._IExpression _2127_expr = _2126___mcc_h32;
        {
          Dafny.ISequence<Dafny.Rune> _2128_recursiveGen;
          bool _2129___v77;
          bool _2130_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2131_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1407;
          bool _out1408;
          bool _out1409;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1410;
          DCOMP.COMP.GenExpr(_2127_expr, selfIdent, @params, true, out _out1407, out _out1408, out _out1409, out _out1410);
          _2128_recursiveGen = _out1407;
          _2129___v77 = _out1408;
          _2130_recErased = _out1409;
          _2131_recIdents = _out1410;
          if (!(_2130_recErased)) {
            _2128_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2128_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2128_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow().len())"));
          isOwned = true;
          readIdents = _2131_recIdents;
          isErased = true;
        }
      } else if (_source21.is_Select) {
        DAST._IExpression _2132___mcc_h33 = _source21.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2133___mcc_h34 = _source21.dtor_field;
        bool _2134___mcc_h35 = _source21.dtor_isConstant;
        bool _2135___mcc_h36 = _source21.dtor_onDatatype;
        DAST._IExpression _source73 = _2132___mcc_h33;
        if (_source73.is_Literal) {
          DAST._ILiteral _2136___mcc_h37 = _source73.dtor_Literal_a0;
          bool _2137_isDatatype = _2135___mcc_h36;
          bool _2138_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2139_field = _2133___mcc_h34;
          DAST._IExpression _2140_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2141_onString;
            bool _2142_onOwned;
            bool _2143_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2144_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1411;
            bool _out1412;
            bool _out1413;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1414;
            DCOMP.COMP.GenExpr(_2140_on, selfIdent, @params, false, out _out1411, out _out1412, out _out1413, out _out1414);
            _2141_onString = _out1411;
            _2142_onOwned = _out1412;
            _2143_onErased = _out1413;
            _2144_recIdents = _out1414;
            if (!(_2143_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2145_eraseFn;
              _2145_eraseFn = ((_2142_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2141_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2145_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2141_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2137_isDatatype) || (_2138_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2141_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2139_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2138_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2141_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2139_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2144_recIdents;
          }
        } else if (_source73.is_Ident) {
          Dafny.ISequence<Dafny.Rune> _2146___mcc_h39 = _source73.dtor_Ident_a0;
          bool _2147_isDatatype = _2135___mcc_h36;
          bool _2148_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2149_field = _2133___mcc_h34;
          DAST._IExpression _2150_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2151_onString;
            bool _2152_onOwned;
            bool _2153_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2154_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1415;
            bool _out1416;
            bool _out1417;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1418;
            DCOMP.COMP.GenExpr(_2150_on, selfIdent, @params, false, out _out1415, out _out1416, out _out1417, out _out1418);
            _2151_onString = _out1415;
            _2152_onOwned = _out1416;
            _2153_onErased = _out1417;
            _2154_recIdents = _out1418;
            if (!(_2153_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2155_eraseFn;
              _2155_eraseFn = ((_2152_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2151_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2155_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2151_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2147_isDatatype) || (_2148_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2151_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2149_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2148_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2151_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2149_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2154_recIdents;
          }
        } else if (_source73.is_Companion) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2156___mcc_h41 = _source73.dtor_Companion_a0;
          bool _2157_isDatatype = _2135___mcc_h36;
          bool _2158_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2159_field = _2133___mcc_h34;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2160_c = _2156___mcc_h41;
          {
            Dafny.ISequence<Dafny.Rune> _2161_onString;
            bool _2162_onOwned;
            bool _2163_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2164_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1419;
            bool _out1420;
            bool _out1421;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1422;
            DCOMP.COMP.GenExpr(DAST.Expression.create_Companion(_2160_c), selfIdent, @params, false, out _out1419, out _out1420, out _out1421, out _out1422);
            _2161_onString = _out1419;
            _2162_onOwned = _out1420;
            _2163_onErased = _out1421;
            _2164_recIdents = _out1422;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2161_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2159_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            isOwned = true;
            isErased = false;
            readIdents = _2164_recIdents;
          }
        } else if (_source73.is_Tuple) {
          Dafny.ISequence<DAST._IExpression> _2165___mcc_h43 = _source73.dtor_Tuple_a0;
          bool _2166_isDatatype = _2135___mcc_h36;
          bool _2167_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2168_field = _2133___mcc_h34;
          DAST._IExpression _2169_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2170_onString;
            bool _2171_onOwned;
            bool _2172_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2173_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1423;
            bool _out1424;
            bool _out1425;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1426;
            DCOMP.COMP.GenExpr(_2169_on, selfIdent, @params, false, out _out1423, out _out1424, out _out1425, out _out1426);
            _2170_onString = _out1423;
            _2171_onOwned = _out1424;
            _2172_onErased = _out1425;
            _2173_recIdents = _out1426;
            if (!(_2172_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2174_eraseFn;
              _2174_eraseFn = ((_2171_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2170_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2174_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2170_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2166_isDatatype) || (_2167_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2170_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2168_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2167_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2170_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2168_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2173_recIdents;
          }
        } else if (_source73.is_New) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2175___mcc_h45 = _source73.dtor_path;
          Dafny.ISequence<DAST._IExpression> _2176___mcc_h46 = _source73.dtor_args;
          bool _2177_isDatatype = _2135___mcc_h36;
          bool _2178_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2179_field = _2133___mcc_h34;
          DAST._IExpression _2180_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2181_onString;
            bool _2182_onOwned;
            bool _2183_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2184_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1427;
            bool _out1428;
            bool _out1429;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1430;
            DCOMP.COMP.GenExpr(_2180_on, selfIdent, @params, false, out _out1427, out _out1428, out _out1429, out _out1430);
            _2181_onString = _out1427;
            _2182_onOwned = _out1428;
            _2183_onErased = _out1429;
            _2184_recIdents = _out1430;
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
        } else if (_source73.is_NewArray) {
          Dafny.ISequence<DAST._IExpression> _2186___mcc_h49 = _source73.dtor_dims;
          bool _2187_isDatatype = _2135___mcc_h36;
          bool _2188_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2189_field = _2133___mcc_h34;
          DAST._IExpression _2190_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2191_onString;
            bool _2192_onOwned;
            bool _2193_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2194_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1431;
            bool _out1432;
            bool _out1433;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1434;
            DCOMP.COMP.GenExpr(_2190_on, selfIdent, @params, false, out _out1431, out _out1432, out _out1433, out _out1434);
            _2191_onString = _out1431;
            _2192_onOwned = _out1432;
            _2193_onErased = _out1433;
            _2194_recIdents = _out1434;
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
        } else if (_source73.is_DatatypeValue) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2196___mcc_h51 = _source73.dtor_path;
          Dafny.ISequence<Dafny.Rune> _2197___mcc_h52 = _source73.dtor_variant;
          bool _2198___mcc_h53 = _source73.dtor_isCo;
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2199___mcc_h54 = _source73.dtor_contents;
          bool _2200_isDatatype = _2135___mcc_h36;
          bool _2201_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2202_field = _2133___mcc_h34;
          DAST._IExpression _2203_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2204_onString;
            bool _2205_onOwned;
            bool _2206_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2207_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1435;
            bool _out1436;
            bool _out1437;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1438;
            DCOMP.COMP.GenExpr(_2203_on, selfIdent, @params, false, out _out1435, out _out1436, out _out1437, out _out1438);
            _2204_onString = _out1435;
            _2205_onOwned = _out1436;
            _2206_onErased = _out1437;
            _2207_recIdents = _out1438;
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
        } else if (_source73.is_Convert) {
          DAST._IExpression _2209___mcc_h59 = _source73.dtor_value;
          DAST._IType _2210___mcc_h60 = _source73.dtor_from;
          DAST._IType _2211___mcc_h61 = _source73.dtor_typ;
          bool _2212_isDatatype = _2135___mcc_h36;
          bool _2213_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2214_field = _2133___mcc_h34;
          DAST._IExpression _2215_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2216_onString;
            bool _2217_onOwned;
            bool _2218_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2219_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1439;
            bool _out1440;
            bool _out1441;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1442;
            DCOMP.COMP.GenExpr(_2215_on, selfIdent, @params, false, out _out1439, out _out1440, out _out1441, out _out1442);
            _2216_onString = _out1439;
            _2217_onOwned = _out1440;
            _2218_onErased = _out1441;
            _2219_recIdents = _out1442;
            if (!(_2218_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2220_eraseFn;
              _2220_eraseFn = ((_2217_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2216_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2220_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2216_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2212_isDatatype) || (_2213_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2216_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2214_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2213_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2216_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2214_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2219_recIdents;
          }
        } else if (_source73.is_SeqValue) {
          Dafny.ISequence<DAST._IExpression> _2221___mcc_h65 = _source73.dtor_elements;
          bool _2222_isDatatype = _2135___mcc_h36;
          bool _2223_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2224_field = _2133___mcc_h34;
          DAST._IExpression _2225_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2226_onString;
            bool _2227_onOwned;
            bool _2228_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2229_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1443;
            bool _out1444;
            bool _out1445;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1446;
            DCOMP.COMP.GenExpr(_2225_on, selfIdent, @params, false, out _out1443, out _out1444, out _out1445, out _out1446);
            _2226_onString = _out1443;
            _2227_onOwned = _out1444;
            _2228_onErased = _out1445;
            _2229_recIdents = _out1446;
            if (!(_2228_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2230_eraseFn;
              _2230_eraseFn = ((_2227_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2226_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2230_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2226_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2222_isDatatype) || (_2223_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2226_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2224_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2223_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2226_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2224_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2229_recIdents;
          }
        } else if (_source73.is_SetValue) {
          Dafny.ISequence<DAST._IExpression> _2231___mcc_h67 = _source73.dtor_elements;
          bool _2232_isDatatype = _2135___mcc_h36;
          bool _2233_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2234_field = _2133___mcc_h34;
          DAST._IExpression _2235_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2236_onString;
            bool _2237_onOwned;
            bool _2238_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2239_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1447;
            bool _out1448;
            bool _out1449;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1450;
            DCOMP.COMP.GenExpr(_2235_on, selfIdent, @params, false, out _out1447, out _out1448, out _out1449, out _out1450);
            _2236_onString = _out1447;
            _2237_onOwned = _out1448;
            _2238_onErased = _out1449;
            _2239_recIdents = _out1450;
            if (!(_2238_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2240_eraseFn;
              _2240_eraseFn = ((_2237_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2236_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2240_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2236_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2232_isDatatype) || (_2233_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2236_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2234_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2233_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2236_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2234_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2239_recIdents;
          }
        } else if (_source73.is_This) {
          bool _2241_isDatatype = _2135___mcc_h36;
          bool _2242_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2243_field = _2133___mcc_h34;
          DAST._IExpression _2244_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2245_onString;
            bool _2246_onOwned;
            bool _2247_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2248_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1451;
            bool _out1452;
            bool _out1453;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1454;
            DCOMP.COMP.GenExpr(_2244_on, selfIdent, @params, false, out _out1451, out _out1452, out _out1453, out _out1454);
            _2245_onString = _out1451;
            _2246_onOwned = _out1452;
            _2247_onErased = _out1453;
            _2248_recIdents = _out1454;
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
        } else if (_source73.is_Ite) {
          DAST._IExpression _2250___mcc_h69 = _source73.dtor_cond;
          DAST._IExpression _2251___mcc_h70 = _source73.dtor_thn;
          DAST._IExpression _2252___mcc_h71 = _source73.dtor_els;
          bool _2253_isDatatype = _2135___mcc_h36;
          bool _2254_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2255_field = _2133___mcc_h34;
          DAST._IExpression _2256_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2257_onString;
            bool _2258_onOwned;
            bool _2259_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2260_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1455;
            bool _out1456;
            bool _out1457;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1458;
            DCOMP.COMP.GenExpr(_2256_on, selfIdent, @params, false, out _out1455, out _out1456, out _out1457, out _out1458);
            _2257_onString = _out1455;
            _2258_onOwned = _out1456;
            _2259_onErased = _out1457;
            _2260_recIdents = _out1458;
            if (!(_2259_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2261_eraseFn;
              _2261_eraseFn = ((_2258_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2257_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2261_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2257_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2253_isDatatype) || (_2254_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2257_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2255_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2254_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2257_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2255_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2260_recIdents;
          }
        } else if (_source73.is_UnOp) {
          DAST._IUnaryOp _2262___mcc_h75 = _source73.dtor_unOp;
          DAST._IExpression _2263___mcc_h76 = _source73.dtor_expr;
          bool _2264_isDatatype = _2135___mcc_h36;
          bool _2265_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2266_field = _2133___mcc_h34;
          DAST._IExpression _2267_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2268_onString;
            bool _2269_onOwned;
            bool _2270_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2271_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1459;
            bool _out1460;
            bool _out1461;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1462;
            DCOMP.COMP.GenExpr(_2267_on, selfIdent, @params, false, out _out1459, out _out1460, out _out1461, out _out1462);
            _2268_onString = _out1459;
            _2269_onOwned = _out1460;
            _2270_onErased = _out1461;
            _2271_recIdents = _out1462;
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
        } else if (_source73.is_BinOp) {
          Dafny.ISequence<Dafny.Rune> _2273___mcc_h79 = _source73.dtor_op;
          DAST._IExpression _2274___mcc_h80 = _source73.dtor_left;
          DAST._IExpression _2275___mcc_h81 = _source73.dtor_right;
          bool _2276_isDatatype = _2135___mcc_h36;
          bool _2277_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2278_field = _2133___mcc_h34;
          DAST._IExpression _2279_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2280_onString;
            bool _2281_onOwned;
            bool _2282_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2283_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1463;
            bool _out1464;
            bool _out1465;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1466;
            DCOMP.COMP.GenExpr(_2279_on, selfIdent, @params, false, out _out1463, out _out1464, out _out1465, out _out1466);
            _2280_onString = _out1463;
            _2281_onOwned = _out1464;
            _2282_onErased = _out1465;
            _2283_recIdents = _out1466;
            if (!(_2282_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2284_eraseFn;
              _2284_eraseFn = ((_2281_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2280_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2284_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2280_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2276_isDatatype) || (_2277_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2280_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2278_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2277_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2280_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2278_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2283_recIdents;
          }
        } else if (_source73.is_ArrayLen) {
          DAST._IExpression _2285___mcc_h85 = _source73.dtor_expr;
          bool _2286_isDatatype = _2135___mcc_h36;
          bool _2287_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2288_field = _2133___mcc_h34;
          DAST._IExpression _2289_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2290_onString;
            bool _2291_onOwned;
            bool _2292_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2293_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1467;
            bool _out1468;
            bool _out1469;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1470;
            DCOMP.COMP.GenExpr(_2289_on, selfIdent, @params, false, out _out1467, out _out1468, out _out1469, out _out1470);
            _2290_onString = _out1467;
            _2291_onOwned = _out1468;
            _2292_onErased = _out1469;
            _2293_recIdents = _out1470;
            if (!(_2292_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2294_eraseFn;
              _2294_eraseFn = ((_2291_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2290_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2294_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2290_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2286_isDatatype) || (_2287_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2290_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2288_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2287_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2290_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2288_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2293_recIdents;
          }
        } else if (_source73.is_Select) {
          DAST._IExpression _2295___mcc_h87 = _source73.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2296___mcc_h88 = _source73.dtor_field;
          bool _2297___mcc_h89 = _source73.dtor_isConstant;
          bool _2298___mcc_h90 = _source73.dtor_onDatatype;
          bool _2299_isDatatype = _2135___mcc_h36;
          bool _2300_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2301_field = _2133___mcc_h34;
          DAST._IExpression _2302_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2303_onString;
            bool _2304_onOwned;
            bool _2305_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2306_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1471;
            bool _out1472;
            bool _out1473;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1474;
            DCOMP.COMP.GenExpr(_2302_on, selfIdent, @params, false, out _out1471, out _out1472, out _out1473, out _out1474);
            _2303_onString = _out1471;
            _2304_onOwned = _out1472;
            _2305_onErased = _out1473;
            _2306_recIdents = _out1474;
            if (!(_2305_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2307_eraseFn;
              _2307_eraseFn = ((_2304_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2303_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2307_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2303_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2299_isDatatype) || (_2300_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2303_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2301_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2300_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2303_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2301_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2306_recIdents;
          }
        } else if (_source73.is_SelectFn) {
          DAST._IExpression _2308___mcc_h95 = _source73.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2309___mcc_h96 = _source73.dtor_field;
          bool _2310___mcc_h97 = _source73.dtor_onDatatype;
          bool _2311___mcc_h98 = _source73.dtor_isStatic;
          BigInteger _2312___mcc_h99 = _source73.dtor_arity;
          bool _2313_isDatatype = _2135___mcc_h36;
          bool _2314_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2315_field = _2133___mcc_h34;
          DAST._IExpression _2316_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2317_onString;
            bool _2318_onOwned;
            bool _2319_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2320_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1475;
            bool _out1476;
            bool _out1477;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1478;
            DCOMP.COMP.GenExpr(_2316_on, selfIdent, @params, false, out _out1475, out _out1476, out _out1477, out _out1478);
            _2317_onString = _out1475;
            _2318_onOwned = _out1476;
            _2319_onErased = _out1477;
            _2320_recIdents = _out1478;
            if (!(_2319_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2321_eraseFn;
              _2321_eraseFn = ((_2318_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2317_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2321_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2317_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2313_isDatatype) || (_2314_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2317_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2315_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2314_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2317_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2315_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2320_recIdents;
          }
        } else if (_source73.is_Index) {
          DAST._IExpression _2322___mcc_h105 = _source73.dtor_expr;
          bool _2323___mcc_h106 = _source73.dtor_isArray;
          Dafny.ISequence<DAST._IExpression> _2324___mcc_h107 = _source73.dtor_indices;
          bool _2325_isDatatype = _2135___mcc_h36;
          bool _2326_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2327_field = _2133___mcc_h34;
          DAST._IExpression _2328_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2329_onString;
            bool _2330_onOwned;
            bool _2331_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2332_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1479;
            bool _out1480;
            bool _out1481;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1482;
            DCOMP.COMP.GenExpr(_2328_on, selfIdent, @params, false, out _out1479, out _out1480, out _out1481, out _out1482);
            _2329_onString = _out1479;
            _2330_onOwned = _out1480;
            _2331_onErased = _out1481;
            _2332_recIdents = _out1482;
            if (!(_2331_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2333_eraseFn;
              _2333_eraseFn = ((_2330_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2329_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2333_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2329_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2325_isDatatype) || (_2326_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2329_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2327_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2326_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2329_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2327_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2332_recIdents;
          }
        } else if (_source73.is_IndexRange) {
          DAST._IExpression _2334___mcc_h111 = _source73.dtor_expr;
          bool _2335___mcc_h112 = _source73.dtor_isArray;
          DAST._IOptional<DAST._IExpression> _2336___mcc_h113 = _source73.dtor_low;
          DAST._IOptional<DAST._IExpression> _2337___mcc_h114 = _source73.dtor_high;
          bool _2338_isDatatype = _2135___mcc_h36;
          bool _2339_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2340_field = _2133___mcc_h34;
          DAST._IExpression _2341_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2342_onString;
            bool _2343_onOwned;
            bool _2344_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2345_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1483;
            bool _out1484;
            bool _out1485;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1486;
            DCOMP.COMP.GenExpr(_2341_on, selfIdent, @params, false, out _out1483, out _out1484, out _out1485, out _out1486);
            _2342_onString = _out1483;
            _2343_onOwned = _out1484;
            _2344_onErased = _out1485;
            _2345_recIdents = _out1486;
            if (!(_2344_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2346_eraseFn;
              _2346_eraseFn = ((_2343_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2342_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2346_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2342_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2338_isDatatype) || (_2339_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2342_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2340_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2339_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2342_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2340_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2345_recIdents;
          }
        } else if (_source73.is_TupleSelect) {
          DAST._IExpression _2347___mcc_h119 = _source73.dtor_expr;
          BigInteger _2348___mcc_h120 = _source73.dtor_index;
          bool _2349_isDatatype = _2135___mcc_h36;
          bool _2350_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2351_field = _2133___mcc_h34;
          DAST._IExpression _2352_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2353_onString;
            bool _2354_onOwned;
            bool _2355_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2356_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1487;
            bool _out1488;
            bool _out1489;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1490;
            DCOMP.COMP.GenExpr(_2352_on, selfIdent, @params, false, out _out1487, out _out1488, out _out1489, out _out1490);
            _2353_onString = _out1487;
            _2354_onOwned = _out1488;
            _2355_onErased = _out1489;
            _2356_recIdents = _out1490;
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
        } else if (_source73.is_Call) {
          DAST._IExpression _2358___mcc_h123 = _source73.dtor_on;
          Dafny.ISequence<Dafny.Rune> _2359___mcc_h124 = _source73.dtor_name;
          Dafny.ISequence<DAST._IType> _2360___mcc_h125 = _source73.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _2361___mcc_h126 = _source73.dtor_args;
          bool _2362_isDatatype = _2135___mcc_h36;
          bool _2363_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2364_field = _2133___mcc_h34;
          DAST._IExpression _2365_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2366_onString;
            bool _2367_onOwned;
            bool _2368_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2369_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1491;
            bool _out1492;
            bool _out1493;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1494;
            DCOMP.COMP.GenExpr(_2365_on, selfIdent, @params, false, out _out1491, out _out1492, out _out1493, out _out1494);
            _2366_onString = _out1491;
            _2367_onOwned = _out1492;
            _2368_onErased = _out1493;
            _2369_recIdents = _out1494;
            if (!(_2368_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2370_eraseFn;
              _2370_eraseFn = ((_2367_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2366_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2370_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2366_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2362_isDatatype) || (_2363_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2366_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2364_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2363_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2366_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2364_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2369_recIdents;
          }
        } else if (_source73.is_Lambda) {
          Dafny.ISequence<DAST._IFormal> _2371___mcc_h131 = _source73.dtor_params;
          DAST._IType _2372___mcc_h132 = _source73.dtor_retType;
          Dafny.ISequence<DAST._IStatement> _2373___mcc_h133 = _source73.dtor_body;
          bool _2374_isDatatype = _2135___mcc_h36;
          bool _2375_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2376_field = _2133___mcc_h34;
          DAST._IExpression _2377_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2378_onString;
            bool _2379_onOwned;
            bool _2380_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2381_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1495;
            bool _out1496;
            bool _out1497;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1498;
            DCOMP.COMP.GenExpr(_2377_on, selfIdent, @params, false, out _out1495, out _out1496, out _out1497, out _out1498);
            _2378_onString = _out1495;
            _2379_onOwned = _out1496;
            _2380_onErased = _out1497;
            _2381_recIdents = _out1498;
            if (!(_2380_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2382_eraseFn;
              _2382_eraseFn = ((_2379_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2378_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2382_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2378_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2374_isDatatype) || (_2375_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2378_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2376_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2375_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2378_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2376_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2381_recIdents;
          }
        } else if (_source73.is_IIFE) {
          Dafny.ISequence<Dafny.Rune> _2383___mcc_h137 = _source73.dtor_name;
          DAST._IType _2384___mcc_h138 = _source73.dtor_typ;
          DAST._IExpression _2385___mcc_h139 = _source73.dtor_value;
          DAST._IExpression _2386___mcc_h140 = _source73.dtor_iifeBody;
          bool _2387_isDatatype = _2135___mcc_h36;
          bool _2388_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2389_field = _2133___mcc_h34;
          DAST._IExpression _2390_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2391_onString;
            bool _2392_onOwned;
            bool _2393_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2394_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1499;
            bool _out1500;
            bool _out1501;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1502;
            DCOMP.COMP.GenExpr(_2390_on, selfIdent, @params, false, out _out1499, out _out1500, out _out1501, out _out1502);
            _2391_onString = _out1499;
            _2392_onOwned = _out1500;
            _2393_onErased = _out1501;
            _2394_recIdents = _out1502;
            if (!(_2393_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2395_eraseFn;
              _2395_eraseFn = ((_2392_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2391_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2395_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2391_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2387_isDatatype) || (_2388_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2391_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2389_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2388_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2391_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2389_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2394_recIdents;
          }
        } else if (_source73.is_Apply) {
          DAST._IExpression _2396___mcc_h145 = _source73.dtor_expr;
          Dafny.ISequence<DAST._IExpression> _2397___mcc_h146 = _source73.dtor_args;
          bool _2398_isDatatype = _2135___mcc_h36;
          bool _2399_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2400_field = _2133___mcc_h34;
          DAST._IExpression _2401_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2402_onString;
            bool _2403_onOwned;
            bool _2404_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2405_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1503;
            bool _out1504;
            bool _out1505;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1506;
            DCOMP.COMP.GenExpr(_2401_on, selfIdent, @params, false, out _out1503, out _out1504, out _out1505, out _out1506);
            _2402_onString = _out1503;
            _2403_onOwned = _out1504;
            _2404_onErased = _out1505;
            _2405_recIdents = _out1506;
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
        } else if (_source73.is_TypeTest) {
          DAST._IExpression _2407___mcc_h149 = _source73.dtor_on;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2408___mcc_h150 = _source73.dtor_dType;
          Dafny.ISequence<Dafny.Rune> _2409___mcc_h151 = _source73.dtor_variant;
          bool _2410_isDatatype = _2135___mcc_h36;
          bool _2411_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2412_field = _2133___mcc_h34;
          DAST._IExpression _2413_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2414_onString;
            bool _2415_onOwned;
            bool _2416_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2417_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1507;
            bool _out1508;
            bool _out1509;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1510;
            DCOMP.COMP.GenExpr(_2413_on, selfIdent, @params, false, out _out1507, out _out1508, out _out1509, out _out1510);
            _2414_onString = _out1507;
            _2415_onOwned = _out1508;
            _2416_onErased = _out1509;
            _2417_recIdents = _out1510;
            if (!(_2416_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2418_eraseFn;
              _2418_eraseFn = ((_2415_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2414_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2418_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2414_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2410_isDatatype) || (_2411_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2414_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2412_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2411_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2414_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2412_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2417_recIdents;
          }
        } else {
          DAST._IType _2419___mcc_h155 = _source73.dtor_typ;
          bool _2420_isDatatype = _2135___mcc_h36;
          bool _2421_isConstant = _2134___mcc_h35;
          Dafny.ISequence<Dafny.Rune> _2422_field = _2133___mcc_h34;
          DAST._IExpression _2423_on = _2132___mcc_h33;
          {
            Dafny.ISequence<Dafny.Rune> _2424_onString;
            bool _2425_onOwned;
            bool _2426_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2427_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1511;
            bool _out1512;
            bool _out1513;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1514;
            DCOMP.COMP.GenExpr(_2423_on, selfIdent, @params, false, out _out1511, out _out1512, out _out1513, out _out1514);
            _2424_onString = _out1511;
            _2425_onOwned = _out1512;
            _2426_onErased = _out1513;
            _2427_recIdents = _out1514;
            if (!(_2426_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2428_eraseFn;
              _2428_eraseFn = ((_2425_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2424_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2428_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2424_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2420_isDatatype) || (_2421_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2422_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2421_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2424_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2422_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2427_recIdents;
          }
        }
      } else if (_source21.is_SelectFn) {
        DAST._IExpression _2429___mcc_h157 = _source21.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2430___mcc_h158 = _source21.dtor_field;
        bool _2431___mcc_h159 = _source21.dtor_onDatatype;
        bool _2432___mcc_h160 = _source21.dtor_isStatic;
        BigInteger _2433___mcc_h161 = _source21.dtor_arity;
        BigInteger _2434_arity = _2433___mcc_h161;
        bool _2435_isStatic = _2432___mcc_h160;
        bool _2436_isDatatype = _2431___mcc_h159;
        Dafny.ISequence<Dafny.Rune> _2437_field = _2430___mcc_h158;
        DAST._IExpression _2438_on = _2429___mcc_h157;
        {
          Dafny.ISequence<Dafny.Rune> _2439_onString;
          bool _2440_onOwned;
          bool _2441___v78;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2442_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1515;
          bool _out1516;
          bool _out1517;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1518;
          DCOMP.COMP.GenExpr(_2438_on, selfIdent, @params, false, out _out1515, out _out1516, out _out1517, out _out1518);
          _2439_onString = _out1515;
          _2440_onOwned = _out1516;
          _2441___v78 = _out1517;
          _2442_recIdents = _out1518;
          if (_2435_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2439_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2437_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2439_onString), ((_2440_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2443_args;
            _2443_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2444_i;
            _2444_i = BigInteger.Zero;
            while ((_2444_i) < (_2434_arity)) {
              if ((_2444_i).Sign == 1) {
                _2443_args = Dafny.Sequence<Dafny.Rune>.Concat(_2443_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2443_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2443_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2444_i));
              _2444_i = (_2444_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2443_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2437_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2443_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _2442_recIdents;
        }
      } else if (_source21.is_Index) {
        DAST._IExpression _2445___mcc_h162 = _source21.dtor_expr;
        bool _2446___mcc_h163 = _source21.dtor_isArray;
        Dafny.ISequence<DAST._IExpression> _2447___mcc_h164 = _source21.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _2448_indices = _2447___mcc_h164;
        bool _2449_isArray = _2446___mcc_h163;
        DAST._IExpression _2450_on = _2445___mcc_h162;
        {
          Dafny.ISequence<Dafny.Rune> _2451_onString;
          bool _2452_onOwned;
          bool _2453_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2454_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1519;
          bool _out1520;
          bool _out1521;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1522;
          DCOMP.COMP.GenExpr(_2450_on, selfIdent, @params, false, out _out1519, out _out1520, out _out1521, out _out1522);
          _2451_onString = _out1519;
          _2452_onOwned = _out1520;
          _2453_onErased = _out1521;
          _2454_recIdents = _out1522;
          readIdents = _2454_recIdents;
          if (!(_2453_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2455_eraseFn;
            _2455_eraseFn = ((_2452_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2451_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2455_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2451_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2451_onString;
          BigInteger _2456_i;
          _2456_i = BigInteger.Zero;
          while ((_2456_i) < (new BigInteger((_2448_indices).Count))) {
            Dafny.ISequence<Dafny.Rune> _2457_idx;
            bool _2458___v79;
            bool _2459_idxErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2460_recIdentsIdx;
            Dafny.ISequence<Dafny.Rune> _out1523;
            bool _out1524;
            bool _out1525;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1526;
            DCOMP.COMP.GenExpr((_2448_indices).Select(_2456_i), selfIdent, @params, true, out _out1523, out _out1524, out _out1525, out _out1526);
            _2457_idx = _out1523;
            _2458___v79 = _out1524;
            _2459_idxErased = _out1525;
            _2460_recIdentsIdx = _out1526;
            if (!(_2459_idxErased)) {
              _2457_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2457_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2449_isArray) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[<usize as ::dafny_runtime::NumCast>::from(")), _2457_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2460_recIdentsIdx);
            _2456_i = (_2456_i) + (BigInteger.One);
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = _2453_onErased;
        }
      } else if (_source21.is_IndexRange) {
        DAST._IExpression _2461___mcc_h165 = _source21.dtor_expr;
        bool _2462___mcc_h166 = _source21.dtor_isArray;
        DAST._IOptional<DAST._IExpression> _2463___mcc_h167 = _source21.dtor_low;
        DAST._IOptional<DAST._IExpression> _2464___mcc_h168 = _source21.dtor_high;
        DAST._IOptional<DAST._IExpression> _2465_high = _2464___mcc_h168;
        DAST._IOptional<DAST._IExpression> _2466_low = _2463___mcc_h167;
        bool _2467_isArray = _2462___mcc_h166;
        DAST._IExpression _2468_on = _2461___mcc_h165;
        {
          Dafny.ISequence<Dafny.Rune> _2469_onString;
          bool _2470_onOwned;
          bool _2471_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2472_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1527;
          bool _out1528;
          bool _out1529;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1530;
          DCOMP.COMP.GenExpr(_2468_on, selfIdent, @params, false, out _out1527, out _out1528, out _out1529, out _out1530);
          _2469_onString = _out1527;
          _2470_onOwned = _out1528;
          _2471_onErased = _out1529;
          _2472_recIdents = _out1530;
          readIdents = _2472_recIdents;
          if (!(_2471_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2473_eraseFn;
            _2473_eraseFn = ((_2470_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2469_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2473_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2469_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2469_onString;
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2474_lowString;
          _2474_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source74 = _2466_low;
          if (_source74.is_Some) {
            DAST._IExpression _2475___mcc_h1055 = _source74.dtor_Some_a0;
            DAST._IExpression _2476_l = _2475___mcc_h1055;
            {
              Dafny.ISequence<Dafny.Rune> _2477_lString;
              bool _2478___v80;
              bool _2479_lErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2480_recIdentsL;
              Dafny.ISequence<Dafny.Rune> _out1531;
              bool _out1532;
              bool _out1533;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1534;
              DCOMP.COMP.GenExpr(_2476_l, selfIdent, @params, true, out _out1531, out _out1532, out _out1533, out _out1534);
              _2477_lString = _out1531;
              _2478___v80 = _out1532;
              _2479_lErased = _out1533;
              _2480_recIdentsL = _out1534;
              if (!(_2479_lErased)) {
                _2477_lString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2477_lString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2474_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2477_lString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2480_recIdentsL);
            }
          } else {
          }
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2481_highString;
          _2481_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source75 = _2465_high;
          if (_source75.is_Some) {
            DAST._IExpression _2482___mcc_h1056 = _source75.dtor_Some_a0;
            DAST._IExpression _2483_h = _2482___mcc_h1056;
            {
              Dafny.ISequence<Dafny.Rune> _2484_hString;
              bool _2485___v81;
              bool _2486_hErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2487_recIdentsH;
              Dafny.ISequence<Dafny.Rune> _out1535;
              bool _out1536;
              bool _out1537;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1538;
              DCOMP.COMP.GenExpr(_2483_h, selfIdent, @params, true, out _out1535, out _out1536, out _out1537, out _out1538);
              _2484_hString = _out1535;
              _2485___v81 = _out1536;
              _2486_hErased = _out1537;
              _2487_recIdentsH = _out1538;
              if (!(_2486_hErased)) {
                _2484_hString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2484_hString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2481_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2484_hString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2487_recIdentsH);
            }
          } else {
          }
          if (_2467_isArray) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source76) => {
            if (_source76.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2488___mcc_h1057 = _source76.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2488___mcc_h1057, _pat_let0_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let0_0, _2489_l => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2489_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2474_lowString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("..")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source77) => {
            if (_source77.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2490___mcc_h1058 = _source77.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2490___mcc_h1058, _pat_let1_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let1_0, _2491_h => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2491_h), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2481_highString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isErased = _2471_onErased;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".to_vec())"));
          isOwned = true;
        }
      } else if (_source21.is_TupleSelect) {
        DAST._IExpression _2492___mcc_h169 = _source21.dtor_expr;
        BigInteger _2493___mcc_h170 = _source21.dtor_index;
        BigInteger _2494_idx = _2493___mcc_h170;
        DAST._IExpression _2495_on = _2492___mcc_h169;
        {
          Dafny.ISequence<Dafny.Rune> _2496_onString;
          bool _2497___v82;
          bool _2498_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2499_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1539;
          bool _out1540;
          bool _out1541;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1542;
          DCOMP.COMP.GenExpr(_2495_on, selfIdent, @params, false, out _out1539, out _out1540, out _out1541, out _out1542);
          _2496_onString = _out1539;
          _2497___v82 = _out1540;
          _2498_tupErased = _out1541;
          _2499_recIdents = _out1542;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2496_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2494_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2498_tupErased;
          readIdents = _2499_recIdents;
        }
      } else if (_source21.is_Call) {
        DAST._IExpression _2500___mcc_h171 = _source21.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2501___mcc_h172 = _source21.dtor_name;
        Dafny.ISequence<DAST._IType> _2502___mcc_h173 = _source21.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2503___mcc_h174 = _source21.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2504_args = _2503___mcc_h174;
        Dafny.ISequence<DAST._IType> _2505_typeArgs = _2502___mcc_h173;
        Dafny.ISequence<Dafny.Rune> _2506_name = _2501___mcc_h172;
        DAST._IExpression _2507_on = _2500___mcc_h171;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2508_typeArgString;
          _2508_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2505_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2509_typeI;
            _2509_typeI = BigInteger.Zero;
            _2508_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2509_typeI) < (new BigInteger((_2505_typeArgs).Count))) {
              if ((_2509_typeI).Sign == 1) {
                _2508_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2508_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2510_typeString;
              Dafny.ISequence<Dafny.Rune> _out1543;
              _out1543 = DCOMP.COMP.GenType((_2505_typeArgs).Select(_2509_typeI), false, false);
              _2510_typeString = _out1543;
              _2508_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2508_typeArgString, _2510_typeString);
              _2509_typeI = (_2509_typeI) + (BigInteger.One);
            }
            _2508_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2508_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2511_argString;
          _2511_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2512_i;
          _2512_i = BigInteger.Zero;
          while ((_2512_i) < (new BigInteger((_2504_args).Count))) {
            if ((_2512_i).Sign == 1) {
              _2511_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2511_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2513_argExpr;
            bool _2514_isOwned;
            bool _2515_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2516_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1544;
            bool _out1545;
            bool _out1546;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1547;
            DCOMP.COMP.GenExpr((_2504_args).Select(_2512_i), selfIdent, @params, false, out _out1544, out _out1545, out _out1546, out _out1547);
            _2513_argExpr = _out1544;
            _2514_isOwned = _out1545;
            _2515_argErased = _out1546;
            _2516_argIdents = _out1547;
            if (_2514_isOwned) {
              _2513_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2513_argExpr);
            }
            _2511_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2511_argString, _2513_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2516_argIdents);
            _2512_i = (_2512_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2517_enclosingString;
          bool _2518___v83;
          bool _2519___v84;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2520_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1548;
          bool _out1549;
          bool _out1550;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1551;
          DCOMP.COMP.GenExpr(_2507_on, selfIdent, @params, false, out _out1548, out _out1549, out _out1550, out _out1551);
          _2517_enclosingString = _out1548;
          _2518___v83 = _out1549;
          _2519___v84 = _out1550;
          _2520_recIdents = _out1551;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2520_recIdents);
          DAST._IExpression _source78 = _2507_on;
          if (_source78.is_Literal) {
            DAST._ILiteral _2521___mcc_h1059 = _source78.dtor_Literal_a0;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2522___mcc_h1061 = _source78.dtor_Ident_a0;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2523___mcc_h1063 = _source78.dtor_Companion_a0;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2517_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (_2506_name));
            }
          } else if (_source78.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2524___mcc_h1065 = _source78.dtor_Tuple_a0;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2525___mcc_h1067 = _source78.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2526___mcc_h1068 = _source78.dtor_args;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2527___mcc_h1071 = _source78.dtor_dims;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2528___mcc_h1073 = _source78.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2529___mcc_h1074 = _source78.dtor_variant;
            bool _2530___mcc_h1075 = _source78.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2531___mcc_h1076 = _source78.dtor_contents;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_Convert) {
            DAST._IExpression _2532___mcc_h1081 = _source78.dtor_value;
            DAST._IType _2533___mcc_h1082 = _source78.dtor_from;
            DAST._IType _2534___mcc_h1083 = _source78.dtor_typ;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2535___mcc_h1087 = _source78.dtor_elements;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2536___mcc_h1089 = _source78.dtor_elements;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_This) {
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_Ite) {
            DAST._IExpression _2537___mcc_h1091 = _source78.dtor_cond;
            DAST._IExpression _2538___mcc_h1092 = _source78.dtor_thn;
            DAST._IExpression _2539___mcc_h1093 = _source78.dtor_els;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_UnOp) {
            DAST._IUnaryOp _2540___mcc_h1097 = _source78.dtor_unOp;
            DAST._IExpression _2541___mcc_h1098 = _source78.dtor_expr;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2542___mcc_h1101 = _source78.dtor_op;
            DAST._IExpression _2543___mcc_h1102 = _source78.dtor_left;
            DAST._IExpression _2544___mcc_h1103 = _source78.dtor_right;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_ArrayLen) {
            DAST._IExpression _2545___mcc_h1107 = _source78.dtor_expr;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_Select) {
            DAST._IExpression _2546___mcc_h1109 = _source78.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2547___mcc_h1110 = _source78.dtor_field;
            bool _2548___mcc_h1111 = _source78.dtor_isConstant;
            bool _2549___mcc_h1112 = _source78.dtor_onDatatype;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_SelectFn) {
            DAST._IExpression _2550___mcc_h1117 = _source78.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2551___mcc_h1118 = _source78.dtor_field;
            bool _2552___mcc_h1119 = _source78.dtor_onDatatype;
            bool _2553___mcc_h1120 = _source78.dtor_isStatic;
            BigInteger _2554___mcc_h1121 = _source78.dtor_arity;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_Index) {
            DAST._IExpression _2555___mcc_h1127 = _source78.dtor_expr;
            bool _2556___mcc_h1128 = _source78.dtor_isArray;
            Dafny.ISequence<DAST._IExpression> _2557___mcc_h1129 = _source78.dtor_indices;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_IndexRange) {
            DAST._IExpression _2558___mcc_h1133 = _source78.dtor_expr;
            bool _2559___mcc_h1134 = _source78.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _2560___mcc_h1135 = _source78.dtor_low;
            DAST._IOptional<DAST._IExpression> _2561___mcc_h1136 = _source78.dtor_high;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_TupleSelect) {
            DAST._IExpression _2562___mcc_h1141 = _source78.dtor_expr;
            BigInteger _2563___mcc_h1142 = _source78.dtor_index;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_Call) {
            DAST._IExpression _2564___mcc_h1145 = _source78.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2565___mcc_h1146 = _source78.dtor_name;
            Dafny.ISequence<DAST._IType> _2566___mcc_h1147 = _source78.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2567___mcc_h1148 = _source78.dtor_args;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2568___mcc_h1153 = _source78.dtor_params;
            DAST._IType _2569___mcc_h1154 = _source78.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2570___mcc_h1155 = _source78.dtor_body;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2571___mcc_h1159 = _source78.dtor_name;
            DAST._IType _2572___mcc_h1160 = _source78.dtor_typ;
            DAST._IExpression _2573___mcc_h1161 = _source78.dtor_value;
            DAST._IExpression _2574___mcc_h1162 = _source78.dtor_iifeBody;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_Apply) {
            DAST._IExpression _2575___mcc_h1167 = _source78.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2576___mcc_h1168 = _source78.dtor_args;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else if (_source78.is_TypeTest) {
            DAST._IExpression _2577___mcc_h1171 = _source78.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2578___mcc_h1172 = _source78.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2579___mcc_h1173 = _source78.dtor_variant;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          } else {
            DAST._IType _2580___mcc_h1177 = _source78.dtor_typ;
            {
              _2517_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2517_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2506_name));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2517_enclosingString, _2508_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2511_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source21.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2581___mcc_h175 = _source21.dtor_params;
        DAST._IType _2582___mcc_h176 = _source21.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2583___mcc_h177 = _source21.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2584_body = _2583___mcc_h177;
        DAST._IType _2585_retType = _2582___mcc_h176;
        Dafny.ISequence<DAST._IFormal> _2586_params = _2581___mcc_h175;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2587_paramNames;
          _2587_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2588_i;
          _2588_i = BigInteger.Zero;
          while ((_2588_i) < (new BigInteger((_2586_params).Count))) {
            _2587_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2587_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2586_params).Select(_2588_i)).dtor_name));
            _2588_i = (_2588_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2589_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2590_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1552;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1553;
          DCOMP.COMP.GenStmts(_2584_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2587_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1552, out _out1553);
          _2589_recursiveGen = _out1552;
          _2590_recIdents = _out1553;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2591_allReadCloned;
          _2591_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2590_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2592_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2590_recIdents).Elements) {
              _2592_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2590_recIdents).Contains(_2592_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1750)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2587_paramNames).Contains(_2592_next))) {
              _2591_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2591_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2592_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2592_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2592_next));
            }
            _2590_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2590_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2592_next));
          }
          Dafny.ISequence<Dafny.Rune> _2593_paramsString;
          _2593_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2588_i = BigInteger.Zero;
          while ((_2588_i) < (new BigInteger((_2586_params).Count))) {
            if ((_2588_i).Sign == 1) {
              _2593_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2593_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2594_typStr;
            Dafny.ISequence<Dafny.Rune> _out1554;
            _out1554 = DCOMP.COMP.GenType(((_2586_params).Select(_2588_i)).dtor_typ, false, true);
            _2594_typStr = _out1554;
            _2593_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2593_paramsString, ((_2586_params).Select(_2588_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2594_typStr);
            _2588_i = (_2588_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2595_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1555;
          _out1555 = DCOMP.COMP.GenType(_2585_retType, false, true);
          _2595_retTypeGen = _out1555;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _2591_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _2593_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2595_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2589_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2596___mcc_h178 = _source21.dtor_name;
        DAST._IType _2597___mcc_h179 = _source21.dtor_typ;
        DAST._IExpression _2598___mcc_h180 = _source21.dtor_value;
        DAST._IExpression _2599___mcc_h181 = _source21.dtor_iifeBody;
        DAST._IExpression _2600_iifeBody = _2599___mcc_h181;
        DAST._IExpression _2601_value = _2598___mcc_h180;
        DAST._IType _2602_tpe = _2597___mcc_h179;
        Dafny.ISequence<Dafny.Rune> _2603_name = _2596___mcc_h178;
        {
          Dafny.ISequence<Dafny.Rune> _2604_valueGen;
          bool _2605_valueOwned;
          bool _2606_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2607_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1556;
          bool _out1557;
          bool _out1558;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1559;
          DCOMP.COMP.GenExpr(_2601_value, selfIdent, @params, false, out _out1556, out _out1557, out _out1558, out _out1559);
          _2604_valueGen = _out1556;
          _2605_valueOwned = _out1557;
          _2606_valueErased = _out1558;
          _2607_recIdents = _out1559;
          if (_2606_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2608_eraseFn;
            _2608_eraseFn = ((_2605_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2604_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2608_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2604_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2607_recIdents;
          Dafny.ISequence<Dafny.Rune> _2609_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1560;
          _out1560 = DCOMP.COMP.GenType(_2602_tpe, false, true);
          _2609_valueTypeGen = _out1560;
          Dafny.ISequence<Dafny.Rune> _2610_bodyGen;
          bool _2611_bodyOwned;
          bool _2612_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2613_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1561;
          bool _out1562;
          bool _out1563;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1564;
          DCOMP.COMP.GenExpr(_2600_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2605_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2603_name))))), mustOwn, out _out1561, out _out1562, out _out1563, out _out1564);
          _2610_bodyGen = _out1561;
          _2611_bodyOwned = _out1562;
          _2612_bodyErased = _out1563;
          _2613_bodyIdents = _out1564;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2613_bodyIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_2603_name))));
          Dafny.ISequence<Dafny.Rune> _2614_eraseFn;
          _2614_eraseFn = ((_2605_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2603_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2605_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2609_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2604_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2610_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2611_bodyOwned;
          isErased = _2612_bodyErased;
        }
      } else if (_source21.is_Apply) {
        DAST._IExpression _2615___mcc_h182 = _source21.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2616___mcc_h183 = _source21.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2617_args = _2616___mcc_h183;
        DAST._IExpression _2618_func = _2615___mcc_h182;
        {
          Dafny.ISequence<Dafny.Rune> _2619_funcString;
          bool _2620___v87;
          bool _2621_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2622_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1565;
          bool _out1566;
          bool _out1567;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1568;
          DCOMP.COMP.GenExpr(_2618_func, selfIdent, @params, false, out _out1565, out _out1566, out _out1567, out _out1568);
          _2619_funcString = _out1565;
          _2620___v87 = _out1566;
          _2621_funcErased = _out1567;
          _2622_recIdents = _out1568;
          readIdents = _2622_recIdents;
          Dafny.ISequence<Dafny.Rune> _2623_argString;
          _2623_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2624_i;
          _2624_i = BigInteger.Zero;
          while ((_2624_i) < (new BigInteger((_2617_args).Count))) {
            if ((_2624_i).Sign == 1) {
              _2623_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2623_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2625_argExpr;
            bool _2626_isOwned;
            bool _2627_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2628_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1569;
            bool _out1570;
            bool _out1571;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1572;
            DCOMP.COMP.GenExpr((_2617_args).Select(_2624_i), selfIdent, @params, false, out _out1569, out _out1570, out _out1571, out _out1572);
            _2625_argExpr = _out1569;
            _2626_isOwned = _out1570;
            _2627_argErased = _out1571;
            _2628_argIdents = _out1572;
            if (_2626_isOwned) {
              _2625_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2625_argExpr);
            }
            _2623_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2623_argString, _2625_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2628_argIdents);
            _2624_i = (_2624_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2619_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2623_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source21.is_TypeTest) {
        DAST._IExpression _2629___mcc_h184 = _source21.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2630___mcc_h185 = _source21.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2631___mcc_h186 = _source21.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2632_variant = _2631___mcc_h186;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2633_dType = _2630___mcc_h185;
        DAST._IExpression _2634_on = _2629___mcc_h184;
        {
          Dafny.ISequence<Dafny.Rune> _2635_exprGen;
          bool _2636___v88;
          bool _2637_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2638_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1573;
          bool _out1574;
          bool _out1575;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1576;
          DCOMP.COMP.GenExpr(_2634_on, selfIdent, @params, false, out _out1573, out _out1574, out _out1575, out _out1576);
          _2635_exprGen = _out1573;
          _2636___v88 = _out1574;
          _2637_exprErased = _out1575;
          _2638_recIdents = _out1576;
          Dafny.ISequence<Dafny.Rune> _2639_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1577;
          _out1577 = DCOMP.COMP.GenPath(_2633_dType);
          _2639_dTypePath = _out1577;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2635_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2639_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2632_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2638_recIdents;
        }
      } else {
        DAST._IType _2640___mcc_h187 = _source21.dtor_typ;
        DAST._IType _2641_typ = _2640___mcc_h187;
        {
          Dafny.ISequence<Dafny.Rune> _2642_typString;
          Dafny.ISequence<Dafny.Rune> _out1578;
          _out1578 = DCOMP.COMP.GenType(_2641_typ, false, false);
          _2642_typString = _out1578;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2642_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2643_i;
      _2643_i = BigInteger.Zero;
      while ((_2643_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2644_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1579;
        _out1579 = DCOMP.COMP.GenModule((p).Select(_2643_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2644_generated = _out1579;
        if ((_2643_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2644_generated);
        _2643_i = (_2643_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2645_i;
      _2645_i = BigInteger.Zero;
      while ((_2645_i) < (new BigInteger((fullName).Count))) {
        if ((_2645_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2645_i));
        _2645_i = (_2645_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

