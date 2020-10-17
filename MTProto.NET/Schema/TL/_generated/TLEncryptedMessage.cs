using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xed18c118)]
    public class TLEncryptedMessage : TLAbsEncryptedMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0xed18c118;
            }
        }

        [MTParameter(Order = 0)]
        public long RandomId { get; set; }
        [MTParameter(Order = 1)]
        public int ChatId { get; set; }
        [MTParameter(Order = 2)]
        public int Date { get; set; }
        [MTParameter(Order = 3)]
        public byte[] Bytes { get; set; }
        [MTParameter(Order = 4)]
        public TLAbsEncryptedFile File { get; set; }


    }
}
