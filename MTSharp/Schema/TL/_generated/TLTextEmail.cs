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
    [MTObject(0xde5a0dd6)]
    public class TLTextEmail : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0xde5a0dd6;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsRichText Text { get; set; }
		[MTParameter(Order = 1)]
		public string Email { get; set; }


    }
}
