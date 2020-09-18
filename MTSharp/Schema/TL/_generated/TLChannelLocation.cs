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
    [MTObject(0x209b82db)]
    public class TLChannelLocation : TLAbsChannelLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0x209b82db;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsGeoPoint GeoPoint { get; set; }
		[MTParameter(Order = 1)]
		public string Address { get; set; }


    }
}
