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
    [MTObject(0x4fcba9c8)]
    public class TLArchivedStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4fcba9c8;
            }
        }

		[MTParameter(Order = 0)]
		public int Count { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsStickerSetCovered> Sets { get; set; }


    }
}
