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
    [MTObject(0xcd050916)]
    public class TLAuthorization : TLAbsAuthorization
    {
        public override uint Constructor
        {
            get
            {
                return 0xcd050916;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.Null)]
		public int? TmpSessions { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsUser User { get; set; }


    }
}
