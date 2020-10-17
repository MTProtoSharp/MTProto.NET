using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xe7027c94)]
    public class TLAcceptAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe7027c94;
            }
        }

        [MTParameter(Order = 0)]
        public int BotId { get; set; }
        [MTParameter(Order = 1)]
        public string Scope { get; set; }
        [MTParameter(Order = 2)]
        public string PublicKey { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<MTProto.NET.Schema.TL.TLSecureValueHash> ValueHashes { get; set; }
        [MTParameter(Order = 4)]
        public MTProto.NET.Schema.TL.TLSecureCredentialsEncrypted Credentials { get; set; }


    }
}
