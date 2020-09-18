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
    [MTObject(0xa0ee3b73)]
    public class TLGetDialogs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa0ee3b73;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool ExcludePinned { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.Null)]
		public int? FolderId { get; set; }
		[MTParameter(Order = 3)]
		public int OffsetDate { get; set; }
		[MTParameter(Order = 4)]
		public int OffsetId { get; set; }
		[MTParameter(Order = 5)]
		public TLAbsInputPeer OffsetPeer { get; set; }
		[MTParameter(Order = 6)]
		public int Limit { get; set; }
		[MTParameter(Order = 7)]
		public int Hash { get; set; }


    }
}
