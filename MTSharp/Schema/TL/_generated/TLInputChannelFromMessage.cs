using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x2a286531)]
    public class TLInputChannelFromMessage : TLAbsInputChannel
    {
        public override uint Constructor
        {
            get
            {
                return 0x2a286531;
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
