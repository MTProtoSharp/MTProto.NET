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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xb86ba8e1)]
    public class TLGetAuthorizationForm : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb86ba8e1;
            }
        }

		[MTParameter(Order = 0)]
		public int BotId { get; set; }
		[MTParameter(Order = 1)]
		public string Scope { get; set; }
		[MTParameter(Order = 2)]
		public string PublicKey { get; set; }


    }
}
