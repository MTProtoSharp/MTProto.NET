using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x36585ea4)]
    public class TLBotCallbackAnswer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x36585ea4;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Alert { get; set; }
        [MTParameter(Order = 2, FlagBitId = 3, FlagType = FlagType.True)]
        public bool HasUrl { get; set; }
        [MTParameter(Order = 3, FlagBitId = 4, FlagType = FlagType.True)]
        public bool NativeUi { get; set; }
        [MTParameter(Order = 4, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Message { get; set; }
        [MTParameter(Order = 5, FlagBitId = 2, FlagType = FlagType.Null)]
        public string Url { get; set; }
        [MTParameter(Order = 6)]
        public int CacheTime { get; set; }


    }
}
