using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xf9d27a5a)]
    public class TLUpdateInlineBotCallbackQuery : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xf9d27a5a;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long QueryId { get; set; }
        [MTParameter(Order = 2)]
        public int UserId { get; set; }
        [MTParameter(Order = 3)]
        public MTSharp.Schema.TL.TLInputBotInlineMessageID MsgId { get; set; }
        [MTParameter(Order = 4)]
        public long ChatInstance { get; set; }
        [MTParameter(Order = 5, FlagBitId = 0, FlagType = FlagType.Null)]
        public byte[] Data { get; set; }
        [MTParameter(Order = 6, FlagBitId = 1, FlagType = FlagType.Null)]
        public string GameShortName { get; set; }


    }
}
