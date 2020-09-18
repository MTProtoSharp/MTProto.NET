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
    [MTObject(0xf3b7acc9)]
    public class TLInputGeoPoint : TLAbsInputGeoPoint
    {
        public override uint Constructor
        {
            get
            {
                return 0xf3b7acc9;
            }
        }

		[MTParameter(Order = 0)]
		public double Lat { get; set; }
		[MTParameter(Order = 1)]
		public double Long { get; set; }


    }
}
