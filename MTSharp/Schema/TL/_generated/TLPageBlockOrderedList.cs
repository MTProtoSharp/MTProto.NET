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
    [MTObject(0x9a8ae1e1)]
    public class TLPageBlockOrderedList : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x9a8ae1e1;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsPageListOrderedItem> Items { get; set; }


    }
}
