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
    [MTObject(0x7b8e7de6)]
    public class TLInputPeerUser : TLAbsInputPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x7b8e7de6;
            }
        }

		[MTParameter(Order = 0)]
		public int UserId { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }


    }
}
