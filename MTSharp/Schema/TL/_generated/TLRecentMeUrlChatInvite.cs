using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xeb49081d)]
    public class TLRecentMeUrlChatInvite : TLAbsRecentMeUrl
    {
        public override uint Constructor
        {
            get
            {
                return 0xeb49081d;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsChatInvite ChatInvite { get; set; }


    }
}
