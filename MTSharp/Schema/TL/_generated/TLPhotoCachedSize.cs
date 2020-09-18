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
    [MTObject(0xe9a734fa)]
    public class TLPhotoCachedSize : TLAbsPhotoSize
    {
        public override uint Constructor
        {
            get
            {
                return 0xe9a734fa;
            }
        }

		[MTParameter(Order = 0)]
		public string Type { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLFileLocationToBeDeprecated Location { get; set; }
		[MTParameter(Order = 2)]
		public int W { get; set; }
		[MTParameter(Order = 3)]
		public int H { get; set; }
		[MTParameter(Order = 4)]
		public byte[] Bytes { get; set; }


    }
}
