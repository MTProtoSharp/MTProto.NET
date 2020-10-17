using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xe33f5613)]
    public class TLRequestUrlAuth : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe33f5613;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int MsgId { get; set; }
        [MTParameter(Order = 2)]
        public int ButtonId { get; set; }


    }
}
