using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x5ce14175)]
    public class TLPopularContact : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5ce14175;
            }
        }

        [MTParameter(Order = 0)]
        public long ClientId { get; set; }
        [MTParameter(Order = 1)]
        public int Importers { get; set; }


    }
}
