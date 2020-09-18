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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x2442485e)]
    public class TLSetAccountTTL : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2442485e;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLAccountDaysTTL Ttl { get; set; }


    }
}
