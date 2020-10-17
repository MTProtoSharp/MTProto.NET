using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xa9776773)]
    public class TLSendEncrypted : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa9776773;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLInputEncryptedChat Peer { get; set; }
        [MTParameter(Order = 1)]
        public long RandomId { get; set; }
        [MTParameter(Order = 2)]
        public byte[] Data { get; set; }


    }
}
