using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x514519e2)]
    public class TLDialogPeerFolder : TLAbsDialogPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x514519e2;
            }
        }

        [MTParameter(Order = 0)]
        public int FolderId { get; set; }


    }
}
