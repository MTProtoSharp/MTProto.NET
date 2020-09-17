using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x2d895c74)]
    public class TLChannelFull : TLAbsChatFull
    {
        public override uint Constructor
        {
            get
            {
                return 0x2d895c74;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 3, FlagType = FlagType.True)]
        public bool CanViewParticipants { get; set; }
        [MTParameter(Order = 2, FromFlag = 6, FlagType = FlagType.True)]
        public bool CanSetUsername { get; set; }
        [MTParameter(Order = 3, FromFlag = 7, FlagType = FlagType.True)]
        public bool CanSetStickers { get; set; }
        [MTParameter(Order = 4, FromFlag = 10, FlagType = FlagType.True)]
        public bool HiddenPrehistory { get; set; }
        [MTParameter(Order = 5, FromFlag = 12, FlagType = FlagType.True)]
        public bool CanViewStats { get; set; }
        [MTParameter(Order = 6, FromFlag = 16, FlagType = FlagType.True)]
        public bool CanSetLocation { get; set; }
        [MTParameter(Order = 7, FromFlag = 19, FlagType = FlagType.True)]
        public bool HasScheduled { get; set; }
        [MTParameter(Order = 8)]
        public int Id { get; set; }
        [MTParameter(Order = 9)]
        public string About { get; set; }
        [MTParameter(Order = 10, FromFlag = 0, FlagType = FlagType.Null)]
        public int? ParticipantsCount { get; set; }
        [MTParameter(Order = 11, FromFlag = 1, FlagType = FlagType.Null)]
        public int? AdminsCount { get; set; }
        [MTParameter(Order = 12, FromFlag = 2, FlagType = FlagType.Null)]
        public int? KickedCount { get; set; }
        [MTParameter(Order = 13, FromFlag = 2, FlagType = FlagType.Null)]
        public int? BannedCount { get; set; }
        [MTParameter(Order = 14, FromFlag = 13, FlagType = FlagType.Null)]
        public int? OnlineCount { get; set; }
        [MTParameter(Order = 15)]
        public int ReadInboxMaxId { get; set; }
        [MTParameter(Order = 16)]
        public int ReadOutboxMaxId { get; set; }
        [MTParameter(Order = 17)]
        public int UnreadCount { get; set; }
        [MTParameter(Order = 18)]
        public TLAbsPhoto ChatPhoto { get; set; }
        [MTParameter(Order = 19)]
        public MTSharp.Schema.TL.TLPeerNotifySettings NotifySettings { get; set; }
        [MTParameter(Order = 20)]
        public TLAbsExportedChatInvite ExportedInvite { get; set; }
        [MTParameter(Order = 21)]
        public TLVector<MTSharp.Schema.TL.TLBotInfo> BotInfo { get; set; }
        [MTParameter(Order = 22, FromFlag = 4, FlagType = FlagType.Null)]
        public int? MigratedFromChatId { get; set; }
        [MTParameter(Order = 23, FromFlag = 4, FlagType = FlagType.Null)]
        public int? MigratedFromMaxId { get; set; }
        [MTParameter(Order = 24, FromFlag = 5, FlagType = FlagType.Null)]
        public int? PinnedMsgId { get; set; }
        [MTParameter(Order = 25, FromFlag = 8, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLStickerSet Stickerset { get; set; }
        [MTParameter(Order = 26, FromFlag = 9, FlagType = FlagType.Null)]
        public int? AvailableMinId { get; set; }
        [MTParameter(Order = 27, FromFlag = 11, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }
        [MTParameter(Order = 28, FromFlag = 14, FlagType = FlagType.Null)]
        public int? LinkedChatId { get; set; }
        [MTParameter(Order = 29, FromFlag = 15, FlagType = FlagType.Null)]
        public TLAbsChannelLocation Location { get; set; }
        [MTParameter(Order = 30, FromFlag = 17, FlagType = FlagType.Null)]
        public int? SlowmodeSeconds { get; set; }
        [MTParameter(Order = 31, FromFlag = 18, FlagType = FlagType.Null)]
        public int? SlowmodeNextSendDate { get; set; }
        [MTParameter(Order = 32)]
        public int Pts { get; set; }


    }
}
