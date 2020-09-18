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
    [MTObject(0x365275f2)]
    public class TLInvokeWithMessagesRange : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x365275f2;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLMessageRange Range { get; set; }
		[MTParameter(Order = 1)]
		public MTObject Query { get; set; }


    }
}
