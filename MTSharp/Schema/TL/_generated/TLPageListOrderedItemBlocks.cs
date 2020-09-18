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
    [MTObject(0x98dd8936)]
    public class TLPageListOrderedItemBlocks : TLAbsPageListOrderedItem
    {
        public override uint Constructor
        {
            get
            {
                return 0x98dd8936;
            }
        }

		[MTParameter(Order = 0)]
		public string Num { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsPageBlock> Blocks { get; set; }


    }
}
