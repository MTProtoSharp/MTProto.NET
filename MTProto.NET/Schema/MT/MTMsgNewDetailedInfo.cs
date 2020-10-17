using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x809db6df)]
    public class MTMsgNewDetailedInfo : MTAbsMsgDetailedInfo
    {
        public override uint Constructor
        {
            get
            {
                return 0x809db6df;
            }
        }

        [MTParameter(Order = 0)]
        public long AnswerMsgId { get; set; }
        [MTParameter(Order = 1)]
        public int Bytes { get; set; }
        [MTParameter(Order = 2)]
        public int Status { get; set; }


    }
}
