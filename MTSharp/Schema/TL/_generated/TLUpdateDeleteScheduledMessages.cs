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
    [MTObject(0x90866cee)]
    public class TLUpdateDeleteScheduledMessages : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x90866cee;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<int> Messages { get; set; }


    }
}
