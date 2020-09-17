using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9fd40bd8)]
    public class TLNotifyPeer : TLAbsNotifyPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x9fd40bd8;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPeer Peer { get; set; }


    }
}
