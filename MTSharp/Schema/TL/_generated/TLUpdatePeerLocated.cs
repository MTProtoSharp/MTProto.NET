using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb4afcfb0)]
    public class TLUpdatePeerLocated : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xb4afcfb0;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTSharp.Schema.TL.TLPeerLocated> Peers { get; set; }


    }
}
