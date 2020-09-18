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
    [MTObject(0x1c0facaf)]
    public class TLChannelParticipantBanned : TLAbsChannelParticipant
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c0facaf;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Left { get; set; }
		[MTParameter(Order = 2)]
		public int UserId { get; set; }
		[MTParameter(Order = 3)]
		public int KickedBy { get; set; }
		[MTParameter(Order = 4)]
		public int Date { get; set; }
		[MTParameter(Order = 5)]
		public MTSharp.Schema.TL.TLChatBannedRights BannedRights { get; set; }


    }
}
