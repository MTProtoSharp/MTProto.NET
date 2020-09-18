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
    [MTObject(0x6410a5d2)]
    public class TLStickerSetCovered : TLAbsStickerSetCovered
    {
        public override uint Constructor
        {
            get
            {
                return 0x6410a5d2;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLStickerSet Set { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsDocument Cover { get; set; }


    }
}
