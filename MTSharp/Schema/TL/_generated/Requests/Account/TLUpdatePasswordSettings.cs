using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xa59b102f)]
    public class TLUpdatePasswordSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa59b102f;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputCheckPasswordSRP Password { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.Account.TLPasswordInputSettings NewSettings { get; set; }


    }
}
