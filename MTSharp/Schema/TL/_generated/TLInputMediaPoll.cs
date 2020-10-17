using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xf94e5f1)]
    public class TLInputMediaPoll : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xf94e5f1;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLPoll Poll { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLVector<byte[]> CorrectAnswers { get; set; }
        [MTParameter(Order = 3, FlagBitId = 1, FlagType = FlagType.Null)]
        public string Solution { get; set; }
        [MTParameter(Order = 4, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> SolutionEntities { get; set; }


    }
}
