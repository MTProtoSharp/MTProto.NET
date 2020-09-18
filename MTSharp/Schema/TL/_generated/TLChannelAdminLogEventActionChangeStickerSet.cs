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
    [MTObject(0xb1c3caa7)]
    public class TLChannelAdminLogEventActionChangeStickerSet : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xb1c3caa7;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputStickerSet PrevStickerset { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputStickerSet NewStickerset { get; set; }


    }
}
