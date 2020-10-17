using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0xa43ad8b7)]
    public class MTRpcAnswerDropped : MTAbsRpcDropAnswer
    {
        public override uint Constructor
        {
            get
            {
                return 0xa43ad8b7;
            }
        }

        [MTParameter(Order = 0)]
        public long MsgId { get; set; }
        [MTParameter(Order = 1)]
        public int SeqNo { get; set; }
        [MTParameter(Order = 2)]
        public int Bytes { get; set; }


    }
}
