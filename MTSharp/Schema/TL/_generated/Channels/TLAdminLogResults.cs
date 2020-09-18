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

namespace MTSharp.Schema.TL.Channels
{
    [MTObject(0xed8af74d)]
    public class TLAdminLogResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xed8af74d;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<MTSharp.Schema.TL.TLChannelAdminLogEvent> Events { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsChat> Chats { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
