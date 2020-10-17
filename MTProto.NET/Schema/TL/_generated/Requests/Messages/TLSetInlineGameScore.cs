using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x15ad9f64)]
    public class TLSetInlineGameScore : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x15ad9f64;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool EditMessage { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Force { get; set; }
        [MTParameter(Order = 3)]
        public MTProto.NET.Schema.TL.TLInputBotInlineMessageID Id { get; set; }
        [MTParameter(Order = 4)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 5)]
        public int Score { get; set; }


    }
}
