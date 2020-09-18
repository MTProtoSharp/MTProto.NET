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
    [MTObject(0xf4108aa0)]
    public class TLReplyKeyboardForceReply : TLAbsReplyMarkup
    {
        public override uint Constructor
        {
            get
            {
                return 0xf4108aa0;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=1, FlagType= FlagType.True)]
		public bool SingleUse { get; set; }
		[MTParameter(Order = 2, FlagBitId=2, FlagType= FlagType.True)]
		public bool Selective { get; set; }


    }
}
