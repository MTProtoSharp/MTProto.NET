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
    [MTObject(0xce4e82fd)]
    public class TLInputMediaGeoLive : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xce4e82fd;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Stopped { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputGeoPoint GeoPoint { get; set; }
		[MTParameter(Order = 3, FlagBitId=1, FlagType= FlagType.Null)]
		public int? Period { get; set; }


    }
}
