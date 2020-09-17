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
    [MTObject(0xf7760f51)]
    public class TLRemoveStickerFromSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf7760f51;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputDocument Sticker { get; set; }


    }
}
