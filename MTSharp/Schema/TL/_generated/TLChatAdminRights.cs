using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5fb224d5)]
    public class TLChatAdminRights : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5fb224d5;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool ChangeInfo { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool PostMessages { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.True)]
        public bool EditMessages { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.True)]
        public bool DeleteMessages { get; set; }
        [MTParameter(Order = 5, FromFlag = 4, FlagType = FlagType.True)]
        public bool BanUsers { get; set; }
        [MTParameter(Order = 6, FromFlag = 5, FlagType = FlagType.True)]
        public bool InviteUsers { get; set; }
        [MTParameter(Order = 7, FromFlag = 7, FlagType = FlagType.True)]
        public bool PinMessages { get; set; }
        [MTParameter(Order = 8, FromFlag = 9, FlagType = FlagType.True)]
        public bool AddAdmins { get; set; }


    }
}
