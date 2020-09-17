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
    [MTObject(0x9bd86e6a)]
    public class TLCreateStickerSet : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9bd86e6a;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=0, FlagType= FlagType.True)]
		public bool Masks { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputUser UserId { get; set; }
		[MTParameter(Order = 3)]
		public string Title { get; set; }
		[MTParameter(Order = 4)]
		public string ShortName { get; set; }
		[MTParameter(Order = 5)]
		public TLVector<MTSharp.Schema.TL.TLInputStickerSetItem> Stickers { get; set; }


    }
}
