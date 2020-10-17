using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xfda68d36)]
    public class TLGetMessageEditData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xfda68d36;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int Id { get; set; }


    }
}
