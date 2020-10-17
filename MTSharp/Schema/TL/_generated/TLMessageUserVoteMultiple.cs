using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe8fe0de)]
    public class TLMessageUserVoteMultiple : TLAbsMessageUserVote
    {
        public override uint Constructor
        {
            get
            {
                return 0xe8fe0de;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<byte[]> Options { get; set; }
        [MTParameter(Order = 2)]
        public int Date { get; set; }


    }
}
