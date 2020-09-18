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
    [MTObject(0xf568028a)]
    public class TLBankCardOpenUrl : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf568028a;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }
		[MTParameter(Order = 1)]
		public string Name { get; set; }


    }
}
