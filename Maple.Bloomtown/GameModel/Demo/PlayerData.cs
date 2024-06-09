using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Bloomtown.GameModel.Demo
{

    /// <summary>
    /// class ["Assembly-CSharp".""."PlayerData"]
    /// [UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// [ISaveable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x0200043BU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [80, 108, 97, 121, 101, 114, 68, 97, 116, 97])]
    public partial class PlayerData
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PlayerData";
        //public static byte[] Static_ClassName { get; } = [80, 108, 97, 121, 101, 114, 68, 97, 116, 97];

        //public const uint Const_TypeToken = 0x0200043BU;




        public readonly unsafe partial struct Const_PlayerData
        {



            /// <summary>
            /// class System.String SaveTag "playerData"
            /// </summary>
            /// public nint SAVE_TAG=>"playerData";


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
        public readonly unsafe partial struct Static_PlayerData
        {



            /// const string Name_Field_instance = "instance";
            /// <summary>
            /// class 0x0 PlayerData instance
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            [MonoCollectorStaticProperty(PropertyName = "Instance")]
            public readonly PlayerData.Ptr_PlayerData instance;


            /// const string Name_Field_OffsetOfInstanceIDInCPlusPlusObject = "OffsetOfInstanceIDInCPlusPlusObject";
            /// <summary>
            /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        }


        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public unsafe partial struct Ref_PlayerData
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


            /// const string Name_Field_m_CancellationTokenSource = "m_CancellationTokenSource";
            /// <summary>
            /// class 0x18 System.Threading.CancellationTokenSource m_CancellationTokenSource
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public readonly nint m_CancellationTokenSource;


            /// const string Name_Field_player = "player";
            /// <summary>
            /// class 0x20 PlayerCharacter player
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            [MonoCollectorProperty(PropertyName = "Player")]
            public readonly PlayerCharacter.Ptr_PlayerCharacter player;


            /// const string Name_Field_gameSettings = "gameSettings";
            /// <summary>
            /// class 0x28 GameSettings gameSettings
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            [MonoCollectorProperty(PropertyName = "GameSettings")]
            public readonly GameSettings.Ptr_GameSettings gameSettings;


            /// const string Name_Field_m_openedLocations = "m_openedLocations";
            /// <summary>
            /// class 0x30 System.Collections.Generic.List<Location> m_openedLocations
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint m_openedLocations;


            /// const string Name_Field_startFairQuestStage = "startFairQuestStage";
            /// <summary>
            /// class 0x38 QuestStage startFairQuestStage
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint startFairQuestStage;


            /// const string Name_Field_startFairCutscene = "startFairCutscene";
            /// <summary>
            /// class 0x40 Unity.VisualScripting.ScriptMachine startFairCutscene
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly nint startFairCutscene;


            /// const string Name_Field_personasCaught = "personasCaught";
            /// <summary>
            /// class 0x48 System.Collections.Generic.List<PersonaProgress> personasCaught
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            [MonoCollectorProperty(PropertyName = "PersonasCaught")]
            public readonly PMonoList_S<PersonaProgress.Ptr_PersonaProgress> personasCaught;


            /// const string Name_Field_followers = "followers";
            /// <summary>
            /// class 0x50 System.Collections.Generic.List<Follower> followers
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly nint followers;


            /// const string Name_Field_keys = "keys";
            /// <summary>
            /// class 0x58 System.Collections.Generic.List<System.String> keys
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            public readonly nint keys;


            /// const string Name_Field_oneDayKeys = "oneDayKeys";
            /// <summary>
            /// class 0x60 System.Collections.Generic.List<System.String> oneDayKeys
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            public readonly nint oneDayKeys;


            /// const string Name_Field_m_interactedConfidantsToday = "m_interactedConfidantsToday";
            /// <summary>
            /// class 0x68 System.Collections.Generic.List<System.String> m_interactedConfidantsToday
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x68)]
            public readonly nint m_interactedConfidantsToday;


            /// const string Name_Field_openedDoors = "openedDoors";
            /// <summary>
            /// class 0x70 System.Collections.Generic.List<System.String> openedDoors
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x70)]
            public readonly nint openedDoors;


            /// const string Name_Field_counters = "counters";
            /// <summary>
            /// class 0x78 System.Collections.Generic.List<System.String> counters
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x78)]
            public readonly nint counters;


            /// const string Name_Field_countersValues = "countersValues";
            /// <summary>
            /// class 0x80 System.Collections.Generic.List<System.Int32> countersValues
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x80)]
            public readonly nint countersValues;


            /// const string Name_Field_eventEntrance = "eventEntrance";
            /// <summary>
            /// class 0x88 UnityEngine.Events.UnityEvent eventEntrance
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x88)]
            public readonly nint eventEntrance;


            /// const string Name_Field_m_currentInterior = "m_currentInterior";
            /// <summary>
            /// class 0x90 BuildingInterior m_currentInterior
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x90)]
            public readonly nint m_currentInterior;


            /// const string Name_Field_m_logger = "m_logger";
            /// <summary>
            /// class 0x98 Logger m_logger
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x98)]
            public readonly nint m_logger;


            /// const string Name_Field_openedTravelPoints = "openedTravelPoints";
            /// <summary>
            /// class 0xA0 System.Collections.Generic.List<TravelPoint> openedTravelPoints
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA0)]
            public readonly nint openedTravelPoints;


            /// const string Name_Field_m_gameLogs = "m_gameLogs";
            /// <summary>
            /// class 0xA8 System.Collections.Generic.List<PlayerData.GameLog> m_gameLogs
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA8)]
            public readonly nint m_gameLogs;


            /// const string Name_Field_m_poolLoadedLocalNames = "m_poolLoadedLocalNames";
            /// <summary>
            /// class 0xB0 System.Collections.Generic.Dictionary<System.String,LocalizedName> m_poolLoadedLocalNames
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB0)]
            public readonly nint m_poolLoadedLocalNames;


            /// const string Name_Field_m_confidantMetData = "m_confidantMetData";
            /// <summary>
            /// class 0xB8 System.Collections.Generic.List<PlayerData.ConfidantData> m_confidantMetData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB8)]
            public readonly nint m_confidantMetData;


            /// const string Name_Field_m_battleMonstersData = "m_battleMonstersData";
            /// <summary>
            /// class 0xC0 System.Collections.Generic.List<PlayerData.BattleMonsterData> m_battleMonstersData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC0)]
            public readonly nint m_battleMonstersData;


            /// const string Name_Field_m_availableRecipes = "m_availableRecipes";
            /// <summary>
            /// class 0xC8 System.Collections.Generic.List<Recipe> m_availableRecipes
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC8)]
            public readonly nint m_availableRecipes;


            /// const string Name_Field_m_booksProgress = "m_booksProgress";
            /// <summary>
            /// class 0xD0 System.Collections.Generic.Dictionary<Book,Book.BookData> m_booksProgress
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD0)]
            public readonly nint m_booksProgress;


            /// const string Name_Field_InventoryCountData = "InventoryCountData";
            /// <summary>
            /// class 0xD8 System.Collections.Generic.Dictionary<Stackable,System.Int32> InventoryCountData
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD8)]
            public readonly nint InventoryCountData;


            /// const string Name_Field_selectedRod = "selectedRod";
            /// <summary>
            /// class 0xE0 Rod selectedRod
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE0)]
            public readonly nint selectedRod;


            /// const string Name_Field_selectedBait = "selectedBait";
            /// <summary>
            /// class 0xE8 Bait selectedBait
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE8)]
            public readonly nint selectedBait;


            /// const string Name_Field_OnInteriorEntered = "OnInteriorEntered";
            /// <summary>
            /// class 0xF0 System.Action OnInteriorEntered
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF0)]
            public readonly nint OnInteriorEntered;


            /// const string Name_Field_OnInteriorLeft = "OnInteriorLeft";
            /// <summary>
            /// class 0xF8 System.Action OnInteriorLeft
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF8)]
            public readonly nint OnInteriorLeft;


            /// const string Name_Field_m_money = "m_money";
            /// <summary>
            /// struct 0x100 System.Single m_money
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x100)]
            [MonoCollectorProperty(PropertyName = "Money")]
            public System.Single m_money;


            /// const string Name_Field_m_essence = "m_essence";
            /// <summary>
            /// struct 0x104 System.Int32 m_essence
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x104)]
            public readonly System.Int32 m_essence;


            /// const string Name_Field_m_candy = "m_candy";
            /// <summary>
            /// struct 0x108 System.Int32 m_candy
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x108)]
            public readonly System.Int32 m_candy;


            /// const string Name_Field_m_pointPosition = "m_pointPosition";
            /// <summary>
            /// struct 0x10C System.Boolean m_pointPosition
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10C)]
            public readonly System.Boolean m_pointPosition;


            /// const string Name_Field_m_isGoingHome = "m_isGoingHome";
            /// <summary>
            /// struct 0x10D System.Boolean m_isGoingHome
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10D)]
            public readonly System.Boolean m_isGoingHome;


            /// const string Name_Field_m_savedPlaytime = "m_savedPlaytime";
            /// <summary>
            /// struct 0x110 System.Single m_savedPlaytime
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x110)]
            public readonly System.Single m_savedPlaytime;


            /// const string Name_Field_m_timeTrackingStarted = "m_timeTrackingStarted";
            /// <summary>
            /// struct 0x114 System.Single m_timeTrackingStarted
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x114)]
            public readonly System.Single m_timeTrackingStarted;


            /// const string Name_Field_m_battlesFinished = "m_battlesFinished";
            /// <summary>
            /// struct 0x118 System.Int32 m_battlesFinished
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x118)]
            public readonly System.Int32 m_battlesFinished;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PlayerData(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PlayerData(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PlayerData obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_PlayerData AsRef()
            {
                return ref Unsafe.AsRef<Ref_PlayerData>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."PlayerData"]
    /// </summary>
    public partial class PlayerData
    {



        /// const string Name_Func_.CCTOR = ".cctor";
        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void .CCTOR ();


        /// const string Name_Func_ADD_ON_INTERIOR_ENTERED = "add_OnInteriorEntered";
        /// <summary>
        ///   System.Void add_OnInteriorEntered(System.Action value)
        /// </summary>
        /// <param name="value">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_ON_INTERIOR_ENTERED (nint value);


        /// const string Name_Func_ADD_ON_INTERIOR_LEFT = "add_OnInteriorLeft";
        /// <summary>
        ///   System.Void add_OnInteriorLeft(System.Action value)
        /// </summary>
        /// <param name="value">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_ON_INTERIOR_LEFT (nint value);


        /// const string Name_Func_ADD_EQUIPMENT = "AddEquipment";
        /// <summary>
        ///   System.Void AddEquipment(Equipment equipment,System.Int32 count,System.Boolean autoEquip)
        /// </summary>
        /// <param name="equipment">abstract class Equipment</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="autoEquip">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_EQUIPMENT (nint equipment,System.Int32 count,System.Boolean autoEquip);


        /// const string Name_Func_ADD_ITEM_BY_UID = "AddItemByUID";
        /// <summary>
        ///   System.Void AddItemByUID(System.String itemUID,System.Int32 count)
        /// </summary>
        /// <param name="itemUID">class System.String</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_ITEM_BY_UID (nint itemUID,System.Int32 count);


        /// const string Name_Func_ADD_KEY = "AddKey";
        /// <summary>
        ///   System.Void AddKey(System.String key,System.Boolean onceDay)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="onceDay">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_KEY (nint key,System.Boolean onceDay);


        /// const string Name_Func_ADD_OPENED_TRAVEL_POINT = "AddOpenedTravelPoint";
        /// <summary>
        ///   System.Void AddOpenedTravelPoint(TravelPoint travelPoint)
        /// </summary>
        /// <param name="travelPoint">class TravelPoint</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_OPENED_TRAVEL_POINT (nint travelPoint);


        /// const string Name_Func_ADD_TREASURE = "AddTreasure";
        /// <summary>
        ///   System.Void AddTreasure(Treasure treasure,System.Int32 count)
        /// </summary>
        /// <param name="treasure">class Treasure</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ADD_TREASURE (nint treasure,System.Int32 count);


        /// const string Name_Func_CHECK_COUNTER = "CheckCounter";
        /// <summary>
        ///   System.Boolean CheckCounter(System.String key,System.Int32 targetValue)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="targetValue">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean CHECK_COUNTER (nint key,System.Int32 targetValue);


        /// const string Name_Func_CHECK_NULL_ARGUMENT = "CheckNullArgument";
        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg,System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void CHECK_NULL_ARGUMENT (nint arg,nint message);


        /// const string Name_Func_CLEAR_GAME_LOG = "ClearGameLog";
        /// <summary>
        /// static  System.Void ClearGameLog()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void CLEAR_GAME_LOG ();


        /// const string Name_Func_CLEAR_INTERACTED_CONFIDANTS = "ClearInteractedConfidants";
        /// <summary>
        ///   System.Void ClearInteractedConfidants()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void CLEAR_INTERACTED_CONFIDANTS ();


        /// const string Name_Func_CLEAR_ONE_DAY_KEYS = "ClearOneDayKeys";
        /// <summary>
        ///   System.Void ClearOneDayKeys()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void CLEAR_ONE_DAY_KEYS ();


        /// const string Name_Func_CLEAR_UNLOCKED_LOCATIONS = "ClearUnlockedLocations";
        /// <summary>
        ///   System.Void ClearUnlockedLocations()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void CLEAR_UNLOCKED_LOCATIONS ();


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


        const string Name_Func_DEBUG_ADD_PERSONA = "DebugAddPersona";
        /// <summary>
        ///   System.Void DebugAddPersona()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [MonoCollectorMethod(Name_Func_DEBUG_ADD_PERSONA)]
        extern void DEBUG_ADD_PERSONA();


        /// const string Name_Func_DECREASE_COUNTER = "DecreaseCounter";
        /// <summary>
        ///   System.Void DecreaseCounter(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DECREASE_COUNTER (nint key);


        /// const string Name_Func_DESERIALIZE = "Deserialize";
        /// <summary>
        ///   System.Void Deserialize(System.String dataStr)
        /// </summary>
        /// <param name="dataStr">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void DESERIALIZE (nint dataStr);


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


        /// const string Name_Func_GET_BAITS = "get_baits";
        /// <summary>
        ///   System.Collections.Generic.List<Bait> get_baits()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Bait></returns>
        /// public  extern nint GET_BAITS ();


        /// const string Name_Func_GET_BOOKS = "get_books";
        /// <summary>
        ///   System.Collections.Generic.List<Book> get_books()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Book></returns>
        /// public  extern nint GET_BOOKS ();


        /// const string Name_Func_GET_CANDY = "get_candy";
        /// <summary>
        ///   System.Int32 get_candy()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_CANDY ();


        /// const string Name_Func_GET_CONFIDANT_GIFTS = "get_confidantGifts";
        /// <summary>
        ///   System.Collections.Generic.List<ConfidantGift> get_confidantGifts()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<ConfidantGift></returns>
        /// public  extern nint GET_CONFIDANT_GIFTS ();


        /// const string Name_Func_GET_CONFIDANTS_MET = "get_confidantsMet";
        /// <summary>
        ///   System.Collections.Generic.List<ConfidantInfo> get_confidantsMet()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<ConfidantInfo></returns>
        /// public  extern nint GET_CONFIDANTS_MET ();


        /// const string Name_Func_GET_CRAFT_MATERIALS = "get_craftMaterials";
        /// <summary>
        ///   System.Collections.Generic.List<CraftMaterial> get_craftMaterials()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<CraftMaterial></returns>
        /// public  extern nint GET_CRAFT_MATERIALS ();


        /// const string Name_Func_GET_DESTROY_CANCELLATION_TOKEN = "get_destroyCancellationToken";
        /// <summary>
        ///   System.Threading.CancellationToken get_destroyCancellationToken()
        /// </summary>
        /// <returns>struct System.Threading.CancellationToken</returns>
        /// public  extern System.Threading.CancellationToken GET_DESTROY_CANCELLATION_TOKEN ();


        /// const string Name_Func_GET_ENABLED = "get_enabled";
        /// <summary>
        ///   System.Boolean get_enabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_ENABLED ();


        /// const string Name_Func_GET_EQUIPMENTS = "get_equipments";
        /// <summary>
        ///   System.Collections.Generic.List<Equipment> get_equipments()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Equipment></returns>
        /// public  extern nint GET_EQUIPMENTS ();


        /// const string Name_Func_GET_ESSENCE = "get_essence";
        /// <summary>
        ///   System.Int32 get_essence()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_ESSENCE ();


        /// const string Name_Func_GET_FERTILIZERS = "get_fertilizers";
        /// <summary>
        ///   System.Collections.Generic.List<Fertilizer> get_fertilizers()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Fertilizer></returns>
        /// public  extern nint GET_FERTILIZERS ();


        /// const string Name_Func_GET_GAME_OBJECT = "get_gameObject";
        /// <summary>
        ///   UnityEngine.GameObject get_gameObject()
        /// </summary>
        /// <returns>class UnityEngine.GameObject</returns>
        /// public  extern nint GET_GAME_OBJECT ();


        /// const string Name_Func_GET_GET_LOCATION_FOLLOWERS = "get_getLocationFollowers";
        /// <summary>
        ///   System.Collections.Generic.List<LocationFollower> get_getLocationFollowers()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<LocationFollower></returns>
        /// public  extern nint GET_GET_LOCATION_FOLLOWERS ();


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


        /// const string Name_Func_GET_ITEMS = "get_items";
        /// <summary>
        ///   System.Collections.Generic.List<Consumable> get_items()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Consumable></returns>
        /// public  extern nint GET_ITEMS ();


        /// const string Name_Func_GET_LOCKPICKS = "get_lockpicks";
        /// <summary>
        ///   Lockpick get_lockpicks()
        /// </summary>
        /// <returns>class Lockpick</returns>
        /// public  extern nint GET_LOCKPICKS ();


        /// const string Name_Func_GET_MONEY = "get_money";
        /// <summary>
        ///   System.Single get_money()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_MONEY ();


        /// const string Name_Func_GET_NAME = "get_name";
        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_NAME ();


        /// const string Name_Func_GET_QUEST_ITEMS = "get_questItems";
        /// <summary>
        ///   System.Collections.Generic.List<QuestItem> get_questItems()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<QuestItem></returns>
        /// public  extern nint GET_QUEST_ITEMS ();


        /// const string Name_Func_GET_RODS = "get_rods";
        /// <summary>
        ///   System.Collections.Generic.List<Rod> get_rods()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Rod></returns>
        /// public  extern nint GET_RODS ();


        /// const string Name_Func_GET_SEEDS = "get_seeds";
        /// <summary>
        ///   System.Collections.Generic.List<Seed> get_seeds()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Seed></returns>
        /// public  extern nint GET_SEEDS ();


        /// const string Name_Func_GET_SELLABLE_EQUIPMENT = "get_sellableEquipment";
        /// <summary>
        ///   System.Collections.Generic.List<Equipment> get_sellableEquipment()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Equipment></returns>
        /// public  extern nint GET_SELLABLE_EQUIPMENT ();


        /// const string Name_Func_GET_SOOTY_EQUIPMENT = "get_sootyEquipment";
        /// <summary>
        ///   System.Collections.Generic.List<Equipment> get_sootyEquipment()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Equipment></returns>
        /// public  extern nint GET_SOOTY_EQUIPMENT ();


        /// const string Name_Func_GET_SOOTY_EQUIPMENT_COUNT = "get_sootyEquipmentCount";
        /// <summary>
        ///   System.Int32 get_sootyEquipmentCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_SOOTY_EQUIPMENT_COUNT ();


        /// const string Name_Func_GET_SPARE_EQUIPMENT = "get_spareEquipment";
        /// <summary>
        ///   System.Collections.Generic.List<Equipment> get_spareEquipment()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Equipment></returns>
        /// public  extern nint GET_SPARE_EQUIPMENT ();


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


        /// const string Name_Func_GET_TREASURES = "get_treasures";
        /// <summary>
        ///   System.Collections.Generic.List<Treasure> get_treasures()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Treasure></returns>
        /// public  extern nint GET_TREASURES ();


        /// const string Name_Func_GET_USE_GUI_LAYOUT = "get_useGUILayout";
        /// <summary>
        ///   System.Boolean get_useGUILayout()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_USE_GUI_LAYOUT ();


        /// const string Name_Func_GET_BATTLE_MONSTER_DATA = "GetBattleMonsterData";
        /// <summary>
        ///   PlayerData.BattleMonsterData GetBattleMonsterData(System.String uid)
        /// </summary>
        /// <param name="uid">class System.String</param>
        /// <returns>class PlayerData.BattleMonsterData</returns>
        /// public  extern nint GET_BATTLE_MONSTER_DATA (nint uid);


        /// const string Name_Func_GET_BATTLES_ON_SAVE = "GetBattlesOnSave";
        /// <summary>
        /// static  System.Int32 GetBattlesOnSave()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 GET_BATTLES_ON_SAVE ();


        /// const string Name_Func_GET_BOOK_DATA = "GetBookData";
        /// <summary>
        ///   Book.BookData GetBookData(Book book)
        /// </summary>
        /// <param name="book">class Book</param>
        /// <returns>class Book.BookData</returns>
        /// public  extern nint GET_BOOK_DATA (nint book);


        /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_CACHED_PTR ();


        /// const string Name_Func_GET_CAUGHT_PERSONAS = "GetCaughtPersonas";
        /// <summary>
        ///   System.Collections.Generic.List<PersonaProgress> GetCaughtPersonas()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<PersonaProgress></returns>
        /// public  extern nint GET_CAUGHT_PERSONAS ();


        const string Name_Func_GET_CHARACTER = "GetCharacter";
        /// <summary>
        ///   Character GetCharacter(System.String uid)
        /// </summary>
        /// <param name="uid">class System.String</param>
        /// <returns>class Character</returns>
        [MonoCollectorMethod(Name_Func_GET_CHARACTER)]
        extern Character.Ptr_Character GET_CHARACTER(nint uid);


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


        /// const string Name_Func_GET_CONFIDANT_DATA = "GetConfidantData";
        /// <summary>
        ///   PlayerData.ConfidantData GetConfidantData(ConfidantInfo confidantInfo)
        /// </summary>
        /// <param name="confidantInfo">class ConfidantInfo</param>
        /// <returns>class PlayerData.ConfidantData</returns>
        /// public  extern nint GET_CONFIDANT_DATA (nint confidantInfo);


        /// const string Name_Func_GET_CONFIDANT_MET = "GetConfidantMet";
        /// <summary>
        ///   System.Collections.Generic.List<ConfidantInfo> GetConfidantMet()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<ConfidantInfo></returns>
        /// public  extern nint GET_CONFIDANT_MET ();


        /// const string Name_Func_GET_COUNTER_VALUE = "GetCounterValue";
        /// <summary>
        ///   System.Int32 GetCounterValue(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_COUNTER_VALUE (nint key);


        /// const string Name_Func_GET_FORMATTED_LOGS = "GetFormattedLogs";
        /// <summary>
        /// static  System.Collections.Generic.List<PlayerData.GameLog> GetFormattedLogs()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<PlayerData.GameLog></returns>
        /// public static extern nint GET_FORMATTED_LOGS ();


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


        /// const string Name_Func_GET_INTERIOR_BUILDING = "GetInteriorBuilding";
        /// <summary>
        ///   BuildingInterior GetInteriorBuilding()
        /// </summary>
        /// <returns>class BuildingInterior</returns>
        /// public  extern nint GET_INTERIOR_BUILDING ();


        const string Name_Func_GET_ITEM_IN_INVENTORY_COUNT = "GetItemInInventoryCount";
        /// <summary>
        ///   System.Int32 GetItemInInventoryCount(Stackable obj)
        /// </summary>
        /// <param name="obj">abstract class Stackable</param>
        /// <returns>struct System.Int32</returns>
        [MonoCollectorMethod(Name_Func_GET_ITEM_IN_INVENTORY_COUNT)]
        extern System.Int32 GET_ITEM_IN_INVENTORY_COUNT(nint obj);


        /// const string Name_Func_GET_ITEM_NAME = "GetItemName";
        /// <summary>
        ///   System.String GetItemName(System.String itemUID)
        /// </summary>
        /// <param name="itemUID">class System.String</param>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_ITEM_NAME (nint itemUID);


        /// const string Name_Func_GET_ITEMS_OF_CATEGORY = "GetItemsOfCategory";
        /// <summary>
        ///   System.Collections.Generic.List<Stackable> GetItemsOfCategory(Uroboros.Extension.ItemCategory category)
        /// </summary>
        /// <param name="category">enum Uroboros.Extension.ItemCategory</param>
        /// <returns>class System.Collections.Generic.List<Stackable></returns>
        /// public  extern nint GET_ITEMS_OF_CATEGORY (Uroboros.Extension.ItemCategory category);


        /// const string Name_Func_GET_KEY_LIST_FROM_DICTIONARY = "GetKeyListFromDictionary";
        /// <summary>
        ///   System.Collections.Generic.List<T> GetKeyListFromDictionary(System.Collections.Generic.Dictionary<T,TV> dictionary)
        /// </summary>
        /// <param name="dictionary">class System.Collections.Generic.Dictionary<T,TV></param>
        /// <returns>class System.Collections.Generic.List<T></returns>
        /// public  extern nint GET_KEY_LIST_FROM_DICTIONARY (nint dictionary);


        /// const string Name_Func_GET_LOCALIZED_OBJECT_NAME = "GetLocalizedObjectName";
        /// <summary>
        /// static  System.String GetLocalizedObjectName(System.String objectUid)
        /// </summary>
        /// <param name="objectUid">class System.String</param>
        /// <returns>class System.String</returns>
        /// public static extern nint GET_LOCALIZED_OBJECT_NAME (nint objectUid);


        /// const string Name_Func_GET_LOCALIZED_TEXT = "GetLocalizedText";
        /// <summary>
        /// static  System.String GetLocalizedText(System.String textUid)
        /// </summary>
        /// <param name="textUid">class System.String</param>
        /// <returns>class System.String</returns>
        /// public static extern nint GET_LOCALIZED_TEXT (nint textUid);


        /// const string Name_Func_GET_MONEY_AS_STRING = "GetMoneyAsString";
        /// <summary>
        ///   System.String GetMoneyAsString(System.Boolean showZero)
        /// </summary>
        /// <param name="showZero">struct System.Boolean</param>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_MONEY_AS_STRING (System.Boolean showZero);


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


        /// const string Name_Func_GET_OPENED_TRAVEL_POINTS = "GetOpenedTravelPoints";
        /// <summary>
        ///   System.Collections.Generic.List<TravelPoint> GetOpenedTravelPoints()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<TravelPoint></returns>
        /// public  extern nint GET_OPENED_TRAVEL_POINTS ();


        const string Name_Func_GET_PLAYER_GROUP = "GetPlayerGroup";
        /// <summary>
        ///   System.Collections.Generic.List<Character> GetPlayerGroup()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Character></returns>
        [MonoCollectorMethod(Name_Func_GET_PLAYER_GROUP)]
        extern PMonoList_S<Character.Ptr_Character> GET_PLAYER_GROUP();


        /// const string Name_Func_GET_PLAYTIME_ON_SAVE = "GetPlaytimeOnSave";
        /// <summary>
        ///   System.Single GetPlaytimeOnSave()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public  extern System.Single GET_PLAYTIME_ON_SAVE ();


        /// const string Name_Func_GET_POINT_POSITION = "GetPointPosition";
        /// <summary>
        ///   System.Boolean GetPointPosition()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean GET_POINT_POSITION ();


        /// const string Name_Func_GET_SAVE_TRACKED_TIME = "GetSaveTrackedTime";
        /// <summary>
        /// static  System.Single GetSaveTrackedTime()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public static extern System.Single GET_SAVE_TRACKED_TIME ();


        /// const string Name_Func_GET_SCRIPT_CLASS_NAME = "GetScriptClassName";
        /// <summary>
        ///   System.String GetScriptClassName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_SCRIPT_CLASS_NAME ();


        /// const string Name_Func_GET_STACKABLE_BY_UID = "GetStackableByUID";
        /// <summary>
        ///   Stackable GetStackableByUID(System.String itemUID)
        /// </summary>
        /// <param name="itemUID">class System.String</param>
        /// <returns>abstract class Stackable</returns>
        /// public  extern nint GET_STACKABLE_BY_UID (nint itemUID);


        /// const string Name_Func_GET_TYPE_LIST_FROM_INVENTORY = "GetTypeListFromInventory";
        /// <summary>
        ///   System.Collections.Generic.List<T> GetTypeListFromInventory()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<T></returns>
        /// public  extern nint GET_TYPE_LIST_FROM_INVENTORY ();


        /// const string Name_Func_GO_HOME = "GoHome";
        /// <summary>
        ///   System.Collections.IEnumerator GoHome()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// public  extern nint GO_HOME ();


        /// const string Name_Func_HAVE_KEY = "HaveKey";
        /// <summary>
        ///   System.Boolean HaveKey(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean HAVE_KEY (nint key);


        /// const string Name_Func_INCREASE_COUNTER = "IncreaseCounter";
        /// <summary>
        ///   System.Void IncreaseCounter(System.String key,System.Int32 increaseBy)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="increaseBy">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void INCREASE_COUNTER (nint key,System.Int32 increaseBy);


        /// const string Name_Func_INCREASE_EMILY_ADDITIONAL_HP = "IncreaseEmilyAdditionalHP";
        /// <summary>
        ///   System.Void IncreaseEmilyAdditionalHP(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void INCREASE_EMILY_ADDITIONAL_HP (System.Int32 value);


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


        const string Name_Func_IS_AVAILABLE_RECIPE = "IsAvailableRecipe";
        /// <summary>
        ///   System.Boolean IsAvailableRecipe(Recipe recipe)
        /// </summary>
        /// <param name="recipe">class Recipe</param>
        /// <returns>struct System.Boolean</returns>
        [MonoCollectorMethod(Name_Func_IS_AVAILABLE_RECIPE)]
        extern System.Boolean IS_AVAILABLE_RECIPE(nint recipe);


        /// const string Name_Func_IS_ENTERED_BUILDING = "IsEnteredBuilding";
        /// <summary>
        ///   System.Boolean IsEnteredBuilding()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_ENTERED_BUILDING ();


        /// const string Name_Func_IS_INTERACTED_WITH_CONFIDANT_TODAY = "IsInteractedWithConfidantToday";
        /// <summary>
        ///   System.Boolean IsInteractedWithConfidantToday(ConfidantInfo confidantInfo)
        /// </summary>
        /// <param name="confidantInfo">class ConfidantInfo</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_INTERACTED_WITH_CONFIDANT_TODAY (nint confidantInfo);


        /// const string Name_Func_IS_LOCATION_OPEN = "IsLocationOpen";
        /// <summary>
        ///   System.Boolean IsLocationOpen(System.String sceneName)
        /// </summary>
        /// <param name="sceneName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_LOCATION_OPEN (nint sceneName);


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


        /// const string Name_Func_IS_PERSONAS_ENABLED = "IsPersonasEnabled";
        /// <summary>
        ///   System.Boolean IsPersonasEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean IS_PERSONAS_ENABLED ();


        const string Name_Func_LEARN_RECIPE = "LearnRecipe";
        /// <summary>
        ///   System.Void LearnRecipe(Recipe recipe)
        /// </summary>
        /// <param name="recipe">class Recipe</param>
        /// <returns>struct System.Void</returns>
        [MonoCollectorMethod(Name_Func_LEARN_RECIPE)]
        extern void LEARN_RECIPE(nint recipe);


        /// const string Name_Func_LOAD_DEFAULT_TRAVEL_POINTS = "LoadDefaultTravelPoints";
        /// <summary>
        ///   System.Void LoadDefaultTravelPoints()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void LOAD_DEFAULT_TRAVEL_POINTS ();


        /// const string Name_Func_LOCK_LOCATION = "LockLocation";
        /// <summary>
        ///   System.Void LockLocation(Location location)
        /// </summary>
        /// <param name="location">class Location</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void LOCK_LOCATION (nint location);


        /// const string Name_Func_MONEY_TO_STRING = "MoneyToString";
        /// <summary>
        /// static  System.String MoneyToString(System.Single money,System.Boolean showZero)
        /// </summary>
        /// <param name="money">struct System.Single</param>
        /// <param name="showZero">struct System.Boolean</param>
        /// <returns>class System.String</returns>
        /// public static extern nint MONEY_TO_STRING (System.Single money,System.Boolean showZero);


        /// const string Name_Func_ON_BATTLE_FINISHED = "OnBattleFinished";
        /// <summary>
        /// static  System.Void OnBattleFinished()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void ON_BATTLE_FINISHED ();


        /// const string Name_Func_ON_CANCELLATION_TOKEN_CREATED = "OnCancellationTokenCreated";
        /// <summary>
        ///   System.Void OnCancellationTokenCreated()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void ON_CANCELLATION_TOKEN_CREATED ();


        /// const string Name_Func_ON_DAY_ENDED = "OnDayEnded";
        /// <summary>
        ///   System.Void OnDayEnded()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void ON_DAY_ENDED ();


        /// const string Name_Func_ON_ENTERED_BUILDING = "OnEnteredBuilding";
        /// <summary>
        ///   System.Void OnEnteredBuilding(BuildingInterior interior)
        /// </summary>
        /// <param name="interior">class BuildingInterior</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ON_ENTERED_BUILDING (nint interior);


        /// const string Name_Func_ON_EXITED_BUILDING = "OnExitedBuilding";
        /// <summary>
        ///   System.Void OnExitedBuilding()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void ON_EXITED_BUILDING ();


        /// const string Name_Func_ON_INTERACTED_WITH_CONFIDANT = "OnInteractedWithConfidant";
        /// <summary>
        ///   System.Void OnInteractedWithConfidant(ConfidantInfo confidantInfo)
        /// </summary>
        /// <param name="confidantInfo">class ConfidantInfo</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void ON_INTERACTED_WITH_CONFIDANT (nint confidantInfo);


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


        /// const string Name_Func_PARSE_PERSONAS = "ParsePersonas";
        /// <summary>
        ///   System.Void ParsePersonas(System.String dataStr)
        /// </summary>
        /// <param name="dataStr">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void PARSE_PERSONAS (nint dataStr);


        /// const string Name_Func_PAUSE_FOLLOWERS = "PauseFollowers";
        /// <summary>
        ///   System.Void PauseFollowers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void PAUSE_FOLLOWERS ();


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


        /// const string Name_Func_REMOVE_ON_INTERIOR_ENTERED = "remove_OnInteriorEntered";
        /// <summary>
        ///   System.Void remove_OnInteriorEntered(System.Action value)
        /// </summary>
        /// <param name="value">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REMOVE_ON_INTERIOR_ENTERED (nint value);


        /// const string Name_Func_REMOVE_ON_INTERIOR_LEFT = "remove_OnInteriorLeft";
        /// <summary>
        ///   System.Void remove_OnInteriorLeft(System.Action value)
        /// </summary>
        /// <param name="value">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REMOVE_ON_INTERIOR_LEFT (nint value);


        /// const string Name_Func_REMOVE_KEY = "RemoveKey";
        /// <summary>
        ///   System.Void RemoveKey(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void REMOVE_KEY (nint key);


        const string Name_Func_REMOVE_LEARN_RECIPE = "RemoveLearnRecipe";
        /// <summary>
        ///   System.Void RemoveLearnRecipe(Recipe recipe)
        /// </summary>
        /// <param name="recipe">class Recipe</param>
        /// <returns>struct System.Void</returns>
        [MonoCollectorMethod(Name_Func_REMOVE_LEARN_RECIPE)]
        extern void REMOVE_LEARN_RECIPE(nint recipe);


        /// const string Name_Func_RESTORE_PLAYER_GROUP_HP_SP = "RestorePlayerGroupHpSp";
        /// <summary>
        ///   System.Void RestorePlayerGroupHpSp()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void RESTORE_PLAYER_GROUP_HP_SP ();


        /// const string Name_Func_SERIALIZE = "Serialize";
        /// <summary>
        ///   System.String Serialize()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint SERIALIZE ();


        /// const string Name_Func_SET_CANDY = "set_candy";
        /// <summary>
        ///   System.Void set_candy(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_CANDY (System.Int32 value);


        /// const string Name_Func_SET_ENABLED = "set_enabled";
        /// <summary>
        ///   System.Void set_enabled(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_ENABLED (System.Boolean value);


        /// const string Name_Func_SET_ESSENCE = "set_essence";
        /// <summary>
        ///   System.Void set_essence(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_ESSENCE (System.Int32 value);


        /// const string Name_Func_SET_HIDE_FLAGS = "set_hideFlags";
        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);


        /// const string Name_Func_SET_MONEY = "set_money";
        /// <summary>
        ///   System.Void set_money(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_MONEY (System.Single value);


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


        /// const string Name_Func_SET_BATTLE_MONSTER_DATA = "SetBattleMonsterData";
        /// <summary>
        ///   System.Void SetBattleMonsterData(System.String uid)
        /// </summary>
        /// <param name="uid">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_BATTLE_MONSTER_DATA (nint uid);


        const string Name_Func_SET_BOOK_DATA = "SetBookData";
        /// <summary>
        ///   System.Void SetBookData(Book book,System.Int32 count,System.Single progress)
        /// </summary>
        /// <param name="book">class Book</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="progress">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        [MonoCollectorMethod(Name_Func_SET_BOOK_DATA)]
        extern void SET_BOOK_DATA(nint book, System.Int32 count, System.Single progress);


        /// const string Name_Func_SET_CONFIDANT_DATA = "SetConfidantData";
        /// <summary>
        ///   System.Void SetConfidantData(ConfidantInfo confidantInfo)
        /// </summary>
        /// <param name="confidantInfo">class ConfidantInfo</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_CONFIDANT_DATA (nint confidantInfo);


        /// const string Name_Func_SET_GAME_LOG = "SetGameLog";
        /// <summary>
        /// static  System.Void SetGameLog(LocalizedName unitName,System.String textUid)
        /// </summary>
        /// <param name="unitName">class LocalizedName</param>
        /// <param name="textUid">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_GAME_LOG (nint unitName,nint textUid);


        const string Name_Func_SET_ITEM_IN_INVENTORY_COUNT = "SetItemInInventoryCount";
        /// <summary>
        ///   System.Void SetItemInInventoryCount(Stackable obj,System.Int32 count)
        /// </summary>
        /// <param name="obj">abstract class Stackable</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [MonoCollectorMethod(Name_Func_SET_ITEM_IN_INVENTORY_COUNT)]
        extern void SET_ITEM_IN_INVENTORY_COUNT(nint obj, System.Int32 count);


        /// const string Name_Func_SET_NAME = "SetName";
        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_NAME (nint obj,nint name);


        /// const string Name_Func_SET_POINT_POSITION = "SetPointPosition";
        /// <summary>
        ///   System.Void SetPointPosition(System.Boolean active)
        /// </summary>
        /// <param name="active">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void SET_POINT_POSITION (System.Boolean active);


        /// const string Name_Func_START = "Start";
        /// <summary>
        ///   System.Void Start()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void START ();


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


        /// const string Name_Func_TAKE_ITEM_BY_UID = "TakeItemByUID";
        /// <summary>
        ///   System.Void TakeItemByUID(System.String itemUID,System.Int32 count)
        /// </summary>
        /// <param name="itemUID">class System.String</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void TAKE_ITEM_BY_UID (nint itemUID,System.Int32 count);


        /// const string Name_Func_TAKE_TREASURE = "TakeTreasure";
        /// <summary>
        ///   System.Void TakeTreasure(Treasure treasure,System.Int32 count)
        /// </summary>
        /// <param name="treasure">class Treasure</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void TAKE_TREASURE (nint treasure,System.Int32 count);


        /// const string Name_Func_TELEPORT_FOLLOWERS_TO_PLAYER = "TeleportFollowersToPlayer";
        /// <summary>
        ///   System.Void TeleportFollowersToPlayer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void TELEPORT_FOLLOWERS_TO_PLAYER ();


        /// const string Name_Func_TELEPORT_TO_ENTRANCE = "TeleportToEntrance";
        /// <summary>
        ///   System.Void TeleportToEntrance(Building building,TeleportingDoor door)
        /// </summary>
        /// <param name="building">abstract class Building</param>
        /// <param name="door">class TeleportingDoor</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void TELEPORT_TO_ENTRANCE (nint building,nint door);


        /// const string Name_Func_TELEPORT_TO_POSITION = "TeleportToPosition";
        /// <summary>
        ///   System.Void TeleportToPosition(UnityEngine.Vector2 position,CharacterAnimation.Direction direction)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector2</param>
        /// <param name="direction">enum CharacterAnimation.Direction</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void TELEPORT_TO_POSITION (UnityEngine.Vector2 position,CharacterAnimation.Direction direction);


        /// const string Name_Func_TRY_TO_EQUIP_AUTOMATICALLY = "TryToEquipAutomatically";
        /// <summary>
        ///   System.Void TryToEquipAutomatically(Equipment equipment)
        /// </summary>
        /// <param name="equipment">abstract class Equipment</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void TRY_TO_EQUIP_AUTOMATICALLY (nint equipment);


        /// const string Name_Func_UNLOCK_LOCATION = "UnlockLocation";
        /// <summary>
        ///   System.Void UnlockLocation(Location location)
        /// </summary>
        /// <param name="location">class Location</param>
        /// <returns>struct System.Void</returns>
        /// public  extern void UNLOCK_LOCATION (nint location);


        /// const string Name_Func_UNPAUSE_FOLLOWERS = "UnpauseFollowers";
        /// <summary>
        ///   System.Void UnpauseFollowers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void UNPAUSE_FOLLOWERS ();


        /// const string Name_Func_UPDATE = "Update";
        /// <summary>
        ///   System.Void Update()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void UPDATE ();



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
        ///   T GetComponentInParent()
        /// </summary>
        /// <returns>class T</returns>
        /// public  extern nint GET_COMPONENT_IN_PARENT_02 ();


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


        /// public static partial class Search_PlayerData
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
        ///   T GetComponentInParent()
        /// </summary>
        /// public static bool GET_COMPONENT_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
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
