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
    [MTObject(0xf2f2330a)]
    public class TLGetLangPack : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf2f2330a;
            }
        }

		[MTParameter(Order = 0)]
		public string LangPack { get; set; }
		[MTParameter(Order = 1)]
		public string LangCode { get; set; }


    }
}
