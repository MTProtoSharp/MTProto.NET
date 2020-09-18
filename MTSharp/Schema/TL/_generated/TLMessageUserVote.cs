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
    [MTObject(0xa28e5559)]
    public class TLMessageUserVote : TLAbsMessageUserVote
    {
        public override uint Constructor
        {
            get
            {
                return 0xa28e5559;
            }
        }

		[MTParameter(Order = 0)]
		public int UserId { get; set; }
		[MTParameter(Order = 1)]
		public byte[] Option { get; set; }
		[MTParameter(Order = 2)]
		public int Date { get; set; }


    }
}
