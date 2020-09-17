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
    [MTObject(0xdcbb8260)]
    public class TLGetHistory : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdcbb8260;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public int OffsetId { get; set; }
		[MTParameter(Order = 2)]
		public int OffsetDate { get; set; }
		[MTParameter(Order = 3)]
		public int AddOffset { get; set; }
		[MTParameter(Order = 4)]
		public int Limit { get; set; }
		[MTParameter(Order = 5)]
		public int MaxId { get; set; }
		[MTParameter(Order = 6)]
		public int MinId { get; set; }
		[MTParameter(Order = 7)]
		public int Hash { get; set; }


    }
}
