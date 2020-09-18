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
    [MTObject(0xad4fc9bd)]
    public class TLMessageInteractionCounters : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xad4fc9bd;
            }
        }

		[MTParameter(Order = 0)]
		public int MsgId { get; set; }
		[MTParameter(Order = 1)]
		public int Views { get; set; }
		[MTParameter(Order = 2)]
		public int Forwards { get; set; }


    }
}
