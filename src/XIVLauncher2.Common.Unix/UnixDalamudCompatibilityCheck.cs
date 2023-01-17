using System.Runtime.InteropServices;
using XIVLauncher2.Common.PlatformAbstractions;

namespace XIVLauncher2.Common.Unix;

public class UnixDalamudCompatibilityCheck : IDalamudCompatibilityCheck
{
    public void EnsureCompatibility()
    {
        //Dalamud will work with wines built-in vcrun, so no need to check that
        EnsureArchitecture();
    }

    private static void EnsureArchitecture()
    {
        var arch = RuntimeInformation.ProcessArchitecture;

        switch (arch)
        {
            case Architecture.X86:
                throw new IDalamudCompatibilityCheck.ArchitectureNotSupportedException("Dalamud is not supported on x86 architecture.");

            case Architecture.X64:
                break;

            case Architecture.Arm:
                throw new IDalamudCompatibilityCheck.ArchitectureNotSupportedException("Dalamud is not supported on ARM32.");

            case Architecture.Arm64:
                throw new IDalamudCompatibilityCheck.ArchitectureNotSupportedException("x64 emulation was not detected. Please make sure to run XIVLauncher with x64 emulation.");
        }
    }
}
