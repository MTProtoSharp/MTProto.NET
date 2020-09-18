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
    [MTObject(0x5cc761bd)]
    public class TLEmojiKeywordsDifference : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5cc761bd;
            }
        }

		[MTParameter(Order = 0)]
		public string LangCode { get; set; }
		[MTParameter(Order = 1)]
		public int FromVersion { get; set; }
		[MTParameter(Order = 2)]
		public int Version { get; set; }
		[MTParameter(Order = 3)]
		public TLVector<TLAbsEmojiKeyword> Keywords { get; set; }


    }
}
