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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xf257106c)]
    public class TLSaveTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf257106c;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputTheme Theme { get; set; }
		[MTParameter(Order = 1)]
		public bool Unsave { get; set; }


    }
}
