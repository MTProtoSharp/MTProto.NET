using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0xe5d7d19c)]
    public class TLChatFull : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe5d7d19c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsChatFull FullChat { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
