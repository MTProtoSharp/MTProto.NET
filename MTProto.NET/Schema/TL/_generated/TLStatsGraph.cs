using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x8ea464b6)]
    public class TLStatsGraph : TLAbsStatsGraph
    {
        public override uint Constructor
        {
            get
            {
                return 0x8ea464b6;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLDataJSON Json { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public string ZoomToken { get; set; }


    }
}
