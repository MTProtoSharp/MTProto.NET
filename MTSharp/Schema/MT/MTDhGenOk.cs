using MTSharp.Attributes;

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

        [MTParameter(Order = 0, BytesCount = 16)]
        public byte[] Nonce { get; set; }
        [MTParameter(Order = 1, BytesCount = 16)]
        public byte[] ServerNonce { get; set; }
        [MTParameter(Order = 2, BytesCount = 16)]
        public byte[] NewNonceHash1 { get; set; }


    }
}
