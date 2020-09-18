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
    [MTObject(0xe6b76ae)]
    public class TLChannelAdminLogEventActionChangeLocation : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xe6b76ae;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsChannelLocation PrevValue { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsChannelLocation NewValue { get; set; }


    }
}
