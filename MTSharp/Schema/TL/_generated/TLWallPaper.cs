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
    [MTObject(0xa437c3ed)]
    public class TLWallPaper : TLAbsWallPaper
    {
        public override uint Constructor
        {
            get
            {
                return 0xa437c3ed;
            }
        }

		[MTParameter(Order = 0)]
		public long Id { get; set; }
		[MTParameter(Order = 1, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 2, FlagBitId=0, FlagType= FlagType.True)]
		public bool Creator { get; set; }
		[MTParameter(Order = 3, FlagBitId=1, FlagType= FlagType.True)]
		public bool Default { get; set; }
		[MTParameter(Order = 4, FlagBitId=3, FlagType= FlagType.True)]
		public bool Pattern { get; set; }
		[MTParameter(Order = 5, FlagBitId=4, FlagType= FlagType.True)]
		public bool Dark { get; set; }
		[MTParameter(Order = 6)]
		public long AccessHash { get; set; }
		[MTParameter(Order = 7)]
		public string Slug { get; set; }
		[MTParameter(Order = 8)]
		public TLAbsDocument Document { get; set; }
		[MTParameter(Order = 9, FlagBitId=2, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLWallPaperSettings Settings { get; set; }


    }
}
