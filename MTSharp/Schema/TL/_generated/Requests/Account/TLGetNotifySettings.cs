using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x12b3ad31)]
    public class TLGetNotifySettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x12b3ad31;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputNotifyPeer Peer { get; set; }


    }
}
