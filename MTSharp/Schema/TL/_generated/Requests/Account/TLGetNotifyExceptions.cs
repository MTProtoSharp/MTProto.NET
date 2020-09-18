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
    [MTObject(0x53577479)]
    public class TLGetNotifyExceptions : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x53577479;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=1, FlagType= FlagType.True)]
		public bool CompareSound { get; set; }
		[MTParameter(Order = 2, FlagBitId=0, FlagType= FlagType.Null)]
		public TLAbsInputNotifyPeer Peer { get; set; }


    }
}
