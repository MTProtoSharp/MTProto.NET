using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc1b15d65)]
    public class TLInputBotInlineMessageMediaGeo : TLAbsInputBotInlineMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0xc1b15d65;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputGeoPoint GeoPoint { get; set; }
        [MTParameter(Order = 2)]
        public int Period { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }


    }
}
