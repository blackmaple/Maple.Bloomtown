﻿using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.Bloomtown.GameModel.Demo
{

    /// <summary>
    /// class ["Assembly-CSharp".""."Armor"]
    /// [Equipment]=>[Sellable]=>[Stackable]=>[Descriptable]=>[UnityEngine.ScriptableObject]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x020003DBU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [65, 114, 109, 111, 114])]
    public partial class Armor
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "Armor";
        //public static byte[] Static_ClassName { get; } = [65, 114, 109, 111, 114];

        //public const uint Const_TypeToken = 0x020003DBU;




        public readonly unsafe partial struct Const_Armor
        {



            /// <summary>
            /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
            /// </summary>
            /// public nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";


            /// <summary>
            /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
            /// </summary>
            /// public nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";

        }


        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Static_Armor
        {



            /// const string Name_Field_OffsetOfInstanceIDInCPlusPlusObject = "OffsetOfInstanceIDInCPlusPlusObject";
            /// <summary>
            /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        }


        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_Armor
        {


            /// <summary>
            /// REF_MONO_OBJECT._vtable
            /// </summary>
            [MarshalAs(UnmanagedType.SysInt)]
            [FieldOffset(0)]
            public readonly nint _vtable;

            /// <summary>
            /// REF_MONO_OBJECT._synchronisation
            /// </summary>
            [MarshalAs(UnmanagedType.SysInt)]
            [FieldOffset(8)]
            public readonly nint _synchronisation;



            /// const string Name_Field_m_CachedPtr = "m_CachedPtr";
            /// <summary>
            /// struct 0x10 System.IntPtr m_CachedPtr
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly System.IntPtr m_CachedPtr;


            /// const string Name_Field_uid = "uid";
            /// <summary>
            /// class 0x18 System.String uid
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            [MonoCollectorProperty(PropertyName = "UID")]
            public readonly PMonoString uid;


            /// const string Name_Field_itemName = "itemName";
            /// <summary>
            /// class 0x20 LocalizationManager.LocalizedField itemName
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            [MonoCollectorProperty(PropertyName = "ItemName")]
            public readonly LocalizedField.Ptr_LocalizedField itemName;


            /// const string Name_Field_description = "description";
            /// <summary>
            /// class 0x28 LocalizationManager.LocalizedField description
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            [MonoCollectorProperty(PropertyName = "Description")]
            public readonly LocalizedField.Ptr_LocalizedField description;


            /// const string Name_Field_smallIcon = "smallIcon";
            /// <summary>
            /// class 0x30 UnityEngine.Sprite smallIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            [MonoCollectorProperty(PropertyName = "SmallIcon")]
            public readonly Sprite.Ptr_Sprite smallIcon;


            /// const string Name_Field_price = "price";
            /// <summary>
            /// struct 0x38 System.Single price
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            [MonoCollectorProperty(PropertyName = "Price")]
            public readonly System.Single price;


            /// const string Name_Field_howToObtain = "howToObtain";
            /// <summary>
            /// class 0x40 System.String howToObtain
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly nint howToObtain;


            /// const string Name_Field_m_passive = "m_passive";
            /// <summary>
            /// class 0x48 PassiveEffect m_passive
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly nint m_passive;


            /// const string Name_Field_tier = "tier";
            /// <summary>
            /// struct 0x50 System.Int32 tier
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly System.Int32 tier;


            /// const string Name_Field_countEquipped = "countEquipped";
            /// <summary>
            /// struct 0x54 System.Int32 countEquipped
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x54)]
            public readonly System.Int32 countEquipped;


            /// const string Name_Field_type = "type";
            /// <summary>
            /// enum 0x58 Armor.Type type
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            public readonly Armor.Type type;


            /// const string Name_Field_defense = "defense";
            /// <summary>
            /// struct 0x5C System.Int32 defense
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x5C)]
            [MonoCollectorProperty(PropertyName = "Defense")]
            public readonly System.Int32 defense;


            /// const string Name_Field_evasion = "evasion";
            /// <summary>
            /// struct 0x60 System.Int32 evasion
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            [MonoCollectorProperty(PropertyName = "Evasion")]
            public readonly System.Int32 evasion;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Armor(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Armor(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Armor obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_Armor AsRef()
            {
                return ref Unsafe.AsRef<Ref_Armor>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."Armor"]
    /// </summary>
    public partial class Armor
    {



        /// const string Name_Func_.CCTOR = ".cctor";
        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void .CCTOR ();


        /// const string Name_Func_CAN_TAKE = "CanTake";
        /// <summary>
        ///   System.Boolean CanTake(System.Int32 amount)
        /// </summary>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CAN_TAKE (System.Int32 amount);


        /// const string Name_Func_CHECK_NULL_ARGUMENT = "CheckNullArgument";
        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg,System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void CHECK_NULL_ARGUMENT (nint arg,nint message);


        /// const string Name_Func_CLAMP_CELL_PRICE = "ClampCellPrice";
        /// <summary>
        ///   System.Single ClampCellPrice(System.Single priceVal)
        /// </summary>
        /// <param name="priceVal">struct System.Single</param>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single CLAMP_CELL_PRICE (System.Single priceVal);


        /// const string Name_Func_CLAMP_PRICE = "ClampPrice";
        /// <summary>
        ///   System.Single ClampPrice(System.Single priceVal)
        /// </summary>
        /// <param name="priceVal">struct System.Single</param>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single CLAMP_PRICE (System.Single priceVal);


        /// const string Name_Func_COMPARE_BASE_OBJECTS = "CompareBaseObjects";
        /// <summary>
        /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs,UnityEngine.Object rhs)
        /// </summary>
        /// <param name="lhs">class UnityEngine.Object</param>
        /// <param name="rhs">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs,nint rhs);


        /// const string Name_Func_CREATE_SCRIPTABLE_OBJECT = "CreateScriptableObject";
        /// <summary>
        /// static  System.Void CreateScriptableObject(UnityEngine.ScriptableObject self)
        /// </summary>
        /// <param name="self">class UnityEngine.ScriptableObject</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void CREATE_SCRIPTABLE_OBJECT (nint self);


        /// const string Name_Func_CREATE_SCRIPTABLE_OBJECT_INSTANCE_FROM_TYPE = "CreateScriptableObjectInstanceFromType";
        /// <summary>
        /// static  UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type,System.Boolean applyDefaultsAndReset)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="applyDefaultsAndReset">struct System.Boolean</param>
        /// <returns>class UnityEngine.ScriptableObject</returns>
        /// public static extern nint CREATE_SCRIPTABLE_OBJECT_INSTANCE_FROM_TYPE (nint type,System.Boolean applyDefaultsAndReset);


        /// const string Name_Func_DESERIALIZE = "Deserialize";
        /// <summary>
        ///   System.Void Deserialize(System.String data)
        /// </summary>
        /// <param name="data">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DESERIALIZE (nint data);


        /// const string Name_Func_DONT_DESTROY_ON_LOAD = "DontDestroyOnLoad";
        /// <summary>
        /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
        /// </summary>
        /// <param name="target">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DONT_DESTROY_ON_LOAD (nint target);


        /// const string Name_Func_EQUALS = "Equals";
        /// <summary>
        ///   System.Boolean Equals(System.Object other)
        /// </summary>
        /// <param name="other">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean EQUALS (nint other);


        /// const string Name_Func_FIND_OBJECT_FROM_INSTANCE_ID = "FindObjectFromInstanceID";
        /// <summary>
        /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FIND_OBJECT_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// const string Name_Func_FORCE_LOAD_FROM_INSTANCE_ID = "ForceLoadFromInstanceID";
        /// <summary>
        /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FORCE_LOAD_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// const string Name_Func_GET_CELL_MODIFIER = "get_cellModifier";
        /// <summary>
        ///   System.Single get_cellModifier()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_CELL_MODIFIER ();


        /// const string Name_Func_GET_COUNT = "get_count";
        /// <summary>
        ///   System.Int32 get_count()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_COUNT ();


        /// const string Name_Func_GET_GET_STAT3 = "get_getStat3";
        /// <summary>
        ///   System.Int32 get_getStat3()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_GET_STAT3 ();


        /// const string Name_Func_GET_GET_STAT3_NAME = "get_getStat3Name";
        /// <summary>
        ///   System.String get_getStat3Name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_GET_STAT3_NAME ();


        /// const string Name_Func_GET_GET_UID = "get_getUID";
        /// <summary>
        ///   System.String get_getUID()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_GET_UID ();


        /// const string Name_Func_GET_HIDE_FLAGS = "get_hideFlags";
        /// <summary>
        ///   UnityEngine.HideFlags get_hideFlags()
        /// </summary>
        /// <returns>enum UnityEngine.HideFlags</returns>
        /// public  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();


        /// const string Name_Func_GET_NAME = "get_name";
        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_NAME ();


        const string Name_Func_GET_PASSIVE = "get_passive";
        /// <summary>
        ///   PassiveEffect get_passive()
        /// </summary>
        /// <returns>class PassiveEffect</returns>
        [MonoCollectorMethod(Name_Func_GET_PASSIVE)]
        extern PassiveEffect.Ptr_PassiveEffect GET_PASSIVE();


        /// const string Name_Func_GET_SELLABLE_COUNT = "get_sellableCount";
        /// <summary>
        ///   System.Int32 get_sellableCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_SELLABLE_COUNT ();


        /// const string Name_Func_GET_BUY_PRICE = "GetBuyPrice";
        /// <summary>
        ///   System.Single GetBuyPrice()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_BUY_PRICE ();


        /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_CACHED_PTR ();


        /// const string Name_Func_GET_CELL_PRICE = "GetCellPrice";
        /// <summary>
        ///   System.Single GetCellPrice()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_CELL_PRICE ();


        /// const string Name_Func_GET_DESCRIPTION = "GetDescription";
        /// <summary>
        ///   System.String GetDescription()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_DESCRIPTION ();


        /// const string Name_Func_GET_DESCRIPTION_FIELD = "GetDescriptionField";
        /// <summary>
        ///   LocalizationManager.LocalizedField GetDescriptionField()
        /// </summary>
        /// <returns>class LocalizationManager.LocalizedField</returns>
        /// public  extern nint GET_DESCRIPTION_FIELD ();


        /// const string Name_Func_GET_HASH_CODE = "GetHashCode";
        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_HASH_CODE ();


        /// const string Name_Func_GET_INSTANCE_ID = "GetInstanceID";
        /// <summary>
        ///   System.Int32 GetInstanceID()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_INSTANCE_ID ();


        /// const string Name_Func_GET_NAME_FIELD = "GetNameField";
        /// <summary>
        ///   LocalizationManager.LocalizedField GetNameField()
        /// </summary>
        /// <returns>class LocalizationManager.LocalizedField</returns>
        /// public  extern nint GET_NAME_FIELD ();


        /// const string Name_Func_GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT = "GetOffsetOfInstanceIDInCPlusPlusObject";
        /// <summary>
        /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();


        /// const string Name_Func_INTERNAL_CLONE_SINGLE = "Internal_CloneSingle";
        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_CLONE_SINGLE (nint data);


        /// const string Name_Func_INTERNAL_CLONE_SINGLE_WITH_PARENT = "Internal_CloneSingleWithParent";
        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data,UnityEngine.Transform parent,System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_CLONE_SINGLE_WITH_PARENT (nint data,nint parent,System.Boolean worldPositionStays);


        /// const string Name_Func_INTERNAL_INSTANTIATE_SINGLE = "Internal_InstantiateSingle";
        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data,UnityEngine.Vector3 pos,UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_INSTANTIATE_SINGLE (nint data,UnityEngine.Vector3 pos,UnityEngine.Quaternion rot);


        /// const string Name_Func_INTERNAL_INSTANTIATE_SINGLE_INJECTED = "Internal_InstantiateSingle_Injected";
        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data,UnityEngine.Vector3& pos,UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_INSTANTIATE_SINGLE_INJECTED (nint data,UnityEngine.Vector3& pos,UnityEngine.Quaternion& rot);


        /// const string Name_Func_INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT = "Internal_InstantiateSingleWithParent";
        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data,UnityEngine.Transform parent,UnityEngine.Vector3 pos,UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT (nint data,nint parent,UnityEngine.Vector3 pos,UnityEngine.Quaternion rot);


        /// const string Name_Func_INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED = "Internal_InstantiateSingleWithParent_Injected";
        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data,UnityEngine.Transform parent,UnityEngine.Vector3& pos,UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED (nint data,nint parent,UnityEngine.Vector3& pos,UnityEngine.Quaternion& rot);


        /// const string Name_Func_IS_NATIVE_OBJECT_ALIVE = "IsNativeObjectAlive";
        /// <summary>
        /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
        /// </summary>
        /// <param name="o">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);


        /// const string Name_Func_OP_EQUALITY = "op_Equality";
        /// <summary>
        /// static  System.Boolean op_Equality(UnityEngine.Object x,UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean OP_EQUALITY (nint x,nint y);


        /// const string Name_Func_OP_IMPLICIT = "op_Implicit";
        /// <summary>
        /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
        /// </summary>
        /// <param name="exists">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean OP_IMPLICIT (nint exists);


        /// const string Name_Func_OP_INEQUALITY = "op_Inequality";
        /// <summary>
        /// static  System.Boolean op_Inequality(UnityEngine.Object x,UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean OP_INEQUALITY (nint x,nint y);


        /// const string Name_Func_SERIALIZE = "Serialize";
        /// <summary>
        ///   System.String Serialize()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint SERIALIZE ();


        /// const string Name_Func_SET_COUNT = "set_count";
        /// <summary>
        ///   System.Void set_count(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COUNT (System.Int32 value);


        /// const string Name_Func_SET_HIDE_FLAGS = "set_hideFlags";
        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);


        /// const string Name_Func_SET_NAME = "set_name";
        /// <summary>
        ///   System.Void set_name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_NAME (nint value);


        /// const string Name_Func_SET_COUNT = "SetCount";
        /// <summary>
        ///   System.Void SetCount(System.Int32 amount)
        /// </summary>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_COUNT (System.Int32 amount);


        /// const string Name_Func_SET_NAME = "SetName";
        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_NAME (nint obj,nint name);


        /// const string Name_Func_SHOULD_BE_HIGHLIGHTED = "ShouldBeHighlighted";
        /// <summary>
        ///   System.Boolean ShouldBeHighlighted()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean SHOULD_BE_HIGHLIGHTED ();


        /// const string Name_Func_TAKE = "Take";
        /// <summary>
        ///   System.Void Take(System.Int32 amount)
        /// </summary>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void TAKE (System.Int32 amount);



        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_00 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_01 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_02 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_03 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_04 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_05 ();


        /// const string Name_Func_.CTOR = ".ctor";
        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void .CTOR_06 ();


        /// const string Name_Func_ADD = "Add";
        /// <summary>
        ///   System.Void Add(System.Int32 amount)
        /// </summary>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_00 (System.Int32 amount);


        /// const string Name_Func_ADD = "Add";
        /// <summary>
        ///   System.Void Add(System.Int32 amount)
        /// </summary>
        /// <param name="amount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_01 (System.Int32 amount);


        /// const string Name_Func_CAN_EQUIP = "CanEquip";
        /// <summary>
        ///   System.Boolean CanEquip(Character character)
        /// </summary>
        /// <param name="character">class Character</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CAN_EQUIP_00 (nint character);


        /// const string Name_Func_CAN_EQUIP = "CanEquip";
        /// <summary>
        ///  abstract System.Boolean CanEquip(Character character)
        /// </summary>
        /// <param name="character">class Character</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CAN_EQUIP_01 (nint character);


        /// const string Name_Func_CREATE_INSTANCE = "CreateInstance";
        /// <summary>
        /// static  UnityEngine.ScriptableObject CreateInstance(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.ScriptableObject</returns>
        /// public static extern nint CREATE_INSTANCE_00 (nint type);


        /// const string Name_Func_CREATE_INSTANCE = "CreateInstance";
        /// <summary>
        /// static  T CreateInstance()
        /// </summary>
        /// <returns>class T</returns>
        /// public static extern nint CREATE_INSTANCE_01 ();


        /// const string Name_Func_DESTROY = "Destroy";
        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj,System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_00 (nint obj,System.Single t);


        /// const string Name_Func_DESTROY = "Destroy";
        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_01 (nint obj);


        /// const string Name_Func_DESTROY_IMMEDIATE = "DestroyImmediate";
        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj,System.Boolean allowDestroyingAssets)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="allowDestroyingAssets">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_IMMEDIATE_00 (nint obj,System.Boolean allowDestroyingAssets);


        /// const string Name_Func_DESTROY_IMMEDIATE = "DestroyImmediate";
        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void DESTROY_IMMEDIATE_01 (nint obj);


        /// const string Name_Func_FIND_OBJECT_OF_TYPE = "FindObjectOfType";
        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// <returns>class T</returns>
        /// public static extern nint FIND_OBJECT_OF_TYPE_00 ();


        /// const string Name_Func_FIND_OBJECT_OF_TYPE = "FindObjectOfType";
        /// <summary>
        /// static  T FindObjectOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// public static extern nint FIND_OBJECT_OF_TYPE_01 (System.Boolean includeInactive);


        /// const string Name_Func_FIND_OBJECT_OF_TYPE = "FindObjectOfType";
        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type,System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint FIND_OBJECT_OF_TYPE_02 (nint type,System.Boolean includeInactive);


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE = "FindObjectsOfType";
        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE = "FindObjectsOfType";
        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type,System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type,System.Boolean includeInactive);


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE = "FindObjectsOfType";
        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// <returns>class T[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_02 ();


        /// const string Name_Func_FIND_OBJECTS_OF_TYPE = "FindObjectsOfType";
        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// public static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);

        const string Name_Func_GET_GET_STAT1 = "get_getStat1";
        /// <summary>
        ///   System.Int32 get_getStat1()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [MonoCollectorMethod(Name_Func_GET_GET_STAT1)]
        extern System.Int32 GET_STAT1();


        const string Name_Func_GET_GET_STAT1_NAME = "get_getStat1Name";
        /// <summary>
        ///   System.String get_getStat1Name()
        /// </summary>
        /// <returns>class System.String</returns>
        [MonoCollectorMethod(Name_Func_GET_GET_STAT1_NAME)]
        extern PMonoString GET_STAT1_NAME();


        const string Name_Func_GET_GET_STAT2 = "get_getStat2";
        /// <summary>
        ///   System.Int32 get_getStat2()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [MonoCollectorMethod(Name_Func_GET_GET_STAT2)]
        extern System.Int32 GET_STAT2();


        const string Name_Func_GET_GET_STAT2_NAME = "get_getStat2Name";
        /// <summary>
        ///   System.String get_getStat2Name()
        /// </summary>
        /// <returns>class System.String</returns>
        [MonoCollectorMethod(Name_Func_GET_GET_STAT2_NAME)]
        extern PMonoString GET_STAT2_NAME();


        const string Name_Func_GET_GET_STAT3 = "get_getStat3";
        /// <summary>
        ///   System.Int32 get_getStat3()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [MonoCollectorMethod(Name_Func_GET_GET_STAT3)]
        extern System.Int32 GET_STAT3();


        const string Name_Func_GET_GET_STAT3_NAME = "get_getStat3Name";
        /// <summary>
        ///   System.String get_getStat3Name()
        /// </summary>
        /// <returns>class System.String</returns>
        [MonoCollectorMethod(Name_Func_GET_GET_STAT3_NAME)]
        extern PMonoString GET_STAT3_NAME();


        /// const string Name_Func_GET_GET_STAT1 = "get_getStat1";
        /// <summary>
        ///   System.Int32 get_getStat1()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_GET_STAT1_00 ();


        /// const string Name_Func_GET_GET_STAT1 = "get_getStat1";
        /// <summary>
        ///   System.Int32 get_getStat1()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_GET_STAT1_01 ();


        /// const string Name_Func_GET_GET_STAT1_NAME = "get_getStat1Name";
        /// <summary>
        ///   System.String get_getStat1Name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_GET_STAT1_NAME_00 ();


        /// const string Name_Func_GET_GET_STAT1_NAME = "get_getStat1Name";
        /// <summary>
        ///   System.String get_getStat1Name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_GET_STAT1_NAME_01 ();


        /// const string Name_Func_GET_GET_STAT2 = "get_getStat2";
        /// <summary>
        ///   System.Int32 get_getStat2()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_GET_STAT2_00 ();


        /// const string Name_Func_GET_GET_STAT2 = "get_getStat2";
        /// <summary>
        ///   System.Int32 get_getStat2()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_GET_STAT2_01 ();


        /// const string Name_Func_GET_GET_STAT2_NAME = "get_getStat2Name";
        /// <summary>
        ///   System.String get_getStat2Name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_GET_STAT2_NAME_00 ();


        /// const string Name_Func_GET_GET_STAT2_NAME = "get_getStat2Name";
        /// <summary>
        ///   System.String get_getStat2Name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_GET_STAT2_NAME_01 ();


        /// const string Name_Func_GET_IS_SOOTY = "get_isSooty";
        /// <summary>
        ///   System.Boolean get_isSooty()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_SOOTY_00 ();


        /// const string Name_Func_GET_IS_SOOTY = "get_isSooty";
        /// <summary>
        ///   System.Boolean get_isSooty()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_IS_SOOTY_01 ();


        /// const string Name_Func_GET_RESOURCES_PATH = "get_ResourcesPath";
        /// <summary>
        ///   System.String get_ResourcesPath()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_RESOURCES_PATH_00 ();


        /// const string Name_Func_GET_RESOURCES_PATH = "get_ResourcesPath";
        /// <summary>
        ///  abstract System.String get_ResourcesPath()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_RESOURCES_PATH_01 ();


        /// const string Name_Func_GET_SLOT = "get_slot";
        /// <summary>
        ///   Equipment.Slot get_slot()
        /// </summary>
        /// <returns>enum Equipment.Slot</returns>
        /// public  extern Equipment.Slot GET_SLOT_00 ();


        /// const string Name_Func_GET_SLOT = "get_slot";
        /// <summary>
        ///  abstract Equipment.Slot get_slot()
        /// </summary>
        /// <returns>enum Equipment.Slot</returns>
        /// public  extern Equipment.Slot GET_SLOT_01 ();


        /// const string Name_Func_GET_COUNT_IN_INVENTORY = "GetCountInInventory";
        /// <summary>
        ///   System.Int32 GetCountInInventory()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_COUNT_IN_INVENTORY_00 ();


        /// const string Name_Func_GET_COUNT_IN_INVENTORY = "GetCountInInventory";
        /// <summary>
        ///   System.Int32 GetCountInInventory()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_COUNT_IN_INVENTORY_01 ();


        const string Name_Func_GET_ICON = "GetIcon";
        /// <summary>
        ///   UnityEngine.Sprite GetIcon()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        [MonoCollectorMethod(Name_Func_GET_ICON)]
        extern Sprite.Ptr_Sprite GET_ICON_00();


        /// const string Name_Func_GET_ICON = "GetIcon";
        /// <summary>
        ///  abstract UnityEngine.Sprite GetIcon()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// public  extern nint GET_ICON_01 ();


        /// const string Name_Func_GET_NAME = "GetName";
        /// <summary>
        ///   System.String GetName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_NAME_00 ();


        /// const string Name_Func_GET_NAME = "GetName";
        /// <summary>
        /// static  System.String GetName(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// public static extern nint GET_NAME_01 (nint obj);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INSTANTIATE_00 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INSTANTIATE_01 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,nint parent);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INSTANTIATE_02 (nint original);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original,UnityEngine.Transform parent,System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// public static extern nint INSTANTIATE_03 (nint original,nint parent,System.Boolean instantiateInWorldSpace);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// <param name="original">class T</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_04 (nint original);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_05 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_06 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,nint parent);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original,UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_07 (nint original,nint parent);


        /// const string Name_Func_INSTANTIATE = "Instantiate";
        /// <summary>
        /// static  T Instantiate(T original,UnityEngine.Transform parent,System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// public static extern nint INSTANTIATE_08 (nint original,nint parent,System.Boolean worldPositionStays);


        /// const string Name_Func_PARSE = "Parse";
        /// <summary>
        ///   System.Void Parse(System.Collections.Generic.Dictionary<System.String,System.Object> row)
        /// </summary>
        /// <param name="row">class System.Collections.Generic.Dictionary<System.String,System.Object></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void PARSE_00 (nint row);


        /// const string Name_Func_PARSE = "Parse";
        /// <summary>
        /// static  System.Void Parse(System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>> table,System.String sheetName)
        /// </summary>
        /// <param name="table">class System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>></param>
        /// <param name="sheetName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void PARSE_01 (nint table,nint sheetName);


        /// const string Name_Func_PARSE = "Parse";
        /// <summary>
        ///   System.Void Parse(System.Collections.Generic.Dictionary<System.String,System.Object> row)
        /// </summary>
        /// <param name="row">class System.Collections.Generic.Dictionary<System.String,System.Object></param>
        /// <returns>struct System.Void</returns>
        /// public  extern void PARSE_02 (nint row);


        /// const string Name_Func_TO_STRING = "ToString";
        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint TO_STRING_00 ();


        /// const string Name_Func_TO_STRING = "ToString";
        /// <summary>
        /// static  System.String ToString(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// public static extern nint TO_STRING_01 (nint obj);


        public static partial class Search_Armor
        {
            /// 
            ///     

            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// public static bool .CTOR_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Add(System.Int32 amount)
            /// </summary>
            /// public static bool ADD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Add(System.Int32 amount)
            /// </summary>
            /// public static bool ADD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean CanEquip(Character character)
            /// </summary>
            /// public static bool CAN_EQUIP_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanEquip", "Character");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract System.Boolean CanEquip(Character character)
            /// </summary>
            /// public static bool CAN_EQUIP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanEquip", "Character");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.ScriptableObject CreateInstance(System.Type type)
            /// </summary>
            /// public static bool CREATE_INSTANCE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateInstance", "System.Type");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T CreateInstance()
            /// </summary>
            /// public static bool CREATE_INSTANCE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateInstance");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// public static bool DESTROY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// public static bool DESTROY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// public static bool DESTROY_IMMEDIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// public static bool DESTROY_IMMEDIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T FindObjectOfType()
            /// </summary>
            /// public static bool FIND_OBJECT_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T FindObjectOfType(System.Boolean includeInactive)
            /// </summary>
            /// public static bool FIND_OBJECT_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// public static bool FIND_OBJECT_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// public static bool FIND_OBJECTS_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// public static bool FIND_OBJECTS_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T[] FindObjectsOfType()
            /// </summary>
            /// public static bool FIND_OBJECTS_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
            /// </summary>
            /// public static bool FIND_OBJECTS_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 get_getStat1()
            /// </summary>
            /// public static bool GET_GET_STAT1_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_getStat1");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 get_getStat1()
            /// </summary>
            /// public static bool GET_GET_STAT1_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_getStat1");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String get_getStat1Name()
            /// </summary>
            /// public static bool GET_GET_STAT1_NAME_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_getStat1Name");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String get_getStat1Name()
            /// </summary>
            /// public static bool GET_GET_STAT1_NAME_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_getStat1Name");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 get_getStat2()
            /// </summary>
            /// public static bool GET_GET_STAT2_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_getStat2");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 get_getStat2()
            /// </summary>
            /// public static bool GET_GET_STAT2_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_getStat2");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String get_getStat2Name()
            /// </summary>
            /// public static bool GET_GET_STAT2_NAME_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_getStat2Name");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String get_getStat2Name()
            /// </summary>
            /// public static bool GET_GET_STAT2_NAME_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_getStat2Name");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean get_isSooty()
            /// </summary>
            /// public static bool GET_IS_SOOTY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_isSooty");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean get_isSooty()
            /// </summary>
            /// public static bool GET_IS_SOOTY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_isSooty");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String get_ResourcesPath()
            /// </summary>
            /// public static bool GET_RESOURCES_PATH_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_ResourcesPath");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract System.String get_ResourcesPath()
            /// </summary>
            /// public static bool GET_RESOURCES_PATH_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_ResourcesPath");
            ///     
            ///  
            /// 


            /// <summary>
            ///   Equipment.Slot get_slot()
            /// </summary>
            /// public static bool GET_SLOT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_slot");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract Equipment.Slot get_slot()
            /// </summary>
            /// public static bool GET_SLOT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_slot");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 GetCountInInventory()
            /// </summary>
            /// public static bool GET_COUNT_IN_INVENTORY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetCountInInventory");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Int32 GetCountInInventory()
            /// </summary>
            /// public static bool GET_COUNT_IN_INVENTORY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetCountInInventory");
            ///     
            ///  
            /// 


            /// <summary>
            ///   UnityEngine.Sprite GetIcon()
            /// </summary>
            public static bool GET_ICON_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetIcon");
            ///     
            ///  
            /// 


            /// <summary>
            ///  abstract UnityEngine.Sprite GetIcon()
            /// </summary>
            /// public static bool GET_ICON_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetIcon");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String GetName()
            /// </summary>
            /// public static bool GET_NAME_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetName");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// public static bool GET_NAME_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetName", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// public static bool INSTANTIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// public static bool INSTANTIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// public static bool INSTANTIATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// public static bool INSTANTIATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// public static bool INSTANTIATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// public static bool INSTANTIATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// public static bool INSTANTIATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// public static bool INSTANTIATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// public static bool INSTANTIATE_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Parse(System.Collections.Generic.Dictionary<System.String,System.Object> row)
            /// </summary>
            /// public static bool PARSE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.Collections.Generic.Dictionary<System.String,System.Object>");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void Parse(System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>> table, System.String sheetName)
            /// </summary>
            /// public static bool PARSE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,System.Object>>", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Parse(System.Collections.Generic.Dictionary<System.String,System.Object> row)
            /// </summary>
            /// public static bool PARSE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Parse", "System.Collections.Generic.Dictionary<System.String,System.Object>");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// public static bool TO_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "UnityEngine.Object");
            ///     
            ///  
            /// 
            /// 
        }

        /// <summary>
        /// ["Assembly-CSharp".""."Type"]
        /// </summary>
        public enum Type : System.Int32
        {


            Male = 0x00000000,

            Female = 0x00000001,

            Unisex = 0x00000002,

            Dog = 0x00000003,

        }

    }

}
