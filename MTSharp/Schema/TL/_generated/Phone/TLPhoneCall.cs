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

namespace MTSharp.Schema.TL.Phone
{
    [MTObject(0xec82e140)]
    public class TLPhoneCall : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xec82e140;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsPhoneCall PhoneCall { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
