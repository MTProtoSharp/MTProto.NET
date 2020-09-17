using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x938458c1)]
    public class TLUser : TLAbsUser
    {
        public override uint Constructor
        {
            get
            {
                return 0x938458c1;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 10, FlagType = FlagType.True)]
        public bool Self { get; set; }
        [MTParameter(Order = 2, FromFlag = 11, FlagType = FlagType.True)]
        public bool Contact { get; set; }
        [MTParameter(Order = 3, FromFlag = 12, FlagType = FlagType.True)]
        public bool MutualContact { get; set; }
        [MTParameter(Order = 4, FromFlag = 13, FlagType = FlagType.True)]
        public bool Deleted { get; set; }
        [MTParameter(Order = 5, FromFlag = 14, FlagType = FlagType.True)]
        public bool Bot { get; set; }
        [MTParameter(Order = 6, FromFlag = 15, FlagType = FlagType.True)]
        public bool BotChatHistory { get; set; }
        [MTParameter(Order = 7, FromFlag = 16, FlagType = FlagType.True)]
        public bool BotNochats { get; set; }
        [MTParameter(Order = 8, FromFlag = 17, FlagType = FlagType.True)]
        public bool Verified { get; set; }
        [MTParameter(Order = 9, FromFlag = 18, FlagType = FlagType.True)]
        public bool Restricted { get; set; }
        [MTParameter(Order = 10, FromFlag = 20, FlagType = FlagType.True)]
        public bool Min { get; set; }
        [MTParameter(Order = 11, FromFlag = 21, FlagType = FlagType.True)]
        public bool BotInlineGeo { get; set; }
        [MTParameter(Order = 12, FromFlag = 23, FlagType = FlagType.True)]
        public bool Support { get; set; }
        [MTParameter(Order = 13, FromFlag = 24, FlagType = FlagType.True)]
        public bool Scam { get; set; }
        [MTParameter(Order = 14)]
        public int Id { get; set; }
        [MTParameter(Order = 15, FromFlag = 0, FlagType = FlagType.Null)]
        public long? AccessHash { get; set; }
        [MTParameter(Order = 16, FromFlag = 1, FlagType = FlagType.Null)]
        public string FirstName { get; set; }
        [MTParameter(Order = 17, FromFlag = 2, FlagType = FlagType.Null)]
        public string LastName { get; set; }
        [MTParameter(Order = 18, FromFlag = 3, FlagType = FlagType.Null)]
        public string Username { get; set; }
        [MTParameter(Order = 19, FromFlag = 4, FlagType = FlagType.Null)]
        public string Phone { get; set; }
        [MTParameter(Order = 20, FromFlag = 5, FlagType = FlagType.Null)]
        public TLAbsUserProfilePhoto Photo { get; set; }
        [MTParameter(Order = 21, FromFlag = 6, FlagType = FlagType.Null)]
        public TLAbsUserStatus Status { get; set; }
        [MTParameter(Order = 22, FromFlag = 14, FlagType = FlagType.Null)]
        public int? BotInfoVersion { get; set; }
        [MTParameter(Order = 23, FromFlag = 18, FlagType = FlagType.Null)]
        public TLVector<MTSharp.Schema.TL.TLRestrictionReason> RestrictionReason { get; set; }
        [MTParameter(Order = 24, FromFlag = 19, FlagType = FlagType.Null)]
        public string BotInlinePlaceholder { get; set; }
        [MTParameter(Order = 25, FromFlag = 22, FlagType = FlagType.Null)]
        public string LangCode { get; set; }


    }
}
