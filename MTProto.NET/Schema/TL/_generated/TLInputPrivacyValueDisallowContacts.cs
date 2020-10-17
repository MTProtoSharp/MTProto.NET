using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xba52007)]
    public class TLInputPrivacyValueDisallowContacts : TLAbsInputPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0xba52007;
            }
        }



    }
}
