using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xfb834291)]
    public class TLTopPeerCategoryPeers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xfb834291;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsTopPeerCategory Category { get; set; }
        [MTParameter(Order = 1)]
        public int Count { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<MTSharp.Schema.TL.TLTopPeer> Peers { get; set; }


    }
}
