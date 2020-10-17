using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xab7ec0a0)]
    public class TLEncryptedChatEmpty : TLAbsEncryptedChat
    {
        public override uint Constructor
        {
            get
            {
                return 0xab7ec0a0;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }


    }
}
