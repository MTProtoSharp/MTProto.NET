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
    [MTObject(0xbea2f424)]
    public class TLGlobalPrivacySettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbea2f424;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.Null)]
		public bool? ArchiveAndMuteNewNoncontactPeers { get; set; }


    }
}
