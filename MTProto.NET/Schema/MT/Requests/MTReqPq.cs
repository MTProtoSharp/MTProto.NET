using MTProto.NET.Attributes;
using Org.BouncyCastle.Math;

namespace MTProto.NET.Schema.MT.Requests
{
    [MTObject(0x60469778)]
    public class MTReqPq : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x60469778;
            }
        }

        [MTParameter(Order = 0, BigIntegerBytesCount = 16)]
        public BigInteger Nonce { get; set; }


    }
}
