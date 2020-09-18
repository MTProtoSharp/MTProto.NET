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

namespace MTSharp.Schema.TL.Updates
{
    [MTObject(0x3e11affb)]
    public class TLChannelDifferenceEmpty : TLAbsChannelDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0x3e11affb;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Final { get; set; }
		[MTParameter(Order = 2)]
		public int Pts { get; set; }
		[MTParameter(Order = 3, FlagBitId=1, FlagType= FlagType.Null)]
		public int? Timeout { get; set; }


    }
}
