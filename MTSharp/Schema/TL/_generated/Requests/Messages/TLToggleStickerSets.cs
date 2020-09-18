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
    [MTObject(0xb5052fea)]
    public class TLToggleStickerSets : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb5052fea;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Uninstall { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool Archive { get; set; }
		[MTParameter(Order = 3, FlagBitId=2, FlagType= FlagType.True)]
		public bool Unarchive { get; set; }
		[MTParameter(Order = 4)]
		public TLVector<TLAbsInputStickerSet> Stickersets { get; set; }


    }
}
