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

namespace MTSharp.Schema.TL.Requests.Help
{
    [MTObject(0xec22cfcd)]
    public class TLSetBotUpdatesStatus : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xec22cfcd;
            }
        }

		[MTParameter(Order = 0)]
		public int PendingUpdatesCount { get; set; }
		[MTParameter(Order = 1)]
		public string Message { get; set; }


    }
}
