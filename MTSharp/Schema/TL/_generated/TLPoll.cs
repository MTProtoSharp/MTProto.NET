using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd5529d06)]
    public class TLPoll : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd5529d06;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public int Flags { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.True)]
        public bool Closed { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.True)]
        public bool PublicVoters { get; set; }
        [MTParameter(Order = 4, FromFlag = 2, FlagType = FlagType.True)]
        public bool MultipleChoice { get; set; }
        [MTParameter(Order = 5, FromFlag = 3, FlagType = FlagType.True)]
        public bool Quiz { get; set; }
        [MTParameter(Order = 6)]
        public string Question { get; set; }
        [MTParameter(Order = 7)]
        public TLVector<MTSharp.Schema.TL.TLPollAnswer> Answers { get; set; }


    }
}
