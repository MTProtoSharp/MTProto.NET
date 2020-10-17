using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0xf35c6d01)]
    public class MTRpcResult : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf35c6d01;
            }
        }

        [MTParameter(Order = 0)]
        public long ReqMsgId { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.MT.MTGzipPacked Result { get; set; }


    }
}
