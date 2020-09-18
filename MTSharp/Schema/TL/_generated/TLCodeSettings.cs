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
    [MTObject(0xdebebe83)]
    public class TLCodeSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdebebe83;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool AllowFlashcall { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool CurrentNumber { get; set; }
		[MTParameter(Order = 3, FlagBitId=4, FlagType= FlagType.True)]
		public bool AllowAppHash { get; set; }


    }
}
