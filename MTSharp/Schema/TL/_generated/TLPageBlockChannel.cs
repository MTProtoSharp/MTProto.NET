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
    [MTObject(0xef1751b5)]
    public class TLPageBlockChannel : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xef1751b5;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsChat Channel { get; set; }


    }
}
