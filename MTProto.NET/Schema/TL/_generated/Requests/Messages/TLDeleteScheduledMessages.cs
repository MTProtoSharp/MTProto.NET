using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x59ae2b16)]
    public class TLDeleteScheduledMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x59ae2b16;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Id { get; set; }


    }
}
