using MTSharp.Attributes;

namespace MTSharp.Schema.MT.Requests
{
    [MTObject(0xf5045f1f)]
    public class MTSetClientDhParams : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf5045f1f;
            }
        }

        [MTParameter(Order = 0, BytesCount = 16)]
        public byte[] Nonce { get; set; }
        [MTParameter(Order = 1, BytesCount = 16)]
        public byte[] ServerNonce { get; set; }
        [MTParameter(Order = 2)]
        public byte[] EncryptedData { get; set; }


    }
}
