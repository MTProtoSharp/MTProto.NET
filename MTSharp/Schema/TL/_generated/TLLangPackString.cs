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
    [MTObject(0xcad181f6)]
    public class TLLangPackString : TLAbsLangPackString
    {
        public override uint Constructor
        {
            get
            {
                return 0xcad181f6;
            }
        }

		[MTParameter(Order = 0)]
		public string Key { get; set; }
		[MTParameter(Order = 1)]
		public string Value { get; set; }


    }
}
