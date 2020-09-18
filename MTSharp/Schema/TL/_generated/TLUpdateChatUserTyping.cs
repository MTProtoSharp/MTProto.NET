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
    [MTObject(0x9a65ea1f)]
    public class TLUpdateChatUserTyping : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x9a65ea1f;
            }
        }

		[MTParameter(Order = 0)]
		public int ChatId { get; set; }
		[MTParameter(Order = 1)]
		public int UserId { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsSendMessageAction Action { get; set; }


    }
}
