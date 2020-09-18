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
    [MTObject(0xe8a40bd9)]
    public class TLSecureValueErrorData : TLAbsSecureValueError
    {
        public override uint Constructor
        {
            get
            {
                return 0xe8a40bd9;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsSecureValueType Type { get; set; }
		[MTParameter(Order = 1)]
		public byte[] DataHash { get; set; }
		[MTParameter(Order = 2)]
		public string Field { get; set; }
		[MTParameter(Order = 3)]
		public string Text { get; set; }


    }
}
