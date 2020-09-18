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
    [MTObject(0x683a5e46)]
    public class TLKeyboardButtonCallback : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0x683a5e46;
            }
        }

		[MTParameter(Order = 0)]
		public string Text { get; set; }
		[MTParameter(Order = 1)]
		public byte[] Data { get; set; }


    }
}
