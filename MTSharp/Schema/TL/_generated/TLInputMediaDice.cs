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
    [MTObject(0xe66fbf7b)]
    public class TLInputMediaDice : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xe66fbf7b;
            }
        }

		[MTParameter(Order = 0)]
		public string Emoticon { get; set; }


    }
}
