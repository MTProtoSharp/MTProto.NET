using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Payments
{
    [MTObject(0x4e5f810d)]
    public class TLPaymentResult : TLAbsPaymentResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x4e5f810d;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsUpdates Updates { get; set; }


    }
}
