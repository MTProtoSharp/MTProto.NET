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
    [MTObject(0x46e1d13d)]
    public class TLRecentMeUrlUnknown : TLAbsRecentMeUrl
    {
        public override uint Constructor
        {
            get
            {
                return 0x46e1d13d;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }


    }
}
