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
    [MTObject(0xb390dc08)]
    public class TLPageRelatedArticle : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb390dc08;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public string Url { get; set; }
		[MTParameter(Order = 2)]
		public long WebpageId { get; set; }
		[MTParameter(Order = 3, FlagBitId=0, FlagType= FlagType.Null)]
		public string Title { get; set; }
		[MTParameter(Order = 4, FlagBitId=1, FlagType= FlagType.Null)]
		public string Description { get; set; }
		[MTParameter(Order = 5, FlagBitId=2, FlagType= FlagType.Null)]
		public long? PhotoId { get; set; }
		[MTParameter(Order = 6, FlagBitId=3, FlagType= FlagType.Null)]
		public string Author { get; set; }
		[MTParameter(Order = 7, FlagBitId=4, FlagType= FlagType.Null)]
		public int? PublishedDate { get; set; }


    }
}
