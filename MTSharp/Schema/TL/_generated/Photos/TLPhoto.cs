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

namespace MTSharp.Schema.TL.Photos
{
    [MTObject(0x20212ca8)]
    public class TLPhoto : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x20212ca8;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsPhoto Photo { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
