using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xfffe1bac)]
    public class TLPrivacyValueAllowContacts : TLAbsPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0xfffe1bac;
            }
        }



    }
}
