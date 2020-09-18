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
    [MTObject(0xf041e250)]
    public class TLChatOnlines : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf041e250;
            }
        }

		[MTParameter(Order = 0)]
		public int Onlines { get; set; }


    }
}
