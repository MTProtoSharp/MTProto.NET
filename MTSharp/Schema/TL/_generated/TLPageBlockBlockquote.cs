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
    [MTObject(0x263d7c26)]
    public class TLPageBlockBlockquote : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x263d7c26;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsRichText Text { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsRichText Caption { get; set; }


    }
}
