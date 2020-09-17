using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x23734b06)]
    public class TLEncryptedMessageService : TLAbsEncryptedMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x23734b06;
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


    }
}
