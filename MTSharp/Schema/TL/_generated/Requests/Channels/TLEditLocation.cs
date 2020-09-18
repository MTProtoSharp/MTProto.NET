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

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x58e63f6d)]
    public class TLEditLocation : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x58e63f6d;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputChannel Channel { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputGeoPoint GeoPoint { get; set; }
		[MTParameter(Order = 2)]
		public string Address { get; set; }


    }
}
