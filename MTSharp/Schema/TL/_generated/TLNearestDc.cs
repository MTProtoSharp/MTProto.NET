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
    [MTObject(0x8e1a1775)]
    public class TLNearestDc : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8e1a1775;
            }
        }

		[MTParameter(Order = 0)]
		public string Country { get; set; }
		[MTParameter(Order = 1)]
		public int ThisDc { get; set; }
		[MTParameter(Order = 2)]
		public int NearestDc { get; set; }


    }
}
