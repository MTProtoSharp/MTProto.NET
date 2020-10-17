using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xeb2b4cf6)]
    public class TLGetGlobalPrivacySettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xeb2b4cf6;
            }
        }



    }
}
