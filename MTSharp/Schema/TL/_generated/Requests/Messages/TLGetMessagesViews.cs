using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xc4c8a55d)]
    public class TLGetMessagesViews : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc4c8a55d;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Id { get; set; }
        [MTParameter(Order = 2)]
        public bool Increment { get; set; }


    }
}
