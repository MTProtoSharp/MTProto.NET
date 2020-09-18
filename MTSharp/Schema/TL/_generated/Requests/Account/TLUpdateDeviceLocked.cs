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
    [MTObject(0x38df3532)]
    public class TLUpdateDeviceLocked : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x38df3532;
            }
        }

		[MTParameter(Order = 0)]
		public int Period { get; set; }


    }
}
