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
    [MTObject(0x18b7a10d)]
    public class TLDcOption : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x18b7a10d;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Ipv6 { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool MediaOnly { get; set; }
		[MTParameter(Order = 3, FlagBitId=2, FlagType= FlagType.True)]
		public bool TcpoOnly { get; set; }
		[MTParameter(Order = 4, FlagBitId=3, FlagType= FlagType.True)]
		public bool Cdn { get; set; }
		[MTParameter(Order = 5, FlagBitId=4, FlagType= FlagType.True)]
		public bool Static { get; set; }
		[MTParameter(Order = 6)]
		public int Id { get; set; }
		[MTParameter(Order = 7)]
		public string IpAddress { get; set; }
		[MTParameter(Order = 8)]
		public int Port { get; set; }
		[MTParameter(Order = 9, FlagBitId=10, FlagType= FlagType.Null)]
		public byte[] Secret { get; set; }


    }
}
