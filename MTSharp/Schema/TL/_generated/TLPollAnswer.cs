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
    [MTObject(0x6ca9c2e9)]
    public class TLPollAnswer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6ca9c2e9;
            }
        }

		[MTParameter(Order = 0)]
		public string Text { get; set; }
		[MTParameter(Order = 1)]
		public byte[] Option { get; set; }


    }
}
