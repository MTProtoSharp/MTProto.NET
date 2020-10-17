using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf0e6672a)]
    public class TLChannelFull : TLAbsChatFull
    {
        public override uint Constructor
        {
            get
            {
                return 0xf0e6672a;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 3, FlagType = FlagType.True)]
        public bool CanViewParticipants { get; set; }
        [MTParameter(Order = 2, FlagBitId = 6, FlagType = FlagType.True)]
        public bool CanSetUsername { get; set; }
        [MTParameter(Order = 3, FlagBitId = 7, FlagType = FlagType.True)]
        public bool CanSetStickers { get; set; }
        [MTParameter(Order = 4, FlagBitId = 10, FlagType = FlagType.True)]
        public bool HiddenPrehistory { get; set; }
        [MTParameter(Order = 5, FlagBitId = 16, FlagType = FlagType.True)]
        public bool CanSetLocation { get; set; }
        [MTParameter(Order = 6, FlagBitId = 19, FlagType = FlagType.True)]
        public bool HasScheduled { get; set; }
        [MTParameter(Order = 7, FlagBitId = 20, FlagType = FlagType.True)]
        public bool CanViewStats { get; set; }
        [MTParameter(Order = 8)]
        public int Id { get; set; }
        [MTParameter(Order = 9)]
        public string About { get; set; }
        [MTParameter(Order = 10, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? ParticipantsCount { get; set; }
        [MTParameter(Order = 11, FlagBitId = 1, FlagType = FlagType.Null)]
        public int? AdminsCount { get; set; }
        [MTParameter(Order = 12, FlagBitId = 2, FlagType = FlagType.Null)]
        public int? KickedCount { get; set; }
        [MTParameter(Order = 13, FlagBitId = 2, FlagType = FlagType.Null)]
        public int? BannedCount { get; set; }
        [MTParameter(Order = 14, FlagBitId = 13, FlagType = FlagType.Null)]
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
        public MTProto.NET.Schema.TL.TLPeerNotifySettings NotifySettings { get; set; }
        [MTParameter(Order = 20)]
        public TLAbsExportedChatInvite ExportedInvite { get; set; }
        [MTParameter(Order = 21)]
        public TLVector<MTProto.NET.Schema.TL.TLBotInfo> BotInfo { get; set; }
        [MTParameter(Order = 22, FlagBitId = 4, FlagType = FlagType.Null)]
        public int? MigratedFromChatId { get; set; }
        [MTParameter(Order = 23, FlagBitId = 4, FlagType = FlagType.Null)]
        public int? MigratedFromMaxId { get; set; }
        [MTParameter(Order = 24, FlagBitId = 5, FlagType = FlagType.Null)]
        public int? PinnedMsgId { get; set; }
        [MTParameter(Order = 25, FlagBitId = 8, FlagType = FlagType.Null)]
        public MTProto.NET.Schema.TL.TLStickerSet Stickerset { get; set; }
        [MTParameter(Order = 26, FlagBitId = 9, FlagType = FlagType.Null)]
        public int? AvailableMinId { get; set; }
        [MTParameter(Order = 27, FlagBitId = 11, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }
        [MTParameter(Order = 28, FlagBitId = 14, FlagType = FlagType.Null)]
        public int? LinkedChatId { get; set; }
        [MTParameter(Order = 29, FlagBitId = 15, FlagType = FlagType.Null)]
        public TLAbsChannelLocation Location { get; set; }
        [MTParameter(Order = 30, FlagBitId = 17, FlagType = FlagType.Null)]
        public int? SlowmodeSeconds { get; set; }
        [MTParameter(Order = 31, FlagBitId = 18, FlagType = FlagType.Null)]
        public int? SlowmodeNextSendDate { get; set; }
        [MTParameter(Order = 32, FlagBitId = 12, FlagType = FlagType.Null)]
        public int? StatsDc { get; set; }
        [MTParameter(Order = 33)]
        public int Pts { get; set; }


    }
}
