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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xfeed5769)]
    public class TLInstallWallPaper : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xfeed5769;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputWallPaper Wallpaper { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLWallPaperSettings Settings { get; set; }


    }
}
