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

namespace MTSharp.Schema.TL.Requests.Stickers
{
    [MTObject(0xffb6d4ca)]
    public class TLChangeStickerPosition : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xffb6d4ca;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputDocument Sticker { get; set; }
		[MTParameter(Order = 1)]
		public int Position { get; set; }


    }
}
