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
    [MTObject(0xe5bfffcd)]
    public class TLExportAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe5bfffcd;
            }
        }

		[MTParameter(Order = 0)]
		public int DcId { get; set; }


    }
}
