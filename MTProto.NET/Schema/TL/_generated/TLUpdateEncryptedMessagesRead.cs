using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x38fe25b7)]
    public class TLUpdateEncryptedMessagesRead : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x38fe25b7;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public int MaxDate { get; set; }
        [MTParameter(Order = 2)]
        public int Date { get; set; }


    }
}
