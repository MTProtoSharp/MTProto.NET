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
    [MTObject(0x236df622)]
    public class TLEmojiKeywordDeleted : TLAbsEmojiKeyword
    {
        public override uint Constructor
        {
            get
            {
                return 0x236df622;
            }
        }

		[MTParameter(Order = 0)]
		public string Keyword { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<string> Emoticons { get; set; }


    }
}
