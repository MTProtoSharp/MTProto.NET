using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x209b82db)]
    public class TLChannelLocation : TLAbsChannelLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0x209b82db;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsGeoPoint GeoPoint { get; set; }
        [MTParameter(Order = 1)]
        public string Address { get; set; }


    }
}
