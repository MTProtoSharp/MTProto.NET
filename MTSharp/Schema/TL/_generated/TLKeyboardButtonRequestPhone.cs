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
    [MTObject(0xb16a6c29)]
    public class TLKeyboardButtonRequestPhone : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0xb16a6c29;
            }
        }

		[MTParameter(Order = 0)]
		public string Text { get; set; }


    }
}
