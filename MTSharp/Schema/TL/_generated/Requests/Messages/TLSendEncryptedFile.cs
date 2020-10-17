using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x9a901b66)]
    public class TLSendEncryptedFile : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9a901b66;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLInputEncryptedChat Peer { get; set; }
        [MTParameter(Order = 1)]
        public long RandomId { get; set; }
        [MTParameter(Order = 2)]
        public byte[] Data { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsInputEncryptedFile File { get; set; }


    }
}
