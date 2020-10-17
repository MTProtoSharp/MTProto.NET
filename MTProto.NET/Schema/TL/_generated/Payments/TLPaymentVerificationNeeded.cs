using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Payments
{
    [MTObject(0xd8411139)]
    public class TLPaymentVerificationNeeded : TLAbsPaymentResult
    {
        public override uint Constructor
        {
            get
            {
                return 0xd8411139;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }


    }
}
