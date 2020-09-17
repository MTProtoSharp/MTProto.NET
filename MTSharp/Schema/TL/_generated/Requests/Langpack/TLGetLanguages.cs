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
    [MTObject(0x42c6978f)]
    public class TLGetLanguages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x42c6978f;
            }
        }

		[MTParameter(Order = 0)]
		public string LangPack { get; set; }


    }
}
