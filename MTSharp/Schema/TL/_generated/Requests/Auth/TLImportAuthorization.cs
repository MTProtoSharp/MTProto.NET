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
    [MTObject(0xe3ef9613)]
    public class TLImportAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe3ef9613;
            }
        }

		[MTParameter(Order = 0)]
		public int Id { get; set; }
		[MTParameter(Order = 1)]
		public byte[] Bytes { get; set; }


    }
}
