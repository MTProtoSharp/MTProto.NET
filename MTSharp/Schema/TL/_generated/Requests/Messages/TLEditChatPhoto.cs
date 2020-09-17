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
    [MTObject(0xca4c79d8)]
    public class TLEditChatPhoto : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xca4c79d8;
            }
        }

		[MTParameter(Order = 0)]
		public int ChatId { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputChatPhoto Photo { get; set; }


    }
}
