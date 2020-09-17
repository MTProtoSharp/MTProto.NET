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
        [MTParameter(Order = 6, FromFlag = 19, FlagType = FlagType.True)]
        public bool Legacy { get; set; }
        [MTParameter(Order = 7)]
        public int Id { get; set; }
        [MTParameter(Order = 8, FromFlag = 8, FlagType = FlagType.Null)]
        public int? FromId { get; set; }
        [MTParameter(Order = 9)]
        public TLAbsPeer ToId { get; set; }
        [MTParameter(Order = 10, FromFlag = 3, FlagType = FlagType.Null)]
        public int? ReplyToMsgId { get; set; }
        [MTParameter(Order = 11)]
        public int Date { get; set; }
        [MTParameter(Order = 12)]
        public TLAbsMessageAction Action { get; set; }


    }
}
