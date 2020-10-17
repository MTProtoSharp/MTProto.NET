using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x36377430)]
    public class TLMessageUserVoteInputOption : TLAbsMessageUserVote
    {
        public override uint Constructor
        {
            get
            {
                return 0x36377430;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int Date { get; set; }


    }
}
