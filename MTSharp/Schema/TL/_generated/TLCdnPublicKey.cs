using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc982eaba)]
    public class TLCdnPublicKey : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc982eaba;
            }
        }

        [MTParameter(Order = 0)]
        public int DcId { get; set; }
        [MTParameter(Order = 1)]
        public string PublicKey { get; set; }


    }
}
