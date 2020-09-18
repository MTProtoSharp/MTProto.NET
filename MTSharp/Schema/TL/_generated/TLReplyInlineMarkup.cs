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
    [MTObject(0x48a30254)]
    public class TLReplyInlineMarkup : TLAbsReplyMarkup
    {
        public override uint Constructor
        {
            get
            {
                return 0x48a30254;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<MTSharp.Schema.TL.TLKeyboardButtonRow> Rows { get; set; }


    }
}
