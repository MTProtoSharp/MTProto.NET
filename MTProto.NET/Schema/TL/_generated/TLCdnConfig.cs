using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x5725e40a)]
    public class TLCdnConfig : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5725e40a;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTProto.NET.Schema.TL.TLCdnPublicKey> PublicKeys { get; set; }


    }
}
