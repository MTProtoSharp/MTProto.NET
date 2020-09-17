using MTSharp.Attributes;

namespace MTSharp.Schema.MT.Requests
{
    [MTObject(0x58e4a740)]
    public class MTRpcDropAnswer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x58e4a740;
            }
        }

        [MTParameter(Order = 0)]
        public long ReqMsgId { get; set; }


    }
}
