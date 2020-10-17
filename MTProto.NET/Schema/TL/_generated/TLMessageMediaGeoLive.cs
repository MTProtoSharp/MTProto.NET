using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7c3c2609)]
    public class TLMessageMediaGeoLive : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x7c3c2609;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsGeoPoint Geo { get; set; }
        [MTParameter(Order = 1)]
        public int Period { get; set; }


    }
}
