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
    [MTObject(0x1ccb966a)]
    public class TLTextPhone : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x1ccb966a;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsRichText Text { get; set; }
		[MTParameter(Order = 1)]
		public string Phone { get; set; }


    }
}
