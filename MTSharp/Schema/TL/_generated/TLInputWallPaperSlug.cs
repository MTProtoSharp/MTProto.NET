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
    [MTObject(0x72091c80)]
    public class TLInputWallPaperSlug : TLAbsInputWallPaper
    {
        public override uint Constructor
        {
            get
            {
                return 0x72091c80;
            }
        }

		[MTParameter(Order = 0)]
		public string Slug { get; set; }


    }
}
