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
    [MTObject(0x2df5fc0a)]
    public class TLChannelAdminLogEventActionDefaultBannedRights : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x2df5fc0a;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLChatBannedRights PrevBannedRights { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLChatBannedRights NewBannedRights { get; set; }


    }
}
