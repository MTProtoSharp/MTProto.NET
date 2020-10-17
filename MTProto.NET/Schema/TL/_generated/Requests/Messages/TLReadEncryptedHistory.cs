using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x7f4b690a)]
    public class TLReadEncryptedHistory : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x7f4b690a;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLInputEncryptedChat Peer { get; set; }
        [MTParameter(Order = 1)]
        public int MaxDate { get; set; }


    }
}
