using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x2144ca19)]
    public class MTRpcError : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2144ca19;
            }
        }

        [MTParameter(Order = 0)]
        public int ErrorCode { get; set; }
        [MTParameter(Order = 1)]
        public string ErrorMessage { get; set; }


    }
}
