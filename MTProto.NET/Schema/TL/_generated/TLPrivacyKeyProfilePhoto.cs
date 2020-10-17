using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x96151fed)]
    public class TLPrivacyKeyProfilePhoto : TLAbsPrivacyKey
    {
        public override uint Constructor
        {
            get
            {
                return 0x96151fed;
            }
        }



    }
}
