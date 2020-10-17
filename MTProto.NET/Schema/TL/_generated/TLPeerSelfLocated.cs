using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf8ec284b)]
    public class TLPeerSelfLocated : TLAbsPeerLocated
    {
        public override uint Constructor
        {
            get
            {
                return 0xf8ec284b;
            }
        }

        [MTParameter(Order = 0)]
        public int Expires { get; set; }


    }
}
