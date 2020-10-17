using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0xcdd42a05)]
    public class TLBindTempAuthKey : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcdd42a05;
            }
        }

        [MTParameter(Order = 0)]
        public long PermAuthKeyId { get; set; }
        [MTParameter(Order = 1)]
        public long Nonce { get; set; }
        [MTParameter(Order = 2)]
        public int ExpiresAt { get; set; }
        [MTParameter(Order = 3)]
        public byte[] EncryptedMessage { get; set; }


    }
}
