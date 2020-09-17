using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5755785a)]
    public class TLPollResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5755785a;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Min { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.Null)]
        public TLVector<MTSharp.Schema.TL.TLPollAnswerVoters> Results { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.Null)]
        public int? TotalVoters { get; set; }


    }
}
