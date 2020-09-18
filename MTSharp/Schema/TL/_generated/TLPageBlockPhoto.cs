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
    [MTObject(0x1759c560)]
    public class TLPageBlockPhoto : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x1759c560;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public long PhotoId { get; set; }
		[MTParameter(Order = 2)]
		public MTSharp.Schema.TL.TLPageCaption Caption { get; set; }
		[MTParameter(Order = 3, FlagBitId=0, FlagType= FlagType.Null)]
		public string Url { get; set; }
		[MTParameter(Order = 4, FlagBitId=0, FlagType= FlagType.Null)]
		public long? WebpageId { get; set; }


    }
}
