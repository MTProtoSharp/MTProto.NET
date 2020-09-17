using MTSharp.Attributes;

namespace MTSharp.Schema.MT
{
    [MTObject(0xa7eff811)]
    public class MTBadMsgNotification : MTAbsBadMsgNotification
    {
        public override uint Constructor
        {
            get
            {
                return 0xa7eff811;
            }
        }

        [MTParameter(Order = 0)]
        public long BadMsgId { get; set; }
        [MTParameter(Order = 1)]
        public int BadMsgSeqno { get; set; }
        [MTParameter(Order = 2)]
        public int ErrorCode { get; set; }


    }
}
