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
    [MTObject(0xea4b0e5c)]
    public class TLUpdateChatParticipantAdd : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xea4b0e5c;
            }
        }

		[MTParameter(Order = 0)]
		public int ChatId { get; set; }
		[MTParameter(Order = 1)]
		public int UserId { get; set; }
		[MTParameter(Order = 2)]
		public int InviterId { get; set; }
		[MTParameter(Order = 3)]
		public int Date { get; set; }
		[MTParameter(Order = 4)]
		public int Version { get; set; }


    }
}
