using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb637edaf)]
    public class TLStatsDateRangeDays : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb637edaf;
            }
        }

        [MTParameter(Order = 0)]
        public int MinDate { get; set; }
        [MTParameter(Order = 1)]
        public int MaxDate { get; set; }


    }
}
