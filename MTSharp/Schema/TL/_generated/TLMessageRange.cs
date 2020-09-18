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
    [MTObject(0xae30253)]
    public class TLMessageRange : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xae30253;
            }
        }

		[MTParameter(Order = 0)]
		public int MinId { get; set; }
		[MTParameter(Order = 1)]
		public int MaxId { get; set; }


    }
}
