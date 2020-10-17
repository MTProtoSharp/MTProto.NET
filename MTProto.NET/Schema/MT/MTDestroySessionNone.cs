using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x62d350c9)]
    public class MTDestroySessionNone : MTAbsDestroySessionRes
    {
        public override uint Constructor
        {
            get
            {
                return 0x62d350c9;
            }
        }

        [MTParameter(Order = 0)]
        public long SessionId { get; set; }


    }
}
