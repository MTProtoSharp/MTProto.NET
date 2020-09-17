using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x80e11a7f)]
    public class TLMessageActionPhoneCall : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x80e11a7f;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 2, FlagType = FlagType.True)]
        public bool Video { get; set; }
        [MTParameter(Order = 2)]
        public long CallId { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public TLAbsPhoneCallDiscardReason Reason { get; set; }
        [MTParameter(Order = 4, FromFlag = 1, FlagType = FlagType.Null)]
        public int? Duration { get; set; }


    }
}
