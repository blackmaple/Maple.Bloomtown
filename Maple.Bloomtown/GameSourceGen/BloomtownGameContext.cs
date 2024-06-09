using Maple.Bloomtown.GameModel.Demo;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Security.AccessControl;
using static Maple.Bloomtown.GameModel.Demo.PassiveEffect;

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


    [MonoCollectorType(typeof(UIManager))]
    [MonoCollectorType(typeof(PopUpMessage))]
    [MonoCollectorType(typeof(StatsSync))]
    [MonoCollectorType(typeof(GameSettings))]
    [MonoCollectorType(typeof(PlayerData))]

    //player
    [MonoCollectorType(typeof(BattlePlayerModel))]
    [MonoCollectorType(typeof(BattlePlayerView))]
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
    [MonoCollectorType(typeof(PassiveEffect))]

    //item
    [MonoCollectorType(typeof(Stackable))]
    [MonoCollectorType(typeof(Accessory))]
    [MonoCollectorType(typeof(Armor))]
    [MonoCollectorType(typeof(Bait))]
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

    [MonoCollectorType(typeof(Rod))]
    [MonoCollectorType(typeof(Seed))]
    [MonoCollectorType(typeof(Treasure))]
    [MonoCollectorType(typeof(SocialStat))]
    internal partial class BloomtownGameContext
    {

    }
}
