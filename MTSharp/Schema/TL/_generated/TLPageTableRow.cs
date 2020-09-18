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
    [MTObject(0xe0c0c5e5)]
    public class TLPageTableRow : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe0c0c5e5;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<MTSharp.Schema.TL.TLPageTableCell> Cells { get; set; }


    }
}
