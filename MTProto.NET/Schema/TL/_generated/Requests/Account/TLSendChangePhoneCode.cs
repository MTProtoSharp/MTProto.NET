using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x82574ae5)]
    public class TLSendChangePhoneCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x82574ae5;
            }
        }

        [MTParameter(Order = 0)]
        public string PhoneNumber { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLCodeSettings Settings { get; set; }


    }
}
