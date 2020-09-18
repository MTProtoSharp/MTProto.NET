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
    [MTObject(0x3f7ee58b)]
    public class TLMessageMediaDice : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x3f7ee58b;
            }
        }

		[MTParameter(Order = 0)]
		public int Value { get; set; }
		[MTParameter(Order = 1)]
		public string Emoticon { get; set; }


    }
}
