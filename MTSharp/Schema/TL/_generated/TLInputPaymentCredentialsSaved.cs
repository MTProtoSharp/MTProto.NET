using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc10eb2cf)]
    public class TLInputPaymentCredentialsSaved : TLAbsInputPaymentCredentials
    {
        public override uint Constructor
        {
            get
            {
                return 0xc10eb2cf;
            }
        }

        [MTParameter(Order = 0)]
        public string Id { get; set; }
        [MTParameter(Order = 1)]
        public byte[] TmpPassword { get; set; }


    }
}
