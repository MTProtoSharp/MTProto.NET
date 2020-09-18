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
    [MTObject(0xbaafe5e0)]
    public class TLPageBlockAuthorDate : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xbaafe5e0;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsRichText Author { get; set; }
		[MTParameter(Order = 1)]
		public int PublishedDate { get; set; }


    }
}
