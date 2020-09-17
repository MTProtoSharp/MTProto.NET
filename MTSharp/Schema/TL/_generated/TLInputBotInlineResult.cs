using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x88bf9319)]
    public class TLInputBotInlineResult : TLAbsInputBotInlineResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x88bf9319;
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
        public MTSharp.Schema.TL.TLInputWebDocument Thumb { get; set; }
        [MTParameter(Order = 7, FromFlag = 5, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLInputWebDocument Content { get; set; }
        [MTParameter(Order = 8)]
        public TLAbsInputBotInlineMessage SendMessage { get; set; }


    }
}
