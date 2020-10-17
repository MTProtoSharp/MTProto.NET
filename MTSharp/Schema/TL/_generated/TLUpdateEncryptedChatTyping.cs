using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1710f156)]
    public class TLUpdateEncryptedChatTyping : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x1710f156;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }


    }
}
