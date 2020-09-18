using MTSharp.Attributes;
using Org.BouncyCastle.Math;

namespace MTSharp.Schema.MT
{
    [MTObject(0x3bcbf734)]
    public class MTDhGenOk : MTAbsSetClientDhParamsAnswer
    {
        public override uint Constructor
        {
            get
            {
                return 0x3bcbf734;
            }
        }

        [MTParameter(Order = 0, BigIntegerBytesCount = 16)]
        public BigInteger Nonce { get; set; }
        [MTParameter(Order = 1, BigIntegerBytesCount = 16)]
        public BigInteger ServerNonce { get; set; }
        [MTParameter(Order = 2, BigIntegerBytesCount = 16)]
        public BigInteger NewNonceHash1 { get; set; }


    }
}
