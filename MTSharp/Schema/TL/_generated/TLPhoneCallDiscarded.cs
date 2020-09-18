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
    [MTObject(0x50ca4de1)]
    public class TLPhoneCallDiscarded : TLAbsPhoneCall
    {
        public override uint Constructor
        {
            get
            {
                return 0x50ca4de1;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=2, FlagType= FlagType.True)]
		public bool NeedRating { get; set; }
		[MTParameter(Order = 2, FlagBitId=3, FlagType= FlagType.True)]
		public bool NeedDebug { get; set; }
		[MTParameter(Order = 3, FlagBitId=6, FlagType= FlagType.True)]
		public bool Video { get; set; }
		[MTParameter(Order = 4)]
		public long Id { get; set; }
		[MTParameter(Order = 5, FlagBitId=0, FlagType= FlagType.Null)]
		public TLAbsPhoneCallDiscardReason Reason { get; set; }
		[MTParameter(Order = 6, FlagBitId=1, FlagType= FlagType.Null)]
		public int? Duration { get; set; }


    }
}
