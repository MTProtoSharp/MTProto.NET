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
    [MTObject(0x3c2884c1)]
    public class TLTextUrl : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x3c2884c1;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsRichText Text { get; set; }
		[MTParameter(Order = 1)]
		public string Url { get; set; }
		[MTParameter(Order = 2)]
		public long WebpageId { get; set; }


    }
}
