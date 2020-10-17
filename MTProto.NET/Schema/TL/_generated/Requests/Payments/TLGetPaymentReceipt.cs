using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Payments
{
    [MTObject(0xa092a980)]
    public class TLGetPaymentReceipt : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa092a980;
            }
        }

        [MTParameter(Order = 0)]
        public int MsgId { get; set; }


    }
}
