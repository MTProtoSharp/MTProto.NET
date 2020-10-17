using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
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
        public MTProto.NET.Schema.TL.TLInputEncryptedChat Peer { get; set; }
        [MTParameter(Order = 1)]
        public bool Typing { get; set; }


    }
}
