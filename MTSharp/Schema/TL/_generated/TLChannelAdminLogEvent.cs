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
    [MTObject(0x3b5a3e40)]
    public class TLChannelAdminLogEvent : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3b5a3e40;
            }
        }

		[MTParameter(Order = 0)]
		public long Id { get; set; }
		[MTParameter(Order = 1)]
		public int Date { get; set; }
		[MTParameter(Order = 2)]
		public int UserId { get; set; }
		[MTParameter(Order = 3)]
		public TLAbsChannelAdminLogEventAction Action { get; set; }


    }
}
