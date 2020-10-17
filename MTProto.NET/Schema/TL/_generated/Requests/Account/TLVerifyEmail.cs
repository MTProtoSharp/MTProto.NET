using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xecba39db)]
    public class TLVerifyEmail : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xecba39db;
            }
        }

        [MTParameter(Order = 0)]
        public string Email { get; set; }
        [MTParameter(Order = 1)]
        public string Code { get; set; }


    }
}
