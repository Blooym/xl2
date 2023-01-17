using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using XIVLauncher2.Common.Dalamud;

namespace XIVLauncher2.Common.PlatformAbstractions;

public interface IDalamudRunner
{
    Process? Run(FileInfo runner, bool fakeLogin, bool noPlugins, bool noThirdPlugins, FileInfo gameExe, string gameArgs, IDictionary<string, string> environment, DalamudLoadMethod loadMethod, DalamudStartInfo startInfo);
}
