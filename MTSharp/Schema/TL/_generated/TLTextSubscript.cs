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
    [MTObject(0xed6a8504)]
    public class TLTextSubscript : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0xed6a8504;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsRichText Text { get; set; }


    }
}
