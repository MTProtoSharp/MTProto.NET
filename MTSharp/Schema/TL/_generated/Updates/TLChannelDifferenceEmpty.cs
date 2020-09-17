using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Updates
{
    [MTObject(0x3e11affb)]
    public class TLChannelDifferenceEmpty : TLAbsChannelDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0x3e11affb;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Final { get; set; }
        [MTParameter(Order = 2)]
        public int Pts { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.Null)]
        public int? Timeout { get; set; }


    }
}
