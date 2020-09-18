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
    [MTObject(0xf0e3e596)]
    public class TLDialogsNotModified : TLAbsDialogs
    {
        public override uint Constructor
        {
            get
            {
                return 0xf0e3e596;
            }
        }

		[MTParameter(Order = 0)]
		public int Count { get; set; }


    }
}
