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
    [MTObject(0x9d4c17c0)]
    public class TLPhoneConnection : TLAbsPhoneConnection
    {
        public override uint Constructor
        {
            get
            {
                return 0x9d4c17c0;
            }
        }

		[MTParameter(Order = 0)]
		public long Id { get; set; }
		[MTParameter(Order = 1)]
		public string Ip { get; set; }
		[MTParameter(Order = 2)]
		public string Ipv6 { get; set; }
		[MTParameter(Order = 3)]
		public int Port { get; set; }
		[MTParameter(Order = 4)]
		public byte[] PeerTag { get; set; }


    }
}
