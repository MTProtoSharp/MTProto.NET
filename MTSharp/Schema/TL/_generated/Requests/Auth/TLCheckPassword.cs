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
    [MTObject(0xd18b4d16)]
    public class TLCheckPassword : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd18b4d16;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputCheckPasswordSRP Password { get; set; }


    }
}
