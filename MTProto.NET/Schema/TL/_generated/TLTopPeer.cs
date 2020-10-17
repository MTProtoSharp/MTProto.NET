using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xedcdc05b)]
    public class TLTopPeer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xedcdc05b;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public double Rating { get; set; }


    }
}
