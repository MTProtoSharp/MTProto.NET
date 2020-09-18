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

namespace MTSharp.Schema.TL.Payments
{
    [MTObject(0x3e24e573)]
    public class TLBankCardData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3e24e573;
            }
        }

		[MTParameter(Order = 0)]
		public string Title { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<MTSharp.Schema.TL.TLBankCardOpenUrl> OpenUrls { get; set; }


    }
}
