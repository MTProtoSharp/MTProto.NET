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
    [MTObject(0xe4e88011)]
    public class TLPageBlockList : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xe4e88011;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsPageListItem> Items { get; set; }


    }
}
