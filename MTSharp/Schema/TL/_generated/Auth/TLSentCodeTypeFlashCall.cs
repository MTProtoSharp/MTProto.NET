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

namespace MTSharp.Schema.TL.Auth
{
    [MTObject(0xab03c6d9)]
    public class TLSentCodeTypeFlashCall : TLAbsSentCodeType
    {
        public override uint Constructor
        {
            get
            {
                return 0xab03c6d9;
            }
        }

		[MTParameter(Order = 0)]
		public string Pattern { get; set; }


    }
}
