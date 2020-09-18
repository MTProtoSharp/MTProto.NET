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
    [MTObject(0x15ba6c40)]
    public class TLDialogs : TLAbsDialogs
    {
        public override uint Constructor
        {
            get
            {
                return 0x15ba6c40;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsDialog> Dialogs { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsMessage> Messages { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<TLAbsChat> Chats { get; set; }
		[MTParameter(Order = 3)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
