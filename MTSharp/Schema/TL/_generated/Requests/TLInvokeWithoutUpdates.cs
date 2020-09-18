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
    [MTObject(0xbf9459b7)]
    public class TLInvokeWithoutUpdates : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbf9459b7;
            }
        }

		[MTParameter(Order = 0)]
		public MTObject Query { get; set; }


    }
}
