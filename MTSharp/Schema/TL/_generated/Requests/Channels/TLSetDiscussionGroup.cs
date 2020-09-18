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

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x40582bb2)]
    public class TLSetDiscussionGroup : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x40582bb2;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputChannel Broadcast { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputChannel Group { get; set; }


    }
}
