using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x3371c354)]
    public class TLPeerDialogs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3371c354;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsDialog> Dialogs { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsMessage> Messages { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<TLAbsUser> Users { get; set; }
        [MTParameter(Order = 4)]
        public MTSharp.Schema.TL.Updates.TLState State { get; set; }


    }
}
