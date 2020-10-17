using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Auth
{
    [MTObject(0x1f040578)]
    public class TLCancelCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1f040578;
            }
        }

        [MTParameter(Order = 0)]
        public string PhoneNumber { get; set; }
        [MTParameter(Order = 1)]
        public string PhoneCodeHash { get; set; }


    }
}
