using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x73bb643b)]
    public class TLGetPollResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x73bb643b;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int MsgId { get; set; }


    }
}
