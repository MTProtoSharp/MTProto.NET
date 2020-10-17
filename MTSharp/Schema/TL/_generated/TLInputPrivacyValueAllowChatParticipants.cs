using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x4c81c1ba)]
    public class TLInputPrivacyValueAllowChatParticipants : TLAbsInputPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0x4c81c1ba;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Chats { get; set; }


    }
}
