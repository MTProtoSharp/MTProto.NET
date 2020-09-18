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

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xe5d7d19c)]
    public class TLChatFull : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe5d7d19c;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsChatFull FullChat { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsChat> Chats { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
