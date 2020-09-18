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
    [MTObject(0xdbaeae9)]
    public class TLInputStickerSetThumb : TLAbsInputFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0xdbaeae9;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputStickerSet Stickerset { get; set; }
		[MTParameter(Order = 1)]
		public long VolumeId { get; set; }
		[MTParameter(Order = 2)]
		public int LocalId { get; set; }


    }
}
