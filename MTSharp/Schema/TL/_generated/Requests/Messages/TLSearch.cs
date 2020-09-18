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
    [MTObject(0x8614ef68)]
    public class TLSearch : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8614ef68;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 2)]
		public string Q { get; set; }
		[MTParameter(Order = 3, FlagBitId=0, FlagType= FlagType.Null)]
		public TLAbsInputUser FromId { get; set; }
		[MTParameter(Order = 4)]
		public TLAbsMessagesFilter Filter { get; set; }
		[MTParameter(Order = 5)]
		public int MinDate { get; set; }
		[MTParameter(Order = 6)]
		public int MaxDate { get; set; }
		[MTParameter(Order = 7)]
		public int OffsetId { get; set; }
		[MTParameter(Order = 8)]
		public int AddOffset { get; set; }
		[MTParameter(Order = 9)]
		public int Limit { get; set; }
		[MTParameter(Order = 10)]
		public int MaxId { get; set; }
		[MTParameter(Order = 11)]
		public int MinId { get; set; }
		[MTParameter(Order = 12)]
		public int Hash { get; set; }


    }
}
