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

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xc0e24635)]
    public class TLDhConfigNotModified : TLAbsDhConfig
    {
        public override uint Constructor
        {
            get
            {
                return 0xc0e24635;
            }
        }

		[MTParameter(Order = 0)]
		public byte[] Random { get; set; }


    }
}
