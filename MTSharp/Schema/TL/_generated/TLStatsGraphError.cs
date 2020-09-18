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
    [MTObject(0xbedc9822)]
    public class TLStatsGraphError : TLAbsStatsGraph
    {
        public override uint Constructor
        {
            get
            {
                return 0xbedc9822;
            }
        }

		[MTParameter(Order = 0)]
		public string Error { get; set; }


    }
}
