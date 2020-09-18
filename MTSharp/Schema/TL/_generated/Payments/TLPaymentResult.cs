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
    [MTObject(0x4e5f810d)]
    public class TLPaymentResult : TLAbsPaymentResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x4e5f810d;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsUpdates Updates { get; set; }


    }
}
