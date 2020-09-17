using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xbd507cd1)]
    public class TLInputThemeSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbd507cd1;
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
        public TLAbsInputWallPaper Wallpaper { get; set; }
        [MTParameter(Order = 6, FromFlag = 1, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLWallPaperSettings WallpaperSettings { get; set; }


    }
}
