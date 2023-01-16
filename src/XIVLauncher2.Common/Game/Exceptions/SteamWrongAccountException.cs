using System;

namespace XIVLauncher2.Common.Game.Exceptions;

public class SteamWrongAccountException : Exception
{
    public SteamWrongAccountException(string chosenUserName, string imposedUserName)
        : base($"Wrong username! chosen: {chosenUserName}, imposed: {imposedUserName}")
    {
    }
}
