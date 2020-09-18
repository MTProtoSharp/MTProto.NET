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
    [MTObject(0x6242c773)]
    public class TLFileHash : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6242c773;
            }
        }

		[MTParameter(Order = 0)]
		public int Offset { get; set; }
		[MTParameter(Order = 1)]
		public int Limit { get; set; }
		[MTParameter(Order = 2)]
		public byte[] Hash { get; set; }


    }
}
