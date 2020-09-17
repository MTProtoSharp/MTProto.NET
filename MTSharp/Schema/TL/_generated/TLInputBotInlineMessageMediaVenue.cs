using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x417bbf11)]
    public class TLInputBotInlineMessageMediaVenue : TLAbsInputBotInlineMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x417bbf11;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputGeoPoint GeoPoint { get; set; }
        [MTParameter(Order = 2)]
        public string Title { get; set; }
        [MTParameter(Order = 3)]
        public string Address { get; set; }
        [MTParameter(Order = 4)]
        public string Provider { get; set; }
        [MTParameter(Order = 5)]
        public string VenueId { get; set; }
        [MTParameter(Order = 6)]
        public string VenueType { get; set; }
        [MTParameter(Order = 7, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }


    }
}
