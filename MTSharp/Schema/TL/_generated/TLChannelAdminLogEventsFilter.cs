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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Join { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Leave { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool Invite { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.True)]
        public bool Ban { get; set; }
        [MTParameter(Order = 5, FlagBitId = 4, FlagType = FlagType.True)]
        public bool Unban { get; set; }
        [MTParameter(Order = 6, FlagBitId = 5, FlagType = FlagType.True)]
        public bool Kick { get; set; }
        [MTParameter(Order = 7, FlagBitId = 6, FlagType = FlagType.True)]
        public bool Unkick { get; set; }
        [MTParameter(Order = 8, FlagBitId = 7, FlagType = FlagType.True)]
        public bool Promote { get; set; }
        [MTParameter(Order = 9, FlagBitId = 8, FlagType = FlagType.True)]
        public bool Demote { get; set; }
        [MTParameter(Order = 10, FlagBitId = 9, FlagType = FlagType.True)]
        public bool Info { get; set; }
        [MTParameter(Order = 11, FlagBitId = 10, FlagType = FlagType.True)]
        public bool Settings { get; set; }
        [MTParameter(Order = 12, FlagBitId = 11, FlagType = FlagType.True)]
        public bool Pinned { get; set; }
        [MTParameter(Order = 13, FlagBitId = 12, FlagType = FlagType.True)]
        public bool Edit { get; set; }
        [MTParameter(Order = 14, FlagBitId = 13, FlagType = FlagType.True)]
        public bool Delete { get; set; }


    }
}
