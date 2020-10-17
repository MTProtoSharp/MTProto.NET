using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfbd2c296)]
    public class TLInputFolderPeer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xfbd2c296;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int FolderId { get; set; }


    }
}
