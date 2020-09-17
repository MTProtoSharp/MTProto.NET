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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x220815b0)]
    public class TLSendInlineBotResult : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x220815b0;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=5, FlagType= FlagType.True)]
		public bool Silent { get; set; }
		[MTParameter(Order = 2, FromFlag=6, FlagType= FlagType.True)]
		public bool Background { get; set; }
		[MTParameter(Order = 3, FromFlag=7, FlagType= FlagType.True)]
		public bool ClearDraft { get; set; }
		[MTParameter(Order = 4, FromFlag=11, FlagType= FlagType.True)]
		public bool HideVia { get; set; }
		[MTParameter(Order = 5)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 6, FromFlag=0, FlagType= FlagType.Null)]
		public int? ReplyToMsgId { get; set; }
		[MTParameter(Order = 7)]
		public long RandomId { get; set; }
		[MTParameter(Order = 8)]
		public long QueryId { get; set; }
		[MTParameter(Order = 9)]
		public string Id { get; set; }
		[MTParameter(Order = 10, FromFlag=10, FlagType= FlagType.Null)]
		public int? ScheduleDate { get; set; }


    }
}
