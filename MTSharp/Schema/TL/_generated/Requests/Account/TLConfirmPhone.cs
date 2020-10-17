using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x5f2178c3)]
    public class TLConfirmPhone : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5f2178c3;
            }
        }

        [MTParameter(Order = 0)]
        public string PhoneCodeHash { get; set; }
        [MTParameter(Order = 1)]
        public string PhoneCode { get; set; }


    }
}
