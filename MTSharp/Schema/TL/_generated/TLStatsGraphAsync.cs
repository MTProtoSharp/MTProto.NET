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
    [MTObject(0x4a27eb2d)]
    public class TLStatsGraphAsync : TLAbsStatsGraph
    {
        public override uint Constructor
        {
            get
            {
                return 0x4a27eb2d;
            }
        }

		[MTParameter(Order = 0)]
		public string Token { get; set; }


    }
}
