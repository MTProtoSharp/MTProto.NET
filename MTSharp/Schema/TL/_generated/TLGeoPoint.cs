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
    [MTObject(0x296f104)]
    public class TLGeoPoint : TLAbsGeoPoint
    {
        public override uint Constructor
        {
            get
            {
                return 0x296f104;
            }
        }

		[MTParameter(Order = 0)]
		public double Long { get; set; }
		[MTParameter(Order = 1)]
		public double Lat { get; set; }
		[MTParameter(Order = 2)]
		public long AccessHash { get; set; }


    }
}
