using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x3bda1bde)]
    public class TLChat : TLAbsChat
    {
        public override uint Constructor
        {
            get
            {
                return 0x3bda1bde;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Creator { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Kicked { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool Left { get; set; }
        [MTParameter(Order = 4, FlagBitId = 5, FlagType = FlagType.True)]
        public bool Deactivated { get; set; }
        [MTParameter(Order = 5)]
        public int Id { get; set; }
        [MTParameter(Order = 6)]
        public string Title { get; set; }
        [MTParameter(Order = 7)]
        public TLAbsChatPhoto Photo { get; set; }
        [MTParameter(Order = 8)]
        public int ParticipantsCount { get; set; }
        [MTParameter(Order = 9)]
        public int Date { get; set; }
        [MTParameter(Order = 10)]
        public int Version { get; set; }
        [MTParameter(Order = 11, FlagBitId = 6, FlagType = FlagType.Null)]
        public TLAbsInputChannel MigratedTo { get; set; }
        [MTParameter(Order = 12, FlagBitId = 14, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLChatAdminRights AdminRights { get; set; }
        [MTParameter(Order = 13, FlagBitId = 18, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLChatBannedRights DefaultBannedRights { get; set; }


    }
}
