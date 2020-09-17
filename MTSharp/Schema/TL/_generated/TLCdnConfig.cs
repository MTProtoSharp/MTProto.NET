using MTSharp.Attributes;

namespace MTSharp.Schema.TL
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
        public TLVector<MTSharp.Schema.TL.TLCdnPublicKey> PublicKeys { get; set; }


    }
}
