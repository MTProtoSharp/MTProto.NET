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
    [MTObject(0xf9c44144)]
    public class TLInputMediaGeoPoint : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xf9c44144;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputGeoPoint GeoPoint { get; set; }


    }
}
