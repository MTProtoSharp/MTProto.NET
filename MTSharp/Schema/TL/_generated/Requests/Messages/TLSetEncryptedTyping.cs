using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x791451ed)]
    public class TLSetEncryptedTyping : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x791451ed;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLInputEncryptedChat Peer { get; set; }
        [MTParameter(Order = 1)]
        public bool Typing { get; set; }


    }
}
