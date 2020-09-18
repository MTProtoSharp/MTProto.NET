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
    [MTObject(0x75588b3f)]
    public class TLInputClientProxy : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x75588b3f;
            }
        }

		[MTParameter(Order = 0)]
		public string Address { get; set; }
		[MTParameter(Order = 1)]
		public int Port { get; set; }


    }
}
