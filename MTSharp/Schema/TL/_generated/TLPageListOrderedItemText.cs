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
    [MTObject(0x5e068047)]
    public class TLPageListOrderedItemText : TLAbsPageListOrderedItem
    {
        public override uint Constructor
        {
            get
            {
                return 0x5e068047;
            }
        }

		[MTParameter(Order = 0)]
		public string Num { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsRichText Text { get; set; }


    }
}
