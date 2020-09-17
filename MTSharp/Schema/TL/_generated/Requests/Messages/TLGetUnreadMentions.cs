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
    [MTObject(0x46578472)]
    public class TLGetUnreadMentions : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x46578472;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public int OffsetId { get; set; }
		[MTParameter(Order = 2)]
		public int AddOffset { get; set; }
		[MTParameter(Order = 3)]
		public int Limit { get; set; }
		[MTParameter(Order = 4)]
		public int MaxId { get; set; }
		[MTParameter(Order = 5)]
		public int MinId { get; set; }


    }
}
