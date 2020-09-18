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
    [MTObject(0x2661bf09)]
    public class TLUpdatePhoneCallSignalingData : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x2661bf09;
            }
        }

		[MTParameter(Order = 0)]
		public long PhoneCallId { get; set; }
		[MTParameter(Order = 1)]
		public byte[] Data { get; set; }


    }
}
