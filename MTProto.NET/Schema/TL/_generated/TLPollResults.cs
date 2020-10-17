using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbadcc1a3)]
    public class TLPollResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbadcc1a3;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Min { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLVector<MTProto.NET.Schema.TL.TLPollAnswerVoters> Results { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.Null)]
        public int? TotalVoters { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.Null)]
        public TLVector<int> RecentVoters { get; set; }
        [MTParameter(Order = 5, FlagBitId = 4, FlagType = FlagType.Null)]
        public string Solution { get; set; }
        [MTParameter(Order = 6, FlagBitId = 4, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> SolutionEntities { get; set; }


    }
}
