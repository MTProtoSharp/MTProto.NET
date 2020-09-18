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
    [MTObject(0x98657f0d)]
    public class TLPage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x98657f0d;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Part { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool Rtl { get; set; }
		[MTParameter(Order = 3, FlagBitId=2, FlagType= FlagType.True)]
		public bool V2 { get; set; }
		[MTParameter(Order = 4)]
		public string Url { get; set; }
		[MTParameter(Order = 5)]
		public TLVector<TLAbsPageBlock> Blocks { get; set; }
		[MTParameter(Order = 6)]
		public TLVector<TLAbsPhoto> Photos { get; set; }
		[MTParameter(Order = 7)]
		public TLVector<TLAbsDocument> Documents { get; set; }
		[MTParameter(Order = 8, FlagBitId=3, FlagType= FlagType.Null)]
		public int? Views { get; set; }


    }
}
