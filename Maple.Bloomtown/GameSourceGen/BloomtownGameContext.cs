using Maple.Bloomtown.GameModel.Demo;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.Bloomtown
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]
    [MonoCollectorType(typeof(LocalizationManager))]
    [MonoCollectorType(typeof(LocalizedField))]

    [MonoCollectorType(typeof(GameManager))]
    [MonoCollectorType(typeof(UIManager))]
    [MonoCollectorType(typeof(PopUpMessage))]
    [MonoCollectorType(typeof(StatsSync))]
    [MonoCollectorType(typeof(GameSettings))]
    [MonoCollectorType(typeof(PlayerData))]

    //player
    [MonoCollectorType(typeof(BattlePlayerModel))]
    //[MonoCollectorType(typeof(BattlePlayerView))]
    [MonoCollectorType(typeof(PlayerCharacter))]
    [MonoCollectorType(typeof(Character))]

    //Monster
    [MonoCollectorType(typeof(BattleMonsterModel))]
    [MonoCollectorType(typeof(BattleMonsterView))]
    [MonoCollectorType(typeof(PersonaProgress))]

    //skill
    [MonoCollectorType(typeof(Skill))]
    [MonoCollectorType(typeof(SkillInfo))]
    
    //buffer

    [MonoCollectorType(typeof(SkillEffect))]
    [MonoCollectorType(typeof(PassiveEffect))]
    [MonoCollectorType(typeof(EffectTemplate))]

    //item
    [MonoCollectorType(typeof(Stackable))]
    [MonoCollectorType(typeof(Accessory))]
    [MonoCollectorType(typeof(Armor))]
    // [MonoCollectorType(typeof(Bait))]
    [MonoCollectorType(typeof(Book))]
    [MonoCollectorType(typeof(ConfidantGift))]
    [MonoCollectorType(typeof(Consumable))]
    [MonoCollectorType(typeof(CraftMaterial))]
    [MonoCollectorType(typeof(Fertilizer))]

    [MonoCollectorType(typeof(Lockpick))]

    [MonoCollectorType(typeof(MeleeWeapon))]
    [MonoCollectorType(typeof(QuestItem))]
    [MonoCollectorType(typeof(RangedWeapon))]

    [MonoCollectorType(typeof(Recipe))]

    //   [MonoCollectorType(typeof(Rod))]
    [MonoCollectorType(typeof(Seed))]
    [MonoCollectorType(typeof(Treasure))]
    [MonoCollectorType(typeof(SocialStat))]

    [MonoCollectorType(typeof(Vinyl))]
    [MonoCollectorType(typeof(Movie))]
    [MonoCollectorType(typeof(Fish))]

    internal partial class BloomtownGameContext
    {

    }
}
