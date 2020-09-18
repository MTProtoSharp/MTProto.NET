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
    [MTObject(0xf259a80b)]
    public class TLPageBlockEmbedPost : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xf259a80b;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }
		[MTParameter(Order = 1)]
		public long WebpageId { get; set; }
		[MTParameter(Order = 2)]
		public long AuthorPhotoId { get; set; }
		[MTParameter(Order = 3)]
		public string Author { get; set; }
		[MTParameter(Order = 4)]
		public int Date { get; set; }
		[MTParameter(Order = 5)]
		public TLVector<TLAbsPageBlock> Blocks { get; set; }
		[MTParameter(Order = 6)]
		public MTSharp.Schema.TL.TLPageCaption Caption { get; set; }


    }
}
