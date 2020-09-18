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

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x811f854f)]
    public class TLSentEmailCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x811f854f;
            }
        }

		[MTParameter(Order = 0)]
		public string EmailPattern { get; set; }
		[MTParameter(Order = 1)]
		public int Length { get; set; }


    }
}
