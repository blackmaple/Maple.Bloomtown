using Maple.Bloomtown.GameModel.Demo;
using Maple.MonoGameAssistant.GameDTO;
using static Maple.Bloomtown.GameDisplayExtensions;

namespace Maple.Bloomtown
{
    internal sealed class BloomtownGameEnvironment
    {
        public BloomtownGameContext Context { get; }
        // UIManager.Ptr_UIManager Ptr_UIManager { get; }
        public PopUpMessage.Ptr_PopUpMessage Ptr_PopUpMessage { get; }
        public StatsSync.Ptr_StatsSync Ptr_StatsSync { get; }
        public GameSettings.Ptr_GameSettings Ptr_GameSettings { get; }
        public PlayerData.Ptr_PlayerData Ptr_PlayerData { get; }

        public GameManager.Ptr_GameManager Ptr_GameManager { get; }

        public MessageManager.Ptr_MessageManager Ptr_MessageManager { get; }
        public BattleManager.Ptr_BattleManager Ptr_BattleManager { get; }
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
            this.Ptr_GameManager = gameContext.GameManager.INSTANCE;

            this.Ptr_BattleManager = gameContext.BattleManager.INSTANCE;
            this.Ptr_MessageManager = gameContext.MessageManager.INSTANCE;
        }

        public bool InGame()
        {
            return this.Ptr_PlayerData.Valid() && this.Ptr_PlayerData.M_CACHED_PTR != nint.Zero;
        }

        public bool InFight()
        {
            return this.Ptr_BattleManager.FIGHT_ACTIVE && this.Ptr_BattleManager.M_FIGHT_ENDED == false;
        }

        public void PopUpMessage(string? msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            using var pMonoString = this.Context.T2(msg);
            this.Ptr_PopUpMessage.SHOW_MESSAGE(pMonoString);
        }

        public void ShowMessage(string? msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return;
            }
            using var pMonoString = this.Context.T2(msg);
            this.Ptr_MessageManager.SHOW_TEXT_01(pMonoString, new MonoGameAssistant.RawDotNet.REF_MONO_VECTOR3(), TextTypes.Damage);
        }

        public static string? L(nint uid)
        {
            return LocalizationManager.Ptr_LocalizationManager.L(uid).ToString();
        }
    }






    public static class GameDisplayExtensions
    {
        public interface IGameDisplay
        {
            public string GetObjectId();
            public string? GetDisplayName();
            public string? GetDisplayDesc();

        }


        public static T_OBJ ConvertGameDisplay<T_PTR, T_OBJ>(
           this T_PTR @this, string category,
            Func<T_PTR, string?>? displayName,
            Func<T_PTR, string?>? displayDesc)
            where T_PTR : unmanaged, IGameDisplay
            where T_OBJ : GameObjectDisplayDTO, new()
        {
            return new T_OBJ()
            {
                ObjectId = @this.GetObjectId(),
                DisplayCategory = category,
                DisplayName = displayName is null ? @this.GetDisplayName() : displayName(@this),
                DisplayDesc = displayDesc is null ? @this.GetDisplayDesc() : displayDesc(@this)
            };
        }

        public static T_OBJ ConvertGameDisplay<T_PTR, T_OBJ>(
           this T_PTR @this, string category)
            where T_PTR : unmanaged, IGameDisplay
            where T_OBJ : GameObjectDisplayDTO, new()
        {
            return new T_OBJ()
            {
                ObjectId = @this.GetObjectId(),
                DisplayCategory = category,
                DisplayName = @this.GetDisplayName(),
                DisplayDesc = @this.GetDisplayDesc(),
            };
        }

        public static T_OBJ[] GetListGameDisplay<T_PTR, T_OBJ>(
            this ReadOnlySpan<T_PTR> @this,
            string category,
            Func<T_PTR, string?>? displayName,
            Func<T_PTR, string?>? displayDesc)
            where T_PTR : unmanaged, IGameDisplay
            where T_OBJ : GameObjectDisplayDTO, new()
        {
            var size = @this.Length;
            var objs = new T_OBJ[size];
            for (int i = 0; i < size; i++)
            {
                objs[i] = ConvertGameDisplay<T_PTR, T_OBJ>(@this[i], category, displayName, displayDesc);
            }
            return objs;
        }

        public static T_OBJ[] GetListGameDisplay<T_PTR, T_OBJ>(
            this ReadOnlySpan<T_PTR> @this,
            string category)
            where T_PTR : unmanaged, IGameDisplay
            where T_OBJ : GameObjectDisplayDTO, new()

        {
            var size = @this.Length;
            var objs = new T_OBJ[size];
            for (int i = 0; i < size; i++)
            {
                objs[i] = ConvertGameDisplay<T_PTR, T_OBJ>(@this[i], category);
            }
            return objs;
        }

        #region GameInventoryDisplayDTO
        public static GameInventoryDisplayDTO ConvertGameInventoryDisplay<T_PTR>(
            this T_PTR @this, string category,
            Func<T_PTR, string?>? displayName,
            Func<T_PTR, string?>? displayDesc)
            where T_PTR : unmanaged, IGameDisplay

        {
            return new GameInventoryDisplayDTO()
            {
                ObjectId = @this.GetObjectId(),
                DisplayCategory = category,
                DisplayName = displayName is null ? @this.GetDisplayName() : displayName(@this),
                DisplayDesc = displayDesc is null ? @this.GetDisplayDesc() : displayDesc(@this)
            };
        }

        public static GameInventoryDisplayDTO[] GetListGameInventoryDisplay<T_PTR>(
            this scoped ReadOnlySpan<T_PTR> @this,
            string category,
            Func<T_PTR, string?>? displayName,
            Func<T_PTR, string?>? displayDesc)
            where T_PTR : unmanaged, IGameDisplay
        {

            var size = @this.Length;
            var objs = new GameInventoryDisplayDTO[size];

            for (int i = 0; i < size; i++)
            {
                objs[i] = ConvertGameInventoryDisplay(@this[i], category, displayName, displayDesc);
            }
            return objs;
        }

        #endregion

    }






}
