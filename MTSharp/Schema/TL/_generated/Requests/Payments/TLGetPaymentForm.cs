using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Payments
{
    [MTObject(0x99f09745)]
    public class TLGetPaymentForm : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x99f09745;
            }
        }

        [MTParameter(Order = 0)]
        public int MsgId { get; set; }


    }
}
