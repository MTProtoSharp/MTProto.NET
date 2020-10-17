using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x500e6dfa)]
    public class TLPrivacyKeyChatInvite : TLAbsPrivacyKey
    {
        public override uint Constructor
        {
            get
            {
                return 0x500e6dfa;
            }
        }



    }
}
