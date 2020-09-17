using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x914fbf11)]
    public class TLUpdateShortMessage : TLAbsUpdates
    {
        public override uint Constructor
        {
            get
            {
                return 0x914fbf11;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool Out { get; set; }
        [MTParameter(Order = 2, FromFlag = 4, FlagType = FlagType.True)]
        public bool Mentioned { get; set; }
        [MTParameter(Order = 3, FromFlag = 5, FlagType = FlagType.True)]
        public bool MediaUnread { get; set; }
        [MTParameter(Order = 4, FromFlag = 13, FlagType = FlagType.True)]
        public bool Silent { get; set; }
        [MTParameter(Order = 5)]
        public int Id { get; set; }
        [MTParameter(Order = 6)]
        public int UserId { get; set; }
        [MTParameter(Order = 7)]
        public string Message { get; set; }
        [MTParameter(Order = 8)]
        public int Pts { get; set; }
        [MTParameter(Order = 9)]
        public int PtsCount { get; set; }
        [MTParameter(Order = 10)]
        public int Date { get; set; }
        [MTParameter(Order = 11, FromFlag = 2, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLMessageFwdHeader FwdFrom { get; set; }
        [MTParameter(Order = 12, FromFlag = 11, FlagType = FlagType.Null)]
        public int? ViaBotId { get; set; }
        [MTParameter(Order = 13, FromFlag = 3, FlagType = FlagType.Null)]
        public int? ReplyToMsgId { get; set; }
        [MTParameter(Order = 14, FromFlag = 7, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
