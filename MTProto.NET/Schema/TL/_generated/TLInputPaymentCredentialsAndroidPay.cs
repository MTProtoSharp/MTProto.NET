using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xca05d50e)]
    public class TLInputPaymentCredentialsAndroidPay : TLAbsInputPaymentCredentials
    {
        public override uint Constructor
        {
            get
            {
                return 0xca05d50e;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLDataJSON PaymentToken { get; set; }
        [MTParameter(Order = 1)]
        public string GoogleTransactionId { get; set; }


    }
}
