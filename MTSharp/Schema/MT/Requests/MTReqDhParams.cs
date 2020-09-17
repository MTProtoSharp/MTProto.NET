using MTSharp.Attributes;

namespace MTSharp.Schema.MT.Requests
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

        [MTParameter(Order = 0, BytesCount = 16)]
        public byte[] Nonce { get; set; }
        [MTParameter(Order = 1, BytesCount = 16)]
        public byte[] ServerNonce { get; set; }
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
