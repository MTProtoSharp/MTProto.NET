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
    [MTObject(0x804361ea)]
    public class TLPageBlockAudio : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x804361ea;
            }
        }

		[MTParameter(Order = 0)]
		public long AudioId { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLPageCaption Caption { get; set; }


    }
}
