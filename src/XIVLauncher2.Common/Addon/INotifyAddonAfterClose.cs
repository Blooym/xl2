namespace XIVLauncher2.Common.Addon
{
    interface INotifyAddonAfterClose : IAddon
    {
        void GameClosed();
    }
}
