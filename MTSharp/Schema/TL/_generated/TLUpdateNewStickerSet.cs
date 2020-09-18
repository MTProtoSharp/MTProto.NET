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
    [MTObject(0x688a30aa)]
    public class TLUpdateNewStickerSet : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x688a30aa;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.Messages.TLStickerSet Stickerset { get; set; }


    }
}
