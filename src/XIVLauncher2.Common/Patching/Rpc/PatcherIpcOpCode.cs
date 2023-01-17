namespace XIVLauncher2.Common.PatcherIpc
{
    public enum PatcherIpcOpCode
    {
        Hello,
        Bye,
        StartInstall,
        InstallRunning,
        InstallOk,
        InstallFailed,
        Finish
    }
}
