using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Help
{
    [MTObject(0x1e251c95)]
    public class TLHidePromoData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1e251c95;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
