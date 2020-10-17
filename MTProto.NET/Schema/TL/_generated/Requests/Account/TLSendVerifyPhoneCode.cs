using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xa5a356f9)]
    public class TLSendVerifyPhoneCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa5a356f9;
            }
        }

        [MTParameter(Order = 0)]
        public string PhoneNumber { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLCodeSettings Settings { get; set; }


    }
}
