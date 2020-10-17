using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xe2c2685b)]
    public class TLGetScheduledHistory : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe2c2685b;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int Hash { get; set; }


    }
}
