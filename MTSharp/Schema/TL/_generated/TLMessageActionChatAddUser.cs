using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x488a7337)]
    public class TLMessageActionChatAddUser : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x488a7337;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Users { get; set; }


    }
}
