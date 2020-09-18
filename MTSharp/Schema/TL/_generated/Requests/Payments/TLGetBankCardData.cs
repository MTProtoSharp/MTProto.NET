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

namespace MTSharp.Schema.TL.Requests.Payments
{
    [MTObject(0x2e79d779)]
    public class TLGetBankCardData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2e79d779;
            }
        }

		[MTParameter(Order = 0)]
		public string Number { get; set; }


    }
}
