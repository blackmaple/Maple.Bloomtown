using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Maple.Bloomtown.Metadata.Environment;
using Maple.MonoGameAssistant.Windows.UITask;

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
            => UnityEngineContext_Bloomtown.Create(this.RuntimeContext, this.Logger);

        protected sealed override GameSwitchDisplayDTO[] InitListGameSwitch()
        {
            return [];// return Enumerable.Range(0, 10).Select(p => new GameSwitchDisplayDTO { ObjectId = p.ToString(), DisplayName = $"DisplayName_{p}", DisplayDesc = $"DisplayDesc_{p}", SwitchValue = false }).ToArray();
        }
        #endregion



        #region  WebApi
        bool TryGetGameResource(string category, string fileName, [MaybeNullWhen(false)] out string url)
        {
            Unsafe.SkipInit<string>(out url);
            var webRootPath = this.GameSettings.WebRootPath;
            if (string.IsNullOrEmpty(webRootPath))
            {
                return false;
            }

            string text = Path.Combine(webRootPath, "GameResource");
            if (!Directory.Exists(text))
            {
                return false;
            }

            string text2 = Path.Combine(text, category);
            if (!Directory.Exists(text2))
            {
                return false;
            }

            string text3 = Path.Combine(text2, fileName);
            if (!File.Exists(text3))
            {
                return false;
            }

            url = text3.Replace(webRootPath, string.Empty).Replace("\\", "/");
            return true;
        }
        void FillGameResourceUrlImp<T>(Func<T, string>? getName, params ReadOnlySpan<T> displayDTOs)
            where T : GameObjectDisplayDTO
        {
            foreach (var data in displayDTOs)
            {
                if (TryGetGameResource(data.DisplayCategory!, getName is not null ? getName(data) : $"{data.ObjectId}.png", out var url))
                {
                    data.DisplayImage = url;
                }
            }
        }
        void FillGameResourceUrl(Func<GameObjectDisplayDTO, string>? getName, GameObjectDisplayDTO[]? displayDTOs)
        {
            FillGameResourceUrlImp(getName, displayDTOs);
        }
        void FillGameResourceUrl(Func<GameObjectDisplayDTO, string>? getName, GameObjectDisplayDTO displayDTOs)
        {
            FillGameResourceUrlImp(getName, displayDTOs);
        }

        public required ListGeneric ListPersonaProgress { get; set; }

        #region GameEnvironment
        protected sealed override async ValueTask LoadGameDataAsync()
        {
            this.ListPersonaProgress = await this.MonoTaskAsync(p => p.GetListPersonaProgress()).ConfigureAwait(false) ?? throw new GameException("ERR LoadGameDataAsync");
        }

        private Task<BloomtownGameEnvironment> GetGameEnvironmentAsync()
        {
            return this.MonoTaskAsync(context => context.GetBloomtownGameEnvironment());
        }
        private async Task<BloomtownGameEnvironment> GetGameEnvironmentThrowIfNotInGameAsync()
        {
            BloomtownGameEnvironment gameEnvironment = await GetGameEnvironmentAsync().ConfigureAwait(false);
            if (gameEnvironment.InGame())
            {
                return gameEnvironment;
            }
            return GameException.ThrowIfNotLoaded<BloomtownGameEnvironment>();
        }
        #endregion

        #region LoadResourceAsync
        public sealed override async ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            if (this.UnityEngineContext is null)
            {
                return GameException.Throw<GameSessionInfoDTO>($"NOT LOADED:{nameof(Maple.MonoGameAssistant.UnityCore.UnityEngine.UnityEngineContext)}");
            }
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
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
        #endregion

        #region Currency
        public sealed override async ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            var datas = await this.MonoTaskAsync(static (context) => context.GetListCurrencyDisplay()).ConfigureAwait(false);
            FillGameResourceUrl(data => $"{data.ObjectId}Icon.png", datas);
            return datas;
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.GetCurrencyInfo(args.currencyObjectDTO), (gameEnvironment, currencyObjectDTO)).ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (context, args) => args.gameEnvironment.UpdateCurrencyInfo(args.currencyModifyDTO), (gameEnvironment, currencyModifyDTO)).ConfigureAwait(false);
            return data;
        }
        #endregion

        #region Inventory

        public sealed override async ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, gameEnvironment) => gameEnvironment.GetListInventoryDisplay().ToArray(), gameEnvironment).ConfigureAwait(false);
            FillGameResourceUrl(default, datas);

            return datas;


        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.GetInventoryInfo(args.inventoryObjectDTO), (gameEnvironment, inventoryObjectDTO)).ConfigureAwait(false);
            return data;
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var data = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.UpdateInventoryInfo(args.inventoryObjectDTO), (gameEnvironment, inventoryObjectDTO)).ConfigureAwait(false);
            return data;
        }
        #endregion

        #region Character

        public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, gameEnvironment) => gameEnvironment.GetListCharacterDisplay().ToArray(), gameEnvironment).ConfigureAwait(false);
            FillGameResourceUrl(default, datas);

            return datas;
        }

        public sealed override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.GetCharacterStatus(args.characterObjectDTO), (gameEnvironment, characterObjectDTO)).ConfigureAwait(false);
            return datas;
        }
        public sealed override async ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.UpdateCharacterStatus(args.characterModifyDTO), (gameEnvironment, characterModifyDTO)).ConfigureAwait(false);
            return datas;

        }

        public sealed override async ValueTask<GameCharacterSkillDTO> GetCharacterSkillAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.GetCharacterSkill(args.characterObjectDTO), (gameEnvironment, characterObjectDTO)).ConfigureAwait(false);
            FillGameResourceUrl(default, datas.SkillInfos);

            return datas;
        }
        public sealed override async ValueTask<GameCharacterSkillDTO> UpdateCharacterSkillAsync(GameCharacterModifyDTO characterModifyDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.UpdateCharacterSkill(args.characterModifyDTO), (gameEnvironment, characterModifyDTO)).ConfigureAwait(false);
            FillGameResourceUrl(default, datas.SkillInfos);

            return datas;

        }

        public sealed override async ValueTask<GameCharacterEquipmentDTO> GetCharacterEquipmentAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.GetCharacterEquipment(args.characterObjectDTO), (gameEnvironment, characterObjectDTO)).ConfigureAwait(false);
            FillGameResourceUrl(default, datas.EquipmentInfos);
            return datas;

        }
        public sealed override async ValueTask<GameCharacterEquipmentDTO> UpdateCharacterEquipmentAsync(GameCharacterModifyDTO characterModifyDTO)
        {

            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.UpdateCharacterEquipment(args.characterModifyDTO), (gameEnvironment, characterModifyDTO)).ConfigureAwait(false);
            FillGameResourceUrl(default, datas.EquipmentInfos);
            return datas;
        }
        #endregion

        #region Monster
        public sealed override async ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, gameEnvironment) => gameEnvironment.GetListMonsterDisplay().ToArray(), gameEnvironment).ConfigureAwait(false);
            FillGameResourceUrl(default, datas);
            return datas;

        }

        public sealed override async ValueTask<GameCharacterSkillDTO> AddMonsterMemberAsync(GameMonsterObjectDTO monsterObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.AddMonsterMember(args.monsterObjectDTO), (gameEnvironment, monsterObjectDTO)).ConfigureAwait(false);
            FillGameResourceUrl(default, datas.SkillInfos);
            return datas;
        }
        #endregion

        #region Skill

        public sealed override async ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            var datas = await this.MonoTaskAsync(static (_, gameEnvironment) => gameEnvironment.GetListSkillDisplay().ToArray(), gameEnvironment).ConfigureAwait(false);
            FillGameResourceUrl(default, datas);
            return datas;

        }

        //public sealed override async ValueTask<GameSkillDisplayDTO> AddSkillDisplayAsync(GameSkillObjectDTO gameSkillObject)
        //{
        //    var gameEnvironment = await this.GetGameEnvironmentThrowIfNotInGameAsync().ConfigureAwait(false);
        //    if (gameEnvironment.InFight())
        //    {
        //        return GameException.Throw<GameSkillDisplayDTO>("Error:In Fight");
        //    }
        //    var datas = await this.MonoTaskAsync(static (_, args) => args.gameEnvironment.AddSkillDisplay(args.gameSkillObject), (gameEnvironment, gameSkillObject)).ConfigureAwait(false);
        //    FillGameResourceUrl(default, datas);
        //    return datas;
        //}
        #endregion

        #endregion

    }


}
