﻿using Maple.Bloomtown.GameModel.Demo;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using System.Runtime.CompilerServices;

namespace Maple.Bloomtown
{
    internal static class BloomtownGameContextExtensions
    {

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


        public static IEnumerable<GameInventoryDisplayDTO> GetListInventoryDisplay(this BloomtownGameEnvironment @this)
        {
            var pGameSettings = @this.Ptr_GameSettings;
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.MINUTES_TO_CRAFT), DisplayValue = item.MINUTES_TO_CRAFT.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item._DAY_OF_WEEK), DisplayValue = item._DAY_OF_WEEK.ToString(), CanPreview = true };
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item._SOCIAL_STAT_REWARD), DisplayValue = item._SOCIAL_STAT_REWARD.ToString(), CanPreview = true };

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
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.PRICE), DisplayValue = item.PRICE.ToString("F2"), CanPreview = true };
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.RARITY), DisplayValue = item.RARITY.ToString(), CanPreview = true };

                }
            }

        }
        public static GameInventoryInfoDTO GetInventoryInfo(this BloomtownGameEnvironment @this, GameInventoryObjectDTO gameInventory)
        {
            var pPlayerData = @this.Ptr_PlayerData;
            var pGameSettings = @this.Ptr_GameSettings;

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

                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(accessory).ToString(),
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(armor).ToString(),

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
                                DisplayValue = book.GET_PROGRESS().ToString("F2"),
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(confidantGift).ToString(),

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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(consumable).ToString(),

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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(craftMaterial).ToString(),

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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(fertilizer).ToString(),

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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(meleeWeapon).ToString(),

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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(questItem).ToString(),

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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(rangedWeapon).ToString(),

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
                                DisplayValue = recipe.GET_AVAILABLE().ToString()
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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(seed).ToString(),

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
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(treasure).ToString(),

                            };
                        }

                    }
                }
            }

            //e.唱片
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

            //f.电影
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

            //g.鱼
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

            return GameException.Throw<GameInventoryInfoDTO>($"Not Found:{gameInventory.InventoryObject}");
        }
        public static GameInventoryInfoDTO UpdateInventoryInfo(this BloomtownGameEnvironment @this, GameInventoryModifyDTO gameInventory)
        {
            var pPlayerData = @this.Ptr_PlayerData;
            var pGameSettings = @this.Ptr_GameSettings;

            var count = gameInventory.InventoryCount;
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


            return GameException.Throw<GameInventoryInfoDTO>($"Not Found:{gameInventory.InventoryObject}");
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



        static Character.Ptr_Character GetCharacterThrowIfNotFound(this BloomtownGameEnvironment @this, PlayerData.Ptr_PlayerData pPlayerData, GameCharacterObjectDTO gameCharacter)
        {
            var uid = gameCharacter.CharacterId;
            using var playerId = @this.Context.T2(uid);

            var pCharacter = pPlayerData.GET_CHARACTER(playerId);
            if (pCharacter.Valid() == false)
            {
                return GameException.Throw<Character.Ptr_Character>($"Not Found:{uid}");
            }
            return pCharacter;
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

            var pCharacter = @this.GetCharacterThrowIfNotFound(pPlayerData, gameCharacter);

            return new GameCharacterStatusDTO()
            {
                ObjectId = gameCharacter.CharacterId,
                CharacterAttributes = GetCharacterAttributes(pCharacter).ToArray(),
            };

            static IEnumerable<GameSwitchDisplayDTO> GetCharacterAttributes(Character.Ptr_Character pCharacter)
            {
                BattlePlayerModel.Ptr_BattlePlayerModel pPlayerModel = pCharacter.PLAYER_MODEL;
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(Character.Ptr_Character.CUR_HP), DisplayName = "HP", ContentValue = pCharacter.CUR_HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(Character.Ptr_Character.GET_MAX_HP), DisplayName = "MaxHP", ContentValue = pCharacter.GET_MAX_HP().ToString(), UIType = (int)EnumGameSwitchUIType.Label };

                yield return new GameSwitchDisplayDTO { ObjectId = nameof(Character.Ptr_Character.CUR_SP), DisplayName = "SP", ContentValue = pCharacter.CUR_SP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(Character.Ptr_Character.GET_MAX_SP), DisplayName = "MaxSP", ContentValue = pCharacter.GET_MAX_SP().ToString(), UIType = (int)EnumGameSwitchUIType.Label };

                yield return new GameSwitchDisplayDTO { ObjectId = nameof(Character.Ptr_Character.LEVEL), DisplayName = "Lv", ContentValue = pCharacter.LEVEL.ToString(), UIType = (int)EnumGameSwitchUIType.Label };
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(Character.Ptr_Character.LEVEL_EXP), DisplayName = "Exp", ContentValue = pCharacter.LEVEL_EXP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

                yield return new GameSwitchDisplayDTO { ObjectId = nameof(Character.Ptr_Character.GET_PERSONA_LEVEL), DisplayName = "P.Lv", ContentValue = pCharacter.GET_PERSONA_LEVEL().ToString(), UIType = (int)EnumGameSwitchUIType.Label };
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(Character.Ptr_Character.GET_PERSONA_LEVEL_EXP), DisplayName = "P.Exp", ContentValue = pCharacter.GET_PERSONA_LEVEL_EXP().ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

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
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(PersonaProgress.Ptr_PersonaProgress.GET_AGILITY), DisplayName = "AGI", ContentValue = totalAgility.ToString(), UIType = (int)EnumGameSwitchUIType.Label };
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(PersonaProgress.Ptr_PersonaProgress.GET_STRENGTH), DisplayName = "STR", ContentValue = totalStrength.ToString(), UIType = (int)EnumGameSwitchUIType.Label };
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(PersonaProgress.Ptr_PersonaProgress.GET_ENDURANCE), DisplayName = "EN", ContentValue = totalEndurance.ToString(), UIType = (int)EnumGameSwitchUIType.Label };
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(PersonaProgress.Ptr_PersonaProgress.GET_MAGIC), DisplayName = "MAGIC", ContentValue = totalMagic.ToString(), UIType = (int)EnumGameSwitchUIType.Label };
                yield return new GameSwitchDisplayDTO { ObjectId = nameof(PersonaProgress.Ptr_PersonaProgress.GET_LUCK), DisplayName = "LUCK", ContentValue = totalLuck.ToString(), UIType = (int)EnumGameSwitchUIType.Label };

            }

        }
        public static GameCharacterEquipmentDTO GetCharacterEquipment(this BloomtownGameEnvironment @this, GameCharacterObjectDTO gameCharacter)
        {
            var pGameSettings = @this.Ptr_GameSettings;
            var pPlayerData = @this.Ptr_PlayerData;

            var pCharacter = @this.GetCharacterThrowIfNotFound(pPlayerData, gameCharacter);


            return new GameCharacterEquipmentDTO()
            {
                ObjectId = gameCharacter.CharacterId,
                EquipmentInfos = GetEquipmentAttributes(pCharacter.PLAYER_MODEL).ToArray(),
            };
            static IEnumerable<GameEquipmentInfoDTO> GetEquipmentAttributes(BattlePlayerModel.Ptr_BattlePlayerModel pPlayerModel)
            {
                var defMeleeWeapon = new GameEquipmentInfoDTO()
                {
                    ObjectId = string.Empty,
                    DisplayCategory = nameof(MeleeWeapon),
                    CanWrite = true
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
                    CanWrite = true
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
                    CanWrite = true
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
                    CanWrite = true
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
                    DisplayCategory = nameof(BattleMonsterModel),
                    CanWrite = true
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
        }

        public static GameCharacterSkillDTO GetCharacterSkill(this BloomtownGameEnvironment @this, GameCharacterObjectDTO gameCharacter)
        {
            var pGameSettings = @this.Ptr_GameSettings;
            var pPlayerData = @this.Ptr_PlayerData;
            var pCharacter = @this.GetCharacterThrowIfNotFound(pPlayerData, gameCharacter);

            return new GameCharacterSkillDTO()
            {
                ObjectId = gameCharacter.CharacterId,
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




    }



    internal sealed class BloomtownGameEnvironment
    {
        public BloomtownGameContext Context { get; }
        // UIManager.Ptr_UIManager Ptr_UIManager { get; }
        public PopUpMessage.Ptr_PopUpMessage Ptr_PopUpMessage { get; }
        public StatsSync.Ptr_StatsSync Ptr_StatsSync { get; }
        public GameSettings.Ptr_GameSettings Ptr_GameSettings { get; }
        public PlayerData.Ptr_PlayerData Ptr_PlayerData { get; }
        public BloomtownGameEnvironment(BloomtownGameContext gameContext)
        {
            this.Context = gameContext;

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
            if (ptr_UIManager.Valid())
            {
                var ptr_PopUpMessage = ptr_UIManager.POP_UP_MESSAGE;
                if (ptr_PopUpMessage.Valid())
                {
                    this.Ptr_PopUpMessage = ptr_PopUpMessage;
                }
            }


            this.Ptr_PlayerData = gameContext.PlayerData.INSTANCE;
            this.Ptr_StatsSync = ptr_StatsSync;
            this.Ptr_GameSettings = ptr_GameSettings;
        }

        public bool InGame()
        {
            return this.Ptr_PlayerData.Valid() && this.Ptr_PlayerData.M_CACHED_PTR != nint.Zero;
        }

        public void ShowMessage(string? msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            using var pMonoString = this.Context.T2(msg);
            this.Ptr_PopUpMessage.SHOW_MESSAGE(pMonoString);
        }

    }
}
