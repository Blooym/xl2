using System;

namespace XIVLauncher2.Common.Game.Exceptions;

public class SteamException : Exception
{
    public SteamException(string message, Exception innerException = null)
        : base(message, innerException)
    {
    }
}
