using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb8bc5b0c)]
    public class TLInputNotifyPeer : TLAbsInputNotifyPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0xb8bc5b0c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
