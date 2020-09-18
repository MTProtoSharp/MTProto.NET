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
    [MTObject(0xa3289a6d)]
    public class TLChannelParticipantSelf : TLAbsChannelParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0xa3289a6d;
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
