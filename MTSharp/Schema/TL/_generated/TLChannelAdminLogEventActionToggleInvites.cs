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
    [MTObject(0x1b7907ae)]
    public class TLChannelAdminLogEventActionToggleInvites : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b7907ae;
            }
        }

		[MTParameter(Order = 0)]
		public bool NewValue { get; set; }


    }
}
