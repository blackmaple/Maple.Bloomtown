using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
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
    /// class ["Assembly-CSharp".""."GameSettings"]
    /// [UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x02000416U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [71, 97, 109, 101, 83, 101, 116, 116, 105, 110, 103, 115])]
    public partial class GameSettings
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameSettings";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 83, 101, 116, 116, 105, 110, 103, 115];

        //public const uint Const_TypeToken = 0x02000416U;




        public readonly unsafe partial struct Const_GameSettings
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
        public readonly unsafe partial struct Static_GameSettings
        {



            /// const string Name_Field_OffsetOfInstanceIDInCPlusPlusObject = "OffsetOfInstanceIDInCPlusPlusObject";
            /// <summary>
            /// struct 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Int32 OffsetOfInstanceIDInCPlusPlusObject;

        }


        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public unsafe partial struct Ref_GameSettings
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


            /// const string Name_Field_majorVersion = "majorVersion";
            /// <summary>
            /// class 0x20 System.String majorVersion
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public readonly nint majorVersion;


            /// const string Name_Field_buildDate = "buildDate";
            /// <summary>
            /// class 0x28 System.String buildDate
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public readonly nint buildDate;


            /// const string Name_Field_carsManager = "carsManager";
            /// <summary>
            /// class 0x30 CarsManager carsManager
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public readonly nint carsManager;


            /// const string Name_Field_lockpick = "lockpick";
            /// <summary>
            /// class 0x38 Lockpick lockpick
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            [MonoCollectorProperty(PropertyName = "Lockpick")]
            public readonly Lockpick.Ptr_Lockpick lockpick;


            /// const string Name_Field_animatedObjectPrefab = "animatedObjectPrefab";
            /// <summary>
            /// class 0x40 AnimatedObject animatedObjectPrefab
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public readonly nint animatedObjectPrefab;


            /// const string Name_Field_statusEffectPrefab = "statusEffectPrefab";
            /// <summary>
            /// class 0x48 StatusEffectAnimation statusEffectPrefab
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public readonly nint statusEffectPrefab;


            /// const string Name_Field_reactionPrefab = "reactionPrefab";
            /// <summary>
            /// class 0x50 ControllerInfo reactionPrefab
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x50)]
            public readonly nint reactionPrefab;


            /// const string Name_Field_fishHaul = "fishHaul";
            /// <summary>
            /// abstract class 0x58 Stackable fishHaul
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            [MonoCollectorProperty(PropertyName = "FishHaul")]
            public readonly Stackable.Ptr_Stackable fishHaul;


            /// const string Name_Field_garbageHaul = "garbageHaul";
            /// <summary>
            /// abstract class 0x60 Stackable garbageHaul
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x60)]
            [MonoCollectorProperty(PropertyName = "GarbageHaul")]
            public readonly Stackable.Ptr_Stackable garbageHaul;


            /// const string Name_Field_armorDogIcon = "armorDogIcon";
            /// <summary>
            /// class 0x68 UnityEngine.Sprite armorDogIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x68)]
            [MonoCollectorProperty(PropertyName = "ArmorDogIcon")]
            public readonly Sprite.Ptr_Sprite armorDogIcon;


            /// const string Name_Field_armorFemaleIcon = "armorFemaleIcon";
            /// <summary>
            /// class 0x70 UnityEngine.Sprite armorFemaleIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x70)]
            [MonoCollectorProperty(PropertyName = "ArmorFemaleIcon")]
            public readonly Sprite.Ptr_Sprite armorFemaleIcon;


            /// const string Name_Field_armorMaleIcon = "armorMaleIcon";
            /// <summary>
            /// class 0x78 UnityEngine.Sprite armorMaleIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x78)]
            [MonoCollectorProperty(PropertyName = "ArmorMaleIcon")]
            public readonly Sprite.Ptr_Sprite armorMaleIcon;


            /// const string Name_Field_armorUnisexIcon = "armorUnisexIcon";
            /// <summary>
            /// class 0x80 UnityEngine.Sprite armorUnisexIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x80)]
            [MonoCollectorProperty(PropertyName = "ArmorUnisexIcon")]
            public readonly Sprite.Ptr_Sprite armorUnisexIcon;


            /// const string Name_Field_meleeDaggersIcon = "meleeDaggersIcon";
            /// <summary>
            /// class 0x88 UnityEngine.Sprite meleeDaggersIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x88)]
            [MonoCollectorProperty(PropertyName = "MeleeDaggersIcon")]
            public readonly Sprite.Ptr_Sprite meleeDaggersIcon;


            /// const string Name_Field_meleeKnucklesIcon = "meleeKnucklesIcon";
            /// <summary>
            /// class 0x90 UnityEngine.Sprite meleeKnucklesIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x90)]
            [MonoCollectorProperty(PropertyName = "MeleeKnucklesIcon")]
            public readonly Sprite.Ptr_Sprite meleeKnucklesIcon;


            /// const string Name_Field_meleeScytheIcon = "meleeScytheIcon";
            /// <summary>
            /// class 0x98 UnityEngine.Sprite meleeScytheIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x98)]
            [MonoCollectorProperty(PropertyName = "MeleeScytheIcon")]
            public readonly Sprite.Ptr_Sprite meleeScytheIcon;


            /// const string Name_Field_meleeSwordIcon = "meleeSwordIcon";
            /// <summary>
            /// class 0xA0 UnityEngine.Sprite meleeSwordIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA0)]
            [MonoCollectorProperty(PropertyName = "MeleeSwordIcon")]
            public readonly Sprite.Ptr_Sprite meleeSwordIcon;


            /// const string Name_Field_rangedBazookaIcon = "rangedBazookaIcon";
            /// <summary>
            /// class 0xA8 UnityEngine.Sprite rangedBazookaIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xA8)]
            [MonoCollectorProperty(PropertyName = "RangedBazookaIcon")]
            public readonly Sprite.Ptr_Sprite rangedBazookaIcon;


            /// const string Name_Field_rangedCrossbowIcon = "rangedCrossbowIcon";
            /// <summary>
            /// class 0xB0 UnityEngine.Sprite rangedCrossbowIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB0)]
            [MonoCollectorProperty(PropertyName = "RangedCrossbowIcon")]
            public readonly Sprite.Ptr_Sprite rangedCrossbowIcon;


            /// const string Name_Field_rangedPistolIcon = "rangedPistolIcon";
            /// <summary>
            /// class 0xB8 UnityEngine.Sprite rangedPistolIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xB8)]
            [MonoCollectorProperty(PropertyName = "RangedPistolIcon")]
            public readonly Sprite.Ptr_Sprite rangedPistolIcon;


            /// const string Name_Field_rangedShotgunIcon = "rangedShotgunIcon";
            /// <summary>
            /// class 0xC0 UnityEngine.Sprite rangedShotgunIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC0)]
            [MonoCollectorProperty(PropertyName = "RangedShotgunIcon")]
            public readonly Sprite.Ptr_Sprite rangedShotgunIcon;


            /// const string Name_Field_hpPotionIcon = "hpPotionIcon";
            /// <summary>
            /// class 0xC8 UnityEngine.Sprite hpPotionIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC8)]
            [MonoCollectorProperty(PropertyName = "HpPotionIcon")]
            public readonly Sprite.Ptr_Sprite hpPotionIcon;


            /// const string Name_Field_hpPotionIconBig = "hpPotionIconBig";
            /// <summary>
            /// class 0xD0 UnityEngine.Sprite hpPotionIconBig
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD0)]
            [MonoCollectorProperty(PropertyName = "HpPotionIconBig")]
            public readonly Sprite.Ptr_Sprite hpPotionIconBig;


            /// const string Name_Field_hpPotionIconSmall = "hpPotionIconSmall";
            /// <summary>
            /// class 0xD8 UnityEngine.Sprite hpPotionIconSmall
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xD8)]
            [MonoCollectorProperty(PropertyName = "HpPotionIconSmall")]
            public readonly Sprite.Ptr_Sprite hpPotionIconSmall;


            /// const string Name_Field_spPotionIcon = "spPotionIcon";
            /// <summary>
            /// class 0xE0 UnityEngine.Sprite spPotionIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE0)]
            [MonoCollectorProperty(PropertyName = "SpPotionIcon")]
            public readonly Sprite.Ptr_Sprite spPotionIcon;


            /// const string Name_Field_spPotionIconBig = "spPotionIconBig";
            /// <summary>
            /// class 0xE8 UnityEngine.Sprite spPotionIconBig
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xE8)]
            [MonoCollectorProperty(PropertyName = "SpPotionIconBig")]
            public readonly Sprite.Ptr_Sprite spPotionIconBig;


            /// const string Name_Field_spPotionIconSmall = "spPotionIconSmall";
            /// <summary>
            /// class 0xF0 UnityEngine.Sprite spPotionIconSmall
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF0)]
            [MonoCollectorProperty(PropertyName = "SpPotionIconSmall")]
            public readonly Sprite.Ptr_Sprite spPotionIconSmall;


            /// const string Name_Field_blankPotionIcon = "blankPotionIcon";
            /// <summary>
            /// class 0xF8 UnityEngine.Sprite blankPotionIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xF8)]
            [MonoCollectorProperty(PropertyName = "BlankPotionIcon")]
            public readonly Sprite.Ptr_Sprite blankPotionIcon;


            /// const string Name_Field_blankPotionIconBig = "blankPotionIconBig";
            /// <summary>
            /// class 0x100 UnityEngine.Sprite blankPotionIconBig
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x100)]
            [MonoCollectorProperty(PropertyName = "BlankPotionIconBig")]
            public readonly Sprite.Ptr_Sprite blankPotionIconBig;


            /// const string Name_Field_blankPotionIconSmall = "blankPotionIconSmall";
            /// <summary>
            /// class 0x108 UnityEngine.Sprite blankPotionIconSmall
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x108)]
            [MonoCollectorProperty(PropertyName = "BlankPotionIconSmall")]
            public readonly Sprite.Ptr_Sprite blankPotionIconSmall;


            /// const string Name_Field_revivePotionIcon = "revivePotionIcon";
            /// <summary>
            /// class 0x110 UnityEngine.Sprite revivePotionIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x110)]
            [MonoCollectorProperty(PropertyName = "RevivePotionIcon")]
            public readonly Sprite.Ptr_Sprite revivePotionIcon;


            /// const string Name_Field_skillPhysicalIcon = "skillPhysicalIcon";
            /// <summary>
            /// class 0x118 UnityEngine.Sprite skillPhysicalIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x118)]
            [MonoCollectorProperty(PropertyName = "SkillPhysicalIcon")]
            public readonly Sprite.Ptr_Sprite skillPhysicalIcon;


            /// const string Name_Field_skillGunIcon = "skillGunIcon";
            /// <summary>
            /// class 0x120 UnityEngine.Sprite skillGunIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x120)]
            [MonoCollectorProperty(PropertyName = "SkillGunIcon")]
            public readonly Sprite.Ptr_Sprite skillGunIcon;


            /// const string Name_Field_skillFireIcon = "skillFireIcon";
            /// <summary>
            /// class 0x128 UnityEngine.Sprite skillFireIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x128)]
            [MonoCollectorProperty(PropertyName = "SkillFireIcon")]
            public readonly Sprite.Ptr_Sprite skillFireIcon;


            /// const string Name_Field_skillIceIcon = "skillIceIcon";
            /// <summary>
            /// class 0x130 UnityEngine.Sprite skillIceIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x130)]
            [MonoCollectorProperty(PropertyName = "SkillIceIcon")]
            public readonly Sprite.Ptr_Sprite skillIceIcon;


            /// const string Name_Field_skillWindIcon = "skillWindIcon";
            /// <summary>
            /// class 0x138 UnityEngine.Sprite skillWindIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x138)]
            [MonoCollectorProperty(PropertyName = "SkillWindIcon")]
            public readonly Sprite.Ptr_Sprite skillWindIcon;


            /// const string Name_Field_skillElectricIcon = "skillElectricIcon";
            /// <summary>
            /// class 0x140 UnityEngine.Sprite skillElectricIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x140)]
            [MonoCollectorProperty(PropertyName = "SkillElectricIcon")]
            public readonly Sprite.Ptr_Sprite skillElectricIcon;


            /// const string Name_Field_skillShadowIcon = "skillShadowIcon";
            /// <summary>
            /// class 0x148 UnityEngine.Sprite skillShadowIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x148)]
            [MonoCollectorProperty(PropertyName = "SkillShadowIcon")]
            public readonly Sprite.Ptr_Sprite skillShadowIcon;


            /// const string Name_Field_skillPoisonIcon = "skillPoisonIcon";
            /// <summary>
            /// class 0x150 UnityEngine.Sprite skillPoisonIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x150)]
            [MonoCollectorProperty(PropertyName = "SkillPoisonIcon")]
            public readonly Sprite.Ptr_Sprite skillPoisonIcon;


            /// const string Name_Field_skillHealIcon = "skillHealIcon";
            /// <summary>
            /// class 0x158 UnityEngine.Sprite skillHealIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x158)]
            [MonoCollectorProperty(PropertyName = "SkillHealIcon")]
            public readonly Sprite.Ptr_Sprite skillHealIcon;


            /// const string Name_Field_skillAilmentIcon = "skillAilmentIcon";
            /// <summary>
            /// class 0x160 UnityEngine.Sprite skillAilmentIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x160)]
            [MonoCollectorProperty(PropertyName = "SkillAilmentIcon")]
            public readonly Sprite.Ptr_Sprite skillAilmentIcon;


            /// const string Name_Field_skillDebuffIcon = "skillDebuffIcon";
            /// <summary>
            /// class 0x168 UnityEngine.Sprite skillDebuffIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x168)]
            [MonoCollectorProperty(PropertyName = "SkillDebuffIcon")]
            public readonly Sprite.Ptr_Sprite skillDebuffIcon;


            /// const string Name_Field_skillBuffIcon = "skillBuffIcon";
            /// <summary>
            /// class 0x170 UnityEngine.Sprite skillBuffIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x170)]
            [MonoCollectorProperty(PropertyName = "SkillBuffIcon")]
            public readonly Sprite.Ptr_Sprite skillBuffIcon;


            /// const string Name_Field_cloverIcon = "cloverIcon";
            /// <summary>
            /// class 0x178 UnityEngine.Sprite cloverIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x178)]
            [MonoCollectorProperty(PropertyName = "CloverIcon")]
            public readonly Sprite.Ptr_Sprite cloverIcon;


            /// const string Name_Field_questItemIcon = "questItemIcon";
            /// <summary>
            /// class 0x180 UnityEngine.Sprite questItemIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x180)]
            [MonoCollectorProperty(PropertyName = "QuestItemIcon")]
            public readonly Sprite.Ptr_Sprite questItemIcon;


            /// const string Name_Field_craftMaterialIcon = "craftMaterialIcon";
            /// <summary>
            /// class 0x188 UnityEngine.Sprite craftMaterialIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x188)]
            [MonoCollectorProperty(PropertyName = "CraftMaterialIcon")]
            public readonly Sprite.Ptr_Sprite craftMaterialIcon;


            /// const string Name_Field_bookIcon = "bookIcon";
            /// <summary>
            /// class 0x190 UnityEngine.Sprite bookIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x190)]
            [MonoCollectorProperty(PropertyName = "BookIcon")]
            public readonly Sprite.Ptr_Sprite bookIcon;


            /// const string Name_Field_moneyIcon = "moneyIcon";
            /// <summary>
            /// class 0x198 UnityEngine.Sprite moneyIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x198)]
            [MonoCollectorProperty(PropertyName = "MoneyIcon")]
            public readonly Sprite.Ptr_Sprite moneyIcon;


            /// const string Name_Field_giftIcon = "giftIcon";
            /// <summary>
            /// class 0x1A0 UnityEngine.Sprite giftIcon
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1A0)]
            [MonoCollectorProperty(PropertyName = "GiftIcon")]
            public readonly Sprite.Ptr_Sprite giftIcon;


            /// const string Name_Field_talkAngryReaction = "talkAngryReaction";
            /// <summary>
            /// class 0x1A8 UnityEngine.Sprite talkAngryReaction
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1A8)]
            [MonoCollectorProperty(PropertyName = "TalkAngryReaction")]
            public readonly Sprite.Ptr_Sprite talkAngryReaction;


            /// const string Name_Field_talkNeutralReaction = "talkNeutralReaction";
            /// <summary>
            /// class 0x1B0 UnityEngine.Sprite talkNeutralReaction
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1B0)]
            [MonoCollectorProperty(PropertyName = "TalkNeutralReaction")]
            public readonly Sprite.Ptr_Sprite talkNeutralReaction;


            /// const string Name_Field_talkSatisfiedReaction = "talkSatisfiedReaction";
            /// <summary>
            /// class 0x1B8 UnityEngine.Sprite talkSatisfiedReaction
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1B8)]
            [MonoCollectorProperty(PropertyName = "TalkSatisfiedReaction")]
            public readonly Sprite.Ptr_Sprite talkSatisfiedReaction;


            /// const string Name_Field_floatingTextPrefab = "floatingTextPrefab";
            /// <summary>
            /// class 0x1C0 FloatingText floatingTextPrefab
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1C0)]
            public readonly nint floatingTextPrefab;


            /// const string Name_Field_floatingTextWorldPrefab = "floatingTextWorldPrefab";
            /// <summary>
            /// class 0x1C8 FloatingText floatingTextWorldPrefab
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1C8)]
            public readonly nint floatingTextWorldPrefab;


            /// const string Name_Field_commonTextInfo = "commonTextInfo";
            /// <summary>
            /// class 0x1D0 GameSettings.TextInfo commonTextInfo
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1D0)]
            public readonly nint commonTextInfo;


            /// const string Name_Field_healTextInfo = "healTextInfo";
            /// <summary>
            /// class 0x1D8 GameSettings.TextInfo healTextInfo
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1D8)]
            public readonly nint healTextInfo;


            /// const string Name_Field_damageTextInfo = "damageTextInfo";
            /// <summary>
            /// class 0x1E0 GameSettings.TextInfo damageTextInfo
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1E0)]
            public readonly nint damageTextInfo;


            /// const string Name_Field_entrances = "entrances";
            /// <summary>
            /// class 0x1E8 System.Collections.Generic.List<EntranceInfo> entrances
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1E8)]
            public readonly nint entrances;


            /// const string Name_Field_monsterModels = "monsterModels";
            /// <summary>
            /// class 0x1F0 System.Collections.Generic.List<BattleMonsterModel> monsterModels
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1F0)]
            [MonoCollectorProperty(PropertyName = "MonsterModels")]
            public readonly PMonoList_S<BattleMonsterModel.Ptr_BattleMonsterModel> monsterModels;


            /// const string Name_Field_playerModels = "playerModels";
            /// <summary>
            /// class 0x1F8 System.Collections.Generic.List<BattlePlayerModel> playerModels
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x1F8)]
            [MonoCollectorProperty(PropertyName = "PlayerModels")]
            public readonly PMonoList_S<BattlePlayerModel.Ptr_BattlePlayerModel> playerModels;


            /// const string Name_Field_personaModels = "personaModels";
            /// <summary>
            /// class 0x200 System.Collections.Generic.List<BattleMonsterModel> personaModels
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x200)]
            [MonoCollectorProperty(PropertyName = "PersonaModels")]
            public PMonoList_S<BattleMonsterModel.Ptr_BattleMonsterModel> personaModels;


            /// const string Name_Field_aliases = "aliases";
            /// <summary>
            /// class 0x208 System.Collections.Generic.List<GameSettings.Localization> aliases
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x208)]
            public readonly nint aliases;


            /// const string Name_Field_cutsceneLocales = "cutsceneLocales";
            /// <summary>
            /// class 0x210 System.Collections.Generic.List<GameSettings.CutscenePhrase> cutsceneLocales
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x210)]
            public readonly nint cutsceneLocales;


            /// const string Name_Field_localLocales = "localLocales";
            /// <summary>
            /// class 0x218 System.Collections.Generic.List<GameSettings.Localization> localLocales
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x218)]
            public readonly nint localLocales;


            /// const string Name_Field_variablesForItems = "variablesForItems";
            /// <summary>
            /// class 0x220 System.Collections.Generic.List<GameSettings.VariablesForItem> variablesForItems
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x220)]
            public readonly nint variablesForItems;


            /// const string Name_Field_stringReplacements = "stringReplacements";
            /// <summary>
            /// class 0x228 System.Collections.Generic.List<GameSettings.StringReplacement> stringReplacements
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x228)]
            public readonly nint stringReplacements;


            /// const string Name_Field_passiveEffects = "passiveEffects";
            /// <summary>
            /// class 0x230 System.Collections.Generic.List<PassiveEffect> passiveEffects
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x230)]
            public readonly nint passiveEffects;


            /// const string Name_Field_consumables = "consumables";
            /// <summary>
            /// class 0x238 System.Collections.Generic.List<Consumable> consumables
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x238)]
            [MonoCollectorProperty(PropertyName = "Consumables")]
            public readonly PMonoList_S<Consumable.Ptr_Consumable> consumables;


            /// const string Name_Field_craftMaterials = "craftMaterials";
            /// <summary>
            /// class 0x240 System.Collections.Generic.List<CraftMaterial> craftMaterials
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x240)]
            [MonoCollectorProperty(PropertyName = "CraftMaterials")]
            public readonly PMonoList_S<CraftMaterial.Ptr_CraftMaterial> craftMaterials;


            /// const string Name_Field_weathers = "weathers";
            /// <summary>
            /// class 0x248 System.Collections.Generic.List<WeatherOnDay> weathers
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x248)]
            public readonly nint weathers;


            /// const string Name_Field_treasures = "treasures";
            /// <summary>
            /// class 0x250 System.Collections.Generic.List<Treasure> treasures
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x250)]
            [MonoCollectorProperty(PropertyName = "Treasures")]
            public readonly PMonoList_S<Treasure.Ptr_Treasure> treasures;


            /// const string Name_Field_constants = "constants";
            /// <summary>
            /// class 0x258 GameSettings.KeyValueList constants
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x258)]
            public readonly nint constants;


            /// const string Name_Field_pools = "pools";
            /// <summary>
            /// class 0x260 GameSettings.Pool pools
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x260)]
            public readonly nint pools;


            /// const string Name_Field_activities = "activities";
            /// <summary>
            /// class 0x268 System.Collections.Generic.List<ActivityInfo> activities
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x268)]
            public readonly nint activities;


            /// const string Name_Field_seeds = "seeds";
            /// <summary>
            /// class 0x270 System.Collections.Generic.List<Seed> seeds
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x270)]
            [MonoCollectorProperty(PropertyName = "Seeds")]
            public readonly PMonoList_S<Seed.Ptr_Seed> seeds;


            /// const string Name_Field_fertilizers = "fertilizers";
            /// <summary>
            /// class 0x278 System.Collections.Generic.List<Fertilizer> fertilizers
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x278)]
            [MonoCollectorProperty(PropertyName = "Fertilizers")]
            public readonly PMonoList_S<Fertilizer.Ptr_Fertilizer> fertilizers;


            /// const string Name_Field_rods = "rods";
            /// <summary>
            /// class 0x280 System.Collections.Generic.List<Rod> rods
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x280)]
            [MonoCollectorProperty(PropertyName = "Rods")]
            public readonly PMonoList_S<Rod.Ptr_Rod> rods;


            /// const string Name_Field_baits = "baits";
            /// <summary>
            /// class 0x288 System.Collections.Generic.List<Bait> baits
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x288)]
            [MonoCollectorProperty(PropertyName = "Baits")]
            public readonly PMonoList_S<Bait.Ptr_Bait> baits;


            /// const string Name_Field_fishingGarbage = "fishingGarbage";
            /// <summary>
            /// class 0x290 FishingGarbageTable fishingGarbage
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x290)]
            public readonly nint fishingGarbage;


            /// const string Name_Field_books = "books";
            /// <summary>
            /// class 0x298 System.Collections.Generic.List<Book> books
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x298)]
            [MonoCollectorProperty(PropertyName = "Books")]
            public readonly PMonoList_S<Book.Ptr_Book> books;


            /// const string Name_Field_confidants = "confidants";
            /// <summary>
            /// class 0x2A0 System.Collections.Generic.List<ConfidantInfo> confidants
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2A0)]
            public readonly nint confidants;


            /// const string Name_Field_recipes = "recipes";
            /// <summary>
            /// class 0x2A8 System.Collections.Generic.List<Recipe> recipes
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2A8)]
            [MonoCollectorProperty(PropertyName = "Recipes")]
            public readonly PMonoList_S<Recipe.Ptr_Recipe> recipes;


            /// const string Name_Field_quests = "quests";
            /// <summary>
            /// class 0x2B0 System.Collections.Generic.List<Quest> quests
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2B0)]
            public readonly nint quests;


            /// const string Name_Field_questItems = "questItems";
            /// <summary>
            /// class 0x2B8 System.Collections.Generic.List<QuestItem> questItems
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2B8)]
            [MonoCollectorProperty(PropertyName = "QuestItems")]
            public readonly PMonoList_S<QuestItem.Ptr_QuestItem> questItems;


            /// const string Name_Field_shopInfos = "shopInfos";
            /// <summary>
            /// class 0x2C0 System.Collections.Generic.List<ShopInfo> shopInfos
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2C0)]
            public readonly nint shopInfos;


            /// const string Name_Field_confidantGifts = "confidantGifts";
            /// <summary>
            /// class 0x2C8 System.Collections.Generic.List<ConfidantGift> confidantGifts
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2C8)]
            [MonoCollectorProperty(PropertyName = "ConfidantGifts")]
            public readonly PMonoList_S<ConfidantGift.Ptr_ConfidantGift> confidantGifts;


            /// const string Name_Field_mapEvents = "mapEvents";
            /// <summary>
            /// class 0x2D0 System.Collections.Generic.List<MapEventInfo> mapEvents
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2D0)]
            public readonly nint mapEvents;


            /// const string Name_Field_meleeWeapons = "meleeWeapons";
            /// <summary>
            /// class 0x2D8 System.Collections.Generic.List<MeleeWeapon> meleeWeapons
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2D8)]
            [MonoCollectorProperty(PropertyName = "MeleeWeapons")]
            public readonly PMonoList_S<MeleeWeapon.Ptr_MeleeWeapon> meleeWeapons;


            /// const string Name_Field_rangedWeapons = "rangedWeapons";
            /// <summary>
            /// class 0x2E0 System.Collections.Generic.List<RangedWeapon> rangedWeapons
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2E0)]
            [MonoCollectorProperty(PropertyName = "RangedWeapons")]
            public readonly PMonoList_S<RangedWeapon.Ptr_RangedWeapon> rangedWeapons;


            /// const string Name_Field_armor = "armor";
            /// <summary>
            /// class 0x2E8 System.Collections.Generic.List<Armor> armor
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2E8)]
            [MonoCollectorProperty(PropertyName = "Armors")]
            public readonly PMonoList_S<Armor.Ptr_Armor> armor;


            /// const string Name_Field_accessories = "accessories";
            /// <summary>
            /// class 0x2F0 System.Collections.Generic.List<Accessory> accessories
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2F0)]
            [MonoCollectorProperty(PropertyName = "Accessories")]
            public readonly PMonoList_S<Accessory.Ptr_Accessory> accessories;


            /// const string Name_Field_characterNextLevelExp = "characterNextLevelExp";
            /// <summary>
            /// class 0x2F8 System.Collections.Generic.List<System.Int32> characterNextLevelExp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x2F8)]
            public readonly nint characterNextLevelExp;


            /// const string Name_Field_personaNextLevelExp = "personaNextLevelExp";
            /// <summary>
            /// class 0x300 System.Collections.Generic.List<System.Int32> personaNextLevelExp
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x300)]
            public readonly nint personaNextLevelExp;


            /// const string Name_Field_testSettings = "testSettings";
            /// <summary>
            /// class 0x308 BattleDefaultSettings testSettings
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x308)]
            public readonly nint testSettings;


            /// const string Name_Field_dungeonTestSettings = "dungeonTestSettings";
            /// <summary>
            /// class 0x310 System.Collections.Generic.List<DungeonTestSettings> dungeonTestSettings
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x310)]
            public readonly nint dungeonTestSettings;


            /// const string Name_Field_travelPoints = "travelPoints";
            /// <summary>
            /// class 0x318 System.Collections.Generic.List<TravelPoint> travelPoints
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x318)]
            public readonly nint travelPoints;


            /// const string Name_Field_travelCost = "travelCost";
            /// <summary>
            /// class 0x320 System.Collections.Generic.List<GameSettings.TravelCost> travelCost
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x320)]
            public readonly nint travelCost;


            /// const string Name_Field_locations = "locations";
            /// <summary>
            /// class 0x328 System.Collections.Generic.List<Location> locations
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x328)]
            public readonly nint locations;


            /// const string Name_Field_wetDirt = "wetDirt";
            /// <summary>
            /// class 0x330 System.Collections.Generic.List<UnityEngine.Sprite> wetDirt
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x330)]
            [MonoCollectorProperty(PropertyName = "WetDirt")]
            public readonly PMonoList_S<Sprite.Ptr_Sprite> wetDirt;


            /// const string Name_Field_dryDirt = "dryDirt";
            /// <summary>
            /// class 0x338 System.Collections.Generic.List<UnityEngine.Sprite> dryDirt
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x338)]
            [MonoCollectorProperty(PropertyName = "DryDirt")]
            public readonly PMonoList_S<Sprite.Ptr_Sprite> dryDirt;


            /// const string Name_Field_demonsUnlockCondition = "demonsUnlockCondition";
            /// <summary>
            /// class 0x340 RestrictionsField demonsUnlockCondition
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x340)]
            public readonly nint demonsUnlockCondition;


            /// const string Name_Field_secondhandInfo = "secondhandInfo";
            /// <summary>
            /// class 0x348 SecondhandInfo secondhandInfo
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x348)]
            public readonly nint secondhandInfo;


            /// const string Name_Field_damageConstants = "damageConstants";
            /// <summary>
            /// class 0x350 Uroboros.Extension.Extensions.StringListIntCollection damageConstants
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x350)]
            public readonly nint damageConstants;


            /// const string Name_Field_characterStats = "characterStats";
            /// <summary>
            /// class 0x358 Uroboros.Extension.Extensions.StringListIntCollection characterStats
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x358)]
            public readonly nint characterStats;


            /// const string Name_Field_canGetSkillOnLevel = "canGetSkillOnLevel";
            /// <summary>
            /// class 0x360 Uroboros.Extension.Extensions.StringListIntCollection canGetSkillOnLevel
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x360)]
            public readonly nint canGetSkillOnLevel;


            /// const string Name_Field_experienceFusion = "experienceFusion";
            /// <summary>
            /// class 0x368 System.Collections.Generic.List<System.Int32> experienceFusion
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x368)]
            public readonly nint experienceFusion;


            /// const string Name_Field_returnHours = "returnHours";
            /// <summary>
            /// struct 0x370 System.Int32 returnHours
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x370)]
            public readonly System.Int32 returnHours;


            /// const string Name_Field_returnMinutes = "returnMinutes";
            /// <summary>
            /// struct 0x374 System.Int32 returnMinutes
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x374)]
            public readonly System.Int32 returnMinutes;

        }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameSettings(nint ptr)
        {

            [MarshalAs(UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameSettings(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameSettings obj) => obj._ptr;

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public ref Ref_GameSettings AsRef()
            {
                return ref Unsafe.AsRef<Ref_GameSettings>(_ptr.ToPointer());
            }
        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."GameSettings"]
    /// </summary>
    public partial class GameSettings
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


        /// const string Name_Func_GET_EQUIPMENT_BY_UID = "GetEquipmentByUID";
        /// <summary>
        ///   Equipment GetEquipmentByUID(System.String itemUID)
        /// </summary>
        /// <param name="itemUID">class System.String</param>
        /// <returns>abstract class Equipment</returns>
        /// public  extern nint GET_EQUIPMENT_BY_UID (nint itemUID);


        /// const string Name_Func_GET_GS_OBJECT = "GetGSObject";
        /// <summary>
        /// static  GameSettings GetGSObject()
        /// </summary>
        /// <returns>class GameSettings</returns>
        /// public static extern nint GET_GS_OBJECT ();


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


        /// const string Name_Func_GET_SCRIPT_CLASS_NAME = "GetScriptClassName";
        /// <summary>
        ///   System.String GetScriptClassName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// public  extern nint GET_SCRIPT_CLASS_NAME ();


        /// const string Name_Func_GET_SELLABLE_BY_UID = "GetSellableByUID";
        /// <summary>
        ///   Sellable GetSellableByUID(System.String itemUID)
        /// </summary>
        /// <param name="itemUID">class System.String</param>
        /// <returns>abstract class Sellable</returns>
        /// public  extern nint GET_SELLABLE_BY_UID (nint itemUID);


        /// const string Name_Func_GET_STACKABLE_BY_UID = "GetStackableByUid";
        /// <summary>
        ///   Stackable GetStackableByUid(System.String itemUid)
        /// </summary>
        /// <param name="itemUid">class System.String</param>
        /// <returns>abstract class Stackable</returns>
        /// public  extern nint GET_STACKABLE_BY_UID (nint itemUid);


        /// const string Name_Func_GET_TRAVEL_COST_IN_MINUTES = "GetTravelCostInMinutes";
        /// <summary>
        ///   System.Int32 GetTravelCostInMinutes(System.String district1,System.String district2)
        /// </summary>
        /// <param name="district1">class System.String</param>
        /// <param name="district2">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// public  extern System.Int32 GET_TRAVEL_COST_IN_MINUTES (nint district1,nint district2);


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


        /// const string Name_Func_SET_NAME = "SetName";
        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj,System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// public static extern void SET_NAME (nint obj,nint name);


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


        /// public static partial class Search_GameSettings
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
