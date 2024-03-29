﻿using XIVLauncher2.Common.Patching.Util;

namespace XIVLauncher2.Common.Patching.ZiPatch.Chunk
{
    public class ApplyFreeSpaceChunk : ZiPatchChunk
    {
        // This is a NOP on recent patcher versions, so I don't think we'll be seeing it.
        public new static string Type = "APFS";

        // TODO: No samples of this were found, so these fields are theoretical
        public long UnknownFieldA { get; protected set; }
        public long UnknownFieldB { get; protected set; }

        protected override void ReadChunk()
        {
            var start = this.Reader.BaseStream.Position;

            UnknownFieldA = this.Reader.ReadInt64BE();
            UnknownFieldB = this.Reader.ReadInt64BE();

            this.Reader.ReadBytes(Size - (int)(this.Reader.BaseStream.Position - start));
        }

        public ApplyFreeSpaceChunk(ChecksumBinaryReader reader, int offset, int size) : base(reader, offset, size) {}

        public override string ToString()
        {
            return $"{Type}:{UnknownFieldA}:{UnknownFieldB}";
        }
    }
}
