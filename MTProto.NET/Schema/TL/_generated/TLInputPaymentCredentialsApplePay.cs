using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xaa1c39f)]
    public class TLInputPaymentCredentialsApplePay : TLAbsInputPaymentCredentials
    {
        public override uint Constructor
        {
            get
            {
                return 0xaa1c39f;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLDataJSON PaymentData { get; set; }


    }
}
