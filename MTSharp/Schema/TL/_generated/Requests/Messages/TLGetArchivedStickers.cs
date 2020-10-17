using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x57f17692)]
    public class TLGetArchivedStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x57f17692;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Masks { get; set; }
        [MTParameter(Order = 2)]
        public long OffsetId { get; set; }
        [MTParameter(Order = 3)]
        public int Limit { get; set; }


    }
}
