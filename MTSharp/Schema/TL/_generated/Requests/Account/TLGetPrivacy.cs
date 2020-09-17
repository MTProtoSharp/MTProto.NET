using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xdadbc950)]
    public class TLGetPrivacy : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdadbc950;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPrivacyKey Key { get; set; }


    }
}
