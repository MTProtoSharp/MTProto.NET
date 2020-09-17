using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x4dd3a7f6)]
    public class TLVerifyPhone : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4dd3a7f6;
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
