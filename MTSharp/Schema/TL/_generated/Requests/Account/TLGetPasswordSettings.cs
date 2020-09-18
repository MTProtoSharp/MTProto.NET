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
    [MTObject(0x9cd4eaf9)]
    public class TLGetPasswordSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9cd4eaf9;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputCheckPasswordSRP Password { get; set; }


    }
}
