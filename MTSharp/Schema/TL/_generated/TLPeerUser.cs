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
    [MTObject(0x9db1bc6d)]
    public class TLPeerUser : TLAbsPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x9db1bc6d;
            }
        }

		[MTParameter(Order = 0)]
		public int UserId { get; set; }


    }
}
