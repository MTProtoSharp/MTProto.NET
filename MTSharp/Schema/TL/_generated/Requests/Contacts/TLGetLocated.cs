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

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0xd348bc44)]
    public class TLGetLocated : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd348bc44;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=1, FlagType= FlagType.True)]
		public bool Background { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputGeoPoint GeoPoint { get; set; }
		[MTParameter(Order = 3, FlagBitId=0, FlagType= FlagType.Null)]
		public int? SelfExpires { get; set; }


    }
}
