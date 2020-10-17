using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9e19a1f6)]
    public class TLMessageService : TLAbsMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x9e19a1f6;
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
        [MTParameter(Order = 6, FlagBitId = 19, FlagType = FlagType.True)]
        public bool Legacy { get; set; }
        [MTParameter(Order = 7)]
        public int Id { get; set; }
        [MTParameter(Order = 8, FlagBitId = 8, FlagType = FlagType.Null)]
        public int? FromId { get; set; }
        [MTParameter(Order = 9)]
        public TLAbsPeer ToId { get; set; }
        [MTParameter(Order = 10, FlagBitId = 3, FlagType = FlagType.Null)]
        public int? ReplyToMsgId { get; set; }
        [MTParameter(Order = 11)]
        public int Date { get; set; }
        [MTParameter(Order = 12)]
        public TLAbsMessageAction Action { get; set; }


    }
}
