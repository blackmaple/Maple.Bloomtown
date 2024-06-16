
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
    /// class ["Assembly-CSharp".""."BattleMonsterModel"]
    /// [BattleParticipantModel]=>[UnityEngine.ScriptableObject]=>[UnityEngine.Object]=>[System.Object]
    /// [ISaveable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000119U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [66, 97, 116, 116, 108, 101, 77, 111, 110, 115, 116, 101, 114, 77, 111, 100, 101, 108])]
    public partial class BattleMonsterModel
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "BattleMonsterModel";
        //public static byte[] Static_ClassName { get; } = [66, 97, 116, 116, 108, 101, 77, 111, 110, 115, 116, 101, 114, 77, 111, 100, 101, 108];

        //public const uint Const_TypeToken = 0x02000119U;



        
        public readonly unsafe partial struct Const_BattleMonsterModel
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
        public readonly unsafe partial struct Static_BattleMonsterModel
        {

            
                        
            /// const string Name_Field_OffsetOfInstanceIDInCPlusPlusObject = "OffsetOfInstanceIDInCPlusPlusObject";
            /// <summary>
            /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        }

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_BattleMonsterModel
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
            public readonly nint uid;

                        
            /// const string Name_Field_viewPrefab = "viewPrefab";
            /// <summary>
            /// abstract class 0x20 BattleParticipantView viewPrefab
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint viewPrefab;

                        
            /// const string Name_Field_unitName = "unitName";
            /// <summary>
            /// class 0x28 LocalizationManager.LocalizedField unitName
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly nint unitName;

                        
            /// const string Name_Field_unitNameUid = "unitNameUid";
            /// <summary>
            /// class 0x30 System.String unitNameUid
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint unitNameUid;

                        
            /// const string Name_Field_passiveEffects = "passiveEffects";
            /// <summary>
            /// class 0x38 System.Collections.Generic.List<PassiveEffect> passiveEffects
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint passiveEffects;

                        
            /// const string Name_Field_level = "level";
            /// <summary>
            /// struct 0x40 System.Int32 level
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly System.Int32 level;

                        
            /// const string Name_Field_rawStrength = "rawStrength";
            /// <summary>
            /// struct 0x44 System.Int32 rawStrength
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x44)]
            public readonly System.Int32 rawStrength;

                        
            /// const string Name_Field_rawMagic = "rawMagic";
            /// <summary>
            /// struct 0x48 System.Int32 rawMagic
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly System.Int32 rawMagic;

                        
            /// const string Name_Field_rawEndurance = "rawEndurance";
            /// <summary>
            /// struct 0x4C System.Int32 rawEndurance
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4C)]
            public readonly System.Int32 rawEndurance;

                        
            /// const string Name_Field_rawAgility = "rawAgility";
            /// <summary>
            /// struct 0x50 System.Int32 rawAgility
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly System.Int32 rawAgility;

                        
            /// const string Name_Field_rawLuck = "rawLuck";
            /// <summary>
            /// struct 0x54 System.Int32 rawLuck
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x54)]
            public readonly System.Int32 rawLuck;

                        
            /// const string Name_Field_resists = "resists";
            /// <summary>
            /// class 0x58 System.Collections.Generic.List<Resist> resists
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            public readonly nint resists;

                        
            /// const string Name_Field_skills = "skills";
            /// <summary>
            /// class 0x60 System.Collections.Generic.List<Skill> skills
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            public readonly nint skills;

                        
            /// const string Name_Field_maxHP = "maxHP";
            /// <summary>
            /// struct 0x68 System.Int32 maxHP
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x68)]
            public readonly System.Int32 maxHP;

                        
            /// const string Name_Field_maxSP = "maxSP";
            /// <summary>
            /// struct 0x6C System.Int32 maxSP
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x6C)]
            public readonly System.Int32 maxSP;

                        
            /// const string Name_Field_exp = "exp";
            /// <summary>
            /// struct 0x70 System.Int32 exp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x70)]
            public readonly System.Int32 exp;

                        
            /// const string Name_Field_monsterType = "monsterType";
            /// <summary>
            /// enum 0x74 MonsterPersonality monsterType
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x74)]
            public readonly MonsterPersonality monsterType;

                        
            /// const string Name_Field_monsterRole = "monsterRole";
            /// <summary>
            /// enum 0x78 MonsterRole monsterRole
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x78)]
            public readonly MonsterRole monsterRole;

                        
            /// const string Name_Field_tameStat = "tameStat";
            /// <summary>
            /// enum 0x7C SocialStat.SocialStatType tameStat
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x7C)]
            public readonly  SocialStatType tameStat;

                        
            /// const string Name_Field_tameDifficulty = "tameDifficulty";
            /// <summary>
            /// struct 0x80 System.Int32 tameDifficulty
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x80)]
            public readonly System.Int32 tameDifficulty;

                        
            /// const string Name_Field_stealDifficulty = "stealDifficulty";
            /// <summary>
            /// struct 0x84 System.Int32 stealDifficulty
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x84)]
            public readonly System.Int32 stealDifficulty;

                        
            /// const string Name_Field_element = "element";
            /// <summary>
            /// enum 0x88 DamageType element
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x88)]
            public readonly DamageType element;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_BattleMonsterModel(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_BattleMonsterModel(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_BattleMonsterModel obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_BattleMonsterModel AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_BattleMonsterModel>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."BattleMonsterModel"]
        /// </summary>
        public partial class BattleMonsterModel
        { 

            
            
            /// const string Name_Func_.CCTOR = ".cctor";
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public static extern void .CCTOR ();

            
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

            
            /// const string Name_Func_CURRENT_THREAD_IS_MAIN_THREAD = "CurrentThreadIsMainThread";
            /// <summary>
            /// static  System.Boolean CurrentThreadIsMainThread()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();

            
            /// const string Name_Func_DESERIALIZE = "Deserialize";
            /// <summary>
            ///   System.Void Deserialize(System.String dataStr)
            /// </summary>
            /// <param name="dataStr">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void DESERIALIZE (nint dataStr);

            
            /// const string Name_Func_DOES_OBJECT_WITH_INSTANCE_ID_EXIST = "DoesObjectWithInstanceIDExist";
            /// <summary>
            /// static  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
            /// </summary>
            /// <param name="instanceID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean DOES_OBJECT_WITH_INSTANCE_ID_EXIST (System.Int32 instanceID);

            
            /// const string Name_Func_DONT_DESTROY_ON_LOAD = "DontDestroyOnLoad";
            /// <summary>
            /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
            /// </summary>
            /// <param name="target">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// public static extern void DONT_DESTROY_ON_LOAD (nint target);

            
            /// const string Name_Func_ENSURE_RUNNING_ON_MAIN_THREAD = "EnsureRunningOnMainThread";
            /// <summary>
            ///   System.Void EnsureRunningOnMainThread()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void ENSURE_RUNNING_ON_MAIN_THREAD ();

            
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

            
            /// const string Name_Func_FIND_OBJECTS_OF_TYPE_ALL = "FindObjectsOfTypeAll";
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// public static extern nint FIND_OBJECTS_OF_TYPE_ALL (nint type);

            
            /// const string Name_Func_FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS = "FindObjectsOfTypeIncludingAssets";
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// public static extern nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS (nint type);

            
            /// const string Name_Func_FIND_SCENE_OBJECTS_OF_TYPE = "FindSceneObjectsOfType";
            /// <summary>
            /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// public static extern nint FIND_SCENE_OBJECTS_OF_TYPE (nint type);

            
            /// const string Name_Func_FORCE_LOAD_FROM_INSTANCE_ID = "ForceLoadFromInstanceID";
            /// <summary>
            /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name="instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
            /// public static extern nint FORCE_LOAD_FROM_INSTANCE_ID (System.Int32 instanceID);

            
            /// const string Name_Func_GET_CAN_BE_TAMED = "get_canBeTamed";
            /// <summary>
            ///   System.Boolean get_canBeTamed()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean GET_CAN_BE_TAMED ();

            
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

            
            /// const string Name_Func_GET_IS_ELITE = "get_isElite";
            /// <summary>
            ///   System.Boolean get_isElite()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean GET_IS_ELITE ();

            
            /// const string Name_Func_GET_NAME = "get_name";
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_NAME ();

            
            /// const string Name_Func_GET_SAVED_DATA = "get_savedData";
            /// <summary>
            ///   PlayerData.BattleMonsterData get_savedData()
            /// </summary>
            /// <returns>class PlayerData.BattleMonsterData</returns>
            /// public  extern nint GET_SAVED_DATA ();

            
            /// const string Name_Func_GET_UNLOCKED_RESISTS = "get_unlockedResists";
            /// <summary>
            ///   System.Collections.Generic.List<DamageType> get_unlockedResists()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DamageType></returns>
            /// public  extern nint GET_UNLOCKED_RESISTS ();

            
            /// const string Name_Func_GET_BASE_RESIST = "GetBaseResist";
            /// <summary>
            ///   Resist GetBaseResist(DamageType damageType)
            /// </summary>
            /// <param name="damageType">enum DamageType</param>
            /// <returns>class Resist</returns>
            /// public  extern nint GET_BASE_RESIST (DamageType damageType);

            
            /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /// public  extern System.IntPtr GET_CACHED_PTR ();

            
            /// const string Name_Func_GET_ELEMENT_LOCALE = "GetElementLocale";
            /// <summary>
            ///   System.String GetElementLocale()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_ELEMENT_LOCALE ();

            
            /// const string Name_Func_GET_ELEMENT_NAME = "GetElementName";
            /// <summary>
            ///   System.String GetElementName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_ELEMENT_NAME ();

            
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

            
            /// const string Name_Func_GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT = "GetOffsetOfInstanceIDInCPlusPlusObject";
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();

            
            /// const string Name_Func_GET_ROLE_LOCALE = "GetRoleLocale";
            /// <summary>
            ///   System.String GetRoleLocale()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_ROLE_LOCALE ();

            
            /// const string Name_Func_GET_ROLE_NAME = "GetRoleName";
            /// <summary>
            ///   System.String GetRoleName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_ROLE_NAME ();

            
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

            
            /// const string Name_Func_IS_PERSISTENT = "IsPersistent";
            /// <summary>
            /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean IS_PERSISTENT (nint obj);

            
            /// const string Name_Func_MARK_DIRTY = "MarkDirty";
            /// <summary>
            ///   System.Void MarkDirty()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void MARK_DIRTY ();

            
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

            
            /// const string Name_Func_SET_NAME = "SetName";
            /// <summary>
            /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="name">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public static extern void SET_NAME (nint obj,nint name);
            
            
            
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

            
            /// const string Name_Func_DESTROY_OBJECT = "DestroyObject";
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj,System.Single t)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <param name="t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// public static extern void DESTROY_OBJECT_00 (nint obj,System.Single t);

            
            /// const string Name_Func_DESTROY_OBJECT = "DestroyObject";
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
            /// public static extern void DESTROY_OBJECT_01 (nint obj);

            
            /// const string Name_Func_FIND_ANY_OBJECT_BY_TYPE = "FindAnyObjectByType";
            /// <summary>
            /// static  T FindAnyObjectByType()
            /// </summary>
            /// <returns>class T</returns>
            /// public static extern nint FIND_ANY_OBJECT_BY_TYPE_00 ();

            
            /// const string Name_Func_FIND_ANY_OBJECT_BY_TYPE = "FindAnyObjectByType";
            /// <summary>
            /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class T</returns>
            /// public static extern nint FIND_ANY_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);

            
            /// const string Name_Func_FIND_ANY_OBJECT_BY_TYPE = "FindAnyObjectByType";
            /// <summary>
            /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
            /// public static extern nint FIND_ANY_OBJECT_BY_TYPE_02 (nint type);

            
            /// const string Name_Func_FIND_ANY_OBJECT_BY_TYPE = "FindAnyObjectByType";
            /// <summary>
            /// static  UnityEngine.Object FindAnyObjectByType(System.Type type,UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class UnityEngine.Object</returns>
            /// public static extern nint FIND_ANY_OBJECT_BY_TYPE_03 (nint type,UnityEngine.FindObjectsInactive findObjectsInactive);

            
            /// const string Name_Func_FIND_FIRST_OBJECT_BY_TYPE = "FindFirstObjectByType";
            /// <summary>
            /// static  T FindFirstObjectByType()
            /// </summary>
            /// <returns>class T</returns>
            /// public static extern nint FIND_FIRST_OBJECT_BY_TYPE_00 ();

            
            /// const string Name_Func_FIND_FIRST_OBJECT_BY_TYPE = "FindFirstObjectByType";
            /// <summary>
            /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class T</returns>
            /// public static extern nint FIND_FIRST_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);

            
            /// const string Name_Func_FIND_FIRST_OBJECT_BY_TYPE = "FindFirstObjectByType";
            /// <summary>
            /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
            /// public static extern nint FIND_FIRST_OBJECT_BY_TYPE_02 (nint type);

            
            /// const string Name_Func_FIND_FIRST_OBJECT_BY_TYPE = "FindFirstObjectByType";
            /// <summary>
            /// static  UnityEngine.Object FindFirstObjectByType(System.Type type,UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class UnityEngine.Object</returns>
            /// public static extern nint FIND_FIRST_OBJECT_BY_TYPE_03 (nint type,UnityEngine.FindObjectsInactive findObjectsInactive);

            
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
            /// static  UnityEngine.Object FindObjectOfType(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
            /// public static extern nint FIND_OBJECT_OF_TYPE_02 (nint type);

            
            /// const string Name_Func_FIND_OBJECT_OF_TYPE = "FindObjectOfType";
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type,System.Boolean includeInactive)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// public static extern nint FIND_OBJECT_OF_TYPE_03 (nint type,System.Boolean includeInactive);

            
            /// const string Name_Func_FIND_OBJECTS_BY_TYPE = "FindObjectsByType";
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsByType(System.Type type,UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// public static extern nint FIND_OBJECTS_BY_TYPE_00 (nint type,UnityEngine.FindObjectsSortMode sortMode);

            
            /// const string Name_Func_FIND_OBJECTS_BY_TYPE = "FindObjectsByType";
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsByType(System.Type type,UnityEngine.FindObjectsInactive findObjectsInactive,UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class UnityEngine.Object[]</returns>
            /// public static extern nint FIND_OBJECTS_BY_TYPE_01 (nint type,UnityEngine.FindObjectsInactive findObjectsInactive,UnityEngine.FindObjectsSortMode sortMode);

            
            /// const string Name_Func_FIND_OBJECTS_BY_TYPE = "FindObjectsByType";
            /// <summary>
            /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class T[]</returns>
            /// public static extern nint FIND_OBJECTS_BY_TYPE_02 (UnityEngine.FindObjectsSortMode sortMode);

            
            /// const string Name_Func_FIND_OBJECTS_BY_TYPE = "FindObjectsByType";
            /// <summary>
            /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive,UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class T[]</returns>
            /// public static extern nint FIND_OBJECTS_BY_TYPE_03 (UnityEngine.FindObjectsInactive findObjectsInactive,UnityEngine.FindObjectsSortMode sortMode);

            
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
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original,UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
            /// public static extern nint INSTANTIATE_03 (nint original,nint parent);

            
            /// const string Name_Func_INSTANTIATE = "Instantiate";
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original,UnityEngine.Transform parent,System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// <param name="original">class UnityEngine.Object</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
            /// public static extern nint INSTANTIATE_04 (nint original,nint parent,System.Boolean instantiateInWorldSpace);

            
            /// const string Name_Func_INSTANTIATE = "Instantiate";
            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// <param name="original">class T</param>
            /// <returns>class T</returns>
            /// public static extern nint INSTANTIATE_05 (nint original);

            
            /// const string Name_Func_INSTANTIATE = "Instantiate";
            /// <summary>
            /// static  T Instantiate(T original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class T</returns>
            /// public static extern nint INSTANTIATE_06 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation);

            
            /// const string Name_Func_INSTANTIATE = "Instantiate";
            /// <summary>
            /// static  T Instantiate(T original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="position">struct UnityEngine.Vector3</param>
            /// <param name="rotation">struct UnityEngine.Quaternion</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
            /// public static extern nint INSTANTIATE_07 (nint original,UnityEngine.Vector3 position,UnityEngine.Quaternion rotation,nint parent);

            
            /// const string Name_Func_INSTANTIATE = "Instantiate";
            /// <summary>
            /// static  T Instantiate(T original,UnityEngine.Transform parent)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
            /// public static extern nint INSTANTIATE_08 (nint original,nint parent);

            
            /// const string Name_Func_INSTANTIATE = "Instantiate";
            /// <summary>
            /// static  T Instantiate(T original,UnityEngine.Transform parent,System.Boolean worldPositionStays)
            /// </summary>
            /// <param name="original">class T</param>
            /// <param name="parent">class UnityEngine.Transform</param>
            /// <param name="worldPositionStays">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// public static extern nint INSTANTIATE_09 (nint original,nint parent,System.Boolean worldPositionStays);

            
            /// const string Name_Func_SET_UNLOCKED_RESISTS = "SetUnlockedResists";
            /// <summary>
            ///   System.Void SetUnlockedResists(EffectHolder skill)
            /// </summary>
            /// <param name="skill">abstract class EffectHolder</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_UNLOCKED_RESISTS_00 (nint skill);

            
            /// const string Name_Func_SET_UNLOCKED_RESISTS = "SetUnlockedResists";
            /// <summary>
            ///   System.Void SetUnlockedResists(DamageType damageType)
            /// </summary>
            /// <param name="damageType">enum DamageType</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_UNLOCKED_RESISTS_01 (DamageType damageType);

            
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

            
            /// public static partial class Search_BattleMonsterModel
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
                    /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
                    /// </summary>
                    /// public static bool DESTROY_OBJECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void DestroyObject(UnityEngine.Object obj)
                    /// </summary>
                    /// public static bool DESTROY_OBJECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T FindAnyObjectByType()
                    /// </summary>
                    /// public static bool FIND_ANY_OBJECT_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
                    /// </summary>
                    /// public static bool FIND_ANY_OBJECT_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "UnityEngine.FindObjectsInactive");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
                    /// </summary>
                    /// public static bool FIND_ANY_OBJECT_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
                    /// </summary>
                    /// public static bool FIND_ANY_OBJECT_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "System.Type", "UnityEngine.FindObjectsInactive");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T FindFirstObjectByType()
                    /// </summary>
                    /// public static bool FIND_FIRST_OBJECT_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
                    /// </summary>
                    /// public static bool FIND_FIRST_OBJECT_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "UnityEngine.FindObjectsInactive");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
                    /// </summary>
                    /// public static bool FIND_FIRST_OBJECT_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
                    /// </summary>
                    /// public static bool FIND_FIRST_OBJECT_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "System.Type", "UnityEngine.FindObjectsInactive");
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
                    /// static  UnityEngine.Object FindObjectOfType(System.Type type)
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool FIND_OBJECT_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "System.Type", "UnityEngine.FindObjectsSortMode");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "System.Type", "UnityEngine.FindObjectsInactive", "UnityEngine.FindObjectsSortMode");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "UnityEngine.FindObjectsSortMode");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
                    /// </summary>
                    /// public static bool FIND_OBJECTS_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "UnityEngine.FindObjectsInactive", "UnityEngine.FindObjectsSortMode");
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
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
                    /// </summary>
                    /// public static bool INSTANTIATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original)
                    /// </summary>
                    /// public static bool INSTANTIATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
                    /// </summary>
                    /// public static bool INSTANTIATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Transform parent)
                    /// </summary>
                    /// public static bool INSTANTIATE_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
                    /// </summary>
                    /// public static bool INSTANTIATE_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetUnlockedResists(EffectHolder skill)
                    /// </summary>
                    /// public static bool SET_UNLOCKED_RESISTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetUnlockedResists", "EffectHolder");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetUnlockedResists(DamageType damageType)
                    /// </summary>
                    /// public static bool SET_UNLOCKED_RESISTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetUnlockedResists", "DamageType");
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

        }


}