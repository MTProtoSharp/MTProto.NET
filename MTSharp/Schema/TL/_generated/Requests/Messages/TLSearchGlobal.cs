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
    [MTObject(0xbf7225a4)]
    public class TLSearchGlobal : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbf7225a4;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=0, FlagType= FlagType.Null)]
		public int? FolderId { get; set; }
		[MTParameter(Order = 2)]
		public string Q { get; set; }
		[MTParameter(Order = 3)]
		public int OffsetRate { get; set; }
		[MTParameter(Order = 4)]
		public TLAbsInputPeer OffsetPeer { get; set; }
		[MTParameter(Order = 5)]
		public int OffsetId { get; set; }
		[MTParameter(Order = 6)]
		public int Limit { get; set; }


    }
}
