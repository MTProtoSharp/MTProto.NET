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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xe33f5613)]
    public class TLRequestUrlAuth : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe33f5613;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public int MsgId { get; set; }
		[MTParameter(Order = 2)]
		public int ButtonId { get; set; }


    }
}
