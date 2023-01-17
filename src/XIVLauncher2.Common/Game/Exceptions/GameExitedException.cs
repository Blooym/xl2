using System;

namespace XIVLauncher2.Common.Game.Exceptions;

public class GameExitedException : Exception
{
    public GameExitedException()
        : base("Game exited prematurely.")
    {
    }
}
