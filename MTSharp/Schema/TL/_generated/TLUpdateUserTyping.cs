using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5c486927)]
    public class TLUpdateUserTyping : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x5c486927;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsSendMessageAction Action { get; set; }


    }
}
