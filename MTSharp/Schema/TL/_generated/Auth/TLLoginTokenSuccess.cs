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

namespace MTSharp.Schema.TL.Auth
{
    [MTObject(0x390d5c5e)]
    public class TLLoginTokenSuccess : TLAbsLoginToken
    {
        public override uint Constructor
        {
            get
            {
                return 0x390d5c5e;
            }
        }

		[MTParameter(Order = 0)]
		public Auth.TLAbsAuthorization Authorization { get; set; }


    }
}
