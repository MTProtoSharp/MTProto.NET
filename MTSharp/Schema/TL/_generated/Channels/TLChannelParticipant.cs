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
    [MTObject(0xd0d9b163)]
    public class TLChannelParticipant : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd0d9b163;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsChannelParticipant Participant { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
