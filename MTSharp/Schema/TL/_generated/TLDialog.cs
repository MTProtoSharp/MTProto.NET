using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x2c171f72)]
    public class TLDialog : TLAbsDialog
    {
        public override uint Constructor
        {
            get
            {
                return 0x2c171f72;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 2, FlagType = FlagType.True)]
        public bool Pinned { get; set; }
        [MTParameter(Order = 2, FromFlag = 3, FlagType = FlagType.True)]
        public bool UnreadMark { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 4)]
        public int TopMessage { get; set; }
        [MTParameter(Order = 5)]
        public int ReadInboxMaxId { get; set; }
        [MTParameter(Order = 6)]
        public int ReadOutboxMaxId { get; set; }
        [MTParameter(Order = 7)]
        public int UnreadCount { get; set; }
        [MTParameter(Order = 8)]
        public int UnreadMentionsCount { get; set; }
        [MTParameter(Order = 9)]
        public MTSharp.Schema.TL.TLPeerNotifySettings NotifySettings { get; set; }
        [MTParameter(Order = 10, FromFlag = 0, FlagType = FlagType.Null)]
        public int? Pts { get; set; }
        [MTParameter(Order = 11, FromFlag = 1, FlagType = FlagType.Null)]
        public TLAbsDraftMessage Draft { get; set; }
        [MTParameter(Order = 12, FromFlag = 4, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }


    }
}
