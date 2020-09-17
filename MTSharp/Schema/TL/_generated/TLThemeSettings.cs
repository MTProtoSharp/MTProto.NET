using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9c14984a)]
    public class TLThemeSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9c14984a;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsBaseTheme BaseTheme { get; set; }
        [MTParameter(Order = 2)]
        public int AccentColor { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public int? MessageTopColor { get; set; }
        [MTParameter(Order = 4, FromFlag = 0, FlagType = FlagType.Null)]
        public int? MessageBottomColor { get; set; }
        [MTParameter(Order = 5, FromFlag = 1, FlagType = FlagType.Null)]
        public TLAbsWallPaper Wallpaper { get; set; }


    }
}
