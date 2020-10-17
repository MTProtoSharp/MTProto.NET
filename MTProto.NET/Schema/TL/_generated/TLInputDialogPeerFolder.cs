using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x64600527)]
    public class TLInputDialogPeerFolder : TLAbsInputDialogPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x64600527;
            }
        }

        [MTParameter(Order = 0)]
        public int FolderId { get; set; }


    }
}
