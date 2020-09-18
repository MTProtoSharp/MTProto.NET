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
    [MTObject(0xcb296bf8)]
    public class TLLabeledPrice : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcb296bf8;
            }
        }

		[MTParameter(Order = 0)]
		public string Label { get; set; }
		[MTParameter(Order = 1)]
		public long Amount { get; set; }


    }
}
