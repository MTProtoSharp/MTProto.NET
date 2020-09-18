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
    [MTObject(0xdf969c2d)]
    public class TLExportedAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdf969c2d;
            }
        }

		[MTParameter(Order = 0)]
		public int Id { get; set; }
		[MTParameter(Order = 1)]
		public byte[] Bytes { get; set; }


    }
}
