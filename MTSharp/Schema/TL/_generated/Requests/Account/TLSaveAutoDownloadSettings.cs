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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x76f36233)]
    public class TLSaveAutoDownloadSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x76f36233;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Low { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool High { get; set; }
		[MTParameter(Order = 3)]
		public MTSharp.Schema.TL.TLAutoDownloadSettings Settings { get; set; }


    }
}
