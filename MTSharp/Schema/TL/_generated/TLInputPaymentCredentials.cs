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
    [MTObject(0x3417d728)]
    public class TLInputPaymentCredentials : TLAbsInputPaymentCredentials
    {
        public override uint Constructor
        {
            get
            {
                return 0x3417d728;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Save { get; set; }
		[MTParameter(Order = 2)]
		public MTSharp.Schema.TL.TLDataJSON Data { get; set; }


    }
}
