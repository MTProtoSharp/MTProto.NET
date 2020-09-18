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

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x63cacf26)]
    public class TLAutoDownloadSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x63cacf26;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLAutoDownloadSettings Low { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLAutoDownloadSettings Medium { get; set; }
		[MTParameter(Order = 2)]
		public MTSharp.Schema.TL.TLAutoDownloadSettings High { get; set; }


    }
}
