using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
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
        [MTParameter(Order = 11, FlagBitId = 2, FlagType = FlagType.Null)]
        public MTProto.NET.Schema.TL.TLMessageFwdHeader FwdFrom { get; set; }
        [MTParameter(Order = 12, FlagBitId = 11, FlagType = FlagType.Null)]
        public int? ViaBotId { get; set; }
        [MTParameter(Order = 13, FlagBitId = 3, FlagType = FlagType.Null)]
        public int? ReplyToMsgId { get; set; }
        [MTParameter(Order = 14, FlagBitId = 7, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
