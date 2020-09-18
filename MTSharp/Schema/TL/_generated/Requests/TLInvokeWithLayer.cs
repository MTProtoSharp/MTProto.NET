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

namespace MTSharp.Schema.TL.Requests
{
    [MTObject(0xda9b0d0d)]
    public class TLInvokeWithLayer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xda9b0d0d;
            }
        }

		[MTParameter(Order = 0)]
		public int Layer { get; set; }
		[MTParameter(Order = 1)]
		public MTObject Query { get; set; }


    }
}
