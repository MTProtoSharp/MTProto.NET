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
    [MTObject(0x65ad71dc)]
    public class TLGetMultiWallPapers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x65ad71dc;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsInputWallPaper> Wallpapers { get; set; }


    }
}
