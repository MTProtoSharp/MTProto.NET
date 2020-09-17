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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool Alert { get; set; }
        [MTParameter(Order = 2, FromFlag = 3, FlagType = FlagType.True)]
        public bool HasUrl { get; set; }
        [MTParameter(Order = 3, FromFlag = 4, FlagType = FlagType.True)]
        public bool NativeUi { get; set; }
        [MTParameter(Order = 4, FromFlag = 0, FlagType = FlagType.Null)]
        public string Message { get; set; }
        [MTParameter(Order = 5, FromFlag = 2, FlagType = FlagType.Null)]
        public string Url { get; set; }
        [MTParameter(Order = 6)]
        public int CacheTime { get; set; }


    }
}
