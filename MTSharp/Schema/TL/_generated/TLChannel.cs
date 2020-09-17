using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd31a961e)]
    public class TLChannel : TLAbsChat
    {
        public override uint Constructor
        {
            get
            {
                return 0xd31a961e;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Creator { get; set; }
        [MTParameter(Order = 2, FromFlag = 2, FlagType = FlagType.True)]
        public bool Left { get; set; }
        [MTParameter(Order = 3, FromFlag = 5, FlagType = FlagType.True)]
        public bool Broadcast { get; set; }
        [MTParameter(Order = 4, FromFlag = 7, FlagType = FlagType.True)]
        public bool Verified { get; set; }
        [MTParameter(Order = 5, FromFlag = 8, FlagType = FlagType.True)]
        public bool Megagroup { get; set; }
        [MTParameter(Order = 6, FromFlag = 9, FlagType = FlagType.True)]
        public bool Restricted { get; set; }
        [MTParameter(Order = 7, FromFlag = 11, FlagType = FlagType.True)]
        public bool Signatures { get; set; }
        [MTParameter(Order = 8, FromFlag = 12, FlagType = FlagType.True)]
        public bool Min { get; set; }
        [MTParameter(Order = 9, FromFlag = 19, FlagType = FlagType.True)]
        public bool Scam { get; set; }
        [MTParameter(Order = 10, FromFlag = 20, FlagType = FlagType.True)]
        public bool HasLink { get; set; }
        [MTParameter(Order = 11, FromFlag = 21, FlagType = FlagType.True)]
        public bool HasGeo { get; set; }
        [MTParameter(Order = 12, FromFlag = 22, FlagType = FlagType.True)]
        public bool SlowmodeEnabled { get; set; }
        [MTParameter(Order = 13)]
        public int Id { get; set; }
        [MTParameter(Order = 14, FromFlag = 13, FlagType = FlagType.Null)]
        public long? AccessHash { get; set; }
        [MTParameter(Order = 15)]
        public string Title { get; set; }
        [MTParameter(Order = 16, FromFlag = 6, FlagType = FlagType.Null)]
        public string Username { get; set; }
        [MTParameter(Order = 17)]
        public TLAbsChatPhoto Photo { get; set; }
        [MTParameter(Order = 18)]
        public int Date { get; set; }
        [MTParameter(Order = 19)]
        public int Version { get; set; }
        [MTParameter(Order = 20, FromFlag = 9, FlagType = FlagType.Null)]
        public TLVector<MTSharp.Schema.TL.TLRestrictionReason> RestrictionReason { get; set; }
        [MTParameter(Order = 21, FromFlag = 14, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLChatAdminRights AdminRights { get; set; }
        [MTParameter(Order = 22, FromFlag = 15, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLChatBannedRights BannedRights { get; set; }
        [MTParameter(Order = 23, FromFlag = 18, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLChatBannedRights DefaultBannedRights { get; set; }
        [MTParameter(Order = 24, FromFlag = 17, FlagType = FlagType.Null)]
        public int? ParticipantsCount { get; set; }


    }
}
