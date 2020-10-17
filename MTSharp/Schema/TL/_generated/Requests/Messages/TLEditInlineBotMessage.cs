using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x83557dba)]
    public class TLEditInlineBotMessage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x83557dba;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool NoWebpage { get; set; }
        [MTParameter(Order = 2)]
        public MTSharp.Schema.TL.TLInputBotInlineMessageID Id { get; set; }
        [MTParameter(Order = 3, FlagBitId = 11, FlagType = FlagType.Null)]
        public string Message { get; set; }
        [MTParameter(Order = 4, FlagBitId = 14, FlagType = FlagType.Null)]
        public TLAbsInputMedia Media { get; set; }
        [MTParameter(Order = 5, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }
        [MTParameter(Order = 6, FlagBitId = 3, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
