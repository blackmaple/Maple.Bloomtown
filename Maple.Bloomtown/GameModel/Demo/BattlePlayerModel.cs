using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Bloomtown.GameModel.Demo
{

    /// <summary>
    /// class ["Assembly-CSharp".""."BattlePlayerModel"]
    /// [BattleParticipantModel]=>[UnityEngine.ScriptableObject]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000146U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [66, 97, 116, 116, 108, 101, 80, 108, 97, 121, 101, 114, 77, 111, 100, 101, 108])]
    public partial class BattlePlayerModel
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "BattlePlayerModel";
        //public static byte[] Static_ClassName { get; } = [66, 97, 116, 116, 108, 101, 80, 108, 97, 121, 101, 114, 77, 111, 100, 101, 108];

        //public const uint Const_TypeToken = 0x02000146U;




        public readonly unsafe partial struct Const_BattlePlayerModel
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
        public readonly unsafe partial struct Static_BattlePlayerModel
        {



            /// const string Name_Field_OffsetOfInstanceIDInCPlusPlusObject = "OffsetOfInstanceIDInCPlusPlusObject";
            /// <summary>
            /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        }


        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_BattlePlayerModel
        {


            /// <summary>
            /// REF_MONO_OBJECT._vtable
            /// </summary>
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public readonly nint _vtable;

            /// <summary>
            /// REF_MONO_OBJECT._synchronisation
            /// </summary>
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            [System.Runtime.InteropServices.FieldOffsetAttribute(8)]
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


            /// const string Name_Field_viewPrefab = "viewPrefab";
            /// <summary>
            /// abstract class 0x20 BattleParticipantView viewPrefab
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            [MonoCollectorProperty(PropertyName = "ViewPrefab")]
            public readonly BattlePlayerView.Ptr_BattlePlayerView viewPrefab;


            /// const string Name_Field_unitName = "unitName";
            /// <summary>
            /// class 0x28 LocalizationManager.LocalizedField unitName
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            [MonoCollectorProperty(PropertyName = "UnitName")]
            public readonly LocalizedField.Ptr_LocalizedField unitName;


            /// const string Name_Field_passiveEffects = "passiveEffects";
            /// <summary>
            /// class 0x30 System.Collections.Generic.List<PassiveEffect> passiveEffects
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            [MonoCollectorProperty(PropertyName = "PassiveEffects")]
            public readonly PMonoList_S<PassiveEffect.Ptr_PassiveEffect> passiveEffects;


            /// const string Name_Field_level = "level";
            /// <summary>
            /// struct 0x38 System.Int32 level
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            [MonoCollectorProperty(PropertyName = "Level")]
            public readonly System.Int32 level;


            /// const string Name_Field_rawStrength = "rawStrength";
            /// <summary>
            /// struct 0x3C System.Int32 rawStrength
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x3C)]
            [MonoCollectorProperty(PropertyName = "RawStrength")]
            public readonly System.Int32 rawStrength;


            /// const string Name_Field_rawMagic = "rawMagic";
            /// <summary>
            /// struct 0x40 System.Int32 rawMagic
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            [MonoCollectorProperty(PropertyName = "RawMagic")]
            public readonly System.Int32 rawMagic;


            /// const string Name_Field_rawEndurance = "rawEndurance";
            /// <summary>
            /// struct 0x44 System.Int32 rawEndurance
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x44)]
            [MonoCollectorProperty(PropertyName = "RawEndurance")]
            public readonly System.Int32 rawEndurance;


            /// const string Name_Field_rawAgility = "rawAgility";
            /// <summary>
            /// struct 0x48 System.Int32 rawAgility
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            [MonoCollectorProperty(PropertyName = "RawAgility")]
            public readonly System.Int32 rawAgility;


            /// const string Name_Field_rawLuck = "rawLuck";
            /// <summary>
            /// struct 0x4C System.Int32 rawLuck
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4C)]
            [MonoCollectorProperty(PropertyName = "RawLuck")]
            public readonly System.Int32 rawLuck;


            /// const string Name_Field_defaultWeapon = "defaultWeapon";
            /// <summary>
            /// class 0x50 MeleeWeapon defaultWeapon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            [MonoCollectorProperty(PropertyName = "DefaultWeapon")]
            public readonly MeleeWeapon.Ptr_MeleeWeapon defaultWeapon;


            /// const string Name_Field_defaultGun = "defaultGun";
            /// <summary>
            /// class 0x58 RangedWeapon defaultGun
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            [MonoCollectorProperty(PropertyName = "DefaultGun")]
            public readonly RangedWeapon.Ptr_RangedWeapon defaultGun;


            /// const string Name_Field_defaultArmor = "defaultArmor";
            /// <summary>
            /// class 0x60 Armor defaultArmor
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            [MonoCollectorProperty(PropertyName = "DefaultArmor")]
            public readonly Armor.Ptr_Armor defaultArmor;


            /// const string Name_Field_defaultPersona = "defaultPersona";
            /// <summary>
            /// class 0x68 BattleMonsterModel defaultPersona
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x68)]
            [MonoCollectorProperty(PropertyName = "DefaultPersona")]
            public readonly BattleMonsterModel.Ptr_BattleMonsterModel defaultPersona;


            /// const string Name_Field_personaProgress = "personaProgress";
            /// <summary>
            /// class 0x70 PersonaProgress personaProgress
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x70)]
            [MonoCollectorProperty(PropertyName = "PersonaProgress")]
            public readonly PersonaProgress.Ptr_PersonaProgress personaProgress;


            /// const string Name_Field_meleeWeapon = "meleeWeapon";
            /// <summary>
            /// class 0x78 MeleeWeapon meleeWeapon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x78)]
            [MonoCollectorProperty(PropertyName = "MeleeWeapon")]
            public readonly MeleeWeapon.Ptr_MeleeWeapon meleeWeapon;


            /// const string Name_Field_rangedWeapon = "rangedWeapon";
            /// <summary>
            /// class 0x80 RangedWeapon rangedWeapon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x80)]
            [MonoCollectorProperty(PropertyName = "RangedWeapon")]
            public readonly RangedWeapon.Ptr_RangedWeapon rangedWeapon;


            /// const string Name_Field_armor = "armor";
            /// <summary>
            /// class 0x88 Armor armor
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x88)]
            [MonoCollectorProperty(PropertyName = "Armor")]
            public readonly Armor.Ptr_Armor armor;


            /// const string Name_Field_accessory = "accessory";
            /// <summary>
            /// class 0x90 Accessory accessory
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x90)]
            [MonoCollectorProperty(PropertyName = "Accessory")]
            public readonly Accessory.Ptr_Accessory accessory;


            /// const string Name_Field_tactics = "tactics";
            /// <summary>
            /// enum 0x98 BattlePlayerModel.Tactics tactics
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x98)]
            public readonly BattlePlayerModel.Tactics tactics;


            /// const string Name_Field_strengthFromItems = "strengthFromItems";
            /// <summary>
            /// struct 0x9C System.Int32 strengthFromItems
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x9C)]
            [MonoCollectorProperty(PropertyName = "StrengthFromItems")]
            public readonly System.Int32 strengthFromItems;


            /// const string Name_Field_agilityFromItems = "agilityFromItems";
            /// <summary>
            /// struct 0xA0 System.Int32 agilityFromItems
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA0)]
            [MonoCollectorProperty(PropertyName = "AgilityFromItems")]
            public readonly System.Int32 agilityFromItems;


            /// const string Name_Field_startLvl = "startLvl";
            /// <summary>
            /// struct 0xA4 System.Int32 startLvl
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA4)]
            [MonoCollectorProperty(PropertyName = "StartLvl")]
            public readonly System.Int32 startLvl;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_BattlePlayerModel(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_BattlePlayerModel(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_BattlePlayerModel obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_BattlePlayerModel AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_BattlePlayerModel>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."BattlePlayerModel"]
    /// </summary>
    public partial class BattlePlayerModel
    {



        /// const string Name_Func_.CCTOR = ".cctor";
        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void .CCTOR ();


        /// const string Name_Func_ADD_PASSIVE_EFFECT = "AddPassiveEffect";
        /// <summary>
        ///   System.Void AddPassiveEffect(PassiveEffect effect)
        /// </summary>
        /// <param name="effect">class PassiveEffect</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_PASSIVE_EFFECT (nint effect);


        /// const string Name_Func_CHANGE_STAT = "ChangeStat";
        /// <summary>
        ///   System.Void ChangeStat(System.String statName,System.Int32 power)
        /// </summary>
        /// <param name="statName">class System.String</param>
        /// <param name="power">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void CHANGE_STAT (nint statName,System.Int32 power);


        /// const string Name_Func_CHECK_NULL_ARGUMENT = "CheckNullArgument";
        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg,System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void CHECK_NULL_ARGUMENT (nint arg,nint message);


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


        /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_CACHED_PTR ();


        /// const string Name_Func_GET_CHARACTER_INSTANCE = "GetCharacterInstance";
        /// <summary>
        ///   Character GetCharacterInstance()
        /// </summary>
        /// <returns>class Character</returns>
        /// public  extern nint GET_CHARACTER_INSTANCE ();


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


        const string Name_Func_GET_MAX_HP_FOR_LVL = "GetMaxHPForLvl";
        /// <summary>
        ///   System.Int32 GetMaxHPForLvl(System.Int32 lvl)
        /// </summary>
        /// <param name="lvl">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        [MonoCollectorMethod(Name_Func_GET_MAX_HP_FOR_LVL)]
        extern System.Int32 GET_MAX_HP_FOR_LVL(System.Int32 lvl);


        const string Name_Func_GET_MAX_SP_FOR_LVL = "GetMaxSPForLvl";
        /// <summary>
        ///   System.Int32 GetMaxSPForLvl(System.Int32 lvl)
        /// </summary>
        /// <param name="lvl">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        [MonoCollectorMethod(Name_Func_GET_MAX_SP_FOR_LVL)]
        extern System.Int32 GET_MAX_SP_FOR_LVL(System.Int32 lvl);


        /// const string Name_Func_GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT = "GetOffsetOfInstanceIDInCPlusPlusObject";
        /// <summary>
        /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();


        /// const string Name_Func_INIT = "Init";
        /// <summary>
        ///   System.Void Init()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void INIT ();


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


        /// const string Name_Func_IS_MAIN_PERSONA = "IsMainPersona";
        /// <summary>
        ///   System.Boolean IsMainPersona(PersonaProgress persona)
        /// </summary>
        /// <param name="persona">class PersonaProgress</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_MAIN_PERSONA (nint persona);


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


        /// const string Name_Func_REMOVE_PASSIVE_EFFECT = "RemovePassiveEffect";
        /// <summary>
        ///   System.Void RemovePassiveEffect(PassiveEffect effect)
        /// </summary>
        /// <param name="effect">class PassiveEffect</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REMOVE_PASSIVE_EFFECT (nint effect);


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


        /// const string Name_Func_SET_LEVEL = "SetLevel";
        /// <summary>
        ///   System.Void SetLevel(System.Int32 lvl)
        /// </summary>
        /// <param name="lvl">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_LEVEL (System.Int32 lvl);


        /// const string Name_Func_SET_NAME = "SetName";
        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_NAME (nint obj,nint name);


        /// const string Name_Func_UNEQUIP = "Unequip";
        /// <summary>
        ///   System.Void Unequip(Equipment equipment)
        /// </summary>
        /// <param name="equipment">abstract class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void UNEQUIP (nint equipment);


        /// const string Name_Func_UNEQUIP_ACCESSORY = "UnequipAccessory";
        /// <summary>
        ///   System.Void UnequipAccessory()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void UNEQUIP_ACCESSORY ();


        /// const string Name_Func_UNEQUIP_ARMOR = "UnequipArmor";
        /// <summary>
        ///   System.Void UnequipArmor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void UNEQUIP_ARMOR ();


        /// const string Name_Func_UNEQUIP_GUN = "UnequipGun";
        /// <summary>
        ///   System.Void UnequipGun()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void UNEQUIP_GUN ();


        /// const string Name_Func_UNEQUIP_WEAPON = "UnequipWeapon";
        /// <summary>
        ///   System.Void UnequipWeapon()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void UNEQUIP_WEAPON ();



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


        /// const string Name_Func_EQUIP = "Equip";
        /// <summary>
        ///   System.Void Equip(MeleeWeapon weapon)
        /// </summary>
        /// <param name="weapon">class MeleeWeapon</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EQUIP_00 (nint weapon);


        /// const string Name_Func_EQUIP = "Equip";
        /// <summary>
        ///   System.Void Equip(RangedWeapon weapon)
        /// </summary>
        /// <param name="weapon">class RangedWeapon</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EQUIP_01 (nint weapon);


        /// const string Name_Func_EQUIP = "Equip";
        /// <summary>
        ///   System.Void Equip(Armor equipment)
        /// </summary>
        /// <param name="equipment">class Armor</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EQUIP_02 (nint equipment);


        /// const string Name_Func_EQUIP = "Equip";
        /// <summary>
        ///   System.Void Equip(Accessory equipment)
        /// </summary>
        /// <param name="equipment">class Accessory</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void EQUIP_03 (nint equipment);


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


        /// const string Name_Func_GET_MAX_HP = "GetMaxHP";
        /// <summary>
        ///   System.Int32 GetMaxHP()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_MAX_HP_00 ();


        /// const string Name_Func_GET_MAX_HP = "GetMaxHP";
        /// <summary>
        ///  abstract System.Int32 GetMaxHP()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_MAX_HP_01 ();


        /// const string Name_Func_GET_MAX_SP = "GetMaxSP";
        /// <summary>
        ///   System.Int32 GetMaxSP()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_MAX_SP_00 ();


        /// const string Name_Func_GET_MAX_SP = "GetMaxSP";
        /// <summary>
        ///  abstract System.Int32 GetMaxSP()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_MAX_SP_01 ();


        /// const string Name_Func_GET_NAME = "GetName";
        /// <summary>
        ///   System.String GetName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_NAME_00 ();


        /// const string Name_Func_GET_NAME = "GetName";
        /// <summary>
        ///  abstract System.String GetName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_NAME_01 ();


        /// const string Name_Func_GET_NAME = "GetName";
        /// <summary>
        /// static  System.String GetName(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// public static extern nint GET_NAME_02 (nint obj);


        /// const string Name_Func_GET_NAME_FIELD = "GetNameField";
        /// <summary>
        ///   LocalizationManager.LocalizedField GetNameField()
        /// </summary>
        /// <returns>class LocalizationManager.LocalizedField</returns>
        /// public  extern nint GET_NAME_FIELD_00 ();


        /// const string Name_Func_GET_NAME_FIELD = "GetNameField";
        /// <summary>
        ///  abstract LocalizationManager.LocalizedField GetNameField()
        /// </summary>
        /// <returns>class LocalizationManager.LocalizedField</returns>
        /// public  extern nint GET_NAME_FIELD_01 ();


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


        /// public static partial class Search_BattlePlayerModel
        /// {
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
        ///   System.Void Equip(MeleeWeapon weapon)
        /// </summary>
        /// public static bool EQUIP_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equip", "MeleeWeapon");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Equip(RangedWeapon weapon)
        /// </summary>
        /// public static bool EQUIP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equip", "RangedWeapon");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Equip(Armor equipment)
        /// </summary>
        /// public static bool EQUIP_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equip", "Armor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Equip(Accessory equipment)
        /// </summary>
        /// public static bool EQUIP_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equip", "Accessory");
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
        ///   System.Int32 GetMaxHP()
        /// </summary>
        /// public static bool GET_MAX_HP_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMaxHP");
        ///     
        ///  
        /// 


        /// <summary>
        ///  abstract System.Int32 GetMaxHP()
        /// </summary>
        /// public static bool GET_MAX_HP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMaxHP");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 GetMaxSP()
        /// </summary>
        /// public static bool GET_MAX_SP_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMaxSP");
        ///     
        ///  
        /// 


        /// <summary>
        ///  abstract System.Int32 GetMaxSP()
        /// </summary>
        /// public static bool GET_MAX_SP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMaxSP");
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
        ///  abstract System.String GetName()
        /// </summary>
        /// public static bool GET_NAME_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetName");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.String GetName(UnityEngine.Object obj)
        /// </summary>
        /// public static bool GET_NAME_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetName", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   LocalizationManager.LocalizedField GetNameField()
        /// </summary>
        /// public static bool GET_NAME_FIELD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetNameField");
        ///     
        ///  
        /// 


        /// <summary>
        ///  abstract LocalizationManager.LocalizedField GetNameField()
        /// </summary>
        /// public static bool GET_NAME_FIELD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetNameField");
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
        /// }

        /// <summary>
        /// ["Assembly-CSharp".""."Tactics"]
        /// </summary>
        public enum Tactics : System.Int32
        {


            DirectCommands = 0x00000000,

            ActFreely = 0x00000001,

            FullAssault = 0x00000002,

            ConserveSP = 0x00000003,

            HealSupport = 0x00000004,

        }

    }

}
