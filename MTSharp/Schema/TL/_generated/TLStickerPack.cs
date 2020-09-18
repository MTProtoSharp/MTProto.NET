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
    [MTObject(0x12b299d4)]
    public class TLStickerPack : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x12b299d4;
            }
        }

		[MTParameter(Order = 0)]
		public string Emoticon { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<long> Documents { get; set; }


    }
}
