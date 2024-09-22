using Maple.Bloomtown.GameModel.Demo;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.Bloomtown
{
    internal static class BloomtownGameContextExtensions
    {
        const string CONST_CURR_HP = "属性*HP";
        const string CONST_MAX_HP = "属性*MaxHP";
        const string CONST_CURR_SP = "属性*SP";
        const string CONST_MAX_SP = "属性*MaxSP";
        const string CONST_Lv = "属性*Lv";
        const string CONST_Exp = "属性*Exp";

        const string CONST_PersonaLv = "人格*Lv";
        const string CONST_PersonaExp = "人格*Exp";

        const string CONST_Agility = "属性*敏捷";
        const string CONST_Strength = "属性*力量";
        const string CONST_Endurance = "属性*耐力";
        const string CONST_Magic = "属性*魔力";
        const string CONST_Luck = "属性*幸运";

        const string CONST_Tame = "怪兽*驯化";
        const string CONST_Steal = "怪兽*窃取";
        const string CONST_MonsterSocialStat = "怪兽*社交";
        const string CONST_SocialStat = "社交";

        const string CONST_SkillMinLv = "技能*MinLv";
        const string CONST_SkillMaxLv = "技能*MaxLv";
        const float CONST_BookFullProgress = 1F;
        const float CONST_BookSetProgress = 1F - 0.1F;
        const float CONST_BookZeroProgress = 0F;
        const int CONST_ITEM_ZERO = 0;
        const string CONST_PRICE = "单价";
        const string CONST_Day = "星期";
        const string CONST_MONEY = "金币";
        const string CONST_MINUTES = "耗时";
        const string CONST_RARITY = "稀有";
        const string CONST_MONSTERROLE = "怪兽*角色";
        const string CONST_PassiveEffect = "被动";

        public static ListGeneric? GetListPersonaProgress(this BloomtownGameContext @this)
        {
            var fieldInfo = @this.PlayerData.ClassInfo.FieldInfos.Find(p => MemoryExtensions.SequenceEqual(p.Name.AsSpan(), "personasCaught"));
            if (fieldInfo is not null)
            {
                var classInfo = @this.RuntimeContext.GetMonoCollectorClassInfo(fieldInfo.FieldType.Pointer);
                return new ListGeneric(@this, classInfo);
            }
            return default;
        }

        public static BloomtownGameEnvironment GetBloomtownGameEnvironment(this BloomtownGameContext @this) => new(@this);

        #region Resrouce

        public static IEnumerable<UnitySpriteImageData> GetListGameSettingsIcon(this BloomtownGameEnvironment @this, UnityEngineContext unityEngine)
        {
            var gameSettings = @this.Context.GameSettings;
            foreach (var field in gameSettings.ClassInfo.FieldInfos.Where(static p => p.FieldType.TypeName == "UnityEngine.Sprite"))
            {
                var pSprite = gameSettings.GetMemberFieldValue<Sprite.Ptr_Sprite>(@this.Ptr_GameSettings, field.Name);
                if (pSprite.Valid())
                {
                    var pIconData = unityEngine.ReadSprite2Png(pSprite);
                    if (pIconData.Valid())
                    {
                        yield return new UnitySpriteImageData()
                        {
                            Category = nameof(GameSettings),
                            Name = field.Name,
                            ImageData = pIconData,
                        };
                    }

                }
            }


        }
        public static IEnumerable<UnitySpriteImageData> GetListInventoryIcon(this BloomtownGameEnvironment @this, UnityEngineContext unityEngine)
        {
            var pPlayerData = @this.Ptr_PlayerData;
            var pGameSettings = @this.Ptr_GameSettings;

            //1.装饰品
            var pListAccessories = pGameSettings.ACCESSORIES;
            if (pListAccessories.Valid())
            {
                //null
                foreach (var accessory in pListAccessories)
                {
                    var pIcon = accessory.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Accessory), Name = accessory.UID.ToString(), ImageData = pIconPng };
                        }
                    }
                }
            }

            //2.盔甲
            var pListArmor = pGameSettings.ARMORS;
            if (pListArmor.Valid())
            {
                //getIcon
                foreach (var armor in pListArmor)
                {
                    var pIcon = armor.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Armor), Name = armor.UID.ToString(), ImageData = pIconPng };
                        }
                    }
                }
            }

            //3.书籍
            var pListBooks = pGameSettings.BOOKS;
            if (pListBooks.Valid())
            {
                //bookIcon
                foreach (var book in pListBooks)
                {
                    var pIcon = book.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Book), Name = book.UID.ToString(), ImageData = pIconPng };
                        }
                    }

                }
            }

            //4.礼物
            var pListConfidantGifts = pGameSettings.CONFIDANT_GIFTS;
            if (pListConfidantGifts.Valid())
            {
                //giftIcon
                foreach (var confidantGift in pListConfidantGifts)
                {
                    var pIcon = confidantGift.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(ConfidantGift), Name = confidantGift.UID.ToString(), ImageData = pIconPng };
                        }
                    }
                }
            }

            //5.消耗品
            var pListConsumables = pGameSettings.CONSUMABLES;
            if (pListConsumables.Valid())
            {
                //GetIcon
                foreach (var consumable in pListConsumables)
                {
                    var pIcon = consumable.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Consumable), Name = consumable.UID.ToString(), ImageData = pIconPng };
                        }
                    }
                }
            }

            //6.材料
            var pListCraftMaterials = pGameSettings.CRAFT_MATERIALS;
            if (pListCraftMaterials.Valid())
            {
                //GetIcon()
                foreach (var craftMaterial in pListCraftMaterials)
                {
                    var pIcon = craftMaterial.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(CraftMaterial), Name = craftMaterial.UID.ToString(), ImageData = pIconPng };
                        }
                    }
                }
            }

            //7.肥料
            var pListFertilizers = pGameSettings.FERTILIZERS;
            if (pListFertilizers.Valid())
            {
                //GetIcon()
                foreach (var fertilizer in pListFertilizers)
                {
                    var pIcon = fertilizer.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Fertilizer), Name = fertilizer.UID.ToString(), ImageData = pIconPng };
                        }
                    }
                }
            }

            //8.近战武器
            var pListMeleeWeapons = pGameSettings.MELEE_WEAPONS;
            if (pListMeleeWeapons.Valid())
            {
                //GetIcon()
                foreach (var meleeWeapon in pListMeleeWeapons)
                {

                    var pIcon = meleeWeapon.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(MeleeWeapon), Name = meleeWeapon.UID.ToString(), ImageData = pIconPng };
                        }
                    }

                }
            }

            //9.任务道具
            var pListQuestItems = pGameSettings.QUEST_ITEMS;
            if (pListQuestItems.Valid())
            {
                //GetIcon()
                foreach (var questItem in pListQuestItems)
                {
                    var pIcon = questItem.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(QuestItem), Name = questItem.UID.ToString(), ImageData = pIconPng };
                        }
                    }

                }
            }

            //a.远程武器
            var pListRangedWeapons = pGameSettings.RANGED_WEAPONS;
            if (pListRangedWeapons.Valid())
            {
                //GetIcon()
                foreach (var rangedWeapon in pListRangedWeapons)
                {
                    var pIcon = rangedWeapon.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(RangedWeapon), Name = rangedWeapon.UID.ToString(), ImageData = pIconPng };
                        }
                    }

                }
            }

            //b.食谱
            var pListRecipes = pGameSettings.RECIPES;
            if (pListRecipes.Valid())
            {
                //GetIcon()
                foreach (var recipe in pListRecipes)
                {
                    var pIcon = recipe.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Recipe), Name = recipe.UID.ToString(), ImageData = pIconPng };
                        }
                    }

                }
            }


            //c.种子
            var pListSeeds = pGameSettings.SEEDS;
            if (pListSeeds.Valid())
            {
                foreach (var seed in pListSeeds)
                {
                    var pIcon = seed.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Seed), Name = seed.UID.ToString(), ImageData = pIconPng };
                        }
                    }
                }
            }

            //d.珍宝
            var pListTreasures = pGameSettings.TREASURES;
            if (pListTreasures.Valid())
            {
                //null
                foreach (var treasure in pListTreasures)
                {
                    var pIcon = treasure.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Treasure), Name = treasure.UID.ToString(), ImageData = pIconPng };
                        }
                    }
                }
            }

            //e.唱片
            var pListVinyls = pGameSettings.VINYLS;
            if (pListVinyls.Valid())
            {
                foreach (var vinyl in pListVinyls)
                {
                    var pIcon = vinyl.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Vinyl), Name = vinyl.UID.ToString(), ImageData = pIconPng };
                        }
                    }

                }
            }

            //f.电影
            var pListMovies = pGameSettings.MOVIES;
            if (pListMovies.Valid())
            {
                foreach (var movie in pListMovies)
                {
                    var pIcon = movie.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Movie), Name = movie.UID.ToString(), ImageData = pIconPng };
                        }
                    }

                }
            }

            //g.鱼
            var pListFishes = pGameSettings.FISHES;
            if (pListFishes.Valid())
            {
                foreach (var fish in pListFishes)
                {
                    var pIcon = fish.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Fish), Name = fish.UID.ToString(), ImageData = pIconPng };
                        }
                    }
                }
            }


        }
        public static IEnumerable<UnitySpriteImageData> GetListCharacterIcon(this BloomtownGameEnvironment @this, UnityEngineContext unityEngine)
        {
            var pPlayerData = @this.Ptr_PlayerData;
            var pPlayerGroup = pPlayerData.GET_PLAYER_GROUP();

            foreach (var player in pPlayerGroup)
            {
                var pAvatar = player.AVATAR_MINI;
                //  player.GET_AVATAR(Emotion.Normal);
                if (pAvatar.Valid())
                {
                    var pAvatarIcon = unityEngine.ReadSprite2Png(pAvatar);
                    if (pAvatarIcon.Valid())
                    {
                        yield return new UnitySpriteImageData() { Category = nameof(Character), Name = player.UID.ToString(), ImageData = pAvatarIcon };
                    }
                }

            }
        }
        public static IEnumerable<UnitySpriteImageData> GetListMonsterIcon(this BloomtownGameEnvironment @this, UnityEngineContext unityEngine)
        {

            var pGameSettings = @this.Ptr_GameSettings;

            var pListMonsterModels = pGameSettings.MONSTER_MODELS;
            if (pListMonsterModels.Valid())
            {
                foreach (var monsterModel in pListMonsterModels)
                {
                    if (TryGetUnitySpriteImageData(nameof(BattleMonsterModel), monsterModel, unityEngine, out var imageData))
                    {
                        yield return imageData;
                    }
                }
            }

            var pListPersonaModels = pGameSettings.PERSONA_MODELS;
            if (pListPersonaModels.Valid())
            {
                foreach (var monsterModel in pListPersonaModels)
                {
                    if (TryGetUnitySpriteImageData(nameof(PersonaProgress), monsterModel, unityEngine, out var imageData))
                    {
                        yield return imageData;
                    }
                }
            }

            static bool TryGetUnitySpriteImageData(string category, BattleMonsterModel.Ptr_BattleMonsterModel monsterModel, UnityEngineContext unityEngine, out UnitySpriteImageData imageData)
            {
                Unsafe.SkipInit(out imageData);
                var pViewData = monsterModel.VIEW_PREFAB;
                if (pViewData.Valid())
                {
                    var pPreview = pViewData.MONSTER_PREVIEW;
                    if (pPreview.Valid())
                    {
                        var pPreviewIcon = unityEngine.ReadSprite2Png(pPreview);
                        if (pPreviewIcon.Valid())
                        {
                            imageData = new UnitySpriteImageData() { Category = category, Name = monsterModel.UID.ToString(), ImageData = pPreviewIcon };
                            return true;
                        }
                    }
                }
                return false;
            }
        }
        public static IEnumerable<UnitySpriteImageData> GetListSkillIcon(this BloomtownGameEnvironment @this, UnityEngineContext unityEngine)
        {
            var pGameSettings = @this.Ptr_GameSettings;
            var pListSkills = pGameSettings.SKILLS;
            foreach (var pSkillInfo in pListSkills)
            {
                if (TryGetImageData(nameof(SkillInfo), pSkillInfo, unityEngine, out var imageData))
                {
                    yield return imageData;
                }
            }

            var pListBuffs = pGameSettings.BUFFS;
            foreach (var pSkillInfo in pListBuffs)
            {
                if (TryGetImageData(nameof(SkillEffect), pSkillInfo, unityEngine, out var imageData))
                {
                    yield return imageData;
                }
            }

            static bool TryGetImageData(string category, SkillInfo.Ptr_SkillInfo pSkillInfo, UnityEngineContext unityEngine, [MaybeNullWhen(false)] out UnitySpriteImageData imageData)
            {
                Unsafe.SkipInit(out imageData);
                var pIcon = pSkillInfo.GET_ICON_00();
                if (pIcon.Valid())
                {
                    var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                    if (pIconPng.Valid())
                    {
                        imageData = new UnitySpriteImageData() { Category = nameof(SkillInfo), Name = pSkillInfo.UID.ToString(), ImageData = pIconPng };
                        return true;
                    }
                }
                return false;
            }
        }
        #endregion

        #region Currency
        public static GameCurrencyDisplayDTO[] GetListCurrencyDisplay(this BloomtownGameContext @this)
        {
            return
            [
                new()
                {
                    ObjectId = nameof(PlayerData.Ptr_PlayerData.MONEY),
                    DisplayName =CONST_MONEY,
                    DisplayCategory = nameof(GameSettings),
                },
                  new()
                {
                    ObjectId = nameof(SocialStat.SocialStatType.Knowledge),
                    DisplayName = SocialStat.Ptr_SocialStat.GET_SOCIAL_STAT_NAME(SocialStat.SocialStatType.Knowledge).ToString(),
                    DisplayDesc = SocialStat.Ptr_SocialStat.GET_DESCRIPTION_FOR_SOCIAL_STAT(SocialStat.SocialStatType.Knowledge,5).ToString(),
                    DisplayCategory = nameof(GameSettings),
                },
                  new()
                {
                    ObjectId = nameof(SocialStat.SocialStatType.Charm),
                    DisplayName = SocialStat.Ptr_SocialStat.GET_SOCIAL_STAT_NAME(SocialStat.SocialStatType.Charm).ToString(),
                    DisplayDesc = SocialStat.Ptr_SocialStat.GET_DESCRIPTION_FOR_SOCIAL_STAT(SocialStat.SocialStatType.Charm,5).ToString(),
                    DisplayCategory = nameof(GameSettings),
                },
                  new()
                {
                    ObjectId = nameof(SocialStat.SocialStatType.Kindness),
                    DisplayName = SocialStat.Ptr_SocialStat.GET_SOCIAL_STAT_NAME(SocialStat.SocialStatType.Kindness).ToString(),
                    DisplayDesc = SocialStat.Ptr_SocialStat.GET_DESCRIPTION_FOR_SOCIAL_STAT(SocialStat.SocialStatType.Kindness,5).ToString(),
                    DisplayCategory = nameof(GameSettings),
                },
                  new()
                {
                    ObjectId = nameof(SocialStat.SocialStatType.Proficiency),
                    DisplayName = SocialStat.Ptr_SocialStat.GET_SOCIAL_STAT_NAME(SocialStat.SocialStatType.Proficiency).ToString(),
                    DisplayDesc = SocialStat.Ptr_SocialStat.GET_DESCRIPTION_FOR_SOCIAL_STAT(SocialStat.SocialStatType.Proficiency,5).ToString(),
                    DisplayCategory = nameof(GameSettings),
                },
                new()
                {
                    ObjectId = nameof(SocialStat.SocialStatType.Guts),
                    DisplayName = SocialStat.Ptr_SocialStat.GET_SOCIAL_STAT_NAME(SocialStat.SocialStatType.Guts).ToString(),
                    DisplayDesc = SocialStat.Ptr_SocialStat.GET_DESCRIPTION_FOR_SOCIAL_STAT(SocialStat.SocialStatType.Guts,5).ToString(),
                    DisplayCategory = nameof(GameSettings),
                }
            ];


        }
        public static GameCurrencyInfoDTO GetCurrencyInfo(this BloomtownGameEnvironment @this, GameCurrencyObjectDTO gameCurrency)
        {
            if (Enum.TryParse<SocialStat.SocialStatType>(gameCurrency.CurrencyObject, out var socialStatType))
            {
                var pSocialStat = @this.Ptr_PlayerData.PLAYER.GET_SOCIAL_STAT_BY_TYPE(socialStatType);
                return new GameCurrencyInfoDTO()
                {
                    ObjectId = socialStatType.ToString(),
                    DisplayValue = pSocialStat.GET_RANG().ToString(),
                };
            }
            else
            {
                return new GameCurrencyInfoDTO()
                {
                    ObjectId = nameof(PlayerData.Ptr_PlayerData.MONEY),
                    DisplayValue = @this.Ptr_PlayerData.MONEY.ToString()
                };
            }

        }
        public static GameCurrencyInfoDTO UpdateCurrencyInfo(this BloomtownGameEnvironment @this, GameCurrencyModifyDTO gameCurrency)
        {
            var value = gameCurrency.IntValue;
            var pPlayerData = @this.Ptr_PlayerData;
            if (Enum.TryParse<SocialStat.SocialStatType>(gameCurrency.CurrencyObject, out var socialStatType))
            {
                value = Math.Clamp(value, 1, 5);
                var pSocialStat = pPlayerData.PLAYER.GET_SOCIAL_STAT_BY_TYPE(socialStatType);
                pSocialStat.M_RANG = value;
                pSocialStat.M_EXP = pSocialStat.GET_RANG_CAP(value - 1);
                return new GameCurrencyInfoDTO()
                {
                    ObjectId = socialStatType.ToString(),
                    DisplayValue = pSocialStat.GET_RANG().ToString(),
                };
            }
            else
            {
                value = Math.Clamp(value, 0, 999);
                pPlayerData.MONEY = value;
                return new GameCurrencyInfoDTO()
                {

                    ObjectId = nameof(PlayerData.Ptr_PlayerData.MONEY),
                    DisplayValue = value.ToString()
                };
            }



        }

        #endregion

        #region Inventory
        static int GetPersonaProgressCount(this BloomtownGameEnvironment @this, string uid)
        {
            var count = 0;
            foreach (var data in @this.Ptr_PlayerData.M_PERSONAS_CAUGHT.AsReadOnlySpan())
            {
                if (MemoryExtensions.SequenceEqual(data.GET_GET_UID().AsReadOnlySpan(), uid))
                {
                    count++;
                }
            }
            return count;
        }
        public static IEnumerable<GameInventoryDisplayDTO> GetListInventoryDisplay(this BloomtownGameEnvironment @this)
        {
            var pGameSettings = @this.Ptr_GameSettings;

            //0.人格面具
            var pListPersonaModels = pGameSettings.PERSONA_MODELS;
            if (pListPersonaModels.Valid())
            {
                foreach (var monsterModel in pListPersonaModels)
                {
                    var uid = monsterModel.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = monsterModel.UNIT_NAME.GET_VALUE().ToString(),
                        DisplayDesc = string.Empty,
                        DisplayCategory = nameof(PersonaProgress),

                        ItemAttributes = GetItemAttributes(uid, monsterModel),
                    };

                }
                static GameValueInfoDTO[] GetItemAttributes(string uid, BattleMonsterModel.Ptr_BattleMonsterModel monsterModel)
                {

                    var tameStat = monsterModel.TAME_STAT.ToString();
                    GameValueInfoDTO[] atts =
                    [
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Lv,DisplayValue = monsterModel.LEVEL.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Strength,DisplayValue = monsterModel.RAW_STRENGTH.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Magic,DisplayValue = monsterModel.RAW_MAGIC.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Endurance,DisplayValue = monsterModel.RAW_ENDURANCE.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Agility,DisplayValue = monsterModel.RAW_AGILITY.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId =uid, DisplayName = CONST_Luck,DisplayValue = monsterModel.RAW_LUCK.ToString() ,CanPreview=true },

                         //new GameValueInfoDTO{ ObjectId = uid, DisplayName =CONST_MonsterSocialStat ,DisplayValue = tameStat ,CanPreview=true },
                         //new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Tame,DisplayValue = monsterModel.TAME_DIFFICULTY.ToString() ,CanPreview=true },
                         //new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Steal,DisplayValue = monsterModel.STEAL_DIFFICULTY.ToString()  ,CanPreview=true},

                    ];
                    return atts;
                }

            }

            //1.装饰品
            var pListAccessories = pGameSettings.ACCESSORIES;
            if (pListAccessories.Valid())
            {
                foreach (var accessory in pListAccessories)
                {
                    var uid = accessory.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = accessory.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = accessory.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Accessory),

                        ItemAttributes = GetItemAttributes(uid, accessory).ToArray(),
                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Accessory.Ptr_Accessory item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };

                    var name = item.GET_GET_STAT1_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT1().ToString(), CanPreview = true };
                    }

                    name = item.GET_GET_STAT2_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT2().ToString(), CanPreview = true };
                    }

                    name = item.GET_GET_STAT3_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT3().ToString(), CanPreview = true };
                    }

                    var pPassive = item.GET_PASSIVE();
                    if (pPassive.Valid())
                    {
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PassiveEffect, DisplayValue = pPassive.ARG_STR.ToString() };
                    }
                }
            }

            //2.盔甲
            var pListArmor = pGameSettings.ARMORS;
            if (pListArmor.Valid())
            {
                foreach (var armor in pListArmor)
                {
                    var uid = armor.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = armor.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = armor.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Armor),
                        ItemAttributes = GetItemAttributes(uid, armor).ToArray(),

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Armor.Ptr_Armor item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };

                    var name = item.GET_GET_STAT1_NAME_00().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT1_00().ToString(), CanPreview = true };
                    }

                    name = item.GET_GET_STAT2_NAME_00().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT2_00().ToString(), CanPreview = true };
                    }

                    name = item.GET_GET_STAT3_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT3().ToString(), CanPreview = true };
                    }

                    var pPassive = item.GET_PASSIVE();
                    if (pPassive.Valid())
                    {
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PassiveEffect, DisplayValue = pPassive.ARG_STR.ToString() };
                    }
                }

            }

            //3.书籍
            var pListBooks = pGameSettings.BOOKS;
            if (pListBooks.Valid())
            {
                foreach (var book in pListBooks)
                {
                    var uid = book.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = book.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = book.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Book),
                        ItemAttributes = GetItemAttributes(uid, book).ToArray()

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Book.Ptr_Book item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //4.礼物
            var pListConfidantGifts = pGameSettings.CONFIDANT_GIFTS;
            if (pListConfidantGifts.Valid())
            {
                foreach (var confidantGift in pListConfidantGifts)
                {
                    var uid = confidantGift.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = confidantGift.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = confidantGift.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(ConfidantGift),
                        ItemAttributes = GetItemAttributes(uid, confidantGift).ToArray()

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, ConfidantGift.Ptr_ConfidantGift item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //5.消耗品
            var pListConsumables = pGameSettings.CONSUMABLES;
            if (pListConsumables.Valid())
            {
                foreach (var consumable in pListConsumables)
                {
                    var uid = consumable.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = consumable.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = consumable.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Consumable),
                        ItemAttributes = GetItemAttributes(uid, consumable).ToArray(),

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Consumable.Ptr_Consumable item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //6.材料
            var pListCraftMaterials = pGameSettings.CRAFT_MATERIALS;
            if (pListCraftMaterials.Valid())
            {
                foreach (var craftMaterial in pListCraftMaterials)
                {
                    var uid = craftMaterial.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = craftMaterial.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = craftMaterial.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(CraftMaterial),
                        ItemAttributes = GetItemAttributes(uid, craftMaterial).ToArray(),

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, CraftMaterial.Ptr_CraftMaterial item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //7.肥料
            var pListFertilizers = pGameSettings.FERTILIZERS;
            if (pListFertilizers.Valid())
            {
                foreach (var fertilizer in pListFertilizers)
                {
                    var uid = fertilizer.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = fertilizer.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = fertilizer.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Fertilizer),
                        ItemAttributes = GetItemAttributes(uid, fertilizer).ToArray()

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Fertilizer.Ptr_Fertilizer item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //8.近战武器
            var pListMeleeWeapons = pGameSettings.MELEE_WEAPONS;
            if (pListMeleeWeapons.Valid())
            {
                foreach (var meleeWeapon in pListMeleeWeapons)
                {
                    var uid = meleeWeapon.UID.ToString()!;


                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = meleeWeapon.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = meleeWeapon.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(MeleeWeapon),

                        ItemAttributes = GetItemAttributes(uid, meleeWeapon).ToArray(),
                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, MeleeWeapon.Ptr_MeleeWeapon item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };

                    var name = item.GET_GET_STAT1_NAME_00().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT1_00().ToString(), CanPreview = true };
                    }

                    name = item.GET_GET_STAT2_NAME_00().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT2_00().ToString(), CanPreview = true };
                    }

                    name = item.GET_GET_STAT3_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT3().ToString(), CanPreview = true };
                    }

                    var pPassive = item.GET_PASSIVE();
                    if (pPassive.Valid())
                    {
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PassiveEffect, DisplayValue = pPassive.ARG_STR.ToString() };
                    }
                }

            }

            //9.任务道具
            var pListQuestItems = pGameSettings.QUEST_ITEMS;
            if (pListQuestItems.Valid())
            {
                foreach (var questItem in pListQuestItems)
                {
                    var uid = questItem.UID.ToString()!;

                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = questItem.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = questItem.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(QuestItem),
                        ItemAttributes = GetItemAttributes(uid, questItem).ToArray(),

                    };


                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, QuestItem.Ptr_QuestItem item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //a.远程武器
            var pListRangedWeapons = pGameSettings.RANGED_WEAPONS;
            if (pListRangedWeapons.Valid())
            {
                foreach (var rangedWeapon in pListRangedWeapons)
                {
                    var uid = rangedWeapon.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = rangedWeapon.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = rangedWeapon.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(RangedWeapon),
                        ItemAttributes = GetItemAttributes(uid, rangedWeapon).ToArray(),
                    };


                }

                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, RangedWeapon.Ptr_RangedWeapon item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };

                    var name = item.GET_GET_STAT1_NAME_00().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT1_00().ToString(), CanPreview = true };
                    }

                    name = item.GET_GET_STAT2_NAME_00().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT2_00().ToString(), CanPreview = true };
                    }

                    name = item.GET_GET_STAT3_NAME_00().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_GET_STAT3_00().ToString(), CanPreview = true };
                    }

                    var pPassive = item.GET_PASSIVE();
                    if (pPassive.Valid())
                    {
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PassiveEffect, DisplayValue = pPassive.ARG_STR.ToString() };
                    }
                }

            }

            //b.食谱
            var pListRecipes = pGameSettings.RECIPES;
            if (pListRecipes.Valid())
            {
                foreach (var recipe in pListRecipes)
                {
                    var uid = recipe.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = recipe.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = recipe.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Recipe),
                        ItemAttributes = GetItemAttributes(uid, recipe).ToArray(),

                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Recipe.Ptr_Recipe item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_MINUTES, DisplayValue = item.MINUTES_TO_CRAFT.ToString("F2"), CanPreview = true };
                }

            }

            //c.种子
            var pListSeeds = pGameSettings.SEEDS;
            if (pListSeeds.Valid())
            {
                foreach (var seed in pListSeeds)
                {
                    var uid = seed.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = seed.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = seed.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Seed),
                        ItemAttributes = GetItemAttributes(uid, seed).ToArray(),

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Seed.Ptr_Seed item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //d.珍宝
            var pListTreasures = pGameSettings.TREASURES;
            if (pListTreasures.Valid())
            {
                foreach (var treasure in pListTreasures)
                {
                    var uid = treasure.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = treasure.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = treasure.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Treasure),
                        ItemAttributes = GetItemAttributes(uid, treasure).ToArray()
                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Treasure.Ptr_Treasure item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //e.唱片
            var pListVinyl = pGameSettings.VINYLS;
            if (pListVinyl.Valid())
            {
                foreach (var vinyl in pListVinyl)
                {
                    var uid = vinyl.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = vinyl.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = vinyl.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Vinyl),
                        ItemAttributes = GetItemAttributes(uid, vinyl).ToArray()
                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Vinyl.Ptr_Vinyl item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //f.电影
            var pListMovie = pGameSettings.MOVIES;
            if (pListMovie.Valid())
            {
                foreach (var movie in pListMovie)
                {
                    var uid = movie.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = movie.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = movie.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Movie),
                        ItemAttributes = GetItemAttributes(uid, movie).ToArray()
                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Movie.Ptr_Movie item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_Day, DisplayValue = item._DAY_OF_WEEK.ToString(), CanPreview = true };
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_SocialStat, DisplayValue = item._SOCIAL_STAT_REWARD.ToString(), CanPreview = true };

                }
            }

            //g.鱼
            var pListFish = pGameSettings.FISHES;
            if (pListFish.Valid())
            {
                foreach (var fish in pListFish)
                {
                    var uid = fish.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = fish.ITEM_NAME.GET_VALUE().ToString(),
                        DisplayDesc = fish.DESCRIPTION.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Fish),
                        ItemAttributes = GetItemAttributes(uid, fish).ToArray()
                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Fish.Ptr_Fish item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_PRICE, DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = CONST_RARITY, DisplayValue = item.RARITY.ToString(), CanPreview = true };

                }
            }

        }
        public static GameInventoryInfoDTO GetInventoryInfo(this BloomtownGameEnvironment @this, GameInventoryObjectDTO gameInventory)
        {
            // var pPlayerData = @this.Ptr_PlayerData;
            var pGameSettings = @this.Ptr_GameSettings;

            //0.人格面具
            if (gameInventory.InventoryCategory == nameof(PersonaProgress))
            {
                var uid = gameInventory.InventoryObject;
                return new GameInventoryInfoDTO()
                {
                    ObjectId = uid,
                    InventoryCount = @this.GetPersonaProgressCount(uid)
                };


            }


            //1.装饰品
            if (gameInventory.InventoryCategory == nameof(Accessory))
            {
                var pListAccessories = pGameSettings.ACCESSORIES;
                if (pListAccessories.Valid())
                {
                    foreach (var accessory in pListAccessories)
                    {
                        var uid = accessory.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {

                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = accessory.GET_COUNT().ToString(),
                            };
                        }

                    }
                }
            }

            //2.盔甲
            else if (gameInventory.InventoryCategory == nameof(Armor))
            {
                var pListArmor = pGameSettings.ARMORS;
                if (pListArmor.Valid())
                {
                    foreach (var armor in pListArmor)
                    {
                        var uid = armor.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = armor.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //3.书籍
            else if (gameInventory.InventoryCategory == nameof(Book))
            {
                var pListBooks = pGameSettings.BOOKS;
                if (pListBooks.Valid())
                {
                    foreach (var book in pListBooks)
                    {
                        var uid = book.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {

                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = book.GET_COUNT().ToString(),
                            };
                        }
                    }
                }
            }

            //4.礼物
            else if (gameInventory.InventoryCategory == nameof(ConfidantGift))
            {
                var pListConfidantGifts = pGameSettings.CONFIDANT_GIFTS;
                if (pListConfidantGifts.Valid())
                {
                    foreach (var confidantGift in pListConfidantGifts)
                    {
                        var uid = confidantGift.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = confidantGift.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //5.消耗品
            else if (gameInventory.InventoryCategory == nameof(Consumable))
            {
                var pListConsumables = pGameSettings.CONSUMABLES;
                if (pListConsumables.Valid())
                {
                    foreach (var consumable in pListConsumables)
                    {
                        var uid = consumable.UID.ToString()!;

                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = consumable.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //6.材料
            else if (gameInventory.InventoryCategory == nameof(CraftMaterial))
            {
                var pListCraftMaterials = pGameSettings.CRAFT_MATERIALS;
                if (pListCraftMaterials.Valid())
                {
                    foreach (var craftMaterial in pListCraftMaterials)
                    {
                        var uid = craftMaterial.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = craftMaterial.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //7.肥料
            else if (gameInventory.InventoryCategory == nameof(Fertilizer))
            {
                var pListFertilizers = pGameSettings.FERTILIZERS;
                if (pListFertilizers.Valid())
                {
                    foreach (var fertilizer in pListFertilizers)
                    {
                        var uid = fertilizer.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = fertilizer.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //8.近战武器
            else if (gameInventory.InventoryCategory == nameof(MeleeWeapon))
            {
                var pListMeleeWeapons = pGameSettings.MELEE_WEAPONS;
                if (pListMeleeWeapons.Valid())
                {
                    foreach (var meleeWeapon in pListMeleeWeapons)
                    {
                        var uid = meleeWeapon.UID.ToString()!;

                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = meleeWeapon.GET_COUNT().ToString(),

                            };
                        }

                    }
                }
            }

            //9.任务道具
            else if (gameInventory.InventoryCategory == nameof(QuestItem))
            {
                var pListQuestItems = pGameSettings.QUEST_ITEMS;
                if (pListQuestItems.Valid())
                {
                    foreach (var questItem in pListQuestItems)
                    {
                        var uid = questItem.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = questItem.GET_COUNT().ToString(),

                            };
                        }


                    }
                }
            }


            //a.远程武器
            else if (gameInventory.InventoryCategory == nameof(RangedWeapon))
            {
                var pListRangedWeapons = pGameSettings.RANGED_WEAPONS;
                if (pListRangedWeapons.Valid())
                {
                    foreach (var rangedWeapon in pListRangedWeapons)
                    {
                        var uid = rangedWeapon.UID.ToString()!;

                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = rangedWeapon.GET_COUNT().ToString(),

                            };
                        }


                    }
                }
            }


            //b.食谱
            else if (gameInventory.InventoryCategory == nameof(Recipe))
            {
                var pListRecipes = pGameSettings.RECIPES;
                if (pListRecipes.Valid())
                {
                    foreach (var recipe in pListRecipes)
                    {
                        var uid = recipe.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = (recipe.GET_AVAILABLE() ? 1 : 0).ToString()
                            };
                        }

                    }
                }
            }

            //c.种子
            else if (gameInventory.InventoryCategory == nameof(Seed))
            {
                var pListSeeds = pGameSettings.SEEDS;
                if (pListSeeds.Valid())
                {
                    foreach (var seed in pListSeeds)
                    {
                        var uid = seed.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = seed.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //d.珍宝
            else if (gameInventory.InventoryCategory == nameof(Treasure))
            {
                var pListTreasures = pGameSettings.TREASURES;
                if (pListTreasures.Valid())
                {
                    foreach (var treasure in pListTreasures)
                    {
                        var uid = treasure.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = treasure.GET_COUNT().ToString(),

                            };
                        }

                    }
                }
            }

            //e.唱片
            else if (gameInventory.InventoryCategory == nameof(Vinyl))
            {
                var vinyls = pGameSettings.VINYLS;
                if (vinyls.Valid())
                {
                    foreach (var vinyl in vinyls)
                    {
                        var uid = vinyl.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = vinyl.GET_COUNT().ToString(),

                            };
                        }

                    }
                }
            }

            //f.电影
            else if (gameInventory.InventoryCategory == nameof(Movie))
            {
                var movies = pGameSettings.MOVIES;
                if (movies.Valid())
                {
                    foreach (var movie in movies)
                    {
                        var uid = movie.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                //   DisplayValue = ,

                            };
                        }

                    }
                }
            }

            //g.鱼
            else if (gameInventory.InventoryCategory == nameof(Fish))
            {
                var fishes = pGameSettings.FISHES;
                if (fishes.Valid())
                {
                    foreach (var fish in fishes)
                    {
                        var uid = fish.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = fish.GET_COUNT().ToString(),

                            };
                        }

                    }
                }
            }

            return GameException.Throw<GameInventoryInfoDTO>($"Not Found:{gameInventory.InventoryObject}");
        }
        public static GameInventoryInfoDTO UpdateInventoryInfo(this BloomtownGameEnvironment @this, GameInventoryModifyDTO gameInventory)
        {
            //  var pPlayerData = @this.Ptr_PlayerData;
            var pGameSettings = @this.Ptr_GameSettings;

            var count = gameInventory.InventoryCount;

            //0.人格面具
            if (gameInventory.InventoryCategory == nameof(PersonaProgress))
            {
                var uid = gameInventory.InventoryObject;
                var hasCount = @this.GetPersonaProgressCount(uid);

                for (int i = hasCount; i < count; ++i)
                {
                    @this.AddPersonaProgress(uid);
                }

                return new GameInventoryInfoDTO()
                {
                    ObjectId = uid,
                    InventoryCount = count
                };


            }



            //1.装饰品
            if (gameInventory.InventoryCategory == nameof(Accessory))
            {
                var pListAccessories = pGameSettings.ACCESSORIES;
                if (pListAccessories.Valid())
                {
                    foreach (var accessory in pListAccessories)
                    {
                        var uid = accessory.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {

                            accessory.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                accessory.ADD_00(count);
                            }


                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = accessory.GET_COUNT().ToString(),
                            };
                        }

                    }
                }
            }

            //2.盔甲
            else if (gameInventory.InventoryCategory == nameof(Armor))
            {
                var pListArmor = pGameSettings.ARMORS;
                if (pListArmor.Valid())
                {
                    foreach (var armor in pListArmor)
                    {
                        var uid = armor.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            armor.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                armor.ADD_00(count);
                            }



                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = armor.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }


            //3.书籍*
            else if (gameInventory.InventoryCategory == nameof(Book))
            {
                var pListBooks = pGameSettings.BOOKS;
                if (pListBooks.Valid())
                {
                    foreach (var book in pListBooks)
                    {
                        var uid = book.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {

                            book.SET_PROGRESS(CONST_BookZeroProgress);
                            book.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                book.SET_COUNT(1);
                                book.SET_PROGRESS(CONST_BookSetProgress);
                            }


                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = book.GET_COUNT().ToString(),
                            };
                        }
                    }
                }
            }

            //4.礼物
            else if (gameInventory.InventoryCategory == nameof(ConfidantGift))
            {
                var pListConfidantGifts = pGameSettings.CONFIDANT_GIFTS;
                if (pListConfidantGifts.Valid())
                {
                    foreach (var confidantGift in pListConfidantGifts)
                    {
                        var uid = confidantGift.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {


                            confidantGift.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                confidantGift.ADD(count);
                            }



                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = confidantGift.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }


            //5.消耗品
            else if (gameInventory.InventoryCategory == nameof(Consumable))
            {
                var pListConsumables = pGameSettings.CONSUMABLES;
                if (pListConsumables.Valid())
                {
                    foreach (var consumable in pListConsumables)
                    {
                        var uid = consumable.UID.ToString()!;

                        if (uid == gameInventory.InventoryObject)
                        {
                            consumable.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                consumable.ADD(count);
                            }



                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = consumable.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //6.材料
            else if (gameInventory.InventoryCategory == nameof(CraftMaterial))
            {
                var pListCraftMaterials = pGameSettings.CRAFT_MATERIALS;
                if (pListCraftMaterials.Valid())
                {
                    foreach (var craftMaterial in pListCraftMaterials)
                    {
                        var uid = craftMaterial.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            craftMaterial.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                craftMaterial.ADD(count);
                            }



                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = craftMaterial.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //7.肥料
            else if (gameInventory.InventoryCategory == nameof(Fertilizer))
            {
                var pListFertilizers = pGameSettings.FERTILIZERS;
                if (pListFertilizers.Valid())
                {
                    foreach (var fertilizer in pListFertilizers)
                    {
                        var uid = fertilizer.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            fertilizer.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                fertilizer.ADD(count);
                            }



                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = fertilizer.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //8.近战武器
            else if (gameInventory.InventoryCategory == nameof(MeleeWeapon))
            {
                var pListMeleeWeapons = pGameSettings.MELEE_WEAPONS;
                if (pListMeleeWeapons.Valid())
                {
                    foreach (var meleeWeapon in pListMeleeWeapons)
                    {
                        var uid = meleeWeapon.UID.ToString()!;

                        if (uid == gameInventory.InventoryObject)
                        {
                            meleeWeapon.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                meleeWeapon.ADD_00(count);
                            }



                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = meleeWeapon.GET_COUNT().ToString(),

                            };
                        }

                    }
                }
            }

            //9.任务道具
            else if (gameInventory.InventoryCategory == nameof(QuestItem))
            {
                var pListQuestItems = pGameSettings.QUEST_ITEMS;
                if (pListQuestItems.Valid())
                {
                    foreach (var questItem in pListQuestItems)
                    {
                        var uid = questItem.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            questItem.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                questItem.ADD(count);
                            }



                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = questItem.GET_COUNT().ToString(),

                            };
                        }


                    }
                }
            }


            //a.远程武器
            else if (gameInventory.InventoryCategory == nameof(RangedWeapon))
            {
                var pListRangedWeapons = pGameSettings.RANGED_WEAPONS;
                if (pListRangedWeapons.Valid())
                {
                    foreach (var rangedWeapon in pListRangedWeapons)
                    {
                        var uid = rangedWeapon.UID.ToString()!;

                        if (uid == gameInventory.InventoryObject)
                        {
                            rangedWeapon.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                rangedWeapon.ADD_00(count);
                            }



                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = rangedWeapon.GET_COUNT().ToString(),

                            };
                        }


                    }
                }
            }


            //b.食谱*
            else if (gameInventory.InventoryCategory == nameof(Recipe))
            {
                var pListRecipes = pGameSettings.RECIPES;
                if (pListRecipes.Valid())
                {
                    foreach (var recipe in pListRecipes)
                    {
                        var uid = recipe.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            if (count > 0)
                            {
                                recipe.LEARN_RECIPE();
                            }
                            else
                            {
                                recipe.FORGET_RECIPE();
                            }

                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = (recipe.GET_AVAILABLE() ? 1 : 0).ToString()
                            };
                        }

                    }
                }
            }



            //c.种子
            else if (gameInventory.InventoryCategory == nameof(Seed))
            {
                var pListSeeds = pGameSettings.SEEDS;
                if (pListSeeds.Valid())
                {
                    foreach (var seed in pListSeeds)
                    {
                        var uid = seed.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            seed.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                seed.ADD(count);
                            }



                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = seed.GET_COUNT().ToString(),

                            };
                        }
                    }
                }
            }

            //d.珍宝
            else if (gameInventory.InventoryCategory == nameof(Treasure))
            {
                var pListTreasures = pGameSettings.TREASURES;
                if (pListTreasures.Valid())
                {
                    foreach (var treasure in pListTreasures)
                    {
                        var uid = treasure.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            treasure.SET_COUNT(CONST_ITEM_ZERO);
                            if (count > 0)
                            {
                                treasure.ADD(count);
                            }
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = treasure.GET_COUNT().ToString(),

                            };
                        }

                    }
                }
            }

            //e.唱片
            else if (gameInventory.InventoryCategory == nameof(Vinyl))
            {
                var pListVinyls = pGameSettings.VINYLS;
                if (pListVinyls.Valid())
                {
                    foreach (var vinyl in pListVinyls)
                    {
                        var uid = vinyl.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            vinyl.SET_COUNT(CONST_ITEM_ZERO);
                            vinyl.SET_SHOWED(false);
                            if (count > 0)
                            {
                                vinyl.ADD_00(1);
                                vinyl.SET_SHOWED(true);
                            }
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = vinyl.GET_COUNT().ToString(),

                            };
                        }

                    }
                }
            }

            //f.电影*
            else if (gameInventory.InventoryCategory == nameof(Movie))
            {
                var pListMovies = pGameSettings.MOVIES;
                if (pListMovies.Valid())
                {
                    foreach (var movie in pListMovies)
                    {
                        var uid = movie.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            //      pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(movie, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                //        DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(movie).ToString(),

                            };
                        }

                    }
                }
            }

            //g.鱼
            else if (gameInventory.InventoryCategory == nameof(Fish))
            {
                var pListFishes = pGameSettings.FISHES;
                if (pListFishes.Valid())
                {
                    foreach (var fish in pListFishes)
                    {
                        var uid = fish.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            fish.SET_COUNT(CONST_ITEM_ZERO);
                            fish.SET_SHOWED(false);
                            if (count > 0)
                            {
                                fish.ADD_00(1);
                                fish.SET_SHOWED(true);
                            }
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = fish.GET_COUNT().ToString(),

                            };

                        }

                    }
                }
            }


            return GameException.Throw<GameInventoryInfoDTO>($"Not Found:{gameInventory.InventoryObject}");
        }
        #endregion

        #region Character
        static Character.Ptr_Character GetCharacterThrowIfNotFound(this PlayerData.Ptr_PlayerData pPlayerData, string uid)
        {
            var pPlayerGroup = pPlayerData.GET_PLAYER_GROUP();
            var span_uid = uid.AsSpan();
            foreach (var player in pPlayerGroup)
            {
                if (MemoryExtensions.SequenceEqual(player.UID.AsReadOnlySpan(), span_uid))
                {
                    return player;
                }
            }
            return GameException.Throw<Character.Ptr_Character>($"Not Found:{uid}");
        }
        static IEnumerable<GameSwitchDisplayDTO> GetCharacterAttributes(Character.Ptr_Character pCharacter)
        {
            BattlePlayerModel.Ptr_BattlePlayerModel pPlayerModel = pCharacter.PLAYER_MODEL;
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_CURR_HP), DisplayName = CONST_CURR_HP, ContentValue = pCharacter.CUR_HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_MAX_HP), DisplayName = CONST_MAX_HP, ContentValue = pCharacter.GET_MAX_HP().ToString(), UIType = (int)EnumGameSwitchUIType.Label };

            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_CURR_SP), DisplayName = CONST_CURR_SP, ContentValue = pCharacter.CUR_SP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_MAX_SP), DisplayName = CONST_MAX_SP, ContentValue = pCharacter.GET_MAX_SP().ToString(), UIType = (int)EnumGameSwitchUIType.Label };

            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_Lv), DisplayName = CONST_Lv, ContentValue = pCharacter.LEVEL.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_Exp), DisplayName = CONST_Exp, ContentValue = pCharacter.LEVEL_EXP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_PersonaLv), DisplayName = CONST_PersonaLv, ContentValue = pCharacter.GET_PERSONA_LEVEL().ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_PersonaExp), DisplayName = CONST_PersonaExp, ContentValue = pCharacter.GET_PERSONA_LEVEL_EXP().ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var pPersonas = pCharacter.GET_AVAILABLE_PERSONAS().AsReadOnlySpan().ToArray();
            int totalAgility = pPlayerModel.AGILITY_FROM_ITEMS;
            int totalStrength = pPlayerModel.STRENGTH_FROM_ITEMS;
            int totalEndurance = pPlayerModel.ENDURANCE_FROM_ITEMS;
            int totalMagic = pPlayerModel.MAGIC_FROM_ITEMS;
            int totalLuck = pPlayerModel.LUCK_FROM_ITEMS;
            if (pPersonas.Length != 0)
            {
                totalAgility += pPersonas.Max(p => p.GET_AGILITY());
                totalStrength += pPersonas.Max(p => p.GET_STRENGTH());
                totalEndurance += pPersonas.Max(p => p.GET_ENDURANCE());
                totalMagic += pPersonas.Max(p => p.GET_MAGIC());
                totalLuck += pPersonas.Max(p => p.GET_LUCK());
            }
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_Agility), DisplayName = CONST_Agility, ContentValue = totalAgility.ToString(), UIType = (int)EnumGameSwitchUIType.Label };
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_Strength), DisplayName = CONST_Strength, ContentValue = totalStrength.ToString(), UIType = (int)EnumGameSwitchUIType.Label };
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_Endurance), DisplayName = CONST_Endurance, ContentValue = totalEndurance.ToString(), UIType = (int)EnumGameSwitchUIType.Label };
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_Magic), DisplayName = CONST_Magic, ContentValue = totalMagic.ToString(), UIType = (int)EnumGameSwitchUIType.Label };
            yield return new GameSwitchDisplayDTO { ObjectId = nameof(CONST_Luck), DisplayName = CONST_Luck, ContentValue = totalLuck.ToString(), UIType = (int)EnumGameSwitchUIType.Label };

        }
        static GameSkillInfoDTO[] GameSkillInfoDTO(this Character.Ptr_Character pCharacter) => GameSkillInfoDTO(pCharacter.GetPtrSkillInfos(), PersonaProgress.SKILL_COUNT_MAX * pCharacter.GET_AVAILABLE_PERSONAS().Size);
        static GameSkillInfoDTO[] GameSkillInfoDTO(this PersonaProgress.Ptr_PersonaProgress pPersonas) => GameSkillInfoDTO(pPersonas.GetPtrSkillInfos(), PersonaProgress.SKILL_COUNT_MAX);
        static GameSkillInfoDTO[] GameSkillInfoDTO(this IEnumerable<SkillInfo.Ptr_SkillInfo> skillInfos, int count)
        {
            var skillInfoDTOs = Enumerable.Range(0, count).Select(_ => new GameSkillInfoDTO() { ObjectId = string.Empty, DisplayCategory = nameof(SkillInfo), CanWrite = true }).ToArray();
            int index = 0;
            foreach (var skillInfo in skillInfos)
            {
                var cacheSkillInfo = skillInfoDTOs.ElementAtOrDefault(index++);
                if (cacheSkillInfo is null)
                {
                    break;
                }
                cacheSkillInfo.ObjectId = skillInfo.UID.ToString()!;
                cacheSkillInfo.DisplayName = skillInfo.ITEM_NAME.GET_VALUE().ToString();
                cacheSkillInfo.DisplayDesc = skillInfo.DESCRIPTION.GET_VALUE().ToString();
            }
            return skillInfoDTOs;
        }
        static IEnumerable<SkillInfo.Ptr_SkillInfo> GetPtrSkillInfos(this Character.Ptr_Character pCharacter)
        {
            foreach (var ptr_Persona in pCharacter.GET_AVAILABLE_PERSONAS())
            {
                foreach (var skillInfo in ptr_Persona.GetPtrSkillInfos())
                {
                    yield return skillInfo;
                }
            }

        }
        static IEnumerable<SkillInfo.Ptr_SkillInfo> GetPtrSkillInfos(this PersonaProgress.Ptr_PersonaProgress personaProgress)
        {
            foreach (var skill in personaProgress.GET_SKILLS())
            {
                var skillInfo = skill.SKILL_INFO;
                if (skillInfo.Valid())
                {
                    yield return skillInfo;
                }
            }

        }

        public static IEnumerable<GameCharacterDisplayDTO> GetListCharacterDisplay(this BloomtownGameEnvironment @this)
        {
            var pGameSettings = @this.Ptr_GameSettings;
            var pListPlayerModels = pGameSettings.PLAYER_MODELS;
            if (pListPlayerModels.Valid())
            {
                foreach (var playerModel in pListPlayerModels)
                {
                    var uid = playerModel.UID.ToString()!;

                    yield return new GameCharacterDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = playerModel.UNIT_NAME.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Character),
                    };

                }
            }
        }

        public static GameCharacterStatusDTO GetCharacterStatus(this BloomtownGameEnvironment @this, GameCharacterObjectDTO gameCharacter)
        {
            var pGameSettings = @this.Ptr_GameSettings;
            var pPlayerData = @this.Ptr_PlayerData;

            var pCharacter = pPlayerData.GetCharacterThrowIfNotFound(gameCharacter.CharacterId);

            return new GameCharacterStatusDTO()
            {
                ObjectId = gameCharacter.CharacterId,
                CharacterAttributes = GetCharacterAttributes(pCharacter).ToArray(),
            };


        }
        public static GameCharacterStatusDTO UpdateCharacterStatus(this BloomtownGameEnvironment @this, GameCharacterModifyDTO characterModifyDTO)
        {
            var pPlayerData = @this.Ptr_PlayerData;

            var pCharacter = pPlayerData.GetCharacterThrowIfNotFound(characterModifyDTO.CharacterId);

            if (characterModifyDTO.ModifyObject == nameof(CONST_CURR_HP))
            {
                pCharacter.CUR_HP = characterModifyDTO.IntValue;
            }
            else if (characterModifyDTO.ModifyObject == nameof(CONST_CURR_SP))
            {
                pCharacter.CUR_SP = characterModifyDTO.IntValue;
            }
            else if (characterModifyDTO.ModifyObject == nameof(CONST_Lv))
            {
                pCharacter.SET_LEVEL(characterModifyDTO.IntValue);
            }
            else if (characterModifyDTO.ModifyObject == nameof(CONST_Exp))
            {
                pCharacter.LEVEL_EXP = 0;
                pCharacter.ADD_EXP_01(characterModifyDTO.IntValue);
            }
            else if (characterModifyDTO.ModifyObject == nameof(CONST_PersonaLv))
            {
                var lv = characterModifyDTO.IntValue;
                foreach (var p in pCharacter.GET_AVAILABLE_PERSONAS())
                {
                    p.SET_LEVEL(lv);
                }
            }
            else if (characterModifyDTO.ModifyObject == nameof(CONST_PersonaExp))
            {
                var exp = characterModifyDTO.IntValue;
                foreach (var p in pCharacter.GET_AVAILABLE_PERSONAS())
                {
                    p.EXP = 0;
                    p.ADD_EXP_01(exp);
                }
            }
            return new GameCharacterStatusDTO()
            {
                ObjectId = characterModifyDTO.CharacterId,
                CharacterAttributes = GetCharacterAttributes(pCharacter).ToArray(),
            };


        }


        static IEnumerable<GameEquipmentInfoDTO> GetEquipmentAttributes(BattlePlayerModel.Ptr_BattlePlayerModel pPlayerModel)
        {
            var defMeleeWeapon = new GameEquipmentInfoDTO()
            {
                ObjectId = string.Empty,
                DisplayCategory = nameof(MeleeWeapon),
                CanWrite = false
            };
            var pMeleeWeapon = pPlayerModel.MELEE_WEAPON;
            if (pMeleeWeapon.Valid() == false)
            {
                pMeleeWeapon = pPlayerModel.DEFAULT_WEAPON;
            }
            if (pMeleeWeapon.Valid())
            {
                defMeleeWeapon.ObjectId = pMeleeWeapon.UID.ToString()!;
                defMeleeWeapon.DisplayName = pMeleeWeapon.ITEM_NAME.GET_VALUE().ToString();
                defMeleeWeapon.DisplayDesc = pMeleeWeapon.DESCRIPTION.GET_VALUE().ToString();
            }
            yield return defMeleeWeapon;

            var defRangedWeapon = new GameEquipmentInfoDTO()
            {
                ObjectId = string.Empty,
                DisplayCategory = nameof(RangedWeapon),
                CanWrite = false
            };
            var pRangedWeapon = pPlayerModel.RANGED_WEAPON;
            if (pRangedWeapon.Valid() == false)
            {
                pRangedWeapon = pPlayerModel.DEFAULT_GUN;
            }
            if (pRangedWeapon.Valid())
            {
                defRangedWeapon.ObjectId = pRangedWeapon.UID.ToString()!;
                defRangedWeapon.DisplayName = pRangedWeapon.ITEM_NAME.GET_VALUE().ToString();
                defRangedWeapon.DisplayDesc = pRangedWeapon.DESCRIPTION.GET_VALUE().ToString();

            }
            yield return defRangedWeapon;


            var defArmor = new GameEquipmentInfoDTO()
            {
                ObjectId = string.Empty,
                DisplayCategory = nameof(Armor),
                CanWrite = false
            };
            var pArmor = pPlayerModel.ARMOR;
            if (pArmor.Valid() == false)
            {
                pArmor = pPlayerModel.DEFAULT_ARMOR;
            }
            if (pArmor.Valid())
            {
                defArmor.ObjectId = pArmor.UID.ToString()!;
                defArmor.DisplayName = pArmor.ITEM_NAME.GET_VALUE().ToString();
                defArmor.DisplayDesc = pArmor.DESCRIPTION.GET_VALUE().ToString();
            }
            yield return defArmor;


            var defAccessory = new GameEquipmentInfoDTO()
            {
                ObjectId = string.Empty,
                DisplayCategory = nameof(Accessory),
                CanWrite = false
            };
            var pAccessory = pPlayerModel.ACCESSORY;
            if (pAccessory.Valid())
            {
                defAccessory.ObjectId = pArmor.UID.ToString()!;
                defAccessory.DisplayName = pAccessory.ITEM_NAME.GET_VALUE().ToString();
                defAccessory.DisplayDesc = pAccessory.DESCRIPTION.GET_VALUE().ToString();
            }
            yield return defAccessory;

            var defDefaultPersona = new GameEquipmentInfoDTO()
            {
                ObjectId = string.Empty,
                DisplayCategory = nameof(PersonaProgress),
                CanWrite = false
            };
            var defaultPersona = pPlayerModel.DEFAULT_PERSONA;
            if (defaultPersona.Valid())
            {
                defDefaultPersona.ObjectId = defaultPersona.UID.ToString()!;
                defDefaultPersona.DisplayName = defaultPersona.UNIT_NAME.GET_VALUE().ToString();
            }
            yield return defDefaultPersona;

            var defPersonaProgress = new GameEquipmentInfoDTO()
            {
                ObjectId = string.Empty,
                DisplayCategory = nameof(PersonaProgress),
                CanWrite = true
            };
            var pPersonaProgress = pPlayerModel.PERSONA_PROGRESS;
            if (pPersonaProgress.Valid() && (nint)pPersonaProgress.MONSTER_MODEL != defaultPersona)
            {
                defPersonaProgress.ObjectId = pPersonaProgress.MONSTER_MODEL.UID.ToString()!;
                defPersonaProgress.DisplayName = pPersonaProgress.MONSTER_MODEL.UNIT_NAME.GET_VALUE().ToString();
            }
            yield return defPersonaProgress;

        }

        public static GameCharacterEquipmentDTO GetCharacterEquipment(this BloomtownGameEnvironment @this, GameCharacterObjectDTO gameCharacter)
        {
            var pGameSettings = @this.Ptr_GameSettings;
            var pPlayerData = @this.Ptr_PlayerData;

            var pCharacter = pPlayerData.GetCharacterThrowIfNotFound(gameCharacter.CharacterId);


            return new GameCharacterEquipmentDTO()
            {
                ObjectId = gameCharacter.CharacterId,
                EquipmentInfos = GetEquipmentAttributes(pCharacter.PLAYER_MODEL).ToArray(),
            };
        }

        public static GameCharacterEquipmentDTO UpdateCharacterEquipment(this BloomtownGameEnvironment @this, GameCharacterModifyDTO characterModifyDTO)
        {
            var oldMonsterId = characterModifyDTO.ModifyObject;
            var removeMonster = !string.IsNullOrEmpty(oldMonsterId);

            var newMonsterId = characterModifyDTO.NewValue;
            var addNewMonster = !string.IsNullOrEmpty(newMonsterId);
            if (!removeMonster && !addNewMonster)
            {
                return GameException.Throw<GameCharacterEquipmentDTO>("ERROR ARGS");
            }


            if (characterModifyDTO.ModifyCategory != nameof(PersonaProgress))
            {
                return GameException.Throw<GameCharacterEquipmentDTO>("NotImplemented");
            }

            var pPlayerData = @this.Ptr_PlayerData;
            var pCharacter = pPlayerData.GetCharacterThrowIfNotFound(characterModifyDTO.CharacterId);

            if (removeMonster)
            {
                foreach (var persona in pCharacter.GET_AVAILABLE_PERSONAS())
                {
                    if (MemoryExtensions.SequenceEqual(persona.GET_GET_UID().AsReadOnlySpan(), oldMonsterId))
                    {
                        pCharacter.UNEQUIP_PERSONA(persona);
                        break;
                    }
                }
            }

            if (addNewMonster)
            {
                if (!pPlayerData.TryGetPersonaProgress(newMonsterId, out var persona))
                {
                    persona = @this.AddPersonaProgress(newMonsterId!);
                }
                pCharacter.SET_ACTIVE_PERSONA(persona);
            }

            

            return new GameCharacterEquipmentDTO()
            {
                ObjectId = characterModifyDTO.CharacterId,
                EquipmentInfos = GetEquipmentAttributes(pCharacter.PLAYER_MODEL).ToArray(),
            };
        }

        public static GameCharacterSkillDTO GetCharacterSkill(this BloomtownGameEnvironment @this, GameCharacterObjectDTO gameCharacter)
        {
            //    var pGameSettings = @this.Ptr_GameSettings;
            var pPlayerData = @this.Ptr_PlayerData;
            var pCharacter = pPlayerData.GetCharacterThrowIfNotFound(gameCharacter.CharacterId);

            return new GameCharacterSkillDTO()
            {
                ObjectId = gameCharacter.CharacterId,
                SkillInfos = pCharacter.GameSkillInfoDTO(),
            };

        }
        static bool TryGetPersonaProgress(this PlayerData.Ptr_PlayerData ptr_PlayerData, ReadOnlySpan<char> uid, out PersonaProgress.Ptr_PersonaProgress personaProgress)
        {
            Unsafe.SkipInit(out personaProgress);
            var pListPersonaModels = ptr_PlayerData.M_PERSONAS_CAUGHT;
            if (pListPersonaModels.Valid())
            {
                foreach (var monsterModel in pListPersonaModels)
                {
                    if (MemoryExtensions.SequenceEqual(monsterModel.GET_GET_UID().AsReadOnlySpan(), uid))
                    {
                        personaProgress = monsterModel;
                        return true;
                    }
                }
            }
            return default;
        }
        static PersonaProgress.Ptr_PersonaProgress GetPersonaProgressThrowIfNotFound(this PlayerData.Ptr_PlayerData ptr_PlayerData, ReadOnlySpan<char> uid)
        {
            if (ptr_PlayerData.TryGetPersonaProgress(uid, out var personaProgress))
            {
                return personaProgress;
            }
            return GameException.Throw<PersonaProgress.Ptr_PersonaProgress>($"Not Found:{uid}");
        }
        static void UpdateMonsterSkill(this BloomtownGameEnvironment @this,
           bool removeOldSkill, ReadOnlySpan<char> oldSkillId, bool addNewSkill, ReadOnlySpan<char> newSkillId,
            params ReadOnlySpan<PersonaProgress.Ptr_PersonaProgress> personaProgresses)
        {


            if (removeOldSkill)
            {
                foreach (var pPersonas in personaProgresses)
                {
                    if (TryGetSkill(pPersonas, oldSkillId, out var ptr_Skill))
                    {
                        pPersonas.REMOVE_SKILL(ptr_Skill);
                    }
                }
            }
            if (addNewSkill && TryGetSkillInfo(@this.Ptr_GameSettings, newSkillId, out var ptr_SkillInfo))
            {
                foreach (var pPersonas in personaProgresses)
                {
                    if (!TryGetSkill(pPersonas, newSkillId, out var _))
                    {
                        var newSkill = @this.Context.Skill.GCNew<Skill.Ptr_Skill>(false);
                        newSkill.Target.CTOR_01(ptr_SkillInfo);

                        pPersonas.LEVEL = pPersonas.GET_NEAREST_SKILL_LEVEL();
                        pPersonas.ADD_SKILL(newSkill);
                        break;
                    }
                }
            }

            static bool TryGetSkillInfo(GameSettings.Ptr_GameSettings pGameSettings, ReadOnlySpan<char> uid, out SkillInfo.Ptr_SkillInfo ptr_SkillInfo)
            {
                Unsafe.SkipInit(out ptr_SkillInfo);
                foreach (var skillInfo in pGameSettings.SKILLS)
                {
                    if (MemoryExtensions.SequenceEqual(skillInfo.UID.AsReadOnlySpan(), uid))
                    {
                        ptr_SkillInfo = skillInfo;
                        return true;
                    }
                }
                return default;
            }
            static bool TryGetSkill(PersonaProgress.Ptr_PersonaProgress personaProgress, ReadOnlySpan<char> uid, out Skill.Ptr_Skill ptr_Skill)
            {
                Unsafe.SkipInit(out ptr_Skill);
                foreach (var skill in personaProgress.GET_SKILLS())
                {
                    var skillInfo = skill.SKILL_INFO;
                    if (skillInfo.Valid())
                    {
                        if (MemoryExtensions.SequenceEqual(skillInfo.UID.AsReadOnlySpan(), uid))
                        {
                            ptr_Skill = skill;
                            return true;
                        }
                    }
                }
                return default;
            }


        }
        public static GameCharacterSkillDTO UpdateCharacterSkill(this BloomtownGameEnvironment @this, GameCharacterModifyDTO characterModifyDTO)
        {
            var pGameSettings = @this.Ptr_GameSettings;

            var oldSkillId = characterModifyDTO.ModifyObject;
            var removeOldSkill = !string.IsNullOrEmpty(oldSkillId);

            var newSkillId = characterModifyDTO.NewValue;
            var addNewSkill = !string.IsNullOrEmpty(newSkillId);
            if (!removeOldSkill && !addNewSkill)
            {
                return GameException.Throw<GameCharacterSkillDTO>("ERROR ARGS");
            }

            var pPlayerData = @this.Ptr_PlayerData;

            if (characterModifyDTO.CharacterCategory == nameof(Character))
            {
                var pCharacter = pPlayerData.GetCharacterThrowIfNotFound(characterModifyDTO.CharacterId);
                var personaProgresses = pCharacter.GET_AVAILABLE_PERSONAS().AsReadOnlySpan().ToArray();
                UpdateMonsterSkill(@this, removeOldSkill, oldSkillId, addNewSkill, newSkillId, personaProgresses);
                return new GameCharacterSkillDTO()
                {
                    ObjectId = characterModifyDTO.CharacterId,
                    SkillInfos = pCharacter.GameSkillInfoDTO(),
                };
            }
            else
            {
                var personaProgress = pPlayerData.GetPersonaProgressThrowIfNotFound(characterModifyDTO.CharacterId);
                UpdateMonsterSkill(@this, removeOldSkill, oldSkillId, addNewSkill, newSkillId, personaProgress);
                return new GameCharacterSkillDTO()
                {
                    ObjectId = characterModifyDTO.CharacterId,
                    SkillInfos = personaProgress.GameSkillInfoDTO(),
                };
            }

        }
        #endregion

        #region Monster

        public static IEnumerable<GameMonsterDisplayDTO> GetListMonsterDisplay(this BloomtownGameEnvironment @this)
        {
            var pGameSettings = @this.Ptr_GameSettings;

            var pListMonsterModels = pGameSettings.MONSTER_MODELS;
            if (pListMonsterModels.Valid())
            {
                foreach (var monsterModel in pListMonsterModels)
                {
                    yield return GetMonsterInfo(monsterModel);

                }
            }

            var pListPersonaModels = pGameSettings.PERSONA_MODELS;
            if (pListPersonaModels.Valid())
            {
                foreach (var monsterModel in pListPersonaModels)
                {
                    yield return GetPersonaInfo(monsterModel);

                }
            }

            static GameMonsterDisplayDTO GetMonsterInfo(BattleMonsterModel.Ptr_BattleMonsterModel monsterModel)
            {
                var uid = monsterModel.UID.ToString()!;
                var tameStat = monsterModel.TAME_STAT.ToString();
                GameValueInfoDTO[] atts =
                [
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Lv,DisplayValue = monsterModel.LEVEL.ToString() ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_MAX_HP,DisplayValue = monsterModel.MAX_HP.ToString()   ,CanPreview=true},
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_MAX_SP,DisplayValue = monsterModel.MAX_SP.ToString()  ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Exp,DisplayValue = monsterModel.EXP.ToString()  ,CanPreview=true },


                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_MONSTERROLE,DisplayValue = monsterModel.MONSTER_ROLE.ToString(),CanPreview=true  },
                    ];

                var skills = GetSkillInfos(monsterModel.SKILLS).ToArray();

                return new GameMonsterDisplayDTO()
                {
                    ObjectId = uid,
                    DisplayName = monsterModel.UNIT_NAME.GET_VALUE().ToString(),
                    DisplayCategory = nameof(BattleMonsterModel),
                    MonsterAttributes = atts,
                    SkillInfos = skills,

                };
            }
            static GameMonsterDisplayDTO GetPersonaInfo(BattleMonsterModel.Ptr_BattleMonsterModel monsterModel)
            {
                var uid = monsterModel.UID.ToString()!;
                var tameStat = monsterModel.TAME_STAT.ToString();
                GameValueInfoDTO[] atts =
                [
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Lv,DisplayValue = monsterModel.LEVEL.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Strength,DisplayValue = monsterModel.RAW_STRENGTH.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Magic,DisplayValue = monsterModel.RAW_MAGIC.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Endurance,DisplayValue = monsterModel.RAW_ENDURANCE.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Agility,DisplayValue = monsterModel.RAW_AGILITY.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId =uid, DisplayName = CONST_Luck,DisplayValue = monsterModel.RAW_LUCK.ToString() ,CanPreview=true },

                         new GameValueInfoDTO{ ObjectId = uid, DisplayName =CONST_MonsterSocialStat ,DisplayValue = tameStat ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Tame,DisplayValue = monsterModel.TAME_DIFFICULTY.ToString() ,CanPreview=true },
                         new GameValueInfoDTO{ ObjectId = uid, DisplayName = CONST_Steal,DisplayValue = monsterModel.STEAL_DIFFICULTY.ToString()  ,CanPreview=true},

                    ];

                var skills = GetSkillInfos(monsterModel.SKILLS).ToArray();

                return new GameMonsterDisplayDTO()
                {
                    ObjectId = uid,
                    DisplayName = monsterModel.UNIT_NAME.GET_VALUE().ToString(),
                    DisplayCategory = nameof(PersonaProgress),
                    MonsterAttributes = atts,
                    SkillInfos = skills,

                };
            }


            static IEnumerable<GameSkillInfoDTO> GetSkillInfos(PMonoList_S<Skill.Ptr_Skill> pListSkills)
            {
                if (pListSkills.Valid())
                {
                    foreach (var skill in pListSkills)
                    {
                        var pSkillInfo = skill.SKILL_INFO;
                        if (pSkillInfo.Valid())
                        {
                            yield return new GameSkillInfoDTO()
                            {
                                ObjectId = pSkillInfo.UID.ToString()!,
                                DisplayCategory = nameof(SkillInfo),
                                DisplayName = pSkillInfo.ITEM_NAME.GET_VALUE().ToString(),
                                DisplayDesc = pSkillInfo.DESCRIPTION.GET_VALUE().ToString(),
                            };
                        }
                    }
                }

            }
        }
        static PersonaProgress.Ptr_PersonaProgress AddPersonaProgress(this BloomtownGameEnvironment @this, string uid)
        {
            var battleMonsterModel = @this.Ptr_GameSettings.GetPersonaMonsterModelThrowIfNotFound(uid);
            var pPersonaModel = @this.Context.PersonaProgress.GCNew<PersonaProgress.Ptr_PersonaProgress>(false);
            pPersonaModel.Target.CTOR_01(battleMonsterModel);
            @this.Ptr_PlayerData.PERSONAS_CAUGHT.ADD(pPersonaModel);
            return pPersonaModel;
        }
        public static GameCharacterSkillDTO AddMonsterMember(this BloomtownGameEnvironment @this, GameMonsterObjectDTO monsterObjectDTO)
        {
            var pPersonaModel = @this.AddPersonaProgress(monsterObjectDTO.MonsterObject);
            return new GameCharacterSkillDTO()
            {
                ObjectId = monsterObjectDTO.MonsterObject,
                SkillInfos = pPersonaModel.GameSkillInfoDTO(),
            };

        }
        static BattleMonsterModel.Ptr_BattleMonsterModel GetPersonaMonsterModelThrowIfNotFound(this GameSettings.Ptr_GameSettings pGameSettings, string uid)
        {
            var pListPersonaModels = pGameSettings.PERSONA_MODELS;
            if (pListPersonaModels.Valid())
            {
                foreach (var monsterModel in pListPersonaModels)
                {
                    if (MemoryExtensions.SequenceEqual(monsterModel.UID.AsReadOnlySpan(), uid))
                    {
                        return monsterModel;

                    }
                }
            }
            return GameException.Throw<BattleMonsterModel.Ptr_BattleMonsterModel>($"NOT FOUND:{uid}");

        }
        #endregion

        #region Skill
        static GameSkillDisplayDTO GetSkillInfo(SkillInfo.Ptr_SkillInfo pSkillInfo, string displayCategory)
        {
            var uid = pSkillInfo.UID.ToString()!;
            var atts = new GameValueInfoDTO[]
            {
                    new(){ ObjectId = nameof(CONST_SkillMinLv), DisplayName = CONST_SkillMinLv, DisplayValue = pSkillInfo.START_LEVEL.ToString() },
                    new(){ ObjectId = nameof(CONST_SkillMaxLv), DisplayName = CONST_SkillMaxLv, DisplayValue = pSkillInfo.END_LEVEL.ToString() },
            };
            return new GameSkillDisplayDTO()
            {
                ObjectId = uid,
                DisplayCategory = displayCategory,
                DisplayName = pSkillInfo.ITEM_NAME.GET_VALUE().ToString(),
                DisplayDesc = pSkillInfo.DESCRIPTION.GET_VALUE().ToString(),
                SkillAttributes = atts,
                CanUse = pSkillInfo.EFFECT_HOLDER.Valid(),

            };

        }

        public static IEnumerable<GameSkillDisplayDTO> GetListSkillDisplay(this BloomtownGameEnvironment @this)
        {
            var pGameSettings = @this.Ptr_GameSettings;
            var pListSkills = pGameSettings.SKILLS;
            foreach (var pSkillInfo in pListSkills)
            {
                yield return GetSkillInfo(pSkillInfo, nameof(SkillInfo));
            }


            var pListBuffs = pGameSettings.BUFFS;
            foreach (var pSkillInfo in pListBuffs)
            {
                yield return GetSkillInfo(pSkillInfo, nameof(SkillEffect));
            }

        }

        public static SkillInfo.Ptr_SkillInfo GetSkillInfoThrowIfNotFound(this GameSettings.Ptr_GameSettings ptr_GameSettings, string uid)
        {
            foreach (var skillInfo in ptr_GameSettings.SKILLS)
            {
                if (MemoryExtensions.SequenceEqual(skillInfo.UID.AsReadOnlySpan(), uid))
                {
                    return skillInfo;
                }

            }

            foreach (var skillInfo in ptr_GameSettings.BUFFS)
            {
                if (MemoryExtensions.SequenceEqual(skillInfo.UID.AsReadOnlySpan(), uid))
                {
                    return skillInfo;
                }

            }

            return GameException.Throw<SkillInfo.Ptr_SkillInfo>($"NOT FOUND:{uid}");


        }
        public static GameSkillDisplayDTO AddSkillDisplay(this BloomtownGameEnvironment @this, GameSkillObjectDTO gameSkillObject)
        {
            var pGameSettings = @this.Ptr_GameSettings;
            var skillInfo = pGameSettings.GetSkillInfoThrowIfNotFound(gameSkillObject.SkillObject);

            var pPlayerData = @this.Ptr_PlayerData;
            var caster = pPlayerData.PLAYER;
            var effectHolder = skillInfo.EFFECT_HOLDER;
            if (effectHolder)
            {
                if (effectHolder.EFFECT_TEMPLATE.IS_AOE)
                {
                    @this.Ptr_GameManager.APPLY_EFFECTS_WITHOUT_FIGHT(caster, caster, effectHolder);
                }
                else
                {
                    foreach (var target in pPlayerData.GET_PLAYER_GROUP())
                    {
                        @this.Ptr_GameManager.APPLY_EFFECTS_WITHOUT_FIGHT(caster, target, effectHolder);
                    }
                }
            }
            return GetSkillInfo(skillInfo, gameSkillObject.SkillCategory!);
        }
        #endregion



    }
}
