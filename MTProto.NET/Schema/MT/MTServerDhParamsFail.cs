using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x79cb045d)]
    public class MTServerDhParamsFail : MTAbsServerDhParams
    {
        public override uint Constructor
        {
            get
            {
                return 0x79cb045d;
            }
        }

        [MTParameter(Order = 0, BigIntegerBytesCount = 16)]
        public byte[] Nonce { get; set; }
        [MTParameter(Order = 1, BigIntegerBytesCount = 16)]
        public byte[] ServerNonce { get; set; }
        [MTParameter(Order = 2, BigIntegerBytesCount = 16)]
        public byte[] NewNonceHash { get; set; }


    }
}
