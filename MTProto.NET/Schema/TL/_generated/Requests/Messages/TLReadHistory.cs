using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xe306d3a)]
    public class TLReadHistory : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe306d3a;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int MaxId { get; set; }


    }
}
