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
    [MTObject(0xc0de1bd9)]
    public class TLJsonObjectValue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc0de1bd9;
            }
        }

		[MTParameter(Order = 0)]
		public string Key { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsJSONValue Value { get; set; }


    }
}
