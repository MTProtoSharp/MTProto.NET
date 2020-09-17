using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x11965f3a)]
    public class TLBotInlineResult : TLAbsBotInlineResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x11965f3a;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Id { get; set; }
        [MTParameter(Order = 2)]
        public string Type { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.Null)]
        public string Title { get; set; }
        [MTParameter(Order = 4, FromFlag = 2, FlagType = FlagType.Null)]
        public string Description { get; set; }
        [MTParameter(Order = 5, FromFlag = 3, FlagType = FlagType.Null)]
        public string Url { get; set; }
        [MTParameter(Order = 6, FromFlag = 4, FlagType = FlagType.Null)]
        public TLAbsWebDocument Thumb { get; set; }
        [MTParameter(Order = 7, FromFlag = 5, FlagType = FlagType.Null)]
        public TLAbsWebDocument Content { get; set; }
        [MTParameter(Order = 8)]
        public TLAbsBotInlineMessage SendMessage { get; set; }


    }
}
