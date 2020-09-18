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
    [MTObject(0x92d33a0e)]
    public class TLUrlAuthResultRequest : TLAbsUrlAuthResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x92d33a0e;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool RequestWriteAccess { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsUser Bot { get; set; }
		[MTParameter(Order = 3)]
		public string Domain { get; set; }


    }
}
