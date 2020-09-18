using MTSharp.Attributes;
using Org.BouncyCastle.Math;

namespace MTSharp.Schema.MT
{
    [MTObject(0x83c95aec)]
    public class MTPQInnerData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x83c95aec;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Pq { get; set; }
        [MTParameter(Order = 1)]
        public byte[] P { get; set; }
        [MTParameter(Order = 2)]
        public byte[] Q { get; set; }
        [MTParameter(Order = 3, BigIntegerBytesCount = 16)]
        public BigInteger Nonce { get; set; }
        [MTParameter(Order = 4, BigIntegerBytesCount = 16)]
        public BigInteger ServerNonce { get; set; }
        [MTParameter(Order = 5, BigIntegerBytesCount = 32)]
        public BigInteger NewNonce { get; set; }


    }
}
