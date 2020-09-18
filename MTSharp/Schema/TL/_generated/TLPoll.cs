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
    [MTObject(0x86e18161)]
    public class TLPoll : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x86e18161;
            }
        }

		[MTParameter(Order = 0)]
		public long Id { get; set; }
		[MTParameter(Order = 1, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 2, FlagBitId=0, FlagType= FlagType.True)]
		public bool Closed { get; set; }
		[MTParameter(Order = 3, FlagBitId=1, FlagType= FlagType.True)]
		public bool PublicVoters { get; set; }
		[MTParameter(Order = 4, FlagBitId=2, FlagType= FlagType.True)]
		public bool MultipleChoice { get; set; }
		[MTParameter(Order = 5, FlagBitId=3, FlagType= FlagType.True)]
		public bool Quiz { get; set; }
		[MTParameter(Order = 6)]
		public string Question { get; set; }
		[MTParameter(Order = 7)]
		public TLVector<MTSharp.Schema.TL.TLPollAnswer> Answers { get; set; }
		[MTParameter(Order = 8, FlagBitId=4, FlagType= FlagType.Null)]
		public int? ClosePeriod { get; set; }
		[MTParameter(Order = 9, FlagBitId=5, FlagType= FlagType.Null)]
		public int? CloseDate { get; set; }


    }
}
