using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xbdbb0464)]
    public class TLGetScheduledMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbdbb0464;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Id { get; set; }


    }
}
