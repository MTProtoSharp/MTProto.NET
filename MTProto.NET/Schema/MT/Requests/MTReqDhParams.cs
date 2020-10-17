using MTProto.NET.Attributes;
using Org.BouncyCastle.Math;

namespace MTProto.NET.Schema.MT.Requests
{
    [MTObject(0xd712e4be)]
    public class MTReqDhParams : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd712e4be;
            }
        }

        [MTParameter(Order = 0, BigIntegerBytesCount = 16)]
        public BigInteger Nonce { get; set; }
        [MTParameter(Order = 1, BigIntegerBytesCount = 16)]
        public BigInteger ServerNonce { get; set; }
        [MTParameter(Order = 2)]
        public byte[] P { get; set; }
        [MTParameter(Order = 3)]
        public byte[] Q { get; set; }
        [MTParameter(Order = 4)]
        public long PublicKeyFingerprint { get; set; }
        [MTParameter(Order = 5)]
        public byte[] EncryptedData { get; set; }


    }
}
