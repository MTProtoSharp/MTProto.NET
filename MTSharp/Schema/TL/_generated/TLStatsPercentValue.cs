using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xcbce2fe0)]
    public class TLStatsPercentValue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcbce2fe0;
            }
        }

        [MTParameter(Order = 0)]
        public double Part { get; set; }
        [MTParameter(Order = 1)]
        public double Total { get; set; }


    }
}
