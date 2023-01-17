namespace XIVLauncher2.Common.Addon
{
    public interface IAddon
    {
        string Name { get; }

        void Setup(int gamePid);
    }
}
