using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x65427b82)]
    public class TLPrivacyValueAllowAll : TLAbsPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0x65427b82;
            }
        }



    }
}
