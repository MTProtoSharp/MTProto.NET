using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1b7c9db3)]
    public class TLChatFull : TLAbsChatFull
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b7c9db3;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 7, FlagType = FlagType.True)]
        public bool CanSetUsername { get; set; }
        [MTParameter(Order = 2, FromFlag = 8, FlagType = FlagType.True)]
        public bool HasScheduled { get; set; }
        [MTParameter(Order = 3)]
        public int Id { get; set; }
        [MTParameter(Order = 4)]
        public string About { get; set; }
        [MTParameter(Order = 5)]
        public TLAbsChatParticipants Participants { get; set; }
        [MTParameter(Order = 6, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsPhoto ChatPhoto { get; set; }
        [MTParameter(Order = 7)]
        public MTSharp.Schema.TL.TLPeerNotifySettings NotifySettings { get; set; }
        [MTParameter(Order = 8)]
        public TLAbsExportedChatInvite ExportedInvite { get; set; }
        [MTParameter(Order = 9, FromFlag = 3, FlagType = FlagType.Null)]
        public TLVector<MTSharp.Schema.TL.TLBotInfo> BotInfo { get; set; }
        [MTParameter(Order = 10, FromFlag = 6, FlagType = FlagType.Null)]
        public int? PinnedMsgId { get; set; }
        [MTParameter(Order = 11, FromFlag = 11, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }


    }
}
