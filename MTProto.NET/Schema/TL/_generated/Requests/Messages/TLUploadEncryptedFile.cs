using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x5057c497)]
    public class TLUploadEncryptedFile : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5057c497;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLInputEncryptedChat Peer { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputEncryptedFile File { get; set; }


    }
}
