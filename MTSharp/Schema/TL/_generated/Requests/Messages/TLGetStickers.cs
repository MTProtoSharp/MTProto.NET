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
    [MTObject(0x43d4f2c)]
    public class TLGetStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x43d4f2c;
            }
        }

		[MTParameter(Order = 0)]
		public string Emoticon { get; set; }
		[MTParameter(Order = 1)]
		public int Hash { get; set; }


    }
}
