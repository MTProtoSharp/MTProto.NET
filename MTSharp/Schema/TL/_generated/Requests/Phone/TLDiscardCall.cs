using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Phone
{
    [MTObject(0xb2cbc1c0)]
    public class TLDiscardCall : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb2cbc1c0;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Video { get; set; }
        [MTParameter(Order = 2)]
        public MTSharp.Schema.TL.TLInputPhoneCall Peer { get; set; }
        [MTParameter(Order = 3)]
        public int Duration { get; set; }
        [MTParameter(Order = 4)]
        public TLAbsPhoneCallDiscardReason Reason { get; set; }
        [MTParameter(Order = 5)]
        public long ConnectionId { get; set; }


    }
}
