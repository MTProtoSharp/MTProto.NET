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
    [MTObject(0xc7345e6a)]
    public class TLJsonBool : TLAbsJSONValue
    {
        public override uint Constructor
        {
            get
            {
                return 0xc7345e6a;
            }
        }

		[MTParameter(Order = 0)]
		public bool Value { get; set; }


    }
}
