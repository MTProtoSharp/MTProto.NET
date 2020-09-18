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
    [MTObject(0xb3fb5361)]
    public class TLEmojiLanguage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb3fb5361;
            }
        }

		[MTParameter(Order = 0)]
		public string LangCode { get; set; }


    }
}
