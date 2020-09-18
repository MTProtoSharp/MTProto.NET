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
    [MTObject(0x3407e51b)]
    public class TLStickerSetMultiCovered : TLAbsStickerSetCovered
    {
        public override uint Constructor
        {
            get
            {
                return 0x3407e51b;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLStickerSet Set { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsDocument> Covers { get; set; }


    }
}
