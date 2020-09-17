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
    [MTObject(0x2b8879b3)]
    public class TLSendPaymentForm : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2b8879b3;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public int MsgId { get; set; }
		[MTParameter(Order = 2, FromFlag=0, FlagType= FlagType.Null)]
		public string RequestedInfoId { get; set; }
		[MTParameter(Order = 3, FromFlag=1, FlagType= FlagType.Null)]
		public string ShippingOptionId { get; set; }
		[MTParameter(Order = 4)]
		public TLAbsInputPaymentCredentials Credentials { get; set; }


    }
}
