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
    [MTObject(0x2d01b9ef)]
    public class TLResetWebAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2d01b9ef;
            }
        }

		[MTParameter(Order = 0)]
		public long Hash { get; set; }


    }
}
