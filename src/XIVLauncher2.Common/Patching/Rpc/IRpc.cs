using System;
using XIVLauncher2.Common.PatcherIpc;

namespace XIVLauncher2.Common.Patching.Rpc;

public interface IRpc
{
    public void SendMessage(PatcherIpcEnvelope envelope);

    public event Action<PatcherIpcEnvelope> MessageReceived;
}
