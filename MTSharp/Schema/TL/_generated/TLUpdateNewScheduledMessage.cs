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
    [MTObject(0x39a51dfb)]
    public class TLUpdateNewScheduledMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x39a51dfb;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsMessage Message { get; set; }


    }
}
