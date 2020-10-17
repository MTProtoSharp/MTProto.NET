using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6014f412)]
    public class TLStatsGroupTopAdmin : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6014f412;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int Deleted { get; set; }
        [MTParameter(Order = 2)]
        public int Kicked { get; set; }
        [MTParameter(Order = 3)]
        public int Banned { get; set; }


    }
}
