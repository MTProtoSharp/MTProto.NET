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
    [MTObject(0x6628562c)]
    public class TLUpdateStatus : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6628562c;
            }
        }

		[MTParameter(Order = 0)]
		public bool Offline { get; set; }


    }
}
