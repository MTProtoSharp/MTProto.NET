using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf9c44144)]
    public class TLInputMediaGeoPoint : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xf9c44144;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputGeoPoint GeoPoint { get; set; }


    }
}
