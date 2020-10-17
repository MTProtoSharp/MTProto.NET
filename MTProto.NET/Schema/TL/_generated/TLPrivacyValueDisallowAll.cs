using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x8b73e763)]
    public class TLPrivacyValueDisallowAll : TLAbsPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0x8b73e763;
            }
        }



    }
}
