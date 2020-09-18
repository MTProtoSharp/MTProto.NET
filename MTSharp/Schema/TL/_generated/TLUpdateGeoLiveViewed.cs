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
    [MTObject(0x871fb939)]
    public class TLUpdateGeoLiveViewed : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x871fb939;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public int MsgId { get; set; }


    }
}
