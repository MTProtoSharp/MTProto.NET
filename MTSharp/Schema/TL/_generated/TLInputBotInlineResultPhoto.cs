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
    [MTObject(0xa8d864a7)]
    public class TLInputBotInlineResultPhoto : TLAbsInputBotInlineResult
    {
        public override uint Constructor
        {
            get
            {
                return 0xa8d864a7;
            }
        }

		[MTParameter(Order = 0)]
		public string Id { get; set; }
		[MTParameter(Order = 1)]
		public string Type { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputPhoto Photo { get; set; }
		[MTParameter(Order = 3)]
		public TLAbsInputBotInlineMessage SendMessage { get; set; }


    }
}
