using MTProto.NET.Enums;
using System;

namespace MTProto.NET.Attributes
{
    public class MTParameterAttribute : Attribute
    {
        public int Order { get; set; }
        public int FlagBitId { get; set; } = -1;
        public int BigIntegerBytesCount { get; set; } = -1;
        public FlagType FlagType { get; set; }
        public bool IsFlag { get; set; } = false;
    }
}
