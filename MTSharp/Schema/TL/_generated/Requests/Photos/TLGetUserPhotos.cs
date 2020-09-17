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

namespace MTSharp.Schema.TL.Requests.Photos
{
    [MTObject(0x91cd32a8)]
    public class TLGetUserPhotos : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x91cd32a8;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputUser UserId { get; set; }
		[MTParameter(Order = 1)]
		public int Offset { get; set; }
		[MTParameter(Order = 2)]
		public long MaxId { get; set; }
		[MTParameter(Order = 3)]
		public int Limit { get; set; }


    }
}
