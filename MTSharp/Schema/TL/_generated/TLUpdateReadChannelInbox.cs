using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x330b5424)]
    public class TLUpdateReadChannelInbox : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x330b5424;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }
        [MTParameter(Order = 2)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 3)]
        public int MaxId { get; set; }
        [MTParameter(Order = 4)]
        public int StillUnreadCount { get; set; }
        [MTParameter(Order = 5)]
        public int Pts { get; set; }


    }
}
