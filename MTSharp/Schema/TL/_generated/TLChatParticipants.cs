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
    [MTObject(0x3f460fed)]
    public class TLChatParticipants : TLAbsChatParticipants
    {
        public override uint Constructor
        {
            get
            {
                return 0x3f460fed;
            }
        }

		[MTParameter(Order = 0)]
		public int ChatId { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsChatParticipant> Participants { get; set; }
		[MTParameter(Order = 2)]
		public int Version { get; set; }


    }
}
