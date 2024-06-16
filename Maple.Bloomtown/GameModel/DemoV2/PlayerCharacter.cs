
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
    /// class ["Assembly-CSharp".""."PlayerCharacter"]
    /// [Character]=>[UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000344U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [80, 108, 97, 121, 101, 114, 67, 104, 97, 114, 97, 99, 116, 101, 114])]
    public partial class PlayerCharacter
    { 
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PlayerCharacter";
        //public static byte[] Static_ClassName { get; } = [80, 108, 97, 121, 101, 114, 67, 104, 97, 114, 97, 99, 116, 101, 114];

        //public const uint Const_TypeToken = 0x02000344U;



        
        public readonly unsafe partial struct Const_PlayerCharacter
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
        public readonly unsafe partial struct Static_PlayerCharacter
        {

            
                        
            /// const string Name_Field_OffsetOfInstanceIDInCPlusPlusObject = "OffsetOfInstanceIDInCPlusPlusObject";
            /// <summary>
            /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        }

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_PlayerCharacter
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

                        
            /// const string Name_Field_m_CancellationTokenSource = "m_CancellationTokenSource";
            /// <summary>
            /// class 0x18 System.Threading.CancellationTokenSource m_CancellationTokenSource
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly nint m_CancellationTokenSource;

                        
            /// const string Name_Field_uid = "uid";
            /// <summary>
            /// class 0x20 System.String uid
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint uid;

                        
            /// const string Name_Field_unitName = "unitName";
            /// <summary>
            /// class 0x28 UnitName unitName
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly nint unitName;

                        
            /// const string Name_Field_playerModel = "playerModel";
            /// <summary>
            /// class 0x30 BattlePlayerModel playerModel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint playerModel;

                        
            /// const string Name_Field_avatarMini = "avatarMini";
            /// <summary>
            /// class 0x38 UnityEngine.Sprite avatarMini
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint avatarMini;

                        
            /// const string Name_Field_avatarMicro = "avatarMicro";
            /// <summary>
            /// class 0x40 UnityEngine.Sprite avatarMicro
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly nint avatarMicro;

                        
            /// const string Name_Field_avatarNormal = "avatarNormal";
            /// <summary>
            /// class 0x48 UnityEngine.Sprite avatarNormal
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly nint avatarNormal;

                        
            /// const string Name_Field_avatarThreat = "avatarThreat";
            /// <summary>
            /// class 0x50 UnityEngine.Sprite avatarThreat
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly nint avatarThreat;

                        
            /// const string Name_Field_avatarJoy = "avatarJoy";
            /// <summary>
            /// class 0x58 UnityEngine.Sprite avatarJoy
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            public readonly nint avatarJoy;

                        
            /// const string Name_Field_avatarSadness = "avatarSadness";
            /// <summary>
            /// class 0x60 UnityEngine.Sprite avatarSadness
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            public readonly nint avatarSadness;

                        
            /// const string Name_Field_avatarSurprise = "avatarSurprise";
            /// <summary>
            /// class 0x68 UnityEngine.Sprite avatarSurprise
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x68)]
            public readonly nint avatarSurprise;

                        
            /// const string Name_Field_avatarNormalAnimated = "avatarNormalAnimated";
            /// <summary>
            /// class 0x70 UnityEngine.Sprite[] avatarNormalAnimated
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x70)]
            public readonly nint avatarNormalAnimated;

                        
            /// const string Name_Field_avatarThreatAnimated = "avatarThreatAnimated";
            /// <summary>
            /// class 0x78 UnityEngine.Sprite[] avatarThreatAnimated
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x78)]
            public readonly nint avatarThreatAnimated;

                        
            /// const string Name_Field_avatarJoyAnimated = "avatarJoyAnimated";
            /// <summary>
            /// class 0x80 UnityEngine.Sprite[] avatarJoyAnimated
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x80)]
            public readonly nint avatarJoyAnimated;

                        
            /// const string Name_Field_avatarSadnessAnimated = "avatarSadnessAnimated";
            /// <summary>
            /// class 0x88 UnityEngine.Sprite[] avatarSadnessAnimated
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x88)]
            public readonly nint avatarSadnessAnimated;

                        
            /// const string Name_Field_avatarSurpriseAnimated = "avatarSurpriseAnimated";
            /// <summary>
            /// class 0x90 UnityEngine.Sprite[] avatarSurpriseAnimated
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x90)]
            public readonly nint avatarSurpriseAnimated;

                        
            /// const string Name_Field_activePersonaProgress = "activePersonaProgress";
            /// <summary>
            /// class 0x98 PersonaProgress activePersonaProgress
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x98)]
            public readonly nint activePersonaProgress;

                        
            /// const string Name_Field_meleeWeapon = "meleeWeapon";
            /// <summary>
            /// class 0xA0 MeleeWeapon meleeWeapon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA0)]
            public readonly nint meleeWeapon;

                        
            /// const string Name_Field_rangedWeapon = "rangedWeapon";
            /// <summary>
            /// class 0xA8 RangedWeapon rangedWeapon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA8)]
            public readonly nint rangedWeapon;

                        
            /// const string Name_Field_armor = "armor";
            /// <summary>
            /// class 0xB0 Armor armor
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB0)]
            public readonly nint armor;

                        
            /// const string Name_Field_accessory = "accessory";
            /// <summary>
            /// class 0xB8 Accessory accessory
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB8)]
            public readonly nint accessory;

                        
            /// const string Name_Field_controllerInfo = "controllerInfo";
            /// <summary>
            /// class 0xC0 ControllerInfo controllerInfo
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC0)]
            public readonly nint controllerInfo;

                        
            /// const string Name_Field_movement = "movement";
            /// <summary>
            /// class 0xC8 TopDownMovement movement
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC8)]
            public readonly nint movement;

                        
            /// const string Name_Field_characterAnimation = "characterAnimation";
            /// <summary>
            /// class 0xD0 CharacterAnimation characterAnimation
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD0)]
            public readonly nint characterAnimation;

                        
            /// const string Name_Field_m_activeCliff = "m_activeCliff";
            /// <summary>
            /// class 0xD8 CliffManager m_activeCliff
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD8)]
            public readonly nint m_activeCliff;

                        
            /// const string Name_Field_m_logger = "m_logger";
            /// <summary>
            /// class 0xE0 Logger m_logger
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE0)]
            public readonly nint m_logger;

                        
            /// const string Name_Field_bubbleOffset = "bubbleOffset";
            /// <summary>
            /// struct 0xE8 UnityEngine.Vector2 bubbleOffset
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE8)]
            public readonly REF_MONO_VECTOR2 bubbleOffset;

                        
            /// const string Name_Field_demonsCount = "demonsCount";
            /// <summary>
            /// struct 0xF0 System.Int32 demonsCount
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF0)]
            public readonly System.Int32 demonsCount;

                        
            /// const string Name_Field_customX = "customX";
            /// <summary>
            /// struct 0xF4 System.Single customX
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF4)]
            public readonly System.Single customX;

                        
            /// const string Name_Field_curHP = "curHP";
            /// <summary>
            /// struct 0xF8 System.Int32 curHP
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF8)]
            public readonly System.Int32 curHP;

                        
            /// const string Name_Field_curSP = "curSP";
            /// <summary>
            /// struct 0xFC System.Int32 curSP
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xFC)]
            public readonly System.Int32 curSP;

                        
            /// const string Name_Field__bubblePosition = "_bubblePosition";
            /// <summary>
            /// struct 0x100 UnityEngine.Vector2 _bubblePosition
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x100)]
            public readonly REF_MONO_VECTOR2 _bubblePosition;

                        
            /// const string Name_Field__bubblePositionFound = "_bubblePositionFound";
            /// <summary>
            /// struct 0x108 System.Boolean _bubblePositionFound
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x108)]
            public readonly System.Boolean _bubblePositionFound;

                        
            /// const string Name_Field_level = "level";
            /// <summary>
            /// struct 0x10C System.Int32 level
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10C)]
            public readonly System.Int32 level;

                        
            /// const string Name_Field_levelExp = "levelExp";
            /// <summary>
            /// struct 0x110 System.Int32 levelExp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x110)]
            public readonly System.Int32 levelExp;

                        
            /// const string Name_Field_m_modelReset = "m_modelReset";
            /// <summary>
            /// struct 0x114 System.Boolean m_modelReset
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x114)]
            public readonly System.Boolean m_modelReset;

                        
            /// const string Name_Field_m_cliffProgress = "m_cliffProgress";
            /// <summary>
            /// struct 0x118 System.Single m_cliffProgress
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x118)]
            public readonly System.Single m_cliffProgress;

                        
            /// const string Name_Field_m_animationOffset = "m_animationOffset";
            /// <summary>
            /// struct 0x11C UnityEngine.Vector2 m_animationOffset
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x11C)]
            public readonly REF_MONO_VECTOR2 m_animationOffset;

                        
            /// const string Name_Field_m_loaded = "m_loaded";
            /// <summary>
            /// struct 0x124 System.Boolean m_loaded
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x124)]
            public readonly System.Boolean m_loaded;

                        
            /// const string Name_Field_dialoguesSpoken = "dialoguesSpoken";
            /// <summary>
            /// class 0x128 System.Collections.Generic.List<System.String> dialoguesSpoken
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x128)]
            public readonly nint dialoguesSpoken;

                        
            /// const string Name_Field_view = "view";
            /// <summary>
            /// class 0x130 UnityEngine.GameObject view
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x130)]
            public readonly nint view;

                        
            /// const string Name_Field_knowledge = "knowledge";
            /// <summary>
            /// class 0x138 SocialStat knowledge
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x138)]
            public readonly nint knowledge;

                        
            /// const string Name_Field_charm = "charm";
            /// <summary>
            /// class 0x140 SocialStat charm
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x140)]
            public readonly nint charm;

                        
            /// const string Name_Field_kindness = "kindness";
            /// <summary>
            /// class 0x148 SocialStat kindness
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x148)]
            public readonly nint kindness;

                        
            /// const string Name_Field_proficiency = "proficiency";
            /// <summary>
            /// class 0x150 SocialStat proficiency
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x150)]
            public readonly nint proficiency;

                        
            /// const string Name_Field_guts = "guts";
            /// <summary>
            /// class 0x158 SocialStat guts
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x158)]
            public readonly nint guts;

                        
            /// const string Name_Field_offset = "offset";
            /// <summary>
            /// struct 0x160 UnityEngine.Vector2Int offset
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x160)]
            public readonly REF_MONO_VECTOR2 offset;

                        
            /// const string Name_Field_m_additionalHp = "m_additionalHp";
            /// <summary>
            /// struct 0x168 System.Int32 m_additionalHp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x168)]
            public readonly System.Int32 m_additionalHp;

                        
            /// const string Name_Field_m_isViewActive = "m_isViewActive";
            /// <summary>
            /// struct 0x16C System.Boolean m_isViewActive
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x16C)]
            public readonly System.Boolean m_isViewActive;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PlayerCharacter(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PlayerCharacter(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PlayerCharacter obj) => obj._ptr;
            
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;
            
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_PlayerCharacter AsRef()
            {
                return ref System.Runtime.CompilerServices.Unsafe.AsRef<Ref_PlayerCharacter>(_ptr.ToPointer());
            }
        }

    }

        /// <summary>
        /// ["Assembly-CSharp".""."PlayerCharacter"]
        /// </summary>
        public partial class PlayerCharacter
        { 

            
            
            /// const string Name_Func_.CCTOR = ".cctor";
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public static extern void .CCTOR ();

            
            /// const string Name_Func_<GET_AVAILABLE_PERSONAS>B__74_0 = "<GetAvailablePersonas>b__74_0";
            /// <summary>
            ///   System.Boolean <GetAvailablePersonas>b__74_0(PersonaProgress x)
            /// </summary>
            /// <param name="x">class PersonaProgress</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean <GET_AVAILABLE_PERSONAS>B__74_0 (nint x);

            
            /// const string Name_Func_<INITIALIZATION_COR>B__93_2 = "<InitializationCor>b__93_2";
            /// <summary>
            ///   System.Boolean <InitializationCor>b__93_2(BattlePlayerModel x)
            /// </summary>
            /// <param name="x">class BattlePlayerModel</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean <INITIALIZATION_COR>B__93_2 (nint x);

            
            /// const string Name_Func_ADD_SOCIAL_STAT_ANIMATED = "AddSocialStatAnimated";
            /// <summary>
            ///   System.Collections.IEnumerator AddSocialStatAnimated(SocialStat.SocialStatType stat,System.Int32 count,UnityEngine.Transform starsParent)
            /// </summary>
            /// <param name="stat">enum SocialStat.SocialStatType</param>
            /// <param name="count">struct System.Int32</param>
            /// <param name="starsParent">class UnityEngine.Transform</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /// public  extern nint ADD_SOCIAL_STAT_ANIMATED (SocialStat.SocialStatType stat,System.Int32 count,nint starsParent);

            
            /// const string Name_Func_APPLY_WORLD_EFFECT = "ApplyWorldEffect";
            /// <summary>
            ///   System.Void ApplyWorldEffect(Character caster,EffectHolder effectHolder,EffectTemplate.EffectPrimitive primitive)
            /// </summary>
            /// <param name="caster">class Character</param>
            /// <param name="effectHolder">abstract class EffectHolder</param>
            /// <param name="primitive">class EffectTemplate.EffectPrimitive</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void APPLY_WORLD_EFFECT (nint caster,nint effectHolder,nint primitive);

            
            /// const string Name_Func_AWAKE = "Awake";
            /// <summary>
            ///   System.Void Awake()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void AWAKE ();

            
            /// const string Name_Func_CHECK_NULL_ARGUMENT = "CheckNullArgument";
            /// <summary>
            /// static  System.Void CheckNullArgument(System.Object arg,System.String message)
            /// </summary>
            /// <param name="arg">class System.Object</param>
            /// <param name="message">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public static extern void CHECK_NULL_ARGUMENT (nint arg,nint message);

            
            /// const string Name_Func_CLEAR_MODEL = "ClearModel";
            /// <summary>
            ///   System.Void ClearModel()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void CLEAR_MODEL ();

            
            /// const string Name_Func_CLEAR_SOCIAL_STATS = "ClearSocialStats";
            /// <summary>
            ///   System.Void ClearSocialStats()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void CLEAR_SOCIAL_STATS ();

            
            /// const string Name_Func_COMPARE_BASE_OBJECTS = "CompareBaseObjects";
            /// <summary>
            /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs,UnityEngine.Object rhs)
            /// </summary>
            /// <param name="lhs">class UnityEngine.Object</param>
            /// <param name="rhs">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs,nint rhs);

            
            /// const string Name_Func_COMPARE_TAG = "CompareTag";
            /// <summary>
            ///   System.Boolean CompareTag(System.String tag)
            /// </summary>
            /// <param name="tag">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean COMPARE_TAG (nint tag);

            
            /// const string Name_Func_CURRENT_THREAD_IS_MAIN_THREAD = "CurrentThreadIsMainThread";
            /// <summary>
            /// static  System.Boolean CurrentThreadIsMainThread()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();

            
            /// const string Name_Func_DISABLE_COLLISIONS = "DisableCollisions";
            /// <summary>
            ///   System.Void DisableCollisions()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void DISABLE_COLLISIONS ();

            
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

            
            /// const string Name_Func_ENABLE_COLLISIONS = "EnableCollisions";
            /// <summary>
            ///   System.Void EnableCollisions()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void ENABLE_COLLISIONS ();

            
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

            
            /// const string Name_Func_FULLY_RESTORE_HP = "FullyRestoreHp";
            /// <summary>
            ///   System.Void FullyRestoreHp()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void FULLY_RESTORE_HP ();

            
            /// const string Name_Func_FULLY_RESTORE_SP = "FullyRestoreSp";
            /// <summary>
            ///   System.Void FullyRestoreSp()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void FULLY_RESTORE_SP ();

            
            /// const string Name_Func_GET_BUBBLE_POSITION = "get_BubblePosition";
            /// <summary>
            ///   UnityEngine.Vector2 get_BubblePosition()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /// public  extern UnityEngine.Vector2 GET_BUBBLE_POSITION ();

            
            /// const string Name_Func_GET_DESTROY_CANCELLATION_TOKEN = "get_destroyCancellationToken";
            /// <summary>
            ///   System.Threading.CancellationToken get_destroyCancellationToken()
            /// </summary>
            /// <returns>struct System.Threading.CancellationToken</returns>
            /// public  extern System.Threading.CancellationToken GET_DESTROY_CANCELLATION_TOKEN ();

            
            /// const string Name_Func_GET_DIRECTION = "get_direction";
            /// <summary>
            ///   UnityEngine.Vector2 get_direction()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /// public  extern UnityEngine.Vector2 GET_DIRECTION ();

            
            /// const string Name_Func_GET_ENABLED = "get_enabled";
            /// <summary>
            ///   System.Boolean get_enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean GET_ENABLED ();

            
            /// const string Name_Func_GET_GAME_OBJECT = "get_gameObject";
            /// <summary>
            ///   UnityEngine.GameObject get_gameObject()
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
            /// public  extern nint GET_GAME_OBJECT ();

            
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

            
            /// const string Name_Func_GET_IS_ACTIVE_AND_ENABLED = "get_isActiveAndEnabled";
            /// <summary>
            ///   System.Boolean get_isActiveAndEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean GET_IS_ACTIVE_AND_ENABLED ();

            
            /// const string Name_Func_GET_IS_LOADED = "get_isLoaded";
            /// <summary>
            ///   System.Boolean get_isLoaded()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean GET_IS_LOADED ();

            
            /// const string Name_Func_GET_MAX_HP = "get_maxHP";
            /// <summary>
            ///   System.Int32 get_maxHP()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_MAX_HP ();

            
            /// const string Name_Func_GET_MAX_SP = "get_maxSP";
            /// <summary>
            ///   System.Int32 get_maxSP()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_MAX_SP ();

            
            /// const string Name_Func_GET_NAME = "get_name";
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_NAME ();

            
            /// const string Name_Func_GET_PATH_TO_CONTROLLERS = "get_pathToControllers";
            /// <summary>
            /// static  System.String get_pathToControllers()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public static extern nint GET_PATH_TO_CONTROLLERS ();

            
            /// const string Name_Func_GET_PERSONA_LEVEL = "get_personaLevel";
            /// <summary>
            ///   System.Int32 get_personaLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_PERSONA_LEVEL ();

            
            /// const string Name_Func_GET_PERSONA_LEVEL_EXP = "get_personaLevelExp";
            /// <summary>
            ///   System.Int32 get_personaLevelExp()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_PERSONA_LEVEL_EXP ();

            
            /// const string Name_Func_GET_TAG = "get_tag";
            /// <summary>
            ///   System.String get_tag()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_TAG ();

            
            /// const string Name_Func_GET_TRANSFORM = "get_transform";
            /// <summary>
            ///   UnityEngine.Transform get_transform()
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
            /// public  extern nint GET_TRANSFORM ();

            
            /// const string Name_Func_GET_USE_GUI_LAYOUT = "get_useGUILayout";
            /// <summary>
            ///   System.Boolean get_useGUILayout()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean GET_USE_GUI_LAYOUT ();

            
            /// const string Name_Func_GET_ANIMATED_AVATAR = "GetAnimatedAvatar";
            /// <summary>
            ///   UnityEngine.Sprite[] GetAnimatedAvatar(Character.Emotion emotion)
            /// </summary>
            /// <param name="emotion">enum Character.Emotion</param>
            /// <returns>class UnityEngine.Sprite[]</returns>
            /// public  extern nint GET_ANIMATED_AVATAR (Character.Emotion emotion);

            
            /// const string Name_Func_GET_ANIMATION_OFFSET = "GetAnimationOffset";
            /// <summary>
            ///   UnityEngine.Vector2 GetAnimationOffset()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /// public  extern UnityEngine.Vector2 GET_ANIMATION_OFFSET ();

            
            /// const string Name_Func_GET_AVAILABLE_PERSONAS = "GetAvailablePersonas";
            /// <summary>
            ///   System.Collections.Generic.List<PersonaProgress> GetAvailablePersonas()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PersonaProgress></returns>
            /// public  extern nint GET_AVAILABLE_PERSONAS ();

            
            /// const string Name_Func_GET_AVATAR = "GetAvatar";
            /// <summary>
            ///   UnityEngine.Sprite GetAvatar(Character.Emotion emotion)
            /// </summary>
            /// <param name="emotion">enum Character.Emotion</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /// public  extern nint GET_AVATAR (Character.Emotion emotion);

            
            /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /// public  extern System.IntPtr GET_CACHED_PTR ();

            
            /// const string Name_Func_GET_CLIFF_OFFSET = "GetCliffOffset";
            /// <summary>
            ///   System.Single GetCliffOffset()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /// public  extern System.Single GET_CLIFF_OFFSET ();

            
            /// const string Name_Func_GET_COMPONENT_FAST_PATH = "GetComponentFastPath";
            /// <summary>
            ///   System.Void GetComponentFastPath(System.Type type,System.IntPtr oneFurtherThanResultValue)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="oneFurtherThanResultValue">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void GET_COMPONENT_FAST_PATH (nint type,System.IntPtr oneFurtherThanResultValue);

            
            /// const string Name_Func_GET_COMPONENTS_FOR_LIST_INTERNAL = "GetComponentsForListInternal";
            /// <summary>
            ///   System.Void GetComponentsForListInternal(System.Type searchType,System.Object resultList)
            /// </summary>
            /// <param name="searchType">abstract class System.Type</param>
            /// <param name="resultList">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void GET_COMPONENTS_FOR_LIST_INTERNAL (nint searchType,nint resultList);

            
            /// const string Name_Func_GET_EQUIPMENT = "GetEquipment";
            /// <summary>
            ///   Equipment GetEquipment(Equipment.Slot slot)
            /// </summary>
            /// <param name="slot">enum Equipment.Slot</param>
            /// <returns>abstract class Equipment</returns>
            /// public  extern nint GET_EQUIPMENT (Equipment.Slot slot);

            
            /// const string Name_Func_GET_EXP_TO_LEVEL = "GetExpToLevel";
            /// <summary>
            /// static  System.Int32 GetExpToLevel(System.Int32 lvl)
            /// </summary>
            /// <param name="lvl">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /// public static extern System.Int32 GET_EXP_TO_LEVEL (System.Int32 lvl);

            
            /// const string Name_Func_GET_FEET_POSITION = "GetFeetPosition";
            /// <summary>
            ///   UnityEngine.Vector2 GetFeetPosition()
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /// public  extern UnityEngine.Vector2 GET_FEET_POSITION ();

            
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

            
            /// const string Name_Func_GET_LAYER = "GetLayer";
            /// <summary>
            ///   System.Int32 GetLayer()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_LAYER ();

            
            /// const string Name_Func_GET_MAX_HP_FOR_LVL = "GetMaxHPForLvl";
            /// <summary>
            ///   System.Int32 GetMaxHPForLvl(System.Int32 lvl)
            /// </summary>
            /// <param name="lvl">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_MAX_HP_FOR_LVL (System.Int32 lvl);

            
            /// const string Name_Func_GET_MAX_SP = "GetMaxSP";
            /// <summary>
            ///   System.Int32 GetMaxSP()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_MAX_SP ();

            
            /// const string Name_Func_GET_MAX_SP_FOR_LVL = "GetMaxSPForLvl";
            /// <summary>
            ///   System.Int32 GetMaxSPForLvl(System.Int32 lvl)
            /// </summary>
            /// <param name="lvl">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_MAX_SP_FOR_LVL (System.Int32 lvl);

            
            /// const string Name_Func_GET_NAME = "GetName";
            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
            /// public static extern nint GET_NAME (nint obj);

            
            /// const string Name_Func_GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT = "GetOffsetOfInstanceIDInCPlusPlusObject";
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();

            
            /// const string Name_Func_GET_OVERALL_STAT = "GetOverallStat";
            /// <summary>
            ///   System.Int32 GetOverallStat(PersonaProgress.StateType stateType)
            /// </summary>
            /// <param name="stateType">enum PersonaProgress.StateType</param>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_OVERALL_STAT (PersonaProgress.StateType stateType);

            
            /// const string Name_Func_GET_OVERALL_STAT_FROM_ANOTHER_PERSONA = "GetOverallStatFromAnotherPersona";
            /// <summary>
            ///   System.Int32 GetOverallStatFromAnotherPersona(PersonaProgress personaProgress,PersonaProgress.StateType stateType)
            /// </summary>
            /// <param name="personaProgress">class PersonaProgress</param>
            /// <param name="stateType">enum PersonaProgress.StateType</param>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_OVERALL_STAT_FROM_ANOTHER_PERSONA (nint personaProgress,PersonaProgress.StateType stateType);

            
            /// const string Name_Func_GET_PATH_TO_CONTROLLERS = "GetPathToControllers";
            /// <summary>
            ///   System.String GetPathToControllers()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_PATH_TO_CONTROLLERS ();

            
            /// const string Name_Func_GET_PATH_TO_EXPLORING_CONTROLLER = "GetPathToExploringController";
            /// <summary>
            ///   System.String GetPathToExploringController(System.String postfix)
            /// </summary>
            /// <param name="postfix">class System.String</param>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_PATH_TO_EXPLORING_CONTROLLER (nint postfix);

            
            /// const string Name_Func_GET_PLAYER_INSTANCE = "GetPlayerInstance";
            /// <summary>
            /// static  PlayerCharacter GetPlayerInstance()
            /// </summary>
            /// <returns>class PlayerCharacter</returns>
            /// public static extern nint GET_PLAYER_INSTANCE ();

            
            /// const string Name_Func_GET_SCRIPT_CLASS_NAME = "GetScriptClassName";
            /// <summary>
            ///   System.String GetScriptClassName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint GET_SCRIPT_CLASS_NAME ();

            
            /// const string Name_Func_GET_SKILLS = "GetSkills";
            /// <summary>
            ///   System.Collections.Generic.List<EffectHolder> GetSkills()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<EffectHolder></returns>
            /// public  extern nint GET_SKILLS ();

            
            /// const string Name_Func_GET_SOCIAL_STAT_BY_TYPE = "GetSocialStatByType";
            /// <summary>
            ///   SocialStat GetSocialStatByType(SocialStat.SocialStatType stat)
            /// </summary>
            /// <param name="stat">enum SocialStat.SocialStatType</param>
            /// <returns>class SocialStat</returns>
            /// public  extern nint GET_SOCIAL_STAT_BY_TYPE (SocialStat.SocialStatType stat);

            
            /// const string Name_Func_GET_STRENGTH_ATTACK_POWER = "GetStrengthAttackPower";
            /// <summary>
            ///   System.Single GetStrengthAttackPower()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /// public  extern System.Single GET_STRENGTH_ATTACK_POWER ();

            
            /// const string Name_Func_HEAL = "Heal";
            /// <summary>
            ///   System.Void Heal(System.Int32 power)
            /// </summary>
            /// <param name="power">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void HEAL (System.Int32 power);

            
            /// const string Name_Func_INCREASE_ADDITIONAL_HP = "IncreaseAdditionalHP";
            /// <summary>
            ///   System.Void IncreaseAdditionalHP(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void INCREASE_ADDITIONAL_HP (System.Int32 value);

            
            /// const string Name_Func_INCREASE_MAX_HP_ANIMATED = "IncreaseMaxHPAnimated";
            /// <summary>
            ///   System.Collections.IEnumerator IncreaseMaxHPAnimated(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /// public  extern nint INCREASE_MAX_HP_ANIMATED (System.Int32 value);

            
            /// const string Name_Func_INITIALIZATION_COR = "InitializationCor";
            /// <summary>
            ///   System.Collections.IEnumerator InitializationCor()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /// public  extern nint INITIALIZATION_COR ();

            
            /// const string Name_Func_INTERNAL_CANCEL_INVOKE_ALL = "Internal_CancelInvokeAll";
            /// <summary>
            /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Void</returns>
            /// public static extern void INTERNAL_CANCEL_INVOKE_ALL (nint self);

            
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

            
            /// const string Name_Func_INTERNAL_IS_INVOKING_ALL = "Internal_IsInvokingAll";
            /// <summary>
            /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean INTERNAL_IS_INVOKING_ALL (nint self);

            
            /// const string Name_Func_INVOKE = "Invoke";
            /// <summary>
            ///   System.Void Invoke(System.String methodName,System.Single time)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void INVOKE (nint methodName,System.Single time);

            
            /// const string Name_Func_INVOKE_DELAYED = "InvokeDelayed";
            /// <summary>
            /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self,System.String methodName,System.Single time,System.Single repeatRate)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <param name="repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// public static extern void INVOKE_DELAYED (nint self,nint methodName,System.Single time,System.Single repeatRate);

            
            /// const string Name_Func_INVOKE_REPEATING = "InvokeRepeating";
            /// <summary>
            ///   System.Void InvokeRepeating(System.String methodName,System.Single time,System.Single repeatRate)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="time">struct System.Single</param>
            /// <param name="repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void INVOKE_REPEATING (nint methodName,System.Single time,System.Single repeatRate);

            
            /// const string Name_Func_IS_NATIVE_OBJECT_ALIVE = "IsNativeObjectAlive";
            /// <summary>
            /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
            /// </summary>
            /// <param name="o">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);

            
            /// const string Name_Func_IS_OBJECT_MONO_BEHAVIOUR = "IsObjectMonoBehaviour";
            /// <summary>
            /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean IS_OBJECT_MONO_BEHAVIOUR (nint obj);

            
            /// const string Name_Func_IS_PERSISTENT = "IsPersistent";
            /// <summary>
            /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
            /// </summary>
            /// <param name="obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean IS_PERSISTENT (nint obj);

            
            /// const string Name_Func_LOAD_DEFAULT_ARMOR = "LoadDefaultArmor";
            /// <summary>
            ///   System.Void LoadDefaultArmor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void LOAD_DEFAULT_ARMOR ();

            
            /// const string Name_Func_LOAD_DEFAULT_GUN = "LoadDefaultGun";
            /// <summary>
            ///   System.Void LoadDefaultGun()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void LOAD_DEFAULT_GUN ();

            
            /// const string Name_Func_LOAD_DEFAULT_WEAPON = "LoadDefaultWeapon";
            /// <summary>
            ///   System.Void LoadDefaultWeapon()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void LOAD_DEFAULT_WEAPON ();

            
            /// const string Name_Func_MARK_DIRTY = "MarkDirty";
            /// <summary>
            ///   System.Void MarkDirty()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void MARK_DIRTY ();

            
            /// const string Name_Func_ON_CANCELLATION_TOKEN_CREATED = "OnCancellationTokenCreated";
            /// <summary>
            ///   System.Void OnCancellationTokenCreated()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void ON_CANCELLATION_TOKEN_CREATED ();

            
            /// const string Name_Func_ON_CLIFF_ENTERED = "OnCliffEntered";
            /// <summary>
            ///   System.Void OnCliffEntered(CliffManager cliff)
            /// </summary>
            /// <param name="cliff">class CliffManager</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ON_CLIFF_ENTERED (nint cliff);

            
            /// const string Name_Func_ON_CLIFF_EXITED = "OnCliffExited";
            /// <summary>
            ///   System.Void OnCliffExited(CliffManager cliff)
            /// </summary>
            /// <param name="cliff">class CliffManager</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ON_CLIFF_EXITED (nint cliff);

            
            /// const string Name_Func_ON_CLIFF_STAIRS = "OnCliffStairs";
            /// <summary>
            ///   System.Void OnCliffStairs(CliffManager cliff,System.Single amount)
            /// </summary>
            /// <param name="cliff">class CliffManager</param>
            /// <param name="amount">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ON_CLIFF_STAIRS (nint cliff,System.Single amount);

            
            /// const string Name_Func_ON_ENTERED_SLOPE = "OnEnteredSlope";
            /// <summary>
            ///   System.Void OnEnteredSlope(Slope slope)
            /// </summary>
            /// <param name="slope">class Slope</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ON_ENTERED_SLOPE (nint slope);

            
            /// const string Name_Func_ON_EXITED_SLOPE = "OnExitedSlope";
            /// <summary>
            ///   System.Void OnExitedSlope(Slope slope)
            /// </summary>
            /// <param name="slope">class Slope</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ON_EXITED_SLOPE (nint slope);

            
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

            
            /// const string Name_Func_PLAY_CONTAINER_OPEN_ANIMATION = "PlayContainerOpenAnimation";
            /// <summary>
            ///   System.Collections.IEnumerator PlayContainerOpenAnimation(System.String openType,UnityEngine.Vector2 dir)
            /// </summary>
            /// <param name="openType">class System.String</param>
            /// <param name="dir">struct UnityEngine.Vector2</param>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /// public  extern nint PLAY_CONTAINER_OPEN_ANIMATION (nint openType,UnityEngine.Vector2 dir);

            
            /// const string Name_Func_PRINT = "print";
            /// <summary>
            /// static  System.Void print(System.Object message)
            /// </summary>
            /// <param name="message">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// public static extern void PRINT (nint message);

            
            /// const string Name_Func_RAISE_CANCELLATION = "RaiseCancellation";
            /// <summary>
            ///   System.Void RaiseCancellation()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void RAISE_CANCELLATION ();

            
            /// const string Name_Func_RESTORE_MANA = "RestoreMana";
            /// <summary>
            ///   System.Void RestoreMana(System.Int32 power)
            /// </summary>
            /// <param name="power">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void RESTORE_MANA (System.Int32 power);

            
            /// const string Name_Func_SET_ENABLED = "set_enabled";
            /// <summary>
            ///   System.Void set_enabled(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_ENABLED (System.Boolean value);

            
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

            
            /// const string Name_Func_SET_TAG = "set_tag";
            /// <summary>
            ///   System.Void set_tag(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_TAG (nint value);

            
            /// const string Name_Func_SET_USE_GUI_LAYOUT = "set_useGUILayout";
            /// <summary>
            ///   System.Void set_useGUILayout(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_USE_GUI_LAYOUT (System.Boolean value);

            
            /// const string Name_Func_SET_ACTIVE_PERSONA = "SetActivePersona";
            /// <summary>
            ///   System.Void SetActivePersona(PersonaProgress personaProgress)
            /// </summary>
            /// <param name="personaProgress">class PersonaProgress</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_ACTIVE_PERSONA (nint personaProgress);

            
            /// const string Name_Func_SET_ANIMATION_OFFSET = "SetAnimationOffset";
            /// <summary>
            ///   System.Void SetAnimationOffset(UnityEngine.Vector2 animationOffset)
            /// </summary>
            /// <param name="animationOffset">struct UnityEngine.Vector2</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_ANIMATION_OFFSET (UnityEngine.Vector2 animationOffset);

            
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

            
            /// const string Name_Func_SET_VIEW_ACTIVE = "SetViewActive";
            /// <summary>
            ///   System.Void SetViewActive(System.Boolean isActive)
            /// </summary>
            /// <param name="isActive">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_VIEW_ACTIVE (System.Boolean isActive);

            
            /// const string Name_Func_START_COROUTINE_AUTO = "StartCoroutine_Auto";
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// public  extern nint START_COROUTINE_AUTO (nint routine);

            
            /// const string Name_Func_START_COROUTINE_MANAGED = "StartCoroutineManaged";
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName,System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// public  extern nint START_COROUTINE_MANAGED (nint methodName,nint value);

            
            /// const string Name_Func_START_COROUTINE_MANAGED2 = "StartCoroutineManaged2";
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
            /// </summary>
            /// <param name="enumerator">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// public  extern nint START_COROUTINE_MANAGED2 (nint enumerator);

            
            /// const string Name_Func_STOP_ALL_COROUTINES = "StopAllCoroutines";
            /// <summary>
            ///   System.Void StopAllCoroutines()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void STOP_ALL_COROUTINES ();

            
            /// const string Name_Func_STOP_COROUTINE_FROM_ENUMERATOR_MANAGED = "StopCoroutineFromEnumeratorManaged";
            /// <summary>
            ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED (nint routine);

            
            /// const string Name_Func_STOP_COROUTINE_MANAGED = "StopCoroutineManaged";
            /// <summary>
            ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name="routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void STOP_COROUTINE_MANAGED (nint routine);

            
            /// const string Name_Func_SWITCH_VIEW_ACTIVE = "SwitchViewActive";
            /// <summary>
            ///   System.Void SwitchViewActive()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void SWITCH_VIEW_ACTIVE ();

            
            /// const string Name_Func_UNEQUIP = "Unequip";
            /// <summary>
            ///   System.Void Unequip(Equipment.Slot typeSlot)
            /// </summary>
            /// <param name="typeSlot">enum Equipment.Slot</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void UNEQUIP (Equipment.Slot typeSlot);

            
            /// const string Name_Func_UNEQUIP_PERSONA = "UnequipPersona";
            /// <summary>
            ///   System.Void UnequipPersona(PersonaProgress personaProgress)
            /// </summary>
            /// <param name="personaProgress">class PersonaProgress</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void UNEQUIP_PERSONA (nint personaProgress);

            
            /// const string Name_Func_UPDATE_OFFSET = "UpdateOffset";
            /// <summary>
            ///   System.Void UpdateOffset()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void UPDATE_OFFSET ();

            
            /// const string Name_Func_UPDATE_VIEW_POSITION = "UpdateViewPosition";
            /// <summary>
            ///   System.Void UpdateViewPosition()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void UPDATE_VIEW_POSITION ();
            
            
            
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

            
            /// const string Name_Func_ADD_EXP = "AddExp";
            /// <summary>
            ///   System.Void AddExp(System.Collections.Generic.List<BattleMonsterController> defeatedEnemies)
            /// </summary>
            /// <param name="defeatedEnemies">class System.Collections.Generic.List<BattleMonsterController></param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ADD_EXP_00 (nint defeatedEnemies);

            
            /// const string Name_Func_ADD_EXP = "AddExp";
            /// <summary>
            ///   System.Void AddExp(System.Int32 count)
            /// </summary>
            /// <param name="count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void ADD_EXP_01 (System.Int32 count);

            
            /// const string Name_Func_CANCEL_INVOKE = "CancelInvoke";
            /// <summary>
            ///   System.Void CancelInvoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// public  extern void CANCEL_INVOKE_00 ();

            
            /// const string Name_Func_CANCEL_INVOKE = "CancelInvoke";
            /// <summary>
            ///   System.Void CancelInvoke(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void CANCEL_INVOKE_01 (nint methodName);

            
            /// const string Name_Func_CANCEL_INVOKE = "CancelInvoke";
            /// <summary>
            /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self,System.String methodName)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public static extern void CANCEL_INVOKE_02 (nint self,nint methodName);

            
            /// const string Name_Func_DESERIALIZE = "Deserialize";
            /// <summary>
            ///   System.Void Deserialize(System.String dataStr)
            /// </summary>
            /// <param name="dataStr">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void DESERIALIZE_00 (nint dataStr);

            
            /// const string Name_Func_DESERIALIZE = "Deserialize";
            /// <summary>
            ///   System.Void Deserialize(System.String dataStr)
            /// </summary>
            /// <param name="dataStr">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void DESERIALIZE_01 (nint dataStr);

            
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

            
            /// const string Name_Func_EQUIP = "Equip";
            /// <summary>
            ///   System.Void Equip(Equipment item)
            /// </summary>
            /// <param name="item">abstract class Equipment</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void EQUIP_00 (nint item);

            
            /// const string Name_Func_EQUIP = "Equip";
            /// <summary>
            ///   System.Void Equip(MeleeWeapon item)
            /// </summary>
            /// <param name="item">class MeleeWeapon</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void EQUIP_01 (nint item);

            
            /// const string Name_Func_EQUIP = "Equip";
            /// <summary>
            ///   System.Void Equip(RangedWeapon item)
            /// </summary>
            /// <param name="item">class RangedWeapon</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void EQUIP_02 (nint item);

            
            /// const string Name_Func_EQUIP = "Equip";
            /// <summary>
            ///   System.Void Equip(Armor item)
            /// </summary>
            /// <param name="item">class Armor</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void EQUIP_03 (nint item);

            
            /// const string Name_Func_EQUIP = "Equip";
            /// <summary>
            ///   System.Void Equip(Accessory item)
            /// </summary>
            /// <param name="item">class Accessory</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void EQUIP_04 (nint item);

            
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

            
            /// const string Name_Func_GET_COMPONENT = "GetComponent";
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// public  extern nint GET_COMPONENT_00 (nint type);

            
            /// const string Name_Func_GET_COMPONENT = "GetComponent";
            /// <summary>
            ///   T GetComponent()
            /// </summary>
            /// <returns>class T</returns>
            /// public  extern nint GET_COMPONENT_01 ();

            
            /// const string Name_Func_GET_COMPONENT_IN_CHILDREN = "GetComponentInChildren";
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t,System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
            /// public  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t,System.Boolean includeInactive);

            
            /// const string Name_Func_GET_COMPONENT_IN_CHILDREN = "GetComponentInChildren";
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// public  extern nint GET_COMPONENT_IN_CHILDREN_01 (nint t);

            
            /// const string Name_Func_GET_COMPONENT_IN_CHILDREN = "GetComponentInChildren";
            /// <summary>
            ///   T GetComponentInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// public  extern nint GET_COMPONENT_IN_CHILDREN_02 (System.Boolean includeInactive);

            
            /// const string Name_Func_GET_COMPONENT_IN_CHILDREN = "GetComponentInChildren";
            /// <summary>
            ///   T GetComponentInChildren()
            /// </summary>
            /// <returns>class T</returns>
            /// public  extern nint GET_COMPONENT_IN_CHILDREN_03 ();

            
            /// const string Name_Func_GET_COMPONENT_IN_PARENT = "GetComponentInParent";
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t,System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
            /// public  extern nint GET_COMPONENT_IN_PARENT_00 (nint t,System.Boolean includeInactive);

            
            /// const string Name_Func_GET_COMPONENT_IN_PARENT = "GetComponentInParent";
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
            /// public  extern nint GET_COMPONENT_IN_PARENT_01 (nint t);

            
            /// const string Name_Func_GET_COMPONENT_IN_PARENT = "GetComponentInParent";
            /// <summary>
            ///   T GetComponentInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
            /// public  extern nint GET_COMPONENT_IN_PARENT_02 (System.Boolean includeInactive);

            
            /// const string Name_Func_GET_COMPONENT_IN_PARENT = "GetComponentInParent";
            /// <summary>
            ///   T GetComponentInParent()
            /// </summary>
            /// <returns>class T</returns>
            /// public  extern nint GET_COMPONENT_IN_PARENT_03 ();

            
            /// const string Name_Func_GET_COMPONENTS = "GetComponents";
            /// <summary>
            ///   UnityEngine.Component[] GetComponents(System.Type type)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// public  extern nint GET_COMPONENTS_00 (nint type);

            
            /// const string Name_Func_GET_COMPONENTS = "GetComponents";
            /// <summary>
            ///   System.Void GetComponents(System.Type type,System.Collections.Generic.List<UnityEngine.Component> results)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
            /// <returns>struct System.Void</returns>
            /// public  extern void GET_COMPONENTS_01 (nint type,nint results);

            
            /// const string Name_Func_GET_COMPONENTS = "GetComponents";
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// public  extern void GET_COMPONENTS_02 (nint results);

            
            /// const string Name_Func_GET_COMPONENTS = "GetComponents";
            /// <summary>
            ///   T[] GetComponents()
            /// </summary>
            /// <returns>class T[]</returns>
            /// public  extern nint GET_COMPONENTS_03 ();

            
            /// const string Name_Func_GET_COMPONENTS_IN_CHILDREN = "GetComponentsInChildren";
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// public  extern nint GET_COMPONENTS_IN_CHILDREN_00 (nint t);

            
            /// const string Name_Func_GET_COMPONENTS_IN_CHILDREN = "GetComponentsInChildren";
            /// <summary>
            ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// public  extern nint GET_COMPONENTS_IN_CHILDREN_01 (System.Boolean includeInactive);

            
            /// const string Name_Func_GET_COMPONENTS_IN_CHILDREN = "GetComponentsInChildren";
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Boolean includeInactive,System.Collections.Generic.List<T> result)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <param name="result">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// public  extern void GET_COMPONENTS_IN_CHILDREN_02 (System.Boolean includeInactive,nint result);

            
            /// const string Name_Func_GET_COMPONENTS_IN_CHILDREN = "GetComponentsInChildren";
            /// <summary>
            ///   T[] GetComponentsInChildren()
            /// </summary>
            /// <returns>class T[]</returns>
            /// public  extern nint GET_COMPONENTS_IN_CHILDREN_03 ();

            
            /// const string Name_Func_GET_COMPONENTS_IN_CHILDREN = "GetComponentsInChildren";
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// public  extern void GET_COMPONENTS_IN_CHILDREN_04 (nint results);

            
            /// const string Name_Func_GET_COMPONENTS_IN_PARENT = "GetComponentsInParent";
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInParent(System.Type t,System.Boolean includeInactive)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// public  extern nint GET_COMPONENTS_IN_PARENT_00 (nint t,System.Boolean includeInactive);

            
            /// const string Name_Func_GET_COMPONENTS_IN_PARENT = "GetComponentsInParent";
            /// <summary>
            ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
            /// </summary>
            /// <param name="t">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component[]</returns>
            /// public  extern nint GET_COMPONENTS_IN_PARENT_01 (nint t);

            
            /// const string Name_Func_GET_COMPONENTS_IN_PARENT = "GetComponentsInParent";
            /// <summary>
            ///   T[] GetComponentsInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
            /// public  extern nint GET_COMPONENTS_IN_PARENT_02 (System.Boolean includeInactive);

            
            /// const string Name_Func_GET_COMPONENTS_IN_PARENT = "GetComponentsInParent";
            /// <summary>
            ///   System.Void GetComponentsInParent(System.Boolean includeInactive,System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name="includeInactive">struct System.Boolean</param>
            /// <param name="results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
            /// public  extern void GET_COMPONENTS_IN_PARENT_03 (System.Boolean includeInactive,nint results);

            
            /// const string Name_Func_GET_COMPONENTS_IN_PARENT = "GetComponentsInParent";
            /// <summary>
            ///   T[] GetComponentsInParent()
            /// </summary>
            /// <returns>class T[]</returns>
            /// public  extern nint GET_COMPONENTS_IN_PARENT_04 ();

            
            /// const string Name_Func_GET_MAGIC_ATTACK_POWER = "GetMagicAttackPower";
            /// <summary>
            ///   System.Single GetMagicAttackPower()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /// public  extern System.Single GET_MAGIC_ATTACK_POWER_00 ();

            
            /// const string Name_Func_GET_MAGIC_ATTACK_POWER = "GetMagicAttackPower";
            /// <summary>
            ///   System.Single GetMagicAttackPower(PersonaProgress persona)
            /// </summary>
            /// <param name="persona">class PersonaProgress</param>
            /// <returns>struct System.Single</returns>
            /// public  extern System.Single GET_MAGIC_ATTACK_POWER_01 (nint persona);

            
            /// const string Name_Func_GET_MAX_HP = "GetMaxHP";
            /// <summary>
            ///   System.Int32 GetMaxHP()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_MAX_HP_00 ();

            
            /// const string Name_Func_GET_MAX_HP = "GetMaxHP";
            /// <summary>
            ///   System.Int32 GetMaxHP()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// public  extern System.Int32 GET_MAX_HP_01 ();

            
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

            
            /// const string Name_Func_IS_INVOKING = "IsInvoking";
            /// <summary>
            ///   System.Boolean IsInvoking()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean IS_INVOKING_00 ();

            
            /// const string Name_Func_IS_INVOKING = "IsInvoking";
            /// <summary>
            ///   System.Boolean IsInvoking(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean IS_INVOKING_01 (nint methodName);

            
            /// const string Name_Func_IS_INVOKING = "IsInvoking";
            /// <summary>
            /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self,System.String methodName)
            /// </summary>
            /// <param name="self">class UnityEngine.MonoBehaviour</param>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// public static extern System.Boolean IS_INVOKING_02 (nint self,nint methodName);

            
            /// const string Name_Func_SERIALIZE = "Serialize";
            /// <summary>
            ///   System.String Serialize()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint SERIALIZE_00 ();

            
            /// const string Name_Func_SERIALIZE = "Serialize";
            /// <summary>
            ///   System.String Serialize()
            /// </summary>
            /// <returns>class System.String</returns>
            /// public  extern nint SERIALIZE_01 ();

            
            /// const string Name_Func_SET_DIRECTION = "SetDirection";
            /// <summary>
            ///   System.Void SetDirection(System.Single dirX,System.Single dirY)
            /// </summary>
            /// <param name="dirX">struct System.Single</param>
            /// <param name="dirY">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_DIRECTION_00 (System.Single dirX,System.Single dirY);

            
            /// const string Name_Func_SET_DIRECTION = "SetDirection";
            /// <summary>
            ///   System.Void SetDirection(System.Single dirX,System.Single dirY)
            /// </summary>
            /// <param name="dirX">struct System.Single</param>
            /// <param name="dirY">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_DIRECTION_01 (System.Single dirX,System.Single dirY);

            
            /// const string Name_Func_SET_DIRECTION = "SetDirection";
            /// <summary>
            ///   System.Void SetDirection(CharacterAnimation.Direction dir)
            /// </summary>
            /// <param name="dir">enum CharacterAnimation.Direction</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void SET_DIRECTION_02 (CharacterAnimation.Direction dir);

            
            /// const string Name_Func_START = "Start";
            /// <summary>
            ///   System.Collections.IEnumerator Start()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /// public  extern nint START_00 ();

            
            /// const string Name_Func_START = "Start";
            /// <summary>
            ///   System.Collections.IEnumerator Start()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /// public  extern nint START_01 ();

            
            /// const string Name_Func_START_COROUTINE = "StartCoroutine";
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// public  extern nint START_COROUTINE_00 (nint methodName);

            
            /// const string Name_Func_START_COROUTINE = "StartCoroutine";
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName,System.Object value)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <param name="value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// public  extern nint START_COROUTINE_01 (nint methodName,nint value);

            
            /// const string Name_Func_START_COROUTINE = "StartCoroutine";
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
            /// public  extern nint START_COROUTINE_02 (nint routine);

            
            /// const string Name_Func_STOP_COROUTINE = "StopCoroutine";
            /// <summary>
            ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name="routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void STOP_COROUTINE_00 (nint routine);

            
            /// const string Name_Func_STOP_COROUTINE = "StopCoroutine";
            /// <summary>
            ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name="routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void STOP_COROUTINE_01 (nint routine);

            
            /// const string Name_Func_STOP_COROUTINE = "StopCoroutine";
            /// <summary>
            ///   System.Void StopCoroutine(System.String methodName)
            /// </summary>
            /// <param name="methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// public  extern void STOP_COROUTINE_02 (nint methodName);

            
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

            
            /// const string Name_Func_TRY_GET_COMPONENT = "TryGetComponent";
            /// <summary>
            ///   System.Boolean TryGetComponent(System.Type type,UnityEngine.Component& component)
            /// </summary>
            /// <param name="type">abstract class System.Type</param>
            /// <param name="component">class UnityEngine.Component&</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean TRY_GET_COMPONENT_00 (nint type,nint component);

            
            /// const string Name_Func_TRY_GET_COMPONENT = "TryGetComponent";
            /// <summary>
            ///   System.Boolean TryGetComponent(T& component)
            /// </summary>
            /// <param name="component">class T&</param>
            /// <returns>struct System.Boolean</returns>
            /// public  extern System.Boolean TRY_GET_COMPONENT_01 (nint component);

            
            /// public static partial class Search_PlayerCharacter
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
                    ///   System.Void AddExp(System.Collections.Generic.List<BattleMonsterController> defeatedEnemies)
                    /// </summary>
                    /// public static bool ADD_EXP_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddExp", "System.Collections.Generic.List<BattleMonsterController>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddExp(System.Int32 count)
                    /// </summary>
                    /// public static bool ADD_EXP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddExp", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CancelInvoke()
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CancelInvoke(System.String methodName)
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
                    /// </summary>
                    /// public static bool CANCEL_INVOKE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "UnityEngine.MonoBehaviour", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Deserialize(System.String dataStr)
                    /// </summary>
                    /// public static bool DESERIALIZE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Deserialize", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Deserialize(System.String dataStr)
                    /// </summary>
                    /// public static bool DESERIALIZE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Deserialize", "System.String");
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
                    ///   System.Void Equip(Equipment item)
                    /// </summary>
                    /// public static bool EQUIP_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equip", "Equipment");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Equip(MeleeWeapon item)
                    /// </summary>
                    /// public static bool EQUIP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equip", "MeleeWeapon");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Equip(RangedWeapon item)
                    /// </summary>
                    /// public static bool EQUIP_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equip", "RangedWeapon");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Equip(Armor item)
                    /// </summary>
                    /// public static bool EQUIP_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equip", "Armor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Equip(Accessory item)
                    /// </summary>
                    /// public static bool EQUIP_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equip", "Accessory");
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
                    ///   UnityEngine.Component GetComponent(System.Type type)
                    /// </summary>
                    /// public static bool GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponent()
                    /// </summary>
                    /// public static bool GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInChildren(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInChildren(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInChildren()
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component GetComponentInParent(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInParent(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T GetComponentInParent()
                    /// </summary>
                    /// public static bool GET_COMPONENT_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponents(System.Type type)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type", "System.Collections.Generic.List<UnityEngine.Component>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponents()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInChildren()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_CHILDREN_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInParent(System.Boolean includeInactive)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean", "System.Collections.Generic.List<T>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T[] GetComponentsInParent()
                    /// </summary>
                    /// public static bool GET_COMPONENTS_IN_PARENT_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Single GetMagicAttackPower()
                    /// </summary>
                    /// public static bool GET_MAGIC_ATTACK_POWER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMagicAttackPower");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Single GetMagicAttackPower(PersonaProgress persona)
                    /// </summary>
                    /// public static bool GET_MAGIC_ATTACK_POWER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMagicAttackPower", "PersonaProgress");
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
                    ///   System.Int32 GetMaxHP()
                    /// </summary>
                    /// public static bool GET_MAX_HP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMaxHP");
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
                    ///   System.Boolean IsInvoking()
                    /// </summary>
                    /// public static bool IS_INVOKING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsInvoking(System.String methodName)
                    /// </summary>
                    /// public static bool IS_INVOKING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
                    /// </summary>
                    /// public static bool IS_INVOKING_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "UnityEngine.MonoBehaviour", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String Serialize()
                    /// </summary>
                    /// public static bool SERIALIZE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Serialize");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String Serialize()
                    /// </summary>
                    /// public static bool SERIALIZE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Serialize");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetDirection(System.Single dirX, System.Single dirY)
                    /// </summary>
                    /// public static bool SET_DIRECTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetDirection", "System.Single", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetDirection(System.Single dirX, System.Single dirY)
                    /// </summary>
                    /// public static bool SET_DIRECTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetDirection", "System.Single", "System.Single");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetDirection(CharacterAnimation.Direction dir)
                    /// </summary>
                    /// public static bool SET_DIRECTION_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetDirection", "CharacterAnimation.Direction");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Collections.IEnumerator Start()
                    /// </summary>
                    /// public static bool START_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Start");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Collections.IEnumerator Start()
                    /// </summary>
                    /// public static bool START_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Start");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
                    /// </summary>
                    /// public static bool START_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
                    /// </summary>
                    /// public static bool START_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String", "System.Object");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
                    /// </summary>
                    /// public static bool START_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.Collections.IEnumerator");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.Collections.IEnumerator");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "UnityEngine.Coroutine");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void StopCoroutine(System.String methodName)
                    /// </summary>
                    /// public static bool STOP_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.String");
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

                    
                    /// <summary>
                    ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
                    /// </summary>
                    /// public static bool TRY_GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "System.Type", "UnityEngine.Component&");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean TryGetComponent(T& component)
                    /// </summary>
                    /// public static bool TRY_GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "T&");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}