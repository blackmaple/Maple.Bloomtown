using Maple.Bloomtown.GameModel.Demo;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using System.Runtime.CompilerServices;

namespace Maple.Bloomtown
{
    internal static class BloomtownGameContextExtensions
    {
        public static void ShowMessage(this BloomtownGameContext @this, string? msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            var uiManager = @this.UIManager.INSTANCE;
            if (uiManager.Valid() == false)
            {
                return;
            }
            var popUpMessage = uiManager.POP_UP_MESSAGE;
            if (popUpMessage.Valid() == false)
            {
                return;
            }
            var pMonoString = @this.T(msg);
            popUpMessage.SHOW_MESSAGE(pMonoString);
        }

        public static GameSettings.Ptr_GameSettings GetGameSettings(this BloomtownGameContext @this)
        {
            var pStatsSync = @this.StatsSync.INSTANCE;
            if (pStatsSync.Valid() == false)
            {
                return default;
            }

            var pGameSettings = pStatsSync.GAME_SETTINGS;
            if (pGameSettings.Valid() == false)
            {
                return default;
            }
            return pGameSettings;
        }

        public static PlayerData.Ptr_PlayerData GetPlayerData(this BloomtownGameContext @this)
        {
            return @this.PlayerData.INSTANCE;
        }

        public static IEnumerable<UnitySpriteImageData> GetListGameSettingsIcon(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings, UnityEngineContext unityEngine)
        {

            foreach (var field in @this.GameSettings.ClassInfo.FieldInfos.Where(static p => p.FieldType.TypeName == "UnityEngine.Sprite"))
            {
                var pSprite = @this.GameSettings.GetMemberFieldValue<Sprite.Ptr_Sprite>(pGameSettings, field.Name);
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


        public static GameCurrencyDisplayDTO[] GetListCurrencyDisplay(this BloomtownGameContext @this)
        {
            return
            [
                new()
                {
                    ObjectId = nameof(PlayerData.Ptr_PlayerData.MONEY),
                    DisplayName =nameof(PlayerData.Ptr_PlayerData.MONEY),
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

        public static GameCurrencyInfoDTO GetCurrencyInfo(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, GameCurrencyObjectDTO gameCurrency)
        {
            if (Enum.TryParse<SocialStat.SocialStatType>(gameCurrency.CurrencyObject, out var socialStatType))
            {
                var pSocialStat = pPlayerData.PLAYER.GET_SOCIAL_STAT_BY_TYPE(socialStatType);
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
                    DisplayValue = pPlayerData.MONEY.ToString()
                };
            }

        }

        public static GameCurrencyInfoDTO UpdateCurrencyInfo(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, GameCurrencyModifyDTO gameCurrency)
        {
            _ = decimal.TryParse(gameCurrency.NewValue, out var val);
            var value = Convert.ToInt32(val);


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


        public static IEnumerable<GameInventoryDisplayDTO> GetListInventoryDisplay(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings)
        {

            //装饰品
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };

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
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(PassiveEffect), DisplayValue = pPassive.ARG_STR.ToString() };
                    }
                }
            }

            //盔甲
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };

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
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(PassiveEffect), DisplayValue = pPassive.ARG_STR.ToString() };
                    }
                }

            }

            //鱼饵
            //var pListBaits = pGameSettings.Baits;
            //if (pListBaits.Valid())
            //{
            //    foreach (var bait in pListBaits)
            //    {
            //        var uid = bait.UID.ToString()!;
            //        yield return new GameInventoryDisplayDTO()
            //        {
            //            ObjectId = uid,
            //            DisplayName = bait.ItemName.GET_VALUE().ToString(),
            //            DisplayDesc = bait.Description.GET_VALUE().ToString(),
            //            DisplayCategory = nameof(Bait),
            //            ItemAttributes = GetItemAttributes(uid, bait).ToArray()

            //        };

            //    }
            //    static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Bait.Ptr_Bait item)
            //    {
            //        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
            //    }

            //}

            //书籍
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //礼物
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //消耗品
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //材料
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //肥料
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }


            //开锁器
            var pLockpick = pGameSettings.LOCKPICK;
            if (pLockpick.Valid())
            {
                var uid = pLockpick.UID.ToString()!;
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = uid,
                    DisplayName = pLockpick.ITEM_NAME.GET_VALUE().ToString(),
                    DisplayDesc = pLockpick.DESCRIPTION.GET_VALUE().ToString(),
                    DisplayCategory = nameof(Lockpick),
                    ItemAttributes = GetItemAttributes(uid, pLockpick).ToArray(),

                };
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Lockpick.Ptr_Lockpick item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }

            }

            //捕鱼
            //var pFishHaul = pGameSettings.FishHaul;
            //if (pFishHaul.Valid())
            //{
            //    //yield return ;
            //}

            ////捕垃圾
            //var pGarbageHaul = pGameSettings.GarbageHaul;
            //if (pGarbageHaul.Valid())
            //{
            //    //yield return ;
            //}

            //近战武器
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };

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
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(PassiveEffect), DisplayValue = pPassive.ARG_STR.ToString() };
                    }
                }

            }

            //任务道具
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //远程武器
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };

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
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(PassiveEffect), DisplayValue = pPassive.ARG_STR.ToString() };
                    }
                }

            }

            //食谱
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.MINUTES_TO_CRAFT), DisplayValue = item.MINUTES_TO_CRAFT.ToString("F2"), CanPreview = true };
                }

            }

            //鱼竿
            //var pListRods = pGameSettings.Rods;
            //if (pListRods.Valid())
            //{
            //    foreach (var rod in pListRods)
            //    {
            //        var uid = rod.UID.ToString()!;
            //        yield return new GameInventoryDisplayDTO()
            //        {
            //            ObjectId = uid,
            //            DisplayName = rod.ItemName.GET_VALUE().ToString(),
            //            DisplayDesc = rod.Description.GET_VALUE().ToString(),
            //            DisplayCategory = nameof(Rod),
            //            ItemAttributes = GetItemAttributes(uid, rod).ToArray(),
            //        };

            //    }
            //    static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Rod.Ptr_Rod item)
            //    {
            //        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
            //    }
            //}

            //种子
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //珍宝
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //唱片
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                }
            }

            //电影
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item._DAY_OF_WEEK), DisplayValue = item._DAY_OF_WEEK.ToString(), CanPreview = true };
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item._SOCIAL_STAT_REWARD), DisplayValue = item._SOCIAL_STAT_REWARD.ToString(), CanPreview = true };

                }
            }


            //鱼
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.RARITY), DisplayValue = item.RARITY.ToString(), CanPreview = true };

                }
            }

        }

        public static GameInventoryInfoDTO GetInventoryInfo(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, GameInventoryObjectDTO gameInventory)
        {
            if (string.IsNullOrEmpty(gameInventory.InventoryCategory))
            {
                return GameException.Throw<GameInventoryInfoDTO>("Game Error");
            }

            var pGameSettings = pPlayerData.GAME_SETTINGS;
            if (pGameSettings.Valid() == false)
            {
                return GameException.Throw<GameInventoryInfoDTO>("Game Error");
            }

            //装饰品
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

                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(accessory).ToString(),
                            };
                        }

                    }
                }
            }

            //盔甲
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(armor).ToString(),

                            };
                        }
                    }
                }
            }

            //鱼饵
            //else if (gameInventory.InventoryCategory == nameof(Bait))
            //{
            //    var pListBaits = pGameSettings.Baits;
            //    if (pListBaits.Valid())
            //    {
            //        foreach (var bait in pListBaits)
            //        {
            //            var uid = bait.UID.ToString()!;
            //            if (uid == gameInventory.InventoryObject)
            //            {

            //                return new GameInventoryInfoDTO()
            //                {
            //                    ObjectId = uid,
            //                    DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(bait).ToString(),

            //                };
            //            }

            //        }
            //    }
            //}

            //书籍
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
                                DisplayValue = book.GET_PROGRESS().ToString("F2"),
                            };
                        }
                    }
                }
            }

            //礼物
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(confidantGift).ToString(),

                            };
                        }
                    }
                }
            }


            //消耗品
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(consumable).ToString(),

                            };
                        }
                    }
                }
            }

            //材料
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(craftMaterial).ToString(),

                            };
                        }
                    }
                }
            }

            //肥料
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(fertilizer).ToString(),

                            };
                        }
                    }
                }
            }



            //开锁器
            else if (gameInventory.InventoryCategory == nameof(Lockpick))
            {
                var pLockpick = pGameSettings.LOCKPICK;
                if (pLockpick.Valid())
                {
                    var uid = pLockpick.UID.ToString()!;
                    if (uid == gameInventory.InventoryObject)
                    {
                        return new GameInventoryInfoDTO()
                        {
                            ObjectId = uid,

                        };
                    }


                }
            }


            //捕鱼
            //var pFishHaul = pGameSettings.FishHaul;
            //if (pFishHaul.Valid())
            //{
            //    //yield return ;
            //}

            //捕垃圾
            //var pGarbageHaul = pGameSettings.GarbageHaul;
            //if (pGarbageHaul.Valid())
            //{
            //    //yield return ;
            //}

            //近战武器
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(meleeWeapon).ToString(),

                            };
                        }

                    }
                }
            }

            //任务道具
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(questItem).ToString(),

                            };
                        }


                    }
                }
            }


            //远程武器
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(rangedWeapon).ToString(),

                            };
                        }


                    }
                }
            }


            //食谱
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
                                DisplayValue = recipe.GET_AVAILABLE().ToString()
                            };
                        }

                    }
                }
            }


            //鱼竿
            //else if (gameInventory.InventoryCategory == nameof(Rod))
            //{
            //    var pListRods = pGameSettings.Rods;
            //    if (pListRods.Valid())
            //    {
            //        foreach (var rod in pListRods)
            //        {
            //            var uid = rod.UID.ToString()!;
            //            if (uid == gameInventory.InventoryObject)
            //            {
            //                return new GameInventoryInfoDTO()
            //                {
            //                    ObjectId = uid,
            //                    DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(rod).ToString(),

            //                };
            //            }

            //        }
            //    }
            //}


            //种子
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(seed).ToString(),

                            };
                        }
                    }
                }
            }

            //珍宝
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(treasure).ToString(),

                            };
                        }

                    }
                }
            }

            //唱片
            else if (gameInventory.InventoryCategory == nameof(Vinyl))
            {
                var pListTreasures = pGameSettings.VINYLS;
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(treasure).ToString(),

                            };
                        }

                    }
                }
            }

            //电影
            else if (gameInventory.InventoryCategory == nameof(Movie))
            {
                var pListTreasures = pGameSettings.MOVIES;
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(treasure).ToString(),

                            };
                        }

                    }
                }
            }

            //鱼
            else if (gameInventory.InventoryCategory == nameof(Fish))
            {
                var pListTreasures = pGameSettings.FISHES;
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(treasure).ToString(),

                            };
                        }

                    }
                }
            }

            return GameException.Throw<GameInventoryInfoDTO>($"Not Found Item:{gameInventory.InventoryObject}");
        }


        public static GameInventoryInfoDTO UpdateInventoryInfo(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, GameInventoryModifyDTO gameInventory)
        {
            if (string.IsNullOrEmpty(gameInventory.InventoryCategory))
            {
                return GameException.Throw<GameInventoryInfoDTO>("Game Error");
            }

            var pGameSettings = pPlayerData.GAME_SETTINGS;
            if (pGameSettings.Valid() == false)
            {
                return GameException.Throw<GameInventoryInfoDTO>("Game Error");
            }
            _ = int.TryParse(gameInventory.NewValue, out var count);

            //装饰品
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

                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(accessory, count);


                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(accessory).ToString(),
                            };
                        }

                    }
                }
            }

            //盔甲
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(armor, count);


                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(armor).ToString(),

                            };
                        }
                    }
                }
            }

            //鱼饵
            //else if (gameInventory.InventoryCategory == nameof(Bait))
            //{
            //    var pListBaits = pGameSettings.Baits;
            //    if (pListBaits.Valid())
            //    {
            //        foreach (var bait in pListBaits)
            //        {
            //            var uid = bait.UID.ToString()!;
            //            if (uid == gameInventory.InventoryObject)
            //            {
            //                pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(bait, count);

            //                return new GameInventoryInfoDTO()
            //                {
            //                    ObjectId = uid,
            //                    DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(bait).ToString(),

            //                };
            //            }

            //        }
            //    }
            //}

            //书籍
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
                            if (float.TryParse(gameInventory.NewValue, out var progress))
                            {
                                pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(book, 1);
                                book.SET_PROGRESS(0);
                                book.SET_PROGRESS(progress);
                            }

                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = book.GET_PROGRESS().ToString("F2"),
                            };
                        }
                    }
                }
            }

            //礼物
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(confidantGift, count);

                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(confidantGift).ToString(),

                            };
                        }
                    }
                }
            }


            //消耗品
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(consumable, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(consumable).ToString(),

                            };
                        }
                    }
                }
            }

            //材料
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(craftMaterial, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(craftMaterial).ToString(),

                            };
                        }
                    }
                }
            }

            //肥料
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(fertilizer, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(fertilizer).ToString(),

                            };
                        }
                    }
                }
            }



            //开锁器
            else if (gameInventory.InventoryCategory == nameof(Lockpick))
            {
                var pLockpick = pGameSettings.LOCKPICK;
                if (pLockpick.Valid())
                {
                    var uid = pLockpick.UID.ToString()!;
                    if (uid == gameInventory.InventoryObject)
                    {
                        return new GameInventoryInfoDTO()
                        {
                            ObjectId = uid,

                        };
                    }


                }
            }


            //捕鱼
            //var pFishHaul = pGameSettings.FishHaul;
            //if (pFishHaul.Valid())
            //{
            //    //yield return ;
            //}

            //捕垃圾
            //var pGarbageHaul = pGameSettings.GarbageHaul;
            //if (pGarbageHaul.Valid())
            //{
            //    //yield return ;
            //}

            //近战武器
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(meleeWeapon, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(meleeWeapon).ToString(),

                            };
                        }

                    }
                }
            }

            //任务道具
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(questItem, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(questItem).ToString(),

                            };
                        }


                    }
                }
            }


            //远程武器
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(rangedWeapon, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,

                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(rangedWeapon).ToString(),

                            };
                        }


                    }
                }
            }


            //食谱
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


                            if (bool.TryParse(gameInventory.NewValue, out var available) && available)
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
                                DisplayValue = recipe.GET_AVAILABLE().ToString()
                            };
                        }

                    }
                }
            }


            //鱼竿
            //else if (gameInventory.InventoryCategory == nameof(Rod))
            //{
            //    var pListRods = pGameSettings.Rods;
            //    if (pListRods.Valid())
            //    {
            //        foreach (var rod in pListRods)
            //        {
            //            var uid = rod.UID.ToString()!;
            //            if (uid == gameInventory.InventoryObject)
            //            {
            //                pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(rod, count);
            //                return new GameInventoryInfoDTO()
            //                {
            //                    ObjectId = uid,
            //                    DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(rod).ToString(),

            //                };
            //            }

            //        }
            //    }
            //}


            //种子
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(seed, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(seed).ToString(),

                            };
                        }
                    }
                }
            }

            //珍宝
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(treasure, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(treasure).ToString(),

                            };
                        }

                    }
                }
            }

            //唱片
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(vinyl, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(vinyl).ToString(),

                            };
                        }

                    }
                }
            }

            //电影
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

            //鱼
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
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(fish, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(fish).ToString(),

                            };
                        }

                    }
                }
            }


            return GameException.Throw<GameInventoryInfoDTO>($"Not Found Item:{gameInventory.InventoryObject}");
        }

        public static IEnumerable<UnitySpriteImageData> GetListInventoryIcon(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings, UnityEngineContext unityEngine)
        {

            //装饰品
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

            //盔甲
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

            //鱼饵
            //var pListBaits = pGameSettings.Baits;
            //if (pListBaits.Valid())
            //{
            //    //Icon
            //    foreach (var bait in pListBaits)
            //    {
            //        var pIcon = bait.GET_ICON_00();
            //        if (pIcon.Valid())
            //        {
            //            var pIconPng = unityEngine.ReadSprite2Png(pIcon);
            //            if (pIconPng.Valid())
            //            {
            //                yield return new UnitySpriteImageData() { Category = nameof(Bait), Name = bait.UID.ToString(), ImageData = pIconPng };
            //            }
            //        }

            //    }
            //}

            //书籍
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

            //礼物
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

            //消耗品
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

            //材料
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

            //肥料
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

            //开锁器
            var pLockpick = pGameSettings.LOCKPICK;
            if (pLockpick.Valid())
            {
                //GetIcon()
                var pIcon = pLockpick.GET_ICON_00();
                if (pIcon.Valid())
                {
                    var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                    if (pIconPng.Valid())
                    {
                        yield return new UnitySpriteImageData() { Category = nameof(Lockpick), Name = pLockpick.UID.ToString(), ImageData = pIconPng };
                    }
                }

            }

            //捕鱼
            //var pFishHaul = pGameSettings.FishHaul;
            //if (pFishHaul.Valid())
            //{
            //    //yield return ;
            //}

            ////捕垃圾
            //var pGarbageHaul = pGameSettings.GarbageHaul;
            //if (pGarbageHaul.Valid())
            //{
            //    //yield return ;
            //}

            //近战武器
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

            //任务道具
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

            //远程武器
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

            //食谱
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

            //鱼竿
            //var pListRods = pGameSettings.Rods;
            //if (pListRods.Valid())
            //{
            //    //GetIcon
            //    foreach (var rod in pListRods)
            //    {
            //        var pIcon = rod.GET_ICON_00();
            //        if (pIcon.Valid())
            //        {
            //            var pIconPng = unityEngine.ReadSprite2Png(pIcon);
            //            if (pIconPng.Valid())
            //            {
            //                yield return new UnitySpriteImageData() { Category = nameof(Rod), Name = rod.UID.ToString(), ImageData = pIconPng };
            //            }
            //        }

            //    }
            //}

            //种子
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

            //珍宝
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

            //唱片
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

            //电影
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

            //鱼
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

        public static IEnumerable<GameCharacterDisplayDTO> GetListCharacterDisplay(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings)
        {
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

        public static GameCharacterStatusDTO GetCharacterStatus(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, GameCharacterObjectDTO gameCharacter)
        {
            var uid = gameCharacter.CharacterId;
            var playerId = @this.T(uid);

            var pCharacter = pPlayerData.GET_CHARACTER(playerId);
            if (pCharacter.Valid() == false)
            {
                return GameException.Throw<GameCharacterStatusDTO>($"Not Found Character:{uid}");
            }

            return new GameCharacterStatusDTO()
            {
                ObjectId = uid,
                CharacterAttributes = []// GetCharacterAttributes(uid, pCharacter, pCharacter.PLAYER_MODEL).ToArray(),
            };

            static IEnumerable<GameValueInfoDTO> GetCharacterAttributes(string uid, Character.Ptr_Character pCharacter, BattlePlayerModel.Ptr_BattlePlayerModel pPlayerModel)
            {

                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = nameof(Character.Ptr_Character.CUR_HP), DisplayValue = pCharacter.CUR_HP.ToString(), CanWrite = true };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "MaxHP", DisplayValue = pCharacter.GET_MAX_HP().ToString() };

                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = nameof(Character.Ptr_Character.CUR_SP), DisplayValue = pCharacter.CUR_SP.ToString(), CanWrite = true };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "MaxSP", DisplayValue = pCharacter.GET_MAX_SP().ToString() };

                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = nameof(Character.Ptr_Character.LEVEL), DisplayValue = pCharacter.LEVEL.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = nameof(Character.Ptr_Character.LEVEL_EXP), DisplayValue = pCharacter.LEVEL_EXP.ToString(), CanWrite = true };

                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = $"Persona.Lv", DisplayValue = pCharacter.GET_PERSONA_LEVEL().ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = $"Persona.Exp", DisplayValue = pCharacter.GET_PERSONA_LEVEL_EXP().ToString(), CanWrite = true };



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
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "AGI", DisplayValue = totalAgility.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "STR", DisplayValue = totalStrength.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "EN", DisplayValue = totalEndurance.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "MAGIC", DisplayValue = totalMagic.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "LUCK", DisplayValue = totalLuck.ToString() };

            }

        }

        public static GameCharacterEquipmentDTO GetCharacterEquipment(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, GameCharacterObjectDTO gameCharacter)
        {
            var uid = gameCharacter.CharacterId;
            var playerId = @this.T(uid);

            var pCharacter = pPlayerData.GET_CHARACTER(playerId);
            if (pCharacter.Valid() == false)
            {
                return GameException.Throw<GameCharacterEquipmentDTO>($"Not Found Character:{uid}");
            }

            return new GameCharacterEquipmentDTO()
            {
                ObjectId = uid,
                // EquipmentAttributes = GetEquipmentAttributes(pCharacter.PLAYER_MODEL).ToArray(),
            };
            static IEnumerable<GameValueInfoDTO> GetEquipmentAttributes(BattlePlayerModel.Ptr_BattlePlayerModel pPlayerModel)
            {
                var meleeWeapon_UID = default(string);
                var pMeleeWeapon = pPlayerModel.MELEE_WEAPON;
                if (pMeleeWeapon.Valid() == false)
                {
                    pMeleeWeapon = pPlayerModel.DEFAULT_WEAPON;
                }
                if (pMeleeWeapon.Valid())
                {
                    meleeWeapon_UID = pMeleeWeapon.UID.ToString();
                }
                yield return new GameValueInfoDTO() { ObjectId = nameof(MeleeWeapon), DisplayName = nameof(MeleeWeapon), DisplayValue = meleeWeapon_UID, CanWrite = true };

                var rangedWeapon_UID = default(string);
                var pRangedWeapon = pPlayerModel.RANGED_WEAPON;
                if (pRangedWeapon.Valid() == false)
                {
                    pRangedWeapon = pPlayerModel.DEFAULT_GUN;
                }
                if (pRangedWeapon.Valid())
                {
                    rangedWeapon_UID = pRangedWeapon.UID.ToString();
                }
                yield return new GameValueInfoDTO() { ObjectId = nameof(RangedWeapon), DisplayName = nameof(RangedWeapon), DisplayValue = rangedWeapon_UID, CanWrite = true };

                var armor_UID = default(string);
                var pArmor = pPlayerModel.ARMOR;
                if (pArmor.Valid() == false)
                {
                    pArmor = pPlayerModel.DEFAULT_ARMOR;
                }
                if (pArmor.Valid())
                {
                    armor_UID = pArmor.UID.ToString();
                }
                yield return new GameValueInfoDTO() { ObjectId = nameof(Armor), DisplayName = nameof(Armor), DisplayValue = armor_UID, CanWrite = true };

                var accessory_UID = default(string);
                var pAccessory = pPlayerModel.ACCESSORY;
                if (pAccessory.Valid())
                {
                    yield return new GameValueInfoDTO() { ObjectId = nameof(Accessory), DisplayName = nameof(Accessory), DisplayValue = accessory_UID, CanWrite = true };
                }

                var defaultPersona_UID = pPlayerModel.DEFAULT_PERSONA.UID.ToString();
                yield return new GameValueInfoDTO() { ObjectId = nameof(BattleMonsterModel), DisplayName = nameof(BattleMonsterModel), DisplayValue = defaultPersona_UID, };

                var personaProgress_UID = default(string);
                var pPersonaProgress = pPlayerModel.PERSONA_PROGRESS;
                if (pPersonaProgress.Valid())
                {
                    personaProgress_UID = pPersonaProgress.MONSTER_MODEL.UID.ToString();
                    personaProgress_UID = personaProgress_UID != defaultPersona_UID ? personaProgress_UID : string.Empty;
                }

                yield return new GameValueInfoDTO() { ObjectId = nameof(PersonaProgress), DisplayName = nameof(PersonaProgress), DisplayValue = personaProgress_UID, CanWrite = true };

            }
        }

        public static GameCharacterSkillDTO GetCharacterSkill(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, GameCharacterObjectDTO gameCharacter)
        {
            var uid = gameCharacter.CharacterId;
            var playerId = @this.T(uid);

            var pCharacter = pPlayerData.GET_CHARACTER(playerId);
            if (pCharacter.Valid() == false)
            {
                return GameException.Throw<GameCharacterSkillDTO>($"Not Found Character:{uid}");
            }


            return new GameCharacterSkillDTO()
            {
                ObjectId = uid,
                SkillInfos = [],//[.. GetSkillInfos(pCharacter)],
            };
            static IEnumerable<GameValueInfoDTO> GetSkillInfos(Character.Ptr_Character pCharacter)
            {
                foreach (var pPersonas in pCharacter.GET_AVAILABLE_PERSONAS())
                {
                    var monsterModel = pPersonas.MONSTER_MODEL;
                    if (monsterModel.Valid())
                    {
                        var pSkills = monsterModel.SKILLS;
                        if (pSkills.Valid())
                        {
                            foreach (var skill in pSkills)
                            {
                                var pSkillInfo = skill.SKILL_INFO;
                                if (pSkillInfo.Valid())
                                {
                                    var uid = pSkillInfo.UID.ToString()!;
                                    yield return new GameValueInfoDTO()
                                    {
                                        ObjectId = nameof(Skill),
                                        DisplayName = nameof(Skill),
                                        DisplayValue = uid,
                                    };
                                }
                            }
                        }
                    }
                }
            }

        }

        public static IEnumerable<UnitySpriteImageData> GetListCharacterIcon(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, UnityEngineContext unityEngine)
        {
            var pPlayerGroup = pPlayerData.GET_PLAYER_GROUP();
            if (pPlayerGroup.Valid() == false)
            {
                yield break;
            }
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

        public static IEnumerable<GameMonsterDisplayDTO> GetListMonsterDisplay(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings)
        {
            var pListMonsterModels = pGameSettings.MONSTER_MODELS;
            if (pListMonsterModels.Valid())
            {
                foreach (var monsterModel in pListMonsterModels)
                {
                    var uid = monsterModel.UID.ToString()!;
                    var tameStat = monsterModel.TAME_STAT.ToString();
                    GameValueInfoDTO[] atts =
                    [
                            new GameValueInfoDTO{ ObjectId = uid, DisplayName = "LV",DisplayValue = monsterModel.LEVEL.ToString() ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "HP",DisplayValue = monsterModel.MAX_HP.ToString()   ,CanPreview=true},
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "SP",DisplayValue = monsterModel.MAX_SP.ToString()  ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "EXP",DisplayValue = monsterModel.EXP.ToString()  ,CanPreview=true },

                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Strength",DisplayValue = monsterModel.RAW_STRENGTH.ToString()  },
                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Magic",DisplayValue = monsterModel.RAW_MAGIC.ToString()  },
                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Endurance",DisplayValue = monsterModel.RAW_ENDURANCE.ToString()  },
                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Agility",DisplayValue = monsterModel.RAW_AGILITY.ToString()  },
                        //new GameValueInfoDTO{ ObjectId =uid, DisplayName = "Luck",DisplayValue = monsterModel.RAW_LUCK.ToString()  },

                        new GameValueInfoDTO{ ObjectId = uid, DisplayName =tameStat ,DisplayValue = tameStat ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Tame",DisplayValue = monsterModel.TAME_DIFFICULTY.ToString() ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Steal",DisplayValue = monsterModel.STEAL_DIFFICULTY.ToString()  ,CanPreview=true},

                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = monsterModel.GET_ROLE_NAME().ToString(),DisplayValue = monsterModel.MonsterRole.ToString()  },
                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = monsterModel.GET_ELEMENT_NAME().ToString(),DisplayValue = monsterModel.Element.ToString()  },
                    ];

                    var skills = GetGameSkillInfo(monsterModel.SKILLS).ToArray();

                    yield return new GameMonsterDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = monsterModel.UNIT_NAME.GET_VALUE().ToString(),
                        DisplayCategory = nameof(BattleMonsterModel),
                        MonsterAttributes = atts,
                        SkillInfos = [],

                    };

                }
            }

            var pListPersonaModels = pGameSettings.PERSONA_MODELS;
            if (pListPersonaModels.Valid())
            {
                foreach (var monsterModel in pListPersonaModels)
                {
                    var uid = monsterModel.UID.ToString()!;
                    var tameStat = monsterModel.TAME_STAT.ToString();
                    GameValueInfoDTO[] atts =
                    [
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "LV",DisplayValue = monsterModel.LEVEL.ToString() ,CanPreview=true },

                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Strength",DisplayValue = monsterModel.RAW_STRENGTH.ToString() ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Magic",DisplayValue = monsterModel.RAW_MAGIC.ToString() ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Endurance",DisplayValue = monsterModel.RAW_ENDURANCE.ToString(),CanPreview=true  },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Agility",DisplayValue = monsterModel.RAW_AGILITY.ToString(),CanPreview=true  },
                        new GameValueInfoDTO{ ObjectId =uid, DisplayName = "Luck",DisplayValue = monsterModel.RAW_LUCK.ToString()  ,CanPreview=true},

                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName =tameStat ,DisplayValue = tameStat  },
                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Tame",DisplayValue = monsterModel.TameDifficulty.ToString()  },
                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Steal",DisplayValue = monsterModel.StealDifficulty.ToString()  },

                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = monsterModel.GET_ROLE_NAME().ToString(),DisplayValue = monsterModel.MonsterRole.ToString()  },
                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = monsterModel.GET_ELEMENT_NAME().ToString(),DisplayValue = monsterModel.Element.ToString()  },
                    ];

                    var skills = GetGameSkillInfo(monsterModel.SKILLS).ToArray();

                    yield return new GameMonsterDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = monsterModel.UNIT_NAME.GET_VALUE().ToString(),
                        DisplayCategory = nameof(PersonaProgress),
                        MonsterAttributes = atts,
                        SkillInfos = [],

                    };

                }
            }



            static IEnumerable<GameValueInfoDTO> GetGameSkillInfo(PMonoList_S<Skill.Ptr_Skill> pListSkills)
            {
                if (pListSkills.Valid())
                {
                    foreach (var skill in pListSkills)
                    {
                        var pSkillInfo = skill.SKILL_INFO;
                        if (pSkillInfo.Valid())
                        {
                            var uid = pSkillInfo.UID.ToString()!;


                            yield return new GameValueInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayName = pSkillInfo.ITEM_NAME.GET_VALUE().ToString(),
                                DisplayValue = pSkillInfo.DESCRIPTION.GET_VALUE().ToString(),
                            };
                        }
                    }
                }

            }
        }

        public static IEnumerable<UnitySpriteImageData> GetListMonsterIcon(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings, UnityEngineContext unityEngine)
        {

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

        public static IEnumerable<GameSkillDisplayDTO> GetListSkillDisplay(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings)
        {

            var pListSkills = pGameSettings.SKILLS;

            foreach (var pSkillInfo in pListSkills)
            {
                var uid = pSkillInfo.UID.ToString()!;
                var atts = new GameValueInfoDTO[]
                {
                    new(){ ObjectId = "StartLevel", DisplayName = "StartLevel", DisplayValue = pSkillInfo.START_LEVEL.ToString() },
                    new(){ ObjectId = "EndLevel", DisplayName = "EndLevel", DisplayValue = pSkillInfo.END_LEVEL.ToString() },
                };
                yield return new GameSkillDisplayDTO()
                {
                    ObjectId = uid,
                    DisplayName = pSkillInfo.ITEM_NAME.GET_VALUE().ToString(),
                    DisplayCategory = nameof(Skill),
                    DisplayDesc = pSkillInfo.DESCRIPTION.GET_VALUE().ToString(),
                    SkillAttributes = atts
                };
            }




        }

        public static IEnumerable<UnitySpriteImageData> GetListSkillIcon(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings, UnityEngineContext unityEngine)
        {

            var pListSkills = pGameSettings.SKILLS;
            foreach (var pSkillInfo in pListSkills)
            {
                var pIcon = pSkillInfo.GET_ICON_00();
                if (pIcon.Valid())
                {
                    var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                    if (pIconPng.Valid())
                    {
                        yield return new UnitySpriteImageData() { Category = nameof(SkillInfo), Name = pSkillInfo.UID.ToString(), ImageData = pIconPng };
                    }
                }
            }


        }


        //public static void DebugAddPersona(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData)
        //{

        //    var pGameSettings = pPlayerData.GameSettings;
        //    if (pGameSettings.Valid() == false)
        //    {
        //        return;
        //    }
        //    var pListPersonaModels = pGameSettings.PersonaModels;
        //    if (pListPersonaModels.Valid() == false)
        //    {
        //        return;
        //    }
        //    if (pListPersonaModels.Size <= 0)
        //    {
        //        return;
        //    }
        //    ref var ref_first = ref pListPersonaModels[0];
        //    var first_val = ref_first;
        //    try
        //    {
        //        foreach (var personaModel in pListPersonaModels)
        //        {
        //            ref_first = personaModel;
        //            pPlayerData.DEBUG_ADD_PERSONA();
        //        }
        //    }
        //    finally
        //    {
        //        ref_first = first_val;
        //    }

        //    @this.ShowMessage("DebugAddPersona ok");
        //}
        //public static void DebugAddPersonaEx(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData)
        //{

        //    var pGameSettings = pPlayerData.GameSettings;
        //    if (pGameSettings.Valid() == false)
        //    {
        //        return;
        //    }

        //    var pListMonsterModels = pGameSettings.MonsterModels;
        //    if (pListMonsterModels.Valid() == false)
        //    {
        //        return;
        //    }
        //    var first = pListMonsterModels.AsEnumerable().Where(static p =>
        //    {
        //        var role = p.MonsterRole;
        //        if (role == MonsterRole.Boss || role == MonsterRole.Elite)
        //        {
        //            var pSkills = p.Skills;
        //            return pSkills.Valid() && pSkills.Size > 0;
        //        }
        //        return false;
        //    }).FirstOrDefault();
        //    if (first.Valid() == false)
        //    {
        //        return;
        //    }

        //    var pPlayerCharacter = pPlayerData.Player;
        //    if (pPlayerCharacter.Valid() == false)
        //    {
        //        return;
        //    }
        //    var pPlayerModel = pPlayerCharacter.PlayerModel;
        //    if (pPlayerModel.Valid() == false)
        //    {
        //        return;
        //    }
        //    var pDefaultPersona = pPlayerModel.DefaultPersona;
        //    if (pDefaultPersona.Valid() == false)
        //    {
        //        return;
        //    }
        //    pDefaultPersona.Skills = first.Skills;

        //    @this.ShowMessage("DebugAddPersonaEx ok");

        //}

    }



    internal sealed class BloomtownGameEnvironment
    {

        // UIManager.Ptr_UIManager Ptr_UIManager { get; }
        PopUpMessage.Ptr_PopUpMessage Ptr_PopUpMessage { get; }
        StatsSync.Ptr_StatsSync Ptr_StatsSync { get; }
        GameSettings.Ptr_GameSettings Ptr_GameSettings { get; }
        PlayerData.Ptr_PlayerData Ptr_PlayerData { get; }
        public BloomtownGameEnvironment(BloomtownGameContext gameContext)
        {
            var ptr_StatsSync = gameContext.StatsSync.INSTANCE;
            if (ptr_StatsSync.Valid() == false)
            {
                return;
            }
            var ptr_GameSettings = ptr_StatsSync.GAME_SETTINGS;
            if (ptr_GameSettings.Valid() == false)
            {
                return;
            }

            var ptr_UIManager = gameContext.UIManager.INSTANCE;
            if (false == ptr_UIManager.Valid())
            {
                return;
            }
            var ptr_PopUpMessage = ptr_UIManager.POP_UP_MESSAGE;
            if (false == ptr_PopUpMessage.Valid())
            {
                return;
            }

            this.Ptr_PlayerData = gameContext.PlayerData.INSTANCE;

            this.Ptr_PopUpMessage = ptr_PopUpMessage;

            this.Ptr_StatsSync = ptr_StatsSync;
            this.Ptr_GameSettings = ptr_GameSettings;


        }
    }
}
