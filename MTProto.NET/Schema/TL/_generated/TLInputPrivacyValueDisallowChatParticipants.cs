using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xd82363af)]
    public class TLInputPrivacyValueDisallowChatParticipants : TLAbsInputPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0xd82363af;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Chats { get; set; }


    }
}
