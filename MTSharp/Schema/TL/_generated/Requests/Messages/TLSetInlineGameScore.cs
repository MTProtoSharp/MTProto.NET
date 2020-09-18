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
    [MTObject(0x15ad9f64)]
    public class TLSetInlineGameScore : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x15ad9f64;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool EditMessage { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool Force { get; set; }
		[MTParameter(Order = 3)]
		public MTSharp.Schema.TL.TLInputBotInlineMessageID Id { get; set; }
		[MTParameter(Order = 4)]
		public TLAbsInputUser UserId { get; set; }
		[MTParameter(Order = 5)]
		public int Score { get; set; }


    }
}
