using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa8d864a7)]
    public class TLInputBotInlineResultPhoto : TLAbsInputBotInlineResult
    {
        public override uint Constructor
        {
            get
            {
                return 0xa8d864a7;
            }
        }

        [MTParameter(Order = 0)]
        public string Id { get; set; }
        [MTParameter(Order = 1)]
        public string Type { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputPhoto Photo { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsInputBotInlineMessage SendMessage { get; set; }


    }
}
