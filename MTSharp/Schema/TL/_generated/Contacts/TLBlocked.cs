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

namespace MTSharp.Schema.TL.Contacts
{
    [MTObject(0x1c138d15)]
    public class TLBlocked : TLAbsBlocked
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c138d15;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<MTSharp.Schema.TL.TLContactBlocked> Blocked { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
