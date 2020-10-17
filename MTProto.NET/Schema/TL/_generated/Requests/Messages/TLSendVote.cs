using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x10ea6184)]
    public class TLSendVote : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x10ea6184;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int MsgId { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<byte[]> Options { get; set; }


    }
}
