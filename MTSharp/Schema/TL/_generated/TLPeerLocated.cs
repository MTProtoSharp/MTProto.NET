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
    [MTObject(0xca461b5d)]
    public class TLPeerLocated : TLAbsPeerLocated
    {
        public override uint Constructor
        {
            get
            {
                return 0xca461b5d;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public int Expires { get; set; }
		[MTParameter(Order = 2)]
		public int Distance { get; set; }


    }
}
