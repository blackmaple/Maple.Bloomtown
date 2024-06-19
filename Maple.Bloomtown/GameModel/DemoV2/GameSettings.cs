
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
    /// class ["Assembly-CSharp".""."GameSettings"]
    /// [UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], 0x020004B0U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [], [71, 97, 109, 101, 83, 101, 116, 116, 105, 110, 103, 115])]

    //  class static GameSettings _reference
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_reference", "_REFERENCE"), true]

    //  struct static System.Int32 OffsetOfInstanceIDInCPlusPlusObject
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"OffsetOfInstanceIDInCPlusPlusObject", "OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT"), true]

    // struct 0x10 System.IntPtr m_CachedPtr
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"m_CachedPtr", "M_CACHED_PTR")]

    // class 0x18 System.Threading.CancellationTokenSource m_CancellationTokenSource
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"m_CancellationTokenSource", "M_CANCELLATION_TOKEN_SOURCE")]

    // class 0x20 CarsManager carsManager
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"carsManager", "CARS_MANAGER")]

    // class 0x28 Lockpick lockpick
      [MonoCollectorSearchFieldAttribute(typeof(Lockpick.Ptr_Lockpick),"lockpick", "LOCKPICK")]

    // class 0x30 AnimatedObject animatedObjectPrefab
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"animatedObjectPrefab", "ANIMATED_OBJECT_PREFAB")]

    // class 0x38 StatusEffectAnimation statusEffectPrefab
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"statusEffectPrefab", "STATUS_EFFECT_PREFAB")]

    // class 0x40 ControllerInfo reactionPrefab
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"reactionPrefab", "REACTION_PREFAB")]

    // class 0x48 System.Collections.Generic.List<SkillInfo> buffs
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<SkillInfo.Ptr_SkillInfo>), "buffs", "BUFFS")]

    // class 0x50 UnityEngine.Sprite armorDogIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"armorDogIcon", "ARMOR_DOG_ICON")]

    // class 0x58 UnityEngine.Sprite armorFemaleIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"armorFemaleIcon", "ARMOR_FEMALE_ICON")]

    // class 0x60 UnityEngine.Sprite armorMaleIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"armorMaleIcon", "ARMOR_MALE_ICON")]

    // class 0x68 UnityEngine.Sprite armorUnisexIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"armorUnisexIcon", "ARMOR_UNISEX_ICON")]

    // class 0x70 UnityEngine.Sprite meleeDaggersIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"meleeDaggersIcon", "MELEE_DAGGERS_ICON")]

    // class 0x78 UnityEngine.Sprite meleeKnucklesIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"meleeKnucklesIcon", "MELEE_KNUCKLES_ICON")]

    // class 0x80 UnityEngine.Sprite meleeScytheIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"meleeScytheIcon", "MELEE_SCYTHE_ICON")]

    // class 0x88 UnityEngine.Sprite meleeSwordIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"meleeSwordIcon", "MELEE_SWORD_ICON")]

    // class 0x90 UnityEngine.Sprite rangedBazookaIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"rangedBazookaIcon", "RANGED_BAZOOKA_ICON")]

    // class 0x98 UnityEngine.Sprite rangedCrossbowIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"rangedCrossbowIcon", "RANGED_CROSSBOW_ICON")]

    // class 0xA0 UnityEngine.Sprite rangedPistolIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"rangedPistolIcon", "RANGED_PISTOL_ICON")]

    // class 0xA8 UnityEngine.Sprite rangedShotgunIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"rangedShotgunIcon", "RANGED_SHOTGUN_ICON")]

    // class 0xB0 UnityEngine.Sprite hpPotionIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"hpPotionIcon", "HP_POTION_ICON")]

    // class 0xB8 UnityEngine.Sprite hpPotionIconBig
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"hpPotionIconBig", "HP_POTION_ICON_BIG")]

    // class 0xC0 UnityEngine.Sprite hpPotionIconSmall
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"hpPotionIconSmall", "HP_POTION_ICON_SMALL")]

    // class 0xC8 UnityEngine.Sprite spPotionIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"spPotionIcon", "SP_POTION_ICON")]

    // class 0xD0 UnityEngine.Sprite spPotionIconBig
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"spPotionIconBig", "SP_POTION_ICON_BIG")]

    // class 0xD8 UnityEngine.Sprite spPotionIconSmall
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"spPotionIconSmall", "SP_POTION_ICON_SMALL")]

    // class 0xE0 UnityEngine.Sprite blankPotionIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"blankPotionIcon", "BLANK_POTION_ICON")]

    // class 0xE8 UnityEngine.Sprite blankPotionIconBig
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"blankPotionIconBig", "BLANK_POTION_ICON_BIG")]

    // class 0xF0 UnityEngine.Sprite blankPotionIconSmall
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"blankPotionIconSmall", "BLANK_POTION_ICON_SMALL")]

    // class 0xF8 UnityEngine.Sprite revivePotionIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"revivePotionIcon", "REVIVE_POTION_ICON")]

    // class 0x100 UnityEngine.Sprite skillPhysicalIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillPhysicalIcon", "SKILL_PHYSICAL_ICON")]

    // class 0x108 UnityEngine.Sprite skillGunIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillGunIcon", "SKILL_GUN_ICON")]

    // class 0x110 UnityEngine.Sprite skillFireIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillFireIcon", "SKILL_FIRE_ICON")]

    // class 0x118 UnityEngine.Sprite skillIceIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillIceIcon", "SKILL_ICE_ICON")]

    // class 0x120 UnityEngine.Sprite skillWindIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillWindIcon", "SKILL_WIND_ICON")]

    // class 0x128 UnityEngine.Sprite skillElectricIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillElectricIcon", "SKILL_ELECTRIC_ICON")]

    // class 0x130 UnityEngine.Sprite skillShadowIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillShadowIcon", "SKILL_SHADOW_ICON")]

    // class 0x138 UnityEngine.Sprite skillPoisonIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillPoisonIcon", "SKILL_POISON_ICON")]

    // class 0x140 UnityEngine.Sprite skillHealIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillHealIcon", "SKILL_HEAL_ICON")]

    // class 0x148 UnityEngine.Sprite skillAilmentIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillAilmentIcon", "SKILL_AILMENT_ICON")]

    // class 0x150 UnityEngine.Sprite skillDebuffIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillDebuffIcon", "SKILL_DEBUFF_ICON")]

    // class 0x158 UnityEngine.Sprite skillBuffIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"skillBuffIcon", "SKILL_BUFF_ICON")]

    // class 0x160 UnityEngine.Sprite cloverIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"cloverIcon", "CLOVER_ICON")]

    // class 0x168 UnityEngine.Sprite questItemIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"questItemIcon", "QUEST_ITEM_ICON")]

    // class 0x170 UnityEngine.Sprite craftMaterialIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"craftMaterialIcon", "CRAFT_MATERIAL_ICON")]

    // class 0x178 UnityEngine.Sprite bookIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"bookIcon", "BOOK_ICON")]

    // class 0x180 UnityEngine.Sprite moneyIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"moneyIcon", "MONEY_ICON")]

    // class 0x188 UnityEngine.Sprite giftIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"giftIcon", "GIFT_ICON")]

    // class 0x190 UnityEngine.Sprite charmIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"charmIcon", "CHARM_ICON")]

    // class 0x198 UnityEngine.Sprite gutsIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"gutsIcon", "GUTS_ICON")]

    // class 0x1A0 UnityEngine.Sprite knowledgeIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"knowledgeIcon", "KNOWLEDGE_ICON")]

    // class 0x1A8 UnityEngine.Sprite proficiencyIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"proficiencyIcon", "PROFICIENCY_ICON")]

    // class 0x1B0 UnityEngine.Sprite talkAngryReaction
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"talkAngryReaction", "TALK_ANGRY_REACTION")]

    // class 0x1B8 UnityEngine.Sprite talkNeutralReaction
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"talkNeutralReaction", "TALK_NEUTRAL_REACTION")]

    // class 0x1C0 UnityEngine.Sprite talkSatisfiedReaction
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"talkSatisfiedReaction", "TALK_SATISFIED_REACTION")]

    // class 0x1C8 FloatingText floatingTextPrefab
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"floatingTextPrefab", "FLOATING_TEXT_PREFAB")]

    // class 0x1D0 FloatingText floatingTextWorldPrefab
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"floatingTextWorldPrefab", "FLOATING_TEXT_WORLD_PREFAB")]

    // class 0x1D8 GameSettings.TextInfo commonTextInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"commonTextInfo", "COMMON_TEXT_INFO")]

    // class 0x1E0 GameSettings.TextInfo healTextInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"healTextInfo", "HEAL_TEXT_INFO")]

    // class 0x1E8 GameSettings.TextInfo damageTextInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"damageTextInfo", "DAMAGE_TEXT_INFO")]

    // class 0x1F0 System.Collections.Generic.List<EntranceInfo> entrances
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"entrances", "ENTRANCES")]

    // class 0x1F8 System.Collections.Generic.List<BattleMonsterModel> monsterModels
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<BattleMonsterModel.Ptr_BattleMonsterModel>), "monsterModels", "MONSTER_MODELS")]

    // class 0x200 System.Collections.Generic.List<BattlePlayerModel> playerModels
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<BattlePlayerModel.Ptr_BattlePlayerModel>), "playerModels", "PLAYER_MODELS")]

    // class 0x208 System.Collections.Generic.List<BattleMonsterModel> personaModels
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<BattleMonsterModel.Ptr_BattleMonsterModel>), "personaModels", "PERSONA_MODELS")]

    // class 0x210 System.Collections.Generic.List<GameSettings.Localization> aliases
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"aliases", "ALIASES")]

    // class 0x218 System.Collections.Generic.List<GameSettings.Localization> localLocales
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"localLocales", "LOCAL_LOCALES")]

    // class 0x220 System.Collections.Generic.List<GameSettings.VariablesForItem> variablesForItems
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"variablesForItems", "VARIABLES_FOR_ITEMS")]

    // class 0x228 System.Collections.Generic.List<GameSettings.StringReplacement> stringReplacements
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"stringReplacements", "STRING_REPLACEMENTS")]

    // class 0x230 System.Collections.Generic.List<PassiveEffect> passiveEffects
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<PassiveEffect.Ptr_PassiveEffect>), "passiveEffects", "PASSIVE_EFFECTS")]

    // class 0x238 System.Collections.Generic.List<Consumable> consumables
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Consumable.Ptr_Consumable>), "consumables", "CONSUMABLES")]

    // class 0x240 System.Collections.Generic.List<SkillInfo> skills
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<SkillInfo.Ptr_SkillInfo>), "skills", "SKILLS")]

    // class 0x248 System.Collections.Generic.List<CraftMaterial> craftMaterials
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<CraftMaterial.Ptr_CraftMaterial>), "craftMaterials", "CRAFT_MATERIALS")]

    // class 0x250 System.Collections.Generic.List<WeatherOnDay> weathers
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"weathers", "WEATHERS")]

    // class 0x258 System.Collections.Generic.List<Treasure> treasures
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Treasure.Ptr_Treasure>), "treasures", "TREASURES")]

    // class 0x260 GameSettings.KeyValueList constants
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"constants", "CONSTANTS")]

    // class 0x268 GameSettings.KeyStringValueList passwords
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"passwords", "PASSWORDS")]

    // class 0x270 GameSettings.ItemPool itemPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"itemPools", "ITEM_POOLS")]

    // class 0x278 System.Collections.Generic.List<GameSettings.KeyStringArray> demonPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"demonPools", "DEMON_POOLS")]

    // class 0x280 System.Collections.Generic.List<GameSettings.KeySocialStatPair> rewardSocialStatPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"rewardSocialStatPools", "REWARD_SOCIAL_STAT_POOLS")]

    // class 0x288 System.Collections.Generic.List<GameSettings.KeySocialStatPair> checksSocialStatPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"checksSocialStatPools", "CHECKS_SOCIAL_STAT_POOLS")]

    // class 0x290 System.Collections.Generic.List<ActivityInfo> activities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"activities", "ACTIVITIES")]

    // class 0x298 System.Collections.Generic.List<Seed> seeds
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Seed.Ptr_Seed>), "seeds", "SEEDS")]

    // class 0x2A0 System.Collections.Generic.List<Fertilizer> fertilizers
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Fertilizer.Ptr_Fertilizer>), "fertilizers", "FERTILIZERS")]

    // class 0x2A8 System.Collections.Generic.List<Fish> fishes
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Fish.Ptr_Fish>), "fishes", "FISHES")]

    // class 0x2B0 System.Collections.Generic.List<Vinyl> vinyls
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Vinyl.Ptr_Vinyl>), "vinyls", "VINYLS")]

    // class 0x2B8 System.Collections.Generic.List<Movie> movies
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Movie.Ptr_Movie>), "movies", "MOVIES")]

    // class 0x2C0 System.Collections.Generic.List<Book> books
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Book.Ptr_Book>), "books", "BOOKS")]

    // class 0x2C8 System.Collections.Generic.List<ConfidantInfo> confidants
      [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<ConfidantInfo.Ptr_ConfidantInfo>),"confidants", "CONFIDANTS")]

    // class 0x2D0 System.Collections.Generic.List<Recipe> recipes
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Recipe.Ptr_Recipe>),"recipes", "RECIPES")]

    // class 0x2D8 System.Collections.Generic.List<Quest> quests
      [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Quest.Ptr_Quest>),"quests", "QUESTS")]

    // class 0x2E0 System.Collections.Generic.List<QuestItem> questItems
      [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<QuestItem.Ptr_QuestItem>),"questItems", "QUEST_ITEMS")]

    // class 0x2E8 System.Collections.Generic.List<ShopInfo> shopInfos
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"shopInfos", "SHOP_INFOS")]

    // class 0x2F0 System.Collections.Generic.List<ConfidantGift> confidantGifts
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<ConfidantGift.Ptr_ConfidantGift>), "confidantGifts", "CONFIDANT_GIFTS")]

    // class 0x2F8 System.Collections.Generic.List<MapEventInfo> mapEvents
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"mapEvents", "MAP_EVENTS")]

    // class 0x300 System.Collections.Generic.List<MeleeWeapon> meleeWeapons
      [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<MeleeWeapon.Ptr_MeleeWeapon>),"meleeWeapons", "MELEE_WEAPONS")]

    // class 0x308 System.Collections.Generic.List<RangedWeapon> rangedWeapons
      [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<RangedWeapon.Ptr_RangedWeapon>),"rangedWeapons", "RANGED_WEAPONS")]

    // class 0x310 System.Collections.Generic.List<Armor> armor
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Armor.Ptr_Armor>), "armor", "ARMORS")]

    // class 0x318 System.Collections.Generic.List<Accessory> accessories
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<Accessory.Ptr_Accessory>), "accessories", "ACCESSORIES")]

    // class 0x320 System.Collections.Generic.List<System.Int32> characterNextLevelExp
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"characterNextLevelExp", "CHARACTER_NEXT_LEVEL_EXP")]

    // class 0x328 System.Collections.Generic.List<System.Int32> personaNextLevelExp
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"personaNextLevelExp", "PERSONA_NEXT_LEVEL_EXP")]

    // class 0x330 BattleDefaultSettings testSettings
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"testSettings", "TEST_SETTINGS")]

    // class 0x338 System.Collections.Generic.List<DungeonTestSettings> dungeonTestSettings
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"dungeonTestSettings", "DUNGEON_TEST_SETTINGS")]

    // class 0x340 System.Collections.Generic.List<TravelPoint> travelPoints
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"travelPoints", "TRAVEL_POINTS")]

    // class 0x348 System.Collections.Generic.List<GameSettings.TravelCost> travelCost
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"travelCost", "TRAVEL_COST")]

    // class 0x350 System.Collections.Generic.List<Location> locations
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"locations", "LOCATIONS")]

    // class 0x358 System.Collections.Generic.List<UnityEngine.Sprite> wetDirt
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"wetDirt", "WET_DIRT")]

    // class 0x360 System.Collections.Generic.List<UnityEngine.Sprite> dryDirt
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"dryDirt", "DRY_DIRT")]

    // class 0x368 RestrictionsField demonsUnlockCondition
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"demonsUnlockCondition", "DEMONS_UNLOCK_CONDITION")]

    // abstract class 0x370 Stackable fishingRod
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"fishingRod", "FISHING_ROD")]

    // abstract class 0x378 Stackable fishingBait
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"fishingBait", "FISHING_BAIT")]

    // class 0x380 QuestStage centralFishQuest
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"centralFishQuest", "CENTRAL_FISH_QUEST")]

    // class 0x388 QuestStage farmFishQuest
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"farmFishQuest", "FARM_FISH_QUEST")]

    // class 0x390 QuestStage forestFishQuest
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"forestFishQuest", "FOREST_FISH_QUEST")]

    // class 0x398 SecondhandInfo secondhandInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"secondhandInfo", "SECONDHAND_INFO")]

    // class 0x3A0 System.Collections.Generic.List<GameSettings.TVShopLot> tvShopLot
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"tvShopLot", "TV_SHOP_LOT")]

    // class 0x3A8 System.Collections.Generic.List<GameSettings.SocialStatRang> socialStatsCup
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"socialStatsCup", "SOCIAL_STATS_CUP")]

    // class 0x3B0 Uroboros.Extension.Extensions.StringListIntCollection damageConstants
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"damageConstants", "DAMAGE_CONSTANTS")]

    // class 0x3B8 Uroboros.Extension.Extensions.StringListIntCollection characterStats
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"characterStats", "CHARACTER_STATS")]

    // class 0x3C0 Uroboros.Extension.Extensions.StringListIntCollection canGetSkillOnLevel
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"canGetSkillOnLevel", "CAN_GET_SKILL_ON_LEVEL")]

    // class 0x3C8 System.Collections.Generic.List<System.Int32> experienceFusion
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"experienceFusion", "EXPERIENCE_FUSION")]

    // class 0x3D0 System.Collections.Generic.List<GameSettings.DungeonConditions> dungeonsConditions
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"dungeonsConditions", "DUNGEONS_CONDITIONS")]

    // class 0x3D8 System.Collections.Generic.List<AchievementInfo> achievements
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"achievements", "ACHIEVEMENTS")]

    // struct 0x3E0 System.Int32 returnHours
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"returnHours", "RETURN_HOURS")]

    // struct 0x3E4 System.Int32 returnMinutes
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"returnMinutes", "RETURN_MINUTES")]
    public partial class GameSettings
    {
        //public const string Const_ImageName = "Assembly-CSharp";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameSettings";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 83, 101, 116, 116, 105, 110, 103, 115];

        //public const uint Const_TypeToken = 0x020004B0U;




        /// <summary>
        /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        /// </summary>
        /// public const nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";

        /// <summary>
        /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        /// </summary>
        /// public const nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameSettings(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameSettings(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameSettings obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameSettings obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp".""."GameSettings"]
    /// </summary>
    public partial class GameSettings
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckNullArgument")]
        /// static extern void CHECK_NULL_ARGUMENT (nint arg, nint message);


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
        /// static  System.Boolean CurrentThreadIsMainThread()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CurrentThreadIsMainThread")]
        /// static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();


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
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_name")]
        ///  extern nint GET_NAME ();


        /// <summary>
        ///   System.String get_tag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tag")]
        ///  extern nint GET_TAG ();


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
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCachedPtr")]
        ///  extern System.IntPtr GET_CACHED_PTR ();


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
        ///   Equipment GetEquipmentByUID(System.String itemUID)
        /// </summary>
        /// <param name="itemUID">class System.String</param>
        /// <returns>abstract class Equipment</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEquipmentByUID")]
        ///  extern nint GET_EQUIPMENT_BY_UID (nint itemUID);


        /// <summary>
        /// static  GameSettings GetGSObject()
        /// </summary>
        /// <returns>class GameSettings</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGSObject")]
        /// static extern nint GET_GS_OBJECT ();


        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
        ///  extern System.Int32 GET_HASH_CODE ();


        /// <summary>
        ///   System.Int32 GetInstanceID()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInstanceID")]
        ///  extern System.Int32 GET_INSTANCE_ID ();


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
        ///   System.String GetScriptClassName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetScriptClassName")]
        ///  extern nint GET_SCRIPT_CLASS_NAME ();


        /// <summary>
        ///   Sellable GetSellableByUID(System.String itemUID)
        /// </summary>
        /// <param name="itemUID">class System.String</param>
        /// <returns>abstract class Sellable</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSellableByUID")]
        ///  extern nint GET_SELLABLE_BY_UID (nint itemUID);


        /// <summary>
        ///   Stackable GetStackableByUid(System.String itemUid)
        /// </summary>
        /// <param name="itemUid">class System.String</param>
        /// <returns>abstract class Stackable</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStackableByUid")]
        ///  extern nint GET_STACKABLE_BY_UID (nint itemUid);


        /// <summary>
        ///   System.Int32 GetTravelCostInMinutes(System.String district1, System.String district2)
        /// </summary>
        /// <param name="district1">class System.String</param>
        /// <param name="district2">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTravelCostInMinutes")]
        ///  extern System.Int32 GET_TRAVEL_COST_IN_MINUTES (nint district1, nint district2);


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
        ///   System.Void MarkDirty()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MarkDirty")]
        ///  extern void MARK_DIRTY ();


        /// <summary>
        ///   System.Void OnCancellationTokenCreated()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCancellationTokenCreated")]
        ///  extern void ON_CANCELLATION_TOKEN_CREATED ();


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
        /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
        /// static extern void SET_NAME (nint obj, nint name);


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
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameSettings))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameSettings))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameSettings))]
        ///  extern void .CTOR_02 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameSettings))]
        ///  extern void .CTOR_03 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameSettings))]
        ///  extern void .CTOR_04 ();


        /// <summary>
        ///   System.Void CancelInvoke()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_GameSettings))]
        ///  extern void CANCEL_INVOKE_00 ();


        /// <summary>
        ///   System.Void CancelInvoke(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_GameSettings))]
        ///  extern void CANCEL_INVOKE_01 (nint methodName);


        /// <summary>
        /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_GameSettings))]
        /// static extern void CANCEL_INVOKE_02 (nint self, nint methodName);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_GameSettings))]
        /// static extern void DESTROY_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_GameSettings))]
        /// static extern void DESTROY_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="allowDestroyingAssets">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_GameSettings))]
        /// static extern void DESTROY_IMMEDIATE_00 (nint obj, System.Boolean allowDestroyingAssets);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_GameSettings))]
        /// static extern void DESTROY_IMMEDIATE_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_GameSettings))]
        /// static extern void DESTROY_OBJECT_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_GameSettings))]
        /// static extern void DESTROY_OBJECT_01 (nint obj);


        /// <summary>
        /// static  T FindAnyObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  T FindFirstObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECT_OF_TYPE_00 ();


        /// <summary>
        /// static  T FindObjectOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECT_OF_TYPE_01 (System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECT_OF_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECT_OF_TYPE_03 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_00 (nint type, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_01 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_02 (UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_03 (UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_02 ();


        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_GameSettings))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_00 (nint type);


        /// <summary>
        ///   T GetComponent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_01 ();


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_01 (nint t);


        /// <summary>
        ///   T GetComponentInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInChildren()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_03 ();


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T GetComponentInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInParent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENT_IN_PARENT_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponents(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENTS_00 (nint type);


        /// <summary>
        ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_GameSettings))]
        ///  extern void GET_COMPONENTS_01 (nint type, nint results);


        /// <summary>
        ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_GameSettings))]
        ///  extern void GET_COMPONENTS_02 (nint results);


        /// <summary>
        ///   T[] GetComponents()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENTS_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_00 (nint t);


        /// <summary>
        ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_01 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="result">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_GameSettings))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_02 (System.Boolean includeInactive, nint result);


        /// <summary>
        ///   T[] GetComponentsInChildren()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_03 ();


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_GameSettings))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_04 (nint results);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T[] GetComponentsInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_GameSettings))]
        ///  extern void GET_COMPONENTS_IN_PARENT_03 (System.Boolean includeInactive, nint results);


        /// <summary>
        ///   T[] GetComponentsInParent()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_GameSettings))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_04 ();


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_00 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_01 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_02 (nint original);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_03 (nint original, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_04 (nint original, nint parent, System.Boolean instantiateInWorldSpace);


        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// <param name="original">class T</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_05 (nint original);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_06 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_07 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_08 (nint original, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_GameSettings))]
        /// static extern nint INSTANTIATE_09 (nint original, nint parent, System.Boolean worldPositionStays);


        /// <summary>
        ///   System.Boolean IsInvoking()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_GameSettings))]
        ///  extern System.Boolean IS_INVOKING_00 ();


        /// <summary>
        ///   System.Boolean IsInvoking(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_GameSettings))]
        ///  extern System.Boolean IS_INVOKING_01 (nint methodName);


        /// <summary>
        /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_GameSettings))]
        /// static extern System.Boolean IS_INVOKING_02 (nint self, nint methodName);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_GameSettings))]
        ///  extern nint START_COROUTINE_00 (nint methodName);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_GameSettings))]
        ///  extern nint START_COROUTINE_01 (nint methodName, nint value);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_GameSettings))]
        ///  extern nint START_COROUTINE_02 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_GameSettings))]
        ///  extern void STOP_COROUTINE_00 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
        /// </summary>
        /// <param name="routine">class UnityEngine.Coroutine</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_GameSettings))]
        ///  extern void STOP_COROUTINE_01 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_GameSettings))]
        ///  extern void STOP_COROUTINE_02 (nint methodName);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_GameSettings))]
        ///  extern nint TO_STRING_00 ();


        /// <summary>
        /// static  System.String ToString(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_GameSettings))]
        /// static extern nint TO_STRING_01 (nint obj);


        /// <summary>
        ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="component">class UnityEngine.Component&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_GameSettings))]
        ///  extern System.Boolean TRY_GET_COMPONENT_00 (nint type, nint component);


        /// <summary>
        ///   System.Boolean TryGetComponent(T& component)
        /// </summary>
        /// <param name="component">class T&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_GameSettings))]
        ///  extern System.Boolean TRY_GET_COMPONENT_01 (nint component);


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