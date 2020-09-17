using MTSharp.Attributes;

namespace MTSharp.Schema.MT
{
    [MTObject(0x04deb57d)]
    public class MTMsgsStateInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x04deb57d;
            }
        }

        [MTParameter(Order = 0)]
        public long ReqMsgId { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Info { get; set; }


    }
}
