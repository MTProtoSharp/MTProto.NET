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
    [MTObject(0xfc2e05bc)]
    public class TLChatInviteExported : TLAbsExportedChatInvite
    {
        public override uint Constructor
        {
            get
            {
                return 0xfc2e05bc;
            }
        }

		[MTParameter(Order = 0)]
		public string Link { get; set; }


    }
}
