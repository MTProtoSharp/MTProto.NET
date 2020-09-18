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
    [MTObject(0x78d4dec1)]
    public class TLUpdateShort : TLAbsUpdates
    {
        public override uint Constructor
        {
            get
            {
                return 0x78d4dec1;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsUpdate Update { get; set; }
		[MTParameter(Order = 1)]
		public int Date { get; set; }


    }
}
