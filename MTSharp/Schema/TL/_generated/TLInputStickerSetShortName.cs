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
    [MTObject(0x861cc8a0)]
    public class TLInputStickerSetShortName : TLAbsInputStickerSet
    {
        public override uint Constructor
        {
            get
            {
                return 0x861cc8a0;
            }
        }

		[MTParameter(Order = 0)]
		public string ShortName { get; set; }


    }
}
