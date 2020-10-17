using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xbedc9822)]
    public class TLStatsGraphError : TLAbsStatsGraph
    {
        public override uint Constructor
        {
            get
            {
                return 0xbedc9822;
            }
        }

        [MTParameter(Order = 0)]
        public string Error { get; set; }


    }
}
