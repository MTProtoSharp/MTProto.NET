using MTProto.NET.Attributes;
using Org.BouncyCastle.Math;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x46dc1fb9)]
    public class MTDhGenRetry : MTAbsSetClientDhParamsAnswer
    {
        public override uint Constructor
        {
            get
            {
                return 0x46dc1fb9;
            }
        }

        [MTParameter(Order = 0, BigIntegerBytesCount = 16)]
        public BigInteger Nonce { get; set; }
        [MTParameter(Order = 1, BigIntegerBytesCount = 16)]
        public BigInteger ServerNonce { get; set; }
        [MTParameter(Order = 2, BigIntegerBytesCount = 16)]
        public BigInteger NewNonceHash2 { get; set; }


    }
}
