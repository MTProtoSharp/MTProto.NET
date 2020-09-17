using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe9baa668)]
    public class TLFolderPeer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe9baa668;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int FolderId { get; set; }


    }
}
