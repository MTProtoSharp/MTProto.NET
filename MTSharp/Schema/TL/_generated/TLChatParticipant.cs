using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc8d7493e)]
    public class TLChatParticipant : TLAbsChatParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0xc8d7493e;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int InviterId { get; set; }
        [MTParameter(Order = 2)]
        public int Date { get; set; }


    }
}
