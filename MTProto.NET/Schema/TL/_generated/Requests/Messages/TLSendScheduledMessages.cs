using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xbd38850a)]
    public class TLSendScheduledMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbd38850a;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Id { get; set; }


    }
}
