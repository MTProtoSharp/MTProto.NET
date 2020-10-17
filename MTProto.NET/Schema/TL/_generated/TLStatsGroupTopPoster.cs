using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x18f3d0f7)]
    public class TLStatsGroupTopPoster : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x18f3d0f7;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int Messages { get; set; }
        [MTParameter(Order = 2)]
        public int AvgChars { get; set; }


    }
}
