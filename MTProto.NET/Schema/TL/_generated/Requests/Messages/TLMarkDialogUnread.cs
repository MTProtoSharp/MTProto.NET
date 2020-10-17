using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xc286d98f)]
    public class TLMarkDialogUnread : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc286d98f;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Unread { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputDialogPeer Peer { get; set; }


    }
}
