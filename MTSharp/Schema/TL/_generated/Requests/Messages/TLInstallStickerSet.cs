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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xc78fe460)]
    public class TLInstallStickerSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc78fe460;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputStickerSet Stickerset { get; set; }
		[MTParameter(Order = 1)]
		public bool Archived { get; set; }


    }
}
