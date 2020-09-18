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
    [MTObject(0x65a0fa4d)]
    public class TLPageBlockCollage : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x65a0fa4d;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsPageBlock> Items { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLPageCaption Caption { get; set; }


    }
}
