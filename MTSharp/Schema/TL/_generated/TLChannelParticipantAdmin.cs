using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xccbebbaf)]
    public class TLChannelParticipantAdmin : TLAbsChannelParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0xccbebbaf;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool CanEdit { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool Self { get; set; }
        [MTParameter(Order = 3)]
        public int UserId { get; set; }
        [MTParameter(Order = 4, FromFlag = 1, FlagType = FlagType.Null)]
        public int? InviterId { get; set; }
        [MTParameter(Order = 5)]
        public int PromotedBy { get; set; }
        [MTParameter(Order = 6)]
        public int Date { get; set; }
        [MTParameter(Order = 7)]
        public MTSharp.Schema.TL.TLChatAdminRights AdminRights { get; set; }
        [MTParameter(Order = 8, FromFlag = 2, FlagType = FlagType.Null)]
        public string Rank { get; set; }


    }
}
