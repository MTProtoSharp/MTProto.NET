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
    [MTObject(0xb1b41517)]
    public class TLExportLoginToken : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb1b41517;
            }
        }

		[MTParameter(Order = 0)]
		public int ApiId { get; set; }
		[MTParameter(Order = 1)]
		public string ApiHash { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<int> ExceptIds { get; set; }


    }
}
