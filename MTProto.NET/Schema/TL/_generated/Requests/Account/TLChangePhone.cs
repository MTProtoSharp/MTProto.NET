using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x70c32edb)]
    public class TLChangePhone : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x70c32edb;
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
