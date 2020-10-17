using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x732eef00)]
    public class TLGetSearchCounters : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x732eef00;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsMessagesFilter> Filters { get; set; }


    }
}
