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
    [MTObject(0x6c50051c)]
    public class TLImportChatInvite : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6c50051c;
            }
        }

		[MTParameter(Order = 0)]
		public string Hash { get; set; }


    }
}
