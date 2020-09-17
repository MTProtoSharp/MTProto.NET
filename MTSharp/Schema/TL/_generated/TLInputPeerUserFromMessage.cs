using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x17bae2e6)]
    public class TLInputPeerUserFromMessage : TLAbsInputPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x17bae2e6;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int MsgId { get; set; }
        [MTParameter(Order = 2)]
        public int UserId { get; set; }


    }
}
