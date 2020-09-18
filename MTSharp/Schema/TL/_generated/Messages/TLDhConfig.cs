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

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x2c221edd)]
    public class TLDhConfig : TLAbsDhConfig
    {
        public override uint Constructor
        {
            get
            {
                return 0x2c221edd;
            }
        }

		[MTParameter(Order = 0)]
		public int G { get; set; }
		[MTParameter(Order = 1)]
		public byte[] P { get; set; }
		[MTParameter(Order = 2)]
		public int Version { get; set; }
		[MTParameter(Order = 3)]
		public byte[] Random { get; set; }


    }
}
