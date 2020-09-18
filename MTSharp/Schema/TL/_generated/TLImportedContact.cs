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
    [MTObject(0xd0028438)]
    public class TLImportedContact : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd0028438;
            }
        }

		[MTParameter(Order = 0)]
		public int UserId { get; set; }
		[MTParameter(Order = 1)]
		public long ClientId { get; set; }


    }
}
