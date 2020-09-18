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
    [MTObject(0x434bd2af)]
    public class TLChannelAdminLogEventActionChangePhoto : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x434bd2af;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsPhoto PrevPhoto { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsPhoto NewPhoto { get; set; }


    }
}
