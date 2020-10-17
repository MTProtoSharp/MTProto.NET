using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0xbcd51581)]
    public class TLSignIn : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbcd51581;
            }
        }

        [MTParameter(Order = 0)]
        public string PhoneNumber { get; set; }
        [MTParameter(Order = 1)]
        public string PhoneCodeHash { get; set; }
        [MTParameter(Order = 2)]
        public string PhoneCode { get; set; }


    }
}
