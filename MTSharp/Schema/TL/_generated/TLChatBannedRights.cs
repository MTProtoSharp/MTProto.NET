using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9f120418)]
    public class TLChatBannedRights : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9f120418;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool ViewMessages { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool SendMessages { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.True)]
        public bool SendMedia { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.True)]
        public bool SendStickers { get; set; }
        [MTParameter(Order = 5, FromFlag = 4, FlagType = FlagType.True)]
        public bool SendGifs { get; set; }
        [MTParameter(Order = 6, FromFlag = 5, FlagType = FlagType.True)]
        public bool SendGames { get; set; }
        [MTParameter(Order = 7, FromFlag = 6, FlagType = FlagType.True)]
        public bool SendInline { get; set; }
        [MTParameter(Order = 8, FromFlag = 7, FlagType = FlagType.True)]
        public bool EmbedLinks { get; set; }
        [MTParameter(Order = 9, FromFlag = 8, FlagType = FlagType.True)]
        public bool SendPolls { get; set; }
        [MTParameter(Order = 10, FromFlag = 10, FlagType = FlagType.True)]
        public bool ChangeInfo { get; set; }
        [MTParameter(Order = 11, FromFlag = 15, FlagType = FlagType.True)]
        public bool InviteUsers { get; set; }
        [MTParameter(Order = 12, FromFlag = 17, FlagType = FlagType.True)]
        public bool PinMessages { get; set; }
        [MTParameter(Order = 13)]
        public int UntilDate { get; set; }


    }
}
