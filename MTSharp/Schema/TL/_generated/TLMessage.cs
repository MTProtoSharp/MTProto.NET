using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x452c0e65)]
    public class TLMessage : TLAbsMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x452c0e65;
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
        [MTParameter(Order = 5, FromFlag = 14, FlagType = FlagType.True)]
        public bool Post { get; set; }
        [MTParameter(Order = 6, FromFlag = 18, FlagType = FlagType.True)]
        public bool FromScheduled { get; set; }
        [MTParameter(Order = 7, FromFlag = 19, FlagType = FlagType.True)]
        public bool Legacy { get; set; }
        [MTParameter(Order = 8, FromFlag = 21, FlagType = FlagType.True)]
        public bool EditHide { get; set; }
        [MTParameter(Order = 9)]
        public int Id { get; set; }
        [MTParameter(Order = 10, FromFlag = 8, FlagType = FlagType.Null)]
        public int? FromId { get; set; }
        [MTParameter(Order = 11)]
        public TLAbsPeer ToId { get; set; }
        [MTParameter(Order = 12, FromFlag = 2, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLMessageFwdHeader FwdFrom { get; set; }
        [MTParameter(Order = 13, FromFlag = 11, FlagType = FlagType.Null)]
        public int? ViaBotId { get; set; }
        [MTParameter(Order = 14, FromFlag = 3, FlagType = FlagType.Null)]
        public int? ReplyToMsgId { get; set; }
        [MTParameter(Order = 15)]
        public int Date { get; set; }
        [MTParameter(Order = 16)]
        public string Message { get; set; }
        [MTParameter(Order = 17, FromFlag = 9, FlagType = FlagType.Null)]
        public TLAbsMessageMedia Media { get; set; }
        [MTParameter(Order = 18, FromFlag = 6, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }
        [MTParameter(Order = 19, FromFlag = 7, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 20, FromFlag = 10, FlagType = FlagType.Null)]
        public int? Views { get; set; }
        [MTParameter(Order = 21, FromFlag = 15, FlagType = FlagType.Null)]
        public int? EditDate { get; set; }
        [MTParameter(Order = 22, FromFlag = 16, FlagType = FlagType.Null)]
        public string PostAuthor { get; set; }
        [MTParameter(Order = 23, FromFlag = 17, FlagType = FlagType.Null)]
        public long? GroupedId { get; set; }
        [MTParameter(Order = 24, FromFlag = 22, FlagType = FlagType.Null)]
        public TLVector<MTSharp.Schema.TL.TLRestrictionReason> RestrictionReason { get; set; }


    }
}
