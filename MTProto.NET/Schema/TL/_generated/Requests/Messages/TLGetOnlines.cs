using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x6e2be050)]
    public class TLGetOnlines : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6e2be050;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
