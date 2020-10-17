using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xc97df020)]
    public class TLSendScreenshotNotification : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc97df020;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int ReplyToMsgId { get; set; }
        [MTParameter(Order = 2)]
        public long RandomId { get; set; }


    }
}
