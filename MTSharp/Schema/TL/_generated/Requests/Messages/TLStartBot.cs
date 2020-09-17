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
    [MTObject(0xe6df7378)]
    public class TLStartBot : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe6df7378;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputUser Bot { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 2)]
		public long RandomId { get; set; }
		[MTParameter(Order = 3)]
		public string StartParam { get; set; }


    }
}
