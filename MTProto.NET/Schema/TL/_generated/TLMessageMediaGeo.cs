using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x56e0d474)]
    public class TLMessageMediaGeo : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x56e0d474;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsGeoPoint Geo { get; set; }


    }
}
