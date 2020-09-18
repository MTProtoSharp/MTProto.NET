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
    [MTObject(0xa8718dc5)]
    public class TLPageBlockEmbed : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xa8718dc5;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool FullWidth { get; set; }
		[MTParameter(Order = 2, FlagBitId=3, FlagType= FlagType.True)]
		public bool AllowScrolling { get; set; }
		[MTParameter(Order = 3, FlagBitId=1, FlagType= FlagType.Null)]
		public string Url { get; set; }
		[MTParameter(Order = 4, FlagBitId=2, FlagType= FlagType.Null)]
		public string Html { get; set; }
		[MTParameter(Order = 5, FlagBitId=4, FlagType= FlagType.Null)]
		public long? PosterPhotoId { get; set; }
		[MTParameter(Order = 6, FlagBitId=5, FlagType= FlagType.Null)]
		public int? W { get; set; }
		[MTParameter(Order = 7, FlagBitId=5, FlagType= FlagType.Null)]
		public int? H { get; set; }
		[MTParameter(Order = 8)]
		public MTSharp.Schema.TL.TLPageCaption Caption { get; set; }


    }
}
