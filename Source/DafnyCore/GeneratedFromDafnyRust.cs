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
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _263___mcc_h9 = _source15.dtor_lbl;
        DAST._IExpression _264___mcc_h10 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _265___mcc_h11 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _266_body = _265___mcc_h11;
        DAST._IExpression _267_cond = _264___mcc_h10;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _268_lbl = _263___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _269_condString;
          bool _270___v16;
          bool _271_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _272_recIdents;
          Dafny.ISequence<Dafny.Rune> _out89;
          bool _out90;
          bool _out91;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out92;
          DCOMP.COMP.GenExpr(_267_cond, selfIdent, @params, true, out _out89, out _out90, out _out91, out _out92);
          _269_condString = _out89;
          _270___v16 = _out90;
          _271_condErased = _out91;
          _272_recIdents = _out92;
          if (!(_271_condErased)) {
            _269_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _269_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _272_recIdents;
          Dafny.ISequence<Dafny.Rune> _273_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _274_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out93;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
          DCOMP.COMP.GenStmts(_266_body, selfIdent, @params, false, earlyReturn, out _out93, out _out94);
          _273_bodyString = _out93;
          _274_bodyIdents = _out94;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _274_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _275_lblString;
          _275_lblString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source17 = _268_lbl;
          if (_source17.is_Some) {
            Dafny.ISequence<Dafny.Rune> _276___mcc_h21 = _source17.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _277_id = _276___mcc_h21;
            {
              _275_lblString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _277_id), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": "));
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_275_lblString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while ")), _269_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _273_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _278___mcc_h12 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _279___mcc_h13 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _280___mcc_h14 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _281___mcc_h15 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _282___mcc_h16 = _source15.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _283_maybeOutVars = _282___mcc_h16;
        Dafny.ISequence<DAST._IExpression> _284_args = _281___mcc_h15;
        Dafny.ISequence<DAST._IType> _285_typeArgs = _280___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _286_name = _279___mcc_h13;
        DAST._IExpression _287_on = _278___mcc_h12;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _288_typeArgString;
          _288_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_285_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _289_typeI;
            _289_typeI = BigInteger.Zero;
            _288_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_289_typeI) < (new BigInteger((_285_typeArgs).Count))) {
              if ((_289_typeI).Sign == 1) {
                _288_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_288_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _290_typeString;
              Dafny.ISequence<Dafny.Rune> _out95;
              _out95 = DCOMP.COMP.GenType((_285_typeArgs).Select(_289_typeI), false, false);
              _290_typeString = _out95;
              _288_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_288_typeArgString, _290_typeString);
              _289_typeI = (_289_typeI) + (BigInteger.One);
            }
            _288_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_288_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _291_argString;
          _291_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _292_i;
          _292_i = BigInteger.Zero;
          while ((_292_i) < (new BigInteger((_284_args).Count))) {
            if ((_292_i).Sign == 1) {
              _291_argString = Dafny.Sequence<Dafny.Rune>.Concat(_291_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _293_argExpr;
            bool _294_isOwned;
            bool _295_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _296_argIdents;
            Dafny.ISequence<Dafny.Rune> _out96;
            bool _out97;
            bool _out98;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out99;
            DCOMP.COMP.GenExpr((_284_args).Select(_292_i), selfIdent, @params, false, out _out96, out _out97, out _out98, out _out99);
            _293_argExpr = _out96;
            _294_isOwned = _out97;
            _295_argErased = _out98;
            _296_argIdents = _out99;
            if (_294_isOwned) {
              _293_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _293_argExpr);
            }
            _291_argString = Dafny.Sequence<Dafny.Rune>.Concat(_291_argString, _293_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _296_argIdents);
            _292_i = (_292_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _297_enclosingString;
          bool _298___v17;
          bool _299___v18;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _300_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out100;
          bool _out101;
          bool _out102;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out103;
          DCOMP.COMP.GenExpr(_287_on, selfIdent, @params, false, out _out100, out _out101, out _out102, out _out103);
          _297_enclosingString = _out100;
          _298___v17 = _out101;
          _299___v18 = _out102;
          _300_enclosingIdents = _out103;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _300_enclosingIdents);
          DAST._IExpression _source18 = _287_on;
          if (_source18.is_Literal) {
            DAST._ILiteral _301___mcc_h22 = _source18.dtor_Literal_a0;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _302___mcc_h24 = _source18.dtor_Ident_a0;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _303___mcc_h26 = _source18.dtor_Companion_a0;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_297_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source18.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _304___mcc_h28 = _source18.dtor_Tuple_a0;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _305___mcc_h30 = _source18.dtor_path;
            Dafny.ISequence<DAST._IExpression> _306___mcc_h31 = _source18.dtor_args;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _307___mcc_h34 = _source18.dtor_dims;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _308___mcc_h36 = _source18.dtor_path;
            Dafny.ISequence<Dafny.Rune> _309___mcc_h37 = _source18.dtor_variant;
            bool _310___mcc_h38 = _source18.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _311___mcc_h39 = _source18.dtor_contents;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Convert) {
            DAST._IExpression _312___mcc_h44 = _source18.dtor_value;
            DAST._IType _313___mcc_h45 = _source18.dtor_from;
            DAST._IType _314___mcc_h46 = _source18.dtor_typ;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _315___mcc_h50 = _source18.dtor_elements;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _316___mcc_h52 = _source18.dtor_elements;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_This) {
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ite) {
            DAST._IExpression _317___mcc_h54 = _source18.dtor_cond;
            DAST._IExpression _318___mcc_h55 = _source18.dtor_thn;
            DAST._IExpression _319___mcc_h56 = _source18.dtor_els;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_UnOp) {
            DAST._IUnaryOp _320___mcc_h60 = _source18.dtor_unOp;
            DAST._IExpression _321___mcc_h61 = _source18.dtor_expr;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _322___mcc_h64 = _source18.dtor_op;
            DAST._IExpression _323___mcc_h65 = _source18.dtor_left;
            DAST._IExpression _324___mcc_h66 = _source18.dtor_right;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Select) {
            DAST._IExpression _325___mcc_h70 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _326___mcc_h71 = _source18.dtor_field;
            bool _327___mcc_h72 = _source18.dtor_isConstant;
            bool _328___mcc_h73 = _source18.dtor_onDatatype;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SelectFn) {
            DAST._IExpression _329___mcc_h78 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _330___mcc_h79 = _source18.dtor_field;
            bool _331___mcc_h80 = _source18.dtor_onDatatype;
            bool _332___mcc_h81 = _source18.dtor_isStatic;
            BigInteger _333___mcc_h82 = _source18.dtor_arity;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Index) {
            DAST._IExpression _334___mcc_h88 = _source18.dtor_expr;
            DAST._IExpression _335___mcc_h89 = _source18.dtor_idx;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TupleSelect) {
            DAST._IExpression _336___mcc_h92 = _source18.dtor_expr;
            BigInteger _337___mcc_h93 = _source18.dtor_index;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Call) {
            DAST._IExpression _338___mcc_h96 = _source18.dtor_on;
            Dafny.ISequence<Dafny.Rune> _339___mcc_h97 = _source18.dtor_name;
            Dafny.ISequence<DAST._IType> _340___mcc_h98 = _source18.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _341___mcc_h99 = _source18.dtor_args;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _342___mcc_h104 = _source18.dtor_params;
            DAST._IType _343___mcc_h105 = _source18.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _344___mcc_h106 = _source18.dtor_body;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _345___mcc_h110 = _source18.dtor_name;
            DAST._IType _346___mcc_h111 = _source18.dtor_typ;
            DAST._IExpression _347___mcc_h112 = _source18.dtor_value;
            DAST._IExpression _348___mcc_h113 = _source18.dtor_iifeBody;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Apply) {
            DAST._IExpression _349___mcc_h118 = _source18.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _350___mcc_h119 = _source18.dtor_args;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TypeTest) {
            DAST._IExpression _351___mcc_h122 = _source18.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _352___mcc_h123 = _source18.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _353___mcc_h124 = _source18.dtor_variant;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _354___mcc_h128 = _source18.dtor_typ;
            {
              _297_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _355_receiver;
          _355_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source19 = _283_maybeOutVars;
          if (_source19.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _356___mcc_h130 = _source19.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _357_outVars = _356___mcc_h130;
            {
              if ((new BigInteger((_357_outVars).Count)) > (BigInteger.One)) {
                _355_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _358_outI;
              _358_outI = BigInteger.Zero;
              while ((_358_outI) < (new BigInteger((_357_outVars).Count))) {
                if ((_358_outI).Sign == 1) {
                  _355_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_355_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _359_outVar;
                _359_outVar = (_357_outVars).Select(_358_outI);
                _355_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_355_receiver, (_359_outVar));
                _358_outI = (_358_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_357_outVars).Count)) > (BigInteger.One)) {
                _355_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_355_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_355_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_355_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _297_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _286_name), _288_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _291_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _360___mcc_h17 = _source15.dtor_expr;
        DAST._IExpression _361_expr = _360___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _362_exprString;
          bool _363___v21;
          bool _364_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _365_recIdents;
          Dafny.ISequence<Dafny.Rune> _out104;
          bool _out105;
          bool _out106;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out107;
          DCOMP.COMP.GenExpr(_361_expr, selfIdent, @params, true, out _out104, out _out105, out _out106, out _out107);
          _362_exprString = _out104;
          _363___v21 = _out105;
          _364_recErased = _out106;
          _365_recIdents = _out107;
          _362_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _362_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _365_recIdents;
          if (isLast) {
            generated = _362_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _362_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source15.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_Break) {
        Dafny.ISequence<Dafny.Rune> _366___mcc_h18 = _source15.dtor_toLabel;
        Dafny.ISequence<Dafny.Rune> _367_toLabel = _366___mcc_h18;
        {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break 'label_"), _367_toLabel), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _368___mcc_h19 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _369_body = _368___mcc_h19;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _370_paramI;
          _370_paramI = BigInteger.Zero;
          while ((_370_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _371_param;
            _371_param = (@params).Select(_370_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _371_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _371_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _370_paramI = (_370_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _372_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _373_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out108;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out109;
          DCOMP.COMP.GenStmts(_369_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out108, out _out109);
          _372_bodyString = _out108;
          _373_bodyIdents = _out109;
          readIdents = _373_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _372_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
        DAST._IExpression _374___mcc_h20 = _source15.dtor_Print_a0;
        DAST._IExpression _375_e = _374___mcc_h20;
        {
          Dafny.ISequence<Dafny.Rune> _376_printedExpr;
          bool _377_isOwned;
          bool _378___v22;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _379_recIdents;
          Dafny.ISequence<Dafny.Rune> _out110;
          bool _out111;
          bool _out112;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out113;
          DCOMP.COMP.GenExpr(_375_e, selfIdent, @params, false, out _out110, out _out111, out _out112, out _out113);
          _376_printedExpr = _out110;
          _377_isOwned = _out111;
          _378___v22 = _out112;
          _379_recIdents = _out113;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_377_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _376_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _379_recIdents;
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
        DAST._ILiteral _380___mcc_h0 = _source20.dtor_Literal_a0;
        DAST._ILiteral _source21 = _380___mcc_h0;
        if (_source21.is_BoolLiteral) {
          bool _381___mcc_h1 = _source21.dtor_BoolLiteral_a0;
          if ((_381___mcc_h1) == (false)) {
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
          Dafny.ISequence<Dafny.Rune> _382___mcc_h2 = _source21.dtor_IntLiteral_a0;
          DAST._IType _383___mcc_h3 = _source21.dtor_IntLiteral_a1;
          DAST._IType _384_t = _383___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _385_i = _382___mcc_h2;
          {
            DAST._IType _source22 = _384_t;
            if (_source22.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _386___mcc_h170 = _source22.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _387___mcc_h171 = _source22.dtor_typeArgs;
              DAST._IResolvedType _388___mcc_h172 = _source22.dtor_resolved;
              {
                s = _385_i;
              }
            } else if (_source22.is_Nullable) {
              DAST._IType _389___mcc_h176 = _source22.dtor_Nullable_a0;
              {
                s = _385_i;
              }
            } else if (_source22.is_Tuple) {
              Dafny.ISequence<DAST._IType> _390___mcc_h178 = _source22.dtor_Tuple_a0;
              {
                s = _385_i;
              }
            } else if (_source22.is_Array) {
              DAST._IType _391___mcc_h180 = _source22.dtor_element;
              {
                s = _385_i;
              }
            } else if (_source22.is_Seq) {
              DAST._IType _392___mcc_h182 = _source22.dtor_element;
              {
                s = _385_i;
              }
            } else if (_source22.is_Set) {
              DAST._IType _393___mcc_h184 = _source22.dtor_element;
              {
                s = _385_i;
              }
            } else if (_source22.is_Multiset) {
              DAST._IType _394___mcc_h186 = _source22.dtor_element;
              {
                s = _385_i;
              }
            } else if (_source22.is_Map) {
              DAST._IType _395___mcc_h188 = _source22.dtor_key;
              DAST._IType _396___mcc_h189 = _source22.dtor_value;
              {
                s = _385_i;
              }
            } else if (_source22.is_Arrow) {
              Dafny.ISequence<DAST._IType> _397___mcc_h192 = _source22.dtor_args;
              DAST._IType _398___mcc_h193 = _source22.dtor_result;
              {
                s = _385_i;
              }
            } else if (_source22.is_Primitive) {
              DAST._IPrimitive _399___mcc_h196 = _source22.dtor_Primitive_a0;
              DAST._IPrimitive _source23 = _399___mcc_h196;
              if (_source23.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _385_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source23.is_Real) {
                {
                  s = _385_i;
                }
              } else if (_source23.is_String) {
                {
                  s = _385_i;
                }
              } else if (_source23.is_Bool) {
                {
                  s = _385_i;
                }
              } else {
                {
                  s = _385_i;
                }
              }
            } else if (_source22.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _400___mcc_h198 = _source22.dtor_Passthrough_a0;
              {
                s = _385_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _401___mcc_h200 = _source22.dtor_TypeArg_a0;
              {
                s = _385_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _402___mcc_h4 = _source21.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _403___mcc_h5 = _source21.dtor_DecLiteral_a1;
          DAST._IType _404___mcc_h6 = _source21.dtor_DecLiteral_a2;
          DAST._IType _405_t = _404___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _406_d = _403___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _407_n = _402___mcc_h4;
          {
            DAST._IType _source24 = _405_t;
            if (_source24.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _408___mcc_h202 = _source24.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _409___mcc_h203 = _source24.dtor_typeArgs;
              DAST._IResolvedType _410___mcc_h204 = _source24.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Nullable) {
              DAST._IType _411___mcc_h208 = _source24.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Tuple) {
              Dafny.ISequence<DAST._IType> _412___mcc_h210 = _source24.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Array) {
              DAST._IType _413___mcc_h212 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Seq) {
              DAST._IType _414___mcc_h214 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Set) {
              DAST._IType _415___mcc_h216 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Multiset) {
              DAST._IType _416___mcc_h218 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Map) {
              DAST._IType _417___mcc_h220 = _source24.dtor_key;
              DAST._IType _418___mcc_h221 = _source24.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Arrow) {
              Dafny.ISequence<DAST._IType> _419___mcc_h224 = _source24.dtor_args;
              DAST._IType _420___mcc_h225 = _source24.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Primitive) {
              DAST._IPrimitive _421___mcc_h228 = _source24.dtor_Primitive_a0;
              DAST._IPrimitive _source25 = _421___mcc_h228;
              if (_source25.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source25.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _407_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source25.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source25.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source24.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _422___mcc_h230 = _source24.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _423___mcc_h232 = _source24.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_407_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _406_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _424___mcc_h7 = _source21.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _425_l = _424___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _425_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_CharLiteral) {
          Dafny.Rune _426___mcc_h8 = _source21.dtor_CharLiteral_a0;
          Dafny.Rune _427_c = _426___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_427_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _428___mcc_h9 = _source20.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _429_name = _428___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _429_name);
          if (!((@params).Contains(_429_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_429_name);
        }
      } else if (_source20.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _430___mcc_h10 = _source20.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _431_path = _430___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out114;
          _out114 = DCOMP.COMP.GenPath(_431_path);
          s = _out114;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source20.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _432___mcc_h11 = _source20.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _433_values = _432___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _434_i;
          _434_i = BigInteger.Zero;
          bool _435_allErased;
          _435_allErased = true;
          while ((_434_i) < (new BigInteger((_433_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _436___v25;
            bool _437___v26;
            bool _438_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _439___v27;
            Dafny.ISequence<Dafny.Rune> _out115;
            bool _out116;
            bool _out117;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out118;
            DCOMP.COMP.GenExpr((_433_values).Select(_434_i), selfIdent, @params, true, out _out115, out _out116, out _out117, out _out118);
            _436___v25 = _out115;
            _437___v26 = _out116;
            _438_isErased = _out117;
            _439___v27 = _out118;
            _435_allErased = (_435_allErased) && (_438_isErased);
            _434_i = (_434_i) + (BigInteger.One);
          }
          _434_i = BigInteger.Zero;
          while ((_434_i) < (new BigInteger((_433_values).Count))) {
            if ((_434_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _440_recursiveGen;
            bool _441___v28;
            bool _442_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _443_recIdents;
            Dafny.ISequence<Dafny.Rune> _out119;
            bool _out120;
            bool _out121;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out122;
            DCOMP.COMP.GenExpr((_433_values).Select(_434_i), selfIdent, @params, true, out _out119, out _out120, out _out121, out _out122);
            _440_recursiveGen = _out119;
            _441___v28 = _out120;
            _442_isErased = _out121;
            _443_recIdents = _out122;
            if ((_442_isErased) && (!(_435_allErased))) {
              _440_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _440_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _440_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _443_recIdents);
            _434_i = (_434_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _435_allErased;
        }
      } else if (_source20.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _444___mcc_h12 = _source20.dtor_path;
        Dafny.ISequence<DAST._IExpression> _445___mcc_h13 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _446_args = _445___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _447_path = _444___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _448_path;
          Dafny.ISequence<Dafny.Rune> _out123;
          _out123 = DCOMP.COMP.GenPath(_447_path);
          _448_path = _out123;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _448_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _449_i;
          _449_i = BigInteger.Zero;
          while ((_449_i) < (new BigInteger((_446_args).Count))) {
            if ((_449_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _450_recursiveGen;
            bool _451___v29;
            bool _452_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _453_recIdents;
            Dafny.ISequence<Dafny.Rune> _out124;
            bool _out125;
            bool _out126;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out127;
            DCOMP.COMP.GenExpr((_446_args).Select(_449_i), selfIdent, @params, true, out _out124, out _out125, out _out126, out _out127);
            _450_recursiveGen = _out124;
            _451___v29 = _out125;
            _452_isErased = _out126;
            _453_recIdents = _out127;
            if (_452_isErased) {
              _450_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _450_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _450_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _453_recIdents);
            _449_i = (_449_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _454___mcc_h14 = _source20.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _455_dims = _454___mcc_h14;
        {
          BigInteger _456_i;
          _456_i = (new BigInteger((_455_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_456_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _457_recursiveGen;
            bool _458___v30;
            bool _459_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _460_recIdents;
            Dafny.ISequence<Dafny.Rune> _out128;
            bool _out129;
            bool _out130;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out131;
            DCOMP.COMP.GenExpr((_455_dims).Select(_456_i), selfIdent, @params, true, out _out128, out _out129, out _out130, out _out131);
            _457_recursiveGen = _out128;
            _458___v30 = _out129;
            _459_isErased = _out130;
            _460_recIdents = _out131;
            if (!(_459_isErased)) {
              _457_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _457_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _457_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _460_recIdents);
            _456_i = (_456_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _461___mcc_h15 = _source20.dtor_path;
        Dafny.ISequence<Dafny.Rune> _462___mcc_h16 = _source20.dtor_variant;
        bool _463___mcc_h17 = _source20.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _464___mcc_h18 = _source20.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _465_values = _464___mcc_h18;
        bool _466_isCo = _463___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _467_variant = _462___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _468_path = _461___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _469_path;
          Dafny.ISequence<Dafny.Rune> _out132;
          _out132 = DCOMP.COMP.GenPath(_468_path);
          _469_path = _out132;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _469_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _467_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _470_i;
          _470_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_470_i) < (new BigInteger((_465_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_465_values).Select(_470_i);
            Dafny.ISequence<Dafny.Rune> _471_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _472_value = _let_tmp_rhs0.dtor__1;
            if ((_470_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_466_isCo) {
              Dafny.ISequence<Dafny.Rune> _473_recursiveGen;
              bool _474___v31;
              bool _475_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _476_recIdents;
              Dafny.ISequence<Dafny.Rune> _out133;
              bool _out134;
              bool _out135;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out136;
              DCOMP.COMP.GenExpr(_472_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out133, out _out134, out _out135, out _out136);
              _473_recursiveGen = _out133;
              _474___v31 = _out134;
              _475_isErased = _out135;
              _476_recIdents = _out136;
              if (!(_475_isErased)) {
                _473_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _473_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _476_recIdents);
              Dafny.ISequence<Dafny.Rune> _477_allReadCloned;
              _477_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_476_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _478_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_476_recIdents).Elements) {
                  _478_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_476_recIdents).Contains(_478_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1135)");
              after__ASSIGN_SUCH_THAT_0:;
                _477_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_477_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _478_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _478_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _476_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_476_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_478_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _471_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _477_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _479_recursiveGen;
              bool _480___v32;
              bool _481_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _482_recIdents;
              Dafny.ISequence<Dafny.Rune> _out137;
              bool _out138;
              bool _out139;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out140;
              DCOMP.COMP.GenExpr(_472_value, selfIdent, @params, true, out _out137, out _out138, out _out139, out _out140);
              _479_recursiveGen = _out137;
              _480___v32 = _out138;
              _481_isErased = _out139;
              _482_recIdents = _out140;
              if (!(_481_isErased)) {
                _479_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _479_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _471_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _482_recIdents);
            }
            _470_i = (_470_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_Convert) {
        DAST._IExpression _483___mcc_h19 = _source20.dtor_value;
        DAST._IType _484___mcc_h20 = _source20.dtor_from;
        DAST._IType _485___mcc_h21 = _source20.dtor_typ;
        DAST._IType _486_toTpe = _485___mcc_h21;
        DAST._IType _487_fromTpe = _484___mcc_h20;
        DAST._IExpression _488_expr = _483___mcc_h19;
        {
          if (object.Equals(_487_fromTpe, _486_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _489_recursiveGen;
            bool _490_recOwned;
            bool _491_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _492_recIdents;
            Dafny.ISequence<Dafny.Rune> _out141;
            bool _out142;
            bool _out143;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out144;
            DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out141, out _out142, out _out143, out _out144);
            _489_recursiveGen = _out141;
            _490_recOwned = _out142;
            _491_recErased = _out143;
            _492_recIdents = _out144;
            s = _489_recursiveGen;
            isOwned = _490_recOwned;
            isErased = _491_recErased;
            readIdents = _492_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source26 = _System.Tuple2<DAST._IType, DAST._IType>.create(_487_fromTpe, _486_toTpe);
            DAST._IType _493___mcc_h234 = _source26.dtor__0;
            DAST._IType _494___mcc_h235 = _source26.dtor__1;
            DAST._IType _source27 = _493___mcc_h234;
            if (_source27.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _495___mcc_h238 = _source27.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _496___mcc_h239 = _source27.dtor_typeArgs;
              DAST._IResolvedType _497___mcc_h240 = _source27.dtor_resolved;
              DAST._IResolvedType _source28 = _497___mcc_h240;
              if (_source28.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _498___mcc_h250 = _source28.dtor_path;
                DAST._IType _source29 = _494___mcc_h235;
                if (_source29.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _499___mcc_h254 = _source29.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _500___mcc_h255 = _source29.dtor_typeArgs;
                  DAST._IResolvedType _501___mcc_h256 = _source29.dtor_resolved;
                  DAST._IResolvedType _source30 = _501___mcc_h256;
                  if (_source30.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _502___mcc_h260 = _source30.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _503_recursiveGen;
                      bool _504_recOwned;
                      bool _505_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _506_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out145;
                      bool _out146;
                      bool _out147;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out145, out _out146, out _out147, out _out148);
                      _503_recursiveGen = _out145;
                      _504_recOwned = _out146;
                      _505_recErased = _out147;
                      _506_recIdents = _out148;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _503_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _504_recOwned;
                      isErased = _505_recErased;
                      readIdents = _506_recIdents;
                    }
                  } else if (_source30.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _507___mcc_h262 = _source30.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _508_recursiveGen;
                      bool _509_recOwned;
                      bool _510_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _511_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out149;
                      bool _out150;
                      bool _out151;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out149, out _out150, out _out151, out _out152);
                      _508_recursiveGen = _out149;
                      _509_recOwned = _out150;
                      _510_recErased = _out151;
                      _511_recIdents = _out152;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _508_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _509_recOwned;
                      isErased = _510_recErased;
                      readIdents = _511_recIdents;
                    }
                  } else {
                    DAST._IType _512___mcc_h264 = _source30.dtor_Newtype_a0;
                    DAST._IType _513_b = _512___mcc_h264;
                    {
                      if (object.Equals(_487_fromTpe, _513_b)) {
                        Dafny.ISequence<Dafny.Rune> _514_recursiveGen;
                        bool _515_recOwned;
                        bool _516_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _517_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out153;
                        bool _out154;
                        bool _out155;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out153, out _out154, out _out155, out _out156);
                        _514_recursiveGen = _out153;
                        _515_recOwned = _out154;
                        _516_recErased = _out155;
                        _517_recIdents = _out156;
                        Dafny.ISequence<Dafny.Rune> _518_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out157;
                        _out157 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                        _518_rhsType = _out157;
                        Dafny.ISequence<Dafny.Rune> _519_uneraseFn;
                        _519_uneraseFn = ((_515_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _518_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _519_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _514_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _515_recOwned;
                        isErased = false;
                        readIdents = _517_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out158;
                        bool _out159;
                        bool _out160;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out161;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _513_b), _513_b, _486_toTpe), selfIdent, @params, mustOwn, out _out158, out _out159, out _out160, out _out161);
                        s = _out158;
                        isOwned = _out159;
                        isErased = _out160;
                        readIdents = _out161;
                      }
                    }
                  }
                } else if (_source29.is_Nullable) {
                  DAST._IType _520___mcc_h266 = _source29.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _521_recursiveGen;
                    bool _522_recOwned;
                    bool _523_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _524_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out162;
                    bool _out163;
                    bool _out164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out165;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out162, out _out163, out _out164, out _out165);
                    _521_recursiveGen = _out162;
                    _522_recOwned = _out163;
                    _523_recErased = _out164;
                    _524_recIdents = _out165;
                    if (!(_522_recOwned)) {
                      _521_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_521_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _521_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _523_recErased;
                    readIdents = _524_recIdents;
                  }
                } else if (_source29.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _525___mcc_h268 = _source29.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _526_recursiveGen;
                    bool _527_recOwned;
                    bool _528_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _529_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out166;
                    bool _out167;
                    bool _out168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out169;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out166, out _out167, out _out168, out _out169);
                    _526_recursiveGen = _out166;
                    _527_recOwned = _out167;
                    _528_recErased = _out168;
                    _529_recIdents = _out169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _526_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _527_recOwned;
                    isErased = _528_recErased;
                    readIdents = _529_recIdents;
                  }
                } else if (_source29.is_Array) {
                  DAST._IType _530___mcc_h270 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _531_recursiveGen;
                    bool _532_recOwned;
                    bool _533_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _534_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out170;
                    bool _out171;
                    bool _out172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out173;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out170, out _out171, out _out172, out _out173);
                    _531_recursiveGen = _out170;
                    _532_recOwned = _out171;
                    _533_recErased = _out172;
                    _534_recIdents = _out173;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _531_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _532_recOwned;
                    isErased = _533_recErased;
                    readIdents = _534_recIdents;
                  }
                } else if (_source29.is_Seq) {
                  DAST._IType _535___mcc_h272 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _536_recursiveGen;
                    bool _537_recOwned;
                    bool _538_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _539_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out174;
                    bool _out175;
                    bool _out176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out177;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out174, out _out175, out _out176, out _out177);
                    _536_recursiveGen = _out174;
                    _537_recOwned = _out175;
                    _538_recErased = _out176;
                    _539_recIdents = _out177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _536_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _537_recOwned;
                    isErased = _538_recErased;
                    readIdents = _539_recIdents;
                  }
                } else if (_source29.is_Set) {
                  DAST._IType _540___mcc_h274 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _541_recursiveGen;
                    bool _542_recOwned;
                    bool _543_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _544_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out178;
                    bool _out179;
                    bool _out180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out181;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out178, out _out179, out _out180, out _out181);
                    _541_recursiveGen = _out178;
                    _542_recOwned = _out179;
                    _543_recErased = _out180;
                    _544_recIdents = _out181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _541_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _542_recOwned;
                    isErased = _543_recErased;
                    readIdents = _544_recIdents;
                  }
                } else if (_source29.is_Multiset) {
                  DAST._IType _545___mcc_h276 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _546_recursiveGen;
                    bool _547_recOwned;
                    bool _548_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _549_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out182;
                    bool _out183;
                    bool _out184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out185;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out182, out _out183, out _out184, out _out185);
                    _546_recursiveGen = _out182;
                    _547_recOwned = _out183;
                    _548_recErased = _out184;
                    _549_recIdents = _out185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _547_recOwned;
                    isErased = _548_recErased;
                    readIdents = _549_recIdents;
                  }
                } else if (_source29.is_Map) {
                  DAST._IType _550___mcc_h278 = _source29.dtor_key;
                  DAST._IType _551___mcc_h279 = _source29.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _552_recursiveGen;
                    bool _553_recOwned;
                    bool _554_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _555_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out186;
                    bool _out187;
                    bool _out188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out189;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out186, out _out187, out _out188, out _out189);
                    _552_recursiveGen = _out186;
                    _553_recOwned = _out187;
                    _554_recErased = _out188;
                    _555_recIdents = _out189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _552_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _553_recOwned;
                    isErased = _554_recErased;
                    readIdents = _555_recIdents;
                  }
                } else if (_source29.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _556___mcc_h282 = _source29.dtor_args;
                  DAST._IType _557___mcc_h283 = _source29.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _558_recursiveGen;
                    bool _559_recOwned;
                    bool _560_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _561_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out190;
                    bool _out191;
                    bool _out192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out193;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out190, out _out191, out _out192, out _out193);
                    _558_recursiveGen = _out190;
                    _559_recOwned = _out191;
                    _560_recErased = _out192;
                    _561_recIdents = _out193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _558_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _559_recOwned;
                    isErased = _560_recErased;
                    readIdents = _561_recIdents;
                  }
                } else if (_source29.is_Primitive) {
                  DAST._IPrimitive _562___mcc_h286 = _source29.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _563_recursiveGen;
                    bool _564_recOwned;
                    bool _565_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _566_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out194;
                    bool _out195;
                    bool _out196;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out197;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out194, out _out195, out _out196, out _out197);
                    _563_recursiveGen = _out194;
                    _564_recOwned = _out195;
                    _565_recErased = _out196;
                    _566_recIdents = _out197;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _563_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _564_recOwned;
                    isErased = _565_recErased;
                    readIdents = _566_recIdents;
                  }
                } else if (_source29.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _567___mcc_h288 = _source29.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _568_recursiveGen;
                    bool _569_recOwned;
                    bool _570_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _571_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out198;
                    bool _out199;
                    bool _out200;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out198, out _out199, out _out200, out _out201);
                    _568_recursiveGen = _out198;
                    _569_recOwned = _out199;
                    _570_recErased = _out200;
                    _571_recIdents = _out201;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _568_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _569_recOwned;
                    isErased = _570_recErased;
                    readIdents = _571_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _572___mcc_h290 = _source29.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _573_recursiveGen;
                    bool _574_recOwned;
                    bool _575_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _576_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out202;
                    bool _out203;
                    bool _out204;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out202, out _out203, out _out204, out _out205);
                    _573_recursiveGen = _out202;
                    _574_recOwned = _out203;
                    _575_recErased = _out204;
                    _576_recIdents = _out205;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _573_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _574_recOwned;
                    isErased = _575_recErased;
                    readIdents = _576_recIdents;
                  }
                }
              } else if (_source28.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _577___mcc_h292 = _source28.dtor_path;
                DAST._IType _source31 = _494___mcc_h235;
                if (_source31.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _578___mcc_h296 = _source31.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _579___mcc_h297 = _source31.dtor_typeArgs;
                  DAST._IResolvedType _580___mcc_h298 = _source31.dtor_resolved;
                  DAST._IResolvedType _source32 = _580___mcc_h298;
                  if (_source32.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _581___mcc_h302 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _582_recursiveGen;
                      bool _583_recOwned;
                      bool _584_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _585_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out206;
                      bool _out207;
                      bool _out208;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out206, out _out207, out _out208, out _out209);
                      _582_recursiveGen = _out206;
                      _583_recOwned = _out207;
                      _584_recErased = _out208;
                      _585_recIdents = _out209;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _582_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _583_recOwned;
                      isErased = _584_recErased;
                      readIdents = _585_recIdents;
                    }
                  } else if (_source32.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _586___mcc_h304 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _587_recursiveGen;
                      bool _588_recOwned;
                      bool _589_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _590_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out210;
                      bool _out211;
                      bool _out212;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out210, out _out211, out _out212, out _out213);
                      _587_recursiveGen = _out210;
                      _588_recOwned = _out211;
                      _589_recErased = _out212;
                      _590_recIdents = _out213;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _587_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _588_recOwned;
                      isErased = _589_recErased;
                      readIdents = _590_recIdents;
                    }
                  } else {
                    DAST._IType _591___mcc_h306 = _source32.dtor_Newtype_a0;
                    DAST._IType _592_b = _591___mcc_h306;
                    {
                      if (object.Equals(_487_fromTpe, _592_b)) {
                        Dafny.ISequence<Dafny.Rune> _593_recursiveGen;
                        bool _594_recOwned;
                        bool _595_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _596_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out214;
                        bool _out215;
                        bool _out216;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out214, out _out215, out _out216, out _out217);
                        _593_recursiveGen = _out214;
                        _594_recOwned = _out215;
                        _595_recErased = _out216;
                        _596_recIdents = _out217;
                        Dafny.ISequence<Dafny.Rune> _597_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out218;
                        _out218 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                        _597_rhsType = _out218;
                        Dafny.ISequence<Dafny.Rune> _598_uneraseFn;
                        _598_uneraseFn = ((_594_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _597_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _598_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _593_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _594_recOwned;
                        isErased = false;
                        readIdents = _596_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out219;
                        bool _out220;
                        bool _out221;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out222;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _592_b), _592_b, _486_toTpe), selfIdent, @params, mustOwn, out _out219, out _out220, out _out221, out _out222);
                        s = _out219;
                        isOwned = _out220;
                        isErased = _out221;
                        readIdents = _out222;
                      }
                    }
                  }
                } else if (_source31.is_Nullable) {
                  DAST._IType _599___mcc_h308 = _source31.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _600_recursiveGen;
                    bool _601_recOwned;
                    bool _602_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _603_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out223;
                    bool _out224;
                    bool _out225;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out226;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out223, out _out224, out _out225, out _out226);
                    _600_recursiveGen = _out223;
                    _601_recOwned = _out224;
                    _602_recErased = _out225;
                    _603_recIdents = _out226;
                    if (!(_601_recOwned)) {
                      _600_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_600_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _600_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _602_recErased;
                    readIdents = _603_recIdents;
                  }
                } else if (_source31.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _604___mcc_h310 = _source31.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _605_recursiveGen;
                    bool _606_recOwned;
                    bool _607_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _608_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out227;
                    bool _out228;
                    bool _out229;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out230;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out227, out _out228, out _out229, out _out230);
                    _605_recursiveGen = _out227;
                    _606_recOwned = _out228;
                    _607_recErased = _out229;
                    _608_recIdents = _out230;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _605_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _606_recOwned;
                    isErased = _607_recErased;
                    readIdents = _608_recIdents;
                  }
                } else if (_source31.is_Array) {
                  DAST._IType _609___mcc_h312 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _610_recursiveGen;
                    bool _611_recOwned;
                    bool _612_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _613_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out231;
                    bool _out232;
                    bool _out233;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out234;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out231, out _out232, out _out233, out _out234);
                    _610_recursiveGen = _out231;
                    _611_recOwned = _out232;
                    _612_recErased = _out233;
                    _613_recIdents = _out234;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _610_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _611_recOwned;
                    isErased = _612_recErased;
                    readIdents = _613_recIdents;
                  }
                } else if (_source31.is_Seq) {
                  DAST._IType _614___mcc_h314 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _615_recursiveGen;
                    bool _616_recOwned;
                    bool _617_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _618_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out235;
                    bool _out236;
                    bool _out237;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out238;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out235, out _out236, out _out237, out _out238);
                    _615_recursiveGen = _out235;
                    _616_recOwned = _out236;
                    _617_recErased = _out237;
                    _618_recIdents = _out238;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _615_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _616_recOwned;
                    isErased = _617_recErased;
                    readIdents = _618_recIdents;
                  }
                } else if (_source31.is_Set) {
                  DAST._IType _619___mcc_h316 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _620_recursiveGen;
                    bool _621_recOwned;
                    bool _622_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _623_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out239;
                    bool _out240;
                    bool _out241;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out242;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out239, out _out240, out _out241, out _out242);
                    _620_recursiveGen = _out239;
                    _621_recOwned = _out240;
                    _622_recErased = _out241;
                    _623_recIdents = _out242;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _620_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _621_recOwned;
                    isErased = _622_recErased;
                    readIdents = _623_recIdents;
                  }
                } else if (_source31.is_Multiset) {
                  DAST._IType _624___mcc_h318 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _625_recursiveGen;
                    bool _626_recOwned;
                    bool _627_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _628_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out243;
                    bool _out244;
                    bool _out245;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out246;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out243, out _out244, out _out245, out _out246);
                    _625_recursiveGen = _out243;
                    _626_recOwned = _out244;
                    _627_recErased = _out245;
                    _628_recIdents = _out246;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _625_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _626_recOwned;
                    isErased = _627_recErased;
                    readIdents = _628_recIdents;
                  }
                } else if (_source31.is_Map) {
                  DAST._IType _629___mcc_h320 = _source31.dtor_key;
                  DAST._IType _630___mcc_h321 = _source31.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _631_recursiveGen;
                    bool _632_recOwned;
                    bool _633_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _634_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out247;
                    bool _out248;
                    bool _out249;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out250;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out247, out _out248, out _out249, out _out250);
                    _631_recursiveGen = _out247;
                    _632_recOwned = _out248;
                    _633_recErased = _out249;
                    _634_recIdents = _out250;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _631_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _632_recOwned;
                    isErased = _633_recErased;
                    readIdents = _634_recIdents;
                  }
                } else if (_source31.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _635___mcc_h324 = _source31.dtor_args;
                  DAST._IType _636___mcc_h325 = _source31.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _637_recursiveGen;
                    bool _638_recOwned;
                    bool _639_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _640_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out251;
                    bool _out252;
                    bool _out253;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out251, out _out252, out _out253, out _out254);
                    _637_recursiveGen = _out251;
                    _638_recOwned = _out252;
                    _639_recErased = _out253;
                    _640_recIdents = _out254;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _637_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _638_recOwned;
                    isErased = _639_recErased;
                    readIdents = _640_recIdents;
                  }
                } else if (_source31.is_Primitive) {
                  DAST._IPrimitive _641___mcc_h328 = _source31.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _642_recursiveGen;
                    bool _643_recOwned;
                    bool _644_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _645_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out255;
                    bool _out256;
                    bool _out257;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out255, out _out256, out _out257, out _out258);
                    _642_recursiveGen = _out255;
                    _643_recOwned = _out256;
                    _644_recErased = _out257;
                    _645_recIdents = _out258;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _642_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _643_recOwned;
                    isErased = _644_recErased;
                    readIdents = _645_recIdents;
                  }
                } else if (_source31.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _646___mcc_h330 = _source31.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _647_recursiveGen;
                    bool _648_recOwned;
                    bool _649_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _650_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out259;
                    bool _out260;
                    bool _out261;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out259, out _out260, out _out261, out _out262);
                    _647_recursiveGen = _out259;
                    _648_recOwned = _out260;
                    _649_recErased = _out261;
                    _650_recIdents = _out262;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _647_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _648_recOwned;
                    isErased = _649_recErased;
                    readIdents = _650_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _651___mcc_h332 = _source31.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _652_recursiveGen;
                    bool _653_recOwned;
                    bool _654_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _655_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out263;
                    bool _out264;
                    bool _out265;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out263, out _out264, out _out265, out _out266);
                    _652_recursiveGen = _out263;
                    _653_recOwned = _out264;
                    _654_recErased = _out265;
                    _655_recIdents = _out266;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _652_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _653_recOwned;
                    isErased = _654_recErased;
                    readIdents = _655_recIdents;
                  }
                }
              } else {
                DAST._IType _656___mcc_h334 = _source28.dtor_Newtype_a0;
                DAST._IType _source33 = _494___mcc_h235;
                if (_source33.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _657___mcc_h338 = _source33.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _658___mcc_h339 = _source33.dtor_typeArgs;
                  DAST._IResolvedType _659___mcc_h340 = _source33.dtor_resolved;
                  DAST._IResolvedType _source34 = _659___mcc_h340;
                  if (_source34.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _660___mcc_h347 = _source34.dtor_path;
                    DAST._IType _661_b = _656___mcc_h334;
                    {
                      if (object.Equals(_661_b, _486_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _662_recursiveGen;
                        bool _663_recOwned;
                        bool _664_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _665_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out267;
                        bool _out268;
                        bool _out269;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out267, out _out268, out _out269, out _out270);
                        _662_recursiveGen = _out267;
                        _663_recOwned = _out268;
                        _664_recErased = _out269;
                        _665_recIdents = _out270;
                        Dafny.ISequence<Dafny.Rune> _666_uneraseFn;
                        _666_uneraseFn = ((_663_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _666_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _662_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _663_recOwned;
                        isErased = true;
                        readIdents = _665_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out271;
                        bool _out272;
                        bool _out273;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _661_b), _661_b, _486_toTpe), selfIdent, @params, mustOwn, out _out271, out _out272, out _out273, out _out274);
                        s = _out271;
                        isOwned = _out272;
                        isErased = _out273;
                        readIdents = _out274;
                      }
                    }
                  } else if (_source34.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _667___mcc_h350 = _source34.dtor_path;
                    DAST._IType _668_b = _656___mcc_h334;
                    {
                      if (object.Equals(_668_b, _486_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _669_recursiveGen;
                        bool _670_recOwned;
                        bool _671_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _672_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out275;
                        bool _out276;
                        bool _out277;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out275, out _out276, out _out277, out _out278);
                        _669_recursiveGen = _out275;
                        _670_recOwned = _out276;
                        _671_recErased = _out277;
                        _672_recIdents = _out278;
                        Dafny.ISequence<Dafny.Rune> _673_uneraseFn;
                        _673_uneraseFn = ((_670_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _673_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _669_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _670_recOwned;
                        isErased = true;
                        readIdents = _672_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out279;
                        bool _out280;
                        bool _out281;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _668_b), _668_b, _486_toTpe), selfIdent, @params, mustOwn, out _out279, out _out280, out _out281, out _out282);
                        s = _out279;
                        isOwned = _out280;
                        isErased = _out281;
                        readIdents = _out282;
                      }
                    }
                  } else {
                    DAST._IType _674___mcc_h353 = _source34.dtor_Newtype_a0;
                    DAST._IType _675_b = _674___mcc_h353;
                    {
                      if (object.Equals(_487_fromTpe, _675_b)) {
                        Dafny.ISequence<Dafny.Rune> _676_recursiveGen;
                        bool _677_recOwned;
                        bool _678_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _679_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out283;
                        bool _out284;
                        bool _out285;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out283, out _out284, out _out285, out _out286);
                        _676_recursiveGen = _out283;
                        _677_recOwned = _out284;
                        _678_recErased = _out285;
                        _679_recIdents = _out286;
                        Dafny.ISequence<Dafny.Rune> _680_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out287;
                        _out287 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                        _680_rhsType = _out287;
                        Dafny.ISequence<Dafny.Rune> _681_uneraseFn;
                        _681_uneraseFn = ((_677_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _680_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _681_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _676_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _677_recOwned;
                        isErased = false;
                        readIdents = _679_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out288;
                        bool _out289;
                        bool _out290;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out291;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _675_b), _675_b, _486_toTpe), selfIdent, @params, mustOwn, out _out288, out _out289, out _out290, out _out291);
                        s = _out288;
                        isOwned = _out289;
                        isErased = _out290;
                        readIdents = _out291;
                      }
                    }
                  }
                } else if (_source33.is_Nullable) {
                  DAST._IType _682___mcc_h356 = _source33.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _683_recursiveGen;
                    bool _684_recOwned;
                    bool _685_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _686_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out292;
                    bool _out293;
                    bool _out294;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out295;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out292, out _out293, out _out294, out _out295);
                    _683_recursiveGen = _out292;
                    _684_recOwned = _out293;
                    _685_recErased = _out294;
                    _686_recIdents = _out295;
                    if (!(_684_recOwned)) {
                      _683_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_683_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _683_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _685_recErased;
                    readIdents = _686_recIdents;
                  }
                } else if (_source33.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _687___mcc_h359 = _source33.dtor_Tuple_a0;
                  DAST._IType _688_b = _656___mcc_h334;
                  {
                    if (object.Equals(_688_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _689_recursiveGen;
                      bool _690_recOwned;
                      bool _691_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _692_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out296;
                      bool _out297;
                      bool _out298;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out299;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out296, out _out297, out _out298, out _out299);
                      _689_recursiveGen = _out296;
                      _690_recOwned = _out297;
                      _691_recErased = _out298;
                      _692_recIdents = _out299;
                      Dafny.ISequence<Dafny.Rune> _693_uneraseFn;
                      _693_uneraseFn = ((_690_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _693_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _689_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _690_recOwned;
                      isErased = true;
                      readIdents = _692_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out300;
                      bool _out301;
                      bool _out302;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out303;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _688_b), _688_b, _486_toTpe), selfIdent, @params, mustOwn, out _out300, out _out301, out _out302, out _out303);
                      s = _out300;
                      isOwned = _out301;
                      isErased = _out302;
                      readIdents = _out303;
                    }
                  }
                } else if (_source33.is_Array) {
                  DAST._IType _694___mcc_h362 = _source33.dtor_element;
                  DAST._IType _695_b = _656___mcc_h334;
                  {
                    if (object.Equals(_695_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _696_recursiveGen;
                      bool _697_recOwned;
                      bool _698_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _699_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out304;
                      bool _out305;
                      bool _out306;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out304, out _out305, out _out306, out _out307);
                      _696_recursiveGen = _out304;
                      _697_recOwned = _out305;
                      _698_recErased = _out306;
                      _699_recIdents = _out307;
                      Dafny.ISequence<Dafny.Rune> _700_uneraseFn;
                      _700_uneraseFn = ((_697_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _700_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _696_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _697_recOwned;
                      isErased = true;
                      readIdents = _699_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out308;
                      bool _out309;
                      bool _out310;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _695_b), _695_b, _486_toTpe), selfIdent, @params, mustOwn, out _out308, out _out309, out _out310, out _out311);
                      s = _out308;
                      isOwned = _out309;
                      isErased = _out310;
                      readIdents = _out311;
                    }
                  }
                } else if (_source33.is_Seq) {
                  DAST._IType _701___mcc_h365 = _source33.dtor_element;
                  DAST._IType _702_b = _656___mcc_h334;
                  {
                    if (object.Equals(_702_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _703_recursiveGen;
                      bool _704_recOwned;
                      bool _705_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _706_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out312;
                      bool _out313;
                      bool _out314;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out312, out _out313, out _out314, out _out315);
                      _703_recursiveGen = _out312;
                      _704_recOwned = _out313;
                      _705_recErased = _out314;
                      _706_recIdents = _out315;
                      Dafny.ISequence<Dafny.Rune> _707_uneraseFn;
                      _707_uneraseFn = ((_704_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _707_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _704_recOwned;
                      isErased = true;
                      readIdents = _706_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out316;
                      bool _out317;
                      bool _out318;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _702_b), _702_b, _486_toTpe), selfIdent, @params, mustOwn, out _out316, out _out317, out _out318, out _out319);
                      s = _out316;
                      isOwned = _out317;
                      isErased = _out318;
                      readIdents = _out319;
                    }
                  }
                } else if (_source33.is_Set) {
                  DAST._IType _708___mcc_h368 = _source33.dtor_element;
                  DAST._IType _709_b = _656___mcc_h334;
                  {
                    if (object.Equals(_709_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _710_recursiveGen;
                      bool _711_recOwned;
                      bool _712_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _713_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out320;
                      bool _out321;
                      bool _out322;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out320, out _out321, out _out322, out _out323);
                      _710_recursiveGen = _out320;
                      _711_recOwned = _out321;
                      _712_recErased = _out322;
                      _713_recIdents = _out323;
                      Dafny.ISequence<Dafny.Rune> _714_uneraseFn;
                      _714_uneraseFn = ((_711_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _714_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _710_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _711_recOwned;
                      isErased = true;
                      readIdents = _713_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out324;
                      bool _out325;
                      bool _out326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _709_b), _709_b, _486_toTpe), selfIdent, @params, mustOwn, out _out324, out _out325, out _out326, out _out327);
                      s = _out324;
                      isOwned = _out325;
                      isErased = _out326;
                      readIdents = _out327;
                    }
                  }
                } else if (_source33.is_Multiset) {
                  DAST._IType _715___mcc_h371 = _source33.dtor_element;
                  DAST._IType _716_b = _656___mcc_h334;
                  {
                    if (object.Equals(_716_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _717_recursiveGen;
                      bool _718_recOwned;
                      bool _719_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _720_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out328;
                      bool _out329;
                      bool _out330;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out328, out _out329, out _out330, out _out331);
                      _717_recursiveGen = _out328;
                      _718_recOwned = _out329;
                      _719_recErased = _out330;
                      _720_recIdents = _out331;
                      Dafny.ISequence<Dafny.Rune> _721_uneraseFn;
                      _721_uneraseFn = ((_718_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _721_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _717_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _718_recOwned;
                      isErased = true;
                      readIdents = _720_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out332;
                      bool _out333;
                      bool _out334;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _716_b), _716_b, _486_toTpe), selfIdent, @params, mustOwn, out _out332, out _out333, out _out334, out _out335);
                      s = _out332;
                      isOwned = _out333;
                      isErased = _out334;
                      readIdents = _out335;
                    }
                  }
                } else if (_source33.is_Map) {
                  DAST._IType _722___mcc_h374 = _source33.dtor_key;
                  DAST._IType _723___mcc_h375 = _source33.dtor_value;
                  DAST._IType _724_b = _656___mcc_h334;
                  {
                    if (object.Equals(_724_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _725_recursiveGen;
                      bool _726_recOwned;
                      bool _727_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _728_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out336;
                      bool _out337;
                      bool _out338;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out336, out _out337, out _out338, out _out339);
                      _725_recursiveGen = _out336;
                      _726_recOwned = _out337;
                      _727_recErased = _out338;
                      _728_recIdents = _out339;
                      Dafny.ISequence<Dafny.Rune> _729_uneraseFn;
                      _729_uneraseFn = ((_726_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _729_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _725_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _726_recOwned;
                      isErased = true;
                      readIdents = _728_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out340;
                      bool _out341;
                      bool _out342;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _724_b), _724_b, _486_toTpe), selfIdent, @params, mustOwn, out _out340, out _out341, out _out342, out _out343);
                      s = _out340;
                      isOwned = _out341;
                      isErased = _out342;
                      readIdents = _out343;
                    }
                  }
                } else if (_source33.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _730___mcc_h380 = _source33.dtor_args;
                  DAST._IType _731___mcc_h381 = _source33.dtor_result;
                  DAST._IType _732_b = _656___mcc_h334;
                  {
                    if (object.Equals(_732_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _733_recursiveGen;
                      bool _734_recOwned;
                      bool _735_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _736_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out344;
                      bool _out345;
                      bool _out346;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out344, out _out345, out _out346, out _out347);
                      _733_recursiveGen = _out344;
                      _734_recOwned = _out345;
                      _735_recErased = _out346;
                      _736_recIdents = _out347;
                      Dafny.ISequence<Dafny.Rune> _737_uneraseFn;
                      _737_uneraseFn = ((_734_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _737_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _733_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _734_recOwned;
                      isErased = true;
                      readIdents = _736_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out348;
                      bool _out349;
                      bool _out350;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _732_b), _732_b, _486_toTpe), selfIdent, @params, mustOwn, out _out348, out _out349, out _out350, out _out351);
                      s = _out348;
                      isOwned = _out349;
                      isErased = _out350;
                      readIdents = _out351;
                    }
                  }
                } else if (_source33.is_Primitive) {
                  DAST._IPrimitive _738___mcc_h386 = _source33.dtor_Primitive_a0;
                  DAST._IType _739_b = _656___mcc_h334;
                  {
                    if (object.Equals(_739_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _740_recursiveGen;
                      bool _741_recOwned;
                      bool _742_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _743_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out352;
                      bool _out353;
                      bool _out354;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out352, out _out353, out _out354, out _out355);
                      _740_recursiveGen = _out352;
                      _741_recOwned = _out353;
                      _742_recErased = _out354;
                      _743_recIdents = _out355;
                      Dafny.ISequence<Dafny.Rune> _744_uneraseFn;
                      _744_uneraseFn = ((_741_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _744_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _740_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _741_recOwned;
                      isErased = true;
                      readIdents = _743_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out356;
                      bool _out357;
                      bool _out358;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out359;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _739_b), _739_b, _486_toTpe), selfIdent, @params, mustOwn, out _out356, out _out357, out _out358, out _out359);
                      s = _out356;
                      isOwned = _out357;
                      isErased = _out358;
                      readIdents = _out359;
                    }
                  }
                } else if (_source33.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _745___mcc_h389 = _source33.dtor_Passthrough_a0;
                  DAST._IType _746_b = _656___mcc_h334;
                  {
                    if (object.Equals(_746_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _747_recursiveGen;
                      bool _748_recOwned;
                      bool _749_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _750_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out360;
                      bool _out361;
                      bool _out362;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out363;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out360, out _out361, out _out362, out _out363);
                      _747_recursiveGen = _out360;
                      _748_recOwned = _out361;
                      _749_recErased = _out362;
                      _750_recIdents = _out363;
                      Dafny.ISequence<Dafny.Rune> _751_uneraseFn;
                      _751_uneraseFn = ((_748_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _751_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _747_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _748_recOwned;
                      isErased = true;
                      readIdents = _750_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out364;
                      bool _out365;
                      bool _out366;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out367;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _746_b), _746_b, _486_toTpe), selfIdent, @params, mustOwn, out _out364, out _out365, out _out366, out _out367);
                      s = _out364;
                      isOwned = _out365;
                      isErased = _out366;
                      readIdents = _out367;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _752___mcc_h392 = _source33.dtor_TypeArg_a0;
                  DAST._IType _753_b = _656___mcc_h334;
                  {
                    if (object.Equals(_753_b, _486_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _754_recursiveGen;
                      bool _755_recOwned;
                      bool _756_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _757_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out368;
                      bool _out369;
                      bool _out370;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out371;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out368, out _out369, out _out370, out _out371);
                      _754_recursiveGen = _out368;
                      _755_recOwned = _out369;
                      _756_recErased = _out370;
                      _757_recIdents = _out371;
                      Dafny.ISequence<Dafny.Rune> _758_uneraseFn;
                      _758_uneraseFn = ((_755_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _758_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _754_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _755_recOwned;
                      isErased = true;
                      readIdents = _757_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out372;
                      bool _out373;
                      bool _out374;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out375;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _753_b), _753_b, _486_toTpe), selfIdent, @params, mustOwn, out _out372, out _out373, out _out374, out _out375);
                      s = _out372;
                      isOwned = _out373;
                      isErased = _out374;
                      readIdents = _out375;
                    }
                  }
                }
              }
            } else if (_source27.is_Nullable) {
              DAST._IType _759___mcc_h395 = _source27.dtor_Nullable_a0;
              DAST._IType _source35 = _494___mcc_h235;
              if (_source35.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _760___mcc_h399 = _source35.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _761___mcc_h400 = _source35.dtor_typeArgs;
                DAST._IResolvedType _762___mcc_h401 = _source35.dtor_resolved;
                DAST._IResolvedType _source36 = _762___mcc_h401;
                if (_source36.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _763___mcc_h408 = _source36.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _764_recursiveGen;
                    bool _765_recOwned;
                    bool _766_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _767_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out376;
                    bool _out377;
                    bool _out378;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out379;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out376, out _out377, out _out378, out _out379);
                    _764_recursiveGen = _out376;
                    _765_recOwned = _out377;
                    _766_recErased = _out378;
                    _767_recIdents = _out379;
                    if (!(_765_recOwned)) {
                      _764_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_764_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_764_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _765_recOwned;
                    isErased = _766_recErased;
                    readIdents = _767_recIdents;
                  }
                } else if (_source36.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _768___mcc_h411 = _source36.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _769_recursiveGen;
                    bool _770_recOwned;
                    bool _771_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _772_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out380;
                    bool _out381;
                    bool _out382;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out383;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out380, out _out381, out _out382, out _out383);
                    _769_recursiveGen = _out380;
                    _770_recOwned = _out381;
                    _771_recErased = _out382;
                    _772_recIdents = _out383;
                    if (!(_770_recOwned)) {
                      _769_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_769_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_769_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _770_recOwned;
                    isErased = _771_recErased;
                    readIdents = _772_recIdents;
                  }
                } else {
                  DAST._IType _773___mcc_h414 = _source36.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _774_recursiveGen;
                    bool _775_recOwned;
                    bool _776_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _777_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out384;
                    bool _out385;
                    bool _out386;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out387;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out384, out _out385, out _out386, out _out387);
                    _774_recursiveGen = _out384;
                    _775_recOwned = _out385;
                    _776_recErased = _out386;
                    _777_recIdents = _out387;
                    if (!(_775_recOwned)) {
                      _774_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_774_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_774_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _775_recOwned;
                    isErased = _776_recErased;
                    readIdents = _777_recIdents;
                  }
                }
              } else if (_source35.is_Nullable) {
                DAST._IType _778___mcc_h417 = _source35.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _779_recursiveGen;
                  bool _780_recOwned;
                  bool _781_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _782_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out388;
                  bool _out389;
                  bool _out390;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out391;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out388, out _out389, out _out390, out _out391);
                  _779_recursiveGen = _out388;
                  _780_recOwned = _out389;
                  _781_recErased = _out390;
                  _782_recIdents = _out391;
                  if (!(_780_recOwned)) {
                    _779_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_779_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_779_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _780_recOwned;
                  isErased = _781_recErased;
                  readIdents = _782_recIdents;
                }
              } else if (_source35.is_Tuple) {
                Dafny.ISequence<DAST._IType> _783___mcc_h420 = _source35.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _784_recursiveGen;
                  bool _785_recOwned;
                  bool _786_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _787_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out392;
                  bool _out393;
                  bool _out394;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out395;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out392, out _out393, out _out394, out _out395);
                  _784_recursiveGen = _out392;
                  _785_recOwned = _out393;
                  _786_recErased = _out394;
                  _787_recIdents = _out395;
                  if (!(_785_recOwned)) {
                    _784_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_784_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_784_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _785_recOwned;
                  isErased = _786_recErased;
                  readIdents = _787_recIdents;
                }
              } else if (_source35.is_Array) {
                DAST._IType _788___mcc_h423 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _789_recursiveGen;
                  bool _790_recOwned;
                  bool _791_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _792_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out396;
                  bool _out397;
                  bool _out398;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out399;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out396, out _out397, out _out398, out _out399);
                  _789_recursiveGen = _out396;
                  _790_recOwned = _out397;
                  _791_recErased = _out398;
                  _792_recIdents = _out399;
                  if (!(_790_recOwned)) {
                    _789_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_789_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_789_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _790_recOwned;
                  isErased = _791_recErased;
                  readIdents = _792_recIdents;
                }
              } else if (_source35.is_Seq) {
                DAST._IType _793___mcc_h426 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _794_recursiveGen;
                  bool _795_recOwned;
                  bool _796_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _797_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out400;
                  bool _out401;
                  bool _out402;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out403;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out400, out _out401, out _out402, out _out403);
                  _794_recursiveGen = _out400;
                  _795_recOwned = _out401;
                  _796_recErased = _out402;
                  _797_recIdents = _out403;
                  if (!(_795_recOwned)) {
                    _794_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_794_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_794_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _795_recOwned;
                  isErased = _796_recErased;
                  readIdents = _797_recIdents;
                }
              } else if (_source35.is_Set) {
                DAST._IType _798___mcc_h429 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _799_recursiveGen;
                  bool _800_recOwned;
                  bool _801_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _802_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out404;
                  bool _out405;
                  bool _out406;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out407;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out404, out _out405, out _out406, out _out407);
                  _799_recursiveGen = _out404;
                  _800_recOwned = _out405;
                  _801_recErased = _out406;
                  _802_recIdents = _out407;
                  if (!(_800_recOwned)) {
                    _799_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_799_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_799_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _800_recOwned;
                  isErased = _801_recErased;
                  readIdents = _802_recIdents;
                }
              } else if (_source35.is_Multiset) {
                DAST._IType _803___mcc_h432 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _804_recursiveGen;
                  bool _805_recOwned;
                  bool _806_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _807_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out408;
                  bool _out409;
                  bool _out410;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out411;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out408, out _out409, out _out410, out _out411);
                  _804_recursiveGen = _out408;
                  _805_recOwned = _out409;
                  _806_recErased = _out410;
                  _807_recIdents = _out411;
                  if (!(_805_recOwned)) {
                    _804_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_804_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_804_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _805_recOwned;
                  isErased = _806_recErased;
                  readIdents = _807_recIdents;
                }
              } else if (_source35.is_Map) {
                DAST._IType _808___mcc_h435 = _source35.dtor_key;
                DAST._IType _809___mcc_h436 = _source35.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _810_recursiveGen;
                  bool _811_recOwned;
                  bool _812_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _813_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out412;
                  bool _out413;
                  bool _out414;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out415;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out412, out _out413, out _out414, out _out415);
                  _810_recursiveGen = _out412;
                  _811_recOwned = _out413;
                  _812_recErased = _out414;
                  _813_recIdents = _out415;
                  if (!(_811_recOwned)) {
                    _810_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_810_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_810_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _811_recOwned;
                  isErased = _812_recErased;
                  readIdents = _813_recIdents;
                }
              } else if (_source35.is_Arrow) {
                Dafny.ISequence<DAST._IType> _814___mcc_h441 = _source35.dtor_args;
                DAST._IType _815___mcc_h442 = _source35.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _816_recursiveGen;
                  bool _817_recOwned;
                  bool _818_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _819_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out416;
                  bool _out417;
                  bool _out418;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out419;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out416, out _out417, out _out418, out _out419);
                  _816_recursiveGen = _out416;
                  _817_recOwned = _out417;
                  _818_recErased = _out418;
                  _819_recIdents = _out419;
                  if (!(_817_recOwned)) {
                    _816_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_816_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_816_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _817_recOwned;
                  isErased = _818_recErased;
                  readIdents = _819_recIdents;
                }
              } else if (_source35.is_Primitive) {
                DAST._IPrimitive _820___mcc_h447 = _source35.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _821_recursiveGen;
                  bool _822_recOwned;
                  bool _823_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _824_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out420;
                  bool _out421;
                  bool _out422;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out423;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out420, out _out421, out _out422, out _out423);
                  _821_recursiveGen = _out420;
                  _822_recOwned = _out421;
                  _823_recErased = _out422;
                  _824_recIdents = _out423;
                  if (!(_822_recOwned)) {
                    _821_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_821_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_821_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _822_recOwned;
                  isErased = _823_recErased;
                  readIdents = _824_recIdents;
                }
              } else if (_source35.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _825___mcc_h450 = _source35.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _826_recursiveGen;
                  bool _827_recOwned;
                  bool _828_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _829_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out424;
                  bool _out425;
                  bool _out426;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out427;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out424, out _out425, out _out426, out _out427);
                  _826_recursiveGen = _out424;
                  _827_recOwned = _out425;
                  _828_recErased = _out426;
                  _829_recIdents = _out427;
                  if (!(_827_recOwned)) {
                    _826_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_826_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_826_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _827_recOwned;
                  isErased = _828_recErased;
                  readIdents = _829_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _830___mcc_h453 = _source35.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _831_recursiveGen;
                  bool _832_recOwned;
                  bool _833_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _834_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out428;
                  bool _out429;
                  bool _out430;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out431;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out428, out _out429, out _out430, out _out431);
                  _831_recursiveGen = _out428;
                  _832_recOwned = _out429;
                  _833_recErased = _out430;
                  _834_recIdents = _out431;
                  if (!(_832_recOwned)) {
                    _831_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_831_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_831_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _832_recOwned;
                  isErased = _833_recErased;
                  readIdents = _834_recIdents;
                }
              }
            } else if (_source27.is_Tuple) {
              Dafny.ISequence<DAST._IType> _835___mcc_h456 = _source27.dtor_Tuple_a0;
              DAST._IType _source37 = _494___mcc_h235;
              if (_source37.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _836___mcc_h460 = _source37.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _837___mcc_h461 = _source37.dtor_typeArgs;
                DAST._IResolvedType _838___mcc_h462 = _source37.dtor_resolved;
                DAST._IResolvedType _source38 = _838___mcc_h462;
                if (_source38.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _839___mcc_h466 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _840_recursiveGen;
                    bool _841_recOwned;
                    bool _842_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _843_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out432;
                    bool _out433;
                    bool _out434;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out435;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out432, out _out433, out _out434, out _out435);
                    _840_recursiveGen = _out432;
                    _841_recOwned = _out433;
                    _842_recErased = _out434;
                    _843_recIdents = _out435;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _840_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _841_recOwned;
                    isErased = _842_recErased;
                    readIdents = _843_recIdents;
                  }
                } else if (_source38.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _844___mcc_h468 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _845_recursiveGen;
                    bool _846_recOwned;
                    bool _847_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _848_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out436;
                    bool _out437;
                    bool _out438;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out439;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out436, out _out437, out _out438, out _out439);
                    _845_recursiveGen = _out436;
                    _846_recOwned = _out437;
                    _847_recErased = _out438;
                    _848_recIdents = _out439;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _845_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _846_recOwned;
                    isErased = _847_recErased;
                    readIdents = _848_recIdents;
                  }
                } else {
                  DAST._IType _849___mcc_h470 = _source38.dtor_Newtype_a0;
                  DAST._IType _850_b = _849___mcc_h470;
                  {
                    if (object.Equals(_487_fromTpe, _850_b)) {
                      Dafny.ISequence<Dafny.Rune> _851_recursiveGen;
                      bool _852_recOwned;
                      bool _853_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _854_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out440;
                      bool _out441;
                      bool _out442;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out443;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out440, out _out441, out _out442, out _out443);
                      _851_recursiveGen = _out440;
                      _852_recOwned = _out441;
                      _853_recErased = _out442;
                      _854_recIdents = _out443;
                      Dafny.ISequence<Dafny.Rune> _855_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out444;
                      _out444 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _855_rhsType = _out444;
                      Dafny.ISequence<Dafny.Rune> _856_uneraseFn;
                      _856_uneraseFn = ((_852_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _855_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _856_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _851_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _852_recOwned;
                      isErased = false;
                      readIdents = _854_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out445;
                      bool _out446;
                      bool _out447;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out448;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _850_b), _850_b, _486_toTpe), selfIdent, @params, mustOwn, out _out445, out _out446, out _out447, out _out448);
                      s = _out445;
                      isOwned = _out446;
                      isErased = _out447;
                      readIdents = _out448;
                    }
                  }
                }
              } else if (_source37.is_Nullable) {
                DAST._IType _857___mcc_h472 = _source37.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _858_recursiveGen;
                  bool _859_recOwned;
                  bool _860_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _861_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out449;
                  bool _out450;
                  bool _out451;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out452;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out449, out _out450, out _out451, out _out452);
                  _858_recursiveGen = _out449;
                  _859_recOwned = _out450;
                  _860_recErased = _out451;
                  _861_recIdents = _out452;
                  if (!(_859_recOwned)) {
                    _858_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_858_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _858_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _860_recErased;
                  readIdents = _861_recIdents;
                }
              } else if (_source37.is_Tuple) {
                Dafny.ISequence<DAST._IType> _862___mcc_h474 = _source37.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _863_recursiveGen;
                  bool _864_recOwned;
                  bool _865_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _866_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out453;
                  bool _out454;
                  bool _out455;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out456;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out453, out _out454, out _out455, out _out456);
                  _863_recursiveGen = _out453;
                  _864_recOwned = _out454;
                  _865_recErased = _out455;
                  _866_recIdents = _out456;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _863_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _864_recOwned;
                  isErased = _865_recErased;
                  readIdents = _866_recIdents;
                }
              } else if (_source37.is_Array) {
                DAST._IType _867___mcc_h476 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _868_recursiveGen;
                  bool _869_recOwned;
                  bool _870_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _871_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out457;
                  bool _out458;
                  bool _out459;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out460;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out457, out _out458, out _out459, out _out460);
                  _868_recursiveGen = _out457;
                  _869_recOwned = _out458;
                  _870_recErased = _out459;
                  _871_recIdents = _out460;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _868_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _869_recOwned;
                  isErased = _870_recErased;
                  readIdents = _871_recIdents;
                }
              } else if (_source37.is_Seq) {
                DAST._IType _872___mcc_h478 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _873_recursiveGen;
                  bool _874_recOwned;
                  bool _875_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _876_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out461;
                  bool _out462;
                  bool _out463;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out464;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out461, out _out462, out _out463, out _out464);
                  _873_recursiveGen = _out461;
                  _874_recOwned = _out462;
                  _875_recErased = _out463;
                  _876_recIdents = _out464;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _873_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _874_recOwned;
                  isErased = _875_recErased;
                  readIdents = _876_recIdents;
                }
              } else if (_source37.is_Set) {
                DAST._IType _877___mcc_h480 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _878_recursiveGen;
                  bool _879_recOwned;
                  bool _880_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _881_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out465;
                  bool _out466;
                  bool _out467;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out468;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out465, out _out466, out _out467, out _out468);
                  _878_recursiveGen = _out465;
                  _879_recOwned = _out466;
                  _880_recErased = _out467;
                  _881_recIdents = _out468;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _878_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _879_recOwned;
                  isErased = _880_recErased;
                  readIdents = _881_recIdents;
                }
              } else if (_source37.is_Multiset) {
                DAST._IType _882___mcc_h482 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _883_recursiveGen;
                  bool _884_recOwned;
                  bool _885_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _886_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out469;
                  bool _out470;
                  bool _out471;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out472;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out469, out _out470, out _out471, out _out472);
                  _883_recursiveGen = _out469;
                  _884_recOwned = _out470;
                  _885_recErased = _out471;
                  _886_recIdents = _out472;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _883_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _884_recOwned;
                  isErased = _885_recErased;
                  readIdents = _886_recIdents;
                }
              } else if (_source37.is_Map) {
                DAST._IType _887___mcc_h484 = _source37.dtor_key;
                DAST._IType _888___mcc_h485 = _source37.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _889_recursiveGen;
                  bool _890_recOwned;
                  bool _891_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _892_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out473;
                  bool _out474;
                  bool _out475;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out476;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out473, out _out474, out _out475, out _out476);
                  _889_recursiveGen = _out473;
                  _890_recOwned = _out474;
                  _891_recErased = _out475;
                  _892_recIdents = _out476;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _889_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _890_recOwned;
                  isErased = _891_recErased;
                  readIdents = _892_recIdents;
                }
              } else if (_source37.is_Arrow) {
                Dafny.ISequence<DAST._IType> _893___mcc_h488 = _source37.dtor_args;
                DAST._IType _894___mcc_h489 = _source37.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _895_recursiveGen;
                  bool _896_recOwned;
                  bool _897_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _898_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out477;
                  bool _out478;
                  bool _out479;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out480;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out477, out _out478, out _out479, out _out480);
                  _895_recursiveGen = _out477;
                  _896_recOwned = _out478;
                  _897_recErased = _out479;
                  _898_recIdents = _out480;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _895_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _896_recOwned;
                  isErased = _897_recErased;
                  readIdents = _898_recIdents;
                }
              } else if (_source37.is_Primitive) {
                DAST._IPrimitive _899___mcc_h492 = _source37.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _900_recursiveGen;
                  bool _901_recOwned;
                  bool _902_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _903_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out481;
                  bool _out482;
                  bool _out483;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out484;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out481, out _out482, out _out483, out _out484);
                  _900_recursiveGen = _out481;
                  _901_recOwned = _out482;
                  _902_recErased = _out483;
                  _903_recIdents = _out484;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _900_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _901_recOwned;
                  isErased = _902_recErased;
                  readIdents = _903_recIdents;
                }
              } else if (_source37.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _904___mcc_h494 = _source37.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _905_recursiveGen;
                  bool _906_recOwned;
                  bool _907_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _908_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out485;
                  bool _out486;
                  bool _out487;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out488;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out485, out _out486, out _out487, out _out488);
                  _905_recursiveGen = _out485;
                  _906_recOwned = _out486;
                  _907_recErased = _out487;
                  _908_recIdents = _out488;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _905_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _906_recOwned;
                  isErased = _907_recErased;
                  readIdents = _908_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _909___mcc_h496 = _source37.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _910_recursiveGen;
                  bool _911_recOwned;
                  bool _912_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _913_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out489;
                  bool _out490;
                  bool _out491;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out492;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out489, out _out490, out _out491, out _out492);
                  _910_recursiveGen = _out489;
                  _911_recOwned = _out490;
                  _912_recErased = _out491;
                  _913_recIdents = _out492;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _910_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _911_recOwned;
                  isErased = _912_recErased;
                  readIdents = _913_recIdents;
                }
              }
            } else if (_source27.is_Array) {
              DAST._IType _914___mcc_h498 = _source27.dtor_element;
              DAST._IType _source39 = _494___mcc_h235;
              if (_source39.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _915___mcc_h502 = _source39.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _916___mcc_h503 = _source39.dtor_typeArgs;
                DAST._IResolvedType _917___mcc_h504 = _source39.dtor_resolved;
                DAST._IResolvedType _source40 = _917___mcc_h504;
                if (_source40.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _918___mcc_h508 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _919_recursiveGen;
                    bool _920_recOwned;
                    bool _921_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _922_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out493;
                    bool _out494;
                    bool _out495;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out496;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out493, out _out494, out _out495, out _out496);
                    _919_recursiveGen = _out493;
                    _920_recOwned = _out494;
                    _921_recErased = _out495;
                    _922_recIdents = _out496;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _919_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _920_recOwned;
                    isErased = _921_recErased;
                    readIdents = _922_recIdents;
                  }
                } else if (_source40.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _923___mcc_h510 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _924_recursiveGen;
                    bool _925_recOwned;
                    bool _926_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _927_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out497;
                    bool _out498;
                    bool _out499;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out500;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out497, out _out498, out _out499, out _out500);
                    _924_recursiveGen = _out497;
                    _925_recOwned = _out498;
                    _926_recErased = _out499;
                    _927_recIdents = _out500;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _924_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _925_recOwned;
                    isErased = _926_recErased;
                    readIdents = _927_recIdents;
                  }
                } else {
                  DAST._IType _928___mcc_h512 = _source40.dtor_Newtype_a0;
                  DAST._IType _929_b = _928___mcc_h512;
                  {
                    if (object.Equals(_487_fromTpe, _929_b)) {
                      Dafny.ISequence<Dafny.Rune> _930_recursiveGen;
                      bool _931_recOwned;
                      bool _932_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _933_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out501;
                      bool _out502;
                      bool _out503;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out504;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out501, out _out502, out _out503, out _out504);
                      _930_recursiveGen = _out501;
                      _931_recOwned = _out502;
                      _932_recErased = _out503;
                      _933_recIdents = _out504;
                      Dafny.ISequence<Dafny.Rune> _934_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out505;
                      _out505 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _934_rhsType = _out505;
                      Dafny.ISequence<Dafny.Rune> _935_uneraseFn;
                      _935_uneraseFn = ((_931_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _934_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _935_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _931_recOwned;
                      isErased = false;
                      readIdents = _933_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out506;
                      bool _out507;
                      bool _out508;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out509;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _929_b), _929_b, _486_toTpe), selfIdent, @params, mustOwn, out _out506, out _out507, out _out508, out _out509);
                      s = _out506;
                      isOwned = _out507;
                      isErased = _out508;
                      readIdents = _out509;
                    }
                  }
                }
              } else if (_source39.is_Nullable) {
                DAST._IType _936___mcc_h514 = _source39.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _937_recursiveGen;
                  bool _938_recOwned;
                  bool _939_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _940_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out510;
                  bool _out511;
                  bool _out512;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out513;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out510, out _out511, out _out512, out _out513);
                  _937_recursiveGen = _out510;
                  _938_recOwned = _out511;
                  _939_recErased = _out512;
                  _940_recIdents = _out513;
                  if (!(_938_recOwned)) {
                    _937_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_937_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _937_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _939_recErased;
                  readIdents = _940_recIdents;
                }
              } else if (_source39.is_Tuple) {
                Dafny.ISequence<DAST._IType> _941___mcc_h516 = _source39.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _942_recursiveGen;
                  bool _943_recOwned;
                  bool _944_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _945_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out514;
                  bool _out515;
                  bool _out516;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out517;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out514, out _out515, out _out516, out _out517);
                  _942_recursiveGen = _out514;
                  _943_recOwned = _out515;
                  _944_recErased = _out516;
                  _945_recIdents = _out517;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _942_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _943_recOwned;
                  isErased = _944_recErased;
                  readIdents = _945_recIdents;
                }
              } else if (_source39.is_Array) {
                DAST._IType _946___mcc_h518 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _947_recursiveGen;
                  bool _948_recOwned;
                  bool _949_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _950_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out518;
                  bool _out519;
                  bool _out520;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out521;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out518, out _out519, out _out520, out _out521);
                  _947_recursiveGen = _out518;
                  _948_recOwned = _out519;
                  _949_recErased = _out520;
                  _950_recIdents = _out521;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _947_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _948_recOwned;
                  isErased = _949_recErased;
                  readIdents = _950_recIdents;
                }
              } else if (_source39.is_Seq) {
                DAST._IType _951___mcc_h520 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _952_recursiveGen;
                  bool _953_recOwned;
                  bool _954_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _955_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out522;
                  bool _out523;
                  bool _out524;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out525;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out522, out _out523, out _out524, out _out525);
                  _952_recursiveGen = _out522;
                  _953_recOwned = _out523;
                  _954_recErased = _out524;
                  _955_recIdents = _out525;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _952_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _953_recOwned;
                  isErased = _954_recErased;
                  readIdents = _955_recIdents;
                }
              } else if (_source39.is_Set) {
                DAST._IType _956___mcc_h522 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _957_recursiveGen;
                  bool _958_recOwned;
                  bool _959_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _960_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out526;
                  bool _out527;
                  bool _out528;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out529;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out526, out _out527, out _out528, out _out529);
                  _957_recursiveGen = _out526;
                  _958_recOwned = _out527;
                  _959_recErased = _out528;
                  _960_recIdents = _out529;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _957_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _958_recOwned;
                  isErased = _959_recErased;
                  readIdents = _960_recIdents;
                }
              } else if (_source39.is_Multiset) {
                DAST._IType _961___mcc_h524 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _962_recursiveGen;
                  bool _963_recOwned;
                  bool _964_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _965_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out530;
                  bool _out531;
                  bool _out532;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out533;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out530, out _out531, out _out532, out _out533);
                  _962_recursiveGen = _out530;
                  _963_recOwned = _out531;
                  _964_recErased = _out532;
                  _965_recIdents = _out533;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _962_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _963_recOwned;
                  isErased = _964_recErased;
                  readIdents = _965_recIdents;
                }
              } else if (_source39.is_Map) {
                DAST._IType _966___mcc_h526 = _source39.dtor_key;
                DAST._IType _967___mcc_h527 = _source39.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _968_recursiveGen;
                  bool _969_recOwned;
                  bool _970_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _971_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out534;
                  bool _out535;
                  bool _out536;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out537;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out534, out _out535, out _out536, out _out537);
                  _968_recursiveGen = _out534;
                  _969_recOwned = _out535;
                  _970_recErased = _out536;
                  _971_recIdents = _out537;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _968_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _969_recOwned;
                  isErased = _970_recErased;
                  readIdents = _971_recIdents;
                }
              } else if (_source39.is_Arrow) {
                Dafny.ISequence<DAST._IType> _972___mcc_h530 = _source39.dtor_args;
                DAST._IType _973___mcc_h531 = _source39.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _974_recursiveGen;
                  bool _975_recOwned;
                  bool _976_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _977_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out538;
                  bool _out539;
                  bool _out540;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out541;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out538, out _out539, out _out540, out _out541);
                  _974_recursiveGen = _out538;
                  _975_recOwned = _out539;
                  _976_recErased = _out540;
                  _977_recIdents = _out541;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _974_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _975_recOwned;
                  isErased = _976_recErased;
                  readIdents = _977_recIdents;
                }
              } else if (_source39.is_Primitive) {
                DAST._IPrimitive _978___mcc_h534 = _source39.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _979_recursiveGen;
                  bool _980_recOwned;
                  bool _981_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _982_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out542;
                  bool _out543;
                  bool _out544;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out545;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out542, out _out543, out _out544, out _out545);
                  _979_recursiveGen = _out542;
                  _980_recOwned = _out543;
                  _981_recErased = _out544;
                  _982_recIdents = _out545;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _979_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _980_recOwned;
                  isErased = _981_recErased;
                  readIdents = _982_recIdents;
                }
              } else if (_source39.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _983___mcc_h536 = _source39.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _984_recursiveGen;
                  bool _985_recOwned;
                  bool _986_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _987_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out546;
                  bool _out547;
                  bool _out548;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out549;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out546, out _out547, out _out548, out _out549);
                  _984_recursiveGen = _out546;
                  _985_recOwned = _out547;
                  _986_recErased = _out548;
                  _987_recIdents = _out549;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _984_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _985_recOwned;
                  isErased = _986_recErased;
                  readIdents = _987_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _988___mcc_h538 = _source39.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _989_recursiveGen;
                  bool _990_recOwned;
                  bool _991_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _992_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out550;
                  bool _out551;
                  bool _out552;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out553;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out550, out _out551, out _out552, out _out553);
                  _989_recursiveGen = _out550;
                  _990_recOwned = _out551;
                  _991_recErased = _out552;
                  _992_recIdents = _out553;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _989_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _990_recOwned;
                  isErased = _991_recErased;
                  readIdents = _992_recIdents;
                }
              }
            } else if (_source27.is_Seq) {
              DAST._IType _993___mcc_h540 = _source27.dtor_element;
              DAST._IType _source41 = _494___mcc_h235;
              if (_source41.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _994___mcc_h544 = _source41.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _995___mcc_h545 = _source41.dtor_typeArgs;
                DAST._IResolvedType _996___mcc_h546 = _source41.dtor_resolved;
                DAST._IResolvedType _source42 = _996___mcc_h546;
                if (_source42.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _997___mcc_h550 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _998_recursiveGen;
                    bool _999_recOwned;
                    bool _1000_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1001_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out554;
                    bool _out555;
                    bool _out556;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out557;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out554, out _out555, out _out556, out _out557);
                    _998_recursiveGen = _out554;
                    _999_recOwned = _out555;
                    _1000_recErased = _out556;
                    _1001_recIdents = _out557;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _998_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _999_recOwned;
                    isErased = _1000_recErased;
                    readIdents = _1001_recIdents;
                  }
                } else if (_source42.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1002___mcc_h552 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1003_recursiveGen;
                    bool _1004_recOwned;
                    bool _1005_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1006_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out558;
                    bool _out559;
                    bool _out560;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out561;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out558, out _out559, out _out560, out _out561);
                    _1003_recursiveGen = _out558;
                    _1004_recOwned = _out559;
                    _1005_recErased = _out560;
                    _1006_recIdents = _out561;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1003_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1004_recOwned;
                    isErased = _1005_recErased;
                    readIdents = _1006_recIdents;
                  }
                } else {
                  DAST._IType _1007___mcc_h554 = _source42.dtor_Newtype_a0;
                  DAST._IType _1008_b = _1007___mcc_h554;
                  {
                    if (object.Equals(_487_fromTpe, _1008_b)) {
                      Dafny.ISequence<Dafny.Rune> _1009_recursiveGen;
                      bool _1010_recOwned;
                      bool _1011_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1012_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out562;
                      bool _out563;
                      bool _out564;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out565;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out562, out _out563, out _out564, out _out565);
                      _1009_recursiveGen = _out562;
                      _1010_recOwned = _out563;
                      _1011_recErased = _out564;
                      _1012_recIdents = _out565;
                      Dafny.ISequence<Dafny.Rune> _1013_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out566;
                      _out566 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _1013_rhsType = _out566;
                      Dafny.ISequence<Dafny.Rune> _1014_uneraseFn;
                      _1014_uneraseFn = ((_1010_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1013_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1014_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1010_recOwned;
                      isErased = false;
                      readIdents = _1012_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out567;
                      bool _out568;
                      bool _out569;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out570;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1008_b), _1008_b, _486_toTpe), selfIdent, @params, mustOwn, out _out567, out _out568, out _out569, out _out570);
                      s = _out567;
                      isOwned = _out568;
                      isErased = _out569;
                      readIdents = _out570;
                    }
                  }
                }
              } else if (_source41.is_Nullable) {
                DAST._IType _1015___mcc_h556 = _source41.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1016_recursiveGen;
                  bool _1017_recOwned;
                  bool _1018_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1019_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out571;
                  bool _out572;
                  bool _out573;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out574;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out571, out _out572, out _out573, out _out574);
                  _1016_recursiveGen = _out571;
                  _1017_recOwned = _out572;
                  _1018_recErased = _out573;
                  _1019_recIdents = _out574;
                  if (!(_1017_recOwned)) {
                    _1016_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1016_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1016_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1018_recErased;
                  readIdents = _1019_recIdents;
                }
              } else if (_source41.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1020___mcc_h558 = _source41.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1021_recursiveGen;
                  bool _1022_recOwned;
                  bool _1023_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1024_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out575;
                  bool _out576;
                  bool _out577;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out578;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out575, out _out576, out _out577, out _out578);
                  _1021_recursiveGen = _out575;
                  _1022_recOwned = _out576;
                  _1023_recErased = _out577;
                  _1024_recIdents = _out578;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1021_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1022_recOwned;
                  isErased = _1023_recErased;
                  readIdents = _1024_recIdents;
                }
              } else if (_source41.is_Array) {
                DAST._IType _1025___mcc_h560 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1026_recursiveGen;
                  bool _1027_recOwned;
                  bool _1028_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1029_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out579;
                  bool _out580;
                  bool _out581;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out582;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out579, out _out580, out _out581, out _out582);
                  _1026_recursiveGen = _out579;
                  _1027_recOwned = _out580;
                  _1028_recErased = _out581;
                  _1029_recIdents = _out582;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1026_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1027_recOwned;
                  isErased = _1028_recErased;
                  readIdents = _1029_recIdents;
                }
              } else if (_source41.is_Seq) {
                DAST._IType _1030___mcc_h562 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1031_recursiveGen;
                  bool _1032_recOwned;
                  bool _1033_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1034_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out583;
                  bool _out584;
                  bool _out585;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out586;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out583, out _out584, out _out585, out _out586);
                  _1031_recursiveGen = _out583;
                  _1032_recOwned = _out584;
                  _1033_recErased = _out585;
                  _1034_recIdents = _out586;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1031_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1032_recOwned;
                  isErased = _1033_recErased;
                  readIdents = _1034_recIdents;
                }
              } else if (_source41.is_Set) {
                DAST._IType _1035___mcc_h564 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1036_recursiveGen;
                  bool _1037_recOwned;
                  bool _1038_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1039_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out587;
                  bool _out588;
                  bool _out589;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out590;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out587, out _out588, out _out589, out _out590);
                  _1036_recursiveGen = _out587;
                  _1037_recOwned = _out588;
                  _1038_recErased = _out589;
                  _1039_recIdents = _out590;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1036_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1037_recOwned;
                  isErased = _1038_recErased;
                  readIdents = _1039_recIdents;
                }
              } else if (_source41.is_Multiset) {
                DAST._IType _1040___mcc_h566 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1041_recursiveGen;
                  bool _1042_recOwned;
                  bool _1043_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1044_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out591;
                  bool _out592;
                  bool _out593;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out594;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out591, out _out592, out _out593, out _out594);
                  _1041_recursiveGen = _out591;
                  _1042_recOwned = _out592;
                  _1043_recErased = _out593;
                  _1044_recIdents = _out594;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1041_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1042_recOwned;
                  isErased = _1043_recErased;
                  readIdents = _1044_recIdents;
                }
              } else if (_source41.is_Map) {
                DAST._IType _1045___mcc_h568 = _source41.dtor_key;
                DAST._IType _1046___mcc_h569 = _source41.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1047_recursiveGen;
                  bool _1048_recOwned;
                  bool _1049_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1050_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out595;
                  bool _out596;
                  bool _out597;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out598;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out595, out _out596, out _out597, out _out598);
                  _1047_recursiveGen = _out595;
                  _1048_recOwned = _out596;
                  _1049_recErased = _out597;
                  _1050_recIdents = _out598;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1047_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1048_recOwned;
                  isErased = _1049_recErased;
                  readIdents = _1050_recIdents;
                }
              } else if (_source41.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1051___mcc_h572 = _source41.dtor_args;
                DAST._IType _1052___mcc_h573 = _source41.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1053_recursiveGen;
                  bool _1054_recOwned;
                  bool _1055_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1056_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out599;
                  bool _out600;
                  bool _out601;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out602;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out599, out _out600, out _out601, out _out602);
                  _1053_recursiveGen = _out599;
                  _1054_recOwned = _out600;
                  _1055_recErased = _out601;
                  _1056_recIdents = _out602;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1053_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1054_recOwned;
                  isErased = _1055_recErased;
                  readIdents = _1056_recIdents;
                }
              } else if (_source41.is_Primitive) {
                DAST._IPrimitive _1057___mcc_h576 = _source41.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1058_recursiveGen;
                  bool _1059_recOwned;
                  bool _1060_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1061_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out603;
                  bool _out604;
                  bool _out605;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out606;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out603, out _out604, out _out605, out _out606);
                  _1058_recursiveGen = _out603;
                  _1059_recOwned = _out604;
                  _1060_recErased = _out605;
                  _1061_recIdents = _out606;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1058_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1059_recOwned;
                  isErased = _1060_recErased;
                  readIdents = _1061_recIdents;
                }
              } else if (_source41.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1062___mcc_h578 = _source41.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1063_recursiveGen;
                  bool _1064_recOwned;
                  bool _1065_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1066_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out607;
                  bool _out608;
                  bool _out609;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out610;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out607, out _out608, out _out609, out _out610);
                  _1063_recursiveGen = _out607;
                  _1064_recOwned = _out608;
                  _1065_recErased = _out609;
                  _1066_recIdents = _out610;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1063_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1064_recOwned;
                  isErased = _1065_recErased;
                  readIdents = _1066_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1067___mcc_h580 = _source41.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1068_recursiveGen;
                  bool _1069_recOwned;
                  bool _1070_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1071_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out611;
                  bool _out612;
                  bool _out613;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out614;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out611, out _out612, out _out613, out _out614);
                  _1068_recursiveGen = _out611;
                  _1069_recOwned = _out612;
                  _1070_recErased = _out613;
                  _1071_recIdents = _out614;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1068_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1069_recOwned;
                  isErased = _1070_recErased;
                  readIdents = _1071_recIdents;
                }
              }
            } else if (_source27.is_Set) {
              DAST._IType _1072___mcc_h582 = _source27.dtor_element;
              DAST._IType _source43 = _494___mcc_h235;
              if (_source43.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1073___mcc_h586 = _source43.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1074___mcc_h587 = _source43.dtor_typeArgs;
                DAST._IResolvedType _1075___mcc_h588 = _source43.dtor_resolved;
                DAST._IResolvedType _source44 = _1075___mcc_h588;
                if (_source44.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1076___mcc_h592 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1077_recursiveGen;
                    bool _1078_recOwned;
                    bool _1079_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1080_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out615;
                    bool _out616;
                    bool _out617;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out618;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out615, out _out616, out _out617, out _out618);
                    _1077_recursiveGen = _out615;
                    _1078_recOwned = _out616;
                    _1079_recErased = _out617;
                    _1080_recIdents = _out618;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1077_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1078_recOwned;
                    isErased = _1079_recErased;
                    readIdents = _1080_recIdents;
                  }
                } else if (_source44.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1081___mcc_h594 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1082_recursiveGen;
                    bool _1083_recOwned;
                    bool _1084_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1085_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out619;
                    bool _out620;
                    bool _out621;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out622;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out619, out _out620, out _out621, out _out622);
                    _1082_recursiveGen = _out619;
                    _1083_recOwned = _out620;
                    _1084_recErased = _out621;
                    _1085_recIdents = _out622;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1082_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1083_recOwned;
                    isErased = _1084_recErased;
                    readIdents = _1085_recIdents;
                  }
                } else {
                  DAST._IType _1086___mcc_h596 = _source44.dtor_Newtype_a0;
                  DAST._IType _1087_b = _1086___mcc_h596;
                  {
                    if (object.Equals(_487_fromTpe, _1087_b)) {
                      Dafny.ISequence<Dafny.Rune> _1088_recursiveGen;
                      bool _1089_recOwned;
                      bool _1090_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1091_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out623;
                      bool _out624;
                      bool _out625;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out626;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out623, out _out624, out _out625, out _out626);
                      _1088_recursiveGen = _out623;
                      _1089_recOwned = _out624;
                      _1090_recErased = _out625;
                      _1091_recIdents = _out626;
                      Dafny.ISequence<Dafny.Rune> _1092_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out627;
                      _out627 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _1092_rhsType = _out627;
                      Dafny.ISequence<Dafny.Rune> _1093_uneraseFn;
                      _1093_uneraseFn = ((_1089_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1092_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1093_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1088_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1089_recOwned;
                      isErased = false;
                      readIdents = _1091_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out628;
                      bool _out629;
                      bool _out630;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out631;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1087_b), _1087_b, _486_toTpe), selfIdent, @params, mustOwn, out _out628, out _out629, out _out630, out _out631);
                      s = _out628;
                      isOwned = _out629;
                      isErased = _out630;
                      readIdents = _out631;
                    }
                  }
                }
              } else if (_source43.is_Nullable) {
                DAST._IType _1094___mcc_h598 = _source43.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1095_recursiveGen;
                  bool _1096_recOwned;
                  bool _1097_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1098_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out632;
                  bool _out633;
                  bool _out634;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out635;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out632, out _out633, out _out634, out _out635);
                  _1095_recursiveGen = _out632;
                  _1096_recOwned = _out633;
                  _1097_recErased = _out634;
                  _1098_recIdents = _out635;
                  if (!(_1096_recOwned)) {
                    _1095_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1095_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1095_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1097_recErased;
                  readIdents = _1098_recIdents;
                }
              } else if (_source43.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1099___mcc_h600 = _source43.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1100_recursiveGen;
                  bool _1101_recOwned;
                  bool _1102_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1103_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out636;
                  bool _out637;
                  bool _out638;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out639;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out636, out _out637, out _out638, out _out639);
                  _1100_recursiveGen = _out636;
                  _1101_recOwned = _out637;
                  _1102_recErased = _out638;
                  _1103_recIdents = _out639;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1100_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1101_recOwned;
                  isErased = _1102_recErased;
                  readIdents = _1103_recIdents;
                }
              } else if (_source43.is_Array) {
                DAST._IType _1104___mcc_h602 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1105_recursiveGen;
                  bool _1106_recOwned;
                  bool _1107_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1108_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out640;
                  bool _out641;
                  bool _out642;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out643;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out640, out _out641, out _out642, out _out643);
                  _1105_recursiveGen = _out640;
                  _1106_recOwned = _out641;
                  _1107_recErased = _out642;
                  _1108_recIdents = _out643;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1105_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1106_recOwned;
                  isErased = _1107_recErased;
                  readIdents = _1108_recIdents;
                }
              } else if (_source43.is_Seq) {
                DAST._IType _1109___mcc_h604 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1110_recursiveGen;
                  bool _1111_recOwned;
                  bool _1112_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1113_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out644;
                  bool _out645;
                  bool _out646;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out647;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out644, out _out645, out _out646, out _out647);
                  _1110_recursiveGen = _out644;
                  _1111_recOwned = _out645;
                  _1112_recErased = _out646;
                  _1113_recIdents = _out647;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1110_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1111_recOwned;
                  isErased = _1112_recErased;
                  readIdents = _1113_recIdents;
                }
              } else if (_source43.is_Set) {
                DAST._IType _1114___mcc_h606 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1115_recursiveGen;
                  bool _1116_recOwned;
                  bool _1117_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1118_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out648;
                  bool _out649;
                  bool _out650;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out651;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out648, out _out649, out _out650, out _out651);
                  _1115_recursiveGen = _out648;
                  _1116_recOwned = _out649;
                  _1117_recErased = _out650;
                  _1118_recIdents = _out651;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1115_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1116_recOwned;
                  isErased = _1117_recErased;
                  readIdents = _1118_recIdents;
                }
              } else if (_source43.is_Multiset) {
                DAST._IType _1119___mcc_h608 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1120_recursiveGen;
                  bool _1121_recOwned;
                  bool _1122_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1123_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out652;
                  bool _out653;
                  bool _out654;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out655;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out652, out _out653, out _out654, out _out655);
                  _1120_recursiveGen = _out652;
                  _1121_recOwned = _out653;
                  _1122_recErased = _out654;
                  _1123_recIdents = _out655;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1120_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1121_recOwned;
                  isErased = _1122_recErased;
                  readIdents = _1123_recIdents;
                }
              } else if (_source43.is_Map) {
                DAST._IType _1124___mcc_h610 = _source43.dtor_key;
                DAST._IType _1125___mcc_h611 = _source43.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1126_recursiveGen;
                  bool _1127_recOwned;
                  bool _1128_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1129_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out656;
                  bool _out657;
                  bool _out658;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out659;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out656, out _out657, out _out658, out _out659);
                  _1126_recursiveGen = _out656;
                  _1127_recOwned = _out657;
                  _1128_recErased = _out658;
                  _1129_recIdents = _out659;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1126_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1127_recOwned;
                  isErased = _1128_recErased;
                  readIdents = _1129_recIdents;
                }
              } else if (_source43.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1130___mcc_h614 = _source43.dtor_args;
                DAST._IType _1131___mcc_h615 = _source43.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1132_recursiveGen;
                  bool _1133_recOwned;
                  bool _1134_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1135_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out660;
                  bool _out661;
                  bool _out662;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out663;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out660, out _out661, out _out662, out _out663);
                  _1132_recursiveGen = _out660;
                  _1133_recOwned = _out661;
                  _1134_recErased = _out662;
                  _1135_recIdents = _out663;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1132_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1133_recOwned;
                  isErased = _1134_recErased;
                  readIdents = _1135_recIdents;
                }
              } else if (_source43.is_Primitive) {
                DAST._IPrimitive _1136___mcc_h618 = _source43.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1137_recursiveGen;
                  bool _1138_recOwned;
                  bool _1139_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1140_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out664;
                  bool _out665;
                  bool _out666;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out667;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out664, out _out665, out _out666, out _out667);
                  _1137_recursiveGen = _out664;
                  _1138_recOwned = _out665;
                  _1139_recErased = _out666;
                  _1140_recIdents = _out667;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1137_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1138_recOwned;
                  isErased = _1139_recErased;
                  readIdents = _1140_recIdents;
                }
              } else if (_source43.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1141___mcc_h620 = _source43.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1142_recursiveGen;
                  bool _1143_recOwned;
                  bool _1144_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1145_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out668;
                  bool _out669;
                  bool _out670;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out671;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out668, out _out669, out _out670, out _out671);
                  _1142_recursiveGen = _out668;
                  _1143_recOwned = _out669;
                  _1144_recErased = _out670;
                  _1145_recIdents = _out671;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1142_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1143_recOwned;
                  isErased = _1144_recErased;
                  readIdents = _1145_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1146___mcc_h622 = _source43.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1147_recursiveGen;
                  bool _1148_recOwned;
                  bool _1149_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1150_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out672;
                  bool _out673;
                  bool _out674;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out675;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out672, out _out673, out _out674, out _out675);
                  _1147_recursiveGen = _out672;
                  _1148_recOwned = _out673;
                  _1149_recErased = _out674;
                  _1150_recIdents = _out675;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1147_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1148_recOwned;
                  isErased = _1149_recErased;
                  readIdents = _1150_recIdents;
                }
              }
            } else if (_source27.is_Multiset) {
              DAST._IType _1151___mcc_h624 = _source27.dtor_element;
              DAST._IType _source45 = _494___mcc_h235;
              if (_source45.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1152___mcc_h628 = _source45.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1153___mcc_h629 = _source45.dtor_typeArgs;
                DAST._IResolvedType _1154___mcc_h630 = _source45.dtor_resolved;
                DAST._IResolvedType _source46 = _1154___mcc_h630;
                if (_source46.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1155___mcc_h634 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1156_recursiveGen;
                    bool _1157_recOwned;
                    bool _1158_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1159_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out676;
                    bool _out677;
                    bool _out678;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out679;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out676, out _out677, out _out678, out _out679);
                    _1156_recursiveGen = _out676;
                    _1157_recOwned = _out677;
                    _1158_recErased = _out678;
                    _1159_recIdents = _out679;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1156_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1157_recOwned;
                    isErased = _1158_recErased;
                    readIdents = _1159_recIdents;
                  }
                } else if (_source46.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1160___mcc_h636 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1161_recursiveGen;
                    bool _1162_recOwned;
                    bool _1163_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1164_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out680;
                    bool _out681;
                    bool _out682;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out683;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out680, out _out681, out _out682, out _out683);
                    _1161_recursiveGen = _out680;
                    _1162_recOwned = _out681;
                    _1163_recErased = _out682;
                    _1164_recIdents = _out683;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1161_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1162_recOwned;
                    isErased = _1163_recErased;
                    readIdents = _1164_recIdents;
                  }
                } else {
                  DAST._IType _1165___mcc_h638 = _source46.dtor_Newtype_a0;
                  DAST._IType _1166_b = _1165___mcc_h638;
                  {
                    if (object.Equals(_487_fromTpe, _1166_b)) {
                      Dafny.ISequence<Dafny.Rune> _1167_recursiveGen;
                      bool _1168_recOwned;
                      bool _1169_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1170_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out684;
                      bool _out685;
                      bool _out686;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out687;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out684, out _out685, out _out686, out _out687);
                      _1167_recursiveGen = _out684;
                      _1168_recOwned = _out685;
                      _1169_recErased = _out686;
                      _1170_recIdents = _out687;
                      Dafny.ISequence<Dafny.Rune> _1171_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out688;
                      _out688 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _1171_rhsType = _out688;
                      Dafny.ISequence<Dafny.Rune> _1172_uneraseFn;
                      _1172_uneraseFn = ((_1168_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1171_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1172_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1167_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1168_recOwned;
                      isErased = false;
                      readIdents = _1170_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out689;
                      bool _out690;
                      bool _out691;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out692;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1166_b), _1166_b, _486_toTpe), selfIdent, @params, mustOwn, out _out689, out _out690, out _out691, out _out692);
                      s = _out689;
                      isOwned = _out690;
                      isErased = _out691;
                      readIdents = _out692;
                    }
                  }
                }
              } else if (_source45.is_Nullable) {
                DAST._IType _1173___mcc_h640 = _source45.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1174_recursiveGen;
                  bool _1175_recOwned;
                  bool _1176_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1177_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out693;
                  bool _out694;
                  bool _out695;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out696;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out693, out _out694, out _out695, out _out696);
                  _1174_recursiveGen = _out693;
                  _1175_recOwned = _out694;
                  _1176_recErased = _out695;
                  _1177_recIdents = _out696;
                  if (!(_1175_recOwned)) {
                    _1174_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1174_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1174_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1176_recErased;
                  readIdents = _1177_recIdents;
                }
              } else if (_source45.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1178___mcc_h642 = _source45.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1179_recursiveGen;
                  bool _1180_recOwned;
                  bool _1181_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1182_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out697;
                  bool _out698;
                  bool _out699;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out700;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out697, out _out698, out _out699, out _out700);
                  _1179_recursiveGen = _out697;
                  _1180_recOwned = _out698;
                  _1181_recErased = _out699;
                  _1182_recIdents = _out700;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1179_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1180_recOwned;
                  isErased = _1181_recErased;
                  readIdents = _1182_recIdents;
                }
              } else if (_source45.is_Array) {
                DAST._IType _1183___mcc_h644 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1184_recursiveGen;
                  bool _1185_recOwned;
                  bool _1186_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1187_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out701;
                  bool _out702;
                  bool _out703;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out704;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out701, out _out702, out _out703, out _out704);
                  _1184_recursiveGen = _out701;
                  _1185_recOwned = _out702;
                  _1186_recErased = _out703;
                  _1187_recIdents = _out704;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1184_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1185_recOwned;
                  isErased = _1186_recErased;
                  readIdents = _1187_recIdents;
                }
              } else if (_source45.is_Seq) {
                DAST._IType _1188___mcc_h646 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1189_recursiveGen;
                  bool _1190_recOwned;
                  bool _1191_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1192_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out705;
                  bool _out706;
                  bool _out707;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out708;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out705, out _out706, out _out707, out _out708);
                  _1189_recursiveGen = _out705;
                  _1190_recOwned = _out706;
                  _1191_recErased = _out707;
                  _1192_recIdents = _out708;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1189_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1190_recOwned;
                  isErased = _1191_recErased;
                  readIdents = _1192_recIdents;
                }
              } else if (_source45.is_Set) {
                DAST._IType _1193___mcc_h648 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1194_recursiveGen;
                  bool _1195_recOwned;
                  bool _1196_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1197_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out709;
                  bool _out710;
                  bool _out711;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out712;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out709, out _out710, out _out711, out _out712);
                  _1194_recursiveGen = _out709;
                  _1195_recOwned = _out710;
                  _1196_recErased = _out711;
                  _1197_recIdents = _out712;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1194_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1195_recOwned;
                  isErased = _1196_recErased;
                  readIdents = _1197_recIdents;
                }
              } else if (_source45.is_Multiset) {
                DAST._IType _1198___mcc_h650 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1199_recursiveGen;
                  bool _1200_recOwned;
                  bool _1201_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1202_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out713;
                  bool _out714;
                  bool _out715;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out716;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out713, out _out714, out _out715, out _out716);
                  _1199_recursiveGen = _out713;
                  _1200_recOwned = _out714;
                  _1201_recErased = _out715;
                  _1202_recIdents = _out716;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1199_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1200_recOwned;
                  isErased = _1201_recErased;
                  readIdents = _1202_recIdents;
                }
              } else if (_source45.is_Map) {
                DAST._IType _1203___mcc_h652 = _source45.dtor_key;
                DAST._IType _1204___mcc_h653 = _source45.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1205_recursiveGen;
                  bool _1206_recOwned;
                  bool _1207_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1208_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out717;
                  bool _out718;
                  bool _out719;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out720;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out717, out _out718, out _out719, out _out720);
                  _1205_recursiveGen = _out717;
                  _1206_recOwned = _out718;
                  _1207_recErased = _out719;
                  _1208_recIdents = _out720;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1205_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1206_recOwned;
                  isErased = _1207_recErased;
                  readIdents = _1208_recIdents;
                }
              } else if (_source45.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1209___mcc_h656 = _source45.dtor_args;
                DAST._IType _1210___mcc_h657 = _source45.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1211_recursiveGen;
                  bool _1212_recOwned;
                  bool _1213_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1214_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out721;
                  bool _out722;
                  bool _out723;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out724;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out721, out _out722, out _out723, out _out724);
                  _1211_recursiveGen = _out721;
                  _1212_recOwned = _out722;
                  _1213_recErased = _out723;
                  _1214_recIdents = _out724;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1211_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1212_recOwned;
                  isErased = _1213_recErased;
                  readIdents = _1214_recIdents;
                }
              } else if (_source45.is_Primitive) {
                DAST._IPrimitive _1215___mcc_h660 = _source45.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1216_recursiveGen;
                  bool _1217_recOwned;
                  bool _1218_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1219_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out725;
                  bool _out726;
                  bool _out727;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out728;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out725, out _out726, out _out727, out _out728);
                  _1216_recursiveGen = _out725;
                  _1217_recOwned = _out726;
                  _1218_recErased = _out727;
                  _1219_recIdents = _out728;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1216_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1217_recOwned;
                  isErased = _1218_recErased;
                  readIdents = _1219_recIdents;
                }
              } else if (_source45.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1220___mcc_h662 = _source45.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1221_recursiveGen;
                  bool _1222_recOwned;
                  bool _1223_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1224_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out729;
                  bool _out730;
                  bool _out731;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out732;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out729, out _out730, out _out731, out _out732);
                  _1221_recursiveGen = _out729;
                  _1222_recOwned = _out730;
                  _1223_recErased = _out731;
                  _1224_recIdents = _out732;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1221_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1222_recOwned;
                  isErased = _1223_recErased;
                  readIdents = _1224_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1225___mcc_h664 = _source45.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1226_recursiveGen;
                  bool _1227_recOwned;
                  bool _1228_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1229_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out733;
                  bool _out734;
                  bool _out735;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out736;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out733, out _out734, out _out735, out _out736);
                  _1226_recursiveGen = _out733;
                  _1227_recOwned = _out734;
                  _1228_recErased = _out735;
                  _1229_recIdents = _out736;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1226_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1227_recOwned;
                  isErased = _1228_recErased;
                  readIdents = _1229_recIdents;
                }
              }
            } else if (_source27.is_Map) {
              DAST._IType _1230___mcc_h666 = _source27.dtor_key;
              DAST._IType _1231___mcc_h667 = _source27.dtor_value;
              DAST._IType _source47 = _494___mcc_h235;
              if (_source47.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1232___mcc_h674 = _source47.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1233___mcc_h675 = _source47.dtor_typeArgs;
                DAST._IResolvedType _1234___mcc_h676 = _source47.dtor_resolved;
                DAST._IResolvedType _source48 = _1234___mcc_h676;
                if (_source48.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1235___mcc_h680 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1236_recursiveGen;
                    bool _1237_recOwned;
                    bool _1238_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1239_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out737;
                    bool _out738;
                    bool _out739;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out740;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out737, out _out738, out _out739, out _out740);
                    _1236_recursiveGen = _out737;
                    _1237_recOwned = _out738;
                    _1238_recErased = _out739;
                    _1239_recIdents = _out740;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1236_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1237_recOwned;
                    isErased = _1238_recErased;
                    readIdents = _1239_recIdents;
                  }
                } else if (_source48.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1240___mcc_h682 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1241_recursiveGen;
                    bool _1242_recOwned;
                    bool _1243_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1244_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out741;
                    bool _out742;
                    bool _out743;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out744;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out741, out _out742, out _out743, out _out744);
                    _1241_recursiveGen = _out741;
                    _1242_recOwned = _out742;
                    _1243_recErased = _out743;
                    _1244_recIdents = _out744;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1241_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1242_recOwned;
                    isErased = _1243_recErased;
                    readIdents = _1244_recIdents;
                  }
                } else {
                  DAST._IType _1245___mcc_h684 = _source48.dtor_Newtype_a0;
                  DAST._IType _1246_b = _1245___mcc_h684;
                  {
                    if (object.Equals(_487_fromTpe, _1246_b)) {
                      Dafny.ISequence<Dafny.Rune> _1247_recursiveGen;
                      bool _1248_recOwned;
                      bool _1249_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1250_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out745;
                      bool _out746;
                      bool _out747;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out748;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out745, out _out746, out _out747, out _out748);
                      _1247_recursiveGen = _out745;
                      _1248_recOwned = _out746;
                      _1249_recErased = _out747;
                      _1250_recIdents = _out748;
                      Dafny.ISequence<Dafny.Rune> _1251_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out749;
                      _out749 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _1251_rhsType = _out749;
                      Dafny.ISequence<Dafny.Rune> _1252_uneraseFn;
                      _1252_uneraseFn = ((_1248_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1251_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1252_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1247_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1248_recOwned;
                      isErased = false;
                      readIdents = _1250_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out750;
                      bool _out751;
                      bool _out752;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out753;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1246_b), _1246_b, _486_toTpe), selfIdent, @params, mustOwn, out _out750, out _out751, out _out752, out _out753);
                      s = _out750;
                      isOwned = _out751;
                      isErased = _out752;
                      readIdents = _out753;
                    }
                  }
                }
              } else if (_source47.is_Nullable) {
                DAST._IType _1253___mcc_h686 = _source47.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1254_recursiveGen;
                  bool _1255_recOwned;
                  bool _1256_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1257_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out754;
                  bool _out755;
                  bool _out756;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out757;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out754, out _out755, out _out756, out _out757);
                  _1254_recursiveGen = _out754;
                  _1255_recOwned = _out755;
                  _1256_recErased = _out756;
                  _1257_recIdents = _out757;
                  if (!(_1255_recOwned)) {
                    _1254_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1254_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1254_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1256_recErased;
                  readIdents = _1257_recIdents;
                }
              } else if (_source47.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1258___mcc_h688 = _source47.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1259_recursiveGen;
                  bool _1260_recOwned;
                  bool _1261_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1262_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out758;
                  bool _out759;
                  bool _out760;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out761;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out758, out _out759, out _out760, out _out761);
                  _1259_recursiveGen = _out758;
                  _1260_recOwned = _out759;
                  _1261_recErased = _out760;
                  _1262_recIdents = _out761;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1259_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1260_recOwned;
                  isErased = _1261_recErased;
                  readIdents = _1262_recIdents;
                }
              } else if (_source47.is_Array) {
                DAST._IType _1263___mcc_h690 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1264_recursiveGen;
                  bool _1265_recOwned;
                  bool _1266_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1267_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out762;
                  bool _out763;
                  bool _out764;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out765;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out762, out _out763, out _out764, out _out765);
                  _1264_recursiveGen = _out762;
                  _1265_recOwned = _out763;
                  _1266_recErased = _out764;
                  _1267_recIdents = _out765;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1264_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1265_recOwned;
                  isErased = _1266_recErased;
                  readIdents = _1267_recIdents;
                }
              } else if (_source47.is_Seq) {
                DAST._IType _1268___mcc_h692 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1269_recursiveGen;
                  bool _1270_recOwned;
                  bool _1271_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1272_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out766;
                  bool _out767;
                  bool _out768;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out769;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out766, out _out767, out _out768, out _out769);
                  _1269_recursiveGen = _out766;
                  _1270_recOwned = _out767;
                  _1271_recErased = _out768;
                  _1272_recIdents = _out769;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1269_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1270_recOwned;
                  isErased = _1271_recErased;
                  readIdents = _1272_recIdents;
                }
              } else if (_source47.is_Set) {
                DAST._IType _1273___mcc_h694 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1274_recursiveGen;
                  bool _1275_recOwned;
                  bool _1276_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1277_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out770;
                  bool _out771;
                  bool _out772;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out773;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out770, out _out771, out _out772, out _out773);
                  _1274_recursiveGen = _out770;
                  _1275_recOwned = _out771;
                  _1276_recErased = _out772;
                  _1277_recIdents = _out773;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1274_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1275_recOwned;
                  isErased = _1276_recErased;
                  readIdents = _1277_recIdents;
                }
              } else if (_source47.is_Multiset) {
                DAST._IType _1278___mcc_h696 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1279_recursiveGen;
                  bool _1280_recOwned;
                  bool _1281_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1282_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out774;
                  bool _out775;
                  bool _out776;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out777;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out774, out _out775, out _out776, out _out777);
                  _1279_recursiveGen = _out774;
                  _1280_recOwned = _out775;
                  _1281_recErased = _out776;
                  _1282_recIdents = _out777;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1279_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1280_recOwned;
                  isErased = _1281_recErased;
                  readIdents = _1282_recIdents;
                }
              } else if (_source47.is_Map) {
                DAST._IType _1283___mcc_h698 = _source47.dtor_key;
                DAST._IType _1284___mcc_h699 = _source47.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1285_recursiveGen;
                  bool _1286_recOwned;
                  bool _1287_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1288_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out778;
                  bool _out779;
                  bool _out780;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out781;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out778, out _out779, out _out780, out _out781);
                  _1285_recursiveGen = _out778;
                  _1286_recOwned = _out779;
                  _1287_recErased = _out780;
                  _1288_recIdents = _out781;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1285_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1286_recOwned;
                  isErased = _1287_recErased;
                  readIdents = _1288_recIdents;
                }
              } else if (_source47.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1289___mcc_h702 = _source47.dtor_args;
                DAST._IType _1290___mcc_h703 = _source47.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1291_recursiveGen;
                  bool _1292_recOwned;
                  bool _1293_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1294_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out782;
                  bool _out783;
                  bool _out784;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out785;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out782, out _out783, out _out784, out _out785);
                  _1291_recursiveGen = _out782;
                  _1292_recOwned = _out783;
                  _1293_recErased = _out784;
                  _1294_recIdents = _out785;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1291_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1292_recOwned;
                  isErased = _1293_recErased;
                  readIdents = _1294_recIdents;
                }
              } else if (_source47.is_Primitive) {
                DAST._IPrimitive _1295___mcc_h706 = _source47.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1296_recursiveGen;
                  bool _1297_recOwned;
                  bool _1298_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1299_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out786;
                  bool _out787;
                  bool _out788;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out789;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out786, out _out787, out _out788, out _out789);
                  _1296_recursiveGen = _out786;
                  _1297_recOwned = _out787;
                  _1298_recErased = _out788;
                  _1299_recIdents = _out789;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1296_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1297_recOwned;
                  isErased = _1298_recErased;
                  readIdents = _1299_recIdents;
                }
              } else if (_source47.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1300___mcc_h708 = _source47.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1301_recursiveGen;
                  bool _1302_recOwned;
                  bool _1303_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1304_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out790;
                  bool _out791;
                  bool _out792;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out793;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out790, out _out791, out _out792, out _out793);
                  _1301_recursiveGen = _out790;
                  _1302_recOwned = _out791;
                  _1303_recErased = _out792;
                  _1304_recIdents = _out793;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1301_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1302_recOwned;
                  isErased = _1303_recErased;
                  readIdents = _1304_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1305___mcc_h710 = _source47.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1306_recursiveGen;
                  bool _1307_recOwned;
                  bool _1308_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1309_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out794;
                  bool _out795;
                  bool _out796;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out797;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out794, out _out795, out _out796, out _out797);
                  _1306_recursiveGen = _out794;
                  _1307_recOwned = _out795;
                  _1308_recErased = _out796;
                  _1309_recIdents = _out797;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1306_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1307_recOwned;
                  isErased = _1308_recErased;
                  readIdents = _1309_recIdents;
                }
              }
            } else if (_source27.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1310___mcc_h712 = _source27.dtor_args;
              DAST._IType _1311___mcc_h713 = _source27.dtor_result;
              DAST._IType _source49 = _494___mcc_h235;
              if (_source49.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1312___mcc_h720 = _source49.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1313___mcc_h721 = _source49.dtor_typeArgs;
                DAST._IResolvedType _1314___mcc_h722 = _source49.dtor_resolved;
                DAST._IResolvedType _source50 = _1314___mcc_h722;
                if (_source50.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1315___mcc_h726 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1316_recursiveGen;
                    bool _1317_recOwned;
                    bool _1318_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1319_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out798;
                    bool _out799;
                    bool _out800;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out801;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out798, out _out799, out _out800, out _out801);
                    _1316_recursiveGen = _out798;
                    _1317_recOwned = _out799;
                    _1318_recErased = _out800;
                    _1319_recIdents = _out801;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1316_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1317_recOwned;
                    isErased = _1318_recErased;
                    readIdents = _1319_recIdents;
                  }
                } else if (_source50.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1320___mcc_h728 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1321_recursiveGen;
                    bool _1322_recOwned;
                    bool _1323_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1324_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out802;
                    bool _out803;
                    bool _out804;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out805;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out802, out _out803, out _out804, out _out805);
                    _1321_recursiveGen = _out802;
                    _1322_recOwned = _out803;
                    _1323_recErased = _out804;
                    _1324_recIdents = _out805;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1321_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1322_recOwned;
                    isErased = _1323_recErased;
                    readIdents = _1324_recIdents;
                  }
                } else {
                  DAST._IType _1325___mcc_h730 = _source50.dtor_Newtype_a0;
                  DAST._IType _1326_b = _1325___mcc_h730;
                  {
                    if (object.Equals(_487_fromTpe, _1326_b)) {
                      Dafny.ISequence<Dafny.Rune> _1327_recursiveGen;
                      bool _1328_recOwned;
                      bool _1329_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1330_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out806;
                      bool _out807;
                      bool _out808;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out809;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out806, out _out807, out _out808, out _out809);
                      _1327_recursiveGen = _out806;
                      _1328_recOwned = _out807;
                      _1329_recErased = _out808;
                      _1330_recIdents = _out809;
                      Dafny.ISequence<Dafny.Rune> _1331_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out810;
                      _out810 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _1331_rhsType = _out810;
                      Dafny.ISequence<Dafny.Rune> _1332_uneraseFn;
                      _1332_uneraseFn = ((_1328_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1331_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1332_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1327_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1328_recOwned;
                      isErased = false;
                      readIdents = _1330_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out811;
                      bool _out812;
                      bool _out813;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out814;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1326_b), _1326_b, _486_toTpe), selfIdent, @params, mustOwn, out _out811, out _out812, out _out813, out _out814);
                      s = _out811;
                      isOwned = _out812;
                      isErased = _out813;
                      readIdents = _out814;
                    }
                  }
                }
              } else if (_source49.is_Nullable) {
                DAST._IType _1333___mcc_h732 = _source49.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1334_recursiveGen;
                  bool _1335_recOwned;
                  bool _1336_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1337_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out815;
                  bool _out816;
                  bool _out817;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out818;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out815, out _out816, out _out817, out _out818);
                  _1334_recursiveGen = _out815;
                  _1335_recOwned = _out816;
                  _1336_recErased = _out817;
                  _1337_recIdents = _out818;
                  if (!(_1335_recOwned)) {
                    _1334_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1334_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1334_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1336_recErased;
                  readIdents = _1337_recIdents;
                }
              } else if (_source49.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1338___mcc_h734 = _source49.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1339_recursiveGen;
                  bool _1340_recOwned;
                  bool _1341_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1342_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out819;
                  bool _out820;
                  bool _out821;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out822;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out819, out _out820, out _out821, out _out822);
                  _1339_recursiveGen = _out819;
                  _1340_recOwned = _out820;
                  _1341_recErased = _out821;
                  _1342_recIdents = _out822;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1339_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1340_recOwned;
                  isErased = _1341_recErased;
                  readIdents = _1342_recIdents;
                }
              } else if (_source49.is_Array) {
                DAST._IType _1343___mcc_h736 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1344_recursiveGen;
                  bool _1345_recOwned;
                  bool _1346_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1347_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out823;
                  bool _out824;
                  bool _out825;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out826;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out823, out _out824, out _out825, out _out826);
                  _1344_recursiveGen = _out823;
                  _1345_recOwned = _out824;
                  _1346_recErased = _out825;
                  _1347_recIdents = _out826;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1344_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1345_recOwned;
                  isErased = _1346_recErased;
                  readIdents = _1347_recIdents;
                }
              } else if (_source49.is_Seq) {
                DAST._IType _1348___mcc_h738 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1349_recursiveGen;
                  bool _1350_recOwned;
                  bool _1351_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1352_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out827;
                  bool _out828;
                  bool _out829;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out827, out _out828, out _out829, out _out830);
                  _1349_recursiveGen = _out827;
                  _1350_recOwned = _out828;
                  _1351_recErased = _out829;
                  _1352_recIdents = _out830;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1349_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1350_recOwned;
                  isErased = _1351_recErased;
                  readIdents = _1352_recIdents;
                }
              } else if (_source49.is_Set) {
                DAST._IType _1353___mcc_h740 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1354_recursiveGen;
                  bool _1355_recOwned;
                  bool _1356_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1357_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out831;
                  bool _out832;
                  bool _out833;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                  _1354_recursiveGen = _out831;
                  _1355_recOwned = _out832;
                  _1356_recErased = _out833;
                  _1357_recIdents = _out834;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1354_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1355_recOwned;
                  isErased = _1356_recErased;
                  readIdents = _1357_recIdents;
                }
              } else if (_source49.is_Multiset) {
                DAST._IType _1358___mcc_h742 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1359_recursiveGen;
                  bool _1360_recOwned;
                  bool _1361_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1362_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out835;
                  bool _out836;
                  bool _out837;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                  _1359_recursiveGen = _out835;
                  _1360_recOwned = _out836;
                  _1361_recErased = _out837;
                  _1362_recIdents = _out838;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1359_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1360_recOwned;
                  isErased = _1361_recErased;
                  readIdents = _1362_recIdents;
                }
              } else if (_source49.is_Map) {
                DAST._IType _1363___mcc_h744 = _source49.dtor_key;
                DAST._IType _1364___mcc_h745 = _source49.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1365_recursiveGen;
                  bool _1366_recOwned;
                  bool _1367_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1368_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out839;
                  bool _out840;
                  bool _out841;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                  _1365_recursiveGen = _out839;
                  _1366_recOwned = _out840;
                  _1367_recErased = _out841;
                  _1368_recIdents = _out842;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1365_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1366_recOwned;
                  isErased = _1367_recErased;
                  readIdents = _1368_recIdents;
                }
              } else if (_source49.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1369___mcc_h748 = _source49.dtor_args;
                DAST._IType _1370___mcc_h749 = _source49.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1371_recursiveGen;
                  bool _1372_recOwned;
                  bool _1373_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1374_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out843;
                  bool _out844;
                  bool _out845;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                  _1371_recursiveGen = _out843;
                  _1372_recOwned = _out844;
                  _1373_recErased = _out845;
                  _1374_recIdents = _out846;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1371_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1372_recOwned;
                  isErased = _1373_recErased;
                  readIdents = _1374_recIdents;
                }
              } else if (_source49.is_Primitive) {
                DAST._IPrimitive _1375___mcc_h752 = _source49.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1376_recursiveGen;
                  bool _1377_recOwned;
                  bool _1378_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1379_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out847;
                  bool _out848;
                  bool _out849;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out850;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out847, out _out848, out _out849, out _out850);
                  _1376_recursiveGen = _out847;
                  _1377_recOwned = _out848;
                  _1378_recErased = _out849;
                  _1379_recIdents = _out850;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1376_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1377_recOwned;
                  isErased = _1378_recErased;
                  readIdents = _1379_recIdents;
                }
              } else if (_source49.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1380___mcc_h754 = _source49.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1381_recursiveGen;
                  bool _1382_recOwned;
                  bool _1383_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1384_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out851;
                  bool _out852;
                  bool _out853;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out854;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out851, out _out852, out _out853, out _out854);
                  _1381_recursiveGen = _out851;
                  _1382_recOwned = _out852;
                  _1383_recErased = _out853;
                  _1384_recIdents = _out854;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1381_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1382_recOwned;
                  isErased = _1383_recErased;
                  readIdents = _1384_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1385___mcc_h756 = _source49.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1386_recursiveGen;
                  bool _1387_recOwned;
                  bool _1388_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1389_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out855;
                  bool _out856;
                  bool _out857;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out858;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out855, out _out856, out _out857, out _out858);
                  _1386_recursiveGen = _out855;
                  _1387_recOwned = _out856;
                  _1388_recErased = _out857;
                  _1389_recIdents = _out858;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1386_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1387_recOwned;
                  isErased = _1388_recErased;
                  readIdents = _1389_recIdents;
                }
              }
            } else if (_source27.is_Primitive) {
              DAST._IPrimitive _1390___mcc_h758 = _source27.dtor_Primitive_a0;
              DAST._IPrimitive _source51 = _1390___mcc_h758;
              if (_source51.is_Int) {
                DAST._IType _source52 = _494___mcc_h235;
                if (_source52.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1391___mcc_h762 = _source52.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1392___mcc_h763 = _source52.dtor_typeArgs;
                  DAST._IResolvedType _1393___mcc_h764 = _source52.dtor_resolved;
                  DAST._IResolvedType _source53 = _1393___mcc_h764;
                  if (_source53.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1394___mcc_h768 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1395_recursiveGen;
                      bool _1396_recOwned;
                      bool _1397_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1398_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out859;
                      bool _out860;
                      bool _out861;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out862;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out859, out _out860, out _out861, out _out862);
                      _1395_recursiveGen = _out859;
                      _1396_recOwned = _out860;
                      _1397_recErased = _out861;
                      _1398_recIdents = _out862;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1395_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1396_recOwned;
                      isErased = _1397_recErased;
                      readIdents = _1398_recIdents;
                    }
                  } else if (_source53.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1399___mcc_h770 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1400_recursiveGen;
                      bool _1401_recOwned;
                      bool _1402_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1403_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out863;
                      bool _out864;
                      bool _out865;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out866;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out863, out _out864, out _out865, out _out866);
                      _1400_recursiveGen = _out863;
                      _1401_recOwned = _out864;
                      _1402_recErased = _out865;
                      _1403_recIdents = _out866;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1400_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1401_recOwned;
                      isErased = _1402_recErased;
                      readIdents = _1403_recIdents;
                    }
                  } else {
                    DAST._IType _1404___mcc_h772 = _source53.dtor_Newtype_a0;
                    DAST._IType _1405_b = _1404___mcc_h772;
                    {
                      if (object.Equals(_487_fromTpe, _1405_b)) {
                        Dafny.ISequence<Dafny.Rune> _1406_recursiveGen;
                        bool _1407_recOwned;
                        bool _1408_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1409_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out867;
                        bool _out868;
                        bool _out869;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out870;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out867, out _out868, out _out869, out _out870);
                        _1406_recursiveGen = _out867;
                        _1407_recOwned = _out868;
                        _1408_recErased = _out869;
                        _1409_recIdents = _out870;
                        Dafny.ISequence<Dafny.Rune> _1410_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out871;
                        _out871 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                        _1410_rhsType = _out871;
                        Dafny.ISequence<Dafny.Rune> _1411_uneraseFn;
                        _1411_uneraseFn = ((_1407_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1410_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1411_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1406_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1407_recOwned;
                        isErased = false;
                        readIdents = _1409_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out872;
                        bool _out873;
                        bool _out874;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out875;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1405_b), _1405_b, _486_toTpe), selfIdent, @params, mustOwn, out _out872, out _out873, out _out874, out _out875);
                        s = _out872;
                        isOwned = _out873;
                        isErased = _out874;
                        readIdents = _out875;
                      }
                    }
                  }
                } else if (_source52.is_Nullable) {
                  DAST._IType _1412___mcc_h774 = _source52.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1413_recursiveGen;
                    bool _1414_recOwned;
                    bool _1415_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1416_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out876;
                    bool _out877;
                    bool _out878;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out879;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out876, out _out877, out _out878, out _out879);
                    _1413_recursiveGen = _out876;
                    _1414_recOwned = _out877;
                    _1415_recErased = _out878;
                    _1416_recIdents = _out879;
                    if (!(_1414_recOwned)) {
                      _1413_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1413_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1413_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1415_recErased;
                    readIdents = _1416_recIdents;
                  }
                } else if (_source52.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1417___mcc_h776 = _source52.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1418_recursiveGen;
                    bool _1419_recOwned;
                    bool _1420_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1421_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out880;
                    bool _out881;
                    bool _out882;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                    _1418_recursiveGen = _out880;
                    _1419_recOwned = _out881;
                    _1420_recErased = _out882;
                    _1421_recIdents = _out883;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1418_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1419_recOwned;
                    isErased = _1420_recErased;
                    readIdents = _1421_recIdents;
                  }
                } else if (_source52.is_Array) {
                  DAST._IType _1422___mcc_h778 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1423_recursiveGen;
                    bool _1424_recOwned;
                    bool _1425_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1426_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out884;
                    bool _out885;
                    bool _out886;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                    _1423_recursiveGen = _out884;
                    _1424_recOwned = _out885;
                    _1425_recErased = _out886;
                    _1426_recIdents = _out887;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1423_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1424_recOwned;
                    isErased = _1425_recErased;
                    readIdents = _1426_recIdents;
                  }
                } else if (_source52.is_Seq) {
                  DAST._IType _1427___mcc_h780 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1428_recursiveGen;
                    bool _1429_recOwned;
                    bool _1430_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1431_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out888;
                    bool _out889;
                    bool _out890;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                    _1428_recursiveGen = _out888;
                    _1429_recOwned = _out889;
                    _1430_recErased = _out890;
                    _1431_recIdents = _out891;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1428_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1429_recOwned;
                    isErased = _1430_recErased;
                    readIdents = _1431_recIdents;
                  }
                } else if (_source52.is_Set) {
                  DAST._IType _1432___mcc_h782 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1433_recursiveGen;
                    bool _1434_recOwned;
                    bool _1435_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1436_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out892;
                    bool _out893;
                    bool _out894;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                    _1433_recursiveGen = _out892;
                    _1434_recOwned = _out893;
                    _1435_recErased = _out894;
                    _1436_recIdents = _out895;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1433_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1434_recOwned;
                    isErased = _1435_recErased;
                    readIdents = _1436_recIdents;
                  }
                } else if (_source52.is_Multiset) {
                  DAST._IType _1437___mcc_h784 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1438_recursiveGen;
                    bool _1439_recOwned;
                    bool _1440_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1441_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out896;
                    bool _out897;
                    bool _out898;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                    _1438_recursiveGen = _out896;
                    _1439_recOwned = _out897;
                    _1440_recErased = _out898;
                    _1441_recIdents = _out899;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1438_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1439_recOwned;
                    isErased = _1440_recErased;
                    readIdents = _1441_recIdents;
                  }
                } else if (_source52.is_Map) {
                  DAST._IType _1442___mcc_h786 = _source52.dtor_key;
                  DAST._IType _1443___mcc_h787 = _source52.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1444_recursiveGen;
                    bool _1445_recOwned;
                    bool _1446_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1447_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1444_recursiveGen = _out900;
                    _1445_recOwned = _out901;
                    _1446_recErased = _out902;
                    _1447_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1444_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1445_recOwned;
                    isErased = _1446_recErased;
                    readIdents = _1447_recIdents;
                  }
                } else if (_source52.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1448___mcc_h790 = _source52.dtor_args;
                  DAST._IType _1449___mcc_h791 = _source52.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1450_recursiveGen;
                    bool _1451_recOwned;
                    bool _1452_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1453_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1450_recursiveGen = _out904;
                    _1451_recOwned = _out905;
                    _1452_recErased = _out906;
                    _1453_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1450_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1451_recOwned;
                    isErased = _1452_recErased;
                    readIdents = _1453_recIdents;
                  }
                } else if (_source52.is_Primitive) {
                  DAST._IPrimitive _1454___mcc_h794 = _source52.dtor_Primitive_a0;
                  DAST._IPrimitive _source54 = _1454___mcc_h794;
                  if (_source54.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1455_recursiveGen;
                      bool _1456_recOwned;
                      bool _1457_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1458_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out908;
                      bool _out909;
                      bool _out910;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                      _1455_recursiveGen = _out908;
                      _1456_recOwned = _out909;
                      _1457_recErased = _out910;
                      _1458_recIdents = _out911;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1455_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1456_recOwned;
                      isErased = _1457_recErased;
                      readIdents = _1458_recIdents;
                    }
                  } else if (_source54.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1459_recursiveGen;
                      bool _1460___v43;
                      bool _1461___v44;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1462_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out912;
                      bool _out913;
                      bool _out914;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, true, out _out912, out _out913, out _out914, out _out915);
                      _1459_recursiveGen = _out912;
                      _1460___v43 = _out913;
                      _1461___v44 = _out914;
                      _1462_recIdents = _out915;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1459_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1462_recIdents;
                    }
                  } else if (_source54.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1463_recursiveGen;
                      bool _1464_recOwned;
                      bool _1465_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1466_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out916;
                      bool _out917;
                      bool _out918;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                      _1463_recursiveGen = _out916;
                      _1464_recOwned = _out917;
                      _1465_recErased = _out918;
                      _1466_recIdents = _out919;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1463_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1464_recOwned;
                      isErased = _1465_recErased;
                      readIdents = _1466_recIdents;
                    }
                  } else if (_source54.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1467_recursiveGen;
                      bool _1468_recOwned;
                      bool _1469_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1470_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out920;
                      bool _out921;
                      bool _out922;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out920, out _out921, out _out922, out _out923);
                      _1467_recursiveGen = _out920;
                      _1468_recOwned = _out921;
                      _1469_recErased = _out922;
                      _1470_recIdents = _out923;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1467_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1468_recOwned;
                      isErased = _1469_recErased;
                      readIdents = _1470_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1471_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out924;
                      _out924 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _1471_rhsType = _out924;
                      Dafny.ISequence<Dafny.Rune> _1472_recursiveGen;
                      bool _1473___v53;
                      bool _1474___v54;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1475_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out925;
                      bool _out926;
                      bool _out927;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out928;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, true, out _out925, out _out926, out _out927, out _out928);
                      _1472_recursiveGen = _out925;
                      _1473___v53 = _out926;
                      _1474___v54 = _out927;
                      _1475_recIdents = _out928;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1472_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1475_recIdents;
                    }
                  }
                } else if (_source52.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1476___mcc_h796 = _source52.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1477_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out929;
                    _out929 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                    _1477_rhsType = _out929;
                    Dafny.ISequence<Dafny.Rune> _1478_recursiveGen;
                    bool _1479___v48;
                    bool _1480___v49;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1481_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out930;
                    bool _out931;
                    bool _out932;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out933;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, true, out _out930, out _out931, out _out932, out _out933);
                    _1478_recursiveGen = _out930;
                    _1479___v48 = _out931;
                    _1480___v49 = _out932;
                    _1481_recIdents = _out933;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1477_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1478_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1481_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1482___mcc_h798 = _source52.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1483_recursiveGen;
                    bool _1484_recOwned;
                    bool _1485_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1486_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out934;
                    bool _out935;
                    bool _out936;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out937;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out934, out _out935, out _out936, out _out937);
                    _1483_recursiveGen = _out934;
                    _1484_recOwned = _out935;
                    _1485_recErased = _out936;
                    _1486_recIdents = _out937;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1483_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1484_recOwned;
                    isErased = _1485_recErased;
                    readIdents = _1486_recIdents;
                  }
                }
              } else if (_source51.is_Real) {
                DAST._IType _source55 = _494___mcc_h235;
                if (_source55.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1487___mcc_h800 = _source55.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1488___mcc_h801 = _source55.dtor_typeArgs;
                  DAST._IResolvedType _1489___mcc_h802 = _source55.dtor_resolved;
                  DAST._IResolvedType _source56 = _1489___mcc_h802;
                  if (_source56.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1490___mcc_h806 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1491_recursiveGen;
                      bool _1492_recOwned;
                      bool _1493_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1494_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out938;
                      bool _out939;
                      bool _out940;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out941;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out938, out _out939, out _out940, out _out941);
                      _1491_recursiveGen = _out938;
                      _1492_recOwned = _out939;
                      _1493_recErased = _out940;
                      _1494_recIdents = _out941;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1491_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1492_recOwned;
                      isErased = _1493_recErased;
                      readIdents = _1494_recIdents;
                    }
                  } else if (_source56.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1495___mcc_h808 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1496_recursiveGen;
                      bool _1497_recOwned;
                      bool _1498_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1499_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out942;
                      bool _out943;
                      bool _out944;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out945;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out942, out _out943, out _out944, out _out945);
                      _1496_recursiveGen = _out942;
                      _1497_recOwned = _out943;
                      _1498_recErased = _out944;
                      _1499_recIdents = _out945;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1496_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1497_recOwned;
                      isErased = _1498_recErased;
                      readIdents = _1499_recIdents;
                    }
                  } else {
                    DAST._IType _1500___mcc_h810 = _source56.dtor_Newtype_a0;
                    DAST._IType _1501_b = _1500___mcc_h810;
                    {
                      if (object.Equals(_487_fromTpe, _1501_b)) {
                        Dafny.ISequence<Dafny.Rune> _1502_recursiveGen;
                        bool _1503_recOwned;
                        bool _1504_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1505_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out946;
                        bool _out947;
                        bool _out948;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out949;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out946, out _out947, out _out948, out _out949);
                        _1502_recursiveGen = _out946;
                        _1503_recOwned = _out947;
                        _1504_recErased = _out948;
                        _1505_recIdents = _out949;
                        Dafny.ISequence<Dafny.Rune> _1506_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out950;
                        _out950 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                        _1506_rhsType = _out950;
                        Dafny.ISequence<Dafny.Rune> _1507_uneraseFn;
                        _1507_uneraseFn = ((_1503_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1506_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1507_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1502_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1503_recOwned;
                        isErased = false;
                        readIdents = _1505_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out951;
                        bool _out952;
                        bool _out953;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out954;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1501_b), _1501_b, _486_toTpe), selfIdent, @params, mustOwn, out _out951, out _out952, out _out953, out _out954);
                        s = _out951;
                        isOwned = _out952;
                        isErased = _out953;
                        readIdents = _out954;
                      }
                    }
                  }
                } else if (_source55.is_Nullable) {
                  DAST._IType _1508___mcc_h812 = _source55.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1509_recursiveGen;
                    bool _1510_recOwned;
                    bool _1511_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1512_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out955;
                    bool _out956;
                    bool _out957;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out958;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out955, out _out956, out _out957, out _out958);
                    _1509_recursiveGen = _out955;
                    _1510_recOwned = _out956;
                    _1511_recErased = _out957;
                    _1512_recIdents = _out958;
                    if (!(_1510_recOwned)) {
                      _1509_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1509_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1509_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1511_recErased;
                    readIdents = _1512_recIdents;
                  }
                } else if (_source55.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1513___mcc_h814 = _source55.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1514_recursiveGen;
                    bool _1515_recOwned;
                    bool _1516_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1517_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out959;
                    bool _out960;
                    bool _out961;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out962;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out959, out _out960, out _out961, out _out962);
                    _1514_recursiveGen = _out959;
                    _1515_recOwned = _out960;
                    _1516_recErased = _out961;
                    _1517_recIdents = _out962;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1514_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1515_recOwned;
                    isErased = _1516_recErased;
                    readIdents = _1517_recIdents;
                  }
                } else if (_source55.is_Array) {
                  DAST._IType _1518___mcc_h816 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1519_recursiveGen;
                    bool _1520_recOwned;
                    bool _1521_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1522_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out963;
                    bool _out964;
                    bool _out965;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out966;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out963, out _out964, out _out965, out _out966);
                    _1519_recursiveGen = _out963;
                    _1520_recOwned = _out964;
                    _1521_recErased = _out965;
                    _1522_recIdents = _out966;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1519_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1520_recOwned;
                    isErased = _1521_recErased;
                    readIdents = _1522_recIdents;
                  }
                } else if (_source55.is_Seq) {
                  DAST._IType _1523___mcc_h818 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1524_recursiveGen;
                    bool _1525_recOwned;
                    bool _1526_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1527_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out967;
                    bool _out968;
                    bool _out969;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out970;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out967, out _out968, out _out969, out _out970);
                    _1524_recursiveGen = _out967;
                    _1525_recOwned = _out968;
                    _1526_recErased = _out969;
                    _1527_recIdents = _out970;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1524_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1525_recOwned;
                    isErased = _1526_recErased;
                    readIdents = _1527_recIdents;
                  }
                } else if (_source55.is_Set) {
                  DAST._IType _1528___mcc_h820 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1529_recursiveGen;
                    bool _1530_recOwned;
                    bool _1531_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1532_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out971;
                    bool _out972;
                    bool _out973;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out974;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out971, out _out972, out _out973, out _out974);
                    _1529_recursiveGen = _out971;
                    _1530_recOwned = _out972;
                    _1531_recErased = _out973;
                    _1532_recIdents = _out974;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1529_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1530_recOwned;
                    isErased = _1531_recErased;
                    readIdents = _1532_recIdents;
                  }
                } else if (_source55.is_Multiset) {
                  DAST._IType _1533___mcc_h822 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1534_recursiveGen;
                    bool _1535_recOwned;
                    bool _1536_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1537_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out975;
                    bool _out976;
                    bool _out977;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out978;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out975, out _out976, out _out977, out _out978);
                    _1534_recursiveGen = _out975;
                    _1535_recOwned = _out976;
                    _1536_recErased = _out977;
                    _1537_recIdents = _out978;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1535_recOwned;
                    isErased = _1536_recErased;
                    readIdents = _1537_recIdents;
                  }
                } else if (_source55.is_Map) {
                  DAST._IType _1538___mcc_h824 = _source55.dtor_key;
                  DAST._IType _1539___mcc_h825 = _source55.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1540_recursiveGen;
                    bool _1541_recOwned;
                    bool _1542_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1543_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out979;
                    bool _out980;
                    bool _out981;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out982;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out979, out _out980, out _out981, out _out982);
                    _1540_recursiveGen = _out979;
                    _1541_recOwned = _out980;
                    _1542_recErased = _out981;
                    _1543_recIdents = _out982;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1540_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1541_recOwned;
                    isErased = _1542_recErased;
                    readIdents = _1543_recIdents;
                  }
                } else if (_source55.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1544___mcc_h828 = _source55.dtor_args;
                  DAST._IType _1545___mcc_h829 = _source55.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1546_recursiveGen;
                    bool _1547_recOwned;
                    bool _1548_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1549_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out983;
                    bool _out984;
                    bool _out985;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out986;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out983, out _out984, out _out985, out _out986);
                    _1546_recursiveGen = _out983;
                    _1547_recOwned = _out984;
                    _1548_recErased = _out985;
                    _1549_recIdents = _out986;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1547_recOwned;
                    isErased = _1548_recErased;
                    readIdents = _1549_recIdents;
                  }
                } else if (_source55.is_Primitive) {
                  DAST._IPrimitive _1550___mcc_h832 = _source55.dtor_Primitive_a0;
                  DAST._IPrimitive _source57 = _1550___mcc_h832;
                  if (_source57.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1551_recursiveGen;
                      bool _1552___v45;
                      bool _1553___v46;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1554_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out987;
                      bool _out988;
                      bool _out989;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out990;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, false, out _out987, out _out988, out _out989, out _out990);
                      _1551_recursiveGen = _out987;
                      _1552___v45 = _out988;
                      _1553___v46 = _out989;
                      _1554_recIdents = _out990;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1551_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1554_recIdents;
                    }
                  } else if (_source57.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1555_recursiveGen;
                      bool _1556_recOwned;
                      bool _1557_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1558_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out991;
                      bool _out992;
                      bool _out993;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out994;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out991, out _out992, out _out993, out _out994);
                      _1555_recursiveGen = _out991;
                      _1556_recOwned = _out992;
                      _1557_recErased = _out993;
                      _1558_recIdents = _out994;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1555_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1556_recOwned;
                      isErased = _1557_recErased;
                      readIdents = _1558_recIdents;
                    }
                  } else if (_source57.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1559_recursiveGen;
                      bool _1560_recOwned;
                      bool _1561_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1562_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out995;
                      bool _out996;
                      bool _out997;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out998;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out995, out _out996, out _out997, out _out998);
                      _1559_recursiveGen = _out995;
                      _1560_recOwned = _out996;
                      _1561_recErased = _out997;
                      _1562_recIdents = _out998;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1559_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1560_recOwned;
                      isErased = _1561_recErased;
                      readIdents = _1562_recIdents;
                    }
                  } else if (_source57.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1563_recursiveGen;
                      bool _1564_recOwned;
                      bool _1565_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1566_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out999;
                      bool _out1000;
                      bool _out1001;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1002;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out999, out _out1000, out _out1001, out _out1002);
                      _1563_recursiveGen = _out999;
                      _1564_recOwned = _out1000;
                      _1565_recErased = _out1001;
                      _1566_recIdents = _out1002;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1563_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1564_recOwned;
                      isErased = _1565_recErased;
                      readIdents = _1566_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1567_recursiveGen;
                      bool _1568_recOwned;
                      bool _1569_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1570_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1003;
                      bool _out1004;
                      bool _out1005;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1006;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1003, out _out1004, out _out1005, out _out1006);
                      _1567_recursiveGen = _out1003;
                      _1568_recOwned = _out1004;
                      _1569_recErased = _out1005;
                      _1570_recIdents = _out1006;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1567_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1568_recOwned;
                      isErased = _1569_recErased;
                      readIdents = _1570_recIdents;
                    }
                  }
                } else if (_source55.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1571___mcc_h834 = _source55.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1572_recursiveGen;
                    bool _1573_recOwned;
                    bool _1574_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1575_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1007;
                    bool _out1008;
                    bool _out1009;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1010;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1007, out _out1008, out _out1009, out _out1010);
                    _1572_recursiveGen = _out1007;
                    _1573_recOwned = _out1008;
                    _1574_recErased = _out1009;
                    _1575_recIdents = _out1010;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1572_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1573_recOwned;
                    isErased = _1574_recErased;
                    readIdents = _1575_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1576___mcc_h836 = _source55.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1577_recursiveGen;
                    bool _1578_recOwned;
                    bool _1579_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1580_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1011;
                    bool _out1012;
                    bool _out1013;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1014;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1011, out _out1012, out _out1013, out _out1014);
                    _1577_recursiveGen = _out1011;
                    _1578_recOwned = _out1012;
                    _1579_recErased = _out1013;
                    _1580_recIdents = _out1014;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1577_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1578_recOwned;
                    isErased = _1579_recErased;
                    readIdents = _1580_recIdents;
                  }
                }
              } else if (_source51.is_String) {
                DAST._IType _source58 = _494___mcc_h235;
                if (_source58.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1581___mcc_h838 = _source58.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1582___mcc_h839 = _source58.dtor_typeArgs;
                  DAST._IResolvedType _1583___mcc_h840 = _source58.dtor_resolved;
                  DAST._IResolvedType _source59 = _1583___mcc_h840;
                  if (_source59.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1584___mcc_h844 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1585_recursiveGen;
                      bool _1586_recOwned;
                      bool _1587_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1588_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1015;
                      bool _out1016;
                      bool _out1017;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1018;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1015, out _out1016, out _out1017, out _out1018);
                      _1585_recursiveGen = _out1015;
                      _1586_recOwned = _out1016;
                      _1587_recErased = _out1017;
                      _1588_recIdents = _out1018;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1585_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1586_recOwned;
                      isErased = _1587_recErased;
                      readIdents = _1588_recIdents;
                    }
                  } else if (_source59.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1589___mcc_h846 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1590_recursiveGen;
                      bool _1591_recOwned;
                      bool _1592_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1593_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1019;
                      bool _out1020;
                      bool _out1021;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1022;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1019, out _out1020, out _out1021, out _out1022);
                      _1590_recursiveGen = _out1019;
                      _1591_recOwned = _out1020;
                      _1592_recErased = _out1021;
                      _1593_recIdents = _out1022;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1590_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1591_recOwned;
                      isErased = _1592_recErased;
                      readIdents = _1593_recIdents;
                    }
                  } else {
                    DAST._IType _1594___mcc_h848 = _source59.dtor_Newtype_a0;
                    DAST._IType _1595_b = _1594___mcc_h848;
                    {
                      if (object.Equals(_487_fromTpe, _1595_b)) {
                        Dafny.ISequence<Dafny.Rune> _1596_recursiveGen;
                        bool _1597_recOwned;
                        bool _1598_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1599_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1023;
                        bool _out1024;
                        bool _out1025;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1026;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1023, out _out1024, out _out1025, out _out1026);
                        _1596_recursiveGen = _out1023;
                        _1597_recOwned = _out1024;
                        _1598_recErased = _out1025;
                        _1599_recIdents = _out1026;
                        Dafny.ISequence<Dafny.Rune> _1600_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1027;
                        _out1027 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                        _1600_rhsType = _out1027;
                        Dafny.ISequence<Dafny.Rune> _1601_uneraseFn;
                        _1601_uneraseFn = ((_1597_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1600_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1601_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1596_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1597_recOwned;
                        isErased = false;
                        readIdents = _1599_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1028;
                        bool _out1029;
                        bool _out1030;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1031;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1595_b), _1595_b, _486_toTpe), selfIdent, @params, mustOwn, out _out1028, out _out1029, out _out1030, out _out1031);
                        s = _out1028;
                        isOwned = _out1029;
                        isErased = _out1030;
                        readIdents = _out1031;
                      }
                    }
                  }
                } else if (_source58.is_Nullable) {
                  DAST._IType _1602___mcc_h850 = _source58.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1603_recursiveGen;
                    bool _1604_recOwned;
                    bool _1605_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1606_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1032;
                    bool _out1033;
                    bool _out1034;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1035;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1032, out _out1033, out _out1034, out _out1035);
                    _1603_recursiveGen = _out1032;
                    _1604_recOwned = _out1033;
                    _1605_recErased = _out1034;
                    _1606_recIdents = _out1035;
                    if (!(_1604_recOwned)) {
                      _1603_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1603_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1603_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1605_recErased;
                    readIdents = _1606_recIdents;
                  }
                } else if (_source58.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1607___mcc_h852 = _source58.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1608_recursiveGen;
                    bool _1609_recOwned;
                    bool _1610_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1611_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1036;
                    bool _out1037;
                    bool _out1038;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1039;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1036, out _out1037, out _out1038, out _out1039);
                    _1608_recursiveGen = _out1036;
                    _1609_recOwned = _out1037;
                    _1610_recErased = _out1038;
                    _1611_recIdents = _out1039;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1608_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1609_recOwned;
                    isErased = _1610_recErased;
                    readIdents = _1611_recIdents;
                  }
                } else if (_source58.is_Array) {
                  DAST._IType _1612___mcc_h854 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1613_recursiveGen;
                    bool _1614_recOwned;
                    bool _1615_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1616_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1040;
                    bool _out1041;
                    bool _out1042;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1043;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1040, out _out1041, out _out1042, out _out1043);
                    _1613_recursiveGen = _out1040;
                    _1614_recOwned = _out1041;
                    _1615_recErased = _out1042;
                    _1616_recIdents = _out1043;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1614_recOwned;
                    isErased = _1615_recErased;
                    readIdents = _1616_recIdents;
                  }
                } else if (_source58.is_Seq) {
                  DAST._IType _1617___mcc_h856 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1618_recursiveGen;
                    bool _1619_recOwned;
                    bool _1620_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1621_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1044;
                    bool _out1045;
                    bool _out1046;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1047;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1044, out _out1045, out _out1046, out _out1047);
                    _1618_recursiveGen = _out1044;
                    _1619_recOwned = _out1045;
                    _1620_recErased = _out1046;
                    _1621_recIdents = _out1047;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1618_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1619_recOwned;
                    isErased = _1620_recErased;
                    readIdents = _1621_recIdents;
                  }
                } else if (_source58.is_Set) {
                  DAST._IType _1622___mcc_h858 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1623_recursiveGen;
                    bool _1624_recOwned;
                    bool _1625_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1626_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1048;
                    bool _out1049;
                    bool _out1050;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1051;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1048, out _out1049, out _out1050, out _out1051);
                    _1623_recursiveGen = _out1048;
                    _1624_recOwned = _out1049;
                    _1625_recErased = _out1050;
                    _1626_recIdents = _out1051;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1623_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1624_recOwned;
                    isErased = _1625_recErased;
                    readIdents = _1626_recIdents;
                  }
                } else if (_source58.is_Multiset) {
                  DAST._IType _1627___mcc_h860 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1628_recursiveGen;
                    bool _1629_recOwned;
                    bool _1630_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1631_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1052;
                    bool _out1053;
                    bool _out1054;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1055;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1052, out _out1053, out _out1054, out _out1055);
                    _1628_recursiveGen = _out1052;
                    _1629_recOwned = _out1053;
                    _1630_recErased = _out1054;
                    _1631_recIdents = _out1055;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1628_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1629_recOwned;
                    isErased = _1630_recErased;
                    readIdents = _1631_recIdents;
                  }
                } else if (_source58.is_Map) {
                  DAST._IType _1632___mcc_h862 = _source58.dtor_key;
                  DAST._IType _1633___mcc_h863 = _source58.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1634_recursiveGen;
                    bool _1635_recOwned;
                    bool _1636_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1637_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1056;
                    bool _out1057;
                    bool _out1058;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1059;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1056, out _out1057, out _out1058, out _out1059);
                    _1634_recursiveGen = _out1056;
                    _1635_recOwned = _out1057;
                    _1636_recErased = _out1058;
                    _1637_recIdents = _out1059;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1634_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1635_recOwned;
                    isErased = _1636_recErased;
                    readIdents = _1637_recIdents;
                  }
                } else if (_source58.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1638___mcc_h866 = _source58.dtor_args;
                  DAST._IType _1639___mcc_h867 = _source58.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1640_recursiveGen;
                    bool _1641_recOwned;
                    bool _1642_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1643_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1060;
                    bool _out1061;
                    bool _out1062;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1063;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1060, out _out1061, out _out1062, out _out1063);
                    _1640_recursiveGen = _out1060;
                    _1641_recOwned = _out1061;
                    _1642_recErased = _out1062;
                    _1643_recIdents = _out1063;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1641_recOwned;
                    isErased = _1642_recErased;
                    readIdents = _1643_recIdents;
                  }
                } else if (_source58.is_Primitive) {
                  DAST._IPrimitive _1644___mcc_h870 = _source58.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1645_recursiveGen;
                    bool _1646_recOwned;
                    bool _1647_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1648_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1064;
                    bool _out1065;
                    bool _out1066;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1067;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1064, out _out1065, out _out1066, out _out1067);
                    _1645_recursiveGen = _out1064;
                    _1646_recOwned = _out1065;
                    _1647_recErased = _out1066;
                    _1648_recIdents = _out1067;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1646_recOwned;
                    isErased = _1647_recErased;
                    readIdents = _1648_recIdents;
                  }
                } else if (_source58.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1649___mcc_h872 = _source58.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1650_recursiveGen;
                    bool _1651_recOwned;
                    bool _1652_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1653_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1068;
                    bool _out1069;
                    bool _out1070;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1068, out _out1069, out _out1070, out _out1071);
                    _1650_recursiveGen = _out1068;
                    _1651_recOwned = _out1069;
                    _1652_recErased = _out1070;
                    _1653_recIdents = _out1071;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1650_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1651_recOwned;
                    isErased = _1652_recErased;
                    readIdents = _1653_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1654___mcc_h874 = _source58.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1655_recursiveGen;
                    bool _1656_recOwned;
                    bool _1657_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1658_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1072;
                    bool _out1073;
                    bool _out1074;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                    _1655_recursiveGen = _out1072;
                    _1656_recOwned = _out1073;
                    _1657_recErased = _out1074;
                    _1658_recIdents = _out1075;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1655_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1656_recOwned;
                    isErased = _1657_recErased;
                    readIdents = _1658_recIdents;
                  }
                }
              } else if (_source51.is_Bool) {
                DAST._IType _source60 = _494___mcc_h235;
                if (_source60.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1659___mcc_h876 = _source60.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1660___mcc_h877 = _source60.dtor_typeArgs;
                  DAST._IResolvedType _1661___mcc_h878 = _source60.dtor_resolved;
                  DAST._IResolvedType _source61 = _1661___mcc_h878;
                  if (_source61.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1662___mcc_h882 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1663_recursiveGen;
                      bool _1664_recOwned;
                      bool _1665_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1666_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1076;
                      bool _out1077;
                      bool _out1078;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                      _1663_recursiveGen = _out1076;
                      _1664_recOwned = _out1077;
                      _1665_recErased = _out1078;
                      _1666_recIdents = _out1079;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1663_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1664_recOwned;
                      isErased = _1665_recErased;
                      readIdents = _1666_recIdents;
                    }
                  } else if (_source61.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1667___mcc_h884 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1668_recursiveGen;
                      bool _1669_recOwned;
                      bool _1670_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1671_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1080;
                      bool _out1081;
                      bool _out1082;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                      _1668_recursiveGen = _out1080;
                      _1669_recOwned = _out1081;
                      _1670_recErased = _out1082;
                      _1671_recIdents = _out1083;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1668_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1669_recOwned;
                      isErased = _1670_recErased;
                      readIdents = _1671_recIdents;
                    }
                  } else {
                    DAST._IType _1672___mcc_h886 = _source61.dtor_Newtype_a0;
                    DAST._IType _1673_b = _1672___mcc_h886;
                    {
                      if (object.Equals(_487_fromTpe, _1673_b)) {
                        Dafny.ISequence<Dafny.Rune> _1674_recursiveGen;
                        bool _1675_recOwned;
                        bool _1676_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1677_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1084;
                        bool _out1085;
                        bool _out1086;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                        _1674_recursiveGen = _out1084;
                        _1675_recOwned = _out1085;
                        _1676_recErased = _out1086;
                        _1677_recIdents = _out1087;
                        Dafny.ISequence<Dafny.Rune> _1678_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1088;
                        _out1088 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                        _1678_rhsType = _out1088;
                        Dafny.ISequence<Dafny.Rune> _1679_uneraseFn;
                        _1679_uneraseFn = ((_1675_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1678_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1679_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1674_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1675_recOwned;
                        isErased = false;
                        readIdents = _1677_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1089;
                        bool _out1090;
                        bool _out1091;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1092;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1673_b), _1673_b, _486_toTpe), selfIdent, @params, mustOwn, out _out1089, out _out1090, out _out1091, out _out1092);
                        s = _out1089;
                        isOwned = _out1090;
                        isErased = _out1091;
                        readIdents = _out1092;
                      }
                    }
                  }
                } else if (_source60.is_Nullable) {
                  DAST._IType _1680___mcc_h888 = _source60.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1681_recursiveGen;
                    bool _1682_recOwned;
                    bool _1683_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1684_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1093;
                    bool _out1094;
                    bool _out1095;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1096;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1093, out _out1094, out _out1095, out _out1096);
                    _1681_recursiveGen = _out1093;
                    _1682_recOwned = _out1094;
                    _1683_recErased = _out1095;
                    _1684_recIdents = _out1096;
                    if (!(_1682_recOwned)) {
                      _1681_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1681_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1681_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1683_recErased;
                    readIdents = _1684_recIdents;
                  }
                } else if (_source60.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1685___mcc_h890 = _source60.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1686_recursiveGen;
                    bool _1687_recOwned;
                    bool _1688_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1689_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1097;
                    bool _out1098;
                    bool _out1099;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1100;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1097, out _out1098, out _out1099, out _out1100);
                    _1686_recursiveGen = _out1097;
                    _1687_recOwned = _out1098;
                    _1688_recErased = _out1099;
                    _1689_recIdents = _out1100;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1686_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1687_recOwned;
                    isErased = _1688_recErased;
                    readIdents = _1689_recIdents;
                  }
                } else if (_source60.is_Array) {
                  DAST._IType _1690___mcc_h892 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1691_recursiveGen;
                    bool _1692_recOwned;
                    bool _1693_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1694_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1101;
                    bool _out1102;
                    bool _out1103;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1104;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1101, out _out1102, out _out1103, out _out1104);
                    _1691_recursiveGen = _out1101;
                    _1692_recOwned = _out1102;
                    _1693_recErased = _out1103;
                    _1694_recIdents = _out1104;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1691_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1692_recOwned;
                    isErased = _1693_recErased;
                    readIdents = _1694_recIdents;
                  }
                } else if (_source60.is_Seq) {
                  DAST._IType _1695___mcc_h894 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1696_recursiveGen;
                    bool _1697_recOwned;
                    bool _1698_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1699_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1105;
                    bool _out1106;
                    bool _out1107;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1108;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1105, out _out1106, out _out1107, out _out1108);
                    _1696_recursiveGen = _out1105;
                    _1697_recOwned = _out1106;
                    _1698_recErased = _out1107;
                    _1699_recIdents = _out1108;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1696_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1697_recOwned;
                    isErased = _1698_recErased;
                    readIdents = _1699_recIdents;
                  }
                } else if (_source60.is_Set) {
                  DAST._IType _1700___mcc_h896 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1701_recursiveGen;
                    bool _1702_recOwned;
                    bool _1703_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1704_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1109;
                    bool _out1110;
                    bool _out1111;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                    _1701_recursiveGen = _out1109;
                    _1702_recOwned = _out1110;
                    _1703_recErased = _out1111;
                    _1704_recIdents = _out1112;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1701_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1702_recOwned;
                    isErased = _1703_recErased;
                    readIdents = _1704_recIdents;
                  }
                } else if (_source60.is_Multiset) {
                  DAST._IType _1705___mcc_h898 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1706_recursiveGen;
                    bool _1707_recOwned;
                    bool _1708_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1709_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1113;
                    bool _out1114;
                    bool _out1115;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                    _1706_recursiveGen = _out1113;
                    _1707_recOwned = _out1114;
                    _1708_recErased = _out1115;
                    _1709_recIdents = _out1116;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1706_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1707_recOwned;
                    isErased = _1708_recErased;
                    readIdents = _1709_recIdents;
                  }
                } else if (_source60.is_Map) {
                  DAST._IType _1710___mcc_h900 = _source60.dtor_key;
                  DAST._IType _1711___mcc_h901 = _source60.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1712_recursiveGen;
                    bool _1713_recOwned;
                    bool _1714_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1715_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1117;
                    bool _out1118;
                    bool _out1119;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                    _1712_recursiveGen = _out1117;
                    _1713_recOwned = _out1118;
                    _1714_recErased = _out1119;
                    _1715_recIdents = _out1120;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1712_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1713_recOwned;
                    isErased = _1714_recErased;
                    readIdents = _1715_recIdents;
                  }
                } else if (_source60.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1716___mcc_h904 = _source60.dtor_args;
                  DAST._IType _1717___mcc_h905 = _source60.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1718_recursiveGen;
                    bool _1719_recOwned;
                    bool _1720_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1721_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1121;
                    bool _out1122;
                    bool _out1123;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                    _1718_recursiveGen = _out1121;
                    _1719_recOwned = _out1122;
                    _1720_recErased = _out1123;
                    _1721_recIdents = _out1124;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1718_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1719_recOwned;
                    isErased = _1720_recErased;
                    readIdents = _1721_recIdents;
                  }
                } else if (_source60.is_Primitive) {
                  DAST._IPrimitive _1722___mcc_h908 = _source60.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1723_recursiveGen;
                    bool _1724_recOwned;
                    bool _1725_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1726_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1125;
                    bool _out1126;
                    bool _out1127;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                    _1723_recursiveGen = _out1125;
                    _1724_recOwned = _out1126;
                    _1725_recErased = _out1127;
                    _1726_recIdents = _out1128;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1723_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1724_recOwned;
                    isErased = _1725_recErased;
                    readIdents = _1726_recIdents;
                  }
                } else if (_source60.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1727___mcc_h910 = _source60.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1728_recursiveGen;
                    bool _1729_recOwned;
                    bool _1730_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1731_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1129;
                    bool _out1130;
                    bool _out1131;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                    _1728_recursiveGen = _out1129;
                    _1729_recOwned = _out1130;
                    _1730_recErased = _out1131;
                    _1731_recIdents = _out1132;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1728_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1729_recOwned;
                    isErased = _1730_recErased;
                    readIdents = _1731_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1732___mcc_h912 = _source60.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1733_recursiveGen;
                    bool _1734_recOwned;
                    bool _1735_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1736_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1133;
                    bool _out1134;
                    bool _out1135;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                    _1733_recursiveGen = _out1133;
                    _1734_recOwned = _out1134;
                    _1735_recErased = _out1135;
                    _1736_recIdents = _out1136;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1733_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1734_recOwned;
                    isErased = _1735_recErased;
                    readIdents = _1736_recIdents;
                  }
                }
              } else {
                DAST._IType _source62 = _494___mcc_h235;
                if (_source62.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1737___mcc_h914 = _source62.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1738___mcc_h915 = _source62.dtor_typeArgs;
                  DAST._IResolvedType _1739___mcc_h916 = _source62.dtor_resolved;
                  DAST._IResolvedType _source63 = _1739___mcc_h916;
                  if (_source63.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1740___mcc_h920 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1741_recursiveGen;
                      bool _1742_recOwned;
                      bool _1743_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1744_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1137;
                      bool _out1138;
                      bool _out1139;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                      _1741_recursiveGen = _out1137;
                      _1742_recOwned = _out1138;
                      _1743_recErased = _out1139;
                      _1744_recIdents = _out1140;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1741_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1742_recOwned;
                      isErased = _1743_recErased;
                      readIdents = _1744_recIdents;
                    }
                  } else if (_source63.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1745___mcc_h922 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1746_recursiveGen;
                      bool _1747_recOwned;
                      bool _1748_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1749_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1141;
                      bool _out1142;
                      bool _out1143;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1144;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1141, out _out1142, out _out1143, out _out1144);
                      _1746_recursiveGen = _out1141;
                      _1747_recOwned = _out1142;
                      _1748_recErased = _out1143;
                      _1749_recIdents = _out1144;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1746_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1747_recOwned;
                      isErased = _1748_recErased;
                      readIdents = _1749_recIdents;
                    }
                  } else {
                    DAST._IType _1750___mcc_h924 = _source63.dtor_Newtype_a0;
                    DAST._IType _1751_b = _1750___mcc_h924;
                    {
                      if (object.Equals(_487_fromTpe, _1751_b)) {
                        Dafny.ISequence<Dafny.Rune> _1752_recursiveGen;
                        bool _1753_recOwned;
                        bool _1754_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1755_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1145;
                        bool _out1146;
                        bool _out1147;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1148;
                        DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1145, out _out1146, out _out1147, out _out1148);
                        _1752_recursiveGen = _out1145;
                        _1753_recOwned = _out1146;
                        _1754_recErased = _out1147;
                        _1755_recIdents = _out1148;
                        Dafny.ISequence<Dafny.Rune> _1756_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1149;
                        _out1149 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                        _1756_rhsType = _out1149;
                        Dafny.ISequence<Dafny.Rune> _1757_uneraseFn;
                        _1757_uneraseFn = ((_1753_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1756_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1757_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1752_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1753_recOwned;
                        isErased = false;
                        readIdents = _1755_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1150;
                        bool _out1151;
                        bool _out1152;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1153;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1751_b), _1751_b, _486_toTpe), selfIdent, @params, mustOwn, out _out1150, out _out1151, out _out1152, out _out1153);
                        s = _out1150;
                        isOwned = _out1151;
                        isErased = _out1152;
                        readIdents = _out1153;
                      }
                    }
                  }
                } else if (_source62.is_Nullable) {
                  DAST._IType _1758___mcc_h926 = _source62.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1759_recursiveGen;
                    bool _1760_recOwned;
                    bool _1761_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1762_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1154;
                    bool _out1155;
                    bool _out1156;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1157;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1154, out _out1155, out _out1156, out _out1157);
                    _1759_recursiveGen = _out1154;
                    _1760_recOwned = _out1155;
                    _1761_recErased = _out1156;
                    _1762_recIdents = _out1157;
                    if (!(_1760_recOwned)) {
                      _1759_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1759_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1761_recErased;
                    readIdents = _1762_recIdents;
                  }
                } else if (_source62.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1763___mcc_h928 = _source62.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1764_recursiveGen;
                    bool _1765_recOwned;
                    bool _1766_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1767_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1158;
                    bool _out1159;
                    bool _out1160;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                    _1764_recursiveGen = _out1158;
                    _1765_recOwned = _out1159;
                    _1766_recErased = _out1160;
                    _1767_recIdents = _out1161;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1764_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1765_recOwned;
                    isErased = _1766_recErased;
                    readIdents = _1767_recIdents;
                  }
                } else if (_source62.is_Array) {
                  DAST._IType _1768___mcc_h930 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1769_recursiveGen;
                    bool _1770_recOwned;
                    bool _1771_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1772_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1162;
                    bool _out1163;
                    bool _out1164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                    _1769_recursiveGen = _out1162;
                    _1770_recOwned = _out1163;
                    _1771_recErased = _out1164;
                    _1772_recIdents = _out1165;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1769_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1770_recOwned;
                    isErased = _1771_recErased;
                    readIdents = _1772_recIdents;
                  }
                } else if (_source62.is_Seq) {
                  DAST._IType _1773___mcc_h932 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1774_recursiveGen;
                    bool _1775_recOwned;
                    bool _1776_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1777_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1166;
                    bool _out1167;
                    bool _out1168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1169;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1166, out _out1167, out _out1168, out _out1169);
                    _1774_recursiveGen = _out1166;
                    _1775_recOwned = _out1167;
                    _1776_recErased = _out1168;
                    _1777_recIdents = _out1169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1774_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1775_recOwned;
                    isErased = _1776_recErased;
                    readIdents = _1777_recIdents;
                  }
                } else if (_source62.is_Set) {
                  DAST._IType _1778___mcc_h934 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1779_recursiveGen;
                    bool _1780_recOwned;
                    bool _1781_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1782_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1170;
                    bool _out1171;
                    bool _out1172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1173;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1170, out _out1171, out _out1172, out _out1173);
                    _1779_recursiveGen = _out1170;
                    _1780_recOwned = _out1171;
                    _1781_recErased = _out1172;
                    _1782_recIdents = _out1173;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1779_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1780_recOwned;
                    isErased = _1781_recErased;
                    readIdents = _1782_recIdents;
                  }
                } else if (_source62.is_Multiset) {
                  DAST._IType _1783___mcc_h936 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1784_recursiveGen;
                    bool _1785_recOwned;
                    bool _1786_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1787_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1174;
                    bool _out1175;
                    bool _out1176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1177;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1174, out _out1175, out _out1176, out _out1177);
                    _1784_recursiveGen = _out1174;
                    _1785_recOwned = _out1175;
                    _1786_recErased = _out1176;
                    _1787_recIdents = _out1177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1784_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1785_recOwned;
                    isErased = _1786_recErased;
                    readIdents = _1787_recIdents;
                  }
                } else if (_source62.is_Map) {
                  DAST._IType _1788___mcc_h938 = _source62.dtor_key;
                  DAST._IType _1789___mcc_h939 = _source62.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1790_recursiveGen;
                    bool _1791_recOwned;
                    bool _1792_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1793_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1178;
                    bool _out1179;
                    bool _out1180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1181;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1178, out _out1179, out _out1180, out _out1181);
                    _1790_recursiveGen = _out1178;
                    _1791_recOwned = _out1179;
                    _1792_recErased = _out1180;
                    _1793_recIdents = _out1181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1790_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1791_recOwned;
                    isErased = _1792_recErased;
                    readIdents = _1793_recIdents;
                  }
                } else if (_source62.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1794___mcc_h942 = _source62.dtor_args;
                  DAST._IType _1795___mcc_h943 = _source62.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1796_recursiveGen;
                    bool _1797_recOwned;
                    bool _1798_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1799_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1182;
                    bool _out1183;
                    bool _out1184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1185;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1182, out _out1183, out _out1184, out _out1185);
                    _1796_recursiveGen = _out1182;
                    _1797_recOwned = _out1183;
                    _1798_recErased = _out1184;
                    _1799_recIdents = _out1185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1796_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1797_recOwned;
                    isErased = _1798_recErased;
                    readIdents = _1799_recIdents;
                  }
                } else if (_source62.is_Primitive) {
                  DAST._IPrimitive _1800___mcc_h946 = _source62.dtor_Primitive_a0;
                  DAST._IPrimitive _source64 = _1800___mcc_h946;
                  if (_source64.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1801_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1186;
                      _out1186 = DCOMP.COMP.GenType(_487_fromTpe, true, false);
                      _1801_rhsType = _out1186;
                      Dafny.ISequence<Dafny.Rune> _1802_recursiveGen;
                      bool _1803___v55;
                      bool _1804___v56;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1805_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1187;
                      bool _out1188;
                      bool _out1189;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1190;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, true, out _out1187, out _out1188, out _out1189, out _out1190);
                      _1802_recursiveGen = _out1187;
                      _1803___v55 = _out1188;
                      _1804___v56 = _out1189;
                      _1805_recIdents = _out1190;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1802_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1805_recIdents;
                    }
                  } else if (_source64.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1806_recursiveGen;
                      bool _1807_recOwned;
                      bool _1808_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1809_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1191;
                      bool _out1192;
                      bool _out1193;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1194;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1191, out _out1192, out _out1193, out _out1194);
                      _1806_recursiveGen = _out1191;
                      _1807_recOwned = _out1192;
                      _1808_recErased = _out1193;
                      _1809_recIdents = _out1194;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1806_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1807_recOwned;
                      isErased = _1808_recErased;
                      readIdents = _1809_recIdents;
                    }
                  } else if (_source64.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1810_recursiveGen;
                      bool _1811_recOwned;
                      bool _1812_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1813_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1195;
                      bool _out1196;
                      bool _out1197;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1198;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1195, out _out1196, out _out1197, out _out1198);
                      _1810_recursiveGen = _out1195;
                      _1811_recOwned = _out1196;
                      _1812_recErased = _out1197;
                      _1813_recIdents = _out1198;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1810_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1811_recOwned;
                      isErased = _1812_recErased;
                      readIdents = _1813_recIdents;
                    }
                  } else if (_source64.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1814_recursiveGen;
                      bool _1815_recOwned;
                      bool _1816_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1817_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1199;
                      bool _out1200;
                      bool _out1201;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1202;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1199, out _out1200, out _out1201, out _out1202);
                      _1814_recursiveGen = _out1199;
                      _1815_recOwned = _out1200;
                      _1816_recErased = _out1201;
                      _1817_recIdents = _out1202;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1814_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1815_recOwned;
                      isErased = _1816_recErased;
                      readIdents = _1817_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1818_recursiveGen;
                      bool _1819_recOwned;
                      bool _1820_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1821_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      bool _out1204;
                      bool _out1205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1206;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1203, out _out1204, out _out1205, out _out1206);
                      _1818_recursiveGen = _out1203;
                      _1819_recOwned = _out1204;
                      _1820_recErased = _out1205;
                      _1821_recIdents = _out1206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1818_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1819_recOwned;
                      isErased = _1820_recErased;
                      readIdents = _1821_recIdents;
                    }
                  }
                } else if (_source62.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1822___mcc_h948 = _source62.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1823_recursiveGen;
                    bool _1824_recOwned;
                    bool _1825_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1826_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1207;
                    bool _out1208;
                    bool _out1209;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1210;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1207, out _out1208, out _out1209, out _out1210);
                    _1823_recursiveGen = _out1207;
                    _1824_recOwned = _out1208;
                    _1825_recErased = _out1209;
                    _1826_recIdents = _out1210;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1823_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1824_recOwned;
                    isErased = _1825_recErased;
                    readIdents = _1826_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1827___mcc_h950 = _source62.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1828_recursiveGen;
                    bool _1829_recOwned;
                    bool _1830_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1831_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1211;
                    bool _out1212;
                    bool _out1213;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1214;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1211, out _out1212, out _out1213, out _out1214);
                    _1828_recursiveGen = _out1211;
                    _1829_recOwned = _out1212;
                    _1830_recErased = _out1213;
                    _1831_recIdents = _out1214;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1828_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1829_recOwned;
                    isErased = _1830_recErased;
                    readIdents = _1831_recIdents;
                  }
                }
              }
            } else if (_source27.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1832___mcc_h952 = _source27.dtor_Passthrough_a0;
              DAST._IType _source65 = _494___mcc_h235;
              if (_source65.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1833___mcc_h956 = _source65.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1834___mcc_h957 = _source65.dtor_typeArgs;
                DAST._IResolvedType _1835___mcc_h958 = _source65.dtor_resolved;
                DAST._IResolvedType _source66 = _1835___mcc_h958;
                if (_source66.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1836___mcc_h962 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1837_recursiveGen;
                    bool _1838_recOwned;
                    bool _1839_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1840_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1215;
                    bool _out1216;
                    bool _out1217;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1218;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1215, out _out1216, out _out1217, out _out1218);
                    _1837_recursiveGen = _out1215;
                    _1838_recOwned = _out1216;
                    _1839_recErased = _out1217;
                    _1840_recIdents = _out1218;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1837_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1838_recOwned;
                    isErased = _1839_recErased;
                    readIdents = _1840_recIdents;
                  }
                } else if (_source66.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1841___mcc_h964 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1842_recursiveGen;
                    bool _1843_recOwned;
                    bool _1844_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1845_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1219;
                    bool _out1220;
                    bool _out1221;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1222;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1219, out _out1220, out _out1221, out _out1222);
                    _1842_recursiveGen = _out1219;
                    _1843_recOwned = _out1220;
                    _1844_recErased = _out1221;
                    _1845_recIdents = _out1222;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1842_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1843_recOwned;
                    isErased = _1844_recErased;
                    readIdents = _1845_recIdents;
                  }
                } else {
                  DAST._IType _1846___mcc_h966 = _source66.dtor_Newtype_a0;
                  DAST._IType _1847_b = _1846___mcc_h966;
                  {
                    if (object.Equals(_487_fromTpe, _1847_b)) {
                      Dafny.ISequence<Dafny.Rune> _1848_recursiveGen;
                      bool _1849_recOwned;
                      bool _1850_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1851_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1223;
                      bool _out1224;
                      bool _out1225;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1226;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1223, out _out1224, out _out1225, out _out1226);
                      _1848_recursiveGen = _out1223;
                      _1849_recOwned = _out1224;
                      _1850_recErased = _out1225;
                      _1851_recIdents = _out1226;
                      Dafny.ISequence<Dafny.Rune> _1852_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1227;
                      _out1227 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _1852_rhsType = _out1227;
                      Dafny.ISequence<Dafny.Rune> _1853_uneraseFn;
                      _1853_uneraseFn = ((_1849_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1852_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1853_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1848_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1849_recOwned;
                      isErased = false;
                      readIdents = _1851_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1228;
                      bool _out1229;
                      bool _out1230;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1231;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1847_b), _1847_b, _486_toTpe), selfIdent, @params, mustOwn, out _out1228, out _out1229, out _out1230, out _out1231);
                      s = _out1228;
                      isOwned = _out1229;
                      isErased = _out1230;
                      readIdents = _out1231;
                    }
                  }
                }
              } else if (_source65.is_Nullable) {
                DAST._IType _1854___mcc_h968 = _source65.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1855_recursiveGen;
                  bool _1856_recOwned;
                  bool _1857_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1858_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1232;
                  bool _out1233;
                  bool _out1234;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1235;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1232, out _out1233, out _out1234, out _out1235);
                  _1855_recursiveGen = _out1232;
                  _1856_recOwned = _out1233;
                  _1857_recErased = _out1234;
                  _1858_recIdents = _out1235;
                  if (!(_1856_recOwned)) {
                    _1855_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1855_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1855_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1857_recErased;
                  readIdents = _1858_recIdents;
                }
              } else if (_source65.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1859___mcc_h970 = _source65.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1860_recursiveGen;
                  bool _1861_recOwned;
                  bool _1862_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1863_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1236;
                  bool _out1237;
                  bool _out1238;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1236, out _out1237, out _out1238, out _out1239);
                  _1860_recursiveGen = _out1236;
                  _1861_recOwned = _out1237;
                  _1862_recErased = _out1238;
                  _1863_recIdents = _out1239;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1860_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1861_recOwned;
                  isErased = _1862_recErased;
                  readIdents = _1863_recIdents;
                }
              } else if (_source65.is_Array) {
                DAST._IType _1864___mcc_h972 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1865_recursiveGen;
                  bool _1866_recOwned;
                  bool _1867_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1868_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1240;
                  bool _out1241;
                  bool _out1242;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
                  _1865_recursiveGen = _out1240;
                  _1866_recOwned = _out1241;
                  _1867_recErased = _out1242;
                  _1868_recIdents = _out1243;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1865_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1866_recOwned;
                  isErased = _1867_recErased;
                  readIdents = _1868_recIdents;
                }
              } else if (_source65.is_Seq) {
                DAST._IType _1869___mcc_h974 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1870_recursiveGen;
                  bool _1871_recOwned;
                  bool _1872_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1873_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1244;
                  bool _out1245;
                  bool _out1246;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1244, out _out1245, out _out1246, out _out1247);
                  _1870_recursiveGen = _out1244;
                  _1871_recOwned = _out1245;
                  _1872_recErased = _out1246;
                  _1873_recIdents = _out1247;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1870_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1871_recOwned;
                  isErased = _1872_recErased;
                  readIdents = _1873_recIdents;
                }
              } else if (_source65.is_Set) {
                DAST._IType _1874___mcc_h976 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1875_recursiveGen;
                  bool _1876_recOwned;
                  bool _1877_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1878_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1248;
                  bool _out1249;
                  bool _out1250;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1248, out _out1249, out _out1250, out _out1251);
                  _1875_recursiveGen = _out1248;
                  _1876_recOwned = _out1249;
                  _1877_recErased = _out1250;
                  _1878_recIdents = _out1251;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1875_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1876_recOwned;
                  isErased = _1877_recErased;
                  readIdents = _1878_recIdents;
                }
              } else if (_source65.is_Multiset) {
                DAST._IType _1879___mcc_h978 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1880_recursiveGen;
                  bool _1881_recOwned;
                  bool _1882_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1883_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1252;
                  bool _out1253;
                  bool _out1254;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1252, out _out1253, out _out1254, out _out1255);
                  _1880_recursiveGen = _out1252;
                  _1881_recOwned = _out1253;
                  _1882_recErased = _out1254;
                  _1883_recIdents = _out1255;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1880_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1881_recOwned;
                  isErased = _1882_recErased;
                  readIdents = _1883_recIdents;
                }
              } else if (_source65.is_Map) {
                DAST._IType _1884___mcc_h980 = _source65.dtor_key;
                DAST._IType _1885___mcc_h981 = _source65.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1886_recursiveGen;
                  bool _1887_recOwned;
                  bool _1888_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1889_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1256;
                  bool _out1257;
                  bool _out1258;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1256, out _out1257, out _out1258, out _out1259);
                  _1886_recursiveGen = _out1256;
                  _1887_recOwned = _out1257;
                  _1888_recErased = _out1258;
                  _1889_recIdents = _out1259;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1886_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1887_recOwned;
                  isErased = _1888_recErased;
                  readIdents = _1889_recIdents;
                }
              } else if (_source65.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1890___mcc_h984 = _source65.dtor_args;
                DAST._IType _1891___mcc_h985 = _source65.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1892_recursiveGen;
                  bool _1893_recOwned;
                  bool _1894_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1895_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1260;
                  bool _out1261;
                  bool _out1262;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1260, out _out1261, out _out1262, out _out1263);
                  _1892_recursiveGen = _out1260;
                  _1893_recOwned = _out1261;
                  _1894_recErased = _out1262;
                  _1895_recIdents = _out1263;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1892_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1893_recOwned;
                  isErased = _1894_recErased;
                  readIdents = _1895_recIdents;
                }
              } else if (_source65.is_Primitive) {
                DAST._IPrimitive _1896___mcc_h988 = _source65.dtor_Primitive_a0;
                DAST._IPrimitive _source67 = _1896___mcc_h988;
                if (_source67.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1897_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1264;
                    _out1264 = DCOMP.COMP.GenType(_487_fromTpe, true, false);
                    _1897_rhsType = _out1264;
                    Dafny.ISequence<Dafny.Rune> _1898_recursiveGen;
                    bool _1899___v51;
                    bool _1900___v52;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1901_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1265;
                    bool _out1266;
                    bool _out1267;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1268;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, true, out _out1265, out _out1266, out _out1267, out _out1268);
                    _1898_recursiveGen = _out1265;
                    _1899___v51 = _out1266;
                    _1900___v52 = _out1267;
                    _1901_recIdents = _out1268;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1898_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1901_recIdents;
                  }
                } else if (_source67.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1902_recursiveGen;
                    bool _1903_recOwned;
                    bool _1904_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1905_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1269;
                    bool _out1270;
                    bool _out1271;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1272;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1269, out _out1270, out _out1271, out _out1272);
                    _1902_recursiveGen = _out1269;
                    _1903_recOwned = _out1270;
                    _1904_recErased = _out1271;
                    _1905_recIdents = _out1272;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1902_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1903_recOwned;
                    isErased = _1904_recErased;
                    readIdents = _1905_recIdents;
                  }
                } else if (_source67.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1906_recursiveGen;
                    bool _1907_recOwned;
                    bool _1908_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1909_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1273;
                    bool _out1274;
                    bool _out1275;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1276;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1273, out _out1274, out _out1275, out _out1276);
                    _1906_recursiveGen = _out1273;
                    _1907_recOwned = _out1274;
                    _1908_recErased = _out1275;
                    _1909_recIdents = _out1276;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1906_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1907_recOwned;
                    isErased = _1908_recErased;
                    readIdents = _1909_recIdents;
                  }
                } else if (_source67.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1910_recursiveGen;
                    bool _1911_recOwned;
                    bool _1912_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1913_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1277;
                    bool _out1278;
                    bool _out1279;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1280;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1277, out _out1278, out _out1279, out _out1280);
                    _1910_recursiveGen = _out1277;
                    _1911_recOwned = _out1278;
                    _1912_recErased = _out1279;
                    _1913_recIdents = _out1280;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1910_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1911_recOwned;
                    isErased = _1912_recErased;
                    readIdents = _1913_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1914_recursiveGen;
                    bool _1915_recOwned;
                    bool _1916_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1917_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    bool _out1282;
                    bool _out1283;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1284;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1281, out _out1282, out _out1283, out _out1284);
                    _1914_recursiveGen = _out1281;
                    _1915_recOwned = _out1282;
                    _1916_recErased = _out1283;
                    _1917_recIdents = _out1284;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1914_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1915_recOwned;
                    isErased = _1916_recErased;
                    readIdents = _1917_recIdents;
                  }
                }
              } else if (_source65.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1918___mcc_h990 = _source65.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1919_recursiveGen;
                  bool _1920___v59;
                  bool _1921___v60;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1922_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1285;
                  bool _out1286;
                  bool _out1287;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1288;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, true, out _out1285, out _out1286, out _out1287, out _out1288);
                  _1919_recursiveGen = _out1285;
                  _1920___v59 = _out1286;
                  _1921___v60 = _out1287;
                  _1922_recIdents = _out1288;
                  Dafny.ISequence<Dafny.Rune> _1923_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1289;
                  _out1289 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                  _1923_toTpeGen = _out1289;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1919_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1923_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1922_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1924___mcc_h992 = _source65.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1925_recursiveGen;
                  bool _1926_recOwned;
                  bool _1927_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1928_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1290;
                  bool _out1291;
                  bool _out1292;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1293;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1290, out _out1291, out _out1292, out _out1293);
                  _1925_recursiveGen = _out1290;
                  _1926_recOwned = _out1291;
                  _1927_recErased = _out1292;
                  _1928_recIdents = _out1293;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1926_recOwned;
                  isErased = _1927_recErased;
                  readIdents = _1928_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1929___mcc_h994 = _source27.dtor_TypeArg_a0;
              DAST._IType _source68 = _494___mcc_h235;
              if (_source68.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1930___mcc_h998 = _source68.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1931___mcc_h999 = _source68.dtor_typeArgs;
                DAST._IResolvedType _1932___mcc_h1000 = _source68.dtor_resolved;
                DAST._IResolvedType _source69 = _1932___mcc_h1000;
                if (_source69.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1933___mcc_h1004 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1934_recursiveGen;
                    bool _1935_recOwned;
                    bool _1936_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1937_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1294;
                    bool _out1295;
                    bool _out1296;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1297;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1294, out _out1295, out _out1296, out _out1297);
                    _1934_recursiveGen = _out1294;
                    _1935_recOwned = _out1295;
                    _1936_recErased = _out1296;
                    _1937_recIdents = _out1297;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1934_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1935_recOwned;
                    isErased = _1936_recErased;
                    readIdents = _1937_recIdents;
                  }
                } else if (_source69.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1938___mcc_h1006 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1939_recursiveGen;
                    bool _1940_recOwned;
                    bool _1941_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1942_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1298;
                    bool _out1299;
                    bool _out1300;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1301;
                    DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1298, out _out1299, out _out1300, out _out1301);
                    _1939_recursiveGen = _out1298;
                    _1940_recOwned = _out1299;
                    _1941_recErased = _out1300;
                    _1942_recIdents = _out1301;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1939_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1940_recOwned;
                    isErased = _1941_recErased;
                    readIdents = _1942_recIdents;
                  }
                } else {
                  DAST._IType _1943___mcc_h1008 = _source69.dtor_Newtype_a0;
                  DAST._IType _1944_b = _1943___mcc_h1008;
                  {
                    if (object.Equals(_487_fromTpe, _1944_b)) {
                      Dafny.ISequence<Dafny.Rune> _1945_recursiveGen;
                      bool _1946_recOwned;
                      bool _1947_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1948_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1302;
                      bool _out1303;
                      bool _out1304;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
                      DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1302, out _out1303, out _out1304, out _out1305);
                      _1945_recursiveGen = _out1302;
                      _1946_recOwned = _out1303;
                      _1947_recErased = _out1304;
                      _1948_recIdents = _out1305;
                      Dafny.ISequence<Dafny.Rune> _1949_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1306;
                      _out1306 = DCOMP.COMP.GenType(_486_toTpe, true, false);
                      _1949_rhsType = _out1306;
                      Dafny.ISequence<Dafny.Rune> _1950_uneraseFn;
                      _1950_uneraseFn = ((_1946_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1949_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1950_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1945_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1946_recOwned;
                      isErased = false;
                      readIdents = _1948_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1307;
                      bool _out1308;
                      bool _out1309;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1310;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_488_expr, _487_fromTpe, _1944_b), _1944_b, _486_toTpe), selfIdent, @params, mustOwn, out _out1307, out _out1308, out _out1309, out _out1310);
                      s = _out1307;
                      isOwned = _out1308;
                      isErased = _out1309;
                      readIdents = _out1310;
                    }
                  }
                }
              } else if (_source68.is_Nullable) {
                DAST._IType _1951___mcc_h1010 = _source68.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1952_recursiveGen;
                  bool _1953_recOwned;
                  bool _1954_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1955_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1311;
                  bool _out1312;
                  bool _out1313;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1314;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1311, out _out1312, out _out1313, out _out1314);
                  _1952_recursiveGen = _out1311;
                  _1953_recOwned = _out1312;
                  _1954_recErased = _out1313;
                  _1955_recIdents = _out1314;
                  if (!(_1953_recOwned)) {
                    _1952_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1952_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1952_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1954_recErased;
                  readIdents = _1955_recIdents;
                }
              } else if (_source68.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1956___mcc_h1012 = _source68.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1957_recursiveGen;
                  bool _1958_recOwned;
                  bool _1959_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1960_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1315;
                  bool _out1316;
                  bool _out1317;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1318;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1315, out _out1316, out _out1317, out _out1318);
                  _1957_recursiveGen = _out1315;
                  _1958_recOwned = _out1316;
                  _1959_recErased = _out1317;
                  _1960_recIdents = _out1318;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1957_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1958_recOwned;
                  isErased = _1959_recErased;
                  readIdents = _1960_recIdents;
                }
              } else if (_source68.is_Array) {
                DAST._IType _1961___mcc_h1014 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1962_recursiveGen;
                  bool _1963_recOwned;
                  bool _1964_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1965_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1319;
                  bool _out1320;
                  bool _out1321;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1322;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1319, out _out1320, out _out1321, out _out1322);
                  _1962_recursiveGen = _out1319;
                  _1963_recOwned = _out1320;
                  _1964_recErased = _out1321;
                  _1965_recIdents = _out1322;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1962_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1963_recOwned;
                  isErased = _1964_recErased;
                  readIdents = _1965_recIdents;
                }
              } else if (_source68.is_Seq) {
                DAST._IType _1966___mcc_h1016 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1967_recursiveGen;
                  bool _1968_recOwned;
                  bool _1969_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1970_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1323;
                  bool _out1324;
                  bool _out1325;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1326;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1323, out _out1324, out _out1325, out _out1326);
                  _1967_recursiveGen = _out1323;
                  _1968_recOwned = _out1324;
                  _1969_recErased = _out1325;
                  _1970_recIdents = _out1326;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1967_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1968_recOwned;
                  isErased = _1969_recErased;
                  readIdents = _1970_recIdents;
                }
              } else if (_source68.is_Set) {
                DAST._IType _1971___mcc_h1018 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1972_recursiveGen;
                  bool _1973_recOwned;
                  bool _1974_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1975_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1327;
                  bool _out1328;
                  bool _out1329;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1330;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1327, out _out1328, out _out1329, out _out1330);
                  _1972_recursiveGen = _out1327;
                  _1973_recOwned = _out1328;
                  _1974_recErased = _out1329;
                  _1975_recIdents = _out1330;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1972_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1973_recOwned;
                  isErased = _1974_recErased;
                  readIdents = _1975_recIdents;
                }
              } else if (_source68.is_Multiset) {
                DAST._IType _1976___mcc_h1020 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1977_recursiveGen;
                  bool _1978_recOwned;
                  bool _1979_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1980_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1331;
                  bool _out1332;
                  bool _out1333;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1334;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1331, out _out1332, out _out1333, out _out1334);
                  _1977_recursiveGen = _out1331;
                  _1978_recOwned = _out1332;
                  _1979_recErased = _out1333;
                  _1980_recIdents = _out1334;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1977_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1978_recOwned;
                  isErased = _1979_recErased;
                  readIdents = _1980_recIdents;
                }
              } else if (_source68.is_Map) {
                DAST._IType _1981___mcc_h1022 = _source68.dtor_key;
                DAST._IType _1982___mcc_h1023 = _source68.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1983_recursiveGen;
                  bool _1984_recOwned;
                  bool _1985_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1986_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1335;
                  bool _out1336;
                  bool _out1337;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1338;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1335, out _out1336, out _out1337, out _out1338);
                  _1983_recursiveGen = _out1335;
                  _1984_recOwned = _out1336;
                  _1985_recErased = _out1337;
                  _1986_recIdents = _out1338;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1983_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1984_recOwned;
                  isErased = _1985_recErased;
                  readIdents = _1986_recIdents;
                }
              } else if (_source68.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1987___mcc_h1026 = _source68.dtor_args;
                DAST._IType _1988___mcc_h1027 = _source68.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1989_recursiveGen;
                  bool _1990_recOwned;
                  bool _1991_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1992_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1339;
                  bool _out1340;
                  bool _out1341;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1342;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1339, out _out1340, out _out1341, out _out1342);
                  _1989_recursiveGen = _out1339;
                  _1990_recOwned = _out1340;
                  _1991_recErased = _out1341;
                  _1992_recIdents = _out1342;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1989_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1990_recOwned;
                  isErased = _1991_recErased;
                  readIdents = _1992_recIdents;
                }
              } else if (_source68.is_Primitive) {
                DAST._IPrimitive _1993___mcc_h1030 = _source68.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1994_recursiveGen;
                  bool _1995_recOwned;
                  bool _1996_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1997_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1343;
                  bool _out1344;
                  bool _out1345;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1346;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1343, out _out1344, out _out1345, out _out1346);
                  _1994_recursiveGen = _out1343;
                  _1995_recOwned = _out1344;
                  _1996_recErased = _out1345;
                  _1997_recIdents = _out1346;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1994_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1995_recOwned;
                  isErased = _1996_recErased;
                  readIdents = _1997_recIdents;
                }
              } else if (_source68.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1998___mcc_h1032 = _source68.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1999_recursiveGen;
                  bool _2000_recOwned;
                  bool _2001_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2002_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1347;
                  bool _out1348;
                  bool _out1349;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1350;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1347, out _out1348, out _out1349, out _out1350);
                  _1999_recursiveGen = _out1347;
                  _2000_recOwned = _out1348;
                  _2001_recErased = _out1349;
                  _2002_recIdents = _out1350;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1999_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2000_recOwned;
                  isErased = _2001_recErased;
                  readIdents = _2002_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2003___mcc_h1034 = _source68.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2004_recursiveGen;
                  bool _2005_recOwned;
                  bool _2006_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2007_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1351;
                  bool _out1352;
                  bool _out1353;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1354;
                  DCOMP.COMP.GenExpr(_488_expr, selfIdent, @params, mustOwn, out _out1351, out _out1352, out _out1353, out _out1354);
                  _2004_recursiveGen = _out1351;
                  _2005_recOwned = _out1352;
                  _2006_recErased = _out1353;
                  _2007_recIdents = _out1354;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2004_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2005_recOwned;
                  isErased = _2006_recErased;
                  readIdents = _2007_recIdents;
                }
              }
            }
          }
        }
      } else if (_source20.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2008___mcc_h22 = _source20.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2009_exprs = _2008___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2010_generatedValues;
          _2010_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2011_i;
          _2011_i = BigInteger.Zero;
          bool _2012_allErased;
          _2012_allErased = true;
          while ((_2011_i) < (new BigInteger((_2009_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2013_recursiveGen;
            bool _2014___v62;
            bool _2015_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2016_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1355;
            bool _out1356;
            bool _out1357;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1358;
            DCOMP.COMP.GenExpr((_2009_exprs).Select(_2011_i), selfIdent, @params, true, out _out1355, out _out1356, out _out1357, out _out1358);
            _2013_recursiveGen = _out1355;
            _2014___v62 = _out1356;
            _2015_isErased = _out1357;
            _2016_recIdents = _out1358;
            _2012_allErased = (_2012_allErased) && (_2015_isErased);
            _2010_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2010_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2013_recursiveGen, _2015_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2016_recIdents);
            _2011_i = (_2011_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2011_i = BigInteger.Zero;
          while ((_2011_i) < (new BigInteger((_2010_generatedValues).Count))) {
            if ((_2011_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2017_gen;
            _2017_gen = ((_2010_generatedValues).Select(_2011_i)).dtor__0;
            if ((((_2010_generatedValues).Select(_2011_i)).dtor__1) && (!(_2012_allErased))) {
              _2017_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2017_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2017_gen);
            _2011_i = (_2011_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2012_allErased;
        }
      } else if (_source20.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2018___mcc_h23 = _source20.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2019_exprs = _2018___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2020_generatedValues;
          _2020_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2021_i;
          _2021_i = BigInteger.Zero;
          bool _2022_allErased;
          _2022_allErased = true;
          while ((_2021_i) < (new BigInteger((_2019_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2023_recursiveGen;
            bool _2024___v63;
            bool _2025_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2026_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1359;
            bool _out1360;
            bool _out1361;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1362;
            DCOMP.COMP.GenExpr((_2019_exprs).Select(_2021_i), selfIdent, @params, true, out _out1359, out _out1360, out _out1361, out _out1362);
            _2023_recursiveGen = _out1359;
            _2024___v63 = _out1360;
            _2025_isErased = _out1361;
            _2026_recIdents = _out1362;
            _2022_allErased = (_2022_allErased) && (_2025_isErased);
            _2020_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2020_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2023_recursiveGen, _2025_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2026_recIdents);
            _2021_i = (_2021_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2021_i = BigInteger.Zero;
          while ((_2021_i) < (new BigInteger((_2020_generatedValues).Count))) {
            if ((_2021_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2027_gen;
            _2027_gen = ((_2020_generatedValues).Select(_2021_i)).dtor__0;
            if ((((_2020_generatedValues).Select(_2021_i)).dtor__1) && (!(_2022_allErased))) {
              _2027_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2027_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2027_gen);
            _2021_i = (_2021_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source70 = selfIdent;
          if (_source70.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2028___mcc_h1036 = _source70.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2029_id = _2028___mcc_h1036;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2029_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2029_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2029_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2029_id);
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
        DAST._IExpression _2030___mcc_h24 = _source20.dtor_cond;
        DAST._IExpression _2031___mcc_h25 = _source20.dtor_thn;
        DAST._IExpression _2032___mcc_h26 = _source20.dtor_els;
        DAST._IExpression _2033_f = _2032___mcc_h26;
        DAST._IExpression _2034_t = _2031___mcc_h25;
        DAST._IExpression _2035_cond = _2030___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _2036_condString;
          bool _2037___v64;
          bool _2038_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2039_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1363;
          bool _out1364;
          bool _out1365;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1366;
          DCOMP.COMP.GenExpr(_2035_cond, selfIdent, @params, true, out _out1363, out _out1364, out _out1365, out _out1366);
          _2036_condString = _out1363;
          _2037___v64 = _out1364;
          _2038_condErased = _out1365;
          _2039_recIdentsCond = _out1366;
          if (!(_2038_condErased)) {
            _2036_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2036_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2040___v65;
          bool _2041_tHasToBeOwned;
          bool _2042___v66;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2043___v67;
          Dafny.ISequence<Dafny.Rune> _out1367;
          bool _out1368;
          bool _out1369;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1370;
          DCOMP.COMP.GenExpr(_2034_t, selfIdent, @params, mustOwn, out _out1367, out _out1368, out _out1369, out _out1370);
          _2040___v65 = _out1367;
          _2041_tHasToBeOwned = _out1368;
          _2042___v66 = _out1369;
          _2043___v67 = _out1370;
          Dafny.ISequence<Dafny.Rune> _2044_fString;
          bool _2045_fOwned;
          bool _2046_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2047_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1371;
          bool _out1372;
          bool _out1373;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1374;
          DCOMP.COMP.GenExpr(_2033_f, selfIdent, @params, _2041_tHasToBeOwned, out _out1371, out _out1372, out _out1373, out _out1374);
          _2044_fString = _out1371;
          _2045_fOwned = _out1372;
          _2046_fErased = _out1373;
          _2047_recIdentsF = _out1374;
          Dafny.ISequence<Dafny.Rune> _2048_tString;
          bool _2049___v68;
          bool _2050_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2051_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1375;
          bool _out1376;
          bool _out1377;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1378;
          DCOMP.COMP.GenExpr(_2034_t, selfIdent, @params, _2045_fOwned, out _out1375, out _out1376, out _out1377, out _out1378);
          _2048_tString = _out1375;
          _2049___v68 = _out1376;
          _2050_tErased = _out1377;
          _2051_recIdentsT = _out1378;
          if ((!(_2046_fErased)) || (!(_2050_tErased))) {
            if (_2046_fErased) {
              _2044_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2044_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2050_tErased) {
              _2048_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2048_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2036_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2048_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2044_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2045_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2039_recIdentsCond, _2051_recIdentsT), _2047_recIdentsF);
          isErased = (_2046_fErased) || (_2050_tErased);
        }
      } else if (_source20.is_UnOp) {
        DAST._IUnaryOp _2052___mcc_h27 = _source20.dtor_unOp;
        DAST._IExpression _2053___mcc_h28 = _source20.dtor_expr;
        DAST._IUnaryOp _source71 = _2052___mcc_h27;
        if (_source71.is_Not) {
          DAST._IExpression _2054_e = _2053___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2055_recursiveGen;
            bool _2056___v69;
            bool _2057_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2058_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1379;
            bool _out1380;
            bool _out1381;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1382;
            DCOMP.COMP.GenExpr(_2054_e, selfIdent, @params, true, out _out1379, out _out1380, out _out1381, out _out1382);
            _2055_recursiveGen = _out1379;
            _2056___v69 = _out1380;
            _2057_recErased = _out1381;
            _2058_recIdents = _out1382;
            if (!(_2057_recErased)) {
              _2055_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2055_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2055_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2058_recIdents;
            isErased = true;
          }
        } else if (_source71.is_BitwiseNot) {
          DAST._IExpression _2059_e = _2053___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2060_recursiveGen;
            bool _2061___v70;
            bool _2062_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2063_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1383;
            bool _out1384;
            bool _out1385;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1386;
            DCOMP.COMP.GenExpr(_2059_e, selfIdent, @params, true, out _out1383, out _out1384, out _out1385, out _out1386);
            _2060_recursiveGen = _out1383;
            _2061___v70 = _out1384;
            _2062_recErased = _out1385;
            _2063_recIdents = _out1386;
            if (!(_2062_recErased)) {
              _2060_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2060_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2060_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2063_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2064_e = _2053___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2065_recursiveGen;
            bool _2066_recOwned;
            bool _2067_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2068_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1387;
            bool _out1388;
            bool _out1389;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1390;
            DCOMP.COMP.GenExpr(_2064_e, selfIdent, @params, false, out _out1387, out _out1388, out _out1389, out _out1390);
            _2065_recursiveGen = _out1387;
            _2066_recOwned = _out1388;
            _2067_recErased = _out1389;
            _2068_recIdents = _out1390;
            if (!(_2067_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2069_eraseFn;
              _2069_eraseFn = ((_2066_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2065_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2069_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2065_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2065_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2068_recIdents;
            isErased = true;
          }
        }
      } else if (_source20.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2070___mcc_h29 = _source20.dtor_op;
        DAST._IExpression _2071___mcc_h30 = _source20.dtor_left;
        DAST._IExpression _2072___mcc_h31 = _source20.dtor_right;
        DAST._IExpression _2073_r = _2072___mcc_h31;
        DAST._IExpression _2074_l = _2071___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _2075_op = _2070___mcc_h29;
        {
          Dafny.ISequence<Dafny.Rune> _2076_left;
          bool _2077___v71;
          bool _2078_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2079_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1391;
          bool _out1392;
          bool _out1393;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1394;
          DCOMP.COMP.GenExpr(_2074_l, selfIdent, @params, true, out _out1391, out _out1392, out _out1393, out _out1394);
          _2076_left = _out1391;
          _2077___v71 = _out1392;
          _2078_leftErased = _out1393;
          _2079_recIdentsL = _out1394;
          Dafny.ISequence<Dafny.Rune> _2080_right;
          bool _2081___v72;
          bool _2082_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2083_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1395;
          bool _out1396;
          bool _out1397;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1398;
          DCOMP.COMP.GenExpr(_2073_r, selfIdent, @params, true, out _out1395, out _out1396, out _out1397, out _out1398);
          _2080_right = _out1395;
          _2081___v72 = _out1396;
          _2082_rightErased = _out1397;
          _2083_recIdentsR = _out1398;
          if (!(_2078_leftErased)) {
            _2076_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2076_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2082_rightErased)) {
            _2080_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2080_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2075_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2076_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2080_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2075_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2076_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2080_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2076_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2075_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2080_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2079_recIdentsL, _2083_recIdentsR);
          isErased = true;
        }
      } else if (_source20.is_Select) {
        DAST._IExpression _2084___mcc_h32 = _source20.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2085___mcc_h33 = _source20.dtor_field;
        bool _2086___mcc_h34 = _source20.dtor_isConstant;
        bool _2087___mcc_h35 = _source20.dtor_onDatatype;
        DAST._IExpression _source72 = _2084___mcc_h32;
        if (_source72.is_Literal) {
          DAST._ILiteral _2088___mcc_h36 = _source72.dtor_Literal_a0;
          bool _2089_isDatatype = _2087___mcc_h35;
          bool _2090_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2091_field = _2085___mcc_h33;
          DAST._IExpression _2092_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2093_onString;
            bool _2094_onOwned;
            bool _2095_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2096_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1399;
            bool _out1400;
            bool _out1401;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1402;
            DCOMP.COMP.GenExpr(_2092_on, selfIdent, @params, false, out _out1399, out _out1400, out _out1401, out _out1402);
            _2093_onString = _out1399;
            _2094_onOwned = _out1400;
            _2095_onErased = _out1401;
            _2096_recIdents = _out1402;
            if (!(_2095_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2097_eraseFn;
              _2097_eraseFn = ((_2094_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2093_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2097_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2093_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2089_isDatatype) || (_2090_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2093_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2091_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2090_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2093_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2091_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2096_recIdents;
          }
        } else if (_source72.is_Ident) {
          Dafny.ISequence<Dafny.Rune> _2098___mcc_h38 = _source72.dtor_Ident_a0;
          bool _2099_isDatatype = _2087___mcc_h35;
          bool _2100_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2101_field = _2085___mcc_h33;
          DAST._IExpression _2102_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2103_onString;
            bool _2104_onOwned;
            bool _2105_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2106_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1403;
            bool _out1404;
            bool _out1405;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1406;
            DCOMP.COMP.GenExpr(_2102_on, selfIdent, @params, false, out _out1403, out _out1404, out _out1405, out _out1406);
            _2103_onString = _out1403;
            _2104_onOwned = _out1404;
            _2105_onErased = _out1405;
            _2106_recIdents = _out1406;
            if (!(_2105_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2107_eraseFn;
              _2107_eraseFn = ((_2104_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2103_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2107_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2103_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2099_isDatatype) || (_2100_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2103_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2101_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2100_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2103_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2101_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2106_recIdents;
          }
        } else if (_source72.is_Companion) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2108___mcc_h40 = _source72.dtor_Companion_a0;
          bool _2109_isDatatype = _2087___mcc_h35;
          bool _2110_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2111_field = _2085___mcc_h33;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2112_c = _2108___mcc_h40;
          {
            Dafny.ISequence<Dafny.Rune> _2113_onString;
            bool _2114_onOwned;
            bool _2115_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2116_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1407;
            bool _out1408;
            bool _out1409;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1410;
            DCOMP.COMP.GenExpr(DAST.Expression.create_Companion(_2112_c), selfIdent, @params, false, out _out1407, out _out1408, out _out1409, out _out1410);
            _2113_onString = _out1407;
            _2114_onOwned = _out1408;
            _2115_onErased = _out1409;
            _2116_recIdents = _out1410;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2113_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2111_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            isOwned = true;
            isErased = false;
            readIdents = _2116_recIdents;
          }
        } else if (_source72.is_Tuple) {
          Dafny.ISequence<DAST._IExpression> _2117___mcc_h42 = _source72.dtor_Tuple_a0;
          bool _2118_isDatatype = _2087___mcc_h35;
          bool _2119_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2120_field = _2085___mcc_h33;
          DAST._IExpression _2121_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2122_onString;
            bool _2123_onOwned;
            bool _2124_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2125_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1411;
            bool _out1412;
            bool _out1413;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1414;
            DCOMP.COMP.GenExpr(_2121_on, selfIdent, @params, false, out _out1411, out _out1412, out _out1413, out _out1414);
            _2122_onString = _out1411;
            _2123_onOwned = _out1412;
            _2124_onErased = _out1413;
            _2125_recIdents = _out1414;
            if (!(_2124_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2126_eraseFn;
              _2126_eraseFn = ((_2123_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2122_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2126_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2122_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2118_isDatatype) || (_2119_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2122_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2120_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2119_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2122_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2120_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2125_recIdents;
          }
        } else if (_source72.is_New) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2127___mcc_h44 = _source72.dtor_path;
          Dafny.ISequence<DAST._IExpression> _2128___mcc_h45 = _source72.dtor_args;
          bool _2129_isDatatype = _2087___mcc_h35;
          bool _2130_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2131_field = _2085___mcc_h33;
          DAST._IExpression _2132_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2133_onString;
            bool _2134_onOwned;
            bool _2135_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2136_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1415;
            bool _out1416;
            bool _out1417;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1418;
            DCOMP.COMP.GenExpr(_2132_on, selfIdent, @params, false, out _out1415, out _out1416, out _out1417, out _out1418);
            _2133_onString = _out1415;
            _2134_onOwned = _out1416;
            _2135_onErased = _out1417;
            _2136_recIdents = _out1418;
            if (!(_2135_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2137_eraseFn;
              _2137_eraseFn = ((_2134_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2133_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2137_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2133_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2129_isDatatype) || (_2130_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2133_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2131_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2130_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2133_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2131_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2136_recIdents;
          }
        } else if (_source72.is_NewArray) {
          Dafny.ISequence<DAST._IExpression> _2138___mcc_h48 = _source72.dtor_dims;
          bool _2139_isDatatype = _2087___mcc_h35;
          bool _2140_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2141_field = _2085___mcc_h33;
          DAST._IExpression _2142_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2143_onString;
            bool _2144_onOwned;
            bool _2145_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2146_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1419;
            bool _out1420;
            bool _out1421;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1422;
            DCOMP.COMP.GenExpr(_2142_on, selfIdent, @params, false, out _out1419, out _out1420, out _out1421, out _out1422);
            _2143_onString = _out1419;
            _2144_onOwned = _out1420;
            _2145_onErased = _out1421;
            _2146_recIdents = _out1422;
            if (!(_2145_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2147_eraseFn;
              _2147_eraseFn = ((_2144_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2143_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2147_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2143_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2139_isDatatype) || (_2140_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2143_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2141_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2140_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2143_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2141_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2146_recIdents;
          }
        } else if (_source72.is_DatatypeValue) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2148___mcc_h50 = _source72.dtor_path;
          Dafny.ISequence<Dafny.Rune> _2149___mcc_h51 = _source72.dtor_variant;
          bool _2150___mcc_h52 = _source72.dtor_isCo;
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2151___mcc_h53 = _source72.dtor_contents;
          bool _2152_isDatatype = _2087___mcc_h35;
          bool _2153_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2154_field = _2085___mcc_h33;
          DAST._IExpression _2155_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2156_onString;
            bool _2157_onOwned;
            bool _2158_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2159_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1423;
            bool _out1424;
            bool _out1425;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1426;
            DCOMP.COMP.GenExpr(_2155_on, selfIdent, @params, false, out _out1423, out _out1424, out _out1425, out _out1426);
            _2156_onString = _out1423;
            _2157_onOwned = _out1424;
            _2158_onErased = _out1425;
            _2159_recIdents = _out1426;
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
        } else if (_source72.is_Convert) {
          DAST._IExpression _2161___mcc_h58 = _source72.dtor_value;
          DAST._IType _2162___mcc_h59 = _source72.dtor_from;
          DAST._IType _2163___mcc_h60 = _source72.dtor_typ;
          bool _2164_isDatatype = _2087___mcc_h35;
          bool _2165_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2166_field = _2085___mcc_h33;
          DAST._IExpression _2167_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2168_onString;
            bool _2169_onOwned;
            bool _2170_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2171_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1427;
            bool _out1428;
            bool _out1429;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1430;
            DCOMP.COMP.GenExpr(_2167_on, selfIdent, @params, false, out _out1427, out _out1428, out _out1429, out _out1430);
            _2168_onString = _out1427;
            _2169_onOwned = _out1428;
            _2170_onErased = _out1429;
            _2171_recIdents = _out1430;
            if (!(_2170_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2172_eraseFn;
              _2172_eraseFn = ((_2169_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2168_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2172_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2168_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2164_isDatatype) || (_2165_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2168_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2166_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2165_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2168_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2166_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2171_recIdents;
          }
        } else if (_source72.is_SeqValue) {
          Dafny.ISequence<DAST._IExpression> _2173___mcc_h64 = _source72.dtor_elements;
          bool _2174_isDatatype = _2087___mcc_h35;
          bool _2175_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2176_field = _2085___mcc_h33;
          DAST._IExpression _2177_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2178_onString;
            bool _2179_onOwned;
            bool _2180_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2181_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1431;
            bool _out1432;
            bool _out1433;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1434;
            DCOMP.COMP.GenExpr(_2177_on, selfIdent, @params, false, out _out1431, out _out1432, out _out1433, out _out1434);
            _2178_onString = _out1431;
            _2179_onOwned = _out1432;
            _2180_onErased = _out1433;
            _2181_recIdents = _out1434;
            if (!(_2180_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2182_eraseFn;
              _2182_eraseFn = ((_2179_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2178_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2182_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2178_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2174_isDatatype) || (_2175_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2178_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2176_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2175_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2178_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2176_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2181_recIdents;
          }
        } else if (_source72.is_SetValue) {
          Dafny.ISequence<DAST._IExpression> _2183___mcc_h66 = _source72.dtor_elements;
          bool _2184_isDatatype = _2087___mcc_h35;
          bool _2185_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2186_field = _2085___mcc_h33;
          DAST._IExpression _2187_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2188_onString;
            bool _2189_onOwned;
            bool _2190_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2191_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1435;
            bool _out1436;
            bool _out1437;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1438;
            DCOMP.COMP.GenExpr(_2187_on, selfIdent, @params, false, out _out1435, out _out1436, out _out1437, out _out1438);
            _2188_onString = _out1435;
            _2189_onOwned = _out1436;
            _2190_onErased = _out1437;
            _2191_recIdents = _out1438;
            if (!(_2190_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2192_eraseFn;
              _2192_eraseFn = ((_2189_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2188_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2192_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2188_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2184_isDatatype) || (_2185_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2188_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2186_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2185_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2188_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2186_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2191_recIdents;
          }
        } else if (_source72.is_This) {
          bool _2193_isDatatype = _2087___mcc_h35;
          bool _2194_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2195_field = _2085___mcc_h33;
          DAST._IExpression _2196_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2197_onString;
            bool _2198_onOwned;
            bool _2199_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2200_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1439;
            bool _out1440;
            bool _out1441;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1442;
            DCOMP.COMP.GenExpr(_2196_on, selfIdent, @params, false, out _out1439, out _out1440, out _out1441, out _out1442);
            _2197_onString = _out1439;
            _2198_onOwned = _out1440;
            _2199_onErased = _out1441;
            _2200_recIdents = _out1442;
            if (!(_2199_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2201_eraseFn;
              _2201_eraseFn = ((_2198_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2197_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2201_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2197_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2193_isDatatype) || (_2194_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2197_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2195_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2194_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2197_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2195_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2200_recIdents;
          }
        } else if (_source72.is_Ite) {
          DAST._IExpression _2202___mcc_h68 = _source72.dtor_cond;
          DAST._IExpression _2203___mcc_h69 = _source72.dtor_thn;
          DAST._IExpression _2204___mcc_h70 = _source72.dtor_els;
          bool _2205_isDatatype = _2087___mcc_h35;
          bool _2206_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2207_field = _2085___mcc_h33;
          DAST._IExpression _2208_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2209_onString;
            bool _2210_onOwned;
            bool _2211_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2212_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1443;
            bool _out1444;
            bool _out1445;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1446;
            DCOMP.COMP.GenExpr(_2208_on, selfIdent, @params, false, out _out1443, out _out1444, out _out1445, out _out1446);
            _2209_onString = _out1443;
            _2210_onOwned = _out1444;
            _2211_onErased = _out1445;
            _2212_recIdents = _out1446;
            if (!(_2211_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2213_eraseFn;
              _2213_eraseFn = ((_2210_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2209_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2213_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2209_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2205_isDatatype) || (_2206_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2209_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2207_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2206_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2209_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2207_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2212_recIdents;
          }
        } else if (_source72.is_UnOp) {
          DAST._IUnaryOp _2214___mcc_h74 = _source72.dtor_unOp;
          DAST._IExpression _2215___mcc_h75 = _source72.dtor_expr;
          bool _2216_isDatatype = _2087___mcc_h35;
          bool _2217_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2218_field = _2085___mcc_h33;
          DAST._IExpression _2219_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2220_onString;
            bool _2221_onOwned;
            bool _2222_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2223_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1447;
            bool _out1448;
            bool _out1449;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1450;
            DCOMP.COMP.GenExpr(_2219_on, selfIdent, @params, false, out _out1447, out _out1448, out _out1449, out _out1450);
            _2220_onString = _out1447;
            _2221_onOwned = _out1448;
            _2222_onErased = _out1449;
            _2223_recIdents = _out1450;
            if (!(_2222_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2224_eraseFn;
              _2224_eraseFn = ((_2221_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2220_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2224_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2220_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2216_isDatatype) || (_2217_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2220_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2218_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2217_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2220_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2218_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2223_recIdents;
          }
        } else if (_source72.is_BinOp) {
          Dafny.ISequence<Dafny.Rune> _2225___mcc_h78 = _source72.dtor_op;
          DAST._IExpression _2226___mcc_h79 = _source72.dtor_left;
          DAST._IExpression _2227___mcc_h80 = _source72.dtor_right;
          bool _2228_isDatatype = _2087___mcc_h35;
          bool _2229_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2230_field = _2085___mcc_h33;
          DAST._IExpression _2231_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2232_onString;
            bool _2233_onOwned;
            bool _2234_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2235_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1451;
            bool _out1452;
            bool _out1453;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1454;
            DCOMP.COMP.GenExpr(_2231_on, selfIdent, @params, false, out _out1451, out _out1452, out _out1453, out _out1454);
            _2232_onString = _out1451;
            _2233_onOwned = _out1452;
            _2234_onErased = _out1453;
            _2235_recIdents = _out1454;
            if (!(_2234_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2236_eraseFn;
              _2236_eraseFn = ((_2233_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2232_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2236_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2232_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2228_isDatatype) || (_2229_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2232_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2230_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2229_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2232_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2230_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2235_recIdents;
          }
        } else if (_source72.is_Select) {
          DAST._IExpression _2237___mcc_h84 = _source72.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2238___mcc_h85 = _source72.dtor_field;
          bool _2239___mcc_h86 = _source72.dtor_isConstant;
          bool _2240___mcc_h87 = _source72.dtor_onDatatype;
          bool _2241_isDatatype = _2087___mcc_h35;
          bool _2242_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2243_field = _2085___mcc_h33;
          DAST._IExpression _2244_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2245_onString;
            bool _2246_onOwned;
            bool _2247_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2248_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1455;
            bool _out1456;
            bool _out1457;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1458;
            DCOMP.COMP.GenExpr(_2244_on, selfIdent, @params, false, out _out1455, out _out1456, out _out1457, out _out1458);
            _2245_onString = _out1455;
            _2246_onOwned = _out1456;
            _2247_onErased = _out1457;
            _2248_recIdents = _out1458;
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
        } else if (_source72.is_SelectFn) {
          DAST._IExpression _2250___mcc_h92 = _source72.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2251___mcc_h93 = _source72.dtor_field;
          bool _2252___mcc_h94 = _source72.dtor_onDatatype;
          bool _2253___mcc_h95 = _source72.dtor_isStatic;
          BigInteger _2254___mcc_h96 = _source72.dtor_arity;
          bool _2255_isDatatype = _2087___mcc_h35;
          bool _2256_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2257_field = _2085___mcc_h33;
          DAST._IExpression _2258_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2259_onString;
            bool _2260_onOwned;
            bool _2261_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2262_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1459;
            bool _out1460;
            bool _out1461;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1462;
            DCOMP.COMP.GenExpr(_2258_on, selfIdent, @params, false, out _out1459, out _out1460, out _out1461, out _out1462);
            _2259_onString = _out1459;
            _2260_onOwned = _out1460;
            _2261_onErased = _out1461;
            _2262_recIdents = _out1462;
            if (!(_2261_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2263_eraseFn;
              _2263_eraseFn = ((_2260_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2259_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2263_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2259_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2255_isDatatype) || (_2256_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2259_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2257_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2256_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2259_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2257_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2262_recIdents;
          }
        } else if (_source72.is_Index) {
          DAST._IExpression _2264___mcc_h102 = _source72.dtor_expr;
          DAST._IExpression _2265___mcc_h103 = _source72.dtor_idx;
          bool _2266_isDatatype = _2087___mcc_h35;
          bool _2267_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2268_field = _2085___mcc_h33;
          DAST._IExpression _2269_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2270_onString;
            bool _2271_onOwned;
            bool _2272_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2273_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1463;
            bool _out1464;
            bool _out1465;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1466;
            DCOMP.COMP.GenExpr(_2269_on, selfIdent, @params, false, out _out1463, out _out1464, out _out1465, out _out1466);
            _2270_onString = _out1463;
            _2271_onOwned = _out1464;
            _2272_onErased = _out1465;
            _2273_recIdents = _out1466;
            if (!(_2272_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2274_eraseFn;
              _2274_eraseFn = ((_2271_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2270_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2274_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2270_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2266_isDatatype) || (_2267_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2270_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2268_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2267_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2270_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2268_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2273_recIdents;
          }
        } else if (_source72.is_TupleSelect) {
          DAST._IExpression _2275___mcc_h106 = _source72.dtor_expr;
          BigInteger _2276___mcc_h107 = _source72.dtor_index;
          bool _2277_isDatatype = _2087___mcc_h35;
          bool _2278_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2279_field = _2085___mcc_h33;
          DAST._IExpression _2280_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2281_onString;
            bool _2282_onOwned;
            bool _2283_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2284_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1467;
            bool _out1468;
            bool _out1469;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1470;
            DCOMP.COMP.GenExpr(_2280_on, selfIdent, @params, false, out _out1467, out _out1468, out _out1469, out _out1470);
            _2281_onString = _out1467;
            _2282_onOwned = _out1468;
            _2283_onErased = _out1469;
            _2284_recIdents = _out1470;
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
        } else if (_source72.is_Call) {
          DAST._IExpression _2286___mcc_h110 = _source72.dtor_on;
          Dafny.ISequence<Dafny.Rune> _2287___mcc_h111 = _source72.dtor_name;
          Dafny.ISequence<DAST._IType> _2288___mcc_h112 = _source72.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _2289___mcc_h113 = _source72.dtor_args;
          bool _2290_isDatatype = _2087___mcc_h35;
          bool _2291_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2292_field = _2085___mcc_h33;
          DAST._IExpression _2293_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2294_onString;
            bool _2295_onOwned;
            bool _2296_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2297_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1471;
            bool _out1472;
            bool _out1473;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1474;
            DCOMP.COMP.GenExpr(_2293_on, selfIdent, @params, false, out _out1471, out _out1472, out _out1473, out _out1474);
            _2294_onString = _out1471;
            _2295_onOwned = _out1472;
            _2296_onErased = _out1473;
            _2297_recIdents = _out1474;
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
        } else if (_source72.is_Lambda) {
          Dafny.ISequence<DAST._IFormal> _2299___mcc_h118 = _source72.dtor_params;
          DAST._IType _2300___mcc_h119 = _source72.dtor_retType;
          Dafny.ISequence<DAST._IStatement> _2301___mcc_h120 = _source72.dtor_body;
          bool _2302_isDatatype = _2087___mcc_h35;
          bool _2303_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2304_field = _2085___mcc_h33;
          DAST._IExpression _2305_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2306_onString;
            bool _2307_onOwned;
            bool _2308_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2309_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1475;
            bool _out1476;
            bool _out1477;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1478;
            DCOMP.COMP.GenExpr(_2305_on, selfIdent, @params, false, out _out1475, out _out1476, out _out1477, out _out1478);
            _2306_onString = _out1475;
            _2307_onOwned = _out1476;
            _2308_onErased = _out1477;
            _2309_recIdents = _out1478;
            if (!(_2308_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2310_eraseFn;
              _2310_eraseFn = ((_2307_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2306_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2310_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2306_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2302_isDatatype) || (_2303_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2306_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2304_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2303_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2306_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2304_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2309_recIdents;
          }
        } else if (_source72.is_IIFE) {
          Dafny.ISequence<Dafny.Rune> _2311___mcc_h124 = _source72.dtor_name;
          DAST._IType _2312___mcc_h125 = _source72.dtor_typ;
          DAST._IExpression _2313___mcc_h126 = _source72.dtor_value;
          DAST._IExpression _2314___mcc_h127 = _source72.dtor_iifeBody;
          bool _2315_isDatatype = _2087___mcc_h35;
          bool _2316_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2317_field = _2085___mcc_h33;
          DAST._IExpression _2318_on = _2084___mcc_h32;
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
        } else if (_source72.is_Apply) {
          DAST._IExpression _2324___mcc_h132 = _source72.dtor_expr;
          Dafny.ISequence<DAST._IExpression> _2325___mcc_h133 = _source72.dtor_args;
          bool _2326_isDatatype = _2087___mcc_h35;
          bool _2327_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2328_field = _2085___mcc_h33;
          DAST._IExpression _2329_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2330_onString;
            bool _2331_onOwned;
            bool _2332_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2333_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1483;
            bool _out1484;
            bool _out1485;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1486;
            DCOMP.COMP.GenExpr(_2329_on, selfIdent, @params, false, out _out1483, out _out1484, out _out1485, out _out1486);
            _2330_onString = _out1483;
            _2331_onOwned = _out1484;
            _2332_onErased = _out1485;
            _2333_recIdents = _out1486;
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
        } else if (_source72.is_TypeTest) {
          DAST._IExpression _2335___mcc_h136 = _source72.dtor_on;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2336___mcc_h137 = _source72.dtor_dType;
          Dafny.ISequence<Dafny.Rune> _2337___mcc_h138 = _source72.dtor_variant;
          bool _2338_isDatatype = _2087___mcc_h35;
          bool _2339_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2340_field = _2085___mcc_h33;
          DAST._IExpression _2341_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2342_onString;
            bool _2343_onOwned;
            bool _2344_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2345_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1487;
            bool _out1488;
            bool _out1489;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1490;
            DCOMP.COMP.GenExpr(_2341_on, selfIdent, @params, false, out _out1487, out _out1488, out _out1489, out _out1490);
            _2342_onString = _out1487;
            _2343_onOwned = _out1488;
            _2344_onErased = _out1489;
            _2345_recIdents = _out1490;
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
        } else {
          DAST._IType _2347___mcc_h142 = _source72.dtor_typ;
          bool _2348_isDatatype = _2087___mcc_h35;
          bool _2349_isConstant = _2086___mcc_h34;
          Dafny.ISequence<Dafny.Rune> _2350_field = _2085___mcc_h33;
          DAST._IExpression _2351_on = _2084___mcc_h32;
          {
            Dafny.ISequence<Dafny.Rune> _2352_onString;
            bool _2353_onOwned;
            bool _2354_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2355_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1491;
            bool _out1492;
            bool _out1493;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1494;
            DCOMP.COMP.GenExpr(_2351_on, selfIdent, @params, false, out _out1491, out _out1492, out _out1493, out _out1494);
            _2352_onString = _out1491;
            _2353_onOwned = _out1492;
            _2354_onErased = _out1493;
            _2355_recIdents = _out1494;
            if (!(_2354_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2356_eraseFn;
              _2356_eraseFn = ((_2353_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2352_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2356_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2352_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2348_isDatatype) || (_2349_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2352_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2350_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2349_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2352_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2350_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2355_recIdents;
          }
        }
      } else if (_source20.is_SelectFn) {
        DAST._IExpression _2357___mcc_h144 = _source20.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2358___mcc_h145 = _source20.dtor_field;
        bool _2359___mcc_h146 = _source20.dtor_onDatatype;
        bool _2360___mcc_h147 = _source20.dtor_isStatic;
        BigInteger _2361___mcc_h148 = _source20.dtor_arity;
        BigInteger _2362_arity = _2361___mcc_h148;
        bool _2363_isStatic = _2360___mcc_h147;
        bool _2364_isDatatype = _2359___mcc_h146;
        Dafny.ISequence<Dafny.Rune> _2365_field = _2358___mcc_h145;
        DAST._IExpression _2366_on = _2357___mcc_h144;
        {
          Dafny.ISequence<Dafny.Rune> _2367_onString;
          bool _2368_onOwned;
          bool _2369___v73;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2370_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1495;
          bool _out1496;
          bool _out1497;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1498;
          DCOMP.COMP.GenExpr(_2366_on, selfIdent, @params, false, out _out1495, out _out1496, out _out1497, out _out1498);
          _2367_onString = _out1495;
          _2368_onOwned = _out1496;
          _2369___v73 = _out1497;
          _2370_recIdents = _out1498;
          if (_2363_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2367_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2365_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2367_onString), ((_2368_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2371_args;
            _2371_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2372_i;
            _2372_i = BigInteger.Zero;
            while ((_2372_i) < (_2362_arity)) {
              if ((_2372_i).Sign == 1) {
                _2371_args = Dafny.Sequence<Dafny.Rune>.Concat(_2371_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2371_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2371_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2372_i));
              _2372_i = (_2372_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2371_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2365_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2371_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _2370_recIdents;
        }
      } else if (_source20.is_Index) {
        DAST._IExpression _2373___mcc_h149 = _source20.dtor_expr;
        DAST._IExpression _2374___mcc_h150 = _source20.dtor_idx;
        DAST._IExpression _2375_idx = _2374___mcc_h150;
        DAST._IExpression _2376_on = _2373___mcc_h149;
        {
          Dafny.ISequence<Dafny.Rune> _2377_onString;
          bool _2378_onOwned;
          bool _2379_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2380_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1499;
          bool _out1500;
          bool _out1501;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1502;
          DCOMP.COMP.GenExpr(_2376_on, selfIdent, @params, false, out _out1499, out _out1500, out _out1501, out _out1502);
          _2377_onString = _out1499;
          _2378_onOwned = _out1500;
          _2379_onErased = _out1501;
          _2380_recIdents = _out1502;
          if (!(_2379_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2381_eraseFn;
            _2381_eraseFn = ((_2378_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2377_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2381_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2377_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2382_idxString;
          bool _2383___v74;
          bool _2384_idxErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2385_recIdentsIdx;
          Dafny.ISequence<Dafny.Rune> _out1503;
          bool _out1504;
          bool _out1505;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1506;
          DCOMP.COMP.GenExpr(_2375_idx, selfIdent, @params, true, out _out1503, out _out1504, out _out1505, out _out1506);
          _2382_idxString = _out1503;
          _2383___v74 = _out1504;
          _2384_idxErased = _out1505;
          _2385_recIdentsIdx = _out1506;
          if (!(_2384_idxErased)) {
            _2382_idxString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2382_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2377_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[<usize as ::dafny_runtime::NumCast>::from(")), _2382_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2380_recIdents, _2385_recIdentsIdx);
        }
      } else if (_source20.is_TupleSelect) {
        DAST._IExpression _2386___mcc_h151 = _source20.dtor_expr;
        BigInteger _2387___mcc_h152 = _source20.dtor_index;
        BigInteger _2388_idx = _2387___mcc_h152;
        DAST._IExpression _2389_on = _2386___mcc_h151;
        {
          Dafny.ISequence<Dafny.Rune> _2390_onString;
          bool _2391___v75;
          bool _2392_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2393_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1507;
          bool _out1508;
          bool _out1509;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1510;
          DCOMP.COMP.GenExpr(_2389_on, selfIdent, @params, false, out _out1507, out _out1508, out _out1509, out _out1510);
          _2390_onString = _out1507;
          _2391___v75 = _out1508;
          _2392_tupErased = _out1509;
          _2393_recIdents = _out1510;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2390_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2388_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2392_tupErased;
          readIdents = _2393_recIdents;
        }
      } else if (_source20.is_Call) {
        DAST._IExpression _2394___mcc_h153 = _source20.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2395___mcc_h154 = _source20.dtor_name;
        Dafny.ISequence<DAST._IType> _2396___mcc_h155 = _source20.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2397___mcc_h156 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2398_args = _2397___mcc_h156;
        Dafny.ISequence<DAST._IType> _2399_typeArgs = _2396___mcc_h155;
        Dafny.ISequence<Dafny.Rune> _2400_name = _2395___mcc_h154;
        DAST._IExpression _2401_on = _2394___mcc_h153;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2402_typeArgString;
          _2402_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2399_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2403_typeI;
            _2403_typeI = BigInteger.Zero;
            _2402_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2403_typeI) < (new BigInteger((_2399_typeArgs).Count))) {
              if ((_2403_typeI).Sign == 1) {
                _2402_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2402_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2404_typeString;
              Dafny.ISequence<Dafny.Rune> _out1511;
              _out1511 = DCOMP.COMP.GenType((_2399_typeArgs).Select(_2403_typeI), false, false);
              _2404_typeString = _out1511;
              _2402_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2402_typeArgString, _2404_typeString);
              _2403_typeI = (_2403_typeI) + (BigInteger.One);
            }
            _2402_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2402_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2405_argString;
          _2405_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2406_i;
          _2406_i = BigInteger.Zero;
          while ((_2406_i) < (new BigInteger((_2398_args).Count))) {
            if ((_2406_i).Sign == 1) {
              _2405_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2405_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2407_argExpr;
            bool _2408_isOwned;
            bool _2409_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2410_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1512;
            bool _out1513;
            bool _out1514;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1515;
            DCOMP.COMP.GenExpr((_2398_args).Select(_2406_i), selfIdent, @params, false, out _out1512, out _out1513, out _out1514, out _out1515);
            _2407_argExpr = _out1512;
            _2408_isOwned = _out1513;
            _2409_argErased = _out1514;
            _2410_argIdents = _out1515;
            if (_2408_isOwned) {
              _2407_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2407_argExpr);
            }
            _2405_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2405_argString, _2407_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2410_argIdents);
            _2406_i = (_2406_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2411_enclosingString;
          bool _2412___v76;
          bool _2413___v77;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2414_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1516;
          bool _out1517;
          bool _out1518;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1519;
          DCOMP.COMP.GenExpr(_2401_on, selfIdent, @params, false, out _out1516, out _out1517, out _out1518, out _out1519);
          _2411_enclosingString = _out1516;
          _2412___v76 = _out1517;
          _2413___v77 = _out1518;
          _2414_recIdents = _out1519;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2414_recIdents);
          DAST._IExpression _source73 = _2401_on;
          if (_source73.is_Literal) {
            DAST._ILiteral _2415___mcc_h1037 = _source73.dtor_Literal_a0;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2416___mcc_h1039 = _source73.dtor_Ident_a0;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2417___mcc_h1041 = _source73.dtor_Companion_a0;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_2411_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source73.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2418___mcc_h1043 = _source73.dtor_Tuple_a0;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2419___mcc_h1045 = _source73.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2420___mcc_h1046 = _source73.dtor_args;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2421___mcc_h1049 = _source73.dtor_dims;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2422___mcc_h1051 = _source73.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2423___mcc_h1052 = _source73.dtor_variant;
            bool _2424___mcc_h1053 = _source73.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2425___mcc_h1054 = _source73.dtor_contents;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Convert) {
            DAST._IExpression _2426___mcc_h1059 = _source73.dtor_value;
            DAST._IType _2427___mcc_h1060 = _source73.dtor_from;
            DAST._IType _2428___mcc_h1061 = _source73.dtor_typ;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2429___mcc_h1065 = _source73.dtor_elements;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2430___mcc_h1067 = _source73.dtor_elements;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_This) {
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Ite) {
            DAST._IExpression _2431___mcc_h1069 = _source73.dtor_cond;
            DAST._IExpression _2432___mcc_h1070 = _source73.dtor_thn;
            DAST._IExpression _2433___mcc_h1071 = _source73.dtor_els;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_UnOp) {
            DAST._IUnaryOp _2434___mcc_h1075 = _source73.dtor_unOp;
            DAST._IExpression _2435___mcc_h1076 = _source73.dtor_expr;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2436___mcc_h1079 = _source73.dtor_op;
            DAST._IExpression _2437___mcc_h1080 = _source73.dtor_left;
            DAST._IExpression _2438___mcc_h1081 = _source73.dtor_right;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Select) {
            DAST._IExpression _2439___mcc_h1085 = _source73.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2440___mcc_h1086 = _source73.dtor_field;
            bool _2441___mcc_h1087 = _source73.dtor_isConstant;
            bool _2442___mcc_h1088 = _source73.dtor_onDatatype;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_SelectFn) {
            DAST._IExpression _2443___mcc_h1093 = _source73.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2444___mcc_h1094 = _source73.dtor_field;
            bool _2445___mcc_h1095 = _source73.dtor_onDatatype;
            bool _2446___mcc_h1096 = _source73.dtor_isStatic;
            BigInteger _2447___mcc_h1097 = _source73.dtor_arity;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Index) {
            DAST._IExpression _2448___mcc_h1103 = _source73.dtor_expr;
            DAST._IExpression _2449___mcc_h1104 = _source73.dtor_idx;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_TupleSelect) {
            DAST._IExpression _2450___mcc_h1107 = _source73.dtor_expr;
            BigInteger _2451___mcc_h1108 = _source73.dtor_index;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Call) {
            DAST._IExpression _2452___mcc_h1111 = _source73.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2453___mcc_h1112 = _source73.dtor_name;
            Dafny.ISequence<DAST._IType> _2454___mcc_h1113 = _source73.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2455___mcc_h1114 = _source73.dtor_args;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2456___mcc_h1119 = _source73.dtor_params;
            DAST._IType _2457___mcc_h1120 = _source73.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2458___mcc_h1121 = _source73.dtor_body;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2459___mcc_h1125 = _source73.dtor_name;
            DAST._IType _2460___mcc_h1126 = _source73.dtor_typ;
            DAST._IExpression _2461___mcc_h1127 = _source73.dtor_value;
            DAST._IExpression _2462___mcc_h1128 = _source73.dtor_iifeBody;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_Apply) {
            DAST._IExpression _2463___mcc_h1133 = _source73.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2464___mcc_h1134 = _source73.dtor_args;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source73.is_TypeTest) {
            DAST._IExpression _2465___mcc_h1137 = _source73.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2466___mcc_h1138 = _source73.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2467___mcc_h1139 = _source73.dtor_variant;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _2468___mcc_h1143 = _source73.dtor_typ;
            {
              _2411_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2411_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_2400_name)), _2402_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2405_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source20.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2469___mcc_h157 = _source20.dtor_params;
        DAST._IType _2470___mcc_h158 = _source20.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2471___mcc_h159 = _source20.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2472_body = _2471___mcc_h159;
        DAST._IType _2473_retType = _2470___mcc_h158;
        Dafny.ISequence<DAST._IFormal> _2474_params = _2469___mcc_h157;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2475_paramNames;
          _2475_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2476_i;
          _2476_i = BigInteger.Zero;
          while ((_2476_i) < (new BigInteger((_2474_params).Count))) {
            _2475_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2475_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2474_params).Select(_2476_i)).dtor_name));
            _2476_i = (_2476_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2477_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2478_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1520;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1521;
          DCOMP.COMP.GenStmts(_2472_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2475_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1520, out _out1521);
          _2477_recursiveGen = _out1520;
          _2478_recIdents = _out1521;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2479_allReadCloned;
          _2479_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2478_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2480_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2478_recIdents).Elements) {
              _2480_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2478_recIdents).Contains(_2480_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1627)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2475_paramNames).Contains(_2480_next))) {
              _2479_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2479_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2480_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2480_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2480_next));
            }
            _2478_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2478_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2480_next));
          }
          Dafny.ISequence<Dafny.Rune> _2481_paramsString;
          _2481_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2476_i = BigInteger.Zero;
          while ((_2476_i) < (new BigInteger((_2474_params).Count))) {
            if ((_2476_i).Sign == 1) {
              _2481_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2481_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2482_typStr;
            Dafny.ISequence<Dafny.Rune> _out1522;
            _out1522 = DCOMP.COMP.GenType(((_2474_params).Select(_2476_i)).dtor_typ, false, true);
            _2482_typStr = _out1522;
            _2481_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2481_paramsString, ((_2474_params).Select(_2476_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2482_typStr);
            _2476_i = (_2476_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2483_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1523;
          _out1523 = DCOMP.COMP.GenType(_2473_retType, false, true);
          _2483_retTypeGen = _out1523;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _2479_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _2481_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2483_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2477_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2484___mcc_h160 = _source20.dtor_name;
        DAST._IType _2485___mcc_h161 = _source20.dtor_typ;
        DAST._IExpression _2486___mcc_h162 = _source20.dtor_value;
        DAST._IExpression _2487___mcc_h163 = _source20.dtor_iifeBody;
        DAST._IExpression _2488_iifeBody = _2487___mcc_h163;
        DAST._IExpression _2489_value = _2486___mcc_h162;
        DAST._IType _2490_tpe = _2485___mcc_h161;
        Dafny.ISequence<Dafny.Rune> _2491_name = _2484___mcc_h160;
        {
          Dafny.ISequence<Dafny.Rune> _2492_valueGen;
          bool _2493_valueOwned;
          bool _2494_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2495_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1524;
          bool _out1525;
          bool _out1526;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1527;
          DCOMP.COMP.GenExpr(_2489_value, selfIdent, @params, false, out _out1524, out _out1525, out _out1526, out _out1527);
          _2492_valueGen = _out1524;
          _2493_valueOwned = _out1525;
          _2494_valueErased = _out1526;
          _2495_recIdents = _out1527;
          if (_2494_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2496_eraseFn;
            _2496_eraseFn = ((_2493_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2492_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2496_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2492_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2495_recIdents;
          Dafny.ISequence<Dafny.Rune> _2497_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1528;
          _out1528 = DCOMP.COMP.GenType(_2490_tpe, false, true);
          _2497_valueTypeGen = _out1528;
          Dafny.ISequence<Dafny.Rune> _2498_bodyGen;
          bool _2499_bodyOwned;
          bool _2500_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2501_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1529;
          bool _out1530;
          bool _out1531;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1532;
          DCOMP.COMP.GenExpr(_2488_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2493_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2491_name))))), mustOwn, out _out1529, out _out1530, out _out1531, out _out1532);
          _2498_bodyGen = _out1529;
          _2499_bodyOwned = _out1530;
          _2500_bodyErased = _out1531;
          _2501_bodyIdents = _out1532;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2501_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _2502_eraseFn;
          _2502_eraseFn = ((_2493_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2491_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2493_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2497_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2492_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2498_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2499_bodyOwned;
          isErased = _2500_bodyErased;
        }
      } else if (_source20.is_Apply) {
        DAST._IExpression _2503___mcc_h164 = _source20.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2504___mcc_h165 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2505_args = _2504___mcc_h165;
        DAST._IExpression _2506_func = _2503___mcc_h164;
        {
          Dafny.ISequence<Dafny.Rune> _2507_funcString;
          bool _2508___v80;
          bool _2509_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2510_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1533;
          bool _out1534;
          bool _out1535;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1536;
          DCOMP.COMP.GenExpr(_2506_func, selfIdent, @params, false, out _out1533, out _out1534, out _out1535, out _out1536);
          _2507_funcString = _out1533;
          _2508___v80 = _out1534;
          _2509_funcErased = _out1535;
          _2510_recIdents = _out1536;
          readIdents = _2510_recIdents;
          Dafny.ISequence<Dafny.Rune> _2511_argString;
          _2511_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2512_i;
          _2512_i = BigInteger.Zero;
          while ((_2512_i) < (new BigInteger((_2505_args).Count))) {
            if ((_2512_i).Sign == 1) {
              _2511_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2511_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2513_argExpr;
            bool _2514_isOwned;
            bool _2515_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2516_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1537;
            bool _out1538;
            bool _out1539;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1540;
            DCOMP.COMP.GenExpr((_2505_args).Select(_2512_i), selfIdent, @params, false, out _out1537, out _out1538, out _out1539, out _out1540);
            _2513_argExpr = _out1537;
            _2514_isOwned = _out1538;
            _2515_argErased = _out1539;
            _2516_argIdents = _out1540;
            if (_2514_isOwned) {
              _2513_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2513_argExpr);
            }
            _2511_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2511_argString, _2513_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2516_argIdents);
            _2512_i = (_2512_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2507_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2511_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source20.is_TypeTest) {
        DAST._IExpression _2517___mcc_h166 = _source20.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2518___mcc_h167 = _source20.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2519___mcc_h168 = _source20.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2520_variant = _2519___mcc_h168;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2521_dType = _2518___mcc_h167;
        DAST._IExpression _2522_on = _2517___mcc_h166;
        {
          Dafny.ISequence<Dafny.Rune> _2523_exprGen;
          bool _2524___v81;
          bool _2525_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2526_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1541;
          bool _out1542;
          bool _out1543;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1544;
          DCOMP.COMP.GenExpr(_2522_on, selfIdent, @params, false, out _out1541, out _out1542, out _out1543, out _out1544);
          _2523_exprGen = _out1541;
          _2524___v81 = _out1542;
          _2525_exprErased = _out1543;
          _2526_recIdents = _out1544;
          Dafny.ISequence<Dafny.Rune> _2527_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1545;
          _out1545 = DCOMP.COMP.GenPath(_2521_dType);
          _2527_dTypePath = _out1545;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2523_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2527_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2520_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2526_recIdents;
        }
      } else {
        DAST._IType _2528___mcc_h169 = _source20.dtor_typ;
        DAST._IType _2529_typ = _2528___mcc_h169;
        {
          Dafny.ISequence<Dafny.Rune> _2530_typString;
          Dafny.ISequence<Dafny.Rune> _out1546;
          _out1546 = DCOMP.COMP.GenType(_2529_typ, false, false);
          _2530_typString = _out1546;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2530_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2531_i;
      _2531_i = BigInteger.Zero;
      while ((_2531_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2532_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1547;
        _out1547 = DCOMP.COMP.GenModule((p).Select(_2531_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2532_generated = _out1547;
        if ((_2531_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2532_generated);
        _2531_i = (_2531_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2533_i;
      _2533_i = BigInteger.Zero;
      while ((_2533_i) < (new BigInteger((fullName).Count))) {
        if ((_2533_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2533_i));
        _2533_i = (_2533_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

