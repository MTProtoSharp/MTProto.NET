using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfabadc5f)]
    public class TLInputPrivacyKeyPhoneCall : TLAbsInputPrivacyKey
    {
        public override uint Constructor
        {
            get
            {
                return 0xfabadc5f;
            }
        }



    }
}
