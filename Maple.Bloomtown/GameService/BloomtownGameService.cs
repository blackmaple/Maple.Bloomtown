using Maple.Bloomtown.GameModel.Demo;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameContext;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UITask;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;


namespace Maple.Bloomtown
{
    internal sealed partial class BloomtownGameService(ILogger<BloomtownGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<BloomtownGameContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)
    {

        #region LoadService

        //   protected sealed override bool EnableService => false;

        protected sealed override BloomtownGameContext LoadGameContext()
            => BloomtownGameContext.LoadGameContext(this.RuntimeContext, EnumMonoCollectorTypeVersion.APP, this.Logger);
        protected sealed override UnityEngineContext LoadUnityEngineContext()
            => default!;// new UnityEngineContext_Bloomtown(this.RuntimeContext, this.Logger);

        protected sealed override GameSwitchDisplayDTO[] InitListGameSwitch()
        {
            return Enumerable.Range(0, 10).Select(p => new GameSwitchDisplayDTO { ObjectId = p.ToString(), DisplayName = $"DisplayName_{p}", DisplayDesc = $"DisplayDesc_{p}", SwitchValue = false }).ToArray();
        }
        #endregion

        #region KeyDown
        protected sealed override async ValueTask F5_KeyDown()
        {
            var pGameSettings = await this.MonoTaskAsync((context) => context.GetGameSettings()).ConfigureAwait(false);
            if (pGameSettings.Valid())
            {
                var gameIcons = await this.UITaskAsync((context, args)
                => context.GetListGameSettingsIcon(args.pGameSettings, args.UnityEngineContext).ToArray(),
                (pGameSettings, this.UnityEngineContext)).ConfigureAwait(false);

                foreach (var gameIcon in gameIcons)
                {
                    this.GameSettings.WriteImageFile(gameIcon.ImageData.AsReadOnlySpan(), gameIcon.Category, $"{gameIcon.Name}.png");
                }


                var monsterIcons = await this.UITaskAsync((context, args)
                        => context.GetListMonsterIcon(args.pGameSettings, args.UnityEngineContext).ToArray(),
                        (pGameSettings, this.UnityEngineContext)).ConfigureAwait(false);

                foreach (var monsterIcon in monsterIcons)
                {
                    this.GameSettings.WriteImageFile(monsterIcon.ImageData.AsReadOnlySpan(), monsterIcon.Category, $"{monsterIcon.Name}.png");
                }


                var skillIcons = await this.UITaskAsync((context, args)
                  => context.GetListSkillIcon(args.pGameSettings, args.UnityEngineContext).ToArray(),
                  (pGameSettings, this.UnityEngineContext)).ConfigureAwait(false);
                foreach (var skillIcon in skillIcons)
                {
                    this.GameSettings.WriteImageFile(skillIcon.ImageData.AsReadOnlySpan(), skillIcon.Category, $"{skillIcon.Name}.png");
                }

                var inventoryIcons = await this.UITaskAsync((context, args)
                  => context.GetListInventoryIcon(args.pGameSettings, args.UnityEngineContext).ToArray(),
                  (pGameSettings, this.UnityEngineContext)).ConfigureAwait(false);
                foreach (var inventoryIcon in inventoryIcons)
                {
                    this.GameSettings.WriteImageFile(inventoryIcon.ImageData.AsReadOnlySpan(), inventoryIcon.Category, $"{inventoryIcon.Name}.png");
                }




            }


            var pPlayerData = await this.MonoTaskAsync(context => context.GetPlayerData()).ConfigureAwait(false);
            if (pPlayerData.Valid())
            {
                var playerIcons = await this.UITaskAsync((context, args)
                    => context.GetListCharacterIcon(args.pPlayerData, args.UnityEngineContext).ToArray(),
                    (pPlayerData, this.UnityEngineContext)).ConfigureAwait(false);
                foreach (var playerIcon in playerIcons)
                {
                    this.GameSettings.WriteImageFile(playerIcon.ImageData.AsReadOnlySpan(), playerIcon.Category, $"{playerIcon.Name}.png");
                }

            }

        }
        #endregion

        #region  WebApi

        private async Task<PlayerData.Ptr_PlayerData> GetGamePlayerDataAsync()
        {
            var data = await this.MonoTaskAsync(context => context.GetPlayerData()).ConfigureAwait(false);
            return data.Valid() ? data : GameException.Throw<PlayerData.Ptr_PlayerData>("Please enter the game first!");
        }
        private async Task<GameSettings.Ptr_GameSettings> GetGameSettingsAsync()
        {
            var data = await this.MonoTaskAsync(context => context.GetGameSettings()).ConfigureAwait(false);
            return data.Valid() ? data : GameException.Throw<GameSettings.Ptr_GameSettings>("Please enter the game first!");
        }


        public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var gameSettings = await this.GetGameSettingsAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (context, data) => context.GetListCharacterDisplay(data).ToArray(), gameSettings).ConfigureAwait(false);
            foreach (var data in datas)
            {
                if (this.GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, $"{data.ObjectId}.png", out var url))
                {
                    data.DisplayImage = url;
                }
            }
            return datas;


        }
        public sealed override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (context, args) => context.GetCharacterStatus(args.playerData, args.characterObjectDTO), (playerData, characterObjectDTO)).ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (context, args) => context.GetCharacterEquipment(args.playerData, args.characterObjectDTO), (playerData, characterObjectDTO)).ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (context, args) => context.GetCharacterSkill(args.playerData, args.characterObjectDTO), (playerData, characterObjectDTO)).ConfigureAwait(false);
            return data;
        }

        public sealed override async ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            var gameSettings = await this.GetGameSettingsAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (context, data) => context.GetListMonsterDisplay(data).ToArray(), gameSettings).ConfigureAwait(false);
            foreach (var data in datas)
            {
                if (this.GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, $"{data.ObjectId}.png", out var url))
                {
                    data.DisplayImage = url;
                }
            }
            return datas;

        }
        public sealed override async ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            var gameSettings = await this.GetGameSettingsAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (context, data) => context.GetListSkillDisplay(data).ToArray(), gameSettings).ConfigureAwait(false);
            foreach (var data in datas)
            {
                if (this.GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, $"{data.ObjectId}.png", out var url))
                {
                    data.DisplayImage = url;
                }
            }
            return datas;

        }


        public sealed override async ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            var gameSettings = await this.GetGameSettingsAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (context, data) => context.GetListCurrencyDisplay(), gameSettings).ConfigureAwait(false);
            foreach (var data in datas)
            {
                if (this.GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, $"{data.ObjectId}Icon.png", out var url))
                {
                    data.DisplayImage = url;
                }
            }
            return datas;
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (context, args) => context.GetCurrencyInfo(args.playerData, args.currencyObjectDTO), (playerData, currencyObjectDTO)).ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (context, args) => context.UpdateCurrencyInfo(args.playerData, args.currencyModifyDTO), (playerData, currencyModifyDTO)).ConfigureAwait(false);
            return data;
        }


        public sealed override async ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var gameSettings = await this.GetGameSettingsAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (context, data) => context.GetListInventoryDisplay(data).ToArray(), gameSettings).ConfigureAwait(false);
            foreach (var data in datas)
            {
                if (this.GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, $"{data.ObjectId}.png", out var url))
                {
                    data.DisplayImage = url;
                }
            }
            return datas;


        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (context, args) => context.GetInventoryInfo(args.playerData, args.inventoryObjectDTO), (playerData, inventoryObjectDTO)).ConfigureAwait(false);
            return data;

        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (context, args) => context.UpdateInventoryInfo(args.playerData, args.inventoryObjectDTO), (playerData, inventoryObjectDTO)).ConfigureAwait(false);
            return data;
        }




        //public sealed override ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        //{

        //}

        public sealed override ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
        => GameException.Throw<ValueTask<GameSwitchDisplayDTO>>("NotImplemented");



        #endregion

    }


}
