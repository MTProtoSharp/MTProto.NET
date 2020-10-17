using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5086cf8)]
    public class TLWallPaperSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5086cf8;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Blur { get; set; }
        [MTParameter(Order = 2, FlagBitId = 2, FlagType = FlagType.True)]
        public bool Motion { get; set; }
        [MTParameter(Order = 3, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? BackgroundColor { get; set; }
        [MTParameter(Order = 4, FlagBitId = 4, FlagType = FlagType.Null)]
        public int? SecondBackgroundColor { get; set; }
        [MTParameter(Order = 5, FlagBitId = 3, FlagType = FlagType.Null)]
        public int? Intensity { get; set; }
        [MTParameter(Order = 6, FlagBitId = 4, FlagType = FlagType.Null)]
        public int? Rotation { get; set; }


    }
}
