using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xa3825e50)]
    public class TLSetTyping : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa3825e50;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsSendMessageAction Action { get; set; }


    }
}
