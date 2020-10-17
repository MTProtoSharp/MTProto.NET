using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xf89cf5e8)]
    public class TLMessageActionChatJoinedByLink : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xf89cf5e8;
            }
        }

        [MTParameter(Order = 0)]
        public int InviterId { get; set; }


    }
}
