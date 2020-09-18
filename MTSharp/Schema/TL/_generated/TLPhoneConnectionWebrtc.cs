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
    [MTObject(0x635fe375)]
    public class TLPhoneConnectionWebrtc : TLAbsPhoneConnection
    {
        public override uint Constructor
        {
            get
            {
                return 0x635fe375;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Turn { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool Stun { get; set; }
		[MTParameter(Order = 3)]
		public long Id { get; set; }
		[MTParameter(Order = 4)]
		public string Ip { get; set; }
		[MTParameter(Order = 5)]
		public string Ipv6 { get; set; }
		[MTParameter(Order = 6)]
		public int Port { get; set; }
		[MTParameter(Order = 7)]
		public string Username { get; set; }
		[MTParameter(Order = 8)]
		public string Password { get; set; }


    }
}
