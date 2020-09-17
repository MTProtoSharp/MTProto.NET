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
    [MTObject(0x8ef8ecc0)]
    public class TLSetGameScore : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8ef8ecc0;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=0, FlagType= FlagType.True)]
		public bool EditMessage { get; set; }
		[MTParameter(Order = 2, FromFlag=1, FlagType= FlagType.True)]
		public bool Force { get; set; }
		[MTParameter(Order = 3)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 4)]
		public int Id { get; set; }
		[MTParameter(Order = 5)]
		public TLAbsInputUser UserId { get; set; }
		[MTParameter(Order = 6)]
		public int Score { get; set; }


    }
}
