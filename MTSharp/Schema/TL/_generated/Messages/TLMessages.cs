using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x8c718e87)]
    public class TLMessages : TLAbsMessages
    {
        public override uint Constructor
        {
            get
            {
                return 0x8c718e87;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsMessage> Messages { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
