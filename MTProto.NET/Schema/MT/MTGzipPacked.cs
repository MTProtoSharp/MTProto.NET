using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x3072cfa1)]
    public class MTGzipPacked : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3072cfa1;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] PackedData { get; set; }


    }
}
