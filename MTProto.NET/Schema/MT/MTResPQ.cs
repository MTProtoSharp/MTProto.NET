using MTProto.NET.Attributes;
using MTProto.NET.Schema.TL;
using Org.BouncyCastle.Math;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x5162463)]
    public class MTResPQ : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5162463;
            }
        }

        [MTParameter(Order = 0, BigIntegerBytesCount = 16)]
        public BigInteger Nonce { get; set; }
        [MTParameter(Order = 1, BigIntegerBytesCount = 16)]
        public BigInteger ServerNonce { get; set; }
        [MTParameter(Order = 2)]
        public byte[] Pq { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<long> ServerPublicKeyFingerprints { get; set; }


    }
}
