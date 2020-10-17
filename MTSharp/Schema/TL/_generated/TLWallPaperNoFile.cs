using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x8af40b25)]
    public class TLWallPaperNoFile : TLAbsWallPaper
    {
        public override uint Constructor
        {
            get
            {
                return 0x8af40b25;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Default { get; set; }
        [MTParameter(Order = 2, FlagBitId = 4, FlagType = FlagType.True)]
        public bool Dark { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLWallPaperSettings Settings { get; set; }


    }
}
