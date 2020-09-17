using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x20adaef8)]
    public class TLInputPeerChannel : TLAbsInputPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x20adaef8;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
