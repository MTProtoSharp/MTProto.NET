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
    [MTObject(0xf89cf5e8)]
    public class TLMessageActionChatJoinedByLink : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xf89cf5e8;
            }
        }

		[MTParameter(Order = 0)]
		public int InviterId { get; set; }


    }
}
