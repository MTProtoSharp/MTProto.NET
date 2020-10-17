using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x42f88f2c)]
    public class TLUpdateMessagePollVote : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x42f88f2c;
            }
        }

        [MTParameter(Order = 0)]
        public long PollId { get; set; }
        [MTParameter(Order = 1)]
        public int UserId { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<byte[]> Options { get; set; }


    }
}
