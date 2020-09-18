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
    [MTObject(0xa6638b9a)]
    public class TLMessageActionChatCreate : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xa6638b9a;
            }
        }

		[MTParameter(Order = 0)]
		public string Title { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<int> Users { get; set; }


    }
}
