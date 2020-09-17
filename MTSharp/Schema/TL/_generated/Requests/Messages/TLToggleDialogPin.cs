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
    [MTObject(0xa731e257)]
    public class TLToggleDialogPin : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa731e257;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=0, FlagType= FlagType.True)]
		public bool Pinned { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputDialogPeer Peer { get; set; }


    }
}
