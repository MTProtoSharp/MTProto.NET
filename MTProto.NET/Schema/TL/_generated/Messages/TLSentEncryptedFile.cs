using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0x9493ff32)]
    public class TLSentEncryptedFile : TLAbsSentEncryptedMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x9493ff32;
            }
        }

        [MTParameter(Order = 0)]
        public int Date { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsEncryptedFile File { get; set; }


    }
}
