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
    [MTObject(0x25d6c9c7)]
    public class TLUpdateReadChannelOutbox : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x25d6c9c7;
            }
        }

		[MTParameter(Order = 0)]
		public int ChannelId { get; set; }
		[MTParameter(Order = 1)]
		public int MaxId { get; set; }


    }
}
