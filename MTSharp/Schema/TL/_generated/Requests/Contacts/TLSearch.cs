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

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0x11f812d8)]
    public class TLSearch : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x11f812d8;
            }
        }

		[MTParameter(Order = 0)]
		public string Q { get; set; }
		[MTParameter(Order = 1)]
		public int Limit { get; set; }


    }
}
