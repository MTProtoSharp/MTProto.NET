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
    [MTObject(0x7c3c2609)]
    public class TLMessageMediaGeoLive : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x7c3c2609;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsGeoPoint Geo { get; set; }
		[MTParameter(Order = 1)]
		public int Period { get; set; }


    }
}
