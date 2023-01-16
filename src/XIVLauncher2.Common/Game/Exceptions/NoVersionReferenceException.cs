using System;

namespace XIVLauncher2.Common.Game.Exceptions;

public class NoVersionReferenceException : Exception
{
    public NoVersionReferenceException(Repository repo, string version)
        : base($"No version reference found for {repo}({version})")
    {
    }
}
