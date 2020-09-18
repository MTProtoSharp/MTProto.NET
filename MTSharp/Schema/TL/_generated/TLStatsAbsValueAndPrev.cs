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
    [MTObject(0xcb43acde)]
    public class TLStatsAbsValueAndPrev : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcb43acde;
            }
        }

		[MTParameter(Order = 0)]
		public double Current { get; set; }
		[MTParameter(Order = 1)]
		public double Previous { get; set; }


    }
}
