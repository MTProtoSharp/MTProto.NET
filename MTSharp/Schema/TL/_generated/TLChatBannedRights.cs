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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool ViewMessages { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool SendMessages { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool SendMedia { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.True)]
        public bool SendStickers { get; set; }
        [MTParameter(Order = 5, FlagBitId = 4, FlagType = FlagType.True)]
        public bool SendGifs { get; set; }
        [MTParameter(Order = 6, FlagBitId = 5, FlagType = FlagType.True)]
        public bool SendGames { get; set; }
        [MTParameter(Order = 7, FlagBitId = 6, FlagType = FlagType.True)]
        public bool SendInline { get; set; }
        [MTParameter(Order = 8, FlagBitId = 7, FlagType = FlagType.True)]
        public bool EmbedLinks { get; set; }
        [MTParameter(Order = 9, FlagBitId = 8, FlagType = FlagType.True)]
        public bool SendPolls { get; set; }
        [MTParameter(Order = 10, FlagBitId = 10, FlagType = FlagType.True)]
        public bool ChangeInfo { get; set; }
        [MTParameter(Order = 11, FlagBitId = 15, FlagType = FlagType.True)]
        public bool InviteUsers { get; set; }
        [MTParameter(Order = 12, FlagBitId = 17, FlagType = FlagType.True)]
        public bool PinMessages { get; set; }
        [MTParameter(Order = 13)]
        public int UntilDate { get; set; }


    }
}
