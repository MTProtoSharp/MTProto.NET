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
    [MTObject(0x61695cb0)]
    public class TLChatInvitePeek : TLAbsChatInvite
    {
        public override uint Constructor
        {
            get
            {
                return 0x61695cb0;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsChat Chat { get; set; }
		[MTParameter(Order = 1)]
		public int Expires { get; set; }


    }
}
