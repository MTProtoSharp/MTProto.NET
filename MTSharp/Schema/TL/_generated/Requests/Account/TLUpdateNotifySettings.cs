using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x84be5b93)]
    public class TLUpdateNotifySettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x84be5b93;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputNotifyPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLInputPeerNotifySettings Settings { get; set; }


    }
}
