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
    [MTObject(0x258aff05)]
    public class TLKeyboardButtonUrl : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0x258aff05;
            }
        }

		[MTParameter(Order = 0)]
		public string Text { get; set; }
		[MTParameter(Order = 1)]
		public string Url { get; set; }


    }
}
