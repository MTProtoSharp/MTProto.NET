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
    [MTObject(0xed56c9fc)]
    public class TLWebAuthorizations : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xed56c9fc;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<MTSharp.Schema.TL.TLWebAuthorization> Authorizations { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
