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
    [MTObject(0x11965f3a)]
    public class TLBotInlineResult : TLAbsBotInlineResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x11965f3a;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public string Id { get; set; }
		[MTParameter(Order = 2)]
		public string Type { get; set; }
		[MTParameter(Order = 3, FlagBitId=1, FlagType= FlagType.Null)]
		public string Title { get; set; }
		[MTParameter(Order = 4, FlagBitId=2, FlagType= FlagType.Null)]
		public string Description { get; set; }
		[MTParameter(Order = 5, FlagBitId=3, FlagType= FlagType.Null)]
		public string Url { get; set; }
		[MTParameter(Order = 6, FlagBitId=4, FlagType= FlagType.Null)]
		public TLAbsWebDocument Thumb { get; set; }
		[MTParameter(Order = 7, FlagBitId=5, FlagType= FlagType.Null)]
		public TLAbsWebDocument Content { get; set; }
		[MTParameter(Order = 8)]
		public TLAbsBotInlineMessage SendMessage { get; set; }


    }
}
