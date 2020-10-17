using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x18be796b)]
    public class TLPrivacyValueAllowChatParticipants : TLAbsPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0x18be796b;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Chats { get; set; }


    }
}
