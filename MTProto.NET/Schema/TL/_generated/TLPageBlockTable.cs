using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbf4dea82)]
    public class TLPageBlockTable : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xbf4dea82;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Bordered { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Striped { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsRichText Title { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<MTProto.NET.Schema.TL.TLPageTableRow> Rows { get; set; }


    }
}
