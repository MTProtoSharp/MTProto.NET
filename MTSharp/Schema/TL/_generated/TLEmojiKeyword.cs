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
    [MTObject(0xd5b3b9f9)]
    public class TLEmojiKeyword : TLAbsEmojiKeyword
    {
        public override uint Constructor
        {
            get
            {
                return 0xd5b3b9f9;
            }
        }

		[MTParameter(Order = 0)]
		public string Keyword { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<string> Emoticons { get; set; }


    }
}
