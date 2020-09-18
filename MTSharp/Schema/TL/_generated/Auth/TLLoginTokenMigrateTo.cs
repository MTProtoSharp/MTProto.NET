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
    [MTObject(0x68e9916)]
    public class TLLoginTokenMigrateTo : TLAbsLoginToken
    {
        public override uint Constructor
        {
            get
            {
                return 0x68e9916;
            }
        }

		[MTParameter(Order = 0)]
		public int DcId { get; set; }
		[MTParameter(Order = 1)]
		public byte[] Token { get; set; }


    }
}
