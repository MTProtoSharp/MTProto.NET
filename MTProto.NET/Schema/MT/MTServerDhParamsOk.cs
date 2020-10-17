using MTProto.NET.Attributes;
using Org.BouncyCastle.Math;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0xd0e8075c)]
    public class MTServerDhParamsOk : MTAbsServerDhParams
    {
        public override uint Constructor
        {
            get
            {
                return 0xd0e8075c;
            }
        }

        [MTParameter(Order = 0, BigIntegerBytesCount = 16)]
        public BigInteger Nonce { get; set; }
        [MTParameter(Order = 1, BigIntegerBytesCount = 16)]
        public BigInteger ServerNonce { get; set; }
        [MTParameter(Order = 2)]
        public byte[] EncryptedAnswer { get; set; }


    }
}
