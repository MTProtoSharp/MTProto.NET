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
    [MTObject(0x3491eba9)]
    public class TLSendMedia : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3491eba9;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=5, FlagType= FlagType.True)]
		public bool Silent { get; set; }
		[MTParameter(Order = 2, FlagBitId=6, FlagType= FlagType.True)]
		public bool Background { get; set; }
		[MTParameter(Order = 3, FlagBitId=7, FlagType= FlagType.True)]
		public bool ClearDraft { get; set; }
		[MTParameter(Order = 4)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 5, FlagBitId=0, FlagType= FlagType.Null)]
		public int? ReplyToMsgId { get; set; }
		[MTParameter(Order = 6)]
		public TLAbsInputMedia Media { get; set; }
		[MTParameter(Order = 7)]
		public string Message { get; set; }
		[MTParameter(Order = 8)]
		public long RandomId { get; set; }
		[MTParameter(Order = 9, FlagBitId=2, FlagType= FlagType.Null)]
		public TLAbsReplyMarkup ReplyMarkup { get; set; }
		[MTParameter(Order = 10, FlagBitId=3, FlagType= FlagType.Null)]
		public TLVector<TLAbsMessageEntity> Entities { get; set; }
		[MTParameter(Order = 11, FlagBitId=10, FlagType= FlagType.Null)]
		public int? ScheduleDate { get; set; }


    }
}
