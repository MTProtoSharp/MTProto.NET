using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

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

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsBaseTheme BaseTheme { get; set; }
		[MTParameter(Order = 2)]
		public int AccentColor { get; set; }
		[MTParameter(Order = 3, FlagBitId=0, FlagType= FlagType.Null)]
		public int? MessageTopColor { get; set; }
		[MTParameter(Order = 4, FlagBitId=0, FlagType= FlagType.Null)]
		public int? MessageBottomColor { get; set; }
		[MTParameter(Order = 5, FlagBitId=1, FlagType= FlagType.Null)]
		public TLAbsWallPaper Wallpaper { get; set; }


    }
}
