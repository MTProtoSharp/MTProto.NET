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
    [MTObject(0x8aeabec3)]
    public class TLSecureData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8aeabec3;
            }
        }

		[MTParameter(Order = 0)]
		public byte[] Data { get; set; }
		[MTParameter(Order = 1)]
		public byte[] DataHash { get; set; }
		[MTParameter(Order = 2)]
		public byte[] Secret { get; set; }


    }
}
