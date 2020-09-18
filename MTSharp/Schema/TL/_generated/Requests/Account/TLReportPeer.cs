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
    [MTObject(0xae189d5f)]
    public class TLReportPeer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xae189d5f;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsReportReason Reason { get; set; }


    }
}
