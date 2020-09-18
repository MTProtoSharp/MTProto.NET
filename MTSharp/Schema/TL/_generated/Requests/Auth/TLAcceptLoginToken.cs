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
    [MTObject(0xe894ad4d)]
    public class TLAcceptLoginToken : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe894ad4d;
            }
        }

		[MTParameter(Order = 0)]
		public byte[] Token { get; set; }


    }
}
