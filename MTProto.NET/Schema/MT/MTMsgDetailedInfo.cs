using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x276d3ec6)]
    public class MTMsgDetailedInfo : MTAbsMsgDetailedInfo
    {
        public override uint Constructor
        {
            get
            {
                return 0x276d3ec6;
            }
        }

        [MTParameter(Order = 0)]
        public long MsgId { get; set; }
        [MTParameter(Order = 1)]
        public long AnswerMsgId { get; set; }
        [MTParameter(Order = 2)]
        public int Bytes { get; set; }
        [MTParameter(Order = 3)]
        public int Status { get; set; }


    }
}
