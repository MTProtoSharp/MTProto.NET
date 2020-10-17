using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
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
        public MTSharp.Schema.TL.TLCodeSettings Settings { get; set; }


    }
}
