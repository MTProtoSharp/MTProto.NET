using MTSharp.Enums;
using System;

namespace MTSharp.Attributes
{
    public class MTParameterAttribute : Attribute
    {
        public int Order { get; set; }
        public int FromFlag { get; set; } = -1;
        public int BytesCount { get; set; } = -1;
        public FlagType FlagType { get; set; }
    }
}
