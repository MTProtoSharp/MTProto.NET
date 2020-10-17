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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Out { get; set; }
        [MTParameter(Order = 2, FlagBitId = 4, FlagType = FlagType.True)]
        public bool Mentioned { get; set; }
        [MTParameter(Order = 3, FlagBitId = 5, FlagType = FlagType.True)]
        public bool MediaUnread { get; set; }
        [MTParameter(Order = 4, FlagBitId = 13, FlagType = FlagType.True)]
        public bool Silent { get; set; }
        [MTParameter(Order = 5, FlagBitId = 14, FlagType = FlagType.True)]
        public bool Post { get; set; }
        [MTParameter(Order = 6, FlagBitId = 18, FlagType = FlagType.True)]
        public bool FromScheduled { get; set; }
        [MTParameter(Order = 7, FlagBitId = 19, FlagType = FlagType.True)]
        public bool Legacy { get; set; }
        [MTParameter(Order = 8, FlagBitId = 21, FlagType = FlagType.True)]
        public bool EditHide { get; set; }
        [MTParameter(Order = 9)]
        public int Id { get; set; }
        [MTParameter(Order = 10, FlagBitId = 8, FlagType = FlagType.Null)]
        public int? FromId { get; set; }
        [MTParameter(Order = 11)]
        public TLAbsPeer ToId { get; set; }
        [MTParameter(Order = 12, FlagBitId = 2, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLMessageFwdHeader FwdFrom { get; set; }
        [MTParameter(Order = 13, FlagBitId = 11, FlagType = FlagType.Null)]
        public int? ViaBotId { get; set; }
        [MTParameter(Order = 14, FlagBitId = 3, FlagType = FlagType.Null)]
        public int? ReplyToMsgId { get; set; }
        [MTParameter(Order = 15)]
        public int Date { get; set; }
        [MTParameter(Order = 16)]
        public string Message { get; set; }
        [MTParameter(Order = 17, FlagBitId = 9, FlagType = FlagType.Null)]
        public TLAbsMessageMedia Media { get; set; }
        [MTParameter(Order = 18, FlagBitId = 6, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }
        [MTParameter(Order = 19, FlagBitId = 7, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 20, FlagBitId = 10, FlagType = FlagType.Null)]
        public int? Views { get; set; }
        [MTParameter(Order = 21, FlagBitId = 15, FlagType = FlagType.Null)]
        public int? EditDate { get; set; }
        [MTParameter(Order = 22, FlagBitId = 16, FlagType = FlagType.Null)]
        public string PostAuthor { get; set; }
        [MTParameter(Order = 23, FlagBitId = 17, FlagType = FlagType.Null)]
        public long? GroupedId { get; set; }
        [MTParameter(Order = 24, FlagBitId = 22, FlagType = FlagType.Null)]
        public TLVector<MTSharp.Schema.TL.TLRestrictionReason> RestrictionReason { get; set; }


    }
}
