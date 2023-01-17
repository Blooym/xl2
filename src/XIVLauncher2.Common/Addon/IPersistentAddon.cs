namespace XIVLauncher2.Common.Addon
{
    interface IPersistentAddon : IAddon
    {
        void DoWork(object state);
    }
}
