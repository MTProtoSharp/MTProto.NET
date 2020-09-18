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
    [MTObject(0x51bdb021)]
    public class TLMessageActionChatMigrateTo : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x51bdb021;
            }
        }

		[MTParameter(Order = 0)]
		public int ChannelId { get; set; }


    }
}
