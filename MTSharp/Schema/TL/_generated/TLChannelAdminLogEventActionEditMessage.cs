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
    [MTObject(0x709b2405)]
    public class TLChannelAdminLogEventActionEditMessage : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x709b2405;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsMessage PrevMessage { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsMessage NewMessage { get; set; }


    }
}
