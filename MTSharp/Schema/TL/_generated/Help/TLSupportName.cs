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

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0x8c05f1c9)]
    public class TLSupportName : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8c05f1c9;
            }
        }

		[MTParameter(Order = 0)]
		public string Name { get; set; }


    }
}
