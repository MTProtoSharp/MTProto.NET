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
    [MTObject(0xab0f6b1e)]
    public class TLUpdatePhoneCall : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xab0f6b1e;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsPhoneCall PhoneCall { get; set; }


    }
}
