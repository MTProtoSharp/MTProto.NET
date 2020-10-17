using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0x823f649)]
    public class TLVotesList : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x823f649;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int Count { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsMessageUserVote> Votes { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<TLAbsUser> Users { get; set; }
        [MTParameter(Order = 4, FlagBitId = 0, FlagType = FlagType.Null)]
        public string NextOffset { get; set; }


    }
}
