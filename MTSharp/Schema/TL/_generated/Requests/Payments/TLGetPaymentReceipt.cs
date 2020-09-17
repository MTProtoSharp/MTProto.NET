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
    [MTObject(0xa092a980)]
    public class TLGetPaymentReceipt : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa092a980;
            }
        }

		[MTParameter(Order = 0)]
		public int MsgId { get; set; }


    }
}
