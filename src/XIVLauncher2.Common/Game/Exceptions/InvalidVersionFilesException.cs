using System;

namespace XIVLauncher2.Common.Game.Exceptions;

public class InvalidVersionFilesException : Exception
{
    public InvalidVersionFilesException()
        : base("Version files are invalid.")
    {
    }
}
