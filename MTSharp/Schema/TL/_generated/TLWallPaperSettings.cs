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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool Blur { get; set; }
        [MTParameter(Order = 2, FromFlag = 2, FlagType = FlagType.True)]
        public bool Motion { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public int? BackgroundColor { get; set; }
        [MTParameter(Order = 4, FromFlag = 4, FlagType = FlagType.Null)]
        public int? SecondBackgroundColor { get; set; }
        [MTParameter(Order = 5, FromFlag = 3, FlagType = FlagType.Null)]
        public int? Intensity { get; set; }
        [MTParameter(Order = 6, FromFlag = 4, FlagType = FlagType.Null)]
        public int? Rotation { get; set; }


    }
}
