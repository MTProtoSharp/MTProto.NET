using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xca461b5d)]
    public class TLPeerLocated : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xca461b5d;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int Expires { get; set; }
        [MTParameter(Order = 2)]
        public int Distance { get; set; }


    }
}
