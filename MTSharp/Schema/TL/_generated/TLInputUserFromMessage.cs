using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x2d117597)]
    public class TLInputUserFromMessage : TLAbsInputUser
    {
        public override uint Constructor
        {
            get
            {
                return 0x2d117597;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 1)]
        public int MsgId { get; set; }
        [MTParameter(Order = 2)]
        public int UserId { get; set; }


    }
}
