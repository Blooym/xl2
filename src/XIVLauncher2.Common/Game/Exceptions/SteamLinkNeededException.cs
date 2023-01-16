using System;

namespace XIVLauncher2.Common.Game.Exceptions;

public class SteamLinkNeededException : Exception
{
    public SteamLinkNeededException()
        : base("No steam account linked.")
    {
    }
}
