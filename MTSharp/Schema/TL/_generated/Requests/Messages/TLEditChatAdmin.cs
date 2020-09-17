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
    [MTObject(0xa9e69f2e)]
    public class TLEditChatAdmin : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa9e69f2e;
            }
        }

		[MTParameter(Order = 0)]
		public int ChatId { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputUser UserId { get; set; }
		[MTParameter(Order = 2)]
		public bool IsAdmin { get; set; }


    }
}
