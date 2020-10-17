using MTProto.NET.Attributes;
using Org.BouncyCastle.Math;

namespace MTProto.NET.Schema.MT
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

        [MTParameter(Order = 0, BigIntegerBytesCount = 16)]
        public BigInteger Nonce { get; set; }
        [MTParameter(Order = 1, BigIntegerBytesCount = 16)]
        public BigInteger ServerNonce { get; set; }
        [MTParameter(Order = 2, BigIntegerBytesCount = 16)]
        public BigInteger NewNonceHash3 { get; set; }


    }
}
