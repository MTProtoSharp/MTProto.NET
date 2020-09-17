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
    [MTObject(0xc2b7d08b)]
    public class TLSearchStickerSets : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc2b7d08b;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=0, FlagType= FlagType.True)]
		public bool ExcludeFeatured { get; set; }
		[MTParameter(Order = 2)]
		public string Q { get; set; }
		[MTParameter(Order = 3)]
		public int Hash { get; set; }


    }
}
