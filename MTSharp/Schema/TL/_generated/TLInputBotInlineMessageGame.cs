using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x4b425864)]
    public class TLInputBotInlineMessageGame : TLAbsInputBotInlineMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x4b425864;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }


    }
}
