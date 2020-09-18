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

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0x17c6b5f6)]
    public class TLSupport : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x17c6b5f6;
            }
        }

		[MTParameter(Order = 0)]
		public string PhoneNumber { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsUser User { get; set; }


    }
}
