using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x54c01850)]
    public class TLUpdateChatDefaultBannedRights : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x54c01850;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLChatBannedRights DefaultBannedRights { get; set; }
        [MTParameter(Order = 2)]
        public int Version { get; set; }


    }
}
