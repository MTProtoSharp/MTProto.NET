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
    [MTObject(0xb8bc5b0c)]
    public class TLInputNotifyPeer : TLAbsInputNotifyPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0xb8bc5b0c;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputPeer Peer { get; set; }


    }
}
