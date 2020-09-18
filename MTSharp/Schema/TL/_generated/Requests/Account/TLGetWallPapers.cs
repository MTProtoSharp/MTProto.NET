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
    [MTObject(0xaabb1763)]
    public class TLGetWallPapers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xaabb1763;
            }
        }

		[MTParameter(Order = 0)]
		public int Hash { get; set; }


    }
}
