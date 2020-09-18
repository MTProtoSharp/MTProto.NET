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

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x702b65a9)]
    public class TLWallPapers : TLAbsWallPapers
    {
        public override uint Constructor
        {
            get
            {
                return 0x702b65a9;
            }
        }

		[MTParameter(Order = 0)]
		public int Hash { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsWallPaper> Wallpapers { get; set; }


    }
}
