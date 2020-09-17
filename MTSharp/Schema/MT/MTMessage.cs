using MTSharp.Attributes;

namespace MTSharp.Schema.MT
{
    [MTObject(0x5BB8E511)]
    public class MTMessage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5BB8E511;
            }
        }

        [MTParameter(Order = 0)]
        public long MsgId { get; set; }
        [MTParameter(Order = 1)]
        public int Seqno { get; set; }
        [MTParameter(Order = 2)]
        public int Bytes { get; set; }
        [MTParameter(Order = 3)]
        public MTSharp.Schema.MT.MTGzipPacked Body { get; set; }


    }
}
