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
    [MTObject(0xa26f881b)]
    public class TLChannelAdminLogEventActionChangeLinkedChat : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xa26f881b;
            }
        }

		[MTParameter(Order = 0)]
		public int PrevValue { get; set; }
		[MTParameter(Order = 1)]
		public int NewValue { get; set; }


    }
}
