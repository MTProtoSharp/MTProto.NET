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
    [MTObject(0xe0b0bc2e)]
    public class TLPhotoStrippedSize : TLAbsPhotoSize
    {
        public override uint Constructor
        {
            get
            {
                return 0xe0b0bc2e;
            }
        }

		[MTParameter(Order = 0)]
		public string Type { get; set; }
		[MTParameter(Order = 1)]
		public byte[] Bytes { get; set; }


    }
}
