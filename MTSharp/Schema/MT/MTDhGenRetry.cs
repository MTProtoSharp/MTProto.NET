using MTSharp.Attributes;

namespace MTSharp.Schema.MT
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

        [MTParameter(Order = 0, BytesCount = 16)]
        public byte[] Nonce { get; set; }
        [MTParameter(Order = 1, BytesCount = 16)]
        public byte[] ServerNonce { get; set; }
        [MTParameter(Order = 2, BytesCount = 16)]
        public byte[] NewNonceHash2 { get; set; }


    }
}
