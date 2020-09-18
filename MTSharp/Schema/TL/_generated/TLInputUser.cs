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

namespace MTSharp.Schema.TL
{
    [MTObject(0xd8292816)]
    public class TLInputUser : TLAbsInputUser
    {
        public override uint Constructor
        {
            get
            {
                return 0xd8292816;
            }
        }

		[MTParameter(Order = 0)]
		public int UserId { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }


    }
}
