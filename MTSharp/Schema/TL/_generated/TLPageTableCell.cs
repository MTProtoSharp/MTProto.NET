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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Header { get; set; }
        [MTParameter(Order = 2, FromFlag = 3, FlagType = FlagType.True)]
        public bool AlignCenter { get; set; }
        [MTParameter(Order = 3, FromFlag = 4, FlagType = FlagType.True)]
        public bool AlignRight { get; set; }
        [MTParameter(Order = 4, FromFlag = 5, FlagType = FlagType.True)]
        public bool ValignMiddle { get; set; }
        [MTParameter(Order = 5, FromFlag = 6, FlagType = FlagType.True)]
        public bool ValignBottom { get; set; }
        [MTParameter(Order = 6, FromFlag = 7, FlagType = FlagType.Null)]
        public TLAbsRichText Text { get; set; }
        [MTParameter(Order = 7, FromFlag = 1, FlagType = FlagType.Null)]
        public int? Colspan { get; set; }
        [MTParameter(Order = 8, FromFlag = 2, FlagType = FlagType.Null)]
        public int? Rowspan { get; set; }


    }
}
