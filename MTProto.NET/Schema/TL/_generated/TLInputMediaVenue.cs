using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc13d1c11)]
    public class TLInputMediaVenue : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xc13d1c11;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputGeoPoint GeoPoint { get; set; }
        [MTParameter(Order = 1)]
        public string Title { get; set; }
        [MTParameter(Order = 2)]
        public string Address { get; set; }
        [MTParameter(Order = 3)]
        public string Provider { get; set; }
        [MTParameter(Order = 4)]
        public string VenueId { get; set; }
        [MTParameter(Order = 5)]
        public string VenueType { get; set; }


    }
}
