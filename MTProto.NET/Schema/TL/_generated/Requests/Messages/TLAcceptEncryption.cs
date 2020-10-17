using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x3dbc0415)]
    public class TLAcceptEncryption : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3dbc0415;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLInputEncryptedChat Peer { get; set; }
        [MTParameter(Order = 1)]
        public byte[] GB { get; set; }
        [MTParameter(Order = 2)]
        public long KeyFingerprint { get; set; }


    }
}
