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
      hash = ((hash << 5) + hash) + 7;
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
        } else if (_source13.is_Call) {
          DAST._IExpression _222___mcc_h22 = _source13.dtor_on;
          Dafny.ISequence<Dafny.Rune> _223___mcc_h23 = _source13.dtor_name;
          Dafny.ISequence<DAST._IType> _224___mcc_h24 = _source13.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _225___mcc_h25 = _source13.dtor_args;
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _226___mcc_h26 = _source13.dtor_outs;
        } else if (_source13.is_Return) {
          DAST._IExpression _227___mcc_h32 = _source13.dtor_expr;
        } else if (_source13.is_EarlyReturn) {
        } else if (_source13.is_Break) {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _228___mcc_h34 = _source13.dtor_toLabel;
        } else if (_source13.is_TailRecursive) {
          Dafny.ISequence<DAST._IStatement> _229___mcc_h36 = _source13.dtor_body;
        } else if (_source13.is_JumpTailCallStart) {
        } else if (_source13.is_Halt) {
        } else {
          DAST._IExpression _230___mcc_h38 = _source13.dtor_Print_a0;
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
        Dafny.ISequence<Dafny.Rune> _231___mcc_h0 = _source14.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _source15 = _231___mcc_h0;
        Dafny.ISequence<Dafny.Rune> _232___mcc_h1 = _source15;
        Dafny.ISequence<Dafny.Rune> _233_id = _232___mcc_h1;
        {
          if ((@params).Contains(_233_id)) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*r#"), _233_id);
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _233_id);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_233_id);
          needsIIFE = false;
        }
      } else if (_source14.is_Select) {
        DAST._IExpression _234___mcc_h2 = _source14.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _235___mcc_h3 = _source14.dtor_field;
        Dafny.ISequence<Dafny.Rune> _236_field = _235___mcc_h3;
        DAST._IExpression _237_on = _234___mcc_h2;
        {
          Dafny.ISequence<Dafny.Rune> _238_onExpr;
          bool _239_onOwned;
          bool _240_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _241_recIdents;
          Dafny.ISequence<Dafny.Rune> _out64;
          bool _out65;
          bool _out66;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out67;
          DCOMP.COMP.GenExpr(_237_on, selfIdent, @params, false, out _out64, out _out65, out _out66, out _out67);
          _238_onExpr = _out64;
          _239_onOwned = _out65;
          _240_onErased = _out66;
          _241_recIdents = _out67;
          if (!(_240_onErased)) {
            Dafny.ISequence<Dafny.Rune> _242_eraseFn;
            _242_eraseFn = ((_239_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _238_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _242_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _238_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _238_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _236_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()) = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = _241_recIdents;
          needsIIFE = true;
        }
      } else {
        DAST._IExpression _243___mcc_h4 = _source14.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _244___mcc_h5 = _source14.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _245_indices = _244___mcc_h5;
        DAST._IExpression _246_on = _243___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _247_onExpr;
          bool _248_onOwned;
          bool _249_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _250_recIdents;
          Dafny.ISequence<Dafny.Rune> _out68;
          bool _out69;
          bool _out70;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out71;
          DCOMP.COMP.GenExpr(_246_on, selfIdent, @params, false, out _out68, out _out69, out _out70, out _out71);
          _247_onExpr = _out68;
          _248_onOwned = _out69;
          _249_onErased = _out70;
          _250_recIdents = _out71;
          readIdents = _250_recIdents;
          if (!(_249_onErased)) {
            Dafny.ISequence<Dafny.Rune> _251_eraseFn;
            _251_eraseFn = ((_248_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _247_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _251_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _247_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          BigInteger _252_i;
          _252_i = BigInteger.Zero;
          while ((_252_i) < (new BigInteger((_245_indices).Count))) {
            Dafny.ISequence<Dafny.Rune> _253_idx;
            bool _254___v16;
            bool _255_idxErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _256_recIdentsIdx;
            Dafny.ISequence<Dafny.Rune> _out72;
            bool _out73;
            bool _out74;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out75;
            DCOMP.COMP.GenExpr((_245_indices).Select(_252_i), selfIdent, @params, true, out _out72, out _out73, out _out74, out _out75);
            _253_idx = _out72;
            _254___v16 = _out73;
            _255_idxErased = _out74;
            _256_recIdentsIdx = _out75;
            if (!(_255_idxErased)) {
              _253_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _253_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let __idx")), DCOMP.__default.natToString(_252_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = <usize as ::dafny_runtime::NumCast>::from(")), _253_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap();\n"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _256_recIdentsIdx);
            _252_i = (_252_i) + (BigInteger.One);
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, _247_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()"));
          _252_i = BigInteger.Zero;
          while ((_252_i) < (new BigInteger((_245_indices).Count))) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[__idx")), DCOMP.__default.natToString(_252_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
            _252_i = (_252_i) + (BigInteger.One);
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
        Dafny.ISequence<Dafny.Rune> _257___mcc_h0 = _source16.dtor_name;
        DAST._IType _258___mcc_h1 = _source16.dtor_typ;
        DAST._IOptional<DAST._IExpression> _259___mcc_h2 = _source16.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source17 = _259___mcc_h2;
        if (_source17.is_Some) {
          DAST._IExpression _260___mcc_h3 = _source17.dtor_Some_a0;
          DAST._IExpression _261_expression = _260___mcc_h3;
          DAST._IType _262_typ = _258___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _263_name = _257___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _264_expr;
            bool _265___v17;
            bool _266_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _267_recIdents;
            Dafny.ISequence<Dafny.Rune> _out76;
            bool _out77;
            bool _out78;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out79;
            DCOMP.COMP.GenExpr(_261_expression, selfIdent, @params, true, out _out76, out _out77, out _out78, out _out79);
            _264_expr = _out76;
            _265___v17 = _out77;
            _266_recErased = _out78;
            _267_recIdents = _out79;
            if (_266_recErased) {
              _264_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _264_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _268_typeString;
            Dafny.ISequence<Dafny.Rune> _out80;
            _out80 = DCOMP.COMP.GenType(_262_typ, true, false);
            _268_typeString = _out80;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _263_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _268_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _264_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _267_recIdents;
          }
        } else {
          DAST._IType _269_typ = _258___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _270_name = _257___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _271_typeString;
            Dafny.ISequence<Dafny.Rune> _out81;
            _out81 = DCOMP.COMP.GenType(_269_typ, true, false);
            _271_typeString = _out81;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _270_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _271_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source16.is_Assign) {
        DAST._IAssignLhs _272___mcc_h4 = _source16.dtor_lhs;
        DAST._IExpression _273___mcc_h5 = _source16.dtor_value;
        DAST._IExpression _274_expression = _273___mcc_h5;
        DAST._IAssignLhs _275_lhs = _272___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _276_lhsGen;
          bool _277_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _278_recIdents;
          Dafny.ISequence<Dafny.Rune> _out82;
          bool _out83;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out84;
          DCOMP.COMP.GenAssignLhs(_275_lhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("__rhs"), selfIdent, @params, out _out82, out _out83, out _out84);
          _276_lhsGen = _out82;
          _277_needsIIFE = _out83;
          _278_recIdents = _out84;
          Dafny.ISequence<Dafny.Rune> _279_exprGen;
          bool _280___v18;
          bool _281_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _282_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out85;
          bool _out86;
          bool _out87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out88;
          DCOMP.COMP.GenExpr(_274_expression, selfIdent, @params, true, out _out85, out _out86, out _out87, out _out88);
          _279_exprGen = _out85;
          _280___v18 = _out86;
          _281_exprErased = _out87;
          _282_exprIdents = _out88;
          if (_281_exprErased) {
            _279_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _279_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_277_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __rhs = "), _279_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _276_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_276_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _279_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_278_recIdents, _282_exprIdents);
        }
      } else if (_source16.is_If) {
        DAST._IExpression _283___mcc_h6 = _source16.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _284___mcc_h7 = _source16.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _285___mcc_h8 = _source16.dtor_els;
        Dafny.ISequence<DAST._IStatement> _286_els = _285___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _287_thn = _284___mcc_h7;
        DAST._IExpression _288_cond = _283___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _289_condString;
          bool _290___v19;
          bool _291_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _292_recIdents;
          Dafny.ISequence<Dafny.Rune> _out89;
          bool _out90;
          bool _out91;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out92;
          DCOMP.COMP.GenExpr(_288_cond, selfIdent, @params, true, out _out89, out _out90, out _out91, out _out92);
          _289_condString = _out89;
          _290___v19 = _out90;
          _291_condErased = _out91;
          _292_recIdents = _out92;
          if (!(_291_condErased)) {
            _289_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _289_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _292_recIdents;
          Dafny.ISequence<Dafny.Rune> _293_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _294_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out93;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
          DCOMP.COMP.GenStmts(_287_thn, selfIdent, @params, isLast, earlyReturn, out _out93, out _out94);
          _293_thnString = _out93;
          _294_thnIdents = _out94;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _294_thnIdents);
          Dafny.ISequence<Dafny.Rune> _295_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _296_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out95;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out96;
          DCOMP.COMP.GenStmts(_286_els, selfIdent, @params, isLast, earlyReturn, out _out95, out _out96);
          _295_elsString = _out95;
          _296_elsIdents = _out96;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _296_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _289_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _293_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _295_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_While) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _297___mcc_h9 = _source16.dtor_lbl;
        DAST._IExpression _298___mcc_h10 = _source16.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _299___mcc_h11 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _300_body = _299___mcc_h11;
        DAST._IExpression _301_cond = _298___mcc_h10;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _302_lbl = _297___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _303_condString;
          bool _304___v20;
          bool _305_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _306_recIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          bool _out98;
          bool _out99;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out100;
          DCOMP.COMP.GenExpr(_301_cond, selfIdent, @params, true, out _out97, out _out98, out _out99, out _out100);
          _303_condString = _out97;
          _304___v20 = _out98;
          _305_condErased = _out99;
          _306_recIdents = _out100;
          if (!(_305_condErased)) {
            _303_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _303_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _306_recIdents;
          Dafny.ISequence<Dafny.Rune> _307_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _308_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenStmts(_300_body, selfIdent, @params, false, earlyReturn, out _out101, out _out102);
          _307_bodyString = _out101;
          _308_bodyIdents = _out102;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _308_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _309_lblString;
          _309_lblString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source18 = _302_lbl;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.Rune> _310___mcc_h21 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _311_id = _310___mcc_h21;
            {
              _309_lblString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _311_id), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": "));
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_309_lblString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while ")), _303_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _307_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Call) {
        DAST._IExpression _312___mcc_h12 = _source16.dtor_on;
        Dafny.ISequence<Dafny.Rune> _313___mcc_h13 = _source16.dtor_name;
        Dafny.ISequence<DAST._IType> _314___mcc_h14 = _source16.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _315___mcc_h15 = _source16.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _316___mcc_h16 = _source16.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _317_maybeOutVars = _316___mcc_h16;
        Dafny.ISequence<DAST._IExpression> _318_args = _315___mcc_h15;
        Dafny.ISequence<DAST._IType> _319_typeArgs = _314___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _320_name = _313___mcc_h13;
        DAST._IExpression _321_on = _312___mcc_h12;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _322_typeArgString;
          _322_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_319_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _323_typeI;
            _323_typeI = BigInteger.Zero;
            _322_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_323_typeI) < (new BigInteger((_319_typeArgs).Count))) {
              if ((_323_typeI).Sign == 1) {
                _322_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_322_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _324_typeString;
              Dafny.ISequence<Dafny.Rune> _out103;
              _out103 = DCOMP.COMP.GenType((_319_typeArgs).Select(_323_typeI), false, false);
              _324_typeString = _out103;
              _322_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_322_typeArgString, _324_typeString);
              _323_typeI = (_323_typeI) + (BigInteger.One);
            }
            _322_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_322_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _325_argString;
          _325_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _326_i;
          _326_i = BigInteger.Zero;
          while ((_326_i) < (new BigInteger((_318_args).Count))) {
            if ((_326_i).Sign == 1) {
              _325_argString = Dafny.Sequence<Dafny.Rune>.Concat(_325_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _327_argExpr;
            bool _328_isOwned;
            bool _329_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _330_argIdents;
            Dafny.ISequence<Dafny.Rune> _out104;
            bool _out105;
            bool _out106;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out107;
            DCOMP.COMP.GenExpr((_318_args).Select(_326_i), selfIdent, @params, false, out _out104, out _out105, out _out106, out _out107);
            _327_argExpr = _out104;
            _328_isOwned = _out105;
            _329_argErased = _out106;
            _330_argIdents = _out107;
            if (_328_isOwned) {
              _327_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _327_argExpr);
            }
            _325_argString = Dafny.Sequence<Dafny.Rune>.Concat(_325_argString, _327_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _330_argIdents);
            _326_i = (_326_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _331_enclosingString;
          bool _332___v21;
          bool _333___v22;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _334_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out108;
          bool _out109;
          bool _out110;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out111;
          DCOMP.COMP.GenExpr(_321_on, selfIdent, @params, false, out _out108, out _out109, out _out110, out _out111);
          _331_enclosingString = _out108;
          _332___v21 = _out109;
          _333___v22 = _out110;
          _334_enclosingIdents = _out111;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _334_enclosingIdents);
          DAST._IExpression _source19 = _321_on;
          if (_source19.is_Literal) {
            DAST._ILiteral _335___mcc_h22 = _source19.dtor_Literal_a0;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _336___mcc_h24 = _source19.dtor_Ident_a0;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _337___mcc_h26 = _source19.dtor_Companion_a0;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_331_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source19.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _338___mcc_h28 = _source19.dtor_Tuple_a0;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _339___mcc_h30 = _source19.dtor_path;
            Dafny.ISequence<DAST._IExpression> _340___mcc_h31 = _source19.dtor_args;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _341___mcc_h34 = _source19.dtor_dims;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _342___mcc_h36 = _source19.dtor_path;
            Dafny.ISequence<Dafny.Rune> _343___mcc_h37 = _source19.dtor_variant;
            bool _344___mcc_h38 = _source19.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _345___mcc_h39 = _source19.dtor_contents;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Convert) {
            DAST._IExpression _346___mcc_h44 = _source19.dtor_value;
            DAST._IType _347___mcc_h45 = _source19.dtor_from;
            DAST._IType _348___mcc_h46 = _source19.dtor_typ;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _349___mcc_h50 = _source19.dtor_elements;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _350___mcc_h52 = _source19.dtor_elements;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _351___mcc_h54 = _source19.dtor_mapElems;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_This) {
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Ite) {
            DAST._IExpression _352___mcc_h56 = _source19.dtor_cond;
            DAST._IExpression _353___mcc_h57 = _source19.dtor_thn;
            DAST._IExpression _354___mcc_h58 = _source19.dtor_els;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_UnOp) {
            DAST._IUnaryOp _355___mcc_h62 = _source19.dtor_unOp;
            DAST._IExpression _356___mcc_h63 = _source19.dtor_expr;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _357___mcc_h66 = _source19.dtor_op;
            DAST._IExpression _358___mcc_h67 = _source19.dtor_left;
            DAST._IExpression _359___mcc_h68 = _source19.dtor_right;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_ArrayLen) {
            DAST._IExpression _360___mcc_h72 = _source19.dtor_expr;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Select) {
            DAST._IExpression _361___mcc_h74 = _source19.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _362___mcc_h75 = _source19.dtor_field;
            bool _363___mcc_h76 = _source19.dtor_isConstant;
            bool _364___mcc_h77 = _source19.dtor_onDatatype;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_SelectFn) {
            DAST._IExpression _365___mcc_h82 = _source19.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _366___mcc_h83 = _source19.dtor_field;
            bool _367___mcc_h84 = _source19.dtor_onDatatype;
            bool _368___mcc_h85 = _source19.dtor_isStatic;
            BigInteger _369___mcc_h86 = _source19.dtor_arity;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Index) {
            DAST._IExpression _370___mcc_h92 = _source19.dtor_expr;
            DAST._ICollKind _371___mcc_h93 = _source19.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _372___mcc_h94 = _source19.dtor_indices;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_IndexRange) {
            DAST._IExpression _373___mcc_h98 = _source19.dtor_expr;
            bool _374___mcc_h99 = _source19.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _375___mcc_h100 = _source19.dtor_low;
            DAST._IOptional<DAST._IExpression> _376___mcc_h101 = _source19.dtor_high;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_TupleSelect) {
            DAST._IExpression _377___mcc_h106 = _source19.dtor_expr;
            BigInteger _378___mcc_h107 = _source19.dtor_index;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Call) {
            DAST._IExpression _379___mcc_h110 = _source19.dtor_on;
            Dafny.ISequence<Dafny.Rune> _380___mcc_h111 = _source19.dtor_name;
            Dafny.ISequence<DAST._IType> _381___mcc_h112 = _source19.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _382___mcc_h113 = _source19.dtor_args;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _383___mcc_h118 = _source19.dtor_params;
            DAST._IType _384___mcc_h119 = _source19.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _385___mcc_h120 = _source19.dtor_body;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _386___mcc_h124 = _source19.dtor_values;
            DAST._IType _387___mcc_h125 = _source19.dtor_retType;
            DAST._IExpression _388___mcc_h126 = _source19.dtor_expr;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _389___mcc_h130 = _source19.dtor_name;
            DAST._IType _390___mcc_h131 = _source19.dtor_typ;
            DAST._IExpression _391___mcc_h132 = _source19.dtor_value;
            DAST._IExpression _392___mcc_h133 = _source19.dtor_iifeBody;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Apply) {
            DAST._IExpression _393___mcc_h138 = _source19.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _394___mcc_h139 = _source19.dtor_args;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_TypeTest) {
            DAST._IExpression _395___mcc_h142 = _source19.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _396___mcc_h143 = _source19.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _397___mcc_h144 = _source19.dtor_variant;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _398___mcc_h148 = _source19.dtor_typ;
            {
              _331_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _399_receiver;
          _399_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source20 = _317_maybeOutVars;
          if (_source20.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _400___mcc_h150 = _source20.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _401_outVars = _400___mcc_h150;
            {
              if ((new BigInteger((_401_outVars).Count)) > (BigInteger.One)) {
                _399_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _402_outI;
              _402_outI = BigInteger.Zero;
              while ((_402_outI) < (new BigInteger((_401_outVars).Count))) {
                if ((_402_outI).Sign == 1) {
                  _399_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_399_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _403_outVar;
                _403_outVar = (_401_outVars).Select(_402_outI);
                _399_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_399_receiver, (_403_outVar));
                _402_outI = (_402_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_401_outVars).Count)) > (BigInteger.One)) {
                _399_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_399_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_399_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_399_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _331_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _320_name), _322_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _325_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source16.is_Return) {
        DAST._IExpression _404___mcc_h17 = _source16.dtor_expr;
        DAST._IExpression _405_expr = _404___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _406_exprString;
          bool _407___v25;
          bool _408_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _409_recIdents;
          Dafny.ISequence<Dafny.Rune> _out112;
          bool _out113;
          bool _out114;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out115;
          DCOMP.COMP.GenExpr(_405_expr, selfIdent, @params, true, out _out112, out _out113, out _out114, out _out115);
          _406_exprString = _out112;
          _407___v25 = _out113;
          _408_recErased = _out114;
          _409_recIdents = _out115;
          _406_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _406_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _409_recIdents;
          if (isLast) {
            generated = _406_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _406_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source16.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_Break) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _410___mcc_h18 = _source16.dtor_toLabel;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _411_toLabel = _410___mcc_h18;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source21 = _411_toLabel;
          if (_source21.is_Some) {
            Dafny.ISequence<Dafny.Rune> _412___mcc_h151 = _source21.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _413_lbl = _412___mcc_h151;
            {
              generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break 'label_"), _413_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            }
          } else {
            {
              generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break;");
            }
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _414___mcc_h19 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _415_body = _414___mcc_h19;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _416_paramI;
          _416_paramI = BigInteger.Zero;
          while ((_416_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _417_param;
            _417_param = (@params).Select(_416_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _417_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _417_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _416_paramI = (_416_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _418_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _419_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out116;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out117;
          DCOMP.COMP.GenStmts(_415_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out116, out _out117);
          _418_bodyString = _out116;
          _419_bodyIdents = _out117;
          readIdents = _419_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _418_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
        DAST._IExpression _420___mcc_h20 = _source16.dtor_Print_a0;
        DAST._IExpression _421_e = _420___mcc_h20;
        {
          Dafny.ISequence<Dafny.Rune> _422_printedExpr;
          bool _423_isOwned;
          bool _424___v26;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _425_recIdents;
          Dafny.ISequence<Dafny.Rune> _out118;
          bool _out119;
          bool _out120;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out121;
          DCOMP.COMP.GenExpr(_421_e, selfIdent, @params, false, out _out118, out _out119, out _out120, out _out121);
          _422_printedExpr = _out118;
          _423_isOwned = _out119;
          _424___v26 = _out120;
          _425_recIdents = _out121;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_423_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _422_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _425_recIdents;
        }
      }
    }
    public static void GenExpr(DAST._IExpression e, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool mustOwn, out Dafny.ISequence<Dafny.Rune> s, out bool isOwned, out bool isErased, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      isOwned = false;
      isErased = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IExpression _source22 = e;
      if (_source22.is_Literal) {
        DAST._ILiteral _426___mcc_h0 = _source22.dtor_Literal_a0;
        DAST._ILiteral _source23 = _426___mcc_h0;
        if (_source23.is_BoolLiteral) {
          bool _427___mcc_h1 = _source23.dtor_BoolLiteral_a0;
          if ((_427___mcc_h1) == (false)) {
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
        } else if (_source23.is_IntLiteral) {
          Dafny.ISequence<Dafny.Rune> _428___mcc_h2 = _source23.dtor_IntLiteral_a0;
          DAST._IType _429___mcc_h3 = _source23.dtor_IntLiteral_a1;
          DAST._IType _430_t = _429___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _431_i = _428___mcc_h2;
          {
            DAST._IType _source24 = _430_t;
            if (_source24.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _432___mcc_h200 = _source24.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _433___mcc_h201 = _source24.dtor_typeArgs;
              DAST._IResolvedType _434___mcc_h202 = _source24.dtor_resolved;
              {
                s = _431_i;
              }
            } else if (_source24.is_Nullable) {
              DAST._IType _435___mcc_h206 = _source24.dtor_Nullable_a0;
              {
                s = _431_i;
              }
            } else if (_source24.is_Tuple) {
              Dafny.ISequence<DAST._IType> _436___mcc_h208 = _source24.dtor_Tuple_a0;
              {
                s = _431_i;
              }
            } else if (_source24.is_Array) {
              DAST._IType _437___mcc_h210 = _source24.dtor_element;
              {
                s = _431_i;
              }
            } else if (_source24.is_Seq) {
              DAST._IType _438___mcc_h212 = _source24.dtor_element;
              {
                s = _431_i;
              }
            } else if (_source24.is_Set) {
              DAST._IType _439___mcc_h214 = _source24.dtor_element;
              {
                s = _431_i;
              }
            } else if (_source24.is_Multiset) {
              DAST._IType _440___mcc_h216 = _source24.dtor_element;
              {
                s = _431_i;
              }
            } else if (_source24.is_Map) {
              DAST._IType _441___mcc_h218 = _source24.dtor_key;
              DAST._IType _442___mcc_h219 = _source24.dtor_value;
              {
                s = _431_i;
              }
            } else if (_source24.is_Arrow) {
              Dafny.ISequence<DAST._IType> _443___mcc_h222 = _source24.dtor_args;
              DAST._IType _444___mcc_h223 = _source24.dtor_result;
              {
                s = _431_i;
              }
            } else if (_source24.is_Primitive) {
              DAST._IPrimitive _445___mcc_h226 = _source24.dtor_Primitive_a0;
              DAST._IPrimitive _source25 = _445___mcc_h226;
              if (_source25.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _431_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source25.is_Real) {
                {
                  s = _431_i;
                }
              } else if (_source25.is_String) {
                {
                  s = _431_i;
                }
              } else if (_source25.is_Bool) {
                {
                  s = _431_i;
                }
              } else {
                {
                  s = _431_i;
                }
              }
            } else if (_source24.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _446___mcc_h228 = _source24.dtor_Passthrough_a0;
              {
                s = _431_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _447___mcc_h230 = _source24.dtor_TypeArg_a0;
              {
                s = _431_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source23.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _448___mcc_h4 = _source23.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _449___mcc_h5 = _source23.dtor_DecLiteral_a1;
          DAST._IType _450___mcc_h6 = _source23.dtor_DecLiteral_a2;
          DAST._IType _451_t = _450___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _452_d = _449___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _453_n = _448___mcc_h4;
          {
            DAST._IType _source26 = _451_t;
            if (_source26.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _454___mcc_h232 = _source26.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _455___mcc_h233 = _source26.dtor_typeArgs;
              DAST._IResolvedType _456___mcc_h234 = _source26.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source26.is_Nullable) {
              DAST._IType _457___mcc_h238 = _source26.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source26.is_Tuple) {
              Dafny.ISequence<DAST._IType> _458___mcc_h240 = _source26.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source26.is_Array) {
              DAST._IType _459___mcc_h242 = _source26.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source26.is_Seq) {
              DAST._IType _460___mcc_h244 = _source26.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source26.is_Set) {
              DAST._IType _461___mcc_h246 = _source26.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source26.is_Multiset) {
              DAST._IType _462___mcc_h248 = _source26.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source26.is_Map) {
              DAST._IType _463___mcc_h250 = _source26.dtor_key;
              DAST._IType _464___mcc_h251 = _source26.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source26.is_Arrow) {
              Dafny.ISequence<DAST._IType> _465___mcc_h254 = _source26.dtor_args;
              DAST._IType _466___mcc_h255 = _source26.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source26.is_Primitive) {
              DAST._IPrimitive _467___mcc_h258 = _source26.dtor_Primitive_a0;
              DAST._IPrimitive _source27 = _467___mcc_h258;
              if (_source27.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source27.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _453_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source27.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source27.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source26.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _468___mcc_h260 = _source26.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _469___mcc_h262 = _source26.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_453_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _452_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source23.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _470___mcc_h7 = _source23.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _471_l = _470___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _471_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source23.is_CharLiteral) {
          Dafny.Rune _472___mcc_h8 = _source23.dtor_CharLiteral_a0;
          Dafny.Rune _473_c = _472___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_473_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
      } else if (_source22.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _474___mcc_h9 = _source22.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _475_name = _474___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _475_name);
          if (!((@params).Contains(_475_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_475_name);
        }
      } else if (_source22.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _476___mcc_h10 = _source22.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _477_path = _476___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out122;
          _out122 = DCOMP.COMP.GenPath(_477_path);
          s = _out122;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source22.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _478___mcc_h11 = _source22.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _479_values = _478___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _480_i;
          _480_i = BigInteger.Zero;
          bool _481_allErased;
          _481_allErased = true;
          while ((_480_i) < (new BigInteger((_479_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _482___v29;
            bool _483___v30;
            bool _484_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _485___v31;
            Dafny.ISequence<Dafny.Rune> _out123;
            bool _out124;
            bool _out125;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out126;
            DCOMP.COMP.GenExpr((_479_values).Select(_480_i), selfIdent, @params, true, out _out123, out _out124, out _out125, out _out126);
            _482___v29 = _out123;
            _483___v30 = _out124;
            _484_isErased = _out125;
            _485___v31 = _out126;
            _481_allErased = (_481_allErased) && (_484_isErased);
            _480_i = (_480_i) + (BigInteger.One);
          }
          _480_i = BigInteger.Zero;
          while ((_480_i) < (new BigInteger((_479_values).Count))) {
            if ((_480_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _486_recursiveGen;
            bool _487___v32;
            bool _488_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _489_recIdents;
            Dafny.ISequence<Dafny.Rune> _out127;
            bool _out128;
            bool _out129;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out130;
            DCOMP.COMP.GenExpr((_479_values).Select(_480_i), selfIdent, @params, true, out _out127, out _out128, out _out129, out _out130);
            _486_recursiveGen = _out127;
            _487___v32 = _out128;
            _488_isErased = _out129;
            _489_recIdents = _out130;
            if ((_488_isErased) && (!(_481_allErased))) {
              _486_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _486_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _486_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _489_recIdents);
            _480_i = (_480_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _481_allErased;
        }
      } else if (_source22.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _490___mcc_h12 = _source22.dtor_path;
        Dafny.ISequence<DAST._IExpression> _491___mcc_h13 = _source22.dtor_args;
        Dafny.ISequence<DAST._IExpression> _492_args = _491___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _493_path = _490___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _494_path;
          Dafny.ISequence<Dafny.Rune> _out131;
          _out131 = DCOMP.COMP.GenPath(_493_path);
          _494_path = _out131;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _494_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _495_i;
          _495_i = BigInteger.Zero;
          while ((_495_i) < (new BigInteger((_492_args).Count))) {
            if ((_495_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _496_recursiveGen;
            bool _497___v33;
            bool _498_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _499_recIdents;
            Dafny.ISequence<Dafny.Rune> _out132;
            bool _out133;
            bool _out134;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out135;
            DCOMP.COMP.GenExpr((_492_args).Select(_495_i), selfIdent, @params, true, out _out132, out _out133, out _out134, out _out135);
            _496_recursiveGen = _out132;
            _497___v33 = _out133;
            _498_isErased = _out134;
            _499_recIdents = _out135;
            if (_498_isErased) {
              _496_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _496_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _496_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _499_recIdents);
            _495_i = (_495_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source22.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _500___mcc_h14 = _source22.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _501_dims = _500___mcc_h14;
        {
          BigInteger _502_i;
          _502_i = (new BigInteger((_501_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_502_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _503_recursiveGen;
            bool _504___v34;
            bool _505_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _506_recIdents;
            Dafny.ISequence<Dafny.Rune> _out136;
            bool _out137;
            bool _out138;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out139;
            DCOMP.COMP.GenExpr((_501_dims).Select(_502_i), selfIdent, @params, true, out _out136, out _out137, out _out138, out _out139);
            _503_recursiveGen = _out136;
            _504___v34 = _out137;
            _505_isErased = _out138;
            _506_recIdents = _out139;
            if (!(_505_isErased)) {
              _503_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _503_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _503_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _506_recIdents);
            _502_i = (_502_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source22.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _507___mcc_h15 = _source22.dtor_path;
        Dafny.ISequence<Dafny.Rune> _508___mcc_h16 = _source22.dtor_variant;
        bool _509___mcc_h17 = _source22.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _510___mcc_h18 = _source22.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _511_values = _510___mcc_h18;
        bool _512_isCo = _509___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _513_variant = _508___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _514_path = _507___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _515_path;
          Dafny.ISequence<Dafny.Rune> _out140;
          _out140 = DCOMP.COMP.GenPath(_514_path);
          _515_path = _out140;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _515_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _513_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _516_i;
          _516_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_516_i) < (new BigInteger((_511_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_511_values).Select(_516_i);
            Dafny.ISequence<Dafny.Rune> _517_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _518_value = _let_tmp_rhs0.dtor__1;
            if ((_516_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_512_isCo) {
              Dafny.ISequence<Dafny.Rune> _519_recursiveGen;
              bool _520___v35;
              bool _521_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _522_recIdents;
              Dafny.ISequence<Dafny.Rune> _out141;
              bool _out142;
              bool _out143;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out144;
              DCOMP.COMP.GenExpr(_518_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out141, out _out142, out _out143, out _out144);
              _519_recursiveGen = _out141;
              _520___v35 = _out142;
              _521_isErased = _out143;
              _522_recIdents = _out144;
              if (!(_521_isErased)) {
                _519_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _519_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _519_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _519_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _522_recIdents);
              Dafny.ISequence<Dafny.Rune> _523_allReadCloned;
              _523_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_522_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _524_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_522_recIdents).Elements) {
                  _524_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_522_recIdents).Contains(_524_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1168)");
              after__ASSIGN_SUCH_THAT_0:;
                _523_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_523_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _524_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _524_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _522_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_522_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_524_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _517_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _523_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _519_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _525_recursiveGen;
              bool _526___v36;
              bool _527_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _528_recIdents;
              Dafny.ISequence<Dafny.Rune> _out145;
              bool _out146;
              bool _out147;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
              DCOMP.COMP.GenExpr(_518_value, selfIdent, @params, true, out _out145, out _out146, out _out147, out _out148);
              _525_recursiveGen = _out145;
              _526___v36 = _out146;
              _527_isErased = _out147;
              _528_recIdents = _out148;
              if (!(_527_isErased)) {
                _525_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _525_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _525_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _525_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _517_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _525_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _528_recIdents);
            }
            _516_i = (_516_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source22.is_Convert) {
        DAST._IExpression _529___mcc_h19 = _source22.dtor_value;
        DAST._IType _530___mcc_h20 = _source22.dtor_from;
        DAST._IType _531___mcc_h21 = _source22.dtor_typ;
        DAST._IType _532_toTpe = _531___mcc_h21;
        DAST._IType _533_fromTpe = _530___mcc_h20;
        DAST._IExpression _534_expr = _529___mcc_h19;
        {
          if (object.Equals(_533_fromTpe, _532_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _535_recursiveGen;
            bool _536_recOwned;
            bool _537_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _538_recIdents;
            Dafny.ISequence<Dafny.Rune> _out149;
            bool _out150;
            bool _out151;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
            DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out149, out _out150, out _out151, out _out152);
            _535_recursiveGen = _out149;
            _536_recOwned = _out150;
            _537_recErased = _out151;
            _538_recIdents = _out152;
            s = _535_recursiveGen;
            isOwned = _536_recOwned;
            isErased = _537_recErased;
            readIdents = _538_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source28 = _System.Tuple2<DAST._IType, DAST._IType>.create(_533_fromTpe, _532_toTpe);
            DAST._IType _539___mcc_h264 = _source28.dtor__0;
            DAST._IType _540___mcc_h265 = _source28.dtor__1;
            DAST._IType _source29 = _539___mcc_h264;
            if (_source29.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _541___mcc_h268 = _source29.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _542___mcc_h269 = _source29.dtor_typeArgs;
              DAST._IResolvedType _543___mcc_h270 = _source29.dtor_resolved;
              DAST._IResolvedType _source30 = _543___mcc_h270;
              if (_source30.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _544___mcc_h280 = _source30.dtor_path;
                DAST._IType _source31 = _540___mcc_h265;
                if (_source31.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _545___mcc_h284 = _source31.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _546___mcc_h285 = _source31.dtor_typeArgs;
                  DAST._IResolvedType _547___mcc_h286 = _source31.dtor_resolved;
                  DAST._IResolvedType _source32 = _547___mcc_h286;
                  if (_source32.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _548___mcc_h290 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _549_recursiveGen;
                      bool _550_recOwned;
                      bool _551_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _552_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out153;
                      bool _out154;
                      bool _out155;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out153, out _out154, out _out155, out _out156);
                      _549_recursiveGen = _out153;
                      _550_recOwned = _out154;
                      _551_recErased = _out155;
                      _552_recIdents = _out156;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _549_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _550_recOwned;
                      isErased = _551_recErased;
                      readIdents = _552_recIdents;
                    }
                  } else if (_source32.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _553___mcc_h292 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _554_recursiveGen;
                      bool _555_recOwned;
                      bool _556_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _557_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out157;
                      bool _out158;
                      bool _out159;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out160;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out157, out _out158, out _out159, out _out160);
                      _554_recursiveGen = _out157;
                      _555_recOwned = _out158;
                      _556_recErased = _out159;
                      _557_recIdents = _out160;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _554_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _555_recOwned;
                      isErased = _556_recErased;
                      readIdents = _557_recIdents;
                    }
                  } else {
                    DAST._IType _558___mcc_h294 = _source32.dtor_Newtype_a0;
                    DAST._IType _559_b = _558___mcc_h294;
                    {
                      if (object.Equals(_533_fromTpe, _559_b)) {
                        Dafny.ISequence<Dafny.Rune> _560_recursiveGen;
                        bool _561_recOwned;
                        bool _562_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _563_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out161;
                        bool _out162;
                        bool _out163;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out164;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out161, out _out162, out _out163, out _out164);
                        _560_recursiveGen = _out161;
                        _561_recOwned = _out162;
                        _562_recErased = _out163;
                        _563_recIdents = _out164;
                        Dafny.ISequence<Dafny.Rune> _564_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out165;
                        _out165 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                        _564_rhsType = _out165;
                        Dafny.ISequence<Dafny.Rune> _565_uneraseFn;
                        _565_uneraseFn = ((_561_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _564_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _565_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _561_recOwned;
                        isErased = false;
                        readIdents = _563_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out166;
                        bool _out167;
                        bool _out168;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out169;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _559_b), _559_b, _532_toTpe), selfIdent, @params, mustOwn, out _out166, out _out167, out _out168, out _out169);
                        s = _out166;
                        isOwned = _out167;
                        isErased = _out168;
                        readIdents = _out169;
                      }
                    }
                  }
                } else if (_source31.is_Nullable) {
                  DAST._IType _566___mcc_h296 = _source31.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _567_recursiveGen;
                    bool _568_recOwned;
                    bool _569_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _570_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out170;
                    bool _out171;
                    bool _out172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out173;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out170, out _out171, out _out172, out _out173);
                    _567_recursiveGen = _out170;
                    _568_recOwned = _out171;
                    _569_recErased = _out172;
                    _570_recIdents = _out173;
                    if (!(_568_recOwned)) {
                      _567_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_567_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _567_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _569_recErased;
                    readIdents = _570_recIdents;
                  }
                } else if (_source31.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _571___mcc_h298 = _source31.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _572_recursiveGen;
                    bool _573_recOwned;
                    bool _574_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _575_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out174;
                    bool _out175;
                    bool _out176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out177;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out174, out _out175, out _out176, out _out177);
                    _572_recursiveGen = _out174;
                    _573_recOwned = _out175;
                    _574_recErased = _out176;
                    _575_recIdents = _out177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _572_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _573_recOwned;
                    isErased = _574_recErased;
                    readIdents = _575_recIdents;
                  }
                } else if (_source31.is_Array) {
                  DAST._IType _576___mcc_h300 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _577_recursiveGen;
                    bool _578_recOwned;
                    bool _579_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _580_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out178;
                    bool _out179;
                    bool _out180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out181;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out178, out _out179, out _out180, out _out181);
                    _577_recursiveGen = _out178;
                    _578_recOwned = _out179;
                    _579_recErased = _out180;
                    _580_recIdents = _out181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _577_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _578_recOwned;
                    isErased = _579_recErased;
                    readIdents = _580_recIdents;
                  }
                } else if (_source31.is_Seq) {
                  DAST._IType _581___mcc_h302 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _582_recursiveGen;
                    bool _583_recOwned;
                    bool _584_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _585_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out182;
                    bool _out183;
                    bool _out184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out185;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out182, out _out183, out _out184, out _out185);
                    _582_recursiveGen = _out182;
                    _583_recOwned = _out183;
                    _584_recErased = _out184;
                    _585_recIdents = _out185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _582_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _583_recOwned;
                    isErased = _584_recErased;
                    readIdents = _585_recIdents;
                  }
                } else if (_source31.is_Set) {
                  DAST._IType _586___mcc_h304 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _587_recursiveGen;
                    bool _588_recOwned;
                    bool _589_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _590_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out186;
                    bool _out187;
                    bool _out188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out189;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out186, out _out187, out _out188, out _out189);
                    _587_recursiveGen = _out186;
                    _588_recOwned = _out187;
                    _589_recErased = _out188;
                    _590_recIdents = _out189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _587_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _588_recOwned;
                    isErased = _589_recErased;
                    readIdents = _590_recIdents;
                  }
                } else if (_source31.is_Multiset) {
                  DAST._IType _591___mcc_h306 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _592_recursiveGen;
                    bool _593_recOwned;
                    bool _594_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _595_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out190;
                    bool _out191;
                    bool _out192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out193;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out190, out _out191, out _out192, out _out193);
                    _592_recursiveGen = _out190;
                    _593_recOwned = _out191;
                    _594_recErased = _out192;
                    _595_recIdents = _out193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _592_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _593_recOwned;
                    isErased = _594_recErased;
                    readIdents = _595_recIdents;
                  }
                } else if (_source31.is_Map) {
                  DAST._IType _596___mcc_h308 = _source31.dtor_key;
                  DAST._IType _597___mcc_h309 = _source31.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _598_recursiveGen;
                    bool _599_recOwned;
                    bool _600_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _601_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out194;
                    bool _out195;
                    bool _out196;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out197;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out194, out _out195, out _out196, out _out197);
                    _598_recursiveGen = _out194;
                    _599_recOwned = _out195;
                    _600_recErased = _out196;
                    _601_recIdents = _out197;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _598_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _599_recOwned;
                    isErased = _600_recErased;
                    readIdents = _601_recIdents;
                  }
                } else if (_source31.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _602___mcc_h312 = _source31.dtor_args;
                  DAST._IType _603___mcc_h313 = _source31.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _604_recursiveGen;
                    bool _605_recOwned;
                    bool _606_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _607_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out198;
                    bool _out199;
                    bool _out200;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out198, out _out199, out _out200, out _out201);
                    _604_recursiveGen = _out198;
                    _605_recOwned = _out199;
                    _606_recErased = _out200;
                    _607_recIdents = _out201;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _604_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _605_recOwned;
                    isErased = _606_recErased;
                    readIdents = _607_recIdents;
                  }
                } else if (_source31.is_Primitive) {
                  DAST._IPrimitive _608___mcc_h316 = _source31.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _609_recursiveGen;
                    bool _610_recOwned;
                    bool _611_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _612_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out202;
                    bool _out203;
                    bool _out204;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out202, out _out203, out _out204, out _out205);
                    _609_recursiveGen = _out202;
                    _610_recOwned = _out203;
                    _611_recErased = _out204;
                    _612_recIdents = _out205;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _610_recOwned;
                    isErased = _611_recErased;
                    readIdents = _612_recIdents;
                  }
                } else if (_source31.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _613___mcc_h318 = _source31.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _614_recursiveGen;
                    bool _615_recOwned;
                    bool _616_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _617_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out206;
                    bool _out207;
                    bool _out208;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out206, out _out207, out _out208, out _out209);
                    _614_recursiveGen = _out206;
                    _615_recOwned = _out207;
                    _616_recErased = _out208;
                    _617_recIdents = _out209;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _614_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _615_recOwned;
                    isErased = _616_recErased;
                    readIdents = _617_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _618___mcc_h320 = _source31.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _619_recursiveGen;
                    bool _620_recOwned;
                    bool _621_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _622_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out210;
                    bool _out211;
                    bool _out212;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out210, out _out211, out _out212, out _out213);
                    _619_recursiveGen = _out210;
                    _620_recOwned = _out211;
                    _621_recErased = _out212;
                    _622_recIdents = _out213;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _619_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _620_recOwned;
                    isErased = _621_recErased;
                    readIdents = _622_recIdents;
                  }
                }
              } else if (_source30.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _623___mcc_h322 = _source30.dtor_path;
                DAST._IType _source33 = _540___mcc_h265;
                if (_source33.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _624___mcc_h326 = _source33.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _625___mcc_h327 = _source33.dtor_typeArgs;
                  DAST._IResolvedType _626___mcc_h328 = _source33.dtor_resolved;
                  DAST._IResolvedType _source34 = _626___mcc_h328;
                  if (_source34.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _627___mcc_h332 = _source34.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _628_recursiveGen;
                      bool _629_recOwned;
                      bool _630_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _631_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out214;
                      bool _out215;
                      bool _out216;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out214, out _out215, out _out216, out _out217);
                      _628_recursiveGen = _out214;
                      _629_recOwned = _out215;
                      _630_recErased = _out216;
                      _631_recIdents = _out217;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _628_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _629_recOwned;
                      isErased = _630_recErased;
                      readIdents = _631_recIdents;
                    }
                  } else if (_source34.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _632___mcc_h334 = _source34.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _633_recursiveGen;
                      bool _634_recOwned;
                      bool _635_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _636_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out218;
                      bool _out219;
                      bool _out220;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out221;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out218, out _out219, out _out220, out _out221);
                      _633_recursiveGen = _out218;
                      _634_recOwned = _out219;
                      _635_recErased = _out220;
                      _636_recIdents = _out221;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _633_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _634_recOwned;
                      isErased = _635_recErased;
                      readIdents = _636_recIdents;
                    }
                  } else {
                    DAST._IType _637___mcc_h336 = _source34.dtor_Newtype_a0;
                    DAST._IType _638_b = _637___mcc_h336;
                    {
                      if (object.Equals(_533_fromTpe, _638_b)) {
                        Dafny.ISequence<Dafny.Rune> _639_recursiveGen;
                        bool _640_recOwned;
                        bool _641_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _642_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out222;
                        bool _out223;
                        bool _out224;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out225;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out222, out _out223, out _out224, out _out225);
                        _639_recursiveGen = _out222;
                        _640_recOwned = _out223;
                        _641_recErased = _out224;
                        _642_recIdents = _out225;
                        Dafny.ISequence<Dafny.Rune> _643_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out226;
                        _out226 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                        _643_rhsType = _out226;
                        Dafny.ISequence<Dafny.Rune> _644_uneraseFn;
                        _644_uneraseFn = ((_640_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _643_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _644_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _639_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _640_recOwned;
                        isErased = false;
                        readIdents = _642_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out227;
                        bool _out228;
                        bool _out229;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out230;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _638_b), _638_b, _532_toTpe), selfIdent, @params, mustOwn, out _out227, out _out228, out _out229, out _out230);
                        s = _out227;
                        isOwned = _out228;
                        isErased = _out229;
                        readIdents = _out230;
                      }
                    }
                  }
                } else if (_source33.is_Nullable) {
                  DAST._IType _645___mcc_h338 = _source33.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _646_recursiveGen;
                    bool _647_recOwned;
                    bool _648_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _649_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out231;
                    bool _out232;
                    bool _out233;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out234;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out231, out _out232, out _out233, out _out234);
                    _646_recursiveGen = _out231;
                    _647_recOwned = _out232;
                    _648_recErased = _out233;
                    _649_recIdents = _out234;
                    if (!(_647_recOwned)) {
                      _646_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_646_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _646_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _648_recErased;
                    readIdents = _649_recIdents;
                  }
                } else if (_source33.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _650___mcc_h340 = _source33.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _651_recursiveGen;
                    bool _652_recOwned;
                    bool _653_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _654_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out235;
                    bool _out236;
                    bool _out237;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out238;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out235, out _out236, out _out237, out _out238);
                    _651_recursiveGen = _out235;
                    _652_recOwned = _out236;
                    _653_recErased = _out237;
                    _654_recIdents = _out238;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _651_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _652_recOwned;
                    isErased = _653_recErased;
                    readIdents = _654_recIdents;
                  }
                } else if (_source33.is_Array) {
                  DAST._IType _655___mcc_h342 = _source33.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _656_recursiveGen;
                    bool _657_recOwned;
                    bool _658_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _659_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out239;
                    bool _out240;
                    bool _out241;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out242;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out239, out _out240, out _out241, out _out242);
                    _656_recursiveGen = _out239;
                    _657_recOwned = _out240;
                    _658_recErased = _out241;
                    _659_recIdents = _out242;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _656_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _657_recOwned;
                    isErased = _658_recErased;
                    readIdents = _659_recIdents;
                  }
                } else if (_source33.is_Seq) {
                  DAST._IType _660___mcc_h344 = _source33.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _661_recursiveGen;
                    bool _662_recOwned;
                    bool _663_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _664_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out243;
                    bool _out244;
                    bool _out245;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out246;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out243, out _out244, out _out245, out _out246);
                    _661_recursiveGen = _out243;
                    _662_recOwned = _out244;
                    _663_recErased = _out245;
                    _664_recIdents = _out246;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _661_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _662_recOwned;
                    isErased = _663_recErased;
                    readIdents = _664_recIdents;
                  }
                } else if (_source33.is_Set) {
                  DAST._IType _665___mcc_h346 = _source33.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _666_recursiveGen;
                    bool _667_recOwned;
                    bool _668_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _669_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out247;
                    bool _out248;
                    bool _out249;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out250;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out247, out _out248, out _out249, out _out250);
                    _666_recursiveGen = _out247;
                    _667_recOwned = _out248;
                    _668_recErased = _out249;
                    _669_recIdents = _out250;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _666_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _667_recOwned;
                    isErased = _668_recErased;
                    readIdents = _669_recIdents;
                  }
                } else if (_source33.is_Multiset) {
                  DAST._IType _670___mcc_h348 = _source33.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _671_recursiveGen;
                    bool _672_recOwned;
                    bool _673_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _674_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out251;
                    bool _out252;
                    bool _out253;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out251, out _out252, out _out253, out _out254);
                    _671_recursiveGen = _out251;
                    _672_recOwned = _out252;
                    _673_recErased = _out253;
                    _674_recIdents = _out254;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _671_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _672_recOwned;
                    isErased = _673_recErased;
                    readIdents = _674_recIdents;
                  }
                } else if (_source33.is_Map) {
                  DAST._IType _675___mcc_h350 = _source33.dtor_key;
                  DAST._IType _676___mcc_h351 = _source33.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _677_recursiveGen;
                    bool _678_recOwned;
                    bool _679_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _680_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out255;
                    bool _out256;
                    bool _out257;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out255, out _out256, out _out257, out _out258);
                    _677_recursiveGen = _out255;
                    _678_recOwned = _out256;
                    _679_recErased = _out257;
                    _680_recIdents = _out258;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _677_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _678_recOwned;
                    isErased = _679_recErased;
                    readIdents = _680_recIdents;
                  }
                } else if (_source33.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _681___mcc_h354 = _source33.dtor_args;
                  DAST._IType _682___mcc_h355 = _source33.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _683_recursiveGen;
                    bool _684_recOwned;
                    bool _685_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _686_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out259;
                    bool _out260;
                    bool _out261;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out259, out _out260, out _out261, out _out262);
                    _683_recursiveGen = _out259;
                    _684_recOwned = _out260;
                    _685_recErased = _out261;
                    _686_recIdents = _out262;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _683_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _684_recOwned;
                    isErased = _685_recErased;
                    readIdents = _686_recIdents;
                  }
                } else if (_source33.is_Primitive) {
                  DAST._IPrimitive _687___mcc_h358 = _source33.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _688_recursiveGen;
                    bool _689_recOwned;
                    bool _690_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _691_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out263;
                    bool _out264;
                    bool _out265;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out263, out _out264, out _out265, out _out266);
                    _688_recursiveGen = _out263;
                    _689_recOwned = _out264;
                    _690_recErased = _out265;
                    _691_recIdents = _out266;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _688_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _689_recOwned;
                    isErased = _690_recErased;
                    readIdents = _691_recIdents;
                  }
                } else if (_source33.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _692___mcc_h360 = _source33.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _693_recursiveGen;
                    bool _694_recOwned;
                    bool _695_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _696_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out267;
                    bool _out268;
                    bool _out269;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out267, out _out268, out _out269, out _out270);
                    _693_recursiveGen = _out267;
                    _694_recOwned = _out268;
                    _695_recErased = _out269;
                    _696_recIdents = _out270;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _693_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _694_recOwned;
                    isErased = _695_recErased;
                    readIdents = _696_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _697___mcc_h362 = _source33.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _698_recursiveGen;
                    bool _699_recOwned;
                    bool _700_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _701_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out271;
                    bool _out272;
                    bool _out273;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out271, out _out272, out _out273, out _out274);
                    _698_recursiveGen = _out271;
                    _699_recOwned = _out272;
                    _700_recErased = _out273;
                    _701_recIdents = _out274;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _698_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _699_recOwned;
                    isErased = _700_recErased;
                    readIdents = _701_recIdents;
                  }
                }
              } else {
                DAST._IType _702___mcc_h364 = _source30.dtor_Newtype_a0;
                DAST._IType _source35 = _540___mcc_h265;
                if (_source35.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _703___mcc_h368 = _source35.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _704___mcc_h369 = _source35.dtor_typeArgs;
                  DAST._IResolvedType _705___mcc_h370 = _source35.dtor_resolved;
                  DAST._IResolvedType _source36 = _705___mcc_h370;
                  if (_source36.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _706___mcc_h377 = _source36.dtor_path;
                    DAST._IType _707_b = _702___mcc_h364;
                    {
                      if (object.Equals(_707_b, _532_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _708_recursiveGen;
                        bool _709_recOwned;
                        bool _710_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _711_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out275;
                        bool _out276;
                        bool _out277;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out275, out _out276, out _out277, out _out278);
                        _708_recursiveGen = _out275;
                        _709_recOwned = _out276;
                        _710_recErased = _out277;
                        _711_recIdents = _out278;
                        Dafny.ISequence<Dafny.Rune> _712_uneraseFn;
                        _712_uneraseFn = ((_709_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _712_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _708_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _709_recOwned;
                        isErased = true;
                        readIdents = _711_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out279;
                        bool _out280;
                        bool _out281;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _707_b), _707_b, _532_toTpe), selfIdent, @params, mustOwn, out _out279, out _out280, out _out281, out _out282);
                        s = _out279;
                        isOwned = _out280;
                        isErased = _out281;
                        readIdents = _out282;
                      }
                    }
                  } else if (_source36.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _713___mcc_h380 = _source36.dtor_path;
                    DAST._IType _714_b = _702___mcc_h364;
                    {
                      if (object.Equals(_714_b, _532_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _715_recursiveGen;
                        bool _716_recOwned;
                        bool _717_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _718_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out283;
                        bool _out284;
                        bool _out285;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out283, out _out284, out _out285, out _out286);
                        _715_recursiveGen = _out283;
                        _716_recOwned = _out284;
                        _717_recErased = _out285;
                        _718_recIdents = _out286;
                        Dafny.ISequence<Dafny.Rune> _719_uneraseFn;
                        _719_uneraseFn = ((_716_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _719_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _715_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _716_recOwned;
                        isErased = true;
                        readIdents = _718_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out287;
                        bool _out288;
                        bool _out289;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out290;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _714_b), _714_b, _532_toTpe), selfIdent, @params, mustOwn, out _out287, out _out288, out _out289, out _out290);
                        s = _out287;
                        isOwned = _out288;
                        isErased = _out289;
                        readIdents = _out290;
                      }
                    }
                  } else {
                    DAST._IType _720___mcc_h383 = _source36.dtor_Newtype_a0;
                    DAST._IType _721_b = _720___mcc_h383;
                    {
                      if (object.Equals(_533_fromTpe, _721_b)) {
                        Dafny.ISequence<Dafny.Rune> _722_recursiveGen;
                        bool _723_recOwned;
                        bool _724_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _725_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out291;
                        bool _out292;
                        bool _out293;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out294;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out291, out _out292, out _out293, out _out294);
                        _722_recursiveGen = _out291;
                        _723_recOwned = _out292;
                        _724_recErased = _out293;
                        _725_recIdents = _out294;
                        Dafny.ISequence<Dafny.Rune> _726_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out295;
                        _out295 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                        _726_rhsType = _out295;
                        Dafny.ISequence<Dafny.Rune> _727_uneraseFn;
                        _727_uneraseFn = ((_723_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _726_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _727_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _722_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _723_recOwned;
                        isErased = false;
                        readIdents = _725_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out296;
                        bool _out297;
                        bool _out298;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out299;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _721_b), _721_b, _532_toTpe), selfIdent, @params, mustOwn, out _out296, out _out297, out _out298, out _out299);
                        s = _out296;
                        isOwned = _out297;
                        isErased = _out298;
                        readIdents = _out299;
                      }
                    }
                  }
                } else if (_source35.is_Nullable) {
                  DAST._IType _728___mcc_h386 = _source35.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _729_recursiveGen;
                    bool _730_recOwned;
                    bool _731_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _732_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out300;
                    bool _out301;
                    bool _out302;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out303;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out300, out _out301, out _out302, out _out303);
                    _729_recursiveGen = _out300;
                    _730_recOwned = _out301;
                    _731_recErased = _out302;
                    _732_recIdents = _out303;
                    if (!(_730_recOwned)) {
                      _729_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_729_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _729_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _731_recErased;
                    readIdents = _732_recIdents;
                  }
                } else if (_source35.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _733___mcc_h389 = _source35.dtor_Tuple_a0;
                  DAST._IType _734_b = _702___mcc_h364;
                  {
                    if (object.Equals(_734_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _735_recursiveGen;
                      bool _736_recOwned;
                      bool _737_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _738_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out304;
                      bool _out305;
                      bool _out306;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out304, out _out305, out _out306, out _out307);
                      _735_recursiveGen = _out304;
                      _736_recOwned = _out305;
                      _737_recErased = _out306;
                      _738_recIdents = _out307;
                      Dafny.ISequence<Dafny.Rune> _739_uneraseFn;
                      _739_uneraseFn = ((_736_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _739_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _735_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _736_recOwned;
                      isErased = true;
                      readIdents = _738_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out308;
                      bool _out309;
                      bool _out310;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _734_b), _734_b, _532_toTpe), selfIdent, @params, mustOwn, out _out308, out _out309, out _out310, out _out311);
                      s = _out308;
                      isOwned = _out309;
                      isErased = _out310;
                      readIdents = _out311;
                    }
                  }
                } else if (_source35.is_Array) {
                  DAST._IType _740___mcc_h392 = _source35.dtor_element;
                  DAST._IType _741_b = _702___mcc_h364;
                  {
                    if (object.Equals(_741_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _742_recursiveGen;
                      bool _743_recOwned;
                      bool _744_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _745_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out312;
                      bool _out313;
                      bool _out314;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out312, out _out313, out _out314, out _out315);
                      _742_recursiveGen = _out312;
                      _743_recOwned = _out313;
                      _744_recErased = _out314;
                      _745_recIdents = _out315;
                      Dafny.ISequence<Dafny.Rune> _746_uneraseFn;
                      _746_uneraseFn = ((_743_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _746_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _742_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _743_recOwned;
                      isErased = true;
                      readIdents = _745_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out316;
                      bool _out317;
                      bool _out318;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _741_b), _741_b, _532_toTpe), selfIdent, @params, mustOwn, out _out316, out _out317, out _out318, out _out319);
                      s = _out316;
                      isOwned = _out317;
                      isErased = _out318;
                      readIdents = _out319;
                    }
                  }
                } else if (_source35.is_Seq) {
                  DAST._IType _747___mcc_h395 = _source35.dtor_element;
                  DAST._IType _748_b = _702___mcc_h364;
                  {
                    if (object.Equals(_748_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _749_recursiveGen;
                      bool _750_recOwned;
                      bool _751_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _752_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out320;
                      bool _out321;
                      bool _out322;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out320, out _out321, out _out322, out _out323);
                      _749_recursiveGen = _out320;
                      _750_recOwned = _out321;
                      _751_recErased = _out322;
                      _752_recIdents = _out323;
                      Dafny.ISequence<Dafny.Rune> _753_uneraseFn;
                      _753_uneraseFn = ((_750_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _753_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _749_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _750_recOwned;
                      isErased = true;
                      readIdents = _752_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out324;
                      bool _out325;
                      bool _out326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _748_b), _748_b, _532_toTpe), selfIdent, @params, mustOwn, out _out324, out _out325, out _out326, out _out327);
                      s = _out324;
                      isOwned = _out325;
                      isErased = _out326;
                      readIdents = _out327;
                    }
                  }
                } else if (_source35.is_Set) {
                  DAST._IType _754___mcc_h398 = _source35.dtor_element;
                  DAST._IType _755_b = _702___mcc_h364;
                  {
                    if (object.Equals(_755_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _756_recursiveGen;
                      bool _757_recOwned;
                      bool _758_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _759_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out328;
                      bool _out329;
                      bool _out330;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out328, out _out329, out _out330, out _out331);
                      _756_recursiveGen = _out328;
                      _757_recOwned = _out329;
                      _758_recErased = _out330;
                      _759_recIdents = _out331;
                      Dafny.ISequence<Dafny.Rune> _760_uneraseFn;
                      _760_uneraseFn = ((_757_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _760_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _756_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _757_recOwned;
                      isErased = true;
                      readIdents = _759_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out332;
                      bool _out333;
                      bool _out334;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _755_b), _755_b, _532_toTpe), selfIdent, @params, mustOwn, out _out332, out _out333, out _out334, out _out335);
                      s = _out332;
                      isOwned = _out333;
                      isErased = _out334;
                      readIdents = _out335;
                    }
                  }
                } else if (_source35.is_Multiset) {
                  DAST._IType _761___mcc_h401 = _source35.dtor_element;
                  DAST._IType _762_b = _702___mcc_h364;
                  {
                    if (object.Equals(_762_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _763_recursiveGen;
                      bool _764_recOwned;
                      bool _765_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _766_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out336;
                      bool _out337;
                      bool _out338;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out336, out _out337, out _out338, out _out339);
                      _763_recursiveGen = _out336;
                      _764_recOwned = _out337;
                      _765_recErased = _out338;
                      _766_recIdents = _out339;
                      Dafny.ISequence<Dafny.Rune> _767_uneraseFn;
                      _767_uneraseFn = ((_764_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _767_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _763_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _764_recOwned;
                      isErased = true;
                      readIdents = _766_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out340;
                      bool _out341;
                      bool _out342;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _762_b), _762_b, _532_toTpe), selfIdent, @params, mustOwn, out _out340, out _out341, out _out342, out _out343);
                      s = _out340;
                      isOwned = _out341;
                      isErased = _out342;
                      readIdents = _out343;
                    }
                  }
                } else if (_source35.is_Map) {
                  DAST._IType _768___mcc_h404 = _source35.dtor_key;
                  DAST._IType _769___mcc_h405 = _source35.dtor_value;
                  DAST._IType _770_b = _702___mcc_h364;
                  {
                    if (object.Equals(_770_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _771_recursiveGen;
                      bool _772_recOwned;
                      bool _773_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _774_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out344;
                      bool _out345;
                      bool _out346;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out344, out _out345, out _out346, out _out347);
                      _771_recursiveGen = _out344;
                      _772_recOwned = _out345;
                      _773_recErased = _out346;
                      _774_recIdents = _out347;
                      Dafny.ISequence<Dafny.Rune> _775_uneraseFn;
                      _775_uneraseFn = ((_772_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _775_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _771_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _772_recOwned;
                      isErased = true;
                      readIdents = _774_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out348;
                      bool _out349;
                      bool _out350;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _770_b), _770_b, _532_toTpe), selfIdent, @params, mustOwn, out _out348, out _out349, out _out350, out _out351);
                      s = _out348;
                      isOwned = _out349;
                      isErased = _out350;
                      readIdents = _out351;
                    }
                  }
                } else if (_source35.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _776___mcc_h410 = _source35.dtor_args;
                  DAST._IType _777___mcc_h411 = _source35.dtor_result;
                  DAST._IType _778_b = _702___mcc_h364;
                  {
                    if (object.Equals(_778_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _779_recursiveGen;
                      bool _780_recOwned;
                      bool _781_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _782_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out352;
                      bool _out353;
                      bool _out354;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out352, out _out353, out _out354, out _out355);
                      _779_recursiveGen = _out352;
                      _780_recOwned = _out353;
                      _781_recErased = _out354;
                      _782_recIdents = _out355;
                      Dafny.ISequence<Dafny.Rune> _783_uneraseFn;
                      _783_uneraseFn = ((_780_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _783_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _779_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _780_recOwned;
                      isErased = true;
                      readIdents = _782_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out356;
                      bool _out357;
                      bool _out358;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out359;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _778_b), _778_b, _532_toTpe), selfIdent, @params, mustOwn, out _out356, out _out357, out _out358, out _out359);
                      s = _out356;
                      isOwned = _out357;
                      isErased = _out358;
                      readIdents = _out359;
                    }
                  }
                } else if (_source35.is_Primitive) {
                  DAST._IPrimitive _784___mcc_h416 = _source35.dtor_Primitive_a0;
                  DAST._IType _785_b = _702___mcc_h364;
                  {
                    if (object.Equals(_785_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _786_recursiveGen;
                      bool _787_recOwned;
                      bool _788_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _789_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out360;
                      bool _out361;
                      bool _out362;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out363;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out360, out _out361, out _out362, out _out363);
                      _786_recursiveGen = _out360;
                      _787_recOwned = _out361;
                      _788_recErased = _out362;
                      _789_recIdents = _out363;
                      Dafny.ISequence<Dafny.Rune> _790_uneraseFn;
                      _790_uneraseFn = ((_787_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _790_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _786_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _787_recOwned;
                      isErased = true;
                      readIdents = _789_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out364;
                      bool _out365;
                      bool _out366;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out367;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _785_b), _785_b, _532_toTpe), selfIdent, @params, mustOwn, out _out364, out _out365, out _out366, out _out367);
                      s = _out364;
                      isOwned = _out365;
                      isErased = _out366;
                      readIdents = _out367;
                    }
                  }
                } else if (_source35.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _791___mcc_h419 = _source35.dtor_Passthrough_a0;
                  DAST._IType _792_b = _702___mcc_h364;
                  {
                    if (object.Equals(_792_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _793_recursiveGen;
                      bool _794_recOwned;
                      bool _795_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _796_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out368;
                      bool _out369;
                      bool _out370;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out371;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out368, out _out369, out _out370, out _out371);
                      _793_recursiveGen = _out368;
                      _794_recOwned = _out369;
                      _795_recErased = _out370;
                      _796_recIdents = _out371;
                      Dafny.ISequence<Dafny.Rune> _797_uneraseFn;
                      _797_uneraseFn = ((_794_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _797_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _793_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _794_recOwned;
                      isErased = true;
                      readIdents = _796_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out372;
                      bool _out373;
                      bool _out374;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out375;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _792_b), _792_b, _532_toTpe), selfIdent, @params, mustOwn, out _out372, out _out373, out _out374, out _out375);
                      s = _out372;
                      isOwned = _out373;
                      isErased = _out374;
                      readIdents = _out375;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _798___mcc_h422 = _source35.dtor_TypeArg_a0;
                  DAST._IType _799_b = _702___mcc_h364;
                  {
                    if (object.Equals(_799_b, _532_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _800_recursiveGen;
                      bool _801_recOwned;
                      bool _802_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _803_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out376;
                      bool _out377;
                      bool _out378;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out379;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out376, out _out377, out _out378, out _out379);
                      _800_recursiveGen = _out376;
                      _801_recOwned = _out377;
                      _802_recErased = _out378;
                      _803_recIdents = _out379;
                      Dafny.ISequence<Dafny.Rune> _804_uneraseFn;
                      _804_uneraseFn = ((_801_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _804_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _800_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _801_recOwned;
                      isErased = true;
                      readIdents = _803_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out380;
                      bool _out381;
                      bool _out382;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out383;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _799_b), _799_b, _532_toTpe), selfIdent, @params, mustOwn, out _out380, out _out381, out _out382, out _out383);
                      s = _out380;
                      isOwned = _out381;
                      isErased = _out382;
                      readIdents = _out383;
                    }
                  }
                }
              }
            } else if (_source29.is_Nullable) {
              DAST._IType _805___mcc_h425 = _source29.dtor_Nullable_a0;
              DAST._IType _source37 = _540___mcc_h265;
              if (_source37.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _806___mcc_h429 = _source37.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _807___mcc_h430 = _source37.dtor_typeArgs;
                DAST._IResolvedType _808___mcc_h431 = _source37.dtor_resolved;
                DAST._IResolvedType _source38 = _808___mcc_h431;
                if (_source38.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _809___mcc_h438 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _810_recursiveGen;
                    bool _811_recOwned;
                    bool _812_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _813_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out384;
                    bool _out385;
                    bool _out386;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out387;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out384, out _out385, out _out386, out _out387);
                    _810_recursiveGen = _out384;
                    _811_recOwned = _out385;
                    _812_recErased = _out386;
                    _813_recIdents = _out387;
                    if (!(_811_recOwned)) {
                      _810_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_810_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_810_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _811_recOwned;
                    isErased = _812_recErased;
                    readIdents = _813_recIdents;
                  }
                } else if (_source38.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _814___mcc_h441 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _815_recursiveGen;
                    bool _816_recOwned;
                    bool _817_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _818_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out388;
                    bool _out389;
                    bool _out390;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out391;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out388, out _out389, out _out390, out _out391);
                    _815_recursiveGen = _out388;
                    _816_recOwned = _out389;
                    _817_recErased = _out390;
                    _818_recIdents = _out391;
                    if (!(_816_recOwned)) {
                      _815_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_815_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_815_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _816_recOwned;
                    isErased = _817_recErased;
                    readIdents = _818_recIdents;
                  }
                } else {
                  DAST._IType _819___mcc_h444 = _source38.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _820_recursiveGen;
                    bool _821_recOwned;
                    bool _822_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _823_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out392;
                    bool _out393;
                    bool _out394;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out395;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out392, out _out393, out _out394, out _out395);
                    _820_recursiveGen = _out392;
                    _821_recOwned = _out393;
                    _822_recErased = _out394;
                    _823_recIdents = _out395;
                    if (!(_821_recOwned)) {
                      _820_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_820_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_820_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _821_recOwned;
                    isErased = _822_recErased;
                    readIdents = _823_recIdents;
                  }
                }
              } else if (_source37.is_Nullable) {
                DAST._IType _824___mcc_h447 = _source37.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _825_recursiveGen;
                  bool _826_recOwned;
                  bool _827_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _828_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out396;
                  bool _out397;
                  bool _out398;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out399;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out396, out _out397, out _out398, out _out399);
                  _825_recursiveGen = _out396;
                  _826_recOwned = _out397;
                  _827_recErased = _out398;
                  _828_recIdents = _out399;
                  if (!(_826_recOwned)) {
                    _825_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_825_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_825_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _826_recOwned;
                  isErased = _827_recErased;
                  readIdents = _828_recIdents;
                }
              } else if (_source37.is_Tuple) {
                Dafny.ISequence<DAST._IType> _829___mcc_h450 = _source37.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _830_recursiveGen;
                  bool _831_recOwned;
                  bool _832_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _833_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out400;
                  bool _out401;
                  bool _out402;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out403;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out400, out _out401, out _out402, out _out403);
                  _830_recursiveGen = _out400;
                  _831_recOwned = _out401;
                  _832_recErased = _out402;
                  _833_recIdents = _out403;
                  if (!(_831_recOwned)) {
                    _830_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_830_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_830_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _831_recOwned;
                  isErased = _832_recErased;
                  readIdents = _833_recIdents;
                }
              } else if (_source37.is_Array) {
                DAST._IType _834___mcc_h453 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _835_recursiveGen;
                  bool _836_recOwned;
                  bool _837_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _838_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out404;
                  bool _out405;
                  bool _out406;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out407;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out404, out _out405, out _out406, out _out407);
                  _835_recursiveGen = _out404;
                  _836_recOwned = _out405;
                  _837_recErased = _out406;
                  _838_recIdents = _out407;
                  if (!(_836_recOwned)) {
                    _835_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_835_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_835_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _836_recOwned;
                  isErased = _837_recErased;
                  readIdents = _838_recIdents;
                }
              } else if (_source37.is_Seq) {
                DAST._IType _839___mcc_h456 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _840_recursiveGen;
                  bool _841_recOwned;
                  bool _842_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _843_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out408;
                  bool _out409;
                  bool _out410;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out411;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out408, out _out409, out _out410, out _out411);
                  _840_recursiveGen = _out408;
                  _841_recOwned = _out409;
                  _842_recErased = _out410;
                  _843_recIdents = _out411;
                  if (!(_841_recOwned)) {
                    _840_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_840_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_840_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _841_recOwned;
                  isErased = _842_recErased;
                  readIdents = _843_recIdents;
                }
              } else if (_source37.is_Set) {
                DAST._IType _844___mcc_h459 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _845_recursiveGen;
                  bool _846_recOwned;
                  bool _847_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _848_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out412;
                  bool _out413;
                  bool _out414;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out415;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out412, out _out413, out _out414, out _out415);
                  _845_recursiveGen = _out412;
                  _846_recOwned = _out413;
                  _847_recErased = _out414;
                  _848_recIdents = _out415;
                  if (!(_846_recOwned)) {
                    _845_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_845_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_845_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _846_recOwned;
                  isErased = _847_recErased;
                  readIdents = _848_recIdents;
                }
              } else if (_source37.is_Multiset) {
                DAST._IType _849___mcc_h462 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _850_recursiveGen;
                  bool _851_recOwned;
                  bool _852_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _853_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out416;
                  bool _out417;
                  bool _out418;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out419;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out416, out _out417, out _out418, out _out419);
                  _850_recursiveGen = _out416;
                  _851_recOwned = _out417;
                  _852_recErased = _out418;
                  _853_recIdents = _out419;
                  if (!(_851_recOwned)) {
                    _850_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_850_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_850_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _851_recOwned;
                  isErased = _852_recErased;
                  readIdents = _853_recIdents;
                }
              } else if (_source37.is_Map) {
                DAST._IType _854___mcc_h465 = _source37.dtor_key;
                DAST._IType _855___mcc_h466 = _source37.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _856_recursiveGen;
                  bool _857_recOwned;
                  bool _858_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _859_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out420;
                  bool _out421;
                  bool _out422;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out423;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out420, out _out421, out _out422, out _out423);
                  _856_recursiveGen = _out420;
                  _857_recOwned = _out421;
                  _858_recErased = _out422;
                  _859_recIdents = _out423;
                  if (!(_857_recOwned)) {
                    _856_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_856_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_856_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _857_recOwned;
                  isErased = _858_recErased;
                  readIdents = _859_recIdents;
                }
              } else if (_source37.is_Arrow) {
                Dafny.ISequence<DAST._IType> _860___mcc_h471 = _source37.dtor_args;
                DAST._IType _861___mcc_h472 = _source37.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _862_recursiveGen;
                  bool _863_recOwned;
                  bool _864_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _865_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out424;
                  bool _out425;
                  bool _out426;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out427;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out424, out _out425, out _out426, out _out427);
                  _862_recursiveGen = _out424;
                  _863_recOwned = _out425;
                  _864_recErased = _out426;
                  _865_recIdents = _out427;
                  if (!(_863_recOwned)) {
                    _862_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_862_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_862_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _863_recOwned;
                  isErased = _864_recErased;
                  readIdents = _865_recIdents;
                }
              } else if (_source37.is_Primitive) {
                DAST._IPrimitive _866___mcc_h477 = _source37.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _867_recursiveGen;
                  bool _868_recOwned;
                  bool _869_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _870_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out428;
                  bool _out429;
                  bool _out430;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out431;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out428, out _out429, out _out430, out _out431);
                  _867_recursiveGen = _out428;
                  _868_recOwned = _out429;
                  _869_recErased = _out430;
                  _870_recIdents = _out431;
                  if (!(_868_recOwned)) {
                    _867_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_867_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_867_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _868_recOwned;
                  isErased = _869_recErased;
                  readIdents = _870_recIdents;
                }
              } else if (_source37.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _871___mcc_h480 = _source37.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _872_recursiveGen;
                  bool _873_recOwned;
                  bool _874_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _875_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out432;
                  bool _out433;
                  bool _out434;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out435;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out432, out _out433, out _out434, out _out435);
                  _872_recursiveGen = _out432;
                  _873_recOwned = _out433;
                  _874_recErased = _out434;
                  _875_recIdents = _out435;
                  if (!(_873_recOwned)) {
                    _872_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_872_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_872_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _873_recOwned;
                  isErased = _874_recErased;
                  readIdents = _875_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _876___mcc_h483 = _source37.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _877_recursiveGen;
                  bool _878_recOwned;
                  bool _879_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _880_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out436;
                  bool _out437;
                  bool _out438;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out439;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out436, out _out437, out _out438, out _out439);
                  _877_recursiveGen = _out436;
                  _878_recOwned = _out437;
                  _879_recErased = _out438;
                  _880_recIdents = _out439;
                  if (!(_878_recOwned)) {
                    _877_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_877_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_877_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _878_recOwned;
                  isErased = _879_recErased;
                  readIdents = _880_recIdents;
                }
              }
            } else if (_source29.is_Tuple) {
              Dafny.ISequence<DAST._IType> _881___mcc_h486 = _source29.dtor_Tuple_a0;
              DAST._IType _source39 = _540___mcc_h265;
              if (_source39.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _882___mcc_h490 = _source39.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _883___mcc_h491 = _source39.dtor_typeArgs;
                DAST._IResolvedType _884___mcc_h492 = _source39.dtor_resolved;
                DAST._IResolvedType _source40 = _884___mcc_h492;
                if (_source40.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _885___mcc_h496 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _886_recursiveGen;
                    bool _887_recOwned;
                    bool _888_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _889_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out440;
                    bool _out441;
                    bool _out442;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out443;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out440, out _out441, out _out442, out _out443);
                    _886_recursiveGen = _out440;
                    _887_recOwned = _out441;
                    _888_recErased = _out442;
                    _889_recIdents = _out443;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _886_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _887_recOwned;
                    isErased = _888_recErased;
                    readIdents = _889_recIdents;
                  }
                } else if (_source40.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _890___mcc_h498 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _891_recursiveGen;
                    bool _892_recOwned;
                    bool _893_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _894_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out444;
                    bool _out445;
                    bool _out446;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out447;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out444, out _out445, out _out446, out _out447);
                    _891_recursiveGen = _out444;
                    _892_recOwned = _out445;
                    _893_recErased = _out446;
                    _894_recIdents = _out447;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _891_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _892_recOwned;
                    isErased = _893_recErased;
                    readIdents = _894_recIdents;
                  }
                } else {
                  DAST._IType _895___mcc_h500 = _source40.dtor_Newtype_a0;
                  DAST._IType _896_b = _895___mcc_h500;
                  {
                    if (object.Equals(_533_fromTpe, _896_b)) {
                      Dafny.ISequence<Dafny.Rune> _897_recursiveGen;
                      bool _898_recOwned;
                      bool _899_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _900_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out448;
                      bool _out449;
                      bool _out450;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out451;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out448, out _out449, out _out450, out _out451);
                      _897_recursiveGen = _out448;
                      _898_recOwned = _out449;
                      _899_recErased = _out450;
                      _900_recIdents = _out451;
                      Dafny.ISequence<Dafny.Rune> _901_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out452;
                      _out452 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _901_rhsType = _out452;
                      Dafny.ISequence<Dafny.Rune> _902_uneraseFn;
                      _902_uneraseFn = ((_898_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _901_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _902_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _897_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _898_recOwned;
                      isErased = false;
                      readIdents = _900_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out453;
                      bool _out454;
                      bool _out455;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out456;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _896_b), _896_b, _532_toTpe), selfIdent, @params, mustOwn, out _out453, out _out454, out _out455, out _out456);
                      s = _out453;
                      isOwned = _out454;
                      isErased = _out455;
                      readIdents = _out456;
                    }
                  }
                }
              } else if (_source39.is_Nullable) {
                DAST._IType _903___mcc_h502 = _source39.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _904_recursiveGen;
                  bool _905_recOwned;
                  bool _906_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _907_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out457;
                  bool _out458;
                  bool _out459;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out460;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out457, out _out458, out _out459, out _out460);
                  _904_recursiveGen = _out457;
                  _905_recOwned = _out458;
                  _906_recErased = _out459;
                  _907_recIdents = _out460;
                  if (!(_905_recOwned)) {
                    _904_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_904_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _904_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _906_recErased;
                  readIdents = _907_recIdents;
                }
              } else if (_source39.is_Tuple) {
                Dafny.ISequence<DAST._IType> _908___mcc_h504 = _source39.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _909_recursiveGen;
                  bool _910_recOwned;
                  bool _911_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _912_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out461;
                  bool _out462;
                  bool _out463;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out464;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out461, out _out462, out _out463, out _out464);
                  _909_recursiveGen = _out461;
                  _910_recOwned = _out462;
                  _911_recErased = _out463;
                  _912_recIdents = _out464;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _909_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _910_recOwned;
                  isErased = _911_recErased;
                  readIdents = _912_recIdents;
                }
              } else if (_source39.is_Array) {
                DAST._IType _913___mcc_h506 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _914_recursiveGen;
                  bool _915_recOwned;
                  bool _916_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _917_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out465;
                  bool _out466;
                  bool _out467;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out468;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out465, out _out466, out _out467, out _out468);
                  _914_recursiveGen = _out465;
                  _915_recOwned = _out466;
                  _916_recErased = _out467;
                  _917_recIdents = _out468;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _914_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _915_recOwned;
                  isErased = _916_recErased;
                  readIdents = _917_recIdents;
                }
              } else if (_source39.is_Seq) {
                DAST._IType _918___mcc_h508 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _919_recursiveGen;
                  bool _920_recOwned;
                  bool _921_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _922_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out469;
                  bool _out470;
                  bool _out471;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out472;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out469, out _out470, out _out471, out _out472);
                  _919_recursiveGen = _out469;
                  _920_recOwned = _out470;
                  _921_recErased = _out471;
                  _922_recIdents = _out472;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _919_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _920_recOwned;
                  isErased = _921_recErased;
                  readIdents = _922_recIdents;
                }
              } else if (_source39.is_Set) {
                DAST._IType _923___mcc_h510 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _924_recursiveGen;
                  bool _925_recOwned;
                  bool _926_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _927_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out473;
                  bool _out474;
                  bool _out475;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out476;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out473, out _out474, out _out475, out _out476);
                  _924_recursiveGen = _out473;
                  _925_recOwned = _out474;
                  _926_recErased = _out475;
                  _927_recIdents = _out476;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _924_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _925_recOwned;
                  isErased = _926_recErased;
                  readIdents = _927_recIdents;
                }
              } else if (_source39.is_Multiset) {
                DAST._IType _928___mcc_h512 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _929_recursiveGen;
                  bool _930_recOwned;
                  bool _931_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _932_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out477;
                  bool _out478;
                  bool _out479;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out480;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out477, out _out478, out _out479, out _out480);
                  _929_recursiveGen = _out477;
                  _930_recOwned = _out478;
                  _931_recErased = _out479;
                  _932_recIdents = _out480;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _929_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _930_recOwned;
                  isErased = _931_recErased;
                  readIdents = _932_recIdents;
                }
              } else if (_source39.is_Map) {
                DAST._IType _933___mcc_h514 = _source39.dtor_key;
                DAST._IType _934___mcc_h515 = _source39.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _935_recursiveGen;
                  bool _936_recOwned;
                  bool _937_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _938_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out481;
                  bool _out482;
                  bool _out483;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out484;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out481, out _out482, out _out483, out _out484);
                  _935_recursiveGen = _out481;
                  _936_recOwned = _out482;
                  _937_recErased = _out483;
                  _938_recIdents = _out484;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _935_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _936_recOwned;
                  isErased = _937_recErased;
                  readIdents = _938_recIdents;
                }
              } else if (_source39.is_Arrow) {
                Dafny.ISequence<DAST._IType> _939___mcc_h518 = _source39.dtor_args;
                DAST._IType _940___mcc_h519 = _source39.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _941_recursiveGen;
                  bool _942_recOwned;
                  bool _943_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _944_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out485;
                  bool _out486;
                  bool _out487;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out488;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out485, out _out486, out _out487, out _out488);
                  _941_recursiveGen = _out485;
                  _942_recOwned = _out486;
                  _943_recErased = _out487;
                  _944_recIdents = _out488;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _941_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _942_recOwned;
                  isErased = _943_recErased;
                  readIdents = _944_recIdents;
                }
              } else if (_source39.is_Primitive) {
                DAST._IPrimitive _945___mcc_h522 = _source39.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _946_recursiveGen;
                  bool _947_recOwned;
                  bool _948_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _949_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out489;
                  bool _out490;
                  bool _out491;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out492;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out489, out _out490, out _out491, out _out492);
                  _946_recursiveGen = _out489;
                  _947_recOwned = _out490;
                  _948_recErased = _out491;
                  _949_recIdents = _out492;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _946_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _947_recOwned;
                  isErased = _948_recErased;
                  readIdents = _949_recIdents;
                }
              } else if (_source39.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _950___mcc_h524 = _source39.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _951_recursiveGen;
                  bool _952_recOwned;
                  bool _953_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _954_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out493;
                  bool _out494;
                  bool _out495;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out496;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out493, out _out494, out _out495, out _out496);
                  _951_recursiveGen = _out493;
                  _952_recOwned = _out494;
                  _953_recErased = _out495;
                  _954_recIdents = _out496;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _951_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _952_recOwned;
                  isErased = _953_recErased;
                  readIdents = _954_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _955___mcc_h526 = _source39.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _956_recursiveGen;
                  bool _957_recOwned;
                  bool _958_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _959_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out497;
                  bool _out498;
                  bool _out499;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out500;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out497, out _out498, out _out499, out _out500);
                  _956_recursiveGen = _out497;
                  _957_recOwned = _out498;
                  _958_recErased = _out499;
                  _959_recIdents = _out500;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _956_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _957_recOwned;
                  isErased = _958_recErased;
                  readIdents = _959_recIdents;
                }
              }
            } else if (_source29.is_Array) {
              DAST._IType _960___mcc_h528 = _source29.dtor_element;
              DAST._IType _source41 = _540___mcc_h265;
              if (_source41.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _961___mcc_h532 = _source41.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _962___mcc_h533 = _source41.dtor_typeArgs;
                DAST._IResolvedType _963___mcc_h534 = _source41.dtor_resolved;
                DAST._IResolvedType _source42 = _963___mcc_h534;
                if (_source42.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _964___mcc_h538 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _965_recursiveGen;
                    bool _966_recOwned;
                    bool _967_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _968_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out501;
                    bool _out502;
                    bool _out503;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out504;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out501, out _out502, out _out503, out _out504);
                    _965_recursiveGen = _out501;
                    _966_recOwned = _out502;
                    _967_recErased = _out503;
                    _968_recIdents = _out504;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _965_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _966_recOwned;
                    isErased = _967_recErased;
                    readIdents = _968_recIdents;
                  }
                } else if (_source42.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _969___mcc_h540 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _970_recursiveGen;
                    bool _971_recOwned;
                    bool _972_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _973_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out505;
                    bool _out506;
                    bool _out507;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out508;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out505, out _out506, out _out507, out _out508);
                    _970_recursiveGen = _out505;
                    _971_recOwned = _out506;
                    _972_recErased = _out507;
                    _973_recIdents = _out508;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _970_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _971_recOwned;
                    isErased = _972_recErased;
                    readIdents = _973_recIdents;
                  }
                } else {
                  DAST._IType _974___mcc_h542 = _source42.dtor_Newtype_a0;
                  DAST._IType _975_b = _974___mcc_h542;
                  {
                    if (object.Equals(_533_fromTpe, _975_b)) {
                      Dafny.ISequence<Dafny.Rune> _976_recursiveGen;
                      bool _977_recOwned;
                      bool _978_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _979_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out509;
                      bool _out510;
                      bool _out511;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out512;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out509, out _out510, out _out511, out _out512);
                      _976_recursiveGen = _out509;
                      _977_recOwned = _out510;
                      _978_recErased = _out511;
                      _979_recIdents = _out512;
                      Dafny.ISequence<Dafny.Rune> _980_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out513;
                      _out513 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _980_rhsType = _out513;
                      Dafny.ISequence<Dafny.Rune> _981_uneraseFn;
                      _981_uneraseFn = ((_977_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _980_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _981_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _976_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _977_recOwned;
                      isErased = false;
                      readIdents = _979_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out514;
                      bool _out515;
                      bool _out516;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out517;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _975_b), _975_b, _532_toTpe), selfIdent, @params, mustOwn, out _out514, out _out515, out _out516, out _out517);
                      s = _out514;
                      isOwned = _out515;
                      isErased = _out516;
                      readIdents = _out517;
                    }
                  }
                }
              } else if (_source41.is_Nullable) {
                DAST._IType _982___mcc_h544 = _source41.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _983_recursiveGen;
                  bool _984_recOwned;
                  bool _985_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _986_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out518;
                  bool _out519;
                  bool _out520;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out521;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out518, out _out519, out _out520, out _out521);
                  _983_recursiveGen = _out518;
                  _984_recOwned = _out519;
                  _985_recErased = _out520;
                  _986_recIdents = _out521;
                  if (!(_984_recOwned)) {
                    _983_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_983_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _983_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _985_recErased;
                  readIdents = _986_recIdents;
                }
              } else if (_source41.is_Tuple) {
                Dafny.ISequence<DAST._IType> _987___mcc_h546 = _source41.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _988_recursiveGen;
                  bool _989_recOwned;
                  bool _990_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _991_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out522;
                  bool _out523;
                  bool _out524;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out525;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out522, out _out523, out _out524, out _out525);
                  _988_recursiveGen = _out522;
                  _989_recOwned = _out523;
                  _990_recErased = _out524;
                  _991_recIdents = _out525;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _988_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _989_recOwned;
                  isErased = _990_recErased;
                  readIdents = _991_recIdents;
                }
              } else if (_source41.is_Array) {
                DAST._IType _992___mcc_h548 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _993_recursiveGen;
                  bool _994_recOwned;
                  bool _995_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _996_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out526;
                  bool _out527;
                  bool _out528;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out529;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out526, out _out527, out _out528, out _out529);
                  _993_recursiveGen = _out526;
                  _994_recOwned = _out527;
                  _995_recErased = _out528;
                  _996_recIdents = _out529;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _993_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _994_recOwned;
                  isErased = _995_recErased;
                  readIdents = _996_recIdents;
                }
              } else if (_source41.is_Seq) {
                DAST._IType _997___mcc_h550 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _998_recursiveGen;
                  bool _999_recOwned;
                  bool _1000_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1001_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out530;
                  bool _out531;
                  bool _out532;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out533;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out530, out _out531, out _out532, out _out533);
                  _998_recursiveGen = _out530;
                  _999_recOwned = _out531;
                  _1000_recErased = _out532;
                  _1001_recIdents = _out533;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _998_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _999_recOwned;
                  isErased = _1000_recErased;
                  readIdents = _1001_recIdents;
                }
              } else if (_source41.is_Set) {
                DAST._IType _1002___mcc_h552 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1003_recursiveGen;
                  bool _1004_recOwned;
                  bool _1005_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1006_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out534;
                  bool _out535;
                  bool _out536;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out537;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out534, out _out535, out _out536, out _out537);
                  _1003_recursiveGen = _out534;
                  _1004_recOwned = _out535;
                  _1005_recErased = _out536;
                  _1006_recIdents = _out537;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1003_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1004_recOwned;
                  isErased = _1005_recErased;
                  readIdents = _1006_recIdents;
                }
              } else if (_source41.is_Multiset) {
                DAST._IType _1007___mcc_h554 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1008_recursiveGen;
                  bool _1009_recOwned;
                  bool _1010_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1011_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out538;
                  bool _out539;
                  bool _out540;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out541;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out538, out _out539, out _out540, out _out541);
                  _1008_recursiveGen = _out538;
                  _1009_recOwned = _out539;
                  _1010_recErased = _out540;
                  _1011_recIdents = _out541;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1008_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1009_recOwned;
                  isErased = _1010_recErased;
                  readIdents = _1011_recIdents;
                }
              } else if (_source41.is_Map) {
                DAST._IType _1012___mcc_h556 = _source41.dtor_key;
                DAST._IType _1013___mcc_h557 = _source41.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1014_recursiveGen;
                  bool _1015_recOwned;
                  bool _1016_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1017_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out542;
                  bool _out543;
                  bool _out544;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out545;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out542, out _out543, out _out544, out _out545);
                  _1014_recursiveGen = _out542;
                  _1015_recOwned = _out543;
                  _1016_recErased = _out544;
                  _1017_recIdents = _out545;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1014_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1015_recOwned;
                  isErased = _1016_recErased;
                  readIdents = _1017_recIdents;
                }
              } else if (_source41.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1018___mcc_h560 = _source41.dtor_args;
                DAST._IType _1019___mcc_h561 = _source41.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1020_recursiveGen;
                  bool _1021_recOwned;
                  bool _1022_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1023_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out546;
                  bool _out547;
                  bool _out548;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out549;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out546, out _out547, out _out548, out _out549);
                  _1020_recursiveGen = _out546;
                  _1021_recOwned = _out547;
                  _1022_recErased = _out548;
                  _1023_recIdents = _out549;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1020_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1021_recOwned;
                  isErased = _1022_recErased;
                  readIdents = _1023_recIdents;
                }
              } else if (_source41.is_Primitive) {
                DAST._IPrimitive _1024___mcc_h564 = _source41.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1025_recursiveGen;
                  bool _1026_recOwned;
                  bool _1027_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1028_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out550;
                  bool _out551;
                  bool _out552;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out553;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out550, out _out551, out _out552, out _out553);
                  _1025_recursiveGen = _out550;
                  _1026_recOwned = _out551;
                  _1027_recErased = _out552;
                  _1028_recIdents = _out553;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1025_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1026_recOwned;
                  isErased = _1027_recErased;
                  readIdents = _1028_recIdents;
                }
              } else if (_source41.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1029___mcc_h566 = _source41.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1030_recursiveGen;
                  bool _1031_recOwned;
                  bool _1032_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1033_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out554;
                  bool _out555;
                  bool _out556;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out557;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out554, out _out555, out _out556, out _out557);
                  _1030_recursiveGen = _out554;
                  _1031_recOwned = _out555;
                  _1032_recErased = _out556;
                  _1033_recIdents = _out557;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1030_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1031_recOwned;
                  isErased = _1032_recErased;
                  readIdents = _1033_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1034___mcc_h568 = _source41.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1035_recursiveGen;
                  bool _1036_recOwned;
                  bool _1037_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1038_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out558;
                  bool _out559;
                  bool _out560;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out561;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out558, out _out559, out _out560, out _out561);
                  _1035_recursiveGen = _out558;
                  _1036_recOwned = _out559;
                  _1037_recErased = _out560;
                  _1038_recIdents = _out561;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1035_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1036_recOwned;
                  isErased = _1037_recErased;
                  readIdents = _1038_recIdents;
                }
              }
            } else if (_source29.is_Seq) {
              DAST._IType _1039___mcc_h570 = _source29.dtor_element;
              DAST._IType _source43 = _540___mcc_h265;
              if (_source43.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1040___mcc_h574 = _source43.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1041___mcc_h575 = _source43.dtor_typeArgs;
                DAST._IResolvedType _1042___mcc_h576 = _source43.dtor_resolved;
                DAST._IResolvedType _source44 = _1042___mcc_h576;
                if (_source44.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1043___mcc_h580 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1044_recursiveGen;
                    bool _1045_recOwned;
                    bool _1046_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1047_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out562;
                    bool _out563;
                    bool _out564;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out565;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out562, out _out563, out _out564, out _out565);
                    _1044_recursiveGen = _out562;
                    _1045_recOwned = _out563;
                    _1046_recErased = _out564;
                    _1047_recIdents = _out565;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1044_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1045_recOwned;
                    isErased = _1046_recErased;
                    readIdents = _1047_recIdents;
                  }
                } else if (_source44.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1048___mcc_h582 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1049_recursiveGen;
                    bool _1050_recOwned;
                    bool _1051_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1052_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out566;
                    bool _out567;
                    bool _out568;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out569;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out566, out _out567, out _out568, out _out569);
                    _1049_recursiveGen = _out566;
                    _1050_recOwned = _out567;
                    _1051_recErased = _out568;
                    _1052_recIdents = _out569;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1049_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1050_recOwned;
                    isErased = _1051_recErased;
                    readIdents = _1052_recIdents;
                  }
                } else {
                  DAST._IType _1053___mcc_h584 = _source44.dtor_Newtype_a0;
                  DAST._IType _1054_b = _1053___mcc_h584;
                  {
                    if (object.Equals(_533_fromTpe, _1054_b)) {
                      Dafny.ISequence<Dafny.Rune> _1055_recursiveGen;
                      bool _1056_recOwned;
                      bool _1057_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1058_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out570;
                      bool _out571;
                      bool _out572;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out573;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out570, out _out571, out _out572, out _out573);
                      _1055_recursiveGen = _out570;
                      _1056_recOwned = _out571;
                      _1057_recErased = _out572;
                      _1058_recIdents = _out573;
                      Dafny.ISequence<Dafny.Rune> _1059_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out574;
                      _out574 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _1059_rhsType = _out574;
                      Dafny.ISequence<Dafny.Rune> _1060_uneraseFn;
                      _1060_uneraseFn = ((_1056_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1059_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1060_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1055_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1056_recOwned;
                      isErased = false;
                      readIdents = _1058_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out575;
                      bool _out576;
                      bool _out577;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out578;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1054_b), _1054_b, _532_toTpe), selfIdent, @params, mustOwn, out _out575, out _out576, out _out577, out _out578);
                      s = _out575;
                      isOwned = _out576;
                      isErased = _out577;
                      readIdents = _out578;
                    }
                  }
                }
              } else if (_source43.is_Nullable) {
                DAST._IType _1061___mcc_h586 = _source43.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1062_recursiveGen;
                  bool _1063_recOwned;
                  bool _1064_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1065_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out579;
                  bool _out580;
                  bool _out581;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out582;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out579, out _out580, out _out581, out _out582);
                  _1062_recursiveGen = _out579;
                  _1063_recOwned = _out580;
                  _1064_recErased = _out581;
                  _1065_recIdents = _out582;
                  if (!(_1063_recOwned)) {
                    _1062_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1062_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1062_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1064_recErased;
                  readIdents = _1065_recIdents;
                }
              } else if (_source43.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1066___mcc_h588 = _source43.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1067_recursiveGen;
                  bool _1068_recOwned;
                  bool _1069_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1070_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out583;
                  bool _out584;
                  bool _out585;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out586;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out583, out _out584, out _out585, out _out586);
                  _1067_recursiveGen = _out583;
                  _1068_recOwned = _out584;
                  _1069_recErased = _out585;
                  _1070_recIdents = _out586;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1067_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1068_recOwned;
                  isErased = _1069_recErased;
                  readIdents = _1070_recIdents;
                }
              } else if (_source43.is_Array) {
                DAST._IType _1071___mcc_h590 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1072_recursiveGen;
                  bool _1073_recOwned;
                  bool _1074_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1075_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out587;
                  bool _out588;
                  bool _out589;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out590;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out587, out _out588, out _out589, out _out590);
                  _1072_recursiveGen = _out587;
                  _1073_recOwned = _out588;
                  _1074_recErased = _out589;
                  _1075_recIdents = _out590;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1072_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1073_recOwned;
                  isErased = _1074_recErased;
                  readIdents = _1075_recIdents;
                }
              } else if (_source43.is_Seq) {
                DAST._IType _1076___mcc_h592 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1077_recursiveGen;
                  bool _1078_recOwned;
                  bool _1079_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1080_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out591;
                  bool _out592;
                  bool _out593;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out594;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out591, out _out592, out _out593, out _out594);
                  _1077_recursiveGen = _out591;
                  _1078_recOwned = _out592;
                  _1079_recErased = _out593;
                  _1080_recIdents = _out594;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1077_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1078_recOwned;
                  isErased = _1079_recErased;
                  readIdents = _1080_recIdents;
                }
              } else if (_source43.is_Set) {
                DAST._IType _1081___mcc_h594 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1082_recursiveGen;
                  bool _1083_recOwned;
                  bool _1084_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1085_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out595;
                  bool _out596;
                  bool _out597;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out598;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out595, out _out596, out _out597, out _out598);
                  _1082_recursiveGen = _out595;
                  _1083_recOwned = _out596;
                  _1084_recErased = _out597;
                  _1085_recIdents = _out598;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1082_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1083_recOwned;
                  isErased = _1084_recErased;
                  readIdents = _1085_recIdents;
                }
              } else if (_source43.is_Multiset) {
                DAST._IType _1086___mcc_h596 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1087_recursiveGen;
                  bool _1088_recOwned;
                  bool _1089_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1090_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out599;
                  bool _out600;
                  bool _out601;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out602;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out599, out _out600, out _out601, out _out602);
                  _1087_recursiveGen = _out599;
                  _1088_recOwned = _out600;
                  _1089_recErased = _out601;
                  _1090_recIdents = _out602;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1087_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1088_recOwned;
                  isErased = _1089_recErased;
                  readIdents = _1090_recIdents;
                }
              } else if (_source43.is_Map) {
                DAST._IType _1091___mcc_h598 = _source43.dtor_key;
                DAST._IType _1092___mcc_h599 = _source43.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1093_recursiveGen;
                  bool _1094_recOwned;
                  bool _1095_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1096_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out603;
                  bool _out604;
                  bool _out605;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out606;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out603, out _out604, out _out605, out _out606);
                  _1093_recursiveGen = _out603;
                  _1094_recOwned = _out604;
                  _1095_recErased = _out605;
                  _1096_recIdents = _out606;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1093_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1094_recOwned;
                  isErased = _1095_recErased;
                  readIdents = _1096_recIdents;
                }
              } else if (_source43.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1097___mcc_h602 = _source43.dtor_args;
                DAST._IType _1098___mcc_h603 = _source43.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1099_recursiveGen;
                  bool _1100_recOwned;
                  bool _1101_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1102_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out607;
                  bool _out608;
                  bool _out609;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out610;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out607, out _out608, out _out609, out _out610);
                  _1099_recursiveGen = _out607;
                  _1100_recOwned = _out608;
                  _1101_recErased = _out609;
                  _1102_recIdents = _out610;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1099_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1100_recOwned;
                  isErased = _1101_recErased;
                  readIdents = _1102_recIdents;
                }
              } else if (_source43.is_Primitive) {
                DAST._IPrimitive _1103___mcc_h606 = _source43.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1104_recursiveGen;
                  bool _1105_recOwned;
                  bool _1106_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1107_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out611;
                  bool _out612;
                  bool _out613;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out614;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out611, out _out612, out _out613, out _out614);
                  _1104_recursiveGen = _out611;
                  _1105_recOwned = _out612;
                  _1106_recErased = _out613;
                  _1107_recIdents = _out614;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1104_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1105_recOwned;
                  isErased = _1106_recErased;
                  readIdents = _1107_recIdents;
                }
              } else if (_source43.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1108___mcc_h608 = _source43.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1109_recursiveGen;
                  bool _1110_recOwned;
                  bool _1111_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1112_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out615;
                  bool _out616;
                  bool _out617;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out618;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out615, out _out616, out _out617, out _out618);
                  _1109_recursiveGen = _out615;
                  _1110_recOwned = _out616;
                  _1111_recErased = _out617;
                  _1112_recIdents = _out618;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1109_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1110_recOwned;
                  isErased = _1111_recErased;
                  readIdents = _1112_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1113___mcc_h610 = _source43.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1114_recursiveGen;
                  bool _1115_recOwned;
                  bool _1116_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1117_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out619;
                  bool _out620;
                  bool _out621;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out622;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out619, out _out620, out _out621, out _out622);
                  _1114_recursiveGen = _out619;
                  _1115_recOwned = _out620;
                  _1116_recErased = _out621;
                  _1117_recIdents = _out622;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1114_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1115_recOwned;
                  isErased = _1116_recErased;
                  readIdents = _1117_recIdents;
                }
              }
            } else if (_source29.is_Set) {
              DAST._IType _1118___mcc_h612 = _source29.dtor_element;
              DAST._IType _source45 = _540___mcc_h265;
              if (_source45.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1119___mcc_h616 = _source45.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1120___mcc_h617 = _source45.dtor_typeArgs;
                DAST._IResolvedType _1121___mcc_h618 = _source45.dtor_resolved;
                DAST._IResolvedType _source46 = _1121___mcc_h618;
                if (_source46.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1122___mcc_h622 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1123_recursiveGen;
                    bool _1124_recOwned;
                    bool _1125_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1126_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out623;
                    bool _out624;
                    bool _out625;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out626;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out623, out _out624, out _out625, out _out626);
                    _1123_recursiveGen = _out623;
                    _1124_recOwned = _out624;
                    _1125_recErased = _out625;
                    _1126_recIdents = _out626;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1123_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1124_recOwned;
                    isErased = _1125_recErased;
                    readIdents = _1126_recIdents;
                  }
                } else if (_source46.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1127___mcc_h624 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1128_recursiveGen;
                    bool _1129_recOwned;
                    bool _1130_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1131_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out627;
                    bool _out628;
                    bool _out629;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out630;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out627, out _out628, out _out629, out _out630);
                    _1128_recursiveGen = _out627;
                    _1129_recOwned = _out628;
                    _1130_recErased = _out629;
                    _1131_recIdents = _out630;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1128_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1129_recOwned;
                    isErased = _1130_recErased;
                    readIdents = _1131_recIdents;
                  }
                } else {
                  DAST._IType _1132___mcc_h626 = _source46.dtor_Newtype_a0;
                  DAST._IType _1133_b = _1132___mcc_h626;
                  {
                    if (object.Equals(_533_fromTpe, _1133_b)) {
                      Dafny.ISequence<Dafny.Rune> _1134_recursiveGen;
                      bool _1135_recOwned;
                      bool _1136_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1137_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out631;
                      bool _out632;
                      bool _out633;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out634;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out631, out _out632, out _out633, out _out634);
                      _1134_recursiveGen = _out631;
                      _1135_recOwned = _out632;
                      _1136_recErased = _out633;
                      _1137_recIdents = _out634;
                      Dafny.ISequence<Dafny.Rune> _1138_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out635;
                      _out635 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _1138_rhsType = _out635;
                      Dafny.ISequence<Dafny.Rune> _1139_uneraseFn;
                      _1139_uneraseFn = ((_1135_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1138_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1139_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1134_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1135_recOwned;
                      isErased = false;
                      readIdents = _1137_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out636;
                      bool _out637;
                      bool _out638;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out639;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1133_b), _1133_b, _532_toTpe), selfIdent, @params, mustOwn, out _out636, out _out637, out _out638, out _out639);
                      s = _out636;
                      isOwned = _out637;
                      isErased = _out638;
                      readIdents = _out639;
                    }
                  }
                }
              } else if (_source45.is_Nullable) {
                DAST._IType _1140___mcc_h628 = _source45.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1141_recursiveGen;
                  bool _1142_recOwned;
                  bool _1143_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1144_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out640;
                  bool _out641;
                  bool _out642;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out643;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out640, out _out641, out _out642, out _out643);
                  _1141_recursiveGen = _out640;
                  _1142_recOwned = _out641;
                  _1143_recErased = _out642;
                  _1144_recIdents = _out643;
                  if (!(_1142_recOwned)) {
                    _1141_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1141_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1141_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1143_recErased;
                  readIdents = _1144_recIdents;
                }
              } else if (_source45.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1145___mcc_h630 = _source45.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1146_recursiveGen;
                  bool _1147_recOwned;
                  bool _1148_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1149_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out644;
                  bool _out645;
                  bool _out646;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out647;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out644, out _out645, out _out646, out _out647);
                  _1146_recursiveGen = _out644;
                  _1147_recOwned = _out645;
                  _1148_recErased = _out646;
                  _1149_recIdents = _out647;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1146_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1147_recOwned;
                  isErased = _1148_recErased;
                  readIdents = _1149_recIdents;
                }
              } else if (_source45.is_Array) {
                DAST._IType _1150___mcc_h632 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1151_recursiveGen;
                  bool _1152_recOwned;
                  bool _1153_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1154_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out648;
                  bool _out649;
                  bool _out650;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out651;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out648, out _out649, out _out650, out _out651);
                  _1151_recursiveGen = _out648;
                  _1152_recOwned = _out649;
                  _1153_recErased = _out650;
                  _1154_recIdents = _out651;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1151_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1152_recOwned;
                  isErased = _1153_recErased;
                  readIdents = _1154_recIdents;
                }
              } else if (_source45.is_Seq) {
                DAST._IType _1155___mcc_h634 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1156_recursiveGen;
                  bool _1157_recOwned;
                  bool _1158_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1159_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out652;
                  bool _out653;
                  bool _out654;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out655;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out652, out _out653, out _out654, out _out655);
                  _1156_recursiveGen = _out652;
                  _1157_recOwned = _out653;
                  _1158_recErased = _out654;
                  _1159_recIdents = _out655;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1156_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1157_recOwned;
                  isErased = _1158_recErased;
                  readIdents = _1159_recIdents;
                }
              } else if (_source45.is_Set) {
                DAST._IType _1160___mcc_h636 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1161_recursiveGen;
                  bool _1162_recOwned;
                  bool _1163_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1164_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out656;
                  bool _out657;
                  bool _out658;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out659;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out656, out _out657, out _out658, out _out659);
                  _1161_recursiveGen = _out656;
                  _1162_recOwned = _out657;
                  _1163_recErased = _out658;
                  _1164_recIdents = _out659;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1161_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1162_recOwned;
                  isErased = _1163_recErased;
                  readIdents = _1164_recIdents;
                }
              } else if (_source45.is_Multiset) {
                DAST._IType _1165___mcc_h638 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1166_recursiveGen;
                  bool _1167_recOwned;
                  bool _1168_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1169_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out660;
                  bool _out661;
                  bool _out662;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out663;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out660, out _out661, out _out662, out _out663);
                  _1166_recursiveGen = _out660;
                  _1167_recOwned = _out661;
                  _1168_recErased = _out662;
                  _1169_recIdents = _out663;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1166_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1167_recOwned;
                  isErased = _1168_recErased;
                  readIdents = _1169_recIdents;
                }
              } else if (_source45.is_Map) {
                DAST._IType _1170___mcc_h640 = _source45.dtor_key;
                DAST._IType _1171___mcc_h641 = _source45.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1172_recursiveGen;
                  bool _1173_recOwned;
                  bool _1174_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1175_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out664;
                  bool _out665;
                  bool _out666;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out667;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out664, out _out665, out _out666, out _out667);
                  _1172_recursiveGen = _out664;
                  _1173_recOwned = _out665;
                  _1174_recErased = _out666;
                  _1175_recIdents = _out667;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1172_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1173_recOwned;
                  isErased = _1174_recErased;
                  readIdents = _1175_recIdents;
                }
              } else if (_source45.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1176___mcc_h644 = _source45.dtor_args;
                DAST._IType _1177___mcc_h645 = _source45.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1178_recursiveGen;
                  bool _1179_recOwned;
                  bool _1180_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1181_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out668;
                  bool _out669;
                  bool _out670;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out671;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out668, out _out669, out _out670, out _out671);
                  _1178_recursiveGen = _out668;
                  _1179_recOwned = _out669;
                  _1180_recErased = _out670;
                  _1181_recIdents = _out671;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1178_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1179_recOwned;
                  isErased = _1180_recErased;
                  readIdents = _1181_recIdents;
                }
              } else if (_source45.is_Primitive) {
                DAST._IPrimitive _1182___mcc_h648 = _source45.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1183_recursiveGen;
                  bool _1184_recOwned;
                  bool _1185_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1186_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out672;
                  bool _out673;
                  bool _out674;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out675;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out672, out _out673, out _out674, out _out675);
                  _1183_recursiveGen = _out672;
                  _1184_recOwned = _out673;
                  _1185_recErased = _out674;
                  _1186_recIdents = _out675;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1183_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1184_recOwned;
                  isErased = _1185_recErased;
                  readIdents = _1186_recIdents;
                }
              } else if (_source45.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1187___mcc_h650 = _source45.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1188_recursiveGen;
                  bool _1189_recOwned;
                  bool _1190_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1191_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out676;
                  bool _out677;
                  bool _out678;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out679;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out676, out _out677, out _out678, out _out679);
                  _1188_recursiveGen = _out676;
                  _1189_recOwned = _out677;
                  _1190_recErased = _out678;
                  _1191_recIdents = _out679;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1188_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1189_recOwned;
                  isErased = _1190_recErased;
                  readIdents = _1191_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1192___mcc_h652 = _source45.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1193_recursiveGen;
                  bool _1194_recOwned;
                  bool _1195_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1196_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out680;
                  bool _out681;
                  bool _out682;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out683;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out680, out _out681, out _out682, out _out683);
                  _1193_recursiveGen = _out680;
                  _1194_recOwned = _out681;
                  _1195_recErased = _out682;
                  _1196_recIdents = _out683;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1193_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1194_recOwned;
                  isErased = _1195_recErased;
                  readIdents = _1196_recIdents;
                }
              }
            } else if (_source29.is_Multiset) {
              DAST._IType _1197___mcc_h654 = _source29.dtor_element;
              DAST._IType _source47 = _540___mcc_h265;
              if (_source47.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1198___mcc_h658 = _source47.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1199___mcc_h659 = _source47.dtor_typeArgs;
                DAST._IResolvedType _1200___mcc_h660 = _source47.dtor_resolved;
                DAST._IResolvedType _source48 = _1200___mcc_h660;
                if (_source48.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1201___mcc_h664 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1202_recursiveGen;
                    bool _1203_recOwned;
                    bool _1204_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1205_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out684;
                    bool _out685;
                    bool _out686;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out687;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out684, out _out685, out _out686, out _out687);
                    _1202_recursiveGen = _out684;
                    _1203_recOwned = _out685;
                    _1204_recErased = _out686;
                    _1205_recIdents = _out687;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1202_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1203_recOwned;
                    isErased = _1204_recErased;
                    readIdents = _1205_recIdents;
                  }
                } else if (_source48.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1206___mcc_h666 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1207_recursiveGen;
                    bool _1208_recOwned;
                    bool _1209_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1210_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out688;
                    bool _out689;
                    bool _out690;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out691;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out688, out _out689, out _out690, out _out691);
                    _1207_recursiveGen = _out688;
                    _1208_recOwned = _out689;
                    _1209_recErased = _out690;
                    _1210_recIdents = _out691;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1207_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1208_recOwned;
                    isErased = _1209_recErased;
                    readIdents = _1210_recIdents;
                  }
                } else {
                  DAST._IType _1211___mcc_h668 = _source48.dtor_Newtype_a0;
                  DAST._IType _1212_b = _1211___mcc_h668;
                  {
                    if (object.Equals(_533_fromTpe, _1212_b)) {
                      Dafny.ISequence<Dafny.Rune> _1213_recursiveGen;
                      bool _1214_recOwned;
                      bool _1215_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1216_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out692;
                      bool _out693;
                      bool _out694;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out695;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out692, out _out693, out _out694, out _out695);
                      _1213_recursiveGen = _out692;
                      _1214_recOwned = _out693;
                      _1215_recErased = _out694;
                      _1216_recIdents = _out695;
                      Dafny.ISequence<Dafny.Rune> _1217_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out696;
                      _out696 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _1217_rhsType = _out696;
                      Dafny.ISequence<Dafny.Rune> _1218_uneraseFn;
                      _1218_uneraseFn = ((_1214_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1217_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1218_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1213_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1214_recOwned;
                      isErased = false;
                      readIdents = _1216_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out697;
                      bool _out698;
                      bool _out699;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out700;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1212_b), _1212_b, _532_toTpe), selfIdent, @params, mustOwn, out _out697, out _out698, out _out699, out _out700);
                      s = _out697;
                      isOwned = _out698;
                      isErased = _out699;
                      readIdents = _out700;
                    }
                  }
                }
              } else if (_source47.is_Nullable) {
                DAST._IType _1219___mcc_h670 = _source47.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1220_recursiveGen;
                  bool _1221_recOwned;
                  bool _1222_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1223_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out701;
                  bool _out702;
                  bool _out703;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out704;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out701, out _out702, out _out703, out _out704);
                  _1220_recursiveGen = _out701;
                  _1221_recOwned = _out702;
                  _1222_recErased = _out703;
                  _1223_recIdents = _out704;
                  if (!(_1221_recOwned)) {
                    _1220_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1220_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1220_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1222_recErased;
                  readIdents = _1223_recIdents;
                }
              } else if (_source47.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1224___mcc_h672 = _source47.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1225_recursiveGen;
                  bool _1226_recOwned;
                  bool _1227_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1228_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out705;
                  bool _out706;
                  bool _out707;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out708;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out705, out _out706, out _out707, out _out708);
                  _1225_recursiveGen = _out705;
                  _1226_recOwned = _out706;
                  _1227_recErased = _out707;
                  _1228_recIdents = _out708;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1225_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1226_recOwned;
                  isErased = _1227_recErased;
                  readIdents = _1228_recIdents;
                }
              } else if (_source47.is_Array) {
                DAST._IType _1229___mcc_h674 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1230_recursiveGen;
                  bool _1231_recOwned;
                  bool _1232_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1233_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out709;
                  bool _out710;
                  bool _out711;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out712;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out709, out _out710, out _out711, out _out712);
                  _1230_recursiveGen = _out709;
                  _1231_recOwned = _out710;
                  _1232_recErased = _out711;
                  _1233_recIdents = _out712;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1230_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1231_recOwned;
                  isErased = _1232_recErased;
                  readIdents = _1233_recIdents;
                }
              } else if (_source47.is_Seq) {
                DAST._IType _1234___mcc_h676 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1235_recursiveGen;
                  bool _1236_recOwned;
                  bool _1237_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1238_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out713;
                  bool _out714;
                  bool _out715;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out716;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out713, out _out714, out _out715, out _out716);
                  _1235_recursiveGen = _out713;
                  _1236_recOwned = _out714;
                  _1237_recErased = _out715;
                  _1238_recIdents = _out716;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1235_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1236_recOwned;
                  isErased = _1237_recErased;
                  readIdents = _1238_recIdents;
                }
              } else if (_source47.is_Set) {
                DAST._IType _1239___mcc_h678 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1240_recursiveGen;
                  bool _1241_recOwned;
                  bool _1242_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1243_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out717;
                  bool _out718;
                  bool _out719;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out720;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out717, out _out718, out _out719, out _out720);
                  _1240_recursiveGen = _out717;
                  _1241_recOwned = _out718;
                  _1242_recErased = _out719;
                  _1243_recIdents = _out720;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1240_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1241_recOwned;
                  isErased = _1242_recErased;
                  readIdents = _1243_recIdents;
                }
              } else if (_source47.is_Multiset) {
                DAST._IType _1244___mcc_h680 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1245_recursiveGen;
                  bool _1246_recOwned;
                  bool _1247_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1248_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out721;
                  bool _out722;
                  bool _out723;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out724;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out721, out _out722, out _out723, out _out724);
                  _1245_recursiveGen = _out721;
                  _1246_recOwned = _out722;
                  _1247_recErased = _out723;
                  _1248_recIdents = _out724;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1245_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1246_recOwned;
                  isErased = _1247_recErased;
                  readIdents = _1248_recIdents;
                }
              } else if (_source47.is_Map) {
                DAST._IType _1249___mcc_h682 = _source47.dtor_key;
                DAST._IType _1250___mcc_h683 = _source47.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1251_recursiveGen;
                  bool _1252_recOwned;
                  bool _1253_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1254_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out725;
                  bool _out726;
                  bool _out727;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out728;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out725, out _out726, out _out727, out _out728);
                  _1251_recursiveGen = _out725;
                  _1252_recOwned = _out726;
                  _1253_recErased = _out727;
                  _1254_recIdents = _out728;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1251_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1252_recOwned;
                  isErased = _1253_recErased;
                  readIdents = _1254_recIdents;
                }
              } else if (_source47.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1255___mcc_h686 = _source47.dtor_args;
                DAST._IType _1256___mcc_h687 = _source47.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1257_recursiveGen;
                  bool _1258_recOwned;
                  bool _1259_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1260_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out729;
                  bool _out730;
                  bool _out731;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out732;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out729, out _out730, out _out731, out _out732);
                  _1257_recursiveGen = _out729;
                  _1258_recOwned = _out730;
                  _1259_recErased = _out731;
                  _1260_recIdents = _out732;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1257_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1258_recOwned;
                  isErased = _1259_recErased;
                  readIdents = _1260_recIdents;
                }
              } else if (_source47.is_Primitive) {
                DAST._IPrimitive _1261___mcc_h690 = _source47.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1262_recursiveGen;
                  bool _1263_recOwned;
                  bool _1264_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1265_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out733;
                  bool _out734;
                  bool _out735;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out736;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out733, out _out734, out _out735, out _out736);
                  _1262_recursiveGen = _out733;
                  _1263_recOwned = _out734;
                  _1264_recErased = _out735;
                  _1265_recIdents = _out736;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1262_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1263_recOwned;
                  isErased = _1264_recErased;
                  readIdents = _1265_recIdents;
                }
              } else if (_source47.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1266___mcc_h692 = _source47.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1267_recursiveGen;
                  bool _1268_recOwned;
                  bool _1269_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1270_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out737;
                  bool _out738;
                  bool _out739;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out740;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out737, out _out738, out _out739, out _out740);
                  _1267_recursiveGen = _out737;
                  _1268_recOwned = _out738;
                  _1269_recErased = _out739;
                  _1270_recIdents = _out740;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1267_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1268_recOwned;
                  isErased = _1269_recErased;
                  readIdents = _1270_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1271___mcc_h694 = _source47.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1272_recursiveGen;
                  bool _1273_recOwned;
                  bool _1274_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1275_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out741;
                  bool _out742;
                  bool _out743;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out744;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out741, out _out742, out _out743, out _out744);
                  _1272_recursiveGen = _out741;
                  _1273_recOwned = _out742;
                  _1274_recErased = _out743;
                  _1275_recIdents = _out744;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1272_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1273_recOwned;
                  isErased = _1274_recErased;
                  readIdents = _1275_recIdents;
                }
              }
            } else if (_source29.is_Map) {
              DAST._IType _1276___mcc_h696 = _source29.dtor_key;
              DAST._IType _1277___mcc_h697 = _source29.dtor_value;
              DAST._IType _source49 = _540___mcc_h265;
              if (_source49.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1278___mcc_h704 = _source49.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1279___mcc_h705 = _source49.dtor_typeArgs;
                DAST._IResolvedType _1280___mcc_h706 = _source49.dtor_resolved;
                DAST._IResolvedType _source50 = _1280___mcc_h706;
                if (_source50.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1281___mcc_h710 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1282_recursiveGen;
                    bool _1283_recOwned;
                    bool _1284_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1285_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out745;
                    bool _out746;
                    bool _out747;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out748;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out745, out _out746, out _out747, out _out748);
                    _1282_recursiveGen = _out745;
                    _1283_recOwned = _out746;
                    _1284_recErased = _out747;
                    _1285_recIdents = _out748;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1282_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1283_recOwned;
                    isErased = _1284_recErased;
                    readIdents = _1285_recIdents;
                  }
                } else if (_source50.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1286___mcc_h712 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1287_recursiveGen;
                    bool _1288_recOwned;
                    bool _1289_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1290_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out749;
                    bool _out750;
                    bool _out751;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out752;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out749, out _out750, out _out751, out _out752);
                    _1287_recursiveGen = _out749;
                    _1288_recOwned = _out750;
                    _1289_recErased = _out751;
                    _1290_recIdents = _out752;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1287_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1288_recOwned;
                    isErased = _1289_recErased;
                    readIdents = _1290_recIdents;
                  }
                } else {
                  DAST._IType _1291___mcc_h714 = _source50.dtor_Newtype_a0;
                  DAST._IType _1292_b = _1291___mcc_h714;
                  {
                    if (object.Equals(_533_fromTpe, _1292_b)) {
                      Dafny.ISequence<Dafny.Rune> _1293_recursiveGen;
                      bool _1294_recOwned;
                      bool _1295_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1296_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out753;
                      bool _out754;
                      bool _out755;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out756;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out753, out _out754, out _out755, out _out756);
                      _1293_recursiveGen = _out753;
                      _1294_recOwned = _out754;
                      _1295_recErased = _out755;
                      _1296_recIdents = _out756;
                      Dafny.ISequence<Dafny.Rune> _1297_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out757;
                      _out757 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _1297_rhsType = _out757;
                      Dafny.ISequence<Dafny.Rune> _1298_uneraseFn;
                      _1298_uneraseFn = ((_1294_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1297_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1298_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1293_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1294_recOwned;
                      isErased = false;
                      readIdents = _1296_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out758;
                      bool _out759;
                      bool _out760;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out761;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1292_b), _1292_b, _532_toTpe), selfIdent, @params, mustOwn, out _out758, out _out759, out _out760, out _out761);
                      s = _out758;
                      isOwned = _out759;
                      isErased = _out760;
                      readIdents = _out761;
                    }
                  }
                }
              } else if (_source49.is_Nullable) {
                DAST._IType _1299___mcc_h716 = _source49.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1300_recursiveGen;
                  bool _1301_recOwned;
                  bool _1302_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1303_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out762;
                  bool _out763;
                  bool _out764;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out765;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out762, out _out763, out _out764, out _out765);
                  _1300_recursiveGen = _out762;
                  _1301_recOwned = _out763;
                  _1302_recErased = _out764;
                  _1303_recIdents = _out765;
                  if (!(_1301_recOwned)) {
                    _1300_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1300_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1300_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1302_recErased;
                  readIdents = _1303_recIdents;
                }
              } else if (_source49.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1304___mcc_h718 = _source49.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1305_recursiveGen;
                  bool _1306_recOwned;
                  bool _1307_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1308_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out766;
                  bool _out767;
                  bool _out768;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out769;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out766, out _out767, out _out768, out _out769);
                  _1305_recursiveGen = _out766;
                  _1306_recOwned = _out767;
                  _1307_recErased = _out768;
                  _1308_recIdents = _out769;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1305_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1306_recOwned;
                  isErased = _1307_recErased;
                  readIdents = _1308_recIdents;
                }
              } else if (_source49.is_Array) {
                DAST._IType _1309___mcc_h720 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1310_recursiveGen;
                  bool _1311_recOwned;
                  bool _1312_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1313_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out770;
                  bool _out771;
                  bool _out772;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out773;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out770, out _out771, out _out772, out _out773);
                  _1310_recursiveGen = _out770;
                  _1311_recOwned = _out771;
                  _1312_recErased = _out772;
                  _1313_recIdents = _out773;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1310_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1311_recOwned;
                  isErased = _1312_recErased;
                  readIdents = _1313_recIdents;
                }
              } else if (_source49.is_Seq) {
                DAST._IType _1314___mcc_h722 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1315_recursiveGen;
                  bool _1316_recOwned;
                  bool _1317_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1318_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out774;
                  bool _out775;
                  bool _out776;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out777;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out774, out _out775, out _out776, out _out777);
                  _1315_recursiveGen = _out774;
                  _1316_recOwned = _out775;
                  _1317_recErased = _out776;
                  _1318_recIdents = _out777;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1315_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1316_recOwned;
                  isErased = _1317_recErased;
                  readIdents = _1318_recIdents;
                }
              } else if (_source49.is_Set) {
                DAST._IType _1319___mcc_h724 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1320_recursiveGen;
                  bool _1321_recOwned;
                  bool _1322_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1323_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out778;
                  bool _out779;
                  bool _out780;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out781;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out778, out _out779, out _out780, out _out781);
                  _1320_recursiveGen = _out778;
                  _1321_recOwned = _out779;
                  _1322_recErased = _out780;
                  _1323_recIdents = _out781;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1320_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1321_recOwned;
                  isErased = _1322_recErased;
                  readIdents = _1323_recIdents;
                }
              } else if (_source49.is_Multiset) {
                DAST._IType _1324___mcc_h726 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1325_recursiveGen;
                  bool _1326_recOwned;
                  bool _1327_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1328_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out782;
                  bool _out783;
                  bool _out784;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out785;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out782, out _out783, out _out784, out _out785);
                  _1325_recursiveGen = _out782;
                  _1326_recOwned = _out783;
                  _1327_recErased = _out784;
                  _1328_recIdents = _out785;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1325_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1326_recOwned;
                  isErased = _1327_recErased;
                  readIdents = _1328_recIdents;
                }
              } else if (_source49.is_Map) {
                DAST._IType _1329___mcc_h728 = _source49.dtor_key;
                DAST._IType _1330___mcc_h729 = _source49.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1331_recursiveGen;
                  bool _1332_recOwned;
                  bool _1333_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1334_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out786;
                  bool _out787;
                  bool _out788;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out789;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out786, out _out787, out _out788, out _out789);
                  _1331_recursiveGen = _out786;
                  _1332_recOwned = _out787;
                  _1333_recErased = _out788;
                  _1334_recIdents = _out789;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1331_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1332_recOwned;
                  isErased = _1333_recErased;
                  readIdents = _1334_recIdents;
                }
              } else if (_source49.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1335___mcc_h732 = _source49.dtor_args;
                DAST._IType _1336___mcc_h733 = _source49.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1337_recursiveGen;
                  bool _1338_recOwned;
                  bool _1339_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1340_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out790;
                  bool _out791;
                  bool _out792;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out793;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out790, out _out791, out _out792, out _out793);
                  _1337_recursiveGen = _out790;
                  _1338_recOwned = _out791;
                  _1339_recErased = _out792;
                  _1340_recIdents = _out793;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1337_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1338_recOwned;
                  isErased = _1339_recErased;
                  readIdents = _1340_recIdents;
                }
              } else if (_source49.is_Primitive) {
                DAST._IPrimitive _1341___mcc_h736 = _source49.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1342_recursiveGen;
                  bool _1343_recOwned;
                  bool _1344_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1345_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out794;
                  bool _out795;
                  bool _out796;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out797;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out794, out _out795, out _out796, out _out797);
                  _1342_recursiveGen = _out794;
                  _1343_recOwned = _out795;
                  _1344_recErased = _out796;
                  _1345_recIdents = _out797;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1342_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1343_recOwned;
                  isErased = _1344_recErased;
                  readIdents = _1345_recIdents;
                }
              } else if (_source49.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1346___mcc_h738 = _source49.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1347_recursiveGen;
                  bool _1348_recOwned;
                  bool _1349_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1350_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out798;
                  bool _out799;
                  bool _out800;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out801;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out798, out _out799, out _out800, out _out801);
                  _1347_recursiveGen = _out798;
                  _1348_recOwned = _out799;
                  _1349_recErased = _out800;
                  _1350_recIdents = _out801;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1347_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1348_recOwned;
                  isErased = _1349_recErased;
                  readIdents = _1350_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1351___mcc_h740 = _source49.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1352_recursiveGen;
                  bool _1353_recOwned;
                  bool _1354_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1355_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out802;
                  bool _out803;
                  bool _out804;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out805;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out802, out _out803, out _out804, out _out805);
                  _1352_recursiveGen = _out802;
                  _1353_recOwned = _out803;
                  _1354_recErased = _out804;
                  _1355_recIdents = _out805;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1352_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1353_recOwned;
                  isErased = _1354_recErased;
                  readIdents = _1355_recIdents;
                }
              }
            } else if (_source29.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1356___mcc_h742 = _source29.dtor_args;
              DAST._IType _1357___mcc_h743 = _source29.dtor_result;
              DAST._IType _source51 = _540___mcc_h265;
              if (_source51.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1358___mcc_h750 = _source51.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1359___mcc_h751 = _source51.dtor_typeArgs;
                DAST._IResolvedType _1360___mcc_h752 = _source51.dtor_resolved;
                DAST._IResolvedType _source52 = _1360___mcc_h752;
                if (_source52.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1361___mcc_h756 = _source52.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1362_recursiveGen;
                    bool _1363_recOwned;
                    bool _1364_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1365_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out806;
                    bool _out807;
                    bool _out808;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out809;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out806, out _out807, out _out808, out _out809);
                    _1362_recursiveGen = _out806;
                    _1363_recOwned = _out807;
                    _1364_recErased = _out808;
                    _1365_recIdents = _out809;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1362_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1363_recOwned;
                    isErased = _1364_recErased;
                    readIdents = _1365_recIdents;
                  }
                } else if (_source52.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1366___mcc_h758 = _source52.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1367_recursiveGen;
                    bool _1368_recOwned;
                    bool _1369_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1370_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out810;
                    bool _out811;
                    bool _out812;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out813;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out810, out _out811, out _out812, out _out813);
                    _1367_recursiveGen = _out810;
                    _1368_recOwned = _out811;
                    _1369_recErased = _out812;
                    _1370_recIdents = _out813;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1367_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1368_recOwned;
                    isErased = _1369_recErased;
                    readIdents = _1370_recIdents;
                  }
                } else {
                  DAST._IType _1371___mcc_h760 = _source52.dtor_Newtype_a0;
                  DAST._IType _1372_b = _1371___mcc_h760;
                  {
                    if (object.Equals(_533_fromTpe, _1372_b)) {
                      Dafny.ISequence<Dafny.Rune> _1373_recursiveGen;
                      bool _1374_recOwned;
                      bool _1375_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1376_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out814;
                      bool _out815;
                      bool _out816;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out817;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out814, out _out815, out _out816, out _out817);
                      _1373_recursiveGen = _out814;
                      _1374_recOwned = _out815;
                      _1375_recErased = _out816;
                      _1376_recIdents = _out817;
                      Dafny.ISequence<Dafny.Rune> _1377_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out818;
                      _out818 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _1377_rhsType = _out818;
                      Dafny.ISequence<Dafny.Rune> _1378_uneraseFn;
                      _1378_uneraseFn = ((_1374_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1377_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1378_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1373_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1374_recOwned;
                      isErased = false;
                      readIdents = _1376_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out819;
                      bool _out820;
                      bool _out821;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out822;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1372_b), _1372_b, _532_toTpe), selfIdent, @params, mustOwn, out _out819, out _out820, out _out821, out _out822);
                      s = _out819;
                      isOwned = _out820;
                      isErased = _out821;
                      readIdents = _out822;
                    }
                  }
                }
              } else if (_source51.is_Nullable) {
                DAST._IType _1379___mcc_h762 = _source51.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1380_recursiveGen;
                  bool _1381_recOwned;
                  bool _1382_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1383_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out823;
                  bool _out824;
                  bool _out825;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out826;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out823, out _out824, out _out825, out _out826);
                  _1380_recursiveGen = _out823;
                  _1381_recOwned = _out824;
                  _1382_recErased = _out825;
                  _1383_recIdents = _out826;
                  if (!(_1381_recOwned)) {
                    _1380_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1380_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1380_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1382_recErased;
                  readIdents = _1383_recIdents;
                }
              } else if (_source51.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1384___mcc_h764 = _source51.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1385_recursiveGen;
                  bool _1386_recOwned;
                  bool _1387_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1388_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out827;
                  bool _out828;
                  bool _out829;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out827, out _out828, out _out829, out _out830);
                  _1385_recursiveGen = _out827;
                  _1386_recOwned = _out828;
                  _1387_recErased = _out829;
                  _1388_recIdents = _out830;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1385_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1386_recOwned;
                  isErased = _1387_recErased;
                  readIdents = _1388_recIdents;
                }
              } else if (_source51.is_Array) {
                DAST._IType _1389___mcc_h766 = _source51.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1390_recursiveGen;
                  bool _1391_recOwned;
                  bool _1392_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1393_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out831;
                  bool _out832;
                  bool _out833;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                  _1390_recursiveGen = _out831;
                  _1391_recOwned = _out832;
                  _1392_recErased = _out833;
                  _1393_recIdents = _out834;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1390_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1391_recOwned;
                  isErased = _1392_recErased;
                  readIdents = _1393_recIdents;
                }
              } else if (_source51.is_Seq) {
                DAST._IType _1394___mcc_h768 = _source51.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1395_recursiveGen;
                  bool _1396_recOwned;
                  bool _1397_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1398_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out835;
                  bool _out836;
                  bool _out837;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                  _1395_recursiveGen = _out835;
                  _1396_recOwned = _out836;
                  _1397_recErased = _out837;
                  _1398_recIdents = _out838;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1395_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1396_recOwned;
                  isErased = _1397_recErased;
                  readIdents = _1398_recIdents;
                }
              } else if (_source51.is_Set) {
                DAST._IType _1399___mcc_h770 = _source51.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1400_recursiveGen;
                  bool _1401_recOwned;
                  bool _1402_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1403_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out839;
                  bool _out840;
                  bool _out841;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                  _1400_recursiveGen = _out839;
                  _1401_recOwned = _out840;
                  _1402_recErased = _out841;
                  _1403_recIdents = _out842;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1400_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1401_recOwned;
                  isErased = _1402_recErased;
                  readIdents = _1403_recIdents;
                }
              } else if (_source51.is_Multiset) {
                DAST._IType _1404___mcc_h772 = _source51.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1405_recursiveGen;
                  bool _1406_recOwned;
                  bool _1407_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1408_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out843;
                  bool _out844;
                  bool _out845;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                  _1405_recursiveGen = _out843;
                  _1406_recOwned = _out844;
                  _1407_recErased = _out845;
                  _1408_recIdents = _out846;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1405_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1406_recOwned;
                  isErased = _1407_recErased;
                  readIdents = _1408_recIdents;
                }
              } else if (_source51.is_Map) {
                DAST._IType _1409___mcc_h774 = _source51.dtor_key;
                DAST._IType _1410___mcc_h775 = _source51.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1411_recursiveGen;
                  bool _1412_recOwned;
                  bool _1413_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1414_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out847;
                  bool _out848;
                  bool _out849;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out850;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out847, out _out848, out _out849, out _out850);
                  _1411_recursiveGen = _out847;
                  _1412_recOwned = _out848;
                  _1413_recErased = _out849;
                  _1414_recIdents = _out850;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1411_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1412_recOwned;
                  isErased = _1413_recErased;
                  readIdents = _1414_recIdents;
                }
              } else if (_source51.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1415___mcc_h778 = _source51.dtor_args;
                DAST._IType _1416___mcc_h779 = _source51.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1417_recursiveGen;
                  bool _1418_recOwned;
                  bool _1419_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1420_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out851;
                  bool _out852;
                  bool _out853;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out854;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out851, out _out852, out _out853, out _out854);
                  _1417_recursiveGen = _out851;
                  _1418_recOwned = _out852;
                  _1419_recErased = _out853;
                  _1420_recIdents = _out854;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1417_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1418_recOwned;
                  isErased = _1419_recErased;
                  readIdents = _1420_recIdents;
                }
              } else if (_source51.is_Primitive) {
                DAST._IPrimitive _1421___mcc_h782 = _source51.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1422_recursiveGen;
                  bool _1423_recOwned;
                  bool _1424_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1425_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out855;
                  bool _out856;
                  bool _out857;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out858;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out855, out _out856, out _out857, out _out858);
                  _1422_recursiveGen = _out855;
                  _1423_recOwned = _out856;
                  _1424_recErased = _out857;
                  _1425_recIdents = _out858;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1422_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1423_recOwned;
                  isErased = _1424_recErased;
                  readIdents = _1425_recIdents;
                }
              } else if (_source51.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1426___mcc_h784 = _source51.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1427_recursiveGen;
                  bool _1428_recOwned;
                  bool _1429_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1430_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out859;
                  bool _out860;
                  bool _out861;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out862;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out859, out _out860, out _out861, out _out862);
                  _1427_recursiveGen = _out859;
                  _1428_recOwned = _out860;
                  _1429_recErased = _out861;
                  _1430_recIdents = _out862;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1427_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1428_recOwned;
                  isErased = _1429_recErased;
                  readIdents = _1430_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1431___mcc_h786 = _source51.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1432_recursiveGen;
                  bool _1433_recOwned;
                  bool _1434_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1435_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out863;
                  bool _out864;
                  bool _out865;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out866;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out863, out _out864, out _out865, out _out866);
                  _1432_recursiveGen = _out863;
                  _1433_recOwned = _out864;
                  _1434_recErased = _out865;
                  _1435_recIdents = _out866;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1432_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1433_recOwned;
                  isErased = _1434_recErased;
                  readIdents = _1435_recIdents;
                }
              }
            } else if (_source29.is_Primitive) {
              DAST._IPrimitive _1436___mcc_h788 = _source29.dtor_Primitive_a0;
              DAST._IPrimitive _source53 = _1436___mcc_h788;
              if (_source53.is_Int) {
                DAST._IType _source54 = _540___mcc_h265;
                if (_source54.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1437___mcc_h792 = _source54.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1438___mcc_h793 = _source54.dtor_typeArgs;
                  DAST._IResolvedType _1439___mcc_h794 = _source54.dtor_resolved;
                  DAST._IResolvedType _source55 = _1439___mcc_h794;
                  if (_source55.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1440___mcc_h798 = _source55.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1441_recursiveGen;
                      bool _1442_recOwned;
                      bool _1443_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1444_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out867;
                      bool _out868;
                      bool _out869;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out870;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out867, out _out868, out _out869, out _out870);
                      _1441_recursiveGen = _out867;
                      _1442_recOwned = _out868;
                      _1443_recErased = _out869;
                      _1444_recIdents = _out870;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1441_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1442_recOwned;
                      isErased = _1443_recErased;
                      readIdents = _1444_recIdents;
                    }
                  } else if (_source55.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1445___mcc_h800 = _source55.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1446_recursiveGen;
                      bool _1447_recOwned;
                      bool _1448_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1449_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out871;
                      bool _out872;
                      bool _out873;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out874;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out871, out _out872, out _out873, out _out874);
                      _1446_recursiveGen = _out871;
                      _1447_recOwned = _out872;
                      _1448_recErased = _out873;
                      _1449_recIdents = _out874;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1446_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1447_recOwned;
                      isErased = _1448_recErased;
                      readIdents = _1449_recIdents;
                    }
                  } else {
                    DAST._IType _1450___mcc_h802 = _source55.dtor_Newtype_a0;
                    DAST._IType _1451_b = _1450___mcc_h802;
                    {
                      if (object.Equals(_533_fromTpe, _1451_b)) {
                        Dafny.ISequence<Dafny.Rune> _1452_recursiveGen;
                        bool _1453_recOwned;
                        bool _1454_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1455_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out875;
                        bool _out876;
                        bool _out877;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out878;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out875, out _out876, out _out877, out _out878);
                        _1452_recursiveGen = _out875;
                        _1453_recOwned = _out876;
                        _1454_recErased = _out877;
                        _1455_recIdents = _out878;
                        Dafny.ISequence<Dafny.Rune> _1456_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out879;
                        _out879 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                        _1456_rhsType = _out879;
                        Dafny.ISequence<Dafny.Rune> _1457_uneraseFn;
                        _1457_uneraseFn = ((_1453_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1456_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1457_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1452_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1453_recOwned;
                        isErased = false;
                        readIdents = _1455_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out880;
                        bool _out881;
                        bool _out882;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1451_b), _1451_b, _532_toTpe), selfIdent, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                        s = _out880;
                        isOwned = _out881;
                        isErased = _out882;
                        readIdents = _out883;
                      }
                    }
                  }
                } else if (_source54.is_Nullable) {
                  DAST._IType _1458___mcc_h804 = _source54.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1459_recursiveGen;
                    bool _1460_recOwned;
                    bool _1461_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1462_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out884;
                    bool _out885;
                    bool _out886;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                    _1459_recursiveGen = _out884;
                    _1460_recOwned = _out885;
                    _1461_recErased = _out886;
                    _1462_recIdents = _out887;
                    if (!(_1460_recOwned)) {
                      _1459_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1459_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1459_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1461_recErased;
                    readIdents = _1462_recIdents;
                  }
                } else if (_source54.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1463___mcc_h806 = _source54.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1464_recursiveGen;
                    bool _1465_recOwned;
                    bool _1466_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1467_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out888;
                    bool _out889;
                    bool _out890;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                    _1464_recursiveGen = _out888;
                    _1465_recOwned = _out889;
                    _1466_recErased = _out890;
                    _1467_recIdents = _out891;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1464_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1465_recOwned;
                    isErased = _1466_recErased;
                    readIdents = _1467_recIdents;
                  }
                } else if (_source54.is_Array) {
                  DAST._IType _1468___mcc_h808 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1469_recursiveGen;
                    bool _1470_recOwned;
                    bool _1471_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1472_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out892;
                    bool _out893;
                    bool _out894;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                    _1469_recursiveGen = _out892;
                    _1470_recOwned = _out893;
                    _1471_recErased = _out894;
                    _1472_recIdents = _out895;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1469_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1470_recOwned;
                    isErased = _1471_recErased;
                    readIdents = _1472_recIdents;
                  }
                } else if (_source54.is_Seq) {
                  DAST._IType _1473___mcc_h810 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1474_recursiveGen;
                    bool _1475_recOwned;
                    bool _1476_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1477_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out896;
                    bool _out897;
                    bool _out898;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                    _1474_recursiveGen = _out896;
                    _1475_recOwned = _out897;
                    _1476_recErased = _out898;
                    _1477_recIdents = _out899;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1474_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1475_recOwned;
                    isErased = _1476_recErased;
                    readIdents = _1477_recIdents;
                  }
                } else if (_source54.is_Set) {
                  DAST._IType _1478___mcc_h812 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1479_recursiveGen;
                    bool _1480_recOwned;
                    bool _1481_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1482_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1479_recursiveGen = _out900;
                    _1480_recOwned = _out901;
                    _1481_recErased = _out902;
                    _1482_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1480_recOwned;
                    isErased = _1481_recErased;
                    readIdents = _1482_recIdents;
                  }
                } else if (_source54.is_Multiset) {
                  DAST._IType _1483___mcc_h814 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1484_recursiveGen;
                    bool _1485_recOwned;
                    bool _1486_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1487_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1484_recursiveGen = _out904;
                    _1485_recOwned = _out905;
                    _1486_recErased = _out906;
                    _1487_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1484_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1485_recOwned;
                    isErased = _1486_recErased;
                    readIdents = _1487_recIdents;
                  }
                } else if (_source54.is_Map) {
                  DAST._IType _1488___mcc_h816 = _source54.dtor_key;
                  DAST._IType _1489___mcc_h817 = _source54.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1490_recursiveGen;
                    bool _1491_recOwned;
                    bool _1492_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1493_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out908;
                    bool _out909;
                    bool _out910;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                    _1490_recursiveGen = _out908;
                    _1491_recOwned = _out909;
                    _1492_recErased = _out910;
                    _1493_recIdents = _out911;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1490_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1491_recOwned;
                    isErased = _1492_recErased;
                    readIdents = _1493_recIdents;
                  }
                } else if (_source54.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1494___mcc_h820 = _source54.dtor_args;
                  DAST._IType _1495___mcc_h821 = _source54.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1496_recursiveGen;
                    bool _1497_recOwned;
                    bool _1498_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1499_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out912;
                    bool _out913;
                    bool _out914;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out912, out _out913, out _out914, out _out915);
                    _1496_recursiveGen = _out912;
                    _1497_recOwned = _out913;
                    _1498_recErased = _out914;
                    _1499_recIdents = _out915;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1496_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1497_recOwned;
                    isErased = _1498_recErased;
                    readIdents = _1499_recIdents;
                  }
                } else if (_source54.is_Primitive) {
                  DAST._IPrimitive _1500___mcc_h824 = _source54.dtor_Primitive_a0;
                  DAST._IPrimitive _source56 = _1500___mcc_h824;
                  if (_source56.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1501_recursiveGen;
                      bool _1502_recOwned;
                      bool _1503_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1504_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out916;
                      bool _out917;
                      bool _out918;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                      _1501_recursiveGen = _out916;
                      _1502_recOwned = _out917;
                      _1503_recErased = _out918;
                      _1504_recIdents = _out919;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1501_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1502_recOwned;
                      isErased = _1503_recErased;
                      readIdents = _1504_recIdents;
                    }
                  } else if (_source56.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1505_recursiveGen;
                      bool _1506___v47;
                      bool _1507___v48;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1508_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out920;
                      bool _out921;
                      bool _out922;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, true, out _out920, out _out921, out _out922, out _out923);
                      _1505_recursiveGen = _out920;
                      _1506___v47 = _out921;
                      _1507___v48 = _out922;
                      _1508_recIdents = _out923;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1505_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1508_recIdents;
                    }
                  } else if (_source56.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1509_recursiveGen;
                      bool _1510_recOwned;
                      bool _1511_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1512_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out924;
                      bool _out925;
                      bool _out926;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out927;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out924, out _out925, out _out926, out _out927);
                      _1509_recursiveGen = _out924;
                      _1510_recOwned = _out925;
                      _1511_recErased = _out926;
                      _1512_recIdents = _out927;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1509_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1510_recOwned;
                      isErased = _1511_recErased;
                      readIdents = _1512_recIdents;
                    }
                  } else if (_source56.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1513_recursiveGen;
                      bool _1514_recOwned;
                      bool _1515_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1516_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out928;
                      bool _out929;
                      bool _out930;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out931;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out928, out _out929, out _out930, out _out931);
                      _1513_recursiveGen = _out928;
                      _1514_recOwned = _out929;
                      _1515_recErased = _out930;
                      _1516_recIdents = _out931;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1513_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1514_recOwned;
                      isErased = _1515_recErased;
                      readIdents = _1516_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1517_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out932;
                      _out932 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _1517_rhsType = _out932;
                      Dafny.ISequence<Dafny.Rune> _1518_recursiveGen;
                      bool _1519___v57;
                      bool _1520___v58;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1521_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out933;
                      bool _out934;
                      bool _out935;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, true, out _out933, out _out934, out _out935, out _out936);
                      _1518_recursiveGen = _out933;
                      _1519___v57 = _out934;
                      _1520___v58 = _out935;
                      _1521_recIdents = _out936;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1518_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1521_recIdents;
                    }
                  }
                } else if (_source54.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1522___mcc_h826 = _source54.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1523_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out937;
                    _out937 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                    _1523_rhsType = _out937;
                    Dafny.ISequence<Dafny.Rune> _1524_recursiveGen;
                    bool _1525___v52;
                    bool _1526___v53;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1527_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out938;
                    bool _out939;
                    bool _out940;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out941;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, true, out _out938, out _out939, out _out940, out _out941);
                    _1524_recursiveGen = _out938;
                    _1525___v52 = _out939;
                    _1526___v53 = _out940;
                    _1527_recIdents = _out941;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1523_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1524_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1527_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1528___mcc_h828 = _source54.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1529_recursiveGen;
                    bool _1530_recOwned;
                    bool _1531_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1532_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out942;
                    bool _out943;
                    bool _out944;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out945;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out942, out _out943, out _out944, out _out945);
                    _1529_recursiveGen = _out942;
                    _1530_recOwned = _out943;
                    _1531_recErased = _out944;
                    _1532_recIdents = _out945;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1529_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1530_recOwned;
                    isErased = _1531_recErased;
                    readIdents = _1532_recIdents;
                  }
                }
              } else if (_source53.is_Real) {
                DAST._IType _source57 = _540___mcc_h265;
                if (_source57.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1533___mcc_h830 = _source57.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1534___mcc_h831 = _source57.dtor_typeArgs;
                  DAST._IResolvedType _1535___mcc_h832 = _source57.dtor_resolved;
                  DAST._IResolvedType _source58 = _1535___mcc_h832;
                  if (_source58.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1536___mcc_h836 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1537_recursiveGen;
                      bool _1538_recOwned;
                      bool _1539_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1540_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out946;
                      bool _out947;
                      bool _out948;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out949;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out946, out _out947, out _out948, out _out949);
                      _1537_recursiveGen = _out946;
                      _1538_recOwned = _out947;
                      _1539_recErased = _out948;
                      _1540_recIdents = _out949;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1537_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1538_recOwned;
                      isErased = _1539_recErased;
                      readIdents = _1540_recIdents;
                    }
                  } else if (_source58.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1541___mcc_h838 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1542_recursiveGen;
                      bool _1543_recOwned;
                      bool _1544_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1545_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out950;
                      bool _out951;
                      bool _out952;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out953;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out950, out _out951, out _out952, out _out953);
                      _1542_recursiveGen = _out950;
                      _1543_recOwned = _out951;
                      _1544_recErased = _out952;
                      _1545_recIdents = _out953;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1542_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1543_recOwned;
                      isErased = _1544_recErased;
                      readIdents = _1545_recIdents;
                    }
                  } else {
                    DAST._IType _1546___mcc_h840 = _source58.dtor_Newtype_a0;
                    DAST._IType _1547_b = _1546___mcc_h840;
                    {
                      if (object.Equals(_533_fromTpe, _1547_b)) {
                        Dafny.ISequence<Dafny.Rune> _1548_recursiveGen;
                        bool _1549_recOwned;
                        bool _1550_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1551_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out954;
                        bool _out955;
                        bool _out956;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out957;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out954, out _out955, out _out956, out _out957);
                        _1548_recursiveGen = _out954;
                        _1549_recOwned = _out955;
                        _1550_recErased = _out956;
                        _1551_recIdents = _out957;
                        Dafny.ISequence<Dafny.Rune> _1552_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out958;
                        _out958 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                        _1552_rhsType = _out958;
                        Dafny.ISequence<Dafny.Rune> _1553_uneraseFn;
                        _1553_uneraseFn = ((_1549_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1552_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1553_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1548_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1549_recOwned;
                        isErased = false;
                        readIdents = _1551_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out959;
                        bool _out960;
                        bool _out961;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out962;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1547_b), _1547_b, _532_toTpe), selfIdent, @params, mustOwn, out _out959, out _out960, out _out961, out _out962);
                        s = _out959;
                        isOwned = _out960;
                        isErased = _out961;
                        readIdents = _out962;
                      }
                    }
                  }
                } else if (_source57.is_Nullable) {
                  DAST._IType _1554___mcc_h842 = _source57.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1555_recursiveGen;
                    bool _1556_recOwned;
                    bool _1557_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1558_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out963;
                    bool _out964;
                    bool _out965;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out966;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out963, out _out964, out _out965, out _out966);
                    _1555_recursiveGen = _out963;
                    _1556_recOwned = _out964;
                    _1557_recErased = _out965;
                    _1558_recIdents = _out966;
                    if (!(_1556_recOwned)) {
                      _1555_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1555_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1555_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1557_recErased;
                    readIdents = _1558_recIdents;
                  }
                } else if (_source57.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1559___mcc_h844 = _source57.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1560_recursiveGen;
                    bool _1561_recOwned;
                    bool _1562_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1563_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out967;
                    bool _out968;
                    bool _out969;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out970;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out967, out _out968, out _out969, out _out970);
                    _1560_recursiveGen = _out967;
                    _1561_recOwned = _out968;
                    _1562_recErased = _out969;
                    _1563_recIdents = _out970;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1561_recOwned;
                    isErased = _1562_recErased;
                    readIdents = _1563_recIdents;
                  }
                } else if (_source57.is_Array) {
                  DAST._IType _1564___mcc_h846 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1565_recursiveGen;
                    bool _1566_recOwned;
                    bool _1567_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1568_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out971;
                    bool _out972;
                    bool _out973;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out974;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out971, out _out972, out _out973, out _out974);
                    _1565_recursiveGen = _out971;
                    _1566_recOwned = _out972;
                    _1567_recErased = _out973;
                    _1568_recIdents = _out974;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1565_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1566_recOwned;
                    isErased = _1567_recErased;
                    readIdents = _1568_recIdents;
                  }
                } else if (_source57.is_Seq) {
                  DAST._IType _1569___mcc_h848 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1570_recursiveGen;
                    bool _1571_recOwned;
                    bool _1572_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1573_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out975;
                    bool _out976;
                    bool _out977;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out978;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out975, out _out976, out _out977, out _out978);
                    _1570_recursiveGen = _out975;
                    _1571_recOwned = _out976;
                    _1572_recErased = _out977;
                    _1573_recIdents = _out978;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1570_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1571_recOwned;
                    isErased = _1572_recErased;
                    readIdents = _1573_recIdents;
                  }
                } else if (_source57.is_Set) {
                  DAST._IType _1574___mcc_h850 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1575_recursiveGen;
                    bool _1576_recOwned;
                    bool _1577_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1578_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out979;
                    bool _out980;
                    bool _out981;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out982;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out979, out _out980, out _out981, out _out982);
                    _1575_recursiveGen = _out979;
                    _1576_recOwned = _out980;
                    _1577_recErased = _out981;
                    _1578_recIdents = _out982;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1575_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1576_recOwned;
                    isErased = _1577_recErased;
                    readIdents = _1578_recIdents;
                  }
                } else if (_source57.is_Multiset) {
                  DAST._IType _1579___mcc_h852 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1580_recursiveGen;
                    bool _1581_recOwned;
                    bool _1582_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1583_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out983;
                    bool _out984;
                    bool _out985;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out986;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out983, out _out984, out _out985, out _out986);
                    _1580_recursiveGen = _out983;
                    _1581_recOwned = _out984;
                    _1582_recErased = _out985;
                    _1583_recIdents = _out986;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1580_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1581_recOwned;
                    isErased = _1582_recErased;
                    readIdents = _1583_recIdents;
                  }
                } else if (_source57.is_Map) {
                  DAST._IType _1584___mcc_h854 = _source57.dtor_key;
                  DAST._IType _1585___mcc_h855 = _source57.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1586_recursiveGen;
                    bool _1587_recOwned;
                    bool _1588_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1589_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out987;
                    bool _out988;
                    bool _out989;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out990;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out987, out _out988, out _out989, out _out990);
                    _1586_recursiveGen = _out987;
                    _1587_recOwned = _out988;
                    _1588_recErased = _out989;
                    _1589_recIdents = _out990;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1586_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1587_recOwned;
                    isErased = _1588_recErased;
                    readIdents = _1589_recIdents;
                  }
                } else if (_source57.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1590___mcc_h858 = _source57.dtor_args;
                  DAST._IType _1591___mcc_h859 = _source57.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1592_recursiveGen;
                    bool _1593_recOwned;
                    bool _1594_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1595_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out991;
                    bool _out992;
                    bool _out993;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out994;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out991, out _out992, out _out993, out _out994);
                    _1592_recursiveGen = _out991;
                    _1593_recOwned = _out992;
                    _1594_recErased = _out993;
                    _1595_recIdents = _out994;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1592_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1593_recOwned;
                    isErased = _1594_recErased;
                    readIdents = _1595_recIdents;
                  }
                } else if (_source57.is_Primitive) {
                  DAST._IPrimitive _1596___mcc_h862 = _source57.dtor_Primitive_a0;
                  DAST._IPrimitive _source59 = _1596___mcc_h862;
                  if (_source59.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1597_recursiveGen;
                      bool _1598___v49;
                      bool _1599___v50;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1600_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out995;
                      bool _out996;
                      bool _out997;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out998;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, false, out _out995, out _out996, out _out997, out _out998);
                      _1597_recursiveGen = _out995;
                      _1598___v49 = _out996;
                      _1599___v50 = _out997;
                      _1600_recIdents = _out998;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1597_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1600_recIdents;
                    }
                  } else if (_source59.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1601_recursiveGen;
                      bool _1602_recOwned;
                      bool _1603_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1604_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out999;
                      bool _out1000;
                      bool _out1001;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1002;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out999, out _out1000, out _out1001, out _out1002);
                      _1601_recursiveGen = _out999;
                      _1602_recOwned = _out1000;
                      _1603_recErased = _out1001;
                      _1604_recIdents = _out1002;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1601_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1602_recOwned;
                      isErased = _1603_recErased;
                      readIdents = _1604_recIdents;
                    }
                  } else if (_source59.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1605_recursiveGen;
                      bool _1606_recOwned;
                      bool _1607_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1608_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1003;
                      bool _out1004;
                      bool _out1005;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1006;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1003, out _out1004, out _out1005, out _out1006);
                      _1605_recursiveGen = _out1003;
                      _1606_recOwned = _out1004;
                      _1607_recErased = _out1005;
                      _1608_recIdents = _out1006;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1605_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1606_recOwned;
                      isErased = _1607_recErased;
                      readIdents = _1608_recIdents;
                    }
                  } else if (_source59.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1609_recursiveGen;
                      bool _1610_recOwned;
                      bool _1611_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1612_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1007;
                      bool _out1008;
                      bool _out1009;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1010;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1007, out _out1008, out _out1009, out _out1010);
                      _1609_recursiveGen = _out1007;
                      _1610_recOwned = _out1008;
                      _1611_recErased = _out1009;
                      _1612_recIdents = _out1010;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1610_recOwned;
                      isErased = _1611_recErased;
                      readIdents = _1612_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1613_recursiveGen;
                      bool _1614_recOwned;
                      bool _1615_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1616_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1011;
                      bool _out1012;
                      bool _out1013;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1014;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1011, out _out1012, out _out1013, out _out1014);
                      _1613_recursiveGen = _out1011;
                      _1614_recOwned = _out1012;
                      _1615_recErased = _out1013;
                      _1616_recIdents = _out1014;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1614_recOwned;
                      isErased = _1615_recErased;
                      readIdents = _1616_recIdents;
                    }
                  }
                } else if (_source57.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1617___mcc_h864 = _source57.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1618_recursiveGen;
                    bool _1619_recOwned;
                    bool _1620_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1621_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1015;
                    bool _out1016;
                    bool _out1017;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1018;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1015, out _out1016, out _out1017, out _out1018);
                    _1618_recursiveGen = _out1015;
                    _1619_recOwned = _out1016;
                    _1620_recErased = _out1017;
                    _1621_recIdents = _out1018;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1618_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1619_recOwned;
                    isErased = _1620_recErased;
                    readIdents = _1621_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1622___mcc_h866 = _source57.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1623_recursiveGen;
                    bool _1624_recOwned;
                    bool _1625_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1626_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1019;
                    bool _out1020;
                    bool _out1021;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1022;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1019, out _out1020, out _out1021, out _out1022);
                    _1623_recursiveGen = _out1019;
                    _1624_recOwned = _out1020;
                    _1625_recErased = _out1021;
                    _1626_recIdents = _out1022;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1623_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1624_recOwned;
                    isErased = _1625_recErased;
                    readIdents = _1626_recIdents;
                  }
                }
              } else if (_source53.is_String) {
                DAST._IType _source60 = _540___mcc_h265;
                if (_source60.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1627___mcc_h868 = _source60.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1628___mcc_h869 = _source60.dtor_typeArgs;
                  DAST._IResolvedType _1629___mcc_h870 = _source60.dtor_resolved;
                  DAST._IResolvedType _source61 = _1629___mcc_h870;
                  if (_source61.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1630___mcc_h874 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1631_recursiveGen;
                      bool _1632_recOwned;
                      bool _1633_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1634_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1023;
                      bool _out1024;
                      bool _out1025;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1026;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1023, out _out1024, out _out1025, out _out1026);
                      _1631_recursiveGen = _out1023;
                      _1632_recOwned = _out1024;
                      _1633_recErased = _out1025;
                      _1634_recIdents = _out1026;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1631_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1632_recOwned;
                      isErased = _1633_recErased;
                      readIdents = _1634_recIdents;
                    }
                  } else if (_source61.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1635___mcc_h876 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1636_recursiveGen;
                      bool _1637_recOwned;
                      bool _1638_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1639_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1027;
                      bool _out1028;
                      bool _out1029;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1030;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1027, out _out1028, out _out1029, out _out1030);
                      _1636_recursiveGen = _out1027;
                      _1637_recOwned = _out1028;
                      _1638_recErased = _out1029;
                      _1639_recIdents = _out1030;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1636_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1637_recOwned;
                      isErased = _1638_recErased;
                      readIdents = _1639_recIdents;
                    }
                  } else {
                    DAST._IType _1640___mcc_h878 = _source61.dtor_Newtype_a0;
                    DAST._IType _1641_b = _1640___mcc_h878;
                    {
                      if (object.Equals(_533_fromTpe, _1641_b)) {
                        Dafny.ISequence<Dafny.Rune> _1642_recursiveGen;
                        bool _1643_recOwned;
                        bool _1644_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1645_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1031;
                        bool _out1032;
                        bool _out1033;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1034;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1031, out _out1032, out _out1033, out _out1034);
                        _1642_recursiveGen = _out1031;
                        _1643_recOwned = _out1032;
                        _1644_recErased = _out1033;
                        _1645_recIdents = _out1034;
                        Dafny.ISequence<Dafny.Rune> _1646_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1035;
                        _out1035 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                        _1646_rhsType = _out1035;
                        Dafny.ISequence<Dafny.Rune> _1647_uneraseFn;
                        _1647_uneraseFn = ((_1643_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1646_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1647_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1642_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1643_recOwned;
                        isErased = false;
                        readIdents = _1645_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1036;
                        bool _out1037;
                        bool _out1038;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1039;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1641_b), _1641_b, _532_toTpe), selfIdent, @params, mustOwn, out _out1036, out _out1037, out _out1038, out _out1039);
                        s = _out1036;
                        isOwned = _out1037;
                        isErased = _out1038;
                        readIdents = _out1039;
                      }
                    }
                  }
                } else if (_source60.is_Nullable) {
                  DAST._IType _1648___mcc_h880 = _source60.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1649_recursiveGen;
                    bool _1650_recOwned;
                    bool _1651_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1652_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1040;
                    bool _out1041;
                    bool _out1042;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1043;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1040, out _out1041, out _out1042, out _out1043);
                    _1649_recursiveGen = _out1040;
                    _1650_recOwned = _out1041;
                    _1651_recErased = _out1042;
                    _1652_recIdents = _out1043;
                    if (!(_1650_recOwned)) {
                      _1649_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1649_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1649_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1651_recErased;
                    readIdents = _1652_recIdents;
                  }
                } else if (_source60.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1653___mcc_h882 = _source60.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1654_recursiveGen;
                    bool _1655_recOwned;
                    bool _1656_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1657_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1044;
                    bool _out1045;
                    bool _out1046;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1047;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1044, out _out1045, out _out1046, out _out1047);
                    _1654_recursiveGen = _out1044;
                    _1655_recOwned = _out1045;
                    _1656_recErased = _out1046;
                    _1657_recIdents = _out1047;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1654_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1655_recOwned;
                    isErased = _1656_recErased;
                    readIdents = _1657_recIdents;
                  }
                } else if (_source60.is_Array) {
                  DAST._IType _1658___mcc_h884 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1659_recursiveGen;
                    bool _1660_recOwned;
                    bool _1661_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1662_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1048;
                    bool _out1049;
                    bool _out1050;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1051;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1048, out _out1049, out _out1050, out _out1051);
                    _1659_recursiveGen = _out1048;
                    _1660_recOwned = _out1049;
                    _1661_recErased = _out1050;
                    _1662_recIdents = _out1051;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1659_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1660_recOwned;
                    isErased = _1661_recErased;
                    readIdents = _1662_recIdents;
                  }
                } else if (_source60.is_Seq) {
                  DAST._IType _1663___mcc_h886 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1664_recursiveGen;
                    bool _1665_recOwned;
                    bool _1666_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1667_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1052;
                    bool _out1053;
                    bool _out1054;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1055;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1052, out _out1053, out _out1054, out _out1055);
                    _1664_recursiveGen = _out1052;
                    _1665_recOwned = _out1053;
                    _1666_recErased = _out1054;
                    _1667_recIdents = _out1055;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1664_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1665_recOwned;
                    isErased = _1666_recErased;
                    readIdents = _1667_recIdents;
                  }
                } else if (_source60.is_Set) {
                  DAST._IType _1668___mcc_h888 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1669_recursiveGen;
                    bool _1670_recOwned;
                    bool _1671_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1672_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1056;
                    bool _out1057;
                    bool _out1058;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1059;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1056, out _out1057, out _out1058, out _out1059);
                    _1669_recursiveGen = _out1056;
                    _1670_recOwned = _out1057;
                    _1671_recErased = _out1058;
                    _1672_recIdents = _out1059;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1669_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1670_recOwned;
                    isErased = _1671_recErased;
                    readIdents = _1672_recIdents;
                  }
                } else if (_source60.is_Multiset) {
                  DAST._IType _1673___mcc_h890 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1674_recursiveGen;
                    bool _1675_recOwned;
                    bool _1676_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1677_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1060;
                    bool _out1061;
                    bool _out1062;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1063;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1060, out _out1061, out _out1062, out _out1063);
                    _1674_recursiveGen = _out1060;
                    _1675_recOwned = _out1061;
                    _1676_recErased = _out1062;
                    _1677_recIdents = _out1063;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1674_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1675_recOwned;
                    isErased = _1676_recErased;
                    readIdents = _1677_recIdents;
                  }
                } else if (_source60.is_Map) {
                  DAST._IType _1678___mcc_h892 = _source60.dtor_key;
                  DAST._IType _1679___mcc_h893 = _source60.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1680_recursiveGen;
                    bool _1681_recOwned;
                    bool _1682_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1683_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1064;
                    bool _out1065;
                    bool _out1066;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1067;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1064, out _out1065, out _out1066, out _out1067);
                    _1680_recursiveGen = _out1064;
                    _1681_recOwned = _out1065;
                    _1682_recErased = _out1066;
                    _1683_recIdents = _out1067;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1680_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1681_recOwned;
                    isErased = _1682_recErased;
                    readIdents = _1683_recIdents;
                  }
                } else if (_source60.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1684___mcc_h896 = _source60.dtor_args;
                  DAST._IType _1685___mcc_h897 = _source60.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1686_recursiveGen;
                    bool _1687_recOwned;
                    bool _1688_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1689_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1068;
                    bool _out1069;
                    bool _out1070;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1068, out _out1069, out _out1070, out _out1071);
                    _1686_recursiveGen = _out1068;
                    _1687_recOwned = _out1069;
                    _1688_recErased = _out1070;
                    _1689_recIdents = _out1071;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1686_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1687_recOwned;
                    isErased = _1688_recErased;
                    readIdents = _1689_recIdents;
                  }
                } else if (_source60.is_Primitive) {
                  DAST._IPrimitive _1690___mcc_h900 = _source60.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1691_recursiveGen;
                    bool _1692_recOwned;
                    bool _1693_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1694_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1072;
                    bool _out1073;
                    bool _out1074;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                    _1691_recursiveGen = _out1072;
                    _1692_recOwned = _out1073;
                    _1693_recErased = _out1074;
                    _1694_recIdents = _out1075;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1691_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1692_recOwned;
                    isErased = _1693_recErased;
                    readIdents = _1694_recIdents;
                  }
                } else if (_source60.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1695___mcc_h902 = _source60.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1696_recursiveGen;
                    bool _1697_recOwned;
                    bool _1698_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1699_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1076;
                    bool _out1077;
                    bool _out1078;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                    _1696_recursiveGen = _out1076;
                    _1697_recOwned = _out1077;
                    _1698_recErased = _out1078;
                    _1699_recIdents = _out1079;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1696_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1697_recOwned;
                    isErased = _1698_recErased;
                    readIdents = _1699_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1700___mcc_h904 = _source60.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1701_recursiveGen;
                    bool _1702_recOwned;
                    bool _1703_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1704_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1080;
                    bool _out1081;
                    bool _out1082;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                    _1701_recursiveGen = _out1080;
                    _1702_recOwned = _out1081;
                    _1703_recErased = _out1082;
                    _1704_recIdents = _out1083;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1701_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1702_recOwned;
                    isErased = _1703_recErased;
                    readIdents = _1704_recIdents;
                  }
                }
              } else if (_source53.is_Bool) {
                DAST._IType _source62 = _540___mcc_h265;
                if (_source62.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1705___mcc_h906 = _source62.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1706___mcc_h907 = _source62.dtor_typeArgs;
                  DAST._IResolvedType _1707___mcc_h908 = _source62.dtor_resolved;
                  DAST._IResolvedType _source63 = _1707___mcc_h908;
                  if (_source63.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1708___mcc_h912 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1709_recursiveGen;
                      bool _1710_recOwned;
                      bool _1711_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1712_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1084;
                      bool _out1085;
                      bool _out1086;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                      _1709_recursiveGen = _out1084;
                      _1710_recOwned = _out1085;
                      _1711_recErased = _out1086;
                      _1712_recIdents = _out1087;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1709_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1710_recOwned;
                      isErased = _1711_recErased;
                      readIdents = _1712_recIdents;
                    }
                  } else if (_source63.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1713___mcc_h914 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1714_recursiveGen;
                      bool _1715_recOwned;
                      bool _1716_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1717_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1088;
                      bool _out1089;
                      bool _out1090;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1091;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1088, out _out1089, out _out1090, out _out1091);
                      _1714_recursiveGen = _out1088;
                      _1715_recOwned = _out1089;
                      _1716_recErased = _out1090;
                      _1717_recIdents = _out1091;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1714_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1715_recOwned;
                      isErased = _1716_recErased;
                      readIdents = _1717_recIdents;
                    }
                  } else {
                    DAST._IType _1718___mcc_h916 = _source63.dtor_Newtype_a0;
                    DAST._IType _1719_b = _1718___mcc_h916;
                    {
                      if (object.Equals(_533_fromTpe, _1719_b)) {
                        Dafny.ISequence<Dafny.Rune> _1720_recursiveGen;
                        bool _1721_recOwned;
                        bool _1722_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1723_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1092;
                        bool _out1093;
                        bool _out1094;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1095;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1092, out _out1093, out _out1094, out _out1095);
                        _1720_recursiveGen = _out1092;
                        _1721_recOwned = _out1093;
                        _1722_recErased = _out1094;
                        _1723_recIdents = _out1095;
                        Dafny.ISequence<Dafny.Rune> _1724_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1096;
                        _out1096 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                        _1724_rhsType = _out1096;
                        Dafny.ISequence<Dafny.Rune> _1725_uneraseFn;
                        _1725_uneraseFn = ((_1721_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1724_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1725_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1720_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1721_recOwned;
                        isErased = false;
                        readIdents = _1723_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1097;
                        bool _out1098;
                        bool _out1099;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1100;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1719_b), _1719_b, _532_toTpe), selfIdent, @params, mustOwn, out _out1097, out _out1098, out _out1099, out _out1100);
                        s = _out1097;
                        isOwned = _out1098;
                        isErased = _out1099;
                        readIdents = _out1100;
                      }
                    }
                  }
                } else if (_source62.is_Nullable) {
                  DAST._IType _1726___mcc_h918 = _source62.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1727_recursiveGen;
                    bool _1728_recOwned;
                    bool _1729_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1730_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1101;
                    bool _out1102;
                    bool _out1103;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1104;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1101, out _out1102, out _out1103, out _out1104);
                    _1727_recursiveGen = _out1101;
                    _1728_recOwned = _out1102;
                    _1729_recErased = _out1103;
                    _1730_recIdents = _out1104;
                    if (!(_1728_recOwned)) {
                      _1727_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1727_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1727_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1729_recErased;
                    readIdents = _1730_recIdents;
                  }
                } else if (_source62.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1731___mcc_h920 = _source62.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1732_recursiveGen;
                    bool _1733_recOwned;
                    bool _1734_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1735_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1105;
                    bool _out1106;
                    bool _out1107;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1108;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1105, out _out1106, out _out1107, out _out1108);
                    _1732_recursiveGen = _out1105;
                    _1733_recOwned = _out1106;
                    _1734_recErased = _out1107;
                    _1735_recIdents = _out1108;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1732_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1733_recOwned;
                    isErased = _1734_recErased;
                    readIdents = _1735_recIdents;
                  }
                } else if (_source62.is_Array) {
                  DAST._IType _1736___mcc_h922 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1737_recursiveGen;
                    bool _1738_recOwned;
                    bool _1739_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1740_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1109;
                    bool _out1110;
                    bool _out1111;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                    _1737_recursiveGen = _out1109;
                    _1738_recOwned = _out1110;
                    _1739_recErased = _out1111;
                    _1740_recIdents = _out1112;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1737_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1738_recOwned;
                    isErased = _1739_recErased;
                    readIdents = _1740_recIdents;
                  }
                } else if (_source62.is_Seq) {
                  DAST._IType _1741___mcc_h924 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1742_recursiveGen;
                    bool _1743_recOwned;
                    bool _1744_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1745_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1113;
                    bool _out1114;
                    bool _out1115;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                    _1742_recursiveGen = _out1113;
                    _1743_recOwned = _out1114;
                    _1744_recErased = _out1115;
                    _1745_recIdents = _out1116;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1742_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1743_recOwned;
                    isErased = _1744_recErased;
                    readIdents = _1745_recIdents;
                  }
                } else if (_source62.is_Set) {
                  DAST._IType _1746___mcc_h926 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1747_recursiveGen;
                    bool _1748_recOwned;
                    bool _1749_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1750_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1117;
                    bool _out1118;
                    bool _out1119;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                    _1747_recursiveGen = _out1117;
                    _1748_recOwned = _out1118;
                    _1749_recErased = _out1119;
                    _1750_recIdents = _out1120;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1747_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1748_recOwned;
                    isErased = _1749_recErased;
                    readIdents = _1750_recIdents;
                  }
                } else if (_source62.is_Multiset) {
                  DAST._IType _1751___mcc_h928 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1752_recursiveGen;
                    bool _1753_recOwned;
                    bool _1754_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1755_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1121;
                    bool _out1122;
                    bool _out1123;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                    _1752_recursiveGen = _out1121;
                    _1753_recOwned = _out1122;
                    _1754_recErased = _out1123;
                    _1755_recIdents = _out1124;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1752_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1753_recOwned;
                    isErased = _1754_recErased;
                    readIdents = _1755_recIdents;
                  }
                } else if (_source62.is_Map) {
                  DAST._IType _1756___mcc_h930 = _source62.dtor_key;
                  DAST._IType _1757___mcc_h931 = _source62.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1758_recursiveGen;
                    bool _1759_recOwned;
                    bool _1760_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1761_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1125;
                    bool _out1126;
                    bool _out1127;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                    _1758_recursiveGen = _out1125;
                    _1759_recOwned = _out1126;
                    _1760_recErased = _out1127;
                    _1761_recIdents = _out1128;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1758_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1759_recOwned;
                    isErased = _1760_recErased;
                    readIdents = _1761_recIdents;
                  }
                } else if (_source62.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1762___mcc_h934 = _source62.dtor_args;
                  DAST._IType _1763___mcc_h935 = _source62.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1764_recursiveGen;
                    bool _1765_recOwned;
                    bool _1766_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1767_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1129;
                    bool _out1130;
                    bool _out1131;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                    _1764_recursiveGen = _out1129;
                    _1765_recOwned = _out1130;
                    _1766_recErased = _out1131;
                    _1767_recIdents = _out1132;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1764_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1765_recOwned;
                    isErased = _1766_recErased;
                    readIdents = _1767_recIdents;
                  }
                } else if (_source62.is_Primitive) {
                  DAST._IPrimitive _1768___mcc_h938 = _source62.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1769_recursiveGen;
                    bool _1770_recOwned;
                    bool _1771_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1772_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1133;
                    bool _out1134;
                    bool _out1135;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                    _1769_recursiveGen = _out1133;
                    _1770_recOwned = _out1134;
                    _1771_recErased = _out1135;
                    _1772_recIdents = _out1136;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1769_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1770_recOwned;
                    isErased = _1771_recErased;
                    readIdents = _1772_recIdents;
                  }
                } else if (_source62.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1773___mcc_h940 = _source62.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1774_recursiveGen;
                    bool _1775_recOwned;
                    bool _1776_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1777_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1137;
                    bool _out1138;
                    bool _out1139;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                    _1774_recursiveGen = _out1137;
                    _1775_recOwned = _out1138;
                    _1776_recErased = _out1139;
                    _1777_recIdents = _out1140;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1774_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1775_recOwned;
                    isErased = _1776_recErased;
                    readIdents = _1777_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1778___mcc_h942 = _source62.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1779_recursiveGen;
                    bool _1780_recOwned;
                    bool _1781_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1782_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1141;
                    bool _out1142;
                    bool _out1143;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1144;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1141, out _out1142, out _out1143, out _out1144);
                    _1779_recursiveGen = _out1141;
                    _1780_recOwned = _out1142;
                    _1781_recErased = _out1143;
                    _1782_recIdents = _out1144;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1779_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1780_recOwned;
                    isErased = _1781_recErased;
                    readIdents = _1782_recIdents;
                  }
                }
              } else {
                DAST._IType _source64 = _540___mcc_h265;
                if (_source64.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1783___mcc_h944 = _source64.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1784___mcc_h945 = _source64.dtor_typeArgs;
                  DAST._IResolvedType _1785___mcc_h946 = _source64.dtor_resolved;
                  DAST._IResolvedType _source65 = _1785___mcc_h946;
                  if (_source65.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1786___mcc_h950 = _source65.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1787_recursiveGen;
                      bool _1788_recOwned;
                      bool _1789_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1790_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1145;
                      bool _out1146;
                      bool _out1147;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1148;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1145, out _out1146, out _out1147, out _out1148);
                      _1787_recursiveGen = _out1145;
                      _1788_recOwned = _out1146;
                      _1789_recErased = _out1147;
                      _1790_recIdents = _out1148;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1787_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1788_recOwned;
                      isErased = _1789_recErased;
                      readIdents = _1790_recIdents;
                    }
                  } else if (_source65.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1791___mcc_h952 = _source65.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1792_recursiveGen;
                      bool _1793_recOwned;
                      bool _1794_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1795_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1149;
                      bool _out1150;
                      bool _out1151;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1152;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1149, out _out1150, out _out1151, out _out1152);
                      _1792_recursiveGen = _out1149;
                      _1793_recOwned = _out1150;
                      _1794_recErased = _out1151;
                      _1795_recIdents = _out1152;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1792_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1793_recOwned;
                      isErased = _1794_recErased;
                      readIdents = _1795_recIdents;
                    }
                  } else {
                    DAST._IType _1796___mcc_h954 = _source65.dtor_Newtype_a0;
                    DAST._IType _1797_b = _1796___mcc_h954;
                    {
                      if (object.Equals(_533_fromTpe, _1797_b)) {
                        Dafny.ISequence<Dafny.Rune> _1798_recursiveGen;
                        bool _1799_recOwned;
                        bool _1800_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1801_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1153;
                        bool _out1154;
                        bool _out1155;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1156;
                        DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1153, out _out1154, out _out1155, out _out1156);
                        _1798_recursiveGen = _out1153;
                        _1799_recOwned = _out1154;
                        _1800_recErased = _out1155;
                        _1801_recIdents = _out1156;
                        Dafny.ISequence<Dafny.Rune> _1802_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1157;
                        _out1157 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                        _1802_rhsType = _out1157;
                        Dafny.ISequence<Dafny.Rune> _1803_uneraseFn;
                        _1803_uneraseFn = ((_1799_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1802_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1803_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1798_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1799_recOwned;
                        isErased = false;
                        readIdents = _1801_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1158;
                        bool _out1159;
                        bool _out1160;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1797_b), _1797_b, _532_toTpe), selfIdent, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                        s = _out1158;
                        isOwned = _out1159;
                        isErased = _out1160;
                        readIdents = _out1161;
                      }
                    }
                  }
                } else if (_source64.is_Nullable) {
                  DAST._IType _1804___mcc_h956 = _source64.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1805_recursiveGen;
                    bool _1806_recOwned;
                    bool _1807_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1808_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1162;
                    bool _out1163;
                    bool _out1164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                    _1805_recursiveGen = _out1162;
                    _1806_recOwned = _out1163;
                    _1807_recErased = _out1164;
                    _1808_recIdents = _out1165;
                    if (!(_1806_recOwned)) {
                      _1805_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1805_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1805_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1807_recErased;
                    readIdents = _1808_recIdents;
                  }
                } else if (_source64.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1809___mcc_h958 = _source64.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1810_recursiveGen;
                    bool _1811_recOwned;
                    bool _1812_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1813_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1166;
                    bool _out1167;
                    bool _out1168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1169;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1166, out _out1167, out _out1168, out _out1169);
                    _1810_recursiveGen = _out1166;
                    _1811_recOwned = _out1167;
                    _1812_recErased = _out1168;
                    _1813_recIdents = _out1169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1810_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1811_recOwned;
                    isErased = _1812_recErased;
                    readIdents = _1813_recIdents;
                  }
                } else if (_source64.is_Array) {
                  DAST._IType _1814___mcc_h960 = _source64.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1815_recursiveGen;
                    bool _1816_recOwned;
                    bool _1817_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1818_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1170;
                    bool _out1171;
                    bool _out1172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1173;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1170, out _out1171, out _out1172, out _out1173);
                    _1815_recursiveGen = _out1170;
                    _1816_recOwned = _out1171;
                    _1817_recErased = _out1172;
                    _1818_recIdents = _out1173;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1815_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1816_recOwned;
                    isErased = _1817_recErased;
                    readIdents = _1818_recIdents;
                  }
                } else if (_source64.is_Seq) {
                  DAST._IType _1819___mcc_h962 = _source64.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1820_recursiveGen;
                    bool _1821_recOwned;
                    bool _1822_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1823_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1174;
                    bool _out1175;
                    bool _out1176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1177;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1174, out _out1175, out _out1176, out _out1177);
                    _1820_recursiveGen = _out1174;
                    _1821_recOwned = _out1175;
                    _1822_recErased = _out1176;
                    _1823_recIdents = _out1177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1820_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1821_recOwned;
                    isErased = _1822_recErased;
                    readIdents = _1823_recIdents;
                  }
                } else if (_source64.is_Set) {
                  DAST._IType _1824___mcc_h964 = _source64.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1825_recursiveGen;
                    bool _1826_recOwned;
                    bool _1827_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1828_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1178;
                    bool _out1179;
                    bool _out1180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1181;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1178, out _out1179, out _out1180, out _out1181);
                    _1825_recursiveGen = _out1178;
                    _1826_recOwned = _out1179;
                    _1827_recErased = _out1180;
                    _1828_recIdents = _out1181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1825_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1826_recOwned;
                    isErased = _1827_recErased;
                    readIdents = _1828_recIdents;
                  }
                } else if (_source64.is_Multiset) {
                  DAST._IType _1829___mcc_h966 = _source64.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1830_recursiveGen;
                    bool _1831_recOwned;
                    bool _1832_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1833_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1182;
                    bool _out1183;
                    bool _out1184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1185;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1182, out _out1183, out _out1184, out _out1185);
                    _1830_recursiveGen = _out1182;
                    _1831_recOwned = _out1183;
                    _1832_recErased = _out1184;
                    _1833_recIdents = _out1185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1830_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1831_recOwned;
                    isErased = _1832_recErased;
                    readIdents = _1833_recIdents;
                  }
                } else if (_source64.is_Map) {
                  DAST._IType _1834___mcc_h968 = _source64.dtor_key;
                  DAST._IType _1835___mcc_h969 = _source64.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1836_recursiveGen;
                    bool _1837_recOwned;
                    bool _1838_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1839_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1186;
                    bool _out1187;
                    bool _out1188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1189;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1186, out _out1187, out _out1188, out _out1189);
                    _1836_recursiveGen = _out1186;
                    _1837_recOwned = _out1187;
                    _1838_recErased = _out1188;
                    _1839_recIdents = _out1189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1836_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1837_recOwned;
                    isErased = _1838_recErased;
                    readIdents = _1839_recIdents;
                  }
                } else if (_source64.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1840___mcc_h972 = _source64.dtor_args;
                  DAST._IType _1841___mcc_h973 = _source64.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1842_recursiveGen;
                    bool _1843_recOwned;
                    bool _1844_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1845_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1190;
                    bool _out1191;
                    bool _out1192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1193;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1190, out _out1191, out _out1192, out _out1193);
                    _1842_recursiveGen = _out1190;
                    _1843_recOwned = _out1191;
                    _1844_recErased = _out1192;
                    _1845_recIdents = _out1193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1842_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1843_recOwned;
                    isErased = _1844_recErased;
                    readIdents = _1845_recIdents;
                  }
                } else if (_source64.is_Primitive) {
                  DAST._IPrimitive _1846___mcc_h976 = _source64.dtor_Primitive_a0;
                  DAST._IPrimitive _source66 = _1846___mcc_h976;
                  if (_source66.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1847_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1194;
                      _out1194 = DCOMP.COMP.GenType(_533_fromTpe, true, false);
                      _1847_rhsType = _out1194;
                      Dafny.ISequence<Dafny.Rune> _1848_recursiveGen;
                      bool _1849___v59;
                      bool _1850___v60;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1851_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1195;
                      bool _out1196;
                      bool _out1197;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1198;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, true, out _out1195, out _out1196, out _out1197, out _out1198);
                      _1848_recursiveGen = _out1195;
                      _1849___v59 = _out1196;
                      _1850___v60 = _out1197;
                      _1851_recIdents = _out1198;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1848_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1851_recIdents;
                    }
                  } else if (_source66.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1852_recursiveGen;
                      bool _1853_recOwned;
                      bool _1854_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1855_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1199;
                      bool _out1200;
                      bool _out1201;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1202;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1199, out _out1200, out _out1201, out _out1202);
                      _1852_recursiveGen = _out1199;
                      _1853_recOwned = _out1200;
                      _1854_recErased = _out1201;
                      _1855_recIdents = _out1202;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1852_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1853_recOwned;
                      isErased = _1854_recErased;
                      readIdents = _1855_recIdents;
                    }
                  } else if (_source66.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1856_recursiveGen;
                      bool _1857_recOwned;
                      bool _1858_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1859_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      bool _out1204;
                      bool _out1205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1206;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1203, out _out1204, out _out1205, out _out1206);
                      _1856_recursiveGen = _out1203;
                      _1857_recOwned = _out1204;
                      _1858_recErased = _out1205;
                      _1859_recIdents = _out1206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1856_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1857_recOwned;
                      isErased = _1858_recErased;
                      readIdents = _1859_recIdents;
                    }
                  } else if (_source66.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1860_recursiveGen;
                      bool _1861_recOwned;
                      bool _1862_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1863_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1207;
                      bool _out1208;
                      bool _out1209;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1210;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1207, out _out1208, out _out1209, out _out1210);
                      _1860_recursiveGen = _out1207;
                      _1861_recOwned = _out1208;
                      _1862_recErased = _out1209;
                      _1863_recIdents = _out1210;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1860_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1861_recOwned;
                      isErased = _1862_recErased;
                      readIdents = _1863_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1864_recursiveGen;
                      bool _1865_recOwned;
                      bool _1866_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1867_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1211;
                      bool _out1212;
                      bool _out1213;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1214;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1211, out _out1212, out _out1213, out _out1214);
                      _1864_recursiveGen = _out1211;
                      _1865_recOwned = _out1212;
                      _1866_recErased = _out1213;
                      _1867_recIdents = _out1214;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1864_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1865_recOwned;
                      isErased = _1866_recErased;
                      readIdents = _1867_recIdents;
                    }
                  }
                } else if (_source64.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1868___mcc_h978 = _source64.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1869_recursiveGen;
                    bool _1870_recOwned;
                    bool _1871_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1872_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1215;
                    bool _out1216;
                    bool _out1217;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1218;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1215, out _out1216, out _out1217, out _out1218);
                    _1869_recursiveGen = _out1215;
                    _1870_recOwned = _out1216;
                    _1871_recErased = _out1217;
                    _1872_recIdents = _out1218;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1869_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1870_recOwned;
                    isErased = _1871_recErased;
                    readIdents = _1872_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1873___mcc_h980 = _source64.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1874_recursiveGen;
                    bool _1875_recOwned;
                    bool _1876_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1877_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1219;
                    bool _out1220;
                    bool _out1221;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1222;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1219, out _out1220, out _out1221, out _out1222);
                    _1874_recursiveGen = _out1219;
                    _1875_recOwned = _out1220;
                    _1876_recErased = _out1221;
                    _1877_recIdents = _out1222;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1874_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1875_recOwned;
                    isErased = _1876_recErased;
                    readIdents = _1877_recIdents;
                  }
                }
              }
            } else if (_source29.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1878___mcc_h982 = _source29.dtor_Passthrough_a0;
              DAST._IType _source67 = _540___mcc_h265;
              if (_source67.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1879___mcc_h986 = _source67.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1880___mcc_h987 = _source67.dtor_typeArgs;
                DAST._IResolvedType _1881___mcc_h988 = _source67.dtor_resolved;
                DAST._IResolvedType _source68 = _1881___mcc_h988;
                if (_source68.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1882___mcc_h992 = _source68.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1883_recursiveGen;
                    bool _1884_recOwned;
                    bool _1885_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1886_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1223;
                    bool _out1224;
                    bool _out1225;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1226;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1223, out _out1224, out _out1225, out _out1226);
                    _1883_recursiveGen = _out1223;
                    _1884_recOwned = _out1224;
                    _1885_recErased = _out1225;
                    _1886_recIdents = _out1226;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1883_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1884_recOwned;
                    isErased = _1885_recErased;
                    readIdents = _1886_recIdents;
                  }
                } else if (_source68.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1887___mcc_h994 = _source68.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1888_recursiveGen;
                    bool _1889_recOwned;
                    bool _1890_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1891_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1227;
                    bool _out1228;
                    bool _out1229;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1230;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1227, out _out1228, out _out1229, out _out1230);
                    _1888_recursiveGen = _out1227;
                    _1889_recOwned = _out1228;
                    _1890_recErased = _out1229;
                    _1891_recIdents = _out1230;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1888_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1889_recOwned;
                    isErased = _1890_recErased;
                    readIdents = _1891_recIdents;
                  }
                } else {
                  DAST._IType _1892___mcc_h996 = _source68.dtor_Newtype_a0;
                  DAST._IType _1893_b = _1892___mcc_h996;
                  {
                    if (object.Equals(_533_fromTpe, _1893_b)) {
                      Dafny.ISequence<Dafny.Rune> _1894_recursiveGen;
                      bool _1895_recOwned;
                      bool _1896_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1897_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1231;
                      bool _out1232;
                      bool _out1233;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1234;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1231, out _out1232, out _out1233, out _out1234);
                      _1894_recursiveGen = _out1231;
                      _1895_recOwned = _out1232;
                      _1896_recErased = _out1233;
                      _1897_recIdents = _out1234;
                      Dafny.ISequence<Dafny.Rune> _1898_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1235;
                      _out1235 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _1898_rhsType = _out1235;
                      Dafny.ISequence<Dafny.Rune> _1899_uneraseFn;
                      _1899_uneraseFn = ((_1895_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1898_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1899_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1894_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1895_recOwned;
                      isErased = false;
                      readIdents = _1897_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1236;
                      bool _out1237;
                      bool _out1238;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1893_b), _1893_b, _532_toTpe), selfIdent, @params, mustOwn, out _out1236, out _out1237, out _out1238, out _out1239);
                      s = _out1236;
                      isOwned = _out1237;
                      isErased = _out1238;
                      readIdents = _out1239;
                    }
                  }
                }
              } else if (_source67.is_Nullable) {
                DAST._IType _1900___mcc_h998 = _source67.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1901_recursiveGen;
                  bool _1902_recOwned;
                  bool _1903_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1904_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1240;
                  bool _out1241;
                  bool _out1242;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
                  _1901_recursiveGen = _out1240;
                  _1902_recOwned = _out1241;
                  _1903_recErased = _out1242;
                  _1904_recIdents = _out1243;
                  if (!(_1902_recOwned)) {
                    _1901_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1901_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1901_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1903_recErased;
                  readIdents = _1904_recIdents;
                }
              } else if (_source67.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1905___mcc_h1000 = _source67.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1906_recursiveGen;
                  bool _1907_recOwned;
                  bool _1908_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1909_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1244;
                  bool _out1245;
                  bool _out1246;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1244, out _out1245, out _out1246, out _out1247);
                  _1906_recursiveGen = _out1244;
                  _1907_recOwned = _out1245;
                  _1908_recErased = _out1246;
                  _1909_recIdents = _out1247;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1906_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1907_recOwned;
                  isErased = _1908_recErased;
                  readIdents = _1909_recIdents;
                }
              } else if (_source67.is_Array) {
                DAST._IType _1910___mcc_h1002 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1911_recursiveGen;
                  bool _1912_recOwned;
                  bool _1913_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1914_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1248;
                  bool _out1249;
                  bool _out1250;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1248, out _out1249, out _out1250, out _out1251);
                  _1911_recursiveGen = _out1248;
                  _1912_recOwned = _out1249;
                  _1913_recErased = _out1250;
                  _1914_recIdents = _out1251;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1911_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1912_recOwned;
                  isErased = _1913_recErased;
                  readIdents = _1914_recIdents;
                }
              } else if (_source67.is_Seq) {
                DAST._IType _1915___mcc_h1004 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1916_recursiveGen;
                  bool _1917_recOwned;
                  bool _1918_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1919_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1252;
                  bool _out1253;
                  bool _out1254;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1252, out _out1253, out _out1254, out _out1255);
                  _1916_recursiveGen = _out1252;
                  _1917_recOwned = _out1253;
                  _1918_recErased = _out1254;
                  _1919_recIdents = _out1255;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1916_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1917_recOwned;
                  isErased = _1918_recErased;
                  readIdents = _1919_recIdents;
                }
              } else if (_source67.is_Set) {
                DAST._IType _1920___mcc_h1006 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1921_recursiveGen;
                  bool _1922_recOwned;
                  bool _1923_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1924_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1256;
                  bool _out1257;
                  bool _out1258;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1256, out _out1257, out _out1258, out _out1259);
                  _1921_recursiveGen = _out1256;
                  _1922_recOwned = _out1257;
                  _1923_recErased = _out1258;
                  _1924_recIdents = _out1259;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1921_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1922_recOwned;
                  isErased = _1923_recErased;
                  readIdents = _1924_recIdents;
                }
              } else if (_source67.is_Multiset) {
                DAST._IType _1925___mcc_h1008 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1926_recursiveGen;
                  bool _1927_recOwned;
                  bool _1928_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1929_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1260;
                  bool _out1261;
                  bool _out1262;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1260, out _out1261, out _out1262, out _out1263);
                  _1926_recursiveGen = _out1260;
                  _1927_recOwned = _out1261;
                  _1928_recErased = _out1262;
                  _1929_recIdents = _out1263;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1926_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1927_recOwned;
                  isErased = _1928_recErased;
                  readIdents = _1929_recIdents;
                }
              } else if (_source67.is_Map) {
                DAST._IType _1930___mcc_h1010 = _source67.dtor_key;
                DAST._IType _1931___mcc_h1011 = _source67.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1932_recursiveGen;
                  bool _1933_recOwned;
                  bool _1934_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1935_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1264;
                  bool _out1265;
                  bool _out1266;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1267;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1264, out _out1265, out _out1266, out _out1267);
                  _1932_recursiveGen = _out1264;
                  _1933_recOwned = _out1265;
                  _1934_recErased = _out1266;
                  _1935_recIdents = _out1267;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1932_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1933_recOwned;
                  isErased = _1934_recErased;
                  readIdents = _1935_recIdents;
                }
              } else if (_source67.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1936___mcc_h1014 = _source67.dtor_args;
                DAST._IType _1937___mcc_h1015 = _source67.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1938_recursiveGen;
                  bool _1939_recOwned;
                  bool _1940_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1941_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1268;
                  bool _out1269;
                  bool _out1270;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1271;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1268, out _out1269, out _out1270, out _out1271);
                  _1938_recursiveGen = _out1268;
                  _1939_recOwned = _out1269;
                  _1940_recErased = _out1270;
                  _1941_recIdents = _out1271;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1938_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1939_recOwned;
                  isErased = _1940_recErased;
                  readIdents = _1941_recIdents;
                }
              } else if (_source67.is_Primitive) {
                DAST._IPrimitive _1942___mcc_h1018 = _source67.dtor_Primitive_a0;
                DAST._IPrimitive _source69 = _1942___mcc_h1018;
                if (_source69.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1943_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1272;
                    _out1272 = DCOMP.COMP.GenType(_533_fromTpe, true, false);
                    _1943_rhsType = _out1272;
                    Dafny.ISequence<Dafny.Rune> _1944_recursiveGen;
                    bool _1945___v55;
                    bool _1946___v56;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1947_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1273;
                    bool _out1274;
                    bool _out1275;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1276;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, true, out _out1273, out _out1274, out _out1275, out _out1276);
                    _1944_recursiveGen = _out1273;
                    _1945___v55 = _out1274;
                    _1946___v56 = _out1275;
                    _1947_recIdents = _out1276;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1944_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1947_recIdents;
                  }
                } else if (_source69.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1948_recursiveGen;
                    bool _1949_recOwned;
                    bool _1950_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1951_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1277;
                    bool _out1278;
                    bool _out1279;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1280;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1277, out _out1278, out _out1279, out _out1280);
                    _1948_recursiveGen = _out1277;
                    _1949_recOwned = _out1278;
                    _1950_recErased = _out1279;
                    _1951_recIdents = _out1280;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1948_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1949_recOwned;
                    isErased = _1950_recErased;
                    readIdents = _1951_recIdents;
                  }
                } else if (_source69.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1952_recursiveGen;
                    bool _1953_recOwned;
                    bool _1954_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1955_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    bool _out1282;
                    bool _out1283;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1284;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1281, out _out1282, out _out1283, out _out1284);
                    _1952_recursiveGen = _out1281;
                    _1953_recOwned = _out1282;
                    _1954_recErased = _out1283;
                    _1955_recIdents = _out1284;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1952_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1953_recOwned;
                    isErased = _1954_recErased;
                    readIdents = _1955_recIdents;
                  }
                } else if (_source69.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1956_recursiveGen;
                    bool _1957_recOwned;
                    bool _1958_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1959_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1285;
                    bool _out1286;
                    bool _out1287;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1288;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1285, out _out1286, out _out1287, out _out1288);
                    _1956_recursiveGen = _out1285;
                    _1957_recOwned = _out1286;
                    _1958_recErased = _out1287;
                    _1959_recIdents = _out1288;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1956_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1957_recOwned;
                    isErased = _1958_recErased;
                    readIdents = _1959_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1960_recursiveGen;
                    bool _1961_recOwned;
                    bool _1962_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1963_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1289;
                    bool _out1290;
                    bool _out1291;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1292;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1289, out _out1290, out _out1291, out _out1292);
                    _1960_recursiveGen = _out1289;
                    _1961_recOwned = _out1290;
                    _1962_recErased = _out1291;
                    _1963_recIdents = _out1292;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1960_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1961_recOwned;
                    isErased = _1962_recErased;
                    readIdents = _1963_recIdents;
                  }
                }
              } else if (_source67.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1964___mcc_h1020 = _source67.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1965_recursiveGen;
                  bool _1966___v63;
                  bool _1967___v64;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1968_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1293;
                  bool _out1294;
                  bool _out1295;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1296;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, true, out _out1293, out _out1294, out _out1295, out _out1296);
                  _1965_recursiveGen = _out1293;
                  _1966___v63 = _out1294;
                  _1967___v64 = _out1295;
                  _1968_recIdents = _out1296;
                  Dafny.ISequence<Dafny.Rune> _1969_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1297;
                  _out1297 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                  _1969_toTpeGen = _out1297;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1965_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1969_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1968_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1970___mcc_h1022 = _source67.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1971_recursiveGen;
                  bool _1972_recOwned;
                  bool _1973_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1974_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1298;
                  bool _out1299;
                  bool _out1300;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1301;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1298, out _out1299, out _out1300, out _out1301);
                  _1971_recursiveGen = _out1298;
                  _1972_recOwned = _out1299;
                  _1973_recErased = _out1300;
                  _1974_recIdents = _out1301;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1971_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1972_recOwned;
                  isErased = _1973_recErased;
                  readIdents = _1974_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1975___mcc_h1024 = _source29.dtor_TypeArg_a0;
              DAST._IType _source70 = _540___mcc_h265;
              if (_source70.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1976___mcc_h1028 = _source70.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1977___mcc_h1029 = _source70.dtor_typeArgs;
                DAST._IResolvedType _1978___mcc_h1030 = _source70.dtor_resolved;
                DAST._IResolvedType _source71 = _1978___mcc_h1030;
                if (_source71.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1979___mcc_h1034 = _source71.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1980_recursiveGen;
                    bool _1981_recOwned;
                    bool _1982_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1983_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1302;
                    bool _out1303;
                    bool _out1304;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1302, out _out1303, out _out1304, out _out1305);
                    _1980_recursiveGen = _out1302;
                    _1981_recOwned = _out1303;
                    _1982_recErased = _out1304;
                    _1983_recIdents = _out1305;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1980_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1981_recOwned;
                    isErased = _1982_recErased;
                    readIdents = _1983_recIdents;
                  }
                } else if (_source71.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1984___mcc_h1036 = _source71.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1985_recursiveGen;
                    bool _1986_recOwned;
                    bool _1987_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1988_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1306;
                    bool _out1307;
                    bool _out1308;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1309;
                    DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1306, out _out1307, out _out1308, out _out1309);
                    _1985_recursiveGen = _out1306;
                    _1986_recOwned = _out1307;
                    _1987_recErased = _out1308;
                    _1988_recIdents = _out1309;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1985_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1986_recOwned;
                    isErased = _1987_recErased;
                    readIdents = _1988_recIdents;
                  }
                } else {
                  DAST._IType _1989___mcc_h1038 = _source71.dtor_Newtype_a0;
                  DAST._IType _1990_b = _1989___mcc_h1038;
                  {
                    if (object.Equals(_533_fromTpe, _1990_b)) {
                      Dafny.ISequence<Dafny.Rune> _1991_recursiveGen;
                      bool _1992_recOwned;
                      bool _1993_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1994_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1310;
                      bool _out1311;
                      bool _out1312;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1313;
                      DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1310, out _out1311, out _out1312, out _out1313);
                      _1991_recursiveGen = _out1310;
                      _1992_recOwned = _out1311;
                      _1993_recErased = _out1312;
                      _1994_recIdents = _out1313;
                      Dafny.ISequence<Dafny.Rune> _1995_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1314;
                      _out1314 = DCOMP.COMP.GenType(_532_toTpe, true, false);
                      _1995_rhsType = _out1314;
                      Dafny.ISequence<Dafny.Rune> _1996_uneraseFn;
                      _1996_uneraseFn = ((_1992_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1995_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1996_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1991_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1992_recOwned;
                      isErased = false;
                      readIdents = _1994_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1315;
                      bool _out1316;
                      bool _out1317;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1318;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_534_expr, _533_fromTpe, _1990_b), _1990_b, _532_toTpe), selfIdent, @params, mustOwn, out _out1315, out _out1316, out _out1317, out _out1318);
                      s = _out1315;
                      isOwned = _out1316;
                      isErased = _out1317;
                      readIdents = _out1318;
                    }
                  }
                }
              } else if (_source70.is_Nullable) {
                DAST._IType _1997___mcc_h1040 = _source70.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1998_recursiveGen;
                  bool _1999_recOwned;
                  bool _2000_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2001_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1319;
                  bool _out1320;
                  bool _out1321;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1322;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1319, out _out1320, out _out1321, out _out1322);
                  _1998_recursiveGen = _out1319;
                  _1999_recOwned = _out1320;
                  _2000_recErased = _out1321;
                  _2001_recIdents = _out1322;
                  if (!(_1999_recOwned)) {
                    _1998_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1998_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1998_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _2000_recErased;
                  readIdents = _2001_recIdents;
                }
              } else if (_source70.is_Tuple) {
                Dafny.ISequence<DAST._IType> _2002___mcc_h1042 = _source70.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2003_recursiveGen;
                  bool _2004_recOwned;
                  bool _2005_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2006_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1323;
                  bool _out1324;
                  bool _out1325;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1326;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1323, out _out1324, out _out1325, out _out1326);
                  _2003_recursiveGen = _out1323;
                  _2004_recOwned = _out1324;
                  _2005_recErased = _out1325;
                  _2006_recIdents = _out1326;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2003_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2004_recOwned;
                  isErased = _2005_recErased;
                  readIdents = _2006_recIdents;
                }
              } else if (_source70.is_Array) {
                DAST._IType _2007___mcc_h1044 = _source70.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2008_recursiveGen;
                  bool _2009_recOwned;
                  bool _2010_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2011_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1327;
                  bool _out1328;
                  bool _out1329;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1330;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1327, out _out1328, out _out1329, out _out1330);
                  _2008_recursiveGen = _out1327;
                  _2009_recOwned = _out1328;
                  _2010_recErased = _out1329;
                  _2011_recIdents = _out1330;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2008_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2009_recOwned;
                  isErased = _2010_recErased;
                  readIdents = _2011_recIdents;
                }
              } else if (_source70.is_Seq) {
                DAST._IType _2012___mcc_h1046 = _source70.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2013_recursiveGen;
                  bool _2014_recOwned;
                  bool _2015_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2016_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1331;
                  bool _out1332;
                  bool _out1333;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1334;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1331, out _out1332, out _out1333, out _out1334);
                  _2013_recursiveGen = _out1331;
                  _2014_recOwned = _out1332;
                  _2015_recErased = _out1333;
                  _2016_recIdents = _out1334;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2013_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2014_recOwned;
                  isErased = _2015_recErased;
                  readIdents = _2016_recIdents;
                }
              } else if (_source70.is_Set) {
                DAST._IType _2017___mcc_h1048 = _source70.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2018_recursiveGen;
                  bool _2019_recOwned;
                  bool _2020_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2021_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1335;
                  bool _out1336;
                  bool _out1337;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1338;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1335, out _out1336, out _out1337, out _out1338);
                  _2018_recursiveGen = _out1335;
                  _2019_recOwned = _out1336;
                  _2020_recErased = _out1337;
                  _2021_recIdents = _out1338;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2018_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2019_recOwned;
                  isErased = _2020_recErased;
                  readIdents = _2021_recIdents;
                }
              } else if (_source70.is_Multiset) {
                DAST._IType _2022___mcc_h1050 = _source70.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2023_recursiveGen;
                  bool _2024_recOwned;
                  bool _2025_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2026_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1339;
                  bool _out1340;
                  bool _out1341;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1342;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1339, out _out1340, out _out1341, out _out1342);
                  _2023_recursiveGen = _out1339;
                  _2024_recOwned = _out1340;
                  _2025_recErased = _out1341;
                  _2026_recIdents = _out1342;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2023_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2024_recOwned;
                  isErased = _2025_recErased;
                  readIdents = _2026_recIdents;
                }
              } else if (_source70.is_Map) {
                DAST._IType _2027___mcc_h1052 = _source70.dtor_key;
                DAST._IType _2028___mcc_h1053 = _source70.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _2029_recursiveGen;
                  bool _2030_recOwned;
                  bool _2031_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2032_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1343;
                  bool _out1344;
                  bool _out1345;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1346;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1343, out _out1344, out _out1345, out _out1346);
                  _2029_recursiveGen = _out1343;
                  _2030_recOwned = _out1344;
                  _2031_recErased = _out1345;
                  _2032_recIdents = _out1346;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2029_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2030_recOwned;
                  isErased = _2031_recErased;
                  readIdents = _2032_recIdents;
                }
              } else if (_source70.is_Arrow) {
                Dafny.ISequence<DAST._IType> _2033___mcc_h1056 = _source70.dtor_args;
                DAST._IType _2034___mcc_h1057 = _source70.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _2035_recursiveGen;
                  bool _2036_recOwned;
                  bool _2037_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2038_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1347;
                  bool _out1348;
                  bool _out1349;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1350;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1347, out _out1348, out _out1349, out _out1350);
                  _2035_recursiveGen = _out1347;
                  _2036_recOwned = _out1348;
                  _2037_recErased = _out1349;
                  _2038_recIdents = _out1350;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2035_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2036_recOwned;
                  isErased = _2037_recErased;
                  readIdents = _2038_recIdents;
                }
              } else if (_source70.is_Primitive) {
                DAST._IPrimitive _2039___mcc_h1060 = _source70.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2040_recursiveGen;
                  bool _2041_recOwned;
                  bool _2042_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2043_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1351;
                  bool _out1352;
                  bool _out1353;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1354;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1351, out _out1352, out _out1353, out _out1354);
                  _2040_recursiveGen = _out1351;
                  _2041_recOwned = _out1352;
                  _2042_recErased = _out1353;
                  _2043_recIdents = _out1354;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2040_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2041_recOwned;
                  isErased = _2042_recErased;
                  readIdents = _2043_recIdents;
                }
              } else if (_source70.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2044___mcc_h1062 = _source70.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2045_recursiveGen;
                  bool _2046_recOwned;
                  bool _2047_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2048_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1355;
                  bool _out1356;
                  bool _out1357;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1358;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1355, out _out1356, out _out1357, out _out1358);
                  _2045_recursiveGen = _out1355;
                  _2046_recOwned = _out1356;
                  _2047_recErased = _out1357;
                  _2048_recIdents = _out1358;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2045_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2046_recOwned;
                  isErased = _2047_recErased;
                  readIdents = _2048_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2049___mcc_h1064 = _source70.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2050_recursiveGen;
                  bool _2051_recOwned;
                  bool _2052_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2053_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1359;
                  bool _out1360;
                  bool _out1361;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1362;
                  DCOMP.COMP.GenExpr(_534_expr, selfIdent, @params, mustOwn, out _out1359, out _out1360, out _out1361, out _out1362);
                  _2050_recursiveGen = _out1359;
                  _2051_recOwned = _out1360;
                  _2052_recErased = _out1361;
                  _2053_recIdents = _out1362;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2050_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2051_recOwned;
                  isErased = _2052_recErased;
                  readIdents = _2053_recIdents;
                }
              }
            }
          }
        }
      } else if (_source22.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2054___mcc_h22 = _source22.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2055_exprs = _2054___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2056_generatedValues;
          _2056_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2057_i;
          _2057_i = BigInteger.Zero;
          bool _2058_allErased;
          _2058_allErased = true;
          while ((_2057_i) < (new BigInteger((_2055_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2059_recursiveGen;
            bool _2060___v66;
            bool _2061_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2062_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1363;
            bool _out1364;
            bool _out1365;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1366;
            DCOMP.COMP.GenExpr((_2055_exprs).Select(_2057_i), selfIdent, @params, true, out _out1363, out _out1364, out _out1365, out _out1366);
            _2059_recursiveGen = _out1363;
            _2060___v66 = _out1364;
            _2061_isErased = _out1365;
            _2062_recIdents = _out1366;
            _2058_allErased = (_2058_allErased) && (_2061_isErased);
            _2056_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2056_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2059_recursiveGen, _2061_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2062_recIdents);
            _2057_i = (_2057_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2057_i = BigInteger.Zero;
          while ((_2057_i) < (new BigInteger((_2056_generatedValues).Count))) {
            if ((_2057_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2063_gen;
            _2063_gen = ((_2056_generatedValues).Select(_2057_i)).dtor__0;
            if ((((_2056_generatedValues).Select(_2057_i)).dtor__1) && (!(_2058_allErased))) {
              _2063_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2063_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2063_gen);
            _2057_i = (_2057_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2058_allErased;
        }
      } else if (_source22.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2064___mcc_h23 = _source22.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2065_exprs = _2064___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2066_generatedValues;
          _2066_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2067_i;
          _2067_i = BigInteger.Zero;
          bool _2068_allErased;
          _2068_allErased = true;
          while ((_2067_i) < (new BigInteger((_2065_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2069_recursiveGen;
            bool _2070___v67;
            bool _2071_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2072_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1367;
            bool _out1368;
            bool _out1369;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1370;
            DCOMP.COMP.GenExpr((_2065_exprs).Select(_2067_i), selfIdent, @params, true, out _out1367, out _out1368, out _out1369, out _out1370);
            _2069_recursiveGen = _out1367;
            _2070___v67 = _out1368;
            _2071_isErased = _out1369;
            _2072_recIdents = _out1370;
            _2068_allErased = (_2068_allErased) && (_2071_isErased);
            _2066_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2066_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2069_recursiveGen, _2071_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2072_recIdents);
            _2067_i = (_2067_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2067_i = BigInteger.Zero;
          while ((_2067_i) < (new BigInteger((_2066_generatedValues).Count))) {
            if ((_2067_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2073_gen;
            _2073_gen = ((_2066_generatedValues).Select(_2067_i)).dtor__0;
            if ((((_2066_generatedValues).Select(_2067_i)).dtor__1) && (!(_2068_allErased))) {
              _2073_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2073_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2073_gen);
            _2067_i = (_2067_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = _2068_allErased;
        }
      } else if (_source22.is_MapValue) {
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2074___mcc_h24 = _source22.dtor_mapElems;
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2075_mapElems = _2074___mcc_h24;
        {
          Dafny.ISequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>> _2076_generatedValues;
          _2076_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2077_i;
          _2077_i = BigInteger.Zero;
          bool _2078_allErased;
          _2078_allErased = true;
          while ((_2077_i) < (new BigInteger((_2075_mapElems).Count))) {
            Dafny.ISequence<Dafny.Rune> _2079_recursiveGenKey;
            bool _2080___v68;
            bool _2081_isErasedKey;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2082_recIdentsKey;
            Dafny.ISequence<Dafny.Rune> _out1371;
            bool _out1372;
            bool _out1373;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1374;
            DCOMP.COMP.GenExpr(((_2075_mapElems).Select(_2077_i)).dtor__0, selfIdent, @params, true, out _out1371, out _out1372, out _out1373, out _out1374);
            _2079_recursiveGenKey = _out1371;
            _2080___v68 = _out1372;
            _2081_isErasedKey = _out1373;
            _2082_recIdentsKey = _out1374;
            Dafny.ISequence<Dafny.Rune> _2083_recursiveGenValue;
            bool _2084___v69;
            bool _2085_isErasedValue;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2086_recIdentsValue;
            Dafny.ISequence<Dafny.Rune> _out1375;
            bool _out1376;
            bool _out1377;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1378;
            DCOMP.COMP.GenExpr(((_2075_mapElems).Select(_2077_i)).dtor__1, selfIdent, @params, true, out _out1375, out _out1376, out _out1377, out _out1378);
            _2083_recursiveGenValue = _out1375;
            _2084___v69 = _out1376;
            _2085_isErasedValue = _out1377;
            _2086_recIdentsValue = _out1378;
            _2078_allErased = ((_2078_allErased) && (_2081_isErasedKey)) && (_2085_isErasedValue);
            _2076_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.Concat(_2076_generatedValues, Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements(_System.Tuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>.create(_2079_recursiveGenKey, _2083_recursiveGenValue, _2081_isErasedKey, _2085_isErasedValue)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2082_recIdentsKey), _2086_recIdentsValue);
            _2077_i = (_2077_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2077_i = BigInteger.Zero;
          while ((_2077_i) < (new BigInteger((_2076_generatedValues).Count))) {
            if ((_2077_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2087_genKey;
            _2087_genKey = ((_2076_generatedValues).Select(_2077_i)).dtor__0;
            Dafny.ISequence<Dafny.Rune> _2088_genValue;
            _2088_genValue = ((_2076_generatedValues).Select(_2077_i)).dtor__1;
            if ((((_2076_generatedValues).Select(_2077_i)).dtor__2) && (!(_2078_allErased))) {
              _2087_genKey = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2087_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((((_2076_generatedValues).Select(_2077_i)).dtor__3) && (!(_2078_allErased))) {
              _2088_genValue = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2088_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2087_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2088_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            _2077_i = (_2077_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashMap<_, _>>()"));
          isOwned = true;
          isErased = _2078_allErased;
        }
      } else if (_source22.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source72 = selfIdent;
          if (_source72.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2089___mcc_h1066 = _source72.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2090_id = _2089___mcc_h1066;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2090_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2090_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2090_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2090_id);
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
      } else if (_source22.is_Ite) {
        DAST._IExpression _2091___mcc_h25 = _source22.dtor_cond;
        DAST._IExpression _2092___mcc_h26 = _source22.dtor_thn;
        DAST._IExpression _2093___mcc_h27 = _source22.dtor_els;
        DAST._IExpression _2094_f = _2093___mcc_h27;
        DAST._IExpression _2095_t = _2092___mcc_h26;
        DAST._IExpression _2096_cond = _2091___mcc_h25;
        {
          Dafny.ISequence<Dafny.Rune> _2097_condString;
          bool _2098___v70;
          bool _2099_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2100_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1379;
          bool _out1380;
          bool _out1381;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1382;
          DCOMP.COMP.GenExpr(_2096_cond, selfIdent, @params, true, out _out1379, out _out1380, out _out1381, out _out1382);
          _2097_condString = _out1379;
          _2098___v70 = _out1380;
          _2099_condErased = _out1381;
          _2100_recIdentsCond = _out1382;
          if (!(_2099_condErased)) {
            _2097_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2097_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2101___v71;
          bool _2102_tHasToBeOwned;
          bool _2103___v72;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2104___v73;
          Dafny.ISequence<Dafny.Rune> _out1383;
          bool _out1384;
          bool _out1385;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1386;
          DCOMP.COMP.GenExpr(_2095_t, selfIdent, @params, mustOwn, out _out1383, out _out1384, out _out1385, out _out1386);
          _2101___v71 = _out1383;
          _2102_tHasToBeOwned = _out1384;
          _2103___v72 = _out1385;
          _2104___v73 = _out1386;
          Dafny.ISequence<Dafny.Rune> _2105_fString;
          bool _2106_fOwned;
          bool _2107_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2108_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1387;
          bool _out1388;
          bool _out1389;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1390;
          DCOMP.COMP.GenExpr(_2094_f, selfIdent, @params, _2102_tHasToBeOwned, out _out1387, out _out1388, out _out1389, out _out1390);
          _2105_fString = _out1387;
          _2106_fOwned = _out1388;
          _2107_fErased = _out1389;
          _2108_recIdentsF = _out1390;
          Dafny.ISequence<Dafny.Rune> _2109_tString;
          bool _2110___v74;
          bool _2111_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2112_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1391;
          bool _out1392;
          bool _out1393;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1394;
          DCOMP.COMP.GenExpr(_2095_t, selfIdent, @params, _2106_fOwned, out _out1391, out _out1392, out _out1393, out _out1394);
          _2109_tString = _out1391;
          _2110___v74 = _out1392;
          _2111_tErased = _out1393;
          _2112_recIdentsT = _out1394;
          if ((!(_2107_fErased)) || (!(_2111_tErased))) {
            if (_2107_fErased) {
              _2105_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2105_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2111_tErased) {
              _2109_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2109_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2097_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2109_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2105_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2106_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2100_recIdentsCond, _2112_recIdentsT), _2108_recIdentsF);
          isErased = (_2107_fErased) || (_2111_tErased);
        }
      } else if (_source22.is_UnOp) {
        DAST._IUnaryOp _2113___mcc_h28 = _source22.dtor_unOp;
        DAST._IExpression _2114___mcc_h29 = _source22.dtor_expr;
        DAST._IUnaryOp _source73 = _2113___mcc_h28;
        if (_source73.is_Not) {
          DAST._IExpression _2115_e = _2114___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2116_recursiveGen;
            bool _2117___v75;
            bool _2118_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2119_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1395;
            bool _out1396;
            bool _out1397;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1398;
            DCOMP.COMP.GenExpr(_2115_e, selfIdent, @params, true, out _out1395, out _out1396, out _out1397, out _out1398);
            _2116_recursiveGen = _out1395;
            _2117___v75 = _out1396;
            _2118_recErased = _out1397;
            _2119_recIdents = _out1398;
            if (!(_2118_recErased)) {
              _2116_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2116_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2116_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2119_recIdents;
            isErased = true;
          }
        } else if (_source73.is_BitwiseNot) {
          DAST._IExpression _2120_e = _2114___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2121_recursiveGen;
            bool _2122___v76;
            bool _2123_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2124_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1399;
            bool _out1400;
            bool _out1401;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1402;
            DCOMP.COMP.GenExpr(_2120_e, selfIdent, @params, true, out _out1399, out _out1400, out _out1401, out _out1402);
            _2121_recursiveGen = _out1399;
            _2122___v76 = _out1400;
            _2123_recErased = _out1401;
            _2124_recIdents = _out1402;
            if (!(_2123_recErased)) {
              _2121_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2121_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2121_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2124_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2125_e = _2114___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2126_recursiveGen;
            bool _2127_recOwned;
            bool _2128_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2129_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1403;
            bool _out1404;
            bool _out1405;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1406;
            DCOMP.COMP.GenExpr(_2125_e, selfIdent, @params, false, out _out1403, out _out1404, out _out1405, out _out1406);
            _2126_recursiveGen = _out1403;
            _2127_recOwned = _out1404;
            _2128_recErased = _out1405;
            _2129_recIdents = _out1406;
            if (!(_2128_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2130_eraseFn;
              _2130_eraseFn = ((_2127_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2126_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2130_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2126_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2126_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2129_recIdents;
            isErased = true;
          }
        }
      } else if (_source22.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2131___mcc_h30 = _source22.dtor_op;
        DAST._IExpression _2132___mcc_h31 = _source22.dtor_left;
        DAST._IExpression _2133___mcc_h32 = _source22.dtor_right;
        DAST._IExpression _2134_r = _2133___mcc_h32;
        DAST._IExpression _2135_l = _2132___mcc_h31;
        Dafny.ISequence<Dafny.Rune> _2136_op = _2131___mcc_h30;
        {
          Dafny.ISequence<Dafny.Rune> _2137_left;
          bool _2138___v77;
          bool _2139_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2140_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1407;
          bool _out1408;
          bool _out1409;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1410;
          DCOMP.COMP.GenExpr(_2135_l, selfIdent, @params, true, out _out1407, out _out1408, out _out1409, out _out1410);
          _2137_left = _out1407;
          _2138___v77 = _out1408;
          _2139_leftErased = _out1409;
          _2140_recIdentsL = _out1410;
          Dafny.ISequence<Dafny.Rune> _2141_right;
          bool _2142___v78;
          bool _2143_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2144_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1411;
          bool _out1412;
          bool _out1413;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1414;
          DCOMP.COMP.GenExpr(_2134_r, selfIdent, @params, true, out _out1411, out _out1412, out _out1413, out _out1414);
          _2141_right = _out1411;
          _2142___v78 = _out1412;
          _2143_rightErased = _out1413;
          _2144_recIdentsR = _out1414;
          if (!(_2139_leftErased)) {
            _2137_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2137_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2143_rightErased)) {
            _2141_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2141_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2136_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2137_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2141_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2136_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2137_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2141_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2137_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2136_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2141_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2140_recIdentsL, _2144_recIdentsR);
          isErased = true;
        }
      } else if (_source22.is_ArrayLen) {
        DAST._IExpression _2145___mcc_h33 = _source22.dtor_expr;
        DAST._IExpression _2146_expr = _2145___mcc_h33;
        {
          Dafny.ISequence<Dafny.Rune> _2147_recursiveGen;
          bool _2148___v79;
          bool _2149_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2150_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1415;
          bool _out1416;
          bool _out1417;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1418;
          DCOMP.COMP.GenExpr(_2146_expr, selfIdent, @params, true, out _out1415, out _out1416, out _out1417, out _out1418);
          _2147_recursiveGen = _out1415;
          _2148___v79 = _out1416;
          _2149_recErased = _out1417;
          _2150_recIdents = _out1418;
          if (!(_2149_recErased)) {
            _2147_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2147_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2147_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow().len())"));
          isOwned = true;
          readIdents = _2150_recIdents;
          isErased = true;
        }
      } else if (_source22.is_Select) {
        DAST._IExpression _2151___mcc_h34 = _source22.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2152___mcc_h35 = _source22.dtor_field;
        bool _2153___mcc_h36 = _source22.dtor_isConstant;
        bool _2154___mcc_h37 = _source22.dtor_onDatatype;
        DAST._IExpression _source74 = _2151___mcc_h34;
        if (_source74.is_Literal) {
          DAST._ILiteral _2155___mcc_h38 = _source74.dtor_Literal_a0;
          bool _2156_isDatatype = _2154___mcc_h37;
          bool _2157_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2158_field = _2152___mcc_h35;
          DAST._IExpression _2159_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2160_onString;
            bool _2161_onOwned;
            bool _2162_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2163_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1419;
            bool _out1420;
            bool _out1421;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1422;
            DCOMP.COMP.GenExpr(_2159_on, selfIdent, @params, false, out _out1419, out _out1420, out _out1421, out _out1422);
            _2160_onString = _out1419;
            _2161_onOwned = _out1420;
            _2162_onErased = _out1421;
            _2163_recIdents = _out1422;
            if (!(_2162_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2164_eraseFn;
              _2164_eraseFn = ((_2161_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2160_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2164_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2160_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2156_isDatatype) || (_2157_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2160_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2158_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2157_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2160_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2158_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2163_recIdents;
          }
        } else if (_source74.is_Ident) {
          Dafny.ISequence<Dafny.Rune> _2165___mcc_h40 = _source74.dtor_Ident_a0;
          bool _2166_isDatatype = _2154___mcc_h37;
          bool _2167_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2168_field = _2152___mcc_h35;
          DAST._IExpression _2169_on = _2151___mcc_h34;
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
        } else if (_source74.is_Companion) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2175___mcc_h42 = _source74.dtor_Companion_a0;
          bool _2176_isDatatype = _2154___mcc_h37;
          bool _2177_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2178_field = _2152___mcc_h35;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2179_c = _2175___mcc_h42;
          {
            Dafny.ISequence<Dafny.Rune> _2180_onString;
            bool _2181_onOwned;
            bool _2182_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2183_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1427;
            bool _out1428;
            bool _out1429;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1430;
            DCOMP.COMP.GenExpr(DAST.Expression.create_Companion(_2179_c), selfIdent, @params, false, out _out1427, out _out1428, out _out1429, out _out1430);
            _2180_onString = _out1427;
            _2181_onOwned = _out1428;
            _2182_onErased = _out1429;
            _2183_recIdents = _out1430;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2180_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2178_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            isOwned = true;
            isErased = false;
            readIdents = _2183_recIdents;
          }
        } else if (_source74.is_Tuple) {
          Dafny.ISequence<DAST._IExpression> _2184___mcc_h44 = _source74.dtor_Tuple_a0;
          bool _2185_isDatatype = _2154___mcc_h37;
          bool _2186_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2187_field = _2152___mcc_h35;
          DAST._IExpression _2188_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2189_onString;
            bool _2190_onOwned;
            bool _2191_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2192_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1431;
            bool _out1432;
            bool _out1433;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1434;
            DCOMP.COMP.GenExpr(_2188_on, selfIdent, @params, false, out _out1431, out _out1432, out _out1433, out _out1434);
            _2189_onString = _out1431;
            _2190_onOwned = _out1432;
            _2191_onErased = _out1433;
            _2192_recIdents = _out1434;
            if (!(_2191_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2193_eraseFn;
              _2193_eraseFn = ((_2190_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2189_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2193_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2189_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2185_isDatatype) || (_2186_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2189_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2187_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2186_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2189_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2187_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2192_recIdents;
          }
        } else if (_source74.is_New) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2194___mcc_h46 = _source74.dtor_path;
          Dafny.ISequence<DAST._IExpression> _2195___mcc_h47 = _source74.dtor_args;
          bool _2196_isDatatype = _2154___mcc_h37;
          bool _2197_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2198_field = _2152___mcc_h35;
          DAST._IExpression _2199_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2200_onString;
            bool _2201_onOwned;
            bool _2202_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2203_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1435;
            bool _out1436;
            bool _out1437;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1438;
            DCOMP.COMP.GenExpr(_2199_on, selfIdent, @params, false, out _out1435, out _out1436, out _out1437, out _out1438);
            _2200_onString = _out1435;
            _2201_onOwned = _out1436;
            _2202_onErased = _out1437;
            _2203_recIdents = _out1438;
            if (!(_2202_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2204_eraseFn;
              _2204_eraseFn = ((_2201_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2200_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2204_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2200_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2196_isDatatype) || (_2197_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2200_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2198_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2197_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2200_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2198_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2203_recIdents;
          }
        } else if (_source74.is_NewArray) {
          Dafny.ISequence<DAST._IExpression> _2205___mcc_h50 = _source74.dtor_dims;
          bool _2206_isDatatype = _2154___mcc_h37;
          bool _2207_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2208_field = _2152___mcc_h35;
          DAST._IExpression _2209_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2210_onString;
            bool _2211_onOwned;
            bool _2212_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2213_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1439;
            bool _out1440;
            bool _out1441;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1442;
            DCOMP.COMP.GenExpr(_2209_on, selfIdent, @params, false, out _out1439, out _out1440, out _out1441, out _out1442);
            _2210_onString = _out1439;
            _2211_onOwned = _out1440;
            _2212_onErased = _out1441;
            _2213_recIdents = _out1442;
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
        } else if (_source74.is_DatatypeValue) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2215___mcc_h52 = _source74.dtor_path;
          Dafny.ISequence<Dafny.Rune> _2216___mcc_h53 = _source74.dtor_variant;
          bool _2217___mcc_h54 = _source74.dtor_isCo;
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2218___mcc_h55 = _source74.dtor_contents;
          bool _2219_isDatatype = _2154___mcc_h37;
          bool _2220_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2221_field = _2152___mcc_h35;
          DAST._IExpression _2222_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2223_onString;
            bool _2224_onOwned;
            bool _2225_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2226_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1443;
            bool _out1444;
            bool _out1445;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1446;
            DCOMP.COMP.GenExpr(_2222_on, selfIdent, @params, false, out _out1443, out _out1444, out _out1445, out _out1446);
            _2223_onString = _out1443;
            _2224_onOwned = _out1444;
            _2225_onErased = _out1445;
            _2226_recIdents = _out1446;
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
        } else if (_source74.is_Convert) {
          DAST._IExpression _2228___mcc_h60 = _source74.dtor_value;
          DAST._IType _2229___mcc_h61 = _source74.dtor_from;
          DAST._IType _2230___mcc_h62 = _source74.dtor_typ;
          bool _2231_isDatatype = _2154___mcc_h37;
          bool _2232_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2233_field = _2152___mcc_h35;
          DAST._IExpression _2234_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2235_onString;
            bool _2236_onOwned;
            bool _2237_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2238_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1447;
            bool _out1448;
            bool _out1449;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1450;
            DCOMP.COMP.GenExpr(_2234_on, selfIdent, @params, false, out _out1447, out _out1448, out _out1449, out _out1450);
            _2235_onString = _out1447;
            _2236_onOwned = _out1448;
            _2237_onErased = _out1449;
            _2238_recIdents = _out1450;
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
        } else if (_source74.is_SeqValue) {
          Dafny.ISequence<DAST._IExpression> _2240___mcc_h66 = _source74.dtor_elements;
          bool _2241_isDatatype = _2154___mcc_h37;
          bool _2242_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2243_field = _2152___mcc_h35;
          DAST._IExpression _2244_on = _2151___mcc_h34;
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
        } else if (_source74.is_SetValue) {
          Dafny.ISequence<DAST._IExpression> _2250___mcc_h68 = _source74.dtor_elements;
          bool _2251_isDatatype = _2154___mcc_h37;
          bool _2252_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2253_field = _2152___mcc_h35;
          DAST._IExpression _2254_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2255_onString;
            bool _2256_onOwned;
            bool _2257_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2258_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1455;
            bool _out1456;
            bool _out1457;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1458;
            DCOMP.COMP.GenExpr(_2254_on, selfIdent, @params, false, out _out1455, out _out1456, out _out1457, out _out1458);
            _2255_onString = _out1455;
            _2256_onOwned = _out1456;
            _2257_onErased = _out1457;
            _2258_recIdents = _out1458;
            if (!(_2257_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2259_eraseFn;
              _2259_eraseFn = ((_2256_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2255_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2259_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2255_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2251_isDatatype) || (_2252_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2255_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2253_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2252_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2255_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2253_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2258_recIdents;
          }
        } else if (_source74.is_MapValue) {
          Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2260___mcc_h70 = _source74.dtor_mapElems;
          bool _2261_isDatatype = _2154___mcc_h37;
          bool _2262_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2263_field = _2152___mcc_h35;
          DAST._IExpression _2264_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2265_onString;
            bool _2266_onOwned;
            bool _2267_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2268_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1459;
            bool _out1460;
            bool _out1461;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1462;
            DCOMP.COMP.GenExpr(_2264_on, selfIdent, @params, false, out _out1459, out _out1460, out _out1461, out _out1462);
            _2265_onString = _out1459;
            _2266_onOwned = _out1460;
            _2267_onErased = _out1461;
            _2268_recIdents = _out1462;
            if (!(_2267_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2269_eraseFn;
              _2269_eraseFn = ((_2266_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2265_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2269_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2265_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2261_isDatatype) || (_2262_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2265_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2263_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2262_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2265_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2263_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2268_recIdents;
          }
        } else if (_source74.is_This) {
          bool _2270_isDatatype = _2154___mcc_h37;
          bool _2271_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2272_field = _2152___mcc_h35;
          DAST._IExpression _2273_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2274_onString;
            bool _2275_onOwned;
            bool _2276_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2277_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1463;
            bool _out1464;
            bool _out1465;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1466;
            DCOMP.COMP.GenExpr(_2273_on, selfIdent, @params, false, out _out1463, out _out1464, out _out1465, out _out1466);
            _2274_onString = _out1463;
            _2275_onOwned = _out1464;
            _2276_onErased = _out1465;
            _2277_recIdents = _out1466;
            if (!(_2276_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2278_eraseFn;
              _2278_eraseFn = ((_2275_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2274_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2278_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2274_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2270_isDatatype) || (_2271_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2274_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2272_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2271_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2274_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2272_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2277_recIdents;
          }
        } else if (_source74.is_Ite) {
          DAST._IExpression _2279___mcc_h72 = _source74.dtor_cond;
          DAST._IExpression _2280___mcc_h73 = _source74.dtor_thn;
          DAST._IExpression _2281___mcc_h74 = _source74.dtor_els;
          bool _2282_isDatatype = _2154___mcc_h37;
          bool _2283_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2284_field = _2152___mcc_h35;
          DAST._IExpression _2285_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2286_onString;
            bool _2287_onOwned;
            bool _2288_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2289_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1467;
            bool _out1468;
            bool _out1469;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1470;
            DCOMP.COMP.GenExpr(_2285_on, selfIdent, @params, false, out _out1467, out _out1468, out _out1469, out _out1470);
            _2286_onString = _out1467;
            _2287_onOwned = _out1468;
            _2288_onErased = _out1469;
            _2289_recIdents = _out1470;
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
        } else if (_source74.is_UnOp) {
          DAST._IUnaryOp _2291___mcc_h78 = _source74.dtor_unOp;
          DAST._IExpression _2292___mcc_h79 = _source74.dtor_expr;
          bool _2293_isDatatype = _2154___mcc_h37;
          bool _2294_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2295_field = _2152___mcc_h35;
          DAST._IExpression _2296_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2297_onString;
            bool _2298_onOwned;
            bool _2299_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2300_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1471;
            bool _out1472;
            bool _out1473;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1474;
            DCOMP.COMP.GenExpr(_2296_on, selfIdent, @params, false, out _out1471, out _out1472, out _out1473, out _out1474);
            _2297_onString = _out1471;
            _2298_onOwned = _out1472;
            _2299_onErased = _out1473;
            _2300_recIdents = _out1474;
            if (!(_2299_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2301_eraseFn;
              _2301_eraseFn = ((_2298_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2297_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2301_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2297_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2293_isDatatype) || (_2294_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2297_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2295_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2294_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2297_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2295_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2300_recIdents;
          }
        } else if (_source74.is_BinOp) {
          Dafny.ISequence<Dafny.Rune> _2302___mcc_h82 = _source74.dtor_op;
          DAST._IExpression _2303___mcc_h83 = _source74.dtor_left;
          DAST._IExpression _2304___mcc_h84 = _source74.dtor_right;
          bool _2305_isDatatype = _2154___mcc_h37;
          bool _2306_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2307_field = _2152___mcc_h35;
          DAST._IExpression _2308_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2309_onString;
            bool _2310_onOwned;
            bool _2311_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2312_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1475;
            bool _out1476;
            bool _out1477;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1478;
            DCOMP.COMP.GenExpr(_2308_on, selfIdent, @params, false, out _out1475, out _out1476, out _out1477, out _out1478);
            _2309_onString = _out1475;
            _2310_onOwned = _out1476;
            _2311_onErased = _out1477;
            _2312_recIdents = _out1478;
            if (!(_2311_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2313_eraseFn;
              _2313_eraseFn = ((_2310_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2309_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2313_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2309_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2305_isDatatype) || (_2306_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2309_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2307_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2306_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2309_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2307_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2312_recIdents;
          }
        } else if (_source74.is_ArrayLen) {
          DAST._IExpression _2314___mcc_h88 = _source74.dtor_expr;
          bool _2315_isDatatype = _2154___mcc_h37;
          bool _2316_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2317_field = _2152___mcc_h35;
          DAST._IExpression _2318_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2319_onString;
            bool _2320_onOwned;
            bool _2321_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2322_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1479;
            bool _out1480;
            bool _out1481;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1482;
            DCOMP.COMP.GenExpr(_2318_on, selfIdent, @params, false, out _out1479, out _out1480, out _out1481, out _out1482);
            _2319_onString = _out1479;
            _2320_onOwned = _out1480;
            _2321_onErased = _out1481;
            _2322_recIdents = _out1482;
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
        } else if (_source74.is_Select) {
          DAST._IExpression _2324___mcc_h90 = _source74.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2325___mcc_h91 = _source74.dtor_field;
          bool _2326___mcc_h92 = _source74.dtor_isConstant;
          bool _2327___mcc_h93 = _source74.dtor_onDatatype;
          bool _2328_isDatatype = _2154___mcc_h37;
          bool _2329_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2330_field = _2152___mcc_h35;
          DAST._IExpression _2331_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2332_onString;
            bool _2333_onOwned;
            bool _2334_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2335_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1483;
            bool _out1484;
            bool _out1485;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1486;
            DCOMP.COMP.GenExpr(_2331_on, selfIdent, @params, false, out _out1483, out _out1484, out _out1485, out _out1486);
            _2332_onString = _out1483;
            _2333_onOwned = _out1484;
            _2334_onErased = _out1485;
            _2335_recIdents = _out1486;
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
        } else if (_source74.is_SelectFn) {
          DAST._IExpression _2337___mcc_h98 = _source74.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2338___mcc_h99 = _source74.dtor_field;
          bool _2339___mcc_h100 = _source74.dtor_onDatatype;
          bool _2340___mcc_h101 = _source74.dtor_isStatic;
          BigInteger _2341___mcc_h102 = _source74.dtor_arity;
          bool _2342_isDatatype = _2154___mcc_h37;
          bool _2343_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2344_field = _2152___mcc_h35;
          DAST._IExpression _2345_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2346_onString;
            bool _2347_onOwned;
            bool _2348_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2349_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1487;
            bool _out1488;
            bool _out1489;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1490;
            DCOMP.COMP.GenExpr(_2345_on, selfIdent, @params, false, out _out1487, out _out1488, out _out1489, out _out1490);
            _2346_onString = _out1487;
            _2347_onOwned = _out1488;
            _2348_onErased = _out1489;
            _2349_recIdents = _out1490;
            if (!(_2348_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2350_eraseFn;
              _2350_eraseFn = ((_2347_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2346_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2350_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2346_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2342_isDatatype) || (_2343_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2346_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2344_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2343_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2346_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2344_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2349_recIdents;
          }
        } else if (_source74.is_Index) {
          DAST._IExpression _2351___mcc_h108 = _source74.dtor_expr;
          DAST._ICollKind _2352___mcc_h109 = _source74.dtor_collKind;
          Dafny.ISequence<DAST._IExpression> _2353___mcc_h110 = _source74.dtor_indices;
          bool _2354_isDatatype = _2154___mcc_h37;
          bool _2355_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2356_field = _2152___mcc_h35;
          DAST._IExpression _2357_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2358_onString;
            bool _2359_onOwned;
            bool _2360_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2361_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1491;
            bool _out1492;
            bool _out1493;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1494;
            DCOMP.COMP.GenExpr(_2357_on, selfIdent, @params, false, out _out1491, out _out1492, out _out1493, out _out1494);
            _2358_onString = _out1491;
            _2359_onOwned = _out1492;
            _2360_onErased = _out1493;
            _2361_recIdents = _out1494;
            if (!(_2360_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2362_eraseFn;
              _2362_eraseFn = ((_2359_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2358_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2362_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2358_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2354_isDatatype) || (_2355_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2358_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2356_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2355_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2358_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2356_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2361_recIdents;
          }
        } else if (_source74.is_IndexRange) {
          DAST._IExpression _2363___mcc_h114 = _source74.dtor_expr;
          bool _2364___mcc_h115 = _source74.dtor_isArray;
          DAST._IOptional<DAST._IExpression> _2365___mcc_h116 = _source74.dtor_low;
          DAST._IOptional<DAST._IExpression> _2366___mcc_h117 = _source74.dtor_high;
          bool _2367_isDatatype = _2154___mcc_h37;
          bool _2368_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2369_field = _2152___mcc_h35;
          DAST._IExpression _2370_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2371_onString;
            bool _2372_onOwned;
            bool _2373_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2374_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1495;
            bool _out1496;
            bool _out1497;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1498;
            DCOMP.COMP.GenExpr(_2370_on, selfIdent, @params, false, out _out1495, out _out1496, out _out1497, out _out1498);
            _2371_onString = _out1495;
            _2372_onOwned = _out1496;
            _2373_onErased = _out1497;
            _2374_recIdents = _out1498;
            if (!(_2373_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2375_eraseFn;
              _2375_eraseFn = ((_2372_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2371_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2375_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2371_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2367_isDatatype) || (_2368_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2371_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2369_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2368_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2371_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2369_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2374_recIdents;
          }
        } else if (_source74.is_TupleSelect) {
          DAST._IExpression _2376___mcc_h122 = _source74.dtor_expr;
          BigInteger _2377___mcc_h123 = _source74.dtor_index;
          bool _2378_isDatatype = _2154___mcc_h37;
          bool _2379_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2380_field = _2152___mcc_h35;
          DAST._IExpression _2381_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2382_onString;
            bool _2383_onOwned;
            bool _2384_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2385_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1499;
            bool _out1500;
            bool _out1501;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1502;
            DCOMP.COMP.GenExpr(_2381_on, selfIdent, @params, false, out _out1499, out _out1500, out _out1501, out _out1502);
            _2382_onString = _out1499;
            _2383_onOwned = _out1500;
            _2384_onErased = _out1501;
            _2385_recIdents = _out1502;
            if (!(_2384_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2386_eraseFn;
              _2386_eraseFn = ((_2383_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2382_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2386_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2382_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2378_isDatatype) || (_2379_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2382_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2380_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2379_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2382_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2380_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2385_recIdents;
          }
        } else if (_source74.is_Call) {
          DAST._IExpression _2387___mcc_h126 = _source74.dtor_on;
          Dafny.ISequence<Dafny.Rune> _2388___mcc_h127 = _source74.dtor_name;
          Dafny.ISequence<DAST._IType> _2389___mcc_h128 = _source74.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _2390___mcc_h129 = _source74.dtor_args;
          bool _2391_isDatatype = _2154___mcc_h37;
          bool _2392_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2393_field = _2152___mcc_h35;
          DAST._IExpression _2394_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2395_onString;
            bool _2396_onOwned;
            bool _2397_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2398_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1503;
            bool _out1504;
            bool _out1505;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1506;
            DCOMP.COMP.GenExpr(_2394_on, selfIdent, @params, false, out _out1503, out _out1504, out _out1505, out _out1506);
            _2395_onString = _out1503;
            _2396_onOwned = _out1504;
            _2397_onErased = _out1505;
            _2398_recIdents = _out1506;
            if (!(_2397_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2399_eraseFn;
              _2399_eraseFn = ((_2396_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2395_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2399_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2395_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2391_isDatatype) || (_2392_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2395_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2393_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2392_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2395_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2393_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2398_recIdents;
          }
        } else if (_source74.is_Lambda) {
          Dafny.ISequence<DAST._IFormal> _2400___mcc_h134 = _source74.dtor_params;
          DAST._IType _2401___mcc_h135 = _source74.dtor_retType;
          Dafny.ISequence<DAST._IStatement> _2402___mcc_h136 = _source74.dtor_body;
          bool _2403_isDatatype = _2154___mcc_h37;
          bool _2404_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2405_field = _2152___mcc_h35;
          DAST._IExpression _2406_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2407_onString;
            bool _2408_onOwned;
            bool _2409_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2410_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1507;
            bool _out1508;
            bool _out1509;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1510;
            DCOMP.COMP.GenExpr(_2406_on, selfIdent, @params, false, out _out1507, out _out1508, out _out1509, out _out1510);
            _2407_onString = _out1507;
            _2408_onOwned = _out1508;
            _2409_onErased = _out1509;
            _2410_recIdents = _out1510;
            if (!(_2409_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2411_eraseFn;
              _2411_eraseFn = ((_2408_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2407_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2411_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2407_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2403_isDatatype) || (_2404_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2407_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2405_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2404_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2407_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2405_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2410_recIdents;
          }
        } else if (_source74.is_BetaRedex) {
          Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2412___mcc_h140 = _source74.dtor_values;
          DAST._IType _2413___mcc_h141 = _source74.dtor_retType;
          DAST._IExpression _2414___mcc_h142 = _source74.dtor_expr;
          bool _2415_isDatatype = _2154___mcc_h37;
          bool _2416_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2417_field = _2152___mcc_h35;
          DAST._IExpression _2418_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2419_onString;
            bool _2420_onOwned;
            bool _2421_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2422_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1511;
            bool _out1512;
            bool _out1513;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1514;
            DCOMP.COMP.GenExpr(_2418_on, selfIdent, @params, false, out _out1511, out _out1512, out _out1513, out _out1514);
            _2419_onString = _out1511;
            _2420_onOwned = _out1512;
            _2421_onErased = _out1513;
            _2422_recIdents = _out1514;
            if (!(_2421_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2423_eraseFn;
              _2423_eraseFn = ((_2420_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2419_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2423_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2419_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2415_isDatatype) || (_2416_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2419_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2417_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2416_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2419_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2417_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2422_recIdents;
          }
        } else if (_source74.is_IIFE) {
          Dafny.ISequence<Dafny.Rune> _2424___mcc_h146 = _source74.dtor_name;
          DAST._IType _2425___mcc_h147 = _source74.dtor_typ;
          DAST._IExpression _2426___mcc_h148 = _source74.dtor_value;
          DAST._IExpression _2427___mcc_h149 = _source74.dtor_iifeBody;
          bool _2428_isDatatype = _2154___mcc_h37;
          bool _2429_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2430_field = _2152___mcc_h35;
          DAST._IExpression _2431_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2432_onString;
            bool _2433_onOwned;
            bool _2434_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2435_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1515;
            bool _out1516;
            bool _out1517;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1518;
            DCOMP.COMP.GenExpr(_2431_on, selfIdent, @params, false, out _out1515, out _out1516, out _out1517, out _out1518);
            _2432_onString = _out1515;
            _2433_onOwned = _out1516;
            _2434_onErased = _out1517;
            _2435_recIdents = _out1518;
            if (!(_2434_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2436_eraseFn;
              _2436_eraseFn = ((_2433_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2432_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2436_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2432_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2428_isDatatype) || (_2429_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2432_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2430_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2429_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2432_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2430_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2435_recIdents;
          }
        } else if (_source74.is_Apply) {
          DAST._IExpression _2437___mcc_h154 = _source74.dtor_expr;
          Dafny.ISequence<DAST._IExpression> _2438___mcc_h155 = _source74.dtor_args;
          bool _2439_isDatatype = _2154___mcc_h37;
          bool _2440_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2441_field = _2152___mcc_h35;
          DAST._IExpression _2442_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2443_onString;
            bool _2444_onOwned;
            bool _2445_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2446_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1519;
            bool _out1520;
            bool _out1521;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1522;
            DCOMP.COMP.GenExpr(_2442_on, selfIdent, @params, false, out _out1519, out _out1520, out _out1521, out _out1522);
            _2443_onString = _out1519;
            _2444_onOwned = _out1520;
            _2445_onErased = _out1521;
            _2446_recIdents = _out1522;
            if (!(_2445_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2447_eraseFn;
              _2447_eraseFn = ((_2444_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2443_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2447_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2443_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2439_isDatatype) || (_2440_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2443_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2441_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2440_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2443_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2441_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2446_recIdents;
          }
        } else if (_source74.is_TypeTest) {
          DAST._IExpression _2448___mcc_h158 = _source74.dtor_on;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2449___mcc_h159 = _source74.dtor_dType;
          Dafny.ISequence<Dafny.Rune> _2450___mcc_h160 = _source74.dtor_variant;
          bool _2451_isDatatype = _2154___mcc_h37;
          bool _2452_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2453_field = _2152___mcc_h35;
          DAST._IExpression _2454_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2455_onString;
            bool _2456_onOwned;
            bool _2457_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2458_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1523;
            bool _out1524;
            bool _out1525;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1526;
            DCOMP.COMP.GenExpr(_2454_on, selfIdent, @params, false, out _out1523, out _out1524, out _out1525, out _out1526);
            _2455_onString = _out1523;
            _2456_onOwned = _out1524;
            _2457_onErased = _out1525;
            _2458_recIdents = _out1526;
            if (!(_2457_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2459_eraseFn;
              _2459_eraseFn = ((_2456_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2455_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2459_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2455_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2451_isDatatype) || (_2452_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2455_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2453_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2452_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2455_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2453_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2458_recIdents;
          }
        } else {
          DAST._IType _2460___mcc_h164 = _source74.dtor_typ;
          bool _2461_isDatatype = _2154___mcc_h37;
          bool _2462_isConstant = _2153___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2463_field = _2152___mcc_h35;
          DAST._IExpression _2464_on = _2151___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2465_onString;
            bool _2466_onOwned;
            bool _2467_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2468_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1527;
            bool _out1528;
            bool _out1529;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1530;
            DCOMP.COMP.GenExpr(_2464_on, selfIdent, @params, false, out _out1527, out _out1528, out _out1529, out _out1530);
            _2465_onString = _out1527;
            _2466_onOwned = _out1528;
            _2467_onErased = _out1529;
            _2468_recIdents = _out1530;
            if (!(_2467_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2469_eraseFn;
              _2469_eraseFn = ((_2466_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2465_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2469_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2465_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2461_isDatatype) || (_2462_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2465_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2463_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2462_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2465_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2463_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2468_recIdents;
          }
        }
      } else if (_source22.is_SelectFn) {
        DAST._IExpression _2470___mcc_h166 = _source22.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2471___mcc_h167 = _source22.dtor_field;
        bool _2472___mcc_h168 = _source22.dtor_onDatatype;
        bool _2473___mcc_h169 = _source22.dtor_isStatic;
        BigInteger _2474___mcc_h170 = _source22.dtor_arity;
        BigInteger _2475_arity = _2474___mcc_h170;
        bool _2476_isStatic = _2473___mcc_h169;
        bool _2477_isDatatype = _2472___mcc_h168;
        Dafny.ISequence<Dafny.Rune> _2478_field = _2471___mcc_h167;
        DAST._IExpression _2479_on = _2470___mcc_h166;
        {
          Dafny.ISequence<Dafny.Rune> _2480_onString;
          bool _2481_onOwned;
          bool _2482___v80;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2483_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1531;
          bool _out1532;
          bool _out1533;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1534;
          DCOMP.COMP.GenExpr(_2479_on, selfIdent, @params, false, out _out1531, out _out1532, out _out1533, out _out1534);
          _2480_onString = _out1531;
          _2481_onOwned = _out1532;
          _2482___v80 = _out1533;
          _2483_recIdents = _out1534;
          if (_2476_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2480_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2478_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2480_onString), ((_2481_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2484_args;
            _2484_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2485_i;
            _2485_i = BigInteger.Zero;
            while ((_2485_i) < (_2475_arity)) {
              if ((_2485_i).Sign == 1) {
                _2484_args = Dafny.Sequence<Dafny.Rune>.Concat(_2484_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2484_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2484_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2485_i));
              _2485_i = (_2485_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2484_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2478_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2484_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper(::std::rc::Rc::new("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
          readIdents = _2483_recIdents;
        }
      } else if (_source22.is_Index) {
        DAST._IExpression _2486___mcc_h171 = _source22.dtor_expr;
        DAST._ICollKind _2487___mcc_h172 = _source22.dtor_collKind;
        Dafny.ISequence<DAST._IExpression> _2488___mcc_h173 = _source22.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _2489_indices = _2488___mcc_h173;
        DAST._ICollKind _2490_collKind = _2487___mcc_h172;
        DAST._IExpression _2491_on = _2486___mcc_h171;
        {
          Dafny.ISequence<Dafny.Rune> _2492_onString;
          bool _2493_onOwned;
          bool _2494_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2495_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1535;
          bool _out1536;
          bool _out1537;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1538;
          DCOMP.COMP.GenExpr(_2491_on, selfIdent, @params, false, out _out1535, out _out1536, out _out1537, out _out1538);
          _2492_onString = _out1535;
          _2493_onOwned = _out1536;
          _2494_onErased = _out1537;
          _2495_recIdents = _out1538;
          readIdents = _2495_recIdents;
          if (!(_2494_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2496_eraseFn;
            _2496_eraseFn = ((_2493_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2492_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2496_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2492_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2492_onString;
          BigInteger _2497_i;
          _2497_i = BigInteger.Zero;
          while ((_2497_i) < (new BigInteger((_2489_indices).Count))) {
            if (object.Equals(_2490_collKind, DAST.CollKind.create_Array())) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
            }
            if (object.Equals(_2490_collKind, DAST.CollKind.create_Map())) {
              Dafny.ISequence<Dafny.Rune> _2498_idx;
              bool _2499_idxOwned;
              bool _2500_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2501_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1539;
              bool _out1540;
              bool _out1541;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1542;
              DCOMP.COMP.GenExpr((_2489_indices).Select(_2497_i), selfIdent, @params, false, out _out1539, out _out1540, out _out1541, out _out1542);
              _2498_idx = _out1539;
              _2499_idxOwned = _out1540;
              _2500_idxErased = _out1541;
              _2501_recIdentsIdx = _out1542;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[")), ((_2499_idxOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _2498_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2501_recIdentsIdx);
            } else {
              Dafny.ISequence<Dafny.Rune> _2502_idx;
              bool _2503___v81;
              bool _2504_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2505_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1543;
              bool _out1544;
              bool _out1545;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1546;
              DCOMP.COMP.GenExpr((_2489_indices).Select(_2497_i), selfIdent, @params, true, out _out1543, out _out1544, out _out1545, out _out1546);
              _2502_idx = _out1543;
              _2503___v81 = _out1544;
              _2504_idxErased = _out1545;
              _2505_recIdentsIdx = _out1546;
              if (!(_2504_idxErased)) {
                _2502_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2502_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[<usize as ::dafny_runtime::NumCast>::from(")), _2502_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2505_recIdentsIdx);
            }
            _2497_i = (_2497_i) + (BigInteger.One);
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = _2494_onErased;
        }
      } else if (_source22.is_IndexRange) {
        DAST._IExpression _2506___mcc_h174 = _source22.dtor_expr;
        bool _2507___mcc_h175 = _source22.dtor_isArray;
        DAST._IOptional<DAST._IExpression> _2508___mcc_h176 = _source22.dtor_low;
        DAST._IOptional<DAST._IExpression> _2509___mcc_h177 = _source22.dtor_high;
        DAST._IOptional<DAST._IExpression> _2510_high = _2509___mcc_h177;
        DAST._IOptional<DAST._IExpression> _2511_low = _2508___mcc_h176;
        bool _2512_isArray = _2507___mcc_h175;
        DAST._IExpression _2513_on = _2506___mcc_h174;
        {
          Dafny.ISequence<Dafny.Rune> _2514_onString;
          bool _2515_onOwned;
          bool _2516_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2517_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1547;
          bool _out1548;
          bool _out1549;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1550;
          DCOMP.COMP.GenExpr(_2513_on, selfIdent, @params, false, out _out1547, out _out1548, out _out1549, out _out1550);
          _2514_onString = _out1547;
          _2515_onOwned = _out1548;
          _2516_onErased = _out1549;
          _2517_recIdents = _out1550;
          readIdents = _2517_recIdents;
          if (!(_2516_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2518_eraseFn;
            _2518_eraseFn = ((_2515_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2514_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2518_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2514_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2514_onString;
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2519_lowString;
          _2519_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source75 = _2511_low;
          if (_source75.is_Some) {
            DAST._IExpression _2520___mcc_h1067 = _source75.dtor_Some_a0;
            DAST._IExpression _2521_l = _2520___mcc_h1067;
            {
              Dafny.ISequence<Dafny.Rune> _2522_lString;
              bool _2523___v82;
              bool _2524_lErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2525_recIdentsL;
              Dafny.ISequence<Dafny.Rune> _out1551;
              bool _out1552;
              bool _out1553;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1554;
              DCOMP.COMP.GenExpr(_2521_l, selfIdent, @params, true, out _out1551, out _out1552, out _out1553, out _out1554);
              _2522_lString = _out1551;
              _2523___v82 = _out1552;
              _2524_lErased = _out1553;
              _2525_recIdentsL = _out1554;
              if (!(_2524_lErased)) {
                _2522_lString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2522_lString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2519_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2522_lString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2525_recIdentsL);
            }
          } else {
          }
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2526_highString;
          _2526_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source76 = _2510_high;
          if (_source76.is_Some) {
            DAST._IExpression _2527___mcc_h1068 = _source76.dtor_Some_a0;
            DAST._IExpression _2528_h = _2527___mcc_h1068;
            {
              Dafny.ISequence<Dafny.Rune> _2529_hString;
              bool _2530___v83;
              bool _2531_hErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2532_recIdentsH;
              Dafny.ISequence<Dafny.Rune> _out1555;
              bool _out1556;
              bool _out1557;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1558;
              DCOMP.COMP.GenExpr(_2528_h, selfIdent, @params, true, out _out1555, out _out1556, out _out1557, out _out1558);
              _2529_hString = _out1555;
              _2530___v83 = _out1556;
              _2531_hErased = _out1557;
              _2532_recIdentsH = _out1558;
              if (!(_2531_hErased)) {
                _2529_hString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2529_hString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2526_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2529_hString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2532_recIdentsH);
            }
          } else {
          }
          if (_2512_isArray) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source77) => {
            if (_source77.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2533___mcc_h1069 = _source77.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2533___mcc_h1069, _pat_let0_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let0_0, _2534_l => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2534_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2519_lowString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("..")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source78) => {
            if (_source78.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2535___mcc_h1070 = _source78.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2535___mcc_h1070, _pat_let1_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let1_0, _2536_h => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2536_h), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2526_highString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isErased = _2516_onErased;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".to_vec())"));
          isOwned = true;
        }
      } else if (_source22.is_TupleSelect) {
        DAST._IExpression _2537___mcc_h178 = _source22.dtor_expr;
        BigInteger _2538___mcc_h179 = _source22.dtor_index;
        BigInteger _2539_idx = _2538___mcc_h179;
        DAST._IExpression _2540_on = _2537___mcc_h178;
        {
          Dafny.ISequence<Dafny.Rune> _2541_onString;
          bool _2542___v84;
          bool _2543_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2544_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1559;
          bool _out1560;
          bool _out1561;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1562;
          DCOMP.COMP.GenExpr(_2540_on, selfIdent, @params, false, out _out1559, out _out1560, out _out1561, out _out1562);
          _2541_onString = _out1559;
          _2542___v84 = _out1560;
          _2543_tupErased = _out1561;
          _2544_recIdents = _out1562;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2541_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2539_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2543_tupErased;
          readIdents = _2544_recIdents;
        }
      } else if (_source22.is_Call) {
        DAST._IExpression _2545___mcc_h180 = _source22.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2546___mcc_h181 = _source22.dtor_name;
        Dafny.ISequence<DAST._IType> _2547___mcc_h182 = _source22.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2548___mcc_h183 = _source22.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2549_args = _2548___mcc_h183;
        Dafny.ISequence<DAST._IType> _2550_typeArgs = _2547___mcc_h182;
        Dafny.ISequence<Dafny.Rune> _2551_name = _2546___mcc_h181;
        DAST._IExpression _2552_on = _2545___mcc_h180;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2553_typeArgString;
          _2553_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2550_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2554_typeI;
            _2554_typeI = BigInteger.Zero;
            _2553_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2554_typeI) < (new BigInteger((_2550_typeArgs).Count))) {
              if ((_2554_typeI).Sign == 1) {
                _2553_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2553_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2555_typeString;
              Dafny.ISequence<Dafny.Rune> _out1563;
              _out1563 = DCOMP.COMP.GenType((_2550_typeArgs).Select(_2554_typeI), false, false);
              _2555_typeString = _out1563;
              _2553_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2553_typeArgString, _2555_typeString);
              _2554_typeI = (_2554_typeI) + (BigInteger.One);
            }
            _2553_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2553_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2556_argString;
          _2556_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2557_i;
          _2557_i = BigInteger.Zero;
          while ((_2557_i) < (new BigInteger((_2549_args).Count))) {
            if ((_2557_i).Sign == 1) {
              _2556_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2556_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2558_argExpr;
            bool _2559_isOwned;
            bool _2560_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2561_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1564;
            bool _out1565;
            bool _out1566;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1567;
            DCOMP.COMP.GenExpr((_2549_args).Select(_2557_i), selfIdent, @params, false, out _out1564, out _out1565, out _out1566, out _out1567);
            _2558_argExpr = _out1564;
            _2559_isOwned = _out1565;
            _2560_argErased = _out1566;
            _2561_argIdents = _out1567;
            if (_2559_isOwned) {
              _2558_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2558_argExpr);
            }
            _2556_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2556_argString, _2558_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2561_argIdents);
            _2557_i = (_2557_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2562_enclosingString;
          bool _2563___v85;
          bool _2564___v86;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2565_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1568;
          bool _out1569;
          bool _out1570;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1571;
          DCOMP.COMP.GenExpr(_2552_on, selfIdent, @params, false, out _out1568, out _out1569, out _out1570, out _out1571);
          _2562_enclosingString = _out1568;
          _2563___v85 = _out1569;
          _2564___v86 = _out1570;
          _2565_recIdents = _out1571;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2565_recIdents);
          DAST._IExpression _source79 = _2552_on;
          if (_source79.is_Literal) {
            DAST._ILiteral _2566___mcc_h1071 = _source79.dtor_Literal_a0;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2567___mcc_h1073 = _source79.dtor_Ident_a0;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2568___mcc_h1075 = _source79.dtor_Companion_a0;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2562_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (_2551_name));
            }
          } else if (_source79.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2569___mcc_h1077 = _source79.dtor_Tuple_a0;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2570___mcc_h1079 = _source79.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2571___mcc_h1080 = _source79.dtor_args;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2572___mcc_h1083 = _source79.dtor_dims;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2573___mcc_h1085 = _source79.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2574___mcc_h1086 = _source79.dtor_variant;
            bool _2575___mcc_h1087 = _source79.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2576___mcc_h1088 = _source79.dtor_contents;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_Convert) {
            DAST._IExpression _2577___mcc_h1093 = _source79.dtor_value;
            DAST._IType _2578___mcc_h1094 = _source79.dtor_from;
            DAST._IType _2579___mcc_h1095 = _source79.dtor_typ;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2580___mcc_h1099 = _source79.dtor_elements;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2581___mcc_h1101 = _source79.dtor_elements;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2582___mcc_h1103 = _source79.dtor_mapElems;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_This) {
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_Ite) {
            DAST._IExpression _2583___mcc_h1105 = _source79.dtor_cond;
            DAST._IExpression _2584___mcc_h1106 = _source79.dtor_thn;
            DAST._IExpression _2585___mcc_h1107 = _source79.dtor_els;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_UnOp) {
            DAST._IUnaryOp _2586___mcc_h1111 = _source79.dtor_unOp;
            DAST._IExpression _2587___mcc_h1112 = _source79.dtor_expr;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2588___mcc_h1115 = _source79.dtor_op;
            DAST._IExpression _2589___mcc_h1116 = _source79.dtor_left;
            DAST._IExpression _2590___mcc_h1117 = _source79.dtor_right;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_ArrayLen) {
            DAST._IExpression _2591___mcc_h1121 = _source79.dtor_expr;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_Select) {
            DAST._IExpression _2592___mcc_h1123 = _source79.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2593___mcc_h1124 = _source79.dtor_field;
            bool _2594___mcc_h1125 = _source79.dtor_isConstant;
            bool _2595___mcc_h1126 = _source79.dtor_onDatatype;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_SelectFn) {
            DAST._IExpression _2596___mcc_h1131 = _source79.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2597___mcc_h1132 = _source79.dtor_field;
            bool _2598___mcc_h1133 = _source79.dtor_onDatatype;
            bool _2599___mcc_h1134 = _source79.dtor_isStatic;
            BigInteger _2600___mcc_h1135 = _source79.dtor_arity;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_Index) {
            DAST._IExpression _2601___mcc_h1141 = _source79.dtor_expr;
            DAST._ICollKind _2602___mcc_h1142 = _source79.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _2603___mcc_h1143 = _source79.dtor_indices;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_IndexRange) {
            DAST._IExpression _2604___mcc_h1147 = _source79.dtor_expr;
            bool _2605___mcc_h1148 = _source79.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _2606___mcc_h1149 = _source79.dtor_low;
            DAST._IOptional<DAST._IExpression> _2607___mcc_h1150 = _source79.dtor_high;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_TupleSelect) {
            DAST._IExpression _2608___mcc_h1155 = _source79.dtor_expr;
            BigInteger _2609___mcc_h1156 = _source79.dtor_index;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_Call) {
            DAST._IExpression _2610___mcc_h1159 = _source79.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2611___mcc_h1160 = _source79.dtor_name;
            Dafny.ISequence<DAST._IType> _2612___mcc_h1161 = _source79.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2613___mcc_h1162 = _source79.dtor_args;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2614___mcc_h1167 = _source79.dtor_params;
            DAST._IType _2615___mcc_h1168 = _source79.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2616___mcc_h1169 = _source79.dtor_body;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2617___mcc_h1173 = _source79.dtor_values;
            DAST._IType _2618___mcc_h1174 = _source79.dtor_retType;
            DAST._IExpression _2619___mcc_h1175 = _source79.dtor_expr;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2620___mcc_h1179 = _source79.dtor_name;
            DAST._IType _2621___mcc_h1180 = _source79.dtor_typ;
            DAST._IExpression _2622___mcc_h1181 = _source79.dtor_value;
            DAST._IExpression _2623___mcc_h1182 = _source79.dtor_iifeBody;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_Apply) {
            DAST._IExpression _2624___mcc_h1187 = _source79.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2625___mcc_h1188 = _source79.dtor_args;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else if (_source79.is_TypeTest) {
            DAST._IExpression _2626___mcc_h1191 = _source79.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2627___mcc_h1192 = _source79.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2628___mcc_h1193 = _source79.dtor_variant;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          } else {
            DAST._IType _2629___mcc_h1197 = _source79.dtor_typ;
            {
              _2562_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2562_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2551_name));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2562_enclosingString, _2553_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2556_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source22.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2630___mcc_h184 = _source22.dtor_params;
        DAST._IType _2631___mcc_h185 = _source22.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2632___mcc_h186 = _source22.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2633_body = _2632___mcc_h186;
        DAST._IType _2634_retType = _2631___mcc_h185;
        Dafny.ISequence<DAST._IFormal> _2635_params = _2630___mcc_h184;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2636_paramNames;
          _2636_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2637_i;
          _2637_i = BigInteger.Zero;
          while ((_2637_i) < (new BigInteger((_2635_params).Count))) {
            _2636_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2636_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2635_params).Select(_2637_i)).dtor_name));
            _2637_i = (_2637_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2638_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2639_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1572;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1573;
          DCOMP.COMP.GenStmts(_2633_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2636_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1572, out _out1573);
          _2638_recursiveGen = _out1572;
          _2639_recIdents = _out1573;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2640_allReadCloned;
          _2640_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2639_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2641_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2639_recIdents).Elements) {
              _2641_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2639_recIdents).Contains(_2641_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1784)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2636_paramNames).Contains(_2641_next))) {
              _2640_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2640_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2641_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2641_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2641_next));
            }
            _2639_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2639_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2641_next));
          }
          Dafny.ISequence<Dafny.Rune> _2642_paramsString;
          _2642_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          Dafny.ISequence<Dafny.Rune> _2643_paramTypes;
          _2643_paramTypes = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2637_i = BigInteger.Zero;
          while ((_2637_i) < (new BigInteger((_2635_params).Count))) {
            if ((_2637_i).Sign == 1) {
              _2642_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2642_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              _2643_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(_2643_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2644_typStr;
            Dafny.ISequence<Dafny.Rune> _out1574;
            _out1574 = DCOMP.COMP.GenType(((_2635_params).Select(_2637_i)).dtor_typ, false, true);
            _2644_typStr = _out1574;
            _2642_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2642_paramsString, ((_2635_params).Select(_2637_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2644_typStr);
            _2643_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2643_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _2644_typStr);
            _2637_i = (_2637_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2645_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1575;
          _out1575 = DCOMP.COMP.GenType(_2634_retType, false, true);
          _2645_retTypeGen = _out1575;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper::<::std::rc::Rc<dyn Fn("), _2643_paramTypes), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _2645_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>({\n")), _2640_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(move |")), _2642_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2645_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2638_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source22.is_BetaRedex) {
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2646___mcc_h187 = _source22.dtor_values;
        DAST._IType _2647___mcc_h188 = _source22.dtor_retType;
        DAST._IExpression _2648___mcc_h189 = _source22.dtor_expr;
        DAST._IExpression _2649_expr = _2648___mcc_h189;
        DAST._IType _2650_retType = _2647___mcc_h188;
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2651_values = _2646___mcc_h187;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2652_paramNames;
          _2652_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2653_paramNamesSet;
          _2653_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2654_i;
          _2654_i = BigInteger.Zero;
          while ((_2654_i) < (new BigInteger((_2651_values).Count))) {
            _2652_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2652_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2651_values).Select(_2654_i)).dtor__0).dtor_name));
            _2653_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2653_paramNamesSet, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2651_values).Select(_2654_i)).dtor__0).dtor_name));
            _2654_i = (_2654_i) + (BigInteger.One);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          Dafny.ISequence<Dafny.Rune> _2655_paramsString;
          _2655_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2654_i = BigInteger.Zero;
          while ((_2654_i) < (new BigInteger((_2651_values).Count))) {
            if ((_2654_i).Sign == 1) {
              _2655_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2655_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2656_typStr;
            Dafny.ISequence<Dafny.Rune> _out1576;
            _out1576 = DCOMP.COMP.GenType((((_2651_values).Select(_2654_i)).dtor__0).dtor_typ, false, true);
            _2656_typStr = _out1576;
            Dafny.ISequence<Dafny.Rune> _2657_valueGen;
            bool _2658___v89;
            bool _2659_valueErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2660_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1577;
            bool _out1578;
            bool _out1579;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1580;
            DCOMP.COMP.GenExpr(((_2651_values).Select(_2654_i)).dtor__1, selfIdent, @params, true, out _out1577, out _out1578, out _out1579, out _out1580);
            _2657_valueGen = _out1577;
            _2658___v89 = _out1578;
            _2659_valueErased = _out1579;
            _2660_recIdents = _out1580;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), (((_2651_values).Select(_2654_i)).dtor__0).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _2656_typStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2660_recIdents);
            if (_2659_valueErased) {
              _2657_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2657_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2657_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            _2654_i = (_2654_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2661_recGen;
          bool _2662_recOwned;
          bool _2663_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2664_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1581;
          bool _out1582;
          bool _out1583;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1584;
          DCOMP.COMP.GenExpr(_2649_expr, selfIdent, _2652_paramNames, mustOwn, out _out1581, out _out1582, out _out1583, out _out1584);
          _2661_recGen = _out1581;
          _2662_recOwned = _out1582;
          _2663_recErased = _out1583;
          _2664_recIdents = _out1584;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2664_recIdents, _2653_paramNamesSet);
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2661_recGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2662_recOwned;
          isErased = _2663_recErased;
        }
      } else if (_source22.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2665___mcc_h190 = _source22.dtor_name;
        DAST._IType _2666___mcc_h191 = _source22.dtor_typ;
        DAST._IExpression _2667___mcc_h192 = _source22.dtor_value;
        DAST._IExpression _2668___mcc_h193 = _source22.dtor_iifeBody;
        DAST._IExpression _2669_iifeBody = _2668___mcc_h193;
        DAST._IExpression _2670_value = _2667___mcc_h192;
        DAST._IType _2671_tpe = _2666___mcc_h191;
        Dafny.ISequence<Dafny.Rune> _2672_name = _2665___mcc_h190;
        {
          Dafny.ISequence<Dafny.Rune> _2673_valueGen;
          bool _2674_valueOwned;
          bool _2675_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2676_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1585;
          bool _out1586;
          bool _out1587;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1588;
          DCOMP.COMP.GenExpr(_2670_value, selfIdent, @params, false, out _out1585, out _out1586, out _out1587, out _out1588);
          _2673_valueGen = _out1585;
          _2674_valueOwned = _out1586;
          _2675_valueErased = _out1587;
          _2676_recIdents = _out1588;
          if (_2675_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2677_eraseFn;
            _2677_eraseFn = ((_2674_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2673_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2677_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2673_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2676_recIdents;
          Dafny.ISequence<Dafny.Rune> _2678_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1589;
          _out1589 = DCOMP.COMP.GenType(_2671_tpe, false, true);
          _2678_valueTypeGen = _out1589;
          Dafny.ISequence<Dafny.Rune> _2679_bodyGen;
          bool _2680_bodyOwned;
          bool _2681_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2682_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1590;
          bool _out1591;
          bool _out1592;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1593;
          DCOMP.COMP.GenExpr(_2669_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2674_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2672_name))))), mustOwn, out _out1590, out _out1591, out _out1592, out _out1593);
          _2679_bodyGen = _out1590;
          _2680_bodyOwned = _out1591;
          _2681_bodyErased = _out1592;
          _2682_bodyIdents = _out1593;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2682_bodyIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_2672_name))));
          Dafny.ISequence<Dafny.Rune> _2683_eraseFn;
          _2683_eraseFn = ((_2674_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2672_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2674_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2678_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2673_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2679_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2680_bodyOwned;
          isErased = _2681_bodyErased;
        }
      } else if (_source22.is_Apply) {
        DAST._IExpression _2684___mcc_h194 = _source22.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2685___mcc_h195 = _source22.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2686_args = _2685___mcc_h195;
        DAST._IExpression _2687_func = _2684___mcc_h194;
        {
          Dafny.ISequence<Dafny.Rune> _2688_funcString;
          bool _2689___v90;
          bool _2690_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2691_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1594;
          bool _out1595;
          bool _out1596;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1597;
          DCOMP.COMP.GenExpr(_2687_func, selfIdent, @params, false, out _out1594, out _out1595, out _out1596, out _out1597);
          _2688_funcString = _out1594;
          _2689___v90 = _out1595;
          _2690_funcErased = _out1596;
          _2691_recIdents = _out1597;
          readIdents = _2691_recIdents;
          Dafny.ISequence<Dafny.Rune> _2692_argString;
          _2692_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2693_i;
          _2693_i = BigInteger.Zero;
          while ((_2693_i) < (new BigInteger((_2686_args).Count))) {
            if ((_2693_i).Sign == 1) {
              _2692_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2692_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2694_argExpr;
            bool _2695_isOwned;
            bool _2696_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2697_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1598;
            bool _out1599;
            bool _out1600;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1601;
            DCOMP.COMP.GenExpr((_2686_args).Select(_2693_i), selfIdent, @params, false, out _out1598, out _out1599, out _out1600, out _out1601);
            _2694_argExpr = _out1598;
            _2695_isOwned = _out1599;
            _2696_argErased = _out1600;
            _2697_argIdents = _out1601;
            if (_2695_isOwned) {
              _2694_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2694_argExpr);
            }
            _2692_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2692_argString, _2694_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2697_argIdents);
            _2693_i = (_2693_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2688_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2692_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source22.is_TypeTest) {
        DAST._IExpression _2698___mcc_h196 = _source22.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2699___mcc_h197 = _source22.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2700___mcc_h198 = _source22.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2701_variant = _2700___mcc_h198;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2702_dType = _2699___mcc_h197;
        DAST._IExpression _2703_on = _2698___mcc_h196;
        {
          Dafny.ISequence<Dafny.Rune> _2704_exprGen;
          bool _2705___v91;
          bool _2706_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2707_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1602;
          bool _out1603;
          bool _out1604;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1605;
          DCOMP.COMP.GenExpr(_2703_on, selfIdent, @params, false, out _out1602, out _out1603, out _out1604, out _out1605);
          _2704_exprGen = _out1602;
          _2705___v91 = _out1603;
          _2706_exprErased = _out1604;
          _2707_recIdents = _out1605;
          Dafny.ISequence<Dafny.Rune> _2708_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1606;
          _out1606 = DCOMP.COMP.GenPath(_2702_dType);
          _2708_dTypePath = _out1606;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2704_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2708_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2701_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2707_recIdents;
        }
      } else {
        DAST._IType _2709___mcc_h199 = _source22.dtor_typ;
        DAST._IType _2710_typ = _2709___mcc_h199;
        {
          Dafny.ISequence<Dafny.Rune> _2711_typString;
          Dafny.ISequence<Dafny.Rune> _out1607;
          _out1607 = DCOMP.COMP.GenType(_2710_typ, false, false);
          _2711_typString = _out1607;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2711_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2712_i;
      _2712_i = BigInteger.Zero;
      while ((_2712_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2713_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1608;
        _out1608 = DCOMP.COMP.GenModule((p).Select(_2712_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2713_generated = _out1608;
        if ((_2712_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2713_generated);
        _2712_i = (_2712_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2714_i;
      _2714_i = BigInteger.Zero;
      while ((_2714_i) < (new BigInteger((fullName).Count))) {
        if ((_2714_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2714_i));
        _2714_i = (_2714_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

