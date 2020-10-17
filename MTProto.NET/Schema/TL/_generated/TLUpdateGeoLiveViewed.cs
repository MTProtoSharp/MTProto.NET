using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x871fb939)]
    public class TLUpdateGeoLiveViewed : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x871fb939;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int MsgId { get; set; }


    }
}
