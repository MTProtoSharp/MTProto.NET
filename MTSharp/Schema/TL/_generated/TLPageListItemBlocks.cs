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
    [MTObject(0x25e073fc)]
    public class TLPageListItemBlocks : TLAbsPageListItem
    {
        public override uint Constructor
        {
            get
            {
                return 0x25e073fc;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsPageBlock> Blocks { get; set; }


    }
}
