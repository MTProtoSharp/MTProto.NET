using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1117dd5f)]
    public class TLGeoPointEmpty : TLAbsGeoPoint
    {
        public override uint Constructor
        {
            get
            {
                return 0x1117dd5f;
            }
        }



    }
}
