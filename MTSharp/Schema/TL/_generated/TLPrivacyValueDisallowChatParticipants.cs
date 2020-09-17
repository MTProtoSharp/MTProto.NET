using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xacae0690)]
    public class TLPrivacyValueDisallowChatParticipants : TLAbsPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0xacae0690;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Chats { get; set; }


    }
}
