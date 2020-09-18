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
    [MTObject(0xc070d93e)]
    public class TLPageBlockPreformatted : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xc070d93e;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsRichText Text { get; set; }
		[MTParameter(Order = 1)]
		public string Language { get; set; }


    }
}
