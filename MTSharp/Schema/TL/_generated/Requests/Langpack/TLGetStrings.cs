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

namespace MTSharp.Schema.TL.Requests.Langpack
{
    [MTObject(0xefea3803)]
    public class TLGetStrings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xefea3803;
            }
        }

		[MTParameter(Order = 0)]
		public string LangPack { get; set; }
		[MTParameter(Order = 1)]
		public string LangCode { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<string> Keys { get; set; }


    }
}
