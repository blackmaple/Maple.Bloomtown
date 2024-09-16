using Maple.Bloomtown.GameModel.Demo;

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
