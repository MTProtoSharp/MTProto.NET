using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xaca1657b)]
    public class TLUpdateMessagePoll : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xaca1657b;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long PollId { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLPoll Poll { get; set; }
        [MTParameter(Order = 3)]
        public MTSharp.Schema.TL.TLPollResults Results { get; set; }


    }
}
