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
    [MTObject(0x47a971e0)]
    public class TLStatsURL : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x47a971e0;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }


    }
}
