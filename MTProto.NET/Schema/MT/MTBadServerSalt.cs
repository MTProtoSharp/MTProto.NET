using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0xedab447b)]
    public class MTBadServerSalt : MTAbsBadMsgNotification
    {
        public override uint Constructor
        {
            get
            {
                return 0xedab447b;
            }
        }

        [MTParameter(Order = 0)]
        public long BadMsgId { get; set; }
        [MTParameter(Order = 1)]
        public int BadMsgSeqno { get; set; }
        [MTParameter(Order = 2)]
        public int ErrorCode { get; set; }
        [MTParameter(Order = 3)]
        public long NewServerSalt { get; set; }


    }
}
