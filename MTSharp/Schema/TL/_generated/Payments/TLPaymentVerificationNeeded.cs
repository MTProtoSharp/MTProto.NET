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
    [MTObject(0xd8411139)]
    public class TLPaymentVerificationNeeded : TLAbsPaymentResult
    {
        public override uint Constructor
        {
            get
            {
                return 0xd8411139;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }


    }
}
