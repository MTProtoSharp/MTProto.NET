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
    [MTObject(0x40181ffe)]
    public class TLInputPhotoFileLocation : TLAbsInputFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0x40181ffe;
            }
        }

		[MTParameter(Order = 0)]
		public long Id { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }
		[MTParameter(Order = 2)]
		public byte[] FileReference { get; set; }
		[MTParameter(Order = 3)]
		public string ThumbSize { get; set; }


    }
}
