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
    [MTObject(0xe537ced6)]
    public class TLSecureValueErrorSelfie : TLAbsSecureValueError
    {
        public override uint Constructor
        {
            get
            {
                return 0xe537ced6;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsSecureValueType Type { get; set; }
		[MTParameter(Order = 1)]
		public byte[] FileHash { get; set; }
		[MTParameter(Order = 2)]
		public string Text { get; set; }


    }
}
