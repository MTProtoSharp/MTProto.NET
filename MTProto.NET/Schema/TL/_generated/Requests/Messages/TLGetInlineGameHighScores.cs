using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xf635e1b)]
    public class TLGetInlineGameHighScores : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf635e1b;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLInputBotInlineMessageID Id { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputUser UserId { get; set; }


    }
}
