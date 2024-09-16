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
            =>  new UnityEngineContext_Bloomtown(this.RuntimeContext, this.Logger);

        protected sealed override GameSwitchDisplayDTO[] InitListGameSwitch()
        {
            return Enumerable.Range(0, 10).Select(p => new GameSwitchDisplayDTO { ObjectId = p.ToString(), DisplayName = $"DisplayName_{p}", DisplayDesc = $"DisplayDesc_{p}", SwitchValue = false }).ToArray();
        }
        #endregion

        #region KeyDown
        //protected sealed override async ValueTask F5_KeyDown()
        //{
        //    //var pGameSettings = await this.MonoTaskAsync((context) => context.GetGameSettings()).ConfigureAwait(false);
        //    //if (pGameSettings.Valid())
        //    //{
        //    //    var gameIcons = await this.UITaskAsync((context, args)
        //    //    => context.GetListGameSettingsIcon(args.pGameSettings, args.UnityEngineContext).ToArray(),
        //    //    (pGameSettings, this.UnityEngineContext)).ConfigureAwait(false);

        //    //    foreach (var gameIcon in gameIcons)
        //    //    {
        //    //        this.GameSettings.WriteImageFile(gameIcon.ImageData.AsReadOnlySpan(), gameIcon.Category, $"{gameIcon.Name}.png");
        //    //    }


        //    //    var monsterIcons = await this.UITaskAsync((context, args)
        //    //            => context.GetListMonsterIcon(args.pGameSettings, args.UnityEngineContext).ToArray(),
        //    //            (pGameSettings, this.UnityEngineContext)).ConfigureAwait(false);

        //    //    foreach (var monsterIcon in monsterIcons)
        //    //    {
        //    //        this.GameSettings.WriteImageFile(monsterIcon.ImageData.AsReadOnlySpan(), monsterIcon.Category, $"{monsterIcon.Name}.png");
        //    //    }


        //    //    var skillIcons = await this.UITaskAsync((context, args)
        //    //      => context.GetListSkillIcon(args.pGameSettings, args.UnityEngineContext).ToArray(),
        //    //      (pGameSettings, this.UnityEngineContext)).ConfigureAwait(false);
        //    //    foreach (var skillIcon in skillIcons)
        //    //    {
        //    //        this.GameSettings.WriteImageFile(skillIcon.ImageData.AsReadOnlySpan(), skillIcon.Category, $"{skillIcon.Name}.png");
        //    //    }

        //    //    var inventoryIcons = await this.UITaskAsync((context, args)
        //    //      => context.GetListInventoryIcon(args.pGameSettings, args.UnityEngineContext).ToArray(),
        //    //      (pGameSettings, this.UnityEngineContext)).ConfigureAwait(false);
        //    //    foreach (var inventoryIcon in inventoryIcons)
        //    //    {
        //    //        this.GameSettings.WriteImageFile(inventoryIcon.ImageData.AsReadOnlySpan(), inventoryIcon.Category, $"{inventoryIcon.Name}.png");
        //    //    }




        //    //}


        //    //var pPlayerData = await this.MonoTaskAsync(context => context.GetPlayerData()).ConfigureAwait(false);
        //    //if (pPlayerData.Valid())
        //    //{
        //    //    var playerIcons = await this.UITaskAsync((context, args)
        //    //        => context.GetListCharacterIcon(args.pPlayerData, args.UnityEngineContext).ToArray(),
        //    //        (pPlayerData, this.UnityEngineContext)).ConfigureAwait(false);
        //    //    foreach (var playerIcon in playerIcons)
        //    //    {
        //    //        this.GameSettings.WriteImageFile(playerIcon.ImageData.AsReadOnlySpan(), playerIcon.Category, $"{playerIcon.Name}.png");
        //    //    }

        //    //}

        //}
        #endregion

        #region  WebApi

        private Task<BloomtownGameEnvironment> GetBloomtownGameEnvironmentAsync()
        {
            return this.MonoTaskAsync(context => context.GetBloomtownGameEnvironment());
        }
        private async Task<BloomtownGameEnvironment> GetBloomtownGameEnvironmentThrowIfNotInGameAsync()
        {
            BloomtownGameEnvironment gameEnvironment = await GetBloomtownGameEnvironmentAsync().ConfigureAwait(false);
            if (gameEnvironment.InGame())
            {
                return gameEnvironment;
            }
            return GameException.ThrowIfNotLoaded<BloomtownGameEnvironment>();
        }

        public sealed override async ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            if (this.UnityEngineContext is null)
            {
                return GameException.Throw<GameSessionInfoDTO>($"NOT LOADED:{nameof(Maple.MonoGameAssistant.UnityCore.UnityEngine.UnityEngineContext)}");
            }
            var gameEnvironment = await this.GetBloomtownGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var taskGameSettingsIcon = this.UITaskAsync((_, args) => args.gameEnvironment.GetListGameSettingsIcon(args.UnityEngineContext).ToArray(), (gameEnvironment, this.UnityEngineContext)).AsTask();
            var taskListCharacterIcon = this.UITaskAsync((_, args) => args.gameEnvironment.GetListCharacterIcon(args.UnityEngineContext).ToArray(), (gameEnvironment, this.UnityEngineContext)).AsTask();
            var taskListInventoryIcon = this.UITaskAsync((_, args) => args.gameEnvironment.GetListInventoryIcon(args.UnityEngineContext).ToArray(), (gameEnvironment, this.UnityEngineContext)).AsTask();
            var taskListMonsterIcon = this.UITaskAsync((_, args) => args.gameEnvironment.GetListMonsterIcon(args.UnityEngineContext).ToArray(), (gameEnvironment, this.UnityEngineContext)).AsTask();
            var taskListSkillIcon = this.UITaskAsync((_, args) => args.gameEnvironment.GetListSkillIcon(args.UnityEngineContext).ToArray(), (gameEnvironment, this.UnityEngineContext)).AsTask();
            await foreach (var listIcon in Task.WhenEach(taskGameSettingsIcon, taskListCharacterIcon, taskListInventoryIcon, taskListMonsterIcon, taskListSkillIcon).ConfigureAwait(false))
            {
                foreach (var iconData in await listIcon.ConfigureAwait(false))
                {
                    this.GameSettings.WriteImageFile(iconData.ImageData.AsSpan(), iconData.Category!, $"{iconData.Name}.png");
                }
            }
            return await this.GetSessionInfoAsync().ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            var datas = await this.MonoTaskAsync(static (context) => context.GetListCurrencyDisplay()).ConfigureAwait(false);
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
            var gameEnvironment = await this.GetBloomtownGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.GetCurrencyInfo(args.currencyObjectDTO), (gameEnvironment, currencyObjectDTO)).ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameEnvironment = await this.GetBloomtownGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (context, args) => args.gameEnvironment.UpdateCurrencyInfo(args.currencyModifyDTO), (gameEnvironment, currencyModifyDTO)).ConfigureAwait(false);
            return data;
        }


        public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var gameEnvironment = await this.GetBloomtownGameEnvironmentAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, gameEnvironment) => gameEnvironment.GetListCharacterDisplay().ToArray(), gameEnvironment).ConfigureAwait(false);
            foreach (var data in datas)
            {
                if (this.GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, $"{data.ObjectId}.png", out var url))
                {
                    data.DisplayImage = url;
                }
            }
            return datas;
        }
        public sealed override async ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var gameEnvironment = await this.GetBloomtownGameEnvironmentAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, gameEnvironment) => gameEnvironment.GetListInventoryDisplay().ToArray(), gameEnvironment).ConfigureAwait(false);
             foreach (var data in datas)
            {
                if (this.GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, $"{data.ObjectId}.png", out var url))
                {
                    data.DisplayImage = url;
                }
            }
            return datas;


        }
        public sealed override async ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            var gameEnvironment = await this.GetBloomtownGameEnvironmentAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, gameEnvironment) => gameEnvironment.GetListMonsterDisplay().ToArray(), gameEnvironment).ConfigureAwait(false);
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
            var gameEnvironment = await this.GetBloomtownGameEnvironmentAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, gameEnvironment) => gameEnvironment.GetListSkillDisplay().ToArray(), gameEnvironment).ConfigureAwait(false);
            foreach (var data in datas)
            {
                if (this.GameSettings.TryGetGameResourceUrl(data.DisplayCategory!, $"{data.ObjectId}.png", out var url))
                {
                    data.DisplayImage = url;
                }
            }
            return datas;

        }

        //public sealed override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        //{
        //    var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
        //    var data = await this.MonoTaskAsync(static (context, args) => context.GetCharacterStatus(args.playerData, args.characterObjectDTO), (playerData, characterObjectDTO)).ConfigureAwait(false);
        //    return data;
        //}
        //public sealed override async ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
        //{
        //    var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
        //    var data = await this.MonoTaskAsync(static (context, args) => context.GetCharacterEquipment(args.playerData, args.characterObjectDTO), (playerData, characterObjectDTO)).ConfigureAwait(false);
        //    return data;
        //}
        //public sealed override async ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
        //{
        //    var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
        //    var data = await this.MonoTaskAsync(static (context, args) => context.GetCharacterSkill(args.playerData, args.characterObjectDTO), (playerData, characterObjectDTO)).ConfigureAwait(false);
        //    return data;
        //}






        //public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        //{
        //    var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
        //    var data = await this.MonoTaskAsync(static (context, args) => context.GetInventoryInfo(args.playerData, args.inventoryObjectDTO), (playerData, inventoryObjectDTO)).ConfigureAwait(false);
        //    return data;

        //}
        //public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        //{
        //    var playerData = await this.GetGamePlayerDataAsync().ConfigureAwait(false);
        //    var data = await this.MonoTaskAsync(static (context, args) => context.UpdateInventoryInfo(args.playerData, args.inventoryObjectDTO), (playerData, inventoryObjectDTO)).ConfigureAwait(false);
        //    return data;
        //}




        ////public sealed override ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        ////{

        ////}

        //public sealed override ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
        //=> GameException.Throw<ValueTask<GameSwitchDisplayDTO>>("NotImplemented");



        #endregion

    }


}
