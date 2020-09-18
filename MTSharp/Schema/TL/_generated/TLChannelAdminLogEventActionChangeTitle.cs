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
    [MTObject(0xe6dfb825)]
    public class TLChannelAdminLogEventActionChangeTitle : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xe6dfb825;
            }
        }

		[MTParameter(Order = 0)]
		public string PrevValue { get; set; }
		[MTParameter(Order = 1)]
		public string NewValue { get; set; }


    }
}
