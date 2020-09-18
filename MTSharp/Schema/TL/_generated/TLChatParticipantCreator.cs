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
    [MTObject(0xda13538a)]
    public class TLChatParticipantCreator : TLAbsChatParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0xda13538a;
            }
        }

		[MTParameter(Order = 0)]
		public int UserId { get; set; }


    }
}
