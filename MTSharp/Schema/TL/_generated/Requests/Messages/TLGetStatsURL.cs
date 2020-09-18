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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x812c2ae6)]
    public class TLGetStatsURL : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x812c2ae6;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Dark { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 3)]
		public string Params { get; set; }


    }
}
