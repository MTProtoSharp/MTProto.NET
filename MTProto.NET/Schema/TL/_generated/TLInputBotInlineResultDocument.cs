using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfff8fdc4)]
    public class TLInputBotInlineResultDocument : TLAbsInputBotInlineResult
    {
        public override uint Constructor
        {
            get
            {
                return 0xfff8fdc4;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Id { get; set; }
        [MTParameter(Order = 2)]
        public string Type { get; set; }
        [MTParameter(Order = 3, FlagBitId = 1, FlagType = FlagType.Null)]
        public string Title { get; set; }
        [MTParameter(Order = 4, FlagBitId = 2, FlagType = FlagType.Null)]
        public string Description { get; set; }
        [MTParameter(Order = 5)]
        public TLAbsInputDocument Document { get; set; }
        [MTParameter(Order = 6)]
        public TLAbsInputBotInlineMessage SendMessage { get; set; }


    }
}
