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

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xf8b036af)]
    public class TLGetAdminedPublicChannels : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf8b036af;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool ByLocation { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool CheckLimit { get; set; }


    }
}
