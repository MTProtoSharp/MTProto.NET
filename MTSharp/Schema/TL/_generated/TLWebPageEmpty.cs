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
    [MTObject(0xeb1477e8)]
    public class TLWebPageEmpty : TLAbsWebPage
    {
        public override uint Constructor
        {
            get
            {
                return 0xeb1477e8;
            }
        }

		[MTParameter(Order = 0)]
		public long Id { get; set; }


    }
}
