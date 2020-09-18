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

namespace MTSharp.Schema.TL.Requests.Help
{
    [MTObject(0x3fedc75f)]
    public class TLGetDeepLinkInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3fedc75f;
            }
        }

		[MTParameter(Order = 0)]
		public string Path { get; set; }


    }
}
