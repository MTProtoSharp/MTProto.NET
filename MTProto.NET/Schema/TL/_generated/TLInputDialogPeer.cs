using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfcaafeb7)]
    public class TLInputDialogPeer : TLAbsInputDialogPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0xfcaafeb7;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
