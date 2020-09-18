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
    [MTObject(0xe6d83d7e)]
    public class TLChannelAdminLogEventActionParticipantToggleBan : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xe6d83d7e;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsChannelParticipant PrevParticipant { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsChannelParticipant NewParticipant { get; set; }


    }
}
