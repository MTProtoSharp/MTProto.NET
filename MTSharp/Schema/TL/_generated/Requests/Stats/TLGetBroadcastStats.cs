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

namespace MTSharp.Schema.TL.Requests.Stats
{
    [MTObject(0xab42441a)]
    public class TLGetBroadcastStats : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xab42441a;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Dark { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputChannel Channel { get; set; }


    }
}
