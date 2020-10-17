using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xf64daf43)]
    public class TLRequestEncryption : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf64daf43;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 1)]
        public int RandomId { get; set; }
        [MTParameter(Order = 2)]
        public byte[] GA { get; set; }


    }
}
