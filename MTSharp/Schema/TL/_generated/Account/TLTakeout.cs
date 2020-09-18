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
    [MTObject(0x4dba4501)]
    public class TLTakeout : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4dba4501;
            }
        }

		[MTParameter(Order = 0)]
		public long Id { get; set; }


    }
}
