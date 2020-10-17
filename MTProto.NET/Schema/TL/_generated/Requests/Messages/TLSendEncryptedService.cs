using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x32d439a4)]
    public class TLSendEncryptedService : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x32d439a4;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLInputEncryptedChat Peer { get; set; }
        [MTParameter(Order = 1)]
        public long RandomId { get; set; }
        [MTParameter(Order = 2)]
        public byte[] Data { get; set; }


    }
}
