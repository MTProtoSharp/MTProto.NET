using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x4facb138)]
    public class TLHidePeerSettingsBar : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4facb138;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
