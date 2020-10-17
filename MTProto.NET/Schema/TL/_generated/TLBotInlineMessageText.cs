using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x8c7f65e2)]
    public class TLBotInlineMessageText : TLAbsBotInlineMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x8c7f65e2;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool NoWebpage { get; set; }
        [MTParameter(Order = 2)]
        public string Message { get; set; }
        [MTParameter(Order = 3, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 4, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }


    }
}
