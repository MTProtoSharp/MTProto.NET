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
    [MTObject(0xc331e80a)]
    public class TLInputGameShortName : TLAbsInputGame
    {
        public override uint Constructor
        {
            get
            {
                return 0xc331e80a;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputUser BotId { get; set; }
		[MTParameter(Order = 1)]
		public string ShortName { get; set; }


    }
}
