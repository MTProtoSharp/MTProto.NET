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
    [MTObject(0xa677244f)]
    public class TLSendCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa677244f;
            }
        }

		[MTParameter(Order = 0)]
		public string PhoneNumber { get; set; }
		[MTParameter(Order = 1)]
		public int ApiId { get; set; }
		[MTParameter(Order = 2)]
		public string ApiHash { get; set; }
		[MTParameter(Order = 3)]
		public MTSharp.Schema.TL.TLCodeSettings Settings { get; set; }


    }
}
