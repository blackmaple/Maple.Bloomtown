
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Bloomtown
{


    /// <summary>
    /// class ["Assembly-CSharp".""."BattleManager"]
    /// [UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000051U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [66, 97, 116, 116, 108, 101, 77, 97, 110, 97, 103, 101, 114])]

    //  class static BattleManager instance
    [MonoCollectorSearchFieldAttribute(typeof(BattleManager.Ptr_BattleManager), "instance", "INSTANCE", true)]

    //  struct static System.Int32 OffsetOfInstanceIDInCPlusPlusObject
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"OffsetOfInstanceIDInCPlusPlusObject", "OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT", true)]

    // struct 0x10 System.IntPtr m_CachedPtr
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"m_CachedPtr", "M_CACHED_PTR")]

    // class 0x18 System.Threading.CancellationTokenSource m_CancellationTokenSource
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_CancellationTokenSource", "M_CANCELLATION_TOKEN_SOURCE")]

    // class 0x20 UnityEngine.GameObject lewisJr
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"lewisJr", "LEWIS_JR")]

    // class 0x28 SkillInfo angryResponse
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"angryResponse", "ANGRY_RESPONSE")]

    // class 0x30 SkillInfo defaultAttack
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"defaultAttack", "DEFAULT_ATTACK")]

    // class 0x38 SkillInfo burnStatusSkill
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"burnStatusSkill", "BURN_STATUS_SKILL")]

    // class 0x40 SkillInfo electrifyStatusSkill
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"electrifyStatusSkill", "ELECTRIFY_STATUS_SKILL")]

    // class 0x48 UnityEngine.GameObject normalFightMusic
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"normalFightMusic", "NORMAL_FIGHT_MUSIC")]

    // class 0x50 UnityEngine.GameObject bossFightMusic
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"bossFightMusic", "BOSS_FIGHT_MUSIC")]

    // class 0x58 BattleCamera battleCamera
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battleCamera", "BATTLE_CAMERA")]

    // class 0x60 BattleUI ui
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ui", "UI")]

    // class 0x68 UnityEngine.Transform charactersPanel
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"charactersPanel", "CHARACTERS_PANEL")]

    // class 0x70 AllOutIntro allOutIntro
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"allOutIntro", "ALL_OUT_INTRO")]

    // class 0x78 UnityEngine.Transform cutscenesRoot
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"cutscenesRoot", "CUTSCENES_ROOT")]

    // class 0x80 System.Collections.Generic.List<UnityEngine.GameObject> locations
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"locations", "LOCATIONS")]

    // class 0x88 UnityEngine.GameObject destroyOnAdditiveLoad
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"destroyOnAdditiveLoad", "DESTROY_ON_ADDITIVE_LOAD")]

    // abstract class 0x90 BattleParticipantController <currentCharacter>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<currentCharacter>k__BackingField", "CURRENT_CHARACTER")]

    // abstract class 0x98 BattleParticipantController lastSelectedEnemy
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"lastSelectedEnemy", "LAST_SELECTED_ENEMY")]

    // abstract class 0xA0 BattleParticipantController lastSelectedAlly
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"lastSelectedAlly", "LAST_SELECTED_ALLY")]

    // abstract class 0xA8 EffectHolder <chosenSkill>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<chosenSkill>k__BackingField", "CHOSEN_SKILL")]

    // class 0xB0 System.Collections.Generic.List<BattleMonsterModel> participatingMonsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"participatingMonsters", "PARTICIPATING_MONSTERS")]

    // class 0xB8 System.Collections.Generic.List<Character> originalCharacters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"originalCharacters", "ORIGINAL_CHARACTERS")]

    // class 0xC0 System.Collections.Generic.List<BattlePlayerController> playerCharacters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"playerCharacters", "PLAYER_CHARACTERS")]

    // class 0xC8 System.Collections.Generic.List<BattleParticipantController> monsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"monsters", "MONSTERS")]

    // abstract class 0xD0 BattleParticipantController hoveredTarget
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"hoveredTarget", "HOVERED_TARGET")]

    // class 0xD8 UnityEngine.Events.UnityAction onActionChosen
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"onActionChosen", "ON_ACTION_CHOSEN")]

    // class 0xE0 System.Collections.Generic.List<BattleParticipantController> m_batonPassCharacters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_batonPassCharacters", "M_BATON_PASS_CHARACTERS")]

    // class 0xE8 System.Collections.Generic.List<BattleParticipantController> m_usedBatonPassCharacters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_usedBatonPassCharacters", "M_USED_BATON_PASS_CHARACTERS")]

    // class 0xF0 System.Collections.Generic.List<BattleParticipantController> m_turnsQueue
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_turnsQueue", "M_TURNS_QUEUE")]

    // abstract class 0xF8 BattleParticipantController m_target
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_target", "M_TARGET")]

    // class 0x100 System.String m_poolUid
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_poolUid", "M_POOL_UID")]

    // class 0x108 UnityEngine.Events.UnityAction m_backCallback
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_backCallback", "M_BACK_CALLBACK")]

    // class 0x110 UnityEngine.Events.UnityAction m_bckCtx
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_bckCtx", "M_BCK_CTX")]

    // class 0x118 UnityEngine.Events.UnityAction m_dmnCtx
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_dmnCtx", "M_DMN_CTX")]

    // class 0x120 UnityEngine.Events.UnityAction m_itmCtx
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_itmCtx", "M_ITM_CTX")]

    // class 0x128 UnityEngine.Events.UnityAction m_grdCtx
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_grdCtx", "M_GRD_CTX")]

    // class 0x130 UnityEngine.Events.UnityAction m_atcCtx
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_atcCtx", "M_ATC_CTX")]

    // class 0x138 UnityEngine.Events.UnityAction m_gunCtx
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_gunCtx", "M_GUN_CTX")]

    // class 0x140 UnityEngine.Events.UnityAction m_showtimeCtx
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_showtimeCtx", "M_SHOWTIME_CTX")]

    // class 0x148 UnityEngine.Events.UnityAction m_analyzeCtx
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_analyzeCtx", "M_ANALYZE_CTX")]

    // class 0x150 UnityEngine.Events.UnityAction m_batonPassCtx
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_batonPassCtx", "M_BATON_PASS_CTX")]

    // class 0x158 Logger m_logger
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_logger", "M_LOGGER")]

    // class 0x160 System.Collections.Generic.List<BattleMonsterController> m_killedMonsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_killedMonsters", "M_KILLED_MONSTERS")]

    // class 0x168 System.Collections.Generic.Dictionary<System.String,System.Int32> m_lootDropped
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_lootDropped", "M_LOOT_DROPPED")]

    // class 0x170 BattleManager.BattleInfo battleInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"battleInfo", "BATTLE_INFO")]

    // class 0x178 System.Collections.Generic.List<System.String> monsterIds
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"monsterIds", "MONSTER_IDS")]

    // class 0x180 System.Collections.Generic.List<System.String> charactersIds
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"charactersIds", "CHARACTERS_IDS")]

    // class 0x188 System.Collections.Generic.List<PersonaProgress> newCaughtMonsters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"newCaughtMonsters", "NEW_CAUGHT_MONSTERS")]

    // class 0x190 ControllerInfo librarianShield
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"librarianShield", "LIBRARIAN_SHIELD")]

    // struct 0x198 System.Boolean debugPlayBossMusic
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"debugPlayBossMusic", "DEBUG_PLAY_BOSS_MUSIC")]

    // enum 0x19C BattleManager.Action <currentAction>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(BattleManager.Action),"<currentAction>k__BackingField", "CURRENT_ACTION")]

    // enum 0x1A0 BattlePlayerModel.Tactics m_currentTurnTactics
    // [MonoCollectorSearchFieldAttribute(typeof(BattlePlayerModel.Tactics),"m_currentTurnTactics", "M_CURRENT_TURN_TACTICS")]

    // struct 0x1A4 System.Boolean fightActive
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "fightActive", "FIGHT_ACTIVE")]

    // struct 0x1A5 System.Boolean silent
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"silent", "SILENT")]

    // enum 0x1A8 MonsterEncounter.Location location
    // [MonoCollectorSearchFieldAttribute(typeof(MonsterEncounter.Location),"location", "LOCATION")]

    // struct 0x1AC System.Boolean isAvailableBatonPass
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isAvailableBatonPass", "IS_AVAILABLE_BATON_PASS")]

    // struct 0x1AD System.Boolean isBatonPass
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isBatonPass", "IS_BATON_PASS")]

    // struct 0x1B0 System.Int32 m_turnIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"m_turnIndex", "M_TURN_INDEX")]

    // struct 0x1B4 System.Boolean m_endingTurn
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_endingTurn", "M_ENDING_TURN")]

    // struct 0x1B5 System.Boolean m_followUpTriggered
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_followUpTriggered", "M_FOLLOW_UP_TRIGGERED")]

    // struct 0x1B6 System.Boolean m_showTimeAvailable
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_showTimeAvailable", "M_SHOW_TIME_AVAILABLE")]

    // struct 0x1B7 System.Boolean m_isFirstShot
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_isFirstShot", "M_IS_FIRST_SHOT")]

    // struct 0x1B8 System.Boolean m_initialized
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_initialized", "M_INITIALIZED")]

    // struct 0x1BC System.Single m_moneyDropped
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"m_moneyDropped", "M_MONEY_DROPPED")]

    // struct 0x1C0 System.Boolean m_selectEnemySfxCanPlay
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_selectEnemySfxCanPlay", "M_SELECT_ENEMY_SFX_CAN_PLAY")]

    // struct 0x1C1 System.Boolean m_clickSfxCanPlay
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"m_clickSfxCanPlay", "M_CLICK_SFX_CAN_PLAY")]

    // struct 0x1C2 System.Boolean m_fightEnded
    [MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "m_fightEnded", "M_FIGHT_ENDED")]

    // struct 0x1C4 System.Int32 eliteHealCooldownRemaining
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"eliteHealCooldownRemaining", "ELITE_HEAL_COOLDOWN_REMAINING")]

    // struct 0x1C8 System.Int32 summonBooksCooldownRemaining
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"summonBooksCooldownRemaining", "SUMMON_BOOKS_COOLDOWN_REMAINING")]

    // struct 0x1CC System.Boolean isFirstTurnOfStage
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isFirstTurnOfStage", "IS_FIRST_TURN_OF_STAGE")]

    // struct 0x1CD System.Boolean isIllusionKilledThisTurn
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isIllusionKilledThisTurn", "IS_ILLUSION_KILLED_THIS_TURN")]

    // struct 0x1CE System.Boolean illusionsShuffledThisTurn
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"illusionsShuffledThisTurn", "ILLUSIONS_SHUFFLED_THIS_TURN")]
    public partial class BattleManager
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "BattleManager";
        //public static byte[] Static_ClassName { get; } = [66, 97, 116, 116, 108, 101, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x02000051U;




        /// <summary>
        /// struct System.Int32 EliteHealCooldown "2"
        /// </summary>
        /// public const System.Int32 ELITE_HEAL_COOLDOWN=>"2";

        /// <summary>
        /// struct System.Int32 SummonBooksCooldown "4"
        /// </summary>
        /// public const System.Int32 SUMMON_BOOKS_COOLDOWN=>"4";

        /// <summary>
        /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        /// </summary>
        /// public const nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";

        /// <summary>
        /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        /// </summary>
        /// public const nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_BattleManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_BattleManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_BattleManager obj) => obj._ptr;
            public static implicit operator bool(Ptr_BattleManager obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."BattleManager"]
    /// </summary>
    public partial class BattleManager
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void <ActionChosen>b__187_1()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ActionChosen>b__187_1")]
        ///  extern void <ACTION_CHOSEN>B__187_1 ();


        /// <summary>
        ///   System.Void <ActionChosen>b__187_2()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ActionChosen>b__187_2")]
        ///  extern void <ACTION_CHOSEN>B__187_2 ();


        /// <summary>
        ///   System.Void <ActionChosen>b__187_3()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ActionChosen>b__187_3")]
        ///  extern void <ACTION_CHOSEN>B__187_3 ();


        /// <summary>
        ///   System.Void <ActionChosen>b__187_4()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ActionChosen>b__187_4")]
        ///  extern void <ACTION_CHOSEN>B__187_4 ();


        /// <summary>
        ///   System.Void <ActionChosen>b__187_5()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ActionChosen>b__187_5")]
        ///  extern void <ACTION_CHOSEN>B__187_5 ();


        /// <summary>
        ///   System.Boolean <ApplyElectrificationDamage>b__227_0()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ApplyElectrificationDamage>b__227_0")]
        ///  extern System.Boolean <APPLY_ELECTRIFICATION_DAMAGE>B__227_0 ();


        /// <summary>
        ///   System.Boolean <CanAttackTargetInMelee>b__218_0(BattleParticipantController x)
        /// </summary>
        /// <param name="x">abstract class BattleParticipantController</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<CanAttackTargetInMelee>b__218_0")]
        ///  extern System.Boolean <CAN_ATTACK_TARGET_IN_MELEE>B__218_0 (nint x);


        /// <summary>
        ///   System.Boolean <CanAttackTargetInMelee>b__218_1(BattleParticipantController x)
        /// </summary>
        /// <param name="x">abstract class BattleParticipantController</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<CanAttackTargetInMelee>b__218_1")]
        ///  extern System.Boolean <CAN_ATTACK_TARGET_IN_MELEE>B__218_1 (nint x);


        /// <summary>
        ///   System.Boolean <CanAttackTargetInMelee>b__218_2(BattleParticipantController x)
        /// </summary>
        /// <param name="x">abstract class BattleParticipantController</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<CanAttackTargetInMelee>b__218_2")]
        ///  extern System.Boolean <CAN_ATTACK_TARGET_IN_MELEE>B__218_2 (nint x);


        /// <summary>
        ///   System.Boolean <EndTurn>b__202_0()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<EndTurn>b__202_0")]
        ///  extern System.Boolean <END_TURN>B__202_0 ();


        /// <summary>
        ///   System.Int32 <FormQueueOrder>b__147_0(BattleParticipantController x, BattleParticipantController y)
        /// </summary>
        /// <param name="x">abstract class BattleParticipantController</param>
        /// <param name="y">abstract class BattleParticipantController</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<FormQueueOrder>b__147_0")]
        ///  extern System.Int32 <FORM_QUEUE_ORDER>B__147_0 (nint x, nint y);


        /// <summary>
        ///   System.Boolean <GetAllEnemies>b__167_0(BattleParticipantController x)
        /// </summary>
        /// <param name="x">abstract class BattleParticipantController</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<GetAllEnemies>b__167_0")]
        ///  extern System.Boolean <GET_ALL_ENEMIES>B__167_0 (nint x);


        /// <summary>
        ///   System.Void <InitContexts>b__152_0()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<InitContexts>b__152_0")]
        ///  extern void <INIT_CONTEXTS>B__152_0 ();


        /// <summary>
        ///   System.Void <InitContexts>b__152_1()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<InitContexts>b__152_1")]
        ///  extern void <INIT_CONTEXTS>B__152_1 ();


        /// <summary>
        ///   System.Void <InitContexts>b__152_2()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<InitContexts>b__152_2")]
        ///  extern void <INIT_CONTEXTS>B__152_2 ();


        /// <summary>
        ///   System.Void <InitContexts>b__152_3()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<InitContexts>b__152_3")]
        ///  extern void <INIT_CONTEXTS>B__152_3 ();


        /// <summary>
        ///   System.Void <InitContexts>b__152_4()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<InitContexts>b__152_4")]
        ///  extern void <INIT_CONTEXTS>B__152_4 ();


        /// <summary>
        ///   System.Void <InitContexts>b__152_5()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<InitContexts>b__152_5")]
        ///  extern void <INIT_CONTEXTS>B__152_5 ();


        /// <summary>
        ///   System.Void <InitContexts>b__152_6()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<InitContexts>b__152_6")]
        ///  extern void <INIT_CONTEXTS>B__152_6 ();


        /// <summary>
        ///   System.Int32 <OnFightPrepared>b__146_0(BattlePlayerController x, BattlePlayerController y)
        /// </summary>
        /// <param name="x">class BattlePlayerController</param>
        /// <param name="y">class BattlePlayerController</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<OnFightPrepared>b__146_0")]
        ///  extern System.Int32 <ON_FIGHT_PREPARED>B__146_0 (nint x, nint y);


        /// <summary>
        ///   System.Boolean <OnFightPrepared>b__146_1()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<OnFightPrepared>b__146_1")]
        ///  extern System.Boolean <ON_FIGHT_PREPARED>B__146_1 ();


        /// <summary>
        ///   System.Void <OnShotLanded>b__237_0()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<OnShotLanded>b__237_0")]
        ///  extern void <ON_SHOT_LANDED>B__237_0 ();


        /// <summary>
        ///   System.Void <OnShotLanded>b__237_1()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<OnShotLanded>b__237_1")]
        ///  extern void <ON_SHOT_LANDED>B__237_1 ();


        /// <summary>
        ///   System.Void <OpenGunPanel>b__189_0()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<OpenGunPanel>b__189_0")]
        ///  extern void <OPEN_GUN_PANEL>B__189_0 ();


        /// <summary>
        ///   System.Boolean <RemoveFromFight>b__183_3()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RemoveFromFight>b__183_3")]
        ///  extern System.Boolean <REMOVE_FROM_FIGHT>B__183_3 ();


        /// <summary>
        ///   System.Boolean <StartFight>b__143_0()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<StartFight>b__143_0")]
        ///  extern System.Boolean <START_FIGHT>B__143_0 ();


        /// <summary>
        ///   System.Boolean <StartFight>b__144_0()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<StartFight>b__144_0")]
        ///  extern System.Boolean <START_FIGHT>B__144_0 ();


        /// <summary>
        ///   System.Boolean <UseChargedSkill>b__215_0()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<UseChargedSkill>b__215_0")]
        ///  extern System.Boolean <USE_CHARGED_SKILL>B__215_0 ();


        /// <summary>
        ///   System.Collections.IEnumerator ActionChosen(BattleManager.Action action)
        /// </summary>
        /// <param name="action">enum BattleManager.Action</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ActionChosen")]
        ///  extern nint ACTION_CHOSEN (BattleManager.Action action);


        /// <summary>
        ///   System.Void AddAdditionalMove(BattleParticipantController unit)
        /// </summary>
        /// <param name="unit">abstract class BattleParticipantController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAdditionalMove")]
        ///  extern void ADD_ADDITIONAL_MOVE (nint unit);


        /// <summary>
        ///   System.Void AddLoot()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLoot")]
        ///  extern void ADD_LOOT ();


        /// <summary>
        ///   System.Void AddLootFromMonster(System.String dropUid, System.Int32 count)
        /// </summary>
        /// <param name="dropUid">class System.String</param>
        /// <param name="count">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLootFromMonster")]
        ///  extern void ADD_LOOT_FROM_MONSTER (nint dropUid, System.Int32 count);


        /// <summary>
        ///   System.Void ApplyAIAction(Battles.BattleAI.BattleAIAction action)
        /// </summary>
        /// <param name="action">class Battles.BattleAI.BattleAIAction</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyAIAction")]
        ///  extern void APPLY_AI_ACTION (nint action);


        /// <summary>
        ///   System.Void ApplyCastInfo(UsageInfo result, System.Boolean isTurnAction)
        /// </summary>
        /// <param name="result">class UsageInfo</param>
        /// <param name="isTurnAction">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyCastInfo")]
        ///  extern void APPLY_CAST_INFO (nint result, System.Boolean isTurnAction);


        /// <summary>
        ///   System.Collections.IEnumerator ApplyCustomAIActionRoutine(Battles.BattleAI.BattleAIAction action)
        /// </summary>
        /// <param name="action">class Battles.BattleAI.BattleAIAction</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyCustomAIActionRoutine")]
        ///  extern nint APPLY_CUSTOM_AI_ACTION_ROUTINE (nint action);


        /// <summary>
        ///   System.Void ApplyEffects(UsageInfo castInfo)
        /// </summary>
        /// <param name="castInfo">class UsageInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyEffects")]
        ///  extern void APPLY_EFFECTS (nint castInfo);


        /// <summary>
        ///   System.Collections.IEnumerator ApplyElectrificationDamage()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyElectrificationDamage")]
        ///  extern nint APPLY_ELECTRIFICATION_DAMAGE ();


        /// <summary>
        ///   System.Void ApplyMonsterAIAction()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyMonsterAIAction")]
        ///  extern void APPLY_MONSTER_AI_ACTION ();


        /// <summary>
        ///   System.Void ApplyRandomAIAction()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyRandomAIAction")]
        ///  extern void APPLY_RANDOM_AI_ACTION ();


        /// <summary>
        ///   System.Void Back()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Back")]
        ///  extern void BACK ();


        /// <summary>
        ///   System.Boolean CanAttackTargetInMelee(BattleParticipantController target)
        /// </summary>
        /// <param name="target">abstract class BattleParticipantController</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanAttackTargetInMelee")]
        ///  extern System.Boolean CAN_ATTACK_TARGET_IN_MELEE (nint target);


        /// <summary>
        ///   System.Boolean CanContinueAfterDefeat()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanContinueAfterDefeat")]
        ///  extern System.Boolean CAN_CONTINUE_AFTER_DEFEAT ();


        /// <summary>
        ///   System.Boolean CanDownTarget(BattleParticipantController target)
        /// </summary>
        /// <param name="target">abstract class BattleParticipantController</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanDownTarget")]
        ///  extern System.Boolean CAN_DOWN_TARGET (nint target);


        /// <summary>
        ///   System.Boolean CanSummon()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanSummon")]
        ///  extern System.Boolean CAN_SUMMON ();


        /// <summary>
        ///   System.String CanUseEffects(BattleParticipantController caster)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseEffects")]
        ///  extern nint CAN_USE_EFFECTS (nint caster);


        /// <summary>
        ///   System.Boolean CanUseHoldUp()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseHoldUp")]
        ///  extern System.Boolean CAN_USE_HOLD_UP ();


        /// <summary>
        ///   System.Collections.IEnumerator CastSkill(BattleParticipantController caster, EffectHolder skill, BattleParticipantController skillTarget, System.Boolean playCastAnimation, System.Boolean showSkillNameMessage)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <param name="skill">abstract class EffectHolder</param>
        /// <param name="skillTarget">abstract class BattleParticipantController</param>
        /// <param name="playCastAnimation">struct System.Boolean</param>
        /// <param name="showSkillNameMessage">struct System.Boolean</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CastSkill")]
        ///  extern nint CAST_SKILL (nint caster, nint skill, nint skillTarget, System.Boolean playCastAnimation, System.Boolean showSkillNameMessage);


        /// <summary>
        ///   System.Void ChangeParticipantTurnOrder(BattleParticipantController participant, BattleManager.TurnOrder turnOrder)
        /// </summary>
        /// <param name="participant">abstract class BattleParticipantController</param>
        /// <param name="turnOrder">enum BattleManager.TurnOrder</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ChangeParticipantTurnOrder")]
        ///  extern void CHANGE_PARTICIPANT_TURN_ORDER (nint participant, BattleManager.TurnOrder turnOrder);


        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckNullArgument")]
        /// static extern void CHECK_NULL_ARGUMENT (nint arg, nint message);


        /// <summary>
        ///   System.Void CloseActionHints()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloseActionHints")]
        ///  extern void CLOSE_ACTION_HINTS ();


        /// <summary>
        ///   System.Collections.IEnumerator CloseGunPanel(System.Boolean endTurn)
        /// </summary>
        /// <param name="endTurn">struct System.Boolean</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloseGunPanel")]
        ///  extern nint CLOSE_GUN_PANEL (System.Boolean endTurn);


        /// <summary>
        /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
        /// </summary>
        /// <param name="lhs">class UnityEngine.Object</param>
        /// <param name="rhs">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareBaseObjects")]
        /// static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs, nint rhs);


        /// <summary>
        ///   System.Boolean CompareTag(System.String tag)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTag")]
        ///  extern System.Boolean COMPARE_TAG (nint tag);


        /// <summary>
        ///   System.Void ContinueAfterDefeat()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ContinueAfterDefeat")]
        ///  extern void CONTINUE_AFTER_DEFEAT ();


        /// <summary>
        /// static  System.Boolean CurrentThreadIsMainThread()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CurrentThreadIsMainThread")]
        /// static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();


        /// <summary>
        ///   System.Void DisableBattleControls()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DisableBattleControls")]
        ///  extern void DISABLE_BATTLE_CONTROLS ();


        /// <summary>
        ///   System.Void DisableShowtime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DisableShowtime")]
        ///  extern void DISABLE_SHOWTIME ();


        /// <summary>
        ///   System.Void DisableUnitButtons()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DisableUnitButtons")]
        ///  extern void DISABLE_UNIT_BUTTONS ();


        /// <summary>
        ///   System.Void DisposeDeadSummonedMonsters()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DisposeDeadSummonedMonsters")]
        ///  extern void DISPOSE_DEAD_SUMMONED_MONSTERS ();


        /// <summary>
        /// static  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoesObjectWithInstanceIDExist")]
        /// static extern System.Boolean DOES_OBJECT_WITH_INSTANCE_ID_EXIST (System.Int32 instanceID);


        /// <summary>
        /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
        /// </summary>
        /// <param name="target">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DontDestroyOnLoad")]
        /// static extern void DONT_DESTROY_ON_LOAD (nint target);


        /// <summary>
        ///   System.Void DownTarget(BattleParticipantController attackTarget)
        /// </summary>
        /// <param name="attackTarget">abstract class BattleParticipantController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DownTarget")]
        ///  extern void DOWN_TARGET (nint attackTarget);


        /// <summary>
        ///   System.Void DownTargetFromAttack(BattleParticipantController attackTarget, BattleParticipantController attacker)
        /// </summary>
        /// <param name="attackTarget">abstract class BattleParticipantController</param>
        /// <param name="attacker">abstract class BattleParticipantController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DownTargetFromAttack")]
        ///  extern void DOWN_TARGET_FROM_ATTACK (nint attackTarget, nint attacker);


        /// <summary>
        ///   System.Void EnableShowtime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnableShowtime")]
        ///  extern void ENABLE_SHOWTIME ();


        /// <summary>
        ///   System.Collections.IEnumerator EndFight()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EndFight")]
        ///  extern nint END_FIGHT ();


        /// <summary>
        ///   System.Void EndFightWithRewards()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EndFightWithRewards")]
        ///  extern void END_FIGHT_WITH_REWARDS ();


        /// <summary>
        ///   System.Collections.IEnumerator EndTurn()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EndTurn")]
        ///  extern nint END_TURN ();


        /// <summary>
        ///   System.Void EnsureRunningOnMainThread()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureRunningOnMainThread")]
        ///  extern void ENSURE_RUNNING_ON_MAIN_THREAD ();


        /// <summary>
        ///   System.Boolean Equals(System.Object other)
        /// </summary>
        /// <param name="other">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
        ///  extern System.Boolean EQUALS (nint other);


        /// <summary>
        /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectFromInstanceID")]
        /// static extern nint FIND_OBJECT_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeAll")]
        /// static extern nint FIND_OBJECTS_OF_TYPE_ALL (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeIncludingAssets")]
        /// static extern nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindSceneObjectsOfType")]
        /// static extern nint FIND_SCENE_OBJECTS_OF_TYPE (nint type);


        /// <summary>
        /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceLoadFromInstanceID")]
        /// static extern nint FORCE_LOAD_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// <summary>
        ///   System.Void FormQueueOrder()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FormQueueOrder")]
        ///  extern void FORM_QUEUE_ORDER ();


        /// <summary>
        ///   UnityEngine.Vector3 get_bottomCharacterPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bottomCharacterPosition")]
        ///  extern UnityEngine.Vector3 GET_BOTTOM_CHARACTER_POSITION ();


        /// <summary>
        ///   UnityEngine.Vector3 get_bottomMonsterPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bottomMonsterPosition")]
        ///  extern UnityEngine.Vector3 GET_BOTTOM_MONSTER_POSITION ();


        /// <summary>
        ///   EffectHolder get_chosenSkill()
        /// </summary>
        /// <returns>abstract class EffectHolder</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_chosenSkill")]
        ///  extern nint GET_CHOSEN_SKILL ();


        /// <summary>
        ///   InputManager get_controls()
        /// </summary>
        /// <returns>class InputManager</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_controls")]
        ///  extern nint GET_CONTROLS ();


        /// <summary>
        ///   BattleManager.Action get_currentAction()
        /// </summary>
        /// <returns>enum BattleManager.Action</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentAction")]
        ///  extern BattleManager.Action GET_CURRENT_ACTION ();


        /// <summary>
        ///   BattleParticipantController get_currentCharacter()
        /// </summary>
        /// <returns>abstract class BattleParticipantController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentCharacter")]
        ///  extern nint GET_CURRENT_CHARACTER ();


        /// <summary>
        ///   System.Threading.CancellationToken get_destroyCancellationToken()
        /// </summary>
        /// <returns>struct System.Threading.CancellationToken</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_destroyCancellationToken")]
        ///  extern System.Threading.CancellationToken GET_DESTROY_CANCELLATION_TOKEN ();


        /// <summary>
        ///   System.Boolean get_enabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enabled")]
        ///  extern System.Boolean GET_ENABLED ();


        /// <summary>
        ///   UnityEngine.GameObject get_gameObject()
        /// </summary>
        /// <returns>class UnityEngine.GameObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameObject")]
        ///  extern nint GET_GAME_OBJECT ();


        /// <summary>
        ///   UnityEngine.HideFlags get_hideFlags()
        /// </summary>
        /// <returns>enum UnityEngine.HideFlags</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hideFlags")]
        ///  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();


        /// <summary>
        ///   System.Boolean get_isActiveAndEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isActiveAndEnabled")]
        ///  extern System.Boolean GET_IS_ACTIVE_AND_ENABLED ();


        /// <summary>
        ///   System.Boolean get_isPlayerControls()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerControls")]
        ///  extern System.Boolean GET_IS_PLAYER_CONTROLS ();


        /// <summary>
        ///   System.Boolean get_isPlayerTurn()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerTurn")]
        ///  extern System.Boolean GET_IS_PLAYER_TURN ();


        /// <summary>
        ///   UnityEngine.Vector3 get_leftCharacterPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_leftCharacterPosition")]
        ///  extern UnityEngine.Vector3 GET_LEFT_CHARACTER_POSITION ();


        /// <summary>
        ///   UnityEngine.Vector3 get_leftMonsterPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_leftMonsterPosition")]
        ///  extern UnityEngine.Vector3 GET_LEFT_MONSTER_POSITION ();


        /// <summary>
        ///   UnityEngine.Vector3 get_locationCharactersOffset()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_locationCharactersOffset")]
        ///  extern UnityEngine.Vector3 GET_LOCATION_CHARACTERS_OFFSET ();


        /// <summary>
        ///   UnityEngine.Vector3 get_locationMonstersOffset()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_locationMonstersOffset")]
        ///  extern UnityEngine.Vector3 GET_LOCATION_MONSTERS_OFFSET ();


        /// <summary>
        ///   Logger get_Logger()
        /// </summary>
        /// <returns>class Logger</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Logger")]
        ///  extern nint GET_LOGGER ();


        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_name")]
        ///  extern nint GET_NAME ();


        /// <summary>
        ///   UnityEngine.Vector3 get_rightCharacterPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rightCharacterPosition")]
        ///  extern UnityEngine.Vector3 GET_RIGHT_CHARACTER_POSITION ();


        /// <summary>
        ///   UnityEngine.Vector3 get_rightMonsterPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rightMonsterPosition")]
        ///  extern UnityEngine.Vector3 GET_RIGHT_MONSTER_POSITION ();


        /// <summary>
        ///   System.Boolean get_strangerCharacterTurn()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_strangerCharacterTurn")]
        ///  extern System.Boolean GET_STRANGER_CHARACTER_TURN ();


        /// <summary>
        ///   System.String get_tag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tag")]
        ///  extern nint GET_TAG ();


        /// <summary>
        /// static  BattleDefaultSettings get_testSettings()
        /// </summary>
        /// <returns>class BattleDefaultSettings</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_testSettings")]
        /// static extern nint GET_TEST_SETTINGS ();


        /// <summary>
        ///   UnityEngine.Vector3 get_topCharacterPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_topCharacterPosition")]
        ///  extern UnityEngine.Vector3 GET_TOP_CHARACTER_POSITION ();


        /// <summary>
        ///   UnityEngine.Vector3 get_topMonsterPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_topMonsterPosition")]
        ///  extern UnityEngine.Vector3 GET_TOP_MONSTER_POSITION ();


        /// <summary>
        ///   UnityEngine.Transform get_transform()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transform")]
        ///  extern nint GET_TRANSFORM ();


        /// <summary>
        ///   System.Boolean get_useGUILayout()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_useGUILayout")]
        ///  extern System.Boolean GET_USE_GUI_LAYOUT ();


        /// <summary>
        ///   BattleParticipantController GetActiveCharacter()
        /// </summary>
        /// <returns>abstract class BattleParticipantController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetActiveCharacter")]
        ///  extern nint GET_ACTIVE_CHARACTER ();


        /// <summary>
        ///   System.Collections.Generic.List<BattleParticipantController> GetAllAllies(BattleParticipantController participant)
        /// </summary>
        /// <param name="participant">abstract class BattleParticipantController</param>
        /// <returns>class System.Collections.Generic.List<BattleParticipantController></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllAllies")]
        ///  extern nint GET_ALL_ALLIES (nint participant);


        /// <summary>
        ///   System.Collections.Generic.List<BattleParticipantController> GetAllEnemies(BattleParticipantController participant)
        /// </summary>
        /// <param name="participant">abstract class BattleParticipantController</param>
        /// <returns>class System.Collections.Generic.List<BattleParticipantController></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllEnemies")]
        ///  extern nint GET_ALL_ENEMIES (nint participant);


        /// <summary>
        ///   System.Collections.Generic.List<BattleParticipantController> GetAlliesInFight(BattleParticipantController participant)
        /// </summary>
        /// <param name="participant">abstract class BattleParticipantController</param>
        /// <returns>class System.Collections.Generic.List<BattleParticipantController></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAlliesInFight")]
        ///  extern nint GET_ALLIES_IN_FIGHT (nint participant);


        /// <summary>
        ///   System.Collections.Generic.List<EffectHolder> GetAvailableConsumables()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<EffectHolder></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAvailableConsumables")]
        ///  extern nint GET_AVAILABLE_CONSUMABLES ();


        /// <summary>
        ///   System.Collections.Generic.List<BattleParticipantController> GetAvailableTargets()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<BattleParticipantController></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAvailableTargets")]
        ///  extern nint GET_AVAILABLE_TARGETS ();


        /// <summary>
        ///   System.Collections.Generic.List<BattleEffect> GetBatonPassEffects(BattleParticipantController initiator, BattleParticipantController target)
        /// </summary>
        /// <param name="initiator">abstract class BattleParticipantController</param>
        /// <param name="target">abstract class BattleParticipantController</param>
        /// <returns>class System.Collections.Generic.List<BattleEffect></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBatonPassEffects")]
        ///  extern nint GET_BATON_PASS_EFFECTS (nint initiator, nint target);


        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCachedPtr")]
        ///  extern System.IntPtr GET_CACHED_PTR ();


        /// <summary>
        ///   Character GetCharacter(BattleParticipantController battlePlayerController)
        /// </summary>
        /// <param name="battlePlayerController">abstract class BattleParticipantController</param>
        /// <returns>class Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCharacter")]
        ///  extern nint GET_CHARACTER (nint battlePlayerController);


        /// <summary>
        ///   UnityEngine.Vector3 GetCharacterPosition(BattleParticipantController participant)
        /// </summary>
        /// <param name="participant">abstract class BattleParticipantController</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCharacterPosition")]
        ///  extern UnityEngine.Vector3 GET_CHARACTER_POSITION (nint participant);


        /// <summary>
        ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="oneFurtherThanResultValue">struct System.IntPtr</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentFastPath")]
        ///  extern void GET_COMPONENT_FAST_PATH (nint type, System.IntPtr oneFurtherThanResultValue);


        /// <summary>
        ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
        /// </summary>
        /// <param name="searchType">abstract class System.Type</param>
        /// <param name="resultList">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsForListInternal")]
        ///  extern void GET_COMPONENTS_FOR_LIST_INTERNAL (nint searchType, nint resultList);


        /// <summary>
        ///   System.Collections.Generic.List<BattleParticipantController> GetEnemiesInFight(BattleParticipantController participant)
        /// </summary>
        /// <param name="participant">abstract class BattleParticipantController</param>
        /// <returns>class System.Collections.Generic.List<BattleParticipantController></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEnemiesInFight")]
        ///  extern nint GET_ENEMIES_IN_FIGHT (nint participant);


        /// <summary>
        /// static  System.Int32 GetExpForEnemies(System.Int32 characterLevel, System.Collections.Generic.List<BattleMonsterController> defeatedEnemies)
        /// </summary>
        /// <param name="characterLevel">struct System.Int32</param>
        /// <param name="defeatedEnemies">class System.Collections.Generic.List<BattleMonsterController></param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetExpForEnemies")]
        /// static extern System.Int32 GET_EXP_FOR_ENEMIES (System.Int32 characterLevel, nint defeatedEnemies);


        /// <summary>
        /// static  System.Single GetExpWithMultiplier(System.Int32 exp, System.Int32 characterLevel, System.Int32 targetLevel)
        /// </summary>
        /// <param name="exp">struct System.Int32</param>
        /// <param name="characterLevel">struct System.Int32</param>
        /// <param name="targetLevel">struct System.Int32</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetExpWithMultiplier")]
        /// static extern System.Single GET_EXP_WITH_MULTIPLIER (System.Int32 exp, System.Int32 characterLevel, System.Int32 targetLevel);


        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
        ///  extern System.Int32 GET_HASH_CODE ();


        /// <summary>
        ///   System.Int32 GetInitiative(BattleParticipantController participantController)
        /// </summary>
        /// <param name="participantController">abstract class BattleParticipantController</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInitiative")]
        ///  extern System.Int32 GET_INITIATIVE (nint participantController);


        /// <summary>
        ///   System.Int32 GetInstanceID()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInstanceID")]
        ///  extern System.Int32 GET_INSTANCE_ID ();


        /// <summary>
        ///   UnityEngine.Vector3 GetMonsterPosition(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMonsterPosition")]
        ///  extern UnityEngine.Vector3 GET_MONSTER_POSITION (System.Int32 index);


        /// <summary>
        ///   System.Collections.Generic.List<BattleMonsterModel> GetMonstersFromPool(System.String poolUid)
        /// </summary>
        /// <param name="poolUid">class System.String</param>
        /// <returns>class System.Collections.Generic.List<BattleMonsterModel></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMonstersFromPool")]
        ///  extern nint GET_MONSTERS_FROM_POOL (nint poolUid);


        /// <summary>
        ///   System.String[] GetMonstersUIDsFromPool(System.String poolUid)
        /// </summary>
        /// <param name="poolUid">class System.String</param>
        /// <returns>class System.String[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMonstersUIDsFromPool")]
        ///  extern nint GET_MONSTERS_UI_DS_FROM_POOL (nint poolUid);


        /// <summary>
        /// static  System.String GetName(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
        /// static extern nint GET_NAME (nint obj);


        /// <summary>
        /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOffsetOfInstanceIDInCPlusPlusObject")]
        /// static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();


        /// <summary>
        ///   BattlePlayerController GetParticipantInstanceFromCharacter(Character originalCharacter)
        /// </summary>
        /// <param name="originalCharacter">class Character</param>
        /// <returns>class BattlePlayerController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetParticipantInstanceFromCharacter")]
        ///  extern nint GET_PARTICIPANT_INSTANCE_FROM_CHARACTER (nint originalCharacter);


        /// <summary>
        ///   BattlePlayerController GetPlayerControllerInstance(Character originalCharacter)
        /// </summary>
        /// <param name="originalCharacter">class Character</param>
        /// <returns>class BattlePlayerController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPlayerControllerInstance")]
        ///  extern nint GET_PLAYER_CONTROLLER_INSTANCE (nint originalCharacter);


        /// <summary>
        ///   System.String GetScriptClassName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetScriptClassName")]
        ///  extern nint GET_SCRIPT_CLASS_NAME ();


        /// <summary>
        ///   System.Collections.Generic.List<BattleParticipantController> GetSkillTargets(BattleParticipantController caster, EffectHolder skill, BattleParticipantController skillTarget)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <param name="skill">abstract class EffectHolder</param>
        /// <param name="skillTarget">abstract class BattleParticipantController</param>
        /// <returns>class System.Collections.Generic.List<BattleParticipantController></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSkillTargets")]
        ///  extern nint GET_SKILL_TARGETS (nint caster, nint skill, nint skillTarget);


        /// <summary>
        ///   System.Boolean HaveCharactersInFight()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HaveCharactersInFight")]
        ///  extern System.Boolean HAVE_CHARACTERS_IN_FIGHT ();


        /// <summary>
        ///   System.Void InitContexts()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitContexts")]
        ///  extern void INIT_CONTEXTS ();


        /// <summary>
        ///   BattlePlayerController InstantiatePlayer(Character originalCharacter)
        /// </summary>
        /// <param name="originalCharacter">class Character</param>
        /// <returns>class BattlePlayerController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InstantiatePlayer")]
        ///  extern nint INSTANTIATE_PLAYER (nint originalCharacter);


        /// <summary>
        ///   BattlePlayerController InstantiatePlayerDoppelganger(Character originalCharacter, BattleParticipantController caster)
        /// </summary>
        /// <param name="originalCharacter">class Character</param>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <returns>class BattlePlayerController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InstantiatePlayerDoppelganger")]
        ///  extern nint INSTANTIATE_PLAYER_DOPPELGANGER (nint originalCharacter, nint caster);


        /// <summary>
        /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CancelInvokeAll")]
        /// static extern void INTERNAL_CANCEL_INVOKE_ALL (nint self);


        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingle")]
        /// static extern nint INTERNAL_CLONE_SINGLE (nint data);


        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingleWithParent")]
        /// static extern nint INTERNAL_CLONE_SINGLE_WITH_PARENT (nint data, nint parent, System.Boolean worldPositionStays);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE (nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle_Injected")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE_INJECTED (nint data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT (nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent_Injected")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED (nint data, nint parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);


        /// <summary>
        /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_IsInvokingAll")]
        /// static extern System.Boolean INTERNAL_IS_INVOKING_ALL (nint self);


        /// <summary>
        ///   System.Void Invoke(System.String methodName, System.Single time)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="time">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Invoke")]
        ///  extern void INVOKE (nint methodName, System.Single time);


        /// <summary>
        /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <param name="time">struct System.Single</param>
        /// <param name="repeatRate">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeDelayed")]
        /// static extern void INVOKE_DELAYED (nint self, nint methodName, System.Single time, System.Single repeatRate);


        /// <summary>
        ///   System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="time">struct System.Single</param>
        /// <param name="repeatRate">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeRepeating")]
        ///  extern void INVOKE_REPEATING (nint methodName, System.Single time, System.Single repeatRate);


        /// <summary>
        ///   System.Boolean IsAvailableBatonPass()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsAvailableBatonPass")]
        ///  extern System.Boolean IS_AVAILABLE_BATON_PASS ();


        /// <summary>
        ///   System.Boolean IsFirstActionThisTurn()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsFirstActionThisTurn")]
        ///  extern System.Boolean IS_FIRST_ACTION_THIS_TURN ();


        /// <summary>
        ///   System.Boolean IsGuardEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsGuardEnabled")]
        ///  extern System.Boolean IS_GUARD_ENABLED ();


        /// <summary>
        ///   System.Boolean IsItemsEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsItemsEnabled")]
        ///  extern System.Boolean IS_ITEMS_ENABLED ();


        /// <summary>
        ///   System.Boolean IsMeleeEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsMeleeEnabled")]
        ///  extern System.Boolean IS_MELEE_ENABLED ();


        /// <summary>
        /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
        /// </summary>
        /// <param name="o">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsNativeObjectAlive")]
        /// static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);


        /// <summary>
        /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsObjectMonoBehaviour")]
        /// static extern System.Boolean IS_OBJECT_MONO_BEHAVIOUR (nint obj);


        /// <summary>
        /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPersistent")]
        /// static extern System.Boolean IS_PERSISTENT (nint obj);


        /// <summary>
        ///   System.Boolean IsRangedEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsRangedEnabled")]
        ///  extern System.Boolean IS_RANGED_ENABLED ();


        /// <summary>
        ///   System.Boolean IsSecondActionThisTurn()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsSecondActionThisTurn")]
        ///  extern System.Boolean IS_SECOND_ACTION_THIS_TURN ();


        /// <summary>
        ///   System.Boolean IsSkillsEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsSkillsEnabled")]
        ///  extern System.Boolean IS_SKILLS_ENABLED ();


        /// <summary>
        /// static  System.Boolean IsStatusEffectResisted(DamageType damageType, StatusEffect.Type statusType, BattleParticipantController target)
        /// </summary>
        /// <param name="damageType">enum DamageType</param>
        /// <param name="statusType">enum StatusEffect.Type</param>
        /// <param name="target">abstract class BattleParticipantController</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsStatusEffectResisted")]
        /// static extern System.Boolean IS_STATUS_EFFECT_RESISTED (DamageType damageType, StatusEffect.Type statusType, nint target);


        /// <summary>
        /// static  BattleParticipantModel LoadMonster(System.String monsterUid)
        /// </summary>
        /// <param name="monsterUid">class System.String</param>
        /// <returns>abstract class BattleParticipantModel</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadMonster")]
        /// static extern nint LOAD_MONSTER (nint monsterUid);


        /// <summary>
        ///   System.Void MarkDirty()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MarkDirty")]
        ///  extern void MARK_DIRTY ();


        /// <summary>
        ///   System.Collections.IEnumerator MeleeAttack(BattleParticipantController attacker, BattleParticipantController attackTarget)
        /// </summary>
        /// <param name="attacker">abstract class BattleParticipantController</param>
        /// <param name="attackTarget">abstract class BattleParticipantController</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MeleeAttack")]
        ///  extern nint MELEE_ATTACK (nint attacker, nint attackTarget);


        /// <summary>
        ///   System.Void OnAnalyzePanelClosed()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnAnalyzePanelClosed")]
        ///  extern void ON_ANALYZE_PANEL_CLOSED ();


        /// <summary>
        ///   System.Void OnAnalyzePanelOpened()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnAnalyzePanelOpened")]
        ///  extern void ON_ANALYZE_PANEL_OPENED ();


        /// <summary>
        ///   System.Void OnBattleActionChosen(BattleManager.Action action)
        /// </summary>
        /// <param name="action">enum BattleManager.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnBattleActionChosen")]
        ///  extern void ON_BATTLE_ACTION_CHOSEN (BattleManager.Action action);


        /// <summary>
        ///   System.Void OnCancellationTokenCreated()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCancellationTokenCreated")]
        ///  extern void ON_CANCELLATION_TOKEN_CREATED ();


        /// <summary>
        ///   System.Void OnDamagingActionApplied(UsageInfo usageInfo)
        /// </summary>
        /// <param name="usageInfo">class UsageInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDamagingActionApplied")]
        ///  extern void ON_DAMAGING_ACTION_APPLIED (nint usageInfo);


        /// <summary>
        ///   System.Void OnDestroy()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDestroy")]
        ///  extern void ON_DESTROY ();


        /// <summary>
        ///   System.Void OnDisable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnDisable")]
        ///  extern void ON_DISABLE ();


        /// <summary>
        ///   System.Void OnEnable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnEnable")]
        ///  extern void ON_ENABLE ();


        /// <summary>
        ///   System.Collections.IEnumerator OnFightPrepared(BattleManager.FightType fightType)
        /// </summary>
        /// <param name="fightType">enum BattleManager.FightType</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnFightPrepared")]
        ///  extern nint ON_FIGHT_PREPARED (BattleManager.FightType fightType);


        /// <summary>
        ///   System.Void OnHPChange(BattleParticipantController character)
        /// </summary>
        /// <param name="character">abstract class BattleParticipantController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnHPChange")]
        ///  extern void ON_HP_CHANGE (nint character);


        /// <summary>
        ///   System.Boolean OnlyBattleSceneLoaded()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnlyBattleSceneLoaded")]
        ///  extern System.Boolean ONLY_BATTLE_SCENE_LOADED ();


        /// <summary>
        ///   System.Void OnMeleeAttackLanded(UsageInfo attackInfo, System.Boolean isTurnAction)
        /// </summary>
        /// <param name="attackInfo">class UsageInfo</param>
        /// <param name="isTurnAction">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnMeleeAttackLanded")]
        ///  extern void ON_MELEE_ATTACK_LANDED (nint attackInfo, System.Boolean isTurnAction);


        /// <summary>
        ///   System.Void OnMenuButtonPressed()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnMenuButtonPressed")]
        ///  extern void ON_MENU_BUTTON_PRESSED ();


        /// <summary>
        ///   System.Collections.IEnumerator OnOneTeamDefeated()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnOneTeamDefeated")]
        ///  extern nint ON_ONE_TEAM_DEFEATED ();


        /// <summary>
        ///   System.Void OnReturnedToGameState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnReturnedToGameState")]
        ///  extern void ON_RETURNED_TO_GAME_STATE ();


        /// <summary>
        ///   System.Collections.IEnumerator OnShotLanded(UsageInfo shotInfo)
        /// </summary>
        /// <param name="shotInfo">class UsageInfo</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnShotLanded")]
        ///  extern nint ON_SHOT_LANDED (nint shotInfo);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_BattleManager))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_BattleManager))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_BattleManager))]
        ///  extern void .CTOR_02 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_BattleManager))]
        ///  extern void .CTOR_03 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_BattleManager))]
        ///  extern void .CTOR_04 ();


        /// <summary>
        ///   System.Void ApplyPlayerAIAction(BattlePlayerModel.Tactics tactics)
        /// </summary>
        /// <param name="tactics">enum BattlePlayerModel.Tactics</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyPlayerAIAction", Search = typeof(Search_BattleManager))]
        ///  extern void APPLY_PLAYER_AI_ACTION_00 (BattlePlayerModel.Tactics tactics);


        /// <summary>
        ///   System.Void ApplyPlayerAIAction()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyPlayerAIAction", Search = typeof(Search_BattleManager))]
        ///  extern void APPLY_PLAYER_AI_ACTION_01 ();


        /// <summary>
        ///   System.Void CancelInvoke()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_BattleManager))]
        ///  extern void CANCEL_INVOKE_00 ();


        /// <summary>
        ///   System.Void CancelInvoke(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_BattleManager))]
        ///  extern void CANCEL_INVOKE_01 (nint methodName);


        /// <summary>
        /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_BattleManager))]
        /// static extern void CANCEL_INVOKE_02 (nint self, nint methodName);


        /// <summary>
        ///   System.String CanUseEffect(BattleParticipantController caster, EffectHolder skill)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <param name="skill">abstract class EffectHolder</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseEffect", Search = typeof(Search_BattleManager))]
        ///  extern nint CAN_USE_EFFECT_00 (nint caster, nint skill);


        /// <summary>
        ///   System.String CanUseEffect(BattleParticipantController caster, EffectHolder skill, System.Collections.Generic.List<BattleParticipantController> skillTargets)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <param name="skill">abstract class EffectHolder</param>
        /// <param name="skillTargets">class System.Collections.Generic.List<BattleParticipantController></param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseEffect", Search = typeof(Search_BattleManager))]
        ///  extern nint CAN_USE_EFFECT_01 (nint caster, nint skill, nint skillTargets);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_BattleManager))]
        /// static extern void DESTROY_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_BattleManager))]
        /// static extern void DESTROY_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="allowDestroyingAssets">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_BattleManager))]
        /// static extern void DESTROY_IMMEDIATE_00 (nint obj, System.Boolean allowDestroyingAssets);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_BattleManager))]
        /// static extern void DESTROY_IMMEDIATE_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_BattleManager))]
        /// static extern void DESTROY_OBJECT_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_BattleManager))]
        /// static extern void DESTROY_OBJECT_01 (nint obj);


        /// <summary>
        /// static  T FindAnyObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  T FindFirstObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECT_OF_TYPE_00 ();


        /// <summary>
        /// static  T FindObjectOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECT_OF_TYPE_01 (System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECT_OF_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECT_OF_TYPE_03 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_00 (nint type, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_01 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_02 (UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_03 (UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_02 ();


        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_BattleManager))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_00 (nint type);


        /// <summary>
        ///   T GetComponent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_01 ();


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_01 (nint t);


        /// <summary>
        ///   T GetComponentInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInChildren()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_03 ();


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T GetComponentInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInParent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENT_IN_PARENT_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponents(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENTS_00 (nint type);


        /// <summary>
        ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_BattleManager))]
        ///  extern void GET_COMPONENTS_01 (nint type, nint results);


        /// <summary>
        ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_BattleManager))]
        ///  extern void GET_COMPONENTS_02 (nint results);


        /// <summary>
        ///   T[] GetComponents()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENTS_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_00 (nint t);


        /// <summary>
        ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_01 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="result">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_BattleManager))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_02 (System.Boolean includeInactive, nint result);


        /// <summary>
        ///   T[] GetComponentsInChildren()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_03 ();


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_BattleManager))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_04 (nint results);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T[] GetComponentsInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_BattleManager))]
        ///  extern void GET_COMPONENTS_IN_PARENT_03 (System.Boolean includeInactive, nint results);


        /// <summary>
        ///   T[] GetComponentsInParent()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_BattleManager))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_04 ();


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_00 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_01 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_02 (nint original);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_03 (nint original, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_04 (nint original, nint parent, System.Boolean instantiateInWorldSpace);


        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// <param name="original">class T</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_05 (nint original);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_06 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_07 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_08 (nint original, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_BattleManager))]
        /// static extern nint INSTANTIATE_09 (nint original, nint parent, System.Boolean worldPositionStays);


        /// <summary>
        ///   System.Boolean IsInvoking()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_BattleManager))]
        ///  extern System.Boolean IS_INVOKING_00 ();


        /// <summary>
        ///   System.Boolean IsInvoking(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_BattleManager))]
        ///  extern System.Boolean IS_INVOKING_01 (nint methodName);


        /// <summary>
        /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_BattleManager))]
        /// static extern System.Boolean IS_INVOKING_02 (nint self, nint methodName);


        /// <summary>
        /// static  System.Boolean IsTechnical(BattleParticipantController attackTarget, EffectHolder skill)
        /// </summary>
        /// <param name="attackTarget">abstract class BattleParticipantController</param>
        /// <param name="skill">abstract class EffectHolder</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsTechnical", Search = typeof(Search_BattleManager))]
        /// static extern System.Boolean IS_TECHNICAL_00 (nint attackTarget, nint skill);


        /// <summary>
        /// static  System.Boolean IsTechnical(BattleParticipantController attackTarget, DamageType damageType)
        /// </summary>
        /// <param name="attackTarget">abstract class BattleParticipantController</param>
        /// <param name="damageType">enum DamageType</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsTechnical", Search = typeof(Search_BattleManager))]
        /// static extern System.Boolean IS_TECHNICAL_01 (nint attackTarget, DamageType damageType);


        /// <summary>
        ///   System.Void LogUsageInfo(System.String message, UsageInfo usageInfo)
        /// </summary>
        /// <param name="message">class System.String</param>
        /// <param name="usageInfo">class UsageInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LogUsageInfo", Search = typeof(Search_BattleManager))]
        ///  extern void LOG_USAGE_INFO_00 (nint message, nint usageInfo);


        /// <summary>
        ///   System.Void LogUsageInfo(System.String message, System.Collections.Generic.List<UsageInfo> usageInfos)
        /// </summary>
        /// <param name="message">class System.String</param>
        /// <param name="usageInfos">class System.Collections.Generic.List<UsageInfo></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LogUsageInfo", Search = typeof(Search_BattleManager))]
        ///  extern void LOG_USAGE_INFO_01 (nint message, nint usageInfos);


        /// public static partial class Search_BattleManager
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
        ///   System.Void ApplyPlayerAIAction(BattlePlayerModel.Tactics tactics)
        /// </summary>
        /// public static bool APPLY_PLAYER_AI_ACTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ApplyPlayerAIAction", "BattlePlayerModel.Tactics");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void ApplyPlayerAIAction()
        /// </summary>
        /// public static bool APPLY_PLAYER_AI_ACTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ApplyPlayerAIAction");
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
        ///   System.String CanUseEffect(BattleParticipantController caster, EffectHolder skill)
        /// </summary>
        /// public static bool CAN_USE_EFFECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanUseEffect", "BattleParticipantController", "EffectHolder");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.String CanUseEffect(BattleParticipantController caster, EffectHolder skill, System.Collections.Generic.List<BattleParticipantController> skillTargets)
        /// </summary>
        /// public static bool CAN_USE_EFFECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanUseEffect", "BattleParticipantController", "EffectHolder", "System.Collections.Generic.List<BattleParticipantController>");
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
        /// static  System.Boolean IsTechnical(BattleParticipantController attackTarget, EffectHolder skill)
        /// </summary>
        /// public static bool IS_TECHNICAL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsTechnical", "BattleParticipantController", "EffectHolder");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Boolean IsTechnical(BattleParticipantController attackTarget, DamageType damageType)
        /// </summary>
        /// public static bool IS_TECHNICAL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsTechnical", "BattleParticipantController", "DamageType");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void LogUsageInfo(System.String message, UsageInfo usageInfo)
        /// </summary>
        /// public static bool LOG_USAGE_INFO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LogUsageInfo", "System.String", "UsageInfo");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void LogUsageInfo(System.String message, System.Collections.Generic.List<UsageInfo> usageInfos)
        /// </summary>
        /// public static bool LOG_USAGE_INFO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LogUsageInfo", "System.String", "System.Collections.Generic.List<UsageInfo>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."BattleManager"]
    /// </summary>
    public partial class BattleManager
    {



        /// <summary>
        ///   System.Void OnSkillChosen(EffectHolder skill)
        /// </summary>
        /// <param name="skill">abstract class EffectHolder</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnSkillChosen")]
        ///  extern void ON_SKILL_CHOSEN (nint skill);


        /// <summary>
        ///   System.Void OnSwitchedFromGameState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnSwitchedFromGameState")]
        ///  extern void ON_SWITCHED_FROM_GAME_STATE ();


        /// <summary>
        ///   System.Collections.IEnumerator OnTargetChosen(BattleParticipantController newTarget, System.Boolean aiGeneratedAction)
        /// </summary>
        /// <param name="newTarget">abstract class BattleParticipantController</param>
        /// <param name="aiGeneratedAction">struct System.Boolean</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnTargetChosen")]
        ///  extern nint ON_TARGET_CHOSEN (nint newTarget, System.Boolean aiGeneratedAction);


        /// <summary>
        ///   System.Void OnTargetSelected(BattleParticipantController selectedTarget)
        /// </summary>
        /// <param name="selectedTarget">abstract class BattleParticipantController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnTargetSelected")]
        ///  extern void ON_TARGET_SELECTED (nint selectedTarget);


        /// <summary>
        ///   System.Void OnTurnStarted()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnTurnStarted")]
        ///  extern void ON_TURN_STARTED ();


        /// <summary>
        ///   System.Void OnUnrecognizedAIAction()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnUnrecognizedAIAction")]
        ///  extern void ON_UNRECOGNIZED_AI_ACTION ();


        /// <summary>
        /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality")]
        /// static extern System.Boolean OP_EQUALITY (nint x, nint y);


        /// <summary>
        /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
        /// </summary>
        /// <param name="exists">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit")]
        /// static extern System.Boolean OP_IMPLICIT (nint exists);


        /// <summary>
        /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality")]
        /// static extern System.Boolean OP_INEQUALITY (nint x, nint y);


        /// <summary>
        ///   System.Collections.IEnumerator OpenGunPanel()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OpenGunPanel")]
        ///  extern nint OPEN_GUN_PANEL ();


        /// <summary>
        /// static  System.Void print(System.Object message)
        /// </summary>
        /// <param name="message">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("print")]
        /// static extern void PRINT (nint message);


        /// <summary>
        ///   System.Void RaiseCancellation()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RaiseCancellation")]
        ///  extern void RAISE_CANCELLATION ();


        /// <summary>
        ///   System.Collections.IEnumerator RemoveFromFight(BattleParticipantController character)
        /// </summary>
        /// <param name="character">abstract class BattleParticipantController</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFromFight")]
        ///  extern nint REMOVE_FROM_FIGHT (nint character);


        /// <summary>
        ///   System.Void ResetChargingSkillReferences(BattleParticipantController caster)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetChargingSkillReferences")]
        ///  extern void RESET_CHARGING_SKILL_REFERENCES (nint caster);


        /// <summary>
        ///   System.Void ResetTimeScale()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetTimeScale")]
        ///  extern void RESET_TIME_SCALE ();


        /// <summary>
        ///   System.Void set_chosenSkill(EffectHolder value)
        /// </summary>
        /// <param name="value">abstract class EffectHolder</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_chosenSkill")]
        ///  extern void SET_CHOSEN_SKILL (nint value);


        /// <summary>
        ///   System.Void set_currentAction(BattleManager.Action value)
        /// </summary>
        /// <param name="value">enum BattleManager.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_currentAction")]
        ///  extern void SET_CURRENT_ACTION (BattleManager.Action value);


        /// <summary>
        ///   System.Void set_currentCharacter(BattleParticipantController value)
        /// </summary>
        /// <param name="value">abstract class BattleParticipantController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_currentCharacter")]
        ///  extern void SET_CURRENT_CHARACTER (nint value);


        /// <summary>
        ///   System.Void set_enabled(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_enabled")]
        ///  extern void SET_ENABLED (System.Boolean value);


        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_hideFlags")]
        ///  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);


        /// <summary>
        ///   System.Void set_name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_name")]
        ///  extern void SET_NAME (nint value);


        /// <summary>
        ///   System.Void set_tag(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_tag")]
        ///  extern void SET_TAG (nint value);


        /// <summary>
        ///   System.Void set_useGUILayout(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_useGUILayout")]
        ///  extern void SET_USE_GUI_LAYOUT (System.Boolean value);


        /// <summary>
        ///   System.Void SetBatonPass(BattleParticipantController targetController)
        /// </summary>
        /// <param name="targetController">abstract class BattleParticipantController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBatonPass")]
        ///  extern void SET_BATON_PASS (nint targetController);


        /// <summary>
        ///   System.Void SetBattleControls()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBattleControls")]
        ///  extern void SET_BATTLE_CONTROLS ();


        /// <summary>
        ///   System.Void SetChargedAttackTarget(BattleParticipantController caster, EffectHolder skill, BattleParticipantController skillTarget)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <param name="skill">abstract class EffectHolder</param>
        /// <param name="skillTarget">abstract class BattleParticipantController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetChargedAttackTarget")]
        ///  extern void SET_CHARGED_ATTACK_TARGET (nint caster, nint skill, nint skillTarget);


        /// <summary>
        ///   System.Void SetLocation(MonsterEncounter.Location newLocation)
        /// </summary>
        /// <param name="newLocation">enum MonsterEncounter.Location</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocation")]
        ///  extern void SET_LOCATION (MonsterEncounter.Location newLocation);


        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
        /// static extern void SET_NAME (nint obj, nint name);


        /// <summary>
        ///   System.Void SetTimeScaleToZero()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTimeScaleToZero")]
        ///  extern void SET_TIME_SCALE_TO_ZERO ();


        /// <summary>
        ///   System.Void SetupAvailableTargetsUI(System.Boolean resetBack, System.Boolean updateTarget)
        /// </summary>
        /// <param name="resetBack">struct System.Boolean</param>
        /// <param name="updateTarget">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetupAvailableTargetsUI")]
        ///  extern void SETUP_AVAILABLE_TARGETS_UI (System.Boolean resetBack, System.Boolean updateTarget);


        /// <summary>
        ///   BattleMonsterController SetupMonsterWithNewModel(BattleParticipantController monster, BattleParticipantModel model)
        /// </summary>
        /// <param name="monster">abstract class BattleParticipantController</param>
        /// <param name="model">abstract class BattleParticipantModel</param>
        /// <returns>class BattleMonsterController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetupMonsterWithNewModel")]
        ///  extern nint SETUP_MONSTER_WITH_NEW_MODEL (nint monster, nint model);


        /// <summary>
        ///   BattleMonsterController SetupNewEnemy(BattleParticipantModel monsterModel, System.Int32 index, System.Int32 totalMonstersCount, System.Boolean summoned)
        /// </summary>
        /// <param name="monsterModel">abstract class BattleParticipantModel</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="totalMonstersCount">struct System.Int32</param>
        /// <param name="summoned">struct System.Boolean</param>
        /// <returns>class BattleMonsterController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetupNewEnemy")]
        ///  extern nint SETUP_NEW_ENEMY (nint monsterModel, System.Int32 index, System.Int32 totalMonstersCount, System.Boolean summoned);


        /// <summary>
        ///   System.Collections.IEnumerator Shoot(BattleParticipantController attacker, BattleParticipantController attackTarget)
        /// </summary>
        /// <param name="attacker">abstract class BattleParticipantController</param>
        /// <param name="attackTarget">abstract class BattleParticipantController</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Shoot")]
        ///  extern nint SHOOT (nint attacker, nint attackTarget);


        /// <summary>
        /// static  System.Boolean ShouldBattleControlsBeEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldBattleControlsBeEnabled")]
        /// static extern System.Boolean SHOULD_BATTLE_CONTROLS_BE_ENABLED ();


        /// <summary>
        ///   System.Boolean ShouldMonsterGetAdditionalTurn()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldMonsterGetAdditionalTurn")]
        ///  extern System.Boolean SHOULD_MONSTER_GET_ADDITIONAL_TURN ();


        /// <summary>
        ///   System.Collections.IEnumerator ShowLevelUpPanels(System.Collections.Generic.Dictionary<Character,System.Int32> characterLevelsBefore, System.Collections.Generic.Dictionary<PersonaProgress,System.Int32> personaLevelsBefore)
        /// </summary>
        /// <param name="characterLevelsBefore">class System.Collections.Generic.Dictionary<Character,System.Int32></param>
        /// <param name="personaLevelsBefore">class System.Collections.Generic.Dictionary<PersonaProgress,System.Int32></param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowLevelUpPanels")]
        ///  extern nint SHOW_LEVEL_UP_PANELS (nint characterLevelsBefore, nint personaLevelsBefore);


        /// <summary>
        /// static  System.Void ShowMessage(System.String message, UnityEngine.Vector3 position, MessageManager.TextTypes textType)
        /// </summary>
        /// <param name="message">class System.String</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="textType">enum MessageManager.TextTypes</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowMessage")]
        /// static extern void SHOW_MESSAGE (nint message, UnityEngine.Vector3 position, MessageManager.TextTypes textType);


        /// <summary>
        ///   System.Void SignalStatusEffectResisted(BattleParticipantController target, StatusEffect.Type statusType)
        /// </summary>
        /// <param name="target">abstract class BattleParticipantController</param>
        /// <param name="statusType">enum StatusEffect.Type</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SignalStatusEffectResisted")]
        ///  extern void SIGNAL_STATUS_EFFECT_RESISTED (nint target, StatusEffect.Type statusType);


        /// <summary>
        ///   System.Collections.IEnumerator SkipTurnAnimation(BattleParticipantController character)
        /// </summary>
        /// <param name="character">abstract class BattleParticipantController</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SkipTurnAnimation")]
        ///  extern nint SKIP_TURN_ANIMATION (nint character);


        /// <summary>
        ///   System.Collections.IEnumerator Start()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Start")]
        ///  extern nint START ();


        /// <summary>
        ///   System.Collections.IEnumerator StartChargingSkill(BattleParticipantController caster, EffectHolder skill, BattleParticipantController skillTarget)
        /// </summary>
        /// <param name="caster">abstract class BattleParticipantController</param>
        /// <param name="skill">abstract class EffectHolder</param>
        /// <param name="skillTarget">abstract class BattleParticipantController</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartChargingSkill")]
        ///  extern nint START_CHARGING_SKILL (nint caster, nint skill, nint skillTarget);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine_Auto")]
        ///  extern nint START_COROUTINE_AUTO (nint routine);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged")]
        ///  extern nint START_COROUTINE_MANAGED (nint methodName, nint value);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
        /// </summary>
        /// <param name="enumerator">interface System.Collections.IEnumerator</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged2")]
        ///  extern nint START_COROUTINE_MANAGED2 (nint enumerator);


        /// <summary>
        ///   System.Collections.IEnumerator StartDebugShowtime(BattleParticipantController initiator, BattleParticipantController assistant)
        /// </summary>
        /// <param name="initiator">abstract class BattleParticipantController</param>
        /// <param name="assistant">abstract class BattleParticipantController</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartDebugShowtime")]
        ///  extern nint START_DEBUG_SHOWTIME (nint initiator, nint assistant);


        /// <summary>
        ///   System.Collections.IEnumerator StartFollowUp(BattlePlayerController character)
        /// </summary>
        /// <param name="character">class BattlePlayerController</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartFollowUp")]
        ///  extern nint START_FOLLOW_UP (nint character);


        /// <summary>
        ///   System.Collections.IEnumerator StartHoldUp()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartHoldUp")]
        ///  extern nint START_HOLD_UP ();


        /// <summary>
        ///   System.Collections.IEnumerator StartShowtime(BattleParticipantController initiator, BattleParticipantController assistant, BattleParticipantController target)
        /// </summary>
        /// <param name="initiator">abstract class BattleParticipantController</param>
        /// <param name="assistant">abstract class BattleParticipantController</param>
        /// <param name="target">abstract class BattleParticipantController</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartShowtime")]
        ///  extern nint START_SHOWTIME (nint initiator, nint assistant, nint target);


        /// <summary>
        ///   System.Void StartTurn()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartTurn")]
        ///  extern void START_TURN ();


        /// <summary>
        ///   System.Void StopAllCoroutines()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopAllCoroutines")]
        ///  extern void STOP_ALL_COROUTINES ();


        /// <summary>
        ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineFromEnumeratorManaged")]
        ///  extern void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED (nint routine);


        /// <summary>
        ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
        /// </summary>
        /// <param name="routine">class UnityEngine.Coroutine</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineManaged")]
        ///  extern void STOP_COROUTINE_MANAGED (nint routine);


        /// <summary>
        ///   System.Void Subscribe()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Subscribe")]
        ///  extern void SUBSCRIBE ();


        /// <summary>
        ///   System.Collections.Generic.List<BattleMonsterController> SummonMonsters(System.String uid)
        /// </summary>
        /// <param name="uid">class System.String</param>
        /// <returns>class System.Collections.Generic.List<BattleMonsterController></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SummonMonsters")]
        ///  extern nint SUMMON_MONSTERS (nint uid);


        /// <summary>
        ///   System.Void Unsubscribe()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Unsubscribe")]
        ///  extern void UNSUBSCRIBE ();


        /// <summary>
        ///   System.Void UpdateCharactersEndInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateCharactersEndInfo")]
        ///  extern void UPDATE_CHARACTERS_END_INFO ();


        /// <summary>
        ///   System.Void UpdateCharactersStartInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateCharactersStartInfo")]
        ///  extern void UPDATE_CHARACTERS_START_INFO ();


        /// <summary>
        ///   System.String UsageInfoToFormattedString(UsageInfo usageInfo)
        /// </summary>
        /// <param name="usageInfo">class UsageInfo</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UsageInfoToFormattedString")]
        ///  extern nint USAGE_INFO_TO_FORMATTED_STRING (nint usageInfo);


        /// <summary>
        ///   System.Collections.IEnumerator UseChargedSkill()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UseChargedSkill")]
        ///  extern nint USE_CHARGED_SKILL ();


        /// <summary>
        /// static  System.Collections.IEnumerator WaitForCutscenes()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("WaitForCutscenes")]
        /// static extern nint WAIT_FOR_CUTSCENES ();



        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_BattleManager))]
        ///  extern nint START_COROUTINE_00 (nint methodName);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_BattleManager))]
        ///  extern nint START_COROUTINE_01 (nint methodName, nint value);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_BattleManager))]
        ///  extern nint START_COROUTINE_02 (nint routine);


        /// <summary>
        ///   System.Collections.IEnumerator StartFight(BattleDefaultSettings settings)
        /// </summary>
        /// <param name="settings">class BattleDefaultSettings</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartFight", Search = typeof(Search_BattleManager))]
        ///  extern nint START_FIGHT_00 (nint settings);


        /// <summary>
        ///   System.Collections.IEnumerator StartFight(MonsterEncounter encounter, BattleManager.FightType fightType)
        /// </summary>
        /// <param name="encounter">class MonsterEncounter</param>
        /// <param name="fightType">enum BattleManager.FightType</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartFight", Search = typeof(Search_BattleManager))]
        ///  extern nint START_FIGHT_01 (nint encounter, BattleManager.FightType fightType);


        /// <summary>
        ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_BattleManager))]
        ///  extern void STOP_COROUTINE_00 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
        /// </summary>
        /// <param name="routine">class UnityEngine.Coroutine</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_BattleManager))]
        ///  extern void STOP_COROUTINE_01 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_BattleManager))]
        ///  extern void STOP_COROUTINE_02 (nint methodName);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_BattleManager))]
        ///  extern nint TO_STRING_00 ();


        /// <summary>
        /// static  System.String ToString(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_BattleManager))]
        /// static extern nint TO_STRING_01 (nint obj);


        /// <summary>
        ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="component">class UnityEngine.Component&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_BattleManager))]
        ///  extern System.Boolean TRY_GET_COMPONENT_00 (nint type, nint component);


        /// <summary>
        ///   System.Boolean TryGetComponent(T& component)
        /// </summary>
        /// <param name="component">class T&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_BattleManager))]
        ///  extern System.Boolean TRY_GET_COMPONENT_01 (nint component);


        /// public static partial class Search_BattleManager
        /// {
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
        ///   System.Collections.IEnumerator StartFight(BattleDefaultSettings settings)
        /// </summary>
        /// public static bool START_FIGHT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartFight", "BattleDefaultSettings");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Collections.IEnumerator StartFight(MonsterEncounter encounter, BattleManager.FightType fightType)
        /// </summary>
        /// public static bool START_FIGHT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartFight", "MonsterEncounter", "BattleManager.FightType");
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