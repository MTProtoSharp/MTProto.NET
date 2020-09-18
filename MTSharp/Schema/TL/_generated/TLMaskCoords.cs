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
    [MTObject(0xaed6dbb2)]
    public class TLMaskCoords : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xaed6dbb2;
            }
        }

		[MTParameter(Order = 0)]
		public int N { get; set; }
		[MTParameter(Order = 1)]
		public double X { get; set; }
		[MTParameter(Order = 2)]
		public double Y { get; set; }
		[MTParameter(Order = 3)]
		public double Zoom { get; set; }


    }
}
