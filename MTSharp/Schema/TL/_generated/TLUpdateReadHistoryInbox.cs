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
    [MTObject(0x9c974fdf)]
    public class TLUpdateReadHistoryInbox : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x9c974fdf;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.Null)]
		public int? FolderId { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsPeer Peer { get; set; }
		[MTParameter(Order = 3)]
		public int MaxId { get; set; }
		[MTParameter(Order = 4)]
		public int StillUnreadCount { get; set; }
		[MTParameter(Order = 5)]
		public int Pts { get; set; }
		[MTParameter(Order = 6)]
		public int PtsCount { get; set; }


    }
}
