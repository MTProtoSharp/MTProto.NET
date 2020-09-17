using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9a65ea1f)]
    public class TLUpdateChatUserTyping : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x9a65ea1f;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public int UserId { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsSendMessageAction Action { get; set; }


    }
}
