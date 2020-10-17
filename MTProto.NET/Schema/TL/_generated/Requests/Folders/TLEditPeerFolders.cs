using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Folders
{
    [MTObject(0x6847d0ab)]
    public class TLEditPeerFolders : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6847d0ab;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTProto.NET.Schema.TL.TLInputFolderPeer> FolderPeers { get; set; }


    }
}
