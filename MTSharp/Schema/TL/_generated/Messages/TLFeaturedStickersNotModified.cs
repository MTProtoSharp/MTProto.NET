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

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xc6dc0c66)]
    public class TLFeaturedStickersNotModified : TLAbsFeaturedStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xc6dc0c66;
            }
        }

		[MTParameter(Order = 0)]
		public int Count { get; set; }


    }
}
