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
    [MTObject(0xb637edaf)]
    public class TLStatsDateRangeDays : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb637edaf;
            }
        }

		[MTParameter(Order = 0)]
		public int MinDate { get; set; }
		[MTParameter(Order = 1)]
		public int MaxDate { get; set; }


    }
}
