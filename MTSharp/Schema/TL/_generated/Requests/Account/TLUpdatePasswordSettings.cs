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
    [MTObject(0xa59b102f)]
    public class TLUpdatePasswordSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa59b102f;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputCheckPasswordSRP Password { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.Account.TLPasswordInputSettings NewSettings { get; set; }


    }
}
