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
    [MTObject(0x520c3870)]
    public class TLSendMessage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x520c3870;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=1, FlagType= FlagType.True)]
		public bool NoWebpage { get; set; }
		[MTParameter(Order = 2, FromFlag=5, FlagType= FlagType.True)]
		public bool Silent { get; set; }
		[MTParameter(Order = 3, FromFlag=6, FlagType= FlagType.True)]
		public bool Background { get; set; }
		[MTParameter(Order = 4, FromFlag=7, FlagType= FlagType.True)]
		public bool ClearDraft { get; set; }
		[MTParameter(Order = 5)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 6, FromFlag=0, FlagType= FlagType.Null)]
		public int? ReplyToMsgId { get; set; }
		[MTParameter(Order = 7)]
		public string Message { get; set; }
		[MTParameter(Order = 8)]
		public long RandomId { get; set; }
		[MTParameter(Order = 9, FromFlag=2, FlagType= FlagType.Null)]
		public TLAbsReplyMarkup ReplyMarkup { get; set; }
		[MTParameter(Order = 10, FromFlag=3, FlagType= FlagType.Null)]
		public TLVector<TLAbsMessageEntity> Entities { get; set; }
		[MTParameter(Order = 11, FromFlag=10, FlagType= FlagType.Null)]
		public int? ScheduleDate { get; set; }


    }
}
