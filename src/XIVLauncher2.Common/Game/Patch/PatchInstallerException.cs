using System;

namespace XIVLauncher2.Common.Game.Patch;

public class PatchInstallerException : Exception
{
    public PatchInstallerException(string message, Exception? inner = null) : base(message, inner)
    {
        // ignored
    }
}
