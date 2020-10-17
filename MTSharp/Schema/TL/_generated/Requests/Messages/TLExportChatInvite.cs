using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xdf7534c)]
    public class TLExportChatInvite : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdf7534c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }


    }
}
