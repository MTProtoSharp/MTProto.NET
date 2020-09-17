using MTSharp.Attributes;
using Org.BouncyCastle.Math;

namespace MTSharp.Schema.MT
{
    [MTObject(0xa69dae02)]
    public class MTDhGenFail : MTAbsSetClientDhParamsAnswer
    {
        public override uint Constructor
        {
            get
            {
                return 0xa69dae02;
            }
        }

        [MTParameter(Order = 0, BytesCount = 16)]
        public BigInteger Nonce { get; set; }
        [MTParameter(Order = 1, BytesCount = 16)]
        public BigInteger ServerNonce { get; set; }
        [MTParameter(Order = 2, BytesCount = 16)]
        public BigInteger NewNonceHash3 { get; set; }


    }
}
