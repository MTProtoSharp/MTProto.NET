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
    [MTObject(0xb60a24a6)]
    public class TLStickerSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb60a24a6;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLStickerSet Set { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<MTSharp.Schema.TL.TLStickerPack> Packs { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<TLAbsDocument> Documents { get; set; }


    }
}
