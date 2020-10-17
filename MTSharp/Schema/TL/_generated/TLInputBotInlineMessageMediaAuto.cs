using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x3380c786)]
    public class TLInputBotInlineMessageMediaAuto : TLAbsInputBotInlineMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x3380c786;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Message { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }


    }
}
