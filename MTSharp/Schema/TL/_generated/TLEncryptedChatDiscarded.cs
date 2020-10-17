using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x13d6dd27)]
    public class TLEncryptedChatDiscarded : TLAbsEncryptedChat
    {
        public override uint Constructor
        {
            get
            {
                return 0x13d6dd27;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }


    }
}
