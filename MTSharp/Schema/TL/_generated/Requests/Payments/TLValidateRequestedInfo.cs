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
    [MTObject(0x770a8e74)]
    public class TLValidateRequestedInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x770a8e74;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Save { get; set; }
		[MTParameter(Order = 2)]
		public int MsgId { get; set; }
		[MTParameter(Order = 3)]
		public MTSharp.Schema.TL.TLPaymentRequestedInfo Info { get; set; }


    }
}
