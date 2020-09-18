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
    [MTObject(0xc8d7493e)]
    public class TLChatParticipant : TLAbsChatParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0xc8d7493e;
            }
        }

		[MTParameter(Order = 0)]
		public int UserId { get; set; }
		[MTParameter(Order = 1)]
		public int InviterId { get; set; }
		[MTParameter(Order = 2)]
		public int Date { get; set; }


    }
}
