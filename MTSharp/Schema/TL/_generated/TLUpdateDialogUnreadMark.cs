using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe16459c3)]
    public class TLUpdateDialogUnreadMark : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xe16459c3;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Unread { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsDialogPeer Peer { get; set; }


    }
}
