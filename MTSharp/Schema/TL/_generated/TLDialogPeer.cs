using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe56dbf05)]
    public class TLDialogPeer : TLAbsDialogPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0xe56dbf05;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPeer Peer { get; set; }


    }
}
