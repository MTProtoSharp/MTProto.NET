using MTSharp.Attributes;

namespace MTSharp.Schema.MT
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

        [MTParameter(Order = 0, BytesCount = 16)]
        public byte[] Nonce { get; set; }
        [MTParameter(Order = 1, BytesCount = 16)]
        public byte[] ServerNonce { get; set; }
        [MTParameter(Order = 2)]
        public byte[] EncryptedAnswer { get; set; }


    }
}
