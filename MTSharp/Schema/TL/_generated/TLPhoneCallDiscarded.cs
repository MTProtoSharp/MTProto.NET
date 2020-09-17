using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x50ca4de1)]
    public class TLPhoneCallDiscarded : TLAbsPhoneCall
    {
        public override uint Constructor
        {
            get
            {
                return 0x50ca4de1;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 2, FlagType = FlagType.True)]
        public bool NeedRating { get; set; }
        [MTParameter(Order = 2, FromFlag = 3, FlagType = FlagType.True)]
        public bool NeedDebug { get; set; }
        [MTParameter(Order = 3, FromFlag = 5, FlagType = FlagType.True)]
        public bool Video { get; set; }
        [MTParameter(Order = 4)]
        public long Id { get; set; }
        [MTParameter(Order = 5, FromFlag = 0, FlagType = FlagType.Null)]
        public TLAbsPhoneCallDiscardReason Reason { get; set; }
        [MTParameter(Order = 6, FromFlag = 1, FlagType = FlagType.Null)]
        public int? Duration { get; set; }


    }
}
