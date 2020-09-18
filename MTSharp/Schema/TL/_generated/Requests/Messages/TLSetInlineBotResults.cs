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
    [MTObject(0xeb5ea206)]
    public class TLSetInlineBotResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xeb5ea206;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Gallery { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool Private { get; set; }
		[MTParameter(Order = 3)]
		public long QueryId { get; set; }
		[MTParameter(Order = 4)]
		public TLVector<TLAbsInputBotInlineResult> Results { get; set; }
		[MTParameter(Order = 5)]
		public int CacheTime { get; set; }
		[MTParameter(Order = 6, FlagBitId=2, FlagType= FlagType.Null)]
		public string NextOffset { get; set; }
		[MTParameter(Order = 7, FlagBitId=3, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLInlineBotSwitchPM SwitchPm { get; set; }


    }
}
