using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xbddde532)]
    public class TLPeerChannel : TLAbsPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0xbddde532;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }


    }
}
