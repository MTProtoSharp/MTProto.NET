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
    [MTObject(0x5dab1af4)]
    public class TLExportedMessageLink : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5dab1af4;
            }
        }

		[MTParameter(Order = 0)]
		public string Link { get; set; }
		[MTParameter(Order = 1)]
		public string Html { get; set; }


    }
}
