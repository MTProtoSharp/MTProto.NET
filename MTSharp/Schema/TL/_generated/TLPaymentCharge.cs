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
    [MTObject(0xea02c27e)]
    public class TLPaymentCharge : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xea02c27e;
            }
        }

		[MTParameter(Order = 0)]
		public string Id { get; set; }
		[MTParameter(Order = 1)]
		public string ProviderChargeId { get; set; }


    }
}
