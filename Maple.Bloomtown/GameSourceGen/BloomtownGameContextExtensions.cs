using Maple.Bloomtown.GameModel.Demo;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            var uiManager = @this.UIManager.Instance;
            if (uiManager.Valid() == false)
            {
                return;
            }
            var popUpMessage = uiManager.PopUpMessage;
            if (popUpMessage.Valid() == false)
            {
                return;
            }
            var pMonoString = @this.T(msg);
            popUpMessage.SHOW_MESSAGE(pMonoString);
        }

        public static GameSettings.Ptr_GameSettings GetGameSettings(this BloomtownGameContext @this)
        {
            var pStatsSync = @this.StatsSync.Instance;
            if (pStatsSync.Valid() == false)
            {
                return default;
            }

            var pGameSettings = pStatsSync.GameSettings;
            if (pGameSettings.Valid() == false)
            {
                return default;
            }
            return pGameSettings;
        }
        public static PlayerData.Ptr_PlayerData GetPlayerData(this BloomtownGameContext @this)
        {
            return @this.PlayerData.Instance;
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
                    ObjectId = nameof(GameSettings.Ref_GameSettings.moneyIcon),
                    DisplayName =nameof(PlayerData.Ptr_PlayerData.Money),
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
                var pSocialStat = pPlayerData.Player.GET_SOCIAL_STAT_BY_TYPE(socialStatType);
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

                    ObjectId = nameof(GameSettings.Ref_GameSettings.moneyIcon),
                    DisplayValue = pPlayerData.Money.ToString()
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
                var pSocialStat = pPlayerData.Player.GET_SOCIAL_STAT_BY_TYPE(socialStatType);
                pSocialStat.Rang = value;
                pSocialStat.Exp = pSocialStat.GET_RANG_CAP(value - 1);
                return new GameCurrencyInfoDTO()
                {
                    ObjectId = socialStatType.ToString(),
                    DisplayValue = pSocialStat.GET_RANG().ToString(),
                };
            }
            else
            {
                value = Math.Clamp(value, 0, 999);
                pPlayerData.Money = value;
                return new GameCurrencyInfoDTO()
                {

                    ObjectId = nameof(GameSettings.Ref_GameSettings.moneyIcon),
                    DisplayValue = value.ToString()
                };
            }



        }


        public static IEnumerable<GameInventoryDisplayDTO> GetListInventoryDisplay(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings)
        {

            //装饰品
            var pListAccessories = pGameSettings.Accessories;
            if (pListAccessories.Valid())
            {
                foreach (var accessory in pListAccessories.AsEnumerable())
                {
                    var uid = accessory.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = accessory.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = accessory.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Accessory),

                        ItemAttributes = GetItemAttributes(uid, accessory).ToArray(),
                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Accessory.Ptr_Accessory item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };

                    var name = item.GET_STAT1_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT1().ToString(), CanPreview = true };
                    }

                    name = item.GET_STAT2_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT2().ToString(), CanPreview = true };
                    }

                    name = item.GET_STAT3_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT3().ToString(), CanPreview = true };
                    }

                    var pPassive = item.GET_PASSIVE();
                    if (pPassive.Valid())
                    {
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(PassiveEffect), DisplayValue = pPassive.ArgStr.ToString() };
                    }
                }
            }

            //盔甲
            var pListArmor = pGameSettings.Armors;
            if (pListArmor.Valid())
            {
                foreach (var armor in pListArmor.AsEnumerable())
                {
                    var uid = armor.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = armor.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = armor.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Armor),
                        ItemAttributes = GetItemAttributes(uid, armor).ToArray(),

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Armor.Ptr_Armor item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };

                    var name = item.GET_STAT1_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT1().ToString(), CanPreview = true };
                    }

                    name = item.GET_STAT2_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT2().ToString(), CanPreview = true };
                    }

                    name = item.GET_STAT3_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT3().ToString(), CanPreview = true };
                    }

                    var pPassive = item.GET_PASSIVE();
                    if (pPassive.Valid())
                    {
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(PassiveEffect), DisplayValue = pPassive.ArgStr.ToString() };
                    }
                }

            }

            //鱼饵
            var pListBaits = pGameSettings.Baits;
            if (pListBaits.Valid())
            {
                foreach (var bait in pListBaits.AsEnumerable())
                {
                    var uid = bait.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = bait.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = bait.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Bait),
                        ItemAttributes = GetItemAttributes(uid, bait).ToArray()

                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Bait.Ptr_Bait item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }

            }

            //书籍
            var pListBooks = pGameSettings.Books;
            if (pListBooks.Valid())
            {
                foreach (var book in pListBooks.AsEnumerable())
                {
                    var uid = book.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = book.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = book.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Book),
                        ItemAttributes = GetItemAttributes(uid, book).ToArray()

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Book.Ptr_Book item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }
            }

            //礼物
            var pListConfidantGifts = pGameSettings.ConfidantGifts;
            if (pListConfidantGifts.Valid())
            {
                foreach (var confidantGift in pListConfidantGifts.AsEnumerable())
                {
                    var uid = confidantGift.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = confidantGift.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = confidantGift.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(ConfidantGift),
                        ItemAttributes = GetItemAttributes(uid, confidantGift).ToArray()

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, ConfidantGift.Ptr_ConfidantGift item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }
            }

            //消耗品
            var pListConsumables = pGameSettings.Consumables;
            if (pListConsumables.Valid())
            {
                foreach (var consumable in pListConsumables.AsEnumerable())
                {
                    var uid = consumable.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = consumable.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = consumable.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Consumable),
                        ItemAttributes = GetItemAttributes(uid, consumable).ToArray(),

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Consumable.Ptr_Consumable item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }
            }

            //材料
            var pListCraftMaterials = pGameSettings.CraftMaterials;
            if (pListCraftMaterials.Valid())
            {
                foreach (var craftMaterial in pListCraftMaterials.AsEnumerable())
                {
                    var uid = craftMaterial.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = craftMaterial.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = craftMaterial.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(CraftMaterial),
                        ItemAttributes = GetItemAttributes(uid, craftMaterial).ToArray(),

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, CraftMaterial.Ptr_CraftMaterial item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }
            }

            //肥料
            var pListFertilizers = pGameSettings.Fertilizers;
            if (pListFertilizers.Valid())
            {
                foreach (var fertilizer in pListFertilizers.AsEnumerable())
                {
                    var uid = fertilizer.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = fertilizer.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = fertilizer.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Fertilizer),
                        ItemAttributes = GetItemAttributes(uid, fertilizer).ToArray()

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Fertilizer.Ptr_Fertilizer item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }
            }


            //开锁器
            var pLockpick = pGameSettings.Lockpick;
            if (pLockpick.Valid())
            {
                var uid = pLockpick.UID.ToString()!;
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = uid,
                    DisplayName = pLockpick.ItemName.GET_VALUE().ToString(),
                    DisplayDesc = pLockpick.Description.GET_VALUE().ToString(),
                    DisplayCategory = nameof(Lockpick),
                    ItemAttributes = GetItemAttributes(uid, pLockpick).ToArray(),

                };
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Lockpick.Ptr_Lockpick item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }

            }

            //捕鱼
            var pFishHaul = pGameSettings.FishHaul;
            if (pFishHaul.Valid())
            {
                //yield return ;
            }

            //捕垃圾
            var pGarbageHaul = pGameSettings.GarbageHaul;
            if (pGarbageHaul.Valid())
            {
                //yield return ;
            }

            //近战武器
            var pListMeleeWeapons = pGameSettings.MeleeWeapons;
            if (pListMeleeWeapons.Valid())
            {
                foreach (var meleeWeapon in pListMeleeWeapons.AsEnumerable())
                {
                    var uid = meleeWeapon.UID.ToString()!;


                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = meleeWeapon.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = meleeWeapon.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(MeleeWeapon),

                        ItemAttributes = GetItemAttributes(uid, meleeWeapon).ToArray(),
                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, MeleeWeapon.Ptr_MeleeWeapon item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };

                    var name = item.GET_STAT1_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT1().ToString(), CanPreview = true };
                    }

                    name = item.GET_STAT2_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT2().ToString(), CanPreview = true };
                    }

                    name = item.GET_STAT3_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT3().ToString(), CanPreview = true };
                    }

                    var pPassive = item.GET_PASSIVE();
                    if (pPassive.Valid())
                    {
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(PassiveEffect), DisplayValue = pPassive.ArgStr.ToString() };
                    }
                }

            }

            //任务道具
            var pListQuestItems = pGameSettings.QuestItems;
            if (pListQuestItems.Valid())
            {
                foreach (var questItem in pListQuestItems.AsEnumerable())
                {
                    var uid = questItem.UID.ToString()!;

                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = questItem.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = questItem.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(QuestItem),
                        ItemAttributes = GetItemAttributes(uid, questItem).ToArray(),

                    };


                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, QuestItem.Ptr_QuestItem item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }
            }

            //远程武器
            var pListRangedWeapons = pGameSettings.RangedWeapons;
            if (pListRangedWeapons.Valid())
            {
                foreach (var rangedWeapon in pListRangedWeapons.AsEnumerable())
                {
                    var uid = rangedWeapon.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = rangedWeapon.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = rangedWeapon.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(RangedWeapon),
                        ItemAttributes = GetItemAttributes(uid, rangedWeapon).ToArray(),
                    };


                }

                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, RangedWeapon.Ptr_RangedWeapon item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };

                    var name = item.GET_STAT1_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT1().ToString(), CanPreview = true };
                    }

                    name = item.GET_STAT2_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT2().ToString(), CanPreview = true };
                    }

                    name = item.GET_STAT3_NAME().ToString();
                    if (false == string.IsNullOrEmpty(name))
                    {
                        yield return new() { ObjectId = uid, DisplayName = name, DisplayValue = item.GET_STAT3().ToString(), CanPreview = true };
                    }

                    var pPassive = item.GET_PASSIVE();
                    if (pPassive.Valid())
                    {
                        yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(PassiveEffect), DisplayValue = pPassive.ArgStr.ToString() };
                    }
                }

            }

            //食谱
            var pListRecipes = pGameSettings.Recipes;
            if (pListRecipes.Valid())
            {
                foreach (var recipe in pListRecipes.AsEnumerable())
                {
                    var uid = recipe.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = recipe.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = recipe.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Recipe),
                        ItemAttributes = GetItemAttributes(uid, recipe).ToArray(),

                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Recipe.Ptr_Recipe item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.MinutesToCraft), DisplayValue = item.MinutesToCraft.ToString("F2"), CanPreview = true };
                }

            }

            //鱼竿
            var pListRods = pGameSettings.Rods;
            if (pListRods.Valid())
            {
                foreach (var rod in pListRods.AsEnumerable())
                {
                    var uid = rod.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = rod.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = rod.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Rod),
                        ItemAttributes = GetItemAttributes(uid, rod).ToArray(),
                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Rod.Ptr_Rod item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }
            }

            //种子
            var pListSeeds = pGameSettings.Seeds;
            if (pListSeeds.Valid())
            {
                foreach (var seed in pListSeeds.AsEnumerable())
                {
                    var uid = seed.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = seed.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = seed.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Seed),
                        ItemAttributes = GetItemAttributes(uid, seed).ToArray(),

                    };
                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Seed.Ptr_Seed item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }
            }

            //珍宝
            var pListTreasures = pGameSettings.Treasures;
            if (pListTreasures.Valid())
            {
                foreach (var treasure in pListTreasures.AsEnumerable())
                {
                    var uid = treasure.UID.ToString()!;
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = treasure.ItemName.GET_VALUE().ToString(),
                        DisplayDesc = treasure.Description.GET_VALUE().ToString(),
                        DisplayCategory = nameof(Treasure),
                        ItemAttributes = GetItemAttributes(uid, treasure).ToArray()
                    };

                }
                static IEnumerable<GameValueInfoDTO> GetItemAttributes(string uid, Treasure.Ptr_Treasure item)
                {
                    yield return new GameValueInfoDTO() { ObjectId = uid, DisplayName = nameof(item.Price), DisplayValue = item.Price.ToString("F2"), CanPreview = true };
                }
            }


        }
        public static GameInventoryInfoDTO GetInventoryInfo(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, GameInventoryObjectDTO gameInventory)
        {
            if (string.IsNullOrEmpty(gameInventory.InventoryCategory))
            {
                return GameException.Throw<GameInventoryInfoDTO>("Game Error");
            }

            var pGameSettings = pPlayerData.GameSettings;
            if (pGameSettings.Valid() == false)
            {
                return GameException.Throw<GameInventoryInfoDTO>("Game Error");
            }

            //装饰品
            if (gameInventory.InventoryCategory == nameof(Accessory))
            {
                var pListAccessories = pGameSettings.Accessories;
                if (pListAccessories.Valid())
                {
                    foreach (var accessory in pListAccessories.AsEnumerable())
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
                var pListArmor = pGameSettings.Armors;
                if (pListArmor.Valid())
                {
                    foreach (var armor in pListArmor.AsEnumerable())
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
            else if (gameInventory.InventoryCategory == nameof(Bait))
            {
                var pListBaits = pGameSettings.Baits;
                if (pListBaits.Valid())
                {
                    foreach (var bait in pListBaits.AsEnumerable())
                    {
                        var uid = bait.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {

                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(bait).ToString(),

                            };
                        }

                    }
                }
            }

            //书籍
            else if (gameInventory.InventoryCategory == nameof(Book))
            {
                var pListBooks = pGameSettings.Books;
                if (pListBooks.Valid())
                {
                    foreach (var book in pListBooks.AsEnumerable())
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
                var pListConfidantGifts = pGameSettings.ConfidantGifts;
                if (pListConfidantGifts.Valid())
                {
                    foreach (var confidantGift in pListConfidantGifts.AsEnumerable())
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
                var pListConsumables = pGameSettings.Consumables;
                if (pListConsumables.Valid())
                {
                    foreach (var consumable in pListConsumables.AsEnumerable())
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
                var pListCraftMaterials = pGameSettings.CraftMaterials;
                if (pListCraftMaterials.Valid())
                {
                    foreach (var craftMaterial in pListCraftMaterials.AsEnumerable())
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
                var pListFertilizers = pGameSettings.Fertilizers;
                if (pListFertilizers.Valid())
                {
                    foreach (var fertilizer in pListFertilizers.AsEnumerable())
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
                var pLockpick = pGameSettings.Lockpick;
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
                var pListMeleeWeapons = pGameSettings.MeleeWeapons;
                if (pListMeleeWeapons.Valid())
                {
                    foreach (var meleeWeapon in pListMeleeWeapons.AsEnumerable())
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
                var pListQuestItems = pGameSettings.QuestItems;
                if (pListQuestItems.Valid())
                {
                    foreach (var questItem in pListQuestItems.AsEnumerable())
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
                var pListRangedWeapons = pGameSettings.RangedWeapons;
                if (pListRangedWeapons.Valid())
                {
                    foreach (var rangedWeapon in pListRangedWeapons.AsEnumerable())
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
                var pListRecipes = pGameSettings.Recipes;
                if (pListRecipes.Valid())
                {
                    foreach (var recipe in pListRecipes.AsEnumerable())
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
            else if (gameInventory.InventoryCategory == nameof(Rod))
            {
                var pListRods = pGameSettings.Rods;
                if (pListRods.Valid())
                {
                    foreach (var rod in pListRods.AsEnumerable())
                    {
                        var uid = rod.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(rod).ToString(),

                            };
                        }

                    }
                }
            }


            //种子
            else if (gameInventory.InventoryCategory == nameof(Seed))
            {
                var pListSeeds = pGameSettings.Seeds;
                if (pListSeeds.Valid())
                {
                    foreach (var seed in pListSeeds.AsEnumerable())
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
                var pListTreasures = pGameSettings.Treasures;
                if (pListTreasures.Valid())
                {
                    foreach (var treasure in pListTreasures.AsEnumerable())
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

            return GameException.Throw<GameInventoryInfoDTO>($"找不到对应道具:{gameInventory.InventoryObject}");
        }
        public static GameInventoryInfoDTO UpdateInventoryInfo(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData, GameInventoryModifyDTO gameInventory)
        {
            if (string.IsNullOrEmpty(gameInventory.InventoryCategory))
            {
                return GameException.Throw<GameInventoryInfoDTO>("游戏异常!");
            }

            var pGameSettings = pPlayerData.GameSettings;
            if (pGameSettings.Valid() == false)
            {
                return GameException.Throw<GameInventoryInfoDTO>("游戏异常!");
            }
            _ = int.TryParse(gameInventory.NewValue, out var count);

            //装饰品
            if (gameInventory.InventoryCategory == nameof(Accessory))
            {
                var pListAccessories = pGameSettings.Accessories;
                if (pListAccessories.Valid())
                {
                    foreach (var accessory in pListAccessories.AsEnumerable())
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
                var pListArmor = pGameSettings.Armors;
                if (pListArmor.Valid())
                {
                    foreach (var armor in pListArmor.AsEnumerable())
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
            else if (gameInventory.InventoryCategory == nameof(Bait))
            {
                var pListBaits = pGameSettings.Baits;
                if (pListBaits.Valid())
                {
                    foreach (var bait in pListBaits.AsEnumerable())
                    {
                        var uid = bait.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(bait, count);

                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(bait).ToString(),

                            };
                        }

                    }
                }
            }

            //书籍
            else if (gameInventory.InventoryCategory == nameof(Book))
            {
                var pListBooks = pGameSettings.Books;
                if (pListBooks.Valid())
                {
                    foreach (var book in pListBooks.AsEnumerable())
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
                var pListConfidantGifts = pGameSettings.ConfidantGifts;
                if (pListConfidantGifts.Valid())
                {
                    foreach (var confidantGift in pListConfidantGifts.AsEnumerable())
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
                var pListConsumables = pGameSettings.Consumables;
                if (pListConsumables.Valid())
                {
                    foreach (var consumable in pListConsumables.AsEnumerable())
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
                var pListCraftMaterials = pGameSettings.CraftMaterials;
                if (pListCraftMaterials.Valid())
                {
                    foreach (var craftMaterial in pListCraftMaterials.AsEnumerable())
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
                var pListFertilizers = pGameSettings.Fertilizers;
                if (pListFertilizers.Valid())
                {
                    foreach (var fertilizer in pListFertilizers.AsEnumerable())
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
                var pLockpick = pGameSettings.Lockpick;
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
                var pListMeleeWeapons = pGameSettings.MeleeWeapons;
                if (pListMeleeWeapons.Valid())
                {
                    foreach (var meleeWeapon in pListMeleeWeapons.AsEnumerable())
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
                var pListQuestItems = pGameSettings.QuestItems;
                if (pListQuestItems.Valid())
                {
                    foreach (var questItem in pListQuestItems.AsEnumerable())
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
                var pListRangedWeapons = pGameSettings.RangedWeapons;
                if (pListRangedWeapons.Valid())
                {
                    foreach (var rangedWeapon in pListRangedWeapons.AsEnumerable())
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
                var pListRecipes = pGameSettings.Recipes;
                if (pListRecipes.Valid())
                {
                    foreach (var recipe in pListRecipes.AsEnumerable())
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
            else if (gameInventory.InventoryCategory == nameof(Rod))
            {
                var pListRods = pGameSettings.Rods;
                if (pListRods.Valid())
                {
                    foreach (var rod in pListRods.AsEnumerable())
                    {
                        var uid = rod.UID.ToString()!;
                        if (uid == gameInventory.InventoryObject)
                        {
                            pPlayerData.SET_ITEM_IN_INVENTORY_COUNT(rod, count);
                            return new GameInventoryInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayValue = pPlayerData.GET_ITEM_IN_INVENTORY_COUNT(rod).ToString(),

                            };
                        }

                    }
                }
            }


            //种子
            else if (gameInventory.InventoryCategory == nameof(Seed))
            {
                var pListSeeds = pGameSettings.Seeds;
                if (pListSeeds.Valid())
                {
                    foreach (var seed in pListSeeds.AsEnumerable())
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
                var pListTreasures = pGameSettings.Treasures;
                if (pListTreasures.Valid())
                {
                    foreach (var treasure in pListTreasures.AsEnumerable())
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

            return GameException.Throw<GameInventoryInfoDTO>($"找不到对应道具:{gameInventory.InventoryObject}");
        }
        public static IEnumerable<UnitySpriteImageData> GetListInventoryIcon(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings, UnityEngineContext unityEngine)
        {

            //装饰品
            var pListAccessories = pGameSettings.Accessories;
            if (pListAccessories.Valid())
            {
                //null
                foreach (var accessory in pListAccessories.AsEnumerable())
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
            var pListArmor = pGameSettings.Armors;
            if (pListArmor.Valid())
            {
                //getIcon
                foreach (var armor in pListArmor.AsEnumerable())
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
            var pListBaits = pGameSettings.Baits;
            if (pListBaits.Valid())
            {
                //Icon
                foreach (var bait in pListBaits.AsEnumerable())
                {
                    var pIcon = bait.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Bait), Name = bait.UID.ToString(), ImageData = pIconPng };
                        }
                    }

                }
            }

            //书籍
            var pListBooks = pGameSettings.Books;
            if (pListBooks.Valid())
            {
                //bookIcon
                foreach (var book in pListBooks.AsEnumerable())
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
            var pListConfidantGifts = pGameSettings.ConfidantGifts;
            if (pListConfidantGifts.Valid())
            {
                //giftIcon
                foreach (var confidantGift in pListConfidantGifts.AsEnumerable())
                {
                    var pIcon = pGameSettings.GiftIcon;
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
            var pListConsumables = pGameSettings.Consumables;
            if (pListConsumables.Valid())
            {
                //GetIcon
                foreach (var consumable in pListConsumables.AsEnumerable())
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
            var pListCraftMaterials = pGameSettings.CraftMaterials;
            if (pListCraftMaterials.Valid())
            {
                //GetIcon()
                foreach (var craftMaterial in pListCraftMaterials.AsEnumerable())
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
            var pListFertilizers = pGameSettings.Fertilizers;
            if (pListFertilizers.Valid())
            {
                //GetIcon()
                foreach (var fertilizer in pListFertilizers.AsEnumerable())
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
            var pLockpick = pGameSettings.Lockpick;
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
            var pFishHaul = pGameSettings.FishHaul;
            if (pFishHaul.Valid())
            {
                //yield return ;
            }

            //捕垃圾
            var pGarbageHaul = pGameSettings.GarbageHaul;
            if (pGarbageHaul.Valid())
            {
                //yield return ;
            }

            //近战武器
            var pListMeleeWeapons = pGameSettings.MeleeWeapons;
            if (pListMeleeWeapons.Valid())
            {
                //GetIcon()
                foreach (var meleeWeapon in pListMeleeWeapons.AsEnumerable())
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
            var pListQuestItems = pGameSettings.QuestItems;
            if (pListQuestItems.Valid())
            {
                //GetIcon()
                foreach (var questItem in pListQuestItems.AsEnumerable())
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
            var pListRangedWeapons = pGameSettings.RangedWeapons;
            if (pListRangedWeapons.Valid())
            {
                //GetIcon()
                foreach (var rangedWeapon in pListRangedWeapons.AsEnumerable())
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
            var pListRecipes = pGameSettings.Recipes;
            if (pListRecipes.Valid())
            {
                //GetIcon()
                foreach (var recipe in pListRecipes.AsEnumerable())
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
            var pListRods = pGameSettings.Rods;
            if (pListRods.Valid())
            {
                //GetIcon
                foreach (var rod in pListRods.AsEnumerable())
                {
                    var pIcon = rod.GET_ICON_00();
                    if (pIcon.Valid())
                    {
                        var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                        if (pIconPng.Valid())
                        {
                            yield return new UnitySpriteImageData() { Category = nameof(Rod), Name = rod.UID.ToString(), ImageData = pIconPng };
                        }
                    }

                }
            }

            //种子
            var pListSeeds = pGameSettings.Seeds;
            if (pListSeeds.Valid())
            {
                foreach (var seed in pListSeeds.AsEnumerable())
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
            var pListTreasures = pGameSettings.Treasures;
            if (pListTreasures.Valid())
            {
                //null
                foreach (var treasure in pListTreasures.AsEnumerable())
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
        }

        public static IEnumerable<GameCharacterDisplayDTO> GetListCharacterDisplay(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings)
        {
            var pListPlayerModels = pGameSettings.PlayerModels;
            if (pListPlayerModels.Valid())
            {
                foreach (var playerModel in pListPlayerModels.AsEnumerable())
                {
                    var uid = playerModel.UID.ToString()!;

                    yield return new GameCharacterDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = playerModel.UnitName.GET_VALUE().ToString(),
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
                CharacterAttributes = GetCharacterAttributes(uid, pCharacter, pCharacter.PlayerModel).ToArray(),
            };

            static IEnumerable<GameValueInfoDTO> GetCharacterAttributes(string uid, Character.Ptr_Character pCharacter, BattlePlayerModel.Ptr_BattlePlayerModel pPlayerModel)
            {

                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = nameof(Character.Ptr_Character.CurHP), DisplayValue = pCharacter.CurHP.ToString(), CanWrite = true };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "MaxHP", DisplayValue = pCharacter.GET_MAX_HP().ToString() };

                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = nameof(Character.Ptr_Character.CurSP), DisplayValue = pCharacter.CurSP.ToString(), CanWrite = true };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "MaxSP", DisplayValue = pCharacter.GET_MAX_SP().ToString() };

                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = nameof(Character.Ptr_Character.Level), DisplayValue = pCharacter.Level.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = nameof(Character.Ptr_Character.LevelExp), DisplayValue = pCharacter.LevelExp.ToString(), CanWrite = true };

                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = $"{nameof(PersonaProgress)}.{nameof(PersonaProgress.Ptr_PersonaProgress.Level)}", DisplayValue = pCharacter.GET_PERSONA_LEVEL().ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = $"{nameof(PersonaProgress)}.{nameof(PersonaProgress.Ptr_PersonaProgress.Exp)}", DisplayValue = pCharacter.GET_PERSONA_LEVEL_EXP().ToString(), CanWrite = true };



                //var weaponDamage = 1;
                //var meleeAccuracy = 100;
                //var meleeCriticalChance = 0;
                //var meleeCriticalDamage = 0F;
                //if (pPlayerModel.MeleeWeapon.Valid())
                //{
                //    weaponDamage = pPlayerModel.MeleeWeapon.Attack;
                //    meleeAccuracy = pPlayerModel.MeleeWeapon.Accuracy;
                //    meleeCriticalChance = pPlayerModel.MeleeWeapon.CriticalChance;
                //    meleeCriticalDamage = pPlayerModel.MeleeWeapon.CriticalDamageBonus;
                //}
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "WeaponDamage", DisplayValue = weaponDamage.ToString() };
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "MeleeAccuracy", DisplayValue = meleeAccuracy.ToString() };
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "MeleeCriticalChance", DisplayValue = meleeCriticalChance.ToString() };
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "MeleeCriticalDamage", DisplayValue = meleeCriticalDamage.ToString() };


                //var gunDamage = 0;
                //var gunAccuracy = 100;
                //var gunCriticalChance = 0;
                //var gunCriticalDamage = 0F;
                //var maxShots = 0;
                //if (pPlayerModel.RangedWeapon.Valid())
                //{
                //    gunDamage = pPlayerModel.RangedWeapon.Attack;
                //    gunAccuracy = pPlayerModel.RangedWeapon.Accuracy;
                //    gunCriticalChance = pPlayerModel.RangedWeapon.CriticalChance;
                //    gunCriticalDamage = pPlayerModel.RangedWeapon.CriticalDamageBonus;
                //    maxShots = pPlayerModel.RangedWeapon.Rounds;
                //}
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "GunDamage", DisplayValue = gunDamage.ToString(), };
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "GunAccuracy", DisplayValue = gunAccuracy.ToString(), };
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "GunCriticalChance", DisplayValue = gunCriticalChance.ToString(), };
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "GunCriticalDamage", DisplayValue = gunCriticalDamage.ToString(), };
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "MaxShots", DisplayValue = maxShots.ToString(), };


                //var armor = 0;
                //var evasion = 0;
                //if (pPlayerModel.Armor.Valid())
                //{
                //    armor = pPlayerModel.Armor.Defense;
                //    evasion = pPlayerModel.Armor.Evasion;
                //}
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "Armor", DisplayValue = armor.ToString(), };
                //yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "Evasion", DisplayValue = evasion.ToString(), };

                var pPersonas = pCharacter.GET_AVAILABLE_PERSONAS().AsReadOnlySpan().ToArray();
                int totalAgility = pPlayerModel.AgilityFromItems;
                int totalStrength = pPlayerModel.StrengthFromItems;
                int totalEndurance = 0;
                int totalMagic = 0;
                int totalLuck = 0;
                if (pPersonas.Length != 0)
                {
                    totalAgility += pPersonas.Max(p => p.GET_AGILITY());
                    totalStrength += pPersonas.Max(p => p.GET_STRENGTH());
                    totalEndurance += pPersonas.Max(p => p.GET_ENDURANCE());
                    totalMagic += pPersonas.Max(p => p.GET_MAGIC());
                    totalLuck += pPersonas.Max(p => p.GET_LUCK());
                }
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "TotalAgility", DisplayValue = totalAgility.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "TotalStrength", DisplayValue = totalStrength.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "TotalEndurance", DisplayValue = totalEndurance.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "TotalMagic", DisplayValue = totalMagic.ToString() };
                yield return new GameValueInfoDTO { ObjectId = uid, DisplayName = "TotalLuck", DisplayValue = totalLuck.ToString() };

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
                EquipmentAttributes = GetEquipmentAttributes(pCharacter.PlayerModel).ToArray(),
            };
            static IEnumerable<GameValueInfoDTO> GetEquipmentAttributes(BattlePlayerModel.Ptr_BattlePlayerModel pPlayerModel)
            {
                var meleeWeapon_UID = default(string);
                var pMeleeWeapon = pPlayerModel.MeleeWeapon;
                if (pMeleeWeapon.Valid() == false)
                {
                    pMeleeWeapon = pPlayerModel.DefaultWeapon;
                }
                if (pMeleeWeapon.Valid())
                {
                    meleeWeapon_UID = pMeleeWeapon.UID.ToString();
                }
                yield return new GameValueInfoDTO() { ObjectId = nameof(MeleeWeapon), DisplayName = nameof(MeleeWeapon), DisplayValue = meleeWeapon_UID, CanWrite = true };

                var rangedWeapon_UID = default(string);
                var pRangedWeapon = pPlayerModel.RangedWeapon;
                if (pRangedWeapon.Valid() == false)
                {
                    pRangedWeapon = pPlayerModel.DefaultGun;
                }
                if (pRangedWeapon.Valid())
                {
                    rangedWeapon_UID = pRangedWeapon.UID.ToString();
                }
                yield return new GameValueInfoDTO() { ObjectId = nameof(RangedWeapon), DisplayName = nameof(RangedWeapon), DisplayValue = rangedWeapon_UID, CanWrite = true };

                var Armor_UID = default(string);
                var pArmor = pPlayerModel.Armor;
                if (pArmor.Valid() == false)
                {
                    pArmor = pPlayerModel.DefaultArmor;
                }
                if (pArmor.Valid())
                {
                    Armor_UID = pArmor.UID.ToString();
                }
                yield return new GameValueInfoDTO() { ObjectId = nameof(Armor), DisplayName = nameof(Armor), DisplayValue = Armor_UID, CanWrite = true };

                var accessory_UID = default(string);
                var pAccessory = pPlayerModel.Accessory;
                if (pAccessory.Valid())
                {
                    yield return new GameValueInfoDTO() { ObjectId = nameof(Accessory), DisplayName = nameof(Accessory), DisplayValue = accessory_UID, CanWrite = true };
                }

                var defaultPersona_UID = pPlayerModel.DefaultPersona.UID.ToString();
                yield return new GameValueInfoDTO() { ObjectId = nameof(BattleMonsterModel), DisplayName = nameof(BattleMonsterModel), DisplayValue = defaultPersona_UID, };

                var personaProgress_UID = default(string);
                var pPersonaProgress = pPlayerModel.PersonaProgress;
                if (pPersonaProgress.Valid())
                {
                    personaProgress_UID = pPersonaProgress.MonsterModel.UID.ToString();
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
                SkillInfos = [.. GetSkillInfos(pCharacter)],
            };
            static IEnumerable<GameValueInfoDTO> GetSkillInfos(Character.Ptr_Character pCharacter)
            {
                foreach (var pPersonas in pCharacter.GET_AVAILABLE_PERSONAS().AsEnumerable())
                {
                    var monsterModel = pPersonas.MonsterModel;
                    if (monsterModel.Valid())
                    {
                        var pSkills = monsterModel.Skills;
                        if (pSkills.Valid())
                        {
                            foreach (var skill in pSkills.AsEnumerable())
                            {
                                var pSkillInfo = skill.SkillInfo;
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
            foreach (var player in pPlayerGroup.AsEnumerable())
            {
                var pAvatar = player.AvatarMini;
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
            var pListMonsterModels = pGameSettings.MonsterModels;
            if (pListMonsterModels.Valid())
            {
                foreach (var monsterModel in pListMonsterModels.AsEnumerable())
                {
                    var uid = monsterModel.UID.ToString()!;
                    var tameStat = monsterModel.TameStat.ToString();
                    GameValueInfoDTO[] atts =
                    [
                            new GameValueInfoDTO{ ObjectId = uid, DisplayName = "LV",DisplayValue = monsterModel.Level.ToString() ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "HP",DisplayValue = monsterModel.MaxHP.ToString()   ,CanPreview=true},
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "SP",DisplayValue = monsterModel.MaxSP.ToString()  ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "EXP",DisplayValue = monsterModel.Exp.ToString()  ,CanPreview=true },

                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Strength",DisplayValue = monsterModel.RawStrength.ToString()  },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Magic",DisplayValue = monsterModel.RawMagic.ToString()  },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Endurance",DisplayValue = monsterModel.RawEndurance.ToString()  },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Agility",DisplayValue = monsterModel.RawAgility.ToString()  },
                        new GameValueInfoDTO{ ObjectId =uid, DisplayName = "Luck",DisplayValue = monsterModel.RawLuck.ToString()  },

                        new GameValueInfoDTO{ ObjectId = uid, DisplayName =tameStat ,DisplayValue = tameStat  },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Tame",DisplayValue = monsterModel.TameDifficulty.ToString()  },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Steal",DisplayValue = monsterModel.StealDifficulty.ToString()  },

                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = monsterModel.GET_ROLE_NAME().ToString(),DisplayValue = monsterModel.MonsterRole.ToString()  },
                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = monsterModel.GET_ELEMENT_NAME().ToString(),DisplayValue = monsterModel.Element.ToString()  },
                    ];

                    var skills = GetGameSkillInfo(monsterModel.Skills).ToArray();

                    yield return new GameMonsterDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = monsterModel.UnitName.GET_VALUE().ToString(),
                        DisplayCategory = nameof(BattleMonsterModel),
                        MonsterAttributes = atts,
                        SkillInfos = skills,

                    };

                }
            }

            var pListPersonaModels = pGameSettings.PersonaModels;
            if (pListPersonaModels.Valid())
            {
                foreach (var monsterModel in pListPersonaModels.AsEnumerable())
                {
                    var uid = monsterModel.UID.ToString()!;
                    var tameStat = monsterModel.TameStat.ToString();
                    GameValueInfoDTO[] atts =
                    [
                            new GameValueInfoDTO{ ObjectId = uid, DisplayName = "LV",DisplayValue = monsterModel.Level.ToString()  },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "HP",DisplayValue = monsterModel.MaxHP.ToString()   },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "SP",DisplayValue = monsterModel.MaxSP.ToString()   },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "EXP",DisplayValue = monsterModel.Exp.ToString()   },

                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Strength",DisplayValue = monsterModel.RawStrength.ToString() ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Magic",DisplayValue = monsterModel.RawMagic.ToString() ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Endurance",DisplayValue = monsterModel.RawEndurance.ToString()  ,CanPreview=true},
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Agility",DisplayValue = monsterModel.RawAgility.ToString() ,CanPreview=true },
                        new GameValueInfoDTO{ ObjectId =uid, DisplayName = "Luck",DisplayValue = monsterModel.RawLuck.ToString()  ,CanPreview=true},

                        new GameValueInfoDTO{ ObjectId = uid, DisplayName =tameStat ,DisplayValue = tameStat  },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Tame",DisplayValue = monsterModel.TameDifficulty.ToString()  },
                        new GameValueInfoDTO{ ObjectId = uid, DisplayName = "Steal",DisplayValue = monsterModel.StealDifficulty.ToString()  },

                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = monsterModel.GET_ROLE_NAME().ToString(),DisplayValue = monsterModel.MonsterRole.ToString()  },
                        //new GameValueInfoDTO{ ObjectId = uid, DisplayName = monsterModel.GET_ELEMENT_NAME().ToString(),DisplayValue = monsterModel.Element.ToString()  },
                    ];

                    var skills = GetGameSkillInfo(monsterModel.Skills).ToArray();

                    yield return new GameMonsterDisplayDTO()
                    {
                        ObjectId = uid,
                        DisplayName = monsterModel.UnitName.GET_VALUE().ToString(),
                        DisplayCategory = nameof(PersonaProgress),
                        MonsterAttributes = atts,
                        SkillInfos = skills,

                    };

                }
            }



            static IEnumerable<GameValueInfoDTO> GetGameSkillInfo(PMonoList_S<Skill.Ptr_Skill> pListSkills)
            {
                if (pListSkills.Valid())
                {
                    foreach (var skill in pListSkills.AsEnumerable())
                    {
                        var pSkillInfo = skill.SkillInfo;
                        if (pSkillInfo.Valid())
                        {
                            var uid = pSkillInfo.UID.ToString()!;


                            yield return new GameValueInfoDTO()
                            {
                                ObjectId = uid,
                                DisplayName = pSkillInfo.ItemName.GET_VALUE().ToString(),
                                DisplayValue = pSkillInfo.Description.GET_VALUE().ToString(),
                            };
                        }
                    }
                }

            }
        }
        public static IEnumerable<UnitySpriteImageData> GetListMonsterIcon(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings, UnityEngineContext unityEngine)
        {

            var pListMonsterModels = pGameSettings.MonsterModels;
            if (pListMonsterModels.Valid())
            {
                foreach (var monsterModel in pListMonsterModels.AsEnumerable())
                {
                    if (TryGetUnitySpriteImageData(nameof(BattleMonsterModel), monsterModel, unityEngine, out var imageData))
                    {
                        yield return imageData;
                    }
                }
            }

            var pListPersonaModels = pGameSettings.PersonaModels;
            if (pListPersonaModels.Valid())
            {
                foreach (var monsterModel in pListPersonaModels.AsEnumerable())
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
                var pViewData = monsterModel.ViewPrefab;
                if (pViewData.Valid())
                {
                    var pPreview = pViewData.MonsterPreview;
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

        public static GameSkillDisplayDTO[] GetListSkillDisplay(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings)
        {
            SortedSet<GameSkillDisplayDTO> skillSet = new(Comparer<GameSkillDisplayDTO>.Create(static (l, r) => l.ObjectId.CompareTo(r.ObjectId)));
            var pListMonsterModels = pGameSettings.MonsterModels;
            foreach (var skill in GetListGameSkillDisplay(pListMonsterModels))
            {
                skillSet.Add(skill);
            }
            var pListPersonaModels = pGameSettings.PersonaModels;
            foreach (var skill in GetListGameSkillDisplay(pListPersonaModels))
            {
                skillSet.Add(skill);
            }

            return [.. skillSet];

            static IEnumerable<GameSkillDisplayDTO> GetListGameSkillDisplay(PMonoList_S<BattleMonsterModel.Ptr_BattleMonsterModel> pListMonsterModels)
            {

                if (pListMonsterModels.Valid())
                {
                    foreach (var monsterModel in pListMonsterModels.AsEnumerable())
                    {
                        var pListSkills = monsterModel.Skills;
                        if (pListSkills.Valid())
                        {
                            foreach (var skill in pListSkills.AsEnumerable())
                            {
                                if (skill.Valid())
                                {
                                    var pSkillInfo = skill.SkillInfo;
                                    if (pSkillInfo.Valid())
                                    {
                                        var uid = pSkillInfo.UID.ToString()!;
                                        var atts = new GameValueInfoDTO[]
                                        {
                                            new(){ ObjectId = "Level", DisplayName = "Level", DisplayValue = skill.Level.ToString() },
                                            new(){ ObjectId = "StartLevel", DisplayName = "StartLevel", DisplayValue = pSkillInfo.StartLevel.ToString() },
                                            new(){ ObjectId = "EndLevel", DisplayName = "EndLevel", DisplayValue = pSkillInfo.EndLevel.ToString() },
                                        };
                                        yield return new GameSkillDisplayDTO()
                                        {
                                            ObjectId = uid,
                                            DisplayName = pSkillInfo.ItemName.GET_VALUE().ToString(),
                                            DisplayCategory = nameof(Skill),
                                            DisplayDesc = pSkillInfo.Description.GET_VALUE().ToString(),
                                            SkillAttributes = atts
                                        };
                                    }
                                }
                            }
                        }


                    }
                }
            }


        }
        public static IEnumerable<UnitySpriteImageData> GetListSkillIcon(this BloomtownGameContext @this, GameSettings.Ptr_GameSettings pGameSettings, UnityEngineContext unityEngine)
        {

            var pListMonsterModels = pGameSettings.MonsterModels;
            if (pListMonsterModels.Valid())
            {
                foreach (var monsterModel in pListMonsterModels.AsEnumerable())
                {
                    foreach (var image in GetUnitySpriteImageData(monsterModel.Skills, unityEngine, nameof(BattleMonsterModel)))
                    {
                        yield return image;
                    }
                }
            }

            var pListPersonaModels = pGameSettings.PersonaModels;
            if (pListPersonaModels.Valid())
            {
                foreach (var monsterModel in pListPersonaModels.AsEnumerable())
                {
                    foreach (var image in GetUnitySpriteImageData(monsterModel.Skills, unityEngine, nameof(PersonaProgress)))
                    {
                        yield return image;
                    }
                }
            }

            static IEnumerable<UnitySpriteImageData> GetUnitySpriteImageData(PMonoList_S<Skill.Ptr_Skill> pListSkills, UnityEngineContext unityEngine, string category)
            {

                if (pListSkills.Valid())
                {
                    foreach (var skill in pListSkills.AsEnumerable())
                    {
                        var pSkillInfo = skill.SkillInfo;
                        if (pSkillInfo.Valid())
                        {
                            var pIcon = pSkillInfo.GET_ICON_00();
                            if (pIcon.Valid())
                            {
                                var pIconPng = unityEngine.ReadSprite2Png(pIcon);
                                if (pIconPng.Valid())
                                {
                                    yield return new UnitySpriteImageData() { Category = category, Name = pSkillInfo.UID.ToString(), ImageData = pIconPng };
                                }
                            }
                        }
                    }
                }

            }

        }


        public static void DebugAddPersona(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData)
        {

            var pGameSettings = pPlayerData.GameSettings;
            if (pGameSettings.Valid() == false)
            {
                return;
            }
            var pListPersonaModels = pGameSettings.PersonaModels;
            if (pListPersonaModels.Valid() == false)
            {
                return;
            }
            if (pListPersonaModels.Size <= 0)
            {
                return;
            }
            ref var ref_first = ref pListPersonaModels[0];
            var first_val = ref_first;
            try
            {
                foreach (var personaModel in pListPersonaModels.AsEnumerable())
                {
                    ref_first = personaModel;
                    pPlayerData.DEBUG_ADD_PERSONA();
                }
            }
            finally
            {
                ref_first = first_val;
            }

            @this.ShowMessage("DebugAddPersona ok");
        }
        public static void DebugAddPersonaEx(this BloomtownGameContext @this, PlayerData.Ptr_PlayerData pPlayerData)
        {

            var pGameSettings = pPlayerData.GameSettings;
            if (pGameSettings.Valid() == false)
            {
                return;
            }

            var pListMonsterModels = pGameSettings.MonsterModels;
            if (pListMonsterModels.Valid() == false)
            {
                return;
            }
            var first = pListMonsterModels.AsEnumerable().Where(static p =>
            {
                var role = p.MonsterRole;
                if (role == MonsterRole.Boss || role == MonsterRole.Elite)
                {
                    var pSkills = p.Skills;
                    return pSkills.Valid() && pSkills.Size > 0;
                }
                return false;
            }).FirstOrDefault();
            if (first.Valid() == false)
            {
                return;
            }

            var pPlayerCharacter = pPlayerData.Player;
            if (pPlayerCharacter.Valid() == false)
            {
                return;
            }
            var pPlayerModel = pPlayerCharacter.PlayerModel;
            if (pPlayerModel.Valid() == false)
            {
                return;
            }
            var pDefaultPersona = pPlayerModel.DefaultPersona;
            if (pDefaultPersona.Valid() == false)
            {
                return;
            }
            pDefaultPersona.Skills = first.Skills;

            @this.ShowMessage("DebugAddPersonaEx ok");

        }

    }
}
