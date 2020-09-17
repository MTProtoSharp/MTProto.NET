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
    [MTObject(0xcc0110cb)]
    public class TLSendMultiMedia : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcc0110cb;
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
		[MTParameter(Order = 4)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 5, FromFlag=0, FlagType= FlagType.Null)]
		public int? ReplyToMsgId { get; set; }
		[MTParameter(Order = 6)]
		public TLVector<MTSharp.Schema.TL.TLInputSingleMedia> MultiMedia { get; set; }
		[MTParameter(Order = 7, FromFlag=10, FlagType= FlagType.Null)]
		public int? ScheduleDate { get; set; }


    }
}
