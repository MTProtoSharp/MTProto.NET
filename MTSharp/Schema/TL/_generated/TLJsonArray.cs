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
    [MTObject(0xf7444763)]
    public class TLJsonArray : TLAbsJSONValue
    {
        public override uint Constructor
        {
            get
            {
                return 0xf7444763;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsJSONValue> Value { get; set; }


    }
}
