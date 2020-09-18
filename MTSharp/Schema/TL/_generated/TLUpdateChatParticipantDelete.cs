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
    [MTObject(0x6e5f8c22)]
    public class TLUpdateChatParticipantDelete : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x6e5f8c22;
            }
        }

		[MTParameter(Order = 0)]
		public int ChatId { get; set; }
		[MTParameter(Order = 1)]
		public int UserId { get; set; }
		[MTParameter(Order = 2)]
		public int Version { get; set; }


    }
}
