using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xedf17c12)]
    public class TLUserFull : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xedf17c12;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Blocked { get; set; }
        [MTParameter(Order = 2, FlagBitId = 4, FlagType = FlagType.True)]
        public bool PhoneCallsAvailable { get; set; }
        [MTParameter(Order = 3, FlagBitId = 5, FlagType = FlagType.True)]
        public bool PhoneCallsPrivate { get; set; }
        [MTParameter(Order = 4, FlagBitId = 7, FlagType = FlagType.True)]
        public bool CanPinMessage { get; set; }
        [MTParameter(Order = 5, FlagBitId = 12, FlagType = FlagType.True)]
        public bool HasScheduled { get; set; }
        [MTParameter(Order = 6, FlagBitId = 13, FlagType = FlagType.True)]
        public bool VideoCallsAvailable { get; set; }
        [MTParameter(Order = 7)]
        public TLAbsUser User { get; set; }
        [MTParameter(Order = 8, FlagBitId = 1, FlagType = FlagType.Null)]
        public string About { get; set; }
        [MTParameter(Order = 9)]
        public MTSharp.Schema.TL.TLPeerSettings Settings { get; set; }
        [MTParameter(Order = 10, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsPhoto ProfilePhoto { get; set; }
        [MTParameter(Order = 11)]
        public MTSharp.Schema.TL.TLPeerNotifySettings NotifySettings { get; set; }
        [MTParameter(Order = 12, FlagBitId = 3, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLBotInfo BotInfo { get; set; }
        [MTParameter(Order = 13, FlagBitId = 6, FlagType = FlagType.Null)]
        public int? PinnedMsgId { get; set; }
        [MTParameter(Order = 14)]
        public int CommonChatsCount { get; set; }
        [MTParameter(Order = 15, FlagBitId = 11, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }


    }
}
