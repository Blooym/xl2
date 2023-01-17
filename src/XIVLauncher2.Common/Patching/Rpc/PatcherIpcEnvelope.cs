#nullable enable
using System;
using System.IO;
using System.Text.Json.Serialization;

namespace XIVLauncher2.Common.PatcherIpc
{
    public class PatcherIpcEnvelope
    {
        public PatcherIpcOpCode OpCode { get; set; }
        public DateTime? Timestamp { get; set; }
        public PatcherIpcStartInstall? StartInstallInfo { get; set; }
        public string? GameDirectoryPath { get; set; }

        [JsonIgnore]
        public DirectoryInfo? GameDirectory
        {
            get => new(GameDirectoryPath!);
            set => GameDirectoryPath = value?.FullName;
        }
    }
}
