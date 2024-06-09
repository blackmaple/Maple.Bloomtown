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
    /// class ["Assembly-CSharp".""."UIManager"]
    /// [UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000480U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [85, 73, 77, 97, 110, 97, 103, 101, 114])]
    public partial class UIManager
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "UIManager";
        //public static byte[] Static_ClassName { get; } = [85, 73, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x02000480U;




        public readonly unsafe partial struct Const_UIManager
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
        public readonly unsafe partial struct Static_UIManager
        {



            /// const string Name_Field_instance = "instance";
            /// <summary>
            /// class 0x0 UIManager instance
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            [MonoCollectorStaticProperty(PropertyName = "Instance")]
            public readonly Ptr_UIManager instance;


            /// const string Name_Field_OffsetOfInstanceIDInCPlusPlusObject = "OffsetOfInstanceIDInCPlusPlusObject";
            /// <summary>
            /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        }


        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_UIManager
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


            /// const string Name_Field_worldUiCanvasGroup = "worldUiCanvasGroup";
            /// <summary>
            /// class 0x20 UnityEngine.CanvasGroup worldUiCanvasGroup
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint worldUiCanvasGroup;


            /// const string Name_Field_invisibleButton = "invisibleButton";
            /// <summary>
            /// class 0x28 UnityEngine.UI.Button invisibleButton
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly nint invisibleButton;


            /// const string Name_Field_uiInstancesRoot = "uiInstancesRoot";
            /// <summary>
            /// class 0x30 UnityEngine.Transform uiInstancesRoot
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint uiInstancesRoot;


            /// const string Name_Field_cutsceneButtonsPanel = "cutsceneButtonsPanel";
            /// <summary>
            /// class 0x38 UnityEngine.Transform cutsceneButtonsPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public readonly nint cutsceneButtonsPanel;


            /// const string Name_Field_fadeScreen = "fadeScreen";
            /// <summary>
            /// class 0x40 UnityEngine.UI.Image fadeScreen
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly nint fadeScreen;


            /// const string Name_Field_canvasGO = "canvasGO";
            /// <summary>
            /// class 0x48 UnityEngine.GameObject canvasGO
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly nint canvasGO;


            /// const string Name_Field_textLogWindow = "textLogWindow";
            /// <summary>
            /// class 0x50 HistoryPanel textLogWindow
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly nint textLogWindow;


            /// const string Name_Field_menuPanel = "menuPanel";
            /// <summary>
            /// class 0x58 MenuPanel menuPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            public readonly nint menuPanel;


            /// const string Name_Field_equipsPanel = "equipsPanel";
            /// <summary>
            /// class 0x60 EquipsPanel equipsPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            public readonly nint equipsPanel;


            /// const string Name_Field_сonsumablesStorePanel = "сonsumablesStorePanel";
            /// <summary>
            /// class 0x68 ConsumablesStorePanel сonsumablesStorePanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x68)]
            public readonly nint сonsumablesStorePanel;


            /// const string Name_Field_confidantLevelPanel = "confidantLevelPanel";
            /// <summary>
            /// class 0x70 ConfidantLevelPanel confidantLevelPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x70)]
            public readonly nint confidantLevelPanel;


            /// const string Name_Field_socialStatsPanel = "socialStatsPanel";
            /// <summary>
            /// class 0x78 SocialStatsPanel socialStatsPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x78)]
            public readonly nint socialStatsPanel;


            /// const string Name_Field_popUpMessage = "popUpMessage";
            /// <summary>
            /// class 0x80 PopUpMessage popUpMessage
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x80)]
            [MonoCollectorProperty(PropertyName = "PopUpMessage")]
            public readonly PopUpMessage.Ptr_PopUpMessage popUpMessage;


            /// const string Name_Field_equipmentsShopPanel = "equipmentsShopPanel";
            /// <summary>
            /// class 0x88 EquipmentsShopPanel equipmentsShopPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x88)]
            public readonly nint equipmentsShopPanel;


            /// const string Name_Field_craftWindow = "craftWindow";
            /// <summary>
            /// class 0x90 CraftWindow craftWindow
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x90)]
            public readonly nint craftWindow;


            /// const string Name_Field_laundryPanel = "laundryPanel";
            /// <summary>
            /// class 0x98 LaundryPanel laundryPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x98)]
            public readonly nint laundryPanel;


            /// const string Name_Field_getTakeWindow = "getTakeWindow";
            /// <summary>
            /// class 0xA0 GetTakeWindow getTakeWindow
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA0)]
            public readonly nint getTakeWindow;


            /// const string Name_Field_gardenPanel = "gardenPanel";
            /// <summary>
            /// class 0xA8 GardenPanel gardenPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA8)]
            public readonly nint gardenPanel;


            /// const string Name_Field_fishingPanel = "fishingPanel";
            /// <summary>
            /// class 0xB0 FishingPanel fishingPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB0)]
            public readonly nint fishingPanel;


            /// const string Name_Field_gameButtonHints = "gameButtonHints";
            /// <summary>
            /// class 0xB8 GameButtonHints gameButtonHints
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB8)]
            public readonly nint gameButtonHints;


            /// const string Name_Field_canTalkBubble = "canTalkBubble";
            /// <summary>
            /// class 0xC0 UnityEngine.GameObject canTalkBubble
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC0)]
            public readonly nint canTalkBubble;


            /// const string Name_Field_canTalkBubbleConfedant = "canTalkBubbleConfedant";
            /// <summary>
            /// class 0xC8 UnityEngine.GameObject canTalkBubbleConfedant
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC8)]
            public readonly nint canTalkBubbleConfedant;


            /// const string Name_Field_smallTalkBubble = "smallTalkBubble";
            /// <summary>
            /// class 0xD0 TalkBubble smallTalkBubble
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD0)]
            public readonly nint smallTalkBubble;


            /// const string Name_Field_explorationUI = "explorationUI";
            /// <summary>
            /// class 0xD8 ExplorationUI explorationUI
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD8)]
            public readonly nint explorationUI;


            /// const string Name_Field_skillsPanel = "skillsPanel";
            /// <summary>
            /// class 0xE0 SkillsPanel skillsPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE0)]
            public readonly nint skillsPanel;


            /// const string Name_Field_itemsPanel = "itemsPanel";
            /// <summary>
            /// class 0xE8 ItemsPanel itemsPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE8)]
            public readonly nint itemsPanel;


            /// const string Name_Field_personaPanel = "personaPanel";
            /// <summary>
            /// class 0xF0 PersonaPanel personaPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF0)]
            public readonly nint personaPanel;


            /// const string Name_Field_confidantPanel = "confidantPanel";
            /// <summary>
            /// class 0xF8 ConfidantPanel confidantPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF8)]
            public readonly nint confidantPanel;


            /// const string Name_Field_bookPanel = "bookPanel";
            /// <summary>
            /// class 0x100 BookPanel bookPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x100)]
            public readonly nint bookPanel;


            /// const string Name_Field_moneyPanel = "moneyPanel";
            /// <summary>
            /// class 0x108 MoneyPanelNew moneyPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x108)]
            public readonly nint moneyPanel;


            /// const string Name_Field_waitingPanel = "waitingPanel";
            /// <summary>
            /// class 0x110 WaitingPanel waitingPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x110)]
            public readonly nint waitingPanel;


            /// const string Name_Field_questPanel = "questPanel";
            /// <summary>
            /// class 0x118 QuestPanel questPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x118)]
            public readonly nint questPanel;


            /// const string Name_Field_charactersPanel = "charactersPanel";
            /// <summary>
            /// class 0x120 CharactersPanel charactersPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x120)]
            public readonly nint charactersPanel;


            /// const string Name_Field_buttonHintsPanel = "buttonHintsPanel";
            /// <summary>
            /// class 0x128 ButtonHintsPanel buttonHintsPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x128)]
            public readonly nint buttonHintsPanel;


            /// const string Name_Field_mapPanel = "mapPanel";
            /// <summary>
            /// class 0x130 MapPanel mapPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x130)]
            public readonly nint mapPanel;


            /// const string Name_Field_confirmPanel = "confirmPanel";
            /// <summary>
            /// class 0x138 ConfirmPanel confirmPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x138)]
            public readonly nint confirmPanel;


            /// const string Name_Field_systemPanel = "systemPanel";
            /// <summary>
            /// class 0x140 SystemPanel systemPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x140)]
            public readonly nint systemPanel;


            /// const string Name_Field_notificationPanel = "notificationPanel";
            /// <summary>
            /// class 0x148 NotificationPanel notificationPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x148)]
            public readonly nint notificationPanel;


            /// const string Name_Field_calendarPanel = "calendarPanel";
            /// <summary>
            /// class 0x150 CalendarPanel calendarPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x150)]
            public readonly nint calendarPanel;


            /// const string Name_Field_newFusePanel = "newFusePanel";
            /// <summary>
            /// class 0x158 NewFusePanel newFusePanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x158)]
            public readonly nint newFusePanel;


            /// const string Name_Field_blackout = "blackout";
            /// <summary>
            /// class 0x160 UnityEngine.UI.Image blackout
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x160)]
            public readonly nint blackout;


            /// const string Name_Field_loadingPanel = "loadingPanel";
            /// <summary>
            /// class 0x168 UnityEngine.GameObject loadingPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x168)]
            public readonly nint loadingPanel;


            /// const string Name_Field_pausePanel = "pausePanel";
            /// <summary>
            /// class 0x170 PausePanel pausePanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x170)]
            public readonly nint pausePanel;


            /// const string Name_Field_gameOverPanel = "gameOverPanel";
            /// <summary>
            /// class 0x178 GameOverPanel gameOverPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x178)]
            public readonly nint gameOverPanel;


            /// const string Name_Field_secondhandPanel = "secondhandPanel";
            /// <summary>
            /// class 0x180 SecondHandPanel secondhandPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x180)]
            public readonly nint secondhandPanel;


            /// const string Name_Field_settingsPanel = "settingsPanel";
            /// <summary>
            /// class 0x188 SettingsPanel settingsPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x188)]
            public readonly nint settingsPanel;


            /// const string Name_Field_questMapPanel = "questMapPanel";
            /// <summary>
            /// class 0x190 QuestMapPanel questMapPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x190)]
            public readonly nint questMapPanel;


            /// const string Name_Field_socialStatBoostPanel = "socialStatBoostPanel";
            /// <summary>
            /// class 0x198 SocialStatBoostPanel socialStatBoostPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x198)]
            public readonly nint socialStatBoostPanel;


            /// const string Name_Field_runHintPanel = "runHintPanel";
            /// <summary>
            /// class 0x1A0 RunHintPanel runHintPanel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1A0)]
            public readonly nint runHintPanel;


            /// const string Name_Field_logger = "logger";
            /// <summary>
            /// class 0x1A8 Logger logger
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1A8)]
            public readonly nint logger;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UIManager(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UIManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UIManager obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_UIManager AsRef()
            {
                return ref Unsafe.AsRef<Ref_UIManager>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."UIManager"]
    /// </summary>
    public partial class UIManager
    {



        /// const string Name_Func_.CCTOR = ".cctor";
        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void .CCTOR ();


        /// const string Name_Func_ADD_CHILD_INSTANCE = "AddChildInstance";
        /// <summary>
        /// static  T AddChildInstance(T prefab,UnityEngine.Transform parent,System.String countIfNameContains)
        /// </summary>
        /// <param name="prefab">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="countIfNameContains">class System.String</param>
        /// <returns>class T</returns>
        /// public static extern nint ADD_CHILD_INSTANCE (nint prefab,nint parent,nint countIfNameContains);


        /// const string Name_Func_CAN_OPEN_MENU_BY_KEY = "CanOpenMenuByKey";
        /// <summary>
        /// static  System.Boolean CanOpenMenuByKey()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// public static extern System.Boolean CAN_OPEN_MENU_BY_KEY ();


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


        /// const string Name_Func_COMPARE_TAG = "CompareTag";
        /// <summary>
        ///   System.Boolean CompareTag(System.String tag)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// public  extern System.Boolean COMPARE_TAG (nint tag);


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


        /// const string Name_Func_FIND_BLEND_MODE = "FindBlendMode";
        /// <summary>
        /// static  System.Void FindBlendMode(BlendModes.BlendModeEffect blendModeEffect,System.String filename)
        /// </summary>
        /// <param name="blendModeEffect">class BlendModes.BlendModeEffect</param>
        /// <param name="filename">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void FIND_BLEND_MODE (nint blendModeEffect,nint filename);


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


        /// const string Name_Func_GET_GAME_OBJECT = "get_gameObject";
        /// <summary>
        ///   UnityEngine.GameObject get_gameObject()
        /// </summary>
        /// <returns>class UnityEngine.GameObject</returns>
        /// public  extern nint GET_GAME_OBJECT ();


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


        /// const string Name_Func_GET_NAME = "get_name";
        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_NAME ();


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


        /// const string Name_Func_GET_WORLD_POS_TO_UI_SCALE_FACTOR = "get_WorldPosToUIScaleFactor";
        /// <summary>
        /// static  System.Single get_WorldPosToUIScaleFactor()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// public static extern System.Single GET_WORLD_POS_TO_UI_SCALE_FACTOR ();


        /// const string Name_Func_GET_CACHED_PTR = "GetCachedPtr";
        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// public  extern System.IntPtr GET_CACHED_PTR ();


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


        /// const string Name_Func_GET_LOCALE_FOR_ITEM_CATEGORY = "GetLocaleForItemCategory";
        /// <summary>
        /// static  System.String GetLocaleForItemCategory(System.String categoryStr)
        /// </summary>
        /// <param name="categoryStr">class System.String</param>
        /// <returns>class System.String</returns>
        /// public static extern nint GET_LOCALE_FOR_ITEM_CATEGORY (nint categoryStr);


        /// const string Name_Func_GET_MAX_VALUE_SPRITE_ALPHA = "GetMaxValueSpriteAlpha";
        /// <summary>
        /// static  System.Int32 GetMaxValueSpriteAlpha(System.String spriteName)
        /// </summary>
        /// <param name="spriteName">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 GET_MAX_VALUE_SPRITE_ALPHA (nint spriteName);


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


        /// const string Name_Func_GET_ROUND_SLIDER_VALUE = "GetRoundSliderValue";
        /// <summary>
        /// static  System.Int32 GetRoundSliderValue(System.Single maxSliderValue,System.Single value,System.Single maxValue)
        /// </summary>
        /// <param name="maxSliderValue">struct System.Single</param>
        /// <param name="value">struct System.Single</param>
        /// <param name="maxValue">struct System.Single</param>
        /// <returns>struct System.Int32</returns>
        /// public static extern System.Int32 GET_ROUND_SLIDER_VALUE (System.Single maxSliderValue,System.Single value,System.Single maxValue);


        /// const string Name_Func_GET_SCRIPT_CLASS_NAME = "GetScriptClassName";
        /// <summary>
        ///   System.String GetScriptClassName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_SCRIPT_CLASS_NAME ();


        /// const string Name_Func_HIDE_LOADING_PANEL = "HideLoadingPanel";
        /// <summary>
        ///   System.Void HideLoadingPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void HIDE_LOADING_PANEL ();


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


        /// const string Name_Func_INVOKE_IN_NEXT_FRAME = "InvokeInNextFrame";
        /// <summary>
        /// static  System.Collections.IEnumerator InvokeInNextFrame(UnityEngine.Events.UnityAction action)
        /// </summary>
        /// <param name="action">class UnityEngine.Events.UnityAction</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// public static extern nint INVOKE_IN_NEXT_FRAME (nint action);


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


        /// const string Name_Func_MOVE_SCROLL_RECT = "MoveScrollRect";
        /// <summary>
        /// static  System.Void MoveScrollRect(UnityEngine.UI.ScrollRect scrollRect,UnityEngine.GameObject contentObject,System.Single layoutGroupPaddingTop,System.Single layoutGroupPaddingBottom)
        /// </summary>
        /// <param name="scrollRect">class UnityEngine.UI.ScrollRect</param>
        /// <param name="contentObject">class UnityEngine.GameObject</param>
        /// <param name="layoutGroupPaddingTop">struct System.Single</param>
        /// <param name="layoutGroupPaddingBottom">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void MOVE_SCROLL_RECT (nint scrollRect,nint contentObject,System.Single layoutGroupPaddingTop,System.Single layoutGroupPaddingBottom);


        /// const string Name_Func_ON_CANCELLATION_TOKEN_CREATED = "OnCancellationTokenCreated";
        /// <summary>
        ///   System.Void OnCancellationTokenCreated()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void ON_CANCELLATION_TOKEN_CREATED ();


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


        /// const string Name_Func_RESET_SELECTION = "ResetSelection";
        /// <summary>
        /// static  System.Void ResetSelection()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public static extern void RESET_SELECTION ();


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


        /// const string Name_Func_SET_ACTIVE_ANIMATOR = "SetActiveAnimator";
        /// <summary>
        /// static  System.Void SetActiveAnimator(UnityEngine.Component component,System.Boolean active)
        /// </summary>
        /// <param name="component">class UnityEngine.Component</param>
        /// <param name="active">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_ACTIVE_ANIMATOR (nint component,System.Boolean active);


        /// const string Name_Func_SET_BUTTON_ACTIVE_NEXT_FRAME = "SetButtonActiveNextFrame";
        /// <summary>
        /// static  System.Collections.IEnumerator SetButtonActiveNextFrame(UnityEngine.UI.Selectable selectable)
        /// </summary>
        /// <param name="selectable">class UnityEngine.UI.Selectable</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// public static extern nint SET_BUTTON_ACTIVE_NEXT_FRAME (nint selectable);


        /// const string Name_Func_SET_BUTTONS_NAV_GRID = "SetButtonsNavGrid";
        /// <summary>
        /// static  System.Void SetButtonsNavGrid(System.Collections.Generic.List<UnityEngine.UI.Button> buttons,System.Int32 countInRow,System.Int32 startIndex)
        /// </summary>
        /// <param name="buttons">class System.Collections.Generic.List<UnityEngine.UI.Button></param>
        /// <param name="countInRow">struct System.Int32</param>
        /// <param name="startIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_BUTTONS_NAV_GRID (nint buttons,System.Int32 countInRow,System.Int32 startIndex);


        /// const string Name_Func_SET_BUTTONS_NAV_LEFT_RIGHT = "SetButtonsNavLeftRight";
        /// <summary>
        /// static  System.Void SetButtonsNavLeftRight(System.Collections.Generic.List<UnityEngine.UI.Button> buttons)
        /// </summary>
        /// <param name="buttons">class System.Collections.Generic.List<UnityEngine.UI.Button></param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_BUTTONS_NAV_LEFT_RIGHT (nint buttons);


        /// const string Name_Func_SET_DISABLED_SELECTION = "SetDisabledSelection";
        /// <summary>
        /// static  System.Void SetDisabledSelection(UnityEngine.Component component,System.Boolean active)
        /// </summary>
        /// <param name="component">class UnityEngine.Component</param>
        /// <param name="active">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_DISABLED_SELECTION (nint component,System.Boolean active);


        /// const string Name_Func_SET_NAME = "SetName";
        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_NAME (nint obj,nint name);


        /// const string Name_Func_SET_PORTRAIT_NUMS = "SetPortraitNums";
        /// <summary>
        /// static  System.Void SetPortraitNums(UnityEngine.Transform root,System.Int32 value)
        /// </summary>
        /// <param name="root">class UnityEngine.Transform</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_PORTRAIT_NUMS (nint root,System.Int32 value);


        /// const string Name_Func_SET_PRICE_SIGNS_COLOR = "SetPriceSignsColor";
        /// <summary>
        /// static  System.Void SetPriceSignsColor(TMPro.TextMeshProUGUI textMeshProUGUI,System.Single price,UnityEngine.Color color)
        /// </summary>
        /// <param name="textMeshProUGUI">class TMPro.TextMeshProUGUI</param>
        /// <param name="price">struct System.Single</param>
        /// <param name="color">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_PRICE_SIGNS_COLOR (nint textMeshProUGUI,System.Single price,UnityEngine.Color color);


        /// const string Name_Func_SET_SELECTION_ALPHA = "SetSelectionAlpha";
        /// <summary>
        /// static  System.Void SetSelectionAlpha(UnityEngine.Component button,System.Single value)
        /// </summary>
        /// <param name="button">class UnityEngine.Component</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_SELECTION_ALPHA (nint button,System.Single value);


        /// const string Name_Func_SET_SIZE_RT = "SetSizeRt";
        /// <summary>
        /// static  System.Void SetSizeRt(UnityEngine.Component sizeObject,System.Single height,System.Single width)
        /// </summary>
        /// <param name="sizeObject">class UnityEngine.Component</param>
        /// <param name="height">struct System.Single</param>
        /// <param name="width">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_SIZE_RT (nint sizeObject,System.Single height,System.Single width);


        /// const string Name_Func_SET_SIZE_RT_LIKE_PREFERRED_SIZE = "SetSizeRtLikePreferredSize";
        /// <summary>
        /// static  System.Void SetSizeRtLikePreferredSize(UnityEngine.Component sizeObject,TMPro.TextMeshProUGUI TextMP,System.Boolean width,System.Boolean height)
        /// </summary>
        /// <param name="sizeObject">class UnityEngine.Component</param>
        /// <param name="TextMP">class TMPro.TextMeshProUGUI</param>
        /// <param name="width">struct System.Boolean</param>
        /// <param name="height">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_SIZE_RT_LIKE_PREFERRED_SIZE (nint sizeObject,nint TextMP,System.Boolean width,System.Boolean height);


        /// const string Name_Func_SET_WINDOW_POSITION = "SetWindowPosition";
        /// <summary>
        /// static  System.Void SetWindowPosition(UnityEngine.Transform window,UnityEngine.Vector2 offset)
        /// </summary>
        /// <param name="window">class UnityEngine.Transform</param>
        /// <param name="offset">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_WINDOW_POSITION (nint window,UnityEngine.Vector2 offset);


        /// const string Name_Func_SHOW_LOADING_PANEL = "ShowLoadingPanel";
        /// <summary>
        ///   System.Void ShowLoadingPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// public  extern void SHOW_LOADING_PANEL ();


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


        /// const string Name_Func_WORLD_POS_TO_UI = "WorldPosToUI";
        /// <summary>
        /// static  UnityEngine.Vector3 WorldPosToUI(UnityEngine.Vector3 worldPos,System.Boolean snap)
        /// </summary>
        /// <param name="worldPos">struct UnityEngine.Vector3</param>
        /// <param name="snap">struct System.Boolean</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// public static extern UnityEngine.Vector3 WORLD_POS_TO_UI (UnityEngine.Vector3 worldPos,System.Boolean snap);


        /// const string Name_Func_WORLD_POS_TO_UI_FOR_BATTLE_POSITIONED_ELEMENTS = "WorldPosToUIForBattlePositionedElements";
        /// <summary>
        /// static  UnityEngine.Vector3 WorldPosToUIForBattlePositionedElements(UnityEngine.Vector3 worldPos,System.Boolean snap)
        /// </summary>
        /// <param name="worldPos">struct UnityEngine.Vector3</param>
        /// <param name="snap">struct System.Boolean</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// public static extern UnityEngine.Vector3 WORLD_POS_TO_UI_FOR_BATTLE_POSITIONED_ELEMENTS (UnityEngine.Vector3 worldPos,System.Boolean snap);



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


        /// const string Name_Func_SET_BUTTONS_NAV_UP_DOWN = "SetButtonsNavUpDown";
        /// <summary>
        /// static  System.Void SetButtonsNavUpDown(System.Collections.Generic.List<UnityEngine.UI.Button> buttons)
        /// </summary>
        /// <param name="buttons">class System.Collections.Generic.List<UnityEngine.UI.Button></param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_BUTTONS_NAV_UP_DOWN_00 (nint buttons);


        /// const string Name_Func_SET_BUTTONS_NAV_UP_DOWN = "SetButtonsNavUpDown";
        /// <summary>
        /// static  System.Void SetButtonsNavUpDown(System.Collections.Generic.List<UnityEngine.UI.Selectable> selectables)
        /// </summary>
        /// <param name="selectables">class System.Collections.Generic.List<UnityEngine.UI.Selectable></param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_BUTTONS_NAV_UP_DOWN_01 (nint selectables);


        /// const string Name_Func_SET_CHILDREN_COUNT = "SetChildrenCount";
        /// <summary>
        /// static  System.Collections.Generic.List<T> SetChildrenCount(T prefab,UnityEngine.Transform parent,System.Int32 count,System.String countIfNameContains)
        /// </summary>
        /// <param name="prefab">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="countIfNameContains">class System.String</param>
        /// <returns>class System.Collections.Generic.List<T></returns>
        /// public static extern nint SET_CHILDREN_COUNT_00 (nint prefab,nint parent,System.Int32 count,nint countIfNameContains);


        /// const string Name_Func_SET_CHILDREN_COUNT = "SetChildrenCount";
        /// <summary>
        /// static  System.Collections.Generic.List<UnityEngine.Transform> SetChildrenCount(UnityEngine.GameObject prefab,UnityEngine.Transform parent,System.Int32 count,System.String countIfNameContains)
        /// </summary>
        /// <param name="prefab">class UnityEngine.GameObject</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="countIfNameContains">class System.String</param>
        /// <returns>class System.Collections.Generic.List<UnityEngine.Transform></returns>
        /// public static extern nint SET_CHILDREN_COUNT_01 (nint prefab,nint parent,System.Int32 count,nint countIfNameContains);


        /// const string Name_Func_SET_LOCALIZED_TEXT = "SetLocalizedText";
        /// <summary>
        /// static  System.Void SetLocalizedText(TMPro.TextMeshProUGUI label,System.String text,LocalizationManager.LocalizedField[] fields)
        /// </summary>
        /// <param name="label">class TMPro.TextMeshProUGUI</param>
        /// <param name="text">class System.String</param>
        /// <param name="fields">class LocalizationManager.LocalizedField[]</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_LOCALIZED_TEXT_00 (nint label,nint text,nint fields);


        /// const string Name_Func_SET_LOCALIZED_TEXT = "SetLocalizedText";
        /// <summary>
        /// static  System.Void SetLocalizedText(TMPro.TextMeshProUGUI label,LocalizationManager.LocalizedField field)
        /// </summary>
        /// <param name="label">class TMPro.TextMeshProUGUI</param>
        /// <param name="field">class LocalizationManager.LocalizedField</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_LOCALIZED_TEXT_01 (nint label,nint field);


        /// const string Name_Func_SET_SPRITE_AND_UPDATE_SIZE = "SetSpriteAndUpdateSize";
        /// <summary>
        /// static  System.Void SetSpriteAndUpdateSize(UnityEngine.UI.Image image,UnityEngine.Sprite sprite)
        /// </summary>
        /// <param name="image">class UnityEngine.UI.Image</param>
        /// <param name="sprite">class UnityEngine.Sprite</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_SPRITE_AND_UPDATE_SIZE_00 (nint image,nint sprite);


        /// const string Name_Func_SET_SPRITE_AND_UPDATE_SIZE = "SetSpriteAndUpdateSize";
        /// <summary>
        /// static  System.Void SetSpriteAndUpdateSize(UnityEngine.UI.Image image,UnityEngine.Sprite sprite,UnityEngine.Vector2 maxSize)
        /// </summary>
        /// <param name="image">class UnityEngine.UI.Image</param>
        /// <param name="sprite">class UnityEngine.Sprite</param>
        /// <param name="maxSize">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_SPRITE_AND_UPDATE_SIZE_01 (nint image,nint sprite,UnityEngine.Vector2 maxSize);


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


        /// public static partial class Search_UIManager
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
        /// static  System.Void SetButtonsNavUpDown(System.Collections.Generic.List<UnityEngine.UI.Button> buttons)
        /// </summary>
        /// public static bool SET_BUTTONS_NAV_UP_DOWN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetButtonsNavUpDown", "System.Collections.Generic.List<UnityEngine.UI.Button>");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetButtonsNavUpDown(System.Collections.Generic.List<UnityEngine.UI.Selectable> selectables)
        /// </summary>
        /// public static bool SET_BUTTONS_NAV_UP_DOWN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetButtonsNavUpDown", "System.Collections.Generic.List<UnityEngine.UI.Selectable>");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Collections.Generic.List<T> SetChildrenCount(T prefab, UnityEngine.Transform parent, System.Int32 count, System.String countIfNameContains)
        /// </summary>
        /// public static bool SET_CHILDREN_COUNT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetChildrenCount", "T", "UnityEngine.Transform", "System.Int32", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Collections.Generic.List<UnityEngine.Transform> SetChildrenCount(UnityEngine.GameObject prefab, UnityEngine.Transform parent, System.Int32 count, System.String countIfNameContains)
        /// </summary>
        /// public static bool SET_CHILDREN_COUNT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetChildrenCount", "UnityEngine.GameObject", "UnityEngine.Transform", "System.Int32", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetLocalizedText(TMPro.TextMeshProUGUI label, System.String text, LocalizationManager.LocalizedField[] fields)
        /// </summary>
        /// public static bool SET_LOCALIZED_TEXT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLocalizedText", "TMPro.TextMeshProUGUI", "System.String", "LocalizationManager.LocalizedField[]");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetLocalizedText(TMPro.TextMeshProUGUI label, LocalizationManager.LocalizedField field)
        /// </summary>
        /// public static bool SET_LOCALIZED_TEXT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLocalizedText", "TMPro.TextMeshProUGUI", "LocalizationManager.LocalizedField");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetSpriteAndUpdateSize(UnityEngine.UI.Image image, UnityEngine.Sprite sprite)
        /// </summary>
        /// public static bool SET_SPRITE_AND_UPDATE_SIZE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetSpriteAndUpdateSize", "UnityEngine.UI.Image", "UnityEngine.Sprite");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetSpriteAndUpdateSize(UnityEngine.UI.Image image, UnityEngine.Sprite sprite, UnityEngine.Vector2 maxSize)
        /// </summary>
        /// public static bool SET_SPRITE_AND_UPDATE_SIZE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetSpriteAndUpdateSize", "UnityEngine.UI.Image", "UnityEngine.Sprite", "UnityEngine.Vector2");
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
