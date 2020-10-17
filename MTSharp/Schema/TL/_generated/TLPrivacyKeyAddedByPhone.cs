using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x42ffd42b)]
    public class TLPrivacyKeyAddedByPhone : TLAbsPrivacyKey
    {
        public override uint Constructor
        {
            get
            {
                return 0x42ffd42b;
            }
        }



    }
}
