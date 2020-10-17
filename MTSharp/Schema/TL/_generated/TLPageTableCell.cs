using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x34566b6a)]
    public class TLPageTableCell : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x34566b6a;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Header { get; set; }
        [MTParameter(Order = 2, FlagBitId = 3, FlagType = FlagType.True)]
        public bool AlignCenter { get; set; }
        [MTParameter(Order = 3, FlagBitId = 4, FlagType = FlagType.True)]
        public bool AlignRight { get; set; }
        [MTParameter(Order = 4, FlagBitId = 5, FlagType = FlagType.True)]
        public bool ValignMiddle { get; set; }
        [MTParameter(Order = 5, FlagBitId = 6, FlagType = FlagType.True)]
        public bool ValignBottom { get; set; }
        [MTParameter(Order = 6, FlagBitId = 7, FlagType = FlagType.Null)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 7, FlagBitId = 1, FlagType = FlagType.Null)]
        public int? Colspan { get; set; }
        [MTParameter(Order = 8, FlagBitId = 2, FlagType = FlagType.Null)]
        public int? Rowspan { get; set; }


    }
}
