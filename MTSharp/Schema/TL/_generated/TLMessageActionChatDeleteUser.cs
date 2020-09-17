using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb2ae9b0c)]
    public class TLMessageActionChatDeleteUser : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xb2ae9b0c;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }


    }
}
