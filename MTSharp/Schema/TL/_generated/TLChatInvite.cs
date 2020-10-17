using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xdfc2f58e)]
    public class TLChatInvite : TLAbsChatInvite
    {
        public override uint Constructor
        {
            get
            {
                return 0xdfc2f58e;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Channel { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Broadcast { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool Public { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.True)]
        public bool Megagroup { get; set; }
        [MTParameter(Order = 5)]
        public string Title { get; set; }
        [MTParameter(Order = 6)]
        public TLAbsPhoto Photo { get; set; }
        [MTParameter(Order = 7)]
        public int ParticipantsCount { get; set; }
        [MTParameter(Order = 8, FlagBitId = 4, FlagType = FlagType.Null)]
        public TLVector<TLAbsUser> Participants { get; set; }


    }
}
