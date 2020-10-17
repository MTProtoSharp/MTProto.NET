using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xcb43acde)]
    public class TLStatsAbsValueAndPrev : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcb43acde;
            }
        }

        [MTParameter(Order = 0)]
        public double Current { get; set; }
        [MTParameter(Order = 1)]
        public double Previous { get; set; }


    }
}
