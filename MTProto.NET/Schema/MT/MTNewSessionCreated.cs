using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x9ec20908)]
    public class MTNewSessionCreated : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9ec20908;
            }
        }

        [MTParameter(Order = 0)]
        public long FirstMsgId { get; set; }
        [MTParameter(Order = 1)]
        public long UniqueId { get; set; }
        [MTParameter(Order = 2)]
        public long ServerSalt { get; set; }


    }
}
