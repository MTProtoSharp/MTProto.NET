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
    [MTObject(0xafd93fbb)]
    public class TLKeyboardButtonBuy : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0xafd93fbb;
            }
        }

		[MTParameter(Order = 0)]
		public string Text { get; set; }


    }
}
