using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x4a27eb2d)]
    public class TLStatsGraphAsync : TLAbsStatsGraph
    {
        public override uint Constructor
        {
            get
            {
                return 0x4a27eb2d;
            }
        }

        [MTParameter(Order = 0)]
        public string Token { get; set; }


    }
}
