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
    [MTObject(0x810a9fec)]
    public class TLGetBotCallbackAnswer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x810a9fec;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=1, FlagType= FlagType.True)]
		public bool Game { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 3)]
		public int MsgId { get; set; }
		[MTParameter(Order = 4, FromFlag=0, FlagType= FlagType.Null)]
		public byte[] Data { get; set; }


    }
}
