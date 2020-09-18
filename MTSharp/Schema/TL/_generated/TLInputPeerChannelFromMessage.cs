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
    [MTObject(0x9c95f7bb)]
    public class TLInputPeerChannelFromMessage : TLAbsInputPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x9c95f7bb;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public int MsgId { get; set; }
		[MTParameter(Order = 2)]
		public int ChannelId { get; set; }


    }
}
