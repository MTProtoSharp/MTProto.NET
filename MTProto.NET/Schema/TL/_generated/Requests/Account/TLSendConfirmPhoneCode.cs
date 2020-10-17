using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x1b3faa88)]
    public class TLSendConfirmPhoneCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b3faa88;
            }
        }

        [MTParameter(Order = 0)]
        public string Hash { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLCodeSettings Settings { get; set; }


    }
}
