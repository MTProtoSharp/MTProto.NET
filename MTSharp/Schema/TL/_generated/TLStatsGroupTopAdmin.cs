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
    [MTObject(0x6014f412)]
    public class TLStatsGroupTopAdmin : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6014f412;
            }
        }

		[MTParameter(Order = 0)]
		public int UserId { get; set; }
		[MTParameter(Order = 1)]
		public int Deleted { get; set; }
		[MTParameter(Order = 2)]
		public int Kicked { get; set; }
		[MTParameter(Order = 3)]
		public int Banned { get; set; }


    }
}
