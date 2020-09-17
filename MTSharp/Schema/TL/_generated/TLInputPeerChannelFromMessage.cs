using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9c95f7bb)]
    public class TLInputPeerChannelFromMessage : TLAbsInputPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x9c95f7bb;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int MsgId { get; set; }
        [MTParameter(Order = 2)]
        public int ChannelId { get; set; }


    }
}
