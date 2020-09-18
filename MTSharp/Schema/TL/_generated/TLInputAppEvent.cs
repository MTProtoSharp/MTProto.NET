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
    [MTObject(0x1d1b1245)]
    public class TLInputAppEvent : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1d1b1245;
            }
        }

		[MTParameter(Order = 0)]
		public double Time { get; set; }
		[MTParameter(Order = 1)]
		public string Type { get; set; }
		[MTParameter(Order = 2)]
		public long Peer { get; set; }
		[MTParameter(Order = 3)]
		public TLAbsJSONValue Data { get; set; }


    }
}
