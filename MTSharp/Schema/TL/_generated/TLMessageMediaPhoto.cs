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
    [MTObject(0x695150d7)]
    public class TLMessageMediaPhoto : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x695150d7;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.Null)]
		public TLAbsPhoto Photo { get; set; }
		[MTParameter(Order = 2, FlagBitId=2, FlagType= FlagType.Null)]
		public int? TtlSeconds { get; set; }


    }
}
