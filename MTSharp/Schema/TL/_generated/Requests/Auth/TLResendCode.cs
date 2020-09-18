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

namespace MTSharp.Schema.TL.Requests.Auth
{
    [MTObject(0x3ef1a9bf)]
    public class TLResendCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3ef1a9bf;
            }
        }

		[MTParameter(Order = 0)]
		public string PhoneNumber { get; set; }
		[MTParameter(Order = 1)]
		public string PhoneCodeHash { get; set; }


    }
}
