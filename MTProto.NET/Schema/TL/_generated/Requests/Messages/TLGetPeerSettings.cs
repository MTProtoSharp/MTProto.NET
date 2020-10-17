using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x3672e09c)]
    public class TLGetPeerSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3672e09c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
