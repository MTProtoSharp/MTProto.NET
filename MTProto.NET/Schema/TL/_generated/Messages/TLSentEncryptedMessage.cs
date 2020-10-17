using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0x560f8935)]
    public class TLSentEncryptedMessage : TLAbsSentEncryptedMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x560f8935;
            }
        }

        [MTParameter(Order = 0)]
        public int Date { get; set; }


    }
}
