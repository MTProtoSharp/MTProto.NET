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
    [MTObject(0x71bd134c)]
    public class TLDialogFolder : TLAbsDialog
    {
        public override uint Constructor
        {
            get
            {
                return 0x71bd134c;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=2, FlagType= FlagType.True)]
		public bool Pinned { get; set; }
		[MTParameter(Order = 2)]
		public MTSharp.Schema.TL.TLFolder Folder { get; set; }
		[MTParameter(Order = 3)]
		public TLAbsPeer Peer { get; set; }
		[MTParameter(Order = 4)]
		public int TopMessage { get; set; }
		[MTParameter(Order = 5)]
		public int UnreadMutedPeersCount { get; set; }
		[MTParameter(Order = 6)]
		public int UnreadUnmutedPeersCount { get; set; }
		[MTParameter(Order = 7)]
		public int UnreadMutedMessagesCount { get; set; }
		[MTParameter(Order = 8)]
		public int UnreadUnmutedMessagesCount { get; set; }


    }
}
