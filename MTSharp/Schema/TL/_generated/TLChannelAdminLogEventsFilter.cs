using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xea107ae4)]
    public class TLChannelAdminLogEventsFilter : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xea107ae4;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Join { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool Leave { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.True)]
        public bool Invite { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.True)]
        public bool Ban { get; set; }
        [MTParameter(Order = 5, FromFlag = 4, FlagType = FlagType.True)]
        public bool Unban { get; set; }
        [MTParameter(Order = 6, FromFlag = 5, FlagType = FlagType.True)]
        public bool Kick { get; set; }
        [MTParameter(Order = 7, FromFlag = 6, FlagType = FlagType.True)]
        public bool Unkick { get; set; }
        [MTParameter(Order = 8, FromFlag = 7, FlagType = FlagType.True)]
        public bool Promote { get; set; }
        [MTParameter(Order = 9, FromFlag = 8, FlagType = FlagType.True)]
        public bool Demote { get; set; }
        [MTParameter(Order = 10, FromFlag = 9, FlagType = FlagType.True)]
        public bool Info { get; set; }
        [MTParameter(Order = 11, FromFlag = 10, FlagType = FlagType.True)]
        public bool Settings { get; set; }
        [MTParameter(Order = 12, FromFlag = 11, FlagType = FlagType.True)]
        public bool Pinned { get; set; }
        [MTParameter(Order = 13, FromFlag = 12, FlagType = FlagType.True)]
        public bool Edit { get; set; }
        [MTParameter(Order = 14, FromFlag = 13, FlagType = FlagType.True)]
        public bool Delete { get; set; }


    }
}
