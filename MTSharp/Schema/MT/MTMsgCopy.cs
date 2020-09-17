using MTSharp.Attributes;

namespace MTSharp.Schema.MT
{
    [MTObject(0xe06046b2)]
    public class MTMsgCopy : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe06046b2;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.MT.MTMessage OrigMessage { get; set; }


    }
}
