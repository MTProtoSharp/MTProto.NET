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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool Default { get; set; }
        [MTParameter(Order = 2, FromFlag = 4, FlagType = FlagType.True)]
        public bool Dark { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLWallPaperSettings Settings { get; set; }


    }
}
