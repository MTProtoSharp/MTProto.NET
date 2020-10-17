using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x9cd81144)]
    public class TLChatsSlice : TLAbsChats
    {
        public override uint Constructor
        {
            get
            {
                return 0x9cd81144;
            }
        }

        [MTParameter(Order = 0)]
        public int Count { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsChat> Chats { get; set; }


    }
}
