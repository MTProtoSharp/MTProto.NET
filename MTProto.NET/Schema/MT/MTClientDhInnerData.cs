using MTProto.NET.Attributes;
using Org.BouncyCastle.Math;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x6643b654)]
    public class MTClientDhInnerData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6643b654;
            }
        }

        [MTParameter(Order = 0, BigIntegerBytesCount = 16)]
        public BigInteger Nonce { get; set; }
        [MTParameter(Order = 1, BigIntegerBytesCount = 16)]
        public BigInteger ServerNonce { get; set; }
        [MTParameter(Order = 2)]
        public long RetryId { get; set; }
        [MTParameter(Order = 3)]
        public byte[] GB { get; set; }


    }
}
