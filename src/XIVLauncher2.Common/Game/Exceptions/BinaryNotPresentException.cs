using System;

namespace XIVLauncher2.Common.Game.Exceptions;

public class BinaryNotPresentException : Exception
{
    public string Path { get; private set; }

    public BinaryNotPresentException(string path)
        : base("Game binary was not found")
    {
        this.Path = path;
    }
}
