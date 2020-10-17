using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0x1ae373ac)]
    public class TLResetTopPeerRating : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1ae373ac;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsTopPeerCategory Category { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
