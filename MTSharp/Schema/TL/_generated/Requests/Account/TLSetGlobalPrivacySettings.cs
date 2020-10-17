using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x1edaaac2)]
    public class TLSetGlobalPrivacySettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1edaaac2;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLGlobalPrivacySettings Settings { get; set; }


    }
}
