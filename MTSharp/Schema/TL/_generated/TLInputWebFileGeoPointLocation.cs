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
    [MTObject(0x9f2221c9)]
    public class TLInputWebFileGeoPointLocation : TLAbsInputWebFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0x9f2221c9;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputGeoPoint GeoPoint { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }
		[MTParameter(Order = 2)]
		public int W { get; set; }
		[MTParameter(Order = 3)]
		public int H { get; set; }
		[MTParameter(Order = 4)]
		public int Zoom { get; set; }
		[MTParameter(Order = 5)]
		public int Scale { get; set; }


    }
}
