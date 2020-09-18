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

namespace MTSharp.Schema.TL.Requests.Help
{
    [MTObject(0xee72f79a)]
    public class TLAcceptTermsOfService : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xee72f79a;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLDataJSON Id { get; set; }


    }
}
