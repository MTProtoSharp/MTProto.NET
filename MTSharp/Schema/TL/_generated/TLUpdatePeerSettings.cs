using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6a7e7366)]
    public class TLUpdatePeerSettings : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x6a7e7366;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLPeerSettings Settings { get; set; }


    }
}
