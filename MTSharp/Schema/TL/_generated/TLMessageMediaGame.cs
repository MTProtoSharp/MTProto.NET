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
    [MTObject(0xfdb19008)]
    public class TLMessageMediaGame : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xfdb19008;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLGame Game { get; set; }


    }
}
